Imports BeaverOil.DataGridButton
Imports System.IO

Public Class frmProduct
    Inherits System.Windows.Forms.Form

    Public prodID As Integer = 0
    Public genID As Integer = 0
    Dim rCount As Integer = 0
    'Dim folderPath As String = Application.StartupPath & "\Analytical Input Forms"
    Dim folderPath As String = DBHelper.Analytical_Files_Location
    '
    'col_dgLabData_V
    '
    Dim col_dgLabData_V As DataGridButtonColumn = New DataGridButtonColumn(4)
    '
    'col_dgLabData_D
    '
    Dim col_dgLabData_D As DataGridButtonColumn = New DataGridButtonColumn(5)
    Dim ProductCount As Integer
    Dim addNewFlag As Boolean = False

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
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents JobTicket As System.Windows.Forms.CheckBox
    Friend WithEvents BillOfLading As System.Windows.Forms.CheckBox
    Friend WithEvents NonHazardous As System.Windows.Forms.CheckBox
    Friend WithEvents Hazardous As System.Windows.Forms.CheckBox
    Friend WithEvents AnalyticalDate As System.Windows.Forms.TextBox
    Friend WithEvents GeneratorID As System.Windows.Forms.ComboBox
    Friend WithEvents GenProdNo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents FedNo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnCancelP As System.Windows.Forms.Button
    Friend WithEvents btnSaveP As System.Windows.Forms.Button
    Friend WithEvents ProductN As System.Windows.Forms.TextBox
    Friend WithEvents grpProduct As System.Windows.Forms.GroupBox
    Friend WithEvents grpPaperwork As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents tbPages As System.Windows.Forms.TabControl
    Friend WithEvents tbP1 As System.Windows.Forms.TabPage
    Friend WithEvents tbP2 As System.Windows.Forms.TabPage
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DAProductLabData As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents SelectPLabData As System.Data.OleDb.OleDbCommand
    Friend WithEvents dgLabData As System.Windows.Forms.DataGrid
    Friend WithEvents DsProductLabDat1 As BeaverOil.DSProductLabDat
    Friend WithEvents cmbAssignTemplate As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnViewTemplate As System.Windows.Forms.PictureBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Friend WithEvents btnViewPNos As System.Windows.Forms.Button
    Friend WithEvents btnApprovalNumbers As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Plant2Manifest As System.Windows.Forms.CheckBox
    Friend WithEvents ProductDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents HWNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents SpecialInstructions As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents ApprovalNo As System.Windows.Forms.TextBox
    Friend WithEvents PermitNo As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Type As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Manifest_Description As System.Windows.Forms.TextBox
    Friend WithEvents tbP3 As System.Windows.Forms.TabPage
    Friend WithEvents dgRates As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ts_dgLabData As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ts_dgProdutRates As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DsProductRates1 As BeaverOil.DSProductRates
    Friend WithEvents col_ProdRates_1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_ProdRates_2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_ProdRates_3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_ProdRates_4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents SelectProdRates As System.Data.OleDb.OleDbCommand
    Friend WithEvents DAProdRates As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents InsertRates As System.Data.OleDb.OleDbCommand
    Friend WithEvents UpdateRates As System.Data.OleDb.OleDbCommand
    Friend WithEvents DeleteRates As System.Data.OleDb.OleDbCommand
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents LabRecertDate As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents ProductDescription1 As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents DsDescriptions1 As BeaverOil.DSDescriptions
    Friend WithEvents cmbDescs As System.Windows.Forms.ComboBox
    Friend WithEvents SelectDESCs As System.Data.OleDb.OleDbCommand
    Friend WithEvents DADescs As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents ProcessDescription As System.Windows.Forms.TextBox
    Friend WithEvents chkLandBanForm As System.Windows.Forms.CheckBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtLandbanText As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents grpSelectProduct As System.Windows.Forms.GroupBox
    Friend WithEvents Fill_Customer As System.Windows.Forms.TextBox
    Friend WithEvents dgSearchProduct As System.Windows.Forms.DataGrid
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
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
    Friend WithEvents ViewNewJobList As System.Windows.Forms.Button
    Friend WithEvents grBottom As System.Windows.Forms.GroupBox
    Friend WithEvents txtMailingName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMailingAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents txtMailingAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents txtMailingCity As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents txtMailingState As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents txtMailingZip As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Col_Approval As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Fil_Approval As System.Windows.Forms.TextBox
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents lblGen As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents cmbWasteType As System.Windows.Forms.ComboBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents lblGAdd As System.Windows.Forms.Label
    Friend WithEvents lblGCityStateZip As System.Windows.Forms.Label
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents btnAddNewProduct As System.Windows.Forms.Button
    Friend WithEvents chkInactive As System.Windows.Forms.CheckBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents txtAdditionalHWNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents chkNewProduct As System.Windows.Forms.CheckBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtCWTCode As System.Windows.Forms.TextBox
    Friend WithEvents Label59 As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProduct))
        Me.grpProduct = New System.Windows.Forms.GroupBox
        Me.Label58 = New System.Windows.Forms.Label
        Me.txtAdditionalHWNumber = New System.Windows.Forms.TextBox
        Me.Label57 = New System.Windows.Forms.Label
        Me.lblGCityStateZip = New System.Windows.Forms.Label
        Me.lblGAdd = New System.Windows.Forms.Label
        Me.lblGen = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.txtLandbanText = New System.Windows.Forms.TextBox
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.ProcessDescription = New System.Windows.Forms.TextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.ProductDescription1 = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.LabRecertDate = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.HWNumber = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.chkActive = New System.Windows.Forms.CheckBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GeneratorID = New System.Windows.Forms.ComboBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.AnalyticalDate = New System.Windows.Forms.TextBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.ProductDescription = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.ProductN = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.btnApprovalNumbers = New System.Windows.Forms.Button
        Me.btnViewPNos = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.FedNo = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.ApprovalNo = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GenProdNo = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.grpPaperwork = New System.Windows.Forms.GroupBox
        Me.chkLandBanForm = New System.Windows.Forms.CheckBox
        Me.Plant2Manifest = New System.Windows.Forms.CheckBox
        Me.Hazardous = New System.Windows.Forms.CheckBox
        Me.NonHazardous = New System.Windows.Forms.CheckBox
        Me.BillOfLading = New System.Windows.Forms.CheckBox
        Me.JobTicket = New System.Windows.Forms.CheckBox
        Me.btnCancelP = New System.Windows.Forms.Button
        Me.btnSaveP = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.tbPages = New System.Windows.Forms.TabControl
        Me.tbP1 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblCustomerName = New System.Windows.Forms.Label
        Me.Label56 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.txtMailingZip = New System.Windows.Forms.TextBox
        Me.Label52 = New System.Windows.Forms.Label
        Me.txtMailingState = New System.Windows.Forms.TextBox
        Me.Label51 = New System.Windows.Forms.Label
        Me.txtMailingCity = New System.Windows.Forms.TextBox
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.txtMailingAddress2 = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtMailingAddress1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMailingName = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmbDescs = New System.Windows.Forms.ComboBox
        Me.DsDescriptions1 = New BeaverOil.DSDescriptions
        Me.Label41 = New System.Windows.Forms.Label
        Me.Manifest_Description = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Type = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.SpecialInstructions = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.PermitNo = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label54 = New System.Windows.Forms.Label
        Me.cmbWasteType = New System.Windows.Forms.ComboBox
        Me.tbP2 = New System.Windows.Forms.TabPage
        Me.btnViewTemplate = New System.Windows.Forms.PictureBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmbAssignTemplate = New System.Windows.Forms.ComboBox
        Me.dgLabData = New System.Windows.Forms.DataGrid
        Me.DsProductLabDat1 = New BeaverOil.DSProductLabDat
        Me.ts_dgLabData = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.tbP3 = New System.Windows.Forms.TabPage
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.dgRates = New System.Windows.Forms.DataGrid
        Me.DsProductRates1 = New BeaverOil.DSProductRates
        Me.ts_dgProdutRates = New System.Windows.Forms.DataGridTableStyle
        Me.col_ProdRates_1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_ProdRates_2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_ProdRates_3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_ProdRates_4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.DAProductLabData = New System.Data.OleDb.OleDbDataAdapter
        Me.SelectPLabData = New System.Data.OleDb.OleDbCommand
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.SelectProdRates = New System.Data.OleDb.OleDbCommand
        Me.InsertRates = New System.Data.OleDb.OleDbCommand
        Me.UpdateRates = New System.Data.OleDb.OleDbCommand
        Me.DeleteRates = New System.Data.OleDb.OleDbCommand
        Me.DAProdRates = New System.Data.OleDb.OleDbDataAdapter
        Me.DADescs = New System.Data.OleDb.OleDbDataAdapter
        Me.SelectDESCs = New System.Data.OleDb.OleDbCommand
        Me.grpSelectProduct = New System.Windows.Forms.GroupBox
        Me.chkInactive = New System.Windows.Forms.CheckBox
        Me.btnAddNewProduct = New System.Windows.Forms.Button
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
        Me.Col_Approval = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn
        Me.btnSelect = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.lblBorder = New System.Windows.Forms.Label
        Me.ViewNewJobList = New System.Windows.Forms.Button
        Me.grBottom = New System.Windows.Forms.GroupBox
        Me.btnPrint = New System.Windows.Forms.Button
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.Label23 = New System.Windows.Forms.Label
        Me.chkNewProduct = New System.Windows.Forms.CheckBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtCWTCode = New System.Windows.Forms.TextBox
        Me.Label59 = New System.Windows.Forms.Label
        Me.grpProduct.SuspendLayout()
        Me.grpPaperwork.SuspendLayout()
        Me.tbPages.SuspendLayout()
        Me.tbP1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DsDescriptions1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.tbP2.SuspendLayout()
        CType(Me.dgLabData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProductLabDat1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbP3.SuspendLayout()
        CType(Me.dgRates, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProductRates1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSelectProduct.SuspendLayout()
        CType(Me.dgSearchProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNewJobSearch1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpProduct
        '
        Me.grpProduct.Controls.Add(Me.chkNewProduct)
        Me.grpProduct.Controls.Add(Me.Label23)
        Me.grpProduct.Controls.Add(Me.Label58)
        Me.grpProduct.Controls.Add(Me.txtAdditionalHWNumber)
        Me.grpProduct.Controls.Add(Me.Label57)
        Me.grpProduct.Controls.Add(Me.lblGCityStateZip)
        Me.grpProduct.Controls.Add(Me.lblGAdd)
        Me.grpProduct.Controls.Add(Me.lblGen)
        Me.grpProduct.Controls.Add(Me.Label46)
        Me.grpProduct.Controls.Add(Me.txtLandbanText)
        Me.grpProduct.Controls.Add(Me.Label42)
        Me.grpProduct.Controls.Add(Me.Label40)
        Me.grpProduct.Controls.Add(Me.ProcessDescription)
        Me.grpProduct.Controls.Add(Me.Label39)
        Me.grpProduct.Controls.Add(Me.Label38)
        Me.grpProduct.Controls.Add(Me.ProductDescription1)
        Me.grpProduct.Controls.Add(Me.Label36)
        Me.grpProduct.Controls.Add(Me.Label35)
        Me.grpProduct.Controls.Add(Me.Label34)
        Me.grpProduct.Controls.Add(Me.LabRecertDate)
        Me.grpProduct.Controls.Add(Me.Label14)
        Me.grpProduct.Controls.Add(Me.HWNumber)
        Me.grpProduct.Controls.Add(Me.Label17)
        Me.grpProduct.Controls.Add(Me.Label45)
        Me.grpProduct.Controls.Add(Me.chkActive)
        Me.grpProduct.Controls.Add(Me.Label13)
        Me.grpProduct.Controls.Add(Me.Label4)
        Me.grpProduct.Controls.Add(Me.GeneratorID)
        Me.grpProduct.Controls.Add(Me.Label43)
        Me.grpProduct.Controls.Add(Me.AnalyticalDate)
        Me.grpProduct.Controls.Add(Me.Label44)
        Me.grpProduct.Controls.Add(Me.Label20)
        Me.grpProduct.Controls.Add(Me.ProductDescription)
        Me.grpProduct.Controls.Add(Me.Label21)
        Me.grpProduct.Controls.Add(Me.Label18)
        Me.grpProduct.Controls.Add(Me.Label15)
        Me.grpProduct.Controls.Add(Me.ProductN)
        Me.grpProduct.Controls.Add(Me.Label16)
        Me.grpProduct.Controls.Add(Me.Label37)
        Me.grpProduct.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpProduct.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProduct.Location = New System.Drawing.Point(8, 0)
        Me.grpProduct.Name = "grpProduct"
        Me.grpProduct.Size = New System.Drawing.Size(768, 264)
        Me.grpProduct.TabIndex = 0
        Me.grpProduct.TabStop = False
        Me.grpProduct.Text = "Product Info"
        '
        'Label58
        '
        Me.Label58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label58.Location = New System.Drawing.Point(138, 258)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(612, 1)
        Me.Label58.TabIndex = 177
        '
        'txtAdditionalHWNumber
        '
        Me.txtAdditionalHWNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAdditionalHWNumber.Location = New System.Drawing.Point(142, 242)
        Me.txtAdditionalHWNumber.MaxLength = 35
        Me.txtAdditionalHWNumber.Name = "txtAdditionalHWNumber"
        Me.txtAdditionalHWNumber.Size = New System.Drawing.Size(608, 13)
        Me.txtAdditionalHWNumber.TabIndex = 12
        Me.txtAdditionalHWNumber.Text = ""
        '
        'Label57
        '
        Me.Label57.Location = New System.Drawing.Point(14, 242)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(122, 16)
        Me.Label57.TabIndex = 175
        Me.Label57.Text = "Additional HW #:"
        '
        'lblGCityStateZip
        '
        Me.lblGCityStateZip.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGCityStateZip.Location = New System.Drawing.Point(426, 78)
        Me.lblGCityStateZip.Name = "lblGCityStateZip"
        Me.lblGCityStateZip.Size = New System.Drawing.Size(228, 16)
        Me.lblGCityStateZip.TabIndex = 174
        '
        'lblGAdd
        '
        Me.lblGAdd.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGAdd.Location = New System.Drawing.Point(148, 78)
        Me.lblGAdd.Name = "lblGAdd"
        Me.lblGAdd.Size = New System.Drawing.Size(276, 16)
        Me.lblGAdd.TabIndex = 4
        '
        'lblGen
        '
        Me.lblGen.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGen.Location = New System.Drawing.Point(148, 60)
        Me.lblGen.Name = "lblGen"
        Me.lblGen.Size = New System.Drawing.Size(504, 16)
        Me.lblGen.TabIndex = 3
        '
        'Label46
        '
        Me.Label46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label46.Location = New System.Drawing.Point(384, 238)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(368, 1)
        Me.Label46.TabIndex = 61
        '
        'txtLandbanText
        '
        Me.txtLandbanText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLandbanText.Location = New System.Drawing.Point(384, 224)
        Me.txtLandbanText.MaxLength = 50
        Me.txtLandbanText.Name = "txtLandbanText"
        Me.txtLandbanText.Size = New System.Drawing.Size(368, 13)
        Me.txtLandbanText.TabIndex = 11
        Me.txtLandbanText.Text = ""
        '
        'Label42
        '
        Me.Label42.Location = New System.Drawing.Point(280, 224)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(96, 16)
        Me.Label42.TabIndex = 59
        Me.Label42.Text = "LandBan Text :"
        '
        'Label40
        '
        Me.Label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label40.Location = New System.Drawing.Point(144, 116)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(620, 1)
        Me.Label40.TabIndex = 58
        '
        'ProcessDescription
        '
        Me.ProcessDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProcessDescription.Location = New System.Drawing.Point(144, 96)
        Me.ProcessDescription.MaxLength = 150
        Me.ProcessDescription.Multiline = True
        Me.ProcessDescription.Name = "ProcessDescription"
        Me.ProcessDescription.Size = New System.Drawing.Size(620, 20)
        Me.ProcessDescription.TabIndex = 5
        Me.ProcessDescription.Text = ""
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(8, 96)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(136, 16)
        Me.Label39.TabIndex = 56
        Me.Label39.Text = "Process Description: "
        '
        'Label38
        '
        Me.Label38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label38.Location = New System.Drawing.Point(286, 200)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(476, 1)
        Me.Label38.TabIndex = 55
        '
        'ProductDescription1
        '
        Me.ProductDescription1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProductDescription1.Location = New System.Drawing.Point(288, 164)
        Me.ProductDescription1.MaxLength = 200
        Me.ProductDescription1.Multiline = True
        Me.ProductDescription1.Name = "ProductDescription1"
        Me.ProductDescription1.Size = New System.Drawing.Size(476, 36)
        Me.ProductDescription1.TabIndex = 7
        Me.ProductDescription1.Text = ""
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(8, 168)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(280, 16)
        Me.Label36.TabIndex = 53
        Me.Label36.Text = "Product Description 2: (Shows up on Manifests)"
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(34, 222)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(104, 16)
        Me.Label35.TabIndex = 5
        Me.Label35.Text = "LAB Recert Date:"
        '
        'Label34
        '
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label34.Location = New System.Drawing.Point(138, 238)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(136, 1)
        Me.Label34.TabIndex = 52
        '
        'LabRecertDate
        '
        Me.LabRecertDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LabRecertDate.Location = New System.Drawing.Point(144, 224)
        Me.LabRecertDate.MaxLength = 10
        Me.LabRecertDate.Name = "LabRecertDate"
        Me.LabRecertDate.Size = New System.Drawing.Size(128, 13)
        Me.LabRecertDate.TabIndex = 9
        Me.LabRecertDate.Text = ""
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Location = New System.Drawing.Point(320, 220)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(272, 1)
        Me.Label14.TabIndex = 49
        '
        'HWNumber
        '
        Me.HWNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HWNumber.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HWNumber.Location = New System.Drawing.Point(320, 204)
        Me.HWNumber.MaxLength = 50
        Me.HWNumber.Name = "HWNumber"
        Me.HWNumber.Size = New System.Drawing.Size(272, 13)
        Me.HWNumber.TabIndex = 10
        Me.HWNumber.Text = ""
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(280, 204)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 16)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "HW #:"
        '
        'Label45
        '
        Me.Label45.Location = New System.Drawing.Point(608, 204)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(48, 16)
        Me.Label45.TabIndex = 43
        Me.Label45.Text = "Active:"
        '
        'chkActive
        '
        Me.chkActive.Checked = True
        Me.chkActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkActive.Location = New System.Drawing.Point(656, 204)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(16, 16)
        Me.chkActive.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(2, 204)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(8, 8)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "*"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(6, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(8, 8)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "*"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GeneratorID
        '
        Me.GeneratorID.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneratorID.Location = New System.Drawing.Point(146, 36)
        Me.GeneratorID.Name = "GeneratorID"
        Me.GeneratorID.Size = New System.Drawing.Size(508, 20)
        Me.GeneratorID.TabIndex = 2
        '
        'Label43
        '
        Me.Label43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label43.Location = New System.Drawing.Point(136, 220)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(136, 1)
        Me.Label43.TabIndex = 29
        '
        'AnalyticalDate
        '
        Me.AnalyticalDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AnalyticalDate.Location = New System.Drawing.Point(136, 204)
        Me.AnalyticalDate.MaxLength = 10
        Me.AnalyticalDate.Name = "AnalyticalDate"
        Me.AnalyticalDate.Size = New System.Drawing.Size(136, 13)
        Me.AnalyticalDate.TabIndex = 8
        Me.AnalyticalDate.Text = ""
        '
        'Label44
        '
        Me.Label44.Location = New System.Drawing.Point(8, 204)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(128, 16)
        Me.Label44.TabIndex = 28
        Me.Label44.Text = "Last Analytical Date:"
        '
        'Label20
        '
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Location = New System.Drawing.Point(286, 158)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(478, 1)
        Me.Label20.TabIndex = 15
        '
        'ProductDescription
        '
        Me.ProductDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProductDescription.Location = New System.Drawing.Point(288, 122)
        Me.ProductDescription.MaxLength = 200
        Me.ProductDescription.Multiline = True
        Me.ProductDescription.Name = "ProductDescription"
        Me.ProductDescription.Size = New System.Drawing.Size(476, 36)
        Me.ProductDescription.TabIndex = 6
        Me.ProductDescription.Text = ""
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(8, 122)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(280, 16)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "Product Description 1: (Shows up on Manifests)"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(6, 46)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(140, 30)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Choose Existing Gen+Cust Combination:"
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Location = New System.Drawing.Point(146, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(504, 1)
        Me.Label15.TabIndex = 9
        '
        'ProductN
        '
        Me.ProductN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProductN.Location = New System.Drawing.Point(150, 18)
        Me.ProductN.MaxLength = 100
        Me.ProductN.Name = "ProductN"
        Me.ProductN.Size = New System.Drawing.Size(496, 13)
        Me.ProductN.TabIndex = 1
        Me.ProductN.Text = ""
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(26, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(122, 16)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Product Description:"
        '
        'Label37
        '
        Me.Label37.ForeColor = System.Drawing.Color.Red
        Me.Label37.Location = New System.Drawing.Point(16, 14)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(8, 8)
        Me.Label37.TabIndex = 26
        Me.Label37.Text = "*"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnApprovalNumbers
        '
        Me.btnApprovalNumbers.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnApprovalNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApprovalNumbers.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprovalNumbers.Location = New System.Drawing.Point(820, 8)
        Me.btnApprovalNumbers.Name = "btnApprovalNumbers"
        Me.btnApprovalNumbers.Size = New System.Drawing.Size(76, 24)
        Me.btnApprovalNumbers.TabIndex = 4
        Me.btnApprovalNumbers.Text = "&Approval #'s"
        '
        'btnViewPNos
        '
        Me.btnViewPNos.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnViewPNos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewPNos.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewPNos.Location = New System.Drawing.Point(550, 8)
        Me.btnViewPNos.Name = "btnViewPNos"
        Me.btnViewPNos.Size = New System.Drawing.Size(80, 24)
        Me.btnViewPNos.TabIndex = 2
        Me.btnViewPNos.Text = "&Customer #'s"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(90, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 1)
        Me.Label9.TabIndex = 40
        '
        'FedNo
        '
        Me.FedNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FedNo.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FedNo.Location = New System.Drawing.Point(96, 132)
        Me.FedNo.MaxLength = 20
        Me.FedNo.Name = "FedNo"
        Me.FedNo.Size = New System.Drawing.Size(128, 13)
        Me.FedNo.TabIndex = 13
        Me.FedNo.Text = ""
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Federal No:"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(714, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 1)
        Me.Label7.TabIndex = 37
        '
        'ApprovalNo
        '
        Me.ApprovalNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ApprovalNo.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApprovalNo.Location = New System.Drawing.Point(714, 12)
        Me.ApprovalNo.MaxLength = 20
        Me.ApprovalNo.Name = "ApprovalNo"
        Me.ApprovalNo.Size = New System.Drawing.Size(104, 13)
        Me.ApprovalNo.TabIndex = 3
        Me.ApprovalNo.Text = ""
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(634, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Approval No:"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(436, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 1)
        Me.Label5.TabIndex = 34
        '
        'GenProdNo
        '
        Me.GenProdNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GenProdNo.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenProdNo.Location = New System.Drawing.Point(444, 12)
        Me.GenProdNo.MaxLength = 20
        Me.GenProdNo.Name = "GenProdNo"
        Me.GenProdNo.Size = New System.Drawing.Size(104, 13)
        Me.GenProdNo.TabIndex = 1
        Me.GenProdNo.Text = ""
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(356, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Customer No:"
        '
        'grpPaperwork
        '
        Me.grpPaperwork.Controls.Add(Me.chkLandBanForm)
        Me.grpPaperwork.Controls.Add(Me.Plant2Manifest)
        Me.grpPaperwork.Controls.Add(Me.Hazardous)
        Me.grpPaperwork.Controls.Add(Me.NonHazardous)
        Me.grpPaperwork.Controls.Add(Me.BillOfLading)
        Me.grpPaperwork.Controls.Add(Me.JobTicket)
        Me.grpPaperwork.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpPaperwork.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPaperwork.Location = New System.Drawing.Point(776, 0)
        Me.grpPaperwork.Name = "grpPaperwork"
        Me.grpPaperwork.Size = New System.Drawing.Size(136, 196)
        Me.grpPaperwork.TabIndex = 1
        Me.grpPaperwork.TabStop = False
        Me.grpPaperwork.Text = "Paperwork"
        '
        'chkLandBanForm
        '
        Me.chkLandBanForm.Location = New System.Drawing.Point(8, 144)
        Me.chkLandBanForm.Name = "chkLandBanForm"
        Me.chkLandBanForm.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkLandBanForm.Size = New System.Drawing.Size(120, 16)
        Me.chkLandBanForm.TabIndex = 5
        Me.chkLandBanForm.Text = "Land Ban Form"
        Me.chkLandBanForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Plant2Manifest
        '
        Me.Plant2Manifest.Location = New System.Drawing.Point(8, 120)
        Me.Plant2Manifest.Name = "Plant2Manifest"
        Me.Plant2Manifest.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Plant2Manifest.Size = New System.Drawing.Size(120, 16)
        Me.Plant2Manifest.TabIndex = 4
        Me.Plant2Manifest.Text = "Plant 2 Manifest"
        Me.Plant2Manifest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Hazardous
        '
        Me.Hazardous.Location = New System.Drawing.Point(8, 96)
        Me.Hazardous.Name = "Hazardous"
        Me.Hazardous.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Hazardous.Size = New System.Drawing.Size(120, 16)
        Me.Hazardous.TabIndex = 3
        Me.Hazardous.Text = "Hazardous"
        Me.Hazardous.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NonHazardous
        '
        Me.NonHazardous.Location = New System.Drawing.Point(8, 72)
        Me.NonHazardous.Name = "NonHazardous"
        Me.NonHazardous.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NonHazardous.Size = New System.Drawing.Size(120, 16)
        Me.NonHazardous.TabIndex = 3
        Me.NonHazardous.Text = "Non-Hazardous"
        Me.NonHazardous.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BillOfLading
        '
        Me.BillOfLading.Location = New System.Drawing.Point(8, 48)
        Me.BillOfLading.Name = "BillOfLading"
        Me.BillOfLading.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BillOfLading.Size = New System.Drawing.Size(120, 16)
        Me.BillOfLading.TabIndex = 2
        Me.BillOfLading.Text = "Bill of Lading"
        Me.BillOfLading.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'JobTicket
        '
        Me.JobTicket.Location = New System.Drawing.Point(8, 24)
        Me.JobTicket.Name = "JobTicket"
        Me.JobTicket.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.JobTicket.Size = New System.Drawing.Size(120, 16)
        Me.JobTicket.TabIndex = 1
        Me.JobTicket.Text = "Job Ticket"
        Me.JobTicket.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCancelP
        '
        Me.btnCancelP.BackColor = System.Drawing.Color.SlateGray
        Me.btnCancelP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelP.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelP.Location = New System.Drawing.Point(432, 580)
        Me.btnCancelP.Name = "btnCancelP"
        Me.btnCancelP.Size = New System.Drawing.Size(112, 26)
        Me.btnCancelP.TabIndex = 19
        Me.btnCancelP.Text = "&Cancel"
        '
        'btnSaveP
        '
        Me.btnSaveP.BackColor = System.Drawing.Color.SlateGray
        Me.btnSaveP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveP.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveP.Location = New System.Drawing.Point(300, 580)
        Me.btnSaveP.Name = "btnSaveP"
        Me.btnSaveP.Size = New System.Drawing.Size(112, 26)
        Me.btnSaveP.TabIndex = 18
        Me.btnSaveP.Text = "&Save"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.SlateGray
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(760, 578)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(94, 26)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "&In-Activate"
        Me.btnDelete.Visible = False
        '
        'tbPages
        '
        Me.tbPages.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tbPages.Controls.Add(Me.tbP1)
        Me.tbPages.Controls.Add(Me.tbP2)
        Me.tbPages.Controls.Add(Me.tbP3)
        Me.tbPages.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPages.Location = New System.Drawing.Point(2, 24)
        Me.tbPages.Name = "tbPages"
        Me.tbPages.SelectedIndex = 0
        Me.tbPages.Size = New System.Drawing.Size(922, 552)
        Me.tbPages.TabIndex = 2
        '
        'tbP1
        '
        Me.tbP1.BackColor = System.Drawing.Color.White
        Me.tbP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbP1.Controls.Add(Me.GroupBox1)
        Me.tbP1.Controls.Add(Me.grpPaperwork)
        Me.tbP1.Controls.Add(Me.grpProduct)
        Me.tbP1.Controls.Add(Me.GroupBox2)
        Me.tbP1.Location = New System.Drawing.Point(4, 25)
        Me.tbP1.Name = "tbP1"
        Me.tbP1.Size = New System.Drawing.Size(914, 523)
        Me.tbP1.TabIndex = 0
        Me.tbP1.Text = "Product Info"
        Me.tbP1.ToolTipText = "Product Info"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label59)
        Me.GroupBox1.Controls.Add(Me.txtCWTCode)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.lblCustomerName)
        Me.GroupBox1.Controls.Add(Me.Label56)
        Me.GroupBox1.Controls.Add(Me.Label55)
        Me.GroupBox1.Controls.Add(Me.Label53)
        Me.GroupBox1.Controls.Add(Me.txtMailingZip)
        Me.GroupBox1.Controls.Add(Me.Label52)
        Me.GroupBox1.Controls.Add(Me.txtMailingState)
        Me.GroupBox1.Controls.Add(Me.Label51)
        Me.GroupBox1.Controls.Add(Me.txtMailingCity)
        Me.GroupBox1.Controls.Add(Me.Label50)
        Me.GroupBox1.Controls.Add(Me.Label49)
        Me.GroupBox1.Controls.Add(Me.Label48)
        Me.GroupBox1.Controls.Add(Me.Label47)
        Me.GroupBox1.Controls.Add(Me.txtMailingAddress2)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMailingAddress1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtMailingName)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cmbDescs)
        Me.GroupBox1.Controls.Add(Me.Label41)
        Me.GroupBox1.Controls.Add(Me.Manifest_Description)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Type)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.SpecialInstructions)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.PermitNo)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.GenProdNo)
        Me.GroupBox1.Controls.Add(Me.btnApprovalNumbers)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnViewPNos)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ApprovalNo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.FedNo)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 2.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 260)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(904, 256)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'lblCustomerName
        '
        Me.lblCustomerName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(112, 12)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(240, 16)
        Me.lblCustomerName.TabIndex = 0
        '
        'Label56
        '
        Me.Label56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label56.Location = New System.Drawing.Point(112, 28)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(240, 1)
        Me.Label56.TabIndex = 80
        '
        'Label55
        '
        Me.Label55.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(8, 12)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(112, 16)
        Me.Label55.TabIndex = 78
        Me.Label55.Text = "Customer Name:"
        '
        'Label53
        '
        Me.Label53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label53.Location = New System.Drawing.Point(504, 90)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(128, 1)
        Me.Label53.TabIndex = 77
        '
        'txtMailingZip
        '
        Me.txtMailingZip.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMailingZip.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMailingZip.Location = New System.Drawing.Point(504, 74)
        Me.txtMailingZip.MaxLength = 10
        Me.txtMailingZip.Name = "txtMailingZip"
        Me.txtMailingZip.Size = New System.Drawing.Size(128, 13)
        Me.txtMailingZip.TabIndex = 10
        Me.txtMailingZip.Text = ""
        '
        'Label52
        '
        Me.Label52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label52.Location = New System.Drawing.Point(368, 90)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(41, 1)
        Me.Label52.TabIndex = 75
        '
        'txtMailingState
        '
        Me.txtMailingState.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMailingState.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMailingState.Location = New System.Drawing.Point(368, 74)
        Me.txtMailingState.MaxLength = 2
        Me.txtMailingState.Name = "txtMailingState"
        Me.txtMailingState.Size = New System.Drawing.Size(43, 13)
        Me.txtMailingState.TabIndex = 9
        Me.txtMailingState.Text = ""
        '
        'Label51
        '
        Me.Label51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label51.Location = New System.Drawing.Point(125, 90)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(158, 1)
        Me.Label51.TabIndex = 73
        '
        'txtMailingCity
        '
        Me.txtMailingCity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMailingCity.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMailingCity.Location = New System.Drawing.Point(128, 74)
        Me.txtMailingCity.MaxLength = 50
        Me.txtMailingCity.Name = "txtMailingCity"
        Me.txtMailingCity.Size = New System.Drawing.Size(146, 13)
        Me.txtMailingCity.TabIndex = 8
        Me.txtMailingCity.Text = ""
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(424, 74)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(88, 16)
        Me.Label50.TabIndex = 71
        Me.Label50.Text = "Mailing Zip :-"
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(280, 74)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(96, 16)
        Me.Label49.TabIndex = 70
        Me.Label49.Text = "Mailing State :-"
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(40, 74)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(88, 16)
        Me.Label48.TabIndex = 69
        Me.Label48.Text = "Mailing City :-"
        '
        'Label47
        '
        Me.Label47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label47.Location = New System.Drawing.Point(488, 68)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(240, 1)
        Me.Label47.TabIndex = 68
        '
        'txtMailingAddress2
        '
        Me.txtMailingAddress2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMailingAddress2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMailingAddress2.Location = New System.Drawing.Point(488, 52)
        Me.txtMailingAddress2.MaxLength = 50
        Me.txtMailingAddress2.Name = "txtMailingAddress2"
        Me.txtMailingAddress2.Size = New System.Drawing.Size(240, 13)
        Me.txtMailingAddress2.TabIndex = 7
        Me.txtMailingAddress2.Text = ""
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(368, 52)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(120, 16)
        Me.Label27.TabIndex = 66
        Me.Label27.Text = "Mailing Address #2 :-"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(128, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 1)
        Me.Label3.TabIndex = 65
        '
        'txtMailingAddress1
        '
        Me.txtMailingAddress1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMailingAddress1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMailingAddress1.Location = New System.Drawing.Point(128, 52)
        Me.txtMailingAddress1.MaxLength = 50
        Me.txtMailingAddress1.Name = "txtMailingAddress1"
        Me.txtMailingAddress1.Size = New System.Drawing.Size(240, 13)
        Me.txtMailingAddress1.TabIndex = 6
        Me.txtMailingAddress1.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Mailing Address #1 :-"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(104, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 1)
        Me.Label1.TabIndex = 62
        '
        'txtMailingName
        '
        Me.txtMailingName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMailingName.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMailingName.Location = New System.Drawing.Point(106, 32)
        Me.txtMailingName.MaxLength = 20
        Me.txtMailingName.Name = "txtMailingName"
        Me.txtMailingName.Size = New System.Drawing.Size(256, 13)
        Me.txtMailingName.TabIndex = 5
        Me.txtMailingName.Text = ""
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 16)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "Mailing Name :-"
        '
        'cmbDescs
        '
        Me.cmbDescs.DataSource = Me.DsDescriptions1.tblHWNumberDESCs
        Me.cmbDescs.DisplayMember = "HWNumber"
        Me.cmbDescs.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDescs.Location = New System.Drawing.Point(734, 66)
        Me.cmbDescs.Name = "cmbDescs"
        Me.cmbDescs.Size = New System.Drawing.Size(160, 21)
        Me.cmbDescs.TabIndex = 11
        Me.cmbDescs.ValueMember = "HWNumber"
        '
        'DsDescriptions1
        '
        Me.DsDescriptions1.DataSetName = "DSDescriptions"
        Me.DsDescriptions1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(750, 50)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(136, 16)
        Me.Label41.TabIndex = 58
        Me.Label41.Text = "Assign Description(s):"
        '
        'Manifest_Description
        '
        Me.Manifest_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Manifest_Description.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Manifest_Description.Location = New System.Drawing.Point(90, 94)
        Me.Manifest_Description.MaxLength = 200
        Me.Manifest_Description.Multiline = True
        Me.Manifest_Description.Name = "Manifest_Description"
        Me.Manifest_Description.Size = New System.Drawing.Size(808, 34)
        Me.Manifest_Description.TabIndex = 12
        Me.Manifest_Description.Text = ""
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(8, 94)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(80, 32)
        Me.Label28.TabIndex = 55
        Me.Label28.Text = "Manifest Description:"
        '
        'Label26
        '
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label26.Location = New System.Drawing.Point(88, 172)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(152, 1)
        Me.Label26.TabIndex = 54
        '
        'Type
        '
        Me.Type.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Type.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Type.Location = New System.Drawing.Point(92, 154)
        Me.Type.MaxLength = 20
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(144, 13)
        Me.Type.TabIndex = 15
        Me.Type.Text = ""
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(38, 156)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(40, 16)
        Me.Label25.TabIndex = 52
        Me.Label25.Text = "Type:"
        '
        'SpecialInstructions
        '
        Me.SpecialInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SpecialInstructions.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecialInstructions.Location = New System.Drawing.Point(56, 176)
        Me.SpecialInstructions.MaxLength = 500
        Me.SpecialInstructions.Multiline = True
        Me.SpecialInstructions.Name = "SpecialInstructions"
        Me.SpecialInstructions.Size = New System.Drawing.Size(844, 74)
        Me.SpecialInstructions.TabIndex = 17
        Me.SpecialInstructions.Text = ""
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(8, 178)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(46, 72)
        Me.Label24.TabIndex = 50
        Me.Label24.Text = "Special Instr:"
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Location = New System.Drawing.Point(348, 148)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(184, 1)
        Me.Label19.TabIndex = 48
        '
        'PermitNo
        '
        Me.PermitNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PermitNo.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PermitNo.Location = New System.Drawing.Point(354, 132)
        Me.PermitNo.MaxLength = 20
        Me.PermitNo.Name = "PermitNo"
        Me.PermitNo.Size = New System.Drawing.Size(176, 13)
        Me.PermitNo.TabIndex = 14
        Me.PermitNo.Text = ""
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(240, 132)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(106, 16)
        Me.Label22.TabIndex = 47
        Me.Label22.Text = "Verified Date :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label54)
        Me.GroupBox2.Controls.Add(Me.cmbWasteType)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 1.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(776, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(136, 68)
        Me.GroupBox2.TabIndex = 78
        Me.GroupBox2.TabStop = False
        '
        'Label54
        '
        Me.Label54.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(24, 8)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(88, 16)
        Me.Label54.TabIndex = 37
        Me.Label54.Text = "Waste Type :"
        '
        'cmbWasteType
        '
        Me.cmbWasteType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWasteType.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbWasteType.Location = New System.Drawing.Point(8, 30)
        Me.cmbWasteType.Name = "cmbWasteType"
        Me.cmbWasteType.Size = New System.Drawing.Size(121, 21)
        Me.cmbWasteType.TabIndex = 78
        '
        'tbP2
        '
        Me.tbP2.BackColor = System.Drawing.Color.White
        Me.tbP2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbP2.Controls.Add(Me.btnViewTemplate)
        Me.tbP2.Controls.Add(Me.Label11)
        Me.tbP2.Controls.Add(Me.cmbAssignTemplate)
        Me.tbP2.Controls.Add(Me.dgLabData)
        Me.tbP2.Location = New System.Drawing.Point(4, 25)
        Me.tbP2.Name = "tbP2"
        Me.tbP2.Size = New System.Drawing.Size(914, 523)
        Me.tbP2.TabIndex = 1
        Me.tbP2.Text = "LAB Data Template(s)"
        Me.tbP2.ToolTipText = "LAB Data Templates"
        '
        'btnViewTemplate
        '
        Me.btnViewTemplate.Image = CType(resources.GetObject("btnViewTemplate.Image"), System.Drawing.Image)
        Me.btnViewTemplate.Location = New System.Drawing.Point(536, 304)
        Me.btnViewTemplate.Name = "btnViewTemplate"
        Me.btnViewTemplate.Size = New System.Drawing.Size(32, 16)
        Me.btnViewTemplate.TabIndex = 36
        Me.btnViewTemplate.TabStop = False
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 304)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 16)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Assign a new Template:"
        '
        'cmbAssignTemplate
        '
        Me.cmbAssignTemplate.Location = New System.Drawing.Point(160, 304)
        Me.cmbAssignTemplate.Name = "cmbAssignTemplate"
        Me.cmbAssignTemplate.Size = New System.Drawing.Size(368, 21)
        Me.cmbAssignTemplate.TabIndex = 1
        '
        'dgLabData
        '
        Me.dgLabData.BackgroundColor = System.Drawing.Color.White
        Me.dgLabData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgLabData.CaptionVisible = False
        Me.dgLabData.DataMember = "tblProduct_LabData"
        Me.dgLabData.DataSource = Me.DsProductLabDat1
        Me.dgLabData.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgLabData.Location = New System.Drawing.Point(0, 0)
        Me.dgLabData.Name = "dgLabData"
        Me.dgLabData.ReadOnly = True
        Me.dgLabData.Size = New System.Drawing.Size(608, 296)
        Me.dgLabData.TabIndex = 0
        Me.dgLabData.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.ts_dgLabData})
        '
        'DsProductLabDat1
        '
        Me.DsProductLabDat1.DataSetName = "DSProductLabDat"
        Me.DsProductLabDat1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'ts_dgLabData
        '
        Me.ts_dgLabData.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.ts_dgLabData.DataGrid = Me.dgLabData
        Me.ts_dgLabData.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8})
        Me.ts_dgLabData.GridLineColor = System.Drawing.Color.Black
        Me.ts_dgLabData.HeaderBackColor = System.Drawing.Color.SteelBlue
        Me.ts_dgLabData.HeaderFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_dgLabData.HeaderForeColor = System.Drawing.Color.White
        Me.ts_dgLabData.MappingName = "tblProduct_LabData"
        Me.ts_dgLabData.RowHeadersVisible = False
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.MappingName = "ProductLabDataID"
        Me.DataGridTextBoxColumn5.Width = 0
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.MappingName = "ProductID"
        Me.DataGridTextBoxColumn6.Width = 0
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Template Name"
        Me.DataGridTextBoxColumn7.MappingName = "TemplateFile"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.ReadOnly = True
        Me.DataGridTextBoxColumn7.Width = 240
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "File Name"
        Me.DataGridTextBoxColumn8.MappingName = "FileName"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.ReadOnly = True
        Me.DataGridTextBoxColumn8.Width = 240
        '
        'tbP3
        '
        Me.tbP3.BackColor = System.Drawing.Color.White
        Me.tbP3.Controls.Add(Me.Label33)
        Me.tbP3.Controls.Add(Me.Label32)
        Me.tbP3.Controls.Add(Me.Label31)
        Me.tbP3.Controls.Add(Me.Label30)
        Me.tbP3.Controls.Add(Me.dgRates)
        Me.tbP3.Location = New System.Drawing.Point(4, 25)
        Me.tbP3.Name = "tbP3"
        Me.tbP3.Size = New System.Drawing.Size(914, 523)
        Me.tbP3.TabIndex = 2
        Me.tbP3.Text = "Rates"
        Me.tbP3.ToolTipText = "Setup Rates for this Product"
        '
        'Label33
        '
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label33.Location = New System.Drawing.Point(8, 16)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(1, 312)
        Me.Label33.TabIndex = 13
        '
        'Label32
        '
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label32.Location = New System.Drawing.Point(592, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(1, 312)
        Me.Label32.TabIndex = 12
        '
        'Label31
        '
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label31.Location = New System.Drawing.Point(8, 328)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(584, 1)
        Me.Label31.TabIndex = 11
        '
        'Label30
        '
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label30.Location = New System.Drawing.Point(8, 16)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(584, 1)
        Me.Label30.TabIndex = 10
        '
        'dgRates
        '
        Me.dgRates.BackgroundColor = System.Drawing.Color.White
        Me.dgRates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgRates.CaptionVisible = False
        Me.dgRates.DataMember = "tblProductRates"
        Me.dgRates.DataSource = Me.DsProductRates1
        Me.dgRates.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgRates.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgRates.Location = New System.Drawing.Point(5, 13)
        Me.dgRates.Name = "dgRates"
        Me.dgRates.Size = New System.Drawing.Size(584, 312)
        Me.dgRates.TabIndex = 1
        Me.dgRates.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.ts_dgProdutRates})
        '
        'DsProductRates1
        '
        Me.DsProductRates1.DataSetName = "DSProductRates"
        Me.DsProductRates1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'ts_dgProdutRates
        '
        Me.ts_dgProdutRates.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.ts_dgProdutRates.DataGrid = Me.dgRates
        Me.ts_dgProdutRates.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.col_ProdRates_1, Me.col_ProdRates_2, Me.col_ProdRates_3, Me.col_ProdRates_4})
        Me.ts_dgProdutRates.GridLineColor = System.Drawing.Color.Black
        Me.ts_dgProdutRates.HeaderBackColor = System.Drawing.Color.SteelBlue
        Me.ts_dgProdutRates.HeaderFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_dgProdutRates.HeaderForeColor = System.Drawing.Color.White
        Me.ts_dgProdutRates.MappingName = "tblProductRates"
        '
        'col_ProdRates_1
        '
        Me.col_ProdRates_1.Format = ""
        Me.col_ProdRates_1.FormatInfo = Nothing
        Me.col_ProdRates_1.MappingName = "ProdRateID"
        Me.col_ProdRates_1.ReadOnly = True
        Me.col_ProdRates_1.Width = 0
        '
        'col_ProdRates_2
        '
        Me.col_ProdRates_2.Format = ""
        Me.col_ProdRates_2.FormatInfo = Nothing
        Me.col_ProdRates_2.MappingName = "ProductID"
        Me.col_ProdRates_2.NullText = ""
        Me.col_ProdRates_2.Width = 0
        '
        'col_ProdRates_3
        '
        Me.col_ProdRates_3.Format = ""
        Me.col_ProdRates_3.FormatInfo = Nothing
        Me.col_ProdRates_3.HeaderText = "Rate Description"
        Me.col_ProdRates_3.MappingName = "RateDesc"
        Me.col_ProdRates_3.NullText = ""
        Me.col_ProdRates_3.Width = 300
        '
        'col_ProdRates_4
        '
        Me.col_ProdRates_4.Format = "G"
        Me.col_ProdRates_4.FormatInfo = Nothing
        Me.col_ProdRates_4.HeaderText = "Rate"
        Me.col_ProdRates_4.MappingName = "Rate"
        Me.col_ProdRates_4.NullText = ""
        Me.col_ProdRates_4.Width = 150
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Jet OLEDB:Database Password=;Data Source=""Z:\VB.NET Apps\BeaverOil" & _
        "\bin\JobTrackingSystem.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global B" & _
        "ulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=" & _
        ";Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Dat" & _
        "abase Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Loca" & _
        "le on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin" & _
        ";Jet OLEDB:Encrypt Database=False"
        '
        'DAProductLabData
        '
        Me.DAProductLabData.SelectCommand = Me.SelectPLabData
        Me.DAProductLabData.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblProduct_LabData", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ViewText", "ViewText"), New System.Data.Common.DataColumnMapping("RemoveText", "RemoveText"), New System.Data.Common.DataColumnMapping("ProductLabDataID", "ProductLabDataID"), New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("TemplateFile", "TemplateFile"), New System.Data.Common.DataColumnMapping("FileName", "FileName")})})
        '
        'SelectPLabData
        '
        Me.SelectPLabData.CommandText = "SELECT *, 'View' AS ViewText, 'Remove' AS RemoveText FROM tblProduct_LabData ORDE" & _
        "R BY ProductLabDataID"
        Me.SelectPLabData.Connection = Me.OleDbConnection1
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "ID"
        Me.DataGridTextBoxColumn1.MappingName = "ProductLabDataID"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Product"
        Me.DataGridTextBoxColumn2.MappingName = "ProductID"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 0
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Template Name"
        Me.DataGridTextBoxColumn3.MappingName = "TemplateFile"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 250
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "File Name"
        Me.DataGridTextBoxColumn4.MappingName = "FileName"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 325
        '
        'SelectProdRates
        '
        Me.SelectProdRates.CommandText = "SELECT ProdRateID, ProductID, Rate, RateDesc FROM tblProductRates"
        Me.SelectProdRates.Connection = Me.OleDbConnection1
        '
        'InsertRates
        '
        Me.InsertRates.CommandText = "INSERT INTO tblProductRates(ProductID, Rate, RateDesc) VALUES (?, ?, ?)"
        Me.InsertRates.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProductID", System.Data.OleDb.OleDbType.Integer, 0, "ProductID"))
        Me.InsertRates.Parameters.Add(New System.Data.OleDb.OleDbParameter("Rate", System.Data.OleDb.OleDbType.Double, 0, "Rate"))
        Me.InsertRates.Parameters.Add(New System.Data.OleDb.OleDbParameter("RateDesc", System.Data.OleDb.OleDbType.VarWChar, 50, "RateDesc"))
        '
        'UpdateRates
        '
        Me.UpdateRates.CommandText = "UPDATE tblProductRates SET ProductID = ?, Rate = ?, RateDesc = ? WHERE (ProductID" & _
        " = ?) AND (RateDesc = ?) AND (Rate = ?)"
        Me.UpdateRates.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProductID", System.Data.OleDb.OleDbType.Integer, 0, "ProductID"))
        Me.UpdateRates.Parameters.Add(New System.Data.OleDb.OleDbParameter("Rate", System.Data.OleDb.OleDbType.Double, 0, "Rate"))
        Me.UpdateRates.Parameters.Add(New System.Data.OleDb.OleDbParameter("RateDesc", System.Data.OleDb.OleDbType.VarWChar, 50, "RateDesc"))
        Me.UpdateRates.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductID", System.Data.DataRowVersion.Original, Nothing))
        Me.UpdateRates.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RateDesc", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RateDesc", System.Data.DataRowVersion.Original, Nothing))
        Me.UpdateRates.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Rate", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Rate", System.Data.DataRowVersion.Original, Nothing))
        '
        'DeleteRates
        '
        Me.DeleteRates.CommandText = "DELETE FROM tblProductRates WHERE (ProductID = ?) AND (RateDesc = ?) AND (ProdRat" & _
        "eID = ?) AND (Rate = ?)"
        Me.DeleteRates.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductID", System.Data.DataRowVersion.Original, Nothing))
        Me.DeleteRates.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RateDesc", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RateDesc", System.Data.DataRowVersion.Original, Nothing))
        Me.DeleteRates.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProdRateID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProdRateID", System.Data.DataRowVersion.Original, Nothing))
        Me.DeleteRates.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Rate", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Rate", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAProdRates
        '
        Me.DAProdRates.DeleteCommand = Me.DeleteRates
        Me.DAProdRates.InsertCommand = Me.InsertRates
        Me.DAProdRates.SelectCommand = Me.SelectProdRates
        Me.DAProdRates.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblProductRates", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ProdRateID", "ProdRateID"), New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("Rate", "Rate"), New System.Data.Common.DataColumnMapping("RateDesc", "RateDesc")})})
        Me.DAProdRates.UpdateCommand = Me.UpdateRates
        '
        'DADescs
        '
        Me.DADescs.SelectCommand = Me.SelectDESCs
        Me.DADescs.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblHWNumberDESCs", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("DescriptionsID", "DescriptionsID"), New System.Data.Common.DataColumnMapping("HWNumber", "HWNumber"), New System.Data.Common.DataColumnMapping("ProductDescription", "ProductDescription"), New System.Data.Common.DataColumnMapping("ProductDescription1", "ProductDescription1"), New System.Data.Common.DataColumnMapping("ManifestDescription", "ManifestDescription")})})
        '
        'SelectDESCs
        '
        Me.SelectDESCs.CommandText = "SELECT tblHWNumberDESCs.* FROM tblHWNumberDESCs ORDER BY HWNumber"
        Me.SelectDESCs.Connection = Me.OleDbConnection1
        '
        'grpSelectProduct
        '
        Me.grpSelectProduct.Controls.Add(Me.chkInactive)
        Me.grpSelectProduct.Controls.Add(Me.btnAddNewProduct)
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
        Me.grpSelectProduct.Location = New System.Drawing.Point(0, -2)
        Me.grpSelectProduct.Name = "grpSelectProduct"
        Me.grpSelectProduct.Size = New System.Drawing.Size(926, 204)
        Me.grpSelectProduct.TabIndex = 36
        Me.grpSelectProduct.TabStop = False
        Me.grpSelectProduct.Text = "Select a Product"
        '
        'chkInactive
        '
        Me.chkInactive.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInactive.ForeColor = System.Drawing.Color.Red
        Me.chkInactive.Location = New System.Drawing.Point(624, 184)
        Me.chkInactive.Name = "chkInactive"
        Me.chkInactive.Size = New System.Drawing.Size(292, 16)
        Me.chkInactive.TabIndex = 17
        Me.chkInactive.Text = "Choose from existing Inactive product list"
        Me.chkInactive.Visible = False
        '
        'btnAddNewProduct
        '
        Me.btnAddNewProduct.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewProduct.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewProduct.Location = New System.Drawing.Point(8, 184)
        Me.btnAddNewProduct.Name = "btnAddNewProduct"
        Me.btnAddNewProduct.Size = New System.Drawing.Size(224, 18)
        Me.btnAddNewProduct.TabIndex = 16
        Me.btnAddNewProduct.Text = "Add New Product Record"
        '
        'Fil_Approval
        '
        Me.Fil_Approval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fil_Approval.Location = New System.Drawing.Point(748, 12)
        Me.Fil_Approval.Name = "Fil_Approval"
        Me.Fil_Approval.Size = New System.Drawing.Size(152, 21)
        Me.Fil_Approval.TabIndex = 15
        Me.Fil_Approval.Text = ""
        '
        'Fill_Customer
        '
        Me.Fill_Customer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fill_Customer.Location = New System.Drawing.Point(218, 12)
        Me.Fill_Customer.Name = "Fill_Customer"
        Me.Fill_Customer.Size = New System.Drawing.Size(158, 21)
        Me.Fill_Customer.TabIndex = 14
        Me.Fill_Customer.Text = ""
        '
        'Fil_Product
        '
        Me.Fil_Product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fil_Product.Location = New System.Drawing.Point(600, 12)
        Me.Fil_Product.Name = "Fil_Product"
        Me.Fil_Product.Size = New System.Drawing.Size(148, 21)
        Me.Fil_Product.TabIndex = 4
        Me.Fil_Product.Text = ""
        '
        'Fil_City
        '
        Me.Fil_City.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fil_City.Location = New System.Drawing.Point(494, 12)
        Me.Fil_City.Name = "Fil_City"
        Me.Fil_City.Size = New System.Drawing.Size(106, 21)
        Me.Fil_City.TabIndex = 3
        Me.Fil_City.Text = ""
        '
        'Fil_Address
        '
        Me.Fil_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fil_Address.Location = New System.Drawing.Point(376, 12)
        Me.Fil_Address.Name = "Fil_Address"
        Me.Fil_Address.Size = New System.Drawing.Size(120, 21)
        Me.Fil_Address.TabIndex = 2
        Me.Fil_Address.Text = ""
        '
        'Fill_JobSite
        '
        Me.Fill_JobSite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fill_JobSite.Location = New System.Drawing.Point(28, 12)
        Me.Fill_JobSite.Name = "Fill_JobSite"
        Me.Fill_JobSite.Size = New System.Drawing.Size(190, 21)
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
        Me.dgSearchProduct.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgSearchProduct.LinkColor = System.Drawing.Color.Teal
        Me.dgSearchProduct.Location = New System.Drawing.Point(10, 36)
        Me.dgSearchProduct.Name = "dgSearchProduct"
        Me.dgSearchProduct.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dgSearchProduct.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.dgSearchProduct.RowHeaderWidth = 30
        Me.dgSearchProduct.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgSearchProduct.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgSearchProduct.Size = New System.Drawing.Size(908, 144)
        Me.dgSearchProduct.TabIndex = 5
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
        Me.dgTblStyle.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.col_GName, Me.col_GeneratorName, Me.col_GAdd, Me.col_City, Me.col_Product, Me.col_ProductID, Me.col_GenID, Me.Col_Approval, Me.DataGridBoolColumn1})
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
        'col_GName
        '
        Me.col_GName.Format = ""
        Me.col_GName.FormatInfo = Nothing
        Me.col_GName.HeaderText = "Generator"
        Me.col_GName.MappingName = "JobSite"
        Me.col_GName.NullText = ""
        Me.col_GName.ReadOnly = True
        Me.col_GName.Width = 180
        '
        'col_GeneratorName
        '
        Me.col_GeneratorName.Format = ""
        Me.col_GeneratorName.FormatInfo = Nothing
        Me.col_GeneratorName.HeaderText = "Customer"
        Me.col_GeneratorName.MappingName = "GeneratorName"
        Me.col_GeneratorName.NullText = ""
        Me.col_GeneratorName.Width = 160
        '
        'col_GAdd
        '
        Me.col_GAdd.Format = ""
        Me.col_GAdd.FormatInfo = Nothing
        Me.col_GAdd.HeaderText = "Address"
        Me.col_GAdd.MappingName = "JobSiteAddress1"
        Me.col_GAdd.NullText = ""
        Me.col_GAdd.ReadOnly = True
        Me.col_GAdd.Width = 115
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
        'Col_Approval
        '
        Me.Col_Approval.Format = ""
        Me.Col_Approval.FormatInfo = Nothing
        Me.Col_Approval.HeaderText = "Approval #"
        Me.Col_Approval.MappingName = "ApprovalNo"
        Me.Col_Approval.NullText = ""
        Me.Col_Approval.ReadOnly = True
        Me.Col_Approval.Width = 110
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.FalseValue = False
        Me.DataGridBoolColumn1.HeaderText = "Active?"
        Me.DataGridBoolColumn1.MappingName = "Status"
        Me.DataGridBoolColumn1.NullText = ""
        Me.DataGridBoolColumn1.NullValue = CType(resources.GetObject("DataGridBoolColumn1.NullValue"), Object)
        Me.DataGridBoolColumn1.ReadOnly = True
        Me.DataGridBoolColumn1.TrueValue = True
        Me.DataGridBoolColumn1.Width = 40
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(374, 184)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(101, 18)
        Me.btnSelect.TabIndex = 6
        Me.btnSelect.Text = "Select"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(480, 184)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(76, 18)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        '
        'lblBorder
        '
        Me.lblBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBorder.Location = New System.Drawing.Point(8, 34)
        Me.lblBorder.Name = "lblBorder"
        Me.lblBorder.Size = New System.Drawing.Size(912, 148)
        Me.lblBorder.TabIndex = 13
        '
        'ViewNewJobList
        '
        Me.ViewNewJobList.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ViewNewJobList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewNewJobList.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewNewJobList.Location = New System.Drawing.Point(786, 4)
        Me.ViewNewJobList.Name = "ViewNewJobList"
        Me.ViewNewJobList.Size = New System.Drawing.Size(136, 18)
        Me.ViewNewJobList.TabIndex = 43
        Me.ViewNewJobList.Text = "&View Product List"
        Me.ViewNewJobList.Visible = False
        '
        'grBottom
        '
        Me.grBottom.Controls.Add(Me.btnPrint)
        Me.grBottom.Controls.Add(Me.tbPages)
        Me.grBottom.Controls.Add(Me.btnCancelP)
        Me.grBottom.Controls.Add(Me.btnSaveP)
        Me.grBottom.Controls.Add(Me.btnDelete)
        Me.grBottom.Controls.Add(Me.ViewNewJobList)
        Me.grBottom.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Document, CType(0, Byte))
        Me.grBottom.Location = New System.Drawing.Point(2, 202)
        Me.grBottom.Name = "grBottom"
        Me.grBottom.Size = New System.Drawing.Size(924, 612)
        Me.grBottom.TabIndex = 44
        Me.grBottom.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.SlateGray
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(570, 580)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(112, 26)
        Me.btnPrint.TabIndex = 20
        Me.btnPrint.Text = "&Print"
        '
        'StatusBar1
        '
        Me.StatusBar1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.Location = New System.Drawing.Point(0, 816)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Size = New System.Drawing.Size(926, 19)
        Me.StatusBar1.TabIndex = 45
        Me.StatusBar1.Text = "StatusBar1"
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(680, 26)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(66, 30)
        Me.Label23.TabIndex = 178
        Me.Label23.Text = "New Product?"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkNewProduct
        '
        Me.chkNewProduct.Location = New System.Drawing.Point(706, 60)
        Me.chkNewProduct.Name = "chkNewProduct"
        Me.chkNewProduct.Size = New System.Drawing.Size(16, 16)
        Me.chkNewProduct.TabIndex = 179
        Me.chkNewProduct.Text = " "
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(250, 156)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(106, 16)
        Me.Label29.TabIndex = 81
        Me.Label29.Text = "CWT Code:"
        '
        'txtCWTCode
        '
        Me.txtCWTCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCWTCode.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCWTCode.Location = New System.Drawing.Point(368, 154)
        Me.txtCWTCode.MaxLength = 20
        Me.txtCWTCode.Name = "txtCWTCode"
        Me.txtCWTCode.Size = New System.Drawing.Size(144, 13)
        Me.txtCWTCode.TabIndex = 16
        Me.txtCWTCode.Text = ""
        '
        'Label59
        '
        Me.Label59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label59.Location = New System.Drawing.Point(364, 172)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(152, 1)
        Me.Label59.TabIndex = 83
        '
        'frmProduct
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(926, 835)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.grBottom)
        Me.Controls.Add(Me.grpSelectProduct)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product"
        Me.grpProduct.ResumeLayout(False)
        Me.grpPaperwork.ResumeLayout(False)
        Me.tbPages.ResumeLayout(False)
        Me.tbP1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DsDescriptions1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.tbP2.ResumeLayout(False)
        CType(Me.dgLabData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProductLabDat1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbP3.ResumeLayout(False)
        CType(Me.dgRates, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProductRates1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSelectProduct.ResumeLayout(False)
        CType(Me.dgSearchProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNewJobSearch1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grBottom.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Me.InitialLoad()
            Me.OleDbConnection1.ConnectionString = DBHelper.ConnStr
            If Me.OleDbConnection1.State = ConnectionState.Closed Then Me.OleDbConnection1.Open()
            Me.SelectProdRates.Connection = Me.OleDbConnection1
            Me.DeleteRates.Connection = Me.OleDbConnection1
            Me.InsertRates.Connection = Me.OleDbConnection1
            Me.UpdateRates.Connection = Me.OleDbConnection1
            Me.SelectDESCs.Connection = Me.OleDbConnection1

            Me.DADescs.Fill(Me.DsDescriptions1)

            col_dgLabData_V.InitializeRowCount(0)
            col_dgLabData_V.Format = ""
            col_dgLabData_V.FormatInfo = Nothing
            col_dgLabData_V.HeaderText = ""
            col_dgLabData_V.MappingName = "ViewText"
            col_dgLabData_V.NullText = "View"
            col_dgLabData_V.Width = 50
            col_dgLabData_V.Alignment = HorizontalAlignment.Center
            Me.ts_dgLabData.GridColumnStyles.Add(col_dgLabData_V)
            col_dgLabData_D.InitializeRowCount(0)
            col_dgLabData_D.Format = ""
            col_dgLabData_D.FormatInfo = Nothing
            col_dgLabData_D.HeaderText = ""
            col_dgLabData_D.MappingName = "RemoveText"
            col_dgLabData_D.NullText = "Remove"
            col_dgLabData_D.Width = 50
            col_dgLabData_D.Alignment = HorizontalAlignment.Center
            Me.ts_dgLabData.GridColumnStyles.Add(col_dgLabData_D)

            Me.grBottom.Visible = False
            Me.LoadDGValues(Not addNewFlag)
            Me.Height = 610

            ProductCount = DBHelper.GetInteger("SELECT Count(*) FROM tblProducts WHERE Active = TRUE")
            Me.StatusBar1.Text = "Unique Product Records =" & ProductCount
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Ocurred while loading data")
        End Try
    End Sub

    Function InitialLoad()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet
        Dim strSQL As String
        Try
            '-------------------------------------------------------------------
            'Haigriv Vyas
            'Date: 07/05/2005
            '-------------------------------------------------------------------
            'strSQL = "SELECT GeneratorID, (JobSite + ' : ' + GeneratorName + ' : ' + JobSiteAddress1)  as JobSite FROM tblGenerators ORDER BY JobSite, GeneratorName"
            strSQL = "SELECT GeneratorID, (GeneratorName + ' : ' + JobSite + ' : ' + JobSiteCity)  as JobSite FROM tblGenerators WHERE Active = TRUE ORDER BY (GeneratorName + ' : ' + JobSiteAddress1 + ' : ' + JobSiteCity + ', ' + JobSiteState + ' ' + JobSiteZip) "
            ds = DBHelper.GetDataSet(strSQL, "tblGenerators")
            Me.GeneratorID.DataSource = ds
            Me.GeneratorID.DisplayMember = "tblGenerators.JobSite"
            Me.GeneratorID.ValueMember = "tblGenerators.GeneratorID"
            Me.GeneratorID.SelectedText = ""
            Me.GeneratorID.Text = ""

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
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try
        Me.clearAll()
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function

    Function clearAll()
        Me.lblGen.Text = ""
        Me.lblGCityStateZip.Text = ""
        Me.lblGAdd.Text = ""
        Me.ProductN.Text = ""
        Me.GeneratorID.SelectedText = ""
        Me.GeneratorID.Text = ""
        Me.GenProdNo.Text = ""
        Me.PermitNo.Text = ""
        Me.ApprovalNo.Text = ""
        Me.SpecialInstructions.Text = ""
        Me.ProductDescription.Text = ""
        Me.FedNo.Text = ""
        Me.HWNumber.Text = ""
        Me.txtAdditionalHWNumber.Text = ""
        Me.txtLandbanText.Text = ""
        Me.Type.Text = ""
        Me.ProductDescription.Text = ""
        Me.ProductDescription1.Text = ""
        Me.ProcessDescription.Text = ""
        Me.JobTicket.Checked = True
        Me.BillOfLading.Checked = True
        Me.Hazardous.Checked = False
        Me.NonHazardous.Checked = False
        Me.AnalyticalDate.Text = ""
        Me.cmbAssignTemplate.Items.Clear()
        Me.cmbAssignTemplate.Text = ""
        Me.Manifest_Description.Text = ""
        Me.LabRecertDate.Text = ""
        Me.chkLandBanForm.Checked = False
        Me.cmbWasteType.SelectedText = ""
        Me.cmbWasteType.Text = ""
        '-------------------------------------------------------------------
        'Haigriv Vyas
        'Date: 07/05/2005
        '-------------------------------------------------------------------
        Me.lblCustomerName.Text = ""
        Me.chkNewProduct.Checked = False

    End Function

    Private Sub btnViewP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.populateProductInfo(1, 0, 0)
        Me.tbPages.SelectedTab = Me.tbPages.TabPages(0)
        Me.ProductN.Focus()
        Me.PopulateTemplateDatagrid()
        Me.populateRates()

    End Sub

    Private Sub btnCancelP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelP.Click

        Me.Close()

    End Sub

    Private Sub btnSaveP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveP.Click

        If Me.ProductN.Text = "" Then
            MsgBox("Missing ProductName. Please enter a ProductName.", MsgBoxStyle.Information, "Save Product")
            Me.ProductN.Focus()
            Exit Sub
        End If
        If Me.GeneratorID.SelectedIndex < 0 Then
            MsgBox("Missing Generator. Please select a Generator.", MsgBoxStyle.Information, "Save Product")
            Me.GeneratorID.Focus()
            Exit Sub
        End If
        If Me.AnalyticalDate.Text = "" Then
            MsgBox("Missing Analytical Date. Please enter the last Analytical Date.", MsgBoxStyle.Information, "Save Product")
            Me.AnalyticalDate.Focus()
            Exit Sub
        End If
        'If Me.TypeOfProduct.SelectedIndex < 0 Then
        '    MsgBox("Please select a Type of Product.", MsgBoxStyle.Information, "Save Product")
        '    Me.TypeOfProduct.Focus()
        '    Exit Sub
        'End If

        Dim strSQL As String = String.Empty
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        Try
            Dim alreadyExists As Boolean = False, Active As Boolean = False
            Dim ProductName As String, ProductDescription As String, ProductDescription1 As String, AnalyticalDate As String, LabRecertDate As String, ProcessDescription As String
            Dim GenProdNo As String, FedNo As String, PermitNo As String, ApprovalNo As String, HWNumber As String, GeneratorID As Long
            Dim JobTicket As Boolean, BillOfLading As Boolean, Hazardous As Boolean, NonHazardous As Boolean, Plant2Manifest As Boolean, LandBanForm As Boolean
            Dim TypeOfProduct As Integer = 1, Type As String, SpecialInstructions As String, Manifest_Description As String
            Dim LanBandText As String
            Dim strWasteType As String
            Dim str1 As String
            Dim strAddHWNumber As String = ""
            'Grab values entered
            ProductName = Me.ProductN.Text
            GeneratorID = Me.GeneratorID.SelectedValue
            ProductDescription = Me.ProductDescription.Text
            ProductDescription1 = Me.ProductDescription1.Text
            AnalyticalDate = Me.AnalyticalDate.Text
            GenProdNo = Me.GenProdNo.Text
            FedNo = Me.FedNo.Text
            PermitNo = Me.PermitNo.Text
            ApprovalNo = Me.ApprovalNo.Text
            HWNumber = Me.HWNumber.Text
            strAddHWNumber = Me.txtAdditionalHWNumber.Text.Trim
            LanBandText = Me.txtLandbanText.Text.Trim
            JobTicket = Me.JobTicket.Checked
            BillOfLading = Me.BillOfLading.Checked
            Hazardous = Me.Hazardous.Checked
            NonHazardous = Me.NonHazardous.Checked
            Plant2Manifest = Me.Plant2Manifest.Checked
            LandBanForm = Me.chkLandBanForm.Checked
            Active = Me.chkActive.Checked
            SpecialInstructions = Me.SpecialInstructions.Text
            LabRecertDate = Me.LabRecertDate.Text
            Type = Me.Type.Text
            Manifest_Description = Replace(Me.Manifest_Description.Text, "'", "''")
            ProcessDescription = Replace(Me.ProcessDescription.Text, "'", "''")
            strWasteType = Me.cmbWasteType.Text


            If DBHelper.GetRecordCount("SELECT Count(*) FROM tblProducts WHERE Active = TRUE and ProductName = '" & Replace(ProductName, "'", "''") & "' AND GeneratorID= " & GeneratorID & "") > 0 Then
                alreadyExists = True
            End If
            If alreadyExists = True And Me.prodID = 0 Then
                MsgBox("This Product already exists. Please re-enter.", MsgBoxStyle.Information, "Generator")
            Else
                If prodID > 0 Then
                    strSQL = "UPDATE tblProducts SET GeneratorID=" & GeneratorID & ", ProductName='" & Replace(ProductName, "'", "''") & "', ProductDescription='" & Replace(ProductDescription, "'", "''") & "', " _
                            & "GenProdNo='" & Replace(GenProdNo, "'", "''") & "', FedNo='" & Replace(FedNo, "'", "''") & "', PermitNo='" & Replace(PermitNo, "'", "''") & "', ApprovalNo='" & Replace(ApprovalNo, "'", "''") & "', HWNumber='" & Replace(HWNumber, "'", "''") & "',LandBanText='" & Replace(LanBandText, "'", "''") & "'," _
                            & "JobTicket=" & JobTicket & ", BillOfLading=" & BillOfLading & ", Hazardous=" & Hazardous & ", NonHazardous=" & NonHazardous & ", Plant2Manifest=" & Plant2Manifest & ",LandBanForm =" & LandBanForm & ", " _
                            & "AnalyticalDate='" & AnalyticalDate & "', Active=" & Active & ", SpecialInstructions = '" & Replace(SpecialInstructions, "'", "''") & "', Manifest_Description = '" & Manifest_Description & "', LabRecertDate = '" & LabRecertDate & "', ProductDescription1 = '" & Replace(ProductDescription1, "'", "''", 1) & "', ProcessDescription = '" & ProcessDescription & "'," _
                            & " WasteType = '" & strWasteType & "',AdditionalHWNumber = '" & strAddHWNumber & "',Type = '" & Me.Type.Text & "', IsNewProduct=" & Me.chkNewProduct.Checked & ", CWTCode='" & Me.txtCWTCode.Text & "'  WHERE ProductID = " & Me.prodID

                    str1 = "UPDATE tblGenerators SET MailingName = '" & Replace(Me.txtMailingName.Text.Trim, "'", "''") & "'," _
                                                & " MailingAddress1 = '" & Replace(Me.txtMailingAddress1.Text.Trim, "'", "''") & "'," _
                                                & " MailingAddress2 = '" & Replace(Me.txtMailingAddress2.Text.Trim, "'", "''") & "'," _
                                                & " MailingCity = '" & Replace(Me.txtMailingCity.Text.Trim, "'", "''") & "'," _
                                                & " MailingState = '" & Replace(Me.txtMailingState.Text.Trim, "'", "''") & "'," _
                                                & " MailingZip ='" & Replace(Me.txtMailingZip.Text.Trim, "'", "''") & "'" _
                                                & " WHERE GeneratorID = " & GeneratorID
                    If Me.addNewFlag = True Then Me.addNewFlag = False
                ElseIf Me.addNewFlag = True Then
                    strSQL = "INSERT INTO tblProducts(GeneratorID, ProductName, ProductDescription, AnalyticalDate, GenProdNo, FedNo, PermitNo, JobTicket, BillOfLading, NonHazardous, Hazardous, Active, Plant2Manifest, Type, HWNumber, ApprovalNo, SpecialInstructions, Manifest_Description, LabRecertDate, ProductDescription1, ProcessDescription,LandBanForm,LandBanText,WasteType,AdditionalHWNumber, IsNewProduct, CWTCode) " _
                            & " SELECT " & GeneratorID & ", '" & Replace(ProductName, "'", "''") & "', '" & Replace(ProductDescription, "'", "''") & "', '" & Replace(AnalyticalDate, "'", "''") & "', '" & Replace(GenProdNo, "'", "''") & "', '" & Replace(FedNo, "'", "''") & "', '" & Replace(PermitNo, "'", "''") & "', " & JobTicket & ", " & BillOfLading & ", " & NonHazardous & ", " & Hazardous & ", " & Active & "," & Plant2Manifest & ", '" & Replace(Type, "'", "''") & "', '" & Replace(HWNumber, "'", "''") & "', '" & Replace(ApprovalNo, "'", "''") & "', '" & Replace(SpecialInstructions, "'", "''") & "', '" & Manifest_Description & "', '" & LabRecertDate & "', '" & Replace(ProductDescription1, "'", "''") & "', '" & ProcessDescription & "'," & LandBanForm & ",'" & LanBandText & "','" & strWasteType & "','" & strAddHWNumber & "'," & Me.chkNewProduct.Checked & ", '" & Me.txtCWTCode.Text & "';"
                    Me.addNewFlag = False
                End If
                Me.chkInactive.Visible = False
                If DBHelper.ExecuteQuery(strSQL) = False Then
                    If str1.Trim <> "" Then
                        If DBHelper.ExecuteQuery(str1) = False Then
                            MsgBox("An error ocurred while performing this operation.", MsgBoxStyle.Information, "Error")
                        End If
                    End If
                Else
                    If Me.prodID > 0 Then
                        Me.FillTemplates()
                    End If
                    If Me.prodID > 0 Then
                        If Me.DsProductRates1.HasChanges = True Then
                            Me.DAProdRates.Update(Me.DsProductRates1)
                        End If
                    End If
                End If
                ProductCount = DBHelper.GetInteger("SELECT Count(*) FROM tblProducts WHERE Active = TRUE")
                Me.StatusBar1.Text = "Unique Product Records =" & ProductCount
                Me.LoadDGValues(Not Me.addNewFlag)
            End If
            Me.ViewNewJobList.Visible = False
            Me.grpSelectProduct.Visible = True
            Me.grBottom.Visible = False
            Me.grpSelectProduct.Top = 0
            Me.tbPages.Top = 216
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Function populateProductInfo(ByVal whatOpt As Integer, ByVal GID As Long, ByVal PID As Long)

        If GID = 0 Then
            MsgBox("Please select a Generator first.", MsgBoxStyle.Information, "Product")
            Exit Function
        End If
        If PID = 0 Then
            MsgBox("Please select a Product first.", MsgBoxStyle.Information, "Product")
            Exit Function
        End If

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        If whatOpt = 1 Then
            Me.prodID = PID
            Me.genID = GID
        ElseIf whatOpt = 2 Then
            Me.prodID = PID
            Me.genID = GID
            Me.grpSelectProduct.Visible = False
            Me.grBottom.Visible = True
            Me.grBottom.Top = 0
            Me.tbPages.Top = 30
            Me.Height = 610
            ViewNewJobList.Visible = True
        End If
        Dim strSQL As String
        Dim ds As DataSet
        Me.clearAll()
        Dim display As Boolean = False
        If Me.chkInactive.Visible = False Then
            display = True
        Else
            If Me.chkInactive.Checked Then
                display = True
            End If
        End If
        If display Then
            Me.FillTemplates()
            Me.populateRates()
            strSQL = "SELECT * FROM tblProducts WHERE ProductID = " & Me.prodID
            Try
                ds = DBHelper.GetDataSet(strSQL, "tblProducts")
                If ds.Tables(0).Rows.Count > 0 Then
                    Dim dtRow As DataRow
                    dtRow = ds.Tables(0).Rows(0)
                    Me.ProductN.Text = dtRow.Item("ProductName")
                    Me.GeneratorID.SelectedValue = dtRow.Item("GeneratorID")
                    Me.ProcessDescription.Text = IIf(IsDBNull(dtRow.Item("processdescription")), "", dtRow.Item("ProcessDescription"))
                    Me.ProductDescription.Text = IIf(IsDBNull(dtRow.Item("ProductDescription")), "", dtRow.Item("ProductDescription"))
                    Me.ProductDescription1.Text = IIf(IsDBNull(dtRow.Item("ProductDescription1")), "", dtRow.Item("ProductDescription1"))
                    Me.AnalyticalDate.Text = IIf(IsDBNull(dtRow.Item("AnalyticalDate")), "", dtRow.Item("AnalyticalDate"))
                    Me.LabRecertDate.Text = IIf(IsDBNull(dtRow.Item("LabRecertDate")), "", dtRow.Item("LabRecertDate"))
                    Me.GenProdNo.Text = IIf(IsDBNull(dtRow.Item("GenProdNo")), "", dtRow.Item("GenProdNo"))
                    Me.FedNo.Text = IIf(IsDBNull(dtRow.Item("FedNo")), "", dtRow.Item("FedNo"))
                    Me.PermitNo.Text = IIf(IsDBNull(dtRow.Item("PermitNo")), "", dtRow.Item("PermitNo"))
                    Me.ApprovalNo.Text = IIf(IsDBNull(dtRow.Item("ApprovalNo")), "", dtRow.Item("ApprovalNo"))
                    Me.HWNumber.Text = IIf(IsDBNull(dtRow.Item("HWNumber")), "", dtRow.Item("HWNumber"))
                    Me.txtAdditionalHWNumber.Text = IIf(IsDBNull(dtRow.Item("AdditionalHWNumber")), "", dtRow.Item("AdditionalHWNumber"))
                    Me.txtLandbanText.Text = IIf(IsDBNull(dtRow.Item("LandBanText")), "", dtRow.Item("LandBanText"))
                    Me.SpecialInstructions.Text = IIf(IsDBNull(dtRow.Item("SpecialInstructions")), "", dtRow.Item("SpecialInstructions"))
                    Me.Type.Text = IIf(IsDBNull(dtRow.Item("Type")), "", dtRow.Item("Type"))
                    Me.JobTicket.Checked = IIf(IsDBNull(dtRow.Item("JobTicket")), False, dtRow.Item("JobTicket"))
                    Me.BillOfLading.Checked = IIf(IsDBNull(dtRow.Item("BillOfLading")), False, dtRow.Item("BillOfLading"))
                    Me.NonHazardous.Checked = IIf(IsDBNull(dtRow.Item("NonHazardous")), False, dtRow.Item("NonHazardous"))
                    Me.Hazardous.Checked = IIf(IsDBNull(dtRow.Item("Hazardous")), False, dtRow.Item("Hazardous"))
                    Me.Plant2Manifest.Checked = IIf(IsDBNull(dtRow.Item("Plant2Manifest")), False, dtRow.Item("Plant2Manifest"))
                    Me.chkLandBanForm.Checked = IIf(IsDBNull(dtRow.Item("LandBanForm")), False, dtRow.Item("LandBanForm"))
                    Me.Manifest_Description.Text = (IIf(IsDBNull(dtRow.Item("Manifest_Description")), "", dtRow.Item("Manifest_Description")))
                    Me.chkActive.Checked = IIf(IsDBNull(dtRow.Item("Active")), True, dtRow.Item("Active"))
                    Me.chkNewProduct.Checked = IIf(IsDBNull(dtRow.Item("IsNewProduct")), False, dtRow.Item("IsNewProduct"))
                    Me.txtCWTCode.Text = IIf(IsDBNull(dtRow.Item("CWTCode")), "", dtRow.Item("CWTCode"))
                    'Dim index As Short = Me.cmbWasteType.Items.IndexOf(IIf(IsDBNull(dtRow.Item("WasteType")), " ", dtRow.Item("WasteType")))
                    Me.cmbWasteType.Text = IIf(IsDBNull(dtRow.Item("WasteType")), " ", dtRow.Item("WasteType"))
                    'If IsDBNull(dtRow.Item("TypeOfProduct")) = True Then
                    '    Me.TypeOfProduct.SelectedIndex = 1
                    '    Me.TypeOfProduct.Text = "Non-Hazardous"
                    'ElseIf dtRow.Item("TypeOfProduct") = 1 Then
                    '    Me.TypeOfProduct.SelectedIndex = 0
                    '    Me.TypeOfProduct.Text = "Hazardous"
                    'ElseIf dtRow.Item("TypeOfProduct") = 2 Then
                    '    Me.TypeOfProduct.SelectedIndex = 1
                    '    Me.TypeOfProduct.Text = "Non-Hazardous"
                    'ElseIf dtRow.Item("TypeOfProduct") = 3 Then
                    '    Me.TypeOfProduct.SelectedIndex = 2
                    '    Me.TypeOfProduct.Text = "BOL"
                    'ElseIf dtRow.Item("TypeOfProduct") = 4 Then
                    '    Me.TypeOfProduct.SelectedIndex = 3
                    '    Me.TypeOfProduct.Text = "Plant 2 Manifest"
                    'End If
                    dtRow = Nothing
                Else
                    MsgBox("Product selected was not found. Please make another selection.", MsgBoxStyle.Information, "Product")
                End If
            Catch ex As SystemException
                MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

            Finally
                ds = Nothing
                Cursor.Current = System.Windows.Forms.Cursors.Default
            End Try
        End If

        If genID <> 0 Then
            Try
                Dim dsGen As DataSet = New DataSet
                strSQL = "SELECT * FROM tblGenerators WHERE GeneratorID = " & genID
                ds = DBHelper.GetDataSet(strSQL, "tblGenerators")
                If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                    Dim dtrow As DataRow
                    dtRow = ds.Tables(0).Rows(0)
                    Me.txtMailingName.Text = IIf(IsDBNull(dtRow.Item("MailingName")), "", dtRow.Item("MailingName"))
                    Me.txtMailingAddress1.Text = IIf(IsDBNull(dtRow.Item("MailingAddress1")), "", dtRow.Item("MailingAddress1"))
                    Me.txtMailingAddress2.Text = IIf(IsDBNull(dtRow.Item("MailingAddress2")), "", dtRow.Item("MailingAddress2"))
                    Me.txtMailingCity.Text = IIf(IsDBNull(dtRow.Item("MailingCity")), "", dtRow.Item("MailingCity"))
                    Me.txtMailingState.Text = IIf(IsDBNull(dtRow.Item("MailingState")), "", dtRow.Item("MailingState"))
                    Me.txtMailingZip.Text = IIf(IsDBNull(dtRow.Item("MailingZip")), "", dtRow.Item("MailingZip"))
                    Me.lblCustomerName.Text = IIf(IsDBNull(dtRow.Item("JobSite")), "", dtRow.Item("JobSite"))
                End If
                If Me.genID > 0 Then
                    Me.GeneratorID.SelectedValue = Me.genID
                End If

            Catch ex As SystemException
                MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

            Finally
                ds = Nothing
                Cursor.Current = System.Windows.Forms.Cursors.Default
            End Try
        End If
    End Function

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        Dim ds As DataSet
        Dim strsql As String = "SELECT tblProducts.*, tblGenerators.GeneratorName, tblGenerators.JobSite FROM (tblProducts INNER JOIN tblGenerators ON tblProducts.GeneratorID = tblGenerators.GeneratorID) ORDER BY tblGenerators.GeneratorName, tblProducts.ProductName"

        Try
            ds = DBHelper.GetDataSet(strsql, "tblProducts")
            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("No matching data found. Cancelling Report..", MsgBoxStyle.Information, "Products List")
            Else
                Dim frmR As New frmReport
                Dim objR As New rpt_ProductsList
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

    Function FillTemplates()

        'Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        'Me.cmbAssignTemplate.Items.Clear()
        'Try
        '    'Dim folderPath As String = Application.StartupPath & "\Analytical Input Forms"
        '    Dim folderPath As String = DBHelper.Analytical_Files_Location
        '    Dim dirTemp As New DirectoryInfo(folderPath)
        '    Dim objFile As FileInfo
        '    If Directory.Exists(folderPath) Then
        '        For Each objFile In dirTemp.GetFiles
        '            Me.cmbAssignTemplate.Items.Add(objFile.Name)
        '        Next
        '    End If
        'Catch ex As SystemException
        '    MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
        'Finally
        '    Cursor.Current = System.Windows.Forms.Cursors.Default
        'End Try

    End Function

    Private Sub btnViewTemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewTemplate.Click

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            If Me.cmbAssignTemplate.Text = "" Then Exit Sub
            Dim objfile As File, fileName As String, originalTemplate As String
            Dim alreadyExists As Boolean
            'Check to see if this template already exists
            If DBHelper.GetRecordCount("SELECT Count(*) FROM tblProduct_LabData WHERE ProductID = " & Me.prodID & " AND TemplateFile = '" & Replace(Me.cmbAssignTemplate.Text, "'", "''") & "'") > 0 Then
                alreadyExists = True
            Else
                alreadyExists = False
            End If
            'If this template already exists
            If alreadyExists = True Then
                If MsgBox("This template has already been assigned to this Product. Do you want to overwrite it?", MsgBoxStyle.YesNo, "Overwrite Template") = MsgBoxResult.Yes Then
                    fileName = DBHelper.GetStringVar("SELECT FileName FROM tblProduct_LabData WHERE WHERE ProductID = " & Me.prodID & " AND TemplateFile = '" & Replace(Me.cmbAssignTemplate.Text, "'", "''") & "'")
                    objfile.Delete(folderPath & "\SavedFiles\" & fileName)
                    fileName = Me.prodID & "_" & Replace(Replace(Me.ProductN.Text, "/", "_"), ".", "_") & "_" & Replace(Replace(Me.cmbAssignTemplate.Text, "/", "_"), ".", "_") & ".xls"
                    objfile.Copy(folderPath & "\" & Me.cmbAssignTemplate.Text, folderPath & "\SavedFiles\" & fileName, True)
                    originalTemplate = Me.cmbAssignTemplate.Text
                Else
                    Exit Sub
                End If
                DBHelper.ExecuteQuery("UPDATE tblProduct_LabData SET FileName = '" & fileName & "' WHERE TemplateFile = '" & Replace(Me.cmbAssignTemplate.Text, "'", "''") & "'")
                Me.PopulateTemplateDatagrid()
                'If this template does not exist
            Else
                'If the Directory does not exist
                If Directory.Exists(folderPath & "\SavedFiles") = False Then Directory.CreateDirectory(folderPath & "\SavedFiles")
                fileName = Me.prodID & "_" & Replace(Replace(Me.ProductN.Text, "/", "_"), ".", "_") & "_" & Replace(Replace(Me.cmbAssignTemplate.Text, "/", "_"), ".", "_") & ".xls"
                objfile.Copy(folderPath & "\" & Me.cmbAssignTemplate.Text, folderPath & "\SavedFiles\" & fileName, True)
                originalTemplate = Me.cmbAssignTemplate.Text
                DBHelper.ExecuteQuery("INSERT INTO tblProduct_LabData(ProductID, TemplateFile, FileName) SELECT " & Me.prodID & ", '" & Replace(Me.cmbAssignTemplate.Text, "'", "''") & "', '" & fileName & "'")
                Me.PopulateTemplateDatagrid()
            End If
            'Launch the file
            System.Diagnostics.Process.Start(folderPath & "\SavedFiles\" & fileName)
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
        Finally
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Function PopulateTemplateDatagrid()
        Dim aConn As OleDb.OleDbConnection
        Try
            Me.DsProductLabDat1.Clear()
            aConn = New OleDb.OleDbConnection(DBHelper.ConnStr)
            If aConn.State = ConnectionState.Closed Then aConn.Open()
            Me.SelectPLabData.Connection = aConn
            Me.DAProductLabData.Fill(Me.DsProductLabDat1, "tblProduct_LabData")
            Me.dgLabData.DataSource = Me.DsProductLabDat1
            Me.dgLabData.DataMember = "tblProduct_LabData"
            Me.dgLabData.Refresh()
            Me.col_dgLabData_V.InitializeRowCount(Me.DsProductLabDat1.Tables(0).Rows.Count)
            Me.col_dgLabData_D.InitializeRowCount(Me.DsProductLabDat1.Tables(0).Rows.Count)
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
        Finally
            If aConn.State = ConnectionState.Open Then aConn.Close()
            aConn = Nothing
        End Try

    End Function

    Function ViewProductInfo(ByVal whatPID As Long, ByVal whatGID As Long)

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        If Me.Visible = False Then
            Me.Visible = True
        End If
        Me.populateProductInfo(2, whatGID, whatPID)
        Cursor.Current = System.Windows.Forms.Cursors.Default

        If whatGID > 0 Then
            Me.lblGen.Text = DBHelper.GetStringVar("SELECT GeneratorName FROM tblGenerators WHERE GeneratorID = " & whatGID & "")
            Me.lblGAdd.Text = DBHelper.GetStringVar("SELECT JobSiteAddress1 FROM tblGenerators WHERE GeneratorID = " & whatGID & "")
            Me.lblGCityStateZip.Text = DBHelper.GetStringVar("SELECT (JobSiteCity + ', ' + JobSiteState + ' ' + JobSiteZip) FROM tblGenerators WHERE GeneratorID = " & whatGID & "")
            'Me.lblGen.Text = Me.GeneratorID.Text
        End If

    End Function

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If MsgBox("Are you sure you want to In-Activate this Product?", MsgBoxStyle.YesNo, "In-Activate Product") = MsgBoxResult.Yes Then
                If DBHelper.ExecuteQuery("UPDATE tblProducts SET Active = False WHERE ProductID = " & Me.prodID & "") = True Then
                    Me.InitialLoad()
                Else
                    MsgBox("Could not In-Activate. There was an error.", MsgBoxStyle.Information, "Error Ocurred")
                End If
            End If
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
        End Try
    End Sub

    Private Sub GeneratorID_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GeneratorID.KeyUp

        Dim index As Integer, actual As String, found As String
        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Back) Or (e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        ' Store the actual text that has been typed
        actual = Me.GeneratorID.Text
        ' Find the first match for the typed value
        index = Me.GeneratorID.FindString(actual)
        ' Get the text of the first match
        If (index > -1) Then
            ' Select this item from the list
            Me.GeneratorID.SelectedIndex = index
            found = Me.GeneratorID.Text
            ' Select the portion of the text that was automatically added so further typing will replace it
            Me.GeneratorID.SelectionStart = actual.Length
            Me.GeneratorID.SelectionLength = found.Length - actual.Length
        End If

    End Sub

    Private Sub HandleCellButtonClick(ByVal whatVal As String, ByVal cellVal As String)

        If CStr(whatVal).ToUpper = "VIEW" Then
            Dim folderPath As String = DBHelper.Analytical_Files_Location
            'Launch the file
            System.Diagnostics.Process.Start(folderPath & "\SavedFiles\" & cellVal)
        Else
            If MsgBox("Are you sure you want to remove this Template assignment?", MsgBoxStyle.YesNo, "Remove") = MsgBoxResult.Yes Then
                Dim fileName As String = DBHelper.GetStringVar("SELECT FileName FROM tblProduct_LabData WHERE ProductLabDataID = " & CLng(cellVal) & "")
                Dim objfile As File
                objfile.Delete(folderPath & "\SavedFiles\" & fileName)
                DBHelper.ExecuteQuery("DELETE * FROM tblProduct_LabData WHERE ProductLabDataID = " & CLng(cellVal) & "")
                Me.PopulateTemplateDatagrid()
            End If
        End If

    End Sub

    Private Sub dgLabData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgLabData.Click

        If Me.dgLabData.CurrentCell.ColumnNumber < 4 Then Exit Sub
        If Me.dgLabData.CurrentCell.ColumnNumber = 4 Then
            Me.HandleCellButtonClick("VIEW", CStr(Me.dgLabData.Item(Me.dgLabData.CurrentCell.RowNumber, 3)))
        Else
            Me.HandleCellButtonClick("REMOVE", CStr(Me.dgLabData.Item(Me.dgLabData.CurrentCell.RowNumber, 0)))
        End If

    End Sub

    Private Sub btnViewPNos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewPNos.Click

        If Me.GeneratorID.SelectedIndex >= 0 Then

            Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Dim newPForm As New frmListItems
            newPForm.genID = Me.GeneratorID.SelectedValue
            newPForm.whatOpt = 1
            newPForm.ShowDialog(Me)
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End If

    End Sub

    Private Sub btnApprovalNumbers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApprovalNumbers.Click

        If Me.GeneratorID.SelectedIndex >= 0 Then

            Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Dim newPForm As New frmListItems
            newPForm.genID = Me.GeneratorID.SelectedValue
            newPForm.whatOpt = 2
            newPForm.ShowDialog(Me)
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End If

    End Sub

    Function populateRates()

        Try

            If Me.OleDbConnection1.State = ConnectionState.Closed Then Me.OleDbConnection1.Open()
            Me.SelectProdRates.CommandText = "SELECT * FROM tblProductRates WHERE ProductID = " & Me.prodID & ""
            Me.DsProductRates1.Clear()
            Me.DAProdRates.Fill(Me.DsProductRates1)
            Me.dgLabData.Refresh()
            Me.rCount = Me.DsProductRates1.Tables(0).Rows.Count

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Ocurred")

        End Try

    End Function

    Private Sub dgRates_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgRates.CurrentCellChanged

        Dim strValue As String
        Try
            If Me.dgRates.CurrentCell.RowNumber >= rCount Then
                dgRates.Item(Me.dgRates.CurrentCell.RowNumber, 1) = Me.prodID
            End If
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub tbPages_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPages.SelectedIndexChanged

        If tbPages.SelectedIndex = 2 Then
            If Me.prodID = 0 Then
                Me.dgRates.ReadOnly = True
            Else
                Me.dgRates.ReadOnly = False
            End If
        End If

    End Sub

    Private Sub cmbDescs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDescs.SelectedIndexChanged

        If Me.cmbDescs.SelectedIndex < 0 Then Exit Sub
        Dim drRow As DataRow
        Try

            drRow = Me.DsDescriptions1.Tables(0).Rows.Find(Me.cmbDescs.SelectedValue)
            If Not drRow Is Nothing Then
                If IsDBNull(drRow.Item("ManifestDescription")) = False Then
                    Me.Manifest_Description.Text = drRow.Item("ManifestDescription")
                End If
                If IsDBNull(drRow.Item("ProductDescription")) = False Then
                    Me.ProductDescription.Text = drRow.Item("ProductDescription")
                End If
                If IsDBNull(drRow.Item("ProductDescription1")) = False Then
                    Me.ProductDescription1.Text = drRow.Item("ProductDescription1")
                End If
            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Information, "Error ocurred...")

        Finally

            drRow = Nothing

        End Try

    End Sub
    Function LoadDGValues(ByVal bStatus As Boolean)
        If Me.chkInactive.Visible = True Then
            If Me.chkInactive.Checked Then
                bStatus = False
            Else
                bStatus = True
            End If
        End If

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet, whereClause As String = ""
        Try
            Dim strSQL As String
            '-------------------------------------------------------------------
            'Haigriv Vyas
            'Date: 07/05/2005
            '-------------------------------------------------------------------
            'strSQL = "SELECT tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblProducts.ProductName, tblProducts.ProductID, tblGenerators.GeneratorID,tblGenerators.GeneratorName,tblProducts.ApprovalNo,tblProducts.Active as Status FROM (tblGenerators LEFT OUTER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) "
            If Me.addNewFlag = True Then
                strSQL = "SELECT tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblProducts.ProductName, tblProducts.ProductID, tblGenerators.GeneratorID, tblGenerators.JobSite as GeneratorName, tblProducts.ApprovalNo, tblProducts.Active as Status FROM (tblGenerators Left OUTER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) "
            Else
                strSQL = "SELECT tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblProducts.ProductName, tblProducts.ProductID, tblGenerators.GeneratorID, tblGenerators.JobSite as GeneratorName, tblProducts.ApprovalNo, tblProducts.Active as Status FROM (tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) "
            End If

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
            If Me.Fil_Product.Text <> "" Then
                If whereClause <> "" Then
                    whereClause = whereClause & " AND (tblProducts.ProductName Like '" & Replace(Me.Fil_Product.Text, "'", "''") & "%') "
                Else
                    whereClause = " WHERE (tblProducts.ProductName Like '" & Replace(Me.Fil_Product.Text, "'", "''") & "%') "
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
            If Me.Fil_Approval.Text <> "" Then
                If whereClause <> "" Then
                    whereClause = whereClause & " AND (tblProducts.ApprovalNo Like '" & Replace(Me.Fil_Approval.Text, "'", "''") & "%') "
                Else
                    whereClause = " WHERE (tblProducts.ApprovalNo Like '" & Replace(Me.Fil_Approval.Text, "'", "''") & "%') "
                End If
            End If

            If Me.addNewFlag = True Then
                If Len(whereClause) <> 0 Then strSQL = strSQL & whereClause Else strSQL = strSQL
                strSQL = strSQL & " ORDER BY tblGenerators.GeneratorName, tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity "
            Else
                If Len(whereClause) <> 0 Then strSQL = strSQL & whereClause & " and (tblProducts.Active = " & bStatus & " )" Else strSQL = strSQL & " WHERE (tblProducts.Active = " & bStatus & ")"
                strSQL = strSQL & " ORDER BY tblGenerators.GeneratorName, tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblProducts.ProductName "
            End If
            ds = DBHelper.GetDataSet(strSQL, "tblGenerators")
            Me.dgSearchProduct.DataSource = ds
            Me.dgSearchProduct.DataMember = "tblGenerators"
            Me.dgSearchProduct.Refresh()

            If Me.addNewFlag = True And Me.chkInactive.Checked = False Then
                Me.col_Product.Width = 0
                Me.Col_Approval.Width = 0
                Me.DataGridBoolColumn1.Width = 0
                Me.Fil_Product.Visible = False
                Me.Fil_Approval.Visible = False
            Else
                Me.col_Product.Width = 150
                Me.Col_Approval.Width = 110
                Me.DataGridBoolColumn1.Width = 40
                Me.Fil_Product.Visible = True
                Me.Fil_Approval.Visible = True
            End If
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
            Me.Fil_Address.Focus()
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

    Private Sub Fil_City_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Fil_City.KeyUp

        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Enter)) Then
            System.Windows.Forms.SendKeys.SendWait("{TAB}")
            Me.Fil_Product.Focus()
        ElseIf ((e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        Me.LoadDGValues(Not addNewFlag)

    End Sub

    Private Sub Fil_Product_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Fil_Product.KeyUp

        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Enter)) Then
            System.Windows.Forms.SendKeys.SendWait("{TAB}")
            Me.btnSelect.Focus()
        ElseIf ((e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        Me.LoadDGValues(Not addNewFlag)

    End Sub

    Private Sub Fill_Customer_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Fill_Customer.KeyUp, Fil_Approval.KeyUp

        ' Do nothing for certain keys such as navigation keys, Delete, Page Up/Down
        If ((e.KeyCode = Keys.Enter)) Then
            System.Windows.Forms.SendKeys.SendWait("{TAB}")
            Me.btnSelect.Focus()
        ElseIf ((e.KeyCode = Keys.Right) Or (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.PageUp) Or (e.KeyCode = Keys.PageDown) Or (e.KeyCode = Keys.Home) Or (e.KeyCode = Keys.ShiftKey) Or (e.KeyCode = Keys.End)) Then
            Return
        End If
        Me.LoadDGValues(Not addNewFlag)

    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click

        If Me.dgSearchProduct.CurrentRowIndex < 0 Then
            MsgBox("Product not selected. Please select a product.", MsgBoxStyle.Information, "Invalid selection")
            Me.dgSearchProduct.Focus()
            Exit Sub
        End If
        Me.clearAll()
        If IsDBNull(Me.dgSearchProduct.Item(Me.dgSearchProduct.CurrentRowIndex, 5)) = False AndAlso (Me.dgSearchProduct.Item(Me.dgSearchProduct.CurrentRowIndex, 5)) > 0 Then
            If addNewFlag = True Then
                Me.prodID = 0
            Else
                Me.prodID = Me.dgSearchProduct.Item(Me.dgSearchProduct.CurrentRowIndex, 5)
            End If
        Else
            Me.prodID = 0
        End If
        If IsDBNull(Me.dgSearchProduct.Item(Me.dgSearchProduct.CurrentRowIndex, 6)) = False AndAlso (Me.dgSearchProduct.Item(Me.dgSearchProduct.CurrentRowIndex, 6)) > 0 Then
            Me.genID = Me.dgSearchProduct.Item(Me.dgSearchProduct.CurrentRowIndex, 6)
        Else
            Me.genID = 0
        End If
        Me.populateProductInfo(1, genID, prodID)
        Me.grpSelectProduct.Visible = False
        Me.grBottom.Visible = True
        Me.grBottom.Top = 0
        Me.tbPages.Top = 24
        Me.Height = 700
        Me.ViewNewJobList.Visible = True
        If Me.genID > 0 Then
            Me.GeneratorID.SelectedValue = Me.genID
            Me.lblGen.Text = DBHelper.GetStringVar("SELECT GeneratorName FROM tblGenerators WHERE GeneratorID = " & Me.genID & "")
            Me.lblGAdd.Text = DBHelper.GetStringVar("SELECT JobSiteAddress1 FROM tblGenerators WHERE GeneratorID = " & Me.genID & "")
            Me.lblGCityStateZip.Text = DBHelper.GetStringVar("SELECT (JobSiteCity + ', ' + JobSiteState + ' ' + JobSiteZip) FROM tblGenerators WHERE GeneratorID = " & Me.genID & "")
            'Me.lblGen.Text = Me.GeneratorID.Text
        End If

    End Sub

    Private Sub ViewNewJobList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewNewJobList.Click
        Me.ViewNewJobList.Visible = False
        Me.grpSelectProduct.Visible = True
        Me.grBottom.Visible = False
        Me.grpSelectProduct.Top = 0
        Me.tbPages.Top = 216
    End Sub

    Private Sub GeneratorID_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles GeneratorID.SelectionChangeCommitted
        Dim gID As Integer
        If Me.GeneratorID.SelectedIndex > -1 Then
            gID = Me.GeneratorID.SelectedValue
        End If
        If gID > 0 Then
            Me.GeneratorID.SelectedValue = gID
            Me.lblGen.Text = DBHelper.GetStringVar("SELECT GeneratorName FROM tblGenerators WHERE GeneratorID = " & gID & "")
            Me.lblGAdd.Text = DBHelper.GetStringVar("SELECT JobSiteAddress1 FROM tblGenerators WHERE GeneratorID = " & gID & "")
            Me.lblGCityStateZip.Text = DBHelper.GetStringVar("SELECT (JobSiteCity + ', ' + JobSiteState + ' ' + JobSiteZip) FROM tblGenerators WHERE GeneratorID = " & gID & "")
            'Me.lblGen.Text = Me.GeneratorID.Text
        End If

    End Sub

    Private Sub Fil_Product_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fil_Product.TextChanged

    End Sub

    Private Sub btnAddNewProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewProduct.Click
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Me.clearAll()
        Me.genID = 0
        Me.prodID = 0
        Me.tbPages.SelectedTab = Me.tbPages.TabPages(0)
        Me.ProductN.Focus()
        Cursor.Current = System.Windows.Forms.Cursors.Default
        Me.populateRates()
        Me.lblGen.Text = ""
        Me.lblGCityStateZip.Text = ""
        Me.lblGAdd.Text = ""
        Me.addNewFlag = True
        Me.LoadDGValues(addNewFlag)
        Me.grpSelectProduct.Visible = True
        Me.grBottom.Visible = True
        Me.Height = 740
        Me.Width = 950
        Me.grBottom.Location = New System.Drawing.Point(0, 212)
        Me.ViewNewJobList.Visible = False
        Me.grpSelectProduct.Top = 0
        Me.grBottom.Top = 215
        Me.tbPages.Top = 5
        Me.chkInactive.Visible = True
        Me.chkInactive.Checked = False
        Me.ProductN.Focus()
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.addNewFlag = False
        Me.Fill_Customer.Text = ""
        Me.Fill_JobSite.Text = ""
        Me.Fil_City.Text = ""
        Me.Fil_Address.Text = ""
        Me.Fil_Approval.Text = ""
        Me.Fil_Product.Text = ""
        Me.LoadDGValues(Not addNewFlag)
        Me.grpSelectProduct.Visible = True
        Me.grBottom.Visible = False
        Me.chkInactive.Visible = False
    End Sub
    Private Sub chkInactive_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkInactive.CheckStateChanged
        Me.LoadDGValues(Not Me.chkInactive.Checked)
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

End Class
