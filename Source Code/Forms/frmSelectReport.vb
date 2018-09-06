Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO
Imports System.Text
Public Class frmSelectReport
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gpJobActivity As System.Windows.Forms.GroupBox
    Friend WithEvents gpReceivables As System.Windows.Forms.GroupBox
    Friend WithEvents gpDateRange As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbJReportBy As System.Windows.Forms.ComboBox
    Friend WithEvents btnJActivityReport As System.Windows.Forms.Button
    Friend WithEvents cmbRReportBy As System.Windows.Forms.ComboBox
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DAJobActivity As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents SelectJobActivity As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsJobActivity1 As BeaverOil.DSJobActivity
    Friend WithEvents DAInvoicing As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsInvoicingReport1 As BeaverOil.DSInvoicingReport
    Friend WithEvents btnRAll As System.Windows.Forms.Button
    Friend WithEvents DAReceivables As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsReceivablesReport1 As BeaverOil.DSReceivablesReport
    Friend WithEvents cmbReportByCriteria As System.Windows.Forms.ComboBox
    Friend WithEvents lblProductLabel As System.Windows.Forms.Label
    Friend WithEvents lblReportBy As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbHaz As System.Windows.Forms.ComboBox
    Friend WithEvents IsNonHaz As System.Windows.Forms.RadioButton
    Friend WithEvents IsHaz As System.Windows.Forms.RadioButton
    Friend WithEvents IsBoth As System.Windows.Forms.RadioButton
    Friend WithEvents grpPayable As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbPReportBy As System.Windows.Forms.ComboBox
    Friend WithEvents DAPayables As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents SelectPayables As System.Data.OleDb.OleDbCommand
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbVendor As System.Windows.Forms.ComboBox
    Friend WithEvents btnCheckRegister As System.Windows.Forms.Button
    Friend WithEvents DsCheckRegister1 As BeaverOil.DSCheckRegister
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnPrintInvoice As System.Windows.Forms.Button
    Friend WithEvents cmbInvoices As System.Windows.Forms.ComboBox
    Friend WithEvents grpInvoices As System.Windows.Forms.GroupBox
    Friend WithEvents grpLoads As System.Windows.Forms.GroupBox
    Friend WithEvents btnHazLoads As System.Windows.Forms.Button
    Friend WithEvents btnManifests As System.Windows.Forms.Button
    Friend WithEvents btnBOLs As System.Windows.Forms.Button
    Friend WithEvents btnManifestsInHouse As System.Windows.Forms.Button
    Friend WithEvents DAHazardous As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents SelectHazardous As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsepA_HazardousLoads1 As BeaverOil.DSEPA_HazardousLoads
    Friend WithEvents DAManifests As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents SelectManifests As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsepA_Manifests1 As BeaverOil.DSEPA_Manifests
    Friend WithEvents DABOLs As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents SelectBOLs As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsepA_BOLs1 As BeaverOil.DSEPA_BOLs
    Friend WithEvents DAInHouseManifests As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents SelectInHouseManifests As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsInHouseManifests1 As BeaverOil.DSInHouseManifests
    Friend WithEvents btnMulti As System.Windows.Forms.Button
    Friend WithEvents TODate As System.Windows.Forms.DateTimePicker
    Friend WithEvents FROMDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection2 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DsDailyHazNonHaz1 As BeaverOil.dsDailyHazNonHaz
    Friend WithEvents btnMultiStop_Daily As System.Windows.Forms.Button
    Friend WithEvents btnGaryPlant_Daily As System.Windows.Forms.Button
    Friend WithEvents btnBOL_Daily As System.Windows.Forms.Button
    Friend WithEvents btnNonHazardous_Daily As System.Windows.Forms.Button
    Friend WithEvents btnFESTLog As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnMWRDReport As System.Windows.Forms.Button
    Friend WithEvents btnHAZReport As System.Windows.Forms.Button
    Friend WithEvents btnGeneratorReport As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkExcelReport As System.Windows.Forms.CheckBox
    Friend WithEvents dotMatrix As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents EndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents grpSelectProduct As System.Windows.Forms.GroupBox
    Friend WithEvents Fill_Customer As System.Windows.Forms.TextBox
    Friend WithEvents Fil_City As System.Windows.Forms.TextBox
    Friend WithEvents Fil_Address As System.Windows.Forms.TextBox
    Friend WithEvents Fill_JobSite As System.Windows.Forms.TextBox
    Friend WithEvents dgSearchProduct As System.Windows.Forms.DataGrid
    Friend WithEvents lblBorder As System.Windows.Forms.Label
    Friend WithEvents DsNewJobSearch1 As BeaverOil.DSNewJobSearch
    Friend WithEvents btnSelectGen As System.Windows.Forms.Button
    Friend WithEvents chkProduct As System.Windows.Forms.CheckedListBox
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents DsCustomerReport1 As BeaverOil.DSCustomerReport
    Friend WithEvents dgCustomer As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents Fill_JobSite_C As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridBoolColumn2 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnCustomerReport As System.Windows.Forms.Button
    Friend WithEvents DataGridTS As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CustDate1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CustDate2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fill_JobSiteAdd_C As System.Windows.Forms.TextBox
    Friend WithEvents Fill_JobSiteCity_C As System.Windows.Forms.TextBox
    Friend WithEvents Fill_Approval_C As System.Windows.Forms.TextBox
    Friend WithEvents Fill_Product_C As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gpJobActivity = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.IsBoth = New System.Windows.Forms.RadioButton
        Me.IsHaz = New System.Windows.Forms.RadioButton
        Me.IsNonHaz = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbHaz = New System.Windows.Forms.ComboBox
        Me.lblReportBy = New System.Windows.Forms.Label
        Me.cmbReportByCriteria = New System.Windows.Forms.ComboBox
        Me.btnJActivityReport = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbJReportBy = New System.Windows.Forms.ComboBox
        Me.gpReceivables = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbRReportBy = New System.Windows.Forms.ComboBox
        Me.btnRAll = New System.Windows.Forms.Button
        Me.gpDateRange = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.FROMDate = New System.Windows.Forms.DateTimePicker
        Me.TODate = New System.Windows.Forms.DateTimePicker
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.DAJobActivity = New System.Data.OleDb.OleDbDataAdapter
        Me.SelectJobActivity = New System.Data.OleDb.OleDbCommand
        Me.DsJobActivity1 = New BeaverOil.DSJobActivity
        Me.DAInvoicing = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand
        Me.DsInvoicingReport1 = New BeaverOil.DSInvoicingReport
        Me.DAReceivables = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbCommand3 = New System.Data.OleDb.OleDbCommand
        Me.DsReceivablesReport1 = New BeaverOil.DSReceivablesReport
        Me.lblProductLabel = New System.Windows.Forms.Label
        Me.grpPayable = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbVendor = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbPReportBy = New System.Windows.Forms.ComboBox
        Me.btnCheckRegister = New System.Windows.Forms.Button
        Me.DAPayables = New System.Data.OleDb.OleDbDataAdapter
        Me.SelectPayables = New System.Data.OleDb.OleDbCommand
        Me.DsCheckRegister1 = New BeaverOil.DSCheckRegister
        Me.grpInvoices = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmbInvoices = New System.Windows.Forms.ComboBox
        Me.btnPrintInvoice = New System.Windows.Forms.Button
        Me.grpLoads = New System.Windows.Forms.GroupBox
        Me.dotMatrix = New System.Windows.Forms.Button
        Me.chkExcelReport = New System.Windows.Forms.CheckBox
        Me.btnMulti = New System.Windows.Forms.Button
        Me.btnManifestsInHouse = New System.Windows.Forms.Button
        Me.btnBOLs = New System.Windows.Forms.Button
        Me.btnManifests = New System.Windows.Forms.Button
        Me.btnHazLoads = New System.Windows.Forms.Button
        Me.btnFESTLog = New System.Windows.Forms.Button
        Me.btnGeneratorReport = New System.Windows.Forms.Button
        Me.btnHAZReport = New System.Windows.Forms.Button
        Me.btnMWRDReport = New System.Windows.Forms.Button
        Me.DAHazardous = New System.Data.OleDb.OleDbDataAdapter
        Me.SelectHazardous = New System.Data.OleDb.OleDbCommand
        Me.DsepA_HazardousLoads1 = New BeaverOil.DSEPA_HazardousLoads
        Me.DAManifests = New System.Data.OleDb.OleDbDataAdapter
        Me.SelectManifests = New System.Data.OleDb.OleDbCommand
        Me.DsepA_Manifests1 = New BeaverOil.DSEPA_Manifests
        Me.DABOLs = New System.Data.OleDb.OleDbDataAdapter
        Me.SelectBOLs = New System.Data.OleDb.OleDbCommand
        Me.DsepA_BOLs1 = New BeaverOil.DSEPA_BOLs
        Me.DAInHouseManifests = New System.Data.OleDb.OleDbDataAdapter
        Me.SelectInHouseManifests = New System.Data.OleDb.OleDbCommand
        Me.DsInHouseManifests1 = New BeaverOil.DSInHouseManifests
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnMultiStop_Daily = New System.Windows.Forms.Button
        Me.btnGaryPlant_Daily = New System.Windows.Forms.Button
        Me.btnBOL_Daily = New System.Windows.Forms.Button
        Me.btnNonHazardous_Daily = New System.Windows.Forms.Button
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection2 = New System.Data.OleDb.OleDbConnection
        Me.DsDailyHazNonHaz1 = New BeaverOil.dsDailyHazNonHaz
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.grpSelectProduct = New System.Windows.Forms.GroupBox
        Me.btnSelectGen = New System.Windows.Forms.Button
        Me.Fill_Customer = New System.Windows.Forms.TextBox
        Me.Fil_City = New System.Windows.Forms.TextBox
        Me.Fil_Address = New System.Windows.Forms.TextBox
        Me.Fill_JobSite = New System.Windows.Forms.TextBox
        Me.dgSearchProduct = New System.Windows.Forms.DataGrid
        Me.DsNewJobSearch1 = New BeaverOil.DSNewJobSearch
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn
        Me.lblBorder = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.chkProduct = New System.Windows.Forms.CheckedListBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.StartDate = New System.Windows.Forms.DateTimePicker
        Me.EndDate = New System.Windows.Forms.DateTimePicker
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnSelect = New System.Windows.Forms.Button
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Fill_JobSiteAdd_C = New System.Windows.Forms.TextBox
        Me.cmbCustomer = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Fill_JobSiteCity_C = New System.Windows.Forms.TextBox
        Me.Fill_Approval_C = New System.Windows.Forms.TextBox
        Me.Fill_Product_C = New System.Windows.Forms.TextBox
        Me.Fill_JobSite_C = New System.Windows.Forms.TextBox
        Me.dgCustomer = New System.Windows.Forms.DataGrid
        Me.DsCustomerReport1 = New BeaverOil.DSCustomerReport
        Me.DataGridTS = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridBoolColumn2 = New System.Windows.Forms.DataGridBoolColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnCustomerReport = New System.Windows.Forms.Button
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.CustDate1 = New System.Windows.Forms.DateTimePicker
        Me.CustDate2 = New System.Windows.Forms.DateTimePicker
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.gpJobActivity.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gpReceivables.SuspendLayout()
        Me.gpDateRange.SuspendLayout()
        CType(Me.DsJobActivity1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsInvoicingReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsReceivablesReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPayable.SuspendLayout()
        CType(Me.DsCheckRegister1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInvoices.SuspendLayout()
        Me.grpLoads.SuspendLayout()
        CType(Me.DsepA_HazardousLoads1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsepA_Manifests1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsepA_BOLs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsInHouseManifests1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DsDailyHazNonHaz1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpSelectProduct.SuspendLayout()
        CType(Me.dgSearchProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNewJobSearch1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCustomerReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpJobActivity
        '
        Me.gpJobActivity.Controls.Add(Me.GroupBox1)
        Me.gpJobActivity.Controls.Add(Me.Label7)
        Me.gpJobActivity.Controls.Add(Me.cmbHaz)
        Me.gpJobActivity.Controls.Add(Me.lblReportBy)
        Me.gpJobActivity.Controls.Add(Me.cmbReportByCriteria)
        Me.gpJobActivity.Controls.Add(Me.btnJActivityReport)
        Me.gpJobActivity.Controls.Add(Me.Label5)
        Me.gpJobActivity.Controls.Add(Me.cmbJReportBy)
        Me.gpJobActivity.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gpJobActivity.Location = New System.Drawing.Point(292, 286)
        Me.gpJobActivity.Name = "gpJobActivity"
        Me.gpJobActivity.Size = New System.Drawing.Size(258, 50)
        Me.gpJobActivity.TabIndex = 1
        Me.gpJobActivity.TabStop = False
        Me.gpJobActivity.Text = "Job Activity"
        Me.gpJobActivity.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IsBoth)
        Me.GroupBox1.Controls.Add(Me.IsHaz)
        Me.GroupBox1.Controls.Add(Me.IsNonHaz)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 1.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(126, 68)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'IsBoth
        '
        Me.IsBoth.Checked = True
        Me.IsBoth.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsBoth.Location = New System.Drawing.Point(10, 8)
        Me.IsBoth.Name = "IsBoth"
        Me.IsBoth.Size = New System.Drawing.Size(48, 16)
        Me.IsBoth.TabIndex = 4
        Me.IsBoth.TabStop = True
        Me.IsBoth.Text = "Both"
        '
        'IsHaz
        '
        Me.IsHaz.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsHaz.Location = New System.Drawing.Point(10, 26)
        Me.IsHaz.Name = "IsHaz"
        Me.IsHaz.Size = New System.Drawing.Size(88, 16)
        Me.IsHaz.TabIndex = 5
        Me.IsHaz.Text = "Hazardous"
        '
        'IsNonHaz
        '
        Me.IsNonHaz.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsNonHaz.Location = New System.Drawing.Point(8, 46)
        Me.IsNonHaz.Name = "IsNonHaz"
        Me.IsNonHaz.Size = New System.Drawing.Size(112, 16)
        Me.IsNonHaz.TabIndex = 6
        Me.IsNonHaz.Text = "Non-Hazardous"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(234, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Select a Hazardous Code:"
        '
        'cmbHaz
        '
        Me.cmbHaz.Enabled = False
        Me.cmbHaz.Location = New System.Drawing.Point(10, 222)
        Me.cmbHaz.Name = "cmbHaz"
        Me.cmbHaz.Size = New System.Drawing.Size(246, 21)
        Me.cmbHaz.TabIndex = 7
        '
        'lblReportBy
        '
        Me.lblReportBy.BackColor = System.Drawing.Color.White
        Me.lblReportBy.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportBy.Location = New System.Drawing.Point(12, 84)
        Me.lblReportBy.Name = "lblReportBy"
        Me.lblReportBy.Size = New System.Drawing.Size(200, 16)
        Me.lblReportBy.TabIndex = 6
        Me.lblReportBy.Text = "Select a Type of Waste:"
        '
        'cmbReportByCriteria
        '
        Me.cmbReportByCriteria.Items.AddRange(New Object() {"Type of Waste", "Generator", "Site"})
        Me.cmbReportByCriteria.Location = New System.Drawing.Point(12, 100)
        Me.cmbReportByCriteria.Name = "cmbReportByCriteria"
        Me.cmbReportByCriteria.Size = New System.Drawing.Size(242, 21)
        Me.cmbReportByCriteria.TabIndex = 3
        '
        'btnJActivityReport
        '
        Me.btnJActivityReport.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnJActivityReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJActivityReport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJActivityReport.Location = New System.Drawing.Point(48, 24)
        Me.btnJActivityReport.Name = "btnJActivityReport"
        Me.btnJActivityReport.Size = New System.Drawing.Size(152, 24)
        Me.btnJActivityReport.TabIndex = 1
        Me.btnJActivityReport.Text = "Activity"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Report By:"
        '
        'cmbJReportBy
        '
        Me.cmbJReportBy.Items.AddRange(New Object() {"Type of Waste", "Customer", "Generator"})
        Me.cmbJReportBy.Location = New System.Drawing.Point(86, 52)
        Me.cmbJReportBy.Name = "cmbJReportBy"
        Me.cmbJReportBy.Size = New System.Drawing.Size(152, 21)
        Me.cmbJReportBy.TabIndex = 2
        Me.cmbJReportBy.Text = "Type of Waste"
        '
        'gpReceivables
        '
        Me.gpReceivables.Controls.Add(Me.Label6)
        Me.gpReceivables.Controls.Add(Me.cmbRReportBy)
        Me.gpReceivables.Controls.Add(Me.btnRAll)
        Me.gpReceivables.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gpReceivables.Location = New System.Drawing.Point(12, 62)
        Me.gpReceivables.Name = "gpReceivables"
        Me.gpReceivables.Size = New System.Drawing.Size(270, 84)
        Me.gpReceivables.TabIndex = 2
        Me.gpReceivables.TabStop = False
        Me.gpReceivables.Text = "Receivables"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Report By:"
        '
        'cmbRReportBy
        '
        Me.cmbRReportBy.Items.AddRange(New Object() {"Client", "Invoice Date"})
        Me.cmbRReportBy.Location = New System.Drawing.Point(80, 20)
        Me.cmbRReportBy.Name = "cmbRReportBy"
        Me.cmbRReportBy.Size = New System.Drawing.Size(144, 21)
        Me.cmbRReportBy.TabIndex = 2
        Me.cmbRReportBy.Text = "Client"
        '
        'btnRAll
        '
        Me.btnRAll.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnRAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRAll.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRAll.Location = New System.Drawing.Point(82, 46)
        Me.btnRAll.Name = "btnRAll"
        Me.btnRAll.Size = New System.Drawing.Size(144, 24)
        Me.btnRAll.TabIndex = 1
        Me.btnRAll.Text = "Receivables"
        '
        'gpDateRange
        '
        Me.gpDateRange.Controls.Add(Me.Label2)
        Me.gpDateRange.Controls.Add(Me.Label1)
        Me.gpDateRange.Controls.Add(Me.FROMDate)
        Me.gpDateRange.Controls.Add(Me.TODate)
        Me.gpDateRange.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gpDateRange.Location = New System.Drawing.Point(52, 8)
        Me.gpDateRange.Name = "gpDateRange"
        Me.gpDateRange.Size = New System.Drawing.Size(400, 42)
        Me.gpDateRange.TabIndex = 0
        Me.gpDateRange.TabStop = False
        Me.gpDateRange.Text = "Date Range"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(208, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "End Date:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Start Date:"
        '
        'FROMDate
        '
        Me.FROMDate.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FROMDate.Location = New System.Drawing.Point(80, 16)
        Me.FROMDate.Name = "FROMDate"
        Me.FROMDate.Size = New System.Drawing.Size(120, 20)
        Me.FROMDate.TabIndex = 33
        '
        'TODate
        '
        Me.TODate.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TODate.Location = New System.Drawing.Point(272, 16)
        Me.TODate.Name = "TODate"
        Me.TODate.Size = New System.Drawing.Size(120, 20)
        Me.TODate.TabIndex = 34
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Data Source=""C:\Documents and Settings\Patel\Desktop\BeaverOil\VB." & _
        "NET Source Code\bin\JobTrackingSystem.mdb"";Mode=Share Deny None;Jet OLEDB:Engine" & _
        " Type=5;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:" & _
        "SFP=False;persist security info=False;Extended Properties=;Jet OLEDB:Compact Wit" & _
        "hout Replica Repair=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create Syst" & _
        "em Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;User ID=Admin;Jet" & _
        " OLEDB:Global Bulk Transactions=1"
        '
        'DAJobActivity
        '
        Me.DAJobActivity.SelectCommand = Me.SelectJobActivity
        Me.DAJobActivity.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblJobActivity", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("JobSite", "JobSite"), New System.Data.Common.DataColumnMapping("JobTicketNo", "JobTicketNo"), New System.Data.Common.DataColumnMapping("JobTicketDate", "JobTicketDate"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("GeneratorName", "GeneratorName"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("ManifestNo", "ManifestNo"), New System.Data.Common.DataColumnMapping("PermitNo", "PermitNo")})})
        '
        'SelectJobActivity
        '
        Me.SelectJobActivity.CommandText = "SELECT tblGenerators.JobSite, tblJobTickets.JobTicketNo, tblJobTickets.JobTicketD" & _
        "ate, tblProducts.ProductName, tblGenerators.GeneratorName, tblJobTickets_Details" & _
        ".Quantity, tblJobTickets.ManifestNo, tblProducts.PermitNo FROM (((tblProducts IN" & _
        "NER JOIN tblGenerators ON tblProducts.GeneratorID = tblGenerators.GeneratorID) I" & _
        "NNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) INNE" & _
        "R JOIN tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Detail" & _
        "s.JobTicketID) ORDER BY tblJobTickets.JobTicketDate, tblGenerators.GeneratorName" & _
        ", tblProducts.ProductName"
        Me.SelectJobActivity.Connection = Me.OleDbConnection1
        '
        'DsJobActivity1
        '
        Me.DsJobActivity1.DataSetName = "DSJobActivity"
        Me.DsJobActivity1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DAInvoicing
        '
        Me.DAInvoicing.SelectCommand = Me.OleDbCommand1
        Me.DAInvoicing.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblInvoicing", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GeneratorName", "GeneratorName"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("JobTicketNo", "JobTicketNo"), New System.Data.Common.DataColumnMapping("JobTicketDate", "JobTicketDate"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("InvoiceNo", "InvoiceNo"), New System.Data.Common.DataColumnMapping("InvoiceDate", "InvoiceDate"), New System.Data.Common.DataColumnMapping("InvoiceAmount", "InvoiceAmount"), New System.Data.Common.DataColumnMapping("Invoiced", "Invoiced"), New System.Data.Common.DataColumnMapping("PaymentReceived", "PaymentReceived")})})
        '
        'OleDbCommand1
        '
        Me.OleDbCommand1.CommandText = "SELECT tblGenerators.GeneratorName, tblProducts.ProductName, tblJobTickets.JobTic" & _
        "ketNo, tblJobTickets.JobTicketDate, tblJobTickets_Details.Quantity, tblJobTicket" & _
        "s_Details.Description, tblInvoicing.InvoiceNo, tblInvoicing.InvoiceDate, tblInvo" & _
        "icing.InvoiceAmount, tblInvoicing.Invoiced, tblInvoicing.PaymentReceived FROM ((" & _
        "((tblJobTickets INNER JOIN tblProducts ON tblJobTickets.ProductID = tblProducts." & _
        "ProductID) INNER JOIN tblGenerators ON tblProducts.GeneratorID = tblGenerators.G" & _
        "eneratorID) INNER JOIN tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJ" & _
        "obTickets_Details.JobTicketID) LEFT OUTER JOIN tblInvoicing ON tblJobTickets.Job" & _
        "TicketID = tblInvoicing.JobTicketID)"
        Me.OleDbCommand1.Connection = Me.OleDbConnection1
        '
        'DsInvoicingReport1
        '
        Me.DsInvoicingReport1.DataSetName = "DSInvoicingReport"
        Me.DsInvoicingReport1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DAReceivables
        '
        Me.DAReceivables.SelectCommand = Me.OleDbCommand3
        Me.DAReceivables.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblInvoicing", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("JobTicketDate", "JobTicketDate"), New System.Data.Common.DataColumnMapping("GeneratorName", "GeneratorName"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("JobTicketNo", "JobTicketNo"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("InvoiceAmount", "InvoiceAmount"), New System.Data.Common.DataColumnMapping("CheckAmount", "CheckAmount"), New System.Data.Common.DataColumnMapping("CheckDate", "CheckDate"), New System.Data.Common.DataColumnMapping("CheckNo", "CheckNo"), New System.Data.Common.DataColumnMapping("PaymentReceived", "PaymentReceived")})})
        '
        'OleDbCommand3
        '
        Me.OleDbCommand3.CommandText = "SELECT tblJobTickets.JobTicketDate, tblGenerators.GeneratorName, tblProducts.Prod" & _
        "uctName, tblJobTickets.JobTicketNo, tblJobTickets_Details.Quantity, tblInvoicing" & _
        ".InvoiceAmount, tblInvoicing.CheckAmount, tblInvoicing.CheckDate, tblInvoicing.C" & _
        "heckNo, tblInvoicing.PaymentReceived FROM ((((tblJobTickets INNER JOIN tblProduc" & _
        "ts ON tblJobTickets.ProductID = tblProducts.ProductID) INNER JOIN tblGenerators " & _
        "ON tblProducts.GeneratorID = tblGenerators.GeneratorID) INNER JOIN tblJobTickets" & _
        "_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) INNER" & _
        " JOIN tblInvoicing ON tblJobTickets.JobTicketID = tblInvoicing.JobTicketID)"
        Me.OleDbCommand3.Connection = Me.OleDbConnection1
        '
        'DsReceivablesReport1
        '
        Me.DsReceivablesReport1.DataSetName = "DSReceivablesReport"
        Me.DsReceivablesReport1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'lblProductLabel
        '
        Me.lblProductLabel.Font = New System.Drawing.Font("Verdana", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductLabel.Location = New System.Drawing.Point(120, 8)
        Me.lblProductLabel.Name = "lblProductLabel"
        Me.lblProductLabel.Size = New System.Drawing.Size(296, 24)
        Me.lblProductLabel.TabIndex = 32
        Me.lblProductLabel.Text = "Reports:"
        Me.lblProductLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grpPayable
        '
        Me.grpPayable.Controls.Add(Me.Label9)
        Me.grpPayable.Controls.Add(Me.cmbVendor)
        Me.grpPayable.Controls.Add(Me.Label8)
        Me.grpPayable.Controls.Add(Me.cmbPReportBy)
        Me.grpPayable.Controls.Add(Me.btnCheckRegister)
        Me.grpPayable.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpPayable.Location = New System.Drawing.Point(292, 152)
        Me.grpPayable.Name = "grpPayable"
        Me.grpPayable.Size = New System.Drawing.Size(260, 122)
        Me.grpPayable.TabIndex = 3
        Me.grpPayable.TabStop = False
        Me.grpPayable.Text = "Payables"
        Me.grpPayable.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(200, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Select a Vendor:"
        '
        'cmbVendor
        '
        Me.cmbVendor.Items.AddRange(New Object() {"Type of Waste", "Generator", "Site"})
        Me.cmbVendor.Location = New System.Drawing.Point(6, 60)
        Me.cmbVendor.Name = "cmbVendor"
        Me.cmbVendor.Size = New System.Drawing.Size(246, 21)
        Me.cmbVendor.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Report By:"
        '
        'cmbPReportBy
        '
        Me.cmbPReportBy.Items.AddRange(New Object() {"Date", "Vendor"})
        Me.cmbPReportBy.Location = New System.Drawing.Point(84, 16)
        Me.cmbPReportBy.Name = "cmbPReportBy"
        Me.cmbPReportBy.Size = New System.Drawing.Size(126, 21)
        Me.cmbPReportBy.TabIndex = 2
        Me.cmbPReportBy.Text = "Date"
        '
        'btnCheckRegister
        '
        Me.btnCheckRegister.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCheckRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckRegister.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckRegister.Location = New System.Drawing.Point(82, 86)
        Me.btnCheckRegister.Name = "btnCheckRegister"
        Me.btnCheckRegister.Size = New System.Drawing.Size(152, 24)
        Me.btnCheckRegister.TabIndex = 1
        Me.btnCheckRegister.Text = "Check Register"
        '
        'DAPayables
        '
        Me.DAPayables.SelectCommand = Me.SelectPayables
        Me.DAPayables.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblPayables", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Beaver_CheckDate", "Beaver_CheckDate"), New System.Data.Common.DataColumnMapping("Beaver_CheckNo", "Beaver_CheckNo"), New System.Data.Common.DataColumnMapping("VendorName", "VendorName"), New System.Data.Common.DataColumnMapping("Beaver_CheckAmount", "Beaver_CheckAmount"), New System.Data.Common.DataColumnMapping("Beaver_Desc", "Beaver_Desc"), New System.Data.Common.DataColumnMapping("VendorAddress1", "VendorAddress1"), New System.Data.Common.DataColumnMapping("VendorCity", "VendorCity"), New System.Data.Common.DataColumnMapping("VendorState", "VendorState"), New System.Data.Common.DataColumnMapping("VendorZip", "VendorZip")})})
        '
        'SelectPayables
        '
        Me.SelectPayables.CommandText = "SELECT tblPayables.Beaver_CheckDate, tblPayables.Beaver_CheckNo, tblVendors.Vendo" & _
        "rName, tblPayables.Beaver_CheckAmount, tblPayables.Beaver_Desc, tblVendors.Vendo" & _
        "rAddress1, tblVendors.VendorCity, tblVendors.VendorState, tblVendors.VendorZip F" & _
        "ROM (tblVendors INNER JOIN tblPayables ON tblVendors.VendorID = tblPayables.Vend" & _
        "orID)"
        Me.SelectPayables.Connection = Me.OleDbConnection1
        '
        'DsCheckRegister1
        '
        Me.DsCheckRegister1.DataSetName = "DSCheckRegister"
        Me.DsCheckRegister1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'grpInvoices
        '
        Me.grpInvoices.Controls.Add(Me.Label10)
        Me.grpInvoices.Controls.Add(Me.cmbInvoices)
        Me.grpInvoices.Controls.Add(Me.btnPrintInvoice)
        Me.grpInvoices.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpInvoices.Location = New System.Drawing.Point(292, 64)
        Me.grpInvoices.Name = "grpInvoices"
        Me.grpInvoices.Size = New System.Drawing.Size(270, 78)
        Me.grpInvoices.TabIndex = 4
        Me.grpInvoices.TabStop = False
        Me.grpInvoices.Text = "Invoices"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Select an Invoice:"
        '
        'cmbInvoices
        '
        Me.cmbInvoices.Location = New System.Drawing.Point(118, 20)
        Me.cmbInvoices.Name = "cmbInvoices"
        Me.cmbInvoices.Size = New System.Drawing.Size(128, 21)
        Me.cmbInvoices.TabIndex = 2
        '
        'btnPrintInvoice
        '
        Me.btnPrintInvoice.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPrintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintInvoice.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintInvoice.Location = New System.Drawing.Point(82, 46)
        Me.btnPrintInvoice.Name = "btnPrintInvoice"
        Me.btnPrintInvoice.Size = New System.Drawing.Size(144, 24)
        Me.btnPrintInvoice.TabIndex = 1
        Me.btnPrintInvoice.Text = "Print an Invoice"
        '
        'grpLoads
        '
        Me.grpLoads.Controls.Add(Me.dotMatrix)
        Me.grpLoads.Controls.Add(Me.chkExcelReport)
        Me.grpLoads.Controls.Add(Me.btnMulti)
        Me.grpLoads.Controls.Add(Me.btnManifestsInHouse)
        Me.grpLoads.Controls.Add(Me.btnBOLs)
        Me.grpLoads.Controls.Add(Me.btnManifests)
        Me.grpLoads.Controls.Add(Me.btnHazLoads)
        Me.grpLoads.Controls.Add(Me.btnFESTLog)
        Me.grpLoads.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpLoads.Location = New System.Drawing.Point(12, 154)
        Me.grpLoads.Name = "grpLoads"
        Me.grpLoads.Size = New System.Drawing.Size(268, 224)
        Me.grpLoads.TabIndex = 4
        Me.grpLoads.TabStop = False
        Me.grpLoads.Text = "Loads Activity"
        '
        'dotMatrix
        '
        Me.dotMatrix.BackColor = System.Drawing.Color.LightSteelBlue
        Me.dotMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dotMatrix.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dotMatrix.ForeColor = System.Drawing.Color.Red
        Me.dotMatrix.Location = New System.Drawing.Point(30, 196)
        Me.dotMatrix.Name = "dotMatrix"
        Me.dotMatrix.Size = New System.Drawing.Size(208, 24)
        Me.dotMatrix.TabIndex = 37
        Me.dotMatrix.Text = "FEST Log [DOT MATRIX RPT]"
        '
        'chkExcelReport
        '
        Me.chkExcelReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkExcelReport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkExcelReport.ForeColor = System.Drawing.Color.Blue
        Me.chkExcelReport.Location = New System.Drawing.Point(60, 20)
        Me.chkExcelReport.Name = "chkExcelReport"
        Me.chkExcelReport.Size = New System.Drawing.Size(148, 16)
        Me.chkExcelReport.TabIndex = 36
        Me.chkExcelReport.Text = "Export to Excel File"
        '
        'btnMulti
        '
        Me.btnMulti.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnMulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMulti.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMulti.Location = New System.Drawing.Point(30, 118)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(208, 24)
        Me.btnMulti.TabIndex = 5
        Me.btnMulti.Text = "Multi-Stop"
        '
        'btnManifestsInHouse
        '
        Me.btnManifestsInHouse.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnManifestsInHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManifestsInHouse.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManifestsInHouse.Location = New System.Drawing.Point(30, 144)
        Me.btnManifestsInHouse.Name = "btnManifestsInHouse"
        Me.btnManifestsInHouse.Size = New System.Drawing.Size(208, 24)
        Me.btnManifestsInHouse.TabIndex = 4
        Me.btnManifestsInHouse.Text = "Gary Plant"
        '
        'btnBOLs
        '
        Me.btnBOLs.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnBOLs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBOLs.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBOLs.Location = New System.Drawing.Point(30, 92)
        Me.btnBOLs.Name = "btnBOLs"
        Me.btnBOLs.Size = New System.Drawing.Size(208, 24)
        Me.btnBOLs.TabIndex = 3
        Me.btnBOLs.Text = "BOL"
        '
        'btnManifests
        '
        Me.btnManifests.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnManifests.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManifests.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManifests.Location = New System.Drawing.Point(30, 40)
        Me.btnManifests.Name = "btnManifests"
        Me.btnManifests.Size = New System.Drawing.Size(208, 24)
        Me.btnManifests.TabIndex = 2
        Me.btnManifests.Text = "Non-Hazardous"
        '
        'btnHazLoads
        '
        Me.btnHazLoads.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnHazLoads.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHazLoads.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHazLoads.Location = New System.Drawing.Point(30, 66)
        Me.btnHazLoads.Name = "btnHazLoads"
        Me.btnHazLoads.Size = New System.Drawing.Size(208, 24)
        Me.btnHazLoads.TabIndex = 1
        Me.btnHazLoads.Text = "Hazardous"
        '
        'btnFESTLog
        '
        Me.btnFESTLog.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnFESTLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFESTLog.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFESTLog.Location = New System.Drawing.Point(30, 170)
        Me.btnFESTLog.Name = "btnFESTLog"
        Me.btnFESTLog.Size = New System.Drawing.Size(208, 24)
        Me.btnFESTLog.TabIndex = 6
        Me.btnFESTLog.Text = "FEST Log"
        '
        'btnGeneratorReport
        '
        Me.btnGeneratorReport.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnGeneratorReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeneratorReport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGeneratorReport.Location = New System.Drawing.Point(272, 390)
        Me.btnGeneratorReport.Name = "btnGeneratorReport"
        Me.btnGeneratorReport.Size = New System.Drawing.Size(208, 24)
        Me.btnGeneratorReport.TabIndex = 7
        Me.btnGeneratorReport.Text = "Generator Report"
        '
        'btnHAZReport
        '
        Me.btnHAZReport.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnHAZReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHAZReport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHAZReport.Location = New System.Drawing.Point(6, 50)
        Me.btnHAZReport.Name = "btnHAZReport"
        Me.btnHAZReport.Size = New System.Drawing.Size(208, 24)
        Me.btnHAZReport.TabIndex = 1
        Me.btnHAZReport.Text = "HAZ Report"
        '
        'btnMWRDReport
        '
        Me.btnMWRDReport.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnMWRDReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMWRDReport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMWRDReport.Location = New System.Drawing.Point(6, 24)
        Me.btnMWRDReport.Name = "btnMWRDReport"
        Me.btnMWRDReport.Size = New System.Drawing.Size(208, 24)
        Me.btnMWRDReport.TabIndex = 1
        Me.btnMWRDReport.Text = "MWRD Report"
        '
        'DAHazardous
        '
        Me.DAHazardous.SelectCommand = Me.SelectHazardous
        Me.DAHazardous.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblInvoicing", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GeneratorName", "GeneratorName"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("JobTicketNo", "JobTicketNo"), New System.Data.Common.DataColumnMapping("JobTicketDate", "JobTicketDate"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("InvoiceNo", "InvoiceNo"), New System.Data.Common.DataColumnMapping("InvoiceDate", "InvoiceDate"), New System.Data.Common.DataColumnMapping("InvoiceAmount", "InvoiceAmount"), New System.Data.Common.DataColumnMapping("Invoiced", "Invoiced"), New System.Data.Common.DataColumnMapping("PaymentReceived", "PaymentReceived")})})
        '
        'SelectHazardous
        '
        Me.SelectHazardous.CommandText = "SELECT tblJobTickets.ScheduleDate, tblJobTickets.ManifestNo, tblGenerators.GNo AS" & _
        " GenNo, tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobS" & _
        "iteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, tblJobTickets_Det" & _
        "ails.Quantity, tblProducts.HWNumber FROM (((tblGenerators INNER JOIN tblProducts" & _
        " ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTicket" & _
        "s ON tblProducts.ProductID = tblJobTickets.ProductID) INNER JOIN tblJobTickets_D" & _
        "etails ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) ORDER B" & _
        "Y tblJobTickets.ScheduleDate"
        Me.SelectHazardous.Connection = Me.OleDbConnection1
        '
        'DsepA_HazardousLoads1
        '
        Me.DsepA_HazardousLoads1.DataSetName = "DSEPA_HazardousLoads"
        Me.DsepA_HazardousLoads1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DAManifests
        '
        Me.DAManifests.SelectCommand = Me.SelectManifests
        Me.DAManifests.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblInvoicing", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GeneratorName", "GeneratorName"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("JobTicketNo", "JobTicketNo"), New System.Data.Common.DataColumnMapping("JobTicketDate", "JobTicketDate"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("InvoiceNo", "InvoiceNo"), New System.Data.Common.DataColumnMapping("InvoiceDate", "InvoiceDate"), New System.Data.Common.DataColumnMapping("InvoiceAmount", "InvoiceAmount"), New System.Data.Common.DataColumnMapping("Invoiced", "Invoiced"), New System.Data.Common.DataColumnMapping("PaymentReceived", "PaymentReceived")})})
        '
        'SelectManifests
        '
        Me.SelectManifests.CommandText = "SELECT tblJobTickets.ScheduleDate, tblJobTickets.ManifestNo, tblGenerators.GNo AS" & _
        " GenNo, tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobS" & _
        "iteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, tblJobTickets_Det" & _
        "ails.Quantity, tblProducts.HWNumber, tblJobTickets.bsw, tblJobTickets.JobTicketN" & _
        "o, tblGenerators.BrokerName, tblProducts.ApprovalNo FROM (((tblGenerators INNER " & _
        "JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER J" & _
        "OIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) INNER JOIN" & _
        " tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobT" & _
        "icketID) WHERE (tblJobTickets.Hazardous = TRUE) OR (tblJobTickets.NonHazardous =" & _
        " TRUE) ORDER BY tblJobTickets.ScheduleDate"
        Me.SelectManifests.Connection = Me.OleDbConnection1
        '
        'DsepA_Manifests1
        '
        Me.DsepA_Manifests1.DataSetName = "DSEPA_Manifests"
        Me.DsepA_Manifests1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DABOLs
        '
        Me.DABOLs.SelectCommand = Me.SelectBOLs
        Me.DABOLs.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblInvoicing", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GeneratorName", "GeneratorName"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("JobTicketNo", "JobTicketNo"), New System.Data.Common.DataColumnMapping("JobTicketDate", "JobTicketDate"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("InvoiceNo", "InvoiceNo"), New System.Data.Common.DataColumnMapping("InvoiceDate", "InvoiceDate"), New System.Data.Common.DataColumnMapping("InvoiceAmount", "InvoiceAmount"), New System.Data.Common.DataColumnMapping("Invoiced", "Invoiced"), New System.Data.Common.DataColumnMapping("PaymentReceived", "PaymentReceived")})})
        '
        'SelectBOLs
        '
        Me.SelectBOLs.CommandText = "SELECT tblInvoicing.InvoiceNo, tblGenerators.GeneratorName, tblGenerators.JobSite" & _
        ", tblJobTickets.TicketNo, tblJobTickets_Details.Quantity, tblJobTickets.Manifest" & _
        "No, tblJobTickets.DisposalFacilityID FROM ((((tblGenerators INNER JOIN tblProduc" & _
        "ts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTick" & _
        "ets ON tblProducts.ProductID = tblJobTickets.ProductID) INNER JOIN tblJobTickets" & _
        "_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) LEFT " & _
        "OUTER JOIN tblInvoicing ON tblJobTickets.JobTicketID = tblInvoicing.JobTicketID)" & _
        " WHERE (tblJobTickets.BillOfLading = TRUE) ORDER BY tblGenerators.GeneratorName," & _
        " tblGenerators.JobSite, tblJobTickets.TicketNo"
        Me.SelectBOLs.Connection = Me.OleDbConnection1
        '
        'DsepA_BOLs1
        '
        Me.DsepA_BOLs1.DataSetName = "DSEPA_BOLs"
        Me.DsepA_BOLs1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DAInHouseManifests
        '
        Me.DAInHouseManifests.SelectCommand = Me.SelectInHouseManifests
        Me.DAInHouseManifests.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblInvoicing", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("InvoiceNo", "InvoiceNo"), New System.Data.Common.DataColumnMapping("GeneratorName", "GeneratorName"), New System.Data.Common.DataColumnMapping("JobSite", "JobSite"), New System.Data.Common.DataColumnMapping("JobSiteCity", "JobSiteCity"), New System.Data.Common.DataColumnMapping("ManifestNo", "ManifestNo"), New System.Data.Common.DataColumnMapping("TransporterName", "TransporterName"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("Drums", "Drums")})})
        '
        'SelectInHouseManifests
        '
        Me.SelectInHouseManifests.CommandText = "SELECT tblInvoicing.InvoiceNo, tblGenerators.GeneratorName, tblGenerators.JobSite" & _
        ", tblGenerators.JobSiteCity, tblJobTickets.ManifestNo, tblTransporters.Transport" & _
        "erName, tblJobTickets_Details.Quantity, tblJobTickets.Drums FROM (((((tblGenerat" & _
        "ors INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorI" & _
        "D) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) " & _
        "INNER JOIN tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_De" & _
        "tails.JobTicketID) INNER JOIN tblTransporters ON tblJobTickets.TransporterID = t" & _
        "blTransporters.TransporterID) LEFT OUTER JOIN tblInvoicing ON tblJobTickets.JobT" & _
        "icketID = tblInvoicing.JobTicketID) ORDER BY tblGenerators.GeneratorName, tblGen" & _
        "erators.JobSite"
        Me.SelectInHouseManifests.Connection = Me.OleDbConnection1
        '
        'DsInHouseManifests1
        '
        Me.DsInHouseManifests1.DataSetName = "DSInHouseManifests"
        Me.DsInHouseManifests1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnMultiStop_Daily)
        Me.GroupBox2.Controls.Add(Me.btnGaryPlant_Daily)
        Me.GroupBox2.Controls.Add(Me.btnBOL_Daily)
        Me.GroupBox2.Controls.Add(Me.btnNonHazardous_Daily)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(222, 132)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Daily Activity"
        '
        'btnMultiStop_Daily
        '
        Me.btnMultiStop_Daily.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnMultiStop_Daily.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMultiStop_Daily.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiStop_Daily.Location = New System.Drawing.Point(8, 76)
        Me.btnMultiStop_Daily.Name = "btnMultiStop_Daily"
        Me.btnMultiStop_Daily.Size = New System.Drawing.Size(208, 24)
        Me.btnMultiStop_Daily.TabIndex = 3
        Me.btnMultiStop_Daily.Text = "Multi-Stop"
        '
        'btnGaryPlant_Daily
        '
        Me.btnGaryPlant_Daily.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnGaryPlant_Daily.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGaryPlant_Daily.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGaryPlant_Daily.Location = New System.Drawing.Point(8, 102)
        Me.btnGaryPlant_Daily.Name = "btnGaryPlant_Daily"
        Me.btnGaryPlant_Daily.Size = New System.Drawing.Size(208, 24)
        Me.btnGaryPlant_Daily.TabIndex = 3
        Me.btnGaryPlant_Daily.Text = "Gary Plant"
        '
        'btnBOL_Daily
        '
        Me.btnBOL_Daily.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnBOL_Daily.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBOL_Daily.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBOL_Daily.Location = New System.Drawing.Point(8, 50)
        Me.btnBOL_Daily.Name = "btnBOL_Daily"
        Me.btnBOL_Daily.Size = New System.Drawing.Size(208, 24)
        Me.btnBOL_Daily.TabIndex = 2
        Me.btnBOL_Daily.Text = "BOL"
        '
        'btnNonHazardous_Daily
        '
        Me.btnNonHazardous_Daily.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnNonHazardous_Daily.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNonHazardous_Daily.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNonHazardous_Daily.Location = New System.Drawing.Point(8, 24)
        Me.btnNonHazardous_Daily.Name = "btnNonHazardous_Daily"
        Me.btnNonHazardous_Daily.Size = New System.Drawing.Size(208, 24)
        Me.btnNonHazardous_Daily.TabIndex = 1
        Me.btnNonHazardous_Daily.Text = "Non-Hazardous/Hazardous"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT DISTINCT tblJobTickets.JobTicketID, tblJobTickets.ManifestNo, tblJobTicket" & _
        "s.ScheduleDate, tblGenerators.GNo AS GenNo, tblGenerators.GeneratorName, tblGene" & _
        "rators.JobSiteAddress1, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, t" & _
        "blGenerators.JobSiteZip, SUM(tblJobTickets_Details.Quantity) AS Quantity, tblPro" & _
        "ducts.HWNumber, tblJobTickets.bsw, tblJobTickets.JobTicketNo, tblGenerators.Brok" & _
        "erName, tblProducts.ApprovalNo, tblTransporters.TransporterName AS TransporterNa" & _
        "me, tblGenerators.JobSite, tblJobTickets.WasteType, tblJobTickets.Drums, tblJobT" & _
        "ickets.TicketNo FROM (((tblGenerators LEFT JOIN tblProducts ON tblGenerators.Gen" & _
        "eratorID = tblProducts.GeneratorID) LEFT JOIN tblJobTickets ON tblProducts.Produ" & _
        "ctID = tblJobTickets.ProductID) LEFT JOIN tblTransporters ON tblJobTickets.Trans" & _
        "porterID = tblTransporters.TransporterID) LEFT JOIN tblJobTickets_Details ON tbl" & _
        "JobTickets.JobTicketID = tblJobTickets_Details.JobTicketID WHERE (((tblJobTicket" & _
        "s.WasteType) = 'Non HAZARDOUS') AND ((tblJobTickets.ScheduleDate) BETWEEN #2/1/2" & _
        "005# AND #8/9/2005#)) GROUP BY tblJobTickets.JobTicketID, tblJobTickets.Manifest" & _
        "No, tblJobTickets.ScheduleDate, tblGenerators.GNo, tblGenerators.GeneratorName, " & _
        "tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblGenerators.JobSiteS" & _
        "tate, tblGenerators.JobSiteZip, tblProducts.HWNumber, tblJobTickets.bsw, tblJobT" & _
        "ickets.JobTicketNo, tblGenerators.BrokerName, tblProducts.ApprovalNo, tblTranspo" & _
        "rters.TransporterName, tblGenerators.JobSite, tblJobTickets.WasteType, tblJobTic" & _
        "kets.Drums, tblJobTickets.TicketNo ORDER BY tblJobTickets.ScheduleDate;"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'DsDailyHazNonHaz1
        '
        Me.DsDailyHazNonHaz1.DataSetName = "dsDailyHazNonHaz"
        Me.DsDailyHazNonHaz1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 36)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(946, 526)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.grpSelectProduct)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.btnSelect)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(938, 497)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Daily/Monthly"
        '
        'grpSelectProduct
        '
        Me.grpSelectProduct.Controls.Add(Me.btnSelectGen)
        Me.grpSelectProduct.Controls.Add(Me.Fill_Customer)
        Me.grpSelectProduct.Controls.Add(Me.Fil_City)
        Me.grpSelectProduct.Controls.Add(Me.Fil_Address)
        Me.grpSelectProduct.Controls.Add(Me.Fill_JobSite)
        Me.grpSelectProduct.Controls.Add(Me.dgSearchProduct)
        Me.grpSelectProduct.Controls.Add(Me.lblBorder)
        Me.grpSelectProduct.Controls.Add(Me.GroupBox5)
        Me.grpSelectProduct.Controls.Add(Me.btnGeneratorReport)
        Me.grpSelectProduct.Controls.Add(Me.btnClear)
        Me.grpSelectProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpSelectProduct.Location = New System.Drawing.Point(238, 64)
        Me.grpSelectProduct.Name = "grpSelectProduct"
        Me.grpSelectProduct.Size = New System.Drawing.Size(690, 420)
        Me.grpSelectProduct.TabIndex = 4
        Me.grpSelectProduct.TabStop = False
        Me.grpSelectProduct.Text = "Select a Generator"
        '
        'btnSelectGen
        '
        Me.btnSelectGen.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSelectGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectGen.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectGen.Location = New System.Drawing.Point(240, 220)
        Me.btnSelectGen.Name = "btnSelectGen"
        Me.btnSelectGen.Size = New System.Drawing.Size(112, 22)
        Me.btnSelectGen.TabIndex = 40
        Me.btnSelectGen.Text = "Select"
        '
        'Fill_Customer
        '
        Me.Fill_Customer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fill_Customer.Location = New System.Drawing.Point(240, 12)
        Me.Fill_Customer.Name = "Fill_Customer"
        Me.Fill_Customer.Size = New System.Drawing.Size(158, 21)
        Me.Fill_Customer.TabIndex = 2
        Me.Fill_Customer.Text = ""
        '
        'Fil_City
        '
        Me.Fil_City.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fil_City.Location = New System.Drawing.Point(536, 12)
        Me.Fil_City.Name = "Fil_City"
        Me.Fil_City.Size = New System.Drawing.Size(122, 21)
        Me.Fil_City.TabIndex = 4
        Me.Fil_City.Text = ""
        '
        'Fil_Address
        '
        Me.Fil_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fil_Address.Location = New System.Drawing.Point(398, 12)
        Me.Fil_Address.Name = "Fil_Address"
        Me.Fil_Address.Size = New System.Drawing.Size(138, 21)
        Me.Fil_Address.TabIndex = 3
        Me.Fil_Address.Text = ""
        '
        'Fill_JobSite
        '
        Me.Fill_JobSite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fill_JobSite.Location = New System.Drawing.Point(46, 12)
        Me.Fill_JobSite.Name = "Fill_JobSite"
        Me.Fill_JobSite.Size = New System.Drawing.Size(194, 21)
        Me.Fill_JobSite.TabIndex = 1
        Me.Fill_JobSite.Text = ""
        '
        'dgSearchProduct
        '
        Me.dgSearchProduct.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.dgSearchProduct.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgSearchProduct.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgSearchProduct.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgSearchProduct.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgSearchProduct.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgSearchProduct.CaptionVisible = False
        Me.dgSearchProduct.DataMember = "tblGenerators"
        Me.dgSearchProduct.DataSource = Me.DsNewJobSearch1
        Me.dgSearchProduct.FlatMode = True
        Me.dgSearchProduct.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgSearchProduct.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dgSearchProduct.GridLineColor = System.Drawing.Color.Gainsboro
        Me.dgSearchProduct.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgSearchProduct.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgSearchProduct.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgSearchProduct.HeaderForeColor = System.Drawing.Color.Black
        Me.dgSearchProduct.LinkColor = System.Drawing.Color.Teal
        Me.dgSearchProduct.Location = New System.Drawing.Point(10, 36)
        Me.dgSearchProduct.Name = "dgSearchProduct"
        Me.dgSearchProduct.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dgSearchProduct.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.dgSearchProduct.RowHeaderWidth = 30
        Me.dgSearchProduct.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgSearchProduct.SelectionForeColor = System.Drawing.Color.Black
        Me.dgSearchProduct.Size = New System.Drawing.Size(668, 180)
        Me.dgSearchProduct.TabIndex = 5
        Me.dgSearchProduct.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DsNewJobSearch1
        '
        Me.DsNewJobSearch1.DataSetName = "DSNewJobSearch"
        Me.DsNewJobSearch1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridTableStyle1.DataGrid = Me.dgSearchProduct
        Me.DataGridTableStyle1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridBoolColumn1})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Black
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridTableStyle1.LinkColor = System.Drawing.Color.Teal
        Me.DataGridTableStyle1.MappingName = "tblGenerators"
        Me.DataGridTableStyle1.RowHeaderWidth = 30
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Generator"
        Me.DataGridTextBoxColumn1.MappingName = "JobSite"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 200
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Customer"
        Me.DataGridTextBoxColumn2.MappingName = "GeneratorName"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 160
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Address"
        Me.DataGridTextBoxColumn3.MappingName = "JobSiteAddress1"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 135
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "City"
        Me.DataGridTextBoxColumn4.MappingName = "JobSiteCity"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 125
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "GeneratorId"
        Me.DataGridTextBoxColumn5.MappingName = "GeneratorID"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 0
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "ProductID"
        Me.DataGridTextBoxColumn6.MappingName = "ProductID"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 0
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Product"
        Me.DataGridTextBoxColumn7.MappingName = "ProductName"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.ReadOnly = True
        Me.DataGridTextBoxColumn7.Width = 0
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Approval #"
        Me.DataGridTextBoxColumn8.MappingName = "ApprovalNo"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 0
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.FalseValue = False
        Me.DataGridBoolColumn1.HeaderText = "Select"
        Me.DataGridBoolColumn1.MappingName = "Status"
        Me.DataGridBoolColumn1.NullText = ""
        Me.DataGridBoolColumn1.NullValue = "false"
        Me.DataGridBoolColumn1.TrueValue = True
        Me.DataGridBoolColumn1.Width = 0
        '
        'lblBorder
        '
        Me.lblBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBorder.Location = New System.Drawing.Point(8, 34)
        Me.lblBorder.Name = "lblBorder"
        Me.lblBorder.Size = New System.Drawing.Size(672, 184)
        Me.lblBorder.TabIndex = 13
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkProduct)
        Me.GroupBox5.Font = New System.Drawing.Font("Verdana", 1.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(8, 246)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(674, 138)
        Me.GroupBox5.TabIndex = 39
        Me.GroupBox5.TabStop = False
        '
        'chkProduct
        '
        Me.chkProduct.CheckOnClick = True
        Me.chkProduct.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProduct.Location = New System.Drawing.Point(6, 8)
        Me.chkProduct.Name = "chkProduct"
        Me.chkProduct.Size = New System.Drawing.Size(646, 124)
        Me.chkProduct.TabIndex = 10
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(356, 220)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(112, 22)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.StartDate)
        Me.GroupBox3.Controls.Add(Me.EndDate)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox3.Location = New System.Drawing.Point(66, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 42)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Date Range"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(208, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "End Date:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Start Date:"
        '
        'StartDate
        '
        Me.StartDate.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDate.Location = New System.Drawing.Point(80, 16)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(120, 20)
        Me.StartDate.TabIndex = 1
        '
        'EndDate
        '
        Me.EndDate.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDate.Location = New System.Drawing.Point(272, 16)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(120, 20)
        Me.EndDate.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnMWRDReport)
        Me.GroupBox4.Controls.Add(Me.btnHAZReport)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 196)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(222, 82)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Monthly Activity"
        Me.GroupBox4.Visible = False
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(22, 304)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(112, 22)
        Me.btnSelect.TabIndex = 11
        Me.btnSelect.Text = "Select ALL"
        Me.btnSelect.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.gpDateRange)
        Me.TabPage2.Controls.Add(Me.gpJobActivity)
        Me.TabPage2.Controls.Add(Me.gpReceivables)
        Me.TabPage2.Controls.Add(Me.grpInvoices)
        Me.TabPage2.Controls.Add(Me.grpPayable)
        Me.TabPage2.Controls.Add(Me.grpLoads)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(938, 497)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Other Reports"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(938, 497)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Customer Report"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Fill_JobSiteAdd_C)
        Me.GroupBox6.Controls.Add(Me.cmbCustomer)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.Fill_JobSiteCity_C)
        Me.GroupBox6.Controls.Add(Me.Fill_Approval_C)
        Me.GroupBox6.Controls.Add(Me.Fill_Product_C)
        Me.GroupBox6.Controls.Add(Me.Fill_JobSite_C)
        Me.GroupBox6.Controls.Add(Me.dgCustomer)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.btnCustomerReport)
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox6.Location = New System.Drawing.Point(2, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(932, 486)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Customer Report"
        '
        'Fill_JobSiteAdd_C
        '
        Me.Fill_JobSiteAdd_C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fill_JobSiteAdd_C.Location = New System.Drawing.Point(306, 96)
        Me.Fill_JobSiteAdd_C.Name = "Fill_JobSiteAdd_C"
        Me.Fill_JobSiteAdd_C.Size = New System.Drawing.Size(164, 21)
        Me.Fill_JobSiteAdd_C.TabIndex = 16
        Me.Fill_JobSiteAdd_C.Text = ""
        '
        'cmbCustomer
        '
        Me.cmbCustomer.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCustomer.Location = New System.Drawing.Point(268, 70)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(442, 21)
        Me.cmbCustomer.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(194, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Customer :"
        '
        'Fill_JobSiteCity_C
        '
        Me.Fill_JobSiteCity_C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fill_JobSiteCity_C.Location = New System.Drawing.Point(470, 96)
        Me.Fill_JobSiteCity_C.Name = "Fill_JobSiteCity_C"
        Me.Fill_JobSiteCity_C.Size = New System.Drawing.Size(140, 21)
        Me.Fill_JobSiteCity_C.TabIndex = 2
        Me.Fill_JobSiteCity_C.Text = ""
        '
        'Fill_Approval_C
        '
        Me.Fill_Approval_C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fill_Approval_C.Location = New System.Drawing.Point(750, 96)
        Me.Fill_Approval_C.Name = "Fill_Approval_C"
        Me.Fill_Approval_C.Size = New System.Drawing.Size(124, 21)
        Me.Fill_Approval_C.TabIndex = 4
        Me.Fill_Approval_C.Text = ""
        '
        'Fill_Product_C
        '
        Me.Fill_Product_C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fill_Product_C.Location = New System.Drawing.Point(610, 96)
        Me.Fill_Product_C.Name = "Fill_Product_C"
        Me.Fill_Product_C.Size = New System.Drawing.Size(140, 21)
        Me.Fill_Product_C.TabIndex = 3
        Me.Fill_Product_C.Text = ""
        '
        'Fill_JobSite_C
        '
        Me.Fill_JobSite_C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fill_JobSite_C.Location = New System.Drawing.Point(78, 96)
        Me.Fill_JobSite_C.Name = "Fill_JobSite_C"
        Me.Fill_JobSite_C.Size = New System.Drawing.Size(228, 21)
        Me.Fill_JobSite_C.TabIndex = 1
        Me.Fill_JobSite_C.Text = ""
        '
        'dgCustomer
        '
        Me.dgCustomer.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.dgCustomer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgCustomer.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgCustomer.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgCustomer.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgCustomer.CaptionVisible = False
        Me.dgCustomer.DataMember = "tblCustomers"
        Me.dgCustomer.DataSource = Me.DsCustomerReport1
        Me.dgCustomer.FlatMode = True
        Me.dgCustomer.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgCustomer.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dgCustomer.GridLineColor = System.Drawing.Color.Gainsboro
        Me.dgCustomer.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgCustomer.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgCustomer.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgCustomer.HeaderForeColor = System.Drawing.Color.Black
        Me.dgCustomer.LinkColor = System.Drawing.Color.Teal
        Me.dgCustomer.Location = New System.Drawing.Point(9, 120)
        Me.dgCustomer.Name = "dgCustomer"
        Me.dgCustomer.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dgCustomer.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.dgCustomer.RowHeaderWidth = 30
        Me.dgCustomer.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgCustomer.SelectionForeColor = System.Drawing.Color.Black
        Me.dgCustomer.Size = New System.Drawing.Size(887, 315)
        Me.dgCustomer.TabIndex = 5
        Me.dgCustomer.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTS})
        '
        'DsCustomerReport1
        '
        Me.DsCustomerReport1.DataSetName = "DSCustomerReport"
        Me.DsCustomerReport1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DataGridTS
        '
        Me.DataGridTS.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DataGridTS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridTS.DataGrid = Me.dgCustomer
        Me.DataGridTS.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTS.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridBoolColumn2, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15})
        Me.DataGridTS.GridLineColor = System.Drawing.Color.Black
        Me.DataGridTS.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTS.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridTS.LinkColor = System.Drawing.Color.Teal
        Me.DataGridTS.MappingName = "tblCustomers"
        Me.DataGridTS.RowHeaderWidth = 30
        Me.DataGridTS.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGridTS.SelectionForeColor = System.Drawing.Color.Black
        '
        'DataGridBoolColumn2
        '
        Me.DataGridBoolColumn2.FalseValue = False
        Me.DataGridBoolColumn2.HeaderText = "Select"
        Me.DataGridBoolColumn2.MappingName = "Status"
        Me.DataGridBoolColumn2.NullText = ""
        Me.DataGridBoolColumn2.NullValue = "False"
        Me.DataGridBoolColumn2.TrueValue = True
        Me.DataGridBoolColumn2.Width = 40
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Generator"
        Me.DataGridTextBoxColumn9.MappingName = "GeneratorName"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.ReadOnly = True
        Me.DataGridTextBoxColumn9.Width = 225
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Address"
        Me.DataGridTextBoxColumn10.MappingName = "JobSiteAddress1"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.ReadOnly = True
        Me.DataGridTextBoxColumn10.Width = 165
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "City"
        Me.DataGridTextBoxColumn11.MappingName = "JobSiteCity"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.ReadOnly = True
        Me.DataGridTextBoxColumn11.Width = 140
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "Product"
        Me.DataGridTextBoxColumn12.MappingName = "ProductName"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 140
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Approval #"
        Me.DataGridTextBoxColumn13.MappingName = "ApprovalNo"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 125
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "GeneratorID"
        Me.DataGridTextBoxColumn14.MappingName = "GeneratorID"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 0
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "ProductID"
        Me.DataGridTextBoxColumn15.MappingName = "ProductID"
        Me.DataGridTextBoxColumn15.NullText = ""
        Me.DataGridTextBoxColumn15.Width = 0
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(8, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(890, 320)
        Me.Label11.TabIndex = 13
        '
        'btnCustomerReport
        '
        Me.btnCustomerReport.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCustomerReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomerReport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerReport.Location = New System.Drawing.Point(368, 444)
        Me.btnCustomerReport.Name = "btnCustomerReport"
        Me.btnCustomerReport.Size = New System.Drawing.Size(208, 24)
        Me.btnCustomerReport.TabIndex = 7
        Me.btnCustomerReport.Text = "Customer Report"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.Controls.Add(Me.CustDate1)
        Me.GroupBox7.Controls.Add(Me.CustDate2)
        Me.GroupBox7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox7.Location = New System.Drawing.Point(270, 22)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(398, 42)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Date Range"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(208, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "End Date:"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 16)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Start Date:"
        '
        'CustDate1
        '
        Me.CustDate1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustDate1.Location = New System.Drawing.Point(80, 16)
        Me.CustDate1.Name = "CustDate1"
        Me.CustDate1.Size = New System.Drawing.Size(120, 20)
        Me.CustDate1.TabIndex = 1
        '
        'CustDate2
        '
        Me.CustDate2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustDate2.Location = New System.Drawing.Point(272, 16)
        Me.CustDate2.Name = "CustDate2"
        Me.CustDate2.Size = New System.Drawing.Size(120, 20)
        Me.CustDate2.TabIndex = 2
        '
        'frmSelectReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(944, 552)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblProductLabel)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmSelectReport"
        Me.Text = "Reports"
        Me.gpJobActivity.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.gpReceivables.ResumeLayout(False)
        Me.gpDateRange.ResumeLayout(False)
        CType(Me.DsJobActivity1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsInvoicingReport1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsReceivablesReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPayable.ResumeLayout(False)
        CType(Me.DsCheckRegister1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInvoices.ResumeLayout(False)
        Me.grpLoads.ResumeLayout(False)
        CType(Me.DsepA_HazardousLoads1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsepA_Manifests1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsepA_BOLs1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsInHouseManifests1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DsDailyHazNonHaz1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.grpSelectProduct.ResumeLayout(False)
        CType(Me.dgSearchProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNewJobSearch1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCustomerReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim dateRange As String = ""
    Dim dsGenerator As DataSet
    Dim dsCustomer As DataSet
    Dim genID As Integer = 0
    Private Sub cmbJReportBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbJReportBy.SelectionChangeCommitted


        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Me.populateReportByCriteria()
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Function populateReportByCriteria()

        Dim ds As DataSet
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            If Me.cmbJReportBy.Text = "Type of Waste" Then
                ds = DBHelper.GetDataSet("SELECT DISTINCT ProductName FROM tblProducts ORDER BY ProductName", "tblProducts")
                Dim emptyRow As DataRow
                emptyRow = ds.Tables(0).NewRow()
                emptyRow.Item(0) = ""
                ds.Tables(0).Rows.InsertAt(emptyRow, 0)
                Me.cmbReportByCriteria.DataSource = ds
                Me.cmbReportByCriteria.DisplayMember = "tblProducts.ProductName"
                Me.cmbReportByCriteria.ValueMember = "tblProducts.ProductName"
                Me.lblReportBy.Text = "Select a Type of Waste:"

            ElseIf Me.cmbJReportBy.Text = "Generator" Then
                ds = DBHelper.GetDataSet("SELECT DISTINCT GeneratorName FROM tblGenerators ORDER BY GeneratorName", "tblGenerators")
                Dim emptyRow As DataRow
                emptyRow = ds.Tables(0).NewRow()
                emptyRow.Item(0) = ""
                ds.Tables(0).Rows.InsertAt(emptyRow, 0)
                Me.cmbReportByCriteria.DataSource = ds
                Me.cmbReportByCriteria.DisplayMember = "tblGenerators.GeneratorName"
                Me.cmbReportByCriteria.ValueMember = "tblGenerators.GeneratorName"
                Me.lblReportBy.Text = "Select a Generator:"

            ElseIf Me.cmbJReportBy.Text = "Customer" Then
                ds = DBHelper.GetDataSet("SELECT DISTINCT JobSite FROM tblGenerators ORDER BY JobSite", "tblGenerators")
                Dim emptyRow As DataRow
                emptyRow = ds.Tables(0).NewRow()
                emptyRow.Item(0) = ""
                ds.Tables(0).Rows.InsertAt(emptyRow, 0)
                Me.cmbReportByCriteria.DataSource = ds
                Me.cmbReportByCriteria.DisplayMember = "tblGenerators.JobSite"
                Me.cmbReportByCriteria.ValueMember = "tblGenerators.JobSite"
                Me.lblReportBy.Text = "Select a Customer:"

            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Function

    Private Sub btnJActivityReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJActivityReport.Click

        If Me.ValidateStartEndDate = False Then Exit Sub

        Dim objRpt As New rpt_JobActivity
        Dim ds As DataSet, strSQL As String
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            Dim fFields As FormulaFieldDefinitions = objRpt.DataDefinition.FormulaFields
            Dim fField As FormulaFieldDefinition
            Dim hazCode As String = ""
            If Me.IsHaz.Checked = True Then
                If Me.cmbHaz.SelectedIndex > 0 Then
                    hazCode = " tblProducts.HWNumber = '" & Replace(Me.cmbHaz.Text, "'", "''") & "'"
                End If
            End If
            If Me.FROMDate.Value.ToString <> "" Then
                If hazCode <> "" Then
                    strSQL = "SELECT tblGenerators.JobSite, tblJobTickets.JobTicketNo, tblJobTickets.JobTicketDate, tblProducts.ProductName, tblGenerators.GeneratorName, tblJobTickets_Details.Quantity, tblGenerators.JobSite, tblJobTickets.ManifestNo, tblProducts.PermitNo FROM tblDisposalFacilities INNER JOIN ((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN (tblJobTickets INNER JOIN tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) ON tblProducts.ProductID = tblJobTickets.ProductID) ON tblDisposalFacilities.DisposalFacilityID = tblJobTickets.DisposalFacilityID WHERE (tblDisposalFacilities.IsBeaver=True) AND (tblJobTickets.IsCancelled = False) AND (tblJobTickets.JobTicketDate BETWEEN #" & Me.FROMDate.Value.ToShortDateString & "# AND #" & Me.TODate.Value.ToShortDateString & "#) AND " & hazCode
                Else
                    strSQL = "SELECT tblGenerators.JobSite, tblJobTickets.JobTicketNo, tblJobTickets.JobTicketDate, tblProducts.ProductName, tblGenerators.GeneratorName, tblJobTickets_Details.Quantity, tblGenerators.JobSite, tblJobTickets.ManifestNo, tblProducts.PermitNo FROM tblDisposalFacilities INNER JOIN ((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN (tblJobTickets INNER JOIN tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) ON tblProducts.ProductID = tblJobTickets.ProductID) ON tblDisposalFacilities.DisposalFacilityID = tblJobTickets.DisposalFacilityID WHERE (tblDisposalFacilities.IsBeaver=True) AND (tblJobTickets.IsCancelled = False) AND (tblJobTickets.JobTicketDate BETWEEN #" & Me.FROMDate.Value.ToShortDateString & "# AND #" & Me.TODate.Value.ToShortDateString & "#) "
                End If
                dateRange = "From " & Me.FROMDate.Value.ToShortDateString & " to " & Me.TODate.Value.ToShortDateString
            Else
                If hazCode <> "" Then
                    strSQL = "SELECT tblGenerators.JobSite, tblJobTickets.JobTicketNo, tblJobTickets.JobTicketDate, tblProducts.ProductName, tblGenerators.GeneratorName, tblJobTickets_Details.Quantity, tblGenerators.JobSite, tblJobTickets.ManifestNo, tblProducts.PermitNo FROM tblDisposalFacilities INNER JOIN ((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN (tblJobTickets INNER JOIN tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) ON tblProducts.ProductID = tblJobTickets.ProductID) ON tblDisposalFacilities.DisposalFacilityID = tblJobTickets.DisposalFacilityID WHERE (tblDisposalFacilities.IsBeaver=True) AND (tblJobTickets.IsCancelled = False) AND " & hazCode
                Else
                    strSQL = "SELECT tblGenerators.JobSite, tblJobTickets.JobTicketNo, tblJobTickets.JobTicketDate, tblProducts.ProductName, tblGenerators.GeneratorName, tblJobTickets_Details.Quantity, tblGenerators.JobSite, tblJobTickets.ManifestNo, tblProducts.PermitNo FROM tblDisposalFacilities INNER JOIN ((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN (tblJobTickets INNER JOIN tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) ON tblProducts.ProductID = tblJobTickets.ProductID) ON tblDisposalFacilities.DisposalFacilityID = tblJobTickets.DisposalFacilityID WHERE (tblDisposalFacilities.IsBeaver=True) AND (tblJobTickets.IsCancelled = False) "
                End If
                dateRange = ""
            End If
            If Me.cmbJReportBy.Text = "Type of Waste" Then
                fField = fFields.Item("Field1")
                fField.Text = "{tblJobActivity.ProductName}"
                fField = fFields.Item("Field1_H")
                fField.Text = """Type of Waste"""
                If Me.cmbReportByCriteria.Text <> "" Then
                    strSQL = strSQL & " AND (tblProducts.ProductName = '" & Replace(Me.cmbReportByCriteria.Text, "'", "''") & "') "
                End If
            ElseIf Me.cmbJReportBy.Text = "Generator" Then
                fField = fFields.Item("Field1")
                fField.Text = "{tblJobActivity.GeneratorName}"
                fField = fFields.Item("Field1_H")
                fField.Text = """Job Site"""
                If Me.cmbReportByCriteria.Text <> "" Then
                    strSQL = strSQL & " AND (tblGenerators.GeneratorName = '" & Replace(Me.cmbReportByCriteria.Text, "'", "''") & "') "
                End If
            ElseIf Me.cmbJReportBy.Text = "Customer" Then
                fField = fFields.Item("Field1")
                fField.Text = "{tblJobActivity.JobSite}"
                fField = fFields.Item("Field1_H")
                fField.Text = """Client"""
                If Me.cmbReportByCriteria.Text <> "" Then
                    strSQL = strSQL & " AND (tblGenerators.JobSite = '" & Replace(Me.cmbReportByCriteria.Text, "'", "''") & "') "
                End If
            End If
            If Me.IsHaz.Checked = True Then
                strSQL = strSQL & " AND (tblProducts.Hazardous = Yes) "
            ElseIf Me.IsNonHaz.Checked = True Then
                strSQL = strSQL & " AND (tblProducts.NonHazardous = Yes) "
            End If
            strSQL = strSQL & "  ORDER BY tblJobTickets.JobTicketDate"
            fField = fFields.Item("FromToDate")
            fField.Text = """" & dateRange & """"
            'Generate Dataset
            ds = DBHelper.GetDataSet(strSQL, "tblJobActivity")
            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("No matching records found. Cancelling report...", MsgBoxStyle.Information, "No Data")
                Exit Sub
            End If
            'Assign datasource of report as dataset
            objRpt.SetDataSource(ds)
            'authenticate User Credentials
            DBHelper.Authenticate(objRpt)
            Dim frmSR As New frmReport
            frmSR.WindowState = FormWindowState.Maximized
            frmSR.CrystalReportViewer1.ReportSource = objRpt
            frmSR.CrystalReportViewer1.RefreshReport()
            frmSR.Show()

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally
            ds = Nothing
            objRpt = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Sub

    Function ValidateStartEndDate() As Boolean

        ValidateStartEndDate = True
        If Me.FROMDate.Value.ToString.Trim <> "" Then
            If IsDate(Me.FROMDate.Value) = False Then
                MsgBox("Start Date is invalid. Please enter a valid date.", MsgBoxStyle.Information, "Date Range")
                Me.FROMDate.Focus()
                ValidateStartEndDate = False
            End If
        End If
        If Me.TODate.Value.ToString.Trim <> "" Then
            If IsDate(Me.TODate.Value) = False Then
                MsgBox("End Date is invalid. Please enter a valid date.", MsgBoxStyle.Information, "Date Range")
                Me.TODate.Focus()
                ValidateStartEndDate = False
            End If
        End If
        If Me.FROMDate.Value.ToString.Trim <> "" And Me.TODate.Value.ToString.Trim = "" Then
            MsgBox("End Date is missing. Please enter a valid End date.", MsgBoxStyle.Information, "Date Range")
            Me.TODate.Focus()
            ValidateStartEndDate = False
        End If
        If Me.FROMDate.Value.ToString.Trim = "" And Me.TODate.Value.ToString.Trim <> "" Then
            MsgBox("Start Date is missing. Please enter a valid Start date.", MsgBoxStyle.Information, "Date Range")
            Me.FROMDate.Focus()
            ValidateStartEndDate = False
        End If

    End Function

    Private Sub btnROpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Me.ValidateStartEndDate = False Then Exit Sub

        Dim objRpt As New rptAccounting
        Dim ds As DataSet

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            Dim fFields As FormulaFieldDefinitions = objRpt.DataDefinition.FormulaFields
            Dim fField As FormulaFieldDefinition
            Dim strSQL As String
            'Check to see if Date range is selected
            strSQL = "SELECT tblGenerators.GeneratorName, tblInvoicing.InvoiceNo, tblInvoicing.InvoiceDate, Sum(IIf(DateDiff('d',[InvoiceDate],Now())<=30,[InvoiceAmount],0)) AS Days_30, Sum(IIf(DateDiff('d',[InvoiceDate],Now())>30 And DateDiff('d',[InvoiceDate],Now())<=60,[InvoiceAmount],0)) AS Days_60, Sum(IIf(DateDiff('d',[InvoiceDate],Now())>60 And DateDiff('d',[InvoiceDate],Now())<=90,[InvoiceAmount],0)) AS Days_90, Sum(IIf(DateDiff('d',[InvoiceDate],Now())>90,[InvoiceAmount],0)) AS Days_Over_90 " _
                    & " FROM (tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN (tblJobTickets INNER JOIN tblInvoicing ON tblJobTickets.JobTicketID = tblInvoicing.JobTicketID) ON tblProducts.ProductID = tblJobTickets.ProductID " _
                    & " WHERE (tblInvoicing.PaymentReceived = False) AND (tblJobTickets.IsCancelled = False)"
            If Me.FROMDate.Value.ToString.Trim <> "" Then
                strSQL = strSQL & " AND (tblJobTickets.JobTicketDate BETWEEN #" & Me.FROMDate.Value.ToShortDateString & "# AND #" & Me.TODate.Value.ToShortDateString & "#)"
                dateRange = "From " & Me.FROMDate.Value.ToShortDateString & " to " & Me.TODate.Value.ToShortDateString
            Else
                dateRange = ""
            End If
            strSQL = strSQL & " GROUP BY tblGenerators.GeneratorName, tblInvoicing.InvoiceNo, tblInvoicing.InvoiceDate, tblInvoicing.PaymentReceived " _
                        & " ORDER BY tblGenerators.GeneratorName, tblInvoicing.InvoiceNo"
            ds = DBHelper.GetDataSet(strSQL, "tblAccounting")
            Dim i As Integer
            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("No matching records found. Cancelling report...", MsgBoxStyle.Information, "No Data")
                Exit Sub
            End If
            'Update Date Range Formula field with date range
            fField = fFields.Item("DateRange")
            fField.Text = dateRange
            'Set Datasouce and authenticate
            objRpt.SetDataSource(ds)
            DBHelper.Authenticate(objRpt)
            'Open Report Form and show the report
            Dim frmSR As New frmReport
            frmSR.WindowState = FormWindowState.Maximized
            frmSR.CrystalReportViewer1.ReportSource = objRpt
            frmSR.CrystalReportViewer1.RefreshReport()
            frmSR.Show()

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally
            objRpt = Nothing
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Sub

    Private Sub btnRAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRAll.Click

        If Me.ValidateStartEndDate = False Then Exit Sub

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim objRpt As New rpt_ReceivableReport
        Dim ds As DataSet
        Try
            Dim fFields As FormulaFieldDefinitions = objRpt.DataDefinition.FormulaFields
            Dim fField As FormulaFieldDefinition
            Dim strSQL As String
            If Me.FROMDate.Value.ToString.Trim <> "" Then
                'strSQL = "SELECT tblInvoicing.InvoiceDate as JobTicketDate, tblGenerators.GeneratorName, tblProducts.ProductName, tblJobTickets.JobTicketNo, tblJobTickets_Details.Quantity, tblInvoicing.InvoiceAmount, tblInvoicing.CheckAmount, tblInvoicing.CheckDate, tblInvoicing.CheckNo, tblInvoicing.PaymentReceived FROM ((((tblJobTickets INNER JOIN tblProducts ON tblJobTickets.ProductID = tblProducts.ProductID) INNER JOIN tblGenerators ON tblProducts.GeneratorID = tblGenerators.GeneratorID) INNER JOIN tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) INNER JOIN tblInvoicing ON tblJobTickets.JobTicketID = tblInvoicing.JobTicketID) WHERE tblInvoicing.CheckDate BETWEEN #" & Me.FROMDate.Value.ToShortDateString & "# AND #" & Me.TODate.Value.ToShortDateString & "# AND tblInvoicing.InvoiceAmount > 0 AND tblJobTickets.IsCancelled = False"
                strSQL = "SELECT DISTINCT tblJobTickets.JobTicketID,tblInvoicing.InvoiceDate as JobTicketDate, tblGenerators.GeneratorName, tblProducts.ProductName, tblJobTickets.JobTicketNo, " _
                             & " Sum(tblJobTickets_Details.Quantity) as Quantity , Sum(tblInvoicing.InvoiceAmount) as InvoiceAmount, " _
                             & " Sum(tblInvoicing.CheckAmount) as CheckAmount, tblInvoicing.CheckDate, tblInvoicing.CheckNo, tblInvoicing.PaymentReceived " _
                         & " FROM ((((tblJobTickets INNER JOIN tblProducts ON tblJobTickets.ProductID = tblProducts.ProductID) INNER JOIN " _
                                & " tblGenerators ON tblProducts.GeneratorID = tblGenerators.GeneratorID) INNER JOIN " _
                                & " tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) INNER JOIN tblInvoicing ON tblJobTickets.JobTicketID = tblInvoicing.JobTicketID) " _
                                & " WHERE tblInvoicing.CheckDate BETWEEN #" & Me.FROMDate.Value.ToShortDateString & "# AND #" & Me.TODate.Value.ToShortDateString & "# AND tblInvoicing.InvoiceAmount > 0 AND tblJobTickets.IsCancelled = False " _
                                & " GROUP BY tblJobTickets.JobTicketID,tblInvoicing.InvoiceDate, tblGenerators.GeneratorName, tblProducts.ProductName, tblJobTickets.JobTicketNo,tblInvoicing.CheckDate, tblInvoicing.CheckNo, tblInvoicing.PaymentReceived "

                dateRange = "From " & Me.FROMDate.Value.ToShortDateString & " to " & Me.TODate.Value.ToShortDateString
            Else
                '                strSQL = "SELECT tblInvoicing.InvoiceDate as JobTicketDate, tblGenerators.GeneratorName, tblProducts.ProductName, tblJobTickets.JobTicketNo, tblJobTickets_Details.Quantity, tblInvoicing.InvoiceAmount, tblInvoicing.CheckAmount, tblInvoicing.CheckDate, tblInvoicing.CheckNo, tblInvoicing.PaymentReceived FROM ((((tblJobTickets INNER JOIN tblProducts ON tblJobTickets.ProductID = tblProducts.ProductID) INNER JOIN tblGenerators ON tblProducts.GeneratorID = tblGenerators.GeneratorID) INNER JOIN tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) INNER JOIN tblInvoicing ON tblJobTickets.JobTicketID = tblInvoicing.JobTicketID) WHERE tblInvoicing.InvoiceAmount > 0 AND tblJobTickets.IsCancelled = False"
                strSQL = "SELECT DISTINCT tblJobTickets.JobTicketID,tblInvoicing.InvoiceDate as JobTicketDate, tblGenerators.GeneratorName, tblProducts.ProductName, tblJobTickets.JobTicketNo, " _
                             & " Sum(tblJobTickets_Details.Quantity) as Quantity , Sum(tblInvoicing.InvoiceAmount) as InvoiceAmount, " _
                             & " Sum(tblInvoicing.CheckAmount) as CheckAmount, tblInvoicing.CheckDate, tblInvoicing.CheckNo, tblInvoicing.PaymentReceived " _
                        & " FROM ((((tblJobTickets INNER JOIN tblProducts ON tblJobTickets.ProductID = tblProducts.ProductID) INNER JOIN " _
                             & " tblGenerators ON tblProducts.GeneratorID = tblGenerators.GeneratorID) INNER JOIN " _
                             & " tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) INNER JOIN tblInvoicing ON tblJobTickets.JobTicketID = tblInvoicing.JobTicketID) " _
                             & " WHERE tblInvoicing.InvoiceAmount > 0 AND tblJobTickets.IsCancelled = False " _
                             & " GROUP BY tblJobTickets.JobTicketID,tblInvoicing.InvoiceDate, tblGenerators.GeneratorName, tblProducts.ProductName, tblJobTickets.JobTicketNo,tblInvoicing.CheckDate, tblInvoicing.CheckNo, tblInvoicing.PaymentReceived "

            End If
            ds = DBHelper.GetDataSet(strSQL, "tblInvoicing")
            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("No matching records found. Cancelling report...", MsgBoxStyle.Information, "No Data")
                Exit Sub
            End If
            If Me.cmbRReportBy.Text = "Invoice Date" Then
                fField = fFields.Item("Field1")
                fField.Text = "{tblInvoicing.JobTicketDate}"
                fField = fFields.Item("Field2")
                fField.Text = "{tblInvoicing.GeneratorName}"
                fField = fFields.Item("Field1_H")
                fField.Text = """Invoice Date"""
                fField = fFields.Item("Field2_H")
                fField.Text = """Generator"""
            ElseIf Me.cmbRReportBy.Text = "Client" Then
                fField = fFields.Item("Field1")
                fField.Text = "{tblInvoicing.GeneratorName}"
                fField = fFields.Item("Field2")
                fField.Text = "{tblInvoicing.JobTicketDate}"
                fField = fFields.Item("Field1_H")
                fField.Text = """Client"""
                fField = fFields.Item("Field2_H")
                fField.Text = """Invoice Date"""
            End If
            fField = fFields.Item("Field3")
            fField.Text = """Closed Receivables"""
            fField = fFields.Item("FromToDate")
            fField.Text = """" & dateRange & """"
            objRpt.SetDataSource(ds)
            DBHelper.Authenticate(objRpt)

            Dim frmSR As New frmReport
            frmSR.WindowState = FormWindowState.Maximized
            frmSR.CrystalReportViewer1.ReportSource = objRpt
            frmSR.CrystalReportViewer1.RefreshReport()
            frmSR.Show()

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally
            objRpt = Nothing
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Sub

    Private Sub frmSelectReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Me.OleDbConnection1.ConnectionString = DBHelper.ConnStr
        Me.populateReportByCriteria()
        Me.populateVSelection()
        Me.populateHSelection()
        'Me.populateISelection()

        Me.FROMDate.Format = DateTimePickerFormat.Custom
        Me.FROMDate.CustomFormat = "MM/dd/yyyy"
        Me.TODate.Format = DateTimePickerFormat.Custom
        Me.TODate.CustomFormat = "MM/dd/yyyy"

        Me.StartDate.Format = DateTimePickerFormat.Custom
        Me.StartDate.CustomFormat = "MM/dd/yyyy"
        Me.EndDate.Format = DateTimePickerFormat.Custom
        Me.EndDate.CustomFormat = "MM/dd/yyyy"
        Me.StartDate.Refresh()
        Me.EndDate.Refresh()

        Me.CustDate1.Format = DateTimePickerFormat.Custom
        Me.CustDate1.CustomFormat = "MM/dd/yyyy"
        Me.CustDate2.Format = DateTimePickerFormat.Custom
        Me.CustDate2.CustomFormat = "MM/dd/yyyy"
        Me.CustDate1.Refresh()
        Me.CustDate2.Refresh()

        LoadDGValues()
        InitialLoad_Customer()
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cmbReportByCriteria_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbReportByCriteria.KeyUp

        Dim index As Integer, actual As String, found As String
        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Back) Or (e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        ' Store the actual text that has been typed
        actual = Me.cmbReportByCriteria.Text
        ' Find the first match for the typed value
        index = Me.cmbReportByCriteria.FindString(actual)
        ' Get the text of the first match
        If (index > -1) Then
            ' Select this item from the list
            Me.cmbReportByCriteria.SelectedIndex = index
            found = Me.cmbReportByCriteria.Text
            ' Select the portion of the text that was automatically added so further typing will replace it
            Me.cmbReportByCriteria.SelectionStart = actual.Length
            Me.cmbReportByCriteria.SelectionLength = found.Length - actual.Length
        End If

    End Sub

    Private Sub cmbJReportBy_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbJReportBy.KeyUp

        Dim index As Integer, actual As String, found As String
        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Back) Or (e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        ' Store the actual text that has been typed
        actual = Me.cmbJReportBy.Text
        ' Find the first match for the typed value
        index = Me.cmbJReportBy.FindString(actual)
        ' Get the text of the first match
        If (index > -1) Then
            ' Select this item from the list
            Me.cmbJReportBy.SelectedIndex = index
            found = Me.cmbJReportBy.Text
            ' Select the portion of the text that was automatically added so further typing will replace it
            Me.cmbJReportBy.SelectionStart = actual.Length
            Me.cmbJReportBy.SelectionLength = found.Length - actual.Length
        End If

    End Sub

    Private Sub cmbRReportBy_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbRReportBy.KeyUp

        Dim index As Integer, actual As String, found As String
        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Back) Or (e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        ' Store the actual text that has been typed
        actual = Me.cmbRReportBy.Text
        ' Find the first match for the typed value
        index = Me.cmbRReportBy.FindString(actual)
        ' Get the text of the first match
        If (index > -1) Then
            ' Select this item from the list
            Me.cmbRReportBy.SelectedIndex = index
            found = Me.cmbRReportBy.Text
            ' Select the portion of the text that was automatically added so further typing will replace it
            Me.cmbRReportBy.SelectionStart = actual.Length
            Me.cmbRReportBy.SelectionLength = found.Length - actual.Length
        End If

    End Sub

    Private Sub cmbPReportBy_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbPReportBy.KeyUp

        Dim index As Integer, actual As String, found As String
        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Back) Or (e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        ' Store the actual text that has been typed
        actual = Me.cmbPReportBy.Text
        ' Find the first match for the typed value
        index = Me.cmbPReportBy.FindString(actual)
        ' Get the text of the first match
        If (index > -1) Then
            ' Select this item from the list
            Me.cmbPReportBy.SelectedIndex = index
            found = Me.cmbPReportBy.Text
            ' Select the portion of the text that was automatically added so further typing will replace it
            Me.cmbPReportBy.SelectionStart = actual.Length
            Me.cmbPReportBy.SelectionLength = found.Length - actual.Length
        End If

    End Sub

    Private Sub cmbVendor_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbVendor.KeyUp

        Dim index As Integer, actual As String, found As String
        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Back) Or (e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        ' Store the actual text that has been typed
        actual = Me.cmbVendor.Text
        ' Find the first match for the typed value
        index = Me.cmbVendor.FindString(actual)
        ' Get the text of the first match
        If (index > -1) Then
            ' Select this item from the list
            Me.cmbVendor.SelectedIndex = index
            found = Me.cmbVendor.Text
            ' Select the portion of the text that was automatically added so further typing will replace it
            Me.cmbVendor.SelectionStart = actual.Length
            Me.cmbVendor.SelectionLength = found.Length - actual.Length
        End If

    End Sub

    Private Sub btnCheckRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckRegister.Click

        If Me.ValidateStartEndDate = False Then Exit Sub

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim objRpt As New rptCheckRegister
        Dim ds As DataSet
        Try

            Dim fFields As FormulaFieldDefinitions = objRpt.DataDefinition.FormulaFields
            Dim fField As FormulaFieldDefinition
            Dim strSQL As String

            If Me.FROMDate.Value.ToString.Trim <> "" Then
                If Me.cmbVendor.SelectedIndex > 0 Then
                    strSQL = "SELECT tblPayables.Beaver_CheckDate, tblPayables.Beaver_CheckNo, tblVendors.VendorName, tblPayables.Beaver_CheckAmount, tblPayables.Beaver_Desc, tblVendors.VendorAddress1, tblVendors.VendorCity, tblVendors.VendorState, tblVendors.VendorZip FROM (tblVendors INNER JOIN tblPayables ON tblVendors.VendorID = tblPayables.VendorID) WHERE tblPayables.Beaver_CheckDate BETWEEN #" & Me.FROMDate.Value.ToShortDateString & "# AND #" & Me.TODate.Value.ToShortDateString & "# AND tblVendors.VendorID = " & Me.cmbVendor.SelectedValue & " ORDER BY Beaver_CheckDate, tblVendors.VendorName"
                Else
                    strSQL = "SELECT tblPayables.Beaver_CheckDate, tblPayables.Beaver_CheckNo, tblVendors.VendorName, tblPayables.Beaver_CheckAmount, tblPayables.Beaver_Desc, tblVendors.VendorAddress1, tblVendors.VendorCity, tblVendors.VendorState, tblVendors.VendorZip FROM (tblVendors INNER JOIN tblPayables ON tblVendors.VendorID = tblPayables.VendorID) WHERE tblPayables.Beaver_CheckDate BETWEEN #" & Me.FROMDate.Value.ToShortDateString & "# AND #" & Me.TODate.Value.ToShortDateString & "# ORDER BY Beaver_CheckDate, tblVendors.VendorName"
                End If
                dateRange = "From " & Me.FROMDate.Value.ToShortDateString & " to " & Me.TODate.Value.ToShortDateString
            Else
                If Me.cmbVendor.SelectedIndex > 0 Then
                    strSQL = "SELECT tblPayables.Beaver_CheckDate, tblPayables.Beaver_CheckNo, tblVendors.VendorName, tblPayables.Beaver_CheckAmount, tblPayables.Beaver_Desc, tblVendors.VendorAddress1, tblVendors.VendorCity, tblVendors.VendorState, tblVendors.VendorZip FROM (tblVendors INNER JOIN tblPayables ON tblVendors.VendorID = tblPayables.VendorID) WHERE tblVendors.VendorID = " & Me.cmbVendor.SelectedValue & " ORDER BY Beaver_CheckDate, tblVendors.VendorName"
                Else
                    strSQL = "SELECT tblPayables.Beaver_CheckDate, tblPayables.Beaver_CheckNo, tblVendors.VendorName, tblPayables.Beaver_CheckAmount, tblPayables.Beaver_Desc, tblVendors.VendorAddress1, tblVendors.VendorCity, tblVendors.VendorState, tblVendors.VendorZip FROM (tblVendors INNER JOIN tblPayables ON tblVendors.VendorID = tblPayables.VendorID) ORDER BY Beaver_CheckDate, tblVendors.VendorName"
                End If
            End If
            ds = DBHelper.GetDataSet(strSQL, "tblPayables")
            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("No matching records found. Cancelling report...", MsgBoxStyle.Information, "No Data")
                Exit Sub
            End If
            If Me.cmbPReportBy.Text = "Date" Then
                fField = fFields.Item("Field1")
                fField.Text = "{tblPayables.Beaver_CheckDate}"
                fField = fFields.Item("Field2")
                fField.Text = "{tblPayables.VendorName}"
                fField = fFields.Item("Field1_H")
                fField.Text = """Check Date"""
                fField = fFields.Item("Field2_H")
                fField.Text = """Vendor"""

            ElseIf Me.cmbPReportBy.Text = "Vendor" Then
                fField = fFields.Item("Field1")
                fField.Text = "{tblPayables.VendorName}"
                fField = fFields.Item("Field2")
                fField.Text = "{tblPayables.Beaver_CheckDate}"
                fField = fFields.Item("Field1_H")
                fField.Text = """Vendor"""
                fField = fFields.Item("Field2_H")
                fField.Text = """Check Date"""

            End If
            fField = fFields.Item("Field3")
            fField.Text = """Check Register"""
            fField = fFields.Item("FromToDate")
            fField.Text = """" & dateRange & """"
            objRpt.SetDataSource(ds)
            DBHelper.Authenticate(objRpt)

            Dim frmSR As New frmReport
            frmSR.WindowState = FormWindowState.Maximized
            frmSR.CrystalReportViewer1.ReportSource = objRpt
            frmSR.CrystalReportViewer1.RefreshReport()
            frmSR.Show()

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally
            objRpt = Nothing
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Sub

    Function populateVSelection()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet
        Dim strSQL As String
        Try
            strSQL = "SELECT VendorID, (VendorNo & ' - ' & VendorName) as Vendor FROM tblVendors ORDER BY (VendorNo & ' - ' & VendorName)"
            ds = DBHelper.GetDataSet(strSQL, "tblVendors")
            Dim emptyRow As DataRow
            emptyRow = ds.Tables(0).NewRow()
            emptyRow.Item(0) = "0"
            emptyRow.Item(1) = ""
            ds.Tables(0).Rows.InsertAt(emptyRow, 0)
            Me.cmbVendor.DataSource = ds
            Me.cmbVendor.DisplayMember = "tblVendors.Vendor"
            Me.cmbVendor.ValueMember = "tblVendors.VendorID"

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Function

    Function populateHSelection()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet
        Dim strSQL As String
        Try
            strSQL = "SELECT DISTINCT HWNumber FROM qryAllHazCodes ORDER BY HWNumber"
            ds = DBHelper.GetDataSet(strSQL, "qryAllHazCodes")
            Dim emptyRow As DataRow
            emptyRow = ds.Tables(0).NewRow()
            emptyRow.Item(0) = "Select a Code"
            ds.Tables(0).Rows.InsertAt(emptyRow, 0)
            Me.cmbHaz.DataSource = ds
            Me.cmbHaz.DisplayMember = "qryAllHazCodes.HWNumber"
            Me.cmbHaz.ValueMember = "qryAllHazCodes.HWNumber"

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Function

    Function populateISelection()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet
        Dim strSQL As String
        Try
            strSQL = "SELECT InvoiceID, InvoiceNo FROM tblInvoicing WHERE Invoiced = TRUE ORDER BY InvoiceNo"
            ds = DBHelper.GetDataSet(strSQL, "tblInvoice")
            Dim emptyRow As DataRow
            emptyRow = ds.Tables(0).NewRow()
            emptyRow.Item(0) = "0"
            emptyRow.Item(1) = "Select an Invoice"
            ds.Tables(0).Rows.InsertAt(emptyRow, 0)
            Me.cmbInvoices.DataSource = ds
            Me.cmbInvoices.DisplayMember = "tblInvoice.InvoiceNo"
            Me.cmbInvoices.ValueMember = "tblInvoice.InvoiceID"

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Function

    Private Sub IsBoth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IsBoth.CheckedChanged

        If Me.IsBoth.Checked = True Then
            Me.cmbHaz.Enabled = False
        End If

    End Sub

    Private Sub IsHaz_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IsHaz.CheckedChanged

        If Me.IsHaz.Checked = True Then
            Me.cmbHaz.Enabled = True
            Me.cmbHaz.Focus()
        End If

    End Sub

    Private Sub IsNonHaz_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IsNonHaz.CheckedChanged

        If Me.IsNonHaz.Checked = True Then
            Me.cmbHaz.Enabled = False
        End If

    End Sub

    Private Sub btnPrintInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintInvoice.Click

        If Me.cmbInvoices.SelectedIndex < 1 Then
            MsgBox("Please select an Invoice.", MsgBoxStyle.Information, "Invoice not selected")
            Exit Sub
        End If

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        Dim objRpt As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim ds As DataSet
        Try
            Dim strSQL As String

            strSQL = "SELECT tblInvoicing.InvoiceNo, tblInvoicing.InvoiceDate, tblInvoicing.InvoiceAmount, tblGenerators.BillingName, tblGenerators.BillingAddress1 &  ', ' & tblGenerators.BillingAddress2 as BillingAddress1,tblGenerators.BillingAddress2, " _
            & "tblGenerators.BillingCity, tblGenerators.BillingState, tblGenerators.BillingZip, tblDisposalFacilities.DisposalFacilityName, tblDisposalFacilities.FAddress1, " _
            & "tblDisposalFacilities.FCity, tblDisposalFacilities.FState, tblDisposalFacilities.FZip, tblJobTickets.ScheduleDate as JobTicketDate, tblTransporters.TransporterName, tblProducts.GenProdNo as GNo, " _
            & "tblJobTickets_Details.Quantity, tblJobTickets_Details.UOM, tblJobTickets_Details.Description, tblJobTickets.ManifestNo, tblJobTickets.RefNo, tblGenerators.JobSite, " _
            & "tblGenerators.JobSiteAddress1,tblGenerators.JobSiteAddress2, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, tblJobTickets_Details.ItemIRate, tblJobTickets_Details.ItemIAmount, " _
            & "tblJobTickets.JobPO, tblGenerators.GeneratorName, tblProducts.ProductName, tblJobTickets.JobTicketID, tblInvoicing.InvoiceDescription, tblJobTickets.TicketNo, tblInvoicing.InvoiceType " _
            & " FROM ((tblTransporters INNER JOIN (tblDisposalFacilities INNER JOIN (tblGenerators INNER JOIN (tblProducts " _
            & "     INNER JOIN (tblJobTickets INNER JOIN tblInvoicing ON tblJobTickets.JobTicketID = tblInvoicing.JobTicketID) ON tblProducts.ProductID = tblJobTickets.ProductID) ON " _
            & "     tblGenerators.GeneratorID = tblProducts.GeneratorID) ON tblDisposalFacilities.DisposalFacilityID = tblJobTickets.DisposalFacilityID) ON tblTransporters.TransporterID = " _
            & "     tblJobTickets.TransporterID) INNER JOIN tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) " _
            & "WHERE tblInvoicing.InvoiceID = " & Me.cmbInvoices.SelectedValue

            ds = DBHelper.GetDataSet(strSQL, "tblInvoice_Details")
            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("No matching records found. Cancelling report...", MsgBoxStyle.Information, "No Data")
                Exit Sub
            End If
            If ds.Tables(0).Rows(0).Item("InvoiceType") = 1 Then
                objRpt = New rpt_Invoice
            Else
                objRpt = New rpt_InvoiceList
            End If
            objRpt.SetDataSource(ds)
            DBHelper.Authenticate(objRpt)

            Dim frmSR As New frmReport
            frmSR.WindowState = FormWindowState.Maximized
            frmSR.CrystalReportViewer1.ReportSource = objRpt
            frmSR.CrystalReportViewer1.RefreshReport()
            frmSR.Show()

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally
            objRpt = Nothing
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Sub

    Private Sub btnHazLoads_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Me.ValidateDates = False Then Exit Sub

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim objRpt As New rpt_EPA_Hazardous
        Dim ds As DataSet, strSQL As String
        Try
            'strSQL = "SELECT tblJobTickets.ScheduleDate, tblJobTickets.ManifestNo, tblGenerators.GNo AS GenNo, tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, tblJobTickets_Details.Quantity, tblProducts.HWNumber FROM (((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) INNER JOIN tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) WHERE tblJobTickets.Hazardous = TRUE and tblJobTickets.ScheduleDate BETWEEN #" & Me.txtStartDate.Text & "# AND #" & Me.txtEndDate.Text & "# ORDER BY tblJobTickets.ScheduleDate"
            strSQL = "SELECT DISTINCT tblJobTickets.JobTicketID, tblJobTickets.ManifestNo, tblJobTickets.ScheduleDate, " _
                          & " tblGenerators.GNo AS GenNo, tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteAddress1, " _
                          & " tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, " _
                          & " Sum(tblJobTickets_Details.Quantity) as Quantity,tblProducts.HWNumber, tblJobTickets.bsw, " _
                          & " tblJobTickets.JobTicketNo, tblGenerators.BrokerName, tblProducts.ApprovalNo " _
                  & " FROM (((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) " _
                          & " INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) LEFT OUTER JOIN " _
                          & " tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) " _
                  & " WHERE (tblJobTickets.WasteType = 'HAZARDOUS') and " _
                         & " (tblJobTickets.ScheduleDate BETWEEN #" & Me.FROMDate.Value.ToShortDateString & "# AND #" & Me.TODate.Value.ToShortDateString & "#) " _
                      & " GROUP BY tblJobTickets.JobTicketID, tblJobTickets.ManifestNo, tblJobTickets.ScheduleDate, " _
                          & "  tblGenerators.GNo , tblGenerators.GeneratorName , tblGenerators.JobSiteAddress1, " _
                          & "  tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, " _
                          & "  tblProducts.HWNumber, tblJobTickets.bsw, tblJobTickets.JobTicketNo, tblGenerators.BrokerName, " _
                          & "  tblProducts.ApprovalNo ORDER BY tblJobTickets.ScheduleDate "
            ds = DBHelper.GetDataSet(strSQL, "tblInvoicing")
            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("No matching records found. Cancelling report...", MsgBoxStyle.Information, "No Data")
                Exit Sub
            End If
            objRpt.SetDataSource(ds)
            DBHelper.Authenticate(objRpt)
            Me.SetDateRange(objRpt)
            Dim frmSR As New frmReport
            frmSR.WindowState = FormWindowState.Maximized
            frmSR.CrystalReportViewer1.ReportSource = objRpt
            frmSR.CrystalReportViewer1.RefreshReport()
            frmSR.Show()

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally
            objRpt = Nothing
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Sub

    Private Sub btnManifests_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManifests.Click, btnHazLoads.Click, btnHAZReport.Click

        If Me.ValidateDates = False Then Exit Sub
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet, strSQL As String
        Dim strWasteType As String = ""
        Dim objRpt As ReportDocument

        Try
            Dim FROMDate As Date
            Dim ToDate As Date
            If CType(sender, Button).Name = "btnManifests" Then
                FROMDate = Me.FROMDate.Value.ToShortDateString
                ToDate = Me.TODate.Value.ToShortDateString
                objRpt = New rpt_EPA_Manifests
                strWasteType = "Non HAZARDOUS','NonHAZARDOUS"
            ElseIf CType(sender, Button).Name = "btnHazLoads" Then
                FROMDate = Me.FROMDate.Value.ToShortDateString
                ToDate = Me.TODate.Value.ToShortDateString
                objRpt = New rpt_EPA_Hazardous
                strWasteType = "HAZARDOUS','HAZAROUS"
            ElseIf CType(sender, Button).Name = "btnHAZReport" Then
                FROMDate = Me.StartDate.Value.ToShortDateString
                ToDate = Me.EndDate.Value.ToShortDateString
                objRpt = New rpt_EPA_Hazardous_old
                strWasteType = "HAZARDOUS','HAZAROUS"
            ElseIf CType(sender, Button).Name = "btnGeneratorReport" Then
                FROMDate = Me.StartDate.Value.ToShortDateString
                ToDate = Me.EndDate.Value.ToShortDateString
                objRpt = New rptGenerator
                strWasteType = "HAZARDOUS','HAZAROUS','Non HAZARDOUS','NonHAZARDOUS','GARY PLANT','GARYPLANT','MULTI-STOP','MULTISTOP','B.O.L.','B.O.L"
            End If
            'strSQL = "SELECT DISTINCT tblJobTickets.ManifestNo, tblJobTickets.ScheduleDate, tblGenerators.GNo AS GenNo, tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, tblJobTickets_Details.Quantity, tblProducts.HWNumber, tblProducts.HWNumber, tblJobTickets.bsw, tblJobTickets.JobTicketNo, tblGenerators.BrokerName, tblProducts.ApprovalNo FROM (((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) INNER JOIN tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) WHERE ((tblJobTickets.Hazardous = TRUE) OR (tblJobTickets.NonHazardous = TRUE)) and tblJobTickets.ScheduleDate BETWEEN #" & Me.txtStartDate.Text & "# AND #" & Me.txtEndDate.Text & "# ORDER BY tblJobTickets.ScheduleDate"
            strSQL = "SELECT DISTINCT tblJobTickets.JobTicketID, tblJobTickets.ManifestNo, tblJobTickets.ScheduleDate, " _
                            & " tblGenerators.GNo AS GenNo, tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteAddress1, " _
                            & " tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, " _
                            & " tblJobTickets.Gallons as Quantity,tblProducts.HWNumber, tblJobTickets.bsw, " _
                            & " tblJobTickets.JobTicketNo, tblGenerators.BrokerName, tblProducts.ApprovalNo,tblTransporters.TransporterName as TransporterName,tblJobTickets.WasteType " _
                    & " FROM ((((tblGenerators LEFT OUTER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) " _
                            & " LEFT OUTER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) LEFT OUTER JOIN " _
                            & " tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) " _
                            & " LEFT OUTER JOIN tblTransporters ON tblTransporters.TransporterID = tblJobTickets.TransporterID)" _
                        & " WHERE (tblJobTickets.JobClosed = TRUE) AND (tblJobTickets.IsCancelled = False) AND (tblJobTickets.WasteType in ('" & strWasteType.Trim & "'))  and " _
                            & " (tblJobTickets.ScheduleDate BETWEEN #" & FROMDate & "# AND #" & ToDate & "#) " _
                            & " ORDER BY tblGenerators.GeneratorName "

            ds = DBHelper.GetDataSet(strSQL, "tblInvoicing")
            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("No matching records found. Cancelling report...", MsgBoxStyle.Information, "No Data")
                Exit Sub
            End If
            '#If Export to Excel file is checked then 
            If Me.chkExcelReport.Checked = True Then
                Me.fncExcelExport(ds)
                Exit Sub
            End If
            objRpt.SetDataSource(ds)
            DBHelper.Authenticate(objRpt)

            If CType(sender, Button).Name = "btnManifests" Then
                Me.SetDateRange_Load(objRpt)
            ElseIf CType(sender, Button).Name = "btnHazLoads" Then
                Me.SetDateRange_Load(objRpt)
            ElseIf CType(sender, Button).Name = "btnHAZReport" Then
                Me.SetDateRange(objRpt)
            ElseIf CType(sender, Button).Name = "btnGeneratorReport" Then
                Me.SetDateRange(objRpt)
            End If
            Dim frmSR As New frmReport
            frmSR.WindowState = FormWindowState.Maximized
            frmSR.CrystalReportViewer1.ReportSource = objRpt
            frmSR.CrystalReportViewer1.RefreshReport()
            frmSR.Show()
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
        Finally
            objRpt = Nothing
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnBOLs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBOLs.Click

        If Me.ValidateDates = False Then Exit Sub

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim objRpt As New rpt_EPA_BOLs
        Dim ds As DataSet, strSQL As String

        Try
            strSQL = "SELECT DISTINCT tblJobTickets.JobTicketID,tblInvoicing.InvoiceNo, tblGenerators.GeneratorName, tblGenerators.JobSite, tblJobTickets.TicketNo, " _
                    & " tblJobTickets.Gallons as Quantity,tblJobTickets.ManifestNo,tblJobTickets.DisposalFacilityID, tblJobTickets.ScheduleDate,tblProducts.ApprovalNo FROM ((((tblGenerators LEFT OUTER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) LEFT OUTER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) LEFT OUTER JOIN tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) LEFT OUTER JOIN tblInvoicing ON tblJobTickets.JobTicketID = tblInvoicing.JobTicketID) WHERE (tblJobTickets.JobClosed = TRUE) AND (tblJobTickets.IsCancelled = False) AND (tblJobTickets.WasteType in ('B.O.L.','B.O.L'))  and (tblJobTickets.ScheduleDate BETWEEN #" & FROMDate.Value.ToShortDateString & "# AND #" & TODate.Value.ToShortDateString & "#) ORDER BY tblGenerators.GeneratorName, tblGenerators.JobSite, tblJobTickets.TicketNo "
            ds = DBHelper.GetDataSet(strSQL, "tblInvoicing")
            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("No matching records found. Cancelling report...", MsgBoxStyle.Information, "No Data")
                Exit Sub
            End If
            '#If Export to Excel file is checked then 
            If Me.chkExcelReport.Checked = True Then
                Me.fncExcelExport(ds)
                Exit Sub
            End If

            objRpt.SetDataSource(ds)
            DBHelper.Authenticate(objRpt)
            Me.SetDateRange_Load(objRpt)

            Dim frmSR As New frmReport
            frmSR.WindowState = FormWindowState.Maximized
            frmSR.CrystalReportViewer1.ReportSource = objRpt
            frmSR.CrystalReportViewer1.RefreshReport()
            frmSR.Show()

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally
            objRpt = Nothing
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Sub

    Private Sub btnManifestsInHouse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManifestsInHouse.Click


        If Me.ValidateDates = False Then Exit Sub

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim objRpt As New rpt_InHouseManifests
        Dim ds As DataSet, strSQL As String

        Try
            strSQL = "SELECT DISTINCT tblJobTickets.JobTicketID,tblInvoicing.InvoiceNo, tblGenerators.GeneratorName, tblGenerators.JobSite, " _
                    & " tblGenerators.JobSiteCity, tblJobTickets.ManifestNo, tblTransporters.TransporterName, tblJobTickets.Gallons as Quantity, " _
                    & " tblJobTickets.Drums, tblJobTickets.ScheduleDate,tblProducts.ApprovalNo FROM (((((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) INNER JOIN tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) LEFT OUTER JOIN tblTransporters ON tblJobTickets.TransporterID = tblTransporters.TransporterID) LEFT OUTER JOIN tblInvoicing ON tblJobTickets.JobTicketID = tblInvoicing.JobTicketID) WHERE (tblJobTickets.JobClosed = TRUE) AND (tblJobTickets.IsCancelled = False) AND (tblJobTickets.WasteType IN ('GARY PLANT','GARYPLANT'))  and (tblJobTickets.ScheduleDate BETWEEN #" & FROMDate.Value.ToShortDateString & "# AND #" & TODate.Value.ToShortDateString & "#) ORDER BY tblGenerators.GeneratorName "
            ds = DBHelper.GetDataSet(strSQL, "tblInvoicing")
            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("No matching records found. Cancelling report...", MsgBoxStyle.Information, "No Data")
                Exit Sub
            End If
            '#If Export to Excel file is checked then 
            If Me.chkExcelReport.Checked = True Then
                Me.fncExcelExport(ds)
                Exit Sub
            End If

            objRpt.SetDataSource(ds)
            DBHelper.Authenticate(objRpt)
            Me.SetDateRange_Load(objRpt)

            Dim frmSR As New frmReport
            frmSR.WindowState = FormWindowState.Maximized
            frmSR.CrystalReportViewer1.ReportSource = objRpt
            frmSR.CrystalReportViewer1.RefreshReport()
            frmSR.Show()

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally
            objRpt = Nothing
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Sub

    Function ValidateDates() As Boolean

        ValidateDates = True
        If Me.FROMDate.Value.ToString.Trim <> "" Then
            If IsDate(Me.FROMDate.Value) = False Then
                MsgBox("Start Date is invalid. Please enter a valid date.", MsgBoxStyle.Information, "Date Range")
                Me.FROMDate.Focus()
                ValidateDates = False
            End If
        Else
            MsgBox("Start Date is missing. Please enter a valid date.", MsgBoxStyle.Information, "Date Range")
            Me.FROMDate.Focus()
            ValidateDates = False
        End If
        If Me.TODate.Value.ToString.Trim <> "" Then
            If IsDate(Me.TODate.Value) = False Then
                MsgBox("End Date is invalid. Please enter a valid date.", MsgBoxStyle.Information, "Date Range")
                Me.TODate.Focus()
                ValidateDates = False
            End If
        Else
            MsgBox("End Date is missing. Please enter a valid date.", MsgBoxStyle.Information, "Date Range")
            Me.TODate.Focus()
            ValidateDates = False
        End If

    End Function

    Private Sub btnMulti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMulti.Click

        If Me.ValidateDates = False Then Exit Sub

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim objRpt As New rpt_EPA_BOLs
        Dim ds As DataSet, strSQL As String

        Try
            'strSQL = "SELECT tblInvoicing.InvoiceNo, tblGenerators.GeneratorName, tblGenerators.JobSite, tblJobTickets.TicketNo, tblJobTickets_Details.Quantity, tblJobTickets.ManifestNo, tblJobTickets.DisposalFacilityID FROM ((((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) INNER JOIN tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) INNER JOIN tblInvoicing ON tblJobTickets.JobTicketID = tblInvoicing.JobTicketID) WHERE (tblJobTickets.IsMultiStop = TRUE) and tblJobTickets.ScheduleDate BETWEEN #" & Me.txtStartDate.Text & "# AND #" & Me.txtEndDate.Text & "# ORDER BY tblGenerators.GeneratorName, tblGenerators.JobSite, tblJobTickets.TicketNo "
            strSQL = "SELECT DISTINCT tblJobTickets.JobTicketID,tblInvoicing.InvoiceNo, tblGenerators.GeneratorName, tblGenerators.JobSite, " _
                    & " tblJobTickets.TicketNo, tblJobTickets.Gallons as Quantity,tblJobTickets.ManifestNo,tblJobTickets.DisposalFacilityID, " _
                    & " tblJobTickets.ScheduleDate,tblProducts.ApprovalNo FROM ((((tblGenerators LEFT OUTER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) LEFT OUTER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) LEFT OUTER JOIN tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) LEFT OUTER JOIN tblInvoicing ON tblJobTickets.JobTicketID = tblInvoicing.JobTicketID) WHERE (tblJobTickets.JobClosed = TRUE) AND (tblJobTickets.IsCancelled = False) AND (tblJobTickets.WasteType in ('MULTI-STOP','MULTISTOP'))  and (tblJobTickets.ScheduleDate BETWEEN #" & FROMDate.Value.ToShortDateString & "# AND #" & TODate.Value.ToShortDateString & "#) ORDER BY tblGenerators.GeneratorName, tblGenerators.JobSite, tblJobTickets.TicketNo "
            ds = DBHelper.GetDataSet(strSQL, "tblInvoicing")
            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("No matching records found. Cancelling report...", MsgBoxStyle.Information, "No Data")
                Exit Sub
            End If
            '#If Export to Excel file is checked then 
            If Me.chkExcelReport.Checked = True Then
                Me.fncExcelExport(ds)
                Exit Sub
            End If

            objRpt.SetDataSource(ds)
            DBHelper.Authenticate(objRpt)
            Me.SetDateRange_Load(objRpt)

            Dim frmSR As New frmReport
            frmSR.WindowState = FormWindowState.Maximized
            frmSR.CrystalReportViewer1.ReportSource = objRpt
            frmSR.CrystalReportViewer1.RefreshReport()
            frmSR.Show()

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally
            objRpt = Nothing
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Sub
    Public Function SetDateRange(ByRef rpt As ReportDocument)
        Dim fFields As FormulaFieldDefinitions = rpt.DataDefinition.FormulaFields
        Dim fField As FormulaFieldDefinition

        Dim fromDate As Date = Me.StartDate.Value.ToShortDateString
        Dim toDate As Date = Me.EndDate.Value.ToShortDateString

        dateRange = "FROM " & fromDate.ToShortDateString & " TO " & toDate.ToShortDateString
        'Update Date Range Formula field with date range
        fField = fFields.Item("DateRange")
        fField.Text = """" & dateRange & """"
        'fField.Text = dateRange

    End Function
    Public Function SetDateRange_Load(ByRef rpt As ReportDocument)
        Dim fFields As FormulaFieldDefinitions = rpt.DataDefinition.FormulaFields
        Dim fField As FormulaFieldDefinition
        dateRange = "FROM " & FROMDate.Value.ToShortDateString & " TO " & TODate.Value.ToShortDateString
        'Update Date Range Formula field with date range
        fField = fFields.Item("DateRange")
        fField.Text = """" & dateRange & """"
        'fField.Text = dateRange
    End Function
    Private Sub btnNonHazardous_Daily_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNonHazardous_Daily.Click, btnGaryPlant_Daily.Click, btnMultiStop_Daily.Click, btnBOL_Daily.Click
        If Me.ValidateDates = False Then Exit Sub
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet, strSQL As String
        Dim strWasteType As String = ""
        Dim objRpt As ReportDocument
        Try


            If CType(sender, Button).Name = "btnNonHazardous_Daily" OrElse CType(sender, Button).Name = "btnHazardous_Daily" Then
                objRpt = New rptDailyHazNonHaz
                strWasteType = "Non HAZARDOUS','HAZARDOUS','NonHAZARDOUS"
            ElseIf CType(sender, Button).Name = "btnGaryPlant_Daily" Then
                objRpt = New rptDailyPlant2
                strWasteType = "GARY PLANT','GARYPLANT"
            ElseIf CType(sender, Button).Name = "btnMultiStop_Daily" Then
                objRpt = New rptDailyPlant2
                strWasteType = "MULTI-STOP','MULTISTOP"
            ElseIf CType(sender, Button).Name = "btnBOL_Daily" Then
                objRpt = New rptDailyPlant2
                strWasteType = "B.O.L.','B.O.L"
            End If
            'strSQL = "SELECT DISTINCT tblJobTickets.ManifestNo, tblJobTickets.ScheduleDate, tblGenerators.GNo AS GenNo, tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, tblJobTickets_Details.Quantity, tblProducts.HWNumber, tblProducts.HWNumber, tblJobTickets.bsw, tblJobTickets.JobTicketNo, tblGenerators.BrokerName, tblProducts.ApprovalNo FROM (((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) INNER JOIN tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) WHERE ((tblJobTickets.Hazardous = TRUE) OR (tblJobTickets.NonHazardous = TRUE)) and tblJobTickets.ScheduleDate BETWEEN #" & Me.txtStartDate.Text & "# AND #" & Me.txtEndDate.Text & "# ORDER BY tblJobTickets.ScheduleDate"
            strSQL = "SELECT DISTINCT tblJobTickets.JobTicketID, tblJobTickets.ManifestNo, tblJobTickets.ScheduleDate, " _
                            & " tblGenerators.GNo AS GenNo, tblGenerators.GeneratorName, tblGenerators.JobSiteAddress1, " _
                            & " tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, " _
                            & " tblJobTickets.Gallons as Quantity,tblProducts.HWNumber, tblJobTickets.bsw, " _
                            & " tblJobTickets.JobTicketNo, tblGenerators.BrokerName, tblProducts.ApprovalNo,tblTransporters.TransporterName as TransporterName, " _
                            & " tblGenerators.JobSite, tblJobTickets.WasteType, tblJobTickets.Drums, tblJobTickets.TicketNo " _
                    & " FROM ((((tblGenerators LEFT OUTER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) " _
                            & " LEFT OUTER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) LEFT OUTER JOIN " _
                            & " tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) " _
                            & " LEFT OUTER JOIN tblTransporters ON tblTransporters.TransporterID = tblJobTickets.TransporterID)" _
                        & " WHERE (tblJobTickets.JobClosed = TRUE) AND (tblJobTickets.IsCancelled = False) AND (tblJobTickets.WasteType in ('" & strWasteType.Trim & "'))  and " _
                                & " (tblJobTickets.ScheduleDate BETWEEN #" & StartDate.Value.ToShortDateString & "# AND #" & EndDate.Value.ToShortDateString & "#) "

            ds = DBHelper.GetDataSet(strSQL, "DailyLog")
            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("No matching records found. Cancelling report...", MsgBoxStyle.Information, "No Data")
                Exit Sub
            End If
            '#If Export to Excel file is checked then 
            If Me.chkExcelReport.Checked = True Then
                Me.fncExcelExport(ds)
                Exit Sub
            End If
            objRpt.SetDataSource(ds.Tables(0))
            DBHelper.Authenticate(objRpt)

            Me.SetDateRange(objRpt)

            Dim frmSR As New frmReport
            frmSR.WindowState = FormWindowState.Maximized
            frmSR.CrystalReportViewer1.ReportSource = objRpt
            frmSR.CrystalReportViewer1.RefreshReport()
            frmSR.Show()
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
        Finally
            objRpt = Nothing
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnFESTLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFESTLog.Click
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet, strSQL As String
        Dim strWasteType As String = ""
        Dim objRpt As ReportDocument
        Try
            objRpt = New rpt_FEST_Log

            strWasteType = "Non HAZARDOUS','NonHAZARDOUS','HAZARDOUS','HAZAROUS"

            'FROMDate = Me.DateActivity.Value.Month & "/01/" & Me.DateActivity.Value.Year
            'TODate = Me.DateActivity.Value.Month & "/" & Date.DaysInMonth(Me.DateActivity.Value.Year, Me.DateActivity.Value.Month).ToString & "/" & Me.DateActivity.Value.Year


            'strSQL = "SELECT DISTINCT tblJobTickets.ManifestNo, tblJobTickets.ScheduleDate, tblGenerators.GNo AS GenNo, tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, tblJobTickets_Details.Quantity, tblProducts.HWNumber, tblProducts.HWNumber, tblJobTickets.bsw, tblJobTickets.JobTicketNo, tblGenerators.BrokerName, tblProducts.ApprovalNo FROM (((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) INNER JOIN tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) WHERE ((tblJobTickets.Hazardous = TRUE) OR (tblJobTickets.NonHazardous = TRUE)) and tblJobTickets.ScheduleDate BETWEEN #" & Me.txtStartDate.Text & "# AND #" & Me.txtEndDate.Text & "# ORDER BY tblJobTickets.ScheduleDate"
            If Me.chkExcelReport.Checked = True Then
                strSQL = "SELECT DISTINCT tblJobTickets.JobTicketID, tblJobTickets.ManifestNo, tblJobTickets.ScheduleDate, " _
                            & " tblGenerators.GNo AS GenNo, tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteAddress1, " _
                            & " tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, " _
                            & " tblJobTickets.Gallons as Quantity,tblProducts.HWNumber, tblJobTickets.bsw, " _
                            & " tblJobTickets.TicketNo as JobTicketNo, tblGenerators.BrokerName, tblProducts.ApprovalNo,tblTransporters.TransporterName as TransporterName,tblJobTickets.WasteType,tblProducts.AdditionalHWNumber " _
                    & " FROM ((((tblGenerators LEFT OUTER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) " _
                            & " LEFT OUTER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) LEFT OUTER JOIN " _
                            & " tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) " _
                            & " LEFT OUTER JOIN tblTransporters ON tblTransporters.TransporterID = tblJobTickets.TransporterID)" _
                        & " WHERE (tblJobTickets.JobClosed = TRUE) AND (tblJobTickets.IsCancelled = False) AND (tblJobTickets.WasteType in ('" & strWasteType.Trim & "'))  and " _
                            & " (tblJobTickets.ScheduleDate BETWEEN #" & FROMDate.Value.ToShortDateString & "# AND #" & TODate.Value.ToShortDateString & "#) " _
                            & " ORDER BY tblGenerators.GeneratorName "
            Else
                strSQL = "SELECT DISTINCT tblJobTickets.JobTicketID, tblJobTickets.ManifestNo, tblJobTickets.ScheduleDate, " _
                            & " tblGenerators.GNo AS GenNo, Left(tblGenerators.GeneratorName,18) as JobSite, Left(tblGenerators.JobSiteAddress1,12) as JobSiteAddress1, " _
                            & " Left(tblGenerators.JobSiteCity,8) as JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, " _
                            & " tblJobTickets.Gallons as Quantity,tblProducts.HWNumber, tblJobTickets.bsw, " _
                            & " tblJobTickets.TicketNo as JobTicketNo, Left(tblGenerators.BrokerName,14) AS BrokerName, tblProducts.ApprovalNo,tblTransporters.TransporterName as TransporterName,tblJobTickets.WasteType,tblProducts.AdditionalHWNumber " _
                    & " FROM ((((tblGenerators LEFT OUTER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) " _
                            & " LEFT OUTER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) LEFT OUTER JOIN " _
                            & " tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) " _
                            & " LEFT OUTER JOIN tblTransporters ON tblTransporters.TransporterID = tblJobTickets.TransporterID)" _
                        & " WHERE (tblJobTickets.JobClosed = TRUE) AND (tblJobTickets.IsCancelled = False) AND (tblJobTickets.WasteType in ('" & strWasteType.Trim & "'))  and " _
                            & " (tblJobTickets.ScheduleDate BETWEEN #" & FROMDate.Value.ToShortDateString & "# AND #" & TODate.Value.ToShortDateString & "#) "
            End If
            ds = DBHelper.GetDataSet(strSQL, "tblInvoicing")
            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("No matching records found. Cancelling report...", MsgBoxStyle.Information, "No Data")
                Exit Sub
            End If

            '#If Export to Excel file is checked then 
            If Me.chkExcelReport.Checked = True Then
                Me.fncExcelExport(ds)
                Exit Sub
            End If

            objRpt.SetDataSource(ds)
            DBHelper.Authenticate(objRpt)

            Me.SetDateRange_Load(objRpt)

            Dim frmSR As New frmReport
            frmSR.WindowState = FormWindowState.Maximized
            frmSR.CrystalReportViewer1.ReportSource = objRpt
            frmSR.CrystalReportViewer1.RefreshReport()
            frmSR.Show()

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally
            objRpt = Nothing
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Sub
    Private Sub btnMWRDReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMWRDReport.Click

        If Me.ValidateDates = False Then Exit Sub
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet, strSQL As String
        Dim strWasteType As String = ""
        Dim objRpt As ReportDocument


        Try
            objRpt = New rptMWRDReport
            strWasteType = "Non HAZARDOUS','HAZARDOUS','NonHAZARDOUS"

            strSQL = " SELECT tblGenerators.GNo, tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, " _
                   & " tblGenerators.JobSiteState, tblGenerators.JobSiteZip, tblJobTickets.ManifestNo, " _
                   & " tblProducts.HWNumber, tblJobTickets.Gallons as Quantity " _
            & " FROM (tblGenerators INNER JOIN (tblJobTickets INNER JOIN tblProducts ON tblJobTickets.ProductID = tblProducts.ProductID) ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID " _
            & " WHERE (tblJobTickets.JobClosed = TRUE) AND (tblJobTickets.IsCancelled = False) AND (tblJobTickets.WasteType in ('" & strWasteType.Trim & "'))  and " _
                            & " (tblJobTickets.ScheduleDate BETWEEN #" & Me.StartDate.Value.ToShortDateString & "# AND #" & Me.EndDate.Value.ToShortDateString & "#) "

            ds = DBHelper.GetDataSet(strSQL, "MWRDReport")
            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("No matching records found. Cancelling report...", MsgBoxStyle.Information, "No Data")
                Exit Sub
            End If
            '#If Export to Excel file is checked then 
            If Me.chkExcelReport.Checked = True Then
                Me.fncExcelExport(ds)
                Exit Sub
            End If


            objRpt.SetDataSource(ds)
            DBHelper.Authenticate(objRpt)
            Me.SetDateRange(objRpt)
            Dim frmSR As New frmReport
            frmSR.WindowState = FormWindowState.Maximized
            frmSR.CrystalReportViewer1.ReportSource = objRpt
            frmSR.CrystalReportViewer1.RefreshReport()
            frmSR.Show()

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
        Finally
            objRpt = Nothing
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub
    Private Function fncExcelExport(ByVal dsExcelExport As DataSet)
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim strFileName As String
        Dim TotalGallons As Integer = 0
        Dim Excel As New Excel.Application
        If Me.SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            strFileName = Me.SaveFileDialog1.FileName
        End If
        If strFileName.Trim = "" Then
            MsgBox("Please,Enter excel file name.")
            Exit Function
        End If
        Try
            Dim intColumn, intRow, intColumnValue As Integer
            Dim strExcelFile As String

            With Excel
                .SheetsInNewWorkbook = 1
                .Workbooks.Add()
                .Worksheets(1).Select()
                'For displaying the column name in the the excel file.
                For intColumn = 0 To dsExcelExport.Tables(0).Columns.Count - 1
                    .Cells(1, intColumn + 1).Value = dsExcelExport.Tables(0).Columns(intColumn).ColumnName.ToString
                    .Cells(1, intColumn + 1).Font.Bold() = True
                Next
                .Columns(4).NumberFormatLocal = "@"
                'For displaying the column value row-by-row in the the excel file.
                For intRow = 1 To dsExcelExport.Tables(0).Rows.Count
                    For intColumnValue = 0 To dsExcelExport.Tables(0).Columns.Count - 1
                        .Cells(intRow + 1, intColumnValue + 1).Value = dsExcelExport.Tables(0).Rows(intRow - 1).ItemArray(intColumnValue).ToString
                        If intColumnValue = 9 AndAlso IsNumeric(dsExcelExport.Tables(0).Rows(intRow - 1).ItemArray(intColumnValue)) = True Then
                            TotalGallons = TotalGallons + CType(dsExcelExport.Tables(0).Rows(intRow - 1).ItemArray(intColumnValue), Integer)
                        End If
                    Next
                Next

                '.Cells(intRow + 1, 10).Value = TotalGallons
                .Cells(intRow + 1, 10).Formula = "=SUM(J2:J" & intRow & ")"
                .Cells(intRow + 1, 10).Font.Bold() = True
                .Columns.AutoFit()
                .ActiveWorkbook.SaveAs(strFileName)
                .ActiveWorkbook.Saved = True
                .ActiveWorkbook.Close()
            End With
            MessageBox.Show("File exported sucessfully.", "Exporting done", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Excel.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(Excel)
            Excel = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
        Cursor.Current = System.Windows.Forms.Cursors.Default
    End Function

    Private Sub dotMatrix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dotMatrix.Click
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet, strSQL As String
        Dim strWasteType As String = ""
        Dim objRpt As ReportDocument

        objRpt = New rpt_FEST_Log
        'objRpt.PrintOptions.PaperSize = PaperSize.PaperA4 
        strWasteType = "Non HAZARDOUS','NonHAZARDOUS','HAZARDOUS','HAZAROUS"

        'FROMDate = Me.DateActivity.Value.Month & "/01/" & Me.DateActivity.Value.Year
        'TODate = Me.DateActivity.Value.Month & "/" & Date.DaysInMonth(Me.DateActivity.Value.Year, Me.DateActivity.Value.Month).ToString & "/" & Me.DateActivity.Value.Year


        'strSQL = "SELECT DISTINCT tblJobTickets.ManifestNo, tblJobTickets.ScheduleDate, tblGenerators.GNo AS GenNo, tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, tblJobTickets_Details.Quantity, tblProducts.HWNumber, tblProducts.HWNumber, tblJobTickets.bsw, tblJobTickets.JobTicketNo, tblGenerators.BrokerName, tblProducts.ApprovalNo FROM (((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) INNER JOIN tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) WHERE ((tblJobTickets.Hazardous = TRUE) OR (tblJobTickets.NonHazardous = TRUE)) and tblJobTickets.ScheduleDate BETWEEN #" & Me.txtStartDate.Text & "# AND #" & Me.txtEndDate.Text & "# ORDER BY tblJobTickets.ScheduleDate"
        strSQL = "SELECT DISTINCT tblJobTickets.JobTicketID,tblJobTickets.ScheduleDate, tblJobTickets.ManifestNo,  " _
                        & " tblJobTickets.TicketNo as JobTicketNo,tblGenerators.GNo AS GenNo, tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteAddress1, " _
                        & " tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, " _
                        & " tblJobTickets.Gallons as Quantity,tblProducts.ApprovalNo, " _
                        & "  tblJobTickets.bsw,tblProducts.HWNumber,tblGenerators.BrokerName, tblTransporters.TransporterName as TransporterName,tblJobTickets.WasteType " _
                & " FROM ((((tblGenerators LEFT OUTER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) " _
                        & " LEFT OUTER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) LEFT OUTER JOIN " _
                        & " tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) " _
                        & " LEFT OUTER JOIN tblTransporters ON tblTransporters.TransporterID = tblJobTickets.TransporterID)" _
                    & " WHERE (tblJobTickets.JobClosed = TRUE) AND (tblJobTickets.IsCancelled = False) AND (tblJobTickets.WasteType in ('" & strWasteType.Trim & "'))  and " _
                        & " (tblJobTickets.ScheduleDate BETWEEN #" & FROMDate.Value.ToShortDateString & "# AND #" & TODate.Value.ToShortDateString & "#) " _
                        & " ORDER BY tblGenerators.GeneratorName "
        ds = DBHelper.GetDataSet(strSQL, "tblInvoicing")
        If ds.Tables(0).Rows.Count = 0 Then
            MsgBox("No matching records found. Cancelling report...", MsgBoxStyle.Information, "No Data")
            Exit Sub
        End If

        '#If Export to Excel file is checked then 
        If Me.chkExcelReport.Checked = True Then
            Me.fncExcelExport(ds)
            Exit Sub
        End If

        Dim pd As New PrintDialog
        Dim strfilePath As String = "C:\FESTLOG.txt"
        Dim fs As FileStream = New FileStream(strfilePath, FileMode.Create, FileAccess.Write)
        Dim objFile As StreamWriter = New StreamWriter(fs)
        Dim i, j As Short
        Dim MaxLength As Integer = 0
        Dim ColLength As Integer = 0
        Dim strLine As String
        Dim strlength(ds.Tables(0).Columns.Count) As Short
        If Not ds Is Nothing AndAlso ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
            For i = 0 To ds.Tables(0).Columns.Count - 1
                ColLength = Len(Me.MapColumnName(ds.Tables(0).Columns(i).ColumnName.Trim))
                If ds.Tables(0).Columns(i).ColumnName = "JobTicketID" Or ds.Tables(0).Columns(i).ColumnName = "WasteType" Then
                Else
                    If ds.Tables(0).Columns(i).ColumnName.IndexOf("Date") <> -1 Then
                        For j = 0 To ds.Tables(0).Rows.Count - 1
                            If MaxLength < Len(CDate(ds.Tables(0).Rows(j).Item(i).ToString).ToShortDateString) Then
                                MaxLength = Len(CDate(ds.Tables(0).Rows(j).Item(i).ToString).ToShortDateString.Trim)
                            End If
                        Next
                    Else
                        For j = 0 To ds.Tables(0).Rows.Count - 1
                            If MaxLength < Len(ds.Tables(0).Rows(j).Item(i).ToString.Trim) Then
                                MaxLength = Len(ds.Tables(0).Rows(j).Item(i).ToString.Trim)
                            End If
                        Next
                    End If
                End If
                If MaxLength < ColLength Then
                    MaxLength = ColLength
                End If
                If i = ds.Tables(0).Columns.Count - 1 Then
                    strlength(i) = 15
                ElseIf MaxLength > 20 Then
                    If ds.Tables(0).Columns(i).ColumnName.Trim.IndexOf("City") <> -1 Or _
                            ds.Tables(0).Columns(i).ColumnName.Trim.IndexOf("BrokerName") <> -1 Or _
                            ds.Tables(0).Columns(i).ColumnName.Trim.IndexOf("TransporterName") <> -1 Then
                        strlength(i) = 12
                    Else
                        strlength(i) = 25
                    End If
                Else
                    strlength(i) = MaxLength
                End If
                MaxLength = 0
            Next
        End If

        If Not ds Is Nothing AndAlso ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
            For i = 0 To ds.Tables(0).Columns.Count - 1
                If ds.Tables(0).Columns(i).ColumnName = "JobTicketID" Or ds.Tables(0).Columns(i).ColumnName = "WasteType" Then
                Else
                    strLine = strLine & Me.MapColumnName(ds.Tables(0).Columns(i).ColumnName.ToString).Trim.PadRight(strlength(i), " ")
                    strLine = strLine & " "
                End If
            Next
        End If
        objFile.WriteLine(strLine)

        If Not ds Is Nothing AndAlso ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                strLine = ""
                For j = 0 To ds.Tables(0).Columns.Count - 1
                    If ds.Tables(0).Columns(j).ColumnName = "JobTicketID" Or ds.Tables(0).Columns(j).ColumnName = "WasteType" Then
                    Else
                        If ds.Tables(0).Columns(j).ColumnName.IndexOf("Date") <> -1 Then
                            strLine = strLine & CDate(ds.Tables(0).Rows(i).Item(j).ToString).ToShortDateString.PadRight(strlength(j), " ")
                        Else
                            strLine = strLine & Mid((ds.Tables(0).Rows(i).Item(j).ToString.PadRight(strlength(j), " ")), 1, strlength(j))
                        End If
                        strLine = strLine & " "
                    End If
                Next
                objFile.WriteLine(strLine)
            Next

        End If
        objFile.Close()
        Dim NotepadPro As Process = New Process
        NotepadPro.Start("Notepad.exe", "C:\FESTLOG.txt")
    End Sub
    Private Function MapColumnName(ByVal strColumnName As String) As String
        Dim strMapName As String = ""
        Select Case strColumnName
            Case "ScheduleDate"
                strMapName = "Sch.Date"
            Case "ManifestNo"
                strMapName = "Manifest#"
            Case "GenNo"
                strMapName = "Generator#"
            Case "JobSite"
                strMapName = "Generator"
            Case "JobSiteAddress1"
                strMapName = "Address1"
            Case "JobSiteCity"
                strMapName = "City"
            Case "JobSiteState"
                strMapName = "St"
            Case "JobSiteZip"
                strMapName = "Zip"
            Case "Quantity"
                strMapName = "Gal."
            Case "HWNumber"
                strMapName = "HW #"
            Case "bsw"
                strMapName = "BS&W"
            Case "JobTicketNo"
                strMapName = "Ticket#"
            Case "BrokerName"
                strMapName = "CustomerName"
            Case "ApprovalNo"
                strMapName = "Approval#"
            Case "TransporterName"
                strMapName = "Transporter"
            Case "WasteType"
                strMapName = "Waste Type"
        End Select
        Return strMapName.Trim
    End Function
    Private Function GetGeneratorIDString() As String
        Dim StrSelect As String
        Dim jj As Integer
        Dim i, j As Integer
        Dim dgitem As DataGridCell

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        If Not Me.dsGenerator Is Nothing AndAlso Me.dsGenerator.Tables(0).Rows.Count > 0 Then
            For i = 0 To Me.dsGenerator.Tables(0).Rows.Count - 1
                If j = 0 Then
                    StrSelect = Me.dgSearchProduct.Item(i, 6).ToString
                    j = i + 1
                Else
                    If Me.chkProduct.SelectedIndices.Count > 0 Then
                        StrSelect = StrSelect & "," & Me.dgSearchProduct.Item(i, 6).ToString
                    End If
                End If
            Next
        End If
        Cursor.Current = System.Windows.Forms.Cursors.Default
        Return StrSelect
    End Function
    Private Function GetProductIDString() As String
        Dim StrSelect As String
        Dim jj As Integer
        Dim i, j As Integer
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        For Each jj In Me.chkProduct.CheckedIndices
            Me.chkProduct.SelectedIndex = jj
            If i = 0 Then
                StrSelect = Me.chkProduct.SelectedValue
                i = i + 1
            Else
                If Me.chkProduct.SelectedIndices.Count > 0 Then
                    StrSelect = StrSelect & "," & Me.chkProduct.SelectedValue.ToString
                End If
            End If
        Next
        Cursor.Current = System.Windows.Forms.Cursors.Default
        Return StrSelect
    End Function


    Private Sub btnGeneratorReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeneratorReport.Click
        If Me.ValidateDates = False Then Exit Sub
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet, strSQL As String
        Dim strWasteType As String = ""
        Dim strProductID As String = ""
        Dim objRpt As ReportDocument

        Try
            Dim FROMDate As Date
            Dim ToDate As Date
            FROMDate = Me.StartDate.Value.ToShortDateString
            ToDate = Me.EndDate.Value.ToShortDateString
            objRpt = New rptGenerator
            strWasteType = "HAZARDOUS','HAZAROUS','Non HAZARDOUS','NonHAZARDOUS','GARY PLANT','GARYPLANT','MULTI-STOP','MULTISTOP','B.O.L.','B.O.L"

            strProductID = Me.GetProductIDString()
            If Me.genID = 0 Then
                strSQL = "SELECT DISTINCT tblJobTickets.JobTicketID, tblJobTickets.ManifestNo, tblJobTickets.ScheduleDate, " _
                                & " tblGenerators.GNo AS GenNo, tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteAddress1, " _
                                & " tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, " _
                                & " tblJobTickets.Gallons as Quantity,tblProducts.HWNumber, tblJobTickets.bsw, " _
                                & " tblJobTickets.JobTicketNo, tblGenerators.BrokerName, tblProducts.ApprovalNo,tblTransporters.TransporterName as TransporterName,tblJobTickets.WasteType, " _
                                & " tblProducts.ProductName + ' : ' + tblProducts.ApprovalNo as ProductName " _
                        & " FROM ((((tblGenerators LEFT OUTER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) " _
                                & " LEFT OUTER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) LEFT OUTER JOIN " _
                                & " tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) " _
                                & " LEFT OUTER JOIN tblTransporters ON tblTransporters.TransporterID = tblJobTickets.TransporterID)" _
                            & " WHERE (tblJobTickets.JobClosed = TRUE) AND (tblJobTickets.IsCancelled = False) AND (tblJobTickets.WasteType in ('" & strWasteType.Trim & "'))  and " _
                                & " (tblJobTickets.ScheduleDate BETWEEN #" & FROMDate & "# AND #" & ToDate & "#) " _
                                & " ORDER BY tblGenerators.GeneratorName "

            Else
                strSQL = "SELECT DISTINCT tblJobTickets.JobTicketID, tblJobTickets.ManifestNo, tblJobTickets.ScheduleDate, " _
                                & " tblGenerators.GNo AS GenNo, tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteAddress1, " _
                                & " tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, " _
                                & " tblJobTickets.Gallons as Quantity,tblProducts.HWNumber, tblJobTickets.bsw, " _
                                & " tblJobTickets.JobTicketNo, tblGenerators.BrokerName, tblProducts.ApprovalNo,tblTransporters.TransporterName as TransporterName,tblJobTickets.WasteType, " _
                                & " tblProducts.ProductName + ' : ' + tblProducts.ApprovalNo as ProductName " _
                        & " FROM ((((tblGenerators LEFT OUTER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) " _
                                & " LEFT OUTER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) LEFT OUTER JOIN " _
                                & " tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) " _
                                & " LEFT OUTER JOIN tblTransporters ON tblTransporters.TransporterID = tblJobTickets.TransporterID)" _
                            & " WHERE (tblJobTickets.JobClosed = TRUE) AND (tblJobTickets.IsCancelled = False) AND (tblJobTickets.WasteType in ('" & strWasteType.Trim & "'))  and " _
                                & " (tblJobTickets.ScheduleDate BETWEEN #" & FROMDate & "# AND #" & ToDate & "#) AND (tblProducts.ProductID in (" & strProductID & ")) and " _
                                & " (tblGenerators.GeneratorID in (" & Me.genID & "))" _
                                & " ORDER BY tblGenerators.GeneratorName "

            End If

            'strSQL = "SELECT DISTINCT tblJobTickets.ManifestNo, tblJobTickets.ScheduleDate, tblGenerators.GNo AS GenNo, tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, tblJobTickets_Details.Quantity, tblProducts.HWNumber, tblProducts.HWNumber, tblJobTickets.bsw, tblJobTickets.JobTicketNo, tblGenerators.BrokerName, tblProducts.ApprovalNo FROM (((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) INNER JOIN tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) WHERE ((tblJobTickets.Hazardous = TRUE) OR (tblJobTickets.NonHazardous = TRUE)) and tblJobTickets.ScheduleDate BETWEEN #" & Me.txtStartDate.Text & "# AND #" & Me.txtEndDate.Text & "# ORDER BY tblJobTickets.ScheduleDate"
            ds = DBHelper.GetDataSet(strSQL, "tblInvoicing")
            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("No matching records found. Cancelling report...", MsgBoxStyle.Information, "No Data")
                Exit Sub
            End If
            '#If Export to Excel file is checked then 
            If Me.chkExcelReport.Checked = True Then
                Me.fncExcelExport(ds)
                Exit Sub
            End If
            objRpt.SetDataSource(ds)
            DBHelper.Authenticate(objRpt)

            Me.SetDateRange(objRpt)


            Dim frmSR As New frmReport
            frmSR.WindowState = FormWindowState.Maximized
            frmSR.CrystalReportViewer1.ReportSource = objRpt
            frmSR.CrystalReportViewer1.RefreshReport()
            frmSR.Show()
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
        Finally
            objRpt = Nothing
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim i As Integer
        Dim flag As Boolean = False
        If CType(sender, Button).Name = "btnClear" Then
            flag = False
        Else
            flag = True
        End If
        For i = 0 To Me.chkProduct.Items.Count - 1
            Me.chkProduct.SetItemChecked(i, flag)
        Next
    End Sub
    Function LoadDGValues()
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim whereClause As String = ""
        Try
            Dim strSQL As String
            '-------------------------------------------------------------------
            'Haigriv Vyas
            'Date: 07/05/2005
            '-------------------------------------------------------------------
            'strSQL = "SELECT tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblProducts.ProductName, tblProducts.ProductID, tblGenerators.GeneratorID,tblGenerators.GeneratorName,tblProducts.ApprovalNo,tblProducts.Active as Status FROM (tblGenerators LEFT OUTER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) "
            strSQL = "SELECT tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity,  tblGenerators.GeneratorID, tblGenerators.JobSite as GeneratorName, 0 as ProductId,'' as ProductName,'' as ApprovalNo, True as Status FROM tblGenerators "

            If Me.Fill_JobSite.Text <> "" Then
                'whereClause = " WHERE (tblGenerators.JobSite Like '" & Replace(Me.Fill_JobSite.Text, "'", "''") & "%') "
                whereClause = " WHERE (tblGenerators.GeneratorName Like '" & Replace(Me.Fill_JobSite.Text, "'", "''") & "%') "
            End If
            If Me.Fil_Address.Text <> "" Then
                If whereClause <> "" Then
                    whereClause = whereClause & " AND (tblGenerators.JobSiteAddress1 Like '" & Replace(Me.Fil_Address.Text, "'", "''") & "%') "
                Else
                    whereClause = " WHERE (tblGenerators.JobSiteAddress1 Like '" & Replace(Me.Fil_Address.Text, "'", "''") & "%') "
                End If
            End If
            If Me.Fil_City.Text <> "" Then
                If whereClause <> "" Then
                    whereClause = whereClause & " AND (tblGenerators.JobSiteCity Like '" & Replace(Me.Fil_City.Text, "'", "''") & "%') "
                Else
                    whereClause = " WHERE (tblGenerators.JobSiteCity Like '" & Replace(Me.Fil_City.Text, "'", "''") & "%') "
                End If
            End If

            'Perry Patel
            If Me.Fill_Customer.Text <> "" Then
                If whereClause <> "" Then
                    'whereClause = whereClause & " AND (tblGenerators.GeneratorName Like '" & Replace(Me.Fill_Customer.Text, "'", "''") & "%') "
                    whereClause = whereClause & " AND (tblGenerators.JobSite Like '" & Replace(Me.Fill_Customer.Text, "'", "''") & "%') "
                Else
                    'whereClause = " WHERE (tblGenerators.GeneratorName Like '" & Replace(Me.Fill_Customer.Text, "'", "''") & "%') "
                    whereClause = " WHERE (tblGenerators.JobSite Like '" & Replace(Me.Fill_Customer.Text, "'", "''") & "%') "
                End If
            End If

            If Len(whereClause) <> 0 Then strSQL = strSQL & whereClause
            strSQL = strSQL & " ORDER BY tblGenerators.GeneratorName, tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity "

            Me.dsGenerator = DBHelper.GetDataSet(strSQL, "tblGenerators")
            Me.dgSearchProduct.DataSource = Me.dsGenerator
            Me.dgSearchProduct.DataMember = "tblGenerators"
            Me.dgSearchProduct.Refresh()

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally
            'Me.dsGenerator = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Function

    Private Sub Fill_JobSite_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Fill_JobSite.KeyUp

        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Enter)) Then
            System.Windows.Forms.SendKeys.SendWait("{TAB}")
            Me.Fil_Address.Focus()
        ElseIf ((e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        Me.LoadDGValues()

    End Sub

    Private Sub Fil_Address_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Fil_Address.KeyUp

        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Enter)) Then
            System.Windows.Forms.SendKeys.SendWait("{TAB}")
            Me.Fil_City.Focus()
        ElseIf ((e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        Me.LoadDGValues()

    End Sub

    Private Sub Fil_City_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Fil_City.KeyUp

        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Enter)) Then
            System.Windows.Forms.SendKeys.SendWait("{TAB}")

        ElseIf ((e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        Me.LoadDGValues()

    End Sub

    Private Sub Fil_Product_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Enter)) Then
            System.Windows.Forms.SendKeys.SendWait("{TAB}")
            Me.btnSelect.Focus()
        ElseIf ((e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        Me.LoadDGValues()

    End Sub

    Private Sub Fill_Customer_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Fill_Customer.KeyUp

        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Enter)) Then
            System.Windows.Forms.SendKeys.SendWait("{TAB}")
            Me.btnSelect.Focus()
        ElseIf ((e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        Me.LoadDGValues()

    End Sub
    Private Sub dgSearchProduct_BackButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgSearchProduct.BackButtonClick

    End Sub
    Private Sub btnSelectGen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectGen.Click

        If Me.dgSearchProduct.CurrentRowIndex < 0 Then
            MsgBox("Product not selected. Please select a product.", MsgBoxStyle.Information, "Invalid selection")
            Me.dgSearchProduct.Focus()
            Exit Sub
        End If
        Me.genID = Me.dgSearchProduct.Item(Me.dgSearchProduct.CurrentRowIndex, 4)
        Me.InitialLoad()
    End Sub
    Function InitialLoad()
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet
        Dim strSQL As String
        Try
            strSQL = "SELECT ProductID,ProductName + ' : ' + ApprovalNo as ProductName FROM tblProducts WHERE GeneratorID = " & Me.genID
            ds = DBHelper.GetDataSet(strSQL, "tblProducts")
            Me.chkProduct.DataSource = ds
            Me.chkProduct.DisplayMember = "tblProducts.ProductName"
            Me.chkProduct.ValueMember = "tblProducts.ProductID"
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
        Finally
            dsGenerator = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
        Cursor.Current = System.Windows.Forms.Cursors.Default
    End Function
    Function InitialLoad_Customer()
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet
        Dim strSQL As String
        Try
            Dim dRow As DataRow

            strSQL = "SELECT DISTINCT tblGenerators.JobSite as GeneratorName FROM tblGenerators WHERE Len(Ltrim(GeneratorName)) <> 0"
            ds = DBHelper.GetDataSet(strSQL, "tblGenerators")
            dRow = ds.Tables(0).NewRow
            dRow.Item("GeneratorName") = "Select Customer"
            ds.Tables(0).Rows.InsertAt(dRow, 0)
            Me.cmbCustomer.DataSource = ds
            Me.cmbCustomer.DisplayMember = "tblGenerators.GeneratorName"
            Me.cmbCustomer.ValueMember = "tblGenerators.GeneratorName"
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
        Finally
            dsGenerator = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
        Cursor.Current = System.Windows.Forms.Cursors.Default
    End Function
    Private Sub cmbCustomer_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCustomer.SelectionChangeCommitted
        If Me.cmbCustomer.SelectedIndex > 0 Then
            Me.LoadDGValues_Customer(Me.cmbCustomer.SelectedValue)
        ElseIf Me.cmbCustomer.SelectedIndex = 0 Then
            Me.LoadDGValues_Customer("")
        End If
    End Sub
    Function LoadDGValues_Customer(ByVal strBrokerName As String)
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim whereClause As String = ""
        Try
            Dim strSQL As String
            '-------------------------------------------------------------------
            'Haigriv Vyas
            'Date: 07/05/2005
            '-------------------------------------------------------------------
            strSQL = "SELECT DISTINCT tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblProducts.ProductName, tblProducts.ProductID, tblGenerators.GeneratorID,tblGenerators.GeneratorName,tblProducts.ApprovalNo,tblProducts.Active as Status FROM (tblGenerators LEFT OUTER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) "
            If Me.Fill_JobSite_C.Text <> "" Then
                'whereClause = " WHERE (tblGenerators.JobSite Like '" & Replace(Me.Fill_JobSite.Text, "'", "''") & "%') "
                whereClause = " WHERE (tblGenerators.GeneratorName Like '" & Replace(Me.Fill_JobSite_C.Text, "'", "''") & "%') "
            End If
            If Me.Fill_JobSiteAdd_C.Text <> "" Then
                If whereClause <> "" Then
                    whereClause = whereClause & " AND (tblGenerators.JobSiteAddress1 Like '" & Replace(Me.Fill_JobSiteAdd_C.Text, "'", "''") & "%') "
                Else
                    whereClause = " WHERE (tblGenerators.JobSiteAddress1 Like '" & Replace(Me.Fill_JobSiteAdd_C.Text, "'", "''") & "%') "
                End If
            End If
            If Me.Fill_JobSiteCity_C.Text <> "" Then
                If whereClause <> "" Then
                    whereClause = whereClause & " AND (tblGenerators.JobSiteCity Like '" & Replace(Me.Fill_JobSiteCity_C.Text, "'", "''") & "%') "
                Else
                    whereClause = " WHERE (tblGenerators.JobSiteCity Like '" & Replace(Me.Fill_JobSiteCity_C.Text, "'", "''") & "%') "
                End If
            End If
            If Me.Fill_Product_C.Text <> "" Then
                If whereClause <> "" Then
                    whereClause = whereClause & " AND (tblProducts.ProductName Like '" & Replace(Me.Fill_Product_C.Text, "'", "''") & "%') "
                Else
                    whereClause = " WHERE (tblProducts.ProductName Like '" & Replace(Me.Fill_Product_C.Text, "'", "''") & "%') "
                End If
            End If
            If Me.Fill_Approval_C.Text <> "" Then
                If whereClause <> "" Then
                    whereClause = whereClause & " AND (tblProducts.ApprovalNo Like '" & Replace(Me.Fill_Approval_C.Text, "'", "''") & "%') "
                Else
                    whereClause = " WHERE (tblProducts.ApprovalNo Like '" & Replace(Me.Fill_Approval_C.Text, "'", "''") & "%') "
                End If
            End If

            If strBrokerName.Trim <> "" Then
                If whereClause.Trim <> "" Then
                    strSQL = strSQL & whereClause & " and (tblGenerators.JobSite = '" & strBrokerName & "')"
                Else
                    strSQL = strSQL & " WHERE (tblGenerators.JobSite = '" & strBrokerName & "')"
                End If
            Else
                If Len(whereClause) <> 0 Then strSQL = strSQL & whereClause
            End If

            strSQL = strSQL & " ORDER BY tblGenerators.GeneratorName, tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity "
            Me.dsCustomer = New DataSet
            dsCustomer = DBHelper.GetDataSet(strSQL, "tblCustomers")
            dsCustomer.Tables(0).TableName = "tblCustomers"

            Dim i As Integer = 0
            If Not dsCustomer Is Nothing AndAlso dsCustomer.Tables(0).Rows.Count > 0 Then
                For i = 0 To dsCustomer.Tables(0).Rows.Count - 1
                    dsCustomer.Tables(0).Rows(i).Item("Status") = False
                Next
            End If
            Me.dgCustomer.DataSource = dsCustomer
            Me.dgCustomer.DataMember = dsCustomer.Tables(0).TableName
            Me.dgCustomer.Refresh()
            Me.DataGridBoolColumn2.ReadOnly = False
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally
            'Me.dsGenerator = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Function
    Private Sub btnCustomerReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomerReport.Click
        If Me.ValidateDates = False Then Exit Sub
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet, strSQL As String
        Dim strWasteType As String = ""
        Dim strProductID As String = ""
        Dim objRpt As ReportDocument
        Dim strGenID As String = ""
        Dim strProdID As String = ""
        Dim strWhere As String = ""
        Try
            Dim FROMDate As Date
            Dim ToDate As Date
            FROMDate = Me.CustDate1.Value.ToShortDateString
            ToDate = Me.CustDate2.Value.ToShortDateString
            objRpt = New rptCustomer
            'strWasteType = "HAZARDOUS','HAZAROUS','Non HAZARDOUS','NonHAZARDOUS','GARY PLANT','GARYPLANT','MULTI-STOP','MULTISTOP','B.O.L.','B.O.L"

            Me.GetProductIDAndGeneratorIDString(strGenID, strProdID)


            If Len(strGenID.Replace(",", "").Trim) = 0 Then
                strSQL = "SELECT DISTINCT tblJobTickets.JobTicketID, tblJobTickets.ManifestNo, tblJobTickets.ScheduleDate, " _
                                & " tblGenerators.GNo AS GenNo, tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteAddress1, " _
                                & " tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, " _
                                & " tblJobTickets.Gallons as Quantity,tblProducts.HWNumber, tblJobTickets.bsw, " _
                                & " tblJobTickets.JobTicketNo, tblGenerators.BrokerName, tblProducts.ApprovalNo,tblTransporters.TransporterName as TransporterName,tblJobTickets.WasteType, " _
                                & " tblProducts.ProductName + ' : ' + tblProducts.ApprovalNo as ProductName " _
                        & " FROM ((((tblGenerators LEFT OUTER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) " _
                                & " LEFT OUTER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) LEFT OUTER JOIN " _
                                & " tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) " _
                                & " LEFT OUTER JOIN tblTransporters ON tblTransporters.TransporterID = tblJobTickets.TransporterID)" _
                            & " WHERE (tblJobTickets.JobClosed = TRUE) AND (tblJobTickets.IsCancelled = False) AND " _
                                & " (tblJobTickets.ScheduleDate BETWEEN #" & FROMDate & "# AND #" & ToDate & "#) " _
                                & " ORDER BY tblGenerators.GeneratorName "

            Else
                If Len(strProdID.Replace(",", "").Trim) = 0 Then strProdID = 0
                strSQL = "SELECT DISTINCT tblJobTickets.JobTicketID, tblJobTickets.ManifestNo, tblJobTickets.ScheduleDate, " _
                                & " tblGenerators.GNo AS GenNo, tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteAddress1, " _
                                & " tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, " _
                                & " tblJobTickets.Gallons as Quantity,tblProducts.HWNumber, tblJobTickets.bsw, " _
                                & " tblJobTickets.JobTicketNo, tblGenerators.BrokerName, tblProducts.ApprovalNo,tblTransporters.TransporterName as TransporterName,tblJobTickets.WasteType, " _
                                & " tblProducts.ProductName + ' : ' + tblProducts.ApprovalNo as ProductName " _
                        & " FROM ((((tblGenerators LEFT OUTER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) " _
                                & " LEFT OUTER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) LEFT OUTER JOIN " _
                                & " tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) " _
                                & " LEFT OUTER JOIN tblTransporters ON tblTransporters.TransporterID = tblJobTickets.TransporterID)" _
                            & " WHERE (tblJobTickets.JobClosed = TRUE) AND (tblJobTickets.IsCancelled = False) AND " _
                                & " (tblJobTickets.ScheduleDate BETWEEN #" & FROMDate & "# AND #" & ToDate & "#) AND " _
                                & " (tblGenerators.GeneratorID in (" & strGenID & ")) and (tblProducts.ProductID in (" & strProdID.Trim & "))" _
                                & " ORDER BY tblGenerators.GeneratorName "

            End If

            'strSQL = "SELECT DISTINCT tblJobTickets.ManifestNo, tblJobTickets.ScheduleDate, tblGenerators.GNo AS GenNo, tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, tblJobTickets_Details.Quantity, tblProducts.HWNumber, tblProducts.HWNumber, tblJobTickets.bsw, tblJobTickets.JobTicketNo, tblGenerators.BrokerName, tblProducts.ApprovalNo FROM (((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) INNER JOIN tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_Details.JobTicketID) WHERE ((tblJobTickets.Hazardous = TRUE) OR (tblJobTickets.NonHazardous = TRUE)) and tblJobTickets.ScheduleDate BETWEEN #" & Me.txtStartDate.Text & "# AND #" & Me.txtEndDate.Text & "# ORDER BY tblJobTickets.ScheduleDate"
            ds = DBHelper.GetDataSet(strSQL, "tblInvoicing")
            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("No matching records found. Cancelling report...", MsgBoxStyle.Information, "No Data")
                Exit Sub
            End If
            '#If Export to Excel file is checked then 
            If Me.chkExcelReport.Checked = True Then
                Me.fncExcelExport(ds)
                Exit Sub
            End If
            objRpt.SetDataSource(ds)
            DBHelper.Authenticate(objRpt)

            'Me.SetDateRange(objRpt)
            Dim fFields As FormulaFieldDefinitions = objRpt.DataDefinition.FormulaFields
            Dim fField As FormulaFieldDefinition


            dateRange = "FROM " & FROMDate.ToShortDateString & " TO " & ToDate.ToShortDateString
            'Update Date Range Formula field with date range
            fField = fFields.Item("DateRange")
            fField.Text = """" & dateRange & """"
            'fField.Text = dateRange



            Dim frmSR As New frmReport
            frmSR.WindowState = FormWindowState.Maximized
            frmSR.CrystalReportViewer1.ReportSource = objRpt
            frmSR.CrystalReportViewer1.RefreshReport()
            frmSR.Show()
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
        Finally
            objRpt = Nothing
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    Private Function GetProductIDAndGeneratorIDString(ByRef strGenID As String, ByRef strProdId As String) As String
        Dim jj As Integer
        Dim i, j As Integer
        Dim dgitem As DataGridCell

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        If Not Me.dsCustomer Is Nothing AndAlso Me.dsCustomer.Tables(0).Rows.Count > 0 Then
            For i = 0 To Me.dsCustomer.Tables(0).Rows.Count - 1
                If Me.dgCustomer.Item(i, 0) = True Then
                    If j = 0 Then
                        strGenID = Me.dgCustomer.Item(i, 6).ToString
                        strProdId = Me.dgCustomer.Item(i, 7).ToString
                        j = i + 1
                    Else
                        strGenID = strGenID & "," & Me.dgCustomer.Item(i, 6).ToString
                        strProdId = strProdId & "," & Me.dgCustomer.Item(i, 7).ToString
                    End If
                End If
            Next
        End If
        Cursor.Current = System.Windows.Forms.Cursors.Default
    End Function
    Private Sub Fill_JobSite_C_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Fill_JobSite_C.KeyUp

        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Enter)) Then
            System.Windows.Forms.SendKeys.SendWait("{TAB}")
            Me.Fill_JobSiteAdd_C.Focus()
        ElseIf ((e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        Me.LoadDGValues_Customer("")
    End Sub
    Private Sub Fill_JobSiteAdd_C_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Fill_JobSiteAdd_C.KeyUp

        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Enter)) Then
            System.Windows.Forms.SendKeys.SendWait("{TAB}")
            Me.Fill_JobSiteCity_C.Focus()
        ElseIf ((e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        Me.LoadDGValues_Customer("")
    End Sub
    Private Sub Fill_JobSiteCity_C_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Fill_JobSiteCity_C.KeyUp

        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Enter)) Then
            System.Windows.Forms.SendKeys.SendWait("{TAB}")
        ElseIf ((e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        Me.LoadDGValues_Customer("")

    End Sub
    Private Sub Fill_Product_C_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Fill_Product_C.KeyUp
        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Enter)) Then
            System.Windows.Forms.SendKeys.SendWait("{TAB}")
            Me.Fill_Approval_C.Focus()
        ElseIf ((e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        Me.LoadDGValues_Customer("")

    End Sub
    Private Sub Fill_Approval_C_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Fill_Approval_C.KeyUp

        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Enter)) Then
            System.Windows.Forms.SendKeys.SendWait("{TAB}")
            Me.btnCustomerReport.Focus()
        ElseIf ((e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        Me.LoadDGValues_Customer("")
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.Fill_JobSite.Text = ""
        Me.Fill_Customer.Text = ""
        Me.Fil_Address.Text = ""
        Me.Fil_City.Text = ""
        Me.LoadDGValues()
    End Sub
    Private Sub cmbCustomer_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCustomer.KeyUp
        Dim index As Integer, actual As String, found As String
        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Back) Or (e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        ' Store the actual text that has been typed
        actual = Me.cmbCustomer.Text
        ' Find the first match for the typed value
        index = Me.cmbCustomer.FindString(actual)
        ' Get the text of the first match
        If (index > -1) Then
            ' Select this item from the list
            Me.cmbCustomer.SelectedIndex = index
            found = Me.cmbCustomer.Text
            ' Select the portion of the text that was automatically added so further typing will replace it
            Me.cmbCustomer.SelectionStart = actual.Length
            Me.cmbCustomer.SelectionLength = found.Length - actual.Length
        End If
    End Sub

    Private Sub cmbInvoices_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbInvoices.Click
        If cmbInvoices.Items.Count = 0 Then
            Me.populateISelection()
        End If
    End Sub
End Class
