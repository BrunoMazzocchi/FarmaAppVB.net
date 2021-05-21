<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportes
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
        Me.btnLab = New MaterialSkin.Controls.MaterialButton()
        Me.btnPresentacion = New MaterialSkin.Controls.MaterialButton()
        Me.btnProductos = New MaterialSkin.Controls.MaterialButton()
        Me.SuspendLayout()
        '
        'btnLab
        '
        Me.btnLab.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLab.Depth = 0
        Me.btnLab.DrawShadows = True
        Me.btnLab.HighEmphasis = True
        Me.btnLab.Icon = Nothing
        Me.btnLab.Location = New System.Drawing.Point(368, 259)
        Me.btnLab.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnLab.MaximumSize = New System.Drawing.Size(158, 36)
        Me.btnLab.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnLab.Name = "btnLab"
        Me.btnLab.Size = New System.Drawing.Size(158, 36)
        Me.btnLab.TabIndex = 5
        Me.btnLab.Text = "            Laboratorio           "
        Me.btnLab.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnLab.UseAccentColor = False
        Me.btnLab.UseVisualStyleBackColor = True
        '
        'btnPresentacion
        '
        Me.btnPresentacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPresentacion.Depth = 0
        Me.btnPresentacion.DrawShadows = True
        Me.btnPresentacion.HighEmphasis = True
        Me.btnPresentacion.Icon = Nothing
        Me.btnPresentacion.Location = New System.Drawing.Point(368, 189)
        Me.btnPresentacion.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnPresentacion.MaximumSize = New System.Drawing.Size(158, 36)
        Me.btnPresentacion.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPresentacion.Name = "btnPresentacion"
        Me.btnPresentacion.Size = New System.Drawing.Size(158, 36)
        Me.btnPresentacion.TabIndex = 4
        Me.btnPresentacion.Text = "        Presentacion      "
        Me.btnPresentacion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnPresentacion.UseAccentColor = False
        Me.btnPresentacion.UseVisualStyleBackColor = True
        '
        'btnProductos
        '
        Me.btnProductos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnProductos.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnProductos.Depth = 0
        Me.btnProductos.DrawShadows = True
        Me.btnProductos.HighEmphasis = True
        Me.btnProductos.Icon = Nothing
        Me.btnProductos.Location = New System.Drawing.Point(368, 118)
        Me.btnProductos.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnProductos.MaximumSize = New System.Drawing.Size(158, 36)
        Me.btnProductos.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(157, 36)
        Me.btnProductos.TabIndex = 3
        Me.btnProductos.Text = "              Productos              "
        Me.btnProductos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnProductos.UseAccentColor = False
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'frmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 415)
        Me.Controls.Add(Me.btnLab)
        Me.Controls.Add(Me.btnPresentacion)
        Me.Controls.Add(Me.btnProductos)
        Me.MaximumSize = New System.Drawing.Size(923, 462)
        Me.MinimumSize = New System.Drawing.Size(923, 462)
        Me.Name = "frmReportes"
        Me.Text = "frmReportes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLab As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnPresentacion As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnProductos As MaterialSkin.Controls.MaterialButton
End Class
