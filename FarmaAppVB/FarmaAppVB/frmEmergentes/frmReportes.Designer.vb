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
        Me.btnPresentacion = New System.Windows.Forms.Button()
        Me.btnLab = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPresentacion
        '
        Me.btnPresentacion.Location = New System.Drawing.Point(377, 145)
        Me.btnPresentacion.Name = "btnPresentacion"
        Me.btnPresentacion.Size = New System.Drawing.Size(149, 49)
        Me.btnPresentacion.TabIndex = 0
        Me.btnPresentacion.Text = "Presentaciones"
        Me.btnPresentacion.UseVisualStyleBackColor = True
        '
        'btnLab
        '
        Me.btnLab.Location = New System.Drawing.Point(377, 200)
        Me.btnLab.Name = "btnLab"
        Me.btnLab.Size = New System.Drawing.Size(149, 50)
        Me.btnLab.TabIndex = 1
        Me.btnLab.Text = "Laboratorios"
        Me.btnLab.UseVisualStyleBackColor = True
        '
        'btnProductos
        '
        Me.btnProductos.Location = New System.Drawing.Point(377, 97)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(149, 42)
        Me.btnProductos.TabIndex = 2
        Me.btnProductos.Text = "Productos"
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'frmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 415)
        Me.Controls.Add(Me.btnProductos)
        Me.Controls.Add(Me.btnLab)
        Me.Controls.Add(Me.btnPresentacion)
        Me.Name = "frmReportes"
        Me.Text = "frmReportes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPresentacion As Button
    Friend WithEvents btnLab As Button
    Friend WithEvents btnProductos As Button
End Class
