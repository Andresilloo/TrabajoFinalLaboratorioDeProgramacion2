Imports System.Data.OleDb
Imports System.IO
Imports System.Text

Public Class frm11estadisticasLibrosAutor

    Private InstruccionSQL As String = "Select top 10 * from TituloPorAutor order by CantidadLibro desc"

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        LlenarGrillaYGrafico()
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        ExportarEstadisticasAutor()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Imprimir()
    End Sub

    Private Sub LlenarGrillaYGrafico()
        Try
            Conexion.ConnectionString = CadenaConexion
            Conexion.Open()

            Comando.Connection = Conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = InstruccionSQL
            DR = Comando.ExecuteReader

            If DR.HasRows Then
                Do While DR.Read
                    dgvGrilla.Rows.Add(DR("Nombre"), DR("CantidadLibro"))
                    chaEstadisticasAutor.Series("Cantidad de Libros").Points.AddXY(DR("Nombre"), DR("CantidadLibro"))
                Loop
            End If

            Conexion.Close()
        Catch ex As Exception
            Conexion.Close()
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub ExportarEstadisticasAutor()
        Try
            Dim AD As New StreamWriter("EstadisticasLibrosAutor.CSV", False, Encoding.UTF8)
            AD.WriteLine("Estadisticas de libros ordenados por autor")
            AD.WriteLine("")
            AD.WriteLine("Nombre del autor;Cantidad")
            Conexion.ConnectionString = CadenaConexion
            Conexion.Open()
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = InstruccionSQL
            DR = Comando.ExecuteReader
            While DR.Read
                AD.Write(DR("Nombre"))
                AD.Write(";")
                AD.WriteLine(DR("CantidadLibro"))
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
            Dim TipoTitulo2 As New Font("Arial Black", 14)
            Dim TipoNormal As New Font("Arial", 12)
            Dim fila As Integer = 50

            Conexion.ConnectionString = CadenaConexion
            Conexion.Open()

            Comando.Connection = Conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = InstruccionSQL
            DR = Comando.ExecuteReader

            e.Graphics.DrawString("Estadisticas de libros ordenados por autor ", TipoTitulo1, Brushes.Black, 100, fila)
            fila = fila + 60
            e.Graphics.DrawString("Nombre del autor", TipoTitulo2, Brushes.Black, 80, fila)
            e.Graphics.DrawString("Cantidad", TipoTitulo2, Brushes.Black, 350, fila)
            fila = fila + 30

            While DR.Read
                e.Graphics.DrawString(DR("Nombre"), TipoNormal, Brushes.Black, 80, fila)
                e.Graphics.DrawString(DR("CantidadLibro"), TipoNormal, Brushes.Black, 375, fila)
                fila = fila + 20
            End While

            Conexion.Close()
        Catch
            MessageBox.Show(ErrorToString)
            Conexion.Close()
        End Try
    End Sub
End Class