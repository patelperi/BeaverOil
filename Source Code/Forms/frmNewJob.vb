Public Class frmNewJob
    Inherits System.Windows.Forms.Form

    'Declare variables to be used
    Dim genID As Long = 0, prodID As Long = 0

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
    Friend WithEvents grpProduct As System.Windows.Forms.GroupBox
    Friend WithEvents lblAnalytical As System.Windows.Forms.Label
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCName As System.Windows.Forms.Label
    Friend WithEvents lblAnalyticalDate As System.Windows.Forms.Label
    Friend WithEvents lblCPhone As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnJobBoard As System.Windows.Forms.Button
    Friend WithEvents dtJobSchedule As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblOustandingBalance As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblProductDesc As System.Windows.Forms.Label
    Friend WithEvents chkPaperworkList As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblNumOfDays As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnViewProductInfo As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblApprovalNo As System.Windows.Forms.Label
    Friend WithEvents btnAddG As System.Windows.Forms.Button
    Friend WithEvents btnAddP As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbTruckType As System.Windows.Forms.ComboBox
    Friend WithEvents IsMultiStop As System.Windows.Forms.RadioButton
    Friend WithEvents IsOutsideHauler As System.Windows.Forms.RadioButton
    Friend WithEvents IsBeaver As System.Windows.Forms.RadioButton
    Friend WithEvents cmbHauler As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents SpecialInstrutions As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ScheduledTime As System.Windows.Forms.TextBox
    Friend WithEvents SpecialInstrutions_T As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbReceivingSite As System.Windows.Forms.ComboBox
    Friend WithEvents chkDrums As System.Windows.Forms.CheckBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblRecertDate As System.Windows.Forms.Label
    Friend WithEvents txtPO As System.Windows.Forms.TextBox
    Friend WithEvents grRecurring As System.Windows.Forms.GroupBox
    Friend WithEvents cmbOccursEvery As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dtStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents IsRecurring As System.Windows.Forms.CheckBox
    Friend WithEvents grpSelectProduct As System.Windows.Forms.GroupBox
    Friend WithEvents dgSearchProduct As System.Windows.Forms.DataGrid
    Friend WithEvents DsNewJobSearch1 As BeaverOil.DSNewJobSearch
    Friend WithEvents dgTblStyle As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents col_GName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_GAdd As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_City As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_Product As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Fill_JobSite As System.Windows.Forms.TextBox
    Friend WithEvents Fil_Address As System.Windows.Forms.TextBox
    Friend WithEvents Fil_City As System.Windows.Forms.TextBox
    Friend WithEvents Fil_Product As System.Windows.Forms.TextBox
    Friend WithEvents col_ProductID As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_GenID As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lblBorder As System.Windows.Forms.Label
    Friend WithEvents col_GeneratorName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Fill_Customer As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ViewNewJobList As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents dtEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents IsManifest As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents lblJobSite As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents col_ApprovalNo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_IsNewProduct As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents Fil_Approval As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents lblVerifiedDate As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cmbWasteType As System.Windows.Forms.ComboBox
    Friend WithEvents txtProductSpecialInstruction As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents lblGallons As System.Windows.Forms.Label
    Friend WithEvents txtGallons As System.Windows.Forms.TextBox
    Friend WithEvents chkInactiveProduct As System.Windows.Forms.CheckBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents lblGID As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.grpProduct = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.SpecialInstrutions = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.SpecialInstrutions_T = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtPO = New System.Windows.Forms.TextBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.txtGallons = New System.Windows.Forms.TextBox
        Me.lblGallons = New System.Windows.Forms.Label
        Me.IsManifest = New System.Windows.Forms.CheckBox
        Me.chkDrums = New System.Windows.Forms.CheckBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbTruckType = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtJobSchedule = New System.Windows.Forms.DateTimePicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.ScheduledTime = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lblGID = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.chkPaperworkList = New System.Windows.Forms.CheckedListBox
        Me.IsMultiStop = New System.Windows.Forms.RadioButton
        Me.IsOutsideHauler = New System.Windows.Forms.RadioButton
        Me.IsBeaver = New System.Windows.Forms.RadioButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbHauler = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmbReceivingSite = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.txtProductSpecialInstruction = New System.Windows.Forms.TextBox
        Me.cmbWasteType = New System.Windows.Forms.ComboBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.lblVerifiedDate = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.lblAnalytical = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblAnalyticalDate = New System.Windows.Forms.Label
        Me.lblRecertDate = New System.Windows.Forms.Label
        Me.lblApprovalNo = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblBalance = New System.Windows.Forms.Label
        Me.lblOustandingBalance = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblNumOfDays = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblCPhone = New System.Windows.Forms.Label
        Me.lblCName = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.lblJobSite = New System.Windows.Forms.Label
        Me.lblCustomerName = New System.Windows.Forms.Label
        Me.lblProductName = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.ViewNewJobList = New System.Windows.Forms.Button
        Me.grRecurring = New System.Windows.Forms.GroupBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.dtEndDate = New System.Windows.Forms.DateTimePicker
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.dtStartDate = New System.Windows.Forms.DateTimePicker
        Me.Label17 = New System.Windows.Forms.Label
        Me.cmbOccursEvery = New System.Windows.Forms.ComboBox
        Me.IsRecurring = New System.Windows.Forms.CheckBox
        Me.btnViewProductInfo = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lblProductDesc = New System.Windows.Forms.Label
        Me.btnJobBoard = New System.Windows.Forms.Button
        Me.btnAddG = New System.Windows.Forms.Button
        Me.btnAddP = New System.Windows.Forms.Button
        Me.btnSelect = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.grpSelectProduct = New System.Windows.Forms.GroupBox
        Me.chkInactiveProduct = New System.Windows.Forms.CheckBox
        Me.Fil_Approval = New System.Windows.Forms.TextBox
        Me.Fill_Customer = New System.Windows.Forms.TextBox
        Me.Fil_Product = New System.Windows.Forms.TextBox
        Me.Fil_City = New System.Windows.Forms.TextBox
        Me.Fil_Address = New System.Windows.Forms.TextBox
        Me.Fill_JobSite = New System.Windows.Forms.TextBox
        Me.dgSearchProduct = New System.Windows.Forms.DataGrid
        Me.DsNewJobSearch1 = New BeaverOil.DSNewJobSearch
        Me.dgTblStyle = New System.Windows.Forms.DataGridTableStyle
        Me.col_GName = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_GeneratorName = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_GAdd = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_City = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_Product = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_ProductID = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_GenID = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_ApprovalNo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_IsNewProduct = New System.Windows.Forms.DataGridBoolColumn
        Me.lblBorder = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpProduct.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grRecurring.SuspendLayout()
        Me.grpSelectProduct.SuspendLayout()
        CType(Me.dgSearchProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNewJobSearch1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpProduct
        '
        Me.grpProduct.Controls.Add(Me.Label14)
        Me.grpProduct.Controls.Add(Me.GroupBox7)
        Me.grpProduct.Controls.Add(Me.GroupBox6)
        Me.grpProduct.Controls.Add(Me.GroupBox5)
        Me.grpProduct.Controls.Add(Me.GroupBox4)
        Me.grpProduct.Controls.Add(Me.GroupBox3)
        Me.grpProduct.Controls.Add(Me.GroupBox2)
        Me.grpProduct.Controls.Add(Me.GroupBox1)
        Me.grpProduct.Controls.Add(Me.ViewNewJobList)
        Me.grpProduct.Controls.Add(Me.grRecurring)
        Me.grpProduct.Controls.Add(Me.btnViewProductInfo)
        Me.grpProduct.Controls.Add(Me.btnCancel)
        Me.grpProduct.Controls.Add(Me.lblProductDesc)
        Me.grpProduct.Controls.Add(Me.btnJobBoard)
        Me.grpProduct.Controls.Add(Me.btnAddG)
        Me.grpProduct.Controls.Add(Me.btnAddP)
        Me.grpProduct.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpProduct.Location = New System.Drawing.Point(1, 247)
        Me.grpProduct.Name = "grpProduct"
        Me.grpProduct.Size = New System.Drawing.Size(840, 474)
        Me.grpProduct.TabIndex = 2
        Me.grpProduct.TabStop = False
        Me.grpProduct.Visible = False
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(697, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(140, 14)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "* Indicate Required field."
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label10)
        Me.GroupBox7.Controls.Add(Me.SpecialInstrutions)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Controls.Add(Me.SpecialInstrutions_T)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.txtPO)
        Me.GroupBox7.Font = New System.Drawing.Font("Verdana", 1.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(6, 343)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(832, 100)
        Me.GroupBox7.TabIndex = 50
        Me.GroupBox7.TabStop = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(158, 16)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Job Board Instrutions:-"
        '
        'SpecialInstrutions
        '
        Me.SpecialInstrutions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SpecialInstrutions.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecialInstrutions.Location = New System.Drawing.Point(8, 46)
        Me.SpecialInstrutions.MaxLength = 500
        Me.SpecialInstrutions.Multiline = True
        Me.SpecialInstrutions.Name = "SpecialInstrutions"
        Me.SpecialInstrutions.Size = New System.Drawing.Size(394, 50)
        Me.SpecialInstrutions.TabIndex = 13
        Me.SpecialInstrutions.Text = ""
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(406, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(162, 14)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Job Ticket Instrutions:-"
        '
        'SpecialInstrutions_T
        '
        Me.SpecialInstrutions_T.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SpecialInstrutions_T.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecialInstrutions_T.Location = New System.Drawing.Point(404, 46)
        Me.SpecialInstrutions_T.MaxLength = 500
        Me.SpecialInstrutions_T.Multiline = True
        Me.SpecialInstrutions_T.Name = "SpecialInstrutions_T"
        Me.SpecialInstrutions_T.Size = New System.Drawing.Size(419, 50)
        Me.SpecialInstrutions_T.TabIndex = 14
        Me.SpecialInstrutions_T.Text = ""
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(10, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 16)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "PO # :-"
        '
        'txtPO
        '
        Me.txtPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPO.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPO.Location = New System.Drawing.Point(66, 6)
        Me.txtPO.MaxLength = 20
        Me.txtPO.Name = "txtPO"
        Me.txtPO.Size = New System.Drawing.Size(120, 21)
        Me.txtPO.TabIndex = 15
        Me.txtPO.Text = ""
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtGallons)
        Me.GroupBox6.Controls.Add(Me.lblGallons)
        Me.GroupBox6.Controls.Add(Me.IsManifest)
        Me.GroupBox6.Controls.Add(Me.chkDrums)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.cmbTruckType)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Font = New System.Drawing.Font("Verdana", 1.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(6, 286)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(396, 55)
        Me.GroupBox6.TabIndex = 49
        Me.GroupBox6.TabStop = False
        '
        'txtGallons
        '
        Me.txtGallons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGallons.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGallons.Location = New System.Drawing.Point(307, 29)
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(85, 21)
        Me.txtGallons.TabIndex = 12
        Me.txtGallons.Text = ""
        '
        'lblGallons
        '
        Me.lblGallons.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGallons.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblGallons.Location = New System.Drawing.Point(237, 32)
        Me.lblGallons.Name = "lblGallons"
        Me.lblGallons.Size = New System.Drawing.Size(74, 16)
        Me.lblGallons.TabIndex = 45
        Me.lblGallons.Text = "GALLONS :-"
        '
        'IsManifest
        '
        Me.IsManifest.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsManifest.Location = New System.Drawing.Point(13, 8)
        Me.IsManifest.Name = "IsManifest"
        Me.IsManifest.Size = New System.Drawing.Size(220, 18)
        Me.IsManifest.TabIndex = 43
        Me.IsManifest.Text = "BEAVER PREPARES MANIFEST"
        '
        'chkDrums
        '
        Me.chkDrums.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDrums.ForeColor = System.Drawing.Color.Navy
        Me.chkDrums.Location = New System.Drawing.Point(273, 10)
        Me.chkDrums.Name = "chkDrums"
        Me.chkDrums.Size = New System.Drawing.Size(74, 18)
        Me.chkDrums.TabIndex = 11
        Me.chkDrums.Text = "DRUMS?"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 16)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Type of Truck :-"
        '
        'cmbTruckType
        '
        Me.cmbTruckType.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTruckType.Location = New System.Drawing.Point(136, 29)
        Me.cmbTruckType.Name = "cmbTruckType"
        Me.cmbTruckType.Size = New System.Drawing.Size(100, 21)
        Me.cmbTruckType.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(16, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 12)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "*"
        Me.Label3.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label27)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.dtJobSchedule)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.ScheduledTime)
        Me.GroupBox5.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(572, 11)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(142, 104)
        Me.GroupBox5.TabIndex = 48
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Job Scheduling"
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Red
        Me.Label27.Location = New System.Drawing.Point(3, 28)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(10, 12)
        Me.Label27.TabIndex = 46
        Me.Label27.Text = "*"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Schedule Date :-"
        '
        'dtJobSchedule
        '
        Me.dtJobSchedule.CustomFormat = "mm/dd/yyyy"
        Me.dtJobSchedule.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtJobSchedule.Location = New System.Drawing.Point(10, 51)
        Me.dtJobSchedule.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.dtJobSchedule.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtJobSchedule.Name = "dtJobSchedule"
        Me.dtJobSchedule.Size = New System.Drawing.Size(118, 21)
        Me.dtJobSchedule.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 16)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Time :-"
        Me.Label11.Visible = False
        '
        'ScheduledTime
        '
        Me.ScheduledTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ScheduledTime.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScheduledTime.Location = New System.Drawing.Point(118, 82)
        Me.ScheduledTime.Name = "ScheduledTime"
        Me.ScheduledTime.Size = New System.Drawing.Size(17, 21)
        Me.ScheduledTime.TabIndex = 9
        Me.ScheduledTime.Text = ""
        Me.ScheduledTime.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblGID)
        Me.GroupBox4.Controls.Add(Me.Label32)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.chkPaperworkList)
        Me.GroupBox4.Controls.Add(Me.IsMultiStop)
        Me.GroupBox4.Controls.Add(Me.IsOutsideHauler)
        Me.GroupBox4.Controls.Add(Me.IsBeaver)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.cmbHauler)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.cmbReceivingSite)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 1.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(402, 115)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(436, 171)
        Me.GroupBox4.TabIndex = 47
        Me.GroupBox4.TabStop = False
        '
        'lblGID
        '
        Me.lblGID.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGID.ForeColor = System.Drawing.Color.Blue
        Me.lblGID.Location = New System.Drawing.Point(7, 150)
        Me.lblGID.Name = "lblGID"
        Me.lblGID.Size = New System.Drawing.Size(150, 16)
        Me.lblGID.TabIndex = 50
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label32.Location = New System.Drawing.Point(47, 130)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(54, 16)
        Me.Label32.TabIndex = 49
        Me.Label32.Text = "FED #:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Paperwork:"
        '
        'chkPaperworkList
        '
        Me.chkPaperworkList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chkPaperworkList.CheckOnClick = True
        Me.chkPaperworkList.ColumnWidth = 160
        Me.chkPaperworkList.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPaperworkList.HorizontalExtent = 2
        Me.chkPaperworkList.Items.AddRange(New Object() {"Non-Hazardous Manifest", "Hazardous Manifest", "Bill of Lading", "Job Ticket", "Plant2 Manifest", "Form C Attachment"})
        Me.chkPaperworkList.Location = New System.Drawing.Point(8, 22)
        Me.chkPaperworkList.MultiColumn = True
        Me.chkPaperworkList.Name = "chkPaperworkList"
        Me.chkPaperworkList.Size = New System.Drawing.Size(165, 107)
        Me.chkPaperworkList.TabIndex = 2
        Me.chkPaperworkList.UseTabStops = False
        '
        'IsMultiStop
        '
        Me.IsMultiStop.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMultiStop.Location = New System.Drawing.Point(183, 41)
        Me.IsMultiStop.Name = "IsMultiStop"
        Me.IsMultiStop.Size = New System.Drawing.Size(102, 16)
        Me.IsMultiStop.TabIndex = 5
        Me.IsMultiStop.Text = "Multi-Stop"
        '
        'IsOutsideHauler
        '
        Me.IsOutsideHauler.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsOutsideHauler.Location = New System.Drawing.Point(252, 26)
        Me.IsOutsideHauler.Name = "IsOutsideHauler"
        Me.IsOutsideHauler.Size = New System.Drawing.Size(124, 16)
        Me.IsOutsideHauler.TabIndex = 4
        Me.IsOutsideHauler.Text = "Outside Hauler"
        '
        'IsBeaver
        '
        Me.IsBeaver.Checked = True
        Me.IsBeaver.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsBeaver.Location = New System.Drawing.Point(183, 24)
        Me.IsBeaver.Name = "IsBeaver"
        Me.IsBeaver.Size = New System.Drawing.Size(76, 16)
        Me.IsBeaver.TabIndex = 3
        Me.IsBeaver.TabStop = True
        Me.IsBeaver.Text = "Beaver"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(245, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 14)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Hauler :-"
        '
        'cmbHauler
        '
        Me.cmbHauler.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHauler.Location = New System.Drawing.Point(185, 82)
        Me.cmbHauler.Name = "cmbHauler"
        Me.cmbHauler.Size = New System.Drawing.Size(242, 21)
        Me.cmbHauler.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(231, 106)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 16)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Receiving Site:-"
        '
        'cmbReceivingSite
        '
        Me.cmbReceivingSite.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReceivingSite.Location = New System.Drawing.Point(185, 123)
        Me.cmbReceivingSite.Name = "cmbReceivingSite"
        Me.cmbReceivingSite.Size = New System.Drawing.Size(242, 21)
        Me.cmbReceivingSite.TabIndex = 7
        '
        'Label23
        '
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Location = New System.Drawing.Point(175, 21)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(254, 39)
        Me.Label23.TabIndex = 48
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.txtProductSpecialInstruction)
        Me.GroupBox3.Controls.Add(Me.cmbWasteType)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.lblVerifiedDate)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.lblAnalytical)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.lblAnalyticalDate)
        Me.GroupBox3.Controls.Add(Me.lblRecertDate)
        Me.GroupBox3.Controls.Add(Me.lblApprovalNo)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.lblBalance)
        Me.GroupBox3.Controls.Add(Me.lblOustandingBalance)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.lblNumOfDays)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 1.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 115)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(396, 171)
        Me.GroupBox3.TabIndex = 46
        Me.GroupBox3.TabStop = False
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(9, 110)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(140, 15)
        Me.Label31.TabIndex = 47
        Me.Label31.Text = "Product Instrutions:-"
        '
        'txtProductSpecialInstruction
        '
        Me.txtProductSpecialInstruction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProductSpecialInstruction.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductSpecialInstruction.Location = New System.Drawing.Point(9, 125)
        Me.txtProductSpecialInstruction.MaxLength = 255
        Me.txtProductSpecialInstruction.Multiline = True
        Me.txtProductSpecialInstruction.Name = "txtProductSpecialInstruction"
        Me.txtProductSpecialInstruction.ReadOnly = True
        Me.txtProductSpecialInstruction.Size = New System.Drawing.Size(383, 40)
        Me.txtProductSpecialInstruction.TabIndex = 46
        Me.txtProductSpecialInstruction.Text = ""
        '
        'cmbWasteType
        '
        Me.cmbWasteType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWasteType.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbWasteType.Location = New System.Drawing.Point(247, 25)
        Me.cmbWasteType.Name = "cmbWasteType"
        Me.cmbWasteType.Size = New System.Drawing.Size(141, 21)
        Me.cmbWasteType.TabIndex = 45
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label30.Location = New System.Drawing.Point(230, 10)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(162, 13)
        Me.Label30.TabIndex = 44
        Me.Label30.Text = "ACTIVITY REPORT TYPE :"
        '
        'lblVerifiedDate
        '
        Me.lblVerifiedDate.Font = New System.Drawing.Font("Verdana", 8.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerifiedDate.ForeColor = System.Drawing.Color.Red
        Me.lblVerifiedDate.Location = New System.Drawing.Point(130, 63)
        Me.lblVerifiedDate.Name = "lblVerifiedDate"
        Me.lblVerifiedDate.Size = New System.Drawing.Size(184, 16)
        Me.lblVerifiedDate.TabIndex = 43
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label29.Location = New System.Drawing.Point(24, 64)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(104, 13)
        Me.Label29.TabIndex = 42
        Me.Label29.Text = "Verified Date :-"
        '
        'lblAnalytical
        '
        Me.lblAnalytical.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnalytical.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblAnalytical.Location = New System.Drawing.Point(6, 10)
        Me.lblAnalytical.Name = "lblAnalytical"
        Me.lblAnalytical.Size = New System.Drawing.Size(122, 16)
        Me.lblAnalytical.TabIndex = 1
        Me.lblAnalytical.Text = "Analytical Date :-"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(6, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 14)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "LAB Recert Date:-"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label16.Location = New System.Drawing.Point(24, 46)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 15)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Approval No.:-"
        '
        'lblAnalyticalDate
        '
        Me.lblAnalyticalDate.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnalyticalDate.Location = New System.Drawing.Point(130, 9)
        Me.lblAnalyticalDate.Name = "lblAnalyticalDate"
        Me.lblAnalyticalDate.Size = New System.Drawing.Size(96, 16)
        Me.lblAnalyticalDate.TabIndex = 4
        '
        'lblRecertDate
        '
        Me.lblRecertDate.Font = New System.Drawing.Font("Verdana", 8.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecertDate.Location = New System.Drawing.Point(130, 28)
        Me.lblRecertDate.Name = "lblRecertDate"
        Me.lblRecertDate.Size = New System.Drawing.Size(96, 16)
        Me.lblRecertDate.TabIndex = 41
        '
        'lblApprovalNo
        '
        Me.lblApprovalNo.Font = New System.Drawing.Font("Verdana", 8.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApprovalNo.ForeColor = System.Drawing.Color.Red
        Me.lblApprovalNo.Location = New System.Drawing.Point(130, 46)
        Me.lblApprovalNo.Name = "lblApprovalNo"
        Me.lblApprovalNo.Size = New System.Drawing.Size(116, 16)
        Me.lblApprovalNo.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Credit:"
        '
        'lblBalance
        '
        Me.lblBalance.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(94, 82)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(152, 16)
        Me.lblBalance.TabIndex = 4
        Me.lblBalance.Text = "Outstanding Balance :-"
        '
        'lblOustandingBalance
        '
        Me.lblOustandingBalance.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOustandingBalance.Location = New System.Drawing.Point(248, 82)
        Me.lblOustandingBalance.Name = "lblOustandingBalance"
        Me.lblOustandingBalance.Size = New System.Drawing.Size(96, 16)
        Me.lblOustandingBalance.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(163, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "# of Days :-"
        '
        'lblNumOfDays
        '
        Me.lblNumOfDays.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumOfDays.Location = New System.Drawing.Point(247, 100)
        Me.lblNumOfDays.Name = "lblNumOfDays"
        Me.lblNumOfDays.Size = New System.Drawing.Size(48, 16)
        Me.lblNumOfDays.TabIndex = 22
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblCPhone)
        Me.GroupBox2.Controls.Add(Me.lblCName)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(402, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(170, 104)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        '
        'lblCPhone
        '
        Me.lblCPhone.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPhone.Location = New System.Drawing.Point(8, 66)
        Me.lblCPhone.Name = "lblCPhone"
        Me.lblCPhone.Size = New System.Drawing.Size(156, 16)
        Me.lblCPhone.TabIndex = 9
        '
        'lblCName
        '
        Me.lblCName.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCName.Location = New System.Drawing.Point(8, 46)
        Me.lblCName.Name = "lblCName"
        Me.lblCName.Size = New System.Drawing.Size(155, 16)
        Me.lblCName.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Contact Info:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.lblJobSite)
        Me.GroupBox1.Controls.Add(Me.lblCustomerName)
        Me.GroupBox1.Controls.Add(Me.lblProductName)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(396, 104)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Info."
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Red
        Me.Label26.Location = New System.Drawing.Point(40, 70)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(10, 12)
        Me.Label26.TabIndex = 47
        Me.Label26.Text = "*"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Red
        Me.Label25.Location = New System.Drawing.Point(32, 38)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(10, 12)
        Me.Label25.TabIndex = 46
        Me.Label25.Text = "*"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(8, 19)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(10, 12)
        Me.Label24.TabIndex = 45
        Me.Label24.Text = "*"
        '
        'lblJobSite
        '
        Me.lblJobSite.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobSite.Location = New System.Drawing.Point(130, 56)
        Me.lblJobSite.Name = "lblJobSite"
        Me.lblJobSite.Size = New System.Drawing.Size(258, 44)
        Me.lblJobSite.TabIndex = 5
        '
        'lblCustomerName
        '
        Me.lblCustomerName.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(130, 38)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(258, 16)
        Me.lblCustomerName.TabIndex = 4
        '
        'lblProductName
        '
        Me.lblProductName.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.Location = New System.Drawing.Point(130, 19)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(258, 16)
        Me.lblProductName.TabIndex = 3
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(50, 70)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(74, 14)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Job Site :-"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(42, 38)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(82, 14)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Customer :-"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(18, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(108, 16)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Product Name:-"
        '
        'ViewNewJobList
        '
        Me.ViewNewJobList.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ViewNewJobList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewNewJobList.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewNewJobList.Location = New System.Drawing.Point(720, 52)
        Me.ViewNewJobList.Name = "ViewNewJobList"
        Me.ViewNewJobList.Size = New System.Drawing.Size(117, 38)
        Me.ViewNewJobList.TabIndex = 42
        Me.ViewNewJobList.Text = "&View New Job List"
        Me.ViewNewJobList.Visible = False
        '
        'grRecurring
        '
        Me.grRecurring.BackColor = System.Drawing.Color.White
        Me.grRecurring.Controls.Add(Me.Label28)
        Me.grRecurring.Controls.Add(Me.dtEndDate)
        Me.grRecurring.Controls.Add(Me.Label19)
        Me.grRecurring.Controls.Add(Me.Label18)
        Me.grRecurring.Controls.Add(Me.dtStartDate)
        Me.grRecurring.Controls.Add(Me.Label17)
        Me.grRecurring.Controls.Add(Me.cmbOccursEvery)
        Me.grRecurring.Controls.Add(Me.IsRecurring)
        Me.grRecurring.Font = New System.Drawing.Font("Verdana", 1.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grRecurring.Location = New System.Drawing.Point(402, 287)
        Me.grRecurring.Name = "grRecurring"
        Me.grRecurring.Size = New System.Drawing.Size(436, 56)
        Me.grRecurring.TabIndex = 12
        Me.grRecurring.TabStop = False
        Me.grRecurring.Visible = False
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Verdana", 8.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(7, 6)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(112, 16)
        Me.Label28.TabIndex = 22
        Me.Label28.Text = "Recurring Job :"
        '
        'dtEndDate
        '
        Me.dtEndDate.CustomFormat = "mm/dd/yyyy"
        Me.dtEndDate.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtEndDate.Location = New System.Drawing.Point(323, 32)
        Me.dtEndDate.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.dtEndDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtEndDate.Name = "dtEndDate"
        Me.dtEndDate.Size = New System.Drawing.Size(108, 21)
        Me.dtEndDate.TabIndex = 21
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(249, 33)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 16)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "End Date :-"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(241, 11)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 16)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Start Date :-"
        '
        'dtStartDate
        '
        Me.dtStartDate.CustomFormat = "mm/dd/yyyy"
        Me.dtStartDate.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtStartDate.Location = New System.Drawing.Point(323, 8)
        Me.dtStartDate.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.dtStartDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtStartDate.Name = "dtStartDate"
        Me.dtStartDate.Size = New System.Drawing.Size(108, 21)
        Me.dtStartDate.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(11, 32)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(112, 16)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Occurs every :-"
        '
        'cmbOccursEvery
        '
        Me.cmbOccursEvery.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOccursEvery.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        Me.cmbOccursEvery.Location = New System.Drawing.Point(123, 28)
        Me.cmbOccursEvery.Name = "cmbOccursEvery"
        Me.cmbOccursEvery.Size = New System.Drawing.Size(115, 21)
        Me.cmbOccursEvery.TabIndex = 2
        '
        'IsRecurring
        '
        Me.IsRecurring.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsRecurring.Location = New System.Drawing.Point(125, 8)
        Me.IsRecurring.Name = "IsRecurring"
        Me.IsRecurring.Size = New System.Drawing.Size(112, 20)
        Me.IsRecurring.TabIndex = 1
        Me.IsRecurring.Text = "Is Recurring?"
        '
        'btnViewProductInfo
        '
        Me.btnViewProductInfo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnViewProductInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewProductInfo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewProductInfo.Location = New System.Drawing.Point(56, 444)
        Me.btnViewProductInfo.Name = "btnViewProductInfo"
        Me.btnViewProductInfo.Size = New System.Drawing.Size(224, 24)
        Me.btnViewProductInfo.TabIndex = 16
        Me.btnViewProductInfo.Text = "View Full Product Info"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(544, 444)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(216, 24)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Cancel && Reset"
        '
        'lblProductDesc
        '
        Me.lblProductDesc.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductDesc.Location = New System.Drawing.Point(720, 94)
        Me.lblProductDesc.Name = "lblProductDesc"
        Me.lblProductDesc.Size = New System.Drawing.Size(35, 22)
        Me.lblProductDesc.TabIndex = 18
        Me.lblProductDesc.Text = "Product Info"
        Me.lblProductDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblProductDesc.Visible = False
        '
        'btnJobBoard
        '
        Me.btnJobBoard.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnJobBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJobBoard.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJobBoard.Location = New System.Drawing.Point(312, 444)
        Me.btnJobBoard.Name = "btnJobBoard"
        Me.btnJobBoard.Size = New System.Drawing.Size(200, 24)
        Me.btnJobBoard.TabIndex = 17
        Me.btnJobBoard.Text = "Goto ""JOB BOARD"""
        '
        'btnAddG
        '
        Me.btnAddG.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAddG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddG.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddG.Location = New System.Drawing.Point(762, 93)
        Me.btnAddG.Name = "btnAddG"
        Me.btnAddG.Size = New System.Drawing.Size(32, 24)
        Me.btnAddG.TabIndex = 3
        Me.btnAddG.Text = "Add Generator"
        Me.btnAddG.Visible = False
        '
        'btnAddP
        '
        Me.btnAddP.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAddP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddP.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddP.Location = New System.Drawing.Point(796, 92)
        Me.btnAddP.Name = "btnAddP"
        Me.btnAddP.Size = New System.Drawing.Size(32, 24)
        Me.btnAddP.TabIndex = 4
        Me.btnAddP.Text = "Add Product"
        Me.btnAddP.Visible = False
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(333, 211)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(101, 24)
        Me.btnSelect.TabIndex = 8
        Me.btnSelect.Text = "Select"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(434, 211)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 24)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        '
        'grpSelectProduct
        '
        Me.grpSelectProduct.Controls.Add(Me.chkInactiveProduct)
        Me.grpSelectProduct.Controls.Add(Me.Fil_Approval)
        Me.grpSelectProduct.Controls.Add(Me.Fill_Customer)
        Me.grpSelectProduct.Controls.Add(Me.Fil_Product)
        Me.grpSelectProduct.Controls.Add(Me.Fil_City)
        Me.grpSelectProduct.Controls.Add(Me.Fil_Address)
        Me.grpSelectProduct.Controls.Add(Me.Fill_JobSite)
        Me.grpSelectProduct.Controls.Add(Me.dgSearchProduct)
        Me.grpSelectProduct.Controls.Add(Me.btnSelect)
        Me.grpSelectProduct.Controls.Add(Me.btnClear)
        Me.grpSelectProduct.Controls.Add(Me.lblBorder)
        Me.grpSelectProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpSelectProduct.Location = New System.Drawing.Point(1, 0)
        Me.grpSelectProduct.Name = "grpSelectProduct"
        Me.grpSelectProduct.Size = New System.Drawing.Size(964, 239)
        Me.grpSelectProduct.TabIndex = 1
        Me.grpSelectProduct.TabStop = False
        Me.grpSelectProduct.Text = "Select a Product"
        '
        'chkInactiveProduct
        '
        Me.chkInactiveProduct.Location = New System.Drawing.Point(587, 214)
        Me.chkInactiveProduct.Name = "chkInactiveProduct"
        Me.chkInactiveProduct.Size = New System.Drawing.Size(168, 20)
        Me.chkInactiveProduct.TabIndex = 15
        Me.chkInactiveProduct.Text = "Include Inactive Product"
        '
        'Fil_Approval
        '
        Me.Fil_Approval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fil_Approval.Location = New System.Drawing.Point(792, 13)
        Me.Fil_Approval.Name = "Fil_Approval"
        Me.Fil_Approval.Size = New System.Drawing.Size(108, 21)
        Me.Fil_Approval.TabIndex = 6
        Me.Fil_Approval.Text = ""
        Me.ToolTip1.SetToolTip(Me.Fil_Approval, "Product Search Text")
        '
        'Fill_Customer
        '
        Me.Fill_Customer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fill_Customer.Location = New System.Drawing.Point(233, 13)
        Me.Fill_Customer.Name = "Fill_Customer"
        Me.Fill_Customer.Size = New System.Drawing.Size(166, 21)
        Me.Fill_Customer.TabIndex = 2
        Me.Fill_Customer.Text = ""
        Me.ToolTip1.SetToolTip(Me.Fill_Customer, "Customer Search Text")
        '
        'Fil_Product
        '
        Me.Fil_Product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fil_Product.Location = New System.Drawing.Point(643, 13)
        Me.Fil_Product.Name = "Fil_Product"
        Me.Fil_Product.Size = New System.Drawing.Size(149, 21)
        Me.Fil_Product.TabIndex = 5
        Me.Fil_Product.Text = ""
        Me.ToolTip1.SetToolTip(Me.Fil_Product, "Product Search Text")
        '
        'Fil_City
        '
        Me.Fil_City.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fil_City.Location = New System.Drawing.Point(538, 13)
        Me.Fil_City.Name = "Fil_City"
        Me.Fil_City.Size = New System.Drawing.Size(105, 21)
        Me.Fil_City.TabIndex = 4
        Me.Fil_City.Text = ""
        Me.ToolTip1.SetToolTip(Me.Fil_City, "City Search Text")
        '
        'Fil_Address
        '
        Me.Fil_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fil_Address.Location = New System.Drawing.Point(399, 13)
        Me.Fil_Address.Name = "Fil_Address"
        Me.Fil_Address.Size = New System.Drawing.Size(139, 21)
        Me.Fil_Address.TabIndex = 3
        Me.Fil_Address.Text = ""
        Me.ToolTip1.SetToolTip(Me.Fil_Address, "Address Search Text")
        '
        'Fill_JobSite
        '
        Me.Fill_JobSite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fill_JobSite.Location = New System.Drawing.Point(27, 13)
        Me.Fill_JobSite.Name = "Fill_JobSite"
        Me.Fill_JobSite.Size = New System.Drawing.Size(206, 21)
        Me.Fill_JobSite.TabIndex = 1
        Me.Fill_JobSite.Text = ""
        Me.ToolTip1.SetToolTip(Me.Fill_JobSite, "Generator Search Text")
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
        Me.dgSearchProduct.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgSearchProduct.LinkColor = System.Drawing.Color.Teal
        Me.dgSearchProduct.Location = New System.Drawing.Point(4, 40)
        Me.dgSearchProduct.Name = "dgSearchProduct"
        Me.dgSearchProduct.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dgSearchProduct.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.dgSearchProduct.RowHeaderWidth = 20
        Me.dgSearchProduct.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgSearchProduct.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgSearchProduct.Size = New System.Drawing.Size(954, 168)
        Me.dgSearchProduct.TabIndex = 7
        Me.dgSearchProduct.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.dgTblStyle})
        '
        'DsNewJobSearch1
        '
        Me.DsNewJobSearch1.DataSetName = "DSNewJobSearch"
        Me.DsNewJobSearch1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'dgTblStyle
        '
        Me.dgTblStyle.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.dgTblStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgTblStyle.DataGrid = Me.dgSearchProduct
        Me.dgTblStyle.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dgTblStyle.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.col_GName, Me.col_GeneratorName, Me.col_GAdd, Me.col_City, Me.col_Product, Me.col_ProductID, Me.col_GenID, Me.col_ApprovalNo, Me.col_IsNewProduct})
        Me.dgTblStyle.GridLineColor = System.Drawing.Color.Black
        Me.dgTblStyle.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgTblStyle.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgTblStyle.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgTblStyle.LinkColor = System.Drawing.Color.Teal
        Me.dgTblStyle.MappingName = "tblGenerators"
        Me.dgTblStyle.ReadOnly = True
        Me.dgTblStyle.RowHeaderWidth = 20
        Me.dgTblStyle.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgTblStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        '
        'col_GName
        '
        Me.col_GName.Format = ""
        Me.col_GName.FormatInfo = Nothing
        Me.col_GName.HeaderText = "Generator"
        Me.col_GName.MappingName = "GeneratorName"
        Me.col_GName.NullText = ""
        Me.col_GName.ReadOnly = True
        Me.col_GName.Width = 210
        '
        'col_GeneratorName
        '
        Me.col_GeneratorName.Format = ""
        Me.col_GeneratorName.FormatInfo = Nothing
        Me.col_GeneratorName.HeaderText = "Customer"
        Me.col_GeneratorName.MappingName = "JobSite"
        Me.col_GeneratorName.NullText = ""
        Me.col_GeneratorName.Width = 165
        '
        'col_GAdd
        '
        Me.col_GAdd.Format = ""
        Me.col_GAdd.FormatInfo = Nothing
        Me.col_GAdd.HeaderText = "Address"
        Me.col_GAdd.MappingName = "JobSiteAddress1"
        Me.col_GAdd.NullText = ""
        Me.col_GAdd.ReadOnly = True
        Me.col_GAdd.Width = 140
        '
        'col_City
        '
        Me.col_City.Format = ""
        Me.col_City.FormatInfo = Nothing
        Me.col_City.HeaderText = "City"
        Me.col_City.MappingName = "JobSiteCity"
        Me.col_City.NullText = ""
        Me.col_City.ReadOnly = True
        Me.col_City.Width = 105
        '
        'col_Product
        '
        Me.col_Product.Format = ""
        Me.col_Product.FormatInfo = Nothing
        Me.col_Product.HeaderText = "Product"
        Me.col_Product.MappingName = "ProductName"
        Me.col_Product.NullText = ""
        Me.col_Product.ReadOnly = True
        Me.col_Product.Width = 150
        '
        'col_ProductID
        '
        Me.col_ProductID.Format = ""
        Me.col_ProductID.FormatInfo = Nothing
        Me.col_ProductID.HeaderText = "ProductID"
        Me.col_ProductID.MappingName = "ProductID"
        Me.col_ProductID.NullText = ""
        Me.col_ProductID.ReadOnly = True
        Me.col_ProductID.Width = 0
        '
        'col_GenID
        '
        Me.col_GenID.Format = ""
        Me.col_GenID.FormatInfo = Nothing
        Me.col_GenID.HeaderText = "GeneratorID"
        Me.col_GenID.MappingName = "GeneratorID"
        Me.col_GenID.NullText = ""
        Me.col_GenID.ReadOnly = True
        Me.col_GenID.Width = 0
        '
        'col_ApprovalNo
        '
        Me.col_ApprovalNo.Format = ""
        Me.col_ApprovalNo.FormatInfo = Nothing
        Me.col_ApprovalNo.HeaderText = "Approval #"
        Me.col_ApprovalNo.MappingName = "ApprovalNo"
        Me.col_ApprovalNo.NullText = ""
        Me.col_ApprovalNo.ReadOnly = True
        Me.col_ApprovalNo.Width = 95
        '
        'col_IsNewProduct
        '
        Me.col_IsNewProduct.FalseValue = False
        Me.col_IsNewProduct.HeaderText = "IsNew?"
        Me.col_IsNewProduct.MappingName = "IsNewProduct"
        Me.col_IsNewProduct.NullText = "False"
        Me.col_IsNewProduct.NullValue = False
        Me.col_IsNewProduct.ReadOnly = True
        Me.col_IsNewProduct.TrueValue = True
        Me.col_IsNewProduct.Width = 50
        '
        'lblBorder
        '
        Me.lblBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBorder.Location = New System.Drawing.Point(3, 39)
        Me.lblBorder.Name = "lblBorder"
        Me.lblBorder.Size = New System.Drawing.Size(957, 170)
        Me.lblBorder.TabIndex = 13
        '
        'frmNewJob
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(967, 732)
        Me.Controls.Add(Me.grpSelectProduct)
        Me.Controls.Add(Me.grpProduct)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmNewJob"
        Me.Text = "frmNewJob"
        Me.grpProduct.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.grRecurring.ResumeLayout(False)
        Me.grpSelectProduct.ResumeLayout(False)
        CType(Me.dgSearchProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNewJobSearch1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Shared whichJob As String

    Private Sub frmNewJob_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.LoadHaulersReceivers()
        Me.LoadDGValues()
        Me.dtJobSchedule.Format = DateTimePickerFormat.Custom
        dtJobSchedule.CustomFormat = "MM/dd/yyyy"
        Me.dtStartDate.Format = DateTimePickerFormat.Custom
        Me.dtStartDate.CustomFormat = "MM/dd/yyyy"
        Me.dtEndDate.CustomFormat = "MM/dd/yyyy"
        Me.dtEndDate.Format = DateTimePickerFormat.Custom
        Me.dtEndDate.Value = DateAdd(DateInterval.Month, 1, Date.Now)

    End Sub

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
            Me.Fil_Product.Focus()
        ElseIf ((e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        Me.LoadDGValues()

    End Sub

    Private Sub Fil_Product_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Fil_Product.KeyUp

        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Enter)) Then
            System.Windows.Forms.SendKeys.SendWait("{TAB}")
            Me.btnSelect.Focus()
        ElseIf ((e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        Me.LoadDGValues()

    End Sub

    'Perry Patel
    Private Sub Fill_Customer_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Fill_Customer.KeyUp, Fil_Approval.KeyUp

        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Enter)) Then
            System.Windows.Forms.SendKeys.SendWait("{TAB}")
            Me.btnSelect.Focus()
        ElseIf ((e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        Me.LoadDGValues()

    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click

        If Me.dgSearchProduct.CurrentRowIndex < 0 Then
            MsgBox("Product not selected. Please select a product.", MsgBoxStyle.Information, "Invalid selection")
            Me.dgSearchProduct.Focus()
            Exit Sub
        End If
        Me.prodID = Me.dgSearchProduct.Item(Me.dgSearchProduct.CurrentRowIndex, 5)
        Me.genID = Me.dgSearchProduct.Item(Me.dgSearchProduct.CurrentRowIndex, 6)
        Me.PopulateProductInfo()
        Me.grpSelectProduct.Visible = False
        grpProduct.Top = 0
        Me.ViewNewJobList.Visible = True

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        Me.DsNewJobSearch1.Clear()
        Me.Fill_JobSite.Text = ""
        Me.Fil_Product.Text = ""
        Me.Fil_City.Text = ""
        Me.Fil_Address.Text = ""
        Me.LoadDGValues()
        Me.Fill_JobSite.Focus()

    End Sub

    Function clearProductContent()

        Me.lblProductDesc.Text = ""
        Me.lblAnalyticalDate.Text = ""
        Me.lblOustandingBalance.Text = ""
        Me.lblNumOfDays.Text = ""
        Me.lblCName.Text = ""
        Me.lblCPhone.Text = ""
        Me.lblApprovalNo.Text = ""
        Me.chkPaperworkList.ClearSelected()
        Me.dtJobSchedule.Value = Today
        Me.grpProduct.Visible = False

    End Function

    Function LoadDGValues()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet, whereClause As String = ""
        Try
            Dim strSQL As String
            '-------------------------------------------------------------------
            'Haigriv Vyas
            'Date: 07/05/2005
            '-------------------------------------------------------------------
            strSQL = "SELECT tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblProducts.ProductName, tblProducts.ProductID, tblGenerators.GeneratorID, tblGenerators.GeneratorName, tblProducts.ApprovalNo, tblProducts.IsNewProduct FROM (tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) "
            If Me.Fill_JobSite.Text <> "" Then
                whereClause = " WHERE (tblGenerators.GeneratorName Like '" & Replace(Me.Fill_JobSite.Text, "'", "''") & "%') "
            End If
            '-------------------------------------------------------------------
            'Haigriv Vyas
            'Date: 07/05/2005
            '-------------------------------------------------------------------
            'Perry Patel
            If Me.Fill_Customer.Text <> "" Then
                If whereClause <> "" Then
                    whereClause = whereClause & " AND (tblGenerators.JobSite Like '" & Replace(Me.Fill_Customer.Text, "'", "''") & "%') "
                Else
                    whereClause = " WHERE (tblGenerators.JobSite Like '" & Replace(Me.Fill_Customer.Text, "'", "''") & "%') "
                End If
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
            If Me.Fil_Product.Text <> "" Then
                If whereClause <> "" Then
                    whereClause = whereClause & " AND (tblProducts.ProductName Like '" & Replace(Me.Fil_Product.Text, "'", "''") & "%') "
                Else
                    whereClause = " WHERE (tblProducts.ProductName Like '" & Replace(Me.Fil_Product.Text, "'", "''") & "%') "
                End If
            End If
            If Me.Fil_Approval.Text <> "" Then
                If whereClause <> "" Then
                    whereClause = whereClause & " AND (tblProducts.ApprovalNo Like '" & Replace(Me.Fil_Approval.Text, "'", "''") & "%') "
                Else
                    whereClause = " WHERE (tblProducts.ApprovalNo Like '" & Replace(Me.Fil_Approval.Text, "'", "''") & "%') "
                End If
            End If

            If Me.chkInactiveProduct.Checked = False Then
                If whereClause.Trim <> "" Then
                    strSQL = strSQL & whereClause & " AND (tblProducts.Active = True)"
                Else
                    strSQL = strSQL & " WHERE (tblProducts.Active = True)"
                End If
            Else
                If whereClause <> "" Then strSQL = strSQL & whereClause
            End If
            'If whereClause <> "" Then
            '    strSQL = strSQL & whereClause & " AND (tblProducts.Active = TRUE) ORDER BY tblGenerators.GeneratorName, tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblProducts.ProductName "
            'Else
            '    strSQL = strSQL & " WHERE (tblProducts.Active = TRUE) ORDER BY tblGenerators.GeneratorName, tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblProducts.ProductName "
            'End If
            ds = DBHelper.GetDataSet(strSQL, "tblGenerators")
            Me.dgSearchProduct.DataSource = ds
            Me.dgSearchProduct.DataMember = "tblGenerators"
            Me.dgSearchProduct.Refresh()

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Function

    Private Sub btnViewProductInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewProductInfo.Click

        If Me.prodID > 0 And Me.genID > 0 Then
            Dim frmP As New frmProduct
            frmP.ViewProductInfo(Me.prodID, Me.genID)
        End If

    End Sub

    Private Sub btnAddG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddG.Click

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim newGForm As New frmGenerator
        newGForm.ShowDialog(Me)
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub btnAddP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddP.Click

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim newPForm As New frmProduct
        newPForm.ShowDialog(Me)
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Function LoadHaulersReceivers()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet
        Dim ds1 As DataSet
        Dim ds2 As DataSet
        Dim strSQL As String

        Try
            'Get Transporters
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
            Me.cmbHauler.SelectedIndex = 1
            'Get Disposal Facilities
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
            Me.cmbReceivingSite.SelectedIndex = 1
            'Get Truck Types
            strSQL = "SELECT TypeOfTruckID, TypeOfTruck FROM tblTypeOfTrucks ORDER BY TypeOfTruck "
            ds2 = DBHelper.GetDataSet(strSQL, "tblTypeOfTrucks")
            Me.cmbTruckType.DataSource = ds2
            Me.cmbTruckType.DisplayMember = "tblTypeOfTrucks.TypeOfTruck"
            Me.cmbTruckType.ValueMember = "tblTypeOfTrucks.TypeOfTruckID"
            Me.cmbTruckType.SelectedValue = 0

            Dim dsWorkType As DataSet
            strSQL = "SELECT WasteType FROM tblWasteType ORDER BY ID"
            dsWorkType = DBHelper.GetDataSet(strSQL, "tblWasteType")
            Me.cmbWasteType.DataSource = dsWorkType
            Me.cmbWasteType.DisplayMember = "tblWasteType.WasteType"
            Me.cmbWasteType.SelectedText = ""
            Me.cmbWasteType.Text = ""
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally
            Me.grpProduct.Visible = False
            ds = Nothing
            ds1 = Nothing
            ds2 = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Function

    Function PopulateProductInfo()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet = New DataSet
        Dim strSQL As String
        Try
            strSQL = "SELECT tblProducts.*, ContactName, ContactPhone, GeneratorName, JobSite, JobSiteAddress1 as Address, (JobSiteCity & ', ' & JobSiteState & ' ' & JobSiteZip) as CityStateZip,tblGenerators.G_USEPAID FROM tblProducts INNER JOIN tblGenerators ON tblProducts.GeneratorID = tblGenerators.GeneratorID WHERE ProductID = " & Me.prodID
            Me.prodID = Me.dgSearchProduct.Item(Me.dgSearchProduct.CurrentRowIndex, 5)
            ds = DBHelper.GetDataSet(strSQL, "tblProduct")
            If ds.Tables(0).Rows.Count > 0 Then
                Me.grpProduct.Visible = True
                Me.grpProduct.Focus()
                Me.IsBeaver.Checked = True
                Me.IsOutsideHauler.Checked = False
                Me.IsMultiStop.Checked = False
                'Initialize Credit Check fields
                Me.lblOustandingBalance.Text = ""
                Me.lblNumOfDays.Text = ""
                Me.lblApprovalNo.Text = IIf(IsDBNull(ds.Tables(0).Rows(0).Item("ApprovalNo")), "", CStr(ds.Tables(0).Rows(0).Item("ApprovalNo")))
                Me.lblProductDesc.Text = ds.Tables(0).Rows(0).Item("ProductName") & " - " & ds.Tables(0).Rows(0).Item("GeneratorName") & vbCrLf & ds.Tables(0).Rows(0).Item("JobSite") & " - " & ds.Tables(0).Rows(0).Item("Address") & vbCrLf & ds.Tables(0).Rows(0).Item("CityStateZip")
                If IsDBNull(ds.Tables(0).Rows(0).Item("ProductName")) = False Then Me.lblProductName.Text = ds.Tables(0).Rows(0).Item("ProductName").ToString.Trim Else Me.lblProductName.Text = ""
                If IsDBNull(ds.Tables(0).Rows(0).Item("GeneratorName")) = False Then Me.lblJobSite.Text = ds.Tables(0).Rows(0).Item("GeneratorName").ToString Else Me.lblJobSite.Text = ""
                If IsDBNull(ds.Tables(0).Rows(0).Item("JobSite")) = False Then Me.lblCustomerName.Text = ds.Tables(0).Rows(0).Item("JobSite").ToString Else Me.lblCustomerName.Text = ""
                If IsDBNull(ds.Tables(0).Rows(0).Item("Address")) = False Then Me.lblJobSite.Text = lblJobSite.Text.Trim & vbCrLf & ds.Tables(0).Rows(0).Item("Address").ToString Else Me.lblJobSite.Text = Me.lblJobSite.Text.ToString.Trim
                If IsDBNull(ds.Tables(0).Rows(0).Item("CityStateZip")) = False Then Me.lblJobSite.Text = lblJobSite.Text.Trim & vbCrLf & ds.Tables(0).Rows(0).Item("CityStateZip").ToString Else Me.lblJobSite.Text = Me.lblJobSite.Text.ToString.Trim
                If IsDBNull(ds.Tables(0).Rows(0).Item("PermitNo")) = False Then Me.lblVerifiedDate.Text = ds.Tables(0).Rows(0).Item("PermitNo").ToString Else Me.lblVerifiedDate.Text = ""
                Me.cmbWasteType.Text = IIf(IsDBNull(ds.Tables(0).Rows(0).Item("WasteType")), " ", ds.Tables(0).Rows(0).Item("WasteType"))
                If IsDBNull(ds.Tables(0).Rows(0).Item("SpecialInstructions")) = False Then Me.txtProductSpecialInstruction.Text = ds.Tables(0).Rows(0).Item("SpecialInstructions").ToString Else Me.txtProductSpecialInstruction.Text = ""
                Me.chkPaperworkList.Enabled = True
                If ds.Tables(0).Rows(0).Item("NonHazardous") = True Then
                    Me.chkPaperworkList.SetItemChecked(0, True)
                End If
                If ds.Tables(0).Rows(0).Item("Hazardous") = True Then
                    Me.chkPaperworkList.SetItemChecked(1, True)
                End If
                If ds.Tables(0).Rows(0).Item("BillOfLading") = True Then
                    Me.chkPaperworkList.SetItemChecked(2, True)
                End If
                If ds.Tables(0).Rows(0).Item("JobTicket") = True Then
                    Me.chkPaperworkList.SetItemChecked(3, True)
                End If
                If ds.Tables(0).Rows(0).Item("Plant2Manifest") = True Then
                    Me.chkPaperworkList.SetItemChecked(4, True)
                End If
                Me.lblCName.Text = ds.Tables(0).Rows(0).Item("ContactName")
                Me.lblCPhone.Text = ds.Tables(0).Rows(0).Item("ContactPhone")
                Me.dtJobSchedule.Value = DateAdd(DateInterval.Day, 1, Today)
                If IsDBNull(ds.Tables(0).Rows(0).Item("AnalyticalDate")) = False Then
                    Me.lblAnalyticalDate.Text = ds.Tables(0).Rows(0).Item("AnalyticalDate")
                Else
                    Me.lblAnalyticalDate.Text = ""
                End If
                If IsDBNull(ds.Tables(0).Rows(0).Item("LabRecertDate")) = False Then
                    Me.lblRecertDate.Text = ds.Tables(0).Rows(0).Item("LabRecertDate")
                Else
                    Me.lblRecertDate.Text = ""
                End If
                If IsDBNull(ds.Tables(0).Rows(0).Item("G_USEPAID")) = False Then Me.lblGID.Text = ds.Tables(0).Rows(0).Item("G_USEPAID").ToString Else Me.lblGID.Text = ""
                'Check to see if the Generator has a Credit Problem
                'Criteria is if Invoiced Amount hasn't been paid for more than 29 days
                Dim genSTR As String
                genSTR = "SELECT GeneratorID FROM tblProducts WHERE ProductID = " & Me.prodID & ""
                Dim genID As Integer = DBHelper.GetInteger(genSTR)
                Me.genID = genID
                strSQL = "SELECT Count(*) " _
                        & " FROM tblProducts INNER JOIN (tblJobTickets INNER JOIN tblInvoicing ON tblJobTickets.JobTicketID = tblInvoicing.JobTicketID) ON tblProducts.ProductID = tblJobTickets.ProductID " _
                        & " WHERE (((tblInvoicing.PaymentReceived)=False) AND ((tblProducts.GeneratorID)=" & genID & "));"
                If DBHelper.GetRecordCount(strSQL) > 0 Then
                    strSQL = "SELECT Min(tblInvoicing.InvoiceDate) AS MaxOfInvoiceDate " _
                            & " FROM tblProducts INNER JOIN (tblJobTickets INNER JOIN tblInvoicing ON tblJobTickets.JobTicketID = tblInvoicing.JobTicketID) ON tblProducts.ProductID = tblJobTickets.ProductID " _
                            & " WHERE (((tblInvoicing.PaymentReceived)=False) AND (tblJobTickets.IsCancelled =False) AND ((tblProducts.GeneratorID)=" & genID & "));"
                    Dim ds1 As DataSet = DBHelper.GetDataSet(strSQL, "tblCreditCheck")
                    If ds1.Tables(0).Rows.Count > 0 Then
                        Dim iDate As Date = CDate(ds1.Tables(0).Rows(0).Item(0))
                        Dim iNum As Integer = DateDiff(DateInterval.Day, Today.Date, iDate)
                        Me.lblNumOfDays.Text = CStr(iNum)
                        strSQL = "SELECT Sum(tblInvoicing.InvoiceAmount) AS SumOfInvoiceAmount " _
                                & " FROM tblProducts INNER JOIN (tblJobTickets INNER JOIN tblInvoicing ON tblJobTickets.JobTicketID = tblInvoicing.JobTicketID) ON tblProducts.ProductID = tblJobTickets.ProductID " _
                                & " WHERE (((tblInvoicing.PaymentReceived)=False) AND ((tblProducts.GeneratorID)=" & genID & "));"
                        Dim ds2 As DataSet = DBHelper.GetDataSet(strSQL, "tblCreditCheck")
                        If ds2.Tables(0).Rows.Count > 0 Then
                            Me.lblOustandingBalance.Text = ds2.Tables(0).Rows(0).Item(0)
                            If IsNumeric(Me.lblOustandingBalance.Text) = True Then
                                Me.lblOustandingBalance.Text = Format(Decimal.Round(Decimal.Parse(Me.lblOustandingBalance.Text), 2), "C")
                            End If
                        End If
                        ds2 = Nothing
                    End If
                    ds1 = Nothing
                End If
            Else
                MsgBox("Cannot find the product you have selected.", MsgBoxStyle.Information, "Product not found")
            End If

        Catch ex As SystemException
            MsgBox("An Error ocurred while processing your request: " & ex.Message & "", MsgBoxStyle.Critical, "Error ocurred")

        Finally
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        If MsgBox("Are you sure you want to cancel Scheduling this job?", MsgBoxStyle.YesNo, "Cancel a Job") = MsgBoxResult.Yes Then
            'Cancel job
            Me.clearProductContent()
            Me.Fill_JobSite.Focus()
        End If

    End Sub

    Private Sub btnJobBoard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJobBoard.Click

        Dim curDate As Date = Me.dtJobSchedule.Value
        If Me.cmbTruckType.SelectedIndex < 0 Then Me.cmbTruckType.SelectedIndex = 0
        'If Me.IsMultiStop.Checked = False Then
        '    If Me.cmbTruckType.SelectedIndex = 0 And Me.chkDrums.Checked = False Then
        '        MsgBox("Please select a Type of Truck.", MsgBoxStyle.Information, "Type of Truck")
        '        Me.cmbTruckType.Focus()
        '        Exit Sub
        '    End If
        'End If

        If Me.IsOutsideHauler.Checked = True And Me.cmbHauler.SelectedIndex = 0 Then
            MsgBox("Please select a Hauler.", MsgBoxStyle.Information, "Outside Hauler")
            Me.cmbHauler.Focus()
            Exit Sub
        End If
        If Me.IsRecurring.Checked = True Then
            If Me.cmbOccursEvery.SelectedIndex < 0 Then
                MsgBox("Please select a Weekday this job occurs on.", MsgBoxStyle.Information, "Recurring Job")
                Me.cmbOccursEvery.Focus()
                Exit Sub
            End If
            If Me.dtStartDate.Value.ToShortDateString.Trim = "" Then
                MsgBox("Please select a Start Date this job.", MsgBoxStyle.Information, "Recurring Job")
                Me.dtStartDate.Focus()
                Exit Sub
            Else
                If IsDate(Me.dtStartDate.Value) = False Then
                    MsgBox("Invalid Start date.", MsgBoxStyle.Information, "Recurring Job")
                    Me.dtStartDate.Focus()
                    Exit Sub
                End If
            End If
            If Me.dtEndDate.Value.ToShortDateString.Trim = "" Then
                MsgBox("Please select a End Date this job.", MsgBoxStyle.Information, "Recurring Job")
                Me.dtStartDate.Focus()
                Exit Sub
            Else
                If IsDate(Me.dtEndDate.Value) = False Then
                    MsgBox("Invalid End date.", MsgBoxStyle.Information, "Recurring Job")
                    Me.dtEndDate.Focus()
                    Exit Sub
                End If
            End If
            If CDate(Me.dtEndDate.Value.ToShortDateString) < CDate(Me.dtStartDate.Value.ToShortDateString) Then
                MsgBox("End date of recurring job must be greater than Start date.", MsgBoxStyle.Information, "Recurring Job")
                Me.dtEndDate.Focus()
                Exit Sub
            Else
                If DateDiff(DateInterval.Month, Me.dtStartDate.Value, Me.dtEndDate.Value) > 3 Then
                    MsgBox("End date can not be more than 3 month from Start date.You can not schedule more than 3 Months for Recurring job.", MsgBoxStyle.Information, "Recurring Job")
                    Me.dtEndDate.Focus()
                    Exit Sub
                End If
            End If
            If DateDiff(DateInterval.Day, CDate(Date.Now.ToShortDateString), CDate(Me.dtStartDate.Value.ToShortDateString)) < 0 Then
                MsgBox("You cannot schedule a Job Back in time. Please select a valid date.", MsgBoxStyle.Information, "Recurring Job")
                Me.dtStartDate.Focus()
                Exit Sub
            End If
        End If
        'Perry Patel
        If Me.IsRecurring.Checked = True Then
            frmNewJob.whichJob = "R"
        Else
            If Me.IsBeaver.Checked = True Then
                frmNewJob.whichJob = "B"
            ElseIf Me.IsOutsideHauler.Checked = True Then
                frmNewJob.whichJob = "O"
            ElseIf Me.IsMultiStop.Checked = True Then
                frmNewJob.whichJob = "M"
            End If
        End If
        Dim nH As Boolean, h As Boolean, jt As Boolean, bol As Boolean, p2m As Boolean
        Dim IsBeaver As Boolean, IsOutsideHauler As Boolean, IsMultiStop As Boolean
        Dim spInstr As String, schTime As String, spInstr_T As String = ""
        Dim Hauler As Long = 0, Receiver As Long = 0, IsDrums As Boolean
        Dim PO As String, PrintFormC As Boolean, IsR As Boolean, Rec_Day As String, Rec_Start As Date, Rec_End As Date
        Dim MultiStop As Boolean = False
        Dim IsManifest As Boolean
        Dim strWasteType As String = ""
        Dim Gallons As Decimal = 0
        Try

            nH = Me.chkPaperworkList.GetItemChecked(0)
            h = Me.chkPaperworkList.GetItemChecked(1)
            bol = Me.chkPaperworkList.GetItemChecked(2)
            jt = Me.chkPaperworkList.GetItemChecked(3)
            p2m = Me.chkPaperworkList.GetItemChecked(4)
            PrintFormC = Me.chkPaperworkList.GetItemChecked(5)
            IsBeaver = Me.IsBeaver.Checked
            IsOutsideHauler = Me.IsOutsideHauler.Checked
            IsMultiStop = Me.IsMultiStop.Checked
            spInstr = Me.SpecialInstrutions.Text
            schTime = Me.ScheduledTime.Text
            Hauler = Me.cmbHauler.SelectedValue
            Receiver = Me.cmbReceivingSite.SelectedValue
            spInstr_T = Me.SpecialInstrutions_T.Text
            IsDrums = Me.chkDrums.Checked
            PO = Replace(Me.txtPO.Text, "'", "''")
            IsR = Me.IsRecurring.Checked
            IsManifest = Me.IsManifest.Checked
            strWasteType = Me.cmbWasteType.Text
            If Me.txtGallons.Text <> "" AndAlso IsNumeric(Me.txtGallons.Text) = False Then
                MsgBox("Gallons field must be Numeric.")
                Exit Sub
            ElseIf Me.txtGallons.Text <> "" AndAlso CInt(Me.txtGallons.Text) > 0 Then
                Gallons = Me.txtGallons.Text
            Else
                Gallons = 0
            End If

            If IsR = True Then
                Rec_Day = Me.cmbOccursEvery.Text
                Rec_Start = Me.dtStartDate.Value.ToShortDateString
                Rec_End = Me.dtEndDate.Value.ToShortDateString
            End If
            If MsgBox("Are you sure you want to Schedule this job?", MsgBoxStyle.YesNo, "Schedule a Job") = MsgBoxResult.Yes Then
                'Save and Go to Job Board
                Dim strSQL As String
                Dim nextJTID As Long
                nextJTID = DBHelper.GetInteger("SELECT Max(JobTicketNo) FROM tblJobTickets")
                nextJTID = IIf(nextJTID = 0, 1000, nextJTID + 1)

                If IsR = True Then
                    strSQL = "INSERT INTO tblJobTickets_Recurring (ProductID, ScheduleDate, NonHazardous, BillOfLading, Hazardous, JobTicket, Plant2Manifest, TypeOfTruckID, IsBeaver, IsMultiStop, IsOutsideHauler, SpecialInstructions, ScheduledTime, TransporterID, DisposalFacilityID, SpecialInstructions_T, Drums, JobPO, PrintFormC, JobStartDate,JobEndDate, WeekDay) " _
                        & " SELECT " & Me.prodID & ", '" & curDate & "'," & nH & "," & bol & "," & h & "," & jt & ", " & p2m & ", " & Me.cmbTruckType.SelectedValue & "," & IsBeaver & ", " & IsMultiStop & ", " & IsOutsideHauler & ", '" & Replace(spInstr, "'", "''") & "', '" & Replace(schTime, "'", "''") & "', " & Hauler & ", " & Receiver & ", '" & Replace(spInstr_T, "'", "''") & "', " & IsDrums & ", '" & PO & "', " & PrintFormC & ", #" & Rec_Start & "#,#" & Rec_End & "#,'" & Rec_Day & "';"

                    If DBHelper.ExecuteQuery(strSQL) = False Then
                        MsgBox("Cannot schedule job. Error ocurred.", MsgBoxStyle.Critical, "Error")
                        Exit Sub
                    End If
                    Dim dindex As Integer = Me.cmbOccursEvery.SelectedIndex
                    Dim dtTemp As Date = DateAdd(DateInterval.Day, dindex, Me.dtStartDate.Value)
                    While (dtTemp <= Me.dtEndDate.Value.ToShortDateString)
                        nextJTID = DBHelper.GetInteger("SELECT Max(JobTicketNo) FROM tblJobTickets")
                        nextJTID = IIf(nextJTID = 0, 1000, nextJTID + 1)
                        strSQL = "INSERT INTO tblJobTickets (JobTicketNo, ProductID, ScheduleDate, NonHazardous, BillOfLading, Hazardous, JobTicket, Plant2Manifest, TypeOfTruckID, IsBeaver, IsMultiStop, IsOutsideHauler, SpecialInstructions, ScheduledTime, TransporterID, DisposalFacilityID, SpecialInstructions_T, Drums, JobPO, PrintFormC,IsManifest,WasteType,Gallons) " _
                        & " SELECT " & nextJTID & " AS JobTicketNo, " & Me.prodID & ", '" & dtTemp.ToShortDateString & "'," & nH & "," & bol & "," & h & "," & jt & ", " & p2m & ", " & Me.cmbTruckType.SelectedValue & "," & IsBeaver & ", " & IsMultiStop & ", " & IsOutsideHauler & ", '" & Replace(spInstr, "'", "''") & "', '" & Replace(schTime, "'", "''") & "', " & Hauler & ", " & Receiver & ", '" & Replace(spInstr_T, "'", "''") & "', " & IsDrums & ", '" & PO & "', " & PrintFormC & "," & IsManifest & ",'" & strWasteType & "'," & Gallons & ";"
                        If DBHelper.ExecuteQuery(strSQL) = False Then
                            MsgBox("Cannot schedule job. Error ocurred.", MsgBoxStyle.Critical, "Error")
                            Exit Sub
                        End If
                        dtTemp = DateAdd(DateInterval.Day, 7, dtTemp)
                    End While
                    DirectCast(MdiParent, frmMainScreen).Link2Clicked()
                Else
                    strSQL = "INSERT INTO tblJobTickets (JobTicketNo, ProductID, ScheduleDate, NonHazardous, BillOfLading, Hazardous, JobTicket, Plant2Manifest, TypeOfTruckID, IsBeaver, IsMultiStop, IsOutsideHauler, SpecialInstructions, ScheduledTime, TransporterID, DisposalFacilityID, SpecialInstructions_T, Drums, JobPO, PrintFormC,IsManifest,WasteType,Gallons) " _
                    & " SELECT " & nextJTID & " AS JobTicketNo, " & Me.prodID & ", '" & curDate & "'," & nH & "," & bol & "," & h & "," & jt & ", " & p2m & ", " & Me.cmbTruckType.SelectedValue & "," & IsBeaver & ", " & IsMultiStop & ", " & IsOutsideHauler & ", '" & Replace(spInstr, "'", "''") & "', '" & Replace(schTime, "'", "''") & "', " & Hauler & ", " & Receiver & ", '" & Replace(spInstr_T, "'", "''") & "', " & IsDrums & ", '" & PO & "', " & PrintFormC & "," & IsManifest & ",'" & strWasteType & "'," & Gallons & ";"
                    If DBHelper.ExecuteQuery(strSQL) = False Then
                        MsgBox("Cannot schedule job. Error ocurred.", MsgBoxStyle.Critical, "Error")
                        Exit Sub
                    Else
                        DirectCast(MdiParent, frmMainScreen).Link2Clicked()
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("Error Ocurred: " & ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        End Try

    End Sub

    Private Sub ViewNewJobList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewNewJobList.Click

        Me.ViewNewJobList.Visible = False
        Me.grpSelectProduct.Visible = True
        Me.grpSelectProduct.Top = 0
        Me.grpProduct.Top = 247

    End Sub

    Private Sub dtStartDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtStartDate.Leave

        Dim dtStart As DateTime
        dtStart = Me.dtStartDate.Value.ToShortDateString
        Me.dtEndDate.Value = DateAdd(DateInterval.Month, 1, dtStart)

    End Sub

    Private Sub cmbWasteType_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbWasteType.KeyUp
        Dim index As Integer, actual As String, found As String
        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Back) Or (e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        ' Store the actual text that has been typed
        actual = Me.cmbWasteType.Text
        ' Find the first match for the typed value
        index = Me.cmbWasteType.FindString(actual)
        ' Get the text of the first match
        If (index > -1) Then
            ' Select this item from the list
            Me.cmbWasteType.SelectedIndex = index
            found = Me.cmbWasteType.Text
            ' Select the portion of the text that was automatically added so further typing will replace it
            Me.cmbWasteType.SelectionStart = actual.Length
            Me.cmbWasteType.SelectionLength = found.Length - actual.Length
        End If
    End Sub

    Private Sub chkDrums_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.txtGallons.Visible = Me.chkDrums.Checked
        Me.lblGallons.Visible = Me.chkDrums.Checked
    End Sub
    Private Sub chkInactiveProduct_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkInactiveProduct.CheckedChanged
        Me.LoadDGValues()
    End Sub

End Class
