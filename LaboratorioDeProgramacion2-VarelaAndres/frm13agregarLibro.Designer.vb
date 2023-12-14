<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm13agregarLibro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm13agregarLibro))
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
        Me.btnGrabarLibro = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GroupBox1.Controls.Add(Me.btnGrabarLibro)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTitulo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 261)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Carga de datos"
        '
        'lnkAgregarIdioma
        '
        Me.lnkAgregarIdioma.AutoSize = True
        Me.lnkAgregarIdioma.Location = New System.Drawing.Point(291, 191)
        Me.lnkAgregarIdioma.Name = "lnkAgregarIdioma"
        Me.lnkAgregarIdioma.Size = New System.Drawing.Size(86, 13)
        Me.lnkAgregarIdioma.TabIndex = 19
        Me.lnkAgregarIdioma.TabStop = True
        Me.lnkAgregarIdioma.Text = "Agregar idioma..."
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(118, 82)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(87, 20)
        Me.txtCantidad.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Cantidad:"
        '
        'lnkAgregarPais
        '
        Me.lnkAgregarPais.AutoSize = True
        Me.lnkAgregarPais.Location = New System.Drawing.Point(291, 137)
        Me.lnkAgregarPais.Name = "lnkAgregarPais"
        Me.lnkAgregarPais.Size = New System.Drawing.Size(77, 13)
        Me.lnkAgregarPais.TabIndex = 18
        Me.lnkAgregarPais.TabStop = True
        Me.lnkAgregarPais.Text = "Agregar país..."
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(118, 108)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(87, 20)
        Me.txtPrecio.TabIndex = 10
        '
        'lnkAgregarAutor
        '
        Me.lnkAgregarAutor.AutoSize = True
        Me.lnkAgregarAutor.Location = New System.Drawing.Point(291, 164)
        Me.lnkAgregarAutor.Name = "lnkAgregarAutor"
        Me.lnkAgregarAutor.Size = New System.Drawing.Size(80, 13)
        Me.lnkAgregarAutor.TabIndex = 17
        Me.lnkAgregarAutor.TabStop = True
        Me.lnkAgregarAutor.Text = "Agregar autor..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Precio:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Idioma:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "País:"
        '
        'cmbIdioma
        '
        Me.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdioma.FormattingEnabled = True
        Me.cmbIdioma.Location = New System.Drawing.Point(118, 188)
        Me.cmbIdioma.Name = "cmbIdioma"
        Me.cmbIdioma.Size = New System.Drawing.Size(167, 21)
        Me.cmbIdioma.TabIndex = 14
        '
        'cmbPais
        '
        Me.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPais.FormattingEnabled = True
        Me.cmbPais.Location = New System.Drawing.Point(118, 134)
        Me.cmbPais.Name = "cmbPais"
        Me.cmbPais.Size = New System.Drawing.Size(167, 21)
        Me.cmbPais.TabIndex = 13
        '
        'cmbAutor
        '
        Me.cmbAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAutor.FormattingEnabled = True
        Me.cmbAutor.Location = New System.Drawing.Point(118, 161)
        Me.cmbAutor.Name = "cmbAutor"
        Me.cmbAutor.Size = New System.Drawing.Size(167, 21)
        Me.cmbAutor.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Año:"
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(118, 56)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(87, 20)
        Me.txtAño.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Autor:"
        '
        'btnGrabarLibro
        '
        Me.btnGrabarLibro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabarLibro.Location = New System.Drawing.Point(288, 232)
        Me.btnGrabarLibro.Name = "btnGrabarLibro"
        Me.btnGrabarLibro.Size = New System.Drawing.Size(100, 23)
        Me.btnGrabarLibro.TabIndex = 3
        Me.btnGrabarLibro.Text = "GRABAR"
        Me.btnGrabarLibro.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Titulo:"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(118, 30)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(259, 20)
        Me.txtTitulo.TabIndex = 0
        '
        'frm13agregarLibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 282)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm13agregarLibro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar libro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnGrabarLibro As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAño As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbIdioma As ComboBox
    Friend WithEvents cmbPais As ComboBox
    Friend WithEvents cmbAutor As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lnkAgregarIdioma As LinkLabel
    Friend WithEvents lnkAgregarPais As LinkLabel
    Friend WithEvents lnkAgregarAutor As LinkLabel
End Class
