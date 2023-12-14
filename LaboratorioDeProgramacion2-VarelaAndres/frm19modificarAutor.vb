Public Class frm19modificarAutor
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Buscar()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        GrabarCambios()
    End Sub

    Private Sub Buscar()
        Dim nombre As String = BuscarAutor(txtCodigo.Text)
        If nombre <> "" Then
            btnGrabar.Enabled = True
            txtNombre.Enabled = True
            txtCodigo.Enabled = False
            txtNombre.Text = nombre
        Else
            btnGrabar.Enabled = False
            txtNombre.Enabled = False
            txtCodigo.Enabled = True
            txtNombre.Text = nombre
            MessageBox.Show("El código no existe")
        End If
    End Sub

    Private Sub GrabarCambios()
        Dim InstruccionSQL As String
        InstruccionSQL = "update Autor set Nombre = '"
        InstruccionSQL = InstruccionSQL + txtNombre.Text
        InstruccionSQL = InstruccionSQL + "' where IdAutor = "
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
            txtNombre.Enabled = False
            btnGrabar.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Function BuscarAutor(Cod As Integer) As String
        Dim resultado As String = ""
        Dim conexionAutor As New OleDb.OleDbConnection
        Dim comandoAutor As New OleDb.OleDbCommand
        Dim DRAutor As OleDb.OleDbDataReader

        conexionAutor.ConnectionString = CadenaConexion
        conexionAutor.Open()
        comandoAutor.Connection = conexionAutor
        comandoAutor.CommandType = CommandType.TableDirect
        comandoAutor.CommandText = "Autor"
        DRAutor = comandoAutor.ExecuteReader

        If DRAutor.HasRows Then
            While DRAutor.Read
                If DRAutor("IdAutor") = Cod Then
                    resultado = DRAutor("Nombre")
                    Exit While
                End If
            End While
        End If

        conexionAutor.Close()
        Return resultado
    End Function

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        If txtCodigo.Text <> "" Then
            btnBuscar.Enabled = True
        End If
    End Sub
End Class