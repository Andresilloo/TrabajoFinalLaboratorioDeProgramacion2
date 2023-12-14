Public Class frm16agregarIdioma
    Private Sub btnGrabarIdioma_Click(sender As Object, e As EventArgs) Handles btnGrabarIdioma.Click
        GrabarIdioma()
    End Sub

    Private Sub GrabarIdioma()
        Try
            Dim InstruccionSQL As String = ""
            InstruccionSQL = "INSERT INTO Idioma (nombre) values('" + txtIdioma.Text + "')"

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