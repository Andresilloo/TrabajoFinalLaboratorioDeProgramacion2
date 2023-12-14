Imports System.Data.OleDb
Imports System.IO
Imports System.Text

Public Class frm08consultasLibrosAutor
    Private Sub frm08consultasLibrosAutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboAutor()
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        ListarLibrosAutores()
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        ExportarLibrosAutoresCSV()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Imprimir()
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

    Private Sub ListarLibrosAutores()
        Try
            Dim cantidad As Integer = 0

            Conexion.ConnectionString = CadenaConexion
            Conexion.Open()

            Comando.Connection = Conexion
            Comando.CommandType = CommandType.TableDirect
            Comando.CommandText = "Libro"

            DR = Comando.ExecuteReader
            dgvGrilla.Rows.Clear()
            While DR.Read
                If DR("IdAutor") = cmbAutor.SelectedValue Then
                    cantidad = cantidad + 1
                    dgvGrilla.Rows.Add(DR("Titulo"), DR("Año"), DR("Cantidad"), DR("Precio"))
                End If
            End While

            Conexion.Close()
            lblCantidad.Text = cantidad
        Catch
            MessageBox.Show(ErrorToString)
            Conexion.Close()
        End Try
    End Sub

    Private Sub ExportarLibrosAutoresCSV()
        Try
            Dim AD As New StreamWriter("ListadoLibrosAutor.CSV", False, Encoding.UTF8)
            AD.WriteLine("Listado de libros del autor: " + cmbAutor.Text)
            AD.WriteLine("")
            AD.WriteLine("Titulo libro;Año;Cantidad;Precio")
            Dim cantidad As Integer = 0
            Conexion.ConnectionString = CadenaConexion
            Conexion.Open()
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.TableDirect
            Comando.CommandText = "Libro"
            DR = Comando.ExecuteReader
            While DR.Read
                If DR("IdAutor") = cmbAutor.SelectedValue Then
                    AD.Write(DR("Titulo"))
                    AD.Write(";")
                    AD.Write(DR("Año"))
                    AD.Write(";")
                    AD.Write(DR("Cantidad"))
                    AD.Write(";")
                    AD.WriteLine("$" & DR("Precio"))
                    cantidad = cantidad + 1
                End If
            End While
            AD.WriteLine("")
            AD.WriteLine(";;Cantidad:;" + cantidad.ToString())
            Conexion.Close()
            AD.Close()
            MessageBox.Show("Datos exportados correctamente")
        Catch
            MessageBox.Show(ErrorToString)
            Conexion.Close()
        End Try
    End Sub

    Private Sub Imprimir()
        DialogoImpresora.ShowDialog()
        DocumentoImprimir.PrinterSettings = DialogoImpresora.PrinterSettings
        DocumentoImprimir.Print()
    End Sub

    Private Sub DocumentoImprimir_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles DocumentoImprimir.PrintPage
        Try
            Dim TipoTitulo1 As New Font("Arial Black", 20)
            Dim TipoTitulo2 As New Font("Arial Black", 14)
            Dim TipoNormal As New Font("Arial", 12)
            Dim cantidad As Integer = 0
            Dim fila As Integer = 50

            Conexion.ConnectionString = CadenaConexion
            Conexion.Open()

            Comando.Connection = Conexion
            Comando.CommandType = CommandType.TableDirect
            Comando.CommandText = "Libro"
            DR = Comando.ExecuteReader

            e.Graphics.DrawString("Listado de libros del autor " & cmbAutor.Text, TipoTitulo1, Brushes.Black, 120, fila)
            fila = fila + 60
            e.Graphics.DrawString("Titulo", TipoTitulo2, Brushes.Black, 80, fila)
            e.Graphics.DrawString("Año", TipoTitulo2, Brushes.Black, 370, fila)
            e.Graphics.DrawString("Cantidad", TipoTitulo2, Brushes.Black, 500, fila)
            e.Graphics.DrawString("Precio", TipoTitulo2, Brushes.Black, 680, fila)
            fila = fila + 30
            While DR.Read
                If DR("IdAutor") = cmbAutor.SelectedValue Then
                    e.Graphics.DrawString(DR("Titulo"), TipoNormal, Brushes.Black, 80, fila)
                    e.Graphics.DrawString(DR("Año"), TipoNormal, Brushes.Black, 370, fila)
                    e.Graphics.DrawString(DR("Cantidad"), TipoNormal, Brushes.Black, 540, fila)
                    e.Graphics.DrawString("$" & DR("Precio"), TipoNormal, Brushes.Black, 680, fila)
                    fila = fila + 20
                    cantidad = cantidad + 1
                End If
            End While
            Conexion.Close()
            fila = fila + 20
            e.Graphics.DrawString("Cantidad de libros listados: ", TipoTitulo2, Brushes.Black, 390, fila)
            e.Graphics.DrawString(cantidad, TipoTitulo2, Brushes.Black, 700, fila)
        Catch
            MessageBox.Show(ErrorToString)
            Conexion.Close()
        End Try
    End Sub

    Private Sub dgvGrilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrilla.CellContentClick

    End Sub
End Class