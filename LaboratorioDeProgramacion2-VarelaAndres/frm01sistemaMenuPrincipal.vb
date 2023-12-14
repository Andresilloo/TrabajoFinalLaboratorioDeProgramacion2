Public Class frm01sistemaMenuPrincipal
    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Dim respuesta As DialogResult
        respuesta = MessageBox.Show("Desea salir?", "Salir", MessageBoxButtons.YesNo)
        If respuesta = DialogResult.Yes Then
            MessageBox.Show("El programa finalizó")
            End
            If respuesta <> DialogResult.Yes Then
                MessageBox.Show("")
            End If
        End If
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        sslblEstado.Text = "Ventana: Acerca del sistema"
        frm02sistemaAcercaDe.ShowDialog()
        sslblEstado.Text = ""
    End Sub

    Private Sub ACercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACercaDeToolStripMenuItem.Click
        sslblEstado.Text = "Ventana: Acerca del sistema"
        frm02sistemaAcercaDe.ShowDialog()
        sslblEstado.Text = ""
    End Sub

    Private Sub LibrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosToolStripMenuItem.Click
        sslblEstado.Text = "Ventana: Listado de libros"
        frm03listadosLibros.ShowDialog()
        sslblEstado.Text = ""
    End Sub

    Private Sub AutoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoresToolStripMenuItem.Click
        sslblEstado.Text = "Ventana: Listado de autores"
        frm04listadosAutores.ShowDialog()
        sslblEstado.Text = ""
    End Sub

    Private Sub IdiomasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IdiomasToolStripMenuItem.Click
        sslblEstado.Text = "Ventana: Listado de idiomas"
        frm05listadosIdiomas.ShowDialog()
        sslblEstado.Text = ""
    End Sub

    Private Sub PaisesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaisesToolStripMenuItem.Click
        sslblEstado.Text = "Ventana: Listado de paises"
        frm06listadosPaises.ShowDialog()
        sslblEstado.Text = ""
    End Sub

    Private Sub LibrosDeUnPaísToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosDeUnPaísToolStripMenuItem.Click
        sslblEstado.Text = "Ventana: Consulta de libros de un país"
        frm07consultasLibrosPais.ShowDialog()
        sslblEstado.Text = ""
    End Sub

    Private Sub LibrosDeUnAutorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosDeUnAutorToolStripMenuItem.Click
        sslblEstado.Text = "Ventana: Consulta de libros de un autor"
        frm08consultasLibrosAutor.ShowDialog()
        sslblEstado.Text = ""
    End Sub

    Private Sub LibrosDeUnIdiomaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosDeUnIdiomaToolStripMenuItem.Click
        sslblEstado.Text = "Ventana: Consulta de libros en un idioma"
        frm09consultasLibrosIdioma.ShowDialog()
        sslblEstado.Text = ""
    End Sub

    Private Sub LibrosPorPaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosPorPaisToolStripMenuItem.Click
        sslblEstado.Text = "Ventana: Estadísticas - Libros por país"
        frm10estadisticasLibrosPais.ShowDialog()
        sslblEstado.Text = ""
    End Sub

    Private Sub LibrosPorAutorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosPorAutorToolStripMenuItem.Click
        sslblEstado.Text = "Ventana: Estadísticas - Libros por autor"
        frm11estadisticasLibrosAutor.ShowDialog()
        sslblEstado.Text = ""
    End Sub

    Private Sub LibrosPorIdiomaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosPorIdiomaToolStripMenuItem.Click
        sslblEstado.Text = "Ventana: Estadísticas - Libros por idioma"
        frm12estadisticasLibrosIdioma.ShowDialog()
        sslblEstado.Text = ""
    End Sub

    Private Sub LibroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibroToolStripMenuItem.Click
        sslblEstado.Text = "Ventana: Agregar libro"
        frm13agregarLibro.ShowDialog()
        sslblEstado.Text = ""
    End Sub

    Private Sub PaísToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaísToolStripMenuItem.Click
        sslblEstado.Text = "Ventana: Agregar país"
        frm14agregarPais.ShowDialog()
        sslblEstado.Text = ""
    End Sub

    Private Sub AutorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutorToolStripMenuItem.Click
        sslblEstado.Text = "Ventana: Agregar autor"
        frm15agregarAutor.ShowDialog()
        sslblEstado.Text = ""
    End Sub

    Private Sub IdiomaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IdiomaToolStripMenuItem.Click
        sslblEstado.Text = "Ventana: Agregar idioma"
        frm16agregarIdioma.ShowDialog()
        sslblEstado.Text = ""
    End Sub

    Private Sub LibrosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LibrosToolStripMenuItem1.Click
        sslblEstado.Text = "Ventana: Modificar libros"
        frm17modificarLibros.ShowDialog()
        sslblEstado.Text = ""
    End Sub

    Private Sub PaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaisToolStripMenuItem.Click
        sslblEstado.Text = "Ventana: Modificar país"
        frm18modificarPais.ShowDialog()
        sslblEstado.Text = ""
    End Sub

    Private Sub AutorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AutorToolStripMenuItem1.Click
        sslblEstado.Text = "Ventana: Modificar autor"
        frm19modificarAutor.ShowDialog()
        sslblEstado.Text = ""
    End Sub

    Private Sub IdiomaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IdiomaToolStripMenuItem1.Click
        sslblEstado.Text = "Ventana: Modificar idioma"
        frm20modificarIdioma.ShowDialog()
        sslblEstado.Text = ""
    End Sub

    Private Sub frm01sistemaMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sslblFecha.Text = "Fecha: " & DateTime.Now.ToLongDateString
        sslblHora.Text = "Hora: " & DateTime.Now.ToLongTimeString
    End Sub
End Class
