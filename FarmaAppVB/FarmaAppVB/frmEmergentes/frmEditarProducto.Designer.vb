﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCancelar = New MaterialSkin.Controls.MaterialButton()
        Me.btnAgregar = New MaterialSkin.Controls.MaterialButton()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "descripProd", True))
        Me.txtDescripcion.Location = New System.Drawing.Point(448, 293)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.txtPrecio.Location = New System.Drawing.Point(177, 183)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(176, 22)
        Me.txtPrecio.TabIndex = 18
        '
        'txtExistencia
        '
        Me.txtExistencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "existProd", True))
        Me.txtExistencia.Location = New System.Drawing.Point(176, 240)
        Me.txtExistencia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtExistencia.Name = "txtExistencia"
        Me.txtExistencia.Size = New System.Drawing.Size(176, 22)
        Me.txtExistencia.TabIndex = 17
        '
        'txtDosis
        '
        Me.txtDosis.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "dosisProd", True))
        Me.txtDosis.Location = New System.Drawing.Point(448, 130)
        Me.txtDosis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDosis.Name = "txtDosis"
        Me.txtDosis.Size = New System.Drawing.Size(176, 22)
        Me.txtDosis.TabIndex = 15
        '
        'txtPermiso
        '
        Me.txtPermiso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "permisoProd", True))
        Me.txtPermiso.Location = New System.Drawing.Point(447, 183)
        Me.txtPermiso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPermiso.Name = "txtPermiso"
        Me.txtPermiso.Size = New System.Drawing.Size(176, 22)
        Me.txtPermiso.TabIndex = 14
        '
        'txtEstado
        '
        Me.txtEstado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "estadoProd", True))
        Me.txtEstado.Location = New System.Drawing.Point(448, 240)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(176, 22)
        Me.txtEstado.TabIndex = 13
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "nombreProducto", True))
        Me.txtNombre.Location = New System.Drawing.Point(177, 130)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.txtEditarId.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEditarId.Name = "txtEditarId"
        Me.txtEditarId.Size = New System.Drawing.Size(260, 24)
        Me.txtEditarId.TabIndex = 22
        Me.txtEditarId.ValueMember = "idProducto"
        '
        'txtExp
        '
        Me.txtExp.Location = New System.Drawing.Point(176, 289)
        Me.txtExp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtExp.Name = "txtExp"
        Me.txtExp.Size = New System.Drawing.Size(176, 22)
        Me.txtExp.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(355, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "ID PRODUCTO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 112)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(173, 165)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(173, 220)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Existencias"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(173, 271)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Expiracion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(444, 112)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 17)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Dosis"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(444, 165)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 17)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Permiso"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(444, 220)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 17)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Estado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(444, 271)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 17)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Descripion"
        '
        'btnCancelar
        '
        Me.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancelar.Depth = 0
        Me.btnCancelar.DrawShadows = True
        Me.btnCancelar.HighEmphasis = True
        Me.btnCancelar.Icon = Nothing
        Me.btnCancelar.Location = New System.Drawing.Point(466, 377)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancelar.MaximumSize = New System.Drawing.Size(158, 36)
        Me.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(128, 36)
        Me.btnCancelar.TabIndex = 34
        Me.btnCancelar.Text = "         Cancelar         "
        Me.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnCancelar.UseAccentColor = False
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAgregar.Depth = 0
        Me.btnAgregar.DrawShadows = True
        Me.btnAgregar.HighEmphasis = True
        Me.btnAgregar.Icon = Nothing
        Me.btnAgregar.Location = New System.Drawing.Point(213, 377)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAgregar.MaximumSize = New System.Drawing.Size(158, 36)
        Me.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(127, 36)
        Me.btnAgregar.TabIndex = 33
        Me.btnAgregar.Text = "           Editar          "
        Me.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnAgregar.UseAccentColor = False
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'frmEditarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 441)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtExp)
        Me.Controls.Add(Me.txtEditarId)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtExistencia)
        Me.Controls.Add(Me.txtDosis)
        Me.Controls.Add(Me.txtPermiso)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.txtNombre)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(815, 488)
        Me.MinimumSize = New System.Drawing.Size(815, 488)
        Me.Name = "frmEditarProducto"
        Me.Text = "Editar Producto"
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCancelar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnAgregar As MaterialSkin.Controls.MaterialButton
End Class
