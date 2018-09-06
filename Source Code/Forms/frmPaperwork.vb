Imports BeaverOil.DataGridButton
Imports CrystalDecisions.Windows
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared.PaperSize
Imports System.IO
Imports System.Drawing.Printing
Imports System.Runtime.InteropServices
Public Class frmPaperwork

    Inherits System.Windows.Forms.Form
    'Private m_oLetter As New ClsWord
    Public Const strBeaverManifest = "BEAVER MANIFEST"
    Public newForm As frmJobTicket
    Dim rCount As Integer = 0
    Dim printJTs As ArrayList = New ArrayList, printJTs_M As ArrayList = New ArrayList, printNHs As ArrayList = New ArrayList, printHs As ArrayList = New ArrayList, printBOLs As ArrayList = New ArrayList, printFormCs As ArrayList = New ArrayList, printP2Ms As ArrayList = New ArrayList
    Public IsPageLoaded As Boolean = False
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
    Friend WithEvents dtJobSchedule As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblScheduled As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblJobTickets As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnPrintJT As System.Windows.Forms.Button
    Friend WithEvents btnPrintNH As System.Windows.Forms.Button
    Friend WithEvents btnPrintH As System.Windows.Forms.Button
    Friend WithEvents btnPrintBOL As System.Windows.Forms.Button
    Friend WithEvents lblCJT As System.Windows.Forms.Label
    Friend WithEvents lblCNH As System.Windows.Forms.Label
    Friend WithEvents lblCH As System.Windows.Forms.Label
    Friend WithEvents lblCBOL As System.Windows.Forms.Label
    Friend WithEvents DsJobBoard1 As BeaverOil.DSJobBoard
    Friend WithEvents DAJobTickets As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents UpdateInvoiceDetails As System.Data.OleDb.OleDbCommand
    Friend WithEvents dgPaperwork As System.Windows.Forms.DataGrid
    Friend WithEvents SelectJobTickets As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsJobTickets_P1 As BeaverOil.DSJobTickets_P
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DACustomerSurvey As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DsCustomerSurveys1 As BeaverOil.DSCustomerSurveys
    Friend WithEvents DABOLs As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsboLs1 As BeaverOil.DSBOLs
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DANonHazardous As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbCommand5 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsNonHazardous1 As BeaverOil.DSNonHazardous
    Friend WithEvents DAGenerators As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbCommand7 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsListGenerators1 As BeaverOil.DSListGenerators
    Friend WithEvents DAProducts As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbCommand9 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbCommand10 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsListProducts1 As BeaverOil.DSListProducts
    Friend WithEvents DAHazardous As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents SelectHazardous As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsHazardous1 As BeaverOil.DSHazardous
    Friend WithEvents lblCP2M As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnPrintPlant2M As System.Windows.Forms.Button
    Friend WithEvents DAP2Manifests As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents SelectP2Manifest As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsP2Manifests1 As BeaverOil.DSP2Manifests
    Friend WithEvents btnPrintHAttachments As System.Windows.Forms.Button
    Friend WithEvents lblFormC As System.Windows.Forms.Label
    Friend WithEvents btnPrintFormC As System.Windows.Forms.Button
    Friend WithEvents DANewJobSearch As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents SelectNewJobSearch As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsNewJobSearch1 As BeaverOil.DSNewJobSearch
    Friend WithEvents btnPrintLandBanForm As System.Windows.Forms.Button
    Friend WithEvents DsrptReceiptControl1 As BeaverOil.dsrptReceiptControl
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsAttachmentC1 As BeaverOil.dsAttachmentC
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblMulti As System.Windows.Forms.Label
    Friend WithEvents btnMulti As System.Windows.Forms.Button
    Friend WithEvents btnNewNon As System.Windows.Forms.Button
    Friend WithEvents btnNewHaz As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtJobSchedule = New System.Windows.Forms.DateTimePicker
        Me.lblScheduled = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblJobTickets = New System.Windows.Forms.Label
        Me.btnPrintJT = New System.Windows.Forms.Button
        Me.btnPrintNH = New System.Windows.Forms.Button
        Me.btnPrintH = New System.Windows.Forms.Button
        Me.btnPrintBOL = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblCJT = New System.Windows.Forms.Label
        Me.lblCNH = New System.Windows.Forms.Label
        Me.lblCH = New System.Windows.Forms.Label
        Me.lblCBOL = New System.Windows.Forms.Label
        Me.dgPaperwork = New System.Windows.Forms.DataGrid
        Me.DsJobBoard1 = New BeaverOil.DSJobBoard
        Me.DAJobTickets = New System.Data.OleDb.OleDbDataAdapter
        Me.SelectJobTickets = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.UpdateInvoiceDetails = New System.Data.OleDb.OleDbCommand
        Me.DsJobTickets_P1 = New BeaverOil.DSJobTickets_P
        Me.DACustomerSurvey = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand
        Me.DsCustomerSurveys1 = New BeaverOil.DSCustomerSurveys
        Me.DABOLs = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbCommand3 = New System.Data.OleDb.OleDbCommand
        Me.DsboLs1 = New BeaverOil.DSBOLs
        Me.lblFormC = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnPrintFormC = New System.Windows.Forms.Button
        Me.DANonHazardous = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbCommand5 = New System.Data.OleDb.OleDbCommand
        Me.DsNonHazardous1 = New BeaverOil.DSNonHazardous
        Me.DAGenerators = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbCommand7 = New System.Data.OleDb.OleDbCommand
        Me.DsListGenerators1 = New BeaverOil.DSListGenerators
        Me.DAProducts = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbCommand9 = New System.Data.OleDb.OleDbCommand
        Me.OleDbCommand10 = New System.Data.OleDb.OleDbCommand
        Me.DsListProducts1 = New BeaverOil.DSListProducts
        Me.DAHazardous = New System.Data.OleDb.OleDbDataAdapter
        Me.SelectHazardous = New System.Data.OleDb.OleDbCommand
        Me.DsHazardous1 = New BeaverOil.DSHazardous
        Me.lblCP2M = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnPrintPlant2M = New System.Windows.Forms.Button
        Me.DAP2Manifests = New System.Data.OleDb.OleDbDataAdapter
        Me.SelectP2Manifest = New System.Data.OleDb.OleDbCommand
        Me.DsP2Manifests1 = New BeaverOil.DSP2Manifests
        Me.btnPrintHAttachments = New System.Windows.Forms.Button
        Me.DANewJobSearch = New System.Data.OleDb.OleDbDataAdapter
        Me.SelectNewJobSearch = New System.Data.OleDb.OleDbCommand
        Me.DsNewJobSearch1 = New BeaverOil.DSNewJobSearch
        Me.btnPrintLandBanForm = New System.Windows.Forms.Button
        Me.DsrptReceiptControl1 = New BeaverOil.dsrptReceiptControl
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.DsAttachmentC1 = New BeaverOil.dsAttachmentC
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblMulti = New System.Windows.Forms.Label
        Me.btnMulti = New System.Windows.Forms.Button
        Me.btnNewNon = New System.Windows.Forms.Button
        Me.btnNewHaz = New System.Windows.Forms.Button
        CType(Me.dgPaperwork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsJobBoard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsJobTickets_P1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCustomerSurveys1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsboLs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNonHazardous1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsListGenerators1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsListProducts1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsHazardous1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsP2Manifests1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNewJobSearch1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsrptReceiptControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAttachmentC1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtJobSchedule
        '
        Me.dtJobSchedule.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText
        Me.dtJobSchedule.CustomFormat = "mm/dd/yyyy"
        Me.dtJobSchedule.Location = New System.Drawing.Point(248, 8)
        Me.dtJobSchedule.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.dtJobSchedule.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtJobSchedule.Name = "dtJobSchedule"
        Me.dtJobSchedule.Size = New System.Drawing.Size(232, 21)
        Me.dtJobSchedule.TabIndex = 1
        Me.dtJobSchedule.Value = New Date(2013, 6, 9, 0, 0, 0, 0)
        '
        'lblScheduled
        '
        Me.lblScheduled.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScheduled.Location = New System.Drawing.Point(112, 12)
        Me.lblScheduled.Name = "lblScheduled"
        Me.lblScheduled.Size = New System.Drawing.Size(136, 16)
        Me.lblScheduled.TabIndex = 17
        Me.lblScheduled.Text = "Job Scheduled Date:"
        Me.lblScheduled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(8, 328)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(648, 1)
        Me.Label1.TabIndex = 18
        '
        'lblJobTickets
        '
        Me.lblJobTickets.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobTickets.Location = New System.Drawing.Point(8, 352)
        Me.lblJobTickets.Name = "lblJobTickets"
        Me.lblJobTickets.Size = New System.Drawing.Size(80, 16)
        Me.lblJobTickets.TabIndex = 19
        Me.lblJobTickets.Text = "Job Tickets:"
        Me.lblJobTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrintJT
        '
        Me.btnPrintJT.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPrintJT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintJT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintJT.Location = New System.Drawing.Point(8, 416)
        Me.btnPrintJT.Name = "btnPrintJT"
        Me.btnPrintJT.Size = New System.Drawing.Size(72, 24)
        Me.btnPrintJT.TabIndex = 3
        Me.btnPrintJT.Text = "Print"
        '
        'btnPrintNH
        '
        Me.btnPrintNH.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPrintNH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintNH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintNH.Location = New System.Drawing.Point(288, 464)
        Me.btnPrintNH.Name = "btnPrintNH"
        Me.btnPrintNH.Size = New System.Drawing.Size(96, 32)
        Me.btnPrintNH.TabIndex = 4
        Me.btnPrintNH.Text = "Old Manifest Non Haz"
        Me.btnPrintNH.Visible = False
        '
        'btnPrintH
        '
        Me.btnPrintH.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPrintH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintH.Location = New System.Drawing.Point(216, 464)
        Me.btnPrintH.Name = "btnPrintH"
        Me.btnPrintH.Size = New System.Drawing.Size(96, 32)
        Me.btnPrintH.TabIndex = 5
        Me.btnPrintH.Text = "Old Manifest Haz"
        Me.btnPrintH.Visible = False
        '
        'btnPrintBOL
        '
        Me.btnPrintBOL.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPrintBOL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintBOL.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintBOL.Location = New System.Drawing.Point(456, 416)
        Me.btnPrintBOL.Name = "btnPrintBOL"
        Me.btnPrintBOL.Size = New System.Drawing.Size(80, 24)
        Me.btnPrintBOL.TabIndex = 7
        Me.btnPrintBOL.Text = "Print"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(192, 344)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 32)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Non-Hazardous Manifests:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(448, 352)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Bill of Lading:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(320, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 32)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Hazardous Manifests:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCJT
        '
        Me.lblCJT.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCJT.Location = New System.Drawing.Point(24, 384)
        Me.lblCJT.Name = "lblCJT"
        Me.lblCJT.Size = New System.Drawing.Size(48, 16)
        Me.lblCJT.TabIndex = 28
        Me.lblCJT.Text = "0"
        Me.lblCJT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCNH
        '
        Me.lblCNH.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCNH.Location = New System.Drawing.Point(216, 384)
        Me.lblCNH.Name = "lblCNH"
        Me.lblCNH.Size = New System.Drawing.Size(48, 16)
        Me.lblCNH.TabIndex = 29
        Me.lblCNH.Text = "0"
        Me.lblCNH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCH
        '
        Me.lblCH.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCH.Location = New System.Drawing.Point(344, 384)
        Me.lblCH.Name = "lblCH"
        Me.lblCH.Size = New System.Drawing.Size(48, 16)
        Me.lblCH.TabIndex = 30
        Me.lblCH.Text = "0"
        Me.lblCH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCBOL
        '
        Me.lblCBOL.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCBOL.Location = New System.Drawing.Point(472, 384)
        Me.lblCBOL.Name = "lblCBOL"
        Me.lblCBOL.Size = New System.Drawing.Size(48, 16)
        Me.lblCBOL.TabIndex = 31
        Me.lblCBOL.Text = "0"
        Me.lblCBOL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgPaperwork
        '
        Me.dgPaperwork.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgPaperwork.DataMember = ""
        Me.dgPaperwork.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgPaperwork.Location = New System.Drawing.Point(8, 40)
        Me.dgPaperwork.Name = "dgPaperwork"
        Me.dgPaperwork.ReadOnly = True
        Me.dgPaperwork.RowHeadersVisible = False
        Me.dgPaperwork.Size = New System.Drawing.Size(648, 280)
        Me.dgPaperwork.TabIndex = 2
        '
        'DsJobBoard1
        '
        Me.DsJobBoard1.DataSetName = "DSJobBoard"
        Me.DsJobBoard1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DAJobTickets
        '
        Me.DAJobTickets.SelectCommand = Me.SelectJobTickets
        Me.DAJobTickets.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblJobTickets", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("JobTicketID", "JobTicketID"), New System.Data.Common.DataColumnMapping("JobTicketNo", "JobTicketNo"), New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("ScheduleDate", "ScheduleDate"), New System.Data.Common.DataColumnMapping("NonHazardous", "NonHazardous"), New System.Data.Common.DataColumnMapping("BillOfLading", "BillOfLading"), New System.Data.Common.DataColumnMapping("Hazardous", "Hazardous"), New System.Data.Common.DataColumnMapping("JobTicket", "JobTicket"), New System.Data.Common.DataColumnMapping("TransporterID", "TransporterID"), New System.Data.Common.DataColumnMapping("DisposalFacilityID", "DisposalFacilityID"), New System.Data.Common.DataColumnMapping("JobTicketDate", "JobTicketDate"), New System.Data.Common.DataColumnMapping("DriverName", "DriverName"), New System.Data.Common.DataColumnMapping("JobPO", "JobPO"), New System.Data.Common.DataColumnMapping("Attn", "Attn"), New System.Data.Common.DataColumnMapping("TruckNo", "TruckNo"), New System.Data.Common.DataColumnMapping("DriverRemarks", "DriverRemarks"), New System.Data.Common.DataColumnMapping("ManifestNo", "ManifestNo"), New System.Data.Common.DataColumnMapping("RefNo", "RefNo"), New System.Data.Common.DataColumnMapping("C_Arrived", "C_Arrived"), New System.Data.Common.DataColumnMapping("C_Arrived_M", "C_Arrived_M"), New System.Data.Common.DataColumnMapping("C_Departed", "C_Departed"), New System.Data.Common.DataColumnMapping("C_Departed_M", "C_Departed_M"), New System.Data.Common.DataColumnMapping("P_Start", "P_Start"), New System.Data.Common.DataColumnMapping("P_Finish", "P_Finish"), New System.Data.Common.DataColumnMapping("U_Arrived", "U_Arrived"), New System.Data.Common.DataColumnMapping("U_Arrived_M", "U_Arrived_M"), New System.Data.Common.DataColumnMapping("U_Departed", "U_Departed"), New System.Data.Common.DataColumnMapping("U_Departed_M", "U_Departed_M"), New System.Data.Common.DataColumnMapping("JobTicketSubmitted", "JobTicketSubmitted"), New System.Data.Common.DataColumnMapping("InvoiceCreated", "InvoiceCreated"), New System.Data.Common.DataColumnMapping("Closed", "Closed"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("GeneratorName", "GeneratorName"), New System.Data.Common.DataColumnMapping("JobSite", "JobSite"), New System.Data.Common.DataColumnMapping("JobSiteAddress1", "JobSiteAddress1"), New System.Data.Common.DataColumnMapping("JobSiteAddress2", "JobSiteAddress2"), New System.Data.Common.DataColumnMapping("JobSiteCity", "JobSiteCity"), New System.Data.Common.DataColumnMapping("JobSiteState", "JobSiteState"), New System.Data.Common.DataColumnMapping("JobSiteZip", "JobSiteZip"), New System.Data.Common.DataColumnMapping("TransporterName", "TransporterName"), New System.Data.Common.DataColumnMapping("DisposalFacilityName", "DisposalFacilityName")})})
        Me.DAJobTickets.UpdateCommand = Me.UpdateInvoiceDetails
        '
        'SelectJobTickets
        '
        Me.SelectJobTickets.CommandText = "SELECT tblProducts.ProductName, tblGenerators.GeneratorName, tblGenerators.JobSit" & _
        "e, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteAddress2, tblGenerators.J" & _
        "obSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, tblTransporter" & _
        "s.TransporterName, tblDisposalFacilities.DisposalFacilityName, tblProducts.HWNum" & _
        "ber, tblJobTickets.IsManifest AS IsManifest, tblJobTickets.ManifestNo, tblJobTic" & _
        "kets.Attn, tblJobTickets.DriverName, tblJobTickets.DriverRemarks, tblJobTickets." & _
        "JobPO, tblJobTickets.JobTicketNo, tblJobTickets.ScheduleDate, tblJobTickets.Spec" & _
        "ialInstructions_T, tblJobTickets.TicketNo, tblJobTickets.TruckNo, tblProducts.Ap" & _
        "provalNo AS ApprovalNoManifestText FROM ((((tblGenerators INNER JOIN tblProducts" & _
        " ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTicket" & _
        "s ON tblProducts.ProductID = tblJobTickets.ProductID) INNER JOIN tblDisposalFaci" & _
        "lities ON tblJobTickets.DisposalFacilityID = tblDisposalFacilities.DisposalFacil" & _
        "ityID) INNER JOIN tblTransporters ON tblJobTickets.TransporterID = tblTransporte" & _
        "rs.TransporterID)"
        Me.SelectJobTickets.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Data Source=""\\beaverone\Data\Job Tracking Database\JobTrackingSys" & _
        "tem.mdb"";Mode=Share Deny None;Jet OLEDB:Engine Type=5;Provider=""Microsoft.Jet.OL" & _
        "EDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=Fa" & _
        "lse;Extended Properties=;Jet OLEDB:Compact Without Replica Repair=False;Jet OLED" & _
        "B:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't " & _
        "Copy Locale on Compact=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1"
        '
        'UpdateInvoiceDetails
        '
        Me.UpdateInvoiceDetails.CommandText = "UPDATE tblJobTickets_Details SET ItemIAmount = ? WHERE (JobDetailID = ?)"
        Me.UpdateInvoiceDetails.Connection = Me.OleDbConnection1
        Me.UpdateInvoiceDetails.Parameters.Add(New System.Data.OleDb.OleDbParameter("ItemIAmount", System.Data.OleDb.OleDbType.Double, 0, "ItemIAmount"))
        Me.UpdateInvoiceDetails.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_JobDetailID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "JobDetailID", System.Data.DataRowVersion.Original, Nothing))
        '
        'DsJobTickets_P1
        '
        Me.DsJobTickets_P1.DataSetName = "DSJobTickets_P"
        Me.DsJobTickets_P1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DACustomerSurvey
        '
        Me.DACustomerSurvey.SelectCommand = Me.OleDbCommand1
        Me.DACustomerSurvey.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblJobTickets", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GeneratorName", "GeneratorName"), New System.Data.Common.DataColumnMapping("JobSite", "JobSite"), New System.Data.Common.DataColumnMapping("JobSiteAddress1", "JobSiteAddress1"), New System.Data.Common.DataColumnMapping("JobSiteCity", "JobSiteCity"), New System.Data.Common.DataColumnMapping("JobSiteState", "JobSiteState"), New System.Data.Common.DataColumnMapping("JobSiteZip", "JobSiteZip"), New System.Data.Common.DataColumnMapping("ContactName", "ContactName"), New System.Data.Common.DataColumnMapping("ContactPhone", "ContactPhone"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("BrokerName", "BrokerName"), New System.Data.Common.DataColumnMapping("BrokerContact", "BrokerContact"), New System.Data.Common.DataColumnMapping("BrokerPhone", "BrokerPhone"), New System.Data.Common.DataColumnMapping("BillingName", "BillingName"), New System.Data.Common.DataColumnMapping("BillingAddress1", "BillingAddress1"), New System.Data.Common.DataColumnMapping("BillingAddress2", "BillingAddress2"), New System.Data.Common.DataColumnMapping("BillingCity", "BillingCity"), New System.Data.Common.DataColumnMapping("BillingState", "BillingState"), New System.Data.Common.DataColumnMapping("BillingZip", "BillingZip"), New System.Data.Common.DataColumnMapping("ProcessGenerating", "ProcessGenerating"), New System.Data.Common.DataColumnMapping("JobTicketID", "JobTicketID")})})
        '
        'OleDbCommand1
        '
        Me.OleDbCommand1.CommandText = "SELECT tblGenerators.GeneratorName, tblGenerators.JobSite, tblGenerators.JobSiteA" & _
        "ddress1, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.Jo" & _
        "bSiteZip, tblGenerators.ContactName, tblGenerators.ContactPhone, tblProducts.Pro" & _
        "ductName, tblGenerators.BrokerName, tblGenerators.BrokerContact, tblGenerators.B" & _
        "rokerPhone, tblGenerators.BillingName, tblGenerators.BillingAddress1, tblGenerat" & _
        "ors.BillingAddress2, tblGenerators.BillingCity, tblGenerators.BillingState, tblG" & _
        "enerators.BillingZip, tblProducts.ProductDescription, tblJobTickets.JobTicketID " & _
        "FROM ((tblProducts INNER JOIN tblGenerators ON tblProducts.GeneratorID = tblGene" & _
        "rators.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTi" & _
        "ckets.ProductID)"
        Me.OleDbCommand1.Connection = Me.OleDbConnection1
        '
        'DsCustomerSurveys1
        '
        Me.DsCustomerSurveys1.DataSetName = "DSCustomerSurveys"
        Me.DsCustomerSurveys1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DABOLs
        '
        Me.DABOLs.SelectCommand = Me.OleDbCommand3
        Me.DABOLs.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblJobTickets", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GeneratorName", "GeneratorName"), New System.Data.Common.DataColumnMapping("JobSite", "JobSite"), New System.Data.Common.DataColumnMapping("JobSiteAddress1", "JobSiteAddress1"), New System.Data.Common.DataColumnMapping("JobSiteCity", "JobSiteCity"), New System.Data.Common.DataColumnMapping("JobSiteState", "JobSiteState"), New System.Data.Common.DataColumnMapping("JobSiteZip", "JobSiteZip"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("TransporterName", "TransporterName"), New System.Data.Common.DataColumnMapping("TPhone", "TPhone"), New System.Data.Common.DataColumnMapping("DisposalFacilityName", "DisposalFacilityName"), New System.Data.Common.DataColumnMapping("FAddress1", "FAddress1"), New System.Data.Common.DataColumnMapping("FCity", "FCity"), New System.Data.Common.DataColumnMapping("FState", "FState"), New System.Data.Common.DataColumnMapping("FZip", "FZip"), New System.Data.Common.DataColumnMapping("FPhone", "FPhone"), New System.Data.Common.DataColumnMapping("JobTicketID", "JobTicketID")})})
        '
        'OleDbCommand3
        '
        Me.OleDbCommand3.CommandText = "SELECT tblGenerators.GeneratorName, tblGenerators.JobSite, tblGenerators.JobSiteA" & _
        "ddress1, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.Jo" & _
        "bSiteZip, tblProducts.ProductName, tblTransporters.TransporterName, tblTransport" & _
        "ers.TPhone, tblDisposalFacilities.DisposalFacilityName, tblDisposalFacilities.FA" & _
        "ddress1, tblDisposalFacilities.FCity, tblDisposalFacilities.FState, tblDisposalF" & _
        "acilities.FZip, tblDisposalFacilities.FPhone, tblJobTickets.JobTicketID FROM ((t" & _
        "blProducts INNER JOIN tblGenerators ON tblProducts.GeneratorID = tblGenerators.G" & _
        "eneratorID) INNER JOIN ((tblJobTickets LEFT OUTER JOIN tblDisposalFacilities ON " & _
        "tblJobTickets.DisposalFacilityID = tblDisposalFacilities.DisposalFacilityID) LEF" & _
        "T OUTER JOIN tblTransporters ON tblJobTickets.TransporterID = tblTransporters.Tr" & _
        "ansporterID) ON tblProducts.ProductID = tblJobTickets.ProductID)"
        Me.OleDbCommand3.Connection = Me.OleDbConnection1
        '
        'DsboLs1
        '
        Me.DsboLs1.DataSetName = "DSBOLs"
        Me.DsboLs1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'lblFormC
        '
        Me.lblFormC.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormC.Location = New System.Drawing.Point(592, 384)
        Me.lblFormC.Name = "lblFormC"
        Me.lblFormC.Size = New System.Drawing.Size(48, 16)
        Me.lblFormC.TabIndex = 35
        Me.lblFormC.Text = "0"
        Me.lblFormC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(576, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 24)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Form C Attachement:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrintFormC
        '
        Me.btnPrintFormC.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPrintFormC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintFormC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintFormC.Location = New System.Drawing.Point(576, 416)
        Me.btnPrintFormC.Name = "btnPrintFormC"
        Me.btnPrintFormC.Size = New System.Drawing.Size(80, 24)
        Me.btnPrintFormC.TabIndex = 8
        Me.btnPrintFormC.Text = "Print"
        '
        'DANonHazardous
        '
        Me.DANonHazardous.SelectCommand = Me.OleDbCommand5
        Me.DANonHazardous.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblJobTickets", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("JobSite", "JobSite"), New System.Data.Common.DataColumnMapping("JobSiteAddress1", "JobSiteAddress1"), New System.Data.Common.DataColumnMapping("JobSiteCity", "JobSiteCity"), New System.Data.Common.DataColumnMapping("JobSiteState", "JobSiteState"), New System.Data.Common.DataColumnMapping("JobSiteZip", "JobSiteZip"), New System.Data.Common.DataColumnMapping("ContactPhone", "ContactPhone"), New System.Data.Common.DataColumnMapping("TransporterName", "TransporterName"), New System.Data.Common.DataColumnMapping("T_USEPAID", "T_USEPAID"), New System.Data.Common.DataColumnMapping("TPhone", "TPhone"), New System.Data.Common.DataColumnMapping("DisposalFacilityName", "DisposalFacilityName"), New System.Data.Common.DataColumnMapping("FAddress1", "FAddress1"), New System.Data.Common.DataColumnMapping("FCity", "FCity"), New System.Data.Common.DataColumnMapping("FState", "FState"), New System.Data.Common.DataColumnMapping("FZip", "FZip"), New System.Data.Common.DataColumnMapping("D_USEPAID", "D_USEPAID"), New System.Data.Common.DataColumnMapping("FPhone", "FPhone"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("JobTicketID", "JobTicketID"), New System.Data.Common.DataColumnMapping("G_USEPAID", "G_USEPAID"), New System.Data.Common.DataColumnMapping("G_ILNumber", "G_ILNumber"), New System.Data.Common.DataColumnMapping("Manifest_Description", "Manifest_Description"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("UOM", "UOM"), New System.Data.Common.DataColumnMapping("ApprovalNo", "ApprovalNo"), New System.Data.Common.DataColumnMapping("MailingAddress1", "MailingAddress1"), New System.Data.Common.DataColumnMapping("MailingAddress2", "MailingAddress2"), New System.Data.Common.DataColumnMapping("MailingCity", "MailingCity"), New System.Data.Common.DataColumnMapping("MailingName", "MailingName"), New System.Data.Common.DataColumnMapping("MailingState", "MailingState"), New System.Data.Common.DataColumnMapping("MailingZip", "MailingZip"), New System.Data.Common.DataColumnMapping("ProductDescription", "ProductDescription"), New System.Data.Common.DataColumnMapping("ProductDescription1", "ProductDescription1")})})
        '
        'OleDbCommand5
        '
        Me.OleDbCommand5.CommandText = "SELECT tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSit" & _
        "eCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, tblGenerators.Conta" & _
        "ctPhone, tblTransporters.TransporterName, tblTransporters.T_USEPAID, tblTranspor" & _
        "ters.TPhone, tblDisposalFacilities.DisposalFacilityName, tblDisposalFacilities.F" & _
        "Address1, tblDisposalFacilities.FCity, tblDisposalFacilities.FState, tblDisposal" & _
        "Facilities.FZip, tblDisposalFacilities.D_USEPAID, tblDisposalFacilities.FPhone, " & _
        "tblProducts.ProductName, tblJobTickets.JobTicketID, tblGenerators.G_USEPAID, tbl" & _
        "Generators.G_ILNumber, tblProducts.Manifest_Description, tblJobTickets_Details.Q" & _
        "uantity, tblJobTickets_Details.UOM, tblProducts.ApprovalNo, tblGenerators.Mailin" & _
        "gAddress1, tblGenerators.MailingAddress2, tblGenerators.MailingCity, tblGenerato" & _
        "rs.MailingName, tblGenerators.MailingState, tblGenerators.MailingZip, tblProduct" & _
        "s.ProductDescription, tblProducts.ProductDescription1, tblTransporters.T_ILNumbe" & _
        "r, tblDisposalFacilities.D_ILNumber, tblProducts.Type AS Type FROM (((((tblProdu" & _
        "cts INNER JOIN tblGenerators ON tblProducts.GeneratorID = tblGenerators.Generato" & _
        "rID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID" & _
        ") LEFT OUTER JOIN tblDisposalFacilities ON tblJobTickets.DisposalFacilityID = tb" & _
        "lDisposalFacilities.DisposalFacilityID) LEFT OUTER JOIN tblTransporters ON tblJo" & _
        "bTickets.TransporterID = tblTransporters.TransporterID) LEFT OUTER JOIN tblJobTi" & _
        "ckets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) " & _
        "WHERE (tblJobTickets.IsCancelled = False)"
        Me.OleDbCommand5.Connection = Me.OleDbConnection1
        '
        'DsNonHazardous1
        '
        Me.DsNonHazardous1.DataSetName = "DSNonHazardous"
        Me.DsNonHazardous1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DAGenerators
        '
        Me.DAGenerators.SelectCommand = Me.OleDbCommand7
        Me.DAGenerators.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblGenerators", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GeneratorID", "GeneratorID"), New System.Data.Common.DataColumnMapping("GeneratorName", "GeneratorName"), New System.Data.Common.DataColumnMapping("JobSite", "JobSite"), New System.Data.Common.DataColumnMapping("JobSiteAddress1", "JobSiteAddress1"), New System.Data.Common.DataColumnMapping("JobSiteAddress2", "JobSiteAddress2"), New System.Data.Common.DataColumnMapping("JobSiteCity", "JobSiteCity"), New System.Data.Common.DataColumnMapping("JobSiteState", "JobSiteState"), New System.Data.Common.DataColumnMapping("JobSiteZip", "JobSiteZip"), New System.Data.Common.DataColumnMapping("GNo", "GNo"), New System.Data.Common.DataColumnMapping("ContactName", "ContactName"), New System.Data.Common.DataColumnMapping("ContactPhone", "ContactPhone"), New System.Data.Common.DataColumnMapping("ContacPhoneExt", "ContacPhoneExt"), New System.Data.Common.DataColumnMapping("BrokerName", "BrokerName"), New System.Data.Common.DataColumnMapping("BrokerContact", "BrokerContact"), New System.Data.Common.DataColumnMapping("BrokerPhone", "BrokerPhone"), New System.Data.Common.DataColumnMapping("BillingName", "BillingName"), New System.Data.Common.DataColumnMapping("BillingAddress1", "BillingAddress1"), New System.Data.Common.DataColumnMapping("BillingAddress2", "BillingAddress2"), New System.Data.Common.DataColumnMapping("BillingCity", "BillingCity"), New System.Data.Common.DataColumnMapping("BillingState", "BillingState"), New System.Data.Common.DataColumnMapping("BillingZip", "BillingZip"), New System.Data.Common.DataColumnMapping("G_USEPAID", "G_USEPAID"), New System.Data.Common.DataColumnMapping("Active", "Active"), New System.Data.Common.DataColumnMapping("G_ILNumber", "G_ILNumber")})})
        '
        'OleDbCommand7
        '
        Me.OleDbCommand7.CommandText = "SELECT * FROM tblGenerators ORDER BY GeneratorName"
        Me.OleDbCommand7.Connection = Me.OleDbConnection1
        '
        'DsListGenerators1
        '
        Me.DsListGenerators1.DataSetName = "DSListGenerators"
        Me.DsListGenerators1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DAProducts
        '
        Me.DAProducts.SelectCommand = Me.OleDbCommand9
        Me.DAProducts.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblProducts", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("GeneratorID", "GeneratorID"), New System.Data.Common.DataColumnMapping("GenProdNo", "GenProdNo"), New System.Data.Common.DataColumnMapping("Type", "Type"), New System.Data.Common.DataColumnMapping("Paperwork_Required", "Paperwork_Required"), New System.Data.Common.DataColumnMapping("ProductDescription", "ProductDescription"), New System.Data.Common.DataColumnMapping("NonHazardous", "NonHazardous"), New System.Data.Common.DataColumnMapping("BillOfLading", "BillOfLading"), New System.Data.Common.DataColumnMapping("Hazardous", "Hazardous"), New System.Data.Common.DataColumnMapping("JobTicket", "JobTicket"), New System.Data.Common.DataColumnMapping("Plant2Manifest", "Plant2Manifest"), New System.Data.Common.DataColumnMapping("AnalyticalDate", "AnalyticalDate"), New System.Data.Common.DataColumnMapping("LabRecertDate", "LabRecertDate"), New System.Data.Common.DataColumnMapping("TypeOfProduct", "TypeOfProduct"), New System.Data.Common.DataColumnMapping("GenNo", "GenNo"), New System.Data.Common.DataColumnMapping("FedNo", "FedNo"), New System.Data.Common.DataColumnMapping("ApprovalNo", "ApprovalNo"), New System.Data.Common.DataColumnMapping("TemplateFilePath", "TemplateFilePath"), New System.Data.Common.DataColumnMapping("FileName", "FileName"), New System.Data.Common.DataColumnMapping("Active", "Active"), New System.Data.Common.DataColumnMapping("SpecialInstructions", "SpecialInstructions"), New System.Data.Common.DataColumnMapping("HWNumber", "HWNumber"), New System.Data.Common.DataColumnMapping("PermitNo", "PermitNo"), New System.Data.Common.DataColumnMapping("S_O", "S_O"), New System.Data.Common.DataColumnMapping("GeneratorName", "GeneratorName"), New System.Data.Common.DataColumnMapping("JobSite", "JobSite")})})
        Me.DAProducts.UpdateCommand = Me.OleDbCommand10
        '
        'OleDbCommand9
        '
        Me.OleDbCommand9.CommandText = "SELECT tblProducts.*, tblGenerators.GeneratorName, tblGenerators.JobSite FROM (tb" & _
        "lProducts INNER JOIN tblGenerators ON tblProducts.GeneratorID = tblGenerators.Ge" & _
        "neratorID) ORDER BY tblGenerators.GeneratorName, tblProducts.ProductName"
        Me.OleDbCommand9.Connection = Me.OleDbConnection1
        '
        'OleDbCommand10
        '
        Me.OleDbCommand10.CommandText = "UPDATE tblJobTickets_Details SET ItemIAmount = ? WHERE (JobDetailID = ?)"
        Me.OleDbCommand10.Connection = Me.OleDbConnection1
        Me.OleDbCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("ItemIAmount", System.Data.OleDb.OleDbType.Double, 0, "ItemIAmount"))
        Me.OleDbCommand10.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_JobDetailID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "JobDetailID", System.Data.DataRowVersion.Original, Nothing))
        '
        'DsListProducts1
        '
        Me.DsListProducts1.DataSetName = "DSListProducts"
        Me.DsListProducts1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DAHazardous
        '
        Me.DAHazardous.SelectCommand = Me.SelectHazardous
        Me.DAHazardous.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblJobTickets", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("JobSite", "JobSite"), New System.Data.Common.DataColumnMapping("JobSiteAddress1", "JobSiteAddress1"), New System.Data.Common.DataColumnMapping("JobSiteCity", "JobSiteCity"), New System.Data.Common.DataColumnMapping("JobSiteState", "JobSiteState"), New System.Data.Common.DataColumnMapping("JobSiteZip", "JobSiteZip"), New System.Data.Common.DataColumnMapping("ContactPhone", "ContactPhone"), New System.Data.Common.DataColumnMapping("TransporterName", "TransporterName"), New System.Data.Common.DataColumnMapping("T_USEPAID", "T_USEPAID"), New System.Data.Common.DataColumnMapping("TPhone", "TPhone"), New System.Data.Common.DataColumnMapping("DisposalFacilityName", "DisposalFacilityName"), New System.Data.Common.DataColumnMapping("FAddress1", "FAddress1"), New System.Data.Common.DataColumnMapping("FCity", "FCity"), New System.Data.Common.DataColumnMapping("FState", "FState"), New System.Data.Common.DataColumnMapping("FZip", "FZip"), New System.Data.Common.DataColumnMapping("D_USEPAID", "D_USEPAID"), New System.Data.Common.DataColumnMapping("FPhone", "FPhone"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("JobTicketID", "JobTicketID"), New System.Data.Common.DataColumnMapping("G_USEPAID", "G_USEPAID"), New System.Data.Common.DataColumnMapping("G_ILNumber", "G_ILNumber"), New System.Data.Common.DataColumnMapping("Manifest_Description", "Manifest_Description"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("UOM", "UOM"), New System.Data.Common.DataColumnMapping("ApprovalNo", "ApprovalNo"), New System.Data.Common.DataColumnMapping("MailingAddress1", "MailingAddress1"), New System.Data.Common.DataColumnMapping("MailingAddress2", "MailingAddress2"), New System.Data.Common.DataColumnMapping("MailingCity", "MailingCity"), New System.Data.Common.DataColumnMapping("MailingName", "MailingName"), New System.Data.Common.DataColumnMapping("MailingState", "MailingState"), New System.Data.Common.DataColumnMapping("MailingZip", "MailingZip"), New System.Data.Common.DataColumnMapping("ProductDescription", "ProductDescription"), New System.Data.Common.DataColumnMapping("ProductDescription1", "ProductDescription1")})})
        '
        'SelectHazardous
        '
        Me.SelectHazardous.CommandText = "SELECT tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSit" & _
        "eCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, tblGenerators.Conta" & _
        "ctPhone, tblTransporters.TransporterName, tblTransporters.T_USEPAID, tblTranspor" & _
        "ters.TPhone, tblDisposalFacilities.DisposalFacilityName, tblDisposalFacilities.F" & _
        "Address1, tblDisposalFacilities.FCity, tblDisposalFacilities.FState, tblDisposal" & _
        "Facilities.FZip, tblDisposalFacilities.D_USEPAID, tblDisposalFacilities.FPhone, " & _
        "tblProducts.ProductName, tblJobTickets.JobTicketID, tblGenerators.G_USEPAID, tbl" & _
        "Generators.G_ILNumber, tblProducts.Manifest_Description, tblJobTickets_Details.Q" & _
        "uantity, tblJobTickets_Details.UOM, tblProducts.ApprovalNo, tblGenerators.Mailin" & _
        "gAddress1, tblGenerators.MailingAddress2, tblGenerators.MailingCity, tblGenerato" & _
        "rs.MailingName, tblGenerators.MailingState, tblGenerators.MailingZip, tblProduct" & _
        "s.ProductDescription, tblProducts.ProductDescription1, tblDisposalFacilities.D_I" & _
        "LNumber, tblTransporters.T_ILNumber, tblProducts.HWNumber FROM (((((tblProducts " & _
        "INNER JOIN tblGenerators ON tblProducts.GeneratorID = tblGenerators.GeneratorID)" & _
        " INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) LE" & _
        "FT OUTER JOIN tblDisposalFacilities ON tblJobTickets.DisposalFacilityID = tblDis" & _
        "posalFacilities.DisposalFacilityID) LEFT OUTER JOIN tblTransporters ON tblJobTic" & _
        "kets.TransporterID = tblTransporters.TransporterID) LEFT OUTER JOIN tblJobTicket" & _
        "s_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) WHER" & _
        "E (tblJobTickets.IsCancelled = False)"
        Me.SelectHazardous.Connection = Me.OleDbConnection1
        '
        'DsHazardous1
        '
        Me.DsHazardous1.DataSetName = "DSHazardous"
        Me.DsHazardous1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'lblCP2M
        '
        Me.lblCP2M.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCP2M.Location = New System.Drawing.Point(104, 456)
        Me.lblCP2M.Name = "lblCP2M"
        Me.lblCP2M.Size = New System.Drawing.Size(48, 16)
        Me.lblCP2M.TabIndex = 38
        Me.lblCP2M.Text = "0"
        Me.lblCP2M.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCP2M.Visible = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 456)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 24)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Plant 2 Manifest:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label7.Visible = False
        '
        'btnPrintPlant2M
        '
        Me.btnPrintPlant2M.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPrintPlant2M.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintPlant2M.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintPlant2M.Location = New System.Drawing.Point(72, 472)
        Me.btnPrintPlant2M.Name = "btnPrintPlant2M"
        Me.btnPrintPlant2M.Size = New System.Drawing.Size(80, 24)
        Me.btnPrintPlant2M.TabIndex = 6
        Me.btnPrintPlant2M.Text = "Print"
        Me.btnPrintPlant2M.Visible = False
        '
        'DAP2Manifests
        '
        Me.DAP2Manifests.SelectCommand = Me.SelectP2Manifest
        Me.DAP2Manifests.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblProducts", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("JobSite", "JobSite"), New System.Data.Common.DataColumnMapping("JobSiteAddress1", "JobSiteAddress1"), New System.Data.Common.DataColumnMapping("JobSiteCity", "JobSiteCity"), New System.Data.Common.DataColumnMapping("JobSiteState", "JobSiteState"), New System.Data.Common.DataColumnMapping("JobSiteZip", "JobSiteZip"), New System.Data.Common.DataColumnMapping("ContactPhone", "ContactPhone"), New System.Data.Common.DataColumnMapping("TransporterName", "TransporterName"), New System.Data.Common.DataColumnMapping("T_USEPAID", "T_USEPAID"), New System.Data.Common.DataColumnMapping("TPhone", "TPhone"), New System.Data.Common.DataColumnMapping("DisposalFacilityName", "DisposalFacilityName"), New System.Data.Common.DataColumnMapping("FAddress1", "FAddress1"), New System.Data.Common.DataColumnMapping("FCity", "FCity"), New System.Data.Common.DataColumnMapping("FState", "FState"), New System.Data.Common.DataColumnMapping("FZip", "FZip"), New System.Data.Common.DataColumnMapping("D_USEPAID", "D_USEPAID"), New System.Data.Common.DataColumnMapping("FPhone", "FPhone"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("JobTicketID", "JobTicketID"), New System.Data.Common.DataColumnMapping("G_USEPAID", "G_USEPAID"), New System.Data.Common.DataColumnMapping("G_ILNumber", "G_ILNumber"), New System.Data.Common.DataColumnMapping("Manifest_Description", "Manifest_Description"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("UOM", "UOM"), New System.Data.Common.DataColumnMapping("ApprovalNo", "ApprovalNo"), New System.Data.Common.DataColumnMapping("MailingAddress1", "MailingAddress1"), New System.Data.Common.DataColumnMapping("MailingAddress2", "MailingAddress2"), New System.Data.Common.DataColumnMapping("MailingCity", "MailingCity"), New System.Data.Common.DataColumnMapping("MailingName", "MailingName"), New System.Data.Common.DataColumnMapping("MailingState", "MailingState"), New System.Data.Common.DataColumnMapping("MailingZip", "MailingZip"), New System.Data.Common.DataColumnMapping("ProductDescription", "ProductDescription"), New System.Data.Common.DataColumnMapping("ProductDescription1", "ProductDescription1")})})
        '
        'SelectP2Manifest
        '
        Me.SelectP2Manifest.CommandText = "SELECT tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSit" & _
        "eCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, tblGenerators.Conta" & _
        "ctPhone, tblTransporters.TransporterName, tblTransporters.T_USEPAID, tblTranspor" & _
        "ters.TPhone, tblDisposalFacilities.DisposalFacilityName, tblDisposalFacilities.F" & _
        "Address1, tblDisposalFacilities.FCity, tblDisposalFacilities.FState, tblDisposal" & _
        "Facilities.FZip, tblDisposalFacilities.D_USEPAID, tblDisposalFacilities.FPhone, " & _
        "tblProducts.ProductName, tblJobTickets.JobTicketID, tblGenerators.G_USEPAID, tbl" & _
        "Generators.G_ILNumber, tblProducts.Manifest_Description, tblJobTickets_Details.Q" & _
        "uantity, tblJobTickets_Details.UOM, tblProducts.ApprovalNo, tblGenerators.Mailin" & _
        "gAddress1, tblGenerators.MailingAddress2, tblGenerators.MailingCity, tblGenerato" & _
        "rs.MailingName, tblGenerators.MailingState, tblGenerators.MailingZip, tblProduct" & _
        "s.ProductDescription, tblProducts.ProductDescription1 FROM (((((tblProducts INNE" & _
        "R JOIN tblGenerators ON tblProducts.GeneratorID = tblGenerators.GeneratorID) INN" & _
        "ER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) LEFT O" & _
        "UTER JOIN tblDisposalFacilities ON tblJobTickets.DisposalFacilityID = tblDisposa" & _
        "lFacilities.DisposalFacilityID) LEFT OUTER JOIN tblTransporters ON tblJobTickets" & _
        ".TransporterID = tblTransporters.TransporterID) LEFT OUTER JOIN tblJobTickets_De" & _
        "tails ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) WHERE (t" & _
        "blJobTickets.IsCancelled = False)"
        Me.SelectP2Manifest.Connection = Me.OleDbConnection1
        '
        'DsP2Manifests1
        '
        Me.DsP2Manifests1.DataSetName = "DSP2Manifests"
        Me.DsP2Manifests1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'btnPrintHAttachments
        '
        Me.btnPrintHAttachments.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPrintHAttachments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintHAttachments.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintHAttachments.Location = New System.Drawing.Point(408, 464)
        Me.btnPrintHAttachments.Name = "btnPrintHAttachments"
        Me.btnPrintHAttachments.Size = New System.Drawing.Size(96, 32)
        Me.btnPrintHAttachments.TabIndex = 39
        Me.btnPrintHAttachments.Text = "Print Attachments"
        '
        'DANewJobSearch
        '
        Me.DANewJobSearch.SelectCommand = Me.SelectNewJobSearch
        Me.DANewJobSearch.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblGenerators", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GeneratorID", "GeneratorID"), New System.Data.Common.DataColumnMapping("GeneratorName", "GeneratorName"), New System.Data.Common.DataColumnMapping("JobSite", "JobSite"), New System.Data.Common.DataColumnMapping("JobSiteAddress1", "JobSiteAddress1"), New System.Data.Common.DataColumnMapping("JobSiteAddress2", "JobSiteAddress2"), New System.Data.Common.DataColumnMapping("JobSiteCity", "JobSiteCity"), New System.Data.Common.DataColumnMapping("JobSiteState", "JobSiteState"), New System.Data.Common.DataColumnMapping("JobSiteZip", "JobSiteZip"), New System.Data.Common.DataColumnMapping("GNo", "GNo"), New System.Data.Common.DataColumnMapping("ContactName", "ContactName"), New System.Data.Common.DataColumnMapping("ContactPhone", "ContactPhone"), New System.Data.Common.DataColumnMapping("ContacPhoneExt", "ContacPhoneExt"), New System.Data.Common.DataColumnMapping("BrokerName", "BrokerName"), New System.Data.Common.DataColumnMapping("BrokerContact", "BrokerContact"), New System.Data.Common.DataColumnMapping("BrokerPhone", "BrokerPhone"), New System.Data.Common.DataColumnMapping("BillingName", "BillingName"), New System.Data.Common.DataColumnMapping("BillingAddress1", "BillingAddress1"), New System.Data.Common.DataColumnMapping("BillingAddress2", "BillingAddress2"), New System.Data.Common.DataColumnMapping("BillingCity", "BillingCity"), New System.Data.Common.DataColumnMapping("BillingState", "BillingState"), New System.Data.Common.DataColumnMapping("BillingZip", "BillingZip"), New System.Data.Common.DataColumnMapping("G_USEPAID", "G_USEPAID"), New System.Data.Common.DataColumnMapping("Active", "Active"), New System.Data.Common.DataColumnMapping("G_ILNumber", "G_ILNumber")})})
        '
        'SelectNewJobSearch
        '
        Me.SelectNewJobSearch.CommandText = "SELECT tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSit" & _
        "eCity, tblProducts.ProductName, tblProducts.ProductID FROM (tblGenerators INNER " & _
        "JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) ORDER B" & _
        "Y tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCit" & _
        "y, tblProducts.ProductName"
        Me.SelectNewJobSearch.Connection = Me.OleDbConnection1
        '
        'DsNewJobSearch1
        '
        Me.DsNewJobSearch1.DataSetName = "DSNewJobSearch"
        Me.DsNewJobSearch1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'btnPrintLandBanForm
        '
        Me.btnPrintLandBanForm.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPrintLandBanForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintLandBanForm.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintLandBanForm.Location = New System.Drawing.Point(544, 464)
        Me.btnPrintLandBanForm.Name = "btnPrintLandBanForm"
        Me.btnPrintLandBanForm.Size = New System.Drawing.Size(112, 32)
        Me.btnPrintLandBanForm.TabIndex = 40
        Me.btnPrintLandBanForm.Text = "Print          Land Ban Form"
        '
        'DsrptReceiptControl1
        '
        Me.DsrptReceiptControl1.DataSetName = "dsrptReceiptControl"
        Me.DsrptReceiptControl1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT tblGenerators.GeneratorName, tblGenerators.JobSite, tblGenerators.JobSiteA" & _
        "ddress1, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.Jo" & _
        "bSiteZip, tblGenerators.ContactName, tblGenerators.ContactPhone, tblProducts.Pro" & _
        "ductName, tblProducts.ProductDescription, tblJobTickets.JobTicketID, tblGenerato" & _
        "rs.G_USEPAID, tblGenerators.G_ILNumber, tblProducts.HWNumber, tblGenerators.Appr" & _
        "ovalNo FROM ((tblProducts INNER JOIN tblGenerators ON tblProducts.GeneratorID = " & _
        "tblGenerators.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = t" & _
        "blJobTickets.ProductID) WHERE (tblJobTickets.IsCancelled = False)"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'DsAttachmentC1
        '
        Me.DsAttachmentC1.DataSetName = "dsAttachmentC"
        Me.DsAttachmentC1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(88, 352)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 24)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Multi-Stop Job Tickets:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMulti
        '
        Me.lblMulti.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMulti.Location = New System.Drawing.Point(104, 384)
        Me.lblMulti.Name = "lblMulti"
        Me.lblMulti.Size = New System.Drawing.Size(48, 16)
        Me.lblMulti.TabIndex = 42
        Me.lblMulti.Text = "0"
        Me.lblMulti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMulti
        '
        Me.btnMulti.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnMulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMulti.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMulti.Location = New System.Drawing.Point(96, 416)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(72, 24)
        Me.btnMulti.TabIndex = 43
        Me.btnMulti.Text = "Print"
        '
        'btnNewNon
        '
        Me.btnNewNon.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnNewNon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewNon.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewNon.Location = New System.Drawing.Point(192, 416)
        Me.btnNewNon.Name = "btnNewNon"
        Me.btnNewNon.Size = New System.Drawing.Size(96, 32)
        Me.btnNewNon.TabIndex = 44
        Me.btnNewNon.Text = "Print New Non-Hazardous"
        '
        'btnNewHaz
        '
        Me.btnNewHaz.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnNewHaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewHaz.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewHaz.Location = New System.Drawing.Point(320, 416)
        Me.btnNewHaz.Name = "btnNewHaz"
        Me.btnNewHaz.Size = New System.Drawing.Size(96, 32)
        Me.btnNewHaz.TabIndex = 45
        Me.btnNewHaz.Text = "Print New Hazardous"
        '
        'frmPaperwork
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(672, 509)
        Me.Controls.Add(Me.btnNewHaz)
        Me.Controls.Add(Me.btnNewNon)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.lblMulti)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnPrintLandBanForm)
        Me.Controls.Add(Me.btnPrintHAttachments)
        Me.Controls.Add(Me.lblCP2M)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnPrintPlant2M)
        Me.Controls.Add(Me.lblFormC)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnPrintFormC)
        Me.Controls.Add(Me.dgPaperwork)
        Me.Controls.Add(Me.lblCBOL)
        Me.Controls.Add(Me.lblCH)
        Me.Controls.Add(Me.lblCNH)
        Me.Controls.Add(Me.lblCJT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPrintBOL)
        Me.Controls.Add(Me.btnPrintH)
        Me.Controls.Add(Me.btnPrintNH)
        Me.Controls.Add(Me.btnPrintJT)
        Me.Controls.Add(Me.lblJobTickets)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblScheduled)
        Me.Controls.Add(Me.dtJobSchedule)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmPaperwork"
        Me.Text = "frmPaperwork"
        CType(Me.dgPaperwork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsJobBoard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsJobTickets_P1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCustomerSurveys1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsboLs1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNonHazardous1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsListGenerators1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsListProducts1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsHazardous1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsP2Manifests1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNewJobSearch1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsrptReceiptControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAttachmentC1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmPaperwork_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Me.OleDbConnection1.ConnectionString = DBHelper.ConnStr
        'Initialize Date as being tomorrow's date
        Me.dtJobSchedule.Value = DateAdd(DateInterval.Day, 1, Date.Now)
        Me.populatePrintData()
        Me.populateDatagrid()
        Cursor.Current = System.Windows.Forms.Cursors.Default
        IsPageLoaded = True

    End Sub

    Function populatePrintData()

        Dim jtCount As Integer = 0, jtCount_M As Integer = 0, nhCount As Integer = 0, hCount As Integer = 0, bolCount As Integer = 0, FormCCount As Integer = 0, p2MCount As Integer = 0
        Dim curDate As Date, i As Integer
        Dim ds As DataSet, sqlStr As String
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            curDate = Me.dtJobSchedule.Value.ToShortDateString
            'JobTicket Counts
            sqlStr = "SELECT Count(*) FROM tblJobTickets WHERE tblJobTickets.ScheduleDate = #" & curDate.ToShortDateString & "# AND tblJobTickets.JobTicket = TRUE AND tblJobTickets.IsCancelled = False AND tblJobTickets.IsBeaver = True AND tblJobTickets.InvoiceCreated = False "
            jtCount = DBHelper.GetRecordCount(sqlStr)
            If Not IsNothing(Me.printJTs) Then
                Me.printJTs.Clear()
            End If
            sqlStr = "SELECT JobTicketID FROM tblJobTickets WHERE tblJobTickets.ScheduleDate = #" & curDate.ToShortDateString & "# AND tblJobTickets.JobTicket = TRUE AND tblJobTickets.IsCancelled = False AND tblJobTickets.IsBeaver = True AND tblJobTickets.InvoiceCreated = False "
            ds = DBHelper.GetDataSet(sqlStr, "tblJTs")
            If ds.Tables(0).Rows.Count > 0 Then
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    Me.printJTs.Add(ds.Tables(0).Rows(i).Item("JobTicketID"))
                Next
            End If
            ds.Clear()
            'JobTicket Multistop Counts
            sqlStr = "SELECT Count(*) FROM tblJobTickets WHERE tblJobTickets.ScheduleDate = #" & curDate.ToShortDateString & "# AND tblJobTickets.JobTicket = TRUE AND tblJobTickets.IsCancelled = False AND tblJobTickets.IsMultiStop = True AND tblJobTickets.InvoiceCreated = False "
            jtCount_M = DBHelper.GetRecordCount(sqlStr)
            If Not IsNothing(Me.printJTs_M) Then
                Me.printJTs_M.Clear()
            End If
            sqlStr = "SELECT JobTicketID FROM tblJobTickets WHERE tblJobTickets.ScheduleDate = #" & curDate.ToShortDateString & "# AND tblJobTickets.JobTicket = TRUE AND tblJobTickets.IsCancelled = False AND tblJobTickets.IsMultiStop = True AND tblJobTickets.InvoiceCreated = False "
            ds = DBHelper.GetDataSet(sqlStr, "tblJTs")
            If ds.Tables(0).Rows.Count > 0 Then
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    Me.printJTs_M.Add(ds.Tables(0).Rows(i).Item("JobTicketID"))
                Next
            End If
            ds.Clear()
            'Non-Hazardous Counts
            sqlStr = "SELECT Count(*) FROM tblJobTickets WHERE tblJobTickets.ScheduleDate = #" & curDate.ToShortDateString & "# AND tblJobTickets.NonHazardous = TRUE AND tblJobTickets.IsCancelled = False AND tblJobTickets.InvoiceCreated = False "
            nhCount = DBHelper.GetRecordCount(sqlStr)
            If Not IsNothing(Me.printNHs) Then
                Me.printNHs.Clear()
            End If
            sqlStr = "SELECT JobTicketID FROM tblJobTickets WHERE tblJobTickets.ScheduleDate = #" & curDate.ToShortDateString & "# AND tblJobTickets.NonHazardous = TRUE AND tblJobTickets.IsCancelled = False AND tblJobTickets.InvoiceCreated = False "
            ds = DBHelper.GetDataSet(sqlStr, "tblNHs")
            If ds.Tables(0).Rows.Count > 0 Then
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    Me.printNHs.Add(ds.Tables(0).Rows(i).Item("JobTicketID"))
                Next
            End If
            ds.Clear()
            'Hazardous Counts
            sqlStr = "SELECT Count(*) FROM tblJobTickets WHERE tblJobTickets.ScheduleDate = #" & curDate.ToShortDateString & "# AND tblJobTickets.Hazardous = TRUE AND tblJobTickets.IsCancelled = False AND tblJobTickets.InvoiceCreated = False "
            hCount = DBHelper.GetRecordCount(sqlStr)
            If Not IsNothing(Me.printHs) Then
                Me.printHs.Clear()
            End If
            sqlStr = "SELECT JobTicketID FROM tblJobTickets WHERE tblJobTickets.ScheduleDate = #" & curDate.ToShortDateString & "# AND tblJobTickets.Hazardous = TRUE AND tblJobTickets.IsCancelled = False AND tblJobTickets.InvoiceCreated = False "
            ds = DBHelper.GetDataSet(sqlStr, "tblHs")
            If ds.Tables(0).Rows.Count > 0 Then
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    Me.printHs.Add(ds.Tables(0).Rows(i).Item("JobTicketID"))
                Next
            End If
            ds.Clear()
            'Bill of Lading Counts
            sqlStr = "SELECT Count(*) FROM tblJobTickets WHERE tblJobTickets.ScheduleDate = #" & curDate.ToShortDateString & "# AND tblJobTickets.BillOfLading = TRUE AND tblJobTickets.IsCancelled = False AND tblJobTickets.InvoiceCreated = False "
            bolCount = DBHelper.GetRecordCount(sqlStr)
            If Not IsNothing(Me.printBOLs) Then
                Me.printBOLs.Clear()
            End If
            sqlStr = "SELECT JobTicketID FROM tblJobTickets WHERE tblJobTickets.ScheduleDate = #" & curDate.ToShortDateString & "# AND tblJobTickets.BillOfLading = TRUE AND tblJobTickets.IsCancelled = False AND tblJobTickets.InvoiceCreated = False "
            ds = DBHelper.GetDataSet(sqlStr, "tblBOLs")
            If ds.Tables(0).Rows.Count > 0 Then
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    Me.printBOLs.Add(ds.Tables(0).Rows(i).Item("JobTicketID"))
                Next
            End If
            ds.Clear()
            'Form C Counts
            sqlStr = "SELECT Count(*) FROM tblJobTickets WHERE tblJobTickets.ScheduleDate = #" & curDate.ToShortDateString & "# AND tblJobTickets.IsCancelled = False AND tblJobTickets.PrintFormC = TRUE AND tblJobTickets.InvoiceCreated = False "
            FormCCount = DBHelper.GetRecordCount(sqlStr)
            If Not IsNothing(Me.printFormCs) Then
                Me.printFormCs.Clear()
            End If
            sqlStr = "SELECT JobTicketID FROM tblJobTickets WHERE tblJobTickets.ScheduleDate = #" & curDate.ToShortDateString & "# AND tblJobTickets.IsCancelled = False AND tblJobTickets.PrintFormC = TRUE and tblJobTickets.InvoiceCreated = False "
            ds = DBHelper.GetDataSet(sqlStr, "tblCSs")
            If ds.Tables(0).Rows.Count > 0 Then
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    Me.printFormCs.Add(ds.Tables(0).Rows(i).Item("JobTicketID"))
                Next
            End If
            ds.Clear()
            'Plant 2 Manifests Counts
            sqlStr = "SELECT Count(*) FROM tblJobTickets WHERE tblJobTickets.ScheduleDate = #" & curDate.ToShortDateString & "# AND tblJobTickets.Plant2Manifest = TRUE AND tblJobTickets.IsCancelled = False AND tblJobTickets.InvoiceCreated = False "
            p2MCount = DBHelper.GetRecordCount(sqlStr)
            If Not IsNothing(Me.printP2Ms) Then
                Me.printP2Ms.Clear()
            End If
            sqlStr = "SELECT JobTicketID FROM tblJobTickets WHERE tblJobTickets.ScheduleDate = #" & curDate.ToShortDateString & "# AND tblJobTickets.Plant2Manifest = TRUE AND tblJobTickets.IsCancelled = False AND tblJobTickets.InvoiceCreated = False "
            ds = DBHelper.GetDataSet(sqlStr, "tblP2Ms")
            If ds.Tables(0).Rows.Count > 0 Then
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    Me.printP2Ms.Add(ds.Tables(0).Rows(i).Item("JobTicketID"))
                Next
            End If
            ds.Clear()
            'Update Counts
            Me.lblCBOL.Text = bolCount
            Me.lblCH.Text = hCount
            Me.lblCJT.Text = jtCount
            Me.lblMulti.Text = jtCount_M
            Me.lblCNH.Text = nhCount
            Me.lblFormC.Text = FormCCount
            Me.lblCP2M.Text = p2MCount

            If bolCount = 0 Then
                Me.btnPrintBOL.Enabled = False
            Else
                Me.btnPrintBOL.Enabled = True
            End If
            If hCount = 0 Then
                Me.btnPrintH.Enabled = False
                Me.btnPrintHAttachments.Enabled = False
            Else
                Me.btnPrintH.Enabled = True
                Me.btnPrintHAttachments.Enabled = True
            End If
            If nhCount = 0 Then
                Me.btnPrintNH.Enabled = False
            Else
                Me.btnPrintNH.Enabled = True
            End If
            If jtCount = 0 Then
                Me.btnPrintJT.Enabled = False
            Else
                Me.btnPrintJT.Enabled = True
            End If
            If FormCCount = 0 Then
                Me.btnPrintFormC.Enabled = False
            Else
                Me.btnPrintFormC.Enabled = True
            End If
            If p2MCount = 0 Then
                Me.btnPrintPlant2M.Enabled = False
            Else
                Me.btnPrintPlant2M.Enabled = True
            End If
            If jtCount_M = 0 Then
                Me.btnMulti.Enabled = False
            Else
                Me.btnMulti.Enabled = True
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error ocurred")

        Finally
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Function

    Function populateDatagrid()

        Dim ds As DataSet
        Dim sqlStr As String
        Dim curDate As Date = Me.dtJobSchedule.Value.ToShortDateString
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            '-------------------------------------------------------------------
            'Haigriv Vyas
            'Date: 07/05/2005
            '-------------------------------------------------------------------
            'sqlStr = "SELECT tblJobTickets.JobTicketNo, (tblGenerators.JobSite + ', ' + tblGenerators.JobSiteCity) AS GeneratorName, tblProducts.ProductName, tblJobTickets.ScheduleDate, tblJobTickets.DriverName, 'Edit' as EditCol, tblJobTickets.JobTicketID FROM ((tblJobTickets INNER JOIN tblProducts ON tblJobTickets.ProductID = tblProducts.ProductID) INNER JOIN tblGenerators ON tblProducts.GeneratorID = tblGenerators.GeneratorID) WHERE tblJobTickets.ScheduleDate = #" & curDate.ToShortDateString & "# AND tblJobTickets.IsCancelled = False AND InvoiceCreated = FALSE "
            sqlStr = "SELECT tblJobTickets.JobTicketNo, (tblGenerators.GeneratorName + ', ' + tblGenerators.JobSiteCity) AS GeneratorName, tblProducts.ProductName, tblJobTickets.ScheduleDate, tblJobTickets.DriverName, 'Edit' as EditCol, tblJobTickets.JobTicketID FROM ((tblJobTickets INNER JOIN tblProducts ON tblJobTickets.ProductID = tblProducts.ProductID) INNER JOIN tblGenerators ON tblProducts.GeneratorID = tblGenerators.GeneratorID) WHERE tblJobTickets.ScheduleDate = #" & curDate.ToShortDateString & "# AND tblJobTickets.IsCancelled = False AND InvoiceCreated = FALSE "
            ds = DBHelper.GetDataSet(sqlStr, "tblJobTickets")
            rCount = ds.Tables(0).Rows.Count
            ' make the dataGrid use our new tablestyle
            Dim ts_dgPaperwork = New System.Windows.Forms.DataGridTableStyle
            'Define run-time Datagrid
            Me.DefineColumnStyles(ts_dgPaperwork)
            ' make the dataGrid use our new tablestyle and bind it to our table
            dgPaperwork.TableStyles.Clear()
            dgPaperwork.TableStyles.Add(ts_dgPaperwork)
            'bind the table to the datagrid
            Me.dgPaperwork.DataSource = ds
            Me.dgPaperwork.DataMember = "tblJobTickets"
            Me.dgPaperwork.Refresh()
            If Me.rCount = 0 Then Me.dgPaperwork.ReadOnly = True Else Me.dgPaperwork.ReadOnly = False

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error ocurred")

        Finally
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Function

    Private Sub dtJobSchedule_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtJobSchedule.ValueChanged
        If IsPageLoaded = True Then
            Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Me.populatePrintData()
            Me.populateDatagrid()
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    Function DefineColumnStyles(ByRef ts_dgPaperwork As DataGridTableStyle)

        Dim col_dgPaperwork_J = New System.Windows.Forms.DataGridTextBoxColumn
        Dim col_dgPaperwork_G = New System.Windows.Forms.DataGridTextBoxColumn
        Dim col_dgPaperwork_P = New System.Windows.Forms.DataGridTextBoxColumn
        Dim col_dgPaperwork_D = New System.Windows.Forms.DataGridTextBoxColumn
        Dim col_dgPaperwork_B As DataGridButtonColumn = New DataGridButtonColumn(4)

        '
        'ts_dgPaperwork
        '
        ts_dgPaperwork.AlternatingBackColor = System.Drawing.Color.Silver
        ts_dgPaperwork.GridLineColor = System.Drawing.Color.Black
        ts_dgPaperwork.HeaderBackColor = System.Drawing.Color.LightSteelBlue
        ts_dgPaperwork.HeaderFont = New System.Drawing.Font("Verdana", 10.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ts_dgPaperwork.HeaderForeColor = System.Drawing.SystemColors.ControlText
        ts_dgPaperwork.MappingName = "tblJobTickets"
        ts_dgPaperwork.RowHeadersVisible = False

        '
        'col_dgPaperwork_J
        '
        col_dgPaperwork_J.Format = ""
        col_dgPaperwork_J.FormatInfo = Nothing
        col_dgPaperwork_J.HeaderText = "Job #"
        col_dgPaperwork_J.MappingName = "JobTicketNo"
        col_dgPaperwork_J.NullText = ""
        col_dgPaperwork_J.ReadOnly = True
        col_dgPaperwork_J.Width = 100
        ts_dgPaperwork.GridColumnStyles.Add(col_dgPaperwork_J)
        '
        'col_dgPaperwork_G
        '
        col_dgPaperwork_G.Format = ""
        col_dgPaperwork_G.FormatInfo = Nothing
        col_dgPaperwork_G.HeaderText = "Generator"
        col_dgPaperwork_G.MappingName = "GeneratorName"
        col_dgPaperwork_G.NullText = ""
        col_dgPaperwork_G.ReadOnly = True
        col_dgPaperwork_G.Width = 225
        ts_dgPaperwork.GridColumnStyles.Add(col_dgPaperwork_G)
        '
        'col_dgPaperwork_P
        '
        col_dgPaperwork_P.Format = ""
        col_dgPaperwork_P.FormatInfo = Nothing
        col_dgPaperwork_P.HeaderText = "Product"
        col_dgPaperwork_P.MappingName = "ProductName"
        col_dgPaperwork_P.NullText = ""
        col_dgPaperwork_P.ReadOnly = True
        col_dgPaperwork_P.Width = 200
        ts_dgPaperwork.GridColumnStyles.Add(col_dgPaperwork_P)
        '
        'col_dgPaperwork_D
        '
        col_dgPaperwork_D.Format = ""
        col_dgPaperwork_D.FormatInfo = Nothing
        col_dgPaperwork_D.HeaderText = "Driver"
        col_dgPaperwork_D.MappingName = "DriverName"
        col_dgPaperwork_D.NullText = ""
        col_dgPaperwork_D.Width = 75
        ts_dgPaperwork.GridColumnStyles.Add(col_dgPaperwork_D)

    End Function

    Private Sub btnPrintBOL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintBOL.Click

        If MsgBox("You are about to print " & Me.printBOLs.Count & " BOLs to the DOT Matrix Printer. Continue?", MsgBoxStyle.YesNo, "Print BOLs") = MsgBoxResult.Yes Then

            Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Try

                Dim bolSTR As String, iC As Integer
                If Me.printBOLs.Count > 0 Then
                    For iC = 0 To Me.printBOLs.Count - 1
                        If iC = 0 Then
                            bolSTR = "tblJobTickets.JobTicketID = " & CInt(Me.printBOLs.Item(iC))
                        Else
                            bolSTR = bolSTR & " OR tblJobTickets.JobTicketID = " & CInt(Me.printBOLs.Item(iC))
                        End If
                    Next
                    Dim ds As DataSet
                    '-------------------------------------------------------------------
                    'Haigriv Vyas
                    'Date: 07/05/2005
                    '-------------------------------------------------------------------
                    'bolSTR = "SELECT tblGenerators.GeneratorName, tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip,  " _
                    bolSTR = "SELECT tblGenerators.JobSite as GeneratorName, tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip,  " _
                      & " tblGenerators.ContactPhone, tblTransporters.TransporterName, tblTransporters.T_USEPAID, tblTransporters.TPhone,  " _
                      & " tblDisposalFacilities.DisposalFacilityName, tblDisposalFacilities.FAddress1, tblDisposalFacilities.FCity, tblDisposalFacilities.FState,  " _
                      & " tblDisposalFacilities.FZip, tblDisposalFacilities.D_USEPAID, tblDisposalFacilities.FPhone, tblProducts.ProductName, tblJobTickets.JobTicketID,  " _
                      & " tblGenerators.G_USEPAID, tblGenerators.G_ILNumber, tblProducts.Manifest_Description, tblJobTickets_Details.Quantity,  " _
                      & " tblJobTickets_Details.UOM, tblProducts.ApprovalNo,tblGenerators.MailingAddress1, tblGenerators.MailingAddress2, tblGenerators.MailingCity, tblGenerators.MailingName, " _
                      & " tblGenerators.MailingState, tblGenerators.MailingZip, tblProducts.ProductDescription, tblProducts.ProductDescription1,tblProducts.Type as Type  " _
                      & " FROM (((((tblProducts INNER JOIN " _
                      & " tblGenerators ON tblProducts.GeneratorID = tblGenerators.GeneratorID) INNER JOIN " _
                      & " tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) LEFT OUTER JOIN " _
                      & " tblDisposalFacilities ON tblJobTickets.DisposalFacilityID = tblDisposalFacilities.DisposalFacilityID) LEFT OUTER JOIN " _
                      & " tblTransporters ON tblJobTickets.TransporterID = tblTransporters.TransporterID) LEFT OUTER JOIN " _
                      & " tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) " _
                      & " WHERE (" & Replace(bolSTR, "'", "''") & ") AND tblJobTickets.IsCancelled = False "
                    ds = DBHelper.GetDataSet(bolSTR, "tblJobTickets")
                    Dim objR As New rpt_BOLs_new
                    objR.SetDataSource(ds)
                    DBHelper.Authenticate(objR)
                    Dim frmR As New frmReport
                    frmR.Text = "Bill of Lading(s)"
                    frmR.WindowState = FormWindowState.Maximized
                    frmR.CrystalReportViewer1.ReportSource = objR
                    frmR.CrystalReportViewer1.RefreshReport()
                    frmR.ShowDialog(Me)
                    frmR = Nothing
                End If

            Catch ex As SystemException

                MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

            Finally
                Cursor.Current = System.Windows.Forms.Cursors.Default

            End Try

        End If

    End Sub

    Private Sub btnPrintFormC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintFormC.Click

        If MsgBox("You are about to print " & Me.printFormCs.Count & " Attachments Forms to the Laser Printer. Continue?", MsgBoxStyle.YesNo, "Print Customer Survey Forms") = MsgBoxResult.Yes Then

            Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Try
                Dim curDate As Date, i As Integer
                curDate = Me.dtJobSchedule.Value.ToShortDateString
                Dim csSTR As String, iC As Integer
                If Me.printFormCs.Count > 0 Then
                    For iC = 0 To Me.printFormCs.Count - 1
                        If iC = 0 Then
                            csSTR = "tblJobTickets.JobTicketID = " & CInt(Me.printFormCs.Item(iC))
                        Else
                            csSTR = csSTR & " OR tblJobTickets.JobTicketID = " & CInt(Me.printFormCs.Item(iC))
                        End If
                    Next
                    Dim ds As DataSet
                    '-------------------------------------------------------------------
                    'Haigriv Vyas
                    'Date: 07/05/2005
                    '-------------------------------------------------------------------
                    'csSTR = "SELECT  tblGenerators.GeneratorName, tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, " _
                    csSTR = "SELECT tblGenerators.JobSite as GeneratorName, tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, " _
                        & " tblGenerators.JobSiteZip, tblGenerators.ContactName, tblGenerators.ContactPhone, tblProducts.ProductName,tblProducts.ProductDescription, tblJobTickets.JobTicketID, " _
                        & " tblGenerators.G_USEPAID, tblGenerators.G_ILNumber, tblProducts.HWNumber, tblProducts.ApprovalNo " _
                        & " FROM ((tblProducts INNER JOIN " _
                        & " tblGenerators ON tblProducts.GeneratorID = tblGenerators.GeneratorID) INNER JOIN " _
                        & " tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) " _
                        & " WHERE (" & Replace(csSTR, "'", "''") & ") AND tblJobTickets.ScheduleDate = #" & curDate.ToShortDateString & "# and tblJobTickets.IsCancelled = False AND tblJobTickets.InvoiceCreated = False"
                    ds = DBHelper.GetDataSet(csSTR, "Table")
                    Dim objR As New rptAttachmentC
                    objR.SetDataSource(ds)
                    DBHelper.Authenticate(objR)
                    Dim frmR As New frmReport
                    frmR.Text = "Attachment C"
                    frmR.WindowState = FormWindowState.Maximized
                    frmR.CrystalReportViewer1.ReportSource = objR
                    frmR.CrystalReportViewer1.RefreshReport()
                    frmR.ShowDialog(Me)
                    frmR = Nothing
                End If

            Catch ex As SystemException

                MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

            Finally
                Cursor.Current = System.Windows.Forms.Cursors.Default

            End Try

        End If

    End Sub

    Private Sub btnPrintNH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintNH.Click, btnNewNon.Click

        If MsgBox("You are about to print " & Me.printNHs.Count & " Non-Hazardous Waste Manifest(s) to the DOT Matrix Printer. Continue?", MsgBoxStyle.YesNo, "Non-Hazardous Waste Manifest") = MsgBoxResult.Yes Then

            Try

                Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                Dim nhSTR As String, iC As Integer
                If Me.printNHs.Count > 0 Then
                    For iC = 0 To Me.printNHs.Count - 1
                        If iC = 0 Then
                            nhSTR = "tblJobTickets.JobTicketID = " & CInt(Me.printNHs.Item(iC))
                        Else
                            nhSTR = nhSTR & " OR tblJobTickets.JobTicketID = " & CInt(Me.printNHs.Item(iC))
                        End If
                    Next
                    Dim ds As DataSet
                    '-------------------------------------------------------------------
                    'Haigriv Vyas
                    'Date: 07/05/2005
                    '-------------------------------------------------------------------
                    'nhSTR = "SELECT tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip,  " _
                    Dim objR As ReportDocument
                    If CType(sender, Button).Name = "btnPrintNH" Then
                        nhSTR = "SELECT tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip,  " _
                          & " tblGenerators.ContactPhone, tblTransporters.TransporterName, tblTransporters.T_USEPAID, tblTransporters.TPhone,  " _
                          & " tblDisposalFacilities.DisposalFacilityName, tblDisposalFacilities.FAddress1, tblDisposalFacilities.FCity, tblDisposalFacilities.FState,  " _
                          & " tblDisposalFacilities.FZip, tblDisposalFacilities.D_USEPAID, tblDisposalFacilities.FPhone, tblProducts.ProductName, tblJobTickets.JobTicketID,  " _
                          & " tblGenerators.G_USEPAID, tblGenerators.G_ILNumber, tblProducts.Manifest_Description, tblJobTickets_Details.Quantity,  " _
                          & " tblJobTickets_Details.UOM, tblProducts.ApprovalNo,tblGenerators.MailingAddress1, tblGenerators.MailingAddress2, tblGenerators.MailingCity, tblGenerators.MailingName, " _
                          & " tblGenerators.MailingState, tblGenerators.MailingZip, tblProducts.ProductDescription, tblProducts.ProductDescription1, tblTransporters.T_ILNumber, tblDisposalFacilities.D_ILNumber,tblProducts.AdditionalHWNumber " _
                          & " FROM (((((tblProducts INNER JOIN " _
                          & " tblGenerators ON tblProducts.GeneratorID = tblGenerators.GeneratorID) INNER JOIN " _
                          & " tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) LEFT OUTER JOIN " _
                          & " tblDisposalFacilities ON tblJobTickets.DisposalFacilityID = tblDisposalFacilities.DisposalFacilityID) LEFT OUTER JOIN " _
                          & " tblTransporters ON tblJobTickets.TransporterID = tblTransporters.TransporterID) LEFT OUTER JOIN " _
                          & " tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) " _
                          & " WHERE (" & Replace(nhSTR, "'", "''") & ") AND tblJobTickets.IsCancelled = False "

                        ds = DBHelper.GetDataSet(nhSTR, "tblJobTickets")
                        objR = New rpt_NonHazardous
                    Else
                        nhSTR = "SELECT tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip,  " _
                        & " tblGenerators.ContactPhone, tblTransporters.TransporterName, tblTransporters.T_USEPAID, tblTransporters.TPhone,  " _
                        & " tblDisposalFacilities.DisposalFacilityName, tblDisposalFacilities.FAddress1, tblDisposalFacilities.FCity, tblDisposalFacilities.FState,  " _
                        & " tblDisposalFacilities.FZip, tblDisposalFacilities.D_USEPAID, tblDisposalFacilities.FPhone, tblProducts.ProductName, tblJobTickets.JobTicketID,  " _
                        & " tblGenerators.G_USEPAID, tblGenerators.GNo as G_ILNumber, tblProducts.Manifest_Description, tblJobTickets_Details.Quantity,  " _
                        & " tblJobTickets_Details.UOM, tblProducts.ApprovalNo,tblGenerators.MailingAddress1, tblGenerators.MailingAddress2, tblGenerators.MailingCity, tblGenerators.MailingName, " _
                        & " tblGenerators.MailingState, tblGenerators.MailingZip, tblProducts.ProductDescription, tblProducts.ProductDescription1, tblTransporters.T_ILNumber, tblDisposalFacilities.D_ILNumber,tblProducts.AdditionalHWNumber,tblProducts.HWNumber " _
                        & " FROM (((((tblProducts INNER JOIN " _
                        & " tblGenerators ON tblProducts.GeneratorID = tblGenerators.GeneratorID) INNER JOIN " _
                        & " tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) LEFT OUTER JOIN " _
                        & " tblDisposalFacilities ON tblJobTickets.DisposalFacilityID = tblDisposalFacilities.DisposalFacilityID) LEFT OUTER JOIN " _
                        & " tblTransporters ON tblJobTickets.TransporterID = tblTransporters.TransporterID) LEFT OUTER JOIN " _
                        & " tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) " _
                        & " WHERE (" & Replace(nhSTR, "'", "''") & ") AND tblJobTickets.IsCancelled = False "

                        ds = DBHelper.GetDataSet(nhSTR, "tblJobTickets")

                        objR = New rptNonHazardous
                    End If
                    objR.SetDataSource(ds)
                    DBHelper.Authenticate(objR)
                    Dim frmR As New frmReport
                    frmR.Text = "Non-Hazardous Manifest(s)"
                    frmR.WindowState = FormWindowState.Maximized
                    frmR.CrystalReportViewer1.ReportSource = objR
                    frmR.CrystalReportViewer1.RefreshReport()
                    frmR.ShowDialog(Me)
                    frmR = Nothing
                End If

            Catch ex As SystemException

                MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

            Finally
                Cursor.Current = System.Windows.Forms.Cursors.Default

            End Try

        End If

    End Sub

    Private Sub btnPrintH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintH.Click, btnNewHaz.Click

        If MsgBox("You are about to print " & Me.printHs.Count & " Hazardous Manifest(s) to the DOT Matrix Printer. Continue?", MsgBoxStyle.YesNo, "Hazardous Manifest(s)") = MsgBoxResult.Yes Then

            Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Try

                Dim hSTR As String, iC As Integer
                If Me.printHs.Count > 0 Then
                    For iC = 0 To Me.printHs.Count - 1
                        If iC = 0 Then
                            hSTR = "tblJobTickets.JobTicketID = " & CInt(Me.printHs.Item(iC))
                        Else
                            hSTR = hSTR & " OR tblJobTickets.JobTicketID = " & CInt(Me.printHs.Item(iC))
                        End If
                    Next
                    Dim ds As DataSet
                    '-------------------------------------------------------------------
                    'Haigriv Vyas
                    'Date: 07/05/2005
                    '-------------------------------------------------------------------
                    'hSTR = "SELECT tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, " _
                    hSTR = "SELECT tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, " _
                      & " tblGenerators.ContactPhone, tblTransporters.TransporterName, tblTransporters.T_USEPAID, tblTransporters.TPhone,  " _
                      & " tblDisposalFacilities.DisposalFacilityName, tblDisposalFacilities.FAddress1, tblDisposalFacilities.FCity, tblDisposalFacilities.FState,  " _
                      & " tblDisposalFacilities.FZip, tblDisposalFacilities.D_USEPAID, tblDisposalFacilities.FPhone, tblProducts.ProductName, tblJobTickets.JobTicketID,  " _
                      & " tblGenerators.G_USEPAID, tblGenerators.G_ILNumber, tblProducts.Manifest_Description, tblJobTickets_Details.Quantity,  " _
                      & " tblJobTickets_Details.UOM, tblProducts.ApprovalNo,tblGenerators.MailingAddress1, tblGenerators.MailingAddress2, tblGenerators.MailingCity, tblGenerators.MailingName, " _
                      & " tblGenerators.MailingState, tblGenerators.MailingZip, tblProducts.ProductDescription, tblProducts.ProductDescription1, tblDisposalFacilities.D_ILNumber, tblTransporters.T_ILNumber, tblProducts.HWNumber,tblProducts.AdditionalHWNumber " _
                      & " FROM (((((tblProducts INNER JOIN " _
                      & " tblGenerators ON tblProducts.GeneratorID = tblGenerators.GeneratorID) INNER JOIN " _
                      & " tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) LEFT OUTER JOIN " _
                      & " tblDisposalFacilities ON tblJobTickets.DisposalFacilityID = tblDisposalFacilities.DisposalFacilityID) LEFT OUTER JOIN " _
                      & " tblTransporters ON tblJobTickets.TransporterID = tblTransporters.TransporterID) LEFT OUTER JOIN " _
                      & " tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) " _
                      & " WHERE (" & Replace(hSTR, "'", "''") & ") AND tblJobTickets.IsCancelled = False "

                    ds = DBHelper.GetDataSet(hSTR, "tblJobTickets")

                    Dim objR As ReportDocument
                    If CType(sender, Button).Name = "btnPrintH" Then
                        objR = New rpt_Hazardous_new
                    Else
                        objR = New rptHazardous
                    End If
                    objR.SetDataSource(ds)
                    DBHelper.Authenticate(objR)
                    Dim frmR As New frmReport
                    frmR.Text = "Hazardous Manifest(s)"
                    frmR.WindowState = FormWindowState.Maximized
                    frmR.CrystalReportViewer1.ReportSource = objR
                    frmR.CrystalReportViewer1.RefreshReport()
                    frmR.ShowDialog(Me)
                    frmR = Nothing
                End If

            Catch ex As SystemException

                MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

            Finally
                Cursor.Current = System.Windows.Forms.Cursors.Default
            End Try
        End If

    End Sub

    Private Sub btnPrintHAttachments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintHAttachments.Click

        If MsgBox("You are about to print " & Me.printHs.Count & " Hazardous Manifest Attachments to the laser printer. Continue?", MsgBoxStyle.YesNo, "Hazardous Manifest(s)") = MsgBoxResult.Yes Then

            Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Try

                Dim hSTR As String, iC As Integer
                If Me.printHs.Count > 0 Then
                    For iC = 0 To Me.printHs.Count - 1
                        If iC = 0 Then
                            hSTR = "tblJobTickets.JobTicketID = " & CInt(Me.printHs.Item(iC))
                        Else
                            hSTR = hSTR & " OR tblJobTickets.JobTicketID = " & CInt(Me.printHs.Item(iC))
                        End If
                    Next
                    Dim ds As DataSet
                    '-------------------------------------------------------------------
                    'Haigriv Vyas
                    'Date: 07/05/2005
                    '-------------------------------------------------------------------
                    'hSTR = "SELECT tblGenerators.GeneratorName, tblGenerators.JobSiteAddress1, tblGenerators.JobSite, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, " _
                    hSTR = "SELECT tblGenerators.JobSite as GeneratorName, tblGenerators.JobSiteAddress1, tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, " _
                    & " tblTransporters.TransporterName, tblTransporters.TAddress1, tblTransporters.TCity, tblTransporters.TState, tblTransporters.TZip, tblGenerators.G_USEPAID, tblGenerators.G_ILNumber,tblProducts.HWNumber,tblProducts.AdditionalHWNumber " _
                    & " FROM (((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) LEFT OUTER JOIN tblTransporters ON tblJobTickets.TransporterID = tblTransporters.TransporterID) " _
                    & " WHERE (" & Replace(hSTR, "'", "''") & ") AND tblJobTickets.IsCancelled = False "
                    'Print Preview Analysis Sheets
                    ds = DBHelper.GetDataSet(hSTR, "Table")
                    Dim objR As New rptAnalysis
                    objR.SetDataSource(ds)
                    DBHelper.Authenticate(objR)
                    Dim frmR As New frmReport
                    frmR.Text = "Analysis Sheets(s)"
                    frmR.WindowState = FormWindowState.Maximized
                    frmR.CrystalReportViewer1.ReportSource = objR
                    frmR.CrystalReportViewer1.RefreshReport()
                    frmR.ShowDialog(Me)
                    frmR = Nothing
                    'Print Preview Receipt Controls
                    Dim objR1 As New rptReceiptControl
                    objR1.SetDataSource(ds)
                    DBHelper.Authenticate(objR1)
                    Dim frmR1 As New frmReport
                    frmR1.Text = "Receipt Control(s)"
                    frmR1.WindowState = FormWindowState.Maximized
                    frmR1.CrystalReportViewer1.ReportSource = objR1
                    frmR1.CrystalReportViewer1.RefreshReport()
                    frmR1.ShowDialog(Me)
                    frmR1 = Nothing
                    'Print Preview Waste Notification
                    Dim objR2 As New rptWasteNoitification
                    objR2.SetDataSource(ds)
                    DBHelper.Authenticate(objR2)
                    Dim frmR2 As New frmReport
                    frmR2.Text = "Waste Notification(s)"
                    frmR2.WindowState = FormWindowState.Maximized
                    frmR2.CrystalReportViewer1.ReportSource = objR2
                    frmR2.CrystalReportViewer1.RefreshReport()
                    frmR2.ShowDialog(Me)
                    frmR2 = Nothing

                End If

            Catch ex As SystemException

                MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

            Finally
                Cursor.Current = System.Windows.Forms.Cursors.Default
            End Try
        End If

    End Sub

    Private Sub btnPrintPlant2M_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPlant2M.Click

        If MsgBox("You are about to print " & Me.printP2Ms.Count & " Plant 2 Manifest(s) to the DOT Matrix Printer. Continue?", MsgBoxStyle.YesNo, "Plant 2 Manifest(s)") = MsgBoxResult.Yes Then

            Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Try

                Dim p2MSTR As String, iC As Integer
                If Me.printP2Ms.Count > 0 Then
                    For iC = 0 To Me.printP2Ms.Count - 1
                        If iC = 0 Then
                            p2MSTR = "tblJobTickets.JobTicketID = " & CInt(Me.printP2Ms.Item(iC))
                        Else
                            p2MSTR = p2MSTR & " OR tblJobTickets.JobTicketID = " & CInt(Me.printP2Ms.Item(iC))
                        End If
                    Next
                    Dim ds As DataSet
                    '-------------------------------------------------------------------
                    'Haigriv Vyas
                    'Date: 07/05/2005
                    '-------------------------------------------------------------------
                    'p2MSTR = "SELECT tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip,  " _
                    p2MSTR = "SELECT tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip,  " _
                      & " tblGenerators.ContactPhone, tblTransporters.TransporterName, tblTransporters.T_USEPAID, tblTransporters.TPhone,  " _
                      & " tblDisposalFacilities.DisposalFacilityName, tblDisposalFacilities.FAddress1, tblDisposalFacilities.FCity, tblDisposalFacilities.FState,  " _
                      & " tblDisposalFacilities.FZip, tblDisposalFacilities.D_USEPAID, tblDisposalFacilities.FPhone, tblProducts.ProductName, tblJobTickets.JobTicketID,  " _
                      & " tblGenerators.G_USEPAID, tblGenerators.G_ILNumber, tblProducts.Manifest_Description, tblJobTickets_Details.Quantity,  " _
                      & " tblJobTickets_Details.UOM, tblProducts.ApprovalNo,tblGenerators.MailingAddress1, tblGenerators.MailingAddress2, tblGenerators.MailingCity, tblGenerators.MailingName, " _
                      & " tblGenerators.MailingState, tblGenerators.MailingZip, tblProducts.ProductDescription, tblProducts.ProductDescription1,tblProducts.AdditionalHWNumber " _
                      & " FROM (((((tblProducts INNER JOIN " _
                      & " tblGenerators ON tblProducts.GeneratorID = tblGenerators.GeneratorID) INNER JOIN " _
                      & " tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) LEFT OUTER JOIN " _
                      & " tblDisposalFacilities ON tblJobTickets.DisposalFacilityID = tblDisposalFacilities.DisposalFacilityID) LEFT OUTER JOIN " _
                      & " tblTransporters ON tblJobTickets.TransporterID = tblTransporters.TransporterID) LEFT OUTER JOIN " _
                      & " tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) " _
                      & " WHERE (" & Replace(p2MSTR, "'", "''") & ") AND tblJobTickets.IsCancelled = False "

                    ds = DBHelper.GetDataSet(p2MSTR, "tblJobTickets")
                    Dim objR As New rpt_P2Manifests_new
                    objR.SetDataSource(ds)
                    DBHelper.Authenticate(objR)
                    Dim frmR As New frmReport
                    frmR.Text = "Plant 2 Manifest(s)"
                    frmR.WindowState = FormWindowState.Maximized
                    frmR.CrystalReportViewer1.ReportSource = objR
                    frmR.CrystalReportViewer1.RefreshReport()
                    frmR.ShowDialog(Me)
                    frmR = Nothing
                End If

            Catch ex As SystemException

                MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

            Finally
                Cursor.Current = System.Windows.Forms.Cursors.Default
            End Try
        End If

    End Sub

    Private Sub btnPrintLandBanForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintLandBanForm.Click
        If Me.printHs.Count = 0 Then
            MsgBox("No Land Ban Form found.")
            Exit Sub
        End If
        If MsgBox("You are about to print Land Ban Form to the laser printer. Continue?", MsgBoxStyle.YesNo, "Land Ban Form") = MsgBoxResult.Yes Then
            Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Try
                Dim hSTR As String, iC As Integer
                If Me.printHs.Count > 0 Then
                    For iC = 0 To Me.printHs.Count - 1
                        If iC = 0 Then
                            hSTR = "tblJobTickets.JobTicketID = " & CInt(Me.printHs.Item(iC))
                        Else
                            hSTR = hSTR & " OR tblJobTickets.JobTicketID = " & CInt(Me.printHs.Item(iC))
                        End If
                    Next
                    Dim ds As DataSet
                    '-------------------------------------------------------------------
                    'Haigriv Vyas
                    'Date: 07/05/2005
                    '-------------------------------------------------------------------
                    'hSTR = "SELECT tblGenerators.GeneratorName, tblGenerators.JobSiteAddress1, tblGenerators.JobSite, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, " _
                    hSTR = "SELECT tblGenerators.JobSite as GeneratorName, tblGenerators.JobSiteAddress1, tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, " _
                    & " tblTransporters.TransporterName, tblTransporters.TAddress1, tblTransporters.TCity, tblTransporters.TState, tblTransporters.TZip, tblGenerators.G_USEPAID, tblGenerators.G_ILNumber ,tblProducts.HWNumber,tblProducts.AdditionalHWNumber" _
                    & " FROM (((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) LEFT OUTER JOIN tblTransporters ON tblJobTickets.TransporterID = tblTransporters.TransporterID) " _
                    & " WHERE (" & Replace(hSTR, "'", "''") & ") AND tblJobTickets.IsCancelled = False "
                    'Print Preview Analysis Sheets
                    ds = DBHelper.GetDataSet(hSTR, "Table")
                    'Print Preview Waste Notification
                    Dim objR2 As New rptWasteNoitification
                    objR2.SetDataSource(ds)
                    DBHelper.Authenticate(objR2)
                    Dim frmR2 As New frmReport
                    frmR2.Text = "Waste Notification(s)"
                    frmR2.WindowState = FormWindowState.Maximized
                    frmR2.CrystalReportViewer1.ReportSource = objR2
                    frmR2.CrystalReportViewer1.RefreshReport()
                    frmR2.ShowDialog(Me)
                    frmR2 = Nothing
                End If
            Catch ex As SystemException
                MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
            Finally
                Cursor.Current = System.Windows.Forms.Cursors.Default
            End Try
        End If
    End Sub

    Private Sub btnMulti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMulti.Click
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            If Me.printJTs_M.Count > 0 Then
                Dim jtSTR As String, iC As Integer
                If MsgBox("You are about to print " & Me.printJTs_M.Count & " Multistop Job Ticket(s) to the DOT Matrix Printer. Continue?", MsgBoxStyle.YesNo, "Print Job Tickets") = MsgBoxResult.Yes Then
                    If Me.printJTs_M.Count > 0 Then
                        For iC = 0 To Me.printJTs_M.Count - 1
                            If iC = 0 Then
                                jtSTR = "tblJobTickets.JobTicketID = " & CInt(Me.printJTs_M.Item(iC))
                            Else
                                jtSTR = jtSTR & " OR tblJobTickets.JobTicketID = " & CInt(Me.printJTs_M.Item(iC))
                            End If
                        Next
                        Dim ds As DataSet
                        '-------------------------------------------------------------------
                        'Haigriv Vyas
                        'Date: 07/05/2005
                        '-------------------------------------------------------------------
                        'jtSTR = "SELECT tblProducts.ProductName, tblGenerators.GeneratorName, tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteAddress2, tblGenerators.JobSiteCity, " & _
                        jtSTR = "SELECT tblProducts.ProductName, IIF(len(Trim(tblGenerators.JobSite))=0, tblGenerators.GeneratorName, tblGenerators.JobSite) as GeneratorName, tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteAddress2, tblGenerators.JobSiteCity, " & _
                            "tblGenerators.JobSiteState, tblGenerators.JobSiteZip, tblTransporters.TransporterName,tblDisposalFacilities.DisposalFacilityName + ' : ' + tblDisposalFacilities.FCity as DisposalFacilityName, " & _
                            "tblProducts.HWNumber, tblJobTickets.IsManifest AS IsManifest, tblJobTickets.ManifestNo, tblJobTickets.Attn, tblJobTickets.DriverName, tblJobTickets.DriverRemarks, tblJobTickets.JobPO, " & _
                            "tblJobTickets.JobTicketNo, tblJobTickets.ScheduleDate, tblJobTickets.SpecialInstructions_T, tblJobTickets.TicketNo, tblJobTickets.TruckNo, tblJobTickets.ManifestText as ApprovalNoManifestText " & _
                        "FROM ((((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) " & _
                            "INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) " & _
                            "INNER JOIN tblDisposalFacilities ON tblJobTickets.DisposalFacilityID = tblDisposalFacilities.DisposalFacilityID) " & _
                            "INNER JOIN tblTransporters ON tblJobTickets.TransporterID = tblTransporters.TransporterID) " & _
                        "WHERE (" & Replace(jtSTR, "'", "''") & ") AND tblJobTickets.IsCancelled = False "


                        'jtSTR = "SELECT tblJobTickets.*, tblProducts.ApprovalNo, tblProducts.ProductName, tblGenerators.GeneratorName, tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteAddress2, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, tblTransporters.TransporterName, tblDisposalFacilities.DisposalFacilityName, IIF(len(Trim(tblJobTickets.ManifestText)) > 0, tblJobTickets.ManifestText, ""APV # "" & tblProducts.ApprovalNo) as ApprovalNoManifestText, " _
                        '        & " tblJobTickets.SpecialInstructions_T FROM (tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN ((tblJobTickets LEFT JOIN tblDisposalFacilities ON tblJobTickets.DisposalFacilityID = tblDisposalFacilities.DisposalFacilityID) LEFT JOIN tblTransporters ON tblJobTickets.TransporterID = tblTransporters.TransporterID) ON tblProducts.ProductID = tblJobTickets.ProductID " _
                        '        & " WHERE (" & Replace(jtSTR, "'", "''") & ") AND tblJobTickets.IsCancelled = False "
                        ds = DBHelper.GetDataSet(jtSTR, "tblJobTickets")
                        Dim objR1 As New rpt_JobTicket_Multistop
                        objR1.SetDataSource(ds)
                        DBHelper.Authenticate(objR1)
                        Dim frmR1 As New frmReport
                        frmR1.Text = "Job Tickets(s) - Multistops"
                        frmR1.WindowState = FormWindowState.Maximized
                        frmR1.CrystalReportViewer1.ReportSource = objR1
                        frmR1.CrystalReportViewer1.RefreshReport()
                        frmR1.ShowDialog()
                        frmR1 = Nothing
                    End If
                End If
            End If
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
            Cursor.Current = System.Windows.Forms.Cursors.Default
        Finally
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnPrintJT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintJT.Click
        Dim jtSTR As String, iC As Integer
        Try
            If MsgBox("You are about to print " & Me.printJTs.Count & " regular Job Ticket(s) to the DOT MATRIX Printer. Continue?", MsgBoxStyle.YesNo, "Print Job Tickets") = MsgBoxResult.Yes Then
                Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                If Me.printJTs.Count > 0 Then
                    For iC = 0 To Me.printJTs.Count - 1
                        If iC = 0 Then
                            jtSTR = "tblJobTickets.JobTicketID = " & CInt(Me.printJTs.Item(iC))
                        Else
                            jtSTR = jtSTR & " OR tblJobTickets.JobTicketID = " & CInt(Me.printJTs.Item(iC))
                        End If
                    Next
                    Dim ds As DataSet
                    'jtSTR = "SELECT tblJobTickets.ScheduleDate,tblProducts.ApprovalNo, tblProducts.ProductName, tblGenerators.GeneratorName, tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteAddress2, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, tblTransporters.TransporterName, tblDisposalFacilities.DisposalFacilityName, IIF(len(Trim(tblJobTickets.ManifestText)) > 0, tblJobTickets.ManifestText, ""APV # "" & tblProducts.ApprovalNo) as ApprovalNoManifestText, " _
                    '        & " tblJobTickets.IsManifest as IsManifest,tblJobTickets.SpecialInstructions_T,tblJobTickets.ManifestNo,tblJobTickets.JobPO,tblJobTickets.Attn,tblJobTickets.TruckNo,tblJobTickets.DriverName FROM (tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN ((tblJobTickets LEFT JOIN tblDisposalFacilities ON tblJobTickets.DisposalFacilityID = tblDisposalFacilities.DisposalFacilityID) LEFT JOIN tblTransporters ON tblJobTickets.TransporterID = tblTransporters.TransporterID) ON tblProducts.ProductID = tblJobTickets.ProductID " _
                    '        & " WHERE (" & Replace(jtSTR, "'", "''") & ") AND tblJobTickets.IsCancelled = False "


                    '-------------------------------------------------------------------
                    'Haigriv Vyas
                    'Date: 07/05/2005
                    '-------------------------------------------------------------------
                    'jtSTR = "SELECT tblProducts.ProductName, tblGenerators.GeneratorName, tblGenerators.JobSit" & _
                    jtSTR = "SELECT tblProducts.ProductName, IIF(len(tblGenerators.JobSite)=0, tblGenerators.GeneratorName, tblGenerators.JobSite) as GeneratorName, tblGenerators.GeneratorName as JobSite, " & _
        "tblGenerators.JobSiteAddress1, tblGenerators.JobSiteAddress2, tblGenerators.J" & _
       "obSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, tblTransporter" & _
       "s.TransporterName, tblDisposalFacilities.DisposalFacilityName + ' : ' + tblDisposalFacilities.FCity as DisposalFacilityName, tblProducts.HWNum" & _
       "ber, tblJobTickets.IsManifest AS IsManifest, tblJobTickets.ManifestNo, tblJobTic" & _
       "kets.Attn, tblJobTickets.DriverName, tblJobTickets.DriverRemarks, tblJobTickets." & _
       "JobPO, tblJobTickets.JobTicketNo, tblJobTickets.ScheduleDate, tblJobTickets.Spec" & _
       "ialInstructions_T, tblJobTickets.TicketNo, tblJobTickets.TruckNo,IIF(len(Trim(tblJobTickets.ManifestText)) > 0, tblJobTickets.ManifestText, ""APV # "" & tblProducts.ApprovalNo) as ApprovalNoManifestText FROM ((((tblGen" & _
       "erators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.Genera" & _
       "torID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.Product" & _
       "ID) INNER JOIN tblDisposalFacilities ON tblJobTickets.DisposalFacilityID = tblDi" & _
       "sposalFacilities.DisposalFacilityID) INNER JOIN tblTransporters ON tblJobTickets" & _
       ".TransporterID = tblTransporters.TransporterID)" & _
       " WHERE (" & Replace(jtSTR, "'", "''") & ") AND tblJobTickets.IsCancelled = False "

                    ds = DBHelper.GetDataSet(jtSTR, "tblJobTickets")
                    'Me.CreateTXTLog(ds)

                    'Dim NotepadPro As Process = New Process
                    'NotepadPro.Start("Notepad.exe", "C:\testprint.txt")


                    'Me.Print_JobTicket(ds)
                    Dim objR As New rpt_JobTicket_Multistop_new
                    'Dim pkCustomSize1 As New CrystalDecisions.Shared.PaperSize
                    'pkCustomSize1 = PaperStatement
                    'objR.PrintOptions.PaperSize = pkCustomSize1.PaperEnvelopeB6
                    objR.SetDataSource(ds)
                    DBHelper.Authenticate(objR)
                    Dim frmR As New frmReport
                    frmR.Text = "Job Tickets(s)"
                    frmR.WindowState = FormWindowState.Maximized
                    frmR.CrystalReportViewer1.ReportSource = objR
                    frmR.CrystalReportViewer1.RefreshReport()
                    frmR.ShowDialog()
                    frmR = Nothing
                End If
            End If
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
        Finally
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

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
        Dim strfilePath As String = "C:\a.txt"
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

                'objFile.WriteLine(Microsoft.VisualBasic.vbCrLf)
                'objFile.WriteLine(Microsoft.VisualBasic.vbCrLf)
                'objFile.WriteLine(Microsoft.VisualBasic.vbCrLf)
                objFile.NewLine = 1
                objFile.WriteLine("     " & ScheduleDate.ToShortDateString.ToString & "          " & strGeneratorName.ToString.Trim)
                objFile.WriteLine("        " & strJobSite.ToString.Trim & "")
                objFile.WriteLine("        " & strJobSiteAddress1.ToString.Trim & "")
                objFile.WriteLine("        " & StrJobSiteCSZ.ToString.Trim & "")
                objFile.WriteLine("     " & strJobPO.ToString.Trim & "        " & strAttn.ToString.Trim)
                objFile.WriteLine("        " & strTransporterName.ToString.Trim & "")
                objFile.WriteLine("        " & strTruckNo.ToString.Trim & "               " & strDriverName.ToString.Trim)
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
