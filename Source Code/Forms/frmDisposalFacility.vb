Public Class frmDisposalFacility
    Inherits System.Windows.Forms.Form
    Dim facilityID As Integer = 0

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
    Friend WithEvents grpAddress As System.Windows.Forms.GroupBox
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpGenerator As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents DisposalFacilityName As System.Windows.Forms.TextBox
    Friend WithEvents FZip As System.Windows.Forms.TextBox
    Friend WithEvents FState As System.Windows.Forms.TextBox
    Friend WithEvents FCity As System.Windows.Forms.TextBox
    Friend WithEvents FAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents FAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents lblFacilityLabel As System.Windows.Forms.Label
    Friend WithEvents btnAddF As System.Windows.Forms.Button
    Friend WithEvents grpD As System.Windows.Forms.GroupBox
    Friend WithEvents btnViewF As System.Windows.Forms.Button
    Friend WithEvents cmbDisposalFacility As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelF As System.Windows.Forms.Button
    Friend WithEvents btnSaveF As System.Windows.Forms.Button
    Friend WithEvents FContactPhone As System.Windows.Forms.TextBox
    Friend WithEvents FContactName As System.Windows.Forms.TextBox
    Friend WithEvents btnPrint As System.Windows.Forms.PictureBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents D_USEPAID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents D_ILNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents IsBeaver As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents FPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDisposalFacility))
        Me.grpAddress = New System.Windows.Forms.GroupBox
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.FZip = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.FState = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.FCity = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.FAddress2 = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.FAddress1 = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblFacilityLabel = New System.Windows.Forms.Label
        Me.btnAddF = New System.Windows.Forms.Button
        Me.grpD = New System.Windows.Forms.GroupBox
        Me.btnViewF = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbDisposalFacility = New System.Windows.Forms.ComboBox
        Me.btnCancelF = New System.Windows.Forms.Button
        Me.btnSaveF = New System.Windows.Forms.Button
        Me.grpGenerator = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.IsBeaver = New System.Windows.Forms.CheckBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.D_ILNumber = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.D_USEPAID = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.chkActive = New System.Windows.Forms.CheckBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.FContactPhone = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.FContactName = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.DisposalFacilityName = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.btnPrint = New System.Windows.Forms.PictureBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.FPhone = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.grpAddress.SuspendLayout()
        Me.grpD.SuspendLayout()
        Me.grpGenerator.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAddress
        '
        Me.grpAddress.Controls.Add(Me.Label42)
        Me.grpAddress.Controls.Add(Me.Label41)
        Me.grpAddress.Controls.Add(Me.Label40)
        Me.grpAddress.Controls.Add(Me.Label39)
        Me.grpAddress.Controls.Add(Me.Label26)
        Me.grpAddress.Controls.Add(Me.FZip)
        Me.grpAddress.Controls.Add(Me.Label27)
        Me.grpAddress.Controls.Add(Me.Label28)
        Me.grpAddress.Controls.Add(Me.FState)
        Me.grpAddress.Controls.Add(Me.Label29)
        Me.grpAddress.Controls.Add(Me.Label30)
        Me.grpAddress.Controls.Add(Me.FCity)
        Me.grpAddress.Controls.Add(Me.Label31)
        Me.grpAddress.Controls.Add(Me.FAddress2)
        Me.grpAddress.Controls.Add(Me.Label32)
        Me.grpAddress.Controls.Add(Me.FAddress1)
        Me.grpAddress.Controls.Add(Me.Label34)
        Me.grpAddress.Controls.Add(Me.Label35)
        Me.grpAddress.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpAddress.Location = New System.Drawing.Point(320, 120)
        Me.grpAddress.Name = "grpAddress"
        Me.grpAddress.Size = New System.Drawing.Size(304, 192)
        Me.grpAddress.TabIndex = 3
        Me.grpAddress.TabStop = False
        Me.grpAddress.Text = "Address Info"
        '
        'Label42
        '
        Me.Label42.ForeColor = System.Drawing.Color.Red
        Me.Label42.Location = New System.Drawing.Point(112, 96)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(8, 8)
        Me.Label42.TabIndex = 40
        Me.Label42.Text = "*"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label41
        '
        Me.Label41.ForeColor = System.Drawing.Color.Red
        Me.Label41.Location = New System.Drawing.Point(2, 96)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(8, 8)
        Me.Label41.TabIndex = 39
        Me.Label41.Text = "*"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label40
        '
        Me.Label40.ForeColor = System.Drawing.Color.Red
        Me.Label40.Location = New System.Drawing.Point(2, 72)
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
        Me.Label26.Location = New System.Drawing.Point(180, 112)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(116, 1)
        Me.Label26.TabIndex = 35
        '
        'FZip
        '
        Me.FZip.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FZip.Location = New System.Drawing.Point(188, 96)
        Me.FZip.MaxLength = 10
        Me.FZip.Name = "FZip"
        Me.FZip.Size = New System.Drawing.Size(104, 14)
        Me.FZip.TabIndex = 6
        Me.FZip.Text = ""
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(120, 96)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 16)
        Me.Label27.TabIndex = 5
        Me.Label27.Text = "Zip Code:"
        '
        'Label28
        '
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label28.Location = New System.Drawing.Point(64, 112)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(40, 1)
        Me.Label28.TabIndex = 32
        '
        'FState
        '
        Me.FState.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FState.Location = New System.Drawing.Point(68, 96)
        Me.FState.MaxLength = 2
        Me.FState.Name = "FState"
        Me.FState.Size = New System.Drawing.Size(32, 14)
        Me.FState.TabIndex = 4
        Me.FState.Text = ""
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(8, 96)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(48, 16)
        Me.Label29.TabIndex = 30
        Me.Label29.Text = "State:"
        '
        'Label30
        '
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label30.Location = New System.Drawing.Point(64, 88)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(232, 1)
        Me.Label30.TabIndex = 29
        '
        'FCity
        '
        Me.FCity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FCity.Location = New System.Drawing.Point(68, 72)
        Me.FCity.MaxLength = 50
        Me.FCity.Name = "FCity"
        Me.FCity.Size = New System.Drawing.Size(224, 14)
        Me.FCity.TabIndex = 3
        Me.FCity.Text = ""
        '
        'Label31
        '
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label31.Location = New System.Drawing.Point(64, 64)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(232, 1)
        Me.Label31.TabIndex = 27
        '
        'FAddress2
        '
        Me.FAddress2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FAddress2.Location = New System.Drawing.Point(68, 48)
        Me.FAddress2.MaxLength = 75
        Me.FAddress2.Name = "FAddress2"
        Me.FAddress2.Size = New System.Drawing.Size(224, 14)
        Me.FAddress2.TabIndex = 2
        Me.FAddress2.Text = ""
        '
        'Label32
        '
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label32.Location = New System.Drawing.Point(64, 40)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(232, 1)
        Me.Label32.TabIndex = 25
        '
        'FAddress1
        '
        Me.FAddress1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FAddress1.Location = New System.Drawing.Point(68, 24)
        Me.FAddress1.MaxLength = 75
        Me.FAddress1.Name = "FAddress1"
        Me.FAddress1.Size = New System.Drawing.Size(224, 14)
        Me.FAddress1.TabIndex = 1
        Me.FAddress1.Text = ""
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(8, 72)
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
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(104, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(488, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Note: * indicates required fields."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblFacilityLabel
        '
        Me.lblFacilityLabel.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacilityLabel.Location = New System.Drawing.Point(96, 80)
        Me.lblFacilityLabel.Name = "lblFacilityLabel"
        Me.lblFacilityLabel.Size = New System.Drawing.Size(488, 16)
        Me.lblFacilityLabel.TabIndex = 35
        Me.lblFacilityLabel.Text = "Disposal Facility:"
        Me.lblFacilityLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnAddF
        '
        Me.btnAddF.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAddF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddF.Location = New System.Drawing.Point(112, 320)
        Me.btnAddF.Name = "btnAddF"
        Me.btnAddF.Size = New System.Drawing.Size(112, 24)
        Me.btnAddF.TabIndex = 4
        Me.btnAddF.Text = "&Add New"
        '
        'grpD
        '
        Me.grpD.Controls.Add(Me.btnViewF)
        Me.grpD.Controls.Add(Me.Label1)
        Me.grpD.Controls.Add(Me.cmbDisposalFacility)
        Me.grpD.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpD.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpD.Location = New System.Drawing.Point(8, 8)
        Me.grpD.Name = "grpD"
        Me.grpD.Size = New System.Drawing.Size(616, 56)
        Me.grpD.TabIndex = 1
        Me.grpD.TabStop = False
        Me.grpD.Text = "Select a Disposal Facility"
        '
        'btnViewF
        '
        Me.btnViewF.BackColor = System.Drawing.Color.SlateGray
        Me.btnViewF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewF.Location = New System.Drawing.Point(520, 24)
        Me.btnViewF.Name = "btnViewF"
        Me.btnViewF.Size = New System.Drawing.Size(88, 24)
        Me.btnViewF.TabIndex = 2
        Me.btnViewF.Text = "View/Edit"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Facility - City:"
        '
        'cmbDisposalFacility
        '
        Me.cmbDisposalFacility.Location = New System.Drawing.Point(152, 24)
        Me.cmbDisposalFacility.Name = "cmbDisposalFacility"
        Me.cmbDisposalFacility.Size = New System.Drawing.Size(360, 21)
        Me.cmbDisposalFacility.TabIndex = 1
        '
        'btnCancelF
        '
        Me.btnCancelF.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCancelF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelF.Location = New System.Drawing.Point(368, 320)
        Me.btnCancelF.Name = "btnCancelF"
        Me.btnCancelF.Size = New System.Drawing.Size(112, 24)
        Me.btnCancelF.TabIndex = 6
        Me.btnCancelF.Text = "&Cancel"
        '
        'btnSaveF
        '
        Me.btnSaveF.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSaveF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveF.Location = New System.Drawing.Point(240, 320)
        Me.btnSaveF.Name = "btnSaveF"
        Me.btnSaveF.Size = New System.Drawing.Size(112, 24)
        Me.btnSaveF.TabIndex = 5
        Me.btnSaveF.Text = "&Save"
        '
        'grpGenerator
        '
        Me.grpGenerator.Controls.Add(Me.Label12)
        Me.grpGenerator.Controls.Add(Me.Label11)
        Me.grpGenerator.Controls.Add(Me.FPhone)
        Me.grpGenerator.Controls.Add(Me.Label10)
        Me.grpGenerator.Controls.Add(Me.Label9)
        Me.grpGenerator.Controls.Add(Me.IsBeaver)
        Me.grpGenerator.Controls.Add(Me.Label8)
        Me.grpGenerator.Controls.Add(Me.Label7)
        Me.grpGenerator.Controls.Add(Me.Label5)
        Me.grpGenerator.Controls.Add(Me.D_ILNumber)
        Me.grpGenerator.Controls.Add(Me.Label6)
        Me.grpGenerator.Controls.Add(Me.Label3)
        Me.grpGenerator.Controls.Add(Me.D_USEPAID)
        Me.grpGenerator.Controls.Add(Me.Label4)
        Me.grpGenerator.Controls.Add(Me.Label45)
        Me.grpGenerator.Controls.Add(Me.chkActive)
        Me.grpGenerator.Controls.Add(Me.Label20)
        Me.grpGenerator.Controls.Add(Me.FContactPhone)
        Me.grpGenerator.Controls.Add(Me.Label21)
        Me.grpGenerator.Controls.Add(Me.Label17)
        Me.grpGenerator.Controls.Add(Me.FContactName)
        Me.grpGenerator.Controls.Add(Me.Label18)
        Me.grpGenerator.Controls.Add(Me.Label15)
        Me.grpGenerator.Controls.Add(Me.DisposalFacilityName)
        Me.grpGenerator.Controls.Add(Me.Label16)
        Me.grpGenerator.Controls.Add(Me.Label37)
        Me.grpGenerator.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpGenerator.Location = New System.Drawing.Point(8, 120)
        Me.grpGenerator.Name = "grpGenerator"
        Me.grpGenerator.Size = New System.Drawing.Size(304, 192)
        Me.grpGenerator.TabIndex = 2
        Me.grpGenerator.TabStop = False
        Me.grpGenerator.Text = "Disposal Facility"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(120, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 16)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Is Beaver Facility?:"
        '
        'IsBeaver
        '
        Me.IsBeaver.Checked = True
        Me.IsBeaver.CheckState = System.Windows.Forms.CheckState.Checked
        Me.IsBeaver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IsBeaver.Location = New System.Drawing.Point(248, 168)
        Me.IsBeaver.Name = "IsBeaver"
        Me.IsBeaver.Size = New System.Drawing.Size(16, 16)
        Me.IsBeaver.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(2, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(8, 8)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "*"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(2, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(8, 8)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "*"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(64, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(224, 1)
        Me.Label5.TabIndex = 38
        '
        'D_ILNumber
        '
        Me.D_ILNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.D_ILNumber.Location = New System.Drawing.Point(72, 48)
        Me.D_ILNumber.MaxLength = 75
        Me.D_ILNumber.Name = "D_ILNumber"
        Me.D_ILNumber.Size = New System.Drawing.Size(216, 14)
        Me.D_ILNumber.TabIndex = 2
        Me.D_ILNumber.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "IL No.:"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(104, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 1)
        Me.Label3.TabIndex = 1
        '
        'D_USEPAID
        '
        Me.D_USEPAID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.D_USEPAID.Location = New System.Drawing.Point(112, 72)
        Me.D_USEPAID.MaxLength = 75
        Me.D_USEPAID.Name = "D_USEPAID"
        Me.D_USEPAID.Size = New System.Drawing.Size(176, 14)
        Me.D_USEPAID.TabIndex = 3
        Me.D_USEPAID.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "US EPA ID No.:"
        '
        'Label45
        '
        Me.Label45.Location = New System.Drawing.Point(8, 168)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(64, 16)
        Me.Label45.TabIndex = 32
        Me.Label45.Text = "Active:"
        '
        'chkActive
        '
        Me.chkActive.Checked = True
        Me.chkActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkActive.Location = New System.Drawing.Point(72, 168)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(16, 16)
        Me.chkActive.TabIndex = 6
        '
        'Label20
        '
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Location = New System.Drawing.Point(104, 160)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(184, 1)
        Me.Label20.TabIndex = 15
        '
        'FContactPhone
        '
        Me.FContactPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FContactPhone.Location = New System.Drawing.Point(112, 144)
        Me.FContactPhone.MaxLength = 20
        Me.FContactPhone.Name = "FContactPhone"
        Me.FContactPhone.Size = New System.Drawing.Size(176, 14)
        Me.FContactPhone.TabIndex = 5
        Me.FContactPhone.Text = ""
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(8, 144)
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
        'FContactName
        '
        Me.FContactName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FContactName.Location = New System.Drawing.Point(72, 120)
        Me.FContactName.MaxLength = 75
        Me.FContactName.Name = "FContactName"
        Me.FContactName.Size = New System.Drawing.Size(216, 14)
        Me.FContactName.TabIndex = 4
        Me.FContactName.Text = ""
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
        'DisposalFacilityName
        '
        Me.DisposalFacilityName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DisposalFacilityName.Location = New System.Drawing.Point(72, 24)
        Me.DisposalFacilityName.MaxLength = 75
        Me.DisposalFacilityName.Name = "DisposalFacilityName"
        Me.DisposalFacilityName.Size = New System.Drawing.Size(216, 14)
        Me.DisposalFacilityName.TabIndex = 1
        Me.DisposalFacilityName.Text = ""
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
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(552, 312)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(72, 40)
        Me.btnPrint.TabIndex = 37
        Me.btnPrint.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.SlateGray
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(504, 320)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(32, 24)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "&In-Activate"
        Me.btnDelete.Visible = False
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 16)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Phone # :"
        '
        'FPhone
        '
        Me.FPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FPhone.Location = New System.Drawing.Point(104, 96)
        Me.FPhone.MaxLength = 20
        Me.FPhone.Name = "FPhone"
        Me.FPhone.Size = New System.Drawing.Size(184, 14)
        Me.FPhone.TabIndex = 4
        Me.FPhone.Text = ""
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(104, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(184, 1)
        Me.Label11.TabIndex = 45
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(3, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(8, 8)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "*"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmDisposalFacility
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(632, 349)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.grpAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblFacilityLabel)
        Me.Controls.Add(Me.btnAddF)
        Me.Controls.Add(Me.grpD)
        Me.Controls.Add(Me.btnCancelF)
        Me.Controls.Add(Me.btnSaveF)
        Me.Controls.Add(Me.grpGenerator)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmDisposalFacility"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Disposal Facility"
        Me.grpAddress.ResumeLayout(False)
        Me.grpD.ResumeLayout(False)
        Me.grpGenerator.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Function populateSelection()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet
        Dim strSQL As String

        Try

            strSQL = "SELECT DisposalFacilityID, (DisposalFacilityName & ' - ' & FCity) as SelectFacility FROM tblDisposalFacilities WHERE (tblDisposalFacilities.Active = TRUE) ORDER BY (DisposalFacilityName & ' - ' & FCity)"
            ds = DBHelper.GetDataSet(strSQL, "tblDisposalFacilities")
            Me.cmbDisposalFacility.DataSource = ds
            Me.cmbDisposalFacility.DisplayMember = "tblDisposalFacilities.SelectFacility"
            Me.cmbDisposalFacility.ValueMember = "tblDisposalFacilities.DisposalFacilityID"
            Me.cmbDisposalFacility.SelectedText = ""
            Me.cmbDisposalFacility.Text = ""

        Catch ex As SystemException

            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally

            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Function

    Function clearAll()

        Me.FAddress1.Text = ""
        Me.FAddress2.Text = ""
        Me.FCity.Text = ""
        Me.FState.Text = ""
        Me.FZip.Text = ""
        Me.FContactName.Text = ""
        Me.FContactPhone.Text = ""
        Me.DisposalFacilityName.Text = ""
        Me.lblFacilityLabel.Text = ""
        Me.D_ILNumber.Text = ""
        Me.D_USEPAID.Text = ""

    End Function

    Private Sub btnAddF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddF.Click

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Me.lblFacilityLabel.Text = "Disposal Facility:"
        Me.clearAll()
        Me.cmbDisposalFacility.SelectedText = ""
        Me.cmbDisposalFacility.Text = ""
        Me.facilityID = 0
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub btnSaveF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveF.Click

        If Me.DisposalFacilityName.Text = "" Then
            MsgBox("Missing DisposalFacilityName. Please enter a DisposalFacilityName.", MsgBoxStyle.Information, "Save Disposal Facility")
            Me.DisposalFacilityName.Focus()
            Exit Sub
        End If
        If Me.D_ILNumber.Text = "" Then
            MsgBox("Missing IL No. Please enter an IL No.", MsgBoxStyle.Information, "Save Disposal Facility")
            Me.D_ILNumber.Focus()
            Exit Sub
        End If
        If Me.D_USEPAID.Text = "" Then
            MsgBox("Missing US EPA ID No. Please enter a US EPA ID No.", MsgBoxStyle.Information, "Save Disposal Facility")
            Me.D_USEPAID.Focus()
            Exit Sub
        End If
        If Me.FPhone.Text = "" Then
            MsgBox("Missing Phone #. Please enter the Phone # of this facility.", MsgBoxStyle.Information, "Save Disposal Facility")
            Me.FPhone.Focus()
            Exit Sub
        End If
        If Me.FAddress1.Text = "" Then
            MsgBox("Missing Address1. Please enter an Address1.", MsgBoxStyle.Information, "Save Disposal Facility")
            Me.FAddress1.Focus()
            Exit Sub
        End If
        If Me.FCity.Text = "" Then
            MsgBox("Missing Disposal Facility City. Please enter a Disposal Facility City.", MsgBoxStyle.Information, "Save Disposal Facility")
            Me.FCity.Focus()
            Exit Sub
        End If
        If Me.FState.Text = "" Then
            MsgBox("Missing Disposal Facility State. Please enter a Disposal Facility State.", MsgBoxStyle.Information, "Save Disposal Facility")
            Me.FState.Focus()
            Exit Sub
        End If
        If Me.FZip.Text = "" Then
            MsgBox("Missing Zip. Please enter a Zip.", MsgBoxStyle.Information, "Save Disposal Facility")
            Me.FZip.Focus()
            Exit Sub
        End If

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        Dim strSQL As String
        Try
            Dim alreadyExists As Boolean = False, Active As Boolean = False
            Dim DisposalFacilityName As String, FContactName As String, FContactPhone As String
            Dim FAddress1 As String, FAddress2 As String, FCity As String, FState As String, FZip As String
            Dim D_ILNumber As String, D_USEPAID As String, FPhone1 As String
            'Grab values entered
            DisposalFacilityName = Me.DisposalFacilityName.Text
            FAddress1 = Me.FAddress1.Text
            FAddress2 = Me.FAddress2.Text
            FCity = Me.FCity.Text
            FState = Me.FState.Text
            FZip = Me.FZip.Text
            FPhone1 = Me.FPhone.Text
            FContactName = Me.FContactName.Text
            FContactPhone = Me.FContactPhone.Text
            Active = Me.chkActive.Checked
            D_ILNumber = Me.D_ILNumber.Text
            D_USEPAID = Me.D_USEPAID.Text

            If DBHelper.GetRecordCount("SELECT Count(*) FROM tblDisposalFacilities WHERE DisposalFacilityName = '" & Replace(DisposalFacilityName, "'", "''") & "'") > 0 Then
                alreadyExists = True
            End If
            If alreadyExists = True And Me.facilityID = 0 Then
                MsgBox("This Disposal Facility already exists. Please re-enter.", MsgBoxStyle.Information, "Disposal Facility")
            Else
                If Me.facilityID > 0 Then
                    strSQL = "UPDATE tblDisposalFacilities SET DisposalFacilityName='" & Replace(DisposalFacilityName, "'", "''") & "', FAddress1='" & Replace(FAddress1, "'", "''") & "', FAddress2='" & Replace(FAddress2, "'", "''") & "'," _
                            & "FCity='" & Replace(FCity, "'", "''") & "',FState='" & Replace(FState, "'", "''") & "',FZip='" & Replace(FZip, "'", "''") & "',FContactName='" & Replace(FContactName, "'", "''") & "',FContactPhone='" & Replace(FContactPhone, "'", "''") & "', Active = " & Active & ", D_USEPAID = '" & Replace(D_USEPAID, "'", "''") & "', D_ILNumber = '" & Replace(D_ILNumber, "'", "''") & "', IsBeaver =" & Me.IsBeaver.Checked & ", FPhone = '" & Replace(FPhone1, "'", "''") & "' " _
                            & "WHERE DisposalFacilityID = " & Me.facilityID
                Else
                    strSQL = "INSERT INTO tblDisposalFacilities(DisposalFacilityName, FAddress1, FAddress2, FCity, FState, FZip, FContactName, FContactPhone, Active, D_ILNumber, D_USEPAID, IsBeaver, FPhone) " _
                            & " SELECT '" & Replace(DisposalFacilityName, "'", "''") & "', '" & Replace(FAddress1, "'", "''") & "', '" & Replace(FAddress2, "'", "''") & "', '" & Replace(FCity, "'", "''") & "', '" & Replace(FState, "'", "''") & "', '" & Replace(FZip, "'", "''") & "', '" & Replace(FContactName, "'", "''") & "', '" & Replace(FContactPhone, "'", "''") & "', " & Active & ", '" & Replace(D_ILNumber, "'", "''") & "', '" & Replace(D_USEPAID, "'", "''") & "', " & Me.IsBeaver.Checked & ", '" & Replace(FPhone1, "'", "''") & "' "
                End If
                If DBHelper.ExecuteQuery(strSQL) = False Then
                    MsgBox("An error ocurred while performing this operation.", MsgBoxStyle.Information, "Error")
                Else
                    Me.populateSelection()
                    Me.cmbDisposalFacility.SelectedValue = Me.facilityID
                End If
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally

            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Sub

    Private Sub btnCancelF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelF.Click

        Me.Close()

    End Sub

    Private Sub btnViewF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewF.Click

        If Me.cmbDisposalFacility.SelectedIndex < 0 Then
            MsgBox("Please select a Disposal Facility first.", MsgBoxStyle.Information, "Disposal Facility")
            Exit Sub
        End If

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Me.clearAll()
        Me.facilityID = Me.cmbDisposalFacility.SelectedValue

        Dim strSQL As String = "SELECT * FROM tblDisposalFacilities WHERE DisposalFacilityID = " & Me.facilityID
        Dim ds As DataSet

        Try

            ds = DBHelper.GetDataSet(strSQL, "tblDisposalFacilities")
            If ds.Tables(0).Rows.Count > 0 Then
                Dim dtRow As DataRow
                dtRow = ds.Tables(0).Rows(0)
                Me.FAddress1.Text = IIf(IsDBNull(dtRow.Item("FAddress1")), "", dtRow.Item("FAddress1"))
                Me.FAddress2.Text = IIf(IsDBNull(dtRow.Item("FAddress2")), "", dtRow.Item("FAddress2"))
                Me.FCity.Text = IIf(IsDBNull(dtRow.Item("FCity")), "", dtRow.Item("FCity"))
                Me.FState.Text = IIf(IsDBNull(dtRow.Item("FState")), "", dtRow.Item("FState"))
                Me.FZip.Text = IIf(IsDBNull(dtRow.Item("FZip")), "", dtRow.Item("FZip"))
                Me.DisposalFacilityName.Text = IIf(IsDBNull(dtRow.Item("DisposalFacilityName")), "", dtRow.Item("DisposalFacilityName"))
                Me.FContactName.Text = IIf(IsDBNull(dtRow.Item("FContactName")), "", dtRow.Item("FContactName"))
                Me.FContactPhone.Text = IIf(IsDBNull(dtRow.Item("FContactPhone")), "", dtRow.Item("FContactPhone"))
                Me.D_ILNumber.Text = IIf(IsDBNull(dtRow.Item("D_ILNumber")), "", dtRow.Item("D_ILNumber"))
                Me.D_USEPAID.Text = IIf(IsDBNull(dtRow.Item("D_USEPAID")), "", dtRow.Item("D_USEPAID"))
                Me.lblFacilityLabel.Text = Me.cmbDisposalFacility.Text
                Me.chkActive.Checked = IIf(IsDBNull(dtRow.Item("Active")), True, dtRow.Item("Active"))
                Me.IsBeaver.Checked = IIf(IsDBNull(dtRow.Item("IsBeaver")), True, dtRow.Item("IsBeaver"))
                Me.FPhone.Text = IIf(IsDBNull(dtRow.Item("FPhone")), "", dtRow.Item("FPhone"))
                dtRow = Nothing
            Else
                MsgBox("Disposal Facility selected was not found. Please make another selection.", MsgBoxStyle.Information, "Disposal Facility")
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub frmDisposalFacility_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.InitialLoad()

    End Sub

    Function InitialLoad()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Me.populateSelection()
        Me.clearAll()
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function

    Private Sub cmbDisposalFacility_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbDisposalFacility.KeyUp

        Dim index As Integer, actual As String, found As String
        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Back) Or (e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        ' Store the actual text that has been typed
        actual = Me.cmbDisposalFacility.Text
        ' Find the first match for the typed value
        index = Me.cmbDisposalFacility.FindString(actual)
        ' Get the text of the first match
        If (index > -1) Then
            ' Select this item from the list
            Me.cmbDisposalFacility.SelectedIndex = index
            found = Me.cmbDisposalFacility.Text
            ' Select the portion of the text that was automatically added so further typing will replace it
            Me.cmbDisposalFacility.SelectionStart = actual.Length
            Me.cmbDisposalFacility.SelectionLength = found.Length - actual.Length
        End If

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        Dim ds As DataSet
        Dim strsql As String = "SELECT * FROM tblDisposalFacilities ORDER BY DisposalFacilityName"

        Try
            ds = DBHelper.GetDataSet(strsql, "tblDisposalFacilities")
            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("No matching data found. Cancelling Report..", MsgBoxStyle.Information, "Disposal Facilities List")
            Else
                Dim frmR As New frmReport
                Dim objR As New rpt_FacilitiesList
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
            If MsgBox("Are you sure you want to In-Activate this Disposal Facility?", MsgBoxStyle.YesNo, "In-Activate Disposal Facility") = MsgBoxResult.Yes Then
                If DBHelper.ExecuteQuery("UPDATE tblDisposalFacilities SET Active = False WHERE DisposalFacilityID = " & Me.facilityID & "") = True Then
                    Me.InitialLoad()
                Else
                    MsgBox("Could not In-Activate. There was an error.", MsgBoxStyle.Information, "Error Ocurred")
                End If
            End If
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
        End Try
    End Sub
End Class
