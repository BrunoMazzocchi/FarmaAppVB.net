<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPresentacion
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
        Me.gbFondo = New System.Windows.Forms.GroupBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.gbContenedorDGV = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdPresentacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrePresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViaAdminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoPresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresentacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Farma24BDDS = New FarmaAppVB.Farma24BDDS()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtIdPres = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtViaAdmin = New System.Windows.Forms.TextBox()
        Me.txtNombreP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PresentacionTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.PresentacionTableAdapter()
        Me.gbFondo.SuspendLayout()
        Me.gbContenedorDGV.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresentacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbFondo
        '
        Me.gbFondo.BackColor = System.Drawing.Color.DodgerBlue
        Me.gbFondo.Controls.Add(Me.btnNuevo)
        Me.gbFondo.Controls.Add(Me.btnEliminar)
        Me.gbFondo.Controls.Add(Me.btnEditar)
        Me.gbFondo.Controls.Add(Me.btnAgregar)
        Me.gbFondo.Location = New System.Drawing.Point(576, -9)
        Me.gbFondo.Name = "gbFondo"
        Me.gbFondo.Size = New System.Drawing.Size(233, 456)
        Me.gbFondo.TabIndex = 0
        Me.gbFondo.TabStop = False
        '
        'btnNuevo
        '
        Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Cyan
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(71, 100)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(87, 30)
        Me.btnNuevo.TabIndex = 3
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(71, 340)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(87, 30)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(71, 260)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(87, 30)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(71, 180)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(87, 30)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'gbContenedorDGV
        '
        Me.gbContenedorDGV.Controls.Add(Me.DataGridView1)
        Me.gbContenedorDGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbContenedorDGV.Location = New System.Drawing.Point(8, 2)
        Me.gbContenedorDGV.Name = "gbContenedorDGV"
        Me.gbContenedorDGV.Size = New System.Drawing.Size(562, 247)
        Me.gbContenedorDGV.TabIndex = 1
        Me.gbContenedorDGV.TabStop = False
        Me.gbContenedorDGV.Text = "Datos Presentacion"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPresentacionDataGridViewTextBoxColumn, Me.NombrePresDataGridViewTextBoxColumn, Me.ViaAdminDataGridViewTextBoxColumn, Me.EstadoPresDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PresentacionBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(556, 226)
        Me.DataGridView1.TabIndex = 0
        '
        'IdPresentacionDataGridViewTextBoxColumn
        '
        Me.IdPresentacionDataGridViewTextBoxColumn.DataPropertyName = "idPresentacion"
        Me.IdPresentacionDataGridViewTextBoxColumn.HeaderText = "idPresentacion"
        Me.IdPresentacionDataGridViewTextBoxColumn.Name = "IdPresentacionDataGridViewTextBoxColumn"
        Me.IdPresentacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombrePresDataGridViewTextBoxColumn
        '
        Me.NombrePresDataGridViewTextBoxColumn.DataPropertyName = "nombrePres"
        Me.NombrePresDataGridViewTextBoxColumn.HeaderText = "nombrePres"
        Me.NombrePresDataGridViewTextBoxColumn.Name = "NombrePresDataGridViewTextBoxColumn"
        Me.NombrePresDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ViaAdminDataGridViewTextBoxColumn
        '
        Me.ViaAdminDataGridViewTextBoxColumn.DataPropertyName = "viaAdmin"
        Me.ViaAdminDataGridViewTextBoxColumn.HeaderText = "viaAdmin"
        Me.ViaAdminDataGridViewTextBoxColumn.Name = "ViaAdminDataGridViewTextBoxColumn"
        Me.ViaAdminDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoPresDataGridViewTextBoxColumn
        '
        Me.EstadoPresDataGridViewTextBoxColumn.DataPropertyName = "estadoPres"
        Me.EstadoPresDataGridViewTextBoxColumn.HeaderText = "estadoPres"
        Me.EstadoPresDataGridViewTextBoxColumn.Name = "EstadoPresDataGridViewTextBoxColumn"
        Me.EstadoPresDataGridViewTextBoxColumn.ReadOnly = True
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtIdPres)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtViaAdmin)
        Me.GroupBox2.Controls.Add(Me.txtNombreP)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 260)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(556, 187)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingrese los Datos de la Presentacion"
        '
        'txtIdPres
        '
        Me.txtIdPres.Location = New System.Drawing.Point(167, 53)
        Me.txtIdPres.Name = "txtIdPres"
        Me.txtIdPres.Size = New System.Drawing.Size(180, 22)
        Me.txtIdPres.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(164, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ID Pres:"
        '
        'txtViaAdmin
        '
        Me.txtViaAdmin.Location = New System.Drawing.Point(167, 141)
        Me.txtViaAdmin.Name = "txtViaAdmin"
        Me.txtViaAdmin.Size = New System.Drawing.Size(180, 22)
        Me.txtViaAdmin.TabIndex = 7
        '
        'txtNombreP
        '
        Me.txtNombreP.Location = New System.Drawing.Point(167, 97)
        Me.txtNombreP.Name = "txtNombreP"
        Me.txtNombreP.Size = New System.Drawing.Size(180, 22)
        Me.txtNombreP.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(164, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Via de administracion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(164, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nombre:"
        '
        'PresentacionTableAdapter
        '
        Me.PresentacionTableAdapter.ClearBeforeFill = True
        '
        'FrmPresentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbContenedorDGV)
        Me.Controls.Add(Me.gbFondo)
        Me.MaximumSize = New System.Drawing.Size(823, 489)
        Me.MinimumSize = New System.Drawing.Size(823, 489)
        Me.Name = "FrmPresentacion"
        Me.Text = "Presentacion"
        Me.gbFondo.ResumeLayout(False)
        Me.gbContenedorDGV.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresentacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbFondo As GroupBox
    Friend WithEvents gbContenedorDGV As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Farma24BDDS As Farma24BDDS
    Friend WithEvents PresentacionBindingSource As BindingSource
    Friend WithEvents PresentacionTableAdapter As Farma24BDDSTableAdapters.PresentacionTableAdapter
    Friend WithEvents IdPresentacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombrePresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ViaAdminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoPresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtIdPres As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtViaAdmin As TextBox
    Friend WithEvents txtNombreP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnNuevo As Button
End Class
