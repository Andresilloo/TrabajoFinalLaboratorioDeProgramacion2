Imports System.Data.OleDb
Imports System.IO
Imports System.Text

Public Class frm04listadosAutores
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        ListarAutores()
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        ExportarAutoresCSV()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Imprimir()
    End Sub

    Private Sub ListarAutores()
        Conexion.ConnectionString = CadenaConexion
        Conexion.Open()

        Comando.Connection = Conexion
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = "Autor"

        Dim Adaptador = New OleDbDataAdapter(Comando)
        Dim DS = New DataSet
        Adaptador.Fill(DS)

        dgvGrilla.DataSource = DS.Tables(0)

        Conexion.Close()
    End Sub

    Private Sub ExportarAutoresCSV()
        Try
            Dim AD As New StreamWriter("ListadoGeneralAutores.CSV", False, Encoding.UTF8)
            AD.WriteLine("Listado general de autores")
            AD.WriteLine("")
            AD.WriteLine("Id autor;Nombre del autor")
            Conexion.ConnectionString = CadenaConexion
            Conexion.Open()
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.TableDirect
            Comando.CommandText = "Autor"
            DR = Comando.ExecuteReader
            While DR.Read
                AD.Write(DR("IdAutor"))
                AD.Write(";")
                AD.WriteLine(DR("Nombre"))
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
            Comando.CommandText = "Autor"
            DR = Comando.ExecuteReader

            e.Graphics.DrawString("Listado general de autores ", TipoTitulo1, Brushes.Black, 250, fila)
            fila = fila + 60
            e.Graphics.DrawString("Id autor", TipoTitulo2, Brushes.Black, 120, fila)
            e.Graphics.DrawString("Nombre del autor", TipoTitulo2, Brushes.Black, 320, fila)
            fila = fila + 30
            While DR.Read
                e.Graphics.DrawString(DR("IdAutor"), TipoNormal, Brushes.Black, 135, fila)
                e.Graphics.DrawString(DR("Nombre"), TipoNormal, Brushes.Black, 320, fila)
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