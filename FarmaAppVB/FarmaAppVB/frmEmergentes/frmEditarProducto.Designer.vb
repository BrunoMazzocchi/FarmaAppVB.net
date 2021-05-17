<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditarProducto
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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.RichTextBox()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Farma24BDDS = New FarmaAppVB.Farma24BDDS()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtExistencia = New System.Windows.Forms.TextBox()
        Me.txtDosis = New System.Windows.Forms.TextBox()
        Me.txtPermiso = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.ProductoTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.ProductoTableAdapter()
        Me.PLPTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.PLPTableAdapter()
        Me.txtEditarId = New System.Windows.Forms.ComboBox()
        Me.txtExp = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(448, 378)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(176, 23)
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(177, 378)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(176, 23)
        Me.btnEditar.TabIndex = 20
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "descripProd", True))
        Me.txtDescripcion.Location = New System.Drawing.Point(448, 249)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(176, 67)
        Me.txtDescripcion.TabIndex = 19
        Me.txtDescripcion.Text = ""
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
        'txtPrecio
        '
        Me.txtPrecio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "precioProd", True))
        Me.txtPrecio.Location = New System.Drawing.Point(177, 171)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(176, 22)
        Me.txtPrecio.TabIndex = 18
        '
        'txtExistencia
        '
        Me.txtExistencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "existProd", True))
        Me.txtExistencia.Location = New System.Drawing.Point(177, 210)
        Me.txtExistencia.Name = "txtExistencia"
        Me.txtExistencia.Size = New System.Drawing.Size(176, 22)
        Me.txtExistencia.TabIndex = 17
        '
        'txtDosis
        '
        Me.txtDosis.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "dosisProd", True))
        Me.txtDosis.Location = New System.Drawing.Point(448, 131)
        Me.txtDosis.Name = "txtDosis"
        Me.txtDosis.Size = New System.Drawing.Size(176, 22)
        Me.txtDosis.TabIndex = 15
        '
        'txtPermiso
        '
        Me.txtPermiso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "permisoProd", True))
        Me.txtPermiso.Location = New System.Drawing.Point(448, 171)
        Me.txtPermiso.Name = "txtPermiso"
        Me.txtPermiso.Size = New System.Drawing.Size(176, 22)
        Me.txtPermiso.TabIndex = 14
        '
        'txtEstado
        '
        Me.txtEstado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "estadoProd", True))
        Me.txtEstado.Location = New System.Drawing.Point(448, 210)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(176, 22)
        Me.txtEstado.TabIndex = 13
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "nombreProducto", True))
        Me.txtNombre.Location = New System.Drawing.Point(177, 131)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(176, 22)
        Me.txtNombre.TabIndex = 12
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'PLPTableAdapter
        '
        Me.PLPTableAdapter.ClearBeforeFill = True
        '
        'txtEditarId
        '
        Me.txtEditarId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "idProducto", True))
        Me.txtEditarId.DataSource = Me.ProductoBindingSource
        Me.txtEditarId.DisplayMember = "idProducto"
        Me.txtEditarId.FormattingEnabled = True
        Me.txtEditarId.Location = New System.Drawing.Point(283, 39)
        Me.txtEditarId.Name = "txtEditarId"
        Me.txtEditarId.Size = New System.Drawing.Size(260, 24)
        Me.txtEditarId.TabIndex = 22
        Me.txtEditarId.ValueMember = "idProducto"
        '
        'txtExp
        '
        Me.txtExp.Location = New System.Drawing.Point(177, 249)
        Me.txtExp.Name = "txtExp"
        Me.txtExp.Size = New System.Drawing.Size(176, 22)
        Me.txtExp.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(355, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "ID PRODUCTO"
        '
        'frmEditarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtExp)
        Me.Controls.Add(Me.txtEditarId)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtExistencia)
        Me.Controls.Add(Me.txtDosis)
        Me.Controls.Add(Me.txtPermiso)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "frmEditarProducto"
        Me.Text = "frmEditarProducto"
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents txtDescripcion As RichTextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtExistencia As TextBox
    Friend WithEvents txtDosis As TextBox
    Friend WithEvents txtPermiso As TextBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Farma24BDDS As Farma24BDDS
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As Farma24BDDSTableAdapters.ProductoTableAdapter
    Friend WithEvents PLPTableAdapter As Farma24BDDSTableAdapters.PLPTableAdapter
    Friend WithEvents txtEditarId As ComboBox
    Friend WithEvents txtExp As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
