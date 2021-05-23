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
        Me.IdUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PwdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Farma24BDDS = New FarmaAppVB.Farma24BDDS()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        Me.btnEliminar = New MaterialSkin.Controls.MaterialButton()
        Me.btnEditar = New MaterialSkin.Controls.MaterialButton()
        Me.btnAgregar = New MaterialSkin.Controls.MaterialButton()
        Me.btnNuevo = New MaterialSkin.Controls.MaterialButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
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
        Me.txtIdUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UsuarioTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.UsuarioTableAdapter()
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
        Me.gbTblUsuario.Location = New System.Drawing.Point(12, 12)
        Me.gbTblUsuario.Name = "gbTblUsuario"
        Me.gbTblUsuario.Size = New System.Drawing.Size(550, 230)
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
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdUserDataGridViewTextBoxColumn, Me.NombreUserDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.PwdDataGridViewTextBoxColumn, Me.EmailUserDataGridViewTextBoxColumn, Me.DireccionUserDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.dgvUsuarios.DataSource = Me.UsuarioBindingSource
        Me.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUsuarios.Location = New System.Drawing.Point(3, 19)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.Size = New System.Drawing.Size(544, 208)
        Me.dgvUsuarios.TabIndex = 0
        '
        'IdUserDataGridViewTextBoxColumn
        '
        Me.IdUserDataGridViewTextBoxColumn.DataPropertyName = "idUser"
        Me.IdUserDataGridViewTextBoxColumn.HeaderText = "idUser"
        Me.IdUserDataGridViewTextBoxColumn.Name = "IdUserDataGridViewTextBoxColumn"
        Me.IdUserDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreUserDataGridViewTextBoxColumn
        '
        Me.NombreUserDataGridViewTextBoxColumn.DataPropertyName = "nombreUser"
        Me.NombreUserDataGridViewTextBoxColumn.HeaderText = "nombreUser"
        Me.NombreUserDataGridViewTextBoxColumn.Name = "NombreUserDataGridViewTextBoxColumn"
        Me.NombreUserDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombresDataGridViewTextBoxColumn
        '
        Me.NombresDataGridViewTextBoxColumn.DataPropertyName = "nombres"
        Me.NombresDataGridViewTextBoxColumn.HeaderText = "nombres"
        Me.NombresDataGridViewTextBoxColumn.Name = "NombresDataGridViewTextBoxColumn"
        Me.NombresDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        Me.ApellidosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PwdDataGridViewTextBoxColumn
        '
        Me.PwdDataGridViewTextBoxColumn.DataPropertyName = "pwd"
        Me.PwdDataGridViewTextBoxColumn.HeaderText = "pwd"
        Me.PwdDataGridViewTextBoxColumn.Name = "PwdDataGridViewTextBoxColumn"
        Me.PwdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailUserDataGridViewTextBoxColumn
        '
        Me.EmailUserDataGridViewTextBoxColumn.DataPropertyName = "emailUser"
        Me.EmailUserDataGridViewTextBoxColumn.HeaderText = "emailUser"
        Me.EmailUserDataGridViewTextBoxColumn.Name = "EmailUserDataGridViewTextBoxColumn"
        Me.EmailUserDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionUserDataGridViewTextBoxColumn
        '
        Me.DireccionUserDataGridViewTextBoxColumn.DataPropertyName = "direccionUser"
        Me.DireccionUserDataGridViewTextBoxColumn.HeaderText = "direccionUser"
        Me.DireccionUserDataGridViewTextBoxColumn.Name = "DireccionUserDataGridViewTextBoxColumn"
        Me.DireccionUserDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.GroupBox1.Controls.Add(Me.MaterialButton1)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(569, -10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 475)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'MaterialButton1
        '
        Me.MaterialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton1.Depth = 0
        Me.MaterialButton1.DrawShadows = True
        Me.MaterialButton1.HighEmphasis = True
        Me.MaterialButton1.Icon = Nothing
        Me.MaterialButton1.Location = New System.Drawing.Point(62, 333)
        Me.MaterialButton1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaterialButton1.MaximumSize = New System.Drawing.Size(118, 29)
        Me.MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton1.Name = "MaterialButton1"
        Me.MaterialButton1.Size = New System.Drawing.Size(116, 29)
        Me.MaterialButton1.TabIndex = 12
        Me.MaterialButton1.Text = "           Cerrar           "
        Me.MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton1.UseAccentColor = False
        Me.MaterialButton1.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEliminar.Depth = 0
        Me.btnEliminar.DrawShadows = True
        Me.btnEliminar.HighEmphasis = True
        Me.btnEliminar.Icon = Nothing
        Me.btnEliminar.Location = New System.Drawing.Point(62, 274)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnEliminar.MaximumSize = New System.Drawing.Size(118, 29)
        Me.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(113, 29)
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
        Me.btnEditar.Location = New System.Drawing.Point(62, 220)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnEditar.MaximumSize = New System.Drawing.Size(118, 29)
        Me.btnEditar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(114, 29)
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
        Me.btnAgregar.Location = New System.Drawing.Point(62, 163)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnAgregar.MaximumSize = New System.Drawing.Size(118, 29)
        Me.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(116, 29)
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
        Me.btnNuevo.Location = New System.Drawing.Point(62, 105)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnNuevo.MaximumSize = New System.Drawing.Size(118, 29)
        Me.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(118, 29)
        Me.btnNuevo.TabIndex = 8
        Me.btnNuevo.Text = "              Nuevo              "
        Me.btnNuevo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnNuevo.UseAccentColor = False
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
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
        Me.GroupBox2.Controls.Add(Me.txtIdUser)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 249)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(550, 200)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingrese los datos de Usuario"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(382, 51)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(151, 23)
        Me.txtDireccion.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(379, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Dirección:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(207, 165)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(151, 23)
        Me.txtEmail.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(204, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Email:"
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(207, 107)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(151, 23)
        Me.txtPwd.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(204, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Contraseña:"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(207, 51)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(151, 23)
        Me.txtApellido.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(204, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Apellido:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(10, 165)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(151, 23)
        Me.txtNombre.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(10, 107)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(151, 23)
        Me.txtUsername.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username:"
        '
        'txtIdUser
        '
        Me.txtIdUser.Location = New System.Drawing.Point(10, 51)
        Me.txtIdUser.Name = "txtIdUser"
        Me.txtIdUser.Size = New System.Drawing.Size(151, 23)
        Me.txtIdUser.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id Usuario:"
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 461)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbTblUsuario)
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
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEliminar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnEditar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnAgregar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnNuevo As MaterialSkin.Controls.MaterialButton
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
    Friend WithEvents txtIdUser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents Farma24BDDS As Farma24BDDS
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As Farma24BDDSTableAdapters.UsuarioTableAdapter
    Friend WithEvents IdUserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreUserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PwdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailUserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionUserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
End Class
