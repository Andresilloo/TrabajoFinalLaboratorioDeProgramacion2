Public Class frm15agregarAutor
    Private Sub btnGrabarAutor_Click(sender As Object, e As EventArgs) Handles btnGrabarAutor.Click
        GrabarAutor()
    End Sub

    Private Sub GrabarAutor()
        Try
            Dim InstruccionSQL As String = ""
            InstruccionSQL = "INSERT INTO Autor (nombre) values('" + txtAutor.Text + "')"

            Conexion.ConnectionString = CadenaConexion
            Conexion.Open()

            Comando.Connection = Conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = InstruccionSQL
            Comando.ExecuteReader()


            Conexion.Close()
            MessageBox.Show("Dato Grabado")
        Catch
            Conexion.Close()
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
End Class