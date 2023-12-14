Public Class frm20modificarIdioma
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Buscar()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        GrabarCambios()
    End Sub

    Private Sub Buscar()
        Dim nombre As String = BuscarIdioma(txtCodigo.Text)
        If nombre <> "" Then
            btnGrabar.Enabled = True
            txtIdioma.Enabled = True
            txtCodigo.Enabled = False
            txtIdioma.Text = nombre
        Else
            btnGrabar.Enabled = False
            txtIdioma.Enabled = False
            txtCodigo.Enabled = True
            txtIdioma.Text = nombre
            MessageBox.Show("El código no existe")
        End If
    End Sub

    Private Sub GrabarCambios()
        Dim InstruccionSQL As String
        InstruccionSQL = "update Idioma set Nombre = '"
        InstruccionSQL = InstruccionSQL + txtIdioma.Text
        InstruccionSQL = InstruccionSQL + "' where IdIdioma = "
        InstruccionSQL = InstruccionSQL + txtCodigo.Text

        Try
            Conexion.ConnectionString = CadenaConexion
            Conexion.Open()

            Comando.Connection = Conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = InstruccionSQL
            Comando.ExecuteReader()

            Conexion.Close()

            MessageBox.Show("Dato Modificado")
            btnBuscar.Enabled = True
            txtCodigo.Enabled = True
            txtIdioma.Enabled = False
            btnGrabar.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Function BuscarIdioma(Cod As Integer) As String
        Dim resultado As String = ""
        Dim conexionIdioma As New OleDb.OleDbConnection
        Dim comandoIdioma As New OleDb.OleDbCommand
        Dim DRIdioma As OleDb.OleDbDataReader

        conexionIdioma.ConnectionString = CadenaConexion
        conexionIdioma.Open()
        comandoIdioma.Connection = conexionIdioma
        comandoIdioma.CommandType = CommandType.TableDirect
        comandoIdioma.CommandText = "Idioma"
        DRIdioma = comandoIdioma.ExecuteReader

        If DRIdioma.HasRows Then
            While DRIdioma.Read
                If DRIdioma("IdIdioma") = Cod Then
                    resultado = DRIdioma("Nombre")
                    Exit While
                End If
            End While
        End If

        conexionIdioma.Close()
        Return resultado
    End Function

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        If txtCodigo.Text <> "" Then
            btnBuscar.Enabled = True
        End If
    End Sub
End Class