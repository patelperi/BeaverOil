Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Data.OleDb
Imports BeaverOil.INIFile
Imports System.Collections.Specialized.NameValueCollection
Imports System.Configuration.ConfigurationSettings

Public NotInheritable Class DBHelper

    'Public Shared MDB_FileLocation As String = System.Configuration.ConfigurationSettings.AppSettings("MDB_FileLocation")
    'Public Shared MDB_FileLocation As String = Application.StartupPath & System.Configuration.ConfigurationSettings.AppSettings("MDB_FileLocation")
    Public Shared MDB_FileLocation As String = System.Configuration.ConfigurationSettings.AppSettings("MDB_FileLocation")

    'Public Shared Analytical_Files_Location As String = System.Configuration.ConfigurationSettings.AppSettings("Analytical_Files_Location")
    'Public Shared Analytical_Files_Location As String = Application.StartupPath & System.Configuration.ConfigurationSettings.AppSettings("Analytical_Files_Location")
    Public Shared Analytical_Files_Location As String = System.Configuration.ConfigurationSettings.AppSettings("Analytical_Files_Location")

    Public Shared ConnStr As String = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Data Source=""" & MDB_FileLocation & """;Mod" & _
        "e=Share Deny None;Jet OLEDB:Engine Type=5;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet" & _
        " OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=False;Extended" & _
        " Properties=;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:Encrypt Da" & _
        "tabase=False;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale " & _
        "on Compact=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1"

    Public Shared USERID As String = "admin"
    Public Shared PWD As String = ""
   

    '****************************************************************
    Public Shared Function Connect() As OleDbConnection
        Return New OleDbConnection(ConnStr)
    End Function

    '****************************************************************
    Public Shared Function GetDataSet(ByVal sql As String, ByVal tblName As String) As DataSet
        Dim objconn As OleDbConnection = Nothing
        Try
            objconn = New OleDbConnection(ConnStr)
            Dim da As New OleDbDataAdapter(sql, objconn)
            Dim ds As New DataSet
            da.Fill(ds, tblName)
            Return ds
        Catch err As SystemException
            MsgBox(err.Message)
            'Return Nothing
        Finally
            If objconn Is Nothing Then
            ElseIf objconn.State = ConnectionState.Open Then
                objconn.Close()
            End If
        End Try
    End Function

    '****************************************************************
    Public Shared Function GetDataSetByREF(ByRef ds As DataSet, ByVal sql As String, ByVal tblName As String)
        Dim objconn As OleDbConnection = Nothing
        Try
            objconn = New OleDbConnection(ConnStr)
            Dim da As New OleDbDataAdapter(sql, objconn)
            da.Fill(ds, tblName)
        Catch err As SystemException
            MsgBox(err.Message)
        Finally
            If objconn Is Nothing Then
            ElseIf objconn.State = ConnectionState.Open Then
                objconn.Close()
            End If
        End Try
    End Function

    '**************************************************************************************************************************************
    Public Shared Function GetDataSetTableDirect(ByVal TableName As String) As DataSet

        Dim Conn As OleDbConnection = Nothing

        Try
            Conn = New OleDbConnection(ConnStr)

            Dim cmdPSelect As New OleDbCommand
            cmdPSelect.Connection = Conn
            cmdPSelect.CommandType = CommandType.TableDirect
            cmdPSelect.CommandText = TableName

            If Conn.State = ConnectionState.Closed Then Conn.Open()

            Dim DASelect As New OleDbDataAdapter(cmdPSelect)
            Dim DSSelect As New DataSet
            DASelect.Fill(DSSelect)
            Return DSSelect

        Catch err As SystemException
            Return Nothing

        Finally

            If Conn Is Nothing Then
            ElseIf Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If

        End Try

    End Function

    '****************************************************************
    Public Shared Function GetRecordCount(ByVal sql As String) As Integer
        Dim objconn As OleDbConnection = Nothing

        Try
            objconn = New OleDbConnection(ConnStr)
            Dim da As New OleDbDataAdapter(sql, objconn)
            Dim ds As New DataSet
            da.Fill(ds)
            If ds.Tables(0).Rows.Count = 0 Then
                Return 0
            Else
                Return ds.Tables(0).Rows(0).Item(0)
            End If
        Catch err As SystemException
            MsgBox(err.Message)
            'Return Nothing
        Finally
            If objconn Is Nothing Then
            ElseIf objconn.State = ConnectionState.Open Then
                objconn.Close()
            End If
        End Try
    End Function

    '****************************************************************
    Public Shared Function GetInteger(ByVal sql As String) As Integer
        Dim objconn As OleDbConnection = Nothing
        Try
            objconn = New OleDbConnection(ConnStr)
            Dim da As New OleDbDataAdapter(sql, objconn)
            Dim ds As New DataSet
            da.Fill(ds)
            If ds.Tables(0).Rows.Count < 0 Then
                Return 0
            ElseIf IsDBNull(ds.Tables(0).Rows(0).Item(0)) Then
                Return 0
            Else
                Return ds.Tables(0).Rows(0).Item(0)
            End If

        Catch err As SystemException
            MsgBox(err.Message)
            Return 0
            'Return Nothing
        Finally
            If objconn Is Nothing Then
            ElseIf objconn.State = ConnectionState.Open Then
                objconn.Close()
            End If
        End Try
    End Function
    '****************************************************************
    Public Shared Function GetDecimal(ByVal sql As String) As Decimal
        Dim objconn As OleDbConnection = Nothing

        Try
            objconn = New OleDbConnection(ConnStr)
            Dim da As New OleDbDataAdapter(sql, objconn)
            Dim ds As New DataSet
            da.Fill(ds)
            If ds.Tables(0).Rows.Count < 0 Then
                Return 0
            ElseIf IsDBNull(ds.Tables(0).Rows(0).Item(0)) Then
                Return 0
            Else
                Return ds.Tables(0).Rows(0).Item(0)
            End If

        Catch err As SystemException
            MsgBox(err.Message)
            Return 0
            'Return Nothing
        Finally
            If objconn Is Nothing Then
            ElseIf objconn.State = ConnectionState.Open Then
                objconn.Close()
            End If
        End Try
    End Function

    '****************************************************************
    Public Shared Function GetStringVar(ByVal sql As String) As String
        Dim objconn As OleDbConnection = Nothing
        Try
            objconn = New OleDbConnection(ConnStr)
            Dim da As New OleDbDataAdapter(sql, objconn)
            Dim ds As New DataSet
            da.Fill(ds)
            If ds.Tables(0).Rows.Count < 0 Then
                Return ""
            ElseIf IsDBNull(ds.Tables(0).Rows(0).Item(0)) Then
                Return ""
            Else
                Return ds.Tables(0).Rows(0).Item(0)
            End If

        Catch err As SystemException
            MsgBox(err.Message)
            Return 0
        Finally
            If objconn Is Nothing Then
            ElseIf objconn.State = ConnectionState.Open Then
                objconn.Close()
            End If
        End Try
    End Function

    '**************************************************************************************************************************************
    Public Shared Function ExecuteQuery(ByVal CommandText As String) As Boolean

        Dim Conn As OleDbConnection = Nothing

        Try
            Conn = New OleDbConnection(ConnStr)
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            Dim cmdPSelect As OleDbCommand = New OleDbCommand(CommandText, Conn)

            cmdPSelect.ExecuteNonQuery()

            ExecuteQuery = True

        Catch err As SystemException

            MsgBox(err.Message, MsgBoxStyle.Critical, "Error")
            ExecuteQuery = False

        Finally

            If Conn Is Nothing Then
            ElseIf Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If

        End Try

    End Function

    Public Shared Sub Authenticate(ByRef SelectReport As ReportDocument)

        Dim myTable As CrystalDecisions.CrystalReports.Engine.Table
        Dim myLogin As CrystalDecisions.Shared.TableLogOnInfo

        For Each myTable In SelectReport.Database.Tables
            myLogin = myTable.LogOnInfo
            myLogin.ConnectionInfo.Password = DBHelper.PWD
            myLogin.ConnectionInfo.UserID = DBHelper.USERID
            myTable.ApplyLogOnInfo(myLogin)
        Next

    End Sub

    Public Shared Function GenerateReport(ByRef SelectReport As ReportDocument) As System.IO.MemoryStream

        Authenticate(SelectReport)
        Return SelectReport.ExportToStream(ExportFormatType.PortableDocFormat)

    End Function

End Class