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
        Me.btnEntrada = New MaterialSkin.Controls.MaterialButton()
        Me.btnSalida = New MaterialSkin.Controls.MaterialButton()
        Me.btnUsuario = New MaterialSkin.Controls.MaterialButton()
        Me.SuspendLayout()
        '
        'btnLab
        '
        Me.btnLab.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLab.Depth = 0
        Me.btnLab.DrawShadows = True
        Me.btnLab.HighEmphasis = True
        Me.btnLab.Icon = Nothing
        Me.btnLab.Location = New System.Drawing.Point(380, 124)
        Me.btnLab.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnLab.MaximumSize = New System.Drawing.Size(118, 29)
        Me.btnLab.MinimumSize = New System.Drawing.Size(160, 29)
        Me.btnLab.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnLab.Name = "btnLab"
        Me.btnLab.Size = New System.Drawing.Size(160, 29)
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
        Me.btnPresentacion.Location = New System.Drawing.Point(380, 68)
        Me.btnPresentacion.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnPresentacion.MaximumSize = New System.Drawing.Size(118, 29)
        Me.btnPresentacion.MinimumSize = New System.Drawing.Size(160, 29)
        Me.btnPresentacion.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPresentacion.Name = "btnPresentacion"
        Me.btnPresentacion.Size = New System.Drawing.Size(160, 29)
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
        Me.btnProductos.Location = New System.Drawing.Point(135, 68)
        Me.btnProductos.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnProductos.MaximumSize = New System.Drawing.Size(118, 29)
        Me.btnProductos.MinimumSize = New System.Drawing.Size(160, 29)
        Me.btnProductos.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(160, 29)
        Me.btnProductos.TabIndex = 3
        Me.btnProductos.Text = "              Productos              "
        Me.btnProductos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnProductos.UseAccentColor = False
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'btnEntrada
        '
        Me.btnEntrada.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEntrada.Depth = 0
        Me.btnEntrada.DrawShadows = True
        Me.btnEntrada.HighEmphasis = True
        Me.btnEntrada.Icon = Nothing
        Me.btnEntrada.Location = New System.Drawing.Point(135, 124)
        Me.btnEntrada.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnEntrada.MaximumSize = New System.Drawing.Size(160, 29)
        Me.btnEntrada.MinimumSize = New System.Drawing.Size(160, 29)
        Me.btnEntrada.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEntrada.Name = "btnEntrada"
        Me.btnEntrada.Size = New System.Drawing.Size(160, 29)
        Me.btnEntrada.TabIndex = 6
        Me.btnEntrada.Text = "            Historial Entradas           "
        Me.btnEntrada.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnEntrada.UseAccentColor = False
        Me.btnEntrada.UseVisualStyleBackColor = True
        '
        'btnSalida
        '
        Me.btnSalida.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSalida.Depth = 0
        Me.btnSalida.DrawShadows = True
        Me.btnSalida.HighEmphasis = True
        Me.btnSalida.Icon = Nothing
        Me.btnSalida.Location = New System.Drawing.Point(135, 183)
        Me.btnSalida.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnSalida.MaximumSize = New System.Drawing.Size(160, 29)
        Me.btnSalida.MinimumSize = New System.Drawing.Size(160, 29)
        Me.btnSalida.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSalida.Name = "btnSalida"
        Me.btnSalida.Size = New System.Drawing.Size(160, 29)
        Me.btnSalida.TabIndex = 7
        Me.btnSalida.Text = "            Historial Salidas           "
        Me.btnSalida.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnSalida.UseAccentColor = False
        Me.btnSalida.UseVisualStyleBackColor = True
        '
        'btnUsuario
        '
        Me.btnUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUsuario.Depth = 0
        Me.btnUsuario.DrawShadows = True
        Me.btnUsuario.HighEmphasis = True
        Me.btnUsuario.Icon = Nothing
        Me.btnUsuario.Location = New System.Drawing.Point(380, 183)
        Me.btnUsuario.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnUsuario.MaximumSize = New System.Drawing.Size(118, 29)
        Me.btnUsuario.MinimumSize = New System.Drawing.Size(160, 29)
        Me.btnUsuario.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(160, 29)
        Me.btnUsuario.TabIndex = 8
        Me.btnUsuario.Text = "            Usuarios           "
        Me.btnUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnUsuario.UseAccentColor = False
        Me.btnUsuario.UseVisualStyleBackColor = True
        '
        'frmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 344)
        Me.Controls.Add(Me.btnUsuario)
        Me.Controls.Add(Me.btnSalida)
        Me.Controls.Add(Me.btnEntrada)
        Me.Controls.Add(Me.btnLab)
        Me.Controls.Add(Me.btnPresentacion)
        Me.Controls.Add(Me.btnProductos)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(696, 383)
        Me.MinimumSize = New System.Drawing.Size(696, 383)
        Me.Name = "frmReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLab As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnPresentacion As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnProductos As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnEntrada As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnSalida As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnUsuario As MaterialSkin.Controls.MaterialButton
End Class
