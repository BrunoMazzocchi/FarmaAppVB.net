﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnImprimir = New MaterialSkin.Controls.MaterialButton()
        Me.gbEncontrados.SuspendLayout()
        CType(Me.dgvProductosFiltrados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbEncontrados
        '
        Me.gbEncontrados.Controls.Add(Me.dgvProductosFiltrados)
        Me.gbEncontrados.Location = New System.Drawing.Point(15, 79)
        Me.gbEncontrados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbEncontrados.Name = "gbEncontrados"
        Me.gbEncontrados.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbEncontrados.Size = New System.Drawing.Size(925, 399)
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
        Me.dgvProductosFiltrados.Location = New System.Drawing.Point(3, 17)
        Me.dgvProductosFiltrados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvProductosFiltrados.Name = "dgvProductosFiltrados"
        Me.dgvProductosFiltrados.ReadOnly = True
        Me.dgvProductosFiltrados.RowHeadersWidth = 51
        Me.dgvProductosFiltrados.RowTemplate.Height = 24
        Me.dgvProductosFiltrados.Size = New System.Drawing.Size(919, 380)
        Me.dgvProductosFiltrados.TabIndex = 0
        '
        'btnImprimir
        '
        Me.btnImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnImprimir.Depth = 0
        Me.btnImprimir.DrawShadows = True
        Me.btnImprimir.HighEmphasis = True
        Me.btnImprimir.Icon = Nothing
        Me.btnImprimir.Location = New System.Drawing.Point(656, 23)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnImprimir.MaximumSize = New System.Drawing.Size(211, 44)
        Me.btnImprimir.MinimumSize = New System.Drawing.Size(211, 44)
        Me.btnImprimir.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(211, 44)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnImprimir.UseAccentColor = False
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'frmProductoBuscado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 481)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.gbEncontrados)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(970, 528)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(970, 528)
        Me.Name = "frmProductoBuscado"
        Me.Text = "Encontrado"
        Me.gbEncontrados.ResumeLayout(False)
        CType(Me.dgvProductosFiltrados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbEncontrados As GroupBox
    Friend WithEvents dgvProductosFiltrados As DataGridView
    Friend WithEvents btnImprimir As MaterialSkin.Controls.MaterialButton
End Class
