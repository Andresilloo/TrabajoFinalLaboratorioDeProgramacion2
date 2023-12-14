Imports System.Data.OleDb

Public Class frm13agregarLibro
    Private Sub frm13agregarLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboAutor()
        LlenarComboIdioma()
        LlenarComboPais()
        cmbAutor.SelectedIndex = -1
        cmbIdioma.SelectedIndex = -1
        cmbPais.SelectedIndex = -1
    End Sub

    Private Sub btnGrabarLibro_Click(sender As Object, e As EventArgs) Handles btnGrabarLibro.Click
        GrabarLibro()
    End Sub

    Private Sub GrabarLibro()
        Try

            Conexion.ConnectionString = CadenaConexion
            Conexion.Open()

            Comando.Connection = Conexion
            Comando.CommandType = CommandType.TableDirect
            Comando.CommandText = "Libro"

            Dim Adaptador = New OleDbDataAdapter(Comando)
            Dim DS = New DataSet
            Adaptador.Fill(DS)

            Dim Tabla As DataTable = DS.Tables(0)
            Dim Fila As DataRow = tabla.NewRow
            Fila("Titulo") = txtTitulo.Text
            Fila("Año") = txtAño.Text
            Fila("Cantidad") = txtCantidad.Text
            Fila("Precio") = txtPrecio.Text
            Fila("IdAutor") = cmbAutor.SelectedValue
            Fila("IdPais") = cmbPais.SelectedValue
            Fila("IdIdioma") = cmbIdioma.SelectedValue

            Tabla.Rows.Add(Fila)
            Dim ComandoGrabar As New OleDbCommandBuilder(Adaptador)
            Adaptador.Update(DS)

            Conexion.Close()
            MessageBox.Show("Dato Grabado")
            txtTitulo.Text = ""
            txtAño.Text = ""
            txtCantidad.Text = ""
            txtPrecio.Text = ""
            cmbAutor.SelectedIndex = -1
            cmbIdioma.SelectedIndex = -1
            cmbPais.SelectedIndex = -1
        Catch
            Conexion.Close()
            MessageBox.Show(ErrorToString)
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

    Private Sub lnkAgregarPais_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAgregarPais.LinkClicked
        frm14agregarPais.ShowDialog()
    End Sub

    Private Sub lnkAgregarAutor_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAgregarAutor.LinkClicked
        frm15agregarAutor.ShowDialog()
    End Sub

    Private Sub lnkAgregarIdioma_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAgregarIdioma.LinkClicked
        frm16agregarIdioma.ShowDialog()
    End Sub
End Class