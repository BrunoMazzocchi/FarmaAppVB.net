<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPresentacion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.gbFondo = New System.Windows.Forms.GroupBox()
        Me.btnCerrar = New MaterialSkin.Controls.MaterialButton()
        Me.btnEliminar = New MaterialSkin.Controls.MaterialButton()
        Me.btnEditar = New MaterialSkin.Controls.MaterialButton()
        Me.btnAgregar = New MaterialSkin.Controls.MaterialButton()
        Me.btnNuevo = New MaterialSkin.Controls.MaterialButton()
        Me.gbContenedorDGV = New System.Windows.Forms.GroupBox()
        Me.dgvPresentacion = New System.Windows.Forms.DataGridView()
        Me.PresentacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Farma24BDDS = New FarmaAppVB.Farma24BDDS()
        Me.PresentacionTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.PresentacionTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtIdPres = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtViaAdmin = New System.Windows.Forms.TextBox()
        Me.txtNombreP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IdPresentacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrePresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViaAdminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbFondo.SuspendLayout()
        Me.gbContenedorDGV.SuspendLayout()
        CType(Me.dgvPresentacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresentacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbFondo
        '
        Me.gbFondo.BackColor = System.Drawing.Color.DodgerBlue
        Me.gbFondo.Controls.Add(Me.btnCerrar)
        Me.gbFondo.Controls.Add(Me.btnEliminar)
        Me.gbFondo.Controls.Add(Me.btnEditar)
        Me.gbFondo.Controls.Add(Me.btnAgregar)
        Me.gbFondo.Controls.Add(Me.btnNuevo)
        Me.gbFondo.Location = New System.Drawing.Point(768, -11)
        Me.gbFondo.Margin = New System.Windows.Forms.Padding(4)
        Me.gbFondo.Name = "gbFondo"
        Me.gbFondo.Padding = New System.Windows.Forms.Padding(4)
        Me.gbFondo.Size = New System.Drawing.Size(311, 561)
        Me.gbFondo.TabIndex = 0
        Me.gbFondo.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCerrar.Depth = 0
        Me.btnCerrar.DrawShadows = True
        Me.btnCerrar.HighEmphasis = True
        Me.btnCerrar.Icon = Nothing
        Me.btnCerrar.Location = New System.Drawing.Point(84, 382)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCerrar.MaximumSize = New System.Drawing.Size(151, 36)
        Me.btnCerrar.MinimumSize = New System.Drawing.Size(151, 36)
        Me.btnCerrar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(151, 36)
        Me.btnCerrar.TabIndex = 8
        Me.btnCerrar.Text = "       Cerrar      "
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
        Me.btnEliminar.Location = New System.Drawing.Point(84, 319)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnEliminar.MaximumSize = New System.Drawing.Size(151, 36)
        Me.btnEliminar.MinimumSize = New System.Drawing.Size(151, 36)
        Me.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(151, 36)
        Me.btnEliminar.TabIndex = 7
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
        Me.btnEditar.Location = New System.Drawing.Point(84, 252)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnEditar.MaximumSize = New System.Drawing.Size(157, 36)
        Me.btnEditar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(114, 36)
        Me.btnEditar.TabIndex = 6
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
        Me.btnAgregar.Location = New System.Drawing.Point(84, 182)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAgregar.MaximumSize = New System.Drawing.Size(157, 36)
        Me.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(116, 36)
        Me.btnAgregar.TabIndex = 5
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
        Me.btnNuevo.Location = New System.Drawing.Point(84, 111)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnNuevo.MaximumSize = New System.Drawing.Size(157, 36)
        Me.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(119, 36)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "              Nuevo              "
        Me.btnNuevo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnNuevo.UseAccentColor = False
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'gbContenedorDGV
        '
        Me.gbContenedorDGV.Controls.Add(Me.dgvPresentacion)
        Me.gbContenedorDGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbContenedorDGV.Location = New System.Drawing.Point(11, 225)
        Me.gbContenedorDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.gbContenedorDGV.Name = "gbContenedorDGV"
        Me.gbContenedorDGV.Padding = New System.Windows.Forms.Padding(4)
        Me.gbContenedorDGV.Size = New System.Drawing.Size(749, 304)
        Me.gbContenedorDGV.TabIndex = 1
        Me.gbContenedorDGV.TabStop = False
        Me.gbContenedorDGV.Text = "Datos Presentacion"
        '
        'dgvPresentacion
        '
        Me.dgvPresentacion.AllowUserToAddRows = False
        Me.dgvPresentacion.AllowUserToDeleteRows = False
        Me.dgvPresentacion.AutoGenerateColumns = False
        Me.dgvPresentacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPresentacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPresentacionDataGridViewTextBoxColumn, Me.NombrePresDataGridViewTextBoxColumn, Me.ViaAdminDataGridViewTextBoxColumn})
        Me.dgvPresentacion.DataSource = Me.PresentacionBindingSource
        Me.dgvPresentacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPresentacion.Location = New System.Drawing.Point(4, 23)
        Me.dgvPresentacion.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvPresentacion.Name = "dgvPresentacion"
        Me.dgvPresentacion.ReadOnly = True
        Me.dgvPresentacion.RowHeadersWidth = 51
        Me.dgvPresentacion.Size = New System.Drawing.Size(741, 277)
        Me.dgvPresentacion.TabIndex = 0
        '
        'PresentacionBindingSource
        '
        Me.PresentacionBindingSource.DataMember = "Presentacion"
        Me.PresentacionBindingSource.DataSource = Me.Farma24BDDS
        '
        'Farma24BDDS
        '
        Me.Farma24BDDS.DataSetName = "Farma24BDDS"
        Me.Farma24BDDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PresentacionTableAdapter
        '
        Me.PresentacionTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtIdPres)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtViaAdmin)
        Me.GroupBox2.Controls.Add(Me.txtNombreP)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 13)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(741, 230)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingrese los Datos de la Presentacion"
        '
        'txtIdPres
        '
        Me.txtIdPres.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresentacionBindingSource, "idPresentacion", True))
        Me.txtIdPres.Location = New System.Drawing.Point(223, 65)
        Me.txtIdPres.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdPres.Name = "txtIdPres"
        Me.txtIdPres.Size = New System.Drawing.Size(239, 26)
        Me.txtIdPres.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(219, 42)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ID Presentacion:"
        '
        'txtViaAdmin
        '
        Me.txtViaAdmin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresentacionBindingSource, "viaAdmin", True))
        Me.txtViaAdmin.Location = New System.Drawing.Point(223, 174)
        Me.txtViaAdmin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtViaAdmin.Name = "txtViaAdmin"
        Me.txtViaAdmin.Size = New System.Drawing.Size(239, 26)
        Me.txtViaAdmin.TabIndex = 7
        '
        'txtNombreP
        '
        Me.txtNombreP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresentacionBindingSource, "nombrePres", True))
        Me.txtNombreP.Location = New System.Drawing.Point(223, 119)
        Me.txtNombreP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreP.Name = "txtNombreP"
        Me.txtNombreP.Size = New System.Drawing.Size(239, 26)
        Me.txtNombreP.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(219, 150)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Via de administracion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(219, 96)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nombre:"
        '
        'IdPresentacionDataGridViewTextBoxColumn
        '
        Me.IdPresentacionDataGridViewTextBoxColumn.DataPropertyName = "idPresentacion"
        Me.IdPresentacionDataGridViewTextBoxColumn.HeaderText = "ID "
        Me.IdPresentacionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdPresentacionDataGridViewTextBoxColumn.Name = "IdPresentacionDataGridViewTextBoxColumn"
        Me.IdPresentacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPresentacionDataGridViewTextBoxColumn.Width = 125
        '
        'NombrePresDataGridViewTextBoxColumn
        '
        Me.NombrePresDataGridViewTextBoxColumn.DataPropertyName = "nombrePres"
        Me.NombrePresDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombrePresDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombrePresDataGridViewTextBoxColumn.Name = "NombrePresDataGridViewTextBoxColumn"
        Me.NombrePresDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombrePresDataGridViewTextBoxColumn.Width = 125
        '
        'ViaAdminDataGridViewTextBoxColumn
        '
        Me.ViaAdminDataGridViewTextBoxColumn.DataPropertyName = "viaAdmin"
        Me.ViaAdminDataGridViewTextBoxColumn.HeaderText = "Via administracion"
        Me.ViaAdminDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ViaAdminDataGridViewTextBoxColumn.Name = "ViaAdminDataGridViewTextBoxColumn"
        Me.ViaAdminDataGridViewTextBoxColumn.ReadOnly = True
        Me.ViaAdminDataGridViewTextBoxColumn.Width = 125
        '
        'FrmPresentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 542)
        Me.Controls.Add(Me.gbContenedorDGV)
        Me.Controls.Add(Me.gbFondo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1090, 589)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1090, 589)
        Me.Name = "FrmPresentacion"
        Me.Text = "Presentacion"
        Me.gbFondo.ResumeLayout(False)
        Me.gbFondo.PerformLayout()
        Me.gbContenedorDGV.ResumeLayout(False)
        CType(Me.dgvPresentacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresentacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbFondo As GroupBox
    Friend WithEvents gbContenedorDGV As GroupBox
    Friend WithEvents dgvPresentacion As DataGridView
    Friend WithEvents Farma24BDDS As Farma24BDDS
    Friend WithEvents PresentacionBindingSource As BindingSource
    Friend WithEvents PresentacionTableAdapter As Farma24BDDSTableAdapters.PresentacionTableAdapter
    Friend WithEvents btnEliminar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnEditar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnAgregar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnNuevo As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnCerrar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtIdPres As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtViaAdmin As TextBox
    Friend WithEvents txtNombreP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents IdPresentacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombrePresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ViaAdminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
