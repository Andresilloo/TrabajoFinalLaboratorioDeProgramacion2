﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm01sistemaMenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm01sistemaMenuPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdiomasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaisesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosDeUnPaísToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosDeUnAutorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosDeUnIdiomaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosPorPaisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosPorAutorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosPorIdiomaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaísToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdiomaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdiomaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sslblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sslblHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sslblEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightGray
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.ListadosToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.EstadisticasToolStripMenuItem, Me.AgregarToolStripMenuItem, Me.ModificarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(812, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ACercaDeToolStripMenuItem, Me.SalirToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'ACercaDeToolStripMenuItem
        '
        Me.ACercaDeToolStripMenuItem.Name = "ACercaDeToolStripMenuItem"
        Me.ACercaDeToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ACercaDeToolStripMenuItem.Text = "Acerca del sistema..."
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(178, 6)
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'ListadosToolStripMenuItem
        '
        Me.ListadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibrosToolStripMenuItem, Me.AutoresToolStripMenuItem, Me.IdiomasToolStripMenuItem, Me.PaisesToolStripMenuItem})
        Me.ListadosToolStripMenuItem.Name = "ListadosToolStripMenuItem"
        Me.ListadosToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ListadosToolStripMenuItem.Text = "Listados"
        '
        'LibrosToolStripMenuItem
        '
        Me.LibrosToolStripMenuItem.Name = "LibrosToolStripMenuItem"
        Me.LibrosToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.LibrosToolStripMenuItem.Text = "Libros..."
        '
        'AutoresToolStripMenuItem
        '
        Me.AutoresToolStripMenuItem.Name = "AutoresToolStripMenuItem"
        Me.AutoresToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AutoresToolStripMenuItem.Text = "Autores..."
        '
        'IdiomasToolStripMenuItem
        '
        Me.IdiomasToolStripMenuItem.Name = "IdiomasToolStripMenuItem"
        Me.IdiomasToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.IdiomasToolStripMenuItem.Text = "Idiomas..."
        '
        'PaisesToolStripMenuItem
        '
        Me.PaisesToolStripMenuItem.Name = "PaisesToolStripMenuItem"
        Me.PaisesToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.PaisesToolStripMenuItem.Text = "Paises..."
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibrosDeUnPaísToolStripMenuItem, Me.LibrosDeUnAutorToolStripMenuItem, Me.LibrosDeUnIdiomaToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'LibrosDeUnPaísToolStripMenuItem
        '
        Me.LibrosDeUnPaísToolStripMenuItem.Name = "LibrosDeUnPaísToolStripMenuItem"
        Me.LibrosDeUnPaísToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.LibrosDeUnPaísToolStripMenuItem.Text = "Libros de un país..."
        '
        'LibrosDeUnAutorToolStripMenuItem
        '
        Me.LibrosDeUnAutorToolStripMenuItem.Name = "LibrosDeUnAutorToolStripMenuItem"
        Me.LibrosDeUnAutorToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.LibrosDeUnAutorToolStripMenuItem.Text = "Libros de un autor..."
        '
        'LibrosDeUnIdiomaToolStripMenuItem
        '
        Me.LibrosDeUnIdiomaToolStripMenuItem.Name = "LibrosDeUnIdiomaToolStripMenuItem"
        Me.LibrosDeUnIdiomaToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.LibrosDeUnIdiomaToolStripMenuItem.Text = "Libros de un idioma..."
        '
        'EstadisticasToolStripMenuItem
        '
        Me.EstadisticasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibrosPorPaisToolStripMenuItem, Me.LibrosPorAutorToolStripMenuItem, Me.LibrosPorIdiomaToolStripMenuItem})
        Me.EstadisticasToolStripMenuItem.Name = "EstadisticasToolStripMenuItem"
        Me.EstadisticasToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.EstadisticasToolStripMenuItem.Text = "Estadisticas"
        '
        'LibrosPorPaisToolStripMenuItem
        '
        Me.LibrosPorPaisToolStripMenuItem.Name = "LibrosPorPaisToolStripMenuItem"
        Me.LibrosPorPaisToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.LibrosPorPaisToolStripMenuItem.Text = "Libros por pais..."
        '
        'LibrosPorAutorToolStripMenuItem
        '
        Me.LibrosPorAutorToolStripMenuItem.Name = "LibrosPorAutorToolStripMenuItem"
        Me.LibrosPorAutorToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.LibrosPorAutorToolStripMenuItem.Text = "Libros por autor..."
        '
        'LibrosPorIdiomaToolStripMenuItem
        '
        Me.LibrosPorIdiomaToolStripMenuItem.Name = "LibrosPorIdiomaToolStripMenuItem"
        Me.LibrosPorIdiomaToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.LibrosPorIdiomaToolStripMenuItem.Text = "Libros por idioma..."
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibroToolStripMenuItem, Me.PaísToolStripMenuItem, Me.AutorToolStripMenuItem, Me.IdiomaToolStripMenuItem})
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'LibroToolStripMenuItem
        '
        Me.LibroToolStripMenuItem.Name = "LibroToolStripMenuItem"
        Me.LibroToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.LibroToolStripMenuItem.Text = "Libro..."
        '
        'PaísToolStripMenuItem
        '
        Me.PaísToolStripMenuItem.Name = "PaísToolStripMenuItem"
        Me.PaísToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.PaísToolStripMenuItem.Text = "País..."
        '
        'AutorToolStripMenuItem
        '
        Me.AutorToolStripMenuItem.Name = "AutorToolStripMenuItem"
        Me.AutorToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.AutorToolStripMenuItem.Text = "Autor..."
        '
        'IdiomaToolStripMenuItem
        '
        Me.IdiomaToolStripMenuItem.Name = "IdiomaToolStripMenuItem"
        Me.IdiomaToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.IdiomaToolStripMenuItem.Text = "Idioma..."
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibrosToolStripMenuItem1, Me.PaisToolStripMenuItem, Me.AutorToolStripMenuItem1, Me.IdiomaToolStripMenuItem1})
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'LibrosToolStripMenuItem1
        '
        Me.LibrosToolStripMenuItem1.Name = "LibrosToolStripMenuItem1"
        Me.LibrosToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.LibrosToolStripMenuItem1.Text = "Libros..."
        '
        'PaisToolStripMenuItem
        '
        Me.PaisToolStripMenuItem.Name = "PaisToolStripMenuItem"
        Me.PaisToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.PaisToolStripMenuItem.Text = "Pais..."
        '
        'AutorToolStripMenuItem1
        '
        Me.AutorToolStripMenuItem1.Name = "AutorToolStripMenuItem1"
        Me.AutorToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.AutorToolStripMenuItem1.Text = "Autor..."
        '
        'IdiomaToolStripMenuItem1
        '
        Me.IdiomaToolStripMenuItem1.Name = "IdiomaToolStripMenuItem1"
        Me.IdiomaToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.IdiomaToolStripMenuItem1.Text = "Idioma..."
        '
        'StatusStrip
        '
        Me.StatusStrip.AutoSize = False
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.sslblFecha, Me.sslblHora, Me.sslblEstado})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 429)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(812, 22)
        Me.StatusStrip.TabIndex = 2
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.IsLink = True
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(68, 17)
        Me.ToolStripStatusLabel1.Text = "Acerca de..."
        '
        'sslblFecha
        '
        Me.sslblFecha.AutoSize = False
        Me.sslblFecha.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.sslblFecha.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.sslblFecha.Name = "sslblFecha"
        Me.sslblFecha.Size = New System.Drawing.Size(250, 17)
        '
        'sslblHora
        '
        Me.sslblHora.AutoSize = False
        Me.sslblHora.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.sslblHora.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.sslblHora.Name = "sslblHora"
        Me.sslblHora.Size = New System.Drawing.Size(100, 17)
        '
        'sslblEstado
        '
        Me.sslblEstado.AutoSize = False
        Me.sslblEstado.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.sslblEstado.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.sslblEstado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sslblEstado.Name = "sslblEstado"
        Me.sslblEstado.Size = New System.Drawing.Size(250, 17)
        '
        'frm01sistemaMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.pryIEFI_Varela.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(812, 451)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm01sistemaMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal - Libreria"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ACercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IdiomasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaisesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosDeUnPaísToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosDeUnAutorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosDeUnIdiomaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadisticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosPorPaisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosPorAutorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosPorIdiomaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaísToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IdiomaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PaisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutorToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents IdiomaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents sslblFecha As ToolStripStatusLabel
    Friend WithEvents sslblHora As ToolStripStatusLabel
    Friend WithEvents sslblEstado As ToolStripStatusLabel
End Class
