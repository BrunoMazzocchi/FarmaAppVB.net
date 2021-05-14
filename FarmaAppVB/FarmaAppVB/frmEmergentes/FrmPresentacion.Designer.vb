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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtViaAdm = New System.Windows.Forms.TextBox()
        Me.txtnombrePres = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtIdPres = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtViaAdmin = New System.Windows.Forms.TextBox()
        Me.txtNombreP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtIdP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.IdPresentacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrePresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViaAdminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoPresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresentacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Farma24BDDS = New FarmaAppVB.Farma24BDDS()
        Me.PresentacionTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.PresentacionTableAdapter()
        Me.gbFondo.SuspendLayout()
        Me.gbContenedorDGV.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PresentacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gbFondo.Size = New System.Drawing.Size(233, 258)
        Me.gbFondo.TabIndex = 0
        Me.gbFondo.TabStop = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(71, 29)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(87, 30)
        Me.btnNuevo.TabIndex = 3
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(71, 204)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(87, 30)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(71, 144)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(87, 30)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(71, 88)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtViaAdm)
        Me.GroupBox1.Controls.Add(Me.txtnombrePres)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 260)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 187)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Presentacion"
        '
        'txtViaAdm
        '
        Me.txtViaAdm.Location = New System.Drawing.Point(79, 123)
        Me.txtViaAdm.Name = "txtViaAdm"
        Me.txtViaAdm.Size = New System.Drawing.Size(180, 22)
        Me.txtViaAdm.TabIndex = 3
        '
        'txtnombrePres
        '
        Me.txtnombrePres.Location = New System.Drawing.Point(79, 53)
        Me.txtnombrePres.Name = "txtnombrePres"
        Me.txtnombrePres.Size = New System.Drawing.Size(180, 22)
        Me.txtnombrePres.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Via de administracion:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
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
        Me.GroupBox2.Location = New System.Drawing.Point(294, 260)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(273, 187)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Editar Presentacion"
        '
        'txtIdPres
        '
        Me.txtIdPres.Location = New System.Drawing.Point(79, 30)
        Me.txtIdPres.Name = "txtIdPres"
        Me.txtIdPres.Size = New System.Drawing.Size(180, 22)
        Me.txtIdPres.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ID Pres:"
        '
        'txtViaAdmin
        '
        Me.txtViaAdmin.Location = New System.Drawing.Point(79, 146)
        Me.txtViaAdmin.Name = "txtViaAdmin"
        Me.txtViaAdmin.Size = New System.Drawing.Size(180, 22)
        Me.txtViaAdmin.TabIndex = 7
        '
        'txtNombreP
        '
        Me.txtNombreP.Location = New System.Drawing.Point(79, 73)
        Me.txtNombreP.Name = "txtNombreP"
        Me.txtNombreP.Size = New System.Drawing.Size(180, 22)
        Me.txtNombreP.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Via de administracion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nombre:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtIdP)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(573, 260)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(236, 187)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Eliminar Presentacion"
        '
        'txtIdP
        '
        Me.txtIdP.Location = New System.Drawing.Point(74, 76)
        Me.txtIdP.Name = "txtIdP"
        Me.txtIdP.Size = New System.Drawing.Size(143, 22)
        Me.txtIdP.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "ID Pres:"
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
        'PresentacionTableAdapter
        '
        Me.PresentacionTableAdapter.ClearBeforeFill = True
        '
        'FrmPresentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbContenedorDGV)
        Me.Controls.Add(Me.gbFondo)
        Me.Name = "FrmPresentacion"
        Me.Text = "FrmPresentacion"
        Me.gbFondo.ResumeLayout(False)
        Me.gbContenedorDGV.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PresentacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtViaAdm As TextBox
    Friend WithEvents txtnombrePres As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
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
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtIdP As TextBox
    Friend WithEvents Label6 As Label
End Class
