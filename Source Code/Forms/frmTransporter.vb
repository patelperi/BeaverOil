Public Class frmTransporter
    Inherits System.Windows.Forms.Form
    Dim transID As Integer = 0

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
    Friend WithEvents grpT As System.Windows.Forms.GroupBox
    Friend WithEvents btnViewT As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbTransporter As System.Windows.Forms.ComboBox
    Friend WithEvents grpGenerator As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents btnAddT As System.Windows.Forms.Button
    Friend WithEvents btnCancelT As System.Windows.Forms.Button
    Friend WithEvents btnSaveT As System.Windows.Forms.Button
    Friend WithEvents grpAddress As System.Windows.Forms.GroupBox
    Friend WithEvents TContactPhone As System.Windows.Forms.TextBox
    Friend WithEvents TContactName As System.Windows.Forms.TextBox
    Friend WithEvents TransporterName As System.Windows.Forms.TextBox
    Friend WithEvents lblTransporterLabel As System.Windows.Forms.Label
    Friend WithEvents TZip As System.Windows.Forms.TextBox
    Friend WithEvents TState As System.Windows.Forms.TextBox
    Friend WithEvents TCity As System.Windows.Forms.TextBox
    Friend WithEvents TAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents TAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents btnPrint As System.Windows.Forms.PictureBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents T_ILNumber As System.Windows.Forms.TextBox
    Friend WithEvents T_USEPAID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CertOfIns As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TPhone As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTransporter))
        Me.grpT = New System.Windows.Forms.GroupBox
        Me.btnViewT = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbTransporter = New System.Windows.Forms.ComboBox
        Me.grpGenerator = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.CertOfIns = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.T_ILNumber = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.T_USEPAID = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.chkActive = New System.Windows.Forms.CheckBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.TContactPhone = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.TContactName = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.TransporterName = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblTransporterLabel = New System.Windows.Forms.Label
        Me.grpAddress = New System.Windows.Forms.GroupBox
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.TZip = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.TState = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.TCity = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.TAddress2 = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.TAddress1 = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.btnAddT = New System.Windows.Forms.Button
        Me.btnCancelT = New System.Windows.Forms.Button
        Me.btnSaveT = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.PictureBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.TPhone = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.grpT.SuspendLayout()
        Me.grpGenerator.SuspendLayout()
        Me.grpAddress.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpT
        '
        Me.grpT.Controls.Add(Me.btnViewT)
        Me.grpT.Controls.Add(Me.Label1)
        Me.grpT.Controls.Add(Me.cmbTransporter)
        Me.grpT.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpT.Location = New System.Drawing.Point(8, 8)
        Me.grpT.Name = "grpT"
        Me.grpT.Size = New System.Drawing.Size(616, 56)
        Me.grpT.TabIndex = 1
        Me.grpT.TabStop = False
        Me.grpT.Text = "Select a Transporter"
        '
        'btnViewT
        '
        Me.btnViewT.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnViewT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewT.Location = New System.Drawing.Point(520, 24)
        Me.btnViewT.Name = "btnViewT"
        Me.btnViewT.Size = New System.Drawing.Size(88, 24)
        Me.btnViewT.TabIndex = 2
        Me.btnViewT.Text = "View/Edit"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Transporter - City:"
        '
        'cmbTransporter
        '
        Me.cmbTransporter.Location = New System.Drawing.Point(152, 24)
        Me.cmbTransporter.Name = "cmbTransporter"
        Me.cmbTransporter.Size = New System.Drawing.Size(360, 21)
        Me.cmbTransporter.TabIndex = 1
        '
        'grpGenerator
        '
        Me.grpGenerator.Controls.Add(Me.Label9)
        Me.grpGenerator.Controls.Add(Me.Label10)
        Me.grpGenerator.Controls.Add(Me.CertOfIns)
        Me.grpGenerator.Controls.Add(Me.Label3)
        Me.grpGenerator.Controls.Add(Me.Label8)
        Me.grpGenerator.Controls.Add(Me.Label7)
        Me.grpGenerator.Controls.Add(Me.Label5)
        Me.grpGenerator.Controls.Add(Me.T_ILNumber)
        Me.grpGenerator.Controls.Add(Me.Label6)
        Me.grpGenerator.Controls.Add(Me.T_USEPAID)
        Me.grpGenerator.Controls.Add(Me.Label4)
        Me.grpGenerator.Controls.Add(Me.Label45)
        Me.grpGenerator.Controls.Add(Me.chkActive)
        Me.grpGenerator.Controls.Add(Me.Label20)
        Me.grpGenerator.Controls.Add(Me.TContactPhone)
        Me.grpGenerator.Controls.Add(Me.Label21)
        Me.grpGenerator.Controls.Add(Me.Label17)
        Me.grpGenerator.Controls.Add(Me.TContactName)
        Me.grpGenerator.Controls.Add(Me.Label18)
        Me.grpGenerator.Controls.Add(Me.Label15)
        Me.grpGenerator.Controls.Add(Me.TransporterName)
        Me.grpGenerator.Controls.Add(Me.Label16)
        Me.grpGenerator.Controls.Add(Me.Label37)
        Me.grpGenerator.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpGenerator.Location = New System.Drawing.Point(8, 120)
        Me.grpGenerator.Name = "grpGenerator"
        Me.grpGenerator.Size = New System.Drawing.Size(304, 224)
        Me.grpGenerator.TabIndex = 2
        Me.grpGenerator.TabStop = False
        Me.grpGenerator.Text = "Transporter"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 200)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 16)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Certificate Of Insurance:"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(152, 216)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 1)
        Me.Label10.TabIndex = 55
        '
        'CertOfIns
        '
        Me.CertOfIns.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CertOfIns.Location = New System.Drawing.Point(160, 200)
        Me.CertOfIns.MaxLength = 10
        Me.CertOfIns.Name = "CertOfIns"
        Me.CertOfIns.Size = New System.Drawing.Size(128, 14)
        Me.CertOfIns.TabIndex = 54
        Me.CertOfIns.Text = ""
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(112, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 1)
        Me.Label3.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(2, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(8, 8)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "*"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(2, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(8, 8)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "*"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(96, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 1)
        Me.Label5.TabIndex = 45
        '
        'T_ILNumber
        '
        Me.T_ILNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.T_ILNumber.Location = New System.Drawing.Point(104, 56)
        Me.T_ILNumber.MaxLength = 75
        Me.T_ILNumber.Name = "T_ILNumber"
        Me.T_ILNumber.Size = New System.Drawing.Size(184, 14)
        Me.T_ILNumber.TabIndex = 2
        Me.T_ILNumber.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 16)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Hauler No.:"
        '
        'T_USEPAID
        '
        Me.T_USEPAID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.T_USEPAID.Location = New System.Drawing.Point(119, 88)
        Me.T_USEPAID.MaxLength = 75
        Me.T_USEPAID.Name = "T_USEPAID"
        Me.T_USEPAID.Size = New System.Drawing.Size(169, 14)
        Me.T_USEPAID.TabIndex = 3
        Me.T_USEPAID.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "US EPA ID No.:"
        '
        'Label45
        '
        Me.Label45.Location = New System.Drawing.Point(8, 176)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(48, 16)
        Me.Label45.TabIndex = 34
        Me.Label45.Text = "Active:"
        '
        'chkActive
        '
        Me.chkActive.Checked = True
        Me.chkActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkActive.Location = New System.Drawing.Point(56, 176)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(16, 16)
        Me.chkActive.TabIndex = 6
        '
        'Label20
        '
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Location = New System.Drawing.Point(104, 168)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(184, 1)
        Me.Label20.TabIndex = 15
        '
        'TContactPhone
        '
        Me.TContactPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TContactPhone.Location = New System.Drawing.Point(112, 152)
        Me.TContactPhone.MaxLength = 20
        Me.TContactPhone.Name = "TContactPhone"
        Me.TContactPhone.Size = New System.Drawing.Size(176, 14)
        Me.TContactPhone.TabIndex = 5
        Me.TContactPhone.Text = ""
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(8, 152)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 16)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "Contact Phone:"
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Location = New System.Drawing.Point(64, 136)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(224, 1)
        Me.Label17.TabIndex = 12
        '
        'TContactName
        '
        Me.TContactName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TContactName.Location = New System.Drawing.Point(72, 120)
        Me.TContactName.MaxLength = 75
        Me.TContactName.Name = "TContactName"
        Me.TContactName.Size = New System.Drawing.Size(216, 14)
        Me.TContactName.TabIndex = 4
        Me.TContactName.Text = ""
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(8, 120)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 16)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Contact:"
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Location = New System.Drawing.Point(64, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(224, 1)
        Me.Label15.TabIndex = 9
        '
        'TransporterName
        '
        Me.TransporterName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TransporterName.Location = New System.Drawing.Point(72, 24)
        Me.TransporterName.MaxLength = 75
        Me.TransporterName.Name = "TransporterName"
        Me.TransporterName.Size = New System.Drawing.Size(216, 14)
        Me.TransporterName.TabIndex = 1
        Me.TransporterName.Text = ""
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(8, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 16)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Name:"
        '
        'Label37
        '
        Me.Label37.ForeColor = System.Drawing.Color.Red
        Me.Label37.Location = New System.Drawing.Point(2, 24)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(8, 8)
        Me.Label37.TabIndex = 26
        Me.Label37.Text = "*"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(104, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(488, 16)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Note: * indicates required fields."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTransporterLabel
        '
        Me.lblTransporterLabel.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransporterLabel.Location = New System.Drawing.Point(96, 72)
        Me.lblTransporterLabel.Name = "lblTransporterLabel"
        Me.lblTransporterLabel.Size = New System.Drawing.Size(488, 16)
        Me.lblTransporterLabel.TabIndex = 27
        Me.lblTransporterLabel.Text = "Transporter:"
        Me.lblTransporterLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grpAddress
        '
        Me.grpAddress.Controls.Add(Me.Label13)
        Me.grpAddress.Controls.Add(Me.Label12)
        Me.grpAddress.Controls.Add(Me.TPhone)
        Me.grpAddress.Controls.Add(Me.Label11)
        Me.grpAddress.Controls.Add(Me.Label42)
        Me.grpAddress.Controls.Add(Me.Label41)
        Me.grpAddress.Controls.Add(Me.Label40)
        Me.grpAddress.Controls.Add(Me.Label39)
        Me.grpAddress.Controls.Add(Me.Label26)
        Me.grpAddress.Controls.Add(Me.TZip)
        Me.grpAddress.Controls.Add(Me.Label27)
        Me.grpAddress.Controls.Add(Me.Label28)
        Me.grpAddress.Controls.Add(Me.TState)
        Me.grpAddress.Controls.Add(Me.Label29)
        Me.grpAddress.Controls.Add(Me.Label30)
        Me.grpAddress.Controls.Add(Me.TCity)
        Me.grpAddress.Controls.Add(Me.Label31)
        Me.grpAddress.Controls.Add(Me.TAddress2)
        Me.grpAddress.Controls.Add(Me.Label32)
        Me.grpAddress.Controls.Add(Me.TAddress1)
        Me.grpAddress.Controls.Add(Me.Label34)
        Me.grpAddress.Controls.Add(Me.Label35)
        Me.grpAddress.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpAddress.Location = New System.Drawing.Point(320, 120)
        Me.grpAddress.Name = "grpAddress"
        Me.grpAddress.Size = New System.Drawing.Size(304, 224)
        Me.grpAddress.TabIndex = 3
        Me.grpAddress.TabStop = False
        Me.grpAddress.Text = "Address Info"
        '
        'Label42
        '
        Me.Label42.ForeColor = System.Drawing.Color.Red
        Me.Label42.Location = New System.Drawing.Point(112, 120)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(8, 8)
        Me.Label42.TabIndex = 4
        Me.Label42.Text = "*"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.Label40.Location = New System.Drawing.Point(2, 88)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(8, 8)
        Me.Label40.TabIndex = 38
        Me.Label40.Text = "*"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label39
        '
        Me.Label39.ForeColor = System.Drawing.Color.Red
        Me.Label39.Location = New System.Drawing.Point(2, 24)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(8, 8)
        Me.Label39.TabIndex = 37
        Me.Label39.Text = "*"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label26
        '
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label26.Location = New System.Drawing.Point(180, 136)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(116, 1)
        Me.Label26.TabIndex = 35
        '
        'TZip
        '
        Me.TZip.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TZip.Location = New System.Drawing.Point(188, 120)
        Me.TZip.MaxLength = 10
        Me.TZip.Name = "TZip"
        Me.TZip.Size = New System.Drawing.Size(104, 14)
        Me.TZip.TabIndex = 5
        Me.TZip.Text = ""
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(120, 120)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 16)
        Me.Label27.TabIndex = 33
        Me.Label27.Text = "Zip Code:"
        '
        'Label28
        '
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label28.Location = New System.Drawing.Point(64, 136)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(40, 1)
        Me.Label28.TabIndex = 32
        '
        'TState
        '
        Me.TState.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TState.Location = New System.Drawing.Point(68, 120)
        Me.TState.MaxLength = 2
        Me.TState.Name = "TState"
        Me.TState.Size = New System.Drawing.Size(32, 14)
        Me.TState.TabIndex = 4
        Me.TState.Text = ""
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(8, 120)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(48, 16)
        Me.Label29.TabIndex = 30
        Me.Label29.Text = "State:"
        '
        'Label30
        '
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label30.Location = New System.Drawing.Point(64, 104)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(232, 1)
        Me.Label30.TabIndex = 29
        '
        'TCity
        '
        Me.TCity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TCity.Location = New System.Drawing.Point(68, 88)
        Me.TCity.MaxLength = 50
        Me.TCity.Name = "TCity"
        Me.TCity.Size = New System.Drawing.Size(224, 14)
        Me.TCity.TabIndex = 3
        Me.TCity.Text = ""
        '
        'Label31
        '
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label31.Location = New System.Drawing.Point(64, 72)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(232, 1)
        Me.Label31.TabIndex = 27
        '
        'TAddress2
        '
        Me.TAddress2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TAddress2.Location = New System.Drawing.Point(68, 56)
        Me.TAddress2.MaxLength = 75
        Me.TAddress2.Name = "TAddress2"
        Me.TAddress2.Size = New System.Drawing.Size(224, 14)
        Me.TAddress2.TabIndex = 2
        Me.TAddress2.Text = ""
        '
        'Label32
        '
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label32.Location = New System.Drawing.Point(64, 40)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(232, 1)
        Me.Label32.TabIndex = 25
        '
        'TAddress1
        '
        Me.TAddress1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TAddress1.Location = New System.Drawing.Point(68, 24)
        Me.TAddress1.MaxLength = 75
        Me.TAddress1.Name = "TAddress1"
        Me.TAddress1.Size = New System.Drawing.Size(224, 14)
        Me.TAddress1.TabIndex = 1
        Me.TAddress1.Text = ""
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(8, 88)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(48, 16)
        Me.Label34.TabIndex = 21
        Me.Label34.Text = "City:"
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(8, 24)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(56, 16)
        Me.Label35.TabIndex = 20
        Me.Label35.Text = "Address:"
        '
        'btnAddT
        '
        Me.btnAddT.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAddT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddT.Location = New System.Drawing.Point(112, 352)
        Me.btnAddT.Name = "btnAddT"
        Me.btnAddT.Size = New System.Drawing.Size(112, 24)
        Me.btnAddT.TabIndex = 4
        Me.btnAddT.Text = "&Add New"
        '
        'btnCancelT
        '
        Me.btnCancelT.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCancelT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelT.Location = New System.Drawing.Point(368, 352)
        Me.btnCancelT.Name = "btnCancelT"
        Me.btnCancelT.Size = New System.Drawing.Size(112, 24)
        Me.btnCancelT.TabIndex = 6
        Me.btnCancelT.Text = "&Cancel"
        '
        'btnSaveT
        '
        Me.btnSaveT.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSaveT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveT.Location = New System.Drawing.Point(240, 352)
        Me.btnSaveT.Name = "btnSaveT"
        Me.btnSaveT.Size = New System.Drawing.Size(112, 24)
        Me.btnSaveT.TabIndex = 5
        Me.btnSaveT.Text = "&Save"
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(552, 344)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(72, 40)
        Me.btnPrint.TabIndex = 36
        Me.btnPrint.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.SlateGray
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(488, 352)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(48, 24)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "&In-Activate"
        Me.btnDelete.Visible = False
        '
        'TPhone
        '
        Me.TPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TPhone.Location = New System.Drawing.Point(120, 152)
        Me.TPhone.MaxLength = 20
        Me.TPhone.Name = "TPhone"
        Me.TPhone.Size = New System.Drawing.Size(176, 14)
        Me.TPhone.TabIndex = 6
        Me.TPhone.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 152)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 16)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Phone # :"
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Location = New System.Drawing.Point(112, 168)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(184, 1)
        Me.Label12.TabIndex = 42
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(3, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(8, 8)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "*"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmTransporter
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(632, 389)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnAddT)
        Me.Controls.Add(Me.btnCancelT)
        Me.Controls.Add(Me.btnSaveT)
        Me.Controls.Add(Me.grpAddress)
        Me.Controls.Add(Me.grpGenerator)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTransporterLabel)
        Me.Controls.Add(Me.grpT)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmTransporter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transporter"
        Me.grpT.ResumeLayout(False)
        Me.grpGenerator.ResumeLayout(False)
        Me.grpAddress.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Function populateSelection()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet
        Dim strSQL As String

        Try

            strSQL = "SELECT TransporterID, (TransporterName & ' - ' & TCity) as SelectTransporter FROM tblTransporters ORDER BY (TransporterName & ' - ' & TCity)"
            ds = DBHelper.GetDataSet(strSQL, "tblTransporters")
            Me.cmbTransporter.DataSource = ds
            Me.cmbTransporter.DisplayMember = "tblTransporters.SelectTransporter"
            Me.cmbTransporter.ValueMember = "tblTransporters.TransporterID"
            Me.cmbTransporter.SelectedText = ""
            Me.cmbTransporter.Text = ""

        Catch ex As SystemException

            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally

            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Function

    Function clearAll()

        Me.TAddress1.Text = ""
        Me.TAddress2.Text = ""
        Me.TCity.Text = ""
        Me.TState.Text = ""
        Me.TZip.Text = ""
        Me.TContactName.Text = ""
        Me.TContactPhone.Text = ""
        Me.TransporterName.Text = ""
        Me.lblTransporterLabel.Text = ""
        Me.T_ILNumber.Text = ""
        Me.T_USEPAID.Text = ""
        Me.CertOfIns.Text = ""

    End Function

    Private Sub btnAddT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddT.Click

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Me.lblTransporterLabel.Text = "Transporter:"
        Me.clearAll()
        Me.cmbTransporter.SelectedText = ""
        Me.cmbTransporter.Text = ""
        Me.transID = 0
        Me.TransporterName.Focus()
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub btnSaveT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveT.Click

        If Me.TransporterName.Text = "" Then
            MsgBox("Missing TransporterName. Please enter a TransporterName.", MsgBoxStyle.Information, "Save Transporter")
            Me.TransporterName.Focus()
            Exit Sub
        End If
        If Me.T_ILNumber.Text = "" Then
            MsgBox("Missing Hauler No. Please enter a Hauler No.", MsgBoxStyle.Information, "Save Transporter")
            Me.T_ILNumber.Focus()
            Exit Sub
        End If
        If Me.TPhone.Text = "" Then
            MsgBox("Missing Phone #. Please enter a Phone #.", MsgBoxStyle.Information, "Save Transporter")
            Me.TPhone.Focus()
            Exit Sub
        End If
        If Me.T_USEPAID.Text = "" Then
            MsgBox("Missing US EPA ID No. Please enter a US EPA ID No.", MsgBoxStyle.Information, "Save Transporter")
            Me.T_USEPAID.Focus()
            Exit Sub
        End If
        If Me.TAddress1.Text = "" Then
            MsgBox("Missing Address1. Please enter an Address1.", MsgBoxStyle.Information, "Save Transporter")
            Me.TAddress1.Focus()
            Exit Sub
        End If
        If Me.TCity.Text = "" Then
            MsgBox("Missing Transporter City. Please enter a Transporter City.", MsgBoxStyle.Information, "Save Transporter")
            Me.TCity.Focus()
            Exit Sub
        End If
        If Me.TState.Text = "" Then
            MsgBox("Missing Transporter State. Please enter a Transporter State.", MsgBoxStyle.Information, "Save Transporter")
            Me.TState.Focus()
            Exit Sub
        End If
        If Me.TZip.Text = "" Then
            MsgBox("Missing Zip. Please enter a Zip.", MsgBoxStyle.Information, "Save Transporter")
            Me.TZip.Focus()
            Exit Sub
        End If

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim strSQL As String
        Try
            Dim alreadyExists As Boolean = False, Active As Boolean = False
            Dim TransporterName As String, TContactName As String, TContactPhone As String
            Dim TAddress1 As String, TAddress2 As String, TCity As String, TState As String, TZip As String
            Dim T_ILNumber As String, T_USEPAID As String, T_CertOfIns As String
            'Grab values entered
            TransporterName = Me.TransporterName.Text
            TAddress1 = Me.TAddress1.Text
            TAddress2 = Me.TAddress2.Text
            TCity = Me.TCity.Text
            TState = Me.TState.Text
            TZip = Me.TZip.Text
            TContactName = Me.TContactName.Text
            TContactPhone = Me.TContactPhone.Text
            Active = Me.chkActive.Checked
            T_ILNumber = Replace(Me.T_ILNumber.Text, "'", "''")
            T_USEPAID = Replace(Me.T_USEPAID.Text, "'", "''")
            T_CertOfIns = Me.CertOfIns.Text

            If DBHelper.GetRecordCount("SELECT Count(*) FROM tblTransporters WHERE TransporterName = '" & Replace(TransporterName, "'", "''") & "'") > 0 Then
                alreadyExists = True
            End If
            If alreadyExists = True And Me.transID = 0 Then
                MsgBox("This Transporter already exists. Please re-enter.", MsgBoxStyle.Information, "Transporter")
            Else
                If Me.transID > 0 Then
                    strSQL = "UPDATE tblTransporters SET TransporterName='" & Replace(TransporterName, "'", "''") & "', TAddress1='" & Replace(TAddress1, "'", "''") & "', TAddress2='" & Replace(TAddress2, "'", "''") & "'," _
                            & "TCity='" & Replace(TCity, "'", "''") & "',TState='" & Replace(TState, "'", "''") & "',TZip='" & Replace(TZip, "'", "''") & "',TContactName='" & Replace(TContactName, "'", "''") & "',TContactPhone='" & Replace(TContactPhone, "'", "''") & "', Active = " & Active & ", T_ILNumber = '" & T_ILNumber & "', T_USEPAID = '" & T_USEPAID & "', CertOfIns = '" & T_CertOfIns & "', TPhone = '" & Replace(Me.TPhone.Text, "'", "''") & "' " _
                            & "WHERE TransporterID = " & Me.transID
                Else
                    strSQL = "INSERT INTO tblTransporters(TransporterName, TAddress1, TAddress2, TCity, TState, TZip, TContactName,TContactPhone, Active, T_ILNumber, T_USEPAID, CertOfIns, TPhone) " _
                            & " SELECT '" & Replace(TransporterName, "'", "''") & "', '" & Replace(TAddress1, "'", "''") & "', '" & Replace(TAddress2, "'", "''") & "', '" & Replace(TCity, "'", "''") & "', '" & Replace(TState, "'", "''") & "', '" & Replace(TZip, "'", "''") & "', '" & Replace(TContactName, "'", "''") & "', '" & Replace(TContactPhone, "'", "''") & "', " & Active & ", '" & T_ILNumber & "', '" & T_USEPAID & "', '" & T_CertOfIns & "', '" & Replace(Me.TPhone.Text, "'", "''") & "' "
                End If
                If DBHelper.ExecuteQuery(strSQL) = False Then
                    MsgBox("An error ocurred while performing this operation.", MsgBoxStyle.Information, "Error")
                Else
                    Me.populateSelection()
                    Me.cmbTransporter.SelectedValue = Me.transID
                End If
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
        Finally
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub btnCancelT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelT.Click

        Me.Close()

    End Sub

    Private Sub btnViewT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewT.Click

        If Me.cmbTransporter.SelectedIndex < 0 Then
            MsgBox("Please select a Transporter first.", MsgBoxStyle.Information, "Transporter")
            Exit Sub
        End If

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Me.transID = Me.cmbTransporter.SelectedValue
        Me.clearAll()

        Dim strSQL As String = "SELECT * FROM tblTransporters WHERE TransporterID = " & Me.transID
        Dim ds As DataSet

        Try

            ds = DBHelper.GetDataSet(strSQL, "tblTransporters")
            If ds.Tables(0).Rows.Count > 0 Then
                Dim dtRow As DataRow
                dtRow = ds.Tables(0).Rows(0)
                Me.TAddress1.Text = IIf(IsDBNull(dtRow.Item("TAddress1")), "", dtRow.Item("TAddress1"))
                Me.TAddress2.Text = IIf(IsDBNull(dtRow.Item("TAddress2")), "", dtRow.Item("TAddress2"))
                Me.TCity.Text = IIf(IsDBNull(dtRow.Item("TCity")), "", dtRow.Item("TCity"))
                Me.TState.Text = IIf(IsDBNull(dtRow.Item("TState")), "", dtRow.Item("TState"))
                Me.TZip.Text = IIf(IsDBNull(dtRow.Item("TZip")), "", dtRow.Item("TZip"))
                Me.TransporterName.Text = IIf(IsDBNull(dtRow.Item("TransporterName")), "", dtRow.Item("TransporterName"))
                Me.TContactName.Text = IIf(IsDBNull(dtRow.Item("TContactName")), "", dtRow.Item("TContactName"))
                Me.TContactPhone.Text = IIf(IsDBNull(dtRow.Item("TContactPhone")), "", dtRow.Item("TContactPhone"))
                Me.lblTransporterLabel.Text = Me.cmbTransporter.Text
                Me.chkActive.Checked = IIf(IsDBNull(dtRow.Item("Active")), True, dtRow.Item("Active"))
                Me.T_ILNumber.Text = IIf(IsDBNull(dtRow.Item("T_ILNumber")), "", dtRow.Item("T_ILNumber"))
                Me.T_USEPAID.Text = IIf(IsDBNull(dtRow.Item("T_USEPAID")), "", dtRow.Item("T_USEPAID"))
                Me.CertOfIns.Text = IIf(IsDBNull(dtRow.Item("CertOfIns")), "", dtRow.Item("CertOfIns"))
                Me.TPhone.Text = IIf(IsDBNull(dtRow.Item("TPhone")), "", dtRow.Item("TPhone"))
                dtRow = Nothing
            Else
                MsgBox("Transporter selected was not found. Please make another selection.", MsgBoxStyle.Information, "Transporter")
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
        Finally
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub frmTransporter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.initialLoad()
    End Sub

    Function initialLoad()
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Me.populateSelection()
        Me.clearAll()
        Me.cmbTransporter.Focus()
        Cursor.Current = System.Windows.Forms.Cursors.Default
    End Function

    Private Sub cmbTransporter_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbTransporter.KeyUp

        Dim index As Integer, actual As String, found As String
        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Back) Or (e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        ' Store the actual text that has been typed
        actual = Me.cmbTransporter.Text
        ' Find the first match for the typed value
        index = Me.cmbTransporter.FindString(actual)
        ' Get the text of the first match
        If (index > -1) Then
            ' Select this item from the list
            Me.cmbTransporter.SelectedIndex = index
            found = Me.cmbTransporter.Text
            ' Select the portion of the text that was automatically added so further typing will replace it
            Me.cmbTransporter.SelectionStart = actual.Length
            Me.cmbTransporter.SelectionLength = found.Length - actual.Length
        End If

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        Dim ds As DataSet
        Dim strsql As String = "SELECT * FROM tblTransporters ORDER BY TransporterName"

        Try
            ds = DBHelper.GetDataSet(strsql, "tblTransporters")
            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("No matching data found. Cancelling Report..", MsgBoxStyle.Information, "Transporters List")
            Else
                Dim frmR As New frmReport
                Dim objR As New rpt_TransportersList
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
            If MsgBox("Are you sure you want to In-Activate this Transporter?", MsgBoxStyle.YesNo, "In-Activate Transporter") = MsgBoxResult.Yes Then
                If DBHelper.ExecuteQuery("UPDATE tblTransporters SET Active = False WHERE TransporterID = " & Me.transID & "") = True Then
                    Me.initialLoad()
                Else
                    MsgBox("Could not In-Activate. There was an error.", MsgBoxStyle.Information, "Error Ocurred")
                End If
            End If
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
        End Try
    End Sub

End Class
