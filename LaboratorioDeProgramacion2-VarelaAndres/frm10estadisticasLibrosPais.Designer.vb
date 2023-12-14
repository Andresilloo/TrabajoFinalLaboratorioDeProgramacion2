<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm10estadisticasLibrosPais
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm10estadisticasLibrosPais))
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.dgvGrilla = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chaEstadisticasPais = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.DialogoImpresora = New System.Windows.Forms.PrintDialog()
        Me.DocumentoImprimir = New System.Drawing.Printing.PrintDocument()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chaEstadisticasPais, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMostrar
        '
        Me.btnMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.Location = New System.Drawing.Point(831, 428)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(134, 53)
        Me.btnMostrar.TabIndex = 0
        Me.btnMostrar.Text = "MOSTRAR"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'dgvGrilla
        '
        Me.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgvGrilla.Location = New System.Drawing.Point(6, 19)
        Me.dgvGrilla.Name = "dgvGrilla"
        Me.dgvGrilla.Size = New System.Drawing.Size(363, 403)
        Me.dgvGrilla.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 200
        '
        'Column2
        '
        Me.Column2.HeaderText = "Cantidad"
        Me.Column2.Name = "Column2"
        '
        'chaEstadisticasPais
        '
        ChartArea1.Name = "ChartArea1"
        Me.chaEstadisticasPais.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chaEstadisticasPais.Legends.Add(Legend1)
        Me.chaEstadisticasPais.Location = New System.Drawing.Point(374, 19)
        Me.chaEstadisticasPais.Name = "chaEstadisticasPais"
        Me.chaEstadisticasPais.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Cantidad de Libros"
        Me.chaEstadisticasPais.Series.Add(Series1)
        Me.chaEstadisticasPais.Size = New System.Drawing.Size(591, 403)
        Me.chaEstadisticasPais.TabIndex = 2
        Me.chaEstadisticasPais.Text = "Chart1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnImprimir)
        Me.GroupBox1.Controls.Add(Me.btnExportar)
        Me.GroupBox1.Controls.Add(Me.dgvGrilla)
        Me.GroupBox1.Controls.Add(Me.chaEstadisticasPais)
        Me.GroupBox1.Controls.Add(Me.btnMostrar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(971, 487)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estadisticas de libros ordenados por pais"
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Location = New System.Drawing.Point(551, 428)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(134, 53)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.Text = "IMPRIMIR"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Location = New System.Drawing.Point(691, 428)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(134, 53)
        Me.btnExportar.TabIndex = 3
        Me.btnExportar.Text = "EXPORTAR CSV"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'DialogoImpresora
        '
        Me.DialogoImpresora.UseEXDialog = True
        '
        'DocumentoImprimir
        '
        '
        'frm10estadisticasLibrosPais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 511)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm10estadisticasLibrosPais"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estadísticas - Libros por país"
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chaEstadisticasPais, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMostrar As Button
    Friend WithEvents dgvGrilla As DataGridView
    Friend WithEvents chaEstadisticasPais As DataVisualization.Charting.Chart
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents DialogoImpresora As PrintDialog
    Friend WithEvents DocumentoImprimir As Printing.PrintDocument
End Class
