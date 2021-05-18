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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbControles = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbTexto.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbTexto
        '
        Me.gbTexto.BackColor = System.Drawing.Color.DodgerBlue
        Me.gbTexto.Controls.Add(Me.PictureBox1)
        Me.gbTexto.Controls.Add(Me.Label1)
        Me.gbTexto.Controls.Add(Me.gbControles)
        Me.gbTexto.Location = New System.Drawing.Point(-20, -45)
        Me.gbTexto.Margin = New System.Windows.Forms.Padding(2)
        Me.gbTexto.Name = "gbTexto"
        Me.gbTexto.Padding = New System.Windows.Forms.Padding(2)
        Me.gbTexto.Size = New System.Drawing.Size(278, 469)
        Me.gbTexto.TabIndex = 0
        Me.gbTexto.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(66, 110)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 48)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "  Farmacia 24" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " de septiembre"
        '
        'gbControles
        '
        Me.gbControles.Location = New System.Drawing.Point(307, 17)
        Me.gbControles.Margin = New System.Windows.Forms.Padding(2)
        Me.gbControles.Name = "gbControles"
        Me.gbControles.Padding = New System.Windows.Forms.Padding(2)
        Me.gbControles.Size = New System.Drawing.Size(534, 452)
        Me.gbControles.TabIndex = 1
        Me.gbControles.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(386, 205)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(251, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(386, 228)
        Me.txtPwd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(251, 20)
        Me.txtPwd.TabIndex = 2
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(386, 290)
        Me.btnIniciar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(114, 35)
        Me.btnIniciar.TabIndex = 3
        Me.btnIniciar.Text = "Iniciar Sesion"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(529, 290)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(107, 35)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(437, 123)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Inicie sesion"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FarmaAppVB.My.Resources.Resources.EldianEmpire
        Me.PictureBox1.Location = New System.Drawing.Point(70, 200)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmIniciarSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(748, 388)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.gbTexto)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(764, 427)
        Me.MinimumSize = New System.Drawing.Size(764, 427)
        Me.Name = "frmIniciarSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesion"
        Me.gbTexto.ResumeLayout(False)
        Me.gbTexto.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
End Class
