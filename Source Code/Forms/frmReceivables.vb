Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmReceivables
    Inherits System.Windows.Forms.Form
    Dim rowC As Integer = 0

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents dgReceivables As System.Windows.Forms.DataGrid
    Friend WithEvents ts_dgReceivables As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DsReceivables1 As BeaverOil.DSReceivables
    Friend WithEvents dgtxt_InvoiceID As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgtxt_InvoiceDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgtxt_JobTicketNo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgtxt_Generator As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgtxt_BillingAmount As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgtxt_CheckNo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgtxt_CheckDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgtxt_Received As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblReceivable As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dgtxt_CheckAmount As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DAReceivables As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents SelectReceivables As System.Data.OleDb.OleDbCommand
    Friend WithEvents UpdateReceivables As System.Data.OleDb.OleDbCommand
    Friend WithEvents btnOver50Days As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDeposits As System.Windows.Forms.Button
    Friend WithEvents TODate As System.Windows.Forms.DateTimePicker
    Friend WithEvents FROMDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnInvoice As System.Windows.Forms.Button
    Friend WithEvents btnJobTickets As System.Windows.Forms.Button
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmReceivables))
        Me.lblScheduled = New System.Windows.Forms.Label
        Me.dgReceivables = New System.Windows.Forms.DataGrid
        Me.DsReceivables1 = New BeaverOil.DSReceivables
        Me.ts_dgReceivables = New System.Windows.Forms.DataGridTableStyle
        Me.dgtxt_InvoiceID = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtxt_InvoiceDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtxt_JobTicketNo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtxt_Generator = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtxt_BillingAmount = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtxt_CheckNo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtxt_CheckDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtxt_CheckAmount = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtxt_Received = New System.Windows.Forms.DataGridBoolColumn
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblReceivable = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.DAReceivables = New System.Data.OleDb.OleDbDataAdapter
        Me.SelectReceivables = New System.Data.OleDb.OleDbCommand
        Me.UpdateReceivables = New System.Data.OleDb.OleDbCommand
        Me.btnOver50Days = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnDeposits = New System.Windows.Forms.Button
        Me.TODate = New System.Windows.Forms.DateTimePicker
        Me.FROMDate = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnJobTickets = New System.Windows.Forms.Button
        Me.btnInvoice = New System.Windows.Forms.Button
        CType(Me.dgReceivables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsReceivables1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblScheduled
        '
        Me.lblScheduled.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScheduled.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.lblScheduled.Location = New System.Drawing.Point(274, 8)
        Me.lblScheduled.Name = "lblScheduled"
        Me.lblScheduled.Size = New System.Drawing.Size(216, 16)
        Me.lblScheduled.TabIndex = 35
        Me.lblScheduled.Text = "Receivables"
        Me.lblScheduled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgReceivables
        '
        Me.dgReceivables.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgReceivables.CaptionVisible = False
        Me.dgReceivables.DataMember = "tblReceivables"
        Me.dgReceivables.DataSource = Me.DsReceivables1
        Me.dgReceivables.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgReceivables.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgReceivables.Location = New System.Drawing.Point(8, 56)
        Me.dgReceivables.Name = "dgReceivables"
        Me.dgReceivables.RowHeadersVisible = False
        Me.dgReceivables.Size = New System.Drawing.Size(854, 492)
        Me.dgReceivables.TabIndex = 36
        Me.dgReceivables.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.ts_dgReceivables})
        '
        'DsReceivables1
        '
        Me.DsReceivables1.DataSetName = "DSReceivables"
        Me.DsReceivables1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'ts_dgReceivables
        '
        Me.ts_dgReceivables.AlternatingBackColor = System.Drawing.Color.Silver
        Me.ts_dgReceivables.DataGrid = Me.dgReceivables
        Me.ts_dgReceivables.ForeColor = System.Drawing.Color.Black
        Me.ts_dgReceivables.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dgtxt_InvoiceID, Me.dgtxt_InvoiceDate, Me.dgtxt_JobTicketNo, Me.dgtxt_Generator, Me.dgtxt_BillingAmount, Me.dgtxt_CheckNo, Me.dgtxt_CheckDate, Me.dgtxt_CheckAmount, Me.dgtxt_Received, Me.DataGridTextBoxColumn1, Me.DataGridBoolColumn1})
        Me.ts_dgReceivables.GridLineColor = System.Drawing.Color.Black
        Me.ts_dgReceivables.HeaderBackColor = System.Drawing.Color.SteelBlue
        Me.ts_dgReceivables.HeaderFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_dgReceivables.HeaderForeColor = System.Drawing.Color.White
        Me.ts_dgReceivables.MappingName = "tblReceivables"
        Me.ts_dgReceivables.SelectionBackColor = System.Drawing.Color.Blue
        Me.ts_dgReceivables.SelectionForeColor = System.Drawing.Color.White
        '
        'dgtxt_InvoiceID
        '
        Me.dgtxt_InvoiceID.Format = ""
        Me.dgtxt_InvoiceID.FormatInfo = Nothing
        Me.dgtxt_InvoiceID.HeaderText = "Invoice ID"
        Me.dgtxt_InvoiceID.MappingName = "InvoiceID"
        Me.dgtxt_InvoiceID.NullText = ""
        Me.dgtxt_InvoiceID.ReadOnly = True
        Me.dgtxt_InvoiceID.Width = 0
        '
        'dgtxt_InvoiceDate
        '
        Me.dgtxt_InvoiceDate.Format = "d"
        Me.dgtxt_InvoiceDate.FormatInfo = Nothing
        Me.dgtxt_InvoiceDate.HeaderText = "Invoice Date"
        Me.dgtxt_InvoiceDate.MappingName = "InvoiceDate"
        Me.dgtxt_InvoiceDate.NullText = ""
        Me.dgtxt_InvoiceDate.ReadOnly = True
        Me.dgtxt_InvoiceDate.Width = 90
        '
        'dgtxt_JobTicketNo
        '
        Me.dgtxt_JobTicketNo.Format = ""
        Me.dgtxt_JobTicketNo.FormatInfo = Nothing
        Me.dgtxt_JobTicketNo.HeaderText = "Invoice #"
        Me.dgtxt_JobTicketNo.MappingName = "InvoiceNo"
        Me.dgtxt_JobTicketNo.NullText = ""
        Me.dgtxt_JobTicketNo.ReadOnly = True
        Me.dgtxt_JobTicketNo.Width = 85
        '
        'dgtxt_Generator
        '
        Me.dgtxt_Generator.Format = ""
        Me.dgtxt_Generator.FormatInfo = Nothing
        Me.dgtxt_Generator.HeaderText = "Client Name"
        Me.dgtxt_Generator.MappingName = "GeneratorName"
        Me.dgtxt_Generator.NullText = ""
        Me.dgtxt_Generator.ReadOnly = True
        Me.dgtxt_Generator.Width = 180
        '
        'dgtxt_BillingAmount
        '
        Me.dgtxt_BillingAmount.Format = "c"
        Me.dgtxt_BillingAmount.FormatInfo = Nothing
        Me.dgtxt_BillingAmount.HeaderText = "Billing $"
        Me.dgtxt_BillingAmount.MappingName = "InvoiceAmount"
        Me.dgtxt_BillingAmount.NullText = ""
        Me.dgtxt_BillingAmount.ReadOnly = True
        Me.dgtxt_BillingAmount.Width = 101
        '
        'dgtxt_CheckNo
        '
        Me.dgtxt_CheckNo.Format = ""
        Me.dgtxt_CheckNo.FormatInfo = Nothing
        Me.dgtxt_CheckNo.HeaderText = "Check #"
        Me.dgtxt_CheckNo.MappingName = "CheckNo"
        Me.dgtxt_CheckNo.NullText = ""
        Me.dgtxt_CheckNo.Width = 101
        '
        'dgtxt_CheckDate
        '
        Me.dgtxt_CheckDate.Format = "d"
        Me.dgtxt_CheckDate.FormatInfo = Nothing
        Me.dgtxt_CheckDate.HeaderText = "Date"
        Me.dgtxt_CheckDate.MappingName = "CheckDate"
        Me.dgtxt_CheckDate.NullText = ""
        Me.dgtxt_CheckDate.Width = 80
        '
        'dgtxt_CheckAmount
        '
        Me.dgtxt_CheckAmount.Format = "c"
        Me.dgtxt_CheckAmount.FormatInfo = Nothing
        Me.dgtxt_CheckAmount.HeaderText = "Amount"
        Me.dgtxt_CheckAmount.MappingName = "CheckAmount"
        Me.dgtxt_CheckAmount.NullText = ""
        Me.dgtxt_CheckAmount.Width = 90
        '
        'dgtxt_Received
        '
        Me.dgtxt_Received.AllowNull = False
        Me.dgtxt_Received.FalseValue = False
        Me.dgtxt_Received.HeaderText = "Close"
        Me.dgtxt_Received.MappingName = "PaymentReceived"
        Me.dgtxt_Received.NullText = ""
        Me.dgtxt_Received.NullValue = "False"
        Me.dgtxt_Received.TrueValue = True
        Me.dgtxt_Received.Width = 45
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = "JobTicketNo"
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.FalseValue = False
        Me.DataGridBoolColumn1.HeaderText = "PP?"
        Me.DataGridBoolColumn1.MappingName = "PartialPayment"
        Me.DataGridBoolColumn1.NullText = ""
        Me.DataGridBoolColumn1.NullValue = CType(resources.GetObject("DataGridBoolColumn1.NullValue"), Object)
        Me.DataGridBoolColumn1.ReadOnly = True
        Me.DataGridBoolColumn1.TrueValue = True
        Me.DataGridBoolColumn1.Width = 30
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 548)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(855, 1)
        Me.Label1.TabIndex = 37
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(855, 1)
        Me.Label2.TabIndex = 38
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1, 492)
        Me.Label3.TabIndex = 39
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(862, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1, 492)
        Me.Label4.TabIndex = 40
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(8, 6)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(176, 24)
        Me.btnPrint.TabIndex = 86
        Me.btnPrint.Text = "&Overdue Receivables"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(432, 10)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 24)
        Me.btnCancel.TabIndex = 85
        Me.btnCancel.Text = "&Cancel"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(228, 10)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(114, 24)
        Me.btnSave.TabIndex = 84
        Me.btnSave.Text = "&Save && Close"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(855, 1)
        Me.Label5.TabIndex = 87
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(8, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1, 24)
        Me.Label6.TabIndex = 88
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(862, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1, 24)
        Me.Label7.TabIndex = 89
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(498, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1, 24)
        Me.Label8.TabIndex = 90
        '
        'lblReceivable
        '
        Me.lblReceivable.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceivable.Location = New System.Drawing.Point(556, 38)
        Me.lblReceivable.Name = "lblReceivable"
        Me.lblReceivable.Size = New System.Drawing.Size(216, 16)
        Me.lblReceivable.TabIndex = 91
        Me.lblReceivable.Text = "Receivable Info."
        Me.lblReceivable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(152, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(216, 16)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Invoice Info."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        '
        'DAReceivables
        '
        Me.DAReceivables.SelectCommand = Me.SelectReceivables
        Me.DAReceivables.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblReceivables", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("InvoiceID", "InvoiceID"), New System.Data.Common.DataColumnMapping("InvoiceDate", "InvoiceDate"), New System.Data.Common.DataColumnMapping("GeneratorName", "GeneratorName"), New System.Data.Common.DataColumnMapping("JobTicketNo", "JobTicketNo"), New System.Data.Common.DataColumnMapping("InvoiceAmount", "InvoiceAmount"), New System.Data.Common.DataColumnMapping("CheckNo", "CheckNo"), New System.Data.Common.DataColumnMapping("CheckDate", "CheckDate"), New System.Data.Common.DataColumnMapping("CheckAmount", "CheckAmount"), New System.Data.Common.DataColumnMapping("PaymentReceived", "PaymentReceived"), New System.Data.Common.DataColumnMapping("JobSiteAddress1", "JobSiteAddress1"), New System.Data.Common.DataColumnMapping("JobSiteCity", "JobSiteCity"), New System.Data.Common.DataColumnMapping("InvoiceNo", "InvoiceNo")})})
        Me.DAReceivables.UpdateCommand = Me.UpdateReceivables
        '
        'SelectReceivables
        '
        Me.SelectReceivables.CommandText = "SELECT tblInvoicing.InvoiceID, tblInvoicing.InvoiceDate, IIf(Len(Trim(tblGenerato" & _
        "rs.JobSite)) <> 0, tblGenerators.JobSite, tblGenerators.GeneratorName) AS Genera" & _
        "torName, tblJobTickets.JobTicketNo, tblInvoicing.InvoiceAmount, tblInvoicing.Che" & _
        "ckNo, tblInvoicing.CheckDate, tblInvoicing.CheckAmount, tblInvoicing.PaymentRece" & _
        "ived, tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblInvoicing.Inv" & _
        "oiceNo, tblGenerators.JobSite, tblJobTickets.JobTicketID, tblInvoicing.PartialPa" & _
        "yment FROM (((tblJobTickets INNER JOIN tblProducts ON tblJobTickets.ProductID = " & _
        "tblProducts.ProductID) INNER JOIN tblGenerators ON tblProducts.GeneratorID = tbl" & _
        "Generators.GeneratorID) INNER JOIN tblInvoicing ON tblJobTickets.JobTicketID = t" & _
        "blInvoicing.JobTicketID) WHERE (tblInvoicing.PaymentReceived = false) AND (tblJo" & _
        "bTickets.IsCancelled = False)"
        Me.SelectReceivables.Connection = Me.OleDbConnection1
        '
        'UpdateReceivables
        '
        Me.UpdateReceivables.CommandText = "UPDATE tblInvoicing SET CheckNo = ?, CheckDate = ?, CheckAmount = ?, PaymentRecei" & _
        "ved = ? WHERE (InvoiceID = ?)"
        Me.UpdateReceivables.Connection = Me.OleDbConnection1
        Me.UpdateReceivables.Parameters.Add(New System.Data.OleDb.OleDbParameter("CheckNo", System.Data.OleDb.OleDbType.VarWChar, 50, "CheckNo"))
        Me.UpdateReceivables.Parameters.Add(New System.Data.OleDb.OleDbParameter("CheckDate", System.Data.OleDb.OleDbType.DBDate, 0, "CheckDate"))
        Me.UpdateReceivables.Parameters.Add(New System.Data.OleDb.OleDbParameter("CheckAmount", System.Data.OleDb.OleDbType.Double, 0, "CheckAmount"))
        Me.UpdateReceivables.Parameters.Add(New System.Data.OleDb.OleDbParameter("PaymentReceived", System.Data.OleDb.OleDbType.Boolean, 2, "PaymentReceived"))
        Me.UpdateReceivables.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InvoiceID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InvoiceID", System.Data.DataRowVersion.Original, Nothing))
        '
        'btnOver50Days
        '
        Me.btnOver50Days.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnOver50Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOver50Days.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOver50Days.Location = New System.Drawing.Point(688, 6)
        Me.btnOver50Days.Name = "btnOver50Days"
        Me.btnOver50Days.Size = New System.Drawing.Size(176, 24)
        Me.btnOver50Days.TabIndex = 93
        Me.btnOver50Days.Text = "&Over 50 Days Receivables"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnDeposits)
        Me.GroupBox1.Controls.Add(Me.TODate)
        Me.GroupBox1.Controls.Add(Me.FROMDate)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 1.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 552)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 60)
        Me.GroupBox1.TabIndex = 94
        Me.GroupBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 16)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "FROM:"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(182, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 16)
        Me.Label10.TabIndex = 87
        Me.Label10.Text = "TO:"
        '
        'btnDeposits
        '
        Me.btnDeposits.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDeposits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeposits.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeposits.Location = New System.Drawing.Point(108, 30)
        Me.btnDeposits.Name = "btnDeposits"
        Me.btnDeposits.Size = New System.Drawing.Size(140, 24)
        Me.btnDeposits.TabIndex = 86
        Me.btnDeposits.Text = "&Deposits Details"
        '
        'TODate
        '
        Me.TODate.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TODate.Location = New System.Drawing.Point(212, 8)
        Me.TODate.Name = "TODate"
        Me.TODate.Size = New System.Drawing.Size(120, 20)
        Me.TODate.TabIndex = 1
        '
        'FROMDate
        '
        Me.FROMDate.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FROMDate.Location = New System.Drawing.Point(54, 8)
        Me.FROMDate.Name = "FROMDate"
        Me.FROMDate.Size = New System.Drawing.Size(120, 20)
        Me.FROMDate.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.btndelete)
        Me.GroupBox2.Controls.Add(Me.btnJobTickets)
        Me.GroupBox2.Controls.Add(Me.btnInvoice)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 1.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(346, 552)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(518, 60)
        Me.GroupBox2.TabIndex = 95
        Me.GroupBox2.TabStop = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(344, 10)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(86, 24)
        Me.btndelete.TabIndex = 96
        Me.btndelete.Text = "&Delete"
        '
        'btnJobTickets
        '
        Me.btnJobTickets.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnJobTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJobTickets.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJobTickets.Location = New System.Drawing.Point(6, 10)
        Me.btnJobTickets.Name = "btnJobTickets"
        Me.btnJobTickets.Size = New System.Drawing.Size(112, 24)
        Me.btnJobTickets.TabIndex = 97
        Me.btnJobTickets.Text = "Edit JobTicket"
        '
        'btnInvoice
        '
        Me.btnInvoice.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInvoice.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvoice.Location = New System.Drawing.Point(120, 10)
        Me.btnInvoice.Name = "btnInvoice"
        Me.btnInvoice.Size = New System.Drawing.Size(106, 24)
        Me.btnInvoice.TabIndex = 96
        Me.btnInvoice.Text = "Edit Invoice"
        '
        'frmReceivables
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(870, 636)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnOver50Days)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblReceivable)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgReceivables)
        Me.Controls.Add(Me.lblScheduled)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmReceivables"
        Me.Text = "Receivables"
        CType(Me.dgReceivables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsReceivables1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Public newForm1 As frmInvoice
    Public newForm As frmJobTicket
    Dim SortColumnName As String = ""
    Private lastEditedRow As Integer = -1
    Private lastEditedCol As Integer = -1
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Me.OleDbConnection1.ConnectionString = DBHelper.ConnStr
        Try
            If Me.DsReceivables1.Tables(0).Rows.Count > 0 Then
                If Me.DsReceivables1.HasChanges = True Then
                    Me.DAReceivables.Update(Me.DsReceivables1)
                End If
            End If
            Me.populateDatagrid()
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Info")

        Finally
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click, btnOver50Days.Click

        'Print Receivables list
        Dim objRpt As New rptAccounting
        Dim ds As DataSet
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            Dim strSQL As String
            'Check to see if Date range is selected
            'strSQL = "SELECT tblGenerators.GeneratorName, tblInvoicing.InvoiceNo, tblInvoicing.InvoiceDate, Sum(IIf(DateDiff('d',[InvoiceDate],Now())<=30,[InvoiceAmount],0)) AS Days_30, Sum(IIf(DateDiff('d',[InvoiceDate],Now())>30 And DateDiff('d',[InvoiceDate],Now())<=60,[InvoiceAmount],0)) AS Days_60, Sum(IIf(DateDiff('d',[InvoiceDate],Now())>60 And DateDiff('d',[InvoiceDate],Now())<=90,[InvoiceAmount],0)) AS Days_90, Sum(IIf(DateDiff('d',[InvoiceDate],Now())>90,[InvoiceAmount],0)) AS Days_Over_90 " _
            '        & " FROM (tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN (tblJobTickets INNER JOIN tblInvoicing ON tblJobTickets.JobTicketID = tblInvoicing.JobTicketID) ON tblProducts.ProductID = tblJobTickets.ProductID " _
            '        & " WHERE tblInvoicing.PaymentReceived = False  AND tblJobTickets.IsCancelled = False " _
            '        & " GROUP BY tblGenerators.GeneratorName, tblInvoicing.InvoiceNo, tblInvoicing.InvoiceDate, tblInvoicing.PaymentReceived " _
            '        & " ORDER BY tblGenerators.GeneratorName, tblInvoicing.InvoiceNo"
            If CType(sender, Button).Name = "btnPrint" Then
                strSQL = "SELECT IIf(Len(Trim(tblGenerators.JobSite)) <> 0,tblGenerators.JobSite,tblGenerators.GeneratorName) AS JobSite, tblInvoicing.InvoiceNo, tblInvoicing.InvoiceDate, Sum(IIf(DateDiff('d',[InvoiceDate],Now())<=49,[InvoiceAmount],0)) AS Days_49, Sum(IIf(DateDiff('d',[InvoiceDate],Now())>49 And DateDiff('d',[InvoiceDate],Now())<=89,[InvoiceAmount],0)) AS Days_89, Sum(IIf(DateDiff('d',[InvoiceDate],Now())>89,[InvoiceAmount],0)) AS Days_Over_90, " _
                                & " 'Y' as Over50 FROM (tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN (tblJobTickets INNER JOIN tblInvoicing ON tblJobTickets.JobTicketID = tblInvoicing.JobTicketID) ON tblProducts.ProductID = tblJobTickets.ProductID " _
                                & " WHERE tblInvoicing.PaymentReceived = False  AND tblJobTickets.IsCancelled = False " _
                                & " GROUP BY IIf(Len(Trim(tblGenerators.JobSite)) <> 0,tblGenerators.JobSite,tblGenerators.GeneratorName), tblInvoicing.InvoiceNo, tblInvoicing.InvoiceDate, tblInvoicing.PaymentReceived "

            Else
                strSQL = "SELECT   IIf(Len(Trim(tblGenerators.JobSite)) <> 0,tblGenerators.JobSite,tblGenerators.GeneratorName) AS JobSite, tblInvoicing.InvoiceNo, tblInvoicing.InvoiceDate, Sum(IIf(DateDiff('d',[InvoiceDate],Now())<=49,[InvoiceAmount],0)) AS Days_49, Sum(IIf(DateDiff('d',[InvoiceDate],Now())>49 And DateDiff('d',[InvoiceDate],Now())<=89,[InvoiceAmount],0)) AS Days_89, Sum(IIf(DateDiff('d',[InvoiceDate],Now())>89,[InvoiceAmount],0)) AS Days_Over_90, " _
                                & " 'N' as Over50 FROM (tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN (tblJobTickets INNER JOIN tblInvoicing ON tblJobTickets.JobTicketID = tblInvoicing.JobTicketID) ON tblProducts.ProductID = tblJobTickets.ProductID " _
                                & " WHERE tblInvoicing.PaymentReceived = False  AND tblJobTickets.IsCancelled = False " _
                                & " GROUP BY IIf(Len(Trim(tblGenerators.JobSite)) <> 0,tblGenerators.JobSite,tblGenerators.GeneratorName), tblInvoicing.InvoiceNo, tblInvoicing.InvoiceDate, tblInvoicing.PaymentReceived "
            End If

            ds = DBHelper.GetDataSet(strSQL, "tblAccounting")
            Dim i As Integer
            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("No matching records found. Cancelling report...", MsgBoxStyle.Information, "No Data")
                Exit Sub
            End If
            'Set Datasouce and authenticate
            objRpt.SetDataSource(ds)
            DBHelper.Authenticate(objRpt)
            'Open Report Form and show the report
            Dim frmSR As New frmReport
            frmSR.WindowState = FormWindowState.Maximized
            frmSR.CrystalReportViewer1.ReportSource = objRpt
            frmSR.CrystalReportViewer1.RefreshReport()
            frmSR.Show()

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally
            objRpt = Nothing
            ds = Nothing
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Sub

    Function populateDatagrid()

        Dim aConn As OleDb.OleDbConnection

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            'Connect, fill dataset and bind it
            aConn = DBHelper.Connect
            If aConn.State = ConnectionState.Closed Then aConn.Open()
            Me.DsReceivables1.Clear()
            If Me.SortColumnName.Trim <> "" AndAlso Me.SelectReceivables.CommandText.IndexOf("ORDER BY") = -1 Then
                Me.SelectReceivables.CommandText = Me.SelectReceivables.CommandText & " ORDER BY " & Me.SortColumnName
            End If
            Me.DAReceivables.Fill(Me.DsReceivables1, "tblReceivables")
            Me.dgReceivables.DataSource = Me.DsReceivables1
            Me.dgReceivables.DataMember = "tblReceivables"
            Me.dgReceivables.Refresh()
            Me.rowC = Me.DsReceivables1.Tables(0).Rows.Count
            If Me.rowC = 0 Then Me.dgReceivables.ReadOnly = True Else Me.dgReceivables.ReadOnly = False

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error ocurred")

        Finally
            If aConn Is Nothing Then
            ElseIf aConn.State = ConnectionState.Open Then
                aConn.Close()
            End If
            aConn.Dispose()
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Function

    Private Sub frmReceivables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Me.OleDbConnection1.ConnectionString = DBHelper.ConnStr
        Me.populateDatagrid()
        Me.FROMDate.Format = DateTimePickerFormat.Custom
        Me.FROMDate.CustomFormat = "MM/dd/yyyy"
        Me.TODate.Format = DateTimePickerFormat.Custom
        Me.TODate.CustomFormat = "MM/dd/yyyy"
        Me.TODate.Refresh()
        Cursor.Current = System.Windows.Forms.Cursors.Default


        'hook the handlers for each of the TextBoxes in the generated columnstyles
        Dim i As Integer = 7
        Dim dgtbc As DataGridTextBoxColumn = ts_dgReceivables.GridColumnStyles(i)
            If Not (dgtbc Is Nothing) Then
                AddHandler dgtbc.TextBox.TextChanged, AddressOf dataGrid_TextChanged
            End If
    End Sub

    Private Sub dgReceivables_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgReceivables.CurrentCellChanged

        If Me.dgReceivables.CurrentCell.RowNumber < rowC Then
            Select Case Me.dgReceivables.CurrentCell.ColumnNumber
                Case 5, 6, 7, 8
                    Me.ts_dgReceivables.GridColumnStyles.Item(Me.dgReceivables.CurrentCell.ColumnNumber).ReadOnly = False
            End Select
        Else
            Select Case Me.dgReceivables.CurrentCell.ColumnNumber
                Case 5, 6, 7, 8
                    Me.ts_dgReceivables.GridColumnStyles.Item(Me.dgReceivables.CurrentCell.ColumnNumber).ReadOnly = True
            End Select
        End If
      
        'If Me.dgReceivables.CurrentRowIndex < 0 Or Me.dgReceivables.CurrentCell.ColumnNumber <> 8 Or Me.dgReceivables.CurrentCell.RowNumber >= rowC Then
        '    Exit Sub
        'End If
        If Me.dgReceivables.CurrentCell.ColumnNumber <= 4 Then Exit Sub

        Dim rNum As Integer, cNum As Integer, cN As String = "", cD As String = "", cA As String = ""
        rNum = Me.dgReceivables.CurrentCell.RowNumber
        cNum = Me.dgReceivables.CurrentCell.ColumnNumber
        If IsDBNull(Me.dgReceivables.Item(rNum, 5)) = False AndAlso Me.dgReceivables.Item(rNum, 5).ToString <> "" Then
            cN = CStr(Me.dgReceivables.Item(rNum, 5))
        End If
        If IsDBNull(Me.dgReceivables.Item(rNum, 6)) = False AndAlso Me.dgReceivables.Item(rNum, 5).ToString <> "" Then
            cD = CStr(Me.dgReceivables.Item(rNum, 6))
        End If
        If IsDBNull(Me.dgReceivables.Item(rNum, 7)) = False AndAlso Me.dgReceivables.Item(rNum, 5).ToString <> "" Then
            cA = CStr(Me.dgReceivables.Item(rNum, 7))
        End If

        If IsDBNull(Me.dgReceivables.Item(rNum, 8)) = False AndAlso CBool(Me.dgReceivables.Item(rNum, 8)) = True Then
            If cN = "" Or cD = "" Or cA = "" Then
                MsgBox("Please fill-in Check #, Date and Amount for the receivable.", MsgBoxStyle.Information, "Missing Receivable Info")
                Me.dgReceivables.Item(rNum, 8) = False
            End If
            Dim IAmount1 As Object
            Dim CAmount1 As Object
            Dim dgCell1 As DataGridCell = New DataGridCell
            dgCell1 = Me.dgReceivables.CurrentCell
            Dim dgIAmountCell1 As DataGridCell = New DataGridCell(dgCell1.RowNumber, 4)
            Dim dgCAmountCell1 As DataGridCell = New DataGridCell(dgCell1.RowNumber, 7)
            If IsDBNull(dgIAmountCell1) = True Then Exit Sub
            If IsDBNull(dgCAmountCell1) = True Then Exit Sub
            IAmount1 = Me.dgReceivables.Item(dgIAmountCell1)
            CAmount1 = Me.dgReceivables.Item(dgCAmountCell1)
            If IAmount1 <> CAmount1 Then
                MsgBox("Check amount must be same as Invoice Amount to close open receivable.", MsgBoxStyle.Information, "Missing Receivable Info")
                Me.dgReceivables.Item(rNum, 8) = False
            End If
        End If


        '#Code to do Partial payment
        Dim dgCell As DataGridCell = New DataGridCell
        Dim IAmount As Object
        Dim CAmount As Object
        Dim PartialPayment As Boolean = False
        Dim InvoiceID As Integer
        dgCell = Me.dgReceivables.CurrentCell
        If lastEditedRow = -1 Then Exit Sub
        If IsDBNull(Me.dgReceivables.Item(lastEditedRow, 0)) = False AndAlso Me.dgReceivables.Item(lastEditedRow, 0) > 0 Then
            InvoiceID = Me.dgReceivables.Item(lastEditedRow, 0)
        End If
        If dgCell.ColumnNumber = 7 AndAlso lastEditedRow > -1 Then
            Dim dgIAmountCell As DataGridCell = New DataGridCell(lastEditedRow, 4)
            Dim dgCAmountCell As DataGridCell = New DataGridCell(lastEditedRow, 7)
            Dim dgPartialPaymentCell As DataGridCell = New DataGridCell(lastEditedRow, 10)
            If IsDBNull(dgIAmountCell) = True Then Exit Sub
            If IsDBNull(dgCAmountCell) = True Then Exit Sub
            If IsDBNull(dgPartialPaymentCell) = True Then Exit Sub
            IAmount = Me.dgReceivables.Item(dgIAmountCell)
            CAmount = Me.dgReceivables.Item(dgCAmountCell)
            PartialPayment = CBool(Me.dgReceivables(dgPartialPaymentCell))
            If IsDBNull(IAmount) = False AndAlso IsDBNull(CAmount) = False AndAlso PartialPayment = False AndAlso _
                                IAmount > 0 AndAlso CAmount > 0 AndAlso IAmount <> CAmount Then
                If IsDBNull(Me.dgReceivables.Item(lastEditedRow, 5)) = False AndAlso IsDBNull(Me.dgReceivables.Item(lastEditedRow, 6)) = False AndAlso _
                                                            Me.dgReceivables.Item(lastEditedRow, 5).ToString.Trim <> "" AndAlso Me.dgReceivables.Item(lastEditedRow, 6).ToString.Trim <> "" Then

                    If MsgBox("Check amount does not match with invoice amount. Do you want to POST PARTIAL PAYMENT?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
                        Dim strInsert As String
                        Dim strUpdate As String
                        Dim strCheckNo As Object = Me.dgReceivables.Item(lastEditedRow, 5)
                        Dim strCheckDate As Object = Me.dgReceivables.Item(lastEditedRow, 6)

                        strInsert = " INSERT INTO tblInvoicing (JobTicketID, InvoiceNo, InvoiceDate, InvoiceAmount, " _
                                  & " Invoiced, CheckNo, CheckDate, CheckAmount, PaymentReceived, " _
                                  & " InvoiceType, InvoiceDescription,PartialPayment) " _
                            & "SELECT tblInvoicing.JobTicketID, tblInvoicing.InvoiceNo, tblInvoicing.InvoiceDate," _
                                  & " tblInvoicing.InvoiceAmount - " & CAmount & ", tblInvoicing.Invoiced, '', CheckDate," _
                                  & " 0, tblInvoicing.PaymentReceived," _
                                  & " tblInvoicing.InvoiceType, tblInvoicing.InvoiceDescription,false " _
                          & " FROM tblInvoicing WHERE InvoiceID = " & InvoiceID & ";"
                        If DBHelper.ExecuteQuery(strInsert) = False Then
                            MsgBox("Cannot Partial Payment. Error ocurred.", MsgBoxStyle.Critical, "Error")
                            Exit Sub
                        End If
                        Me.DAReceivables.Update(Me.DsReceivables1)
                        strUpdate = "UPDATE tblInvoicing SET CheckNo ='" & strCheckNo & "',CheckDate = '" & strCheckDate & "',CheckAmount = " & CAmount & ", InvoiceAmount = " & CAmount & ",PartialPayment = True WHERE InvoiceID = " & InvoiceID & ";"
                        If DBHelper.ExecuteQuery(strUpdate) = False Then
                            MsgBox("Cannot Partial Payment. Error ocurred.", MsgBoxStyle.Critical, "Error")
                            Exit Sub
                        End If
                        Me.populateDatagrid()
                    ElseIf vbNo Then
                        'Me.dgReceivables.Item(dgCAmountCell) = IAmount
                    Else
                        'nothing
                    End If

                End If
            End If
        End If

    End Sub

    Private Sub frmReceivables_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        If Me.DsReceivables1.HasChanges = True Then
            If MsgBox("You have made changes. Do you want to save these changes?", MsgBoxStyle.YesNo, "Save Changes") = MsgBoxResult.Yes Then
                'hook the handlers for each of the TextBoxes in the generated columnstyles
                Me.DAReceivables.Update(Me.DsReceivables1)
            End If
        End If
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub btnDeposits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposits.Click
        'Print Receivables list
        Dim objRpt As New rptdeposit
        Dim ds As DataSet

        Dim strSQL As String = ""
        Dim FROMDate As Date = Me.FROMDate.Value.ToShortDateString
        Dim TODate As Date = Me.TODate.Value.ToShortDateString
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        SetDateRange(objRpt)
        strSQL = "SELECT DISTINCT tblInvoicing.InvoiceID, tblInvoicing.InvoiceDate, IIf(Len(Trim(tblGenerators.JobSite)) <> 0,tblGenerators.JobSite,tblGenerators.GeneratorName) AS GeneratorName," & _
             " tblJobTickets.JobTicketNo, tblInvoicing.InvoiceAmount, tblInvoicing.CheckNo" & _
            ", tblInvoicing.CheckDate, tblInvoicing.CheckAmount, tblInvoicing.PaymentReceived" & _
            ", tblGenerators.JobSiteAddress1, tblGenerators.JobSiteCity, tblInvoicing.Invoice" & _
            "No,IIf(tblInvoicing.CheckAmount > 0,'APOS','BNEG') as GName FROM (((tblJobTickets LEFT OUTER JOIN tblProducts ON tblJobTickets.ProductID = tbl" & _
            "Products.ProductID) LEFT OUTER JOIN tblGenerators ON tblProducts.GeneratorID = tblGen" & _
            "erators.GeneratorID) LEFT OUTER JOIN tblInvoicing ON tblJobTickets.JobTicketID = tblI" & _
            "nvoicing.JobTicketID) WHERE (tblJobTickets.IsCancelled = False) " & _
            " and (tblInvoicing.CheckDate BETWEEN #" & FROMDate & "# and #" & TODate & "#)"
        Try
            ds = DBHelper.GetDataSet(strSQL, "tblReceivables")
            Dim i As Integer
            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("No matching records found. Cancelling report...", MsgBoxStyle.Information, "No Data")
                Exit Sub
            End If
            'Set Datasouce and authenticate
            objRpt.SetDataSource(ds)
            DBHelper.Authenticate(objRpt)
            'Open Report Form and show the report
            Dim frmSR As New frmReport
            frmSR.WindowState = FormWindowState.Maximized
            frmSR.CrystalReportViewer1.ReportSource = objRpt
            frmSR.CrystalReportViewer1.RefreshReport()
            frmSR.Show()

        Catch ex As Exception

        End Try
    End Sub
    Public Function SetDateRange(ByRef rpt As ReportDocument)
        Dim fFields As FormulaFieldDefinitions = rpt.DataDefinition.FormulaFields
        Dim fField As FormulaFieldDefinition
        Dim FROMDate As Date = Me.FROMDate.Value.ToShortDateString
        Dim TODate As Date = Me.TODate.Value.ToShortDateString

        Dim dateRange As String = ""
        dateRange = "FROM " & FROMDate.ToShortDateString & " TO " & TODate.ToShortDateString
        'Update Date Range Formula field with date range
        fField = fFields.Item("DateRange")
        fField.Text = """" & dateRange & """"
        'fField.Text = dateRange
    End Function

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim JobID As Integer = 0
        Dim InvoiceID As Integer = 0
        '#Column 0 is Invoice ID
        If IsDBNull(Me.dgReceivables.Item(Me.dgReceivables.CurrentRowIndex, 0)) = False AndAlso (Me.dgReceivables.Item(Me.dgReceivables.CurrentRowIndex, 0)) > 0 Then
            InvoiceID = Me.dgReceivables.Item(Me.dgReceivables.CurrentRowIndex, 0)
        Else
            InvoiceID = 0
        End If
        '#Column 9 is JobTicket ID
        If IsDBNull(Me.dgReceivables.Item(Me.dgReceivables.CurrentRowIndex, 9)) = False AndAlso (Me.dgReceivables.Item(Me.dgReceivables.CurrentRowIndex, 9)) > 0 Then
            JobID = Me.dgReceivables.Item(Me.dgReceivables.CurrentRowIndex, 9)
        Else
            JobID = 0
        End If
        If InvoiceID <= 0 AndAlso JobID <= 0 Then Exit Sub
        Dim strSQL As String = ""
        Dim delFlag As Boolean = True
        If MsgBox("This will permanently DELETE this invoice from the System.are you sure?", MsgBoxStyle.YesNo, "Confirm Message") = MsgBoxResult.Yes Then
            '#Check if there is any Payment made to any of invoices
            Dim amount As Decimal
            strSQL = "SELECT Sum(tblInvoicing.CheckAmount) AS SumOfInvoiceAmount FROM tblInvoicing WHERE " _
                                & " InvoiceID = " & InvoiceID
            amount = DBHelper.GetDecimal(strSQL)
            If amount > 0 Then
                MsgBox("Can NOT delete because it has already been paid.", MsgBoxStyle.Information, "Error ocurred")
                Exit Sub
            End If
            'delete JobTicket Information
            strSQL = "DELETE FROM tblJobTickets_Details WHERE JobTicketID = " & JobID
            If DBHelper.ExecuteQuery(strSQL) = False Then
                MsgBox("An error ocurred while performing this operation. Your information has not been saved.", MsgBoxStyle.Information, "Error ocurred")
                delFlag = False
            End If
            'DELETE FROM Invoicing
            strSQL = "DELETE FROM tblInvoicing WHERE InvoiceID = " & InvoiceID
            If DBHelper.ExecuteQuery(strSQL) = False Then
                MsgBox("An error ocurred while performing this operation. Your information has not been saved.", MsgBoxStyle.Information, "Error ocurred")
                delFlag = False
            End If
            Me.populateDatagrid()
        End If
    End Sub
    Private Sub btnInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvoice.Click
        Dim JobTicketNo As String
        If IsDBNull(Me.dgReceivables.Item(Me.dgReceivables.CurrentRowIndex, 9)) = False AndAlso (Me.dgReceivables.Item(Me.dgReceivables.CurrentRowIndex, 9).ToString) <> "" Then
            JobTicketNo = Me.dgReceivables.Item(Me.dgReceivables.CurrentRowIndex, 9).ToString
            If JobTicketNo <> "" Then
                newForm1 = New frmInvoice(False)
                newForm1.lblReqField.Text = JobTicketNo
                newForm1.lblWhatForm.Text = "frmReceivables"
                newForm1.Owner = Me
                newForm1.ShowDialog()
            End If
        End If
    End Sub
    Private Sub btnJobTickets_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJobTickets.Click
        Dim JobTicketNo As String
        If IsDBNull(Me.dgReceivables.Item(Me.dgReceivables.CurrentRowIndex, 9)) = False AndAlso (Me.dgReceivables.Item(Me.dgReceivables.CurrentRowIndex, 9).ToString) <> "" Then
            JobTicketNo = Me.dgReceivables.Item(Me.dgReceivables.CurrentRowIndex, 9).ToString
            If JobTicketNo > 0 Then
                newForm = New frmJobTicket(False)
                newForm.lblReqField.Text = JobTicketNo
                newForm.lblWhatForm.Text = "frmReceivables"
                newForm.Owner = Me
                newForm.ShowDialog()
            End If
        End If
    End Sub
    Private Sub dgReceivables_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgReceivables.MouseDown
        Dim hi As System.Windows.Forms.DataGrid.HitTestInfo
        hi = Me.dgReceivables.HitTest(e.X, e.Y)
        ' Test if the clicked area was a cell.
        If hi.Type = DataGrid.HitTestType.Cell Then
        ElseIf hi.Type = DataGrid.HitTestType.ColumnHeader Then
            Select Case hi.Column
                Case 0
                Case 1 : Me.SortColumnName = "InvoiceDate"
                Case 2 : Me.SortColumnName = "InvoiceNo"
                Case 3 : Me.SortColumnName = "GeneratorName"
                Case 4 : Me.SortColumnName = "InvoiceAmount"
                Case 5 : Me.SortColumnName = "CheckNo"
                Case 6 : Me.SortColumnName = "CheckDate"
                Case 7 : Me.SortColumnName = "CheckAmount"
                Case 8 : Me.SortColumnName = "PaymentReceived"
            End Select
        Else
        End If
    End Sub

    Private Sub dataGrid_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim dgcc As DataGridCell = Me.dgReceivables.CurrentCell
        Dim tb As TextBox = GetEmbeddedTextBox(dgcc.ColumnNumber)
        If Not (tb Is Nothing) Then
            Dim oldValue As String = Me.dgReceivables(dgcc).ToString()
            Dim newValue As String = tb.Text
            If newValue <> oldValue AndAlso (dgcc.RowNumber <> lastEditedRow OrElse dgcc.ColumnNumber <> lastEditedCol) Then
                Dim s As String = String.Format("{0},{1} started editing", dgcc.RowNumber, dgcc.ColumnNumber)
                Me.Label1.Text = s
                Console.WriteLine(s)
                lastEditedRow = dgcc.RowNumber
                lastEditedCol = dgcc.ColumnNumber
            End If
        End If
    End Sub 'dataGrid_TextChanged
    Private Function GetEmbeddedTextBox(ByVal col As Integer) As TextBox
        Dim tbc As DataGridTextBoxColumn = ts_dgReceivables.GridColumnStyles(col)
        If Not (tbc Is Nothing) AndAlso tbc.TextBox.Modified Then
            Return tbc.TextBox
        End If
        Return Nothing
    End Function 'GetEmbeddedTextBox


End Class
