<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPLP
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
        Me.cbProducto = New System.Windows.Forms.ComboBox()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Farma24BDDS = New FarmaAppVB.Farma24BDDS()
        Me.cbLab = New System.Windows.Forms.ComboBox()
        Me.LaboratorioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbPres = New System.Windows.Forms.ComboBox()
        Me.PresentacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.ProductoTableAdapter()
        Me.lbIdProd = New System.Windows.Forms.Label()
        Me.PresentacionTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.PresentacionTableAdapter()
        Me.lbIdPres = New System.Windows.Forms.Label()
        Me.LaboratorioTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.LaboratorioTableAdapter()
        Me.lbIdLaboratorio = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGuardar = New MaterialSkin.Controls.MaterialButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdPLPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPresentacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdLaboratorioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PLPBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Farma24BDDS1 = New FarmaAppVB.Farma24BDDS()
        Me.PLPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLPTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.PLPTableAdapter()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaboratorioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresentacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLPBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Farma24BDDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbProducto
        '
        Me.cbProducto.DataSource = Me.ProductoBindingSource
        Me.cbProducto.DisplayMember = "nombreProducto"
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(81, 71)
        Me.cbProducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(152, 21)
        Me.cbProducto.TabIndex = 0
        Me.cbProducto.ValueMember = "idProducto"
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.Farma24BDDS
        '
        'Farma24BDDS
        '
        Me.Farma24BDDS.DataSetName = "Farma24BDDS"
        Me.Farma24BDDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbLab
        '
        Me.cbLab.DataSource = Me.LaboratorioBindingSource
        Me.cbLab.DisplayMember = "nombreLab"
        Me.cbLab.FormattingEnabled = True
        Me.cbLab.Location = New System.Drawing.Point(79, 163)
        Me.cbLab.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbLab.Name = "cbLab"
        Me.cbLab.Size = New System.Drawing.Size(152, 21)
        Me.cbLab.TabIndex = 1
        Me.cbLab.ValueMember = "idLaboratorio"
        '
        'LaboratorioBindingSource
        '
        Me.LaboratorioBindingSource.DataMember = "Laboratorio"
        Me.LaboratorioBindingSource.DataSource = Me.Farma24BDDS
        '
        'cbPres
        '
        Me.cbPres.DataSource = Me.PresentacionBindingSource
        Me.cbPres.DisplayMember = "nombrePres"
        Me.cbPres.FormattingEnabled = True
        Me.cbPres.Location = New System.Drawing.Point(79, 116)
        Me.cbPres.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbPres.Name = "cbPres"
        Me.cbPres.Size = New System.Drawing.Size(152, 21)
        Me.cbPres.TabIndex = 2
        Me.cbPres.ValueMember = "idPresentacion"
        '
        'PresentacionBindingSource
        '
        Me.PresentacionBindingSource.DataMember = "Presentacion"
        Me.PresentacionBindingSource.DataSource = Me.Farma24BDDS
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'lbIdProd
        '
        Me.lbIdProd.AutoSize = True
        Me.lbIdProd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "idProducto", True))
        Me.lbIdProd.Location = New System.Drawing.Point(238, 71)
        Me.lbIdProd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbIdProd.Name = "lbIdProd"
        Me.lbIdProd.Size = New System.Drawing.Size(0, 13)
        Me.lbIdProd.TabIndex = 4
        '
        'PresentacionTableAdapter
        '
        Me.PresentacionTableAdapter.ClearBeforeFill = True
        '
        'lbIdPres
        '
        Me.lbIdPres.AutoSize = True
        Me.lbIdPres.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresentacionBindingSource, "idPresentacion", True))
        Me.lbIdPres.Location = New System.Drawing.Point(240, 147)
        Me.lbIdPres.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbIdPres.Name = "lbIdPres"
        Me.lbIdPres.Size = New System.Drawing.Size(0, 13)
        Me.lbIdPres.TabIndex = 5
        '
        'LaboratorioTableAdapter
        '
        Me.LaboratorioTableAdapter.ClearBeforeFill = True
        '
        'lbIdLaboratorio
        '
        Me.lbIdLaboratorio.AutoSize = True
        Me.lbIdLaboratorio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaboratorioBindingSource, "idLaboratorio", True))
        Me.lbIdLaboratorio.Location = New System.Drawing.Point(238, 218)
        Me.lbIdLaboratorio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbIdLaboratorio.Name = "lbIdLaboratorio"
        Me.lbIdLaboratorio.Size = New System.Drawing.Size(0, 13)
        Me.lbIdLaboratorio.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Datos de producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Datos de presentacion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 147)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Datos de laboratorio"
        '
        'btnGuardar
        '
        Me.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnGuardar.Depth = 0
        Me.btnGuardar.DrawShadows = True
        Me.btnGuardar.HighEmphasis = True
        Me.btnGuardar.Icon = Nothing
        Me.btnGuardar.Location = New System.Drawing.Point(425, 71)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(139, 36)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar datos"
        Me.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnGuardar.UseAccentColor = False
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(79, 195)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(453, 131)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPLPDataGridViewTextBoxColumn, Me.IdProductoDataGridViewTextBoxColumn, Me.IdPresentacionDataGridViewTextBoxColumn, Me.IdLaboratorioDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PLPBindingSource1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(2, 15)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(449, 114)
        Me.DataGridView1.TabIndex = 0
        '
        'IdPLPDataGridViewTextBoxColumn
        '
        Me.IdPLPDataGridViewTextBoxColumn.DataPropertyName = "idPLP"
        Me.IdPLPDataGridViewTextBoxColumn.HeaderText = "idPLP"
        Me.IdPLPDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdPLPDataGridViewTextBoxColumn.Name = "IdPLPDataGridViewTextBoxColumn"
        Me.IdPLPDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPLPDataGridViewTextBoxColumn.Width = 125
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "idProducto"
        Me.IdProductoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdProductoDataGridViewTextBoxColumn.Width = 125
        '
        'IdPresentacionDataGridViewTextBoxColumn
        '
        Me.IdPresentacionDataGridViewTextBoxColumn.DataPropertyName = "idPresentacion"
        Me.IdPresentacionDataGridViewTextBoxColumn.HeaderText = "idPresentacion"
        Me.IdPresentacionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdPresentacionDataGridViewTextBoxColumn.Name = "IdPresentacionDataGridViewTextBoxColumn"
        Me.IdPresentacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPresentacionDataGridViewTextBoxColumn.Width = 125
        '
        'IdLaboratorioDataGridViewTextBoxColumn
        '
        Me.IdLaboratorioDataGridViewTextBoxColumn.DataPropertyName = "idLaboratorio"
        Me.IdLaboratorioDataGridViewTextBoxColumn.HeaderText = "idLaboratorio"
        Me.IdLaboratorioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdLaboratorioDataGridViewTextBoxColumn.Name = "IdLaboratorioDataGridViewTextBoxColumn"
        Me.IdLaboratorioDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdLaboratorioDataGridViewTextBoxColumn.Width = 125
        '
        'PLPBindingSource1
        '
        Me.PLPBindingSource1.DataMember = "PLP"
        Me.PLPBindingSource1.DataSource = Me.Farma24BDDS1
        '
        'Farma24BDDS1
        '
        Me.Farma24BDDS1.DataSetName = "Farma24BDDS"
        Me.Farma24BDDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PLPTableAdapter
        '
        Me.PLPTableAdapter.ClearBeforeFill = True
        '
        'frmPLP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 358)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbIdLaboratorio)
        Me.Controls.Add(Me.lbIdPres)
        Me.Controls.Add(Me.lbIdProd)
        Me.Controls.Add(Me.cbPres)
        Me.Controls.Add(Me.cbLab)
        Me.Controls.Add(Me.cbProducto)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmPLP"
        Me.Text = "PLP"
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaboratorioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresentacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLPBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Farma24BDDS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbProducto As ComboBox
    Friend WithEvents cbLab As ComboBox
    Friend WithEvents cbPres As ComboBox
    Friend WithEvents Farma24BDDS As Farma24BDDS
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As Farma24BDDSTableAdapters.ProductoTableAdapter
    Friend WithEvents lbIdProd As Label
    Friend WithEvents PresentacionBindingSource As BindingSource
    Friend WithEvents PresentacionTableAdapter As Farma24BDDSTableAdapters.PresentacionTableAdapter
    Friend WithEvents lbIdPres As Label
    Friend WithEvents LaboratorioBindingSource As BindingSource
    Friend WithEvents LaboratorioTableAdapter As Farma24BDDSTableAdapters.LaboratorioTableAdapter
    Friend WithEvents lbIdLaboratorio As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnGuardar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PLPBindingSource As BindingSource
    Friend WithEvents PLPTableAdapter As Farma24BDDSTableAdapters.PLPTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Farma24BDDS1 As Farma24BDDS
    Friend WithEvents PLPBindingSource1 As BindingSource
    Friend WithEvents IdPLPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdPresentacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdLaboratorioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
