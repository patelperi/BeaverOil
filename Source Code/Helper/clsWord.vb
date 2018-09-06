Option Strict Off
Option Explicit On 
Imports System.Drawing
Imports System.Drawing.Printing
Imports Microsoft.Win32
Imports System.Threading
Imports System.IO

Public Class ClsWord


#Region "Modular variables"
    Private m_oWord As Word.Application
    Private m_oDoc As Word.Document
    Private m_ltrDocTyp As ClsWord.ltrDocType
    Private vret As Object
    '  Private m_pDevMode As clsDeviceMode
    Private m_hPrtDc As Integer 'printer device
    Private m_bDontSave As Boolean
    Private m_strtitle As String 'title of document
    Private m_strOfficeAddress As String
    Private m_strCallingProg As String
    Private m_strClientSetup As String
    Private m_strDataAccess As String
    Private m_strPyramid As String
    Private m_UserId As String
    Private m_strComments As String
    Private m_strExmCod As String
    Private m_strAddDte As String
    Private m_strConnect As String
    Private m_PrinterDefault As String
#End Region

#Region "Enumerated Types and Structures"
    Public Enum ltrDocType
        icLetter
        icInvoice
    End Enum
    Private Structure DOCINFO
        Dim cbSize As Integer
        Dim lpszDocName As String
        Dim lpszOutput As String
    End Structure
    Private Declare Function OpenPrinter Lib "winspool.drv" Alias "OpenPrinterA" (ByVal pPrinterName As String, ByRef phPrinter As Integer, ByVal pDefault As Integer) As Integer
    'release the pointer to the active printer:
    Private Declare Function ClosePrinter Lib "winspool.drv" (ByVal hPrinter As Integer) As Integer
    'in case reset printer fails:
    Private Declare Function GetLastError Lib "kernel32" () As Integer
    ' Fill the DEVMODE from the Printer
    Private Declare Function DocumentProperties Lib "winspool.drv" Alias "DocumentPropertiesA" (ByVal hwnd As Integer, ByVal hPrinter As Integer, ByVal pDeviceName As String, ByRef pDevModeOutput As Integer, ByRef pDevModeInput As Integer, ByVal fMode As Integer) As Integer
    '    Private Declare Function ResetDC Lib "gdi32" Alias "ResetDCA" (ByVal hdc As Integer, ByRef lpInitData As clsDeviceMode) As Integer
    Private Declare Function CreateDC Lib "gdi32" Alias "CreateDCA" (ByVal lpDriverName As String, ByVal lpDeviceName As String, ByVal lpOutput As Integer, ByVal lpInitData As Integer) As Integer
    Private Declare Function DeleteDC Lib "gdi32" (ByVal hdc As Integer) As Integer
    Private Declare Function TextOut Lib "gdi32" Alias "TextOutA" (ByVal hdc As Integer, ByVal X As Integer, ByVal Y As Integer, ByVal lpString As String, ByVal nCount As Integer) As Boolean
    Private Declare Function StartDoc Lib "gdi32" Alias "StartDocA" (ByVal hdc As Integer, ByRef lpdi As DOCINFO) As Integer
    Private Declare Function EndDoc Lib "gdi32" (ByVal hdc As Integer) As Integer
    ' Copy your changes back, then update DEVMODE
    '  'Private Declare Sub CopyMemory Lib "kernel32"  Alias "RtlMoveMemory"(ByRef hpvDest As Any, ByRef hpvSource As Any, ByVal cbCopy As Integer)
    '    Private Declare Sub CopyMemory Lib "kernel32" Alias "RtlMoveMemory" (ByRef hpvDest As clsDeviceMode, ByRef hpvSource As Byte, ByVal cbCopy As Integer)
    '   Private Declare Sub CopyMemory Lib "kernel32" Alias "RtlMoveMemory" (ByRef hpvDest As Byte, ByRef hpvSource As clsDeviceMode, ByVal cbCopy As Integer)
    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Short
#End Region

#Region "Properties"
    Public ReadOnly Property Table(ByVal intIndex As Short) As Word.Table
        Get
            If Not m_oDoc Is Nothing Then
                Table = m_oDoc.Tables.Item(intIndex)
            End If
        End Get
    End Property
    Public WriteOnly Property ConnectionStr() As String
        Set(ByVal Value As String)
            m_strConnect = Value
        End Set
    End Property
    Public ReadOnly Property open_docs() As Short
        Get
            If Not m_oWord Is Nothing Then
                'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1041"'
                If TypeName(m_oWord) = "ApplicationClass" Then
                    open_docs = m_oWord.Documents.Count
                Else
                    open_docs = 0
                End If
            Else
                open_docs = 0
            End If
        End Get
    End Property
    Public Property DontSave() As Boolean
        Get
            DontSave = m_bDontSave
        End Get
        Set(ByVal Value As Boolean)
            m_bDontSave = Value
        End Set
    End Property
#End Region

#Region "Public Functions"
    Public Sub ReplaceBookmarkField(ByRef strBkFld As String, ByRef strBkVal As String)
        Dim lndx As Short
        Dim objRange As Word.Range
        Try
            If Not m_oDoc Is Nothing Then
                m_oDoc.GoTo(Word.WdGoToItem.wdGoToBookmark, , , strBkFld)
                m_oDoc.Bookmarks.Item(strBkFld).Select()
                m_oDoc.Bookmarks.Item(strBkFld).Range.Text = strBkVal
            End If
        Catch objExc As Exception
            Err.Clear()
        Finally
        End Try
    End Sub
    Public Function OpenTemplate(ByRef strTemplateFileName As String, ByRef strSaveAsName As String, Optional ByVal strFileFormat As String = "Word") As Boolean
        Dim strTimestamp As String
        Dim strWorkName As String
        Dim strgetltrno As String
        Dim intPos As Short
        Dim strSQL As String
        Dim vrbn As Boolean
        Dim strFileN As String
        Dim strValue As String
        Dim intRet As Short
        Dim lngLen As Integer
        Dim strFileName As String
        Dim arstrHeader() As String
        Try
            m_ltrDocTyp = ltrDocType.icLetter
            If Not m_oDoc Is Nothing Then ' we need to close it down before creating a new one
                Try
                    CType(m_oDoc, Word._Document).Close()
                    m_oWord.Visible = False
                Catch objExec As Exception
                    m_oWord = Nothing
                Finally
                    m_oDoc = Nothing
                End Try
            End If
            CreateWordObject()
            'm_oDoc = WordApplication.Documents.Add(strTemplateFileName)
            m_oDoc = m_oWord.Documents.Add(strTemplateFileName)
            m_oDoc.CopyStylesFromTemplate((strTemplateFileName))
            '       Set the printer options
            'UPGRADE_WARNING: Couldn't resolve default property of object vret. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1037"'
            vret = PrinterSettings()
            'SaveAs .doc or .html
            If strFileFormat = "Word" Then
                'strSaveAsName = strSaveAsName & ".doc"
                m_oDoc.SaveAs(strSaveAsName)
            Else
                'strSaveAsName = strSaveAsName & ".html"
                m_oDoc.SaveAs(FileName:=strSaveAsName, FileFormat:=100)
            End If
            OpenTemplate = True
        Catch objExc As Exception
            MsgBox("Error:" & Err.Number & ":" & Err.Description & " " & Err.Source)
            MsgBox(objExc.Message)
        Finally
        End Try
    End Function
    Private Sub HTMLSave(ByVal strSaveAsName As String)
        Dim wrdConverter As Word.FileConverter
        strSaveAsName = strSaveAsName & ".html"
        wrdConverter.FormatName.Format("HTML", 0)
        wrdConverter.Application.ActiveDocument.SaveAs(strSaveAsName, wrdConverter.SaveFormat)
    End Sub
    Public Function PrinterSettings() As Boolean
        'retrieves the printer settings from the database and sets the word app object
        Dim bPreprinted As Boolean
        Dim strSettings As String
        Dim strSQL As String
        Dim vret As Object
        Dim strPrinters As String
        Dim sNtuser_id As String
        Dim TraySetting As Word.WdPaperTray
        Dim di As ClsWord.DOCINFO
        Dim hPrintDc As Integer
        Dim Ret As Integer
        Dim LastError As Integer
        'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup2068"'
        'Dim lPrinter As Printer
        Dim lPrinter As Printing.PrintDocument
        Dim counter As Short
        Dim strPreprBin1 As String
        Dim strPreprBin2 As String
        'get the login of the current user
        'if the instance of word is valid
        'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1041"'
        'If TypeName(m_oWord) = "Application" Then
        If Not m_oWord Is Nothing Then
            Try
                'if the document object exists
                If Not m_oDoc Is Nothing Then
                    m_PrinterDefault = m_oWord.Application.ActivePrinter
                End If
            Catch objExc As Exception
                If Err.Number = 5216 Then 'invalid printer
                    PrinterSettings = False
                End If
            Finally
            End Try
        End If

    End Function
    Public Sub ShowWordApplication()
        ' Will reset the application to pageview display mode on
        ' the 1st page and then show the application
        'If Not WordApplication() Is Nothing Then
        If Not m_oWord Is Nothing Then
            'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1041"'
            'If TypeName(WordApplication) = "Application" Then
            With m_oWord.ActiveDocument
                .Words.Item(1).Select()
                With .ActiveWindow
                    If .Panes.Count > 1 Then
                        .Panes.Item(2).Close()
                    End If
                    .View.TableGridlines = False
                    '.View.Type = Word.WdViewTypeOld.wdPageView
                End With
            End With
            'With WordApplication()
            With m_oWord
                .Visible = True
                '            .WindowState = intWindowState
                .ActiveWindow.Activate()
            End With
        End If
    End Sub
    Public Sub Save()
        Try
            If Not m_oDoc Is Nothing Then
                m_oDoc.Save()
            End If
        Catch objExc As Exception
        End Try
    End Sub
    Public Sub CloseWordObject()
        If Not m_oWord Is Nothing Then
            Try
                CType(m_oWord, Word._Application).Quit()

            Catch objExec As Exception
            Finally
                m_oWord = Nothing
            End Try
        End If
    End Sub
    Public Sub CloseDocument()
        If Not m_oDoc Is Nothing Then
            Try
                CType(m_oDoc, Word._Document).Close()
            Catch objExec As Exception
            Finally
                m_oDoc = Nothing
            End Try
        End If
        'UPGRADE_NOTE: Object m_oDoc may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1029"'
        'm_oDoc = Nothing
    End Sub
    Public Function WordIsClosed() As Boolean
        If Not m_oWord Is Nothing Then
            WordIsClosed = False
        Else
            WordIsClosed = True
        End If
    End Function
    Public Sub ClearBookmarkFields()
        Dim bkBookmark As Word.Bookmark
        If Not m_oDoc Is Nothing Then
            For Each bkBookmark In m_oDoc.Bookmarks
                ReplaceBookmarkField(bkBookmark.Name, "")
            Next bkBookmark
        End If
        Exit Sub
    End Sub
    Public Function DocumentIsClosed() As Boolean
        If m_oDoc Is Nothing Then
            DocumentIsClosed = True
        Else
            DocumentIsClosed = False
        End If
    End Function
    Public Sub HideWordApplication()
        m_oWord.Visible = False
    End Sub
    Public Function OpenDocument(ByRef strDocumentFileName As String) As Boolean
        Dim strTimestamp As String
        Dim strWorkName As String
        Dim strgetltrno As String
        Dim intPos As Short
        Dim strSQL As String
        Dim vrbn As Boolean
        Dim strFileN As String
        Dim strValue As String
        Dim intRet As Short
        Dim lngLen As Integer
        If Not m_oDoc Is Nothing Then ' we need to close it down before creating a new one
            m_oDoc = Nothing
        End If
        Try
            CreateWordObject()
            m_oDoc = m_oWord.Documents.Open(strDocumentFileName)
            'Set the printer options
            vret = PrinterSettings()
            Save()
            OpenDocument = True
        Catch objExc As Exception
            MsgBox("Error:" & Err.Number & ":" & Err.Description)
        End Try
    End Function
    Public Sub PrintLetter()
        If Not m_oDoc Is Nothing Then
            m_oDoc.PrintOut()
        End If
    End Sub
    '=====================================================================================
    'Synopsis: This function replaces the graphic specified by the index (zero based)
    '          with the graphic from the specified file. If the graphic is not in section
    '          number 1, then specify the section number. If the graphic is not in the
    '          header pass bHeader false.
    '          Function returns true if it completed successfully and false if 
    '          an error occured.
    '=====================================================================================
    Public Function ReplaceGraphic(ByVal strGraphicFile As String, _
                                   Optional ByVal intIndex As Integer = 0, _
                                   Optional ByVal intSection As Integer = 0, _
                                   Optional ByVal bHeader As Boolean = True) As Boolean
        Dim shape As Word.Shape
        Dim newShape As Word.Shape
        Dim intLeft As Single
        Dim intTop As Single
        Try
            If bHeader Then
                shape = m_oDoc.Sections.Item(intSection + 1).Headers.Item(1).Shapes.Item(intIndex + 1)
            Else
                shape = m_oDoc.Shapes.Item(intIndex + 1)
            End If
            intLeft = shape.Left
            intTop = shape.Top
            If bHeader Then
                With m_oDoc.Sections.Item(intSection + 1).Headers.Item(1).Shapes
                    newShape = .AddPicture(strGraphicFile, , , intLeft, intTop, shape.Width, shape.Height)
                End With
            Else
                newShape = m_oDoc.Shapes.AddPicture(strGraphicFile, , , intLeft, intTop, shape.Width, shape.Height, shape.Anchor)
            End If
            'newShape.Visible = True
            shape.Delete()
        Catch
            Return False
        End Try
        Return True
    End Function
    Public Function ReplaceGraphic(ByVal strGraphicFile As String, _
                                   ByVal intTop As Integer, _
                                   ByVal intLeft As Integer, _
                                 ByVal intIndex As Integer) As Boolean
        Dim shape As Word.Shape
        Dim newShape As Word.Shape
        Try
            shape = m_oDoc.Shapes.Item(intIndex + 1)
            newShape = m_oDoc.Shapes.AddPicture(strGraphicFile, , , intLeft, intTop, shape.Width, shape.Height, shape.Anchor)
            'newShape.Visible = True
            shape.Delete()
        Catch
            Return False
        End Try
        Return True
    End Function
    'Author   : K. Agun
    'Synopsis : Get the printer names into string array
    Private Function GetInstalledPrinters(ByRef PList() As String) As Integer
        Dim InstalledPrinters As String
        Dim PrinterList() As String
        Dim doc As New PrintDocument

        Dim i As Integer = 0
        For Each InstalledPrinters In doc.PrinterSettings.InstalledPrinters
            ReDim Preserve PrinterList(i + 1)
            PrinterList(i) = InstalledPrinters
            i = i + 1
        Next
        PList = PrinterList

        Return i
    End Function
    'Author   : K. Agun
    'Synopsis : Get the PDF printer name
    Private Function GetPDFPrinter() As String
        Dim i As Integer = 0
        Dim result As Integer
        Dim PrinterList() As String
        Dim PDF_Printer As String

        PDF_Printer = ""

        result = GetInstalledPrinters(PrinterList)

        For i = 0 To result
            result = PrinterList(i).IndexOf("Acrobat PDFWriter")
            If result <> -1 Then
                PDF_Printer = PrinterList(i)
                Exit For
            End If
        Next

        If PDF_Printer = "" Then
            For i = 0 To result
                result = PrinterList(i).IndexOf("Distiller Assistant")
                If result <> -1 Then
                    PDF_Printer = PrinterList(i)
                    Exit For
                End If
            Next
        End If

        Return PDF_Printer
    End Function
    '**********************************************************************
    'Author   : K. Agun
    'Synopsis : Print to file PDF
    'Example :
    '       Dim doc As CWord.ClsWord
    '       Dim strFilePath As String = "c:\test.doc"
    '       Dim strPDFFilePath As String = "c:\kagan.pdf"
    '
    '       doc = New CWord.ClsWord()
    '       doc.OpenDocument(strFilePath)
    '       doc.SaveAsPDF(strFilePath, strPDFFilePath)
    '       doc.CloseWordObject()
    '********************************************************************
    Public Function SaveAsPDF(ByVal WordDocumentPath As String, Optional ByRef PdfDocumentPath As String = "") As Boolean
        Dim i As Integer = 0
        Dim result As Boolean = True
        Dim PDF_Printer As String
        Dim strPDFwriter_key As String = "Software\Adobe\Acrobat PDFWriter"
        Dim strAdobeDistiller_key As String = "Software\Adobe\Acrobat Distiller"
        Dim RegAdobe As Microsoft.Win32.RegistryKey
        Dim m_FileInfo As System.IO.FileInfo

        m_FileInfo = New System.IO.FileInfo(WordDocumentPath)
        If Not m_FileInfo.Exists Then
            Return False
        End If

        If PdfDocumentPath = "" Then
            i = WordDocumentPath.LastIndexOf(".")
            If i <> -1 Then
                PdfDocumentPath = WordDocumentPath.Substring(0, i) & ".pdf"
            Else
                PdfDocumentPath = WordDocumentPath & ".pdf"
            End If
        End If

        PDF_Printer = GetPDFPrinter()

        If Not m_oDoc Is Nothing And PDF_Printer <> "" Then
            m_oWord.Application.ActivePrinter = PDF_Printer

            Try
                If PDF_Printer = "Acrobat PDFWriter" Then
                    RegAdobe = Registry.CurrentUser.OpenSubKey(strPDFwriter_key, True)
                    RegAdobe.SetValue("PDFFileName", PdfDocumentPath)

                    m_oDoc.PrintOut()
                    'check the file exist in the directory.

                    i = 0
                    While i < 60
                        m_FileInfo = New System.IO.FileInfo(PdfDocumentPath)
                        If m_FileInfo.Exists Then
                            result = True
                            'MsgBox("file created", MsgBoxStyle.Information)
                            Thread.Sleep(1000)
                            Exit While
                        Else
                            result = False
                            Thread.Sleep(1000)  'millisec : one thousandth of a second 
                        End If
                        'MsgBox(i.ToString(), MsgBoxStyle.Information)
                        i = i + 1
                    End While
                Else
                    'Not completed yet.
                    RegAdobe = Registry.CurrentUser.OpenSubKey(strAdobeDistiller_key, True)
                    result = False
                End If
            Catch e As Exception
                result = False
                'MsgBox(e.Message, MsgBoxStyle.Critical)
            End Try
            'MsgBox("closing word object", MsgBoxStyle.Information)
            'm_oWord.Documents.Close()

        End If

        Return result
    End Function
    '**********************************************************************
    'Author   : K. Agun
    'Synopsis : Clean create Word Application function
    '**********************************************************************
    Public Function NewCreateWordApplication() As Boolean
        Dim Result As Boolean = True

        Try
            If TypeName(m_oWord) <> "ApplicationClass" Then
                m_oWord = New Word.ApplicationClass
            Else
                Result = False
            End If
        Catch exp As Exception
            MsgBox("Error:" & Err.Number & ":" & Err.Description)
            Result = False
        End Try
        Return Result
    End Function
    'Synopsis : Clean close word application function
    Public Sub NewCloseWordApplication()
        Dim result As Boolean = True
        If Not m_oWord Is Nothing Then
            Try
                CType(m_oWord, Word._Application).Quit()
            Catch objExec As Exception

            Finally
                m_oWord = Nothing
            End Try
        End If

    End Sub
    'Synopsis : Clean open new document function
    Public Function NewOpenDocument(ByRef strDocumentFileName As String) As Boolean
        Dim result As Boolean = True
        Try
            'Check if word application is running
            If m_oWord Is Nothing Then
                result = NewCreateWordApplication()
            ElseIf m_oWord.IsObjectValid(m_oWord) = False Then
                result = NewCreateWordApplication()
            End If

            If result Then
                m_oDoc = m_oWord.Documents.Open(strDocumentFileName)
                m_oDoc.Activate()
            End If
        Catch objExc As Exception
            MsgBox("Error:" & Err.Number & ":" & Err.Description)
            result = False
        End Try
        Return result
    End Function
    'Synopsis : Clean close document function
    Public Sub NewCloseDocument()
        Dim result As Boolean = True
        If Not m_oDoc Is Nothing Then
            Try
                CType(m_oDoc, Word._Document).Close()
            Catch objExec As Exception
            Finally
                m_oDoc = Nothing
            End Try
        End If

    End Sub
    'Synopsis : get word status function
    Public Function NewWordPrintingStatus() As Integer
        Return m_oWord.BackgroundPrintingStatus
    End Function
#End Region

#Region "Private functions"
    Private Sub CreateWordObject()
        Dim breturn As Boolean
        'Test if object is already created before calling CreateObject:
        'If TypeName(m_oWord) <> "Application" Then
        'UPGRADE_NOTE: Object m_oWord may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1029"'
        'If Not m_oWord Is Nothing Then
        '    m_oWord = Nothing
        'End If
        If TypeName(m_oWord) <> "ApplicationClass" Then
            m_oWord = New Word.ApplicationClass
        End If
        'Check_Doc_Alive()
    End Sub
    Private Function WordApplication() As Word.ApplicationClass
        CreateWordObject()
        WordApplication = m_oWord
    End Function
    Private Sub TestWordObject()
        'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1041"'
        MsgBox(TypeName(m_oWord)) 'if displays "Application" then
        'Reference to Word is valid, else reference is invalid and
        'an error occurs on the following line:
        MsgBox(m_oWord.Name)
    End Sub
    Private Function Check_Doc_Alive() As Object
        If m_oWord Is Nothing Then
            CreateWordObject()
        End If
        'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1041"'
        If TypeName(m_oWord) <> "Application" Then
            CreateWordObject()
        End If
    End Function
    Private Sub DefaultPrinterSettings()
        Try
            If Not m_oWord Is Nothing Then
                m_oWord.Application.ActivePrinter = m_PrinterDefault
                m_oWord.Options.DefaultTrayID = 0 'default tray
            End If
        Catch objExc As Exception
        Finally
        End Try
    End Sub
#End Region
#Region "Create Word document from Dataset Perry Patel-09/17/2004"
    Public Function CreateWordDocFROMDataTable(ByVal dtWord As DataTable, ByVal FileName As String, ByVal strCustomerName As String, _
                                                ByVal strTestType As String, ByVal strDateTime As String) As Boolean

        '#Create all word application and document object.
        Dim oWord As Word.Application
        Dim oDoc As Word.Document
        Dim oTable As Word.Table
        If oWord Is Nothing Then
            oWord = New Word.Application
        End If
        Try
            '#add new document to word file and set heading of word documents.
            oDoc = oWord.Documents.Add
            Dim oRange As Word.Range = oDoc.Range(Start:=0, End:=0)
            With oRange
                .PageSetup.TopMargin = 100
                .PageSetup.LeftMargin = 100
                .InsertBefore("                                                                    " + Microsoft.VisualBasic.vbCrLf)
                .InsertAfter(Microsoft.VisualBasic.vbTab + Microsoft.VisualBasic.vbTab + Microsoft.VisualBasic.vbTab + strCustomerName.Trim + Microsoft.VisualBasic.vbCrLf)
                .InsertAfter(Microsoft.VisualBasic.vbTab + Microsoft.VisualBasic.vbTab + Microsoft.VisualBasic.vbTab + Microsoft.VisualBasic.vbTab + strTestType.Trim + Microsoft.VisualBasic.vbCrLf)
                .InsertAfter(Microsoft.VisualBasic.vbTab + Microsoft.VisualBasic.vbTab + Microsoft.VisualBasic.vbTab + strDateTime.Trim + Microsoft.VisualBasic.vbCrLf)
                .InsertAfter("                                                                    " + Microsoft.VisualBasic.vbCrLf)
                .Font.Name = "Verdana"
                .Font.Size = 12
                .Font.Bold = True
                .InsertParagraphAfter()
                .InsertParagraphAfter()
                .InsertParagraphAfter()
                .SetRange(.End, .End)
            End With
            '#End of creating heading of word documents.

            Dim i As Integer
            Dim Row As Integer = 25
            Dim Col As Integer
            If dtWord.Rows.Count > 25 Then
                Col = (dtWord.Rows.Count + 1) / 25
            Else
                Col = 1
            End If

            '#Creating table and alignment of new created table.
            oRange.Tables.Add(Range:=oDoc.Paragraphs.Item(7).Range, NumRows:=Row, NumColumns:=Col + 2)
            oDoc.Tables.Item(1).Rows.SetHeight(1.5, Word.WdRowHeightRule.wdRowHeightAuto)
            oDoc.PageSetup.LeftMargin = 50
            oDoc.PageSetup.RightMargin = 50
            oDoc.PageSetup.TopMargin = 25
            oDoc.PageSetup.BottomMargin = 25
            'oDoc.Tables.Item(1).Rows.RelativeHorizontalPosition = Word.WdRelativeHorizontalPosition.wdRelativeHorizontalPositionMargin
            With oDoc.Tables.Item(1)
                .Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
                .Range.Font.Size = 10
                .Range.Font.Name = "Verdana"
                .Columns.Item(1).Width = 125
                .Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
                .Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
                .Borders.OutsideColorIndex = Word.WdColorIndex.wdBlack
                .Borders.InsideColorIndex = Word.WdColorIndex.wdBlack
                .Cell(1, 1).Range.Text = "Employee ID"
                .Cell(1, 1).Range.Font.Bold = True
                .Cell(1, 1).Range.Font.Size = 10
                .Cell(1, 1).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter
                .Cell(1, 1).Merge(.Cell(1, 2))
                For i = 0 To dtWord.Rows.Count - 1
                    If i <= Row Then
                        If IsDBNull(dtWord.Rows(i).Item(0)) = False Then
                            .Cell(i + 2, 1).Range.Text = dtWord.Rows(i).Item(0).ToString
                            .Cell(i + 2, 1).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter
                        End If
                    Else
                        If IsDBNull(dtWord.Rows(i).Item(0)) = False Then
                            .Cell(i - 24, 2).Range.Text = dtWord.Rows(i).Item(0).ToString
                            .Cell(i - 24, 2).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter
                        End If
                    End If
                    If i = dtWord.Rows.Count - 1 Then Exit For
                Next
            End With
            oRange.SetRange(oRange.End, oRange.End)
            '#Finished copy of all data into word documents.

            '#Save and closed Word and doucment objects
            oDoc.SaveAs(FileName.ToString)
            oDoc.Saved = True
            oDoc.Close()

            '#Release all memory and close object
            oDoc = Nothing
            oWord.Quit()
            oWord = Nothing
        Catch ex As Exception
            oDoc.Saved = True
            oDoc.Close()
            oDoc = Nothing
            oWord.Quit()
            oWord = Nothing
            MsgBox(ex.Message)
        End Try

    End Function
#End Region

    Public Sub New()

    End Sub
End Class
