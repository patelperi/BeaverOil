Public Class frmLabData_L
    Inherits System.Windows.Forms.Form

    Dim jtID As Integer, isLabDataExists As Boolean = False

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
    Friend WithEvents lblReqField As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
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
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents Label103 As System.Windows.Forms.Label
    Friend WithEvents Label104 As System.Windows.Forms.Label
    Friend WithEvents Label105 As System.Windows.Forms.Label
    Friend WithEvents Label106 As System.Windows.Forms.Label
    Friend WithEvents Label107 As System.Windows.Forms.Label
    Friend WithEvents Label108 As System.Windows.Forms.Label
    Friend WithEvents Label109 As System.Windows.Forms.Label
    Friend WithEvents Label110 As System.Windows.Forms.Label
    Friend WithEvents Label111 As System.Windows.Forms.Label
    Friend WithEvents Label112 As System.Windows.Forms.Label
    Friend WithEvents Label113 As System.Windows.Forms.Label
    Friend WithEvents Label114 As System.Windows.Forms.Label
    Friend WithEvents Label118 As System.Windows.Forms.Label
    Friend WithEvents Label119 As System.Windows.Forms.Label
    Friend WithEvents Label120 As System.Windows.Forms.Label
    Friend WithEvents Label121 As System.Windows.Forms.Label
    Friend WithEvents Label122 As System.Windows.Forms.Label
    Friend WithEvents Label123 As System.Windows.Forms.Label
    Friend WithEvents Label124 As System.Windows.Forms.Label
    Friend WithEvents Label125 As System.Windows.Forms.Label
    Friend WithEvents Label115 As System.Windows.Forms.Label
    Friend WithEvents Label116 As System.Windows.Forms.Label
    Friend WithEvents Label117 As System.Windows.Forms.Label
    Friend WithEvents Label126 As System.Windows.Forms.Label
    Friend WithEvents btnCancelLD As System.Windows.Forms.Button
    Friend WithEvents btnSaveLD As System.Windows.Forms.Button
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents lblGenerator As System.Windows.Forms.Label
    Friend WithEvents lblHauler As System.Windows.Forms.Label
    Friend WithEvents lblMaterialDesc As System.Windows.Forms.Label
    Friend WithEvents lblManifest As System.Windows.Forms.Label
    Friend WithEvents lblApproval As System.Windows.Forms.Label
    Friend WithEvents lblHW As System.Windows.Forms.Label
    Friend WithEvents lblJobTicketNo As System.Windows.Forms.Label
    Friend WithEvents lblTruckNo As System.Windows.Forms.Label
    Friend WithEvents lblDriver As System.Windows.Forms.Label
    Friend WithEvents txtPumpedTo As System.Windows.Forms.TextBox
    Friend WithEvents txtGallons As System.Windows.Forms.TextBox
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents txtBSW As System.Windows.Forms.TextBox
    Friend WithEvents txtOil As System.Windows.Forms.TextBox
    Friend WithEvents txtWater As System.Windows.Forms.TextBox
    Friend WithEvents txtGravity As System.Windows.Forms.TextBox
    Friend WithEvents txtPPG As System.Windows.Forms.TextBox
    Friend WithEvents txtPhysical As System.Windows.Forms.TextBox
    Friend WithEvents txtArsenic As System.Windows.Forms.TextBox
    Friend WithEvents txtCadmium As System.Windows.Forms.TextBox
    Friend WithEvents txtChromiumT As System.Windows.Forms.TextBox
    Friend WithEvents txtChromiumH As System.Windows.Forms.TextBox
    Friend WithEvents txtZinc As System.Windows.Forms.TextBox
    Friend WithEvents txtCopper As System.Windows.Forms.TextBox
    Friend WithEvents txtCyanide As System.Windows.Forms.TextBox
    Friend WithEvents txtIron As System.Windows.Forms.TextBox
    Friend WithEvents txtNickel As System.Windows.Forms.TextBox
    Friend WithEvents txtLead As System.Windows.Forms.TextBox
    Friend WithEvents txtOils As System.Windows.Forms.TextBox
    Friend WithEvents txtChlorine As System.Windows.Forms.TextBox
    Friend WithEvents txtNitDio As System.Windows.Forms.TextBox
    Friend WithEvents txtHydSul As System.Windows.Forms.TextBox
    Friend WithEvents txtHydCya As System.Windows.Forms.TextBox
    Friend WithEvents txtPCBs As System.Windows.Forms.TextBox
    Friend WithEvents txtFlashPoint As System.Windows.Forms.TextBox
    Friend WithEvents txtPH As System.Windows.Forms.TextBox
    Friend WithEvents txtAcidTest As System.Windows.Forms.TextBox
    Friend WithEvents txtOdor As System.Windows.Forms.TextBox
    Friend WithEvents txtInitials As System.Windows.Forms.TextBox
    Friend WithEvents txtChlorineFT As System.Windows.Forms.TextBox
    Friend WithEvents txtSludge As System.Windows.Forms.TextBox
    Friend WithEvents rdnH As System.Windows.Forms.CheckBox
    Friend WithEvents rdnNH As System.Windows.Forms.CheckBox
    Friend WithEvents rdnB As System.Windows.Forms.CheckBox
    Friend WithEvents rdnD As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblReqField = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblCustomer = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblGenerator = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.lblHauler = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.lblMaterialDesc = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.lblManifest = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.lblApproval = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.lblHW = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.lblJobTicketNo = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.lblTruckNo = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.lblDriver = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.txtPumpedTo = New System.Windows.Forms.TextBox
        Me.txtGallons = New System.Windows.Forms.TextBox
        Me.txtComments = New System.Windows.Forms.TextBox
        Me.txtBSW = New System.Windows.Forms.TextBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.txtOil = New System.Windows.Forms.TextBox
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.txtWater = New System.Windows.Forms.TextBox
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.txtSludge = New System.Windows.Forms.TextBox
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.txtGravity = New System.Windows.Forms.TextBox
        Me.Label55 = New System.Windows.Forms.Label
        Me.Label56 = New System.Windows.Forms.Label
        Me.txtPPG = New System.Windows.Forms.TextBox
        Me.Label57 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.txtPhysical = New System.Windows.Forms.TextBox
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label60 = New System.Windows.Forms.Label
        Me.txtArsenic = New System.Windows.Forms.TextBox
        Me.Label61 = New System.Windows.Forms.Label
        Me.Label62 = New System.Windows.Forms.Label
        Me.txtCadmium = New System.Windows.Forms.TextBox
        Me.Label63 = New System.Windows.Forms.Label
        Me.Label64 = New System.Windows.Forms.Label
        Me.txtChromiumT = New System.Windows.Forms.TextBox
        Me.Label65 = New System.Windows.Forms.Label
        Me.Label66 = New System.Windows.Forms.Label
        Me.Label67 = New System.Windows.Forms.Label
        Me.Label68 = New System.Windows.Forms.Label
        Me.Label69 = New System.Windows.Forms.Label
        Me.Label70 = New System.Windows.Forms.Label
        Me.txtChromiumH = New System.Windows.Forms.TextBox
        Me.Label71 = New System.Windows.Forms.Label
        Me.Label72 = New System.Windows.Forms.Label
        Me.Label73 = New System.Windows.Forms.Label
        Me.txtZinc = New System.Windows.Forms.TextBox
        Me.Label74 = New System.Windows.Forms.Label
        Me.Label75 = New System.Windows.Forms.Label
        Me.Label76 = New System.Windows.Forms.Label
        Me.txtCopper = New System.Windows.Forms.TextBox
        Me.Label77 = New System.Windows.Forms.Label
        Me.Label78 = New System.Windows.Forms.Label
        Me.Label79 = New System.Windows.Forms.Label
        Me.txtCyanide = New System.Windows.Forms.TextBox
        Me.Label80 = New System.Windows.Forms.Label
        Me.Label81 = New System.Windows.Forms.Label
        Me.Label82 = New System.Windows.Forms.Label
        Me.txtIron = New System.Windows.Forms.TextBox
        Me.Label83 = New System.Windows.Forms.Label
        Me.Label84 = New System.Windows.Forms.Label
        Me.Label85 = New System.Windows.Forms.Label
        Me.txtNickel = New System.Windows.Forms.TextBox
        Me.Label86 = New System.Windows.Forms.Label
        Me.Label87 = New System.Windows.Forms.Label
        Me.Label88 = New System.Windows.Forms.Label
        Me.txtLead = New System.Windows.Forms.TextBox
        Me.Label89 = New System.Windows.Forms.Label
        Me.Label90 = New System.Windows.Forms.Label
        Me.Label91 = New System.Windows.Forms.Label
        Me.txtOils = New System.Windows.Forms.TextBox
        Me.Label92 = New System.Windows.Forms.Label
        Me.Label93 = New System.Windows.Forms.Label
        Me.Label94 = New System.Windows.Forms.Label
        Me.txtChlorine = New System.Windows.Forms.TextBox
        Me.Label95 = New System.Windows.Forms.Label
        Me.Label96 = New System.Windows.Forms.Label
        Me.Label97 = New System.Windows.Forms.Label
        Me.txtNitDio = New System.Windows.Forms.TextBox
        Me.Label98 = New System.Windows.Forms.Label
        Me.Label99 = New System.Windows.Forms.Label
        Me.Label100 = New System.Windows.Forms.Label
        Me.txtHydSul = New System.Windows.Forms.TextBox
        Me.Label101 = New System.Windows.Forms.Label
        Me.Label102 = New System.Windows.Forms.Label
        Me.Label103 = New System.Windows.Forms.Label
        Me.txtHydCya = New System.Windows.Forms.TextBox
        Me.Label104 = New System.Windows.Forms.Label
        Me.Label105 = New System.Windows.Forms.Label
        Me.Label106 = New System.Windows.Forms.Label
        Me.txtPCBs = New System.Windows.Forms.TextBox
        Me.Label107 = New System.Windows.Forms.Label
        Me.Label108 = New System.Windows.Forms.Label
        Me.Label109 = New System.Windows.Forms.Label
        Me.txtFlashPoint = New System.Windows.Forms.TextBox
        Me.Label110 = New System.Windows.Forms.Label
        Me.Label111 = New System.Windows.Forms.Label
        Me.Label112 = New System.Windows.Forms.Label
        Me.txtPH = New System.Windows.Forms.TextBox
        Me.Label113 = New System.Windows.Forms.Label
        Me.Label114 = New System.Windows.Forms.Label
        Me.Label118 = New System.Windows.Forms.Label
        Me.txtAcidTest = New System.Windows.Forms.TextBox
        Me.Label119 = New System.Windows.Forms.Label
        Me.Label120 = New System.Windows.Forms.Label
        Me.Label121 = New System.Windows.Forms.Label
        Me.txtOdor = New System.Windows.Forms.TextBox
        Me.Label122 = New System.Windows.Forms.Label
        Me.Label123 = New System.Windows.Forms.Label
        Me.txtInitials = New System.Windows.Forms.TextBox
        Me.Label124 = New System.Windows.Forms.Label
        Me.Label125 = New System.Windows.Forms.Label
        Me.Label115 = New System.Windows.Forms.Label
        Me.txtChlorineFT = New System.Windows.Forms.TextBox
        Me.Label116 = New System.Windows.Forms.Label
        Me.Label117 = New System.Windows.Forms.Label
        Me.Label126 = New System.Windows.Forms.Label
        Me.btnCancelLD = New System.Windows.Forms.Button
        Me.btnSaveLD = New System.Windows.Forms.Button
        Me.rdnH = New System.Windows.Forms.CheckBox
        Me.rdnNH = New System.Windows.Forms.CheckBox
        Me.rdnB = New System.Windows.Forms.CheckBox
        Me.rdnD = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'lblReqField
        '
        Me.lblReqField.Location = New System.Drawing.Point(0, 0)
        Me.lblReqField.Name = "lblReqField"
        Me.lblReqField.Size = New System.Drawing.Size(48, 16)
        Me.lblReqField.TabIndex = 0
        Me.lblReqField.Text = "Label1"
        Me.lblReqField.Visible = False
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BEAVER"
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(240, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "OIL CO. INC."
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "6037 LENZI AVE."
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Font = New System.Drawing.Font("Verdana", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(192, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 48)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(216, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "HODGKINS, IL 60525"
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Font = New System.Drawing.Font("Verdana", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(400, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 48)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(424, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 24)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "708/354-4040"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(232, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(168, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "LABORATORY TEST REPORT"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(16, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "DATE"
        '
        'txtDate
        '
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDate.Location = New System.Drawing.Point(120, 104)
        Me.txtDate.MaxLength = 10
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(216, 14)
        Me.txtDate.TabIndex = 1
        Me.txtDate.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "CUSTOMER"
        '
        'lblCustomer
        '
        Me.lblCustomer.Location = New System.Drawing.Point(120, 128)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(216, 16)
        Me.lblCustomer.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Location = New System.Drawing.Point(112, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(224, 1)
        Me.Label12.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(112, 144)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(224, 1)
        Me.Label13.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(16, 152)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 16)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "GENERATOR"
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Location = New System.Drawing.Point(112, 168)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(224, 1)
        Me.Label15.TabIndex = 17
        '
        'lblGenerator
        '
        Me.lblGenerator.Location = New System.Drawing.Point(120, 152)
        Me.lblGenerator.Name = "lblGenerator"
        Me.lblGenerator.Size = New System.Drawing.Size(216, 16)
        Me.lblGenerator.TabIndex = 16
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Location = New System.Drawing.Point(112, 192)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(224, 1)
        Me.Label17.TabIndex = 19
        '
        'lblHauler
        '
        Me.lblHauler.Location = New System.Drawing.Point(120, 176)
        Me.lblHauler.Name = "lblHauler"
        Me.lblHauler.Size = New System.Drawing.Size(216, 16)
        Me.lblHauler.TabIndex = 18
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Location = New System.Drawing.Point(112, 232)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(224, 1)
        Me.Label19.TabIndex = 21
        '
        'lblMaterialDesc
        '
        Me.lblMaterialDesc.Location = New System.Drawing.Point(120, 200)
        Me.lblMaterialDesc.Name = "lblMaterialDesc"
        Me.lblMaterialDesc.Size = New System.Drawing.Size(216, 32)
        Me.lblMaterialDesc.TabIndex = 20
        Me.lblMaterialDesc.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(16, 176)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 16)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "HAULER"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(16, 200)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 32)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "MATERIAL DESCRIPTION"
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(16, 264)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 16)
        Me.Label23.TabIndex = 28
        Me.Label23.Text = "MANIFEST #"
        '
        'Label24
        '
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.Location = New System.Drawing.Point(112, 280)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(224, 1)
        Me.Label24.TabIndex = 27
        '
        'lblManifest
        '
        Me.lblManifest.Location = New System.Drawing.Point(120, 264)
        Me.lblManifest.Name = "lblManifest"
        Me.lblManifest.Size = New System.Drawing.Size(208, 16)
        Me.lblManifest.TabIndex = 26
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(16, 288)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(80, 16)
        Me.Label26.TabIndex = 31
        Me.Label26.Text = "APPROVAL #"
        '
        'Label27
        '
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label27.Location = New System.Drawing.Point(112, 304)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(112, 1)
        Me.Label27.TabIndex = 30
        '
        'lblApproval
        '
        Me.lblApproval.Location = New System.Drawing.Point(120, 288)
        Me.lblApproval.Name = "lblApproval"
        Me.lblApproval.Size = New System.Drawing.Size(104, 16)
        Me.lblApproval.TabIndex = 29
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(232, 288)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(40, 16)
        Me.Label29.TabIndex = 32
        Me.Label29.Text = "HW#"
        '
        'Label30
        '
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label30.Location = New System.Drawing.Point(272, 304)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(64, 1)
        Me.Label30.TabIndex = 34
        '
        'lblHW
        '
        Me.lblHW.Location = New System.Drawing.Point(272, 288)
        Me.lblHW.Name = "lblHW"
        Me.lblHW.Size = New System.Drawing.Size(64, 16)
        Me.lblHW.TabIndex = 33
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(16, 312)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(88, 16)
        Me.Label32.TabIndex = 37
        Me.Label32.Text = "JOB TICKET #"
        '
        'Label33
        '
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label33.Location = New System.Drawing.Point(112, 328)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(224, 1)
        Me.Label33.TabIndex = 36
        '
        'lblJobTicketNo
        '
        Me.lblJobTicketNo.Location = New System.Drawing.Point(120, 312)
        Me.lblJobTicketNo.Name = "lblJobTicketNo"
        Me.lblJobTicketNo.Size = New System.Drawing.Size(216, 16)
        Me.lblJobTicketNo.TabIndex = 35
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(16, 336)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(88, 16)
        Me.Label35.TabIndex = 40
        Me.Label35.Text = "TRUCK #"
        '
        'Label36
        '
        Me.Label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label36.Location = New System.Drawing.Point(112, 352)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(224, 1)
        Me.Label36.TabIndex = 39
        '
        'lblTruckNo
        '
        Me.lblTruckNo.Location = New System.Drawing.Point(120, 336)
        Me.lblTruckNo.Name = "lblTruckNo"
        Me.lblTruckNo.Size = New System.Drawing.Size(216, 16)
        Me.lblTruckNo.TabIndex = 38
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(16, 360)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(88, 16)
        Me.Label38.TabIndex = 43
        Me.Label38.Text = "DRIVER NAME"
        '
        'Label39
        '
        Me.Label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label39.Location = New System.Drawing.Point(112, 376)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(224, 1)
        Me.Label39.TabIndex = 42
        '
        'lblDriver
        '
        Me.lblDriver.Location = New System.Drawing.Point(120, 360)
        Me.lblDriver.Name = "lblDriver"
        Me.lblDriver.Size = New System.Drawing.Size(216, 16)
        Me.lblDriver.TabIndex = 41
        '
        'Label41
        '
        Me.Label41.Location = New System.Drawing.Point(16, 384)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(88, 16)
        Me.Label41.TabIndex = 46
        Me.Label41.Text = "GALLONS"
        '
        'Label42
        '
        Me.Label42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label42.Location = New System.Drawing.Point(112, 400)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(224, 1)
        Me.Label42.TabIndex = 45
        '
        'Label44
        '
        Me.Label44.Location = New System.Drawing.Point(16, 432)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(88, 16)
        Me.Label44.TabIndex = 51
        Me.Label44.Text = "PUMPED TO"
        '
        'Label45
        '
        Me.Label45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label45.Location = New System.Drawing.Point(112, 448)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(224, 1)
        Me.Label45.TabIndex = 50
        '
        'Label47
        '
        Me.Label47.Location = New System.Drawing.Point(16, 456)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(88, 16)
        Me.Label47.TabIndex = 54
        Me.Label47.Text = "COMMENTS"
        '
        'Label48
        '
        Me.Label48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label48.Location = New System.Drawing.Point(112, 536)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(224, 1)
        Me.Label48.TabIndex = 53
        '
        'txtPumpedTo
        '
        Me.txtPumpedTo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPumpedTo.Location = New System.Drawing.Point(120, 432)
        Me.txtPumpedTo.MaxLength = 50
        Me.txtPumpedTo.Name = "txtPumpedTo"
        Me.txtPumpedTo.Size = New System.Drawing.Size(216, 14)
        Me.txtPumpedTo.TabIndex = 7
        Me.txtPumpedTo.Text = ""
        '
        'txtGallons
        '
        Me.txtGallons.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGallons.Location = New System.Drawing.Point(120, 384)
        Me.txtGallons.MaxLength = 50
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(216, 14)
        Me.txtGallons.TabIndex = 4
        Me.txtGallons.Text = ""
        '
        'txtComments
        '
        Me.txtComments.AcceptsReturn = True
        Me.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtComments.Location = New System.Drawing.Point(120, 456)
        Me.txtComments.MaxLength = 255
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(216, 80)
        Me.txtComments.TabIndex = 8
        Me.txtComments.Text = ""
        '
        'txtBSW
        '
        Me.txtBSW.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBSW.Location = New System.Drawing.Point(120, 552)
        Me.txtBSW.MaxLength = 50
        Me.txtBSW.Name = "txtBSW"
        Me.txtBSW.Size = New System.Drawing.Size(216, 14)
        Me.txtBSW.TabIndex = 9
        Me.txtBSW.Text = ""
        '
        'Label43
        '
        Me.Label43.Location = New System.Drawing.Point(8, 552)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(104, 16)
        Me.Label43.TabIndex = 59
        Me.Label43.Text = "B S && W - TOTAL"
        '
        'Label46
        '
        Me.Label46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label46.Location = New System.Drawing.Point(112, 568)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(224, 1)
        Me.Label46.TabIndex = 58
        '
        'txtOil
        '
        Me.txtOil.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOil.Location = New System.Drawing.Point(120, 576)
        Me.txtOil.MaxLength = 50
        Me.txtOil.Name = "txtOil"
        Me.txtOil.Size = New System.Drawing.Size(216, 14)
        Me.txtOil.TabIndex = 10
        Me.txtOil.Text = ""
        '
        'Label49
        '
        Me.Label49.Location = New System.Drawing.Point(40, 576)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(64, 16)
        Me.Label49.TabIndex = 62
        Me.Label49.Text = "% OIL"
        '
        'Label50
        '
        Me.Label50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label50.Location = New System.Drawing.Point(112, 592)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(224, 1)
        Me.Label50.TabIndex = 61
        '
        'txtWater
        '
        Me.txtWater.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWater.Location = New System.Drawing.Point(120, 600)
        Me.txtWater.MaxLength = 50
        Me.txtWater.Name = "txtWater"
        Me.txtWater.Size = New System.Drawing.Size(216, 14)
        Me.txtWater.TabIndex = 11
        Me.txtWater.Text = ""
        '
        'Label51
        '
        Me.Label51.Location = New System.Drawing.Point(40, 600)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(64, 16)
        Me.Label51.TabIndex = 65
        Me.Label51.Text = "% WATER"
        '
        'Label52
        '
        Me.Label52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label52.Location = New System.Drawing.Point(112, 616)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(224, 1)
        Me.Label52.TabIndex = 64
        '
        'txtSludge
        '
        Me.txtSludge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSludge.Location = New System.Drawing.Point(120, 624)
        Me.txtSludge.MaxLength = 50
        Me.txtSludge.Name = "txtSludge"
        Me.txtSludge.Size = New System.Drawing.Size(216, 14)
        Me.txtSludge.TabIndex = 12
        Me.txtSludge.Text = ""
        '
        'Label53
        '
        Me.Label53.Location = New System.Drawing.Point(40, 624)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(72, 16)
        Me.Label53.TabIndex = 68
        Me.Label53.Text = "% SLUDGE"
        '
        'Label54
        '
        Me.Label54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label54.Location = New System.Drawing.Point(112, 640)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(224, 1)
        Me.Label54.TabIndex = 67
        '
        'txtGravity
        '
        Me.txtGravity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGravity.Location = New System.Drawing.Point(120, 648)
        Me.txtGravity.MaxLength = 50
        Me.txtGravity.Name = "txtGravity"
        Me.txtGravity.Size = New System.Drawing.Size(216, 14)
        Me.txtGravity.TabIndex = 13
        Me.txtGravity.Text = ""
        '
        'Label55
        '
        Me.Label55.Location = New System.Drawing.Point(16, 648)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(88, 16)
        Me.Label55.TabIndex = 71
        Me.Label55.Text = "GRAVITY"
        '
        'Label56
        '
        Me.Label56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label56.Location = New System.Drawing.Point(112, 664)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(224, 1)
        Me.Label56.TabIndex = 70
        '
        'txtPPG
        '
        Me.txtPPG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPPG.Location = New System.Drawing.Point(120, 672)
        Me.txtPPG.MaxLength = 50
        Me.txtPPG.Name = "txtPPG"
        Me.txtPPG.Size = New System.Drawing.Size(216, 14)
        Me.txtPPG.TabIndex = 14
        Me.txtPPG.Text = ""
        '
        'Label57
        '
        Me.Label57.Location = New System.Drawing.Point(16, 672)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(88, 16)
        Me.Label57.TabIndex = 74
        Me.Label57.Text = "PPG"
        '
        'Label58
        '
        Me.Label58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label58.Location = New System.Drawing.Point(112, 688)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(224, 1)
        Me.Label58.TabIndex = 73
        '
        'txtPhysical
        '
        Me.txtPhysical.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPhysical.Location = New System.Drawing.Point(120, 704)
        Me.txtPhysical.MaxLength = 50
        Me.txtPhysical.Name = "txtPhysical"
        Me.txtPhysical.Size = New System.Drawing.Size(216, 14)
        Me.txtPhysical.TabIndex = 15
        Me.txtPhysical.Text = ""
        '
        'Label59
        '
        Me.Label59.Location = New System.Drawing.Point(16, 696)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(88, 24)
        Me.Label59.TabIndex = 77
        Me.Label59.Text = "PHYSICAL APPEARANCE"
        '
        'Label60
        '
        Me.Label60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label60.Location = New System.Drawing.Point(112, 720)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(224, 1)
        Me.Label60.TabIndex = 76
        '
        'txtArsenic
        '
        Me.txtArsenic.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtArsenic.Location = New System.Drawing.Point(480, 104)
        Me.txtArsenic.MaxLength = 50
        Me.txtArsenic.Name = "txtArsenic"
        Me.txtArsenic.Size = New System.Drawing.Size(136, 14)
        Me.txtArsenic.TabIndex = 16
        Me.txtArsenic.Text = ""
        '
        'Label61
        '
        Me.Label61.Location = New System.Drawing.Point(392, 104)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(64, 16)
        Me.Label61.TabIndex = 80
        Me.Label61.Text = "ARSENIC"
        '
        'Label62
        '
        Me.Label62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label62.Location = New System.Drawing.Point(472, 120)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(144, 1)
        Me.Label62.TabIndex = 79
        '
        'txtCadmium
        '
        Me.txtCadmium.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCadmium.Location = New System.Drawing.Point(480, 128)
        Me.txtCadmium.MaxLength = 50
        Me.txtCadmium.Name = "txtCadmium"
        Me.txtCadmium.Size = New System.Drawing.Size(136, 14)
        Me.txtCadmium.TabIndex = 17
        Me.txtCadmium.Text = ""
        '
        'Label63
        '
        Me.Label63.Location = New System.Drawing.Point(392, 128)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(64, 16)
        Me.Label63.TabIndex = 83
        Me.Label63.Text = "CADMIUM"
        '
        'Label64
        '
        Me.Label64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label64.Location = New System.Drawing.Point(472, 144)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(144, 1)
        Me.Label64.TabIndex = 82
        '
        'txtChromiumT
        '
        Me.txtChromiumT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtChromiumT.Location = New System.Drawing.Point(480, 160)
        Me.txtChromiumT.MaxLength = 50
        Me.txtChromiumT.Name = "txtChromiumT"
        Me.txtChromiumT.Size = New System.Drawing.Size(136, 14)
        Me.txtChromiumT.TabIndex = 18
        Me.txtChromiumT.Text = ""
        '
        'Label65
        '
        Me.Label65.Location = New System.Drawing.Point(392, 152)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(72, 32)
        Me.Label65.TabIndex = 86
        Me.Label65.Text = "CHROMIUM (TOTAL)"
        '
        'Label66
        '
        Me.Label66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label66.Location = New System.Drawing.Point(472, 176)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(144, 1)
        Me.Label66.TabIndex = 85
        '
        'Label67
        '
        Me.Label67.Location = New System.Drawing.Point(616, 104)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(32, 16)
        Me.Label67.TabIndex = 88
        Me.Label67.Text = "ppm"
        '
        'Label68
        '
        Me.Label68.Location = New System.Drawing.Point(616, 128)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(32, 16)
        Me.Label68.TabIndex = 89
        Me.Label68.Text = "ppm"
        '
        'Label69
        '
        Me.Label69.Location = New System.Drawing.Point(616, 160)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(32, 16)
        Me.Label69.TabIndex = 90
        Me.Label69.Text = "ppm"
        '
        'Label70
        '
        Me.Label70.Location = New System.Drawing.Point(616, 192)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(32, 16)
        Me.Label70.TabIndex = 94
        Me.Label70.Text = "ppm"
        '
        'txtChromiumH
        '
        Me.txtChromiumH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtChromiumH.Location = New System.Drawing.Point(480, 192)
        Me.txtChromiumH.MaxLength = 50
        Me.txtChromiumH.Name = "txtChromiumH"
        Me.txtChromiumH.Size = New System.Drawing.Size(136, 14)
        Me.txtChromiumH.TabIndex = 19
        Me.txtChromiumH.Text = ""
        '
        'Label71
        '
        Me.Label71.Location = New System.Drawing.Point(392, 184)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(72, 32)
        Me.Label71.TabIndex = 92
        Me.Label71.Text = "CHROMIUM (HEX)"
        '
        'Label72
        '
        Me.Label72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label72.Location = New System.Drawing.Point(472, 208)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(144, 1)
        Me.Label72.TabIndex = 91
        '
        'Label73
        '
        Me.Label73.Location = New System.Drawing.Point(616, 336)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(32, 16)
        Me.Label73.TabIndex = 98
        Me.Label73.Text = "ppm"
        '
        'txtZinc
        '
        Me.txtZinc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtZinc.Location = New System.Drawing.Point(480, 336)
        Me.txtZinc.MaxLength = 50
        Me.txtZinc.Name = "txtZinc"
        Me.txtZinc.Size = New System.Drawing.Size(136, 14)
        Me.txtZinc.TabIndex = 25
        Me.txtZinc.Text = ""
        '
        'Label74
        '
        Me.Label74.Location = New System.Drawing.Point(392, 336)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(64, 16)
        Me.Label74.TabIndex = 96
        Me.Label74.Text = "ZINC"
        '
        'Label75
        '
        Me.Label75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label75.Location = New System.Drawing.Point(472, 352)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(144, 1)
        Me.Label75.TabIndex = 95
        '
        'Label76
        '
        Me.Label76.Location = New System.Drawing.Point(616, 216)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(32, 16)
        Me.Label76.TabIndex = 102
        Me.Label76.Text = "ppm"
        '
        'txtCopper
        '
        Me.txtCopper.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCopper.Location = New System.Drawing.Point(480, 216)
        Me.txtCopper.MaxLength = 50
        Me.txtCopper.Name = "txtCopper"
        Me.txtCopper.Size = New System.Drawing.Size(136, 14)
        Me.txtCopper.TabIndex = 20
        Me.txtCopper.Text = ""
        '
        'Label77
        '
        Me.Label77.Location = New System.Drawing.Point(392, 216)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(64, 16)
        Me.Label77.TabIndex = 100
        Me.Label77.Text = "COPPER"
        '
        'Label78
        '
        Me.Label78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label78.Location = New System.Drawing.Point(472, 232)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(144, 1)
        Me.Label78.TabIndex = 99
        '
        'Label79
        '
        Me.Label79.Location = New System.Drawing.Point(616, 240)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(32, 16)
        Me.Label79.TabIndex = 106
        Me.Label79.Text = "ppm"
        '
        'txtCyanide
        '
        Me.txtCyanide.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCyanide.Location = New System.Drawing.Point(480, 240)
        Me.txtCyanide.MaxLength = 50
        Me.txtCyanide.Name = "txtCyanide"
        Me.txtCyanide.Size = New System.Drawing.Size(136, 14)
        Me.txtCyanide.TabIndex = 21
        Me.txtCyanide.Text = ""
        '
        'Label80
        '
        Me.Label80.Location = New System.Drawing.Point(392, 240)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(64, 16)
        Me.Label80.TabIndex = 104
        Me.Label80.Text = "CYANIDE"
        '
        'Label81
        '
        Me.Label81.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label81.Location = New System.Drawing.Point(472, 256)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(144, 1)
        Me.Label81.TabIndex = 103
        '
        'Label82
        '
        Me.Label82.Location = New System.Drawing.Point(616, 264)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(32, 16)
        Me.Label82.TabIndex = 110
        Me.Label82.Text = "ppm"
        '
        'txtIron
        '
        Me.txtIron.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIron.Location = New System.Drawing.Point(480, 264)
        Me.txtIron.MaxLength = 50
        Me.txtIron.Name = "txtIron"
        Me.txtIron.Size = New System.Drawing.Size(136, 14)
        Me.txtIron.TabIndex = 22
        Me.txtIron.Text = ""
        '
        'Label83
        '
        Me.Label83.Location = New System.Drawing.Point(392, 264)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(64, 16)
        Me.Label83.TabIndex = 108
        Me.Label83.Text = "IRON"
        '
        'Label84
        '
        Me.Label84.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label84.Location = New System.Drawing.Point(472, 280)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(144, 1)
        Me.Label84.TabIndex = 107
        '
        'Label85
        '
        Me.Label85.Location = New System.Drawing.Point(616, 288)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(32, 16)
        Me.Label85.TabIndex = 114
        Me.Label85.Text = "ppm"
        '
        'txtNickel
        '
        Me.txtNickel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNickel.Location = New System.Drawing.Point(480, 288)
        Me.txtNickel.MaxLength = 50
        Me.txtNickel.Name = "txtNickel"
        Me.txtNickel.Size = New System.Drawing.Size(136, 14)
        Me.txtNickel.TabIndex = 23
        Me.txtNickel.Text = ""
        '
        'Label86
        '
        Me.Label86.Location = New System.Drawing.Point(392, 288)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(64, 16)
        Me.Label86.TabIndex = 112
        Me.Label86.Text = "NICKEL"
        '
        'Label87
        '
        Me.Label87.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label87.Location = New System.Drawing.Point(472, 304)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(144, 1)
        Me.Label87.TabIndex = 111
        '
        'Label88
        '
        Me.Label88.Location = New System.Drawing.Point(616, 312)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(32, 16)
        Me.Label88.TabIndex = 118
        Me.Label88.Text = "ppm"
        '
        'txtLead
        '
        Me.txtLead.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLead.Location = New System.Drawing.Point(480, 312)
        Me.txtLead.MaxLength = 50
        Me.txtLead.Name = "txtLead"
        Me.txtLead.Size = New System.Drawing.Size(136, 14)
        Me.txtLead.TabIndex = 24
        Me.txtLead.Text = ""
        '
        'Label89
        '
        Me.Label89.Location = New System.Drawing.Point(392, 312)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(64, 16)
        Me.Label89.TabIndex = 116
        Me.Label89.Text = "LEAD"
        '
        'Label90
        '
        Me.Label90.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label90.Location = New System.Drawing.Point(472, 328)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(144, 1)
        Me.Label90.TabIndex = 115
        '
        'Label91
        '
        Me.Label91.Location = New System.Drawing.Point(616, 360)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(32, 16)
        Me.Label91.TabIndex = 122
        Me.Label91.Text = "ppm"
        '
        'txtOils
        '
        Me.txtOils.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOils.Location = New System.Drawing.Point(480, 360)
        Me.txtOils.MaxLength = 50
        Me.txtOils.Name = "txtOils"
        Me.txtOils.Size = New System.Drawing.Size(136, 14)
        Me.txtOils.TabIndex = 26
        Me.txtOils.Text = ""
        '
        'Label92
        '
        Me.Label92.Location = New System.Drawing.Point(392, 360)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(64, 16)
        Me.Label92.TabIndex = 120
        Me.Label92.Text = "OILS"
        '
        'Label93
        '
        Me.Label93.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label93.Location = New System.Drawing.Point(472, 376)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(144, 1)
        Me.Label93.TabIndex = 119
        '
        'Label94
        '
        Me.Label94.Location = New System.Drawing.Point(616, 384)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(32, 16)
        Me.Label94.TabIndex = 126
        Me.Label94.Text = "ppm"
        '
        'txtChlorine
        '
        Me.txtChlorine.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtChlorine.Location = New System.Drawing.Point(480, 384)
        Me.txtChlorine.MaxLength = 50
        Me.txtChlorine.Name = "txtChlorine"
        Me.txtChlorine.Size = New System.Drawing.Size(136, 14)
        Me.txtChlorine.TabIndex = 27
        Me.txtChlorine.Text = ""
        '
        'Label95
        '
        Me.Label95.Location = New System.Drawing.Point(392, 384)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(64, 16)
        Me.Label95.TabIndex = 124
        Me.Label95.Text = "CHLORINE"
        '
        'Label96
        '
        Me.Label96.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label96.Location = New System.Drawing.Point(472, 400)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(144, 1)
        Me.Label96.TabIndex = 123
        '
        'Label97
        '
        Me.Label97.Location = New System.Drawing.Point(616, 416)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(32, 16)
        Me.Label97.TabIndex = 130
        Me.Label97.Text = "ppm"
        '
        'txtNitDio
        '
        Me.txtNitDio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNitDio.Location = New System.Drawing.Point(480, 416)
        Me.txtNitDio.MaxLength = 50
        Me.txtNitDio.Name = "txtNitDio"
        Me.txtNitDio.Size = New System.Drawing.Size(136, 14)
        Me.txtNitDio.TabIndex = 28
        Me.txtNitDio.Text = ""
        '
        'Label98
        '
        Me.Label98.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.Location = New System.Drawing.Point(352, 416)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(104, 16)
        Me.Label98.TabIndex = 128
        Me.Label98.Text = "NITROGEN DIOXIDE"
        '
        'Label99
        '
        Me.Label99.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label99.Location = New System.Drawing.Point(472, 432)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(144, 1)
        Me.Label99.TabIndex = 127
        '
        'Label100
        '
        Me.Label100.Location = New System.Drawing.Point(616, 440)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(32, 16)
        Me.Label100.TabIndex = 134
        Me.Label100.Text = "ppm"
        '
        'txtHydSul
        '
        Me.txtHydSul.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHydSul.Location = New System.Drawing.Point(480, 440)
        Me.txtHydSul.MaxLength = 50
        Me.txtHydSul.Name = "txtHydSul"
        Me.txtHydSul.Size = New System.Drawing.Size(136, 14)
        Me.txtHydSul.TabIndex = 29
        Me.txtHydSul.Text = ""
        '
        'Label101
        '
        Me.Label101.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.Location = New System.Drawing.Point(352, 440)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(112, 16)
        Me.Label101.TabIndex = 132
        Me.Label101.Text = "HYDROGEN SULPHIDE"
        '
        'Label102
        '
        Me.Label102.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label102.Location = New System.Drawing.Point(472, 456)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(144, 1)
        Me.Label102.TabIndex = 131
        '
        'Label103
        '
        Me.Label103.Location = New System.Drawing.Point(616, 464)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(32, 16)
        Me.Label103.TabIndex = 138
        Me.Label103.Text = "ppm"
        '
        'txtHydCya
        '
        Me.txtHydCya.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHydCya.Location = New System.Drawing.Point(480, 464)
        Me.txtHydCya.MaxLength = 50
        Me.txtHydCya.Name = "txtHydCya"
        Me.txtHydCya.Size = New System.Drawing.Size(136, 14)
        Me.txtHydCya.TabIndex = 30
        Me.txtHydCya.Text = ""
        '
        'Label104
        '
        Me.Label104.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label104.Location = New System.Drawing.Point(352, 464)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(112, 16)
        Me.Label104.TabIndex = 136
        Me.Label104.Text = "HYDROGEN CYANIDE"
        '
        'Label105
        '
        Me.Label105.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label105.Location = New System.Drawing.Point(472, 480)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(144, 1)
        Me.Label105.TabIndex = 135
        '
        'Label106
        '
        Me.Label106.Location = New System.Drawing.Point(616, 488)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(32, 16)
        Me.Label106.TabIndex = 142
        Me.Label106.Text = "ppm"
        '
        'txtPCBs
        '
        Me.txtPCBs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPCBs.Location = New System.Drawing.Point(480, 488)
        Me.txtPCBs.MaxLength = 50
        Me.txtPCBs.Name = "txtPCBs"
        Me.txtPCBs.Size = New System.Drawing.Size(136, 14)
        Me.txtPCBs.TabIndex = 31
        Me.txtPCBs.Text = ""
        '
        'Label107
        '
        Me.Label107.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label107.Location = New System.Drawing.Point(360, 488)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(104, 16)
        Me.Label107.TabIndex = 140
        Me.Label107.Text = "PCB'S"
        '
        'Label108
        '
        Me.Label108.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label108.Location = New System.Drawing.Point(472, 504)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(144, 1)
        Me.Label108.TabIndex = 139
        '
        'Label109
        '
        Me.Label109.Location = New System.Drawing.Point(616, 512)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(32, 16)
        Me.Label109.TabIndex = 146
        Me.Label109.Text = "ppm"
        '
        'txtFlashPoint
        '
        Me.txtFlashPoint.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFlashPoint.Location = New System.Drawing.Point(480, 512)
        Me.txtFlashPoint.MaxLength = 50
        Me.txtFlashPoint.Name = "txtFlashPoint"
        Me.txtFlashPoint.Size = New System.Drawing.Size(136, 14)
        Me.txtFlashPoint.TabIndex = 32
        Me.txtFlashPoint.Text = ""
        '
        'Label110
        '
        Me.Label110.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label110.Location = New System.Drawing.Point(360, 512)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(104, 16)
        Me.Label110.TabIndex = 144
        Me.Label110.Text = "FLASH POINT"
        '
        'Label111
        '
        Me.Label111.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label111.Location = New System.Drawing.Point(472, 528)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(144, 1)
        Me.Label111.TabIndex = 143
        '
        'Label112
        '
        Me.Label112.Location = New System.Drawing.Point(616, 536)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(32, 16)
        Me.Label112.TabIndex = 150
        Me.Label112.Text = "ppm"
        '
        'txtPH
        '
        Me.txtPH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPH.Location = New System.Drawing.Point(480, 536)
        Me.txtPH.MaxLength = 50
        Me.txtPH.Name = "txtPH"
        Me.txtPH.Size = New System.Drawing.Size(136, 14)
        Me.txtPH.TabIndex = 33
        Me.txtPH.Text = ""
        '
        'Label113
        '
        Me.Label113.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label113.Location = New System.Drawing.Point(360, 536)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(104, 16)
        Me.Label113.TabIndex = 148
        Me.Label113.Text = "P   H   "
        '
        'Label114
        '
        Me.Label114.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label114.Location = New System.Drawing.Point(472, 552)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(144, 1)
        Me.Label114.TabIndex = 147
        '
        'Label118
        '
        Me.Label118.Location = New System.Drawing.Point(616, 624)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(32, 16)
        Me.Label118.TabIndex = 158
        Me.Label118.Text = "ppm"
        '
        'txtAcidTest
        '
        Me.txtAcidTest.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAcidTest.Location = New System.Drawing.Point(448, 624)
        Me.txtAcidTest.MaxLength = 50
        Me.txtAcidTest.Name = "txtAcidTest"
        Me.txtAcidTest.Size = New System.Drawing.Size(168, 14)
        Me.txtAcidTest.TabIndex = 35
        Me.txtAcidTest.Text = ""
        '
        'Label119
        '
        Me.Label119.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label119.Location = New System.Drawing.Point(360, 616)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(64, 24)
        Me.Label119.TabIndex = 156
        Me.Label119.Text = "ACID TEST REACTION"
        '
        'Label120
        '
        Me.Label120.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label120.Location = New System.Drawing.Point(440, 640)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(176, 1)
        Me.Label120.TabIndex = 155
        '
        'Label121
        '
        Me.Label121.Location = New System.Drawing.Point(616, 648)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(32, 16)
        Me.Label121.TabIndex = 162
        Me.Label121.Text = "ppm"
        '
        'txtOdor
        '
        Me.txtOdor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOdor.Location = New System.Drawing.Point(448, 648)
        Me.txtOdor.MaxLength = 50
        Me.txtOdor.Name = "txtOdor"
        Me.txtOdor.Size = New System.Drawing.Size(168, 14)
        Me.txtOdor.TabIndex = 36
        Me.txtOdor.Text = ""
        '
        'Label122
        '
        Me.Label122.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label122.Location = New System.Drawing.Point(360, 648)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(64, 16)
        Me.Label122.TabIndex = 160
        Me.Label122.Text = "ODOR"
        '
        'Label123
        '
        Me.Label123.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label123.Location = New System.Drawing.Point(440, 664)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(176, 1)
        Me.Label123.TabIndex = 159
        '
        'txtInitials
        '
        Me.txtInitials.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInitials.Location = New System.Drawing.Point(392, 704)
        Me.txtInitials.MaxLength = 50
        Me.txtInitials.Name = "txtInitials"
        Me.txtInitials.Size = New System.Drawing.Size(224, 14)
        Me.txtInitials.TabIndex = 37
        Me.txtInitials.Text = ""
        '
        'Label124
        '
        Me.Label124.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label124.Location = New System.Drawing.Point(384, 720)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(232, 1)
        Me.Label124.TabIndex = 163
        '
        'Label125
        '
        Me.Label125.Location = New System.Drawing.Point(424, 728)
        Me.Label125.Name = "Label125"
        Me.Label125.Size = New System.Drawing.Size(184, 16)
        Me.Label125.TabIndex = 165
        Me.Label125.Text = "LAB TECHNICIAN INITIALS"
        '
        'Label115
        '
        Me.Label115.BackColor = System.Drawing.Color.White
        Me.Label115.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label115.Location = New System.Drawing.Point(616, 576)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(32, 16)
        Me.Label115.TabIndex = 154
        Me.Label115.Text = "ppm"
        '
        'txtChlorineFT
        '
        Me.txtChlorineFT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtChlorineFT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChlorineFT.Location = New System.Drawing.Point(456, 576)
        Me.txtChlorineFT.MaxLength = 50
        Me.txtChlorineFT.Name = "txtChlorineFT"
        Me.txtChlorineFT.Size = New System.Drawing.Size(160, 14)
        Me.txtChlorineFT.TabIndex = 34
        Me.txtChlorineFT.Text = ""
        '
        'Label116
        '
        Me.Label116.BackColor = System.Drawing.Color.White
        Me.Label116.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label116.Location = New System.Drawing.Point(360, 568)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(72, 24)
        Me.Label116.TabIndex = 152
        Me.Label116.Text = "CHLORINE FLAME TEST"
        '
        'Label117
        '
        Me.Label117.BackColor = System.Drawing.Color.White
        Me.Label117.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label117.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label117.Location = New System.Drawing.Point(448, 592)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(168, 1)
        Me.Label117.TabIndex = 151
        '
        'Label126
        '
        Me.Label126.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label126.Location = New System.Drawing.Point(16, 768)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(624, 16)
        Me.Label126.TabIndex = 166
        Me.Label126.Text = "SPECIALISTS IN THE TREATMENT/RECYCLING OF WASTE WATER, COOLANT AND OILs"
        '
        'btnCancelLD
        '
        Me.btnCancelLD.BackColor = System.Drawing.Color.SlateGray
        Me.btnCancelLD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelLD.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelLD.Location = New System.Drawing.Point(336, 792)
        Me.btnCancelLD.Name = "btnCancelLD"
        Me.btnCancelLD.Size = New System.Drawing.Size(112, 24)
        Me.btnCancelLD.TabIndex = 39
        Me.btnCancelLD.Text = "Cancel"
        '
        'btnSaveLD
        '
        Me.btnSaveLD.BackColor = System.Drawing.Color.SlateGray
        Me.btnSaveLD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveLD.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveLD.Location = New System.Drawing.Point(208, 792)
        Me.btnSaveLD.Name = "btnSaveLD"
        Me.btnSaveLD.Size = New System.Drawing.Size(112, 24)
        Me.btnSaveLD.TabIndex = 38
        Me.btnSaveLD.Text = "Save && Close"
        '
        'rdnH
        '
        Me.rdnH.Location = New System.Drawing.Point(16, 240)
        Me.rdnH.Name = "rdnH"
        Me.rdnH.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rdnH.Size = New System.Drawing.Size(104, 16)
        Me.rdnH.TabIndex = 2
        Me.rdnH.Text = "HAZARDOUS"
        Me.rdnH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rdnNH
        '
        Me.rdnNH.Location = New System.Drawing.Point(128, 240)
        Me.rdnNH.Name = "rdnNH"
        Me.rdnNH.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rdnNH.Size = New System.Drawing.Size(128, 16)
        Me.rdnNH.TabIndex = 3
        Me.rdnNH.Text = "NON-HAZARDOUS"
        Me.rdnNH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rdnB
        '
        Me.rdnB.Location = New System.Drawing.Point(16, 408)
        Me.rdnB.Name = "rdnB"
        Me.rdnB.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rdnB.Size = New System.Drawing.Size(56, 16)
        Me.rdnB.TabIndex = 5
        Me.rdnB.Text = "BULK"
        Me.rdnB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rdnD
        '
        Me.rdnD.Location = New System.Drawing.Point(80, 408)
        Me.rdnD.Name = "rdnD"
        Me.rdnD.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rdnD.Size = New System.Drawing.Size(72, 16)
        Me.rdnD.TabIndex = 6
        Me.rdnD.Text = "DRUMS"
        Me.rdnD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmLabData_L
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(680, 517)
        Me.Controls.Add(Me.rdnD)
        Me.Controls.Add(Me.rdnB)
        Me.Controls.Add(Me.rdnNH)
        Me.Controls.Add(Me.rdnH)
        Me.Controls.Add(Me.btnCancelLD)
        Me.Controls.Add(Me.btnSaveLD)
        Me.Controls.Add(Me.Label126)
        Me.Controls.Add(Me.Label125)
        Me.Controls.Add(Me.txtInitials)
        Me.Controls.Add(Me.txtOdor)
        Me.Controls.Add(Me.txtAcidTest)
        Me.Controls.Add(Me.txtChlorineFT)
        Me.Controls.Add(Me.txtPH)
        Me.Controls.Add(Me.txtFlashPoint)
        Me.Controls.Add(Me.txtPCBs)
        Me.Controls.Add(Me.txtHydCya)
        Me.Controls.Add(Me.txtHydSul)
        Me.Controls.Add(Me.txtNitDio)
        Me.Controls.Add(Me.txtChlorine)
        Me.Controls.Add(Me.txtOils)
        Me.Controls.Add(Me.txtLead)
        Me.Controls.Add(Me.txtNickel)
        Me.Controls.Add(Me.txtIron)
        Me.Controls.Add(Me.txtCyanide)
        Me.Controls.Add(Me.txtCopper)
        Me.Controls.Add(Me.txtZinc)
        Me.Controls.Add(Me.txtChromiumH)
        Me.Controls.Add(Me.txtChromiumT)
        Me.Controls.Add(Me.txtCadmium)
        Me.Controls.Add(Me.txtArsenic)
        Me.Controls.Add(Me.txtPhysical)
        Me.Controls.Add(Me.txtPPG)
        Me.Controls.Add(Me.txtGravity)
        Me.Controls.Add(Me.txtSludge)
        Me.Controls.Add(Me.txtWater)
        Me.Controls.Add(Me.txtOil)
        Me.Controls.Add(Me.txtBSW)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.txtGallons)
        Me.Controls.Add(Me.txtPumpedTo)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label124)
        Me.Controls.Add(Me.Label121)
        Me.Controls.Add(Me.Label122)
        Me.Controls.Add(Me.Label123)
        Me.Controls.Add(Me.Label118)
        Me.Controls.Add(Me.Label119)
        Me.Controls.Add(Me.Label120)
        Me.Controls.Add(Me.Label115)
        Me.Controls.Add(Me.Label116)
        Me.Controls.Add(Me.Label117)
        Me.Controls.Add(Me.Label112)
        Me.Controls.Add(Me.Label113)
        Me.Controls.Add(Me.Label114)
        Me.Controls.Add(Me.Label109)
        Me.Controls.Add(Me.Label110)
        Me.Controls.Add(Me.Label111)
        Me.Controls.Add(Me.Label106)
        Me.Controls.Add(Me.Label107)
        Me.Controls.Add(Me.Label108)
        Me.Controls.Add(Me.Label103)
        Me.Controls.Add(Me.Label104)
        Me.Controls.Add(Me.Label105)
        Me.Controls.Add(Me.Label100)
        Me.Controls.Add(Me.Label101)
        Me.Controls.Add(Me.Label102)
        Me.Controls.Add(Me.Label97)
        Me.Controls.Add(Me.Label98)
        Me.Controls.Add(Me.Label99)
        Me.Controls.Add(Me.Label94)
        Me.Controls.Add(Me.Label95)
        Me.Controls.Add(Me.Label96)
        Me.Controls.Add(Me.Label91)
        Me.Controls.Add(Me.Label92)
        Me.Controls.Add(Me.Label93)
        Me.Controls.Add(Me.Label88)
        Me.Controls.Add(Me.Label89)
        Me.Controls.Add(Me.Label90)
        Me.Controls.Add(Me.Label85)
        Me.Controls.Add(Me.Label86)
        Me.Controls.Add(Me.Label87)
        Me.Controls.Add(Me.Label82)
        Me.Controls.Add(Me.Label83)
        Me.Controls.Add(Me.Label84)
        Me.Controls.Add(Me.Label79)
        Me.Controls.Add(Me.Label80)
        Me.Controls.Add(Me.Label81)
        Me.Controls.Add(Me.Label76)
        Me.Controls.Add(Me.Label77)
        Me.Controls.Add(Me.Label78)
        Me.Controls.Add(Me.Label73)
        Me.Controls.Add(Me.Label74)
        Me.Controls.Add(Me.Label75)
        Me.Controls.Add(Me.Label70)
        Me.Controls.Add(Me.Label71)
        Me.Controls.Add(Me.Label72)
        Me.Controls.Add(Me.Label69)
        Me.Controls.Add(Me.Label68)
        Me.Controls.Add(Me.Label67)
        Me.Controls.Add(Me.Label65)
        Me.Controls.Add(Me.Label66)
        Me.Controls.Add(Me.Label63)
        Me.Controls.Add(Me.Label64)
        Me.Controls.Add(Me.Label61)
        Me.Controls.Add(Me.Label62)
        Me.Controls.Add(Me.Label59)
        Me.Controls.Add(Me.Label60)
        Me.Controls.Add(Me.Label57)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.lblDriver)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.lblTruckNo)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.lblJobTicketNo)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.lblHW)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.lblApproval)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.lblManifest)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lblMaterialDesc)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblHauler)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblGenerator)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblReqField)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmLabData_L"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLabData_L"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmLabData_L_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        jtID = DBHelper.GetInteger("SELECT JobTicketID FROM tblJobTickets WHERE JobTicketNo = " & Replace(Me.lblReqField.Text, "'", "''") & "")
        If jtID > 0 Then
            If DBHelper.GetRecordCount("SELECT Count(*) FROM tblLabData WHERE JobTicketID = " & Me.jtID & "") > 0 Then
                Me.isLabDataExists = True
            Else
                Me.isLabDataExists = False
            End If
            Me.populateLabData()
        Else
            MsgBox("Job Ticket not found. Cannot continue", MsgBoxStyle.Information, "Invalid Job Ticket")
            Me.Close()
        End If

    End Sub

    Private Sub rdnB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.rdnD.Checked = Not Me.rdnB.Checked

    End Sub

    Private Sub rdnD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.rdnB.Checked = Not Me.rdnD.Checked

    End Sub

    Private Sub rdnH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.rdnNH.Checked = Not Me.rdnH.Checked

    End Sub

    Private Sub rdnNH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.rdnH.Checked = Not Me.rdnNH.Checked

    End Sub

    Function populateLabData()

        'Load Job Ticket Data
        Dim strSQL As String = ""

        strSQL = "SELECT tblJobTickets.JobTicketID, tblGenerators.GeneratorName, tblGenerators.JobSite, tblTransporters.TransporterName, tblProducts.ProductName, tblJobTickets.ManifestNo, tblJobTickets.ApprovalNo, tblJobTickets.RefNo, tblJobTickets.JobTicketNo, tblJobTickets.TruckNo, tblJobTickets.DriverName FROM (tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN (tblTransporters INNER JOIN tblJobTickets ON tblTransporters.TransporterID = tblJobTickets.TransporterID) ON tblProducts.ProductID = tblJobTickets.ProductID WHERE tblJobTickets.JobTicketID = " & Me.jtID
        Dim ds As DataSet = DBHelper.GetDataSet(strSQL, "tblJobTickets")
        Try
            If ds.Tables(0).Rows.Count > 0 Then
                Dim dtRow As DataRow = ds.Tables(0).Rows(0)
                Me.lblCustomer.Text = dtRow.Item("GeneratorName")
                Me.lblGenerator.Text = dtRow.Item("JobSite")
                Me.lblHauler.Text = dtRow.Item("TransporterName")
                Me.lblMaterialDesc.Text = dtRow.Item("ProductName")
                Me.lblManifest.Text = IIf(IsDBNull(dtRow.Item("ManifestNo")), "", dtRow.Item("ManifestNo"))
                Me.lblApproval.Text = IIf(IsDBNull(dtRow.Item("ApprovalNo")), "", dtRow.Item("ApprovalNo"))
                Me.lblHW.Text = IIf(IsDBNull(dtRow.Item("RefNo")), "", dtRow.Item("RefNo"))
                Me.lblJobTicketNo.Text = dtRow.Item("JobTicketNo")
                Me.lblTruckNo.Text = IIf(IsDBNull(dtRow.Item("TruckNo")), "", dtRow.Item("TruckNo"))
                Me.lblDriver.Text = IIf(IsDBNull(dtRow.Item("DriverName")), "", dtRow.Item("DriverName"))
            Else
                MsgBox("Cannot find matching records for this Job Ticket.", MsgBoxStyle.Information, "Missing Info")
                Exit Function
            End If
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Exit Function
        Finally
            ds = Nothing
        End Try

        'Check to see if LabData has already been created and it is being viewed or edited
        If Me.isLabDataExists = True Then
            strSQL = "SELECT * FROM tblLabData WHERE JobTicketID = " & Me.jtID
            Dim ds1 As DataSet = DBHelper.GetDataSet(strSQL, "tblLabData")
            Try
                If ds1.Tables(0).Rows.Count > 0 Then
                    Dim dtRow1 As DataRow = ds1.Tables(0).Rows(0)
                    Me.txtDate.Text = dtRow1.Item("LabDataDate")
                    If dtRow1.Item("IsHaz_NonHaz") > 0 Then
                        If dtRow1.Item("IsHaz_NonHaz") = 1 Then
                            Me.rdnH.Checked = True
                            Me.rdnNH.Checked = False
                        Else
                            Me.rdnNH.Checked = True
                            Me.rdnH.Checked = False
                        End If
                    End If
                    If dtRow1.Item("Bulk_Drums") > 0 Then
                        If dtRow1.Item("Bulk_Drums") = 1 Then
                            Me.rdnB.Checked = True
                            Me.rdnD.Checked = False
                        Else
                            Me.rdnD.Checked = True
                            Me.rdnB.Checked = False
                        End If
                    End If
                    Me.txtGallons.Text = dtRow1.Item("Gallons")
                    Me.txtPumpedTo.Text = dtRow1.Item("PumpedTo")
                    Me.txtComments.Text = dtRow1.Item("Comments")
                    Me.txtBSW.Text = dtRow1.Item("BS_W_Total")
                    Me.txtOil.Text = dtRow1.Item("BSW_Oil")
                    Me.txtWater.Text = dtRow1.Item("BSW_Water")
                    Me.txtSludge.Text = dtRow1.Item("BSW_Sludge")
                    Me.txtGravity.Text = dtRow1.Item("Gravity")
                    Me.txtPPG.Text = dtRow1.Item("PPG")
                    Me.txtPhysical.Text = dtRow1.Item("Physical_Appearance")
                    Me.txtArsenic.Text = dtRow1.Item("Arsenic")
                    Me.txtCadmium.Text = dtRow1.Item("Cadmium")
                    Me.txtChromiumT.Text = dtRow1.Item("Chromium_Total")
                    Me.txtChromiumH.Text = dtRow1.Item("Chromium_Hex")
                    Me.txtCopper.Text = dtRow1.Item("Copper")
                    Me.txtNickel.Text = dtRow1.Item("Nickel")
                    Me.txtCyanide.Text = dtRow1.Item("Cyanide")
                    Me.txtIron.Text = dtRow1.Item("Iron")
                    Me.txtZinc.Text = dtRow1.Item("Zinc")
                    Me.txtLead.Text = dtRow1.Item("Lead")
                    Me.txtOils.Text = dtRow1.Item("Oils")
                    Me.txtChlorine.Text = dtRow1.Item("Chlorine")
                    Me.txtNitDio.Text = dtRow1.Item("Nitrogen_Dioxide")
                    Me.txtHydCya.Text = dtRow1.Item("Hydrogen_Cyanide")
                    Me.txtHydSul.Text = dtRow1.Item("Hydrogen_Sulphide")
                    Me.txtPCBs.Text = dtRow1.Item("PCBs")
                    Me.txtFlashPoint.Text = dtRow1.Item("Flash_Point")
                    Me.txtPH.Text = dtRow1.Item("PH")
                    Me.txtChlorineFT.Text = dtRow1.Item("Chlorine_Flame_Test")
                    Me.txtAcidTest.Text = dtRow1.Item("Acid_Test_Reaction")
                    Me.txtOdor.Text = dtRow1.Item("Odor")
                    Me.txtInitials.Text = dtRow1.Item("LabTechnicianI")
                    dtRow1 = Nothing
                Else
                    MsgBox("Cannot find matching Lab Data records for this Job Ticket.", MsgBoxStyle.Information, "Missing Info")
                    Exit Function
                End If
            Catch ex As SystemException
                MsgBox("Cannot find matching Lab Data records for this Job Ticket.", MsgBoxStyle.Information, "Missing Info")
                Exit Function
            Finally
                ds1 = Nothing
            End Try

        End If

    End Function

    Function saveLabData()

        If Me.txtDate.Text = "" Then
            MsgBox("Missing Lab Date. Please enter the Lab Date.", MsgBoxStyle.Information, "Lab Date")
            Me.txtDate.Focus()
            Exit Function
        ElseIf IsDate(Me.txtDate.Text) = False Then
            MsgBox("Lab Date must be a date. Please enter a valid Lab Date.", MsgBoxStyle.Information, "Lab Date")
            Me.txtDate.Focus()
            Exit Function
        End If

        'Load data into Variables
        Dim LabDataDate As Date, IsHaz_NonHaz As Integer, Bulk_Drums As Integer, Gallons As String, PumpedTo As String
        Dim Comments As String, BS_W_Total As String, BSW_Oil As String, BSW_Water As String, BSW_Sludge As String
        Dim Gravity As String, PPG As String, Physical_Appearance As String, Arsenic As String, Cadmium As String
        Dim Chromium_Total As String, Chromium_Hex As String, Copper As String, Nickel As String, Cyanide As String
        Dim Iron As String, Zinc As String, Lead As String, Oils As String, Chlorine As String
        Dim Nitrogen_Dioxide As String, Hydrogen_Cyanide As String, Hydrogen_Sulphide As String, PCBs As String
        Dim Flash_Point As String, PH As String, Chlorine_Flame_Test As String, Acid_Test_Reaction As String
        Dim Odor As String, LabTechnicianI As String

        LabDataDate = CDate(Me.txtDate.Text).ToShortDateString
        IsHaz_NonHaz = IIf(Me.rdnH.Checked, 1, IIf(Me.rdnNH.Checked, 2, 0))
        Bulk_Drums = IIf(Me.rdnB.Checked, 1, IIf(Me.rdnD.Checked, 2, 0))
        Gallons = Me.txtGallons.Text
        PumpedTo = Me.txtPumpedTo.Text
        Comments = Me.txtComments.Text
        BS_W_Total = Me.txtBSW.Text
        BSW_Oil = Me.txtOil.Text
        BSW_Water = Me.txtWater.Text
        BSW_Sludge = Me.txtSludge.Text
        Gravity = Me.txtGravity.Text
        PPG = Me.txtPPG.Text
        Physical_Appearance = Me.txtPhysical.Text
        Arsenic = Me.txtArsenic.Text
        Cadmium = Me.txtCadmium.Text
        Chromium_Total = Me.txtChromiumT.Text
        Chromium_Hex = Me.txtChromiumH.Text
        Copper = Me.txtCopper.Text
        Nickel = Me.txtNickel.Text
        Cyanide = Me.txtCyanide.Text
        Iron = Me.txtIron.Text
        Zinc = Me.txtZinc.Text
        Lead = Me.txtLead.Text
        Oils = Me.txtOils.Text
        Chlorine = Me.txtChlorine.Text
        Nitrogen_Dioxide = Me.txtNitDio.Text
        Hydrogen_Cyanide = Me.txtHydCya.Text
        Hydrogen_Sulphide = Me.txtHydSul.Text
        PCBs = Me.txtPCBs.Text
        Flash_Point = Me.txtFlashPoint.Text
        PH = Me.txtPH.Text
        Chlorine_Flame_Test = Me.txtChlorineFT.Text
        Acid_Test_Reaction = Me.txtAcidTest.Text
        Odor = Me.txtOdor.Text
        LabTechnicianI = Me.txtInitials.Text


        Try

            'Load Job Ticket Data
            Dim strSQL As String = ""
            If Me.isLabDataExists = False Then
                strSQL = "INSERT INTO tblLabData(JobTicketID,LabDataDate,IsHaz_NonHaz,Bulk_Drums,Gallons,PumpedTo,Comments,BS_W_Total,BSW_Oil,BSW_Water,BSW_Sludge,Gravity,PPG,Physical_Appearance,Arsenic,Cadmium,Chromium_Total,Chromium_Hex,Copper,Nickel,Cyanide,Iron,Zinc,Lead,Oils,Chlorine,Nitrogen_Dioxide,Hydrogen_Cyanide,Hydrogen_Sulphide,PCBs,Flash_Point,PH,Chlorine_Flame_Test,Acid_Test_Reaction,Odor,LabTechnicianI) "
                strSQL = strSQL & "VALUES(" & Me.jtID & ", #" & LabDataDate & "#, " & IsHaz_NonHaz & ", " & Bulk_Drums & ", '" & Replace(Gallons, "'", "''") & "', '" & Replace(PumpedTo, "'", "''") & "', '" & Replace(Comments, "'", "''") & "', '" & Replace(BS_W_Total, "'", "''") & "', '" & Replace(BSW_Oil, "'", "''") & "', '" & Replace(BSW_Water, "'", "''") & "', '" & Replace(BSW_Sludge, "'", "''") & "', '" & Replace(Gravity, "'", "''") & "', '" & Replace(PPG, "'", "''") & "', '" & Replace(Physical_Appearance, "'", "''") & "', '" & Replace(Arsenic, "'", "''") & "', '" & Replace(Cadmium, "'", "''") & "', '" & Replace(Chromium_Total, "'", "''") & "', '" & Replace(Chromium_Hex, "'", "''") & "', '" & Replace(Copper, "'", "''") & "', '" & Replace(Nickel, "'", "''") & "', '" & Replace(Cyanide, "'", "''") & "', '" & Replace(Iron, "'", "''") & "', '" & Replace(Zinc, "'", "''") & "', '" & Replace(Lead, "'", "''") & "', '" & Replace(Oils, "'", "''") & "', '" & Replace(Chlorine, "'", "''") & "', '" & Replace(Nitrogen_Dioxide, "'", "''") & "', '" & Replace(Hydrogen_Cyanide, "'", "''") & "', '" & Replace(Hydrogen_Sulphide, "'", "''") & "', '" & Replace(PCBs, "'", "''") & "', '" & Replace(Flash_Point, "'", "''") & "', '" & Replace(PH, "'", "''") & "', '" & Replace(Chlorine_Flame_Test, "'", "''") & "', '" & Replace(Acid_Test_Reaction, "'", "''") & "', '" & Replace(Odor, "'", "''") & "', '" & Replace(LabTechnicianI, "'", "''") & "')"
            Else
                strSQL = "UPDATE tblLabData SET "
                strSQL = strSQL & "LabDataDate=#" & LabDataDate & "#, IsHaz_NonHaz=" & IsHaz_NonHaz & ", Bulk_Drums=" & Bulk_Drums & ", Gallons ='" & Replace(Gallons, "'", "''") & "', PumpedTo ='" & Replace(PumpedTo, "'", "''") & "', Comments ='" & Replace(Comments, "'", "''") & "', BS_W_Total ='" & Replace(BS_W_Total, "'", "''") & "', BSW_Oil ='" & Replace(BSW_Oil, "'", "''") & "', BSW_Water ='" & Replace(BSW_Water, "'", "''") & "', BSW_Sludge ='" & Replace(BSW_Sludge, "'", "''") & "', Gravity ='" & Replace(Gravity, "'", "''") & "', PPG ='" & Replace(PPG, "'", "''") & "', Physical_Appearance ='" & Replace(Physical_Appearance, "'", "''") & "', Arsenic ='" & Replace(Arsenic, "'", "''") & "', Cadmium ='" & Replace(Cadmium, "'", "''") & "', Chromium_Total ='" & Replace(Chromium_Total, "'", "''") & "', Chromium_Hex ='" & Replace(Chromium_Hex, "'", "''") & "', Copper ='" & Replace(Copper, "'", "''") & "', Nickel ='" & Replace(Nickel, "'", "''") & "', Cyanide ='" & Replace(Cyanide, "'", "''") & "', Iron ='" & Replace(Iron, "'", "''") & "', Zinc ='" & Replace(Zinc, "'", "''") & "', Lead ='" & Replace(Lead, "'", "''") & "', Oils = '" & Replace(Oils, "'", "''") & "', Chlorine ='" & Replace(Chlorine, "'", "''") & "', Nitrogen_Dioxide ='" & Replace(Nitrogen_Dioxide, "'", "''") & "', Hydrogen_Cyanide ='" & Replace(Hydrogen_Cyanide, "'", "''") & "', Hydrogen_Sulphide ='" & Replace(Hydrogen_Sulphide, "'", "''") & "', PCBs ='" & Replace(PCBs, "'", "''") & "', Flash_Point ='" & Replace(Flash_Point, "'", "''") & "', PH ='" & Replace(PH, "'", "''") & "', Chlorine_Flame_Test ='" & Replace(Chlorine_Flame_Test, "'", "''") & "', Acid_Test_Reaction ='" & Replace(Acid_Test_Reaction, "'", "''") & "', Odor ='" & Replace(Odor, "'", "''") & "', LabTechnicianI ='" & Replace(LabTechnicianI, "'", "''") & "'"
                strSQL = strSQL & " WHERE JobTicketID = " & Me.jtID
            End If
            'Execute the created Query
            If DBHelper.ExecuteQuery(strSQL) = False Then
                MsgBox("Could not update data. Error ocurred", MsgBoxStyle.Information, "Lab Data")
            Else
                Dim prdID As Integer = DBHelper.GetInteger("SELECT tblProducts.ProductID FROM tblJobTickets INNER JOIN tblProducts ON tblJobTickets.ProductID = tblProducts.ProductID WHERE tblJobTickets.JobTicketID = " & Me.jtID)
                If prdID > 0 Then
                    DBHelper.ExecuteQuery("UPDATE tblProducts SET AnalyticalDate = #" & LabDataDate & "# WHERE ProductID = " & prdID & " AND AnalyticalDate < #" & LabDataDate & "#")
                End If
                Me.Close()
            End If

        Catch ex As SystemException

            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally

        End Try

    End Function

    Private Sub btnCancelLD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelLD.Click

        Me.Close()

    End Sub

    Private Sub btnSaveLD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveLD.Click

        Me.saveLabData()
        DirectCast(Owner, frmLabData).populateDatagrid()

    End Sub

End Class
