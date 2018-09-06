Imports System.IO
Imports System.Drawing.Printing
Imports System.Runtime.InteropServices
Public Class CreateTXTLog

    Public Sub New()

    End Sub
    Public Function CreateTXTLog(ByVal dsData As DataSet) As Boolean
        Dim strGeneratorName, strJobSite, strJobSiteAddress1, strJobSiteAddress2, strJobSiteCity, strJobSiteState, strJobSiteZip, StrJobSiteCSZ As String
        Dim strJobPO, strAttn, strApprovalNoManifestText, strManifestNo As String
        Dim strTransporterName, strDisposalFacilityName, strApprovalNo, strSpecialInstructions_T As String
        Dim IsManifest As Boolean
        Dim strTruckNo, strDriverName, strEmptyLine As String
        Dim ScheduleDate As Date
        Dim i As Integer = 0

        Dim pd As New PrintDialog
        ' Open the printer dialog box, and then allow the user to select a printer.
        'If pd.ShowDialog(Me) Then
        '    pd.PrinterSettings = New PrinterSettings
        'End If
        Dim strfilePath As String = "C:\testprint.txt"
        Dim fs As FileStream = New FileStream(strfilePath, FileMode.Create, FileAccess.Write)
        Dim objFile As StreamWriter = New StreamWriter(fs)
        If Not dsData Is Nothing AndAlso dsData.Tables.Count > 0 AndAlso dsData.Tables(0).Rows.Count > 0 Then
            For i = 0 To dsData.Tables(0).Rows.Count - 1
                '#Gen Name
                If IsDBNull(dsData.Tables(0).Rows(i).Item("ScheduleDate")) = False Then ScheduleDate = dsData.Tables(0).Rows(i).Item("ScheduleDate").ToString Else ScheduleDate = Now.ToShortDateString
                If IsDBNull(dsData.Tables(0).Rows(i).Item("GeneratorName")) = False Then strGeneratorName = dsData.Tables(0).Rows(i).Item("GeneratorName").ToString Else strGeneratorName = " "
                If IsDBNull(dsData.Tables(0).Rows(i).Item("JobSite")) = False Then strJobSite = dsData.Tables(0).Rows(i).Item("JobSite").ToString Else strJobSite = " "
                If IsDBNull(dsData.Tables(0).Rows(i).Item("JobSiteAddress1")) = False Then strJobSiteAddress1 = dsData.Tables(0).Rows(i).Item("JobSiteAddress1").ToString Else strJobSiteAddress1 = " "
                If IsDBNull(dsData.Tables(0).Rows(i).Item("JobSiteAddress2")) = False Then strJobSiteAddress2 = dsData.Tables(0).Rows(i).Item("JobSiteAddress2").ToString Else strJobSiteAddress2 = " "
                If IsDBNull(dsData.Tables(0).Rows(i).Item("JobSiteCity")) = False Then strJobSiteCity = dsData.Tables(0).Rows(i).Item("JobSiteCity").ToString Else strJobSiteCity = " "
                If IsDBNull(dsData.Tables(0).Rows(i).Item("JobSiteState")) = False Then strJobSiteState = dsData.Tables(0).Rows(i).Item("JobSiteState").ToString Else strJobSiteState = " "
                If IsDBNull(dsData.Tables(0).Rows(i).Item("JobSiteZip")) = False Then strJobSiteZip = dsData.Tables(0).Rows(i).Item("JobSiteZip").ToString Else strJobSiteZip = " "
                If IsDBNull(dsData.Tables(0).Rows(i).Item("JobPO")) = False Then strJobPO = dsData.Tables(0).Rows(i).Item("JobPO").ToString Else strJobPO = " "
                If IsDBNull(dsData.Tables(0).Rows(i).Item("Attn")) = False Then strAttn = dsData.Tables(0).Rows(i).Item("Attn").ToString Else strAttn = " "
                If IsDBNull(dsData.Tables(0).Rows(i).Item("TruckNo")) = False Then strTruckNo = dsData.Tables(0).Rows(i).Item("TruckNo").ToString Else strTruckNo = " "
                If IsDBNull(dsData.Tables(0).Rows(i).Item("DriverName")) = False Then strDriverName = dsData.Tables(0).Rows(i).Item("DriverName").ToString Else strDriverName = " "
                If IsDBNull(dsData.Tables(0).Rows(i).Item("TransporterName")) = False Then strTransporterName = dsData.Tables(0).Rows(i).Item("TransporterName").ToString Else strTransporterName = " "
                If IsDBNull(dsData.Tables(0).Rows(i).Item("DisposalFacilityName")) = False Then strDisposalFacilityName = dsData.Tables(0).Rows(i).Item("DisposalFacilityName").ToString Else strDisposalFacilityName = " "
                If IsDBNull(dsData.Tables(0).Rows(i).Item("SpecialInstructions_T")) = False Then strSpecialInstructions_T = dsData.Tables(0).Rows(i).Item("SpecialInstructions_T").ToString Else strSpecialInstructions_T = " "
                If IsDBNull(dsData.Tables(0).Rows(i).Item("ApprovalNo")) = False Then strApprovalNo = dsData.Tables(0).Rows(i).Item("ApprovalNo").ToString.Trim Else strApprovalNo = " "
                If IsDBNull(dsData.Tables(0).Rows(i).Item("ApprovalNoManifestText")) = False Then strApprovalNoManifestText = dsData.Tables(0).Rows(i).Item("ApprovalNoManifestText").ToString Else strApprovalNoManifestText = " "
                If IsDBNull(dsData.Tables(0).Rows(i).Item("ManifestNo")) = False Then strManifestNo = dsData.Tables(0).Rows(i).Item("ManifestNo").ToString Else strManifestNo = " "
                If IsDBNull(dsData.Tables(0).Rows(i).Item("IsManifest")) = False Then IsManifest = Convert.ToBoolean(dsData.Tables(0).Rows(i).Item("IsManifest")) Else IsManifest = False
                If strJobSiteAddress2.Trim <> "" Then
                    strJobSiteAddress1 = strJobSiteAddress1 + "," + strJobSiteAddress2
                End If
                If strJobSiteCity.Trim <> "" Then
                    StrJobSiteCSZ = strJobSiteCity
                End If
                If strJobSiteState.Trim <> "" Then
                    StrJobSiteCSZ = StrJobSiteCSZ + "," + strJobSiteState
                End If
                If strJobSiteZip.Trim <> "" Then
                    StrJobSiteCSZ = StrJobSiteCSZ + " " + strJobSiteZip
                End If

                '#Printing Module...
                '                RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, s)
                '#Keep first 6 lines blank
                objFile.WriteLine("")
                objFile.WriteLine("")
                objFile.WriteLine("")
                objFile.WriteLine("")
                objFile.WriteLine("")
                objFile.WriteLine("")
                objFile.WriteLine("          " & ScheduleDate.ToShortDateString.ToString & "            " & strGeneratorName.ToString.Trim)
                objFile.WriteLine("")
                objFile.WriteLine(Chr(27) & "               " & strJobSite.ToString.Trim & "")
                objFile.WriteLine("")
                objFile.WriteLine("               " & strJobSiteAddress1.ToString.Trim & "")
                objFile.WriteLine("")
                objFile.WriteLine("               " & StrJobSiteCSZ.ToString.Trim & "")
                objFile.WriteLine("")
                objFile.WriteLine("      " & strJobPO.ToString.Trim & "        " & strAttn.ToString.Trim)
                objFile.WriteLine(Chr(27) & "          " & strTransporterName.ToString.Trim & "")
                objFile.WriteLine("          " & strTruckNo.ToString.Trim & "               " & strDriverName.ToString.Trim)
                objFile.WriteLine("                    " & strDisposalFacilityName.ToString.Trim)

            Next
            objFile.Close()
        End If
    End Function
    Public Function deleteall()
        Dim strUserName As String = SystemInformation.UserName
        If Directory.Exists("C:\ReleaseLock\Logfile\" & strUserName) Then
            Dim str As String = "C:\ReleaseLock\Logfile\" & strUserName & "\"
            Dim d As DirectoryInfo = New DirectoryInfo("C:\ReleaseLock\Logfile\" & strUserName & "\")
            d.Delete(True)
            Directory.CreateDirectory("C:\ReleaseLock\Logfile\" & strUserName)
        End If
    End Function
    Public Class RawPrinterHelper
        ' Structure and API declarions:
        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
        Structure DOCINFOW
            <MarshalAs(UnmanagedType.LPWStr)> Public pDocName As String
            <MarshalAs(UnmanagedType.LPWStr)> Public pOutputFile As String
            <MarshalAs(UnmanagedType.LPWStr)> Public pDataType As String
        End Structure

        <DllImport("winspool.Drv", EntryPoint:="OpenPrinterW", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function OpenPrinter(ByVal src As String, ByRef hPrinter As IntPtr, ByVal pd As Long) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="ClosePrinter", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function ClosePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="StartDocPrinterW", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function StartDocPrinter(ByVal hPrinter As IntPtr, ByVal level As Int32, ByRef pDI As DOCINFOW) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="EndDocPrinter", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function EndDocPrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="StartPagePrinter", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function StartPagePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="EndPagePrinter", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function EndPagePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="WritePrinter", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function WritePrinter(ByVal hPrinter As IntPtr, ByVal pBytes As IntPtr, ByVal dwCount As Int32, ByRef dwWritten As Int32) As Boolean
        End Function

        ' SendBytesToPrinter()
        ' When the function is given a printer name and an unmanaged array of
        ' bytes, the function sends those bytes to the print queue.
        ' Returns True on success or False on failure.
        Public Shared Function SendBytesToPrinter(ByVal szPrinterName As String, ByVal pBytes As IntPtr, ByVal dwCount As Int32) As Boolean
            Dim hPrinter As IntPtr      ' The printer handle.
            Dim dwError As Int32        ' Last error - in case there was trouble.
            Dim di As DOCINFOW          ' Describes your document (name, port, data type).
            Dim dwWritten As Int32      ' The number of bytes written by WritePrinter().
            Dim bSuccess As Boolean     ' Your success code.

            ' Set up the DOCINFO structure.
            With di
                .pDocName = "My Visual Basic .NET RAW Document"
                .pDataType = "RAW"
            End With
            ' Assume failure unless you specifically succeed.
            bSuccess = False
            If OpenPrinter(szPrinterName, hPrinter, 0) Then
                If StartDocPrinter(hPrinter, 1, di) Then
                    If StartPagePrinter(hPrinter) Then
                        ' Write your printer-specific bytes to the printer.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, dwWritten)
                        EndPagePrinter(hPrinter)
                    End If
                    EndDocPrinter(hPrinter)
                End If
                ClosePrinter(hPrinter)
            End If
            ' If you did not succeed, GetLastError may give more information
            ' about why not.
            If bSuccess = False Then
                dwError = Marshal.GetLastWin32Error()
            End If
            Return bSuccess
        End Function ' SendBytesToPrinter()

        ' SendFileToPrinter()
        ' When the function is given a file name and a printer name,
        ' the function reads the contents of the file and sends the
        ' contents to the printer.
        ' Presumes that the file contains printer-ready data.
        ' Shows how to use the SendBytesToPrinter function.
        ' Returns True on success or False on failure.
        Public Shared Function SendFileToPrinter(ByVal szPrinterName As String, ByVal szFileName As String) As Boolean
            ' Open the file.
            Dim fs As New FileStream(szFileName, FileMode.Open)
            ' Create a BinaryReader on the file.
            Dim br As New BinaryReader(fs)
            ' Dim an array of bytes large enough to hold the file's contents.
            Dim bytes(fs.Length) As Byte
            Dim bSuccess As Boolean
            ' Your unmanaged pointer
            Dim pUnmanagedBytes As IntPtr

            ' Read the contents of the file into the array.
            bytes = br.ReadBytes(fs.Length)
            ' Allocate some unmanaged memory for those bytes.
            pUnmanagedBytes = Marshal.AllocCoTaskMem(fs.Length)
            ' Copy the managed byte array into the unmanaged array.
            Marshal.Copy(bytes, 0, pUnmanagedBytes, fs.Length)
            ' Send the unmanaged bytes to the printer.
            bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, fs.Length)
            ' Free the unmanaged memory that you allocated earlier.
            Marshal.FreeCoTaskMem(pUnmanagedBytes)
            Return bSuccess
        End Function ' SendFileToPrinter()

        ' When the function is given a string and a printer name,
        ' the function sends the string to the printer as raw bytes.
        Public Shared Function SendStringToPrinter(ByVal szPrinterName As String, ByVal szString As String)
            Dim pBytes As IntPtr
            Dim dwCount As Int32
            ' How many characters are in the string?
            dwCount = szString.Length()
            ' Assume that the printer is expecting ANSI text, and then convert
            ' the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString)
            ' Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount)
            Marshal.FreeCoTaskMem(pBytes)
        End Function
    End Class


End Class
