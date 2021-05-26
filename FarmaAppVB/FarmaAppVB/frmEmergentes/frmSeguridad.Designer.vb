<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeguridad
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCerrar = New MaterialSkin.Controls.MaterialButton()
        Me.btnEliminar = New MaterialSkin.Controls.MaterialButton()
        Me.btnEditar = New MaterialSkin.Controls.MaterialButton()
        Me.btnAgregar = New MaterialSkin.Controls.MaterialButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvUserRol = New System.Windows.Forms.DataGridView()
        Me.UserRolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Farma24BDDS = New FarmaAppVB.Farma24BDDS()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvRol = New System.Windows.Forms.DataGridView()
        Me.RolNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserRolTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.userRolTableAdapter()
        Me.RolTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.RolTableAdapter()
        Me.UsuarioTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.UsuarioTableAdapter()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.cbIdUserRol = New System.Windows.Forms.ComboBox()
        Me.cbUser = New System.Windows.Forms.ComboBox()
        Me.cbIdRol = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvUserRol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserRolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvRol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Controls.Add(Me.btnCerrar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Location = New System.Drawing.Point(549, -15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 555)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCerrar.Depth = 0
        Me.btnCerrar.DrawShadows = True
        Me.btnCerrar.HighEmphasis = True
        Me.btnCerrar.Icon = Nothing
        Me.btnCerrar.Location = New System.Drawing.Point(77, 330)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnCerrar.MaximumSize = New System.Drawing.Size(118, 29)
        Me.btnCerrar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(116, 29)
        Me.btnCerrar.TabIndex = 17
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
        Me.btnEliminar.Location = New System.Drawing.Point(77, 271)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnEliminar.MaximumSize = New System.Drawing.Size(118, 29)
        Me.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(113, 29)
        Me.btnEliminar.TabIndex = 16
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
        Me.btnEditar.Location = New System.Drawing.Point(77, 217)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnEditar.MaximumSize = New System.Drawing.Size(118, 29)
        Me.btnEditar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(114, 29)
        Me.btnEditar.TabIndex = 15
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
        Me.btnAgregar.Location = New System.Drawing.Point(77, 160)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnAgregar.MaximumSize = New System.Drawing.Size(118, 29)
        Me.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(116, 29)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "        Agregar     "
        Me.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnAgregar.UseAccentColor = False
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvUserRol)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(532, 175)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos UserRol"
        '
        'dgvUserRol
        '
        Me.dgvUserRol.AllowUserToAddRows = False
        Me.dgvUserRol.AllowUserToDeleteRows = False
        Me.dgvUserRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserRol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUserRol.Location = New System.Drawing.Point(3, 18)
        Me.dgvUserRol.Name = "dgvUserRol"
        Me.dgvUserRol.ReadOnly = True
        Me.dgvUserRol.RowHeadersWidth = 51
        Me.dgvUserRol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUserRol.Size = New System.Drawing.Size(526, 154)
        Me.dgvUserRol.TabIndex = 0
        '
        'UserRolBindingSource
        '
        Me.UserRolBindingSource.DataMember = "userRol"
        Me.UserRolBindingSource.DataSource = Me.Farma24BDDS
        '
        'Farma24BDDS
        '
        Me.Farma24BDDS.DataSetName = "Farma24BDDS"
        Me.Farma24BDDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvRol)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(10, 350)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(532, 175)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Guia roles"
        '
        'dgvRol
        '
        Me.dgvRol.AllowUserToAddRows = False
        Me.dgvRol.AllowUserToDeleteRows = False
        Me.dgvRol.AutoGenerateColumns = False
        Me.dgvRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRol.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RolNameDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn})
        Me.dgvRol.DataSource = Me.RolBindingSource1
        Me.dgvRol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRol.Location = New System.Drawing.Point(3, 18)
        Me.dgvRol.Name = "dgvRol"
        Me.dgvRol.ReadOnly = True
        Me.dgvRol.RowHeadersWidth = 51
        Me.dgvRol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRol.Size = New System.Drawing.Size(526, 154)
        Me.dgvRol.TabIndex = 0
        '
        'RolNameDataGridViewTextBoxColumn
        '
        Me.RolNameDataGridViewTextBoxColumn.DataPropertyName = "rolName"
        Me.RolNameDataGridViewTextBoxColumn.HeaderText = "Nombre rol"
        Me.RolNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RolNameDataGridViewTextBoxColumn.Name = "RolNameDataGridViewTextBoxColumn"
        Me.RolNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.RolNameDataGridViewTextBoxColumn.Width = 125
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 125
        '
        'RolBindingSource1
        '
        Me.RolBindingSource1.DataMember = "Rol"
        Me.RolBindingSource1.DataSource = Me.Farma24BDDS
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.Farma24BDDS
        '
        'RolBindingSource
        '
        Me.RolBindingSource.DataMember = "Rol"
        Me.RolBindingSource.DataSource = Me.Farma24BDDS
        '
        'UserRolTableAdapter
        '
        Me.UserRolTableAdapter.ClearBeforeFill = True
        '
        'RolTableAdapter
        '
        Me.RolTableAdapter.ClearBeforeFill = True
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'gbDatos
        '
        Me.gbDatos.Controls.Add(Me.cbIdUserRol)
        Me.gbDatos.Controls.Add(Me.cbUser)
        Me.gbDatos.Controls.Add(Me.cbIdRol)
        Me.gbDatos.Controls.Add(Me.Label3)
        Me.gbDatos.Controls.Add(Me.Label2)
        Me.gbDatos.Controls.Add(Me.Label1)
        Me.gbDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatos.Location = New System.Drawing.Point(10, 7)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(532, 175)
        Me.gbDatos.TabIndex = 4
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Ingrese los datos"
        '
        'cbIdUserRol
        '
        Me.cbIdUserRol.FormattingEnabled = True
        Me.cbIdUserRol.Location = New System.Drawing.Point(179, 37)
        Me.cbIdUserRol.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbIdUserRol.Name = "cbIdUserRol"
        Me.cbIdUserRol.Size = New System.Drawing.Size(173, 24)
        Me.cbIdUserRol.TabIndex = 8
        '
        'cbUser
        '
        Me.cbUser.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.UserRolBindingSource, "idUser", True))
        Me.cbUser.DataSource = Me.UsuarioBindingSource
        Me.cbUser.DisplayMember = "nombreUser"
        Me.cbUser.FormattingEnabled = True
        Me.cbUser.Location = New System.Drawing.Point(179, 138)
        Me.cbUser.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbUser.Name = "cbUser"
        Me.cbUser.Size = New System.Drawing.Size(173, 24)
        Me.cbUser.TabIndex = 7
        Me.cbUser.ValueMember = "idUser"
        '
        'cbIdRol
        '
        Me.cbIdRol.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RolBindingSource1, "idRol", True))
        Me.cbIdRol.DataSource = Me.RolBindingSource
        Me.cbIdRol.DisplayMember = "rolName"
        Me.cbIdRol.Location = New System.Drawing.Point(179, 90)
        Me.cbIdRol.Name = "cbIdRol"
        Me.cbIdRol.Size = New System.Drawing.Size(173, 24)
        Me.cbIdRol.TabIndex = 6
        Me.cbIdRol.ValueMember = "idRol"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(176, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Usuario: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre rol:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(176, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User/Rol"
        '
        'frmSeguridad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 544)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbDatos)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 583)
        Me.MinimumSize = New System.Drawing.Size(800, 583)
        Me.Name = "frmSeguridad"
        Me.Text = "Seguridad"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvUserRol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserRolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvRol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvUserRol As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvRol As DataGridView
    Friend WithEvents Farma24BDDS As Farma24BDDS
    Friend WithEvents UserRolBindingSource As BindingSource
    Friend WithEvents UserRolTableAdapter As Farma24BDDSTableAdapters.userRolTableAdapter
    Friend WithEvents RolBindingSource As BindingSource
    Friend WithEvents RolTableAdapter As Farma24BDDSTableAdapters.RolTableAdapter
    Friend WithEvents RolBindingSource1 As BindingSource
    Friend WithEvents btnCerrar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnEliminar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnEditar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnAgregar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As Farma24BDDSTableAdapters.UsuarioTableAdapter
    Friend WithEvents gbDatos As GroupBox
    Friend WithEvents cbIdUserRol As ComboBox
    Friend WithEvents cbUser As ComboBox
    Friend WithEvents cbIdRol As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RolNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
