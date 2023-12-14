Imports System.Data.OleDb
Imports System.IO
Imports System.Text

Public Class frm03listadosLibros
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        ListarLibros()
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        ExportarLibrosCSV()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Imprimir()
    End Sub

    Private Sub ListarLibros()
        Conexion.ConnectionString = CadenaConexion
        Conexion.Open()

        Comando.Connection = Conexion
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = "Libro"

        Dim Adaptador = New OleDbDataAdapter(Comando)
        Dim DS = New DataSet
        Adaptador.Fill(DS)

        dgvGrilla.DataSource = DS.Tables(0)

        Conexion.Close()
    End Sub

    Private Sub ExportarLibrosCSV()
        Try
            Dim AD As New StreamWriter("ListadoGeneralLibros.CSV", False, Encoding.UTF8)
            AD.WriteLine("Listado general de libros")
            AD.WriteLine("")
            AD.WriteLine("Id libro;Titulo libro;Año;Cantidad;Precio")
            Conexion.ConnectionString = CadenaConexion
            Conexion.Open()
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.TableDirect
            Comando.CommandText = "Libro"
            DR = Comando.ExecuteReader
            While DR.Read
                AD.Write(DR("IdLibro"))
                AD.Write(";")
                AD.Write(DR("Titulo"))
                AD.Write(";")
                AD.Write(DR("Año"))
                AD.Write(";")
                AD.Write(DR("Cantidad"))
                AD.Write(";")
                AD.WriteLine("$" & DR("Precio"))
            End While
            AD.WriteLine("")
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
            Dim TipoTitulo2 As New Font("Arial Black", 11)
            Dim TipoNormal As New Font("Arial", 11)
            Dim fila As Integer = 50

            Conexion.ConnectionString = CadenaConexion
            Conexion.Open()

            Comando.Connection = Conexion
            Comando.CommandType = CommandType.TableDirect
            Comando.CommandText = "Libro"
            DR = Comando.ExecuteReader

            e.Graphics.DrawString("Listado general de libros ", TipoTitulo1, Brushes.Black, 250, fila)
            fila = fila + 60
            e.Graphics.DrawString("Id libro", TipoTitulo2, Brushes.Black, 80, fila)
            e.Graphics.DrawString("Titulo", TipoTitulo2, Brushes.Black, 200, fila)
            e.Graphics.DrawString("Año", TipoTitulo2, Brushes.Black, 450, fila)
            e.Graphics.DrawString("Cantidad", TipoTitulo2, Brushes.Black, 580, fila)
            e.Graphics.DrawString("Precio", TipoTitulo2, Brushes.Black, 700, fila)
            fila = fila + 30
            While DR.Read
                e.Graphics.DrawString(DR("IdLibro"), TipoNormal, Brushes.Black, 80, fila)
                e.Graphics.DrawString(DR("Titulo"), TipoNormal, Brushes.Black, 200, fila)
                e.Graphics.DrawString(DR("Año"), TipoNormal, Brushes.Black, 450, fila)
                e.Graphics.DrawString(DR("Cantidad"), TipoNormal, Brushes.Black, 610, fila)
                e.Graphics.DrawString("$" & DR("Precio"), TipoNormal, Brushes.Black, 710, fila)
                fila = fila + 20
            End While
            Conexion.Close()
        Catch
            MessageBox.Show(ErrorToString)
            Conexion.Close()
        End Try
    End Sub

    Private Sub dgvGrilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrilla.CellContentClick

    End Sub
End Class