<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm04listadosAutores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm04listadosAutores))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.dgvGrilla = New System.Windows.Forms.DataGridView()
        Me.DialogoImpresora = New System.Windows.Forms.PrintDialog()
        Me.DocumentoImprimir = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnImprimir)
        Me.GroupBox1.Controls.Add(Me.btnExportar)
        Me.GroupBox1.Controls.Add(Me.btnListar)
        Me.GroupBox1.Controls.Add(Me.dgvGrilla)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 487)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado general de autores"
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Location = New System.Drawing.Point(94, 458)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(100, 23)
        Me.btnImprimir.TabIndex = 23
        Me.btnImprimir.Text = "IMPRIMIR"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Location = New System.Drawing.Point(200, 458)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(100, 23)
        Me.btnExportar.TabIndex = 22
        Me.btnExportar.Text = "EXPORTAR"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnListar
        '
        Me.btnListar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListar.Location = New System.Drawing.Point(306, 458)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(100, 23)
        Me.btnListar.TabIndex = 21
        Me.btnListar.Text = "LISTAR"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'dgvGrilla
        '
        Me.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrilla.Location = New System.Drawing.Point(6, 19)
        Me.dgvGrilla.Name = "dgvGrilla"
        Me.dgvGrilla.Size = New System.Drawing.Size(400, 433)
        Me.dgvGrilla.TabIndex = 1
        '
        'DialogoImpresora
        '
        Me.DialogoImpresora.UseEXDialog = True
        '
        'DocumentoImprimir
        '
        '
        'frm04listadosAutores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 511)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm04listadosAutores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de autores"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnListar As Button
    Friend WithEvents dgvGrilla As DataGridView
    Friend WithEvents DialogoImpresora As PrintDialog
    Friend WithEvents DocumentoImprimir As Printing.PrintDocument
End Class
