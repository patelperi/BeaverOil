Imports System.IO

Public NotInheritable Class INIFile

    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByRef lpReturnedString As String, ByVal nSize As Long, ByVal lpFileName As String) As Long

    Public Shared Function getConnectString() As String

        Dim strBuffer As String     '// Buffer set to hold the string returned from the INI file
        Dim lngReturn As Long       '// Captures the number of characters retrieved from the INI file
        Dim objF As IO.File
        Dim INIFileName As String = "ConnectSTR.ini"

        Try

            If objF.Exists(Application.StartupPath & "\" & INIFileName) Then
                '// Initialize the buffer
                strBuffer = ""
                '// Read in the value
                lngReturn = GetPrivateProfileString("BeaverOil", "ConnectString", "", strBuffer, Len(strBuffer), INIFileName)
                '// Return the results (chop off the excess)
                getConnectString = strBuffer
            Else
                '// Error 53 is File Not Found
                Err.Raise(53)
            End If
            '// Return the provided default value if the call didn't work
            If lngReturn = 0 Then
                Err.Raise(53)
                getConnectString = ""
            End If

        Catch ex As SystemException
            Err.Raise(Err.Number)
        Finally

        End Try

    End Function

End Class
