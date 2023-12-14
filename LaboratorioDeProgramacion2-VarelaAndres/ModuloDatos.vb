Imports System.Data.OleDb

Module ModuloDatos

    Public Conexion As New OleDbConnection
    Public Comando As New OleDbCommand
    Public DR As OleDbDataReader
    Public CadenaConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=LibreriaBD.mdb"

End Module
