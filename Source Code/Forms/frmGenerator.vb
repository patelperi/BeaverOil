Public Class frmGenerator

    Inherits System.Windows.Forms.Form
    Public genID As Integer = 0
    Dim addNewFlag As Boolean = False
    Public GenCount As Integer

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
    Friend WithEvents btnCancelG As System.Windows.Forms.Button
    Friend WithEvents btnSaveG As System.Windows.Forms.Button
    Friend WithEvents lblGeneratorLabel As System.Windows.Forms.Label
    Friend WithEvents grpContactInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents grpJobSite As System.Windows.Forms.GroupBox
    Friend WithEvents grpBilling As System.Windows.Forms.GroupBox
    Friend WithEvents ContactPhone As System.Windows.Forms.TextBox
    Friend WithEvents ContactName As System.Windows.Forms.TextBox
    Friend WithEvents BrokerPhone As System.Windows.Forms.TextBox
    Friend WithEvents BrokerContact As System.Windows.Forms.TextBox
    Friend WithEvents JobSiteZip As System.Windows.Forms.TextBox
    Friend WithEvents JobSiteState As System.Windows.Forms.TextBox
    Friend WithEvents JobSiteCity As System.Windows.Forms.TextBox
    Friend WithEvents JobSiteAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents JobSiteAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents BillingZip As System.Windows.Forms.TextBox
    Friend WithEvents BillingState As System.Windows.Forms.TextBox
    Friend WithEvents BillingCity As System.Windows.Forms.TextBox
    Friend WithEvents BillingAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents BillingAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents BillingName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents GNo As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents G_USEPAID As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents grpMailing As System.Windows.Forms.GroupBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents MailingZip As System.Windows.Forms.TextBox
    Friend WithEvents MailingState As System.Windows.Forms.TextBox
    Friend WithEvents MailingCity As System.Windows.Forms.TextBox
    Friend WithEvents MailingAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents MailingAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents MailingName As System.Windows.Forms.TextBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Verified As System.Windows.Forms.CheckBox
    Friend WithEvents GeneratorName As System.Windows.Forms.TextBox
    Friend WithEvents JobSite As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DsGenList1 As BeaverOil.dsGenList
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents col_GenID As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_GName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_GeneratorName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_City As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgTblStyle As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents dgSearchGenerator As System.Windows.Forms.DataGrid
    Friend WithEvents btnAddNewProduct As System.Windows.Forms.Button
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Fill_JobSite As System.Windows.Forms.TextBox
    Friend WithEvents Fill_Customer As System.Windows.Forms.TextBox
    Friend WithEvents Fil_City As System.Windows.Forms.TextBox
    Friend WithEvents grpSelectGenerator As System.Windows.Forms.GroupBox
    Friend WithEvents grBottom As System.Windows.Forms.GroupBox
    Friend WithEvents ViewNewJobList As System.Windows.Forms.Button
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents btnPrint As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents col_GeneratorAddress As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Fil_Address As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmGenerator))
        Me.btnCancelG = New System.Windows.Forms.Button
        Me.btnSaveG = New System.Windows.Forms.Button
        Me.Label62 = New System.Windows.Forms.Label
        Me.Verified = New System.Windows.Forms.CheckBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.G_USEPAID = New System.Windows.Forms.TextBox
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.GNo = New System.Windows.Forms.TextBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.ContactPhone = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.ContactName = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.chkActive = New System.Windows.Forms.CheckBox
        Me.grpContactInfo = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.BrokerPhone = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.BrokerContact = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.JobSite = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblGeneratorLabel = New System.Windows.Forms.Label
        Me.grpJobSite = New System.Windows.Forms.GroupBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.JobSiteZip = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.JobSiteState = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.JobSiteCity = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.JobSiteAddress2 = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.JobSiteAddress1 = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.GeneratorName = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.grpBilling = New System.Windows.Forms.GroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.BillingZip = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.BillingState = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.BillingCity = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.BillingAddress2 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.BillingAddress1 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.BillingName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button
        Me.grpMailing = New System.Windows.Forms.GroupBox
        Me.Label51 = New System.Windows.Forms.Label
        Me.MailingZip = New System.Windows.Forms.TextBox
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.MailingState = New System.Windows.Forms.TextBox
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.MailingCity = New System.Windows.Forms.TextBox
        Me.Label56 = New System.Windows.Forms.Label
        Me.MailingAddress2 = New System.Windows.Forms.TextBox
        Me.Label57 = New System.Windows.Forms.Label
        Me.MailingAddress1 = New System.Windows.Forms.TextBox
        Me.Label58 = New System.Windows.Forms.Label
        Me.MailingName = New System.Windows.Forms.TextBox
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label60 = New System.Windows.Forms.Label
        Me.Label61 = New System.Windows.Forms.Label
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.DsGenList1 = New BeaverOil.dsGenList
        Me.dgSearchGenerator = New System.Windows.Forms.DataGrid
        Me.dgTblStyle = New System.Windows.Forms.DataGridTableStyle
        Me.col_GenID = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_GName = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_GeneratorName = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_GeneratorAddress = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_City = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn
        Me.grpSelectGenerator = New System.Windows.Forms.GroupBox
        Me.Fil_Address = New System.Windows.Forms.TextBox
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Fil_City = New System.Windows.Forms.TextBox
        Me.Fill_Customer = New System.Windows.Forms.TextBox
        Me.Fill_JobSite = New System.Windows.Forms.TextBox
        Me.btnAddNewProduct = New System.Windows.Forms.Button
        Me.btnSelect = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.ViewNewJobList = New System.Windows.Forms.Button
        Me.grBottom = New System.Windows.Forms.GroupBox
        Me.btnPrint = New System.Windows.Forms.PictureBox
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.grpContactInfo.SuspendLayout()
        Me.grpJobSite.SuspendLayout()
        Me.grpBilling.SuspendLayout()
        Me.grpMailing.SuspendLayout()
        CType(Me.DsGenList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgSearchGenerator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSelectGenerator.SuspendLayout()
        Me.grBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelG
        '
        Me.btnCancelG.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCancelG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelG.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelG.Location = New System.Drawing.Point(154, 348)
        Me.btnCancelG.Name = "btnCancelG"
        Me.btnCancelG.Size = New System.Drawing.Size(112, 24)
        Me.btnCancelG.TabIndex = 34
        Me.btnCancelG.Text = "&Cancel"
        '
        'btnSaveG
        '
        Me.btnSaveG.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSaveG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveG.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveG.Location = New System.Drawing.Point(40, 348)
        Me.btnSaveG.Name = "btnSaveG"
        Me.btnSaveG.Size = New System.Drawing.Size(112, 24)
        Me.btnSaveG.TabIndex = 33
        Me.btnSaveG.Text = "&Save"
        '
        'Label62
        '
        Me.Label62.Location = New System.Drawing.Point(160, 264)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(64, 16)
        Me.Label62.TabIndex = 39
        Me.Label62.Text = "Verified?"
        '
        'Verified
        '
        Me.Verified.Checked = True
        Me.Verified.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Verified.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Verified.Location = New System.Drawing.Point(224, 264)
        Me.Verified.Name = "Verified"
        Me.Verified.Size = New System.Drawing.Size(16, 16)
        Me.Verified.TabIndex = 16
        '
        'Label47
        '
        Me.Label47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label47.Location = New System.Drawing.Point(136, 256)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(184, 1)
        Me.Label47.TabIndex = 37
        '
        'G_USEPAID
        '
        Me.G_USEPAID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.G_USEPAID.Location = New System.Drawing.Point(144, 240)
        Me.G_USEPAID.MaxLength = 20
        Me.G_USEPAID.Name = "G_USEPAID"
        Me.G_USEPAID.Size = New System.Drawing.Size(176, 13)
        Me.G_USEPAID.TabIndex = 14
        Me.G_USEPAID.Text = ""
        '
        'Label50
        '
        Me.Label50.Location = New System.Drawing.Point(64, 240)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(72, 16)
        Me.Label50.TabIndex = 36
        Me.Label50.Text = "FED #:"
        '
        'Label45
        '
        Me.Label45.Location = New System.Drawing.Point(48, 264)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(64, 16)
        Me.Label45.TabIndex = 30
        Me.Label45.Text = "Active:"
        '
        'Label43
        '
        Me.Label43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label43.Location = New System.Drawing.Point(136, 232)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(184, 1)
        Me.Label43.TabIndex = 29
        '
        'GNo
        '
        Me.GNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GNo.Location = New System.Drawing.Point(144, 216)
        Me.GNo.MaxLength = 20
        Me.GNo.Name = "GNo"
        Me.GNo.Size = New System.Drawing.Size(176, 13)
        Me.GNo.TabIndex = 12
        Me.GNo.Text = ""
        '
        'Label44
        '
        Me.Label44.Location = New System.Drawing.Point(16, 216)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(120, 16)
        Me.Label44.TabIndex = 28
        Me.Label44.Text = "Generator # (IL #):"
        '
        'Label20
        '
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Location = New System.Drawing.Point(136, 208)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(184, 1)
        Me.Label20.TabIndex = 15
        '
        'ContactPhone
        '
        Me.ContactPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ContactPhone.Location = New System.Drawing.Point(144, 192)
        Me.ContactPhone.MaxLength = 20
        Me.ContactPhone.Name = "ContactPhone"
        Me.ContactPhone.Size = New System.Drawing.Size(176, 13)
        Me.ContactPhone.TabIndex = 11
        Me.ContactPhone.Text = ""
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(40, 192)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 16)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "Contact Phone:"
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Location = New System.Drawing.Point(80, 184)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(320, 1)
        Me.Label17.TabIndex = 12
        '
        'ContactName
        '
        Me.ContactName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ContactName.Location = New System.Drawing.Point(88, 168)
        Me.ContactName.MaxLength = 75
        Me.ContactName.Name = "ContactName"
        Me.ContactName.Size = New System.Drawing.Size(312, 13)
        Me.ContactName.TabIndex = 10
        Me.ContactName.Text = ""
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(24, 168)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 16)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Contact:"
        '
        'chkActive
        '
        Me.chkActive.Checked = True
        Me.chkActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkActive.Location = New System.Drawing.Point(112, 264)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(16, 16)
        Me.chkActive.TabIndex = 15
        '
        'grpContactInfo
        '
        Me.grpContactInfo.Controls.Add(Me.Label3)
        Me.grpContactInfo.Controls.Add(Me.BrokerPhone)
        Me.grpContactInfo.Controls.Add(Me.Label19)
        Me.grpContactInfo.Controls.Add(Me.Label22)
        Me.grpContactInfo.Controls.Add(Me.BrokerContact)
        Me.grpContactInfo.Controls.Add(Me.Label23)
        Me.grpContactInfo.Controls.Add(Me.Label24)
        Me.grpContactInfo.Controls.Add(Me.JobSite)
        Me.grpContactInfo.Controls.Add(Me.Label25)
        Me.grpContactInfo.Controls.Add(Me.Label15)
        Me.grpContactInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpContactInfo.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpContactInfo.Location = New System.Drawing.Point(418, 24)
        Me.grpContactInfo.Name = "grpContactInfo"
        Me.grpContactInfo.Size = New System.Drawing.Size(408, 90)
        Me.grpContactInfo.TabIndex = 4
        Me.grpContactInfo.TabStop = False
        Me.grpContactInfo.Text = "Customer Info"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(112, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 1)
        Me.Label3.TabIndex = 24
        '
        'BrokerPhone
        '
        Me.BrokerPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BrokerPhone.Location = New System.Drawing.Point(120, 64)
        Me.BrokerPhone.MaxLength = 20
        Me.BrokerPhone.Name = "BrokerPhone"
        Me.BrokerPhone.Size = New System.Drawing.Size(176, 13)
        Me.BrokerPhone.TabIndex = 19
        Me.BrokerPhone.Text = ""
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(8, 64)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 16)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Contact Phone:"
        '
        'Label22
        '
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Location = New System.Drawing.Point(72, 56)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(312, 1)
        Me.Label22.TabIndex = 21
        '
        'BrokerContact
        '
        Me.BrokerContact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BrokerContact.Location = New System.Drawing.Point(80, 40)
        Me.BrokerContact.MaxLength = 75
        Me.BrokerContact.Name = "BrokerContact"
        Me.BrokerContact.Size = New System.Drawing.Size(304, 13)
        Me.BrokerContact.TabIndex = 18
        Me.BrokerContact.Text = ""
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(8, 40)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 16)
        Me.Label23.TabIndex = 19
        Me.Label23.Text = "Contact:"
        '
        'Label24
        '
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.Location = New System.Drawing.Point(72, 32)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(312, 1)
        Me.Label24.TabIndex = 18
        '
        'JobSite
        '
        Me.JobSite.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.JobSite.Location = New System.Drawing.Point(80, 16)
        Me.JobSite.MaxLength = 75
        Me.JobSite.Name = "JobSite"
        Me.JobSite.Size = New System.Drawing.Size(304, 13)
        Me.JobSite.TabIndex = 17
        Me.JobSite.Text = ""
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(16, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(48, 16)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "Name:"
        '
        'Label15
        '
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(8, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(8, 8)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "*"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblGeneratorLabel
        '
        Me.lblGeneratorLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneratorLabel.ForeColor = System.Drawing.Color.Navy
        Me.lblGeneratorLabel.Location = New System.Drawing.Point(206, 6)
        Me.lblGeneratorLabel.Name = "lblGeneratorLabel"
        Me.lblGeneratorLabel.Size = New System.Drawing.Size(412, 16)
        Me.lblGeneratorLabel.TabIndex = 9
        Me.lblGeneratorLabel.Text = "Generator:"
        Me.lblGeneratorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grpJobSite
        '
        Me.grpJobSite.Controls.Add(Me.Label41)
        Me.grpJobSite.Controls.Add(Me.Label40)
        Me.grpJobSite.Controls.Add(Me.Label39)
        Me.grpJobSite.Controls.Add(Me.Label38)
        Me.grpJobSite.Controls.Add(Me.Label26)
        Me.grpJobSite.Controls.Add(Me.JobSiteZip)
        Me.grpJobSite.Controls.Add(Me.Label27)
        Me.grpJobSite.Controls.Add(Me.Label28)
        Me.grpJobSite.Controls.Add(Me.JobSiteState)
        Me.grpJobSite.Controls.Add(Me.Label29)
        Me.grpJobSite.Controls.Add(Me.Label30)
        Me.grpJobSite.Controls.Add(Me.JobSiteCity)
        Me.grpJobSite.Controls.Add(Me.Label31)
        Me.grpJobSite.Controls.Add(Me.JobSiteAddress2)
        Me.grpJobSite.Controls.Add(Me.Label32)
        Me.grpJobSite.Controls.Add(Me.JobSiteAddress1)
        Me.grpJobSite.Controls.Add(Me.Label33)
        Me.grpJobSite.Controls.Add(Me.GeneratorName)
        Me.grpJobSite.Controls.Add(Me.Label34)
        Me.grpJobSite.Controls.Add(Me.Label35)
        Me.grpJobSite.Controls.Add(Me.Label36)
        Me.grpJobSite.Controls.Add(Me.Label45)
        Me.grpJobSite.Controls.Add(Me.Label43)
        Me.grpJobSite.Controls.Add(Me.GNo)
        Me.grpJobSite.Controls.Add(Me.ContactPhone)
        Me.grpJobSite.Controls.Add(Me.Label21)
        Me.grpJobSite.Controls.Add(Me.Label17)
        Me.grpJobSite.Controls.Add(Me.ContactName)
        Me.grpJobSite.Controls.Add(Me.Label18)
        Me.grpJobSite.Controls.Add(Me.chkActive)
        Me.grpJobSite.Controls.Add(Me.Label44)
        Me.grpJobSite.Controls.Add(Me.Label62)
        Me.grpJobSite.Controls.Add(Me.Verified)
        Me.grpJobSite.Controls.Add(Me.Label47)
        Me.grpJobSite.Controls.Add(Me.G_USEPAID)
        Me.grpJobSite.Controls.Add(Me.Label50)
        Me.grpJobSite.Controls.Add(Me.Label20)
        Me.grpJobSite.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpJobSite.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpJobSite.Location = New System.Drawing.Point(4, 24)
        Me.grpJobSite.Name = "grpJobSite"
        Me.grpJobSite.Size = New System.Drawing.Size(414, 300)
        Me.grpJobSite.TabIndex = 2
        Me.grpJobSite.TabStop = False
        Me.grpJobSite.Text = "Generator"
        '
        'Label41
        '
        Me.Label41.ForeColor = System.Drawing.Color.Red
        Me.Label41.Location = New System.Drawing.Point(2, 120)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(8, 8)
        Me.Label41.TabIndex = 39
        Me.Label41.Text = "*"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label40
        '
        Me.Label40.ForeColor = System.Drawing.Color.Red
        Me.Label40.Location = New System.Drawing.Point(2, 96)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(8, 8)
        Me.Label40.TabIndex = 38
        Me.Label40.Text = "*"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label39
        '
        Me.Label39.ForeColor = System.Drawing.Color.Red
        Me.Label39.Location = New System.Drawing.Point(2, 48)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(8, 8)
        Me.Label39.TabIndex = 37
        Me.Label39.Text = "*"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label38
        '
        Me.Label38.ForeColor = System.Drawing.Color.Red
        Me.Label38.Location = New System.Drawing.Point(2, 24)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(8, 8)
        Me.Label38.TabIndex = 36
        Me.Label38.Text = "*"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label26
        '
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label26.Location = New System.Drawing.Point(180, 132)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(112, 1)
        Me.Label26.TabIndex = 35
        '
        'JobSiteZip
        '
        Me.JobSiteZip.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.JobSiteZip.Location = New System.Drawing.Point(188, 116)
        Me.JobSiteZip.MaxLength = 10
        Me.JobSiteZip.Name = "JobSiteZip"
        Me.JobSiteZip.Size = New System.Drawing.Size(104, 13)
        Me.JobSiteZip.TabIndex = 8
        Me.JobSiteZip.Text = ""
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(120, 116)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 16)
        Me.Label27.TabIndex = 33
        Me.Label27.Text = "Zip Code:"
        '
        'Label28
        '
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label28.Location = New System.Drawing.Point(64, 132)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(40, 1)
        Me.Label28.TabIndex = 32
        '
        'JobSiteState
        '
        Me.JobSiteState.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.JobSiteState.Location = New System.Drawing.Point(68, 116)
        Me.JobSiteState.MaxLength = 2
        Me.JobSiteState.Name = "JobSiteState"
        Me.JobSiteState.Size = New System.Drawing.Size(32, 13)
        Me.JobSiteState.TabIndex = 7
        Me.JobSiteState.Text = ""
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(8, 116)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(48, 16)
        Me.Label29.TabIndex = 30
        Me.Label29.Text = "State:"
        '
        'Label30
        '
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label30.Location = New System.Drawing.Point(64, 108)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(320, 1)
        Me.Label30.TabIndex = 29
        '
        'JobSiteCity
        '
        Me.JobSiteCity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.JobSiteCity.Location = New System.Drawing.Point(68, 92)
        Me.JobSiteCity.MaxLength = 50
        Me.JobSiteCity.Name = "JobSiteCity"
        Me.JobSiteCity.Size = New System.Drawing.Size(316, 13)
        Me.JobSiteCity.TabIndex = 6
        Me.JobSiteCity.Text = ""
        '
        'Label31
        '
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label31.Location = New System.Drawing.Point(64, 84)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(320, 1)
        Me.Label31.TabIndex = 27
        '
        'JobSiteAddress2
        '
        Me.JobSiteAddress2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.JobSiteAddress2.Location = New System.Drawing.Point(68, 68)
        Me.JobSiteAddress2.MaxLength = 75
        Me.JobSiteAddress2.Name = "JobSiteAddress2"
        Me.JobSiteAddress2.Size = New System.Drawing.Size(316, 13)
        Me.JobSiteAddress2.TabIndex = 5
        Me.JobSiteAddress2.Text = ""
        '
        'Label32
        '
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label32.Location = New System.Drawing.Point(64, 60)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(320, 1)
        Me.Label32.TabIndex = 25
        '
        'JobSiteAddress1
        '
        Me.JobSiteAddress1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.JobSiteAddress1.Location = New System.Drawing.Point(68, 44)
        Me.JobSiteAddress1.MaxLength = 75
        Me.JobSiteAddress1.Name = "JobSiteAddress1"
        Me.JobSiteAddress1.Size = New System.Drawing.Size(316, 13)
        Me.JobSiteAddress1.TabIndex = 4
        Me.JobSiteAddress1.Text = ""
        '
        'Label33
        '
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label33.Location = New System.Drawing.Point(64, 36)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(320, 1)
        Me.Label33.TabIndex = 23
        '
        'GeneratorName
        '
        Me.GeneratorName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GeneratorName.Location = New System.Drawing.Point(68, 20)
        Me.GeneratorName.MaxLength = 75
        Me.GeneratorName.Name = "GeneratorName"
        Me.GeneratorName.Size = New System.Drawing.Size(316, 13)
        Me.GeneratorName.TabIndex = 3
        Me.GeneratorName.Text = ""
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(8, 92)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(48, 16)
        Me.Label34.TabIndex = 21
        Me.Label34.Text = "City:"
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(8, 44)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(56, 16)
        Me.Label35.TabIndex = 20
        Me.Label35.Text = "Address:"
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(8, 20)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(48, 16)
        Me.Label36.TabIndex = 19
        Me.Label36.Text = "Name:"
        '
        'grpBilling
        '
        Me.grpBilling.Controls.Add(Me.Label13)
        Me.grpBilling.Controls.Add(Me.BillingZip)
        Me.grpBilling.Controls.Add(Me.Label14)
        Me.grpBilling.Controls.Add(Me.Label11)
        Me.grpBilling.Controls.Add(Me.BillingState)
        Me.grpBilling.Controls.Add(Me.Label12)
        Me.grpBilling.Controls.Add(Me.Label10)
        Me.grpBilling.Controls.Add(Me.BillingCity)
        Me.grpBilling.Controls.Add(Me.Label9)
        Me.grpBilling.Controls.Add(Me.BillingAddress2)
        Me.grpBilling.Controls.Add(Me.Label8)
        Me.grpBilling.Controls.Add(Me.BillingAddress1)
        Me.grpBilling.Controls.Add(Me.Label7)
        Me.grpBilling.Controls.Add(Me.BillingName)
        Me.grpBilling.Controls.Add(Me.Label6)
        Me.grpBilling.Controls.Add(Me.Label5)
        Me.grpBilling.Controls.Add(Me.Label4)
        Me.grpBilling.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpBilling.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBilling.Location = New System.Drawing.Point(418, 116)
        Me.grpBilling.Name = "grpBilling"
        Me.grpBilling.Size = New System.Drawing.Size(408, 144)
        Me.grpBilling.TabIndex = 5
        Me.grpBilling.TabStop = False
        Me.grpBilling.Text = "Billing Info (if different)"
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(184, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 1)
        Me.Label13.TabIndex = 18
        '
        'BillingZip
        '
        Me.BillingZip.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BillingZip.Location = New System.Drawing.Point(192, 120)
        Me.BillingZip.MaxLength = 10
        Me.BillingZip.Name = "BillingZip"
        Me.BillingZip.Size = New System.Drawing.Size(104, 13)
        Me.BillingZip.TabIndex = 25
        Me.BillingZip.Text = ""
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(112, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 16)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Zip Code:"
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(64, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 1)
        Me.Label11.TabIndex = 15
        '
        'BillingState
        '
        Me.BillingState.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BillingState.Location = New System.Drawing.Point(72, 120)
        Me.BillingState.MaxLength = 2
        Me.BillingState.Name = "BillingState"
        Me.BillingState.Size = New System.Drawing.Size(32, 13)
        Me.BillingState.TabIndex = 24
        Me.BillingState.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 16)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "State:"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(64, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(320, 1)
        Me.Label10.TabIndex = 12
        '
        'BillingCity
        '
        Me.BillingCity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BillingCity.Location = New System.Drawing.Point(72, 96)
        Me.BillingCity.MaxLength = 50
        Me.BillingCity.Name = "BillingCity"
        Me.BillingCity.Size = New System.Drawing.Size(312, 13)
        Me.BillingCity.TabIndex = 23
        Me.BillingCity.Text = ""
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(64, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(320, 1)
        Me.Label9.TabIndex = 10
        '
        'BillingAddress2
        '
        Me.BillingAddress2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BillingAddress2.Location = New System.Drawing.Point(72, 72)
        Me.BillingAddress2.MaxLength = 75
        Me.BillingAddress2.Name = "BillingAddress2"
        Me.BillingAddress2.Size = New System.Drawing.Size(312, 13)
        Me.BillingAddress2.TabIndex = 22
        Me.BillingAddress2.Text = ""
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(64, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(320, 1)
        Me.Label8.TabIndex = 8
        '
        'BillingAddress1
        '
        Me.BillingAddress1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BillingAddress1.Location = New System.Drawing.Point(72, 48)
        Me.BillingAddress1.MaxLength = 75
        Me.BillingAddress1.Name = "BillingAddress1"
        Me.BillingAddress1.Size = New System.Drawing.Size(312, 13)
        Me.BillingAddress1.TabIndex = 21
        Me.BillingAddress1.Text = ""
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(64, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(320, 1)
        Me.Label7.TabIndex = 6
        '
        'BillingName
        '
        Me.BillingName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BillingName.Location = New System.Drawing.Point(72, 24)
        Me.BillingName.MaxLength = 75
        Me.BillingName.Name = "BillingName"
        Me.BillingName.Size = New System.Drawing.Size(312, 13)
        Me.BillingName.TabIndex = 20
        Me.BillingName.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "City:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Address:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(4, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Note: * indicates required fields."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.SlateGray
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(242, 348)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(32, 24)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "&In-Activate"
        Me.btnDelete.Visible = False
        '
        'grpMailing
        '
        Me.grpMailing.Controls.Add(Me.Label51)
        Me.grpMailing.Controls.Add(Me.MailingZip)
        Me.grpMailing.Controls.Add(Me.Label52)
        Me.grpMailing.Controls.Add(Me.Label53)
        Me.grpMailing.Controls.Add(Me.MailingState)
        Me.grpMailing.Controls.Add(Me.Label54)
        Me.grpMailing.Controls.Add(Me.Label55)
        Me.grpMailing.Controls.Add(Me.MailingCity)
        Me.grpMailing.Controls.Add(Me.Label56)
        Me.grpMailing.Controls.Add(Me.MailingAddress2)
        Me.grpMailing.Controls.Add(Me.Label57)
        Me.grpMailing.Controls.Add(Me.MailingAddress1)
        Me.grpMailing.Controls.Add(Me.Label58)
        Me.grpMailing.Controls.Add(Me.MailingName)
        Me.grpMailing.Controls.Add(Me.Label59)
        Me.grpMailing.Controls.Add(Me.Label60)
        Me.grpMailing.Controls.Add(Me.Label61)
        Me.grpMailing.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpMailing.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMailing.Location = New System.Drawing.Point(418, 262)
        Me.grpMailing.Name = "grpMailing"
        Me.grpMailing.Size = New System.Drawing.Size(408, 144)
        Me.grpMailing.TabIndex = 6
        Me.grpMailing.TabStop = False
        Me.grpMailing.Text = "Mailing Info (if different)"
        '
        'Label51
        '
        Me.Label51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label51.Location = New System.Drawing.Point(184, 136)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(112, 1)
        Me.Label51.TabIndex = 18
        '
        'MailingZip
        '
        Me.MailingZip.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MailingZip.Location = New System.Drawing.Point(192, 120)
        Me.MailingZip.MaxLength = 10
        Me.MailingZip.Name = "MailingZip"
        Me.MailingZip.Size = New System.Drawing.Size(104, 13)
        Me.MailingZip.TabIndex = 31
        Me.MailingZip.Text = ""
        '
        'Label52
        '
        Me.Label52.Location = New System.Drawing.Point(112, 120)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(64, 16)
        Me.Label52.TabIndex = 16
        Me.Label52.Text = "Zip Code:"
        '
        'Label53
        '
        Me.Label53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label53.Location = New System.Drawing.Point(64, 136)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(40, 1)
        Me.Label53.TabIndex = 15
        '
        'MailingState
        '
        Me.MailingState.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MailingState.Location = New System.Drawing.Point(72, 120)
        Me.MailingState.MaxLength = 2
        Me.MailingState.Name = "MailingState"
        Me.MailingState.Size = New System.Drawing.Size(32, 13)
        Me.MailingState.TabIndex = 30
        Me.MailingState.Text = ""
        '
        'Label54
        '
        Me.Label54.Location = New System.Drawing.Point(8, 120)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(48, 16)
        Me.Label54.TabIndex = 13
        Me.Label54.Text = "State:"
        '
        'Label55
        '
        Me.Label55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label55.Location = New System.Drawing.Point(64, 112)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(320, 1)
        Me.Label55.TabIndex = 12
        '
        'MailingCity
        '
        Me.MailingCity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MailingCity.Location = New System.Drawing.Point(72, 96)
        Me.MailingCity.MaxLength = 50
        Me.MailingCity.Name = "MailingCity"
        Me.MailingCity.Size = New System.Drawing.Size(312, 13)
        Me.MailingCity.TabIndex = 29
        Me.MailingCity.Text = ""
        '
        'Label56
        '
        Me.Label56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label56.Location = New System.Drawing.Point(64, 88)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(320, 1)
        Me.Label56.TabIndex = 10
        '
        'MailingAddress2
        '
        Me.MailingAddress2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MailingAddress2.Location = New System.Drawing.Point(72, 72)
        Me.MailingAddress2.MaxLength = 75
        Me.MailingAddress2.Name = "MailingAddress2"
        Me.MailingAddress2.Size = New System.Drawing.Size(312, 13)
        Me.MailingAddress2.TabIndex = 28
        Me.MailingAddress2.Text = ""
        '
        'Label57
        '
        Me.Label57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label57.Location = New System.Drawing.Point(64, 64)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(320, 1)
        Me.Label57.TabIndex = 8
        '
        'MailingAddress1
        '
        Me.MailingAddress1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MailingAddress1.Location = New System.Drawing.Point(72, 48)
        Me.MailingAddress1.MaxLength = 75
        Me.MailingAddress1.Name = "MailingAddress1"
        Me.MailingAddress1.Size = New System.Drawing.Size(312, 13)
        Me.MailingAddress1.TabIndex = 27
        Me.MailingAddress1.Text = ""
        '
        'Label58
        '
        Me.Label58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label58.Location = New System.Drawing.Point(64, 40)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(320, 1)
        Me.Label58.TabIndex = 6
        '
        'MailingName
        '
        Me.MailingName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MailingName.Location = New System.Drawing.Point(72, 24)
        Me.MailingName.MaxLength = 75
        Me.MailingName.Name = "MailingName"
        Me.MailingName.Size = New System.Drawing.Size(312, 13)
        Me.MailingName.TabIndex = 26
        Me.MailingName.Text = ""
        '
        'Label59
        '
        Me.Label59.Location = New System.Drawing.Point(8, 96)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(48, 16)
        Me.Label59.TabIndex = 4
        Me.Label59.Text = "City:"
        '
        'Label60
        '
        Me.Label60.Location = New System.Drawing.Point(8, 48)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(56, 16)
        Me.Label60.TabIndex = 3
        Me.Label60.Text = "Address:"
        '
        'Label61
        '
        Me.Label61.Location = New System.Drawing.Point(8, 24)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(48, 16)
        Me.Label61.TabIndex = 2
        Me.Label61.Text = "Name:"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblGenerators", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GeneratorName", "GeneratorName"), New System.Data.Common.DataColumnMapping("JobSite", "JobSite"), New System.Data.Common.DataColumnMapping("JobSiteCity", "JobSiteCity"), New System.Data.Common.DataColumnMapping("Active", "Active")})})
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT GeneratorName, JobSite, JobSiteCity, Active, GeneratorID, JobSiteAddress1 " & _
        "FROM tblGenerators ORDER BY GeneratorName, JobSite, JobSiteCity, Active"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
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
        'DsGenList1
        '
        Me.DsGenList1.DataSetName = "dsGenList"
        Me.DsGenList1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'dgSearchGenerator
        '
        Me.dgSearchGenerator.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.dgSearchGenerator.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgSearchGenerator.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgSearchGenerator.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgSearchGenerator.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgSearchGenerator.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgSearchGenerator.CaptionVisible = False
        Me.dgSearchGenerator.DataMember = "tblGenerators"
        Me.dgSearchGenerator.DataSource = Me.DsGenList1
        Me.dgSearchGenerator.FlatMode = True
        Me.dgSearchGenerator.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgSearchGenerator.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dgSearchGenerator.GridLineColor = System.Drawing.Color.Gainsboro
        Me.dgSearchGenerator.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgSearchGenerator.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgSearchGenerator.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgSearchGenerator.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgSearchGenerator.LinkColor = System.Drawing.Color.Teal
        Me.dgSearchGenerator.Location = New System.Drawing.Point(8, 36)
        Me.dgSearchGenerator.Name = "dgSearchGenerator"
        Me.dgSearchGenerator.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dgSearchGenerator.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.dgSearchGenerator.RowHeaderWidth = 30
        Me.dgSearchGenerator.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgSearchGenerator.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgSearchGenerator.Size = New System.Drawing.Size(812, 156)
        Me.dgSearchGenerator.TabIndex = 5
        Me.dgSearchGenerator.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.dgTblStyle})
        '
        'dgTblStyle
        '
        Me.dgTblStyle.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.dgTblStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgTblStyle.DataGrid = Me.dgSearchGenerator
        Me.dgTblStyle.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dgTblStyle.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.col_GenID, Me.col_GName, Me.col_GeneratorName, Me.col_GeneratorAddress, Me.col_City, Me.DataGridBoolColumn1})
        Me.dgTblStyle.GridLineColor = System.Drawing.Color.Black
        Me.dgTblStyle.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgTblStyle.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgTblStyle.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgTblStyle.LinkColor = System.Drawing.Color.Teal
        Me.dgTblStyle.MappingName = "tblGenerators"
        Me.dgTblStyle.ReadOnly = True
        Me.dgTblStyle.RowHeaderWidth = 30
        Me.dgTblStyle.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgTblStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        '
        'col_GenID
        '
        Me.col_GenID.Format = ""
        Me.col_GenID.FormatInfo = Nothing
        Me.col_GenID.HeaderText = "GenID"
        Me.col_GenID.MappingName = "GeneratorID"
        Me.col_GenID.Width = 0
        '
        'col_GName
        '
        Me.col_GName.Format = ""
        Me.col_GName.FormatInfo = Nothing
        Me.col_GName.HeaderText = "Generator"
        Me.col_GName.MappingName = "GeneratorName"
        Me.col_GName.NullText = ""
        Me.col_GName.ReadOnly = True
        Me.col_GName.Width = 225
        '
        'col_GeneratorName
        '
        Me.col_GeneratorName.Format = ""
        Me.col_GeneratorName.FormatInfo = Nothing
        Me.col_GeneratorName.HeaderText = "Customer"
        Me.col_GeneratorName.MappingName = "JobSite"
        Me.col_GeneratorName.NullText = ""
        Me.col_GeneratorName.ReadOnly = True
        Me.col_GeneratorName.Width = 200
        '
        'col_GeneratorAddress
        '
        Me.col_GeneratorAddress.Format = ""
        Me.col_GeneratorAddress.FormatInfo = Nothing
        Me.col_GeneratorAddress.HeaderText = "Address"
        Me.col_GeneratorAddress.MappingName = "JobSiteAddress1"
        Me.col_GeneratorAddress.NullText = ""
        Me.col_GeneratorAddress.ReadOnly = True
        Me.col_GeneratorAddress.Width = 135
        '
        'col_City
        '
        Me.col_City.Format = ""
        Me.col_City.FormatInfo = Nothing
        Me.col_City.HeaderText = "City"
        Me.col_City.MappingName = "JobSiteCity"
        Me.col_City.NullText = ""
        Me.col_City.ReadOnly = True
        Me.col_City.Width = 125
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.FalseValue = False
        Me.DataGridBoolColumn1.HeaderText = "Active ?"
        Me.DataGridBoolColumn1.MappingName = "Active"
        Me.DataGridBoolColumn1.NullValue = CType(resources.GetObject("DataGridBoolColumn1.NullValue"), Object)
        Me.DataGridBoolColumn1.ReadOnly = True
        Me.DataGridBoolColumn1.TrueValue = True
        Me.DataGridBoolColumn1.Width = 75
        '
        'grpSelectGenerator
        '
        Me.grpSelectGenerator.Controls.Add(Me.Fil_Address)
        Me.grpSelectGenerator.Controls.Add(Me.Label42)
        Me.grpSelectGenerator.Controls.Add(Me.Label37)
        Me.grpSelectGenerator.Controls.Add(Me.Label16)
        Me.grpSelectGenerator.Controls.Add(Me.Label1)
        Me.grpSelectGenerator.Controls.Add(Me.Fil_City)
        Me.grpSelectGenerator.Controls.Add(Me.Fill_Customer)
        Me.grpSelectGenerator.Controls.Add(Me.Fill_JobSite)
        Me.grpSelectGenerator.Controls.Add(Me.btnAddNewProduct)
        Me.grpSelectGenerator.Controls.Add(Me.btnSelect)
        Me.grpSelectGenerator.Controls.Add(Me.btnClear)
        Me.grpSelectGenerator.Controls.Add(Me.dgSearchGenerator)
        Me.grpSelectGenerator.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSelectGenerator.Location = New System.Drawing.Point(2, 4)
        Me.grpSelectGenerator.Name = "grpSelectGenerator"
        Me.grpSelectGenerator.Size = New System.Drawing.Size(828, 222)
        Me.grpSelectGenerator.TabIndex = 35
        Me.grpSelectGenerator.TabStop = False
        Me.grpSelectGenerator.Text = "Select Gen + Cust Combination"
        '
        'Fil_Address
        '
        Me.Fil_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fil_Address.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fil_Address.Location = New System.Drawing.Point(464, 14)
        Me.Fil_Address.Name = "Fil_Address"
        Me.Fil_Address.Size = New System.Drawing.Size(136, 20)
        Me.Fil_Address.TabIndex = 27
        Me.Fil_Address.Text = ""
        '
        'Label42
        '
        Me.Label42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label42.Location = New System.Drawing.Point(822, 36)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(1, 158)
        Me.Label42.TabIndex = 26
        '
        'Label37
        '
        Me.Label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label37.Location = New System.Drawing.Point(8, 36)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(1, 158)
        Me.Label37.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Location = New System.Drawing.Point(8, 36)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(816, 1)
        Me.Label16.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(6, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(816, 1)
        Me.Label1.TabIndex = 23
        '
        'Fil_City
        '
        Me.Fil_City.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fil_City.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fil_City.Location = New System.Drawing.Point(600, 14)
        Me.Fil_City.Name = "Fil_City"
        Me.Fil_City.Size = New System.Drawing.Size(160, 20)
        Me.Fil_City.TabIndex = 22
        Me.Fil_City.Text = ""
        '
        'Fill_Customer
        '
        Me.Fill_Customer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fill_Customer.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fill_Customer.Location = New System.Drawing.Point(264, 14)
        Me.Fill_Customer.Name = "Fill_Customer"
        Me.Fill_Customer.Size = New System.Drawing.Size(200, 20)
        Me.Fill_Customer.TabIndex = 21
        Me.Fill_Customer.Text = ""
        '
        'Fill_JobSite
        '
        Me.Fill_JobSite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fill_JobSite.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fill_JobSite.Location = New System.Drawing.Point(36, 14)
        Me.Fill_JobSite.Name = "Fill_JobSite"
        Me.Fill_JobSite.Size = New System.Drawing.Size(228, 20)
        Me.Fill_JobSite.TabIndex = 20
        Me.Fill_JobSite.Text = ""
        '
        'btnAddNewProduct
        '
        Me.btnAddNewProduct.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewProduct.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewProduct.Location = New System.Drawing.Point(8, 198)
        Me.btnAddNewProduct.Name = "btnAddNewProduct"
        Me.btnAddNewProduct.Size = New System.Drawing.Size(224, 20)
        Me.btnAddNewProduct.TabIndex = 19
        Me.btnAddNewProduct.Text = "ADD NEW GEN-CUST"
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(374, 198)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(101, 20)
        Me.btnSelect.TabIndex = 17
        Me.btnSelect.Text = "Select"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(480, 198)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(76, 20)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        '
        'ViewNewJobList
        '
        Me.ViewNewJobList.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ViewNewJobList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewNewJobList.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewNewJobList.Location = New System.Drawing.Point(632, 4)
        Me.ViewNewJobList.Name = "ViewNewJobList"
        Me.ViewNewJobList.Size = New System.Drawing.Size(194, 20)
        Me.ViewNewJobList.TabIndex = 23
        Me.ViewNewJobList.Text = "&View Gen + Cust List"
        '
        'grBottom
        '
        Me.grBottom.Controls.Add(Me.btnPrint)
        Me.grBottom.Controls.Add(Me.Label2)
        Me.grBottom.Controls.Add(Me.lblGeneratorLabel)
        Me.grBottom.Controls.Add(Me.ViewNewJobList)
        Me.grBottom.Controls.Add(Me.grpJobSite)
        Me.grBottom.Controls.Add(Me.grpContactInfo)
        Me.grBottom.Controls.Add(Me.grpBilling)
        Me.grBottom.Controls.Add(Me.grpMailing)
        Me.grBottom.Controls.Add(Me.btnSaveG)
        Me.grBottom.Controls.Add(Me.btnDelete)
        Me.grBottom.Controls.Add(Me.btnCancelG)
        Me.grBottom.Location = New System.Drawing.Point(2, 228)
        Me.grBottom.Name = "grBottom"
        Me.grBottom.Size = New System.Drawing.Size(828, 408)
        Me.grBottom.TabIndex = 36
        Me.grBottom.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(306, 344)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(54, 44)
        Me.btnPrint.TabIndex = 36
        Me.btnPrint.TabStop = False
        '
        'StatusBar1
        '
        Me.StatusBar1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.Location = New System.Drawing.Point(0, 638)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Size = New System.Drawing.Size(832, 14)
        Me.StatusBar1.TabIndex = 37
        Me.StatusBar1.Text = "StatusBar1"
        '
        'frmGenerator
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(1, 2)
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(832, 652)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.grBottom)
        Me.Controls.Add(Me.grpSelectGenerator)
        Me.Font = New System.Drawing.Font("Verdana", 1.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmGenerator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.grpContactInfo.ResumeLayout(False)
        Me.grpJobSite.ResumeLayout(False)
        Me.grpBilling.ResumeLayout(False)
        Me.grpMailing.ResumeLayout(False)
        CType(Me.DsGenList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgSearchGenerator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSelectGenerator.ResumeLayout(False)
        Me.grBottom.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmGenerator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDGValues(True)
        Me.InitialLoad()
        Me.grBottom.Visible = False
        Me.LoadDGValues(Not addNewFlag)
        Me.Height = 610

        GenCount = DBHelper.GetInteger("SELECT Count(*) FROM tblGenerators WHERE Active = TRUE")
        Me.StatusBar1.Text = "Unique Gen + Cust Records =" & GenCount
    End Sub

    Function InitialLoad()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        'Me.populateSelection()
        Me.clearAll()
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function

    'Function populateSelection()

    '    Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
    '    Dim ds As DataSet
    '    Dim strSQL As String
    '    Try
    '        '-------------------------------------------------------------------
    '        'Haigriv Vyas
    '        'Date: 07/05/2005
    '        '-------------------------------------------------------------------
    '        'strSQL = "SELECT GeneratorID, (JobSite & ' : ' & JobSiteCity & ' : ' & GeneratorName & ' : ' & BrokerName) as SelectGenerator FROM tblGenerators WHERE (tblGenerators.Active = True) ORDER BY (JobSite & ' : ' & JobSiteCity & ' : ' & GeneratorName)"
    '        strSQL = "SELECT GeneratorID, (GeneratorName & ' : ' & JobSiteCity & ' : ' & JobSite) as SelectGenerator FROM tblGenerators WHERE (tblGenerators.Active = True) ORDER BY (GeneratorName & ' : ' & JobSiteCity & ' : ' & JobSite)"
    '        ds = DBHelper.GetDataSet(strSQL, "tblGenerators")
    '        Me.cmbGenerator.DataSource = ds
    '        Me.cmbGenerator.DisplayMember = "tblGenerators.SelectGenerator"
    '        Me.cmbGenerator.ValueMember = "tblGenerators.GeneratorID"
    '        Me.cmbGenerator.SelectedText = ""
    '        Me.cmbGenerator.Text = ""

    '    Catch ex As SystemException
    '        MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

    '    Finally
    '        ds = Nothing
    '        Cursor.Current = System.Windows.Forms.Cursors.Default

    '    End Try

    'End Function
    Function LoadGeneratorInfo(Optional ByVal ID As Integer = 0)
        If ID <> 0 Then genID = ID
        Dim strSQL As String = "SELECT * FROM tblGenerators WHERE GeneratorID = " & Me.genID
        Dim ds As DataSet
        Try
            ds = DBHelper.GetDataSet(strSQL, "tblGenerators")
            If ds.Tables(0).Rows.Count > 0 Then
                Dim dtRow As DataRow
                dtRow = ds.Tables(0).Rows(0)
                'Billing Address Info
                Me.BillingAddress1.Text = IIf(IsDBNull(dtRow.Item("BillingAddress1")), "", dtRow.Item("BillingAddress1"))
                Me.BillingAddress2.Text = IIf(IsDBNull(dtRow.Item("BillingAddress2")), "", dtRow.Item("BillingAddress2"))
                Me.BillingCity.Text = IIf(IsDBNull(dtRow.Item("BillingCity")), "", dtRow.Item("BillingCity"))
                Me.BillingState.Text = IIf(IsDBNull(dtRow.Item("BillingState")), "", dtRow.Item("BillingState"))
                Me.BillingZip.Text = IIf(IsDBNull(dtRow.Item("BillingZip")), "", dtRow.Item("BillingZip"))
                Me.BillingName.Text = IIf(IsDBNull(dtRow.Item("BillingName")), "", dtRow.Item("BillingName"))
                'Generator Specific Info
                Me.JobSiteAddress1.Text = IIf(IsDBNull(dtRow.Item("JobSiteAddress1")), "", dtRow.Item("JobSiteAddress1"))
                Me.JobSiteAddress2.Text = IIf(IsDBNull(dtRow.Item("JobSiteAddress2")), "", dtRow.Item("JobSiteAddress2"))
                Me.JobSiteCity.Text = IIf(IsDBNull(dtRow.Item("JobSiteCity")), "", dtRow.Item("JobSiteCity"))
                Me.JobSiteState.Text = IIf(IsDBNull(dtRow.Item("JobSiteState")), "", dtRow.Item("JobSiteState"))
                Me.JobSiteZip.Text = IIf(IsDBNull(dtRow.Item("JobSiteZip")), "", dtRow.Item("JobSiteZip"))
                Me.GeneratorName.Text = IIf(IsDBNull(dtRow.Item("GeneratorName")), "", dtRow.Item("GeneratorName"))
                Me.ContactName.Text = IIf(IsDBNull(dtRow.Item("ContactName")), "", dtRow.Item("ContactName"))
                Me.ContactPhone.Text = IIf(IsDBNull(dtRow.Item("ContactPhone")), "", dtRow.Item("ContactPhone"))
                'Broker Info
                Me.JobSite.Text = IIf(IsDBNull(dtRow.Item("JobSite")), "", dtRow.Item("JobSite"))
                Me.BrokerContact.Text = IIf(IsDBNull(dtRow.Item("BrokerContact")), "", dtRow.Item("BrokerContact"))
                Me.BrokerPhone.Text = IIf(IsDBNull(dtRow.Item("BrokerPhone")), "", dtRow.Item("BrokerPhone"))
                'Generator Specific Info
                Me.GNo.Text = IIf(IsDBNull(dtRow.Item("GNo")), "", dtRow.Item("GNo"))
                Me.lblGeneratorLabel.Text = IIf(IsDBNull(dtRow.Item("GeneratorName")), "", dtRow.Item("GeneratorName")) + " : " + IIf(IsDBNull(dtRow.Item("JobSite")), "", dtRow.Item("JobSite"))
                Me.chkActive.Checked = IIf(IsDBNull(dtRow.Item("Active")), True, dtRow.Item("Active"))
                Me.Verified.Checked = IIf(IsDBNull(dtRow.Item("Verified")), True, dtRow.Item("Verified"))
                'Mailing Address Info
                Me.MailingAddress1.Text = IIf(IsDBNull(dtRow.Item("MailingAddress1")), "", dtRow.Item("MailingAddress1"))
                Me.MailingAddress2.Text = IIf(IsDBNull(dtRow.Item("MailingAddress2")), "", dtRow.Item("MailingAddress2"))
                Me.MailingCity.Text = IIf(IsDBNull(dtRow.Item("MailingCity")), "", dtRow.Item("MailingCity"))
                Me.MailingName.Text = IIf(IsDBNull(dtRow.Item("MailingName")), "", dtRow.Item("MailingName"))
                Me.MailingZip.Text = IIf(IsDBNull(dtRow.Item("MailingZip")), "", dtRow.Item("MailingZip"))
                Me.MailingState.Text = IIf(IsDBNull(dtRow.Item("MailingState")), "", dtRow.Item("MailingState"))
                ' Me.G_ILNumber.Text = IIf(IsDBNull(dtRow.Item("G_ILNumber")), "", dtRow.Item("G_ILNumber"))
                Me.G_USEPAID.Text = IIf(IsDBNull(dtRow.Item("G_USEPAID")), "", dtRow.Item("G_USEPAID"))
                dtRow = Nothing
            Else
                MsgBox("Generator selected was not found. Please make another selection.", MsgBoxStyle.Information, "Generator")
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Function

    Private Sub btnAddG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Me.lblGeneratorLabel.Text = "Generator:"
        Me.clearAll()
        Me.genID = 0
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Function clearAll()

        Me.GNo.Text = ""
        Me.BillingAddress1.Text = ""
        Me.BillingAddress2.Text = ""
        Me.BillingCity.Text = ""
        Me.BillingState.Text = ""
        Me.BillingZip.Text = ""
        Me.BillingName.Text = ""
        Me.JobSiteAddress1.Text = ""
        Me.JobSiteAddress2.Text = ""
        Me.JobSiteCity.Text = ""
        Me.JobSiteState.Text = ""
        Me.JobSiteZip.Text = ""
        Me.GeneratorName.Text = ""
        Me.ContactName.Text = ""
        Me.ContactPhone.Text = ""
        Me.JobSite.Text = ""
        Me.BrokerContact.Text = ""
        Me.BrokerPhone.Text = ""
        Me.lblGeneratorLabel.Text = ""
        ' Me.G_ILNumber.Text = ""
        Me.G_USEPAID.Text = ""
        Me.MailingAddress1.Text = ""
        Me.MailingAddress2.Text = ""
        Me.MailingCity.Text = ""
        Me.MailingName.Text = ""
        Me.MailingState.Text = ""
        Me.MailingZip.Text = ""
        Me.chkActive.Checked = False
        Me.Verified.Checked = False

    End Function

    Private Sub btnSaveG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveG.Click

        If GeneratorName.Text = "" Then
            MsgBox("Missing Generator Name. Please enter a Generator/Jobsite Name.", MsgBoxStyle.Information, "Save JobSite")
            Me.GeneratorName.Focus()
            Exit Sub
        End If
        If Me.JobSite.Text = "" Then
            MsgBox("Missing Customer Name. Please enter a Customer Name.", MsgBoxStyle.Information, "Save JobSite")
            Me.JobSite.Focus()
            Exit Sub
        End If
        If Me.JobSiteAddress1.Text = "" Then
            MsgBox("Missing JobSite Address1. Please enter a JobSite Address1.", MsgBoxStyle.Information, "Save JobSite")
            Me.JobSiteAddress1.Focus()
            Exit Sub
        End If
        If Me.JobSiteCity.Text = "" Then
            MsgBox("Missing JobSite City. Please enter a JobSite City.", MsgBoxStyle.Information, "Save JobSite")
            Me.JobSiteCity.Focus()
            Exit Sub
        End If
        If Me.JobSiteState.Text = "" Then
            MsgBox("Missing JobSite State. Please enter a JobSite State.", MsgBoxStyle.Information, "Save JobSite")
            Me.JobSiteState.Focus()
            Exit Sub
        End If
        If Me.JobSiteZip.Text = "" Then
            MsgBox("Missing JobSite Zip. Please enter a JobSite Zip.", MsgBoxStyle.Information, "Save JobSite")
            Me.JobSiteZip.Focus()
            Exit Sub
        End If
        'If Me.GNo.Text = "" Then
        '    MsgBox("Missing Generator #. Please enter a Generator #.", MsgBoxStyle.Information, "Save JobSite")
        '    Me.GNo.Focus()
        '    Exit Sub
        'End If

        Dim strSQL As String
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            Dim alreadyExists As Boolean = False
            Dim BillingName As String, BillingAddress1 As String, BillingAddress2 As String
            Dim BillingCity As String, BillingState As String, BillingZip As String
            Dim JobSite As String, JobSiteAddress1 As String, JobSiteAddress2 As String
            Dim JobSiteCity As String, JobSiteState As String, JobSiteZip As String
            Dim BrokerName As String, BrokerContact As String, BrokerPhone As String
            Dim GeneratorName As String, ContactName As String, ContactPhone As String, GNo As String
            Dim Active As Boolean = False, G_ILNumber As String, G_USEPAID As String, IsVerified As Boolean
            Dim MailingName As String, MailingAddress1 As String, MailingAddress2 As String
            Dim MailingCity As String, MailingState As String, MailingZip As String
            MailingAddress1 = Replace(Me.MailingAddress1.Text, "'", "''")
            MailingAddress2 = Replace(Me.MailingAddress2.Text, "'", "''")
            MailingCity = Replace(Me.MailingCity.Text, "'", "''")
            MailingState = Replace(Me.MailingState.Text, "'", "''")
            MailingZip = Replace(Me.MailingZip.Text, "'", "''")
            MailingName = Replace(Me.MailingName.Text, "'", "''")
            'Grab values entered
            BillingAddress1 = Replace(Me.BillingAddress1.Text, "'", "''")
            BillingAddress2 = Replace(Me.BillingAddress2.Text, "'", "''")
            BillingCity = Replace(Me.BillingCity.Text, "'", "''")
            BillingState = Replace(Me.BillingState.Text, "'", "''")
            BillingZip = Replace(Me.BillingZip.Text, "'", "''")
            BillingName = Replace(Me.BillingName.Text, "'", "''")
            GeneratorName = Replace(Me.GeneratorName.Text, "'", "''")
            JobSite = Replace(Me.JobSite.Text, "'", "''")
            JobSiteAddress1 = Replace(Me.JobSiteAddress1.Text, "'", "''")
            JobSiteAddress2 = Replace(Me.JobSiteAddress2.Text, "'", "''")
            JobSiteCity = Replace(Me.JobSiteCity.Text, "'", "''")
            JobSiteState = Replace(Me.JobSiteState.Text, "'", "''")
            JobSiteZip = Replace(Me.JobSiteZip.Text, "'", "''")
            ' GeneratorName = Replace(Me.GeneratorName.Text, "'", "''")
            ContactName = Replace(Me.ContactName.Text, "'", "''")
            ContactPhone = Replace(Me.ContactPhone.Text, "'", "''")
            BrokerName = Replace(Me.JobSite.Text, "'", "''")
            BrokerContact = Replace(Me.BrokerContact.Text, "'", "''")
            BrokerPhone = Replace(Me.BrokerPhone.Text, "'", "''")
            Active = Me.chkActive.Checked
            IsVerified = Me.Verified.Checked
            G_ILNumber = Replace(Me.GNo.Text, "'", "''")
            G_USEPAID = Replace(Me.G_USEPAID.Text, "'", "''")
            GNo = Replace(Me.GNo.Text, "'", "''")

            If DBHelper.GetRecordCount("SELECT Count(*) FROM tblGenerators WHERE GeneratorName = '" & Replace(GeneratorName, "'", "''") & "'" _
                                    & " AND JobSite = '" & Replace(JobSite, "'", "''").Trim & "' AND JobSiteAddress1 = '" & Replace(JobSiteAddress1, "'", "''") & "' AND JobSiteCity = '" & Replace(JobSiteCity, "'", "''") & "'") > 0 Then
                alreadyExists = True
            End If
            If alreadyExists = True And Me.genID = 0 Then
                If MsgBox("Generator with same GeneratorName-JobSite-JobSiteAddress-JobSiteCity is already exist." _
                            & vbCrLf & "Do you still want to add this Generator?", MsgBoxStyle.YesNoCancel, "Generator") <> MsgBoxResult.Yes Then
                    Exit Sub
                End If
            End If
            If genID > 0 Then
                strSQL = "UPDATE tblGenerators SET GeneratorName='" & GeneratorName & "', JobSite='" & JobSite & "', JobSiteAddress1='" & JobSiteAddress1 & "',JobSiteAddress2='" & JobSiteAddress2 & "'," _
                        & "JobSiteCity='" & JobSiteCity & "',JobSiteState='" & JobSiteState & "',JobSiteZip='" & JobSiteZip & "',ContactName='" & ContactName & "',ContactPhone='" & ContactPhone & "'," _
                        & "BrokerName='" & BrokerName & "',BrokerContact='" & BrokerContact & "',BrokerPhone='" & BrokerPhone & "',BillingName='" & BillingName & "',BillingAddress1='" & BillingAddress1 & "',BillingAddress2 = '" & BillingAddress2 & "'," _
                        & "BillingCity='" & BillingCity & "',BillingState='" & BillingState & "',BillingZip='" & BillingZip & "', GNo='" & GNo & "', Active = " & Active & ", G_ILNumber = '" & G_ILNumber & "', G_USEPAID = '" _
                        & G_USEPAID & "', MailingName = '" & MailingName & "', MailingAddress1 = '" & MailingAddress1 & "', MailingAddress2 = '" & MailingAddress2 & "', MailingCity = '" & MailingCity & "', MailingState = '" _
                        & MailingState & "', MailingZip = '" & MailingZip & "', Verified = " & IsVerified & " " _
                        & "WHERE GeneratorID = " & Me.genID
                If Me.addNewFlag = True Then Me.addNewFlag = False
            Else
                strSQL = "INSERT INTO tblGenerators(BillingName, BillingAddress1, BillingAddress2, BillingCity, BillingState, BillingZip, JobSite, JobSiteAddress1, JobSiteAddress2, JobSiteCity, JobSiteState, JobSiteZip, " _
                        & "BrokerName, BrokerContact, BrokerPhone, GeneratorName, ContactName, ContactPhone, GNo, Active, G_ILNumber, G_USEPAID, MailingName, MailingAddress1, MailingAddress2, MailingCity, MailingState, MailingZip, Verified) " _
                        & " SELECT '" & BillingName & "', '" & BillingAddress1 & "', '" & BillingAddress2 & "', '" & BillingCity & "', '" & BillingState & "', '" & BillingZip & "', '" & JobSite & "', '" & JobSiteAddress1 & "', '" & JobSiteAddress2 & "', '" & JobSiteCity & "', '" & JobSiteState & "', '" & JobSiteZip & "', " _
                        & "'" & BrokerName & "', '" & BrokerContact & "', '" & BrokerPhone & "', '" & GeneratorName & "', '" & ContactName & "', '" & ContactPhone & "', '" & GNo & "', " & Active & ", '" & G_ILNumber & "', '" & G_USEPAID & "', '" & MailingName & "', '" & MailingAddress1 & "', '" & MailingAddress2 & "', '" & MailingCity & "', '" & MailingState & "', '" & MailingZip & "', " & IsVerified & ""
                Me.addNewFlag = False
            End If
            If DBHelper.ExecuteQuery(strSQL) = False Then
                MsgBox("An error ocurred while performing this operation.", MsgBoxStyle.Information, "Error")
            End If
            GenCount = DBHelper.GetInteger("SELECT Count(*) FROM tblGenerators WHERE Active = TRUE")
            Me.StatusBar1.Text = "Unique Gen + Cust Records =" & GenCount
            Me.LoadDGValues(Not Me.addNewFlag)
            Me.ViewNewJobList.Visible = False
            Me.grpSelectGenerator.Visible = True
            Me.grBottom.Visible = False
            Me.grpSelectGenerator.Top = 0
            Me.grBottom.Top = 228
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
        Finally
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub btnCancelG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelG.Click

        Me.Close()

    End Sub

    'Private Sub cmbGenerator_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    '    Dim index As Integer, actual As String, found As String
    '    ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
    '    If ((e.KeyCode = Keys.Back) Or (e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
    '        Return
    '    End If
    '    ' Store the actual text that has been typed
    '    actual = Me.cmbGenerator.Text
    '    ' Find the first match for the typed value
    '    index = Me.cmbGenerator.FindString(actual)
    '    ' Get the text of the first match
    '    If (index > -1) Then
    '        ' Select this item from the list
    '        Me.cmbGenerator.SelectedIndex = index
    '        found = Me.cmbGenerator.Text
    '        ' Select the portion of the text that was automatically added so further typing will replace it
    '        Me.cmbGenerator.SelectionStart = actual.Length
    '        Me.cmbGenerator.SelectionLength = found.Length - actual.Length
    '    End If

    'End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        Dim ds As DataSet
        Dim strsql As String = "SELECT * FROM tblGenerators ORDER BY GeneratorName"

        Try
            ds = DBHelper.GetDataSet(strsql, "tblGenerators")
            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("No matching data found. Cancelling Report..", MsgBoxStyle.Information, "Generators List")
            Else
                Dim frmR As New frmReport
                Dim objR As New rpt_GeneratorsList
                frmR.WindowState = FormWindowState.Maximized
                objR.SetDataSource(ds)
                DBHelper.Authenticate(objR)
                frmR.CrystalReportViewer1.ReportSource = objR
                frmR.CrystalReportViewer1.RefreshReport()
                frmR.Show()
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
        Finally
            ds = Nothing
        End Try

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If MsgBox("Are you sure you want to In-Activate this Generator?", MsgBoxStyle.YesNo, "In-Activate Generator") = MsgBoxResult.Yes Then
                If DBHelper.ExecuteQuery("UPDATE tblGenerators SET Active = False WHERE GeneratorID = " & Me.genID & "") = True Then
                    Me.InitialLoad()
                Else
                    MsgBox("Could not In-Activate. There was an error.", MsgBoxStyle.Information, "Error Ocurred")
                End If
            End If
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
        End Try
    End Sub
    Function LoadDGValues(ByVal bStatus As Boolean)
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet, whereClause As String = ""
        Try
            Dim strSQL As String
            '-------------------------------------------------------------------
            'Haigriv Vyas
            'Date: 07/05/2005
            '-------------------------------------------------------------------
            'strSQL = "SELECT tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblProducts.ProductName, tblProducts.ProductID, tblGenerators.GeneratorID,tblGenerators.GeneratorName,tblProducts.ApprovalNo,tblProducts.Active as Status FROM (tblGenerators LEFT OUTER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) "
            strSQL = "SELECT GeneratorName,JobSiteAddress1, JobSite, JobSiteCity, Active, GeneratorID FROM tblGenerators"

            If Me.Fill_JobSite.Text <> "" Then
                'whereClause = " WHERE (tblGenerators.JobSite Like '" & Replace(Me.Fill_JobSite.Text, "'", "''") & "%') "
                whereClause = " WHERE (tblGenerators.GeneratorName Like '" & Replace(Me.Fill_JobSite.Text, "'", "''") & "%') "
            End If

            If Me.Fil_City.Text <> "" Then
                If whereClause <> "" Then
                    whereClause = whereClause & " AND (tblGenerators.JobSiteCity Like '" & Replace(Me.Fil_City.Text, "'", "''") & "%') "
                Else
                    whereClause = " WHERE (tblGenerators.JobSiteCity Like '" & Replace(Me.Fil_City.Text, "'", "''") & "%') "
                End If
            End If
            If Me.Fill_Customer.Text <> "" Then
                If whereClause <> "" Then
                    'whereClause = whereClause & " AND (tblGenerators.GeneratorName Like '" & Replace(Me.Fill_Customer.Text, "'", "''") & "%') "
                    whereClause = whereClause & " AND (tblGenerators.JobSite Like '" & Replace(Me.Fill_Customer.Text, "'", "''") & "%') "
                Else
                    'whereClause = " WHERE (tblGenerators.GeneratorName Like '" & Replace(Me.Fill_Customer.Text, "'", "''") & "%') "
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

            If Len(whereClause) <> 0 Then strSQL = strSQL & whereClause & " and (tblGenerators.Active = " & bStatus & " )" Else strSQL = strSQL & " WHERE (tblGenerators.Active = " & bStatus & ")"
            strSQL = strSQL & " ORDER BY GeneratorName, JobSite, JobSiteCity, Active "
            ds = DBHelper.GetDataSet(strSQL, "tblGenerators")
            Me.dgSearchGenerator.DataSource = ds
            Me.dgSearchGenerator.DataMember = "tblGenerators"
            Me.dgSearchGenerator.Refresh()
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
        Finally
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Function
    Private Sub Fill_JobSite_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Fill_JobSite.KeyUp

        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Enter)) Then
            System.Windows.Forms.SendKeys.SendWait("{TAB}")
            'Me.Fil_Address.Focus()
        ElseIf ((e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        Me.LoadDGValues(Not addNewFlag)

    End Sub
    Private Sub Fill_Customer_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Fill_Customer.KeyUp

        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Enter)) Then
            System.Windows.Forms.SendKeys.SendWait("{TAB}")
            'Me.btnSelect.Focus()
        ElseIf ((e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        Me.LoadDGValues(Not addNewFlag)
    End Sub
    Private Sub Fil_City_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Fil_City.KeyUp

        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Enter)) Then
            System.Windows.Forms.SendKeys.SendWait("{TAB}")
            'Me.Fil_Product.Focus()
        ElseIf ((e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        Me.LoadDGValues(Not addNewFlag)
    End Sub
    Private Sub Fil_Address_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Fil_Address.KeyUp
        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Enter)) Then
            System.Windows.Forms.SendKeys.SendWait("{TAB}")
            Me.Fil_City.Focus()
        ElseIf ((e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        Me.LoadDGValues(Not addNewFlag)
    End Sub
    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        If Me.dgSearchGenerator.CurrentRowIndex < 0 Then
            MsgBox("Gen+Cust combination is not selected. Please select a record.", MsgBoxStyle.Information, "Invalid selection")
            Me.dgSearchGenerator.Focus()
            Exit Sub
        End If
        Me.clearAll()
        If IsDBNull(Me.dgSearchGenerator.Item(Me.dgSearchGenerator.CurrentRowIndex, 0)) = False AndAlso (Me.dgSearchGenerator.Item(Me.dgSearchGenerator.CurrentRowIndex, 0)) > 0 Then
            Me.genID = Me.dgSearchGenerator.Item(Me.dgSearchGenerator.CurrentRowIndex, 0)
        Else
            Me.genID = 0
        End If
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        LoadGeneratorInfo()
        Me.grpSelectGenerator.Visible = False
        Me.grBottom.Visible = True
        Me.grBottom.Top = 0
        Me.Height = 480
        Me.ViewNewJobList.Visible = True
        Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnAddNewProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewProduct.Click
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Me.clearAll()
        Me.genID = 0
        Cursor.Current = System.Windows.Forms.Cursors.Default
        Me.lblGeneratorLabel.Text = ""
        Me.addNewFlag = True
        Me.LoadDGValues(Not addNewFlag)
        Me.grpSelectGenerator.Visible = True
        Me.grBottom.Visible = True
        Me.Height = 690
        Me.Width = 850
        Me.chkActive.Checked = True
        Me.ViewNewJobList.Visible = False
        Me.grpSelectGenerator.Top = 0
        Me.grBottom.Top = 228
    End Sub
    Private Sub ViewNewJobList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewNewJobList.Click
        Me.ViewNewJobList.Visible = False
        Me.grpSelectGenerator.Visible = True
        Me.grBottom.Visible = False
        Me.grpSelectGenerator.Top = 0
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.addNewFlag = False
        Me.Fill_Customer.Text = ""
        Me.Fill_JobSite.Text = ""
        Me.Fil_City.Text = ""
        Me.LoadDGValues(Not addNewFlag)
        Me.grpSelectGenerator.Visible = True
        Me.grBottom.Visible = False
    End Sub
End Class
