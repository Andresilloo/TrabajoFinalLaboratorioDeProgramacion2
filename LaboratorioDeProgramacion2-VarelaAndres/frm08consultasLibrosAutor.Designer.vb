<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm08consultasLibrosAutor
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm08consultasLibrosAutor))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbAutor = New System.Windows.Forms.ComboBox()
        Me.dgvGrilla = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentoImprimir = New System.Drawing.Printing.PrintDocument()
        Me.DialogoImpresora = New System.Windows.Forms.PrintDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnImprimir)
        Me.GroupBox1.Controls.Add(Me.btnExportar)
        Me.GroupBox1.Controls.Add(Me.btnListar)
        Me.GroupBox1.Controls.Add(Me.lblCantidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbAutor)
        Me.GroupBox1.Controls.Add(Me.dgvGrilla)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(675, 517)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de libros de un autor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(421, 451)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Cantidad de libros listados:"
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Location = New System.Drawing.Point(357, 488)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(100, 23)
        Me.btnImprimir.TabIndex = 23
        Me.btnImprimir.Text = "IMPRIMIR"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Location = New System.Drawing.Point(463, 488)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(100, 23)
        Me.btnExportar.TabIndex = 22
        Me.btnExportar.Text = "EXPORTAR"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnListar
        '
        Me.btnListar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListar.Location = New System.Drawing.Point(569, 488)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(100, 23)
        Me.btnListar.TabIndex = 21
        Me.btnListar.Text = "LISTAR"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'lblCantidad
        '
        Me.lblCantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCantidad.Location = New System.Drawing.Point(559, 444)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(110, 26)
        Me.lblCantidad.TabIndex = 17
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Autor del libro:"
        '
        'cmbAutor
        '
        Me.cmbAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAutor.FormattingEnabled = True
        Me.cmbAutor.Location = New System.Drawing.Point(86, 27)
        Me.cmbAutor.Name = "cmbAutor"
        Me.cmbAutor.Size = New System.Drawing.Size(150, 21)
        Me.cmbAutor.TabIndex = 2
        '
        'dgvGrilla
        '
        Me.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column5, Me.Column2, Me.Column3})
        Me.dgvGrilla.Location = New System.Drawing.Point(6, 54)
        Me.dgvGrilla.Name = "dgvGrilla"
        Me.dgvGrilla.Size = New System.Drawing.Size(663, 387)
        Me.dgvGrilla.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "Titulo"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 300
        '
        'Column5
        '
        Me.Column5.HeaderText = "Año"
        Me.Column5.Name = "Column5"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Cantidad"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.HeaderText = "Precio"
        Me.Column3.Name = "Column3"
        '
        'DocumentoImprimir
        '
        '
        'DialogoImpresora
        '
        Me.DialogoImpresora.UseEXDialog = True
        '
        'frm08consultasLibrosAutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 541)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm08consultasLibrosAutor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de libros de un autor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnListar As Button
    Friend WithEvents lblCantidad As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbAutor As ComboBox
    Friend WithEvents dgvGrilla As DataGridView
    Public WithEvents DocumentoImprimir As Printing.PrintDocument
    Public WithEvents DialogoImpresora As PrintDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
