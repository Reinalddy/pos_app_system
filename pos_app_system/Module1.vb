Imports System.Data.OleDb

Module Module1
    Public CONN As OleDbConnection
    Public DA As OleDbDataAdapter
    Public Ds As DataSet
    Public Cmd As OleDbCommand
    Public RD As OleDbDataReader

    Public Sub Koneksi()
        CONN = New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=Database4.mdb")
        CONN.Open()
    End Sub

End Module
