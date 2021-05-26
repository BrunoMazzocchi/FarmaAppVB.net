<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dgvLaboratorio
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
        Me.LaboratorioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Farma24BDDS = New FarmaAppVB.Farma24BDDS()
        Me.LaboratorioTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.LaboratorioTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvLaboratori = New System.Windows.Forms.DataGridView()
        Me.IdLaboratorioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreLabDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCerrar = New MaterialSkin.Controls.MaterialButton()
        Me.btnEliminar = New MaterialSkin.Controls.MaterialButton()
        Me.btnEditar = New MaterialSkin.Controls.MaterialButton()
        Me.btnAgregar = New MaterialSkin.Controls.MaterialButton()
        Me.btnNuevo = New MaterialSkin.Controls.MaterialButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtnombreL = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtidLab = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.LaboratorioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvLaboratori, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'LaboratorioBindingSource
        '
        Me.LaboratorioBindingSource.DataMember = "Laboratorio"
        Me.LaboratorioBindingSource.DataSource = Me.Farma24BDDS
        '
        'Farma24BDDS
        '
        Me.Farma24BDDS.DataSetName = "Farma24BDDS"
        Me.Farma24BDDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LaboratorioTableAdapter
        '
        Me.LaboratorioTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvLaboratori)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(562, 247)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Laboratorios"
        '
        'dgvLaboratori
        '
        Me.dgvLaboratori.AllowUserToAddRows = False
        Me.dgvLaboratori.AllowUserToDeleteRows = False
        Me.dgvLaboratori.AutoGenerateColumns = False
        Me.dgvLaboratori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLaboratori.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdLaboratorioDataGridViewTextBoxColumn, Me.NombreLabDataGridViewTextBoxColumn})
        Me.dgvLaboratori.DataSource = Me.LaboratorioBindingSource
        Me.dgvLaboratori.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLaboratori.Location = New System.Drawing.Point(3, 19)
        Me.dgvLaboratori.Name = "dgvLaboratori"
        Me.dgvLaboratori.ReadOnly = True
        Me.dgvLaboratori.RowHeadersWidth = 51
        Me.dgvLaboratori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLaboratori.Size = New System.Drawing.Size(556, 225)
        Me.dgvLaboratori.TabIndex = 0
        '
        'IdLaboratorioDataGridViewTextBoxColumn
        '
        Me.IdLaboratorioDataGridViewTextBoxColumn.DataPropertyName = "idLaboratorio"
        Me.IdLaboratorioDataGridViewTextBoxColumn.HeaderText = "ID Lab"
        Me.IdLaboratorioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdLaboratorioDataGridViewTextBoxColumn.Name = "IdLaboratorioDataGridViewTextBoxColumn"
        Me.IdLaboratorioDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdLaboratorioDataGridViewTextBoxColumn.Width = 125
        '
        'NombreLabDataGridViewTextBoxColumn
        '
        Me.NombreLabDataGridViewTextBoxColumn.DataPropertyName = "nombreLab"
        Me.NombreLabDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreLabDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreLabDataGridViewTextBoxColumn.Name = "NombreLabDataGridViewTextBoxColumn"
        Me.NombreLabDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreLabDataGridViewTextBoxColumn.Width = 125
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Controls.Add(Me.btnCerrar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(577, -9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 456)
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
        Me.btnCerrar.Location = New System.Drawing.Point(60, 302)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnCerrar.MaximumSize = New System.Drawing.Size(118, 29)
        Me.btnCerrar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(116, 29)
        Me.btnCerrar.TabIndex = 9
        Me.btnCerrar.Text = "           Cerrar          "
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
        Me.btnEliminar.Location = New System.Drawing.Point(60, 252)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnEliminar.MaximumSize = New System.Drawing.Size(118, 29)
        Me.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(113, 29)
        Me.btnEliminar.TabIndex = 3
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
        Me.btnEditar.Location = New System.Drawing.Point(60, 198)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnEditar.MaximumSize = New System.Drawing.Size(118, 29)
        Me.btnEditar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(114, 29)
        Me.btnEditar.TabIndex = 2
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
        Me.btnAgregar.Location = New System.Drawing.Point(60, 141)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnAgregar.MaximumSize = New System.Drawing.Size(118, 29)
        Me.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(116, 29)
        Me.btnAgregar.TabIndex = 1
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
        Me.btnNuevo.Location = New System.Drawing.Point(60, 83)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnNuevo.MaximumSize = New System.Drawing.Size(118, 29)
        Me.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(118, 29)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "              Nuevo              "
        Me.btnNuevo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnNuevo.UseAccentColor = False
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtnombreL)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtidLab)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(9, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(556, 187)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ingrese los Datos del Laboratorio"
        '
        'txtnombreL
        '
        Me.txtnombreL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaboratorioBindingSource, "nombreLab", True))
        Me.txtnombreL.Location = New System.Drawing.Point(204, 121)
        Me.txtnombreL.Name = "txtnombreL"
        Me.txtnombreL.Size = New System.Drawing.Size(143, 23)
        Me.txtnombreL.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(201, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre laboratorio:"
        '
        'txtidLab
        '
        Me.txtidLab.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LaboratorioBindingSource, "idLaboratorio", True))
        Me.txtidLab.Location = New System.Drawing.Point(204, 65)
        Me.txtidLab.Name = "txtidLab"
        Me.txtidLab.Size = New System.Drawing.Size(143, 23)
        Me.txtidLab.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(201, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Laboratorio:"
        '
        'dgvLaboratorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 447)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(822, 486)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(822, 486)
        Me.Name = "dgvLaboratorio"
        Me.Text = "Laboratorio"
        CType(Me.LaboratorioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvLaboratori, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Farma24BDDS As Farma24BDDS
    Friend WithEvents LaboratorioBindingSource As BindingSource
    Friend WithEvents LaboratorioTableAdapter As Farma24BDDSTableAdapters.LaboratorioTableAdapter
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvLaboratori As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnEliminar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnEditar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnAgregar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnNuevo As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnCerrar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtnombreL As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtidLab As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents IdLaboratorioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreLabDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
