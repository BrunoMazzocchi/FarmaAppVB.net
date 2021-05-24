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
        Me.Farma24BDDS = New FarmaAppVB.Farma24BDDS()
        Me.cbLab = New System.Windows.Forms.ComboBox()
        Me.cbPres = New System.Windows.Forms.ComboBox()
        Me.lbIdProd = New System.Windows.Forms.Label()
        Me.lbIdPres = New System.Windows.Forms.Label()
        Me.lbIdLaboratorio = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGuardar = New MaterialSkin.Controls.MaterialButton()
        Me.gbPLP = New System.Windows.Forms.GroupBox()
        Me.dgvPLP = New System.Windows.Forms.DataGridView()
        Me.Farma24BDDS1 = New FarmaAppVB.Farma24BDDS()
        Me.PLPTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.PLPTableAdapter()
        Me.Farma24BDDS2 = New FarmaAppVB.Farma24BDDS()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.ProductoTableAdapter()
        Me.PresentacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresentacionTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.PresentacionTableAdapter()
        Me.LaboratorioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LaboratorioTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.LaboratorioTableAdapter()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPLP.SuspendLayout()
        CType(Me.dgvPLP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Farma24BDDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Farma24BDDS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresentacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaboratorioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbProducto
        '
        Me.cbProducto.DataSource = Me.ProductoBindingSource
        Me.cbProducto.DisplayMember = "nombreProducto"
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(108, 87)
        Me.cbProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(201, 24)
        Me.cbProducto.TabIndex = 0
        Me.cbProducto.ValueMember = "idProducto"
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
        Me.cbLab.Location = New System.Drawing.Point(105, 201)
        Me.cbLab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbLab.Name = "cbLab"
        Me.cbLab.Size = New System.Drawing.Size(201, 24)
        Me.cbLab.TabIndex = 1
        Me.cbLab.ValueMember = "idLaboratorio"
        '
        'cbPres
        '
        Me.cbPres.DataSource = Me.PresentacionBindingSource
        Me.cbPres.DisplayMember = "nombrePres"
        Me.cbPres.FormattingEnabled = True
        Me.cbPres.Location = New System.Drawing.Point(105, 143)
        Me.cbPres.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbPres.Name = "cbPres"
        Me.cbPres.Size = New System.Drawing.Size(201, 24)
        Me.cbPres.TabIndex = 2
        Me.cbPres.ValueMember = "idPresentacion"
        '
        'lbIdProd
        '
        Me.lbIdProd.AutoSize = True
        Me.lbIdProd.Location = New System.Drawing.Point(317, 87)
        Me.lbIdProd.Name = "lbIdProd"
        Me.lbIdProd.Size = New System.Drawing.Size(0, 17)
        Me.lbIdProd.TabIndex = 4
        '
        'lbIdPres
        '
        Me.lbIdPres.AutoSize = True
        Me.lbIdPres.Location = New System.Drawing.Point(320, 181)
        Me.lbIdPres.Name = "lbIdPres"
        Me.lbIdPres.Size = New System.Drawing.Size(0, 17)
        Me.lbIdPres.TabIndex = 5
        '
        'lbIdLaboratorio
        '
        Me.lbIdLaboratorio.AutoSize = True
        Me.lbIdLaboratorio.Location = New System.Drawing.Point(317, 268)
        Me.lbIdLaboratorio.Name = "lbIdLaboratorio"
        Me.lbIdLaboratorio.Size = New System.Drawing.Size(0, 17)
        Me.lbIdLaboratorio.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Datos de producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Datos de presentacion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(105, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 17)
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
        Me.btnGuardar.Location = New System.Drawing.Point(567, 87)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(139, 36)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar datos"
        Me.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnGuardar.UseAccentColor = False
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'gbPLP
        '
        Me.gbPLP.Controls.Add(Me.dgvPLP)
        Me.gbPLP.Location = New System.Drawing.Point(105, 240)
        Me.gbPLP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbPLP.Name = "gbPLP"
        Me.gbPLP.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbPLP.Size = New System.Drawing.Size(604, 201)
        Me.gbPLP.TabIndex = 11
        Me.gbPLP.TabStop = False
        Me.gbPLP.Text = "Datos de PLP"
        '
        'dgvPLP
        '
        Me.dgvPLP.AllowUserToAddRows = False
        Me.dgvPLP.AllowUserToDeleteRows = False
        Me.dgvPLP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPLP.Location = New System.Drawing.Point(3, 17)
        Me.dgvPLP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvPLP.Name = "dgvPLP"
        Me.dgvPLP.ReadOnly = True
        Me.dgvPLP.RowHeadersWidth = 51
        Me.dgvPLP.RowTemplate.Height = 24
        Me.dgvPLP.Size = New System.Drawing.Size(598, 182)
        Me.dgvPLP.TabIndex = 0
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
        'Farma24BDDS2
        '
        Me.Farma24BDDS2.DataSetName = "Farma24BDDS"
        Me.Farma24BDDS2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.Farma24BDDS2
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'PresentacionBindingSource
        '
        Me.PresentacionBindingSource.DataMember = "Presentacion"
        Me.PresentacionBindingSource.DataSource = Me.Farma24BDDS2
        '
        'PresentacionTableAdapter
        '
        Me.PresentacionTableAdapter.ClearBeforeFill = True
        '
        'LaboratorioBindingSource
        '
        Me.LaboratorioBindingSource.DataMember = "Laboratorio"
        Me.LaboratorioBindingSource.DataSource = Me.Farma24BDDS2
        '
        'LaboratorioTableAdapter
        '
        Me.LaboratorioTableAdapter.ClearBeforeFill = True
        '
        'frmPLP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 454)
        Me.Controls.Add(Me.gbPLP)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPLP"
        Me.Text = "PLP"
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPLP.ResumeLayout(False)
        CType(Me.dgvPLP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Farma24BDDS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Farma24BDDS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresentacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaboratorioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbProducto As ComboBox
    Friend WithEvents cbLab As ComboBox
    Friend WithEvents cbPres As ComboBox
    Friend WithEvents Farma24BDDS As Farma24BDDS
    Friend WithEvents lbIdProd As Label
    Friend WithEvents lbIdPres As Label
    Friend WithEvents lbIdLaboratorio As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnGuardar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents gbPLP As GroupBox
    Friend WithEvents PLPTableAdapter As Farma24BDDSTableAdapters.PLPTableAdapter
    Friend WithEvents dgvPLP As DataGridView
    Friend WithEvents Farma24BDDS1 As Farma24BDDS
    Friend WithEvents Farma24BDDS2 As Farma24BDDS
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As Farma24BDDSTableAdapters.ProductoTableAdapter
    Friend WithEvents PresentacionBindingSource As BindingSource
    Friend WithEvents PresentacionTableAdapter As Farma24BDDSTableAdapters.PresentacionTableAdapter
    Friend WithEvents LaboratorioBindingSource As BindingSource
    Friend WithEvents LaboratorioTableAdapter As Farma24BDDSTableAdapters.LaboratorioTableAdapter
End Class
