'///Inherited Datagrid Column Style
Public Class DataGridComboBoxColumn

    Inherits DataGridColumnStyle
    Private cboDatagrid As New ComboBox
    ' The isEditing field tracks whether or not the user is
    ' editing data with the hosted control.
    Private isEditing As Boolean
    Private isReadOnly As Boolean

    Public Sub New()
        cboDatagrid.DropDownStyle = ComboBoxStyle.DropDown
        cboDatagrid.Visible = False

    End Sub

    Protected Overrides Sub Abort(ByVal rowNum As Integer)
        isEditing = False
        RemoveHandler cboDatagrid.SelectedValueChanged, AddressOf cboSelectedValueChanged
        Invalidate()
    End Sub

    Protected Overrides Function Commit(ByVal dataSource As CurrencyManager, ByVal rowNum As Integer) As Boolean
        cboDatagrid.Bounds = Rectangle.Empty

        AddHandler cboDatagrid.SelectedValueChanged, AddressOf cboSelectedValueChanged

        If Not isEditing Then
            Return True
        End If
        isEditing = False

        Try
            Dim value As String = cboDatagrid.SelectedText     '.SelectedIndex   '.SelectedIndex   '.SelectedItem   '.SelectedText   '.Text
            SetColumnValueAtRow(dataSource, rowNum, value)
        Catch
        End Try

        Invalidate()
        Return True
    End Function

    Protected Overloads Overrides Sub Edit(ByVal [source] As CurrencyManager, _
    ByVal rowNum As Integer, _
    ByVal bounds As Rectangle, _
    ByVal [readOnly] As Boolean, _
    ByVal instantText As String, _
    ByVal cellIsVisible As Boolean)


        'If CType(GetColumnValueAtRow([source], rowNum), String) = String.Empty Then
        '    MsgBox("enmpty")
        'End If
        '  instantText = 0
        Dim value As String = CType(GetColumnValueAtRow([source], rowNum), String)


        If cellIsVisible Then
            cboDatagrid.Bounds = New Rectangle(bounds.X + 2, bounds.Y + 2, bounds.Width - 2, bounds.Height - 2)

            cboDatagrid.Text = value
            cboDatagrid.Visible = True
            AddHandler cboDatagrid.SelectedValueChanged, AddressOf cboSelectedValueChanged
        Else
            cboDatagrid.Text = value
            cboDatagrid.Visible = False
        End If

        If cboDatagrid.Visible Then
            DataGridTableStyle.DataGrid.Invalidate(bounds)
        End If
    End Sub

    Protected Overrides Function GetPreferredSize(ByVal g As Graphics, ByVal value As Object) As Size
        Return New Size(100, cboDatagrid.PreferredHeight + 1)
    End Function

    Protected Overrides Function GetMinimumHeight() As Integer
        Return cboDatagrid.PreferredHeight + 1
    End Function

    Protected Overrides Function GetPreferredHeight(ByVal g As Graphics, ByVal value As Object) As Integer
        Return cboDatagrid.PreferredHeight + 1
    End Function

    Protected Overloads Overrides Sub Paint(ByVal g As Graphics, ByVal bounds As Rectangle, ByVal [source] As CurrencyManager, ByVal rowNum As Integer)
        Paint(g, bounds, [source], rowNum, False)
    End Sub

    Protected Overloads Overrides Sub Paint(ByVal g As Graphics, ByVal bounds As Rectangle, ByVal [source] As CurrencyManager, ByVal rowNum As Integer, ByVal alignToRight As Boolean)
        Paint(g, bounds, [source], rowNum, Brushes.Red, Brushes.Blue, alignToRight)
    End Sub

    Protected Overloads Overrides Sub Paint(ByVal g As Graphics, ByVal bounds As Rectangle, ByVal [source] As CurrencyManager, ByVal rowNum As Integer, ByVal backBrush As Brush, ByVal foreBrush As Brush, ByVal alignToRight As Boolean)
        Dim [date] As String = CType(GetColumnValueAtRow([source], rowNum), String)
        Dim rect As Rectangle = bounds
        g.FillRectangle(backBrush, rect)
        rect.Offset(0, 2)
        rect.Height -= 2
        g.DrawString([date].ToString(), Me.DataGridTableStyle.DataGrid.Font, foreBrush, RectangleF.FromLTRB(rect.X, rect.Y, rect.Right, rect.Bottom))
    End Sub

    Protected Overrides Sub SetDataGridInColumn(ByVal value As DataGrid)
        MyBase.SetDataGridInColumn(value)
        If Not (cboDatagrid.Parent Is Nothing) Then
            cboDatagrid.Parent.Controls.Remove(cboDatagrid)
        End If
        If Not (value Is Nothing) Then
            value.Controls.Add(cboDatagrid)
        End If
    End Sub
    Private Sub cboSelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.isEditing = True
        MyBase.ColumnStartedEditing(cboDatagrid)

    End Sub


End Class
