<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIniciarSesion
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
        Me.gbTexto = New System.Windows.Forms.GroupBox()
        Me.gbControles = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.gbTexto.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbTexto
        '
        Me.gbTexto.BackColor = System.Drawing.Color.DodgerBlue
        Me.gbTexto.Controls.Add(Me.gbControles)
        Me.gbTexto.Location = New System.Drawing.Point(-28, -57)
        Me.gbTexto.Name = "gbTexto"
        Me.gbTexto.Size = New System.Drawing.Size(370, 577)
        Me.gbTexto.TabIndex = 0
        Me.gbTexto.TabStop = False
        '
        'gbControles
        '
        Me.gbControles.Location = New System.Drawing.Point(409, 21)
        Me.gbControles.Name = "gbControles"
        Me.gbControles.Size = New System.Drawing.Size(712, 556)
        Me.gbControles.TabIndex = 1
        Me.gbControles.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(515, 252)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(333, 22)
        Me.txtNombre.TabIndex = 1
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(515, 280)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(333, 22)
        Me.txtPwd.TabIndex = 2
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(515, 377)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(152, 23)
        Me.btnIniciar.TabIndex = 3
        Me.btnIniciar.Text = "Iniciar Sesion"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(705, 377)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(143, 23)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'frmIniciarSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(998, 477)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.gbTexto)
        Me.Name = "frmIniciarSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesion"
        Me.gbTexto.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbTexto As GroupBox
    Friend WithEvents gbControles As GroupBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPwd As TextBox
    Friend WithEvents btnIniciar As Button
    Friend WithEvents btnCerrar As Button
End Class
