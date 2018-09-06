Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class frmMultiStops
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbReceivingSite As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbHauler As System.Windows.Forms.ComboBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents howMany As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmbReceivingSite = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbHauler = New System.Windows.Forms.ComboBox
        Me.btnPrint = New System.Windows.Forms.Button
        Me.howMany = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 16)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Receiving Site:"
        '
        'cmbReceivingSite
        '
        Me.cmbReceivingSite.Location = New System.Drawing.Point(104, 72)
        Me.cmbReceivingSite.Name = "cmbReceivingSite"
        Me.cmbReceivingSite.Size = New System.Drawing.Size(376, 21)
        Me.cmbReceivingSite.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 16)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Transporter :"
        '
        'cmbHauler
        '
        Me.cmbHauler.Location = New System.Drawing.Point(104, 40)
        Me.cmbHauler.Name = "cmbHauler"
        Me.cmbHauler.Size = New System.Drawing.Size(376, 21)
        Me.cmbHauler.TabIndex = 1
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(232, 112)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 24)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "Print"
        '
        'howMany
        '
        Me.howMany.BackColor = System.Drawing.Color.White
        Me.howMany.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.howMany.Location = New System.Drawing.Point(144, 120)
        Me.howMany.Name = "howMany"
        Me.howMany.Size = New System.Drawing.Size(72, 14)
        Me.howMany.TabIndex = 3
        Me.howMany.Text = ""
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(136, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 1)
        Me.Label1.TabIndex = 44
        '
        'frmMultiStops
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(496, 165)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.howMany)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmbReceivingSite)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbHauler)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMultiStops"
        Me.Text = "Print Multi-Stop Tickets"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try

            If Me.cmbHauler.SelectedIndex <= 0 Then
                MsgBox("Invalid Hauler. Please select a Hauler.", MsgBoxStyle.Information, "Error Ocurred")
                Me.cmbHauler.Focus()
                Exit Sub
            End If
            If Me.cmbReceivingSite.SelectedIndex <= 0 Then
                MsgBox("Invalid Receiving Site. Please select a Receiving Site.", MsgBoxStyle.Information, "Error Ocurred")
                Me.cmbReceivingSite.Focus()
                Exit Sub
            End If
            Dim iVal As String = Me.howMany.Text, iNum As Integer
            If iVal <> "" And IsNumeric(iVal) = False Then
                MsgBox("Invalid # of copies entered.", MsgBoxStyle.Information, "Error Ocurred")
                Me.howMany.Focus()
                Exit Sub
            End If
            If iVal = "" Then
                iNum = 1
            Else
                iNum = CInt(iVal)
            End If
            Dim objRpt As New rpt_Manual_MultiStop
            Dim fField As FormulaFieldDefinition
            fField = objRpt.DataDefinition.FormulaFields.Item("TName")
            fField.Text = """" & Me.cmbHauler.SelectedText & """"
            fField = objRpt.DataDefinition.FormulaFields.Item("DName")
            fField.Text = """" & Me.cmbReceivingSite.SelectedText & """"
            Dim frmR1 As New frmReport
            frmR1.Text = "Job Tickets(s) - Multistops"
            frmR1.WindowState = FormWindowState.Maximized
            frmR1.CrystalReportViewer1.ReportSource = objRpt
            frmR1.CrystalReportViewer1.RefreshReport()
            Dim i As Integer = 0
            For i = 1 To iNum
                frmR1.CrystalReportViewer1.PrintReport()
            Next
            'frmR1.ShowDialog()
            frmR1 = Nothing

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
        Finally
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Function LoadHaulersReceivers()
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet
        Dim ds1 As DataSet
        Dim strSQL As String
        Try

            strSQL = "SELECT tblTransporters.TransporterID, (TransporterName & ' : ' & TCity) AS SelectTransporter FROM tblTransporters WHERE (((tblTransporters.Active)=True)) ORDER BY tblTransporters.DefaultSelected, ([TransporterName] & ' : ' & [TCity])"
            ds = DBHelper.GetDataSet(strSQL, "tblTransporters")
            Dim emptyRow As DataRow
            emptyRow = ds.Tables(0).NewRow()
            emptyRow.Item(0) = "0"
            emptyRow.Item(1) = "Select a Hauler"
            ds.Tables(0).Rows.InsertAt(emptyRow, 0)
            Me.cmbHauler.DataSource = ds
            Me.cmbHauler.DisplayMember = "tblTransporters.SelectTransporter"
            Me.cmbHauler.ValueMember = "tblTransporters.TransporterID"

            strSQL = "SELECT DisposalFacilityID, (DisposalFacilityName & ' : ' & FCity) as SelectDisposal FROM tblDisposalFacilities WHERE Active = TRUE ORDER BY DefaultSelected, (DisposalFacilityName & ' : ' & FCity) "
            ds1 = DBHelper.GetDataSet(strSQL, "tblDisposalFacilities")
            Dim emptyRow1 As DataRow
            emptyRow1 = ds1.Tables(0).NewRow()
            emptyRow1.Item(0) = "0"
            emptyRow1.Item(1) = "Select a Receiving Site"
            ds1.Tables(0).Rows.InsertAt(emptyRow1, 0)
            Me.cmbReceivingSite.DataSource = ds1
            Me.cmbReceivingSite.DisplayMember = "tblDisposalFacilities.SelectDisposal"
            Me.cmbReceivingSite.ValueMember = "tblDisposalFacilities.DisposalFacilityID"

        Catch ex As SystemException

            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally

            ds = Nothing
            ds1 = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try
    End Function

    Private Sub frmMultiStops_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.LoadHaulersReceivers()

    End Sub

End Class
