Imports BeaverOil.DataGridButton

Public Class frmLabData

    Inherits System.Windows.Forms.Form
    Dim rCount As Integer = 0
    Public newForm As frmLabData_L

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
    Friend WithEvents cmbViewBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgLabData As System.Windows.Forms.DataGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dgLabData = New System.Windows.Forms.DataGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbViewBy = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        CType(Me.dgLabData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgLabData
        '
        Me.dgLabData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgLabData.DataMember = "tblJobTickets"
        Me.dgLabData.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgLabData.Location = New System.Drawing.Point(8, 40)
        Me.dgLabData.Name = "dgLabData"
        Me.dgLabData.ReadOnly = True
        Me.dgLabData.RowHeadersVisible = False
        Me.dgLabData.Size = New System.Drawing.Size(616, 376)
        Me.dgLabData.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(208, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 24)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Lab Data"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbViewBy
        '
        Me.cmbViewBy.Items.AddRange(New Object() {"Incomplete", "Complete"})
        Me.cmbViewBy.Location = New System.Drawing.Point(512, 8)
        Me.cmbViewBy.Name = "cmbViewBy"
        Me.cmbViewBy.Size = New System.Drawing.Size(112, 21)
        Me.cmbViewBy.TabIndex = 35
        Me.cmbViewBy.Text = "Incomplete"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(448, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "View by:"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(8, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1, 376)
        Me.Label3.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(624, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1, 376)
        Me.Label4.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(8, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(616, 1)
        Me.Label5.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(8, 416)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(616, 1)
        Me.Label6.TabIndex = 40
        '
        'frmLabData
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(632, 429)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbViewBy)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgLabData)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmLabData"
        Me.Text = "frmLabData"
        CType(Me.dgLabData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmbViewBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbViewBy.SelectedIndexChanged

        Me.populateDatagrid()

    End Sub

    Private Sub frmLabData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.cmbViewBy.Text = "Incomplete"
        Me.populateDatagrid()

    End Sub

    Function populateDatagrid()

        Dim ds As DataSet
        Dim sqlStr As String

        Try

            If Me.cmbViewBy.Text = "Incomplete" Then
                sqlStr = "SELECT tblJobTickets.JobTicketNo, tblJobTickets.JobTicketDate, tblGenerators.GeneratorName, tblProducts.ProductName, tblJobTickets.DriverName, 'ENTER' as LabData FROM ((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) LEFT OUTER JOIN tblLabData ON tblJobTickets.JobTicketID = tblLabData.JobTicketID WHERE (((tblLabData.JobTicketID) Is Null)) AND tblJobTickets.JobTicketSubmitted = True ORDER BY tblJobTickets.JobTicketNo"
            Else
                sqlStr = "SELECT tblJobTickets.JobTicketNo, tblJobTickets.JobTicketDate, tblGenerators.GeneratorName, tblProducts.ProductName, tblJobTickets.DriverName, 'VIEW' as LabData FROM ((tblGenerators INNER JOIN tblProducts ON tblGenerators.GeneratorID = tblProducts.GeneratorID) INNER JOIN tblJobTickets ON tblProducts.ProductID = tblJobTickets.ProductID) INNER JOIN tblLabData ON tblJobTickets.JobTicketID = tblLabData.JobTicketID WHERE tblJobTickets.JobTicketSubmitted = True ORDER BY tblJobTickets.JobTicketNo"
            End If

            ' make the dataGrid use our new tablestyle
            dgLabData.TableStyles.Clear()

            ds = DBHelper.GetDataSet(sqlStr, "tblJobTickets")
            rCount = ds.Tables(0).Rows.Count
            If Me.rCount = 0 Then Me.dgLabData.ReadOnly = True Else Me.dgLabData.ReadOnly = False

            Dim ts_dgLabData = New System.Windows.Forms.DataGridTableStyle
            Dim col_dgLabData_J = New System.Windows.Forms.DataGridTextBoxColumn
            Dim col_dgLabData_JD = New System.Windows.Forms.DataGridTextBoxColumn
            Dim col_dgLabData_G = New System.Windows.Forms.DataGridTextBoxColumn
            Dim col_dgLabData_P = New System.Windows.Forms.DataGridTextBoxColumn
            Dim col_dgLabData_D = New System.Windows.Forms.DataGridTextBoxColumn

            Me.DefineColumnStyles(ts_dgLabData, col_dgLabData_J, col_dgLabData_JD, col_dgLabData_G, col_dgLabData_P, col_dgLabData_D)

            Dim col_dgLabData_L As DataGridButtonColumn = New DataGridButtonColumn(5)
            col_dgLabData_L.InitializeRowCount(rCount)
            col_dgLabData_L.Format = ""
            col_dgLabData_L.FormatInfo = Nothing
            col_dgLabData_L.HeaderText = "Lab Data"
            col_dgLabData_L.MappingName = "LabData"
            col_dgLabData_L.NullText = ""
            col_dgLabData_L.Alignment = HorizontalAlignment.Center
            col_dgLabData_L.Width = 80
            ts_dgLabData.GridColumnStyles.Add(col_dgLabData_L)

            ' make the dataGrid use our new tablestyle and bind it to our table
            dgLabData.TableStyles.Clear()
            dgLabData.TableStyles.Add(ts_dgLabData)

            'bind the table to the datagrid
            Me.dgLabData.DataSource = ds
            Me.dgLabData.DataMember = "tblJobTickets"
            Me.dgLabData.Refresh()

        Catch ex As SystemException

            MsgBox(ex.Message, MsgBoxStyle.Information, "Error ocurred")

        End Try

    End Function

    Function DefineColumnStyles(ByRef ts_dgLabData As DataGridTableStyle, ByRef col_dgLabData_J As DataGridTextBoxColumn, ByRef col_dgLabData_JD As DataGridTextBoxColumn, ByRef col_dgLabData_G As DataGridTextBoxColumn, ByRef col_dgLabData_P As DataGridTextBoxColumn, ByRef col_dgLabData_D As DataGridTextBoxColumn)

        '
        'ts_dgLabData
        '
        ts_dgLabData.AlternatingBackColor = System.Drawing.Color.Silver
        ts_dgLabData.DataGrid = Me.dgLabData
        ts_dgLabData.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {col_dgLabData_J, col_dgLabData_JD, col_dgLabData_G, col_dgLabData_P, col_dgLabData_D})
        ts_dgLabData.GridLineColor = System.Drawing.Color.Black
        ts_dgLabData.HeaderBackColor = System.Drawing.Color.LightSteelBlue
        ts_dgLabData.HeaderFont = New System.Drawing.Font("Verdana", 10.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ts_dgLabData.HeaderForeColor = System.Drawing.SystemColors.ControlText
        ts_dgLabData.MappingName = "tblJobTickets"
        ts_dgLabData.RowHeadersVisible = False
        '
        'col_dgLabData_J
        '
        col_dgLabData_J.Format = ""
        col_dgLabData_J.FormatInfo = Nothing
        col_dgLabData_J.HeaderText = "Job #"
        col_dgLabData_J.MappingName = "JobTicketNo"
        col_dgLabData_J.NullText = ""
        col_dgLabData_J.ReadOnly = True
        col_dgLabData_J.Width = 60
        '
        'col_dgLabData_JD
        '
        col_dgLabData_JD.Format = ""
        col_dgLabData_JD.FormatInfo = Nothing
        col_dgLabData_JD.HeaderText = "Job Date"
        col_dgLabData_JD.MappingName = "JobTicketDate"
        col_dgLabData_JD.NullText = ""
        col_dgLabData_JD.ReadOnly = True
        col_dgLabData_JD.Width = 80
        '
        'col_dgLabData_G
        '
        col_dgLabData_G.Format = ""
        col_dgLabData_G.FormatInfo = Nothing
        col_dgLabData_G.HeaderText = "Generator"
        col_dgLabData_G.MappingName = "GeneratorName"
        col_dgLabData_G.NullText = ""
        col_dgLabData_G.ReadOnly = True
        col_dgLabData_G.Width = 165
        '
        'col_dgLabData_P
        '
        col_dgLabData_P.Format = ""
        col_dgLabData_P.FormatInfo = Nothing
        col_dgLabData_P.HeaderText = "Product"
        col_dgLabData_P.MappingName = "ProductName"
        col_dgLabData_P.NullText = ""
        col_dgLabData_P.ReadOnly = True
        col_dgLabData_P.Width = 140
        '
        'col_dgLabData_D
        '
        col_dgLabData_D.Format = ""
        col_dgLabData_D.FormatInfo = Nothing
        col_dgLabData_D.HeaderText = "Driver"
        col_dgLabData_D.MappingName = "DriverName"
        col_dgLabData_D.NullText = ""
        col_dgLabData_D.Width = 75

    End Function

    Private Sub HandleCellButtonClick(ByVal whatVal As String, ByVal cellVal As String)

        If IsNothing(newForm) = False Then
            newForm = Nothing
        End If
        newForm = New frmLabData_L
        newForm.lblReqField.Text = cellVal
        newForm.Owner = Me
        newForm.ShowDialog()

    End Sub

    Private Sub dgLabData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgLabData.Click

        If Me.dgLabData.CurrentCell.RowNumber >= Me.rCount Then Exit Sub
        If Me.dgLabData.CurrentCell.ColumnNumber <> 5 Then Exit Sub
        Me.HandleCellButtonClick("None", Me.dgLabData.Item(Me.dgLabData.CurrentCell.RowNumber, 0))

    End Sub

End Class
