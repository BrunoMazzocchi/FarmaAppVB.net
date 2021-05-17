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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbTexto.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbTexto
        '
        Me.gbTexto.BackColor = System.Drawing.Color.DodgerBlue
        Me.gbTexto.Controls.Add(Me.Label1)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(88, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 56)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "  Farmacia 24" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " de septiembre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(583, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 33)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Inicie sesion"
        '
        'frmIniciarSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(998, 477)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.gbTexto)
        Me.Name = "frmIniciarSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesion"
        Me.gbTexto.ResumeLayout(False)
        Me.gbTexto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbTexto As GroupBox
    Friend WithEvents gbControles As GroupBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPwd As TextBox
    Friend WithEvents btnIniciar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
