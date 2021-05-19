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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbControles = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnIniciar = New System.Windows.Forms.Button()
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
        Me.gbTexto.Location = New System.Drawing.Point(-27, -55)
        Me.gbTexto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbTexto.Name = "gbTexto"
        Me.gbTexto.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbTexto.Size = New System.Drawing.Size(371, 577)
        Me.gbTexto.TabIndex = 0
        Me.gbTexto.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FarmaAppVB.My.Resources.Resources.EldianEmpire
        Me.PictureBox1.Location = New System.Drawing.Point(93, 246)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(88, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 58)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "  Farmacia 24" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " de septiembre"
        '
        'gbControles
        '
        Me.gbControles.Location = New System.Drawing.Point(409, 21)
        Me.gbControles.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbControles.Name = "gbControles"
        Me.gbControles.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbControles.Size = New System.Drawing.Size(712, 556)
        Me.gbControles.TabIndex = 1
        Me.gbControles.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(515, 252)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(333, 22)
        Me.txtNombre.TabIndex = 1
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(515, 281)
        Me.txtPwd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(333, 22)
        Me.txtPwd.TabIndex = 2
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(705, 357)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(143, 43)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(583, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 34)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Inicie sesion"
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(515, 357)
        Me.btnIniciar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(143, 43)
        Me.btnIniciar.TabIndex = 6
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'frmIniciarSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(995, 468)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.gbTexto)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1013, 515)
        Me.MinimumSize = New System.Drawing.Size(1013, 515)
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
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnIniciar As Button
End Class
