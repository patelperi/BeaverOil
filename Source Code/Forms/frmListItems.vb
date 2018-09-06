Public Class frmListItems
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
    Friend WithEvents dgItems As System.Windows.Forms.DataGrid
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DAItems As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents SelectItems As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsItems1 As BeaverOil.DSItems
    Friend WithEvents ts_Items As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents col_Items1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dgItems = New System.Windows.Forms.DataGrid
        Me.DsItems1 = New BeaverOil.DSItems
        Me.ts_Items = New System.Windows.Forms.DataGridTableStyle
        Me.col_Items1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.DAItems = New System.Data.OleDb.OleDbDataAdapter
        Me.SelectItems = New System.Data.OleDb.OleDbCommand
        CType(Me.dgItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsItems1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgItems
        '
        Me.dgItems.ColumnHeadersVisible = False
        Me.dgItems.DataMember = "tblProducts"
        Me.dgItems.DataSource = Me.DsItems1
        Me.dgItems.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgItems.Location = New System.Drawing.Point(8, 8)
        Me.dgItems.Name = "dgItems"
        Me.dgItems.ParentRowsVisible = False
        Me.dgItems.ReadOnly = True
        Me.dgItems.RowHeadersVisible = False
        Me.dgItems.Size = New System.Drawing.Size(328, 360)
        Me.dgItems.TabIndex = 0
        Me.dgItems.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.ts_Items})
        '
        'DsItems1
        '
        Me.DsItems1.DataSetName = "DSItems"
        Me.DsItems1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'ts_Items
        '
        Me.ts_Items.AlternatingBackColor = System.Drawing.Color.Silver
        Me.ts_Items.DataGrid = Me.dgItems
        Me.ts_Items.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.col_Items1, Me.DataGridTextBoxColumn1})
        Me.ts_Items.HeaderFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_Items.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.ts_Items.MappingName = "tblProducts"
        Me.ts_Items.ReadOnly = True
        Me.ts_Items.RowHeadersVisible = False
        '
        'col_Items1
        '
        Me.col_Items1.Format = ""
        Me.col_Items1.FormatInfo = Nothing
        Me.col_Items1.HeaderText = "Items"
        Me.col_Items1.MappingName = "ItemText"
        Me.col_Items1.NullText = ""
        Me.col_Items1.Width = 120
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = "ProductName"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 180
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
        'DAItems
        '
        Me.DAItems.SelectCommand = Me.SelectItems
        Me.DAItems.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblProducts", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ItemText", "ItemText")})})
        '
        'SelectItems
        '
        Me.SelectItems.CommandText = "SELECT GenProdNo AS ItemText, ProductName FROM tblProducts WHERE (GenProdNo IS NO" & _
        "T NULL) AND (GenProdNo <> '') ORDER BY GenProdNo"
        Me.SelectItems.Connection = Me.OleDbConnection1
        '
        'frmListItems
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(344, 373)
        Me.Controls.Add(Me.dgItems)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmListItems"
        Me.Text = "Items"
        CType(Me.dgItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsItems1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public whatOpt As Integer = 0
    Public genID As Integer = 0

    Private Sub frmListItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim aConn As OleDb.OleDbConnection
        Try

            Me.DsItems1.Clear()
            'Connect, fill dataset and bind it
            aConn = DBHelper.Connect
            If aConn.State = ConnectionState.Closed Then aConn.Open()
            Me.SelectItems.Connection = aConn
            If whatOpt = 1 Then
                Me.SelectItems.CommandText = "SELECT DISTINCT (GenProdNo) as ItemText FROM tblProducts WHERE ((GenProdNo Is Not NULL) AND (GenProdNo <> '')) AND GeneratorID = " & Me.genID & " ORDER BY GenProdNo DESC"
                Me.DAItems.Fill(Me.DsItems1, "tblProducts")
                Me.dgItems.CaptionText = "Customer #'s"
            Else
                Me.SelectItems.CommandText = "SELECT DISTINCT (ApprovalNo) as ItemText,ProductName FROM tblProducts WHERE ((ApprovalNo Is Not NULL) AND (ApprovalNo <> '')) AND GeneratorID = " & Me.genID & " ORDER BY ApprovalNo DESC"
                Me.DAItems.Fill(Me.DsItems1, "tblProducts")
                Me.dgItems.CaptionText = "Approval #'s"
            End If
            Me.dgItems.DataSource = Me.DsItems1
            Me.dgItems.DataMember = "tblProducts"
            Me.dgItems.Refresh()

        Catch ex As SystemException

            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally

            If aConn.State = ConnectionState.Open Then
                aConn.Close()
            End If
            aConn.Dispose()
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Sub

End Class
