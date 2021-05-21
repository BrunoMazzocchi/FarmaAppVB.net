<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntrada
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Farma24BDDS = New FarmaAppVB.Farma24BDDS()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.UsuarioTableAdapter()
        Me.PLPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLPTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.PLPTableAdapter()
        Me.btnCancelar = New MaterialSkin.Controls.MaterialButton()
        Me.btnAceptar = New MaterialSkin.Controls.MaterialButton()
        Me.lbOb = New System.Windows.Forms.Label()
        Me.lbCantidad = New System.Windows.Forms.Label()
        Me.lbPrecio = New System.Windows.Forms.Label()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.lbPLP = New System.Windows.Forms.Label()
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.cbIdPlp = New System.Windows.Forms.ComboBox()
        Me.cbIdUsuario = New System.Windows.Forms.ComboBox()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Farma24BDDS
        '
        Me.Farma24BDDS.DataSetName = "Farma24BDDS"
        Me.Farma24BDDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.Farma24BDDS
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'PLPBindingSource
        '
        Me.PLPBindingSource.DataMember = "PLP"
        Me.PLPBindingSource.DataSource = Me.Farma24BDDS
        '
        'PLPTableAdapter
        '
        Me.PLPTableAdapter.ClearBeforeFill = True
        '
        'btnCancelar
        '
        Me.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancelar.Depth = 0
        Me.btnCancelar.DrawShadows = True
        Me.btnCancelar.HighEmphasis = True
        Me.btnCancelar.Icon = Nothing
        Me.btnCancelar.Location = New System.Drawing.Point(490, 349)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(96, 36)
        Me.btnCancelar.TabIndex = 44
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnCancelar.UseAccentColor = False
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAceptar.Depth = 0
        Me.btnAceptar.DrawShadows = True
        Me.btnAceptar.HighEmphasis = True
        Me.btnAceptar.Icon = Nothing
        Me.btnAceptar.Location = New System.Drawing.Point(183, 349)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 36)
        Me.btnAceptar.TabIndex = 43
        Me.btnAceptar.Text = "    Aceptar     "
        Me.btnAceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnAceptar.UseAccentColor = False
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lbOb
        '
        Me.lbOb.AutoSize = True
        Me.lbOb.Location = New System.Drawing.Point(487, 191)
        Me.lbOb.Name = "lbOb"
        Me.lbOb.Size = New System.Drawing.Size(88, 17)
        Me.lbOb.TabIndex = 42
        Me.lbOb.Text = "Observacion"
        '
        'lbCantidad
        '
        Me.lbCantidad.AutoSize = True
        Me.lbCantidad.Location = New System.Drawing.Point(111, 191)
        Me.lbCantidad.Name = "lbCantidad"
        Me.lbCantidad.Size = New System.Drawing.Size(64, 17)
        Me.lbCantidad.TabIndex = 41
        Me.lbCantidad.Text = "Cantidad"
        '
        'lbPrecio
        '
        Me.lbPrecio.AutoSize = True
        Me.lbPrecio.Location = New System.Drawing.Point(487, 129)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.Size = New System.Drawing.Size(48, 17)
        Me.lbPrecio.TabIndex = 40
        Me.lbPrecio.Text = "Precio"
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Location = New System.Drawing.Point(111, 129)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(52, 17)
        Me.lbEstado.TabIndex = 39
        Me.lbEstado.Text = "Estado"
        '
        'lbPLP
        '
        Me.lbPLP.AutoSize = True
        Me.lbPLP.Location = New System.Drawing.Point(487, 66)
        Me.lbPLP.Name = "lbPLP"
        Me.lbPLP.Size = New System.Drawing.Size(34, 17)
        Me.lbPLP.TabIndex = 38
        Me.lbPLP.Text = "PLP"
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.Location = New System.Drawing.Point(111, 66)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(57, 17)
        Me.lbUsuario.TabIndex = 37
        Me.lbUsuario.Text = "Usuario"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(111, 257)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 36
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(111, 211)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(200, 22)
        Me.txtCantidad.TabIndex = 35
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(490, 149)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(200, 22)
        Me.txtPrecio.TabIndex = 34
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(490, 211)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(200, 68)
        Me.txtObservacion.TabIndex = 33
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(111, 149)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(200, 22)
        Me.txtEstado.TabIndex = 32
        '
        'cbIdPlp
        '
        Me.cbIdPlp.DisplayMember = "idPLP"
        Me.cbIdPlp.FormattingEnabled = True
        Me.cbIdPlp.Location = New System.Drawing.Point(490, 89)
        Me.cbIdPlp.Name = "cbIdPlp"
        Me.cbIdPlp.Size = New System.Drawing.Size(200, 24)
        Me.cbIdPlp.TabIndex = 31
        Me.cbIdPlp.ValueMember = "idPLP"
        '
        'cbIdUsuario
        '
        Me.cbIdUsuario.DisplayMember = "nombres"
        Me.cbIdUsuario.FormattingEnabled = True
        Me.cbIdUsuario.Location = New System.Drawing.Point(111, 89)
        Me.cbIdUsuario.Name = "cbIdUsuario"
        Me.cbIdUsuario.Size = New System.Drawing.Size(200, 24)
        Me.cbIdUsuario.TabIndex = 30
        Me.cbIdUsuario.ValueMember = "idUser"
        '
        'frmEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lbOb)
        Me.Controls.Add(Me.lbCantidad)
        Me.Controls.Add(Me.lbPrecio)
        Me.Controls.Add(Me.lbEstado)
        Me.Controls.Add(Me.lbPLP)
        Me.Controls.Add(Me.lbUsuario)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.cbIdPlp)
        Me.Controls.Add(Me.cbIdUsuario)
        Me.MaximumSize = New System.Drawing.Size(818, 497)
        Me.MinimumSize = New System.Drawing.Size(818, 497)
        Me.Name = "frmEntrada"
        Me.Text = "Entradas"
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Farma24BDDS As Farma24BDDS
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As Farma24BDDSTableAdapters.UsuarioTableAdapter
    Friend WithEvents PLPBindingSource As BindingSource
    Friend WithEvents PLPTableAdapter As Farma24BDDSTableAdapters.PLPTableAdapter
    Friend WithEvents btnCancelar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnAceptar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lbOb As Label
    Friend WithEvents lbCantidad As Label
    Friend WithEvents lbPrecio As Label
    Friend WithEvents lbEstado As Label
    Friend WithEvents lbPLP As Label
    Friend WithEvents lbUsuario As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents cbIdPlp As ComboBox
    Friend WithEvents cbIdUsuario As ComboBox
End Class
