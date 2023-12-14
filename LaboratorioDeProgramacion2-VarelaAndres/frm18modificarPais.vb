Public Class frm18modificarPais
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Buscar()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        GrabarCambios()
    End Sub

    Private Sub Buscar()
        Dim nombre As String = BuscarPais(txtCodigo.Text)
        If nombre <> "" Then
            btnGrabar.Enabled = True
            txtPais.Enabled = True
            txtCodigo.Enabled = False
            txtPais.Text = nombre
        Else
            btnGrabar.Enabled = False
            txtPais.Enabled = False
            txtCodigo.Enabled = True
            txtPais.Text = nombre
            MessageBox.Show("El código no existe")
        End If
    End Sub

    Private Sub GrabarCambios()
        Dim InstruccionSQL As String
        InstruccionSQL = "update Pais set Nombre = '"
        InstruccionSQL = InstruccionSQL + txtPais.Text
        InstruccionSQL = InstruccionSQL + "' where IdPais = "
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
            txtPais.Enabled = False
            btnGrabar.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Function BuscarPais(Cod As Integer) As String
        Dim resultado As String = ""
        Dim conexionPais As New OleDb.OleDbConnection
        Dim comandoPais As New OleDb.OleDbCommand
        Dim DRPais As OleDb.OleDbDataReader

        conexionPais.ConnectionString = CadenaConexion
        conexionPais.Open()
        comandoPais.Connection = conexionPais
        comandoPais.CommandType = CommandType.TableDirect
        comandoPais.CommandText = "Pais"
        DRPais = comandoPais.ExecuteReader

        If DRPais.HasRows Then
            While DRPais.Read
                If DRPais("IdPais") = Cod Then
                    resultado = DRPais("Nombre")
                    Exit While
                End If
            End While
        End If

        conexionPais.Close()
        Return resultado
    End Function

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        If txtCodigo.Text <> "" Then
            btnBuscar.Enabled = True
        End If
    End Sub
End Class