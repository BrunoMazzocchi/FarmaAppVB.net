﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnBuscarID = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscarID = New System.Windows.Forms.TextBox()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.gbDgv = New System.Windows.Forms.GroupBox()
        Me.btnCerrarSesion = New System.Windows.Forms.DataGridView()
        Me.gbControles = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnInfoVendedores = New System.Windows.Forms.Button()
        Me.btnHistorial = New System.Windows.Forms.Button()
        Me.gbBtnCrud = New System.Windows.Forms.GroupBox()
        Me.gbCrud = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnLaboratorio = New System.Windows.Forms.Button()
        Me.btnPresentacion = New System.Windows.Forms.Button()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DosisProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PermisoProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Farma24BDDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Farma24BDDS = New FarmaAppVB.Farma24BDDS()
        Me.ProductoTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.ProductoTableAdapter()
        Me.lbBienvenido = New System.Windows.Forms.Label()
        Me.lbUser = New System.Windows.Forms.Label()
        Me.gbBarra.SuspendLayout()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDgv.SuspendLayout()
        CType(Me.btnCerrarSesion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbControles.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBtnCrud.SuspendLayout()
        CType(Me.Farma24BDDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbBarra
        '
        Me.gbBarra.Controls.Add(Me.btnImprimir)
        Me.gbBarra.Controls.Add(Me.btnBuscarID)
        Me.gbBarra.Controls.Add(Me.btnBuscar)
        Me.gbBarra.Controls.Add(Me.txtBuscarID)
        Me.gbBarra.Controls.Add(Me.txtBuscar)
        Me.gbBarra.Location = New System.Drawing.Point(469, 33)
        Me.gbBarra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbBarra.Name = "gbBarra"
        Me.gbBarra.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbBarra.Size = New System.Drawing.Size(667, 65)
        Me.gbBarra.TabIndex = 1
        Me.gbBarra.TabStop = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(547, 18)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(108, 37)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnBuscarID
        '
        Me.btnBuscarID.Location = New System.Drawing.Point(267, 37)
        Me.btnBuscarID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBuscarID.Name = "btnBuscarID"
        Me.btnBuscarID.Size = New System.Drawing.Size(107, 25)
        Me.btnBuscarID.TabIndex = 3
        Me.btnBuscarID.Text = "Buscar ID"
        Me.btnBuscarID.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(267, 10)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(107, 25)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscarID
        '
        Me.txtBuscarID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "idProducto", True))
        Me.txtBuscarID.Location = New System.Drawing.Point(28, 38)
        Me.txtBuscarID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBuscarID.Name = "txtBuscarID"
        Me.txtBuscarID.Size = New System.Drawing.Size(231, 22)
        Me.txtBuscarID.TabIndex = 1
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.Farma24BDDSBindingSource
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(28, 10)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(231, 22)
        Me.txtBuscar.TabIndex = 0
        '
        'gbDgv
        '
        Me.gbDgv.Controls.Add(Me.btnCerrarSesion)
        Me.gbDgv.Location = New System.Drawing.Point(469, 224)
        Me.gbDgv.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbDgv.Name = "gbDgv"
        Me.gbDgv.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbDgv.Size = New System.Drawing.Size(697, 378)
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
        Me.btnCerrarSesion.Size = New System.Drawing.Size(691, 359)
        Me.btnCerrarSesion.TabIndex = 0
        '
        'gbControles
        '
        Me.gbControles.BackColor = System.Drawing.Color.DodgerBlue
        Me.gbControles.Controls.Add(Me.lbUser)
        Me.gbControles.Controls.Add(Me.lbBienvenido)
        Me.gbControles.Controls.Add(Me.PictureBox1)
        Me.gbControles.Controls.Add(Me.btnCerrar)
        Me.gbControles.Controls.Add(Me.btnInfoVendedores)
        Me.gbControles.Controls.Add(Me.btnHistorial)
        Me.gbControles.Controls.Add(Me.gbBtnCrud)
        Me.gbControles.Location = New System.Drawing.Point(-7, -10)
        Me.gbControles.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbControles.Name = "gbControles"
        Me.gbControles.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbControles.Size = New System.Drawing.Size(271, 622)
        Me.gbControles.TabIndex = 0
        Me.gbControles.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FarmaAppVB.My.Resources.Resources.EldianEmpire
        Me.PictureBox1.Location = New System.Drawing.Point(47, 62)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(173, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(47, 522)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(173, 31)
        Me.btnCerrar.TabIndex = 13
        Me.btnCerrar.Text = "Cerrar Sesion"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnInfoVendedores
        '
        Me.btnInfoVendedores.Location = New System.Drawing.Point(47, 464)
        Me.btnInfoVendedores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInfoVendedores.Name = "btnInfoVendedores"
        Me.btnInfoVendedores.Size = New System.Drawing.Size(173, 31)
        Me.btnInfoVendedores.TabIndex = 11
        Me.btnInfoVendedores.Text = "Info. Usuarios"
        Me.btnInfoVendedores.UseVisualStyleBackColor = True
        '
        'btnHistorial
        '
        Me.btnHistorial.Location = New System.Drawing.Point(47, 409)
        Me.btnHistorial.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Size = New System.Drawing.Size(173, 31)
        Me.btnHistorial.TabIndex = 10
        Me.btnHistorial.Text = "Historial"
        Me.btnHistorial.UseVisualStyleBackColor = True
        '
        'gbBtnCrud
        '
        Me.gbBtnCrud.BackColor = System.Drawing.Color.DodgerBlue
        Me.gbBtnCrud.Controls.Add(Me.gbCrud)
        Me.gbBtnCrud.Location = New System.Drawing.Point(271, 0)
        Me.gbBtnCrud.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbBtnCrud.Name = "gbBtnCrud"
        Me.gbBtnCrud.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbBtnCrud.Size = New System.Drawing.Size(223, 642)
        Me.gbBtnCrud.TabIndex = 1
        Me.gbBtnCrud.TabStop = False
        '
        'gbCrud
        '
        Me.gbCrud.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbCrud.Location = New System.Drawing.Point(216, 102)
        Me.gbCrud.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbCrud.Name = "gbCrud"
        Me.gbCrud.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbCrud.Size = New System.Drawing.Size(160, 441)
        Me.gbCrud.TabIndex = 1
        Me.gbCrud.TabStop = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(320, 320)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(73, 37)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(320, 369)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(73, 37)
        Me.btnEditar.TabIndex = 8
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(320, 418)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(73, 37)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnLaboratorio
        '
        Me.btnLaboratorio.Location = New System.Drawing.Point(307, 37)
        Me.btnLaboratorio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLaboratorio.Name = "btnLaboratorio"
        Me.btnLaboratorio.Size = New System.Drawing.Size(107, 31)
        Me.btnLaboratorio.TabIndex = 10
        Me.btnLaboratorio.Text = "Laboratorios"
        Me.btnLaboratorio.UseVisualStyleBackColor = True
        '
        'btnPresentacion
        '
        Me.btnPresentacion.Location = New System.Drawing.Point(307, 86)
        Me.btnPresentacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPresentacion.Name = "btnPresentacion"
        Me.btnPresentacion.Size = New System.Drawing.Size(107, 31)
        Me.btnPresentacion.TabIndex = 11
        Me.btnPresentacion.Text = "Presentacion"
        Me.btnPresentacion.UseVisualStyleBackColor = True
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
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'lbBienvenido
        '
        Me.lbBienvenido.AutoSize = True
        Me.lbBienvenido.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBienvenido.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbBienvenido.Location = New System.Drawing.Point(6, 251)
        Me.lbBienvenido.Name = "lbBienvenido"
        Me.lbBienvenido.Size = New System.Drawing.Size(237, 24)
        Me.lbBienvenido.TabIndex = 15
        Me.lbBienvenido.Text = "Bienvenido de nuevo"
        '
        'lbUser
        '
        Me.lbUser.AutoSize = True
        Me.lbUser.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbUser.Location = New System.Drawing.Point(95, 275)
        Me.lbUser.Name = "lbUser"
        Me.lbUser.Size = New System.Drawing.Size(0, 24)
        Me.lbUser.TabIndex = 16
        '
        'frmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 596)
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
        Me.MaximumSize = New System.Drawing.Size(1186, 643)
        Me.MinimumSize = New System.Drawing.Size(1186, 643)
        Me.Name = "frmProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Producto"
        Me.gbBarra.ResumeLayout(False)
        Me.gbBarra.PerformLayout()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDgv.ResumeLayout(False)
        CType(Me.btnCerrarSesion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbControles.ResumeLayout(False)
        Me.gbControles.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBtnCrud.ResumeLayout(False)
        CType(Me.Farma24BDDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbBarra As GroupBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnBuscarID As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscarID As TextBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents gbDgv As GroupBox
    Friend WithEvents gbControles As GroupBox
    Friend WithEvents gbBtnCrud As GroupBox
    Friend WithEvents gbCrud As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Farma24BDDSBindingSource As BindingSource
    Friend WithEvents Farma24BDDS As Farma24BDDS
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnInfoVendedores As Button
    Friend WithEvents btnHistorial As Button
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
    Friend WithEvents btnLaboratorio As Button
    Friend WithEvents btnPresentacion As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbUser As Label
    Friend WithEvents lbBienvenido As Label
End Class
