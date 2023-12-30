Imports System.Data.OleDb

Module Module1
    Public CONN As OleDbConnection
    Public DA As OleDbDataAdapter
    Public Ds As DataSet
    Public Cmd As OleDbCommand
    Public RD As OleDbDataReader

    Public Sub Koneksi()
        CONN = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Iqbal TI\PemrogVisual\Kasir New\db\Database4.mdb")
        CONN.Open()
    End Sub

End Module
