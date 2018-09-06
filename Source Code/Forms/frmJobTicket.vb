Public Class frmJobTicket

    Inherits System.Windows.Forms.Form
    Dim ClosedFlag As Boolean
#Region " Windows Form Designer generated code "

    Public Sub New(ByVal flag As Boolean)
        MyBase.New()
        ClosedFlag = flag
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
    Friend WithEvents txtCustomerName As System.Windows.Forms.Label
    Friend WithEvents txtJobSite As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPO As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.Label
    Friend WithEvents txtZip As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtAttn As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtDriver As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtTruckNo As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents DsJobTicket_Details1 As BeaverOil.DSJobTicket_Details
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtManifest As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtREF As System.Windows.Forms.TextBox
    Friend WithEvents txtCArrived As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents cmbCAMer As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCDMer As System.Windows.Forms.ComboBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtCDeparted As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtPumpingStart As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtPumpingFinish As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents cmbUAMer As System.Windows.Forms.ComboBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtUArrived As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents cmbUDMer As System.Windows.Forms.ComboBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents txtUDeparted As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents btnCancelJT As System.Windows.Forms.Button
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents cmbDisposal As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTransporter As System.Windows.Forms.ComboBox
    Friend WithEvents dgQuantity As System.Windows.Forms.DataGrid
    Friend WithEvents lblWhatForm As System.Windows.Forms.Label
    Friend WithEvents col_JDid As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_JTid As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_Q As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_Desc As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ts_dgQuantity As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents SelectJobDetails As System.Data.OleDb.OleDbCommand
    Friend WithEvents InsertJobDetails As System.Data.OleDb.OleDbCommand
    Friend WithEvents UpdateJobDetails As System.Data.OleDb.OleDbCommand
    Friend WithEvents DeleteJobDetails As System.Data.OleDb.OleDbCommand
    Friend WithEvents DAQuantity As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents col_UOM As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TicketNo As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents ManifestText As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents txtBSW As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents lblGenILNo As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents lblGenerator As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents lblApprovalNo As System.Windows.Forms.Label
    Friend WithEvents btnViewProductInfo As System.Windows.Forms.Button
    Friend WithEvents btnSaveJT As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents cmbWasteType As System.Windows.Forms.ComboBox
    Friend WithEvents txtScheduleDate As System.Windows.Forms.TextBox
    Friend WithEvents txtGallons As System.Windows.Forms.TextBox
    Friend WithEvents lblGallons As System.Windows.Forms.Label
    Friend WithEvents chkDrums As System.Windows.Forms.CheckBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents lblGID As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents cmbProducts As System.Windows.Forms.ComboBox
    Friend WithEvents lblCWTCode As System.Windows.Forms.Label
    Friend WithEvents lblCWT As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblReqField = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtScheduleDate = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCustomerName = New System.Windows.Forms.Label
        Me.txtJobSite = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCity = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtPO = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtState = New System.Windows.Forms.Label
        Me.txtZip = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtAttn = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtDriver = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtTruckNo = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.cmbDisposal = New System.Windows.Forms.ComboBox
        Me.dgQuantity = New System.Windows.Forms.DataGrid
        Me.DsJobTicket_Details1 = New BeaverOil.DSJobTicket_Details
        Me.ts_dgQuantity = New System.Windows.Forms.DataGridTableStyle
        Me.col_JDid = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_JTid = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_Q = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_UOM = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_Desc = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtNotes = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtREF = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtManifest = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.txtCArrived = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.cmbCAMer = New System.Windows.Forms.ComboBox
        Me.cmbCDMer = New System.Windows.Forms.ComboBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.txtCDeparted = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.txtPumpingStart = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.txtPumpingFinish = New System.Windows.Forms.TextBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.cmbUAMer = New System.Windows.Forms.ComboBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.txtUArrived = New System.Windows.Forms.TextBox
        Me.Label42 = New System.Windows.Forms.Label
        Me.cmbUDMer = New System.Windows.Forms.ComboBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.txtUDeparted = New System.Windows.Forms.TextBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.btnCancelJT = New System.Windows.Forms.Button
        Me.cmbTransporter = New System.Windows.Forms.ComboBox
        Me.lblWhatForm = New System.Windows.Forms.Label
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.DAQuantity = New System.Data.OleDb.OleDbDataAdapter
        Me.DeleteJobDetails = New System.Data.OleDb.OleDbCommand
        Me.InsertJobDetails = New System.Data.OleDb.OleDbCommand
        Me.SelectJobDetails = New System.Data.OleDb.OleDbCommand
        Me.UpdateJobDetails = New System.Data.OleDb.OleDbCommand
        Me.Label16 = New System.Windows.Forms.Label
        Me.TicketNo = New System.Windows.Forms.TextBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.ManifestText = New System.Windows.Forms.TextBox
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.txtBSW = New System.Windows.Forms.TextBox
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.lblGenILNo = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.lblGenerator = New System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button
        Me.Label52 = New System.Windows.Forms.Label
        Me.lblApprovalNo = New System.Windows.Forms.Label
        Me.btnViewProductInfo = New System.Windows.Forms.Button
        Me.btnSaveJT = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label53 = New System.Windows.Forms.Label
        Me.cmbWasteType = New System.Windows.Forms.ComboBox
        Me.txtGallons = New System.Windows.Forms.TextBox
        Me.lblGallons = New System.Windows.Forms.Label
        Me.chkDrums = New System.Windows.Forms.CheckBox
        Me.Label54 = New System.Windows.Forms.Label
        Me.lblGID = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.cmbProducts = New System.Windows.Forms.ComboBox
        Me.lblCWT = New System.Windows.Forms.Label
        Me.lblCWTCode = New System.Windows.Forms.Label
        CType(Me.dgQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsJobTicket_Details1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblReqField
        '
        Me.lblReqField.Location = New System.Drawing.Point(8, 32)
        Me.lblReqField.Name = "lblReqField"
        Me.lblReqField.Size = New System.Drawing.Size(32, 16)
        Me.lblReqField.TabIndex = 0
        Me.lblReqField.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(44, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SCH. DATE :-"
        '
        'txtScheduleDate
        '
        Me.txtScheduleDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtScheduleDate.Location = New System.Drawing.Point(126, 32)
        Me.txtScheduleDate.MaxLength = 8
        Me.txtScheduleDate.Name = "txtScheduleDate"
        Me.txtScheduleDate.Size = New System.Drawing.Size(104, 14)
        Me.txtScheduleDate.TabIndex = 2
        Me.txtScheduleDate.Text = ""
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(126, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 1)
        Me.Label2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(312, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(256, 1)
        Me.Label3.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(232, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "CUSTOMER"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(312, 32)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(256, 16)
        Me.txtCustomerName.TabIndex = 99
        '
        'txtJobSite
        '
        Me.txtJobSite.Location = New System.Drawing.Point(128, 52)
        Me.txtJobSite.Name = "txtJobSite"
        Me.txtJobSite.Size = New System.Drawing.Size(440, 16)
        Me.txtJobSite.TabIndex = 98
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(120, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(448, 1)
        Me.Label6.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(56, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "JOB SITE"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(128, 72)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(440, 16)
        Me.txtAddress.TabIndex = 97
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(56, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(512, 1)
        Me.Label8.TabIndex = 12
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(128, 92)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(216, 16)
        Me.txtCity.TabIndex = 96
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(56, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(288, 1)
        Me.Label10.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(352, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 1)
        Me.Label5.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(424, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 1)
        Me.Label9.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(96, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(176, 1)
        Me.Label11.TabIndex = 22
        '
        'txtPO
        '
        Me.txtPO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPO.Location = New System.Drawing.Point(104, 114)
        Me.txtPO.MaxLength = 50
        Me.txtPO.Name = "txtPO"
        Me.txtPO.Size = New System.Drawing.Size(168, 14)
        Me.txtPO.TabIndex = 3
        Me.txtPO.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(56, 114)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 16)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "P.O."
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(352, 92)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(64, 16)
        Me.txtState.TabIndex = 95
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(424, 92)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(144, 16)
        Me.txtZip.TabIndex = 94
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(336, 130)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(232, 1)
        Me.Label13.TabIndex = 27
        '
        'txtAttn
        '
        Me.txtAttn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAttn.Location = New System.Drawing.Point(336, 114)
        Me.txtAttn.MaxLength = 50
        Me.txtAttn.Name = "txtAttn"
        Me.txtAttn.Size = New System.Drawing.Size(232, 14)
        Me.txtAttn.TabIndex = 93
        Me.txtAttn.Text = ""
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(280, 114)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 16)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Attn"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(56, 136)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 16)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "HAULER"
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Location = New System.Drawing.Point(336, 178)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(232, 1)
        Me.Label17.TabIndex = 36
        '
        'txtDriver
        '
        Me.txtDriver.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDriver.Location = New System.Drawing.Point(336, 162)
        Me.txtDriver.MaxLength = 50
        Me.txtDriver.Name = "txtDriver"
        Me.txtDriver.Size = New System.Drawing.Size(232, 14)
        Me.txtDriver.TabIndex = 50
        Me.txtDriver.Text = ""
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(280, 162)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 16)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "DRIVER"
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Location = New System.Drawing.Point(112, 178)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(160, 1)
        Me.Label19.TabIndex = 33
        '
        'txtTruckNo
        '
        Me.txtTruckNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTruckNo.Location = New System.Drawing.Point(120, 162)
        Me.txtTruckNo.MaxLength = 50
        Me.txtTruckNo.Name = "txtTruckNo"
        Me.txtTruckNo.Size = New System.Drawing.Size(152, 14)
        Me.txtTruckNo.TabIndex = 7
        Me.txtTruckNo.Text = ""
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(56, 162)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 16)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = "TRUCK #"
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(56, 186)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(102, 16)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "RECEIVING SITE"
        '
        'cmbDisposal
        '
        Me.cmbDisposal.Location = New System.Drawing.Point(160, 182)
        Me.cmbDisposal.Name = "cmbDisposal"
        Me.cmbDisposal.Size = New System.Drawing.Size(316, 21)
        Me.cmbDisposal.TabIndex = 8
        '
        'dgQuantity
        '
        Me.dgQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgQuantity.CaptionVisible = False
        Me.dgQuantity.DataMember = "tblJobTickets_Details"
        Me.dgQuantity.DataSource = Me.DsJobTicket_Details1
        Me.dgQuantity.FlatMode = True
        Me.dgQuantity.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgQuantity.Location = New System.Drawing.Point(56, 296)
        Me.dgQuantity.Name = "dgQuantity"
        Me.dgQuantity.Size = New System.Drawing.Size(512, 156)
        Me.dgQuantity.TabIndex = 52
        Me.dgQuantity.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.ts_dgQuantity})
        '
        'DsJobTicket_Details1
        '
        Me.DsJobTicket_Details1.DataSetName = "DSJobTicket_Details"
        Me.DsJobTicket_Details1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'ts_dgQuantity
        '
        Me.ts_dgQuantity.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.ts_dgQuantity.DataGrid = Me.dgQuantity
        Me.ts_dgQuantity.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.col_JDid, Me.col_JTid, Me.col_Q, Me.col_UOM, Me.col_Desc})
        Me.ts_dgQuantity.GridLineColor = System.Drawing.Color.Black
        Me.ts_dgQuantity.HeaderBackColor = System.Drawing.Color.SteelBlue
        Me.ts_dgQuantity.HeaderFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_dgQuantity.HeaderForeColor = System.Drawing.Color.White
        Me.ts_dgQuantity.MappingName = "tblJobTickets_Details"
        '
        'col_JDid
        '
        Me.col_JDid.Format = "g"
        Me.col_JDid.FormatInfo = Nothing
        Me.col_JDid.HeaderText = "JobDetailID"
        Me.col_JDid.MappingName = "JobDetailID"
        Me.col_JDid.NullText = ""
        Me.col_JDid.Width = 0
        '
        'col_JTid
        '
        Me.col_JTid.Format = "g"
        Me.col_JTid.FormatInfo = Nothing
        Me.col_JTid.HeaderText = "JobTicketID"
        Me.col_JTid.MappingName = "JobTicketID"
        Me.col_JTid.NullText = ""
        Me.col_JTid.Width = 0
        '
        'col_Q
        '
        Me.col_Q.Format = ""
        Me.col_Q.FormatInfo = Nothing
        Me.col_Q.HeaderText = "Quantity"
        Me.col_Q.MappingName = "Quantity"
        Me.col_Q.NullText = ""
        Me.col_Q.Width = 75
        '
        'col_UOM
        '
        Me.col_UOM.Format = ""
        Me.col_UOM.FormatInfo = Nothing
        Me.col_UOM.HeaderText = "UOM"
        Me.col_UOM.MappingName = "UOM"
        Me.col_UOM.NullText = ""
        Me.col_UOM.Width = 75
        '
        'col_Desc
        '
        Me.col_Desc.Format = ""
        Me.col_Desc.FormatInfo = Nothing
        Me.col_Desc.HeaderText = "Description of Work"
        Me.col_Desc.MappingName = "Description"
        Me.col_Desc.NullText = ""
        Me.col_Desc.Width = 310
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(56, 460)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(120, 16)
        Me.Label22.TabIndex = 40
        Me.Label22.Text = "DRIVER REMARKS"
        '
        'txtNotes
        '
        Me.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNotes.Location = New System.Drawing.Point(56, 480)
        Me.txtNotes.MaxLength = 255
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(512, 56)
        Me.txtNotes.TabIndex = 13
        Me.txtNotes.Text = ""
        '
        'Label23
        '
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Location = New System.Drawing.Point(56, 450)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(512, 1)
        Me.Label23.TabIndex = 42
        '
        'Label24
        '
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.Location = New System.Drawing.Point(56, 294)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(512, 1)
        Me.Label24.TabIndex = 43
        '
        'Label25
        '
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label25.Location = New System.Drawing.Point(568, 294)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(1, 156)
        Me.Label25.TabIndex = 44
        '
        'Label26
        '
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label26.Location = New System.Drawing.Point(56, 294)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(1, 156)
        Me.Label26.TabIndex = 11
        '
        'Label27
        '
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label27.Location = New System.Drawing.Point(56, 536)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(512, 1)
        Me.Label27.TabIndex = 46
        '
        'Label28
        '
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label28.Location = New System.Drawing.Point(368, 560)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(200, 1)
        Me.Label28.TabIndex = 52
        '
        'txtREF
        '
        Me.txtREF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtREF.Location = New System.Drawing.Point(376, 544)
        Me.txtREF.MaxLength = 50
        Me.txtREF.Name = "txtREF"
        Me.txtREF.Size = New System.Drawing.Size(192, 14)
        Me.txtREF.TabIndex = 15
        Me.txtREF.Text = ""
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(312, 544)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(48, 16)
        Me.Label29.TabIndex = 50
        Me.Label29.Text = "REF. #"
        '
        'Label30
        '
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label30.Location = New System.Drawing.Point(136, 560)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(168, 1)
        Me.Label30.TabIndex = 49
        '
        'txtManifest
        '
        Me.txtManifest.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtManifest.Location = New System.Drawing.Point(144, 544)
        Me.txtManifest.MaxLength = 50
        Me.txtManifest.Name = "txtManifest"
        Me.txtManifest.Size = New System.Drawing.Size(152, 14)
        Me.txtManifest.TabIndex = 6
        Me.txtManifest.Text = ""
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(56, 544)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(80, 16)
        Me.Label31.TabIndex = 47
        Me.Label31.Text = "MANIFEST #"
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(56, 568)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(80, 16)
        Me.Label32.TabIndex = 53
        Me.Label32.Text = "TIME"
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(56, 584)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(120, 16)
        Me.Label33.TabIndex = 54
        Me.Label33.Text = "Customer: Arrived"
        '
        'txtCArrived
        '
        Me.txtCArrived.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCArrived.Location = New System.Drawing.Point(176, 584)
        Me.txtCArrived.MaxLength = 20
        Me.txtCArrived.Name = "txtCArrived"
        Me.txtCArrived.Size = New System.Drawing.Size(88, 14)
        Me.txtCArrived.TabIndex = 16
        Me.txtCArrived.Text = ""
        '
        'Label34
        '
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label34.Location = New System.Drawing.Point(176, 600)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(88, 1)
        Me.Label34.TabIndex = 56
        '
        'cmbCAMer
        '
        Me.cmbCAMer.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmbCAMer.Location = New System.Drawing.Point(272, 584)
        Me.cmbCAMer.Name = "cmbCAMer"
        Me.cmbCAMer.Size = New System.Drawing.Size(48, 21)
        Me.cmbCAMer.TabIndex = 17
        '
        'cmbCDMer
        '
        Me.cmbCDMer.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmbCDMer.Location = New System.Drawing.Point(520, 584)
        Me.cmbCDMer.Name = "cmbCDMer"
        Me.cmbCDMer.Size = New System.Drawing.Size(48, 21)
        Me.cmbCDMer.TabIndex = 19
        '
        'Label35
        '
        Me.Label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label35.Location = New System.Drawing.Point(424, 600)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(88, 1)
        Me.Label35.TabIndex = 60
        '
        'txtCDeparted
        '
        Me.txtCDeparted.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCDeparted.Location = New System.Drawing.Point(424, 584)
        Me.txtCDeparted.MaxLength = 20
        Me.txtCDeparted.Name = "txtCDeparted"
        Me.txtCDeparted.Size = New System.Drawing.Size(88, 14)
        Me.txtCDeparted.TabIndex = 18
        Me.txtCDeparted.Text = ""
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(344, 584)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(80, 16)
        Me.Label36.TabIndex = 58
        Me.Label36.Text = "Departed"
        '
        'Label37
        '
        Me.Label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label37.Location = New System.Drawing.Point(160, 624)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(160, 1)
        Me.Label37.TabIndex = 64
        '
        'txtPumpingStart
        '
        Me.txtPumpingStart.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPumpingStart.Location = New System.Drawing.Point(168, 608)
        Me.txtPumpingStart.MaxLength = 20
        Me.txtPumpingStart.Name = "txtPumpingStart"
        Me.txtPumpingStart.Size = New System.Drawing.Size(144, 14)
        Me.txtPumpingStart.TabIndex = 20
        Me.txtPumpingStart.Text = ""
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(56, 608)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(96, 16)
        Me.Label38.TabIndex = 62
        Me.Label38.Text = "Pumping: Start"
        '
        'Label39
        '
        Me.Label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label39.Location = New System.Drawing.Point(392, 624)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(176, 1)
        Me.Label39.TabIndex = 67
        '
        'txtPumpingFinish
        '
        Me.txtPumpingFinish.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPumpingFinish.Location = New System.Drawing.Point(400, 608)
        Me.txtPumpingFinish.MaxLength = 20
        Me.txtPumpingFinish.Name = "txtPumpingFinish"
        Me.txtPumpingFinish.Size = New System.Drawing.Size(168, 14)
        Me.txtPumpingFinish.TabIndex = 21
        Me.txtPumpingFinish.Text = ""
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(344, 608)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(56, 16)
        Me.Label40.TabIndex = 65
        Me.Label40.Text = "Finish"
        '
        'cmbUAMer
        '
        Me.cmbUAMer.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmbUAMer.Location = New System.Drawing.Point(272, 632)
        Me.cmbUAMer.Name = "cmbUAMer"
        Me.cmbUAMer.Size = New System.Drawing.Size(48, 21)
        Me.cmbUAMer.TabIndex = 23
        '
        'Label41
        '
        Me.Label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label41.Location = New System.Drawing.Point(176, 648)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(88, 1)
        Me.Label41.TabIndex = 70
        '
        'txtUArrived
        '
        Me.txtUArrived.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUArrived.Location = New System.Drawing.Point(176, 632)
        Me.txtUArrived.MaxLength = 20
        Me.txtUArrived.Name = "txtUArrived"
        Me.txtUArrived.Size = New System.Drawing.Size(88, 14)
        Me.txtUArrived.TabIndex = 22
        Me.txtUArrived.Text = ""
        '
        'Label42
        '
        Me.Label42.Location = New System.Drawing.Point(56, 632)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(120, 16)
        Me.Label42.TabIndex = 68
        Me.Label42.Text = "Unloading: Arrived"
        '
        'cmbUDMer
        '
        Me.cmbUDMer.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmbUDMer.Location = New System.Drawing.Point(520, 632)
        Me.cmbUDMer.Name = "cmbUDMer"
        Me.cmbUDMer.Size = New System.Drawing.Size(48, 21)
        Me.cmbUDMer.TabIndex = 25
        '
        'Label43
        '
        Me.Label43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label43.Location = New System.Drawing.Point(424, 648)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(88, 1)
        Me.Label43.TabIndex = 74
        '
        'txtUDeparted
        '
        Me.txtUDeparted.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUDeparted.Location = New System.Drawing.Point(424, 632)
        Me.txtUDeparted.MaxLength = 20
        Me.txtUDeparted.Name = "txtUDeparted"
        Me.txtUDeparted.Size = New System.Drawing.Size(88, 14)
        Me.txtUDeparted.TabIndex = 24
        Me.txtUDeparted.Text = ""
        '
        'Label44
        '
        Me.Label44.Location = New System.Drawing.Point(344, 632)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(80, 16)
        Me.Label44.TabIndex = 72
        Me.Label44.Text = "Departed"
        '
        'btnCancelJT
        '
        Me.btnCancelJT.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCancelJT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelJT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelJT.Location = New System.Drawing.Point(392, 672)
        Me.btnCancelJT.Name = "btnCancelJT"
        Me.btnCancelJT.Size = New System.Drawing.Size(80, 24)
        Me.btnCancelJT.TabIndex = 28
        Me.btnCancelJT.Text = "&Cancel"
        '
        'cmbTransporter
        '
        Me.cmbTransporter.Location = New System.Drawing.Point(112, 136)
        Me.cmbTransporter.Name = "cmbTransporter"
        Me.cmbTransporter.Size = New System.Drawing.Size(328, 21)
        Me.cmbTransporter.TabIndex = 7
        '
        'lblWhatForm
        '
        Me.lblWhatForm.Location = New System.Drawing.Point(0, 56)
        Me.lblWhatForm.Name = "lblWhatForm"
        Me.lblWhatForm.Size = New System.Drawing.Size(40, 16)
        Me.lblWhatForm.TabIndex = 79
        Me.lblWhatForm.Visible = False
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Jet OLEDB:Database Password=;Data Source=""C:\Documents and Setting" & _
        "s\Administrator.GREEVESLAPTOP\My Documents\Visual Studio Projects\BeaverOil\bin\" & _
        "JobTrackingSystem.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk T" & _
        "ransactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet " & _
        "OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database" & _
        " Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on" & _
        " Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet " & _
        "OLEDB:Encrypt Database=False"
        '
        'DAQuantity
        '
        Me.DAQuantity.DeleteCommand = Me.DeleteJobDetails
        Me.DAQuantity.InsertCommand = Me.InsertJobDetails
        Me.DAQuantity.SelectCommand = Me.SelectJobDetails
        Me.DAQuantity.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblJobTickets_Details", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("JobDetailID", "JobDetailID"), New System.Data.Common.DataColumnMapping("JobTicketID", "JobTicketID"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("UOM", "UOM")})})
        Me.DAQuantity.UpdateCommand = Me.UpdateJobDetails
        '
        'DeleteJobDetails
        '
        Me.DeleteJobDetails.CommandText = "DELETE FROM tblJobTickets_Details WHERE (JobDetailID = ?)"
        Me.DeleteJobDetails.Connection = Me.OleDbConnection1
        Me.DeleteJobDetails.Parameters.Add(New System.Data.OleDb.OleDbParameter("JobDetailID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "JobDetailID", System.Data.DataRowVersion.Original, Nothing))
        '
        'InsertJobDetails
        '
        Me.InsertJobDetails.CommandText = "INSERT INTO tblJobTickets_Details (JobTicketID, Quantity, Description, UOM) VALUE" & _
        "S (?, ?, ?, ?)"
        Me.InsertJobDetails.Connection = Me.OleDbConnection1
        Me.InsertJobDetails.Parameters.Add(New System.Data.OleDb.OleDbParameter("JobTicketID", System.Data.OleDb.OleDbType.Integer, 0, "JobTicketID"))
        Me.InsertJobDetails.Parameters.Add(New System.Data.OleDb.OleDbParameter("Quantity", System.Data.OleDb.OleDbType.Double, 0, "Quantity"))
        Me.InsertJobDetails.Parameters.Add(New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 255, "Description"))
        Me.InsertJobDetails.Parameters.Add(New System.Data.OleDb.OleDbParameter("UOM", System.Data.OleDb.OleDbType.VarWChar, 50, "UOM"))
        '
        'SelectJobDetails
        '
        Me.SelectJobDetails.CommandText = "SELECT JobDetailID, JobTicketID, Quantity, Description, UOM FROM tblJobTickets_De" & _
        "tails"
        Me.SelectJobDetails.Connection = Me.OleDbConnection1
        '
        'UpdateJobDetails
        '
        Me.UpdateJobDetails.CommandText = "UPDATE tblJobTickets_Details SET JobTicketID = ?, Quantity = ?, Description = ?, " & _
        "UOM = ? WHERE (JobDetailID = ?)"
        Me.UpdateJobDetails.Connection = Me.OleDbConnection1
        Me.UpdateJobDetails.Parameters.Add(New System.Data.OleDb.OleDbParameter("JobTicketID", System.Data.OleDb.OleDbType.Integer, 0, "JobTicketID"))
        Me.UpdateJobDetails.Parameters.Add(New System.Data.OleDb.OleDbParameter("Quantity", System.Data.OleDb.OleDbType.Double, 0, "Quantity"))
        Me.UpdateJobDetails.Parameters.Add(New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 255, "Description"))
        Me.UpdateJobDetails.Parameters.Add(New System.Data.OleDb.OleDbParameter("UOM", System.Data.OleDb.OleDbType.VarWChar, 50, "UOM"))
        Me.UpdateJobDetails.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_JobDetailID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "JobDetailID", System.Data.DataRowVersion.Original, Nothing))
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(392, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 16)
        Me.Label16.TabIndex = 162
        Me.Label16.Text = "TICKET #"
        '
        'TicketNo
        '
        Me.TicketNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TicketNo.Location = New System.Drawing.Point(464, 8)
        Me.TicketNo.MaxLength = 8
        Me.TicketNo.Name = "TicketNo"
        Me.TicketNo.Size = New System.Drawing.Size(104, 14)
        Me.TicketNo.TabIndex = 1
        Me.TicketNo.Text = ""
        '
        'Label45
        '
        Me.Label45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label45.Location = New System.Drawing.Point(464, 24)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(104, 1)
        Me.Label45.TabIndex = 161
        '
        'ManifestText
        '
        Me.ManifestText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ManifestText.Location = New System.Drawing.Point(296, 460)
        Me.ManifestText.MaxLength = 50
        Me.ManifestText.Name = "ManifestText"
        Me.ManifestText.Size = New System.Drawing.Size(272, 14)
        Me.ManifestText.TabIndex = 12
        Me.ManifestText.Text = ""
        '
        'Label46
        '
        Me.Label46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label46.Location = New System.Drawing.Point(288, 476)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(280, 1)
        Me.Label46.TabIndex = 165
        '
        'Label47
        '
        Me.Label47.Location = New System.Drawing.Point(192, 460)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(88, 16)
        Me.Label47.TabIndex = 163
        Me.Label47.Text = "Manifest Text: "
        '
        'Label48
        '
        Me.Label48.Location = New System.Drawing.Point(440, 136)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(88, 16)
        Me.Label48.TabIndex = 166
        Me.Label48.Text = "BS+W (%) :-"
        '
        'txtBSW
        '
        Me.txtBSW.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBSW.Location = New System.Drawing.Point(520, 136)
        Me.txtBSW.MaxLength = 8
        Me.txtBSW.Name = "txtBSW"
        Me.txtBSW.Size = New System.Drawing.Size(48, 14)
        Me.txtBSW.TabIndex = 4
        Me.txtBSW.Text = ""
        '
        'Label49
        '
        Me.Label49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label49.Location = New System.Drawing.Point(520, 152)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(48, 1)
        Me.Label49.TabIndex = 168
        '
        'Label50
        '
        Me.Label50.Location = New System.Drawing.Point(56, 234)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(128, 16)
        Me.Label50.TabIndex = 169
        Me.Label50.Text = "Generator IL No. :-"
        '
        'lblGenILNo
        '
        Me.lblGenILNo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenILNo.Location = New System.Drawing.Point(184, 234)
        Me.lblGenILNo.Name = "lblGenILNo"
        Me.lblGenILNo.Size = New System.Drawing.Size(128, 16)
        Me.lblGenILNo.TabIndex = 171
        '
        'Label51
        '
        Me.Label51.Location = New System.Drawing.Point(242, 276)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(80, 16)
        Me.Label51.TabIndex = 172
        Me.Label51.Text = "Generator :-"
        Me.Label51.Visible = False
        '
        'lblGenerator
        '
        Me.lblGenerator.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenerator.Location = New System.Drawing.Point(324, 276)
        Me.lblGenerator.Name = "lblGenerator"
        Me.lblGenerator.Size = New System.Drawing.Size(244, 16)
        Me.lblGenerator.TabIndex = 173
        Me.lblGenerator.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(480, 672)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(84, 24)
        Me.btnDelete.TabIndex = 29
        Me.btnDelete.Text = "&Delete"
        '
        'Label52
        '
        Me.Label52.ForeColor = System.Drawing.Color.Red
        Me.Label52.Location = New System.Drawing.Point(314, 234)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(96, 16)
        Me.Label52.TabIndex = 175
        Me.Label52.Text = "Approval No. :-"
        '
        'lblApprovalNo
        '
        Me.lblApprovalNo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApprovalNo.ForeColor = System.Drawing.Color.Red
        Me.lblApprovalNo.Location = New System.Drawing.Point(416, 234)
        Me.lblApprovalNo.Name = "lblApprovalNo"
        Me.lblApprovalNo.Size = New System.Drawing.Size(128, 16)
        Me.lblApprovalNo.TabIndex = 176
        '
        'btnViewProductInfo
        '
        Me.btnViewProductInfo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnViewProductInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewProductInfo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewProductInfo.Location = New System.Drawing.Point(56, 672)
        Me.btnViewProductInfo.Name = "btnViewProductInfo"
        Me.btnViewProductInfo.Size = New System.Drawing.Size(132, 24)
        Me.btnViewProductInfo.TabIndex = 177
        Me.btnViewProductInfo.Text = "View Product Info"
        '
        'btnSaveJT
        '
        Me.btnSaveJT.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSaveJT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveJT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveJT.Location = New System.Drawing.Point(196, 672)
        Me.btnSaveJT.Name = "btnSaveJT"
        Me.btnSaveJT.Size = New System.Drawing.Size(88, 24)
        Me.btnSaveJT.TabIndex = 26
        Me.btnSaveJT.Text = "&Save"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(292, 672)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(92, 24)
        Me.btnClose.TabIndex = 27
        Me.btnClose.Text = "&Close"
        '
        'Label53
        '
        Me.Label53.Location = New System.Drawing.Point(54, 212)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(154, 16)
        Me.Label53.TabIndex = 179
        Me.Label53.Text = "ACTIVITY REPORT TYPE :"
        '
        'cmbWasteType
        '
        Me.cmbWasteType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWasteType.Location = New System.Drawing.Point(210, 210)
        Me.cmbWasteType.Name = "cmbWasteType"
        Me.cmbWasteType.Size = New System.Drawing.Size(178, 21)
        Me.cmbWasteType.TabIndex = 51
        '
        'txtGallons
        '
        Me.txtGallons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGallons.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGallons.Location = New System.Drawing.Point(472, 210)
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(94, 21)
        Me.txtGallons.TabIndex = 5
        Me.txtGallons.Text = ""
        '
        'lblGallons
        '
        Me.lblGallons.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGallons.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblGallons.Location = New System.Drawing.Point(396, 214)
        Me.lblGallons.Name = "lblGallons"
        Me.lblGallons.Size = New System.Drawing.Size(74, 14)
        Me.lblGallons.TabIndex = 181
        Me.lblGallons.Text = "GALLONS :-"
        '
        'chkDrums
        '
        Me.chkDrums.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDrums.ForeColor = System.Drawing.Color.Navy
        Me.chkDrums.Location = New System.Drawing.Point(488, 184)
        Me.chkDrums.Name = "chkDrums"
        Me.chkDrums.Size = New System.Drawing.Size(74, 18)
        Me.chkDrums.TabIndex = 182
        Me.chkDrums.Text = "DRUMS?"
        '
        'Label54
        '
        Me.Label54.Location = New System.Drawing.Point(56, 276)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(54, 16)
        Me.Label54.TabIndex = 183
        Me.Label54.Text = "FED # :"
        '
        'lblGID
        '
        Me.lblGID.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGID.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblGID.Location = New System.Drawing.Point(112, 276)
        Me.lblGID.Name = "lblGID"
        Me.lblGID.Size = New System.Drawing.Size(128, 16)
        Me.lblGID.TabIndex = 184
        '
        'Label55
        '
        Me.Label55.Location = New System.Drawing.Point(54, 254)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(70, 16)
        Me.Label55.TabIndex = 185
        Me.Label55.Text = "PRODUCT:"
        '
        'cmbProducts
        '
        Me.cmbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProducts.Location = New System.Drawing.Point(128, 252)
        Me.cmbProducts.Name = "cmbProducts"
        Me.cmbProducts.Size = New System.Drawing.Size(438, 21)
        Me.cmbProducts.TabIndex = 186
        '
        'lblCWT
        '
        Me.lblCWT.Location = New System.Drawing.Point(44, 8)
        Me.lblCWT.Name = "lblCWT"
        Me.lblCWT.Size = New System.Drawing.Size(82, 16)
        Me.lblCWT.TabIndex = 187
        Me.lblCWT.Text = "CWT Code # "
        '
        'lblCWTCode
        '
        Me.lblCWTCode.Location = New System.Drawing.Point(130, 8)
        Me.lblCWTCode.Name = "lblCWTCode"
        Me.lblCWTCode.Size = New System.Drawing.Size(82, 16)
        Me.lblCWTCode.TabIndex = 188
        '
        'frmJobTicket
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(632, 701)
        Me.Controls.Add(Me.lblCWTCode)
        Me.Controls.Add(Me.lblCWT)
        Me.Controls.Add(Me.cmbProducts)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.lblGID)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.chkDrums)
        Me.Controls.Add(Me.txtGallons)
        Me.Controls.Add(Me.txtBSW)
        Me.Controls.Add(Me.ManifestText)
        Me.Controls.Add(Me.TicketNo)
        Me.Controls.Add(Me.txtUDeparted)
        Me.Controls.Add(Me.txtUArrived)
        Me.Controls.Add(Me.txtPumpingFinish)
        Me.Controls.Add(Me.txtPumpingStart)
        Me.Controls.Add(Me.txtCDeparted)
        Me.Controls.Add(Me.txtCArrived)
        Me.Controls.Add(Me.txtREF)
        Me.Controls.Add(Me.txtManifest)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.txtDriver)
        Me.Controls.Add(Me.txtTruckNo)
        Me.Controls.Add(Me.txtAttn)
        Me.Controls.Add(Me.txtPO)
        Me.Controls.Add(Me.txtScheduleDate)
        Me.Controls.Add(Me.lblGallons)
        Me.Controls.Add(Me.cmbWasteType)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnViewProductInfo)
        Me.Controls.Add(Me.lblApprovalNo)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblGenerator)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.lblGenILNo)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.lblWhatForm)
        Me.Controls.Add(Me.cmbTransporter)
        Me.Controls.Add(Me.btnCancelJT)
        Me.Controls.Add(Me.btnSaveJT)
        Me.Controls.Add(Me.cmbUDMer)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.cmbUAMer)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.cmbCDMer)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.cmbCAMer)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.dgQuantity)
        Me.Controls.Add(Me.cmbDisposal)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtJobSite)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblReqField)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmJobTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Job Ticket"
        CType(Me.dgQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsJobTicket_Details1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim jtID As Long
    Public frm As frmInvoicing = New frmInvoicing(ClosedFlag)
    Dim prodID As Long, genID As Long

    Private Sub frmJobTicket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.OleDbConnection1.ConnectionString = DBHelper.ConnStr
        Me.Bind_ComboBoxes()
        jtID = DBHelper.GetInteger("SELECT JobTicketID FROM tblJobTickets WHERE JobTicketNo = " & Replace(Me.lblReqField.Text, "'", "''") & "")
        If Me.lblReqField.Text <> "" Then
            If IsNumeric(Me.lblReqField.Text) = True Then
                Me.col_JTid.NullText = jtID
                Me.populateJobTicket()
            End If
        ElseIf Me.jtID > 0 Then
            Me.populateJobTicket()
        End If

    End Sub

    Function populateDatagrid()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim aConn As OleDb.OleDbConnection

        Try
            'Connect to Database and fill Dataset
            aConn = DBHelper.Connect
            Me.DsJobTicket_Details1.Clear()
            Me.SelectJobDetails.CommandText = "SELECT JobDetailID, JobTicketID, Quantity, Description, UOM FROM tblJobTickets_Details WHERE JobTicketID = " & Me.jtID
            Me.DAQuantity.Fill(Me.DsJobTicket_Details1, "tblJobTickets_Details")
            Me.DsJobTicket_Details1.Tables(0).Columns("JobTicketID").DefaultValue = jtID
            If Me.DsJobTicket_Details1.Tables(0).Rows.Count = 0 Then
                'getDefaultRates()
            End If
            'bind the table to the datagrid
            Me.dgQuantity.Refresh()

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error ocurred")

        Finally
            If IsNothing(aConn) = False Then
                If aConn.State = ConnectionState.Open Then
                    aConn.Close()
                End If
            End If
            aConn = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Function

    Function populateJobTicket()

        If jtID > 0 Then

            Dim DS As DataSet
            Dim strSQL As String
            Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Try
                strSQL = "SELECT tblJobTickets.*, tblProducts.ProductName,tblProducts.CWTCode, tblGenerators.GeneratorName, tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteAddress2, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, tblGenerators.G_ILNumber, tblProducts.ApprovalNo, tblGenerators.GeneratorID,tblGenerators.G_USEPAID FROM ((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) WHERE (JobTicketID = " & jtID & ")"
                DS = DBHelper.GetDataSet(strSQL, "tblJobTickets")
                If DS.Tables(0).Rows.Count = 0 Then
                    MsgBox("Cannot find the requested Job Ticket.", MsgBoxStyle.Information, "Cannot find")
                    Exit Function
                Else
                    Dim thisRow As DataRow
                    thisRow = DS.Tables(0).Rows(0)
                    Me.txtScheduleDate.Text = IIf(IsDBNull(thisRow.Item("ScheduleDate")), Today.ToShortDateString, thisRow.Item("ScheduleDate"))
                    '-------------------------------------------------------------------
                    'Haigriv Vyas
                    'Date: 07/05/2005
                    '-------------------------------------------------------------------
                    'Me.txtCustomerName.Text = thisRow.Item("JobSite")
                    'Me.txtJobSite.Text = thisRow.Item("JobSite")
                    Me.txtCustomerName.Text = thisRow.Item("JobSite")
                    Me.txtJobSite.Text = thisRow.Item("GeneratorName")
                    Me.txtAddress.Text = thisRow.Item("JobSiteAddress1")
                    Me.txtCity.Text = thisRow.Item("JobSiteCity")
                    Me.txtState.Text = thisRow.Item("JobSiteState")
                    Me.txtZip.Text = thisRow.Item("JobSiteZip")
                    Me.txtPO.Text = IIf(IsDBNull(thisRow.Item("JobPO")), "", thisRow.Item("JobPO"))
                    Me.txtAttn.Text = IIf(IsDBNull(thisRow.Item("Attn")), "", thisRow.Item("Attn"))
                    Me.txtREF.Text = IIf(IsDBNull(thisRow.Item("RefNo")), "", thisRow.Item("RefNo"))
                    Me.ManifestText.Text = IIf(IsDBNull(thisRow.Item("ManifestText")), "", thisRow.Item("ManifestText"))
                    Me.txtManifest.Text = IIf(IsDBNull(thisRow.Item("ManifestNo")), "", thisRow.Item("ManifestNo"))
                    Me.cmbTransporter.SelectedValue = thisRow.Item("TransporterID")
                    Me.cmbProducts.SelectedValue = thisRow.Item("ProductId")
                    Me.txtTruckNo.Text = IIf(IsDBNull(thisRow.Item("TruckNo")), "", thisRow.Item("TruckNo"))
                    Me.txtDriver.Text = IIf(IsDBNull(thisRow.Item("DriverName")), "", thisRow.Item("DriverName"))
                    Me.cmbDisposal.SelectedValue = thisRow.Item("DisposalFacilityID")
                    Me.cmbUAMer.SelectedText = IIf(IsDBNull(thisRow.Item("U_Arrived_M")), "AM", thisRow.Item("U_Arrived_M"))
                    Me.cmbUDMer.SelectedText = IIf(IsDBNull(thisRow.Item("U_Departed_M")), "AM", thisRow.Item("U_Departed_M"))
                    Me.cmbCAMer.SelectedText = IIf(IsDBNull(thisRow.Item("C_Arrived_M")), "AM", thisRow.Item("C_Arrived_M"))
                    Me.cmbCDMer.SelectedText = IIf(IsDBNull(thisRow.Item("C_Departed_M")), "AM", thisRow.Item("C_Departed_M"))
                    Me.txtCArrived.Text = IIf(IsDBNull(thisRow.Item("C_Arrived")), "", thisRow.Item("C_Arrived"))
                    Me.txtCDeparted.Text = IIf(IsDBNull(thisRow.Item("C_Departed")), "", thisRow.Item("C_Departed"))
                    Me.txtPumpingFinish.Text = IIf(IsDBNull(thisRow.Item("P_Finish")), "", thisRow.Item("P_Finish"))
                    Me.txtPumpingStart.Text = IIf(IsDBNull(thisRow.Item("P_Start")), "", thisRow.Item("P_Start"))
                    Me.txtUArrived.Text = IIf(IsDBNull(thisRow.Item("U_Arrived")), "", thisRow.Item("U_Arrived"))
                    Me.txtUDeparted.Text = IIf(IsDBNull(thisRow.Item("U_Departed")), "", thisRow.Item("U_Departed"))
                    Me.TicketNo.Text = IIf(IsDBNull(thisRow.Item("TicketNo")), "", thisRow.Item("TicketNo"))
                    If IsDBNull(thisRow.Item("BSW")) = False AndAlso thisRow.Item("BSW") > 0 Then
                        Me.txtBSW.Text = thisRow.Item("BSW").ToString
                    Else
                        Me.txtBSW.Text = ""
                    End If
                    Me.cmbWasteType.Text = IIf(IsDBNull(thisRow.Item("WasteType")), " ", thisRow.Item("WasteType"))
                    Me.lblGenILNo.Text = IIf(IsDBNull(thisRow.Item("G_ILNumber")), "", thisRow.Item("G_ILNumber"))
                    Me.lblGenerator.Text = IIf(IsDBNull(thisRow.Item("GeneratorName")), "", thisRow.Item("GeneratorName"))
                    Me.lblApprovalNo.Text = IIf(IsDBNull(thisRow.Item("ApprovalNo")), "", thisRow.Item("ApprovalNo"))
                    If IsDBNull(DS.Tables(0).Rows(0).Item("G_USEPAID")) = False Then Me.lblGID.Text = DS.Tables(0).Rows(0).Item("G_USEPAID").ToString Else Me.lblGID.Text = ""
                    '#IsDrum
                    Dim IsDrum As Boolean = False
                    Dim Gallons As Decimal = 0
                    IsDrum = IIf(IsDBNull(thisRow.Item("Drums")), False, thisRow.Item("Drums"))
                    Me.txtGallons.Text = IIf(IsDBNull(thisRow.Item("Gallons")), 0, thisRow.Item("Gallons"))
                    Me.chkDrums.Checked = IsDrum
                    Me.prodID = thisRow.Item("ProductID")
                    Me.genID = thisRow.Item("GeneratorID")
                    Me.populateDatagrid()
                    If IsDBNull(thisRow.Item("CWTCode")) = False Then
                        Dim str As String = thisRow.Item("CWTCode")
                        If str.Length > 0 Then
                            Me.lblCWTCode.Text = str
                        End If
                    End If
                End If

            Catch ex As SystemException
                MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

            Finally
                DS = Nothing
                Cursor.Current = System.Windows.Forms.Cursors.Default

            End Try

        Else
            MsgBox("Cannot find the requested Job Ticket.", MsgBoxStyle.Information, "Cannot find")

        End If

    End Function

    Function Bind_ComboBoxes()

        Dim dsT As DataSet, dsD As DataSet, dsProduct As DataSet
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            dsT = DBHelper.GetDataSet("SELECT TransporterID, TransporterName + ' : ' + T_ILNumber as TransporterName FROM tblTransporters ORDER BY TransporterName", "tblTransporters")
            Me.cmbTransporter.DataSource = dsT
            Me.cmbTransporter.DisplayMember = "tblTransporters.TransporterName"
            Me.cmbTransporter.ValueMember = "tblTransporters.TransporterID"

            dsD = DBHelper.GetDataSet("SELECT DisposalFacilityID, DisposalFacilityName + ' - ' + FCity as DisposalFacilityName FROM tblDisposalFacilities ORDER BY DisposalFacilityName", "tblDisposal")
            Me.cmbDisposal.DataSource = dsD
            Me.cmbDisposal.DisplayMember = "tblDisposal.DisposalFacilityName"
            Me.cmbDisposal.ValueMember = "tblDisposal.DisposalFacilityID"

            dsProduct = DBHelper.GetDataSet("SELECT ProductId, ProductName + ' - ' + ApprovalNo as ProductName FROM tblProducts ORDER BY ProductName", "tblProducts")
            Me.cmbProducts.DataSource = dsProduct
            Me.cmbProducts.DisplayMember = "tblProducts.ProductName"
            Me.cmbProducts.ValueMember = "tblProducts.ProductId"

            Dim dsWorkType As DataSet
            Dim strSQL As String = ""
            strSQL = "SELECT WasteType FROM tblWasteType ORDER BY ID"
            dsWorkType = DBHelper.GetDataSet(strSQL, "tblWasteType")
            Me.cmbWasteType.DataSource = dsWorkType
            Me.cmbWasteType.DisplayMember = "tblWasteType.WasteType"
            Me.cmbWasteType.SelectedText = ""
            Me.cmbWasteType.Text = ""

        Catch ex As SystemException
            MsgBox("One or more data tables are missing.", MsgBoxStyle.Information, "Error ocurred")

        Finally
            dsD = Nothing
            dsT = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Function

    Private Sub btnCancelJT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelJT.Click

        Me.Close()

    End Sub

    Private Sub btnSaveJT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveJT.Click, btnClose.Click

        Dim strSQL As String
        Dim strWasteType As String = ""
        strWasteType = Me.cmbWasteType.Text

        'Error Checking
        If Me.TicketNo.Text = "" Then
            MsgBox("Invalid Ticket #. Ticket # must be entered.", MsgBoxStyle.Information, "Invalid Ticket #")
            Me.TicketNo.Focus()
            Exit Sub
        End If
        If IsNumeric(Me.TicketNo.Text) = False Then
            MsgBox("Invalid Ticket #. Ticket # must be a number.", MsgBoxStyle.Information, "Invalid Ticket #")
            Me.TicketNo.Focus()
            Exit Sub
        End If
        If CLng(Me.TicketNo.Text) <= 0 Then
            MsgBox("Invalid Ticket #. Ticket # must be a valid number.", MsgBoxStyle.Information, "Invalid Ticket #")
            Me.TicketNo.Focus()
            Exit Sub
        End If
        If Me.txtScheduleDate.Text.Trim = "" Then
            MsgBox("Invalid Schedule date. Enter Schedule Date.", MsgBoxStyle.Information, "Schedule date")
            Me.txtScheduleDate.Focus()
            Exit Sub
        Else
            If Me.txtScheduleDate.Text <> "" AndAlso IsDate(Me.txtScheduleDate.Text) = False Then
                MsgBox("Invalid date. Date must be a date format.", MsgBoxStyle.Information, "Invalid date")
                Me.txtScheduleDate.Focus()
                Exit Sub
            End If
        End If
        If Me.cmbTransporter.SelectedIndex < 0 Then
            MsgBox("HAULER not selected. Please select the HAULER.", MsgBoxStyle.Information, "Missing HAULER")
            Me.cmbTransporter.Focus()
            Exit Sub
        End If
        If Me.cmbDisposal.SelectedIndex < 0 Then
            MsgBox("RECEIVING SITE not selected. Please select the RECEIVING SITE.", MsgBoxStyle.Information, "Missing RECEIVING SITE")
            Me.cmbTransporter.Focus()
            Exit Sub
        End If
        If dgQuantity.VisibleRowCount <= 0 Then
            MsgBox("Need at least one Quantity value breakdown.", MsgBoxStyle.Information, "Quantity missing")
            Me.dgQuantity.Focus()
            Exit Sub
        End If
        Dim bsw As Decimal
        If Me.txtBSW.Text.Trim <> "" Then
            If IsNumeric(Me.txtBSW.Text.Trim) = False Then
                MsgBox("BS+W(%) must be numeric value.", MsgBoxStyle.Information, "Quantity missing")
                Me.txtBSW.Focus()
                Exit Sub
            Else
                bsw = Decimal.Round(Decimal.Parse(Me.txtBSW.Text), 2)
            End If
        Else
            Me.txtBSW.Text = 0
        End If

        'Default values if not entered
        If Me.txtScheduleDate.Text = "" Then
            Me.txtScheduleDate.Text = Today.ToShortDateString
        End If
        If Me.cmbUAMer.SelectedText <> "AM" And Me.cmbUAMer.SelectedText <> "PM" Then
            Me.cmbUAMer.SelectedText = "AM"
        End If
        If Me.cmbUDMer.SelectedText <> "AM" And Me.cmbUDMer.SelectedText <> "PM" Then
            Me.cmbUDMer.SelectedText = "AM"
        End If
        If Me.cmbCAMer.SelectedText <> "AM" And Me.cmbCAMer.SelectedText <> "PM" Then
            Me.cmbCAMer.SelectedText = "AM"
        End If
        If Me.cmbCDMer.SelectedText <> "AM" And Me.cmbCDMer.SelectedText <> "PM" Then
            Me.cmbCDMer.SelectedText = "AM"
        End If
        Dim IsDrums As Boolean = False
        IsDrums = Me.chkDrums.Checked

        Dim Gallons As Decimal = 0
        If Me.txtGallons.Text <> "" AndAlso IsNumeric(Me.txtGallons.Text) = False Then
            MsgBox("Gallons field must be Numeric.")
            Exit Sub
        ElseIf Me.txtGallons.Text <> "" AndAlso CInt(Me.txtGallons.Text) > 0 Then
            Gallons = Me.txtGallons.Text
        Else
            Gallons = 0
        End If

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            If CType(sender, Button).Name = "btnClose" Then
                strSQL = "UPDATE tblJobTickets SET JobTicketDate = #" & Me.txtScheduleDate.Text & "#, ScheduleDate = #" & Me.txtScheduleDate.Text & "#, JobPO='" & Replace(Me.txtPO.Text, "'", "''") & "', " _
                                & "Attn='" & Replace(Me.txtAttn.Text, "'", "''") & "', ProductId=" & Me.cmbProducts.SelectedValue & ", TransporterID=" & Me.cmbTransporter.SelectedValue & ",DisposalFacilityID=" & Me.cmbDisposal.SelectedValue & "," _
                                & "TruckNo='" & Replace(Me.txtTruckNo.Text, "'", "''") & "',DriverName='" & Replace(Me.txtDriver.Text, "'", "''") & "'," _
                                & "ManifestNo='" & Replace(Me.txtManifest.Text, "'", "''") & "', RefNo='" & Replace(Me.txtREF.Text, "'", "''") & "', DriverRemarks='" & Replace(Me.txtNotes.Text, "'", "''") & "'," _
                                & "C_Arrived='" & Replace(Me.txtCArrived.Text, "'", "''") & "',C_Departed='" & Replace(Me.txtCDeparted.Text, "'", "''") & "',C_Arrived_M='" & Me.cmbUAMer.SelectedText & "',C_Departed_M='" & Me.cmbCDMer.SelectedText & "'," _
                                & "P_Start='" & Replace(Me.txtPumpingStart.Text, "'", "''") & "',P_Finish='" & Replace(Me.txtPumpingFinish.Text, "'", "''") & "',U_Arrived='" & Replace(Me.txtUArrived.Text, "'", "''") & "'," _
                                & "U_Departed='" & Replace(Me.txtUDeparted.Text, "'", "''") & "', JobTicketSubmitted = True, TicketNo = " & Me.TicketNo.Text & ", ManifestText = '" & Replace(Me.ManifestText.Text, "'", "''") & "',BSW =" & CType(Me.txtBSW.Text.Trim, Decimal) & "," _
                                & " JobClosed = True,Drums = " & IsDrums & ", WasteType = '" & strWasteType & "',Gallons = " & Gallons & " WHERE JobTicketID = " & jtID

            Else
                strSQL = "UPDATE tblJobTickets SET JobTicketDate = #" & Me.txtScheduleDate.Text & "#, ScheduleDate = #" & Me.txtScheduleDate.Text & "#, JobPO='" & Replace(Me.txtPO.Text, "'", "''") & "', " _
                        & "Attn='" & Replace(Me.txtAttn.Text, "'", "''") & "',ProductId =" & Me.cmbProducts.SelectedValue & ", TransporterID=" & Me.cmbTransporter.SelectedValue & ",DisposalFacilityID=" & Me.cmbDisposal.SelectedValue & "," _
                        & "TruckNo='" & Replace(Me.txtTruckNo.Text, "'", "''") & "',DriverName='" & Replace(Me.txtDriver.Text, "'", "''") & "'," _
                        & "ManifestNo='" & Replace(Me.txtManifest.Text, "'", "''") & "', RefNo='" & Replace(Me.txtREF.Text, "'", "''") & "', DriverRemarks='" & Replace(Me.txtNotes.Text, "'", "''") & "'," _
                        & "C_Arrived='" & Replace(Me.txtCArrived.Text, "'", "''") & "',C_Departed='" & Replace(Me.txtCDeparted.Text, "'", "''") & "',C_Arrived_M='" & Me.cmbUAMer.SelectedText & "',C_Departed_M='" & Me.cmbCDMer.SelectedText & "'," _
                        & "P_Start='" & Replace(Me.txtPumpingStart.Text, "'", "''") & "',P_Finish='" & Replace(Me.txtPumpingFinish.Text, "'", "''") & "',U_Arrived='" & Replace(Me.txtUArrived.Text, "'", "''") & "'," _
                        & "U_Departed='" & Replace(Me.txtUDeparted.Text, "'", "''") & "', JobTicketSubmitted = True, TicketNo = " & Me.TicketNo.Text & ", ManifestText = '" & Replace(Me.ManifestText.Text, "'", "''") & "',BSW =" & CType(Me.txtBSW.Text.Trim, Decimal) & "," _
                        & " Drums = " & IsDrums & ",WasteType = '" & strWasteType & "',Gallons = " & Gallons & " WHERE JobTicketID = " & jtID

            End If

            If DBHelper.ExecuteQuery(strSQL) = False Then
                MsgBox("An error ocurred while performing this operation. Your information has not been saved.", MsgBoxStyle.Information, "Error ocurred")
            End If
            'Update the Datagrid
            If Me.DsJobTicket_Details1.HasChanges = True Then
                Me.DAQuantity.Update(Me.DsJobTicket_Details1)
            End If

        Catch ex As SystemException

            MsgBox(ex.Message, MsgBoxStyle.Information, "Error ocurred")

        Finally
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
        'Save and Close
        Me.Close()
        If Me.lblWhatForm.Text = "frmPaperwork" Then
            DirectCast(Owner, frmPaperwork).populateDatagrid()
        ElseIf Me.lblWhatForm.Text = "frmInvoicing" Then
            DirectCast(Owner, frmInvoicing).populateDatagrid(ClosedFlag)
        ElseIf Me.lblWhatForm.Text = "frmReceivables" Then
            DirectCast(Owner, frmReceivables).populateDatagrid()
        End If
    End Sub

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

    Private Sub cmbDisposal_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbDisposal.KeyUp

        Dim index As Integer, actual As String, found As String
        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Back) Or (e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        ' Store the actual text that has been typed
        actual = Me.cmbDisposal.Text
        ' Find the first match for the typed value
        index = Me.cmbDisposal.FindString(actual)
        ' Get the text of the first match
        If (index > -1) Then
            ' Select this item from the list
            Me.cmbDisposal.SelectedIndex = index
            found = Me.cmbDisposal.Text
            ' Select the portion of the text that was automatically added so further typing will replace it
            Me.cmbDisposal.SelectionStart = actual.Length
            Me.cmbDisposal.SelectionLength = found.Length - actual.Length
        End If

    End Sub

    'Function getDefaultRates()

    '    Dim ds As DataSet, aConn As OleDb.OleDbConnection
    '    Dim prdID As Long, i As Integer
    '    Try

    '        prdID = DBHelper.GetInteger("SELECT ProductID FROM tblJobTickets WHERE JobTicketID = " & Me.jtID & "")
    '        ds = DBHelper.GetDataSet("SELECT * FROM tblProductRates WHERE ProductID = " & prdID & "", "tblProductRates")
    '        If ds.Tables(0).Rows.Count <= 0 Then Exit Function
    '        For i = 0 To ds.Tables(0).Rows.Count - 1
    '            DBHelper.ExecuteQuery("INSERT INTO tblJobTickets_Details (JobTicketID, Quantity, Description, ItemIRate, ItemIAmount) SELECT " & Me.jtID & ", 1, '" & ds.Tables(0).Rows(i).Item("RateDesc") & "', " & ds.Tables(0).Rows(i).Item("Rate") & ", " & ds.Tables(0).Rows(i).Item("Rate") & "")
    '        Next
    '        'Connect to Database and fill Dataset
    '        aConn = DBHelper.Connect
    '        Me.DsJobTicket_Details1.Clear()
    '        Me.SelectJobDetails.CommandText = "SELECT JobDetailID, JobTicketID, Quantity, Description, UOM FROM tblJobTickets_Details WHERE JobTicketID = " & Me.jtID
    '        Me.DAQuantity.Fill(Me.DsJobTicket_Details1, "tblJobTickets_Details")
    '        Me.DsJobTicket_Details1.Tables(0).Columns("JobTicketID").DefaultValue = jtID
    '        'bind the table to the datagrid
    '        Me.dgQuantity.Refresh()

    '    Catch ex As Exception

    '        MsgBox(ex.Message, MsgBoxStyle.Information, "Error ocurred")

    '    Finally

    '        If IsNothing(aConn) = False Then
    '            If aConn.State = ConnectionState.Open Then
    '                aConn.Close()
    '            End If
    '        End If
    '        aConn = Nothing
    '    End Try

    'End Function

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim iCount As Integer
        iCount = DBHelper.GetInteger("SELECT Count(*) FROM tblInvoicing WHERE JobTicketID = " & jtID & "")
        If iCount > 0 Then
            MsgBox("Job Ticket contain active invoice. So you can not delete this Job Ticket.")
            Exit Sub
        Else
            If MsgBox("It will delete the job ticket permanently from the System. Are you sure?", MsgBoxStyle.YesNo, "Confirm Message") = MsgBoxResult.Yes Then
                Dim strSQL As String = String.Empty
                strSQL = "UPDATE tblJobTickets SET IsCancelled = TRUE WHERE JobTicketID = " & jtID
                If DBHelper.ExecuteQuery(strSQL) = False Then
                    MsgBox("An error ocurred while performing this operation. Your information has not been saved.", MsgBoxStyle.Information, "Error ocurred")
                    Exit Sub
                End If
                If Me.lblWhatForm.Text = "frmPaperwork" Then
                    DirectCast(Owner, frmPaperwork).populateDatagrid()
                ElseIf Me.lblWhatForm.Text = "frmInvoicing" Then
                    DirectCast(Owner, frmInvoicing).populateDatagrid(ClosedFlag)
                ElseIf Me.lblWhatForm.Text = "frmReceivables" Then
                    DirectCast(Owner, frmReceivables).populateDatagrid()
                End If
                'DirectCast(Owner, frmInvoicing).populateDatagrid(ClosedFlag)
                'strSQL = "DELETE FROM tblJobTickets_Details WHERE JobTicketID = " & jtID
                'If DBHelper.ExecuteQuery(strSQL) = False Then
                '    MsgBox("An error ocurred while performing this operation. Your information has not been saved.", MsgBoxStyle.Information, "Error ocurred")
                '    Exit Sub
                'End If
                Me.Close()
            End If
        End If

    End Sub

    Private Sub btnViewProductInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewProductInfo.Click

        If Me.prodID > 0 And Me.genID > 0 Then

            Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Dim frmP As New frmProduct
            frmP.Visible = True
            frmP.genID = Me.genID
            frmP.prodID = Me.prodID
            frmP.ViewProductInfo(Me.prodID, Me.genID)
            frmP.GeneratorID.SelectedValue = Me.genID
            frmP.lblGen.Text = DBHelper.GetStringVar("SELECT GeneratorName FROM tblGenerators WHERE GeneratorID = " & Me.genID & "")
            frmP.lblGAdd.Text = DBHelper.GetStringVar("SELECT JobSiteAddress1 FROM tblGenerators WHERE GeneratorID = " & Me.genID & "")
            frmP.lblGCityStateZip.Text = DBHelper.GetStringVar("SELECT (JobSiteCity + ', ' + JobSiteState + ' ' + JobSiteZip) FROM tblGenerators WHERE GeneratorID = " & Me.genID & "")
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End If

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

    Private Sub cmbProducts_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProducts.SelectionChangeCommitted
        Dim str1 As String = String.Empty
        If Me.cmbProducts.SelectedIndex >= 0 Then
            str1 = cmbProducts.Text
        End If
        If str1.Length > 0 Then
            If Mid(str1, str1.LastIndexOf("-") + 2).Length > 0 Then
                Me.lblApprovalNo.Text = Mid(str1, str1.LastIndexOf("-") + 2).Trim()
            End If
        End If
    End Sub
End Class
