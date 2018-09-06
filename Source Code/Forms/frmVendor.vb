Public Class frmVendor
    Inherits System.Windows.Forms.Form

    Public venID As Integer = 0

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
    Friend WithEvents grpP As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpContact As System.Windows.Forms.GroupBox
    Friend WithEvents grpVendor As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents VendorCPhone As System.Windows.Forms.TextBox
    Friend WithEvents VendorCName As System.Windows.Forms.TextBox
    Friend WithEvents VendorNo As System.Windows.Forms.TextBox
    Friend WithEvents VendorZip As System.Windows.Forms.TextBox
    Friend WithEvents VendorState As System.Windows.Forms.TextBox
    Friend WithEvents VendorCity As System.Windows.Forms.TextBox
    Friend WithEvents VendorAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents VendorAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents VendorName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblVendorLabel As System.Windows.Forms.Label
    Friend WithEvents btnAddV As System.Windows.Forms.Button
    Friend WithEvents btnCancelV As System.Windows.Forms.Button
    Friend WithEvents btnSaveV As System.Windows.Forms.Button
    Friend WithEvents btnPrintV As System.Windows.Forms.PictureBox
    Friend WithEvents cmbVendor As System.Windows.Forms.ComboBox
    Friend WithEvents btnViewV As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmVendor))
        Me.grpP = New System.Windows.Forms.GroupBox
        Me.btnViewV = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbVendor = New System.Windows.Forms.ComboBox
        Me.grpContact = New System.Windows.Forms.GroupBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.VendorCPhone = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.VendorCName = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.VendorNo = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblVendorLabel = New System.Windows.Forms.Label
        Me.grpVendor = New System.Windows.Forms.GroupBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.chkActive = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.VendorZip = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.VendorState = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.VendorCity = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.VendorAddress2 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.VendorAddress1 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.VendorName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnAddV = New System.Windows.Forms.Button
        Me.btnCancelV = New System.Windows.Forms.Button
        Me.btnSaveV = New System.Windows.Forms.Button
        Me.btnPrintV = New System.Windows.Forms.PictureBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.grpP.SuspendLayout()
        Me.grpContact.SuspendLayout()
        Me.grpVendor.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpP
        '
        Me.grpP.Controls.Add(Me.btnViewV)
        Me.grpP.Controls.Add(Me.Label2)
        Me.grpP.Controls.Add(Me.cmbVendor)
        Me.grpP.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpP.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpP.Location = New System.Drawing.Point(8, 8)
        Me.grpP.Name = "grpP"
        Me.grpP.Size = New System.Drawing.Size(616, 56)
        Me.grpP.TabIndex = 0
        Me.grpP.TabStop = False
        Me.grpP.Text = "Select a Vendor"
        '
        'btnViewV
        '
        Me.btnViewV.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnViewV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewV.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewV.Location = New System.Drawing.Point(520, 24)
        Me.btnViewV.Name = "btnViewV"
        Me.btnViewV.Size = New System.Drawing.Size(88, 24)
        Me.btnViewV.TabIndex = 2
        Me.btnViewV.Text = "View/Edit"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Vendor:"
        '
        'cmbVendor
        '
        Me.cmbVendor.Location = New System.Drawing.Point(72, 24)
        Me.cmbVendor.Name = "cmbVendor"
        Me.cmbVendor.Size = New System.Drawing.Size(440, 21)
        Me.cmbVendor.TabIndex = 1
        '
        'grpContact
        '
        Me.grpContact.Controls.Add(Me.Label20)
        Me.grpContact.Controls.Add(Me.VendorCPhone)
        Me.grpContact.Controls.Add(Me.Label21)
        Me.grpContact.Controls.Add(Me.Label17)
        Me.grpContact.Controls.Add(Me.VendorCName)
        Me.grpContact.Controls.Add(Me.Label18)
        Me.grpContact.Controls.Add(Me.Label15)
        Me.grpContact.Controls.Add(Me.VendorNo)
        Me.grpContact.Controls.Add(Me.Label16)
        Me.grpContact.Controls.Add(Me.Label37)
        Me.grpContact.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpContact.Location = New System.Drawing.Point(360, 120)
        Me.grpContact.Name = "grpContact"
        Me.grpContact.Size = New System.Drawing.Size(264, 176)
        Me.grpContact.TabIndex = 2
        Me.grpContact.TabStop = False
        Me.grpContact.Text = "Contact Info"
        '
        'Label20
        '
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Location = New System.Drawing.Point(104, 104)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(152, 1)
        Me.Label20.TabIndex = 15
        '
        'VendorCPhone
        '
        Me.VendorCPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VendorCPhone.Location = New System.Drawing.Point(112, 88)
        Me.VendorCPhone.MaxLength = 20
        Me.VendorCPhone.Name = "VendorCPhone"
        Me.VendorCPhone.Size = New System.Drawing.Size(144, 14)
        Me.VendorCPhone.TabIndex = 2
        Me.VendorCPhone.Text = ""
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(8, 88)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 16)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "Contact Phone:"
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Location = New System.Drawing.Point(64, 72)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(192, 1)
        Me.Label17.TabIndex = 12
        '
        'VendorCName
        '
        Me.VendorCName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VendorCName.Location = New System.Drawing.Point(72, 56)
        Me.VendorCName.MaxLength = 75
        Me.VendorCName.Name = "VendorCName"
        Me.VendorCName.Size = New System.Drawing.Size(184, 14)
        Me.VendorCName.TabIndex = 1
        Me.VendorCName.Text = ""
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(8, 56)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 16)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Contact:"
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Location = New System.Drawing.Point(88, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(168, 1)
        Me.Label15.TabIndex = 9
        '
        'VendorNo
        '
        Me.VendorNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VendorNo.Location = New System.Drawing.Point(96, 24)
        Me.VendorNo.MaxLength = 10
        Me.VendorNo.Name = "VendorNo"
        Me.VendorNo.Size = New System.Drawing.Size(160, 14)
        Me.VendorNo.TabIndex = 0
        Me.VendorNo.Text = ""
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(8, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 16)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Vendor No.:"
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
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(80, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(488, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Note: * indicates required fields."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVendorLabel
        '
        Me.lblVendorLabel.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendorLabel.Location = New System.Drawing.Point(72, 80)
        Me.lblVendorLabel.Name = "lblVendorLabel"
        Me.lblVendorLabel.Size = New System.Drawing.Size(488, 16)
        Me.lblVendorLabel.TabIndex = 33
        Me.lblVendorLabel.Text = "Vendor:"
        Me.lblVendorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grpVendor
        '
        Me.grpVendor.Controls.Add(Me.Label45)
        Me.grpVendor.Controls.Add(Me.chkActive)
        Me.grpVendor.Controls.Add(Me.Label3)
        Me.grpVendor.Controls.Add(Me.Label13)
        Me.grpVendor.Controls.Add(Me.VendorZip)
        Me.grpVendor.Controls.Add(Me.Label14)
        Me.grpVendor.Controls.Add(Me.Label11)
        Me.grpVendor.Controls.Add(Me.VendorState)
        Me.grpVendor.Controls.Add(Me.Label12)
        Me.grpVendor.Controls.Add(Me.Label10)
        Me.grpVendor.Controls.Add(Me.VendorCity)
        Me.grpVendor.Controls.Add(Me.Label9)
        Me.grpVendor.Controls.Add(Me.VendorAddress2)
        Me.grpVendor.Controls.Add(Me.Label8)
        Me.grpVendor.Controls.Add(Me.VendorAddress1)
        Me.grpVendor.Controls.Add(Me.Label7)
        Me.grpVendor.Controls.Add(Me.VendorName)
        Me.grpVendor.Controls.Add(Me.Label6)
        Me.grpVendor.Controls.Add(Me.Label5)
        Me.grpVendor.Controls.Add(Me.Label4)
        Me.grpVendor.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpVendor.Location = New System.Drawing.Point(8, 120)
        Me.grpVendor.Name = "grpVendor"
        Me.grpVendor.Size = New System.Drawing.Size(344, 176)
        Me.grpVendor.TabIndex = 1
        Me.grpVendor.TabStop = False
        Me.grpVendor.Text = "Vendor Info"
        '
        'Label45
        '
        Me.Label45.Location = New System.Drawing.Point(8, 152)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(56, 16)
        Me.Label45.TabIndex = 36
        Me.Label45.Text = "Active:"
        '
        'chkActive
        '
        Me.chkActive.Checked = True
        Me.chkActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkActive.Location = New System.Drawing.Point(64, 152)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(16, 16)
        Me.chkActive.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(2, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(8, 8)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "*"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(184, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(144, 1)
        Me.Label13.TabIndex = 18
        '
        'VendorZip
        '
        Me.VendorZip.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VendorZip.Location = New System.Drawing.Point(192, 120)
        Me.VendorZip.MaxLength = 10
        Me.VendorZip.Name = "VendorZip"
        Me.VendorZip.Size = New System.Drawing.Size(136, 14)
        Me.VendorZip.TabIndex = 7
        Me.VendorZip.Text = ""
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(120, 120)
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
        'VendorState
        '
        Me.VendorState.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VendorState.Location = New System.Drawing.Point(72, 120)
        Me.VendorState.MaxLength = 2
        Me.VendorState.Name = "VendorState"
        Me.VendorState.Size = New System.Drawing.Size(32, 14)
        Me.VendorState.TabIndex = 5
        Me.VendorState.Text = ""
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
        Me.Label10.Size = New System.Drawing.Size(264, 1)
        Me.Label10.TabIndex = 12
        '
        'VendorCity
        '
        Me.VendorCity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VendorCity.Location = New System.Drawing.Point(72, 96)
        Me.VendorCity.MaxLength = 50
        Me.VendorCity.Name = "VendorCity"
        Me.VendorCity.Size = New System.Drawing.Size(256, 14)
        Me.VendorCity.TabIndex = 4
        Me.VendorCity.Text = ""
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(64, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(264, 1)
        Me.Label9.TabIndex = 10
        '
        'VendorAddress2
        '
        Me.VendorAddress2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VendorAddress2.Location = New System.Drawing.Point(72, 72)
        Me.VendorAddress2.MaxLength = 75
        Me.VendorAddress2.Name = "VendorAddress2"
        Me.VendorAddress2.Size = New System.Drawing.Size(256, 14)
        Me.VendorAddress2.TabIndex = 3
        Me.VendorAddress2.Text = ""
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(64, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(264, 1)
        Me.Label8.TabIndex = 8
        '
        'VendorAddress1
        '
        Me.VendorAddress1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VendorAddress1.Location = New System.Drawing.Point(72, 48)
        Me.VendorAddress1.MaxLength = 75
        Me.VendorAddress1.Name = "VendorAddress1"
        Me.VendorAddress1.Size = New System.Drawing.Size(256, 14)
        Me.VendorAddress1.TabIndex = 2
        Me.VendorAddress1.Text = ""
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(64, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(264, 1)
        Me.Label7.TabIndex = 6
        '
        'VendorName
        '
        Me.VendorName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VendorName.Location = New System.Drawing.Point(72, 24)
        Me.VendorName.MaxLength = 75
        Me.VendorName.Name = "VendorName"
        Me.VendorName.Size = New System.Drawing.Size(256, 14)
        Me.VendorName.TabIndex = 1
        Me.VendorName.Text = ""
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
        'btnAddV
        '
        Me.btnAddV.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAddV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddV.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddV.Location = New System.Drawing.Point(136, 312)
        Me.btnAddV.Name = "btnAddV"
        Me.btnAddV.Size = New System.Drawing.Size(112, 24)
        Me.btnAddV.TabIndex = 3
        Me.btnAddV.Text = "&Add New"
        '
        'btnCancelV
        '
        Me.btnCancelV.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCancelV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelV.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelV.Location = New System.Drawing.Point(392, 312)
        Me.btnCancelV.Name = "btnCancelV"
        Me.btnCancelV.Size = New System.Drawing.Size(112, 24)
        Me.btnCancelV.TabIndex = 5
        Me.btnCancelV.Text = "&Cancel"
        '
        'btnSaveV
        '
        Me.btnSaveV.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSaveV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveV.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveV.Location = New System.Drawing.Point(264, 312)
        Me.btnSaveV.Name = "btnSaveV"
        Me.btnSaveV.Size = New System.Drawing.Size(112, 24)
        Me.btnSaveV.TabIndex = 4
        Me.btnSaveV.Text = "&Save"
        '
        'btnPrintV
        '
        Me.btnPrintV.Image = CType(resources.GetObject("btnPrintV.Image"), System.Drawing.Image)
        Me.btnPrintV.Location = New System.Drawing.Point(552, 304)
        Me.btnPrintV.Name = "btnPrintV"
        Me.btnPrintV.Size = New System.Drawing.Size(72, 40)
        Me.btnPrintV.TabIndex = 38
        Me.btnPrintV.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.SlateGray
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(520, 312)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(16, 24)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "&In-Activate"
        Me.btnDelete.Visible = False
        '
        'frmVendor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(632, 357)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnPrintV)
        Me.Controls.Add(Me.btnAddV)
        Me.Controls.Add(Me.btnCancelV)
        Me.Controls.Add(Me.btnSaveV)
        Me.Controls.Add(Me.grpVendor)
        Me.Controls.Add(Me.grpContact)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblVendorLabel)
        Me.Controls.Add(Me.grpP)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmVendor"
        Me.Text = "Vendor"
        Me.grpP.ResumeLayout(False)
        Me.grpContact.ResumeLayout(False)
        Me.grpVendor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

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

    Private Sub frmVendor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.InitialLoad()
    End Sub

    Function InitialLoad()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Me.populateVSelection()
        Me.clearAll()
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function

    Function clearAll()

        Me.lblVendorLabel.Text = ""
        Me.VendorName.Text = ""
        Me.VendorAddress1.Text = ""
        Me.VendorAddress2.Text = ""
        Me.VendorCity.Text = ""
        Me.VendorState.Text = ""
        Me.VendorZip.Text = ""
        Me.VendorNo.Text = ""
        Me.VendorCName.Text = ""
        Me.VendorCPhone.Text = ""

    End Function

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
            Me.cmbVendor.Refresh()
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
        Finally
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Function

    Private Sub btnViewV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewV.Click

        Me.populateVendorInfo()

    End Sub

    Function populateVendorInfo()

        If Me.cmbVendor.SelectedIndex < 0 Then
            MsgBox("Please select a Vendor first.", MsgBoxStyle.Information, "Vendor")
            Me.cmbVendor.Focus()
            Exit Function
        End If
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Me.venID = Me.cmbVendor.SelectedValue
        Me.clearAll()
        Dim strSQL As String = "SELECT * FROM tblVendors WHERE VendorID = " & Me.venID
        Dim ds As DataSet
        Try
            ds = DBHelper.GetDataSet(strSQL, "tblVendors")
            If ds.Tables(0).Rows.Count > 0 Then
                Dim dtRow As DataRow
                dtRow = ds.Tables(0).Rows(0)
                Me.VendorName.Text = dtRow.Item("VendorName")
                Me.VendorAddress1.Text = IIf(IsDBNull(dtRow.Item("VendorAddress1")), "", dtRow.Item("VendorAddress1"))
                Me.VendorAddress2.Text = IIf(IsDBNull(dtRow.Item("VendorAddress2")), "", dtRow.Item("VendorAddress2"))
                Me.VendorCity.Text = IIf(IsDBNull(dtRow.Item("VendorCity")), "", dtRow.Item("VendorCity"))
                Me.VendorState.Text = IIf(IsDBNull(dtRow.Item("VendorState")), "", dtRow.Item("VendorState"))
                Me.VendorZip.Text = IIf(IsDBNull(dtRow.Item("VendorZip")), "", dtRow.Item("VendorZip"))
                Me.VendorNo.Text = dtRow.Item("VendorNo")
                Me.VendorCName.Text = IIf(IsDBNull(dtRow.Item("VendorCName")), "", dtRow.Item("VendorCName"))
                Me.VendorCPhone.Text = IIf(IsDBNull(dtRow.Item("VendorCPhone")), "", dtRow.Item("VendorCPhone"))
                Me.lblVendorLabel.Text = dtRow.Item("VendorNo") & " - " & dtRow.Item("VendorName")
                Me.chkActive.Checked = IIf(IsDBNull(dtRow.Item("Active")), True, dtRow.Item("Active"))
                dtRow = Nothing
            Else
                MsgBox("Vendor selected was not found. Please make another selection.", MsgBoxStyle.Information, "Vendor")
            End If
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
        Finally
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Function

    Private Sub btnSaveV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveV.Click

        If Me.VendorName.Text = "" Then
            MsgBox("Missing Vendor Name. Please enter a Vendor Name.", MsgBoxStyle.Information, "Save Vendor")
            Me.VendorName.Focus()
            Exit Sub
        End If
        If Me.VendorNo.Text = "" Then
            MsgBox("Missing Vendor No. Please select a Vendor No.", MsgBoxStyle.Information, "Save Vendor")
            Me.VendorNo.Focus()
            Exit Sub
        End If
        Dim strSQL As String
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try

            Dim alreadyExists As Boolean = False, Active As Boolean = False
            Dim VendorName As String, VendorAddress1 As String, VendorAddress2 As String, VendorCity As String, VendorState As String
            Dim VendorZip As String, VendorNo As String, VendorCName As String, VendorCPhone As String
            'Grab values entered
            VendorName = Me.VendorName.Text
            VendorAddress1 = Me.VendorAddress1.Text
            VendorAddress2 = Me.VendorAddress2.Text
            VendorCity = Me.VendorCity.Text
            VendorState = Me.VendorState.Text
            VendorZip = Me.VendorZip.Text
            VendorNo = Me.VendorNo.Text
            VendorCName = Me.VendorCName.Text
            VendorCPhone = Me.VendorCPhone.Text
            Active = Me.chkActive.Checked

            If Me.venID > 0 Then
                If DBHelper.GetRecordCount("SELECT Count(*) FROM tblVendors WHERE (VendorName = '" & Replace(VendorName, "'", "''") & "' OR VendorNo = '" & Replace(Me.VendorNo.Text, "'", "'") & "') AND VendorID <> " & Me.venID & "") > 0 Then alreadyExists = True
            Else
                If DBHelper.GetRecordCount("SELECT Count(*) FROM tblVendors WHERE VendorName = '" & Replace(VendorName, "'", "''") & "' OR VendorNo = '" & Replace(Me.VendorNo.Text, "'", "'") & "'") > 0 Then alreadyExists = True
            End If
            If alreadyExists = True Then
                MsgBox("A Vendor already exists with this Vendor No or Name. Please re-enter.", MsgBoxStyle.Information, "Vendor")
            Else
                If Me.venID > 0 Then
                    strSQL = "UPDATE tblVendors SET VendorName='" & Replace(VendorName, "'", "''") & "', VendorAddress1='" & Replace(VendorAddress1, "'", "''") & "', " _
                            & "VendorAddress2='" & Replace(VendorAddress2, "'", "''") & "', VendorCity='" & Replace(VendorCity, "'", "''") & "', VendorState='" & Replace(VendorState, "'", "''") & "', " _
                            & "VendorZip='" & Replace(VendorZip, "'", "''") & "', VendorNo = '" & Replace(VendorNo, "'", "''") & "', VendorCName = '" & Replace(VendorCName, "'", "''") & "', " _
                            & "VendorCPhone = '" & Replace(VendorCPhone, "'", "''") & "', Active = " & Active & " " _
                            & "WHERE VendorID = " & Me.venID
                Else
                    strSQL = "INSERT INTO tblVendors(VendorName, VendorAddress1, VendorAddress2, VendorCity, VendorState, VendorZip, VendorNo, VendorCName, VendorCPhone, Active) " _
                            & " SELECT '" & Replace(VendorName, "'", "''") & "', '" & Replace(VendorAddress1, "'", "''") & "', '" & Replace(VendorAddress2, "'", "''") & "', '" & Replace(VendorCity, "'", "''") & "', '" & Replace(VendorState, "'", "''") & "', '" & Replace(VendorZip, "'", "''") & "', '" & Replace(VendorNo, "'", "''") & "', '" & Replace(VendorCName, "'", "''") & "', '" & Replace(VendorCPhone, "'", "''") & "', " & Active & " "
                End If
                If DBHelper.ExecuteQuery(strSQL) = False Then
                    MsgBox("An error ocurred while performing this operation.", MsgBoxStyle.Information, "Error")
                Else
                    If Me.venID = 0 Then
                        Me.populateVSelection()
                        Me.cmbVendor.SelectedValue = DBHelper.GetInteger("SELECT Max(VendorID) FROM tblVendors")
                        Me.venID = Me.cmbVendor.SelectedValue
                    End If
                End If
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub btnCancelV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelV.Click
        Me.Close()
    End Sub

    Private Sub btnAddV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddV.Click
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Me.lblVendorLabel.Text = "Vendor:"
        Me.clearAll()
        Me.cmbVendor.SelectedIndex = -1
        Me.cmbVendor.SelectedText = ""
        Me.cmbVendor.Text = ""
        Me.venID = 0
        Me.VendorName.Focus()
        Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnPrintV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintV.Click

        Dim ds As DataSet
        Dim strsql As String = "SELECT * FROM tblVendors ORDER BY VendorName"

        Try
            ds = DBHelper.GetDataSet(strsql, "tblVendors")
            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("No matching data found. Cancelling Report..", MsgBoxStyle.Information, "Vendors List")
            Else
                Dim frmR As New frmReport
                Dim objR As New rpt_VendorsList
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
            If MsgBox("Are you sure you want to In-Activate this Vendor?", MsgBoxStyle.YesNo, "In-Activate Vendor") = MsgBoxResult.Yes Then
                If DBHelper.ExecuteQuery("UPDATE tblVendors SET Active = False WHERE VendorID = " & Me.venID & "") = True Then
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
