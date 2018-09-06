Public Class frmCancelJobs
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DAJobBoard As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents SelectJobBoard As System.Data.OleDb.OleDbCommand
    Friend WithEvents UpdateJobBoard As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsCancelJobs1 As BeaverOil.DSCancelJobs
    Friend WithEvents dgJobBoard As System.Windows.Forms.DataGrid
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ts_dgJobBoard As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents col_dgJobBoard_J As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_dgJobBoard_G As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_dgJobBoard_P As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_dgJobBoard_SD As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_dgJobBoard_C As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.DAJobBoard = New System.Data.OleDb.OleDbDataAdapter
        Me.SelectJobBoard = New System.Data.OleDb.OleDbCommand
        Me.UpdateJobBoard = New System.Data.OleDb.OleDbCommand
        Me.DsCancelJobs1 = New BeaverOil.DSCancelJobs
        Me.dgJobBoard = New System.Windows.Forms.DataGrid
        Me.ts_dgJobBoard = New System.Windows.Forms.DataGridTableStyle
        Me.col_dgJobBoard_J = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_dgJobBoard_G = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_dgJobBoard_P = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_dgJobBoard_SD = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_dgJobBoard_C = New System.Windows.Forms.DataGridBoolColumn
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.DsCancelJobs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgJobBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(152, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 24)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Cancel Jobs"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Jet OLEDB:Database Password=;Data Source=""C:\Documents and Setting" & _
        "s\Administrator.GREEVESLAPTOP\My Documents\Visual Studio Projects\BeaverOil\DBFi" & _
        "le\JobTrackingSystem.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bul" & _
        "k Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;J" & _
        "et OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Datab" & _
        "ase Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale" & _
        " on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;J" & _
        "et OLEDB:Encrypt Database=False"
        '
        'DAJobBoard
        '
        Me.DAJobBoard.SelectCommand = Me.SelectJobBoard
        Me.DAJobBoard.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblJobTickets", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("JobTicketID", "JobTicketID"), New System.Data.Common.DataColumnMapping("GeneratorName", "GeneratorName"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("ScheduleDate", "ScheduleDate"), New System.Data.Common.DataColumnMapping("IsCancelled", "IsCancelled")})})
        Me.DAJobBoard.UpdateCommand = Me.UpdateJobBoard
        '
        'SelectJobBoard
        '
        Me.SelectJobBoard.CommandText = "SELECT tblJobTickets.JobTicketID, (tblGenerators.GeneratorName + ' - ' + tblGenerators.Job" & _
        "Site) AS GeneratorName, tblProducts.ProductName, tblJobTickets.ScheduleDa" & _
        "te, tblJobTickets.IsCancelled FROM ((tblGenerators INNER JOIN tblProducts ON tbl" & _
        "Generators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets ON tb" & _
        "lProducts.ProductID = tblJobTickets.ProductID) WHERE (tblJobTickets.IsCancelled " & _
        "= False) AND (tblJobTickets.JobTicketSubmitted = False) ORDER BY tblJobTickets.S" & _
        "cheduleDate"
        Me.SelectJobBoard.Connection = Me.OleDbConnection1
        '
        'UpdateJobBoard
        '
        Me.UpdateJobBoard.CommandText = "UPDATE tblJobTickets SET IsCancelled = ? WHERE (JobTicketID = ?)"
        Me.UpdateJobBoard.Connection = Me.OleDbConnection1
        Me.UpdateJobBoard.Parameters.Add(New System.Data.OleDb.OleDbParameter("IsCancelled", System.Data.OleDb.OleDbType.Boolean, 2, "IsCancelled"))
        Me.UpdateJobBoard.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_JobTicketID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "JobTicketID", System.Data.DataRowVersion.Original, Nothing))
        '
        'DsCancelJobs1
        '
        Me.DsCancelJobs1.DataSetName = "DSCancelJobs"
        Me.DsCancelJobs1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'dgJobBoard
        '
        Me.dgJobBoard.CaptionFont = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgJobBoard.CaptionText = "Job Board"
        Me.dgJobBoard.DataMember = "tblJobTickets"
        Me.dgJobBoard.DataSource = Me.DsCancelJobs1
        Me.dgJobBoard.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgJobBoard.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgJobBoard.Location = New System.Drawing.Point(8, 24)
        Me.dgJobBoard.Name = "dgJobBoard"
        Me.dgJobBoard.ParentRowsVisible = False
        Me.dgJobBoard.RowHeadersVisible = False
        Me.dgJobBoard.Size = New System.Drawing.Size(760, 504)
        Me.dgJobBoard.TabIndex = 1
        Me.dgJobBoard.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.ts_dgJobBoard})
        '
        'ts_dgJobBoard
        '
        Me.ts_dgJobBoard.AlternatingBackColor = System.Drawing.Color.Silver
        Me.ts_dgJobBoard.BackColor = System.Drawing.Color.White
        Me.ts_dgJobBoard.DataGrid = Me.dgJobBoard
        Me.ts_dgJobBoard.ForeColor = System.Drawing.Color.Black
        Me.ts_dgJobBoard.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.col_dgJobBoard_J, Me.col_dgJobBoard_G, Me.col_dgJobBoard_P, Me.col_dgJobBoard_SD, Me.col_dgJobBoard_C})
        Me.ts_dgJobBoard.GridLineColor = System.Drawing.Color.Black
        Me.ts_dgJobBoard.HeaderBackColor = System.Drawing.SystemColors.Desktop
        Me.ts_dgJobBoard.HeaderFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_dgJobBoard.HeaderForeColor = System.Drawing.Color.White
        Me.ts_dgJobBoard.MappingName = "tblJobTickets"
        Me.ts_dgJobBoard.RowHeadersVisible = False
        '
        'col_dgJobBoard_J
        '
        Me.col_dgJobBoard_J.Format = ""
        Me.col_dgJobBoard_J.FormatInfo = Nothing
        Me.col_dgJobBoard_J.HeaderText = "JobTicket"
        Me.col_dgJobBoard_J.MappingName = "JobTicketID"
        Me.col_dgJobBoard_J.NullText = ""
        Me.col_dgJobBoard_J.ReadOnly = True
        Me.col_dgJobBoard_J.Width = 0
        '
        'col_dgJobBoard_G
        '
        Me.col_dgJobBoard_G.Format = ""
        Me.col_dgJobBoard_G.FormatInfo = Nothing
        Me.col_dgJobBoard_G.HeaderText = "Generator"
        Me.col_dgJobBoard_G.MappingName = "GeneratorName"
        Me.col_dgJobBoard_G.NullText = ""
        Me.col_dgJobBoard_G.ReadOnly = True
        Me.col_dgJobBoard_G.Width = 320
        '
        'col_dgJobBoard_P
        '
        Me.col_dgJobBoard_P.Format = ""
        Me.col_dgJobBoard_P.FormatInfo = Nothing
        Me.col_dgJobBoard_P.HeaderText = "Product"
        Me.col_dgJobBoard_P.MappingName = "ProductName"
        Me.col_dgJobBoard_P.NullText = ""
        Me.col_dgJobBoard_P.ReadOnly = True
        Me.col_dgJobBoard_P.Width = 225
        '
        'col_dgJobBoard_SD
        '
        Me.col_dgJobBoard_SD.Format = "d"
        Me.col_dgJobBoard_SD.FormatInfo = Nothing
        Me.col_dgJobBoard_SD.HeaderText = "Scheduled Date"
        Me.col_dgJobBoard_SD.MappingName = "ScheduleDate"
        Me.col_dgJobBoard_SD.NullText = ""
        Me.col_dgJobBoard_SD.ReadOnly = True
        Me.col_dgJobBoard_SD.Width = 110
        '
        'col_dgJobBoard_C
        '
        Me.col_dgJobBoard_C.AllowNull = False
        Me.col_dgJobBoard_C.FalseValue = False
        Me.col_dgJobBoard_C.HeaderText = "Cancel"
        Me.col_dgJobBoard_C.MappingName = "IsCancelled"
        Me.col_dgJobBoard_C.NullText = ""
        Me.col_dgJobBoard_C.NullValue = "False"
        Me.col_dgJobBoard_C.TrueValue = True
        Me.col_dgJobBoard_C.Width = 80
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(320, 556)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 24)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(456, 556)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 24)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Save && Close"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(136, 532)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(368, 16)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Note: Once you cancel a job you will not be able to restore it."
        '
        'frmCancelJobs
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(772, 590)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgJobBoard)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmCancelJobs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancel Jobs"
        CType(Me.DsCancelJobs1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgJobBoard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            If Me.DsCancelJobs1.Tables(0).Rows.Count > 0 Then
                If Me.DsCancelJobs1.HasChanges = True Then
                    Me.DAJobBoard.Update(Me.DsCancelJobs1)
                End If
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Info")

        Finally
            Me.Close()
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub frmCancelJobs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Me.OleDbConnection1.ConnectionString = DBHelper.ConnStr
        Dim aConn As OleDb.OleDbConnection
        Try
            'Connect, fill dataset and bind it
            aConn = DBHelper.Connect
            If aConn.State = ConnectionState.Closed Then aConn.Open()
            Me.SelectJobBoard.Connection = aConn
            Me.DsCancelJobs1.Clear()
            Me.DAJobBoard.Fill(Me.DsCancelJobs1, "tblJobTickets")
            Me.dgJobBoard.DataSource = Me.DsCancelJobs1
            Me.dgJobBoard.DataMember = "tblJobTickets"
            Me.dgJobBoard.Refresh()
            If Me.DsCancelJobs1.Tables(0).Rows.Count > 0 Then
                Me.dgJobBoard.ReadOnly = False
            Else
                Me.dgJobBoard.ReadOnly = True
                Me.dgJobBoard.Focus()
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Ocurred")

        Finally
            If aConn Is Nothing Then
            ElseIf aConn.State = ConnectionState.Open Then
                aConn.Close()
            End If
            aConn.Dispose()
            Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

    End Sub

End Class
