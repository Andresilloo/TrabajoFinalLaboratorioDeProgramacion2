<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm17modificarLibros
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm17modificarLibros))
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lnkAgregarIdioma = New System.Windows.Forms.LinkLabel()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lnkAgregarPais = New System.Windows.Forms.LinkLabel()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lnkAgregarAutor = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbIdioma = New System.Windows.Forms.ComboBox()
        Me.cmbPais = New System.Windows.Forms.ComboBox()
        Me.cmbAutor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(288, 16)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(145, 23)
        Me.btnBuscar.TabIndex = 19
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Código del libro:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(125, 18)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(142, 20)
        Me.txtCodigo.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lnkAgregarIdioma)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lnkAgregarPais)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.lnkAgregarAutor)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbIdioma)
        Me.GroupBox1.Controls.Add(Me.cmbPais)
        Me.GroupBox1.Controls.Add(Me.cmbAutor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtAño)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtTitulo)
        Me.GroupBox1.Controls.Add(Me.btnGrabar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 254)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del libro:"
        '
        'lnkAgregarIdioma
        '
        Me.lnkAgregarIdioma.AutoSize = True
        Me.lnkAgregarIdioma.Location = New System.Drawing.Point(313, 190)
        Me.lnkAgregarIdioma.Name = "lnkAgregarIdioma"
        Me.lnkAgregarIdioma.Size = New System.Drawing.Size(92, 13)
        Me.lnkAgregarIdioma.TabIndex = 36
        Me.lnkAgregarIdioma.TabStop = True
        Me.lnkAgregarIdioma.Text = "Modificar idioma..."
        '
        'txtCantidad
        '
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Location = New System.Drawing.Point(140, 81)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(87, 20)
        Me.txtCantidad.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Cantidad:"
        '
        'lnkAgregarPais
        '
        Me.lnkAgregarPais.AutoSize = True
        Me.lnkAgregarPais.Location = New System.Drawing.Point(313, 136)
        Me.lnkAgregarPais.Name = "lnkAgregarPais"
        Me.lnkAgregarPais.Size = New System.Drawing.Size(83, 13)
        Me.lnkAgregarPais.TabIndex = 35
        Me.lnkAgregarPais.TabStop = True
        Me.lnkAgregarPais.Text = "Modificar país..."
        '
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(140, 107)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(87, 20)
        Me.txtPrecio.TabIndex = 27
        '
        'lnkAgregarAutor
        '
        Me.lnkAgregarAutor.AutoSize = True
        Me.lnkAgregarAutor.Location = New System.Drawing.Point(313, 163)
        Me.lnkAgregarAutor.Name = "lnkAgregarAutor"
        Me.lnkAgregarAutor.Size = New System.Drawing.Size(86, 13)
        Me.lnkAgregarAutor.TabIndex = 34
        Me.lnkAgregarAutor.TabStop = True
        Me.lnkAgregarAutor.Text = "Modificar autor..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Precio:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Idioma:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "País:"
        '
        'cmbIdioma
        '
        Me.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdioma.Enabled = False
        Me.cmbIdioma.FormattingEnabled = True
        Me.cmbIdioma.Location = New System.Drawing.Point(140, 187)
        Me.cmbIdioma.Name = "cmbIdioma"
        Me.cmbIdioma.Size = New System.Drawing.Size(167, 21)
        Me.cmbIdioma.TabIndex = 31
        '
        'cmbPais
        '
        Me.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPais.Enabled = False
        Me.cmbPais.FormattingEnabled = True
        Me.cmbPais.Location = New System.Drawing.Point(140, 133)
        Me.cmbPais.Name = "cmbPais"
        Me.cmbPais.Size = New System.Drawing.Size(167, 21)
        Me.cmbPais.TabIndex = 30
        '
        'cmbAutor
        '
        Me.cmbAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAutor.Enabled = False
        Me.cmbAutor.FormattingEnabled = True
        Me.cmbAutor.Location = New System.Drawing.Point(140, 160)
        Me.cmbAutor.Name = "cmbAutor"
        Me.cmbAutor.Size = New System.Drawing.Size(167, 21)
        Me.cmbAutor.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Año:"
        '
        'txtAño
        '
        Me.txtAño.Enabled = False
        Me.txtAño.Location = New System.Drawing.Point(140, 55)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(87, 20)
        Me.txtAño.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Autor:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Titulo:"
        '
        'txtTitulo
        '
        Me.txtTitulo.Enabled = False
        Me.txtTitulo.Location = New System.Drawing.Point(140, 29)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(259, 20)
        Me.txtTitulo.TabIndex = 20
        '
        'btnGrabar
        '
        Me.btnGrabar.Enabled = False
        Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Location = New System.Drawing.Point(287, 225)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(139, 23)
        Me.btnGrabar.TabIndex = 6
        Me.btnGrabar.Text = "GRABAR CAMBIOS"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'frm17modificarLibros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 322)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm17modificarLibros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar libros"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnGrabar As Button
    Friend WithEvents lnkAgregarIdioma As LinkLabel
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lnkAgregarPais As LinkLabel
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lnkAgregarAutor As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbIdioma As ComboBox
    Friend WithEvents cmbPais As ComboBox
    Friend WithEvents cmbAutor As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAño As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTitulo As TextBox
End Class
