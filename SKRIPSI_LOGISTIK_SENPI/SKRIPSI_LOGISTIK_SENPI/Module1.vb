Imports System.Data.Odbc
Module Module1
    Public Conn As OdbcConnection
    Public Cmd As OdbcCommand
    Public Rd As OdbcDataAdapter
    Public Ds As DataSet
    Public Dr As OdbcDataReader
    Public Str As String

    Sub koneksi()
        Dim str As String = "Driver={Mysql ODBC 8.0 ANSI Driver};Database=db_logistik_kompi;server=localhost;uid=root"
        Conn = New OdbcConnection(str)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        Else
            MsgBox("Koneksi Gagal")
        End If
    End Sub
End Module
