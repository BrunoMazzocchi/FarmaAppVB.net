<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.gbBarra = New System.Windows.Forms.GroupBox()
        Me.btnImprimir = New MaterialSkin.Controls.MaterialButton()
        Me.btnBuscarID = New MaterialSkin.Controls.MaterialButton()
        Me.btnBuscar = New MaterialSkin.Controls.MaterialButton()
        Me.btnPlp = New MaterialSkin.Controls.MaterialButton()
        Me.txtBuscarID = New System.Windows.Forms.TextBox()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Farma24BDDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Farma24BDDS = New FarmaAppVB.Farma24BDDS()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.gbDgv = New System.Windows.Forms.GroupBox()
        Me.btnCerrarSesion = New System.Windows.Forms.DataGridView()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DosisProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PermisoProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbControles = New System.Windows.Forms.GroupBox()
        Me.btnCerrar = New MaterialSkin.Controls.MaterialButton()
        Me.btnInfoVendedores = New MaterialSkin.Controls.MaterialButton()
        Me.lbHistorial = New System.Windows.Forms.Label()
        Me.cbHistorial = New System.Windows.Forms.ComboBox()
        Me.lbUser = New System.Windows.Forms.Label()
        Me.lbBienvenido = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbBtnCrud = New System.Windows.Forms.GroupBox()
        Me.gbCrud = New System.Windows.Forms.GroupBox()
        Me.ProductoTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.ProductoTableAdapter()
        Me.btnAgregar = New MaterialSkin.Controls.MaterialButton()
        Me.btnEditar = New MaterialSkin.Controls.MaterialButton()
        Me.btnEliminar = New MaterialSkin.Controls.MaterialButton()
        Me.btnLaboratorio = New MaterialSkin.Controls.MaterialButton()
        Me.btnPresentacion = New MaterialSkin.Controls.MaterialButton()
        Me.gbBarra.SuspendLayout()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Farma24BDDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDgv.SuspendLayout()
        CType(Me.btnCerrarSesion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbControles.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBtnCrud.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbBarra
        '
        Me.gbBarra.Controls.Add(Me.btnImprimir)
        Me.gbBarra.Controls.Add(Me.btnBuscarID)
        Me.gbBarra.Controls.Add(Me.btnBuscar)
        Me.gbBarra.Controls.Add(Me.btnPlp)
        Me.gbBarra.Controls.Add(Me.txtBuscarID)
        Me.gbBarra.Controls.Add(Me.txtBuscar)
        Me.gbBarra.Location = New System.Drawing.Point(507, 26)
        Me.gbBarra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbBarra.Name = "gbBarra"
        Me.gbBarra.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbBarra.Size = New System.Drawing.Size(744, 141)
        Me.gbBarra.TabIndex = 1
        Me.gbBarra.TabStop = False
        '
        'btnImprimir
        '
        Me.btnImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnImprimir.Depth = 0
        Me.btnImprimir.DrawShadows = True
        Me.btnImprimir.HighEmphasis = True
        Me.btnImprimir.Icon = Nothing
        Me.btnImprimir.Location = New System.Drawing.Point(610, 85)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnImprimir.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(87, 36)
        Me.btnImprimir.TabIndex = 20
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnImprimir.UseAccentColor = False
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnBuscarID
        '
        Me.btnBuscarID.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBuscarID.Depth = 0
        Me.btnBuscarID.DrawShadows = True
        Me.btnBuscarID.HighEmphasis = True
        Me.btnBuscarID.Icon = Nothing
        Me.btnBuscarID.Location = New System.Drawing.Point(371, 53)
        Me.btnBuscarID.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnBuscarID.MaximumSize = New System.Drawing.Size(150, 24)
        Me.btnBuscarID.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnBuscarID.Name = "btnBuscarID"
        Me.btnBuscarID.Size = New System.Drawing.Size(99, 24)
        Me.btnBuscarID.TabIndex = 19
        Me.btnBuscarID.Text = " Buscar ID"
        Me.btnBuscarID.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnBuscarID.UseAccentColor = False
        Me.btnBuscarID.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBuscar.Depth = 0
        Me.btnBuscar.DrawShadows = True
        Me.btnBuscar.HighEmphasis = True
        Me.btnBuscar.Icon = Nothing
        Me.btnBuscar.Location = New System.Drawing.Point(371, 16)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnBuscar.MaximumSize = New System.Drawing.Size(150, 24)
        Me.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(99, 24)
        Me.btnBuscar.TabIndex = 18
        Me.btnBuscar.Text = "      Buscar     "
        Me.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnBuscar.UseAccentColor = False
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnPlp
        '
        Me.btnPlp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPlp.Depth = 0
        Me.btnPlp.DrawShadows = True
        Me.btnPlp.HighEmphasis = True
        Me.btnPlp.Icon = Nothing
        Me.btnPlp.Location = New System.Drawing.Point(24, 85)
        Me.btnPlp.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnPlp.MaximumSize = New System.Drawing.Size(220, 34)
        Me.btnPlp.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPlp.Name = "btnPlp"
        Me.btnPlp.Size = New System.Drawing.Size(183, 34)
        Me.btnPlp.TabIndex = 17
        Me.btnPlp.Text = " Registro productos"
        Me.btnPlp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnPlp.UseAccentColor = False
        Me.btnPlp.UseVisualStyleBackColor = True
        '
        'txtBuscarID
        '
        Me.txtBuscarID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "idProducto", True))
        Me.txtBuscarID.Location = New System.Drawing.Point(24, 55)
        Me.txtBuscarID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBuscarID.Name = "txtBuscarID"
        Me.txtBuscarID.Size = New System.Drawing.Size(308, 22)
        Me.txtBuscarID.TabIndex = 1
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.Farma24BDDSBindingSource
        '
        'Farma24BDDSBindingSource
        '
        Me.Farma24BDDSBindingSource.DataSource = Me.Farma24BDDS
        Me.Farma24BDDSBindingSource.Position = 0
        '
        'Farma24BDDS
        '
        Me.Farma24BDDS.DataSetName = "Farma24BDDS"
        Me.Farma24BDDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(24, 18)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(308, 22)
        Me.txtBuscar.TabIndex = 0
        '
        'gbDgv
        '
        Me.gbDgv.Controls.Add(Me.btnCerrarSesion)
        Me.gbDgv.Location = New System.Drawing.Point(493, 234)
        Me.gbDgv.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbDgv.Name = "gbDgv"
        Me.gbDgv.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbDgv.Size = New System.Drawing.Size(761, 378)
        Me.gbDgv.TabIndex = 6
        Me.gbDgv.TabStop = False
        Me.gbDgv.Text = "Productos"
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.AllowUserToAddRows = False
        Me.btnCerrarSesion.AllowUserToDeleteRows = False
        Me.btnCerrarSesion.AutoGenerateColumns = False
        Me.btnCerrarSesion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.btnCerrarSesion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn, Me.NombreProductoDataGridViewTextBoxColumn, Me.DescripProdDataGridViewTextBoxColumn, Me.PrecioProdDataGridViewTextBoxColumn, Me.ExistProdDataGridViewTextBoxColumn, Me.ExpProdDataGridViewTextBoxColumn, Me.DosisProdDataGridViewTextBoxColumn, Me.PermisoProdDataGridViewTextBoxColumn, Me.EstadoProdDataGridViewTextBoxColumn})
        Me.btnCerrarSesion.DataSource = Me.ProductoBindingSource
        Me.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCerrarSesion.Location = New System.Drawing.Point(3, 17)
        Me.btnCerrarSesion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.ReadOnly = True
        Me.btnCerrarSesion.RowHeadersWidth = 51
        Me.btnCerrarSesion.RowTemplate.Height = 24
        Me.btnCerrarSesion.Size = New System.Drawing.Size(755, 359)
        Me.btnCerrarSesion.TabIndex = 0
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdProductoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdProductoDataGridViewTextBoxColumn.Width = 40
        '
        'NombreProductoDataGridViewTextBoxColumn
        '
        Me.NombreProductoDataGridViewTextBoxColumn.DataPropertyName = "nombreProducto"
        Me.NombreProductoDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.NombreProductoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreProductoDataGridViewTextBoxColumn.Name = "NombreProductoDataGridViewTextBoxColumn"
        Me.NombreProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreProductoDataGridViewTextBoxColumn.Width = 125
        '
        'DescripProdDataGridViewTextBoxColumn
        '
        Me.DescripProdDataGridViewTextBoxColumn.DataPropertyName = "descripProd"
        Me.DescripProdDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripProdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescripProdDataGridViewTextBoxColumn.Name = "DescripProdDataGridViewTextBoxColumn"
        Me.DescripProdDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripProdDataGridViewTextBoxColumn.Width = 125
        '
        'PrecioProdDataGridViewTextBoxColumn
        '
        Me.PrecioProdDataGridViewTextBoxColumn.DataPropertyName = "precioProd"
        Me.PrecioProdDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioProdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrecioProdDataGridViewTextBoxColumn.Name = "PrecioProdDataGridViewTextBoxColumn"
        Me.PrecioProdDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioProdDataGridViewTextBoxColumn.Width = 70
        '
        'ExistProdDataGridViewTextBoxColumn
        '
        Me.ExistProdDataGridViewTextBoxColumn.DataPropertyName = "existProd"
        Me.ExistProdDataGridViewTextBoxColumn.HeaderText = "Existencia"
        Me.ExistProdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ExistProdDataGridViewTextBoxColumn.Name = "ExistProdDataGridViewTextBoxColumn"
        Me.ExistProdDataGridViewTextBoxColumn.ReadOnly = True
        Me.ExistProdDataGridViewTextBoxColumn.Width = 60
        '
        'ExpProdDataGridViewTextBoxColumn
        '
        Me.ExpProdDataGridViewTextBoxColumn.DataPropertyName = "expProd"
        Me.ExpProdDataGridViewTextBoxColumn.HeaderText = "Expira"
        Me.ExpProdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ExpProdDataGridViewTextBoxColumn.Name = "ExpProdDataGridViewTextBoxColumn"
        Me.ExpProdDataGridViewTextBoxColumn.ReadOnly = True
        Me.ExpProdDataGridViewTextBoxColumn.Width = 70
        '
        'DosisProdDataGridViewTextBoxColumn
        '
        Me.DosisProdDataGridViewTextBoxColumn.DataPropertyName = "dosisProd"
        Me.DosisProdDataGridViewTextBoxColumn.HeaderText = "Dosis"
        Me.DosisProdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DosisProdDataGridViewTextBoxColumn.Name = "DosisProdDataGridViewTextBoxColumn"
        Me.DosisProdDataGridViewTextBoxColumn.ReadOnly = True
        Me.DosisProdDataGridViewTextBoxColumn.Width = 125
        '
        'PermisoProdDataGridViewTextBoxColumn
        '
        Me.PermisoProdDataGridViewTextBoxColumn.DataPropertyName = "permisoProd"
        Me.PermisoProdDataGridViewTextBoxColumn.HeaderText = "Permiso"
        Me.PermisoProdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PermisoProdDataGridViewTextBoxColumn.Name = "PermisoProdDataGridViewTextBoxColumn"
        Me.PermisoProdDataGridViewTextBoxColumn.ReadOnly = True
        Me.PermisoProdDataGridViewTextBoxColumn.Width = 70
        '
        'EstadoProdDataGridViewTextBoxColumn
        '
        Me.EstadoProdDataGridViewTextBoxColumn.DataPropertyName = "estadoProd"
        Me.EstadoProdDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoProdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EstadoProdDataGridViewTextBoxColumn.Name = "EstadoProdDataGridViewTextBoxColumn"
        Me.EstadoProdDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoProdDataGridViewTextBoxColumn.Width = 45
        '
        'gbControles
        '
        Me.gbControles.BackColor = System.Drawing.Color.DodgerBlue
        Me.gbControles.Controls.Add(Me.btnCerrar)
        Me.gbControles.Controls.Add(Me.btnInfoVendedores)
        Me.gbControles.Controls.Add(Me.lbHistorial)
        Me.gbControles.Controls.Add(Me.cbHistorial)
        Me.gbControles.Controls.Add(Me.lbUser)
        Me.gbControles.Controls.Add(Me.lbBienvenido)
        Me.gbControles.Controls.Add(Me.PictureBox1)
        Me.gbControles.Controls.Add(Me.gbBtnCrud)
        Me.gbControles.Location = New System.Drawing.Point(-7, -10)
        Me.gbControles.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbControles.Name = "gbControles"
        Me.gbControles.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbControles.Size = New System.Drawing.Size(299, 639)
        Me.gbControles.TabIndex = 0
        Me.gbControles.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCerrar.Depth = 0
        Me.btnCerrar.DrawShadows = True
        Me.btnCerrar.HighEmphasis = True
        Me.btnCerrar.Icon = Nothing
        Me.btnCerrar.Location = New System.Drawing.Point(47, 524)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCerrar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(170, 36)
        Me.btnCerrar.TabIndex = 20
        Me.btnCerrar.Text = "           Cerrar sesion         "
        Me.btnCerrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnCerrar.UseAccentColor = False
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnInfoVendedores
        '
        Me.btnInfoVendedores.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnInfoVendedores.Depth = 0
        Me.btnInfoVendedores.DrawShadows = True
        Me.btnInfoVendedores.HighEmphasis = True
        Me.btnInfoVendedores.Icon = Nothing
        Me.btnInfoVendedores.Location = New System.Drawing.Point(47, 461)
        Me.btnInfoVendedores.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnInfoVendedores.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnInfoVendedores.Name = "btnInfoVendedores"
        Me.btnInfoVendedores.Size = New System.Drawing.Size(173, 36)
        Me.btnInfoVendedores.TabIndex = 19
        Me.btnInfoVendedores.Text = "     Info. Vendedores      "
        Me.btnInfoVendedores.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnInfoVendedores.UseAccentColor = False
        Me.btnInfoVendedores.UseVisualStyleBackColor = True
        '
        'lbHistorial
        '
        Me.lbHistorial.AutoSize = True
        Me.lbHistorial.Font = New System.Drawing.Font("Montserrat", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHistorial.ForeColor = System.Drawing.SystemColors.Control
        Me.lbHistorial.Location = New System.Drawing.Point(127, 385)
        Me.lbHistorial.Name = "lbHistorial"
        Me.lbHistorial.Size = New System.Drawing.Size(76, 18)
        Me.lbHistorial.TabIndex = 18
        Me.lbHistorial.Text = "Historial"
        Me.lbHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbHistorial
        '
        Me.cbHistorial.FormattingEnabled = True
        Me.cbHistorial.Items.AddRange(New Object() {"Entradas", "Salidas"})
        Me.cbHistorial.Location = New System.Drawing.Point(47, 415)
        Me.cbHistorial.Name = "cbHistorial"
        Me.cbHistorial.Size = New System.Drawing.Size(223, 24)
        Me.cbHistorial.TabIndex = 17
        '
        'lbUser
        '
        Me.lbUser.AutoSize = True
        Me.lbUser.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbUser.Location = New System.Drawing.Point(126, 275)
        Me.lbUser.Name = "lbUser"
        Me.lbUser.Size = New System.Drawing.Size(0, 24)
        Me.lbUser.TabIndex = 16
        '
        'lbBienvenido
        '
        Me.lbBienvenido.AutoSize = True
        Me.lbBienvenido.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBienvenido.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbBienvenido.Location = New System.Drawing.Point(28, 251)
        Me.lbBienvenido.Name = "lbBienvenido"
        Me.lbBienvenido.Size = New System.Drawing.Size(237, 24)
        Me.lbBienvenido.TabIndex = 15
        Me.lbBienvenido.Text = "Bienvenido de nuevo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FarmaAppVB.My.Resources.Resources.EldianEmpire
        Me.PictureBox1.Location = New System.Drawing.Point(69, 54)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(173, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'gbBtnCrud
        '
        Me.gbBtnCrud.BackColor = System.Drawing.Color.DodgerBlue
        Me.gbBtnCrud.Controls.Add(Me.gbCrud)
        Me.gbBtnCrud.Location = New System.Drawing.Point(312, 0)
        Me.gbBtnCrud.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbBtnCrud.Name = "gbBtnCrud"
        Me.gbBtnCrud.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbBtnCrud.Size = New System.Drawing.Size(182, 642)
        Me.gbBtnCrud.TabIndex = 1
        Me.gbBtnCrud.TabStop = False
        '
        'gbCrud
        '
        Me.gbCrud.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbCrud.Location = New System.Drawing.Point(196, 102)
        Me.gbCrud.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbCrud.Name = "gbCrud"
        Me.gbCrud.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbCrud.Size = New System.Drawing.Size(160, 441)
        Me.gbCrud.TabIndex = 1
        Me.gbCrud.TabStop = False
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'btnAgregar
        '
        Me.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAgregar.Depth = 0
        Me.btnAgregar.DrawShadows = True
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.HighEmphasis = True
        Me.btnAgregar.Icon = Nothing
        Me.btnAgregar.Location = New System.Drawing.Point(336, 331)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(88, 36)
        Me.btnAgregar.TabIndex = 12
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnAgregar.UseAccentColor = False
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEditar.Depth = 0
        Me.btnEditar.DrawShadows = True
        Me.btnEditar.HighEmphasis = True
        Me.btnEditar.Icon = Nothing
        Me.btnEditar.Location = New System.Drawing.Point(336, 393)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnEditar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(89, 36)
        Me.btnEditar.TabIndex = 13
        Me.btnEditar.Text = "     Editar      "
        Me.btnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnEditar.UseAccentColor = False
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEliminar.Depth = 0
        Me.btnEliminar.DrawShadows = True
        Me.btnEliminar.HighEmphasis = True
        Me.btnEliminar.Icon = Nothing
        Me.btnEliminar.Location = New System.Drawing.Point(336, 452)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(88, 36)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnEliminar.UseAccentColor = False
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnLaboratorio
        '
        Me.btnLaboratorio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLaboratorio.Depth = 0
        Me.btnLaboratorio.DrawShadows = True
        Me.btnLaboratorio.HighEmphasis = True
        Me.btnLaboratorio.Icon = Nothing
        Me.btnLaboratorio.Location = New System.Drawing.Point(312, 35)
        Me.btnLaboratorio.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnLaboratorio.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnLaboratorio.Name = "btnLaboratorio"
        Me.btnLaboratorio.Size = New System.Drawing.Size(132, 36)
        Me.btnLaboratorio.TabIndex = 15
        Me.btnLaboratorio.Text = " Laboratorios"
        Me.btnLaboratorio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnLaboratorio.UseAccentColor = False
        Me.btnLaboratorio.UseVisualStyleBackColor = True
        '
        'btnPresentacion
        '
        Me.btnPresentacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPresentacion.Depth = 0
        Me.btnPresentacion.DrawShadows = True
        Me.btnPresentacion.HighEmphasis = True
        Me.btnPresentacion.Icon = Nothing
        Me.btnPresentacion.Location = New System.Drawing.Point(312, 92)
        Me.btnPresentacion.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnPresentacion.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPresentacion.Name = "btnPresentacion"
        Me.btnPresentacion.Size = New System.Drawing.Size(133, 36)
        Me.btnPresentacion.TabIndex = 16
        Me.btnPresentacion.Text = " Presentacion  "
        Me.btnPresentacion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnPresentacion.UseAccentColor = False
        Me.btnPresentacion.UseVisualStyleBackColor = True
        '
        'frmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1266, 611)
        Me.Controls.Add(Me.btnPresentacion)
        Me.Controls.Add(Me.btnLaboratorio)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.gbDgv)
        Me.Controls.Add(Me.gbBarra)
        Me.Controls.Add(Me.gbControles)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1284, 658)
        Me.MinimumSize = New System.Drawing.Size(1284, 658)
        Me.Name = "frmProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Producto"
        Me.gbBarra.ResumeLayout(False)
        Me.gbBarra.PerformLayout()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Farma24BDDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDgv.ResumeLayout(False)
        CType(Me.btnCerrarSesion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbControles.ResumeLayout(False)
        Me.gbControles.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBtnCrud.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbBarra As GroupBox
    Friend WithEvents txtBuscarID As TextBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents gbDgv As GroupBox
    Friend WithEvents gbControles As GroupBox
    Friend WithEvents gbBtnCrud As GroupBox
    Friend WithEvents gbCrud As GroupBox
    Friend WithEvents Farma24BDDSBindingSource As BindingSource
    Friend WithEvents Farma24BDDS As Farma24BDDS
    Private WithEvents btnCerrarSesion As DataGridView
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As Farma24BDDSTableAdapters.ProductoTableAdapter
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripProdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioProdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExistProdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExpProdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DosisProdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PermisoProdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoProdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbUser As Label
    Friend WithEvents lbBienvenido As Label
    Friend WithEvents cbHistorial As ComboBox
    Friend WithEvents lbHistorial As Label
    Friend WithEvents btnAgregar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnEditar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnEliminar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnLaboratorio As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnPresentacion As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnCerrar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnInfoVendedores As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnPlp As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnBuscar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnBuscarID As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnImprimir As MaterialSkin.Controls.MaterialButton
End Class
