Public Class frmManualJobTicket
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
    Friend WithEvents cmbTransporter As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelJT As System.Windows.Forms.Button
    Friend WithEvents btnSaveJT As System.Windows.Forms.Button
    Friend WithEvents cmbUDMer As System.Windows.Forms.ComboBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents txtUDeparted As System.Windows.Forms.TextBox
    Friend WithEvents txtUArrived As System.Windows.Forms.TextBox
    Friend WithEvents txtCArrived As System.Windows.Forms.TextBox
    Friend WithEvents txtREF As System.Windows.Forms.TextBox
    Friend WithEvents txtManifest As System.Windows.Forms.TextBox
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents cmbUAMer As System.Windows.Forms.ComboBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents cmbCDMer As System.Windows.Forms.ComboBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents UpdateJobDetails As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents cmbCAMer As System.Windows.Forms.ComboBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblReqField As System.Windows.Forms.Label
    Friend WithEvents SelectJobDetails As System.Data.OleDb.OleDbCommand
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents DAQuantity As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DeleteJobDetails As System.Data.OleDb.OleDbCommand
    Friend WithEvents InsertJobDetails As System.Data.OleDb.OleDbCommand
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPumpingFinish As System.Windows.Forms.TextBox
    Friend WithEvents txtPumpingStart As System.Windows.Forms.TextBox
    Friend WithEvents txtCDeparted As System.Windows.Forms.TextBox
    Friend WithEvents txtDriver As System.Windows.Forms.TextBox
    Friend WithEvents txtTruckNo As System.Windows.Forms.TextBox
    Friend WithEvents txtAttn As System.Windows.Forms.TextBox
    Friend WithEvents txtPO As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents dgQuantity As System.Windows.Forms.DataGrid
    Friend WithEvents DsJobTicket_Details1 As BeaverOil.DSJobTicket_Details
    Friend WithEvents ts_dgQuantity As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents col_JDid As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_JTid As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_Q As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_UOM As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cmbDisposal As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents col_Desc As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TicketNo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents grpSelectProduct As System.Windows.Forms.GroupBox
    Friend WithEvents Fill_Customer As System.Windows.Forms.TextBox
    Friend WithEvents Fil_Product As System.Windows.Forms.TextBox
    Friend WithEvents Fil_City As System.Windows.Forms.TextBox
    Friend WithEvents Fil_Address As System.Windows.Forms.TextBox
    Friend WithEvents Fill_JobSite As System.Windows.Forms.TextBox
    Friend WithEvents dgSearchProduct As System.Windows.Forms.DataGrid
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblBorder As System.Windows.Forms.Label
    Friend WithEvents DsNewJobSearch1 As BeaverOil.DSNewJobSearch
    Friend WithEvents dgTblStyle As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents col_GName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_GAdd As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_City As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_Product As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_GeneratorName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_ProductID As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_GenID As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblApprovalNo As System.Windows.Forms.Label
    Friend WithEvents col_ApprovalNo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Fil_Approval As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblGenNo As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBSW As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblVerifiedDate As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents cmbWasteType As System.Windows.Forms.ComboBox
    Friend WithEvents btnViewProductInfo As System.Windows.Forms.Button
    Friend WithEvents chkDrums As System.Windows.Forms.CheckBox
    Friend WithEvents txtGallons As System.Windows.Forms.TextBox
    Friend WithEvents lblGallons As System.Windows.Forms.Label
    Friend WithEvents chkInactiveProduct As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblCWTCode As System.Windows.Forms.Label
    Friend WithEvents lblGID As System.Windows.Forms.Label


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManualJobTicket))
        Me.cmbTransporter = New System.Windows.Forms.ComboBox
        Me.btnCancelJT = New System.Windows.Forms.Button
        Me.btnSaveJT = New System.Windows.Forms.Button
        Me.cmbUDMer = New System.Windows.Forms.ComboBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.txtUDeparted = New System.Windows.Forms.TextBox
        Me.txtUArrived = New System.Windows.Forms.TextBox
        Me.txtCArrived = New System.Windows.Forms.TextBox
        Me.txtREF = New System.Windows.Forms.TextBox
        Me.txtManifest = New System.Windows.Forms.TextBox
        Me.txtNotes = New System.Windows.Forms.TextBox
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.cmbUAMer = New System.Windows.Forms.ComboBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.cmbCDMer = New System.Windows.Forms.ComboBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.UpdateJobDetails = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.cmbCAMer = New System.Windows.Forms.ComboBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.lblReqField = New System.Windows.Forms.Label
        Me.SelectJobDetails = New System.Data.OleDb.OleDbCommand
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.DAQuantity = New System.Data.OleDb.OleDbDataAdapter
        Me.DeleteJobDetails = New System.Data.OleDb.OleDbCommand
        Me.InsertJobDetails = New System.Data.OleDb.OleDbCommand
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPumpingFinish = New System.Windows.Forms.TextBox
        Me.txtPumpingStart = New System.Windows.Forms.TextBox
        Me.txtCDeparted = New System.Windows.Forms.TextBox
        Me.txtDriver = New System.Windows.Forms.TextBox
        Me.txtTruckNo = New System.Windows.Forms.TextBox
        Me.txtAttn = New System.Windows.Forms.TextBox
        Me.txtPO = New System.Windows.Forms.TextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.col_Desc = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgQuantity = New System.Windows.Forms.DataGrid
        Me.DsJobTicket_Details1 = New BeaverOil.DSJobTicket_Details
        Me.ts_dgQuantity = New System.Windows.Forms.DataGridTableStyle
        Me.col_JDid = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_JTid = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_Q = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_UOM = New System.Windows.Forms.DataGridTextBoxColumn
        Me.cmbDisposal = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TicketNo = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.grpSelectProduct = New System.Windows.Forms.GroupBox
        Me.chkInactiveProduct = New System.Windows.Forms.CheckBox
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
        Me.btnSelect = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.lblBorder = New System.Windows.Forms.Label
        Me.Fil_Approval = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblApprovalNo = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblGenNo = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtBSW = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblVerifiedDate = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.cmbWasteType = New System.Windows.Forms.ComboBox
        Me.btnViewProductInfo = New System.Windows.Forms.Button
        Me.chkDrums = New System.Windows.Forms.CheckBox
        Me.txtGallons = New System.Windows.Forms.TextBox
        Me.lblGallons = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblGID = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblCWTCode = New System.Windows.Forms.Label
        CType(Me.dgQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsJobTicket_Details1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSelectProduct.SuspendLayout()
        CType(Me.dgSearchProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNewJobSearch1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbTransporter
        '
        Me.cmbTransporter.Location = New System.Drawing.Point(72, 292)
        Me.cmbTransporter.Name = "cmbTransporter"
        Me.cmbTransporter.Size = New System.Drawing.Size(456, 21)
        Me.cmbTransporter.TabIndex = 7
        '
        'btnCancelJT
        '
        Me.btnCancelJT.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCancelJT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelJT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelJT.Location = New System.Drawing.Point(376, 700)
        Me.btnCancelJT.Name = "btnCancelJT"
        Me.btnCancelJT.Size = New System.Drawing.Size(112, 24)
        Me.btnCancelJT.TabIndex = 26
        Me.btnCancelJT.Text = "Cancel"
        Me.btnCancelJT.UseVisualStyleBackColor = False
        '
        'btnSaveJT
        '
        Me.btnSaveJT.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSaveJT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveJT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveJT.Location = New System.Drawing.Point(250, 700)
        Me.btnSaveJT.Name = "btnSaveJT"
        Me.btnSaveJT.Size = New System.Drawing.Size(112, 24)
        Me.btnSaveJT.TabIndex = 25
        Me.btnSaveJT.Text = "Save && Close"
        Me.btnSaveJT.UseVisualStyleBackColor = False
        '
        'cmbUDMer
        '
        Me.cmbUDMer.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmbUDMer.Location = New System.Drawing.Point(476, 660)
        Me.cmbUDMer.Name = "cmbUDMer"
        Me.cmbUDMer.Size = New System.Drawing.Size(48, 21)
        Me.cmbUDMer.TabIndex = 24
        '
        'Label43
        '
        Me.Label43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label43.Location = New System.Drawing.Point(380, 676)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(88, 1)
        Me.Label43.TabIndex = 148
        '
        'txtUDeparted
        '
        Me.txtUDeparted.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUDeparted.Location = New System.Drawing.Point(380, 660)
        Me.txtUDeparted.MaxLength = 20
        Me.txtUDeparted.Name = "txtUDeparted"
        Me.txtUDeparted.Size = New System.Drawing.Size(88, 14)
        Me.txtUDeparted.TabIndex = 23
        '
        'txtUArrived
        '
        Me.txtUArrived.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUArrived.Location = New System.Drawing.Point(132, 660)
        Me.txtUArrived.MaxLength = 20
        Me.txtUArrived.Name = "txtUArrived"
        Me.txtUArrived.Size = New System.Drawing.Size(88, 14)
        Me.txtUArrived.TabIndex = 21
        '
        'txtCArrived
        '
        Me.txtCArrived.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCArrived.Location = New System.Drawing.Point(132, 612)
        Me.txtCArrived.MaxLength = 20
        Me.txtCArrived.Name = "txtCArrived"
        Me.txtCArrived.Size = New System.Drawing.Size(88, 14)
        Me.txtCArrived.TabIndex = 15
        '
        'txtREF
        '
        Me.txtREF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtREF.Location = New System.Drawing.Point(332, 572)
        Me.txtREF.MaxLength = 50
        Me.txtREF.Name = "txtREF"
        Me.txtREF.Size = New System.Drawing.Size(192, 14)
        Me.txtREF.TabIndex = 14
        '
        'txtManifest
        '
        Me.txtManifest.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtManifest.Location = New System.Drawing.Point(100, 572)
        Me.txtManifest.MaxLength = 50
        Me.txtManifest.Name = "txtManifest"
        Me.txtManifest.Size = New System.Drawing.Size(152, 14)
        Me.txtManifest.TabIndex = 6
        '
        'txtNotes
        '
        Me.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNotes.Location = New System.Drawing.Point(20, 500)
        Me.txtNotes.MaxLength = 500
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(504, 64)
        Me.txtNotes.TabIndex = 12
        '
        'txtDate
        '
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDate.Location = New System.Drawing.Point(60, 244)
        Me.txtDate.MaxLength = 8
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(84, 14)
        Me.txtDate.TabIndex = 1
        '
        'Label44
        '
        Me.Label44.Location = New System.Drawing.Point(300, 660)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(80, 16)
        Me.Label44.TabIndex = 146
        Me.Label44.Text = "Departed"
        '
        'cmbUAMer
        '
        Me.cmbUAMer.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmbUAMer.Location = New System.Drawing.Point(228, 660)
        Me.cmbUAMer.Name = "cmbUAMer"
        Me.cmbUAMer.Size = New System.Drawing.Size(48, 21)
        Me.cmbUAMer.TabIndex = 22
        '
        'Label41
        '
        Me.Label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label41.Location = New System.Drawing.Point(132, 676)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(88, 1)
        Me.Label41.TabIndex = 144
        '
        'Label42
        '
        Me.Label42.Location = New System.Drawing.Point(12, 660)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(120, 16)
        Me.Label42.TabIndex = 142
        Me.Label42.Text = "Unloading: Arrived"
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(300, 636)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(56, 16)
        Me.Label40.TabIndex = 139
        Me.Label40.Text = "Finish"
        '
        'cmbCDMer
        '
        Me.cmbCDMer.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmbCDMer.Location = New System.Drawing.Point(476, 612)
        Me.cmbCDMer.Name = "cmbCDMer"
        Me.cmbCDMer.Size = New System.Drawing.Size(48, 21)
        Me.cmbCDMer.TabIndex = 18
        '
        'Label35
        '
        Me.Label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label35.Location = New System.Drawing.Point(380, 628)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(88, 1)
        Me.Label35.TabIndex = 134
        '
        'UpdateJobDetails
        '
        Me.UpdateJobDetails.CommandText = "UPDATE tblJobTickets_Details SET JobTicketID = ?, Quantity = ?, Description = ?, " & _
            "UOM = ? WHERE (JobDetailID = ?)"
        Me.UpdateJobDetails.Connection = Me.OleDbConnection1
        Me.UpdateJobDetails.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("JobTicketID", System.Data.OleDb.OleDbType.[Integer], 0, "JobTicketID"), New System.Data.OleDb.OleDbParameter("Quantity", System.Data.OleDb.OleDbType.[Double], 0, "Quantity"), New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 255, "Description"), New System.Data.OleDb.OleDbParameter("UOM", System.Data.OleDb.OleDbType.VarWChar, 50, "UOM"), New System.Data.OleDb.OleDbParameter("Original_JobDetailID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "JobDetailID", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = resources.GetString("OleDbConnection1.ConnectionString")
        '
        'cmbCAMer
        '
        Me.cmbCAMer.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmbCAMer.Location = New System.Drawing.Point(228, 612)
        Me.cmbCAMer.Name = "cmbCAMer"
        Me.cmbCAMer.Size = New System.Drawing.Size(48, 21)
        Me.cmbCAMer.TabIndex = 16
        '
        'Label34
        '
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label34.Location = New System.Drawing.Point(132, 628)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(88, 1)
        Me.Label34.TabIndex = 130
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(12, 612)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(120, 16)
        Me.Label33.TabIndex = 128
        Me.Label33.Text = "Customer: Arrived"
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(12, 596)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(80, 16)
        Me.Label32.TabIndex = 127
        Me.Label32.Text = "TIME"
        '
        'Label28
        '
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label28.Location = New System.Drawing.Point(324, 588)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(200, 1)
        Me.Label28.TabIndex = 126
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(268, 572)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(48, 16)
        Me.Label29.TabIndex = 124
        Me.Label29.Text = "REF. #"
        '
        'Label27
        '
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label27.Location = New System.Drawing.Point(12, 564)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(512, 1)
        Me.Label27.TabIndex = 120
        '
        'Label26
        '
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label26.Location = New System.Drawing.Point(12, 364)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(1, 112)
        Me.Label26.TabIndex = 11
        '
        'Label25
        '
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label25.Location = New System.Drawing.Point(524, 364)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(1, 112)
        Me.Label25.TabIndex = 118
        '
        'Label24
        '
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.Location = New System.Drawing.Point(12, 364)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(512, 1)
        Me.Label24.TabIndex = 117
        '
        'Label23
        '
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Location = New System.Drawing.Point(12, 476)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(512, 1)
        Me.Label23.TabIndex = 116
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(12, 484)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(120, 16)
        Me.Label22.TabIndex = 114
        Me.Label22.Text = "DRIVER REMARKS"
        '
        'lblReqField
        '
        Me.lblReqField.Location = New System.Drawing.Point(694, 526)
        Me.lblReqField.Name = "lblReqField"
        Me.lblReqField.Size = New System.Drawing.Size(32, 16)
        Me.lblReqField.TabIndex = 80
        Me.lblReqField.Visible = False
        '
        'SelectJobDetails
        '
        Me.SelectJobDetails.CommandText = "SELECT JobDetailID, JobTicketID, Quantity, Description, UOM FROM tblJobTickets_De" & _
            "tails"
        Me.SelectJobDetails.Connection = Me.OleDbConnection1
        '
        'Label30
        '
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label30.Location = New System.Drawing.Point(92, 588)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(168, 1)
        Me.Label30.TabIndex = 123
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(12, 572)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(80, 16)
        Me.Label31.TabIndex = 121
        Me.Label31.Text = "MANIFEST #"
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
        Me.DeleteJobDetails.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("JobDetailID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "JobDetailID", System.Data.DataRowVersion.Original, Nothing)})
        '
        'InsertJobDetails
        '
        Me.InsertJobDetails.CommandText = "INSERT INTO tblJobTickets_Details (JobTicketID, Quantity, Description, UOM) VALUE" & _
            "S (?, ?, ?, ?)"
        Me.InsertJobDetails.Connection = Me.OleDbConnection1
        Me.InsertJobDetails.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("JobTicketID", System.Data.OleDb.OleDbType.[Integer], 0, "JobTicketID"), New System.Data.OleDb.OleDbParameter("Quantity", System.Data.OleDb.OleDbType.[Double], 0, "Quantity"), New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 255, "Description"), New System.Data.OleDb.OleDbParameter("UOM", System.Data.OleDb.OleDbType.VarWChar, 50, "UOM")})
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "DATE"
        '
        'txtPumpingFinish
        '
        Me.txtPumpingFinish.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPumpingFinish.Location = New System.Drawing.Point(356, 636)
        Me.txtPumpingFinish.MaxLength = 20
        Me.txtPumpingFinish.Name = "txtPumpingFinish"
        Me.txtPumpingFinish.Size = New System.Drawing.Size(168, 14)
        Me.txtPumpingFinish.TabIndex = 20
        '
        'txtPumpingStart
        '
        Me.txtPumpingStart.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPumpingStart.Location = New System.Drawing.Point(124, 636)
        Me.txtPumpingStart.MaxLength = 20
        Me.txtPumpingStart.Name = "txtPumpingStart"
        Me.txtPumpingStart.Size = New System.Drawing.Size(144, 14)
        Me.txtPumpingStart.TabIndex = 19
        '
        'txtCDeparted
        '
        Me.txtCDeparted.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCDeparted.Location = New System.Drawing.Point(380, 612)
        Me.txtCDeparted.MaxLength = 20
        Me.txtCDeparted.Name = "txtCDeparted"
        Me.txtCDeparted.Size = New System.Drawing.Size(88, 14)
        Me.txtCDeparted.TabIndex = 17
        '
        'txtDriver
        '
        Me.txtDriver.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDriver.Location = New System.Drawing.Point(296, 318)
        Me.txtDriver.MaxLength = 50
        Me.txtDriver.Name = "txtDriver"
        Me.txtDriver.Size = New System.Drawing.Size(232, 14)
        Me.txtDriver.TabIndex = 95
        '
        'txtTruckNo
        '
        Me.txtTruckNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTruckNo.Location = New System.Drawing.Point(80, 318)
        Me.txtTruckNo.MaxLength = 50
        Me.txtTruckNo.Name = "txtTruckNo"
        Me.txtTruckNo.Size = New System.Drawing.Size(152, 14)
        Me.txtTruckNo.TabIndex = 96
        '
        'txtAttn
        '
        Me.txtAttn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAttn.Location = New System.Drawing.Point(296, 268)
        Me.txtAttn.MaxLength = 50
        Me.txtAttn.Name = "txtAttn"
        Me.txtAttn.Size = New System.Drawing.Size(232, 14)
        Me.txtAttn.TabIndex = 97
        '
        'txtPO
        '
        Me.txtPO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPO.Location = New System.Drawing.Point(64, 268)
        Me.txtPO.MaxLength = 50
        Me.txtPO.Name = "txtPO"
        Me.txtPO.Size = New System.Drawing.Size(168, 14)
        Me.txtPO.TabIndex = 3
        '
        'Label39
        '
        Me.Label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label39.Location = New System.Drawing.Point(348, 652)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(176, 1)
        Me.Label39.TabIndex = 141
        '
        'Label37
        '
        Me.Label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label37.Location = New System.Drawing.Point(116, 652)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(160, 1)
        Me.Label37.TabIndex = 138
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(12, 636)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(96, 16)
        Me.Label38.TabIndex = 136
        Me.Label38.Text = "Pumping: Start"
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(300, 612)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(80, 16)
        Me.Label36.TabIndex = 132
        Me.Label36.Text = "Departed"
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
        'dgQuantity
        '
        Me.dgQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgQuantity.CaptionVisible = False
        Me.dgQuantity.DataMember = "tblJobTickets_Details"
        Me.dgQuantity.DataSource = Me.DsJobTicket_Details1
        Me.dgQuantity.FlatMode = True
        Me.dgQuantity.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgQuantity.Location = New System.Drawing.Point(12, 364)
        Me.dgQuantity.Name = "dgQuantity"
        Me.dgQuantity.Size = New System.Drawing.Size(512, 112)
        Me.dgQuantity.TabIndex = 15
        Me.dgQuantity.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.ts_dgQuantity})
        '
        'DsJobTicket_Details1
        '
        Me.DsJobTicket_Details1.DataSetName = "DSJobTicket_Details"
        Me.DsJobTicket_Details1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsJobTicket_Details1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'cmbDisposal
        '
        Me.cmbDisposal.Location = New System.Drawing.Point(128, 340)
        Me.cmbDisposal.Name = "cmbDisposal"
        Me.cmbDisposal.Size = New System.Drawing.Size(400, 21)
        Me.cmbDisposal.TabIndex = 8
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(16, 340)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(104, 16)
        Me.Label21.TabIndex = 111
        Me.Label21.Text = "RECEIVING SITE"
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Location = New System.Drawing.Point(296, 334)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(232, 1)
        Me.Label17.TabIndex = 110
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(240, 318)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 16)
        Me.Label18.TabIndex = 108
        Me.Label18.Text = "DRIVER"
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Location = New System.Drawing.Point(72, 334)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(160, 1)
        Me.Label19.TabIndex = 107
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(16, 318)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 16)
        Me.Label20.TabIndex = 105
        Me.Label20.Text = "TRUCK #"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(16, 292)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 16)
        Me.Label15.TabIndex = 104
        Me.Label15.Text = "HAULER"
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(296, 284)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(232, 1)
        Me.Label13.TabIndex = 103
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(16, 268)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 16)
        Me.Label12.TabIndex = 96
        Me.Label12.Text = "P.O."
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(240, 268)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 16)
        Me.Label14.TabIndex = 101
        Me.Label14.Text = "Attn"
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(56, 284)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(176, 1)
        Me.Label11.TabIndex = 98
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(60, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 1)
        Me.Label2.TabIndex = 83
        '
        'TicketNo
        '
        Me.TicketNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TicketNo.Location = New System.Drawing.Point(428, 244)
        Me.TicketNo.MaxLength = 8
        Me.TicketNo.Name = "TicketNo"
        Me.TicketNo.Size = New System.Drawing.Size(104, 14)
        Me.TicketNo.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(428, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 1)
        Me.Label6.TabIndex = 158
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(364, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 159
        Me.Label7.Text = "TICKET #"
        '
        'grpSelectProduct
        '
        Me.grpSelectProduct.Controls.Add(Me.chkInactiveProduct)
        Me.grpSelectProduct.Controls.Add(Me.Fill_Customer)
        Me.grpSelectProduct.Controls.Add(Me.Fil_Product)
        Me.grpSelectProduct.Controls.Add(Me.Fil_City)
        Me.grpSelectProduct.Controls.Add(Me.Fil_Address)
        Me.grpSelectProduct.Controls.Add(Me.Fill_JobSite)
        Me.grpSelectProduct.Controls.Add(Me.dgSearchProduct)
        Me.grpSelectProduct.Controls.Add(Me.btnSelect)
        Me.grpSelectProduct.Controls.Add(Me.btnClear)
        Me.grpSelectProduct.Controls.Add(Me.lblBorder)
        Me.grpSelectProduct.Controls.Add(Me.Fil_Approval)
        Me.grpSelectProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpSelectProduct.Location = New System.Drawing.Point(4, 4)
        Me.grpSelectProduct.Name = "grpSelectProduct"
        Me.grpSelectProduct.Size = New System.Drawing.Size(740, 236)
        Me.grpSelectProduct.TabIndex = 160
        Me.grpSelectProduct.TabStop = False
        Me.grpSelectProduct.Text = "Select a Product"
        '
        'chkInactiveProduct
        '
        Me.chkInactiveProduct.Location = New System.Drawing.Point(520, 212)
        Me.chkInactiveProduct.Name = "chkInactiveProduct"
        Me.chkInactiveProduct.Size = New System.Drawing.Size(168, 20)
        Me.chkInactiveProduct.TabIndex = 14
        Me.chkInactiveProduct.Text = "Include Inactive Product"
        '
        'Fill_Customer
        '
        Me.Fill_Customer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fill_Customer.Location = New System.Drawing.Point(172, 12)
        Me.Fill_Customer.Name = "Fill_Customer"
        Me.Fill_Customer.Size = New System.Drawing.Size(124, 21)
        Me.Fill_Customer.TabIndex = 2
        '
        'Fil_Product
        '
        Me.Fil_Product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fil_Product.Location = New System.Drawing.Point(496, 12)
        Me.Fil_Product.Name = "Fil_Product"
        Me.Fil_Product.Size = New System.Drawing.Size(120, 21)
        Me.Fil_Product.TabIndex = 5
        '
        'Fil_City
        '
        Me.Fil_City.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fil_City.Location = New System.Drawing.Point(408, 12)
        Me.Fil_City.Name = "Fil_City"
        Me.Fil_City.Size = New System.Drawing.Size(88, 21)
        Me.Fil_City.TabIndex = 4
        '
        'Fil_Address
        '
        Me.Fil_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fil_Address.Location = New System.Drawing.Point(296, 12)
        Me.Fil_Address.Name = "Fil_Address"
        Me.Fil_Address.Size = New System.Drawing.Size(112, 21)
        Me.Fil_Address.TabIndex = 3
        '
        'Fill_JobSite
        '
        Me.Fill_JobSite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fill_JobSite.Location = New System.Drawing.Point(24, 12)
        Me.Fill_JobSite.Name = "Fill_JobSite"
        Me.Fill_JobSite.Size = New System.Drawing.Size(148, 21)
        Me.Fill_JobSite.TabIndex = 1
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
        Me.dgSearchProduct.Location = New System.Drawing.Point(5, 36)
        Me.dgSearchProduct.Name = "dgSearchProduct"
        Me.dgSearchProduct.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dgSearchProduct.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.dgSearchProduct.RowHeaderWidth = 20
        Me.dgSearchProduct.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgSearchProduct.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgSearchProduct.Size = New System.Drawing.Size(723, 168)
        Me.dgSearchProduct.TabIndex = 7
        Me.dgSearchProduct.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.dgTblStyle})
        '
        'DsNewJobSearch1
        '
        Me.DsNewJobSearch1.DataSetName = "DSNewJobSearch"
        Me.DsNewJobSearch1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsNewJobSearch1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgTblStyle
        '
        Me.dgTblStyle.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.dgTblStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgTblStyle.DataGrid = Me.dgSearchProduct
        Me.dgTblStyle.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dgTblStyle.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.col_GName, Me.col_GeneratorName, Me.col_GAdd, Me.col_City, Me.col_Product, Me.col_ProductID, Me.col_GenID, Me.col_ApprovalNo})
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
        Me.col_GName.MappingName = "JobSite"
        Me.col_GName.NullText = ""
        Me.col_GName.ReadOnly = True
        Me.col_GName.Width = 150
        '
        'col_GeneratorName
        '
        Me.col_GeneratorName.Format = ""
        Me.col_GeneratorName.FormatInfo = Nothing
        Me.col_GeneratorName.HeaderText = "Customer"
        Me.col_GeneratorName.MappingName = "GeneratorName"
        Me.col_GeneratorName.NullText = ""
        Me.col_GeneratorName.Width = 120
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
        Me.col_City.Width = 85
        '
        'col_Product
        '
        Me.col_Product.Format = ""
        Me.col_Product.FormatInfo = Nothing
        Me.col_Product.HeaderText = "Product"
        Me.col_Product.MappingName = "ProductName"
        Me.col_Product.NullText = ""
        Me.col_Product.ReadOnly = True
        Me.col_Product.Width = 120
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
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(276, 209)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(101, 24)
        Me.btnSelect.TabIndex = 8
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(377, 209)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(101, 24)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblBorder
        '
        Me.lblBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBorder.Location = New System.Drawing.Point(4, 36)
        Me.lblBorder.Name = "lblBorder"
        Me.lblBorder.Size = New System.Drawing.Size(728, 172)
        Me.lblBorder.TabIndex = 13
        '
        'Fil_Approval
        '
        Me.Fil_Approval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fil_Approval.Location = New System.Drawing.Point(616, 12)
        Me.Fil_Approval.Name = "Fil_Approval"
        Me.Fil_Approval.Size = New System.Drawing.Size(104, 21)
        Me.Fil_Approval.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label16.Location = New System.Drawing.Point(148, 244)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 16)
        Me.Label16.TabIndex = 162
        Me.Label16.Text = "Approval No.:-"
        '
        'lblApprovalNo
        '
        Me.lblApprovalNo.Font = New System.Drawing.Font("Verdana", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApprovalNo.ForeColor = System.Drawing.Color.Red
        Me.lblApprovalNo.Location = New System.Drawing.Point(248, 244)
        Me.lblApprovalNo.Name = "lblApprovalNo"
        Me.lblApprovalNo.Size = New System.Drawing.Size(112, 16)
        Me.lblApprovalNo.TabIndex = 161
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(574, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 164
        Me.Label3.Text = "Generator #:-"
        '
        'lblGenNo
        '
        Me.lblGenNo.Font = New System.Drawing.Font("Verdana", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenNo.Location = New System.Drawing.Point(564, 262)
        Me.lblGenNo.Name = "lblGenNo"
        Me.lblGenNo.Size = New System.Drawing.Size(112, 16)
        Me.lblGenNo.TabIndex = 163
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(540, 376)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "BS&&W :-"
        '
        'txtBSW
        '
        Me.txtBSW.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBSW.Location = New System.Drawing.Point(592, 376)
        Me.txtBSW.MaxLength = 50
        Me.txtBSW.Name = "txtBSW"
        Me.txtBSW.Size = New System.Drawing.Size(72, 14)
        Me.txtBSW.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(590, 390)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 1)
        Me.Label5.TabIndex = 167
        '
        'lblVerifiedDate
        '
        Me.lblVerifiedDate.Font = New System.Drawing.Font("Verdana", 8.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerifiedDate.ForeColor = System.Drawing.Color.Red
        Me.lblVerifiedDate.Location = New System.Drawing.Point(536, 302)
        Me.lblVerifiedDate.Name = "lblVerifiedDate"
        Me.lblVerifiedDate.Size = New System.Drawing.Size(202, 16)
        Me.lblVerifiedDate.TabIndex = 169
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Location = New System.Drawing.Point(570, 284)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 13)
        Me.Label8.TabIndex = 168
        Me.Label8.Text = "Verified Date :-"
        '
        'Label53
        '
        Me.Label53.Location = New System.Drawing.Point(554, 326)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(154, 16)
        Me.Label53.TabIndex = 180
        Me.Label53.Text = "ACTIVITY REPORT TYPE :"
        '
        'cmbWasteType
        '
        Me.cmbWasteType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWasteType.Location = New System.Drawing.Point(540, 344)
        Me.cmbWasteType.Name = "cmbWasteType"
        Me.cmbWasteType.Size = New System.Drawing.Size(178, 21)
        Me.cmbWasteType.TabIndex = 9
        '
        'btnViewProductInfo
        '
        Me.btnViewProductInfo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnViewProductInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewProductInfo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewProductInfo.Location = New System.Drawing.Point(12, 700)
        Me.btnViewProductInfo.Name = "btnViewProductInfo"
        Me.btnViewProductInfo.Size = New System.Drawing.Size(224, 24)
        Me.btnViewProductInfo.TabIndex = 181
        Me.btnViewProductInfo.Text = "View Full Product Info"
        Me.btnViewProductInfo.UseVisualStyleBackColor = False
        '
        'chkDrums
        '
        Me.chkDrums.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDrums.ForeColor = System.Drawing.Color.Navy
        Me.chkDrums.Location = New System.Drawing.Point(586, 410)
        Me.chkDrums.Name = "chkDrums"
        Me.chkDrums.Size = New System.Drawing.Size(74, 18)
        Me.chkDrums.TabIndex = 185
        Me.chkDrums.Text = "DRUMS?"
        '
        'txtGallons
        '
        Me.txtGallons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGallons.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGallons.Location = New System.Drawing.Point(616, 438)
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(94, 21)
        Me.txtGallons.TabIndex = 5
        '
        'lblGallons
        '
        Me.lblGallons.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGallons.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblGallons.Location = New System.Drawing.Point(540, 442)
        Me.lblGallons.Name = "lblGallons"
        Me.lblGallons.Size = New System.Drawing.Size(74, 14)
        Me.lblGallons.TabIndex = 184
        Me.lblGallons.Text = "GALLONS :-"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Location = New System.Drawing.Point(594, 474)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 16)
        Me.Label9.TabIndex = 184
        Me.Label9.Text = "FED #"
        '
        'lblGID
        '
        Me.lblGID.Font = New System.Drawing.Font("Verdana", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGID.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblGID.Location = New System.Drawing.Point(568, 492)
        Me.lblGID.Name = "lblGID"
        Me.lblGID.Size = New System.Drawing.Size(112, 16)
        Me.lblGID.TabIndex = 183
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Location = New System.Drawing.Point(594, 527)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 16)
        Me.Label10.TabIndex = 186
        Me.Label10.Text = "CWT #"
        '
        'lblCWTCode
        '
        Me.lblCWTCode.Font = New System.Drawing.Font("Verdana", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCWTCode.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCWTCode.Location = New System.Drawing.Point(564, 547)
        Me.lblCWTCode.Name = "lblCWTCode"
        Me.lblCWTCode.Size = New System.Drawing.Size(112, 16)
        Me.lblCWTCode.TabIndex = 187
        '
        'frmManualJobTicket
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(752, 726)
        Me.Controls.Add(Me.lblCWTCode)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblGID)
        Me.Controls.Add(Me.btnViewProductInfo)
        Me.Controls.Add(Me.cmbWasteType)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.lblVerifiedDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBSW)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblGenNo)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblApprovalNo)
        Me.Controls.Add(Me.grpSelectProduct)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TicketNo)
        Me.Controls.Add(Me.txtUDeparted)
        Me.Controls.Add(Me.txtUArrived)
        Me.Controls.Add(Me.txtCArrived)
        Me.Controls.Add(Me.txtREF)
        Me.Controls.Add(Me.txtManifest)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtPumpingFinish)
        Me.Controls.Add(Me.txtPumpingStart)
        Me.Controls.Add(Me.txtCDeparted)
        Me.Controls.Add(Me.txtDriver)
        Me.Controls.Add(Me.txtTruckNo)
        Me.Controls.Add(Me.txtAttn)
        Me.Controls.Add(Me.txtPO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSaveJT)
        Me.Controls.Add(Me.cmbUDMer)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.cmbUAMer)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.cmbCDMer)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.cmbCAMer)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.lblReqField)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.dgQuantity)
        Me.Controls.Add(Me.cmbDisposal)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbTransporter)
        Me.Controls.Add(Me.btnCancelJT)
        Me.Controls.Add(Me.chkDrums)
        Me.Controls.Add(Me.txtGallons)
        Me.Controls.Add(Me.lblGallons)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmManualJobTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manual Job-Ticket"
        CType(Me.dgQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsJobTicket_Details1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSelectProduct.ResumeLayout(False)
        Me.grpSelectProduct.PerformLayout()
        CType(Me.dgSearchProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNewJobSearch1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim jtID As Integer = 0
    Dim ProdId As Integer
    Dim GenID As Integer
    Dim VFlag As Boolean = False

    Private Sub frmManualJobTicket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.OleDbConnection1.ConnectionString = DBHelper.ConnStr
        Me.Bind_ComboBoxes()
        Me.populateDatagrid()
        Me.LoadDGValues()

    End Sub

    Function populateDatagrid()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim aConn As OleDb.OleDbConnection

        Try
            'Connect to Database and fill Dataset
            aConn = DBHelper.Connect
            Me.DsJobTicket_Details1.Clear()
            Me.SelectJobDetails.CommandText = Me.SelectJobDetails.CommandText & " WHERE JobTicketID = " & Me.jtID
            Me.DAQuantity.Fill(Me.DsJobTicket_Details1, "tblJobTickets_Details")
            Me.DsJobTicket_Details1.Tables(0).Columns("JobTicketID").DefaultValue = jtID
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

    Function Bind_ComboBoxes()

        Dim dsT As DataSet, dsD As DataSet, dsC As DataSet
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            'dsC = DBHelper.GetDataSet("SELECT DISTINCT GeneratorName + ':' +  FCity as GeneratorName FROM tblGenerators ORDER BY GeneratorName", "tblGenerators")
            'Dim emptyRow As DataRow
            'emptyRow = dsC.Tables(0).NewRow()
            'emptyRow.Item(0) = ""
            'dsC.Tables(0).Rows.InsertAt(emptyRow, 0)
            'Me.cmbClient.DataSource = dsC
            'Me.cmbClient.DisplayMember = "tblGenerators.GeneratorName"
            'Me.cmbClient.ValueMember = "tblGenerators.GeneratorName"
            'Me.cmbClient.SelectedIndex = 0

            dsT = DBHelper.GetDataSet("SELECT TransporterID, TransporterName + ' : ' + T_ILNumber as TransporterName FROM tblTransporters ORDER BY TransporterName", "tblTransporters")
            Me.cmbTransporter.DataSource = dsT
            Me.cmbTransporter.DisplayMember = "tblTransporters.TransporterName"
            Me.cmbTransporter.ValueMember = "tblTransporters.TransporterID"

            dsD = DBHelper.GetDataSet("SELECT DisposalFacilityID, DisposalFacilityName + ':' + FCity as DisposalFacilityName FROM tblDisposalFacilities ORDER BY DisposalFacilityName", "tblDisposal")
            Me.cmbDisposal.DataSource = dsD
            Me.cmbDisposal.DisplayMember = "tblDisposal.DisposalFacilityName"
            Me.cmbDisposal.ValueMember = "tblDisposal.DisposalFacilityID"

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
            dsC = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Function

    'Function Bind_Sites()

    '    Dim dsS As DataSet
    '    Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
    '    Try
    '        dsS = DBHelper.GetDataSet("SELECT (JobSite + ' - ' + JobSiteAddress1 + ' - ' + JobSiteCity + ', ' + JobSiteState) as Site FROM tblGenerators WHERE GeneratorName = '" & Replace(Me.cmbClient.Text, "'", "''") & "' ORDER BY (JobSite + ' - ' + JobSiteAddress1 + ' - ' + JobSiteCity + ', ' + JobSiteState)", "tblGenerators")
    '        Dim emptyRow As DataRow
    '        emptyRow = dsS.Tables(0).NewRow()
    '        emptyRow.Item(0) = ""
    '        dsS.Tables(0).Rows.InsertAt(emptyRow, 0)
    '        Me.cmbSite.DataSource = dsS
    '        Me.cmbSite.DisplayMember = "tblGenerators.Site"
    '        Me.cmbSite.ValueMember = "tblGenerators.Site"
    '        Me.cmbSite.SelectedIndex = 0

    '    Catch ex As SystemException
    '        MsgBox("One or more data tables are missing.", MsgBoxStyle.Information, "Error ocurred")
    '    Finally
    '        dsS = Nothing
    '        Cursor.Current = System.Windows.Forms.Cursors.Default
    '    End Try

    'End Function

    'Function Bind_Products()

    '    Dim dsP As DataSet
    '    Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
    '    Try
    '        dsP = DBHelper.GetDataSet("SELECT ProductID, ProductName FROM tblProducts INNER JOIN tblGenerators ON tblProducts.GeneratorID = tblGenerators.GeneratorID WHERE GeneratorName = '" & Replace(Me.cmbClient.Text, "'", "''") & "' AND (JobSite + ' - ' + JobSiteAddress1 + ' - ' + JobSiteCity + ', ' + JobSiteState) = '" & Replace(Me.cmbSite.Text, "'", "''") & "' ORDER BY tblProducts.ProductName", "tblProducts")
    '        Dim emptyRow As DataRow
    '        emptyRow = dsP.Tables(0).NewRow()
    '        emptyRow.Item(0) = "0"
    '        emptyRow.Item(1) = ""
    '        dsP.Tables(0).Rows.InsertAt(emptyRow, 0)
    '        Me.cmbProduct.DataSource = dsP
    '        Me.cmbProduct.DisplayMember = "tblProducts.ProductName"
    '        Me.cmbProduct.ValueMember = "tblProducts.ProductID"
    '        Me.cmbProduct.SelectedIndex = 0

    '    Catch ex As SystemException
    '        MsgBox("One or more data tables are missing.", MsgBoxStyle.Information, "Error ocurred")
    '    Finally
    '        dsP = Nothing
    '        Cursor.Current = System.Windows.Forms.Cursors.Default
    '    End Try

    'End Function

    Private Sub btnCancelJT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelJT.Click

        Me.Close()

    End Sub

    Private Sub btnSaveJT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveJT.Click

        Dim strSQL As String
        Dim strWasteType As String = ""
        strWasteType = Me.cmbWasteType.Text

        'Error Checking
        If Me.VFlag = False Then
            MsgBox("Please Select Generator & Product from Datagrid")
            Exit Sub
        End If
        If IsDate(Me.txtDate.Text) = False Then
            MsgBox("Invalid date. Date must be a date format.", MsgBoxStyle.Information, "Invalid date")
            Me.txtDate.Focus()
            Exit Sub
        End If
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
        'Default values if not entered
        If Me.txtDate.Text = "" Then
            Me.txtDate.Text = Today.ToShortDateString
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

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            Dim nextJTID As Long = DBHelper.GetInteger("SELECT Max(JobTicketNo) FROM tblJobTickets")
            nextJTID = IIf(nextJTID = 0, 1000, nextJTID + 1)
            strSQL = "INSERT INTO tblJobTickets (JobTicketDate, JobTicketNo, ProductID, JobPO, Attn, TransporterID, DisposalFacilityID, TruckNo, DriverName, ManifestNo, " _
                    & "RefNo, DriverRemarks, C_Arrived, C_Departed, C_Arrived_M, C_Departed_M, P_Start, P_Finish, U_Arrived, U_Departed, JobTicketSubmitted, ScheduleDate, TicketNo,BSW,WasteType,Drums,Gallons) " _
                    & " SELECT #" & Me.txtDate.Text & "#, " & nextJTID & ", " & ProdId & ", '" & Replace(Me.txtPO.Text, "'", "''") & "', '" & Replace(Me.txtAttn.Text, "'", "''") & "', " _
                    & "" & Me.cmbTransporter.SelectedValue & "," & Me.cmbDisposal.SelectedValue & ", '" & Replace(Me.txtTruckNo.Text, "'", "''") & "','" & Replace(Me.txtDriver.Text, "'", "''") & "'," _
                    & "'" & Replace(Me.txtManifest.Text, "'", "''") & "', '" & Replace(Me.txtREF.Text, "'", "''") & "', '" & Replace(Me.txtNotes.Text, "'", "''") & "'," _
                    & "'" & Replace(Me.txtCArrived.Text, "'", "''") & "','" & Replace(Me.txtCDeparted.Text, "'", "''") & "','" & Me.cmbUAMer.SelectedText & "','" & Me.cmbCDMer.SelectedText & "'," _
                    & "'" & Replace(Me.txtPumpingStart.Text, "'", "''") & "','" & Replace(Me.txtPumpingFinish.Text, "'", "''") & "','" & Replace(Me.txtUArrived.Text, "'", "''") & "'," _
                    & "'" & Replace(Me.txtUDeparted.Text, "'", "''") & "', True, #" & Me.txtDate.Text & "#, " & Me.TicketNo.Text & "," & bsw & ",'" & strWasteType & "'," & IsDrums & "," & Gallons & ";"
            If DBHelper.ExecuteQuery(strSQL) = False Then
                MsgBox("An error ocurred while performing this operation. Your information has not been saved.", MsgBoxStyle.Information, "Error ocurred")
            Else
                Me.jtID = DBHelper.GetInteger("SELECT Max(JobTicketID) FROM tblJobTickets")
                'Update the Datagrid
                Dim i As Integer
                For i = 0 To Me.DsJobTicket_Details1.Tables(0).Rows.Count - 1
                    Me.DsJobTicket_Details1.Tables(0).Rows(i).Item("JobTicketID") = Me.jtID
                Next
                If Me.DsJobTicket_Details1.HasChanges = True Then
                    Me.DAQuantity.Update(Me.DsJobTicket_Details1)
                End If
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error ocurred")

        Finally
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try
        'Save and Close
        Me.Close()
        DirectCast(Owner, frmInvoicing).populateDatagrid(False)

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

    Private Sub Fill_Customer_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Fill_Customer.KeyUp, Fil_Approval.KeyUp, Fil_Approval.KeyUp
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
        Me.ProdId = Me.dgSearchProduct.Item(Me.dgSearchProduct.CurrentRowIndex, 5)
        Me.GenID = Me.dgSearchProduct.Item(Me.dgSearchProduct.CurrentRowIndex, 6)
        Me.VFlag = True
        Dim strSQL As String
        Dim ds As DataSet = New DataSet
        strSQL = "SELECT tblProducts.*, ContactName, ContactPhone, GeneratorName, JobSite, JobSiteAddress1 as Address, (JobSiteCity & ', ' & JobSiteState & ' ' & JobSiteZip) as CityStateZip,tblGenerators.GNo as GNo,tblGenerators.G_USEPAID FROM tblProducts INNER JOIN tblGenerators ON tblProducts.GeneratorID = tblGenerators.GeneratorID WHERE ProductID = " & Me.ProdId
        Me.ProdId = Me.dgSearchProduct.Item(Me.dgSearchProduct.CurrentRowIndex, 5)
        ds = DBHelper.GetDataSet(strSQL, "tblProduct")
        If Not ds Is Nothing AndAlso ds.Tables(0).Rows.Count > 0 Then
            Me.lblApprovalNo.Text = IIf(IsDBNull(ds.Tables(0).Rows(0).Item("ApprovalNo")), "", CStr(ds.Tables(0).Rows(0).Item("ApprovalNo")))
            Me.lblGenNo.Text = IIf(IsDBNull(ds.Tables(0).Rows(0).Item("GNo")), "", CStr(ds.Tables(0).Rows(0).Item("GNo")))
            If IsDBNull(ds.Tables(0).Rows(0).Item("CWTCode")) = False Then Me.lblCWTCode.Text = ds.Tables(0).Rows(0).Item("CWTCode").ToString Else Me.lblCWTCode.Text = ""
            If IsDBNull(ds.Tables(0).Rows(0).Item("PermitNo")) = False Then Me.lblVerifiedDate.Text = ds.Tables(0).Rows(0).Item("PermitNo").ToString Else Me.lblVerifiedDate.Text = ""
            Me.cmbWasteType.Text = IIf(IsDBNull(ds.Tables(0).Rows(0).Item("WasteType")), " ", ds.Tables(0).Rows(0).Item("WasteType"))
            If IsDBNull(ds.Tables(0).Rows(0).Item("G_USEPAID")) = False Then Me.lblGID.Text = ds.Tables(0).Rows(0).Item("G_USEPAID").ToString Else Me.lblGID.Text = ""
        End If
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

    Function LoadDGValues()

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim ds As DataSet, whereClause As String = ""
        Try
            Dim strSQL As String
            '-------------------------------------------------------------------
            'Haigriv Vyas
            'Date: 07/05/2005
            '-------------------------------------------------------------------
            strSQL = "SELECT tblGenerators.GeneratorName as JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblProducts.ProductName, tblProducts.ProductID, tblGenerators.GeneratorID, tblGenerators.JobSite as GeneratorName, tblProducts.ApprovalNo FROM (tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) "
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
            If Me.chkInactiveProduct.Checked = False Then
                If whereClause.Trim <> "" Then
                    strSQL = strSQL & whereClause & " AND (tblProducts.Active = True)"
                Else
                    strSQL = strSQL & " WHERE (tblProducts.Active = True)"
                End If
            Else
                If whereClause <> "" Then strSQL = strSQL & whereClause
            End If
            strSQL = strSQL & " ORDER BY tblGenerators.GeneratorName, tblGenerators.JobSite, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblProducts.ProductName "
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

    Private Sub btnViewProductInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewProductInfo.Click
        If Me.ProdId > 0 And Me.GenID > 0 Then
            Dim frmP As New frmProduct
            frmP.ViewProductInfo(Me.ProdId, Me.GenID)
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
