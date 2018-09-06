Imports BeaverOil.DataGridButton

Public Class frmInvoicingList
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal Flag As Boolean)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.chkInvoiceClosed.Checked = Flag

        Me.lblClosed.Visible = Flag
        
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
    Friend WithEvents dgJobBoard As System.Windows.Forms.DataGrid
    Friend WithEvents btnCreateManual As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnOpenJobTicket As System.Windows.Forms.Button
    Friend WithEvents btnClosedJobTicket As System.Windows.Forms.Button
    Friend WithEvents chkInvoiceClosed As System.Windows.Forms.CheckBox
    Friend WithEvents lblClosed As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dgJobBoard = New System.Windows.Forms.DataGrid
        Me.btnCreateManual = New System.Windows.Forms.Button
        Me.btnOpenJobTicket = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnClosedJobTicket = New System.Windows.Forms.Button
        Me.chkInvoiceClosed = New System.Windows.Forms.CheckBox
        Me.lblClosed = New System.Windows.Forms.Label
        CType(Me.dgJobBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgJobBoard
        '
        Me.dgJobBoard.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgJobBoard.CaptionVisible = False
        Me.dgJobBoard.DataMember = ""
        Me.dgJobBoard.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgJobBoard.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgJobBoard.Location = New System.Drawing.Point(8, 32)
        Me.dgJobBoard.Name = "dgJobBoard"
        Me.dgJobBoard.Size = New System.Drawing.Size(938, 538)
        Me.dgJobBoard.TabIndex = 36
        '
        'btnCreateManual
        '
        Me.btnCreateManual.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCreateManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateManual.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateManual.Location = New System.Drawing.Point(146, 580)
        Me.btnCreateManual.Name = "btnCreateManual"
        Me.btnCreateManual.Size = New System.Drawing.Size(232, 24)
        Me.btnCreateManual.TabIndex = 151
        Me.btnCreateManual.Text = "Create a Manual Job-Ticket"
        Me.btnCreateManual.Visible = False
        '
        'btnOpenJobTicket
        '
        Me.btnOpenJobTicket.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnOpenJobTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenJobTicket.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenJobTicket.Location = New System.Drawing.Point(624, 576)
        Me.btnOpenJobTicket.Name = "btnOpenJobTicket"
        Me.btnOpenJobTicket.Size = New System.Drawing.Size(158, 24)
        Me.btnOpenJobTicket.TabIndex = 152
        Me.btnOpenJobTicket.Text = "&Open Job Ticket"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(6, 570)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(940, 1)
        Me.Label2.TabIndex = 154
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(8, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(938, 1)
        Me.Label3.TabIndex = 155
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1, 538)
        Me.Label1.TabIndex = 156
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Location = New System.Drawing.Point(946, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1, 538)
        Me.Label4.TabIndex = 157
        '
        'btnClosedJobTicket
        '
        Me.btnClosedJobTicket.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnClosedJobTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClosedJobTicket.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClosedJobTicket.Location = New System.Drawing.Point(788, 576)
        Me.btnClosedJobTicket.Name = "btnClosedJobTicket"
        Me.btnClosedJobTicket.Size = New System.Drawing.Size(158, 24)
        Me.btnClosedJobTicket.TabIndex = 159
        Me.btnClosedJobTicket.Text = "&Close Invoice"
        '
        'chkInvoiceClosed
        '
        Me.chkInvoiceClosed.ForeColor = System.Drawing.Color.Red
        Me.chkInvoiceClosed.Location = New System.Drawing.Point(402, 580)
        Me.chkInvoiceClosed.Name = "chkInvoiceClosed"
        Me.chkInvoiceClosed.Size = New System.Drawing.Size(218, 18)
        Me.chkInvoiceClosed.TabIndex = 160
        Me.chkInvoiceClosed.Text = "EDIT/DELETE CLOSED INVOICES "
        '
        'lblClosed
        '
        Me.lblClosed.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClosed.ForeColor = System.Drawing.Color.Red
        Me.lblClosed.Location = New System.Drawing.Point(8, 10)
        Me.lblClosed.Name = "lblClosed"
        Me.lblClosed.Size = New System.Drawing.Size(490, 20)
        Me.lblClosed.TabIndex = 161
        Me.lblClosed.Text = "CLOSED INVOICES - warning changes must be approved."
        '
        'frmInvoicingList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(952, 620)
        Me.Controls.Add(Me.lblClosed)
        Me.Controls.Add(Me.chkInvoiceClosed)
        Me.Controls.Add(Me.btnClosedJobTicket)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnOpenJobTicket)
        Me.Controls.Add(Me.btnCreateManual)
        Me.Controls.Add(Me.dgJobBoard)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmInvoicingList"
        Me.Text = "frmInvoicinglist"
        CType(Me.dgJobBoard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public newForm As frmJobTicket
    Public newForm1 As frmInvoice
    Dim rowC As Integer = 0
    Public Shared jobID As Integer

    Private Sub frmInvoicingList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Me.populateDatagrid(Me.chkInvoiceClosed.Checked)
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Function populateDatagrid(ByVal ClosedFlag As Boolean)

        Dim ds As DataSet
        Dim sqlStr As String

        Try
            If ClosedFlag = False Then
                sqlStr = "SELECT tblJobTickets.JobTicketID, tblJobTickets.JobTicketNo, (tblGenerators.GeneratorName + ', ' + tblGenerators.JobSiteCity) as GeneratorName, GNo, tblProducts.ProductName, tblGenerators.JobSite as CustomerName, tblJobTickets.ScheduleDate, tblJobTickets.JobTicketSubmitted, IIF(tblJobTickets.JobTicketSubmitted, tblJobTickets.TicketNo, 'Enter') as JobTicketText, tblJobTickets.InvoiceCreated,  IIF(Len(tblInvoicing.InvoiceNo) <> 0,InvoiceNo,'New') as InvoiceText, tblJobTickets.Closed FROM (((tblJobTickets INNER JOIN tblProducts ON tblJobTickets.ProductID = tblProducts.ProductID) INNER JOIN tblGenerators ON tblProducts.GeneratorID = tblGenerators.GeneratorID) LEFT OUTER JOIN tblInvoicing ON tblJobTickets.JobTicketID = tblInvoicing.JobTicketID) WHERE tblJobTickets.Closed = False AND tblJobTickets.IsCancelled = False AND tblJobTickets.JobClosed = TRUE"
            ElseIf ClosedFlag = True Then
                sqlStr = "SELECT tblJobTickets.JobTicketID, tblJobTickets.JobTicketNo, (tblGenerators.GeneratorName + ', ' + tblGenerators.JobSiteCity) as GeneratorName, GNo, tblProducts.ProductName, tblGenerators.JobSite as CustomerName, tblJobTickets.ScheduleDate, tblJobTickets.JobTicketSubmitted, IIF(tblJobTickets.JobTicketSubmitted, tblJobTickets.TicketNo, 'Enter') as JobTicketText, tblJobTickets.InvoiceCreated,  IIF(Len(tblInvoicing.InvoiceNo) <> 0,InvoiceNo,'New') as InvoiceText, tblJobTickets.Closed FROM (((tblJobTickets INNER JOIN tblProducts ON tblJobTickets.ProductID = tblProducts.ProductID) INNER JOIN tblGenerators ON tblProducts.GeneratorID = tblGenerators.GeneratorID) LEFT OUTER JOIN tblInvoicing ON tblJobTickets.JobTicketID = tblInvoicing.JobTicketID) WHERE tblJobTickets.Closed = True AND tblJobTickets.IsCancelled = False AND tblJobTickets.JobClosed = TRUE"
            End If

            ' make the dataGrid use our new tablestyle
            dgJobBoard.TableStyles.Clear()
            Dim ts_dgJobBoard = New System.Windows.Forms.DataGridTableStyle
            ds = DBHelper.GetDataSet(sqlStr, "tblJobTickets")
            'Define run-time Datagrid
            '
            'ts_dgJobBoard
            '
            ts_dgJobBoard.AlternatingBackColor = System.Drawing.Color.Silver
            ts_dgJobBoard.GridLineColor = System.Drawing.Color.Black
            ts_dgJobBoard.HeaderBackColor = System.Drawing.Color.LightSteelBlue
            ts_dgJobBoard.HeaderFont = New System.Drawing.Font("Verdana", 10.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                            Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ts_dgJobBoard.HeaderForeColor = System.Drawing.SystemColors.ControlText
            ts_dgJobBoard.MappingName = "tblJobTickets"
            ts_dgJobBoard.RowHeadersVisible = True
            Me.DefineColumnStyles(ds.Tables(0).Rows.Count, ts_dgJobBoard)
            ' make the dataGrid use our new tablestyle and bind it to our table
            dgJobBoard.TableStyles.Clear()
            dgJobBoard.TableStyles.Add(ts_dgJobBoard)
            'bind the table to the datagrid
            Me.dgJobBoard.DataSource = ds
            Me.dgJobBoard.DataMember = "tblJobTickets"
            Me.dgJobBoard.Refresh()

            Me.rowC = ds.Tables(0).Rows.Count
            If Me.rowC = 0 Then Me.dgJobBoard.ReadOnly = True Else Me.dgJobBoard.ReadOnly = False

        Catch ex As SystemException

            MsgBox(ex.Message, MsgBoxStyle.Information, "Error ocurred")

        End Try

    End Function


    Function DefineColumnStyles(ByVal rCount As Integer, ByRef ts_dgJobBoard As DataGridTableStyle) As System.Windows.Forms.DataGridTableStyle

        Dim col_dgJobBoard_J = New System.Windows.Forms.DataGridTextBoxColumn
        Dim col_dgJobBoard_JTID = New System.Windows.Forms.DataGridTextBoxColumn
        Dim col_dgJobBoard_G = New System.Windows.Forms.DataGridTextBoxColumn
        Dim col_dgJobBoard_P = New System.Windows.Forms.DataGridTextBoxColumn
        Dim col_dgJobBoard_PD = New System.Windows.Forms.DataGridTextBoxColumn
        Dim col_dgJobBoard_GNo = New System.Windows.Forms.DataGridTextBoxColumn
        Dim col_dgJobBoard_Cust = New System.Windows.Forms.DataGridTextBoxColumn
        '
        'col_dgJobBoard_J # 1
        '
        col_dgJobBoard_JTID.Format = ""
        col_dgJobBoard_JTID.FormatInfo = Nothing
        col_dgJobBoard_JTID.HeaderText = "JobTicketID"
        col_dgJobBoard_JTID.MappingName = "JobTicketID"
        col_dgJobBoard_JTID.NullText = ""
        col_dgJobBoard_JTID.ReadOnly = True
        col_dgJobBoard_JTID.Width = 0
        ts_dgJobBoard.GridColumnStyles.Add(col_dgJobBoard_JTID)
        '
        'col_dgJobBoard_G #2
        '
        col_dgJobBoard_G.Format = ""
        col_dgJobBoard_G.FormatInfo = Nothing
        col_dgJobBoard_G.HeaderText = "Generator"
        col_dgJobBoard_G.MappingName = "GeneratorName"
        col_dgJobBoard_G.NullText = ""
        col_dgJobBoard_G.ReadOnly = True
        col_dgJobBoard_G.Width = 210
        ts_dgJobBoard.GridColumnStyles.Add(col_dgJobBoard_G)
        '
        'col_dgJobBoard_P #4
        '
        col_dgJobBoard_Cust.Format = ""
        col_dgJobBoard_Cust.FormatInfo = Nothing
        col_dgJobBoard_Cust.HeaderText = "Customer Name"
        col_dgJobBoard_Cust.MappingName = "CustomerName"
        col_dgJobBoard_Cust.NullText = ""
        col_dgJobBoard_Cust.ReadOnly = True
        col_dgJobBoard_Cust.Width = 200
        ts_dgJobBoard.GridColumnStyles.Add(col_dgJobBoard_Cust)
        'col_dgJobBoard_P #3
        '
        col_dgJobBoard_P.Format = ""
        col_dgJobBoard_P.FormatInfo = Nothing
        col_dgJobBoard_P.HeaderText = "Product"
        col_dgJobBoard_P.MappingName = "ProductName"
        col_dgJobBoard_P.NullText = ""
        col_dgJobBoard_P.ReadOnly = True
        col_dgJobBoard_P.Width = 190
        ts_dgJobBoard.GridColumnStyles.Add(col_dgJobBoard_P)
        '

        '
        'col_dgJobBoard_PD #5
        '
        col_dgJobBoard_PD.Format = ""
        col_dgJobBoard_PD.FormatInfo = Nothing
        col_dgJobBoard_PD.HeaderText = "Sch. Date"
        col_dgJobBoard_PD.MappingName = "ScheduleDate"
        col_dgJobBoard_PD.NullText = ""
        col_dgJobBoard_PD.Width = 85
        col_dgJobBoard_PD.ReadOnly = True
        ts_dgJobBoard.GridColumnStyles.Add(col_dgJobBoard_PD)
        '
        'col_dgJobBoard_JTC #6
        '
        Dim col_dgJobBoard_JTC As DataGridBoolColumn = New DataGridBoolColumn
        col_dgJobBoard_JTC.ReadOnly = True
        col_dgJobBoard_JTC.NullValue = False
        col_dgJobBoard_JTC.HeaderText = "JobTicketSubmitted"
        col_dgJobBoard_JTC.MappingName = "JobTicketSubmitted"
        col_dgJobBoard_JTC.NullText = "False"
        col_dgJobBoard_JTC.Width = 0
        ts_dgJobBoard.GridColumnStyles.Add(col_dgJobBoard_JTC)
        '
        '#7
        '
        col_dgJobBoard_J.Format = ""
        col_dgJobBoard_J.FormatInfo = Nothing
        col_dgJobBoard_J.HeaderText = "Job #"
        col_dgJobBoard_J.MappingName = "JobTicketText"
        col_dgJobBoard_J.NullText = ""
        col_dgJobBoard_J.ReadOnly = True
        col_dgJobBoard_J.Width = 80
        ts_dgJobBoard.GridColumnStyles.Add(col_dgJobBoard_J)

        'col_dgJobBoard_JT

        'Dim col_dgJobBoard_JT As DataGridButtonColumn = New DataGridButtonColumn(5)
        'col_dgJobBoard_JT.Format = ""
        'col_dgJobBoard_JT.InitializeRowCount(rCount)
        'col_dgJobBoard_JT.FormatInfo = Nothing
        'col_dgJobBoard_JT.HeaderText = "Job Ticket"
        'col_dgJobBoard_JT.MappingName = "JobTicketText"
        'col_dgJobBoard_JT.NullText = "Enter"
        'col_dgJobBoard_JT.Width = 0
        'col_dgJobBoard_JT.Alignment = HorizontalAlignment.Center
        'ts_dgJobBoard.GridColumnStyles.Add(col_dgJobBoard_JT)
        '
        'col_dgJobBoard_I '#8
        '
        Dim col_dgJobBoard_I As DataGridButtonColumn = New DataGridButtonColumn(6)
        col_dgJobBoard_I.InitializeRowCount(rCount)
        col_dgJobBoard_I.Format = ""
        col_dgJobBoard_I.FormatInfo = Nothing
        col_dgJobBoard_I.HeaderText = "Invoice"
        col_dgJobBoard_I.MappingName = "InvoiceText"
        col_dgJobBoard_I.NullText = "Create"
        col_dgJobBoard_I.Width = 50
        col_dgJobBoard_I.Alignment = HorizontalAlignment.Center
        ts_dgJobBoard.GridColumnStyles.Add(col_dgJobBoard_I)
        '
        'col_dgJobBoard_C '#9
        '
        Dim col_dgJobBoard_C As DataGridBoolColumn = New DataGridBoolColumn
        col_dgJobBoard_C.ReadOnly = False
        col_dgJobBoard_C.NullValue = False
        col_dgJobBoard_C.HeaderText = "Close"
        col_dgJobBoard_C.MappingName = "Closed"
        col_dgJobBoard_C.NullText = "False"
        col_dgJobBoard_C.Width = 55
        col_dgJobBoard_C.TrueValue = True
        col_dgJobBoard_C.AllowNull = False
        ts_dgJobBoard.GridColumnStyles.Add(col_dgJobBoard_C)
        '
        'col_dgJobBoard_IC '10
        '
        Dim col_dgJobBoard_IC As DataGridBoolColumn = New DataGridBoolColumn
        col_dgJobBoard_IC.ReadOnly = False
        col_dgJobBoard_IC.NullValue = False
        col_dgJobBoard_IC.HeaderText = "Created"
        col_dgJobBoard_IC.MappingName = "InvoiceCreated"
        col_dgJobBoard_IC.NullText = "False"
        col_dgJobBoard_IC.Width = 0
        col_dgJobBoard_IC.TrueValue = True
        col_dgJobBoard_IC.AllowNull = False
        ts_dgJobBoard.GridColumnStyles.Add(col_dgJobBoard_IC)
        '
        'col_dgJobBoard_JTID
        '


        'col_dgJobBoard_GNo '11
        '
        col_dgJobBoard_GNo.Format = ""
        col_dgJobBoard_GNo.FormatInfo = Nothing
        col_dgJobBoard_GNo.HeaderText = "JobTicketNo"
        col_dgJobBoard_GNo.MappingName = "JobTicketNo"
        col_dgJobBoard_GNo.NullText = ""
        col_dgJobBoard_GNo.ReadOnly = True
        col_dgJobBoard_GNo.Width = 0
        ts_dgJobBoard.GridColumnStyles.Add(col_dgJobBoard_GNo)

    End Function


    Private Sub HandleCellButtonClick(ByVal whatVal As String, ByVal cellVal As String)

        If CStr(whatVal).ToUpper = "TRUE" Then
            If IsNothing(newForm1) = False Then
                newForm1 = Nothing
            End If
            newForm1 = New frmInvoice(Me.chkInvoiceClosed.Checked)
            newForm1.lblReqField.Text = cellVal
            newForm1.lblWhatForm.Text = "frmInvoicingList"
            newForm1.Owner = Me
            newForm1.ShowDialog()
        Else
            If IsNothing(newForm1) = False Then
                newForm1 = Nothing
            End If
            newForm1 = New frmInvoice(Me.chkInvoiceClosed.Checked)
            newForm1.lblReqField.Text = cellVal
            newForm1.lblWhatForm.Text = "frmInvoicingList"
            newForm1.Owner = Me
            newForm1.ShowDialog()
        End If

    End Sub

    Private Sub frmInvoicingList_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Me.chkInvoiceClosed.Checked = True Then Exit Sub
        Dim i As Integer = 0, iVal As Boolean = False, strSQL As String, jtID As Long = 0
        ' Me.dgJobBoard_CurrentCellChanged(Me.dgJobBoard, e)
        For i = 0 To rowC - 1
            iVal = False
            jtID = 0
            iVal = Me.dgJobBoard.Item(i, 8)
            jtID = Me.dgJobBoard.Item(i, 0)
            If iVal = True And jtID > 0 Then
                strSQL = "UPDATE tblJobTickets SET Closed=TRUE WHERE JobTicketID=" & jtID
                DBHelper.ExecuteQuery(strSQL)
            End If
        Next

    End Sub

    Private Sub dgJobBoard_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgJobBoard.CurrentCellChanged

        Try
            If Me.dgJobBoard.CurrentCell.RowNumber < rowC Then
                dgJobBoard.TableStyles.Item(0).GridColumnStyles.Item(7).ReadOnly = False
                If Me.dgJobBoard.CurrentCell.ColumnNumber = 7 Then
                    If CStr(Me.dgJobBoard.Item(Me.dgJobBoard.CurrentCell.RowNumber, 9)).ToUpper = "TRUE" Then
                        dgJobBoard.TableStyles.Item(0).GridColumnStyles.Item(7).ReadOnly = False
                    Else
                        dgJobBoard.TableStyles.Item(0).GridColumnStyles.Item(7).ReadOnly = False
                    End If
                End If
                jobID = Me.dgJobBoard.Item(Me.dgJobBoard.CurrentCell.RowNumber, 0)
            Else
                dgJobBoard.TableStyles.Item(0).GridColumnStyles.Item(6).ReadOnly = True
                dgJobBoard.TableStyles.Item(0).GridColumnStyles.Item(7).ReadOnly = True
                dgJobBoard.TableStyles.Item(0).GridColumnStyles.Item(8).ReadOnly = True
                dgJobBoard.TableStyles.Item(0).GridColumnStyles.Item(9).ReadOnly = True
            End If
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dgJobBoard_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgJobBoard.Click

        If Me.dgJobBoard.CurrentCell.RowNumber > Me.rowC Then Exit Sub
        If Me.dgJobBoard.CurrentCell.ColumnNumber <> 6 And Me.dgJobBoard.CurrentCell.ColumnNumber <> 7 Then Exit Sub

        If Me.dgJobBoard.CurrentCell.ColumnNumber = 7 Then
            If CStr(Me.dgJobBoard.Item(Me.dgJobBoard.CurrentCell.RowNumber, 5)).ToUpper = "TRUE" Then
                Me.HandleCellButtonClick("TRUE", Me.dgJobBoard.Item(Me.dgJobBoard.CurrentCell.RowNumber, 10))
            End If
        Else
            Me.HandleCellButtonClick("NONE", Me.dgJobBoard.Item(Me.dgJobBoard.CurrentCell.RowNumber, 10))
        End If

    End Sub

    Private Sub btnCreateManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateManual.Click

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim newMForm As New frmManualJobTicket
        newMForm.Owner = Me
        newMForm.ShowDialog()
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub
    Private Sub btnOpenJobTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenJobTicket.Click
        Dim JobId As Integer
        If IsDBNull(Me.dgJobBoard.Item(Me.dgJobBoard.CurrentRowIndex, 0)) = False AndAlso (Me.dgJobBoard.Item(Me.dgJobBoard.CurrentRowIndex, 0)) > 0 Then
            JobId = Me.dgJobBoard.Item(Me.dgJobBoard.CurrentRowIndex, 0)
        Else
            JobId = 0
        End If
        Dim strSQL As String
        If JobId > 0 Then
            strSQL = "UPDATE tblJobTickets SET JobClosed=False, Closed = False WHERE JobTicketID=" & JobId
            'If DBHelper.ExecuteQuery(strSQL) Then Me.populateDatagrid(Me.chkInvoiceClosed.Checked)
            DBHelper.ExecuteQuery(strSQL)
        End If
    End Sub

    Private Sub btnClosedJobTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClosedJobTicket.Click
        Dim i As Integer = 0, iVal As Boolean = False, strSQL As String, jtID As Long = 0
        For i = 0 To rowC - 1
            iVal = False
            jtID = 0
            iVal = Me.dgJobBoard.Item(i, 8)
            jtID = Me.dgJobBoard.Item(i, 0)
            If iVal = True And jtID > 0 Then
                strSQL = "UPDATE tblJobTickets SET Closed=TRUE WHERE JobTicketID=" & jtID
                DBHelper.ExecuteQuery(strSQL)
            End If
        Next
        Me.populateDatagrid(Me.chkInvoiceClosed.Checked)
    End Sub

    Private Sub chkInvoiceClosed_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkInvoiceClosed.CheckedChanged
        Me.populateDatagrid(Me.chkInvoiceClosed.Checked)
        Me.btnClosedJobTicket.Visible = Not Me.chkInvoiceClosed.Checked
        Me.lblClosed.Visible = Me.chkInvoiceClosed.Checked
    End Sub
End Class
