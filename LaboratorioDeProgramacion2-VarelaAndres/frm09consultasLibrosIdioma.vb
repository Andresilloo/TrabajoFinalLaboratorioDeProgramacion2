Imports System.Data.OleDb
Imports System.IO
Imports System.Text

Public Class frm09consultasLibrosIdioma
    Private Sub frm09consultasLibrosIdioma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboIdioma()
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        ListarLibrosIdioma()
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        ExportarLibrosIdiomaCSV()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Imprimir()
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

    Private Sub ListarLibrosIdioma()
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
                If DR("IdIdioma") = cmbIdioma.SelectedValue Then
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

    Private Sub ExportarLibrosIdiomaCSV()
        Try
            Dim AD As New StreamWriter("ListadoLibrosIdioma.CSV", False, Encoding.UTF8)
            AD.WriteLine("Listado de libros en: " + cmbIdioma.Text)
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
                If DR("IdIdioma") = cmbIdioma.SelectedValue Then
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

            e.Graphics.DrawString("Listado de libros en " & cmbIdioma.Text, TipoTitulo1, Brushes.Black, 200, fila)
            fila = fila + 60
            e.Graphics.DrawString("Titulo", TipoTitulo2, Brushes.Black, 80, fila)
            e.Graphics.DrawString("Año", TipoTitulo2, Brushes.Black, 370, fila)
            e.Graphics.DrawString("Cantidad", TipoTitulo2, Brushes.Black, 500, fila)
            e.Graphics.DrawString("Precio", TipoTitulo2, Brushes.Black, 680, fila)
            fila = fila + 30
            While DR.Read
                If DR("IdIdioma") = cmbIdioma.SelectedValue Then
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
End Class