Option Strict Off
Option Explicit On 

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms

Namespace DataGridButton

    '///Inherited Datagrid Button Style
    Public Class DataGridButtonColumn
        'Inherits DataGridButton
        Inherits DataGridTextBoxColumn
        Public Event CellButtonClicked As DataGridCellButtonClickEventHandler

        Private _columnNum As Integer
        Private _pressedRow As Integer
        Private _RowCount As Integer

        Public Sub New(ByVal colNum As Integer)
            _columnNum = colNum
            _pressedRow = -1
        End Sub 'New

        Public Sub InitializeRowCount(ByVal rCount As Integer)
            _RowCount = rCount
        End Sub

        Private Sub DrawButton(ByVal g As Graphics, ByVal bounds As Rectangle, ByVal row As Integer)

            Dim dg As DataGrid = Me.DataGridTableStyle.DataGrid
            Dim s As String = dg(row, Me._columnNum).ToString()

            Dim sz As SizeF = g.MeasureString(s, dg.Font, bounds.Width - 4, StringFormat.GenericTypographic)

            Dim x As Integer = bounds.Left + Math.Max(0, (bounds.Width - sz.Width) / 2)
            g.DrawRectangle(New Pen(New SolidBrush(Color.SteelBlue)), bounds)

            If (sz.Height < bounds.Height) Then
                Dim y As Integer = bounds.Top + (bounds.Height - sz.Height) / 2
                g.DrawString(s, dg.Font, New SolidBrush(Color.White), x, y)
            End If

        End Sub

        Protected Overloads Overrides Sub Edit(ByVal [source] As System.Windows.Forms.CurrencyManager, ByVal rowNum As Integer, ByVal bounds As System.Drawing.Rectangle, ByVal [readOnly] As Boolean, ByVal instantText As String, ByVal cellIsVisible As Boolean)
        End Sub 'Edit

        Public Sub HandleMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)

            If e.Button = MouseButtons.Left Then


                '                If Not (e.X >= Me.DataGridTableStyle.DataGrid.Left And e.X <= (Me.DataGridTableStyle.DataGrid.Left + Me.DataGridTableStyle.DataGrid.Width) And e.Y >= Me.DataGridTableStyle.DataGrid.Top And e.Y <= (Me.DataGridTableStyle.DataGrid.Top + Me.DataGridTableStyle.DataGrid.Height)) Then
                '               Exit Sub
                '          End If
                MsgBox(e.Clicks)
                Dim dg As DataGrid = Me.DataGridTableStyle.DataGrid
                Dim hti As DataGrid.HitTestInfo = dg.HitTest(New Point(e.X, e.Y))
                Dim isClickInCell As Boolean = (hti.Column = Me._columnNum And hti.Row > -1)
                _pressedRow = -1
                If hti.Row >= _RowCount Then Exit Sub
                Dim rect As New Rectangle(0, 0, 0, 0)
                If isClickInCell Then
                    rect = dg.GetCellBounds(hti.Row, hti.Column)
                    isClickInCell = (e.X >= rect.Left And e.X <= rect.Right) And (e.Y >= rect.Top And e.Y <= rect.Bottom)
                End If
                If isClickInCell Then
                    Dim g As Graphics = Graphics.FromHwnd(dg.Handle)
                    If dg.Name = "dgPaperwork" Then
                        RaiseEvent CellButtonClicked(Me, New DataGridCellButtonClickEventArgs(hti.Row, hti.Column), "None", dg.Item(hti.Row, 0))
                        g.FillRectangle(New SolidBrush(Color.Black), rect)
                        g.Dispose()
                    ElseIf dg.Name = "dgLabData" Then
                        RaiseEvent CellButtonClicked(Me, New DataGridCellButtonClickEventArgs(hti.Row, hti.Column), "None", dg.Item(hti.Row, 0))
                        g.FillRectangle(New SolidBrush(Color.Black), rect)
                        g.Dispose()
                    Else
                        If CStr(dg.Item(hti.Row, hti.Column)).ToUpper = "TRUE" Or CStr(dg.Item(hti.Row, hti.Column)).ToUpper = "FALSE" Then
                            If CStr(dg.Item(hti.Row, 4)).ToUpper = "TRUE" Then
                                RaiseEvent CellButtonClicked(Me, New DataGridCellButtonClickEventArgs(hti.Row, hti.Column), dg.Item(hti.Row, hti.Column), dg.Item(hti.Row, 5))
                                g.FillRectangle(New SolidBrush(Color.Black), rect)
                                g.Dispose()
                            End If
                        Else
                            RaiseEvent CellButtonClicked(Me, New DataGridCellButtonClickEventArgs(hti.Row, hti.Column), "None", dg.Item(hti.Row, 5))
                            g.FillRectangle(New SolidBrush(Color.Black), rect)
                            g.Dispose()
                        End If
                    End If
                End If

            End If


        End Sub 'HandleMouseUp

        Protected Overloads Overrides Sub Paint(ByVal g As System.Drawing.Graphics, ByVal bounds As System.Drawing.Rectangle, ByVal [source] As System.Windows.Forms.CurrencyManager, ByVal rowNum As Integer, ByVal backBrush As System.Drawing.Brush, ByVal foreBrush As System.Drawing.Brush, ByVal alignToRight As Boolean)

            Dim parent As DataGrid = Me.DataGridTableStyle.DataGrid
            Dim current As Boolean = parent.IsSelected(rowNum) Or (parent.CurrentRowIndex = rowNum And parent.CurrentCell.ColumnNumber = Me._columnNum)

            'clear the cell
            g.FillRectangle(New SolidBrush(Color.SteelBlue), bounds)

            'draw the value
            Dim s As String = Me.GetColumnValueAtRow([source], rowNum).ToString()
            g.DrawString(s, parent.Font, New SolidBrush(Color.White), bounds.X, bounds.Y)

        End Sub

    End Class 'DataGridButtonColumn

    Public Class DataGridCellButtonClickEventArgs
        Inherits EventArgs
        Private _row As Integer
        Private _col As Integer

        Public Sub New(ByVal row As Integer, ByVal col As Integer)
            _row = row
            _col = col
        End Sub 'New

        Public ReadOnly Property RowIndex() As Integer
            Get
                Return _row
            End Get
        End Property

        Public ReadOnly Property ColIndex() As Integer
            Get
                Return _col
            End Get
        End Property
    End Class 'DataGridCellButtonClickEventArgs

    Public Delegate Sub DataGridCellButtonClickEventHandler(ByVal sender As Object, ByVal e As DataGridCellButtonClickEventArgs, ByVal whatVal As String, ByVal cellVal As String)

End Namespace