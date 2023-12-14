Public Class frm14agregarPais
    Private Sub btnGrabarPais_Click(sender As Object, e As EventArgs) Handles btnGrabarPais.Click
        GrabarPais()
    End Sub

    Private Sub GrabarPais()
        Try
            Dim InstruccionSQL As String = ""
            InstruccionSQL = "INSERT INTO Pais (nombre) values('" + txtPais.Text + "')"

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