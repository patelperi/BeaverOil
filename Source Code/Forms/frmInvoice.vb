imports BeaverOil.KnowDotNet  
Public Class frmInvoice
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "
    Public ClosedFlag As Boolean = False
    Public Sub New(Optional ByVal Flag As Boolean = False)
        MyBase.New()
        ClosedFlag = Flag
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
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents txtInvoiceID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceDate As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtJobSite As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblReqField As System.Windows.Forms.Label
    Friend WithEvents btnCancelI As System.Windows.Forms.Button
    Friend WithEvents btnSaveI As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnPrintCopies As System.Windows.Forms.Button
    Friend WithEvents txtInvoiceAmount As System.Windows.Forms.TextBox
    Friend WithEvents DsInvoice_Details1 As BeaverOil.DSInvoice_Details
    Friend WithEvents dgInvoiceDetails As System.Windows.Forms.DataGrid
    Friend WithEvents ts_DGInvoiceDetails As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents col_JDid As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_JTid As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_JTq As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_JTDesc As KDNGrid.CGridMultiLineTextBoxStyle
    Friend WithEvents col_JTIAmount As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lblWhatForm As System.Windows.Forms.Label
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DAInvoiceDetails As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents col_JUOM As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_JTIRate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DAPrintInvoice As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents SelectInvoice As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsPrintInvoice1 As BeaverOil.DSPrintInvoice
    Friend WithEvents grpType As System.Windows.Forms.GroupBox
    Friend WithEvents rdnReg As System.Windows.Forms.RadioButton
    Friend WithEvents rdnList As System.Windows.Forms.RadioButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceDesc As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dgRates As System.Windows.Forms.DataGrid
    Friend WithEvents btnRates As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DAProduct As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents SelectProductRates As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsPRates1 As BeaverOil.dsPRates
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents SelectInvoiceDetails As System.Data.OleDb.OleDbCommand
    Friend WithEvents btnGenInfo As System.Windows.Forms.Button
    Friend WithEvents lblIncompleteGenInfo As System.Windows.Forms.Label
    Friend WithEvents col_JT_Desc As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtAttn As System.Windows.Forms.TextBox
    Friend WithEvents txtPO As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtGallons As System.Windows.Forms.TextBox
    Friend WithEvents lblGallons As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox
        Me.txtInvoiceID = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtInvoiceDate = New System.Windows.Forms.TextBox
        Me.lblReqField = New System.Windows.Forms.Label
        Me.txtZip = New System.Windows.Forms.Label
        Me.txtState = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCity = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtJobSite = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtCustomerName = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.dgInvoiceDetails = New System.Windows.Forms.DataGrid
        Me.DsInvoice_Details1 = New BeaverOil.DSInvoice_Details
        Me.ts_DGInvoiceDetails = New System.Windows.Forms.DataGridTableStyle
        Me.col_JDid = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_JTid = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_JT_Desc = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_JTq = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_JUOM = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_JTIRate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_JTIAmount = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnCancelI = New System.Windows.Forms.Button
        Me.btnSaveI = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtInvoiceAmount = New System.Windows.Forms.TextBox
        Me.btnPrintCopies = New System.Windows.Forms.Button
        Me.lblWhatForm = New System.Windows.Forms.Label
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.DAInvoiceDetails = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.SelectInvoiceDetails = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.DAPrintInvoice = New System.Data.OleDb.OleDbDataAdapter
        Me.SelectInvoice = New System.Data.OleDb.OleDbCommand
        Me.grpType = New System.Windows.Forms.GroupBox
        Me.rdnList = New System.Windows.Forms.RadioButton
        Me.rdnReg = New System.Windows.Forms.RadioButton
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtInvoiceDesc = New System.Windows.Forms.TextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.dgRates = New System.Windows.Forms.DataGrid
        Me.DsPRates1 = New BeaverOil.dsPRates
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnRates = New System.Windows.Forms.Button
        Me.DAProduct = New System.Data.OleDb.OleDbDataAdapter
        Me.SelectProductRates = New System.Data.OleDb.OleDbCommand
        Me.btnGenInfo = New System.Windows.Forms.Button
        Me.lblIncompleteGenInfo = New System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button
        Me.txtAttn = New System.Windows.Forms.TextBox
        Me.txtPO = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtGallons = New System.Windows.Forms.TextBox
        Me.lblGallons = New System.Windows.Forms.Label
        CType(Me.dgInvoiceDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsInvoice_Details1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpType.SuspendLayout()
        CType(Me.dgRates, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPRates1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInvoiceNo.Location = New System.Drawing.Point(512, 16)
        Me.txtInvoiceNo.MaxLength = 10
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(96, 14)
        Me.txtInvoiceNo.TabIndex = 1
        Me.txtInvoiceNo.Text = ""
        '
        'txtInvoiceID
        '
        Me.txtInvoiceID.Location = New System.Drawing.Point(8, 8)
        Me.txtInvoiceID.Name = "txtInvoiceID"
        Me.txtInvoiceID.Size = New System.Drawing.Size(24, 8)
        Me.txtInvoiceID.TabIndex = 1
        Me.txtInvoiceID.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(424, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Invoice No"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(424, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Invoice Date"
        '
        'txtInvoiceDate
        '
        Me.txtInvoiceDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInvoiceDate.Location = New System.Drawing.Point(512, 36)
        Me.txtInvoiceDate.MaxLength = 8
        Me.txtInvoiceDate.Name = "txtInvoiceDate"
        Me.txtInvoiceDate.Size = New System.Drawing.Size(96, 14)
        Me.txtInvoiceDate.TabIndex = 2
        Me.txtInvoiceDate.Text = ""
        '
        'lblReqField
        '
        Me.lblReqField.Location = New System.Drawing.Point(0, 24)
        Me.lblReqField.Name = "lblReqField"
        Me.lblReqField.Size = New System.Drawing.Size(24, 8)
        Me.lblReqField.TabIndex = 5
        Me.lblReqField.Visible = False
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(320, 88)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(96, 16)
        Me.txtZip.TabIndex = 38
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(272, 88)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(40, 16)
        Me.txtState.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(320, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 1)
        Me.Label9.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(272, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 1)
        Me.Label5.TabIndex = 35
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(120, 88)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(144, 16)
        Me.txtCity.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(112, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 1)
        Me.Label10.TabIndex = 33
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(120, 64)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(296, 16)
        Me.txtAddress.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(112, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(304, 1)
        Me.Label8.TabIndex = 31
        '
        'txtJobSite
        '
        Me.txtJobSite.Location = New System.Drawing.Point(120, 40)
        Me.txtJobSite.Name = "txtJobSite"
        Me.txtJobSite.Size = New System.Drawing.Size(296, 16)
        Me.txtJobSite.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(112, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(304, 1)
        Me.Label6.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(32, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "JOB SITE"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(120, 16)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(296, 16)
        Me.txtCustomerName.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(112, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(304, 1)
        Me.Label3.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(32, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "CUSTOMER"
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(512, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 1)
        Me.Label11.TabIndex = 39
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Location = New System.Drawing.Point(512, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 1)
        Me.Label12.TabIndex = 40
        '
        'Label26
        '
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label26.Location = New System.Drawing.Point(32, 160)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(1, 224)
        Me.Label26.TabIndex = 50
        '
        'Label25
        '
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label25.Location = New System.Drawing.Point(576, 160)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(1, 224)
        Me.Label25.TabIndex = 49
        '
        'Label24
        '
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.Location = New System.Drawing.Point(32, 160)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(544, 1)
        Me.Label24.TabIndex = 48
        '
        'Label23
        '
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Location = New System.Drawing.Point(32, 384)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(892, 1)
        Me.Label23.TabIndex = 47
        '
        'dgInvoiceDetails
        '
        Me.dgInvoiceDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgInvoiceDetails.CaptionVisible = False
        Me.dgInvoiceDetails.DataMember = "tblInvoice_Details"
        Me.dgInvoiceDetails.DataSource = Me.DsInvoice_Details1
        Me.dgInvoiceDetails.FlatMode = True
        Me.dgInvoiceDetails.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgInvoiceDetails.Location = New System.Drawing.Point(32, 160)
        Me.dgInvoiceDetails.Name = "dgInvoiceDetails"
        Me.dgInvoiceDetails.ParentRowsVisible = False
        Me.dgInvoiceDetails.Size = New System.Drawing.Size(892, 224)
        Me.dgInvoiceDetails.TabIndex = 5
        Me.dgInvoiceDetails.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.ts_DGInvoiceDetails})
        '
        'DsInvoice_Details1
        '
        Me.DsInvoice_Details1.DataSetName = "DSInvoice_Details"
        Me.DsInvoice_Details1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'ts_DGInvoiceDetails
        '
        Me.ts_DGInvoiceDetails.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.ts_DGInvoiceDetails.DataGrid = Me.dgInvoiceDetails
        Me.ts_DGInvoiceDetails.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.col_JDid, Me.col_JTid, Me.col_JT_Desc, Me.col_JTq, Me.col_JUOM, Me.col_JTIRate, Me.col_JTIAmount})
        Me.ts_DGInvoiceDetails.GridLineColor = System.Drawing.Color.Black
        Me.ts_DGInvoiceDetails.HeaderBackColor = System.Drawing.Color.SteelBlue
        Me.ts_DGInvoiceDetails.HeaderFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_DGInvoiceDetails.HeaderForeColor = System.Drawing.Color.White
        Me.ts_DGInvoiceDetails.MappingName = "tblInvoice_Details"
        Me.ts_DGInvoiceDetails.RowHeadersVisible = False
        '
        'col_JDid
        '
        Me.col_JDid.Format = ""
        Me.col_JDid.FormatInfo = Nothing
        Me.col_JDid.MappingName = "JobDetailID"
        Me.col_JDid.Width = 0
        '
        'col_JTid
        '
        Me.col_JTid.Format = ""
        Me.col_JTid.FormatInfo = Nothing
        Me.col_JTid.MappingName = "JobTicketID"
        Me.col_JTid.Width = 0
        '
        'col_JT_Desc
        '
        Me.col_JT_Desc.Format = ""
        Me.col_JT_Desc.FormatInfo = Nothing
        Me.col_JT_Desc.HeaderText = "Description"
        Me.col_JT_Desc.MappingName = "Description"
        Me.col_JT_Desc.NullText = ""
        Me.col_JT_Desc.Width = 540
        '
        'col_JTq
        '
        Me.col_JTq.Format = "G"
        Me.col_JTq.FormatInfo = Nothing
        Me.col_JTq.HeaderText = "Quantity"
        Me.col_JTq.MappingName = "Quantity"
        Me.col_JTq.NullText = ""
        Me.col_JTq.Width = 80
        '
        'col_JUOM
        '
        Me.col_JUOM.Format = ""
        Me.col_JUOM.FormatInfo = Nothing
        Me.col_JUOM.HeaderText = "UOM"
        Me.col_JUOM.MappingName = "UOM"
        Me.col_JUOM.NullText = ""
        Me.col_JUOM.Width = 60
        '
        'col_JTIRate
        '
        Me.col_JTIRate.Format = "G"
        Me.col_JTIRate.FormatInfo = Nothing
        Me.col_JTIRate.HeaderText = "Rate"
        Me.col_JTIRate.MappingName = "ItemIRate"
        Me.col_JTIRate.NullText = "0"
        Me.col_JTIRate.Width = 70
        '
        'col_JTIAmount
        '
        Me.col_JTIAmount.Format = "c"
        Me.col_JTIAmount.FormatInfo = Nothing
        Me.col_JTIAmount.HeaderText = "Inv. Amount"
        Me.col_JTIAmount.MappingName = "ItemIAmount"
        Me.col_JTIAmount.NullText = ""
        Me.col_JTIAmount.Width = 115
        '
        'btnCancelI
        '
        Me.btnCancelI.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCancelI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelI.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelI.Location = New System.Drawing.Point(106, 424)
        Me.btnCancelI.Name = "btnCancelI"
        Me.btnCancelI.Size = New System.Drawing.Size(112, 24)
        Me.btnCancelI.TabIndex = 6
        Me.btnCancelI.Text = "Cancel"
        '
        'btnSaveI
        '
        Me.btnSaveI.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSaveI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveI.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveI.Location = New System.Drawing.Point(220, 424)
        Me.btnSaveI.Name = "btnSaveI"
        Me.btnSaveI.Size = New System.Drawing.Size(126, 24)
        Me.btnSaveI.TabIndex = 7
        Me.btnSaveI.Text = "Save && Close"
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(820, 404)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 1)
        Me.Label13.TabIndex = 82
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(674, 388)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 16)
        Me.Label14.TabIndex = 81
        Me.Label14.Text = "Total Invoice Amount:"
        '
        'txtInvoiceAmount
        '
        Me.txtInvoiceAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInvoiceAmount.Location = New System.Drawing.Point(826, 388)
        Me.txtInvoiceAmount.MaxLength = 20
        Me.txtInvoiceAmount.Name = "txtInvoiceAmount"
        Me.txtInvoiceAmount.Size = New System.Drawing.Size(80, 14)
        Me.txtInvoiceAmount.TabIndex = 80
        Me.txtInvoiceAmount.Text = ""
        '
        'btnPrintCopies
        '
        Me.btnPrintCopies.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPrintCopies.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintCopies.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintCopies.Location = New System.Drawing.Point(464, 424)
        Me.btnPrintCopies.Name = "btnPrintCopies"
        Me.btnPrintCopies.Size = New System.Drawing.Size(128, 24)
        Me.btnPrintCopies.TabIndex = 9
        Me.btnPrintCopies.Text = "&Print Invoice"
        '
        'lblWhatForm
        '
        Me.lblWhatForm.Location = New System.Drawing.Point(0, 40)
        Me.lblWhatForm.Name = "lblWhatForm"
        Me.lblWhatForm.Size = New System.Drawing.Size(24, 8)
        Me.lblWhatForm.TabIndex = 87
        Me.lblWhatForm.Visible = False
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
        'DAInvoiceDetails
        '
        Me.DAInvoiceDetails.InsertCommand = Me.OleDbInsertCommand1
        Me.DAInvoiceDetails.SelectCommand = Me.SelectInvoiceDetails
        Me.DAInvoiceDetails.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblJobTickets_Details", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("Invoiced", "Invoiced"), New System.Data.Common.DataColumnMapping("ItemIAmount", "ItemIAmount"), New System.Data.Common.DataColumnMapping("ItemIRate", "ItemIRate"), New System.Data.Common.DataColumnMapping("JobDetailID", "JobDetailID"), New System.Data.Common.DataColumnMapping("JobTicketID", "JobTicketID"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("UOM", "UOM")})})
        Me.DAInvoiceDetails.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO tblJobTickets_Details(Description, Invoiced, ItemIAmount, ItemIRate, " & _
        "JobTicketID, Quantity, UOM) VALUES (?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 255, "Description"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Invoiced", System.Data.OleDb.OleDbType.Boolean, 2, "Invoiced"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ItemIAmount", System.Data.OleDb.OleDbType.Double, 0, "ItemIAmount"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ItemIRate", System.Data.OleDb.OleDbType.Double, 0, "ItemIRate"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("JobTicketID", System.Data.OleDb.OleDbType.Integer, 0, "JobTicketID"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Quantity", System.Data.OleDb.OleDbType.Double, 0, "Quantity"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("UOM", System.Data.OleDb.OleDbType.VarWChar, 50, "UOM"))
        '
        'SelectInvoiceDetails
        '
        Me.SelectInvoiceDetails.CommandText = "SELECT Description, Invoiced, ItemIAmount, ItemIRate, JobDetailID, JobTicketID, Q" & _
        "uantity, UOM FROM tblJobTickets_Details"
        Me.SelectInvoiceDetails.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE tblJobTickets_Details SET Description = ?, Invoiced = ?, ItemIAmount = ?, " & _
        "ItemIRate = ?, JobTicketID = ?, Quantity = ?, UOM = ? WHERE (JobDetailID = ?) AN" & _
        "D (Description = ? OR ? IS NULL AND Description IS NULL) AND (Invoiced = ?) AND " & _
        "(ItemIAmount = ? OR ? IS NULL AND ItemIAmount IS NULL) AND (ItemIRate = ? OR ? I" & _
        "S NULL AND ItemIRate IS NULL) AND (JobTicketID = ?) AND (Quantity = ?) AND (UOM " & _
        "= ? OR ? IS NULL AND UOM IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 255, "Description"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Invoiced", System.Data.OleDb.OleDbType.Boolean, 2, "Invoiced"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ItemIAmount", System.Data.OleDb.OleDbType.Double, 0, "ItemIAmount"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ItemIRate", System.Data.OleDb.OleDbType.Double, 0, "ItemIRate"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("JobTicketID", System.Data.OleDb.OleDbType.Integer, 0, "JobTicketID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Quantity", System.Data.OleDb.OleDbType.Double, 0, "Quantity"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("UOM", System.Data.OleDb.OleDbType.VarWChar, 50, "UOM"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_JobDetailID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "JobDetailID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Invoiced", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Invoiced", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ItemIAmount", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ItemIAmount", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ItemIAmount1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ItemIAmount", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ItemIRate", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ItemIRate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ItemIRate1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ItemIRate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_JobTicketID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "JobTicketID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Quantity", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UOM", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UOM", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UOM1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UOM", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAPrintInvoice
        '
        Me.DAPrintInvoice.SelectCommand = Me.SelectInvoice
        Me.DAPrintInvoice.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblInvoice_Details", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("InvoiceNo", "InvoiceNo"), New System.Data.Common.DataColumnMapping("InvoiceDate", "InvoiceDate"), New System.Data.Common.DataColumnMapping("InvoiceAmount", "InvoiceAmount"), New System.Data.Common.DataColumnMapping("BillingName", "BillingName"), New System.Data.Common.DataColumnMapping("BillingAddress1", "BillingAddress1"), New System.Data.Common.DataColumnMapping("BillingCity", "BillingCity"), New System.Data.Common.DataColumnMapping("BillingState", "BillingState"), New System.Data.Common.DataColumnMapping("BillingZip", "BillingZip"), New System.Data.Common.DataColumnMapping("DisposalFacilityName", "DisposalFacilityName"), New System.Data.Common.DataColumnMapping("FAddress1", "FAddress1"), New System.Data.Common.DataColumnMapping("FCity", "FCity"), New System.Data.Common.DataColumnMapping("FState", "FState"), New System.Data.Common.DataColumnMapping("FZip", "FZip"), New System.Data.Common.DataColumnMapping("JobTicketDate", "JobTicketDate"), New System.Data.Common.DataColumnMapping("TransporterName", "TransporterName"), New System.Data.Common.DataColumnMapping("GNo", "GNo"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("UOM", "UOM"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("ManifestNo", "ManifestNo"), New System.Data.Common.DataColumnMapping("RefNo", "RefNo"), New System.Data.Common.DataColumnMapping("JobSite", "JobSite"), New System.Data.Common.DataColumnMapping("JobSiteAddress1", "JobSiteAddress1"), New System.Data.Common.DataColumnMapping("JobSiteCity", "JobSiteCity"), New System.Data.Common.DataColumnMapping("JobSiteState", "JobSiteState"), New System.Data.Common.DataColumnMapping("JobSiteZip", "JobSiteZip"), New System.Data.Common.DataColumnMapping("ItemIRate", "ItemIRate"), New System.Data.Common.DataColumnMapping("ItemIAmount", "ItemIAmount"), New System.Data.Common.DataColumnMapping("JobPO", "JobPO"), New System.Data.Common.DataColumnMapping("GeneratorName", "GeneratorName"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("JobTicketID", "JobTicketID"), New System.Data.Common.DataColumnMapping("InvoiceDescription", "InvoiceDescription"), New System.Data.Common.DataColumnMapping("TicketNo", "TicketNo")})})
        '
        'SelectInvoice
        '
        Me.SelectInvoice.CommandText = "SELECT tblInvoicing.InvoiceNo, tblInvoicing.InvoiceDate, tblInvoicing.InvoiceAmou" & _
        "nt, tblGenerators.BillingName, tblGenerators.BillingAddress1 &  ', ' & tblGenera" & _
        "tors.BillingAddress2 as BillingAddress1, tblGenerators.BillingCity, tblGenerator" & _
        "s.BillingState, tblGenerators.BillingZip, tblDisposalFacilities.DisposalFacility" & _
        "Name, tblDisposalFacilities.FAddress1, tblDisposalFacilities.FCity, tblDisposalF" & _
        "acilities.FState, tblDisposalFacilities.FZip, tblJobTickets.ScheduleDate as JobT" & _
        "icketDate, tblTransporters.TransporterName, tblProducts.GenProdNo as GNo,tblJobT" & _
        "ickets_Details.Quantity, tblJobTickets_Details.UOM, tblJobTickets_Details.Descri" & _
        "ption, tblJobTickets.ManifestNo, tblJobTickets.RefNo, tblGenerators.JobSite,tblG" & _
        "enerators.JobSiteAddress1, tblGenerators.JobSiteAddress2, tblGenerators.JobSiteCity, tblGenerators.JobSiteState" & _
        ", tblGenerators.JobSiteZip, tblJobTickets_Details.ItemIRate, tblJobTickets_Detai" & _
        "ls.ItemIAmount, tblJobTickets.JobPO, tblGenerators.GeneratorName, tblProducts.Pr" & _
        "oductName, tblJobTickets.JobTicketID, tblInvoicing.InvoiceDescription, tblJobTic" & _
        "kets.TicketNo FROM ((tblTransporters INNER JOIN (tblDisposalFacilities INNER JOI" & _
        "N (tblGenerators INNER JOIN (tblProducts INNER JOIN (tblJobTickets INNER JOIN tb" & _
        "lInvoicing ON tblJobTickets.JobTicketID = tblInvoicing.JobTicketID) ON tblProduc" & _
        "ts.ProductID = tblJobTickets.ProductID) ON tblGenerators.GeneratorID = tblProduc" & _
        "ts.GeneratorID) ON tblDisposalFacilities.DisposalFacilityID = tblJobTickets.Disp" & _
        "osalFacilityID) ON tblTransporters.TransporterID = tblJobTickets.TransporterID) " & _
        "INNER JOIN tblJobTickets_Details ON tblJobTickets.JobTicketID = tblJobTickets_De" & _
        "tails.JobTicketID)"
        Me.SelectInvoice.Connection = Me.OleDbConnection1
        '
        'grpType
        '
        Me.grpType.Controls.Add(Me.rdnList)
        Me.grpType.Controls.Add(Me.rdnReg)
        Me.grpType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpType.Location = New System.Drawing.Point(424, 54)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(184, 36)
        Me.grpType.TabIndex = 3
        Me.grpType.TabStop = False
        Me.grpType.Text = "Invoice Type"
        '
        'rdnList
        '
        Me.rdnList.Location = New System.Drawing.Point(104, 16)
        Me.rdnList.Name = "rdnList"
        Me.rdnList.Size = New System.Drawing.Size(56, 16)
        Me.rdnList.TabIndex = 1
        Me.rdnList.Text = "List"
        '
        'rdnReg
        '
        Me.rdnReg.Checked = True
        Me.rdnReg.Location = New System.Drawing.Point(16, 16)
        Me.rdnReg.Name = "rdnReg"
        Me.rdnReg.Size = New System.Drawing.Size(72, 16)
        Me.rdnReg.TabIndex = 0
        Me.rdnReg.TabStop = True
        Me.rdnReg.Text = "Regular"
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Location = New System.Drawing.Point(184, 156)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(424, 1)
        Me.Label16.TabIndex = 90
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(32, 140)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(144, 16)
        Me.Label17.TabIndex = 89
        Me.Label17.Text = "INVOICE DESCRIPTION"
        '
        'txtInvoiceDesc
        '
        Me.txtInvoiceDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInvoiceDesc.Location = New System.Drawing.Point(192, 140)
        Me.txtInvoiceDesc.MaxLength = 255
        Me.txtInvoiceDesc.Name = "txtInvoiceDesc"
        Me.txtInvoiceDesc.Size = New System.Drawing.Size(408, 14)
        Me.txtInvoiceDesc.TabIndex = 4
        Me.txtInvoiceDesc.Text = ""
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(348, 424)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(114, 24)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "&Save"
        '
        'dgRates
        '
        Me.dgRates.CaptionVisible = False
        Me.dgRates.DataMember = "tblProductRates"
        Me.dgRates.DataSource = Me.DsPRates1
        Me.dgRates.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgRates.Location = New System.Drawing.Point(618, 16)
        Me.dgRates.Name = "dgRates"
        Me.dgRates.RowHeadersVisible = False
        Me.dgRates.Size = New System.Drawing.Size(308, 130)
        Me.dgRates.TabIndex = 91
        Me.dgRates.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DsPRates1
        '
        Me.DsPRates1.DataSetName = "dsPRates"
        Me.DsPRates1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgRates
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Black
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.SteelBlue
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.MappingName = "tblProductRates"
        Me.DataGridTableStyle1.RowHeadersVisible = False
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Rates"
        Me.DataGridTextBoxColumn1.MappingName = "Rate"
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Description"
        Me.DataGridTextBoxColumn2.MappingName = "RateDesc"
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 210
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.MappingName = "ProductID"
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.MappingName = "ProdRateID"
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 0
        '
        'btnRates
        '
        Me.btnRates.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnRates.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRates.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRates.Location = New System.Drawing.Point(708, 424)
        Me.btnRates.Name = "btnRates"
        Me.btnRates.Size = New System.Drawing.Size(114, 24)
        Me.btnRates.TabIndex = 92
        Me.btnRates.Text = "&View Rates"
        Me.btnRates.Visible = False
        '
        'DAProduct
        '
        Me.DAProduct.SelectCommand = Me.SelectProductRates
        Me.DAProduct.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblProductRates", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Rate", "Rate"), New System.Data.Common.DataColumnMapping("RateDesc", "RateDesc"), New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("ProdRateID", "ProdRateID")})})
        '
        'SelectProductRates
        '
        Me.SelectProductRates.CommandText = "SELECT Rate, RateDesc, ProductID, ProdRateID FROM tblProductRates"
        Me.SelectProductRates.Connection = Me.OleDbConnection1
        '
        'btnGenInfo
        '
        Me.btnGenInfo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnGenInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenInfo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenInfo.Location = New System.Drawing.Point(550, 394)
        Me.btnGenInfo.Name = "btnGenInfo"
        Me.btnGenInfo.Size = New System.Drawing.Size(114, 24)
        Me.btnGenInfo.TabIndex = 93
        Me.btnGenInfo.Text = "&Generator Info"
        Me.btnGenInfo.Visible = False
        '
        'lblIncompleteGenInfo
        '
        Me.lblIncompleteGenInfo.ForeColor = System.Drawing.Color.Red
        Me.lblIncompleteGenInfo.Location = New System.Drawing.Point(182, 388)
        Me.lblIncompleteGenInfo.Name = "lblIncompleteGenInfo"
        Me.lblIncompleteGenInfo.Size = New System.Drawing.Size(376, 30)
        Me.lblIncompleteGenInfo.TabIndex = 94
        Me.lblIncompleteGenInfo.Text = "The Generator Record you have selected has incomplete Billing Information. Click " & _
        "on Generator Info -> button to complete it."
        Me.lblIncompleteGenInfo.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(594, 424)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(112, 24)
        Me.btnDelete.TabIndex = 95
        Me.btnDelete.Text = "&Delete"
        '
        'txtAttn
        '
        Me.txtAttn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAttn.Location = New System.Drawing.Point(340, 118)
        Me.txtAttn.MaxLength = 50
        Me.txtAttn.Name = "txtAttn"
        Me.txtAttn.Size = New System.Drawing.Size(232, 14)
        Me.txtAttn.TabIndex = 97
        Me.txtAttn.Text = ""
        '
        'txtPO
        '
        Me.txtPO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPO.Location = New System.Drawing.Point(116, 118)
        Me.txtPO.MaxLength = 50
        Me.txtPO.Name = "txtPO"
        Me.txtPO.Size = New System.Drawing.Size(160, 14)
        Me.txtPO.TabIndex = 96
        Me.txtPO.Text = ""
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Location = New System.Drawing.Point(340, 132)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(232, 1)
        Me.Label15.TabIndex = 101
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(284, 118)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 16)
        Me.Label18.TabIndex = 100
        Me.Label18.Text = "Attn"
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Location = New System.Drawing.Point(114, 132)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(160, 1)
        Me.Label19.TabIndex = 99
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(60, 118)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(48, 16)
        Me.Label20.TabIndex = 98
        Me.Label20.Text = "P.O."
        '
        'txtGallons
        '
        Me.txtGallons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGallons.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGallons.Location = New System.Drawing.Point(500, 92)
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(94, 21)
        Me.txtGallons.TabIndex = 182
        Me.txtGallons.Text = ""
        '
        'lblGallons
        '
        Me.lblGallons.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGallons.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblGallons.Location = New System.Drawing.Point(424, 96)
        Me.lblGallons.Name = "lblGallons"
        Me.lblGallons.Size = New System.Drawing.Size(74, 14)
        Me.lblGallons.TabIndex = 183
        Me.lblGallons.Text = "GALLONS :-"
        '
        'frmInvoice
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(930, 461)
        Me.Controls.Add(Me.txtGallons)
        Me.Controls.Add(Me.lblGallons)
        Me.Controls.Add(Me.txtAttn)
        Me.Controls.Add(Me.txtPO)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnGenInfo)
        Me.Controls.Add(Me.lblIncompleteGenInfo)
        Me.Controls.Add(Me.btnRates)
        Me.Controls.Add(Me.dgRates)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtInvoiceDesc)
        Me.Controls.Add(Me.txtInvoiceAmount)
        Me.Controls.Add(Me.dgInvoiceDetails)
        Me.Controls.Add(Me.txtInvoiceDate)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.grpType)
        Me.Controls.Add(Me.lblWhatForm)
        Me.Controls.Add(Me.btnPrintCopies)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnCancelI)
        Me.Controls.Add(Me.btnSaveI)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
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
        Me.Controls.Add(Me.lblReqField)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInvoiceID)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoicing"
        CType(Me.dgInvoiceDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsInvoice_Details1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpType.ResumeLayout(False)
        CType(Me.dgRates, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPRates1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public jtID As Long
    Public iID As Long
    Public genID As Long
    Dim saveValid As Boolean = True
    '1=Insert, 2=Update
    Dim UpdateOrInsert As Integer = 1

    Private Sub frmInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.OleDbConnection1.ConnectionString = DBHelper.ConnStr
        If Me.lblReqField.Text <> "" Then
            jtID = DBHelper.GetInteger("SELECT JobTicketID FROM tblJobTickets WHERE JobTicketNo = " & Me.lblReqField.Text & "")
            If IsNumeric(Me.lblReqField.Text) = True Then
                Me.txtInvoiceNo.Text = Me.lblReqField.Text
                If DBHelper.GetRecordCount("SELECT Count(*) FROM tblInvoicing WHERE JobTicketID = " & Me.jtID & "") > 0 Then
                    Me.iID = DBHelper.GetInteger("SELECT InvoiceID FROM tblInvoicing WHERE JobTicketID = " & Me.jtID & "")
                    Me.txtInvoiceID.Text = Me.iID
                    Me.UpdateOrInsert = 2
                Else
                    If DBHelper.GetRecordCount("SELECT Count(*) FROM tblInvoicing") > 0 Then
                        Dim nextIid As Long
                        nextIid = DBHelper.GetInteger("SELECT Max(CLng(InvoiceNo)) FROM tblInvoicing WHERE IsNumeric(InvoiceNo)")
                        nextIid = nextIid + 1
                        Me.txtInvoiceNo.Text = nextIid
                    Else
                        Me.txtInvoiceNo.Text = "20000"
                    End If
                    Me.UpdateOrInsert = 1
                End If
                Me.populateInvoiceData()
                Me.UpdateInvoiceTotal()
            End If
        End If
        If Me.txtInvoiceID.Text = "" Then
            Me.txtInvoiceDate.Text = Date.Now.ToShortDateString
        Else
            Me.btnPrintCopies.Enabled = True
        End If
        Me.btnRates_Click(Me.btnRates, CType(e, System.EventArgs))

    End Sub

    Function populateDatagrid()

        Dim aConn As OleDb.OleDbConnection
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            'Connect to Database and fill Dataset
            aConn = DBHelper.Connect
            Me.DsInvoice_Details1.Clear()
            Me.SelectInvoiceDetails.CommandText = Me.SelectInvoiceDetails.CommandText & " WHERE JobTicketID = " & Me.jtID
            Me.DAInvoiceDetails.Fill(Me.DsInvoice_Details1, "tblInvoice_Details")
            Me.InitialUpdate()
            'Bind Datagrid
            Me.dgInvoiceDetails.Refresh()

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

    Function populateInvoiceData()

        If jtID > 0 Then

            Dim strSQL As String
            Dim DS As DataSet
            Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Try
                If Me.iID > 0 Then
                    strSQL = "SELECT tblJobTickets.JobTicketNo, tblJobTickets.ScheduleDate, tblInvoicing.InvoiceID, tblInvoicing.InvoiceNo, tblInvoicing.InvoiceDate, tblInvoicing.InvoiceAmount, tblGenerators.GeneratorName, tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteAddress2, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, tblGenerators.ContactName, tblGenerators.ContactPhone, tblProducts.ProductName, tblInvoicing.InvoiceType, tblGenerators.BillingName, tblGenerators.BillingAddress1, tblGenerators.BillingCity, tblGenerators.BillingState, tblGenerators.BillingZip, tblGenerators.GeneratorID,tblJobTickets.JobPO,tblJobTickets.Attn,Drums,tblJobTickets.Gallons,tblInvoicing.InvoiceDescription FROM ((tblGenerators INNER JOIN (tblProducts INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblInvoicing ON tblJobTickets.JobTicketID = tblInvoicing.JobTicketID) WHERE InvoiceID = " & Me.iID
                Else
                    strSQL = "SELECT tblJobTickets.JobTicketNo, tblJobTickets.ScheduleDate, tblInvoicing.InvoiceID, tblInvoicing.InvoiceNo, tblInvoicing.InvoiceDate, tblInvoicing.InvoiceAmount, tblGenerators.GeneratorName, tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteAddress2, tblGenerators.JobSiteCity, tblGenerators.JobSiteState, tblGenerators.JobSiteZip, tblGenerators.ContactName, tblGenerators.ContactPhone, tblProducts.ProductName, tblInvoicing.InvoiceType, tblGenerators.BillingName, tblGenerators.BillingAddress1, tblGenerators.BillingCity, tblGenerators.BillingState, tblGenerators.BillingZip, tblGenerators.GeneratorID,tblJobTickets.JobPO,tblJobTickets.Attn,Drums,tblJobTickets.Gallons,tblInvoicing.InvoiceDescription  FROM ((tblGenerators INNER JOIN (tblProducts INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) ON tblGenerators.GeneratorID = tblProducts.GeneratorID) LEFT JOIN tblInvoicing ON tblJobTickets.JobTicketID = tblInvoicing.JobTicketID) WHERE tblJobTickets.JobTicketID = " & Me.jtID
                End If
                DS = DBHelper.GetDataSet(strSQL, "tblInvoice")
                If DS.Tables(0).Rows.Count = 0 Then
                    'If cannot find details
                    MsgBox("Cannot find the requested Invoice.", MsgBoxStyle.Information, "Cannot find")
                    Exit Function
                Else
                    Dim thisRow As DataRow
                    thisRow = DS.Tables(0).Rows(0)
                    'Update Details
                    '-------------------------------------------------------------------
                    'Haigriv Vyas
                    'Date: 07/05/2005
                    '-------------------------------------------------------------------
                    'Me.txtCustomerName.Text = thisRow.Item("GeneratorName")
                    'Me.txtJobSite.Text = thisRow.Item("JobSite")
                    Me.txtCustomerName.Text = thisRow.Item("JobSite")
                    Me.txtJobSite.Text = thisRow.Item("GeneratorName")
                    Me.txtAddress.Text = thisRow.Item("JobSiteAddress1")
                    Me.txtCity.Text = thisRow.Item("JobSiteCity")
                    Me.txtState.Text = thisRow.Item("JobSiteState")
                    Me.txtZip.Text = thisRow.Item("JobSiteZip")
                    Me.txtInvoiceID.Text = IIf(IsDBNull(thisRow.Item("InvoiceID")), "", thisRow.Item("InvoiceID"))
                    Me.txtPO.Text = IIf(IsDBNull(thisRow.Item("JobPO")), "", thisRow.Item("JobPO"))
                    Me.txtAttn.Text = IIf(IsDBNull(thisRow.Item("Attn")), "", thisRow.Item("Attn"))

                    '#IsDrum
                    Dim IsDrum As Boolean = False
                    Dim Gallons As Decimal = 0
                    IsDrum = IIf(IsDBNull(thisRow.Item("Drums")), False, thisRow.Item("Drums"))
                    Me.txtGallons.Text = IIf(IsDBNull(thisRow.Item("Gallons")), 0, thisRow.Item("Gallons"))
                    Me.txtInvoiceDesc.Text = IIf(IsDBNull(thisRow.Item("InvoiceDescription")), "", thisRow.Item("InvoiceDescription"))
                    If Me.iID > 0 Then
                        Me.txtInvoiceNo.Text = IIf(IsDBNull(thisRow.Item("InvoiceNo")), "", thisRow.Item("InvoiceNo"))
                    End If
                    Me.txtInvoiceDate.Text = IIf(IsDBNull(thisRow.Item("InvoiceDate")), "", thisRow.Item("InvoiceDate"))
                    If IsDBNull(thisRow.Item("InvoiceType")) Then
                        Me.rdnReg.Checked = True
                    ElseIf thisRow.Item("InvoiceType") = 1 Then
                        Me.rdnReg.Checked = True
                    Else
                        Me.rdnReg.Checked = False
                    End If
                    Me.rdnList.Checked = Not Me.rdnReg.Checked
                    Me.genID = thisRow.Item("GeneratorID")
                    If IsDBNull(thisRow.Item("BillingName")) Or IsDBNull(thisRow.Item("BillingAddress1")) Or IsDBNull(thisRow.Item("BillingCity")) Or IsDBNull(thisRow.Item("BillingState")) Or IsDBNull(thisRow.Item("BillingZip")) Then
                        Me.lblIncompleteGenInfo.Visible = True
                        Me.btnGenInfo.Visible = True
                    Else
                        Me.lblIncompleteGenInfo.Visible = False
                        Me.btnGenInfo.Visible = False
                    End If
                    'Populate Datagrid details
                    Me.populateDatagrid()

                End If

            Catch ex As SystemException
                MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

            Finally
                DS = Nothing
                Cursor.Current = System.Windows.Forms.Cursors.Default

            End Try

        Else

            MsgBox("Cannot find the requested Job Ticket.", MsgBoxStyle.Information, "Job Ticket")

        End If

    End Function

    Private Sub btnPrintCopies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintCopies.Click

        'Save and Close
        Me.saveValid = True

        If Me.saveValid = True Then

            'Print Copies of Invoice
            Dim ds As DataSet
            Dim strsql As String = Me.SelectInvoice.CommandText & " WHERE tblInvoicing.InvoiceID = " & Me.iID
            Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Try
                ds = DBHelper.GetDataSet(strsql, "tblInvoice_Details")
                If ds.Tables(0).Rows.Count = 0 Then
                    MsgBox("No matching data found. Cancelling Report..", MsgBoxStyle.Information, "Print an Invoice")
                Else
                    Dim frmR As New frmReport
                    Dim objr As CrystalDecisions.CrystalReports.Engine.ReportDocument
                    If Me.rdnReg.Checked = True Then
                        objr = New rpt_Invoice
                    Else
                        objr = New rpt_InvoiceList
                    End If
                    frmR.WindowState = FormWindowState.Maximized
                    objr.SetDataSource(ds)
                    DBHelper.Authenticate(objr)
                    frmR.CrystalReportViewer1.ReportSource = objr
                    frmR.CrystalReportViewer1.RefreshReport()
                    frmR.Show()
                End If

            Catch ex As SystemException
                MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

            Finally
                ds = Nothing
                Cursor.Current = System.Windows.Forms.Cursors.Default

            End Try

        End If

    End Sub

    Private Sub btnSaveI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveI.Click

        'Save and Close
        Me.saveValid = True
        Me.SaveRecord()
        If Me.saveValid = True Then
            Me.Close()
            If Me.lblWhatForm.Text = "frmReceivables" Then
                DirectCast(Owner, frmReceivables).populateDatagrid()
            Else
                DirectCast(Owner, frmInvoicingList).populateDatagrid(ClosedFlag)
            End If
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        'Save and Close
        Me.saveValid = True
        Me.SaveRecord()
        If Me.saveValid = True Then Me.btnPrintCopies.Enabled = True

    End Sub

    Function SaveRecord()

        Dim strSQL As String
        'Error Checking
        If IsDate(Me.txtInvoiceDate.Text) = False Then
            MsgBox("INVOICE DATE is either missing or invalid. Please enter a valid INVOICE DATE.", MsgBoxStyle.Information, "INVOICE DATE")
            Me.txtInvoiceDate.Focus()
            Me.saveValid = False
            Exit Function
        End If
        If Me.txtInvoiceNo.Text = "" Then
            MsgBox("INVOICE # is missing. Please select an INVOICE #.", MsgBoxStyle.Information, "INVOICE #")
            Me.txtInvoiceNo.Focus()
            Me.saveValid = False
            Exit Function
        End If
        Me.UpdateInvoiceTotal()
        Dim tmp As Double = CDbl(Me.txtInvoiceAmount.Text)
        'If tmp <= 0 Then
        '    MsgBox("INVOICE AMOUNT is either missing or invalid. Please enter a valid INVOICE AMOUNT.", MsgBoxStyle.Information, "INVOICE AMOUNT")
        '    Me.txtInvoiceAmount.Focus()
        '    Me.saveValid = False
        '    Exit Function
        'End If
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            Dim InvType As Integer = 1
            If Me.rdnReg.Checked = True Then
                InvType = 1
            Else
                InvType = 2
            End If
            If Me.iID <= 0 Then
                strSQL = "INSERT INTO tblInvoicing (JobTicketID, InvoiceNo, InvoiceDate, InvoiceAmount, Invoiced, InvoiceType, InvoiceDescription) " _
                        & "SELECT " & Me.jtID & " as JobTicketID, '" & Replace(Me.txtInvoiceNo.Text, "'", "''") & "' as InvoiceNo, #" & Me.txtInvoiceDate.Text & "# as InvoiceDate, " _
                        & "" & tmp & " as InvoiceAmount, TRUE as Invoiced, " & InvType & " as InvoiceType, '" & Replace(Me.txtInvoiceDesc.Text, "'", "''") & "'"
                Me.UpdateOrInsert = 2
            Else
                strSQL = "UPDATE tblInvoicing SET InvoiceNo='" & Replace(Me.txtInvoiceNo.Text, "'", "''") & "', InvoiceDate=#" & Me.txtInvoiceDate.Text & "#, InvoiceAmount = " & tmp & ", InvoiceType = " & InvType & ", InvoiceDescription = '" & Replace(Me.txtInvoiceDesc.Text, "'", "''") & "'" _
                        & " WHERE InvoiceID = " & CInt(Me.txtInvoiceID.Text) & ""
                Me.UpdateOrInsert = 2
            End If
            If DBHelper.ExecuteQuery(strSQL) = False Then
                MsgBox("An error ocurred while performing this operation. Your information has not been saved.", MsgBoxStyle.Information, "Error ocurred")
                Me.saveValid = False
                Exit Function
            End If
            If Me.DsInvoice_Details1.HasChanges = True Then
                Dim i As Integer
                For i = 0 To Me.DsInvoice_Details1.tblInvoice_Details.Rows.Count - 1
                    If IsDBNull(Me.DsInvoice_Details1.tblInvoice_Details.Rows(i).Item("JobTicketID")) = True Then
                        Me.DsInvoice_Details1.tblInvoice_Details.Rows(i).Item("JobTicketID") = jtID
                    End If
                Next
                Me.DAInvoiceDetails.Update(Me.DsInvoice_Details1, "tblInvoice_Details")
            End If
            If Me.iID <= 0 Then
                Me.iID = DBHelper.GetInteger("SELECT Max(InvoiceID) FROM tblInvoicing")
                Me.txtInvoiceID.Text = Me.iID
            End If
            Dim Gallons As Decimal = 0
            If Me.txtGallons.Text <> "" AndAlso IsNumeric(Me.txtGallons.Text) = False Then
                MsgBox("Gallons field must be Numeric.")
                Exit Function
            ElseIf Me.txtGallons.Text <> "" AndAlso CInt(Me.txtGallons.Text) > 0 Then
                Gallons = Me.txtGallons.Text
            Else
                Gallons = 0
            End If

            strSQL = "UPDATE tblJobTickets SET InvoiceCreated = TRUE,JobPO = '" & Me.txtPO.Text.Trim & "',Attn = '" & Me.txtAttn.Text.Trim & "',Gallons = " & Gallons & " WHERE JobTicketID = " & Me.jtID
            DBHelper.ExecuteQuery(strSQL)
            Me.saveValid = True

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error ocurred")

        Finally
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Function

    Function UpdateInvoiceTotal()

        Dim iCount As Integer = Me.DsInvoice_Details1.Tables(0).Rows.Count
        Dim j As Integer, someC As Double = 0
        For j = 0 To iCount - 1
            If IsDBNull(Me.dgInvoiceDetails.Item(j, 6)) Then
                Me.dgInvoiceDetails.Item(j, 6) = 0
            End If
            If IsDBNull(Me.dgInvoiceDetails.Item(j, 6)) = False Then someC = someC + Format(Me.dgInvoiceDetails.Item(j, 6), "F")
        Next
        Me.txtInvoiceAmount.Text = Format(someC, "C")

    End Function

    Private Sub btnCancelI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelI.Click

        Me.Close()

    End Sub

    Private Sub dgInvoiceDetails_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgInvoiceDetails.KeyUp

        Me.UpdateInvoiceTotal()

    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

        Me.UpdateInvoiceTotal()

    End Sub

    Private Sub dgInvoiceDetails_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgInvoiceDetails.CurrentCellChanged

        Try
            Dim iT As Integer, iC As Integer
            iT = Me.dgInvoiceDetails.CurrentCell.RowNumber
            If IsDBNull(Me.dgInvoiceDetails.Item(iT, 3)) = True Then Exit Sub
            If IsDBNull(Me.dgInvoiceDetails.Item(iT, 5)) = True Then Exit Sub
            If IsNumeric(Me.dgInvoiceDetails.Item(iT, 3)) = False Then Exit Sub
            If IsNumeric(Me.dgInvoiceDetails.Item(iT, 5)) = False Then Exit Sub
            If Me.dgInvoiceDetails.Item(iT, 3) > 0 And IsNumeric(Me.dgInvoiceDetails.Item(iT, 5)) = True Then
                Me.dgInvoiceDetails.Item(iT, 6) = Me.dgInvoiceDetails.Item(iT, 3) * Me.dgInvoiceDetails.Item(iT, 5)
                Me.UpdateInvoiceTotal()
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)

        End Try

    End Sub

    Function InitialUpdate()

        Try
            Dim i As Integer = 0
            Dim rCount As Integer = Me.DsInvoice_Details1.Tables(0).Rows.Count
            For i = 0 To rCount - 1
                If IsDBNull(Me.DsInvoice_Details1.Tables(0).Rows(i).Item(2)) = True Then Exit Function
                If IsDBNull(Me.DsInvoice_Details1.Tables(0).Rows(i).Item(5)) = True Then Exit Function
                If IsNumeric(Me.DsInvoice_Details1.Tables(0).Rows(i).Item(2)) = False Then Exit Function
                If IsNumeric(Me.DsInvoice_Details1.Tables(0).Rows(i).Item(5)) = False Then Exit Function
                If Me.DsInvoice_Details1.Tables(0).Rows(i).Item(2) > 0 And Me.DsInvoice_Details1.Tables(0).Rows(i).Item(5) > 0 Then
                    Me.DsInvoice_Details1.Tables(0).Rows(i).Item(6) = Me.DsInvoice_Details1.Tables(0).Rows(i).Item(2) * Me.DsInvoice_Details1.Tables(0).Rows(i).Item(5)
                End If
            Next

        Catch ex As SystemException
            MsgBox(ex.Message)

        End Try

    End Function

    Private Sub btnRates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRates.Click

        Dim PID As Integer
        PID = DBHelper.GetInteger("SELECT ProductID FROM tblJobTickets WHERE JobTicketID = " & jtID)
        Me.SelectProductRates.CommandText = "SELECT Rate, RateDesc, ProductID, ProdRateID FROM tblProductRates WHERE ProductID =" & PID & ""
        Me.DsPRates1.Clear()
        Me.DAProduct.Fill(Me.DsPRates1)
        Me.dgRates.DataSource = Me.DsPRates1
        Me.dgRates.DataMember = Me.DsPRates1.tblProductRates.TableName.ToString

    End Sub

    Private Sub btnGenInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenInfo.Click

        If Me.genID > 0 Then

            Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Dim frmP As New frmGenerator
            frmP.Visible = True
            'frmP.cmbGenerator.SelectedValue = Me.genID
            frmP.clearAll()
            frmP.LoadGeneratorInfo(genID)
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End If
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Me.iID <= 0 AndAlso jtID <= 0 Then Exit Sub
        Dim strSQL As String = ""
        Dim delFlag As Boolean = True
        If MsgBox("This will permanently DELETE this invoice from the System.are you sure?", MsgBoxStyle.YesNo, "Confirm Message") = MsgBoxResult.Yes Then
            '#Check if there is any Payment made to any of invoices
            Dim amount As Decimal
            strSQL = "SELECT Sum(tblInvoicing.CheckAmount) AS SumOfInvoiceAmount FROM tblInvoicing WHERE " _
                                & " InvoiceID = " & Me.iID
            amount = DBHelper.GetDecimal(strSQL)
            If amount > 0 Then
                MsgBox("Can NOT delete because it has already been paid.", MsgBoxStyle.Information, "Error ocurred")
                Exit Sub
            End If
            'delete JobTicket Information
            strSQL = "DELETE FROM tblJobTickets_Details WHERE JobTicketID = " & Me.jtID
            If DBHelper.ExecuteQuery(strSQL) = False Then
                MsgBox("An error ocurred while performing this operation. Your information has not been saved.", MsgBoxStyle.Information, "Error ocurred")
                delFlag = False
            End If
            'DELETE FROM Invoicing
            strSQL = "DELETE FROM tblInvoicing WHERE InvoiceID = " & Me.iID
            If DBHelper.ExecuteQuery(strSQL) = False Then
                MsgBox("An error ocurred while performing this operation. Your information has not been saved.", MsgBoxStyle.Information, "Error ocurred")
                delFlag = False
            End If
        End If
        If delFlag = True Then
            Me.Close()
            If Me.lblWhatForm.Text = "frmReceivables" Then
                DirectCast(Owner, frmReceivables).populateDatagrid()
            Else
                DirectCast(Owner, frmInvoicingList).populateDatagrid(ClosedFlag)
            End If
            'DirectCast(Owner, frmInvoicingList).populateDatagrid(ClosedFlag)
        End If
    End Sub
End Class
