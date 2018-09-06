Public Class frmPayable
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
    Friend WithEvents lblScheduled As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPrintCheck As System.Windows.Forms.Button
    Friend WithEvents grpP As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents VendorID As System.Windows.Forms.ComboBox
    Friend WithEvents Beaver_CheckNo As System.Windows.Forms.TextBox
    Friend WithEvents Beaver_CheckAmount As System.Windows.Forms.TextBox
    Friend WithEvents Beaver_CheckDate As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Beaver_CheckAmountDesc As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgPayableDetails As System.Windows.Forms.DataGrid
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DAPayableDetails As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DsPayable_Details1 As BeaverOil.DSPayable_Details
    Friend WithEvents dsPayableDetails As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents col_PayableID As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_VendorINo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_VendorIAmt As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DeletePayableDetails As System.Data.OleDb.OleDbCommand
    Friend WithEvents InsertPayableDetails As System.Data.OleDb.OleDbCommand
    Friend WithEvents SelectPayableDetails As System.Data.OleDb.OleDbCommand
    Friend WithEvents UpdatePayableDetails As System.Data.OleDb.OleDbCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblScheduled = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnPrintCheck = New System.Windows.Forms.Button
        Me.grpP = New System.Windows.Forms.GroupBox
        Me.dgPayableDetails = New System.Windows.Forms.DataGrid
        Me.DsPayable_Details1 = New BeaverOil.DSPayable_Details
        Me.dsPayableDetails = New System.Windows.Forms.DataGridTableStyle
        Me.col_PayableID = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_VendorINo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_VendorIAmt = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label24 = New System.Windows.Forms.Label
        Me.Beaver_CheckAmountDesc = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.VendorID = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Beaver_CheckDate = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Beaver_CheckAmount = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Beaver_CheckNo = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.DAPayableDetails = New System.Data.OleDb.OleDbDataAdapter
        Me.DeletePayableDetails = New System.Data.OleDb.OleDbCommand
        Me.InsertPayableDetails = New System.Data.OleDb.OleDbCommand
        Me.SelectPayableDetails = New System.Data.OleDb.OleDbCommand
        Me.UpdatePayableDetails = New System.Data.OleDb.OleDbCommand
        Me.grpP.SuspendLayout()
        CType(Me.dgPayableDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPayable_Details1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblScheduled
        '
        Me.lblScheduled.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScheduled.Location = New System.Drawing.Point(144, 8)
        Me.lblScheduled.Name = "lblScheduled"
        Me.lblScheduled.Size = New System.Drawing.Size(216, 16)
        Me.lblScheduled.TabIndex = 36
        Me.lblScheduled.Text = "Payable"
        Me.lblScheduled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(320, 456)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 24)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        '
        'btnPrintCheck
        '
        Me.btnPrintCheck.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPrintCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintCheck.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintCheck.Location = New System.Drawing.Point(128, 456)
        Me.btnPrintCheck.Name = "btnPrintCheck"
        Me.btnPrintCheck.Size = New System.Drawing.Size(152, 24)
        Me.btnPrintCheck.TabIndex = 2
        Me.btnPrintCheck.Text = "Save && &Print Check"
        '
        'grpP
        '
        Me.grpP.Controls.Add(Me.dgPayableDetails)
        Me.grpP.Controls.Add(Me.Label24)
        Me.grpP.Controls.Add(Me.Beaver_CheckAmountDesc)
        Me.grpP.Controls.Add(Me.Label22)
        Me.grpP.Controls.Add(Me.Label23)
        Me.grpP.Controls.Add(Me.Label1)
        Me.grpP.Controls.Add(Me.Label2)
        Me.grpP.Controls.Add(Me.VendorID)
        Me.grpP.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpP.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpP.Location = New System.Drawing.Point(32, 32)
        Me.grpP.Name = "grpP"
        Me.grpP.Size = New System.Drawing.Size(440, 304)
        Me.grpP.TabIndex = 0
        Me.grpP.TabStop = False
        Me.grpP.Text = "Vendor Info"
        '
        'dgPayableDetails
        '
        Me.dgPayableDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgPayableDetails.CaptionVisible = False
        Me.dgPayableDetails.DataMember = "tblPayables_Details"
        Me.dgPayableDetails.DataSource = Me.DsPayable_Details1
        Me.dgPayableDetails.FlatMode = True
        Me.dgPayableDetails.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgPayableDetails.Location = New System.Drawing.Point(16, 72)
        Me.dgPayableDetails.Name = "dgPayableDetails"
        Me.dgPayableDetails.Size = New System.Drawing.Size(408, 224)
        Me.dgPayableDetails.TabIndex = 3
        Me.dgPayableDetails.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.dsPayableDetails})
        '
        'DsPayable_Details1
        '
        Me.DsPayable_Details1.DataSetName = "DSPayable_Details"
        Me.DsPayable_Details1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'dsPayableDetails
        '
        Me.dsPayableDetails.AlternatingBackColor = System.Drawing.Color.Silver
        Me.dsPayableDetails.BackColor = System.Drawing.Color.White
        Me.dsPayableDetails.DataGrid = Me.dgPayableDetails
        Me.dsPayableDetails.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.col_PayableID, Me.col_VendorINo, Me.col_VendorIAmt})
        Me.dsPayableDetails.GridLineColor = System.Drawing.Color.Black
        Me.dsPayableDetails.HeaderBackColor = System.Drawing.SystemColors.Desktop
        Me.dsPayableDetails.HeaderForeColor = System.Drawing.Color.White
        Me.dsPayableDetails.MappingName = "tblPayables_Details"
        '
        'col_PayableID
        '
        Me.col_PayableID.Format = ""
        Me.col_PayableID.FormatInfo = Nothing
        Me.col_PayableID.HeaderText = "PayableID"
        Me.col_PayableID.MappingName = "PayableID"
        Me.col_PayableID.NullText = "1"
        Me.col_PayableID.Width = 0
        '
        'col_VendorINo
        '
        Me.col_VendorINo.Format = "G"
        Me.col_VendorINo.FormatInfo = Nothing
        Me.col_VendorINo.HeaderText = "Vendor Invoice #"
        Me.col_VendorINo.MappingName = "Vendor_InvoiceNo"
        Me.col_VendorINo.NullText = ""
        Me.col_VendorINo.Width = 150
        '
        'col_VendorIAmt
        '
        Me.col_VendorIAmt.Format = "C"
        Me.col_VendorIAmt.FormatInfo = Nothing
        Me.col_VendorIAmt.HeaderText = "Vendor Invoice Amount"
        Me.col_VendorIAmt.MappingName = "Vendor_InvoiceAmount"
        Me.col_VendorIAmt.NullText = "0"
        Me.col_VendorIAmt.Width = 200
        '
        'Label24
        '
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(104, 64)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(312, 1)
        Me.Label24.TabIndex = 57
        '
        'Beaver_CheckAmountDesc
        '
        Me.Beaver_CheckAmountDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Beaver_CheckAmountDesc.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Beaver_CheckAmountDesc.Location = New System.Drawing.Point(112, 48)
        Me.Beaver_CheckAmountDesc.MaxLength = 255
        Me.Beaver_CheckAmountDesc.Name = "Beaver_CheckAmountDesc"
        Me.Beaver_CheckAmountDesc.Size = New System.Drawing.Size(304, 14)
        Me.Beaver_CheckAmountDesc.TabIndex = 2
        Me.Beaver_CheckAmountDesc.Text = ""
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(24, 48)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 16)
        Me.Label22.TabIndex = 55
        Me.Label22.Text = "Description:"
        '
        'Label23
        '
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(8, 48)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(8, 8)
        Me.Label23.TabIndex = 56
        Me.Label23.Text = "*"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(8, 8)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "*"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Vendor:"
        '
        'VendorID
        '
        Me.VendorID.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VendorID.Location = New System.Drawing.Point(136, 24)
        Me.VendorID.Name = "VendorID"
        Me.VendorID.Size = New System.Drawing.Size(288, 21)
        Me.VendorID.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(160, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(168, 1)
        Me.Label12.TabIndex = 46
        '
        'Beaver_CheckDate
        '
        Me.Beaver_CheckDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Beaver_CheckDate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Beaver_CheckDate.Location = New System.Drawing.Point(168, 72)
        Me.Beaver_CheckDate.MaxLength = 8
        Me.Beaver_CheckDate.Name = "Beaver_CheckDate"
        Me.Beaver_CheckDate.Size = New System.Drawing.Size(160, 14)
        Me.Beaver_CheckDate.TabIndex = 3
        Me.Beaver_CheckDate.Text = ""
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 16)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Check Date:"
        '
        'Label14
        '
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(8, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(8, 8)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "*"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(160, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 1)
        Me.Label9.TabIndex = 42
        '
        'Beaver_CheckAmount
        '
        Me.Beaver_CheckAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Beaver_CheckAmount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Beaver_CheckAmount.Location = New System.Drawing.Point(168, 48)
        Me.Beaver_CheckAmount.MaxLength = 50
        Me.Beaver_CheckAmount.Name = "Beaver_CheckAmount"
        Me.Beaver_CheckAmount.Size = New System.Drawing.Size(160, 14)
        Me.Beaver_CheckAmount.TabIndex = 2
        Me.Beaver_CheckAmount.Text = ""
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 16)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Check Amount:"
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(8, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(8, 8)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "*"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(160, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 1)
        Me.Label6.TabIndex = 38
        '
        'Beaver_CheckNo
        '
        Me.Beaver_CheckNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Beaver_CheckNo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Beaver_CheckNo.Location = New System.Drawing.Point(168, 24)
        Me.Beaver_CheckNo.MaxLength = 50
        Me.Beaver_CheckNo.Name = "Beaver_CheckNo"
        Me.Beaver_CheckNo.Size = New System.Drawing.Size(160, 14)
        Me.Beaver_CheckNo.TabIndex = 1
        Me.Beaver_CheckNo.Text = ""
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 16)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Check No.:"
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(8, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(8, 8)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "*"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Beaver_CheckAmount)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Beaver_CheckNo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Beaver_CheckDate)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(32, 344)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 104)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payable Info"
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
        'DAPayableDetails
        '
        Me.DAPayableDetails.DeleteCommand = Me.DeletePayableDetails
        Me.DAPayableDetails.InsertCommand = Me.InsertPayableDetails
        Me.DAPayableDetails.SelectCommand = Me.SelectPayableDetails
        Me.DAPayableDetails.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblPayables_Details", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("PayableID", "PayableID"), New System.Data.Common.DataColumnMapping("Vendor_InvoiceAmount", "Vendor_InvoiceAmount"), New System.Data.Common.DataColumnMapping("Vendor_InvoiceNo", "Vendor_InvoiceNo")})})
        Me.DAPayableDetails.UpdateCommand = Me.UpdatePayableDetails
        '
        'DeletePayableDetails
        '
        Me.DeletePayableDetails.CommandText = "DELETE FROM tblPayables_Details WHERE (PayableID = ?) AND (Vendor_InvoiceNo = ?)"
        Me.DeletePayableDetails.Connection = Me.OleDbConnection1
        Me.DeletePayableDetails.Parameters.Add(New System.Data.OleDb.OleDbParameter("PayableID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PayableID", System.Data.DataRowVersion.Original, Nothing))
        Me.DeletePayableDetails.Parameters.Add(New System.Data.OleDb.OleDbParameter("Vendor_InvoiceNo", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vendor_InvoiceNo", System.Data.DataRowVersion.Original, Nothing))
        '
        'InsertPayableDetails
        '
        Me.InsertPayableDetails.CommandText = "INSERT INTO tblPayables_Details (PayableID, Vendor_InvoiceAmount, Vendor_InvoiceN" & _
        "o) VALUES (?, ?, ?)"
        Me.InsertPayableDetails.Connection = Me.OleDbConnection1
        Me.InsertPayableDetails.Parameters.Add(New System.Data.OleDb.OleDbParameter("PayableID", System.Data.OleDb.OleDbType.Integer, 0, "PayableID"))
        Me.InsertPayableDetails.Parameters.Add(New System.Data.OleDb.OleDbParameter("Vendor_InvoiceAmount", System.Data.OleDb.OleDbType.Currency, 0, "Vendor_InvoiceAmount"))
        Me.InsertPayableDetails.Parameters.Add(New System.Data.OleDb.OleDbParameter("Vendor_InvoiceNo", System.Data.OleDb.OleDbType.VarWChar, 50, "Vendor_InvoiceNo"))
        '
        'SelectPayableDetails
        '
        Me.SelectPayableDetails.CommandText = "SELECT PayableID, Vendor_InvoiceAmount, Vendor_InvoiceNo FROM tblPayables_Details" & _
        ""
        Me.SelectPayableDetails.Connection = Me.OleDbConnection1
        '
        'UpdatePayableDetails
        '
        Me.UpdatePayableDetails.CommandText = "UPDATE tblPayables_Details SET PayableID = ?, Vendor_InvoiceAmount = ?, Vendor_In" & _
        "voiceNo = ? WHERE (PayableID = ?) AND (Vendor_InvoiceNo = ?)"
        Me.UpdatePayableDetails.Connection = Me.OleDbConnection1
        Me.UpdatePayableDetails.Parameters.Add(New System.Data.OleDb.OleDbParameter("PayableID", System.Data.OleDb.OleDbType.Integer, 0, "PayableID"))
        Me.UpdatePayableDetails.Parameters.Add(New System.Data.OleDb.OleDbParameter("Vendor_InvoiceAmount", System.Data.OleDb.OleDbType.Currency, 0, "Vendor_InvoiceAmount"))
        Me.UpdatePayableDetails.Parameters.Add(New System.Data.OleDb.OleDbParameter("Vendor_InvoiceNo", System.Data.OleDb.OleDbType.VarWChar, 50, "Vendor_InvoiceNo"))
        Me.UpdatePayableDetails.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PayableID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PayableID", System.Data.DataRowVersion.Original, Nothing))
        Me.UpdatePayableDetails.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Vendor_InvoiceNo", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vendor_InvoiceNo", System.Data.DataRowVersion.Original, Nothing))
        '
        'frmPayable
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(504, 485)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpP)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPrintCheck)
        Me.Controls.Add(Me.lblScheduled)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmPayable"
        Me.Text = "frmPayable"
        Me.grpP.ResumeLayout(False)
        CType(Me.dgPayableDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPayable_Details1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnPrintCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintCheck.Click
        If Me.VendorID.SelectedIndex < 1 Then
            MsgBox("Please select a Vendor first.", MsgBoxStyle.Information, "Payable")
            Me.VendorID.Focus()
            Exit Sub
        End If
        If Me.Beaver_CheckAmountDesc.Text = "" Then
            MsgBox("Please enter a Payable Desription.", MsgBoxStyle.Information, "Payable")
            Me.Beaver_CheckAmountDesc.Focus()
            Exit Sub
        End If
        If Me.Beaver_CheckNo.Text = "" Then
            MsgBox("Please enter a Payable Check No.", MsgBoxStyle.Information, "Payable")
            Me.Beaver_CheckNo.Focus()
            Exit Sub
        End If
        If Me.Beaver_CheckDate.Text = "" Then
            MsgBox("Please enter a Payable Check Date.", MsgBoxStyle.Information, "Payable")
            Me.Beaver_CheckDate.Focus()
            Exit Sub
        ElseIf IsDate(Me.Beaver_CheckDate.Text) = False Then
            MsgBox("Please enter a valid Payable Check Date.", MsgBoxStyle.Information, "Payable")
            Me.Beaver_CheckDate.Focus()
            Exit Sub
        End If
        If Me.Beaver_CheckAmount.Text = "" Then
            MsgBox("Please enter a Payable Check Amount.", MsgBoxStyle.Information, "Payable")
            Me.Beaver_CheckAmount.Focus()
            Exit Sub
        ElseIf IsNumeric(Me.Beaver_CheckAmount.Text) = False Then
            MsgBox("Please enter a valid Payable Check Amount.", MsgBoxStyle.Information, "Payable")
            Me.Beaver_CheckAmount.Focus()
            Exit Sub
        End If
        If Me.DsPayable_Details1.Tables(0).Rows.Count = 0 Then
            MsgBox("Please enter Vendor Invoice Infor.", MsgBoxStyle.Information, "Payable")
            Me.dgPayableDetails.Focus()
            Exit Sub
        End If

        Dim ds As DataSet
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            Dim VendorID As Long = Me.VendorID.SelectedValue
            Dim Beaver_CheckNo As String = Me.Beaver_CheckNo.Text
            Dim Beaver_CheckDate As Date = CType(Me.Beaver_CheckDate.Text, System.DateTime).ToShortDateString
            Dim Beaver_CheckAmount As Double = CType(Me.Beaver_CheckAmount.Text, System.Double)
            Dim Beaver_Desc As String = Me.Beaver_CheckAmountDesc.Text

            Dim strSQL As String = "INSERT INTO tblPayables (VendorID, Beaver_CheckNo, Beaver_CheckAmount, Beaver_CheckDate, Beaver_Desc) " _
                                & " SELECT " & VendorID & ", '" & Replace(Beaver_CheckNo, "'", "''") & "', " & Beaver_CheckAmount & ", #" & Beaver_CheckDate & "#, '" & Replace(Beaver_Desc, "'", "''") & "' "

            If DBHelper.ExecuteQuery(strSQL) = False Then
                MsgBox("Error ocurred. Cannot print Checks.", MsgBoxStyle.Information, "Error Ocurred")
                Exit Sub
            Else
                Dim iPID As Integer = DBHelper.GetInteger("SELECT Max(PayableID) FROM tblPayables")
                Dim i As Integer = 0
                For i = 0 To Me.DsPayable_Details1.Tables(0).Rows.Count - 1
                    Me.DsPayable_Details1.Tables(0).Rows(i).Item("PayableID") = iPID
                Next
                Me.DAPayableDetails.Update(Me.DsPayable_Details1)
                Me.ClearAll()

                ds = DBHelper.GetDataSet("SELECT * FROM qry_PrintCheck WHERE PayableID = " & iPID, "qry_PrintCheck")
                Dim objRpt As New rpt_PayableCheck
                objRpt.SetDataSource(ds)
                DBHelper.Authenticate(objRpt)
                Dim frmR As New frmReport
                frmR.WindowState = FormWindowState.Maximized
                frmR.CrystalReportViewer1.ReportSource = objRpt
                frmR.CrystalReportViewer1.RefreshReport()
                frmR.Show()
            End If
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
        Finally
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub frmPayable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim ds As DataSet
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Me.OleDbConnection1.ConnectionString = DBHelper.ConnStr
        Try
            ds = DBHelper.GetDataSet("SELECT VendorID, VendorName FROM tblVendors ORDER BY VendorName", "tblVendors")
            Dim emptyRow As DataRow
            emptyRow = ds.Tables(0).NewRow()
            emptyRow.Item(0) = "0"
            emptyRow.Item(1) = ""
            ds.Tables(0).Rows.InsertAt(emptyRow, 0)
            Me.VendorID.DataSource = ds
            Me.VendorID.DisplayMember = "tblVendors.VendorName"
            Me.VendorID.ValueMember = "tblVendors.VendorID"
            Me.VendorID.Refresh()
            Me.DsPayable_Details1.Clear()
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")
        Finally
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Function ClearAll()
        Me.VendorID.SelectedIndex = 0
        Me.DsPayable_Details1.Clear()
        Me.dgPayableDetails.Refresh()
        Me.Beaver_CheckAmount.Text = ""
        Me.Beaver_CheckAmountDesc.Text = ""
        Me.Beaver_CheckDate.Text = ""
        Me.Beaver_CheckNo.Text = ""
    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

End Class
