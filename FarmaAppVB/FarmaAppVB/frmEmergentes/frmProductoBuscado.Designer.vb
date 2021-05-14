<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductoBuscado
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
        Me.gbEncontrados = New System.Windows.Forms.GroupBox()
        Me.dgvProductosFiltrados = New System.Windows.Forms.DataGridView()
        Me.gbEncontrados.SuspendLayout()
        CType(Me.dgvProductosFiltrados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbEncontrados
        '
        Me.gbEncontrados.Controls.Add(Me.dgvProductosFiltrados)
        Me.gbEncontrados.Location = New System.Drawing.Point(52, 42)
        Me.gbEncontrados.Name = "gbEncontrados"
        Me.gbEncontrados.Size = New System.Drawing.Size(858, 399)
        Me.gbEncontrados.TabIndex = 0
        Me.gbEncontrados.TabStop = False
        Me.gbEncontrados.Text = "Encontrado"
        '
        'dgvProductosFiltrados
        '
        Me.dgvProductosFiltrados.AllowUserToAddRows = False
        Me.dgvProductosFiltrados.AllowUserToDeleteRows = False
        Me.dgvProductosFiltrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductosFiltrados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProductosFiltrados.Location = New System.Drawing.Point(3, 18)
        Me.dgvProductosFiltrados.Name = "dgvProductosFiltrados"
        Me.dgvProductosFiltrados.ReadOnly = True
        Me.dgvProductosFiltrados.RowHeadersWidth = 51
        Me.dgvProductosFiltrados.RowTemplate.Height = 24
        Me.dgvProductosFiltrados.Size = New System.Drawing.Size(852, 378)
        Me.dgvProductosFiltrados.TabIndex = 0
        '
        'frmProductoBuscado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 491)
        Me.Controls.Add(Me.gbEncontrados)
        Me.Name = "frmProductoBuscado"
        Me.Text = "Encontrado"
        Me.gbEncontrados.ResumeLayout(False)
        CType(Me.dgvProductosFiltrados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbEncontrados As GroupBox
    Friend WithEvents dgvProductosFiltrados As DataGridView
End Class
