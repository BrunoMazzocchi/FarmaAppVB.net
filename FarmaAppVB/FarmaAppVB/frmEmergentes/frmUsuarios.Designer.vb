<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.gbTblUsuario = New System.Windows.Forms.GroupBox()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Farma24BDDS = New FarmaAppVB.Farma24BDDS()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCerrar = New MaterialSkin.Controls.MaterialButton()
        Me.btnEliminar = New MaterialSkin.Controls.MaterialButton()
        Me.btnEditar = New MaterialSkin.Controls.MaterialButton()
        Me.btnAgregar = New MaterialSkin.Controls.MaterialButton()
        Me.btnNuevo = New MaterialSkin.Controls.MaterialButton()
        Me.UsuarioTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.UsuarioTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSeguridad = New MaterialSkin.Controls.MaterialButton()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NombreUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtIdUser = New System.Windows.Forms.TextBox()
        Me.gbTblUsuario.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbTblUsuario
        '
        Me.gbTblUsuario.Controls.Add(Me.dgvUsuarios)
        Me.gbTblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTblUsuario.Location = New System.Drawing.Point(13, 262)
        Me.gbTblUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.gbTblUsuario.Name = "gbTblUsuario"
        Me.gbTblUsuario.Padding = New System.Windows.Forms.Padding(4)
        Me.gbTblUsuario.Size = New System.Drawing.Size(733, 283)
        Me.gbTblUsuario.TabIndex = 0
        Me.gbTblUsuario.TabStop = False
        Me.gbTblUsuario.Text = "Datos de Usuarios"
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.AutoGenerateColumns = False
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreUserDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.EmailUserDataGridViewTextBoxColumn, Me.DireccionUserDataGridViewTextBoxColumn})
        Me.dgvUsuarios.DataSource = Me.UsuarioBindingSource
        Me.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUsuarios.Location = New System.Drawing.Point(4, 23)
        Me.dgvUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.RowHeadersWidth = 51
        Me.dgvUsuarios.Size = New System.Drawing.Size(725, 256)
        Me.dgvUsuarios.TabIndex = 0
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.Farma24BDDS
        '
        'Farma24BDDS
        '
        Me.Farma24BDDS.DataSetName = "Farma24BDDS"
        Me.Farma24BDDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Controls.Add(Me.btnCerrar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(759, -12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(313, 585)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCerrar.Depth = 0
        Me.btnCerrar.DrawShadows = True
        Me.btnCerrar.HighEmphasis = True
        Me.btnCerrar.Icon = Nothing
        Me.btnCerrar.Location = New System.Drawing.Point(83, 410)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCerrar.MaximumSize = New System.Drawing.Size(157, 36)
        Me.btnCerrar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(116, 36)
        Me.btnCerrar.TabIndex = 12
        Me.btnCerrar.Text = "           Cerrar           "
        Me.btnCerrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnCerrar.UseAccentColor = False
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEliminar.Depth = 0
        Me.btnEliminar.DrawShadows = True
        Me.btnEliminar.HighEmphasis = True
        Me.btnEliminar.Icon = Nothing
        Me.btnEliminar.Location = New System.Drawing.Point(83, 337)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnEliminar.MaximumSize = New System.Drawing.Size(157, 36)
        Me.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(113, 36)
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.Text = "       Eliminar      "
        Me.btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnEliminar.UseAccentColor = False
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEditar.Depth = 0
        Me.btnEditar.DrawShadows = True
        Me.btnEditar.HighEmphasis = True
        Me.btnEditar.Icon = Nothing
        Me.btnEditar.Location = New System.Drawing.Point(83, 271)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnEditar.MaximumSize = New System.Drawing.Size(157, 36)
        Me.btnEditar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(114, 36)
        Me.btnEditar.TabIndex = 10
        Me.btnEditar.Text = "            Editar           "
        Me.btnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnEditar.UseAccentColor = False
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAgregar.Depth = 0
        Me.btnAgregar.DrawShadows = True
        Me.btnAgregar.HighEmphasis = True
        Me.btnAgregar.Icon = Nothing
        Me.btnAgregar.Location = New System.Drawing.Point(83, 201)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAgregar.MaximumSize = New System.Drawing.Size(157, 36)
        Me.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(116, 36)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "        Agregar     "
        Me.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnAgregar.UseAccentColor = False
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnNuevo.Depth = 0
        Me.btnNuevo.DrawShadows = True
        Me.btnNuevo.HighEmphasis = True
        Me.btnNuevo.Icon = Nothing
        Me.btnNuevo.Location = New System.Drawing.Point(83, 129)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnNuevo.MaximumSize = New System.Drawing.Size(157, 36)
        Me.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(119, 36)
        Me.btnNuevo.TabIndex = 8
        Me.btnNuevo.Text = "              Nuevo              "
        Me.btnNuevo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnNuevo.UseAccentColor = False
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtIdUser)
        Me.GroupBox2.Controls.Add(Me.btnSeguridad)
        Me.GroupBox2.Controls.Add(Me.txtDireccion)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtEmail)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtPwd)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtApellido)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtUsername)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(733, 246)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingrese los datos de Usuario"
        '
        'btnSeguridad
        '
        Me.btnSeguridad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSeguridad.Depth = 0
        Me.btnSeguridad.DrawShadows = True
        Me.btnSeguridad.HighEmphasis = True
        Me.btnSeguridad.Icon = Nothing
        Me.btnSeguridad.Location = New System.Drawing.Point(539, 170)
        Me.btnSeguridad.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSeguridad.MaximumSize = New System.Drawing.Size(157, 36)
        Me.btnSeguridad.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSeguridad.Name = "btnSeguridad"
        Me.btnSeguridad.Size = New System.Drawing.Size(126, 36)
        Me.btnSeguridad.TabIndex = 13
        Me.btnSeguridad.Text = "       Seguridad      "
        Me.btnSeguridad.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnSeguridad.UseAccentColor = False
        Me.btnSeguridad.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "direccionUser", True))
        Me.txtDireccion.Location = New System.Drawing.Point(509, 63)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(200, 26)
        Me.txtDireccion.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(505, 37)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Dirección:"
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "emailUser", True))
        Me.txtEmail.Location = New System.Drawing.Point(276, 203)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 26)
        Me.txtEmail.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(272, 177)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Email:"
        '
        'txtPwd
        '
        Me.txtPwd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "pwd", True))
        Me.txtPwd.Location = New System.Drawing.Point(276, 132)
        Me.txtPwd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(200, 26)
        Me.txtPwd.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(272, 106)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Contraseña:"
        '
        'txtApellido
        '
        Me.txtApellido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "apellidos", True))
        Me.txtApellido.Location = New System.Drawing.Point(276, 63)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(200, 26)
        Me.txtApellido.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(272, 37)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Apellido:"
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "nombres", True))
        Me.txtNombre.Location = New System.Drawing.Point(13, 203)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(200, 26)
        Me.txtNombre.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 177)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre:"
        '
        'txtUsername
        '
        Me.txtUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "nombreUser", True))
        Me.txtUsername.Location = New System.Drawing.Point(13, 132)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(200, 26)
        Me.txtUsername.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id Usuario:"
        '
        'NombreUserDataGridViewTextBoxColumn
        '
        Me.NombreUserDataGridViewTextBoxColumn.DataPropertyName = "nombreUser"
        Me.NombreUserDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.NombreUserDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreUserDataGridViewTextBoxColumn.Name = "NombreUserDataGridViewTextBoxColumn"
        Me.NombreUserDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreUserDataGridViewTextBoxColumn.Width = 125
        '
        'NombresDataGridViewTextBoxColumn
        '
        Me.NombresDataGridViewTextBoxColumn.DataPropertyName = "nombres"
        Me.NombresDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombresDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombresDataGridViewTextBoxColumn.Name = "NombresDataGridViewTextBoxColumn"
        Me.NombresDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombresDataGridViewTextBoxColumn.Width = 125
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        Me.ApellidosDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApellidosDataGridViewTextBoxColumn.Width = 125
        '
        'EmailUserDataGridViewTextBoxColumn
        '
        Me.EmailUserDataGridViewTextBoxColumn.DataPropertyName = "emailUser"
        Me.EmailUserDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailUserDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailUserDataGridViewTextBoxColumn.Name = "EmailUserDataGridViewTextBoxColumn"
        Me.EmailUserDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmailUserDataGridViewTextBoxColumn.Width = 125
        '
        'DireccionUserDataGridViewTextBoxColumn
        '
        Me.DireccionUserDataGridViewTextBoxColumn.DataPropertyName = "direccionUser"
        Me.DireccionUserDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionUserDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DireccionUserDataGridViewTextBoxColumn.Name = "DireccionUserDataGridViewTextBoxColumn"
        Me.DireccionUserDataGridViewTextBoxColumn.ReadOnly = True
        Me.DireccionUserDataGridViewTextBoxColumn.Width = 125
        '
        'txtIdUser
        '
        Me.txtIdUser.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "idUser", True))
        Me.txtIdUser.Location = New System.Drawing.Point(13, 63)
        Me.txtIdUser.Name = "txtIdUser"
        Me.txtIdUser.Size = New System.Drawing.Size(200, 26)
        Me.txtIdUser.TabIndex = 14
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 558)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbTblUsuario)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1087, 605)
        Me.MinimumSize = New System.Drawing.Size(1087, 605)
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        Me.gbTblUsuario.ResumeLayout(False)
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbTblUsuario As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnEliminar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnEditar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnAgregar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnNuevo As MaterialSkin.Controls.MaterialButton
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents Farma24BDDS As Farma24BDDS
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As Farma24BDDSTableAdapters.UsuarioTableAdapter
    Friend WithEvents btnCerrar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSeguridad As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPwd As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NombreUserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailUserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionUserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtIdUser As TextBox
End Class
