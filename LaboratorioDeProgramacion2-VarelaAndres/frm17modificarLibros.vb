Imports System.Data.OleDb

Public Class frm17modificarLibros
    Private Sub frm17modificarLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboAutor()
        LlenarComboIdioma()
        LlenarComboPais()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Buscar()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        GrabarCambios()
    End Sub

    Private Sub Buscar()
        Dim titulo As String = BuscarTitulo(txtCodigo.Text)
        Dim año As String = BuscarAño(txtCodigo.Text)
        Dim cantidad As String = BuscarCantidad(txtCodigo.Text)
        Dim precio As String = BuscarPrecio(txtCodigo.Text)
        If titulo <> "" Then
            btnGrabar.Enabled = True
            txtTitulo.Enabled = True
            cmbAutor.Enabled = True
            txtAño.Enabled = True
            cmbPais.Enabled = True
            cmbIdioma.Enabled = True
            txtCantidad.Enabled = True
            txtPrecio.Enabled = True
            txtCodigo.Enabled = False
            txtTitulo.Text = titulo
            txtAño.Text = año
            txtCantidad.Text = cantidad
            txtPrecio.Text = precio
        Else
            btnGrabar.Enabled = False
            txtTitulo.Enabled = False
            cmbAutor.Enabled = False
            txtAño.Enabled = False
            cmbPais.Enabled = False
            cmbIdioma.Enabled = False
            txtCantidad.Enabled = False
            txtPrecio.Enabled = False
            txtCodigo.Enabled = True
            txtTitulo.Text = titulo
            txtAño.Text = año
            txtCantidad.Text = cantidad
            txtPrecio.Text = precio
            MessageBox.Show("El código no existe")
        End If
    End Sub

    Private Sub GrabarCambios()
        Try
            Dim InstruccionSQL As String = "update Libro set"
            InstruccionSQL = InstruccionSQL & " Titulo = '" & txtTitulo.Text & "', "
            InstruccionSQL = InstruccionSQL & " IdAutor = " & cmbAutor.SelectedValue & ", "
            InstruccionSQL = InstruccionSQL & " Año = '" & txtAño.Text & "', "
            InstruccionSQL = InstruccionSQL & " IdPais = " & cmbPais.SelectedValue & ", "
            InstruccionSQL = InstruccionSQL & " IdIdioma = " & cmbIdioma.SelectedValue & ", "
            InstruccionSQL = InstruccionSQL & " Cantidad = " & txtCantidad.Text & ", "
            InstruccionSQL = InstruccionSQL & " Precio = " & txtPrecio.Text
            InstruccionSQL = InstruccionSQL & " where IdLibro = " & txtCodigo.Text

            Conexion.ConnectionString = CadenaConexion
            Conexion.Open()
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = InstruccionSQL

            Comando.ExecuteReader()
            Conexion.Close()

            MessageBox.Show("Dato Modificado")
        Catch
            MessageBox.Show(ErrorToString)
            Conexion.Close()
        End Try
    End Sub

    Private Sub LlenarComboAutor()
        Try
            Conexion.ConnectionString = CadenaConexion
            Conexion.Open()

            Comando.Connection = Conexion
            Comando.CommandType = CommandType.TableDirect
            Comando.CommandText = "Autor"

            Dim Adaptador = New OleDbDataAdapter(Comando)
            Dim DS = New DataSet
            Adaptador.Fill(DS)

            cmbAutor.DataSource = DS.Tables(0)
            cmbAutor.DisplayMember = "Nombre"
            cmbAutor.ValueMember = "IdAutor"

            Conexion.Close()
        Catch
            MessageBox.Show(ErrorToString)
            Conexion.Close()
        End Try
    End Sub

    Private Sub LlenarComboPais()
        Try
            Conexion.ConnectionString = CadenaConexion
            Conexion.Open()

            Comando.Connection = Conexion
            Comando.CommandType = CommandType.TableDirect
            Comando.CommandText = "Pais"

            Dim Adaptador = New OleDbDataAdapter(Comando)
            Dim DS = New DataSet
            Adaptador.Fill(DS)

            cmbPais.DataSource = DS.Tables(0)
            cmbPais.DisplayMember = "Nombre"
            cmbPais.ValueMember = "IdPais"

            Conexion.Close()
        Catch
            MessageBox.Show(ErrorToString)
            Conexion.Close()
        End Try
    End Sub

    Private Sub LlenarComboIdioma()
        Try
            Conexion.ConnectionString = CadenaConexion
            Conexion.Open()

            Comando.Connection = Conexion
            Comando.CommandType = CommandType.TableDirect
            Comando.CommandText = "Idioma"

            Dim Adaptador = New OleDbDataAdapter(Comando)
            Dim DS = New DataSet
            Adaptador.Fill(DS)

            cmbIdioma.DataSource = DS.Tables(0)
            cmbIdioma.DisplayMember = "Nombre"
            cmbIdioma.ValueMember = "IdIdioma"

            Conexion.Close()
        Catch
            MessageBox.Show(ErrorToString)
            Conexion.Close()
        End Try
    End Sub

    Private Function BuscarTitulo(Cod As Integer) As String
        Dim resultado As String = ""
        Dim conexionLibro As New OleDb.OleDbConnection
        Dim comandoLibro As New OleDb.OleDbCommand
        Dim DRLibro As OleDb.OleDbDataReader

        conexionLibro.ConnectionString = CadenaConexion
        conexionLibro.Open()
        comandoLibro.Connection = conexionLibro
        comandoLibro.CommandType = CommandType.TableDirect
        comandoLibro.CommandText = "Libro"
        DRLibro = comandoLibro.ExecuteReader

        If DRLibro.HasRows Then
            While DRLibro.Read
                If DRLibro("IdLibro") = Cod Then
                    resultado = DRLibro("Titulo")
                    Exit While
                End If
            End While
        End If

        conexionLibro.Close()
        Return resultado
    End Function

    Private Function BuscarAño(Cod As Integer) As String
        Dim resultado As String = ""
        Dim conexionLibro As New OleDb.OleDbConnection
        Dim comandoLibro As New OleDb.OleDbCommand
        Dim DRLibro As OleDb.OleDbDataReader

        conexionLibro.ConnectionString = CadenaConexion
        conexionLibro.Open()
        comandoLibro.Connection = conexionLibro
        comandoLibro.CommandType = CommandType.TableDirect
        comandoLibro.CommandText = "Libro"
        DRLibro = comandoLibro.ExecuteReader

        If DRLibro.HasRows Then
            While DRLibro.Read
                If DRLibro("IdLibro") = Cod Then
                    resultado = DRLibro("Año")
                    Exit While
                End If
            End While
        End If

        conexionLibro.Close()
        Return resultado
    End Function

    Private Function BuscarCantidad(Cod As Integer) As String
        Dim resultado As String = ""
        Dim conexionLibro As New OleDb.OleDbConnection
        Dim comandoLibro As New OleDb.OleDbCommand
        Dim DRLibro As OleDb.OleDbDataReader

        conexionLibro.ConnectionString = CadenaConexion
        conexionLibro.Open()
        comandoLibro.Connection = conexionLibro
        comandoLibro.CommandType = CommandType.TableDirect
        comandoLibro.CommandText = "Libro"
        DRLibro = comandoLibro.ExecuteReader

        If DRLibro.HasRows Then
            While DRLibro.Read
                If DRLibro("IdLibro") = Cod Then
                    resultado = DRLibro("Cantidad")
                    Exit While
                End If
            End While
        End If

        conexionLibro.Close()
        Return resultado
    End Function

    Private Function BuscarPrecio(Cod As Integer) As String
        Dim resultado As String = ""
        Dim conexionLibro As New OleDb.OleDbConnection
        Dim comandoLibro As New OleDb.OleDbCommand
        Dim DRLibro As OleDb.OleDbDataReader

        conexionLibro.ConnectionString = CadenaConexion
        conexionLibro.Open()
        comandoLibro.Connection = conexionLibro
        comandoLibro.CommandType = CommandType.TableDirect
        comandoLibro.CommandText = "Libro"
        DRLibro = comandoLibro.ExecuteReader

        If DRLibro.HasRows Then
            While DRLibro.Read
                If DRLibro("IdLibro") = Cod Then
                    resultado = DRLibro("Precio")
                    Exit While
                End If
            End While
        End If

        conexionLibro.Close()
        Return resultado
    End Function

    Private Sub lnkAgregarPais_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAgregarPais.LinkClicked
        frm18modificarPais.ShowDialog()
    End Sub

    Private Sub lnkAgregarAutor_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAgregarAutor.LinkClicked
        frm19modificarAutor.ShowDialog()
    End Sub

    Private Sub lnkAgregarIdioma_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAgregarIdioma.LinkClicked
        frm20modificarIdioma.ShowDialog()
    End Sub
End Class