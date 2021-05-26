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
        Me.btnCancelar = New MaterialSkin.Controls.MaterialButton()
        Me.lbOb = New System.Windows.Forms.Label()
        Me.lbCantidad = New System.Windows.Forms.Label()
        Me.lbPrecio = New System.Windows.Forms.Label()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.lbPLP = New System.Windows.Forms.Label()
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.cbIdPlp = New System.Windows.Forms.ComboBox()
        Me.PLPBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Farma24BDDS = New FarmaAppVB.Farma24BDDS()
        Me.PLPBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbIdUsuario = New System.Windows.Forms.ComboBox()
        Me.UsuarioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbEntradas = New System.Windows.Forms.GroupBox()
        Me.dgvEntrada = New System.Windows.Forms.DataGridView()
        Me.EntradaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.UsuarioTableAdapter()
        Me.PLPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLPTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.PLPTableAdapter()
        Me.EntradaTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.EntradaTableAdapter()
        Me.SalidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalidaTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.SalidaTableAdapter()
        Me.btnAceptar = New MaterialSkin.Controls.MaterialButton()
        Me.MostrarPLPNuevoToolStrip = New System.Windows.Forms.ToolStrip()
        Me.MostrarPLPNuevoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PLPBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PLPBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLPBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEntradas.SuspendLayout()
        CType(Me.dgvEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntradaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MostrarPLPNuevoToolStrip.SuspendLayout()
        CType(Me.PLPBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancelar.Depth = 0
        Me.btnCancelar.DrawShadows = True
        Me.btnCancelar.HighEmphasis = True
        Me.btnCancelar.Icon = Nothing
        Me.btnCancelar.Location = New System.Drawing.Point(433, 240)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(96, 36)
        Me.btnCancelar.TabIndex = 59
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnCancelar.UseAccentColor = False
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lbOb
        '
        Me.lbOb.AutoSize = True
        Me.lbOb.Location = New System.Drawing.Point(430, 136)
        Me.lbOb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbOb.Name = "lbOb"
        Me.lbOb.Size = New System.Drawing.Size(67, 13)
        Me.lbOb.TabIndex = 57
        Me.lbOb.Text = "Observacion"
        '
        'lbCantidad
        '
        Me.lbCantidad.AutoSize = True
        Me.lbCantidad.Location = New System.Drawing.Point(148, 136)
        Me.lbCantidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCantidad.Name = "lbCantidad"
        Me.lbCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lbCantidad.TabIndex = 56
        Me.lbCantidad.Text = "Cantidad"
        '
        'lbPrecio
        '
        Me.lbPrecio.AutoSize = True
        Me.lbPrecio.Location = New System.Drawing.Point(430, 85)
        Me.lbPrecio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.Size = New System.Drawing.Size(37, 13)
        Me.lbPrecio.TabIndex = 55
        Me.lbPrecio.Text = "Precio"
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Location = New System.Drawing.Point(148, 85)
        Me.lbEstado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(40, 13)
        Me.lbEstado.TabIndex = 54
        Me.lbEstado.Text = "Estado"
        '
        'lbPLP
        '
        Me.lbPLP.AutoSize = True
        Me.lbPLP.Location = New System.Drawing.Point(430, 34)
        Me.lbPLP.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbPLP.Name = "lbPLP"
        Me.lbPLP.Size = New System.Drawing.Size(27, 13)
        Me.lbPLP.TabIndex = 53
        Me.lbPLP.Text = "PLP"
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.Location = New System.Drawing.Point(148, 34)
        Me.lbUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lbUsuario.TabIndex = 52
        Me.lbUsuario.Text = "Usuario"
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(148, 189)
        Me.dtp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(151, 20)
        Me.dtp.TabIndex = 51
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(148, 152)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(151, 20)
        Me.txtCantidad.TabIndex = 50
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(433, 102)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(151, 20)
        Me.txtPrecio.TabIndex = 49
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(433, 152)
        Me.txtObservacion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(151, 56)
        Me.txtObservacion.TabIndex = 48
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(148, 102)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(151, 20)
        Me.txtEstado.TabIndex = 47
        '
        'cbIdPlp
        '
        Me.cbIdPlp.FormattingEnabled = True
        Me.cbIdPlp.Location = New System.Drawing.Point(433, 53)
        Me.cbIdPlp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbIdPlp.Name = "cbIdPlp"
        Me.cbIdPlp.Size = New System.Drawing.Size(151, 21)
        Me.cbIdPlp.TabIndex = 46
        '
        'PLPBindingSource2
        '
        Me.PLPBindingSource2.DataMember = "PLP"
        Me.PLPBindingSource2.DataSource = Me.Farma24BDDS
        '
        'Farma24BDDS
        '
        Me.Farma24BDDS.DataSetName = "Farma24BDDS"
        Me.Farma24BDDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PLPBindingSource1
        '
        Me.PLPBindingSource1.DataMember = "PLP"
        Me.PLPBindingSource1.DataSource = Me.Farma24BDDS
        '
        'cbIdUsuario
        '
        Me.cbIdUsuario.DataSource = Me.UsuarioBindingSource1
        Me.cbIdUsuario.DisplayMember = "nombres"
        Me.cbIdUsuario.FormattingEnabled = True
        Me.cbIdUsuario.Location = New System.Drawing.Point(148, 53)
        Me.cbIdUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbIdUsuario.Name = "cbIdUsuario"
        Me.cbIdUsuario.Size = New System.Drawing.Size(151, 21)
        Me.cbIdUsuario.TabIndex = 45
        Me.cbIdUsuario.ValueMember = "idUser"
        '
        'UsuarioBindingSource1
        '
        Me.UsuarioBindingSource1.DataMember = "Usuario"
        Me.UsuarioBindingSource1.DataSource = Me.Farma24BDDS
        '
        'gbEntradas
        '
        Me.gbEntradas.Controls.Add(Me.dgvEntrada)
        Me.gbEntradas.Location = New System.Drawing.Point(9, 301)
        Me.gbEntradas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbEntradas.Name = "gbEntradas"
        Me.gbEntradas.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbEntradas.Size = New System.Drawing.Size(710, 179)
        Me.gbEntradas.TabIndex = 60
        Me.gbEntradas.TabStop = False
        Me.gbEntradas.Text = "Entradas"
        '
        'dgvEntrada
        '
        Me.dgvEntrada.AllowUserToAddRows = False
        Me.dgvEntrada.AllowUserToDeleteRows = False
        Me.dgvEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEntrada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEntrada.Location = New System.Drawing.Point(2, 15)
        Me.dgvEntrada.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvEntrada.Name = "dgvEntrada"
        Me.dgvEntrada.ReadOnly = True
        Me.dgvEntrada.RowHeadersWidth = 51
        Me.dgvEntrada.RowTemplate.Height = 24
        Me.dgvEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEntrada.Size = New System.Drawing.Size(706, 162)
        Me.dgvEntrada.TabIndex = 0
        '
        'EntradaBindingSource
        '
        Me.EntradaBindingSource.DataMember = "Entrada"
        Me.EntradaBindingSource.DataSource = Me.Farma24BDDS
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
        'EntradaTableAdapter
        '
        Me.EntradaTableAdapter.ClearBeforeFill = True
        '
        'SalidaBindingSource
        '
        Me.SalidaBindingSource.DataMember = "Salida"
        Me.SalidaBindingSource.DataSource = Me.Farma24BDDS
        '
        'SalidaTableAdapter
        '
        Me.SalidaTableAdapter.ClearBeforeFill = True
        '
        'btnAceptar
        '
        Me.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAceptar.Depth = 0
        Me.btnAceptar.DrawShadows = True
        Me.btnAceptar.HighEmphasis = True
        Me.btnAceptar.Icon = Nothing
        Me.btnAceptar.Location = New System.Drawing.Point(194, 240)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(104, 36)
        Me.btnAceptar.TabIndex = 61
        Me.btnAceptar.Text = "     Aceptar      "
        Me.btnAceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnAceptar.UseAccentColor = False
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'MostrarPLPNuevoToolStrip
        '
        Me.MostrarPLPNuevoToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MostrarPLPNuevoToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MostrarPLPNuevoToolStripButton})
        Me.MostrarPLPNuevoToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.MostrarPLPNuevoToolStrip.Name = "MostrarPLPNuevoToolStrip"
        Me.MostrarPLPNuevoToolStrip.Size = New System.Drawing.Size(735, 25)
        Me.MostrarPLPNuevoToolStrip.TabIndex = 62
        Me.MostrarPLPNuevoToolStrip.Text = "MostrarPLPNuevoToolStrip"
        '
        'MostrarPLPNuevoToolStripButton
        '
        Me.MostrarPLPNuevoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.MostrarPLPNuevoToolStripButton.Name = "MostrarPLPNuevoToolStripButton"
        Me.MostrarPLPNuevoToolStripButton.Size = New System.Drawing.Size(107, 22)
        Me.MostrarPLPNuevoToolStripButton.Text = "mostrarPLPNuevo"
        '
        'PLPBindingSource3
        '
        Me.PLPBindingSource3.DataMember = "PLP"
        Me.PLPBindingSource3.DataSource = Me.Farma24BDDS
        '
        'frmEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 488)
        Me.Controls.Add(Me.MostrarPLPNuevoToolStrip)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.gbEntradas)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lbOb)
        Me.Controls.Add(Me.lbCantidad)
        Me.Controls.Add(Me.lbPrecio)
        Me.Controls.Add(Me.lbEstado)
        Me.Controls.Add(Me.lbPLP)
        Me.Controls.Add(Me.lbUsuario)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.cbIdPlp)
        Me.Controls.Add(Me.cbIdUsuario)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(618, 409)
        Me.Name = "frmEntrada"
        Me.Text = "Entradas"
        CType(Me.PLPBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLPBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEntradas.ResumeLayout(False)
        CType(Me.dgvEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntradaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MostrarPLPNuevoToolStrip.ResumeLayout(False)
        Me.MostrarPLPNuevoToolStrip.PerformLayout()
        CType(Me.PLPBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Farma24BDDS As Farma24BDDS
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As Farma24BDDSTableAdapters.UsuarioTableAdapter
    Friend WithEvents PLPBindingSource As BindingSource
    Friend WithEvents PLPTableAdapter As Farma24BDDSTableAdapters.PLPTableAdapter
    Friend WithEvents btnCancelar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lbOb As Label
    Friend WithEvents lbCantidad As Label
    Friend WithEvents lbPrecio As Label
    Friend WithEvents lbEstado As Label
    Friend WithEvents lbPLP As Label
    Friend WithEvents lbUsuario As Label
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents cbIdPlp As ComboBox
    Friend WithEvents cbIdUsuario As ComboBox
    Friend WithEvents gbEntradas As GroupBox
    Friend WithEvents dgvEntrada As DataGridView
    Friend WithEvents EntradaBindingSource As BindingSource
    Friend WithEvents EntradaTableAdapter As Farma24BDDSTableAdapters.EntradaTableAdapter
    Friend WithEvents UsuarioBindingSource1 As BindingSource
    Friend WithEvents SalidaBindingSource As BindingSource
    Friend WithEvents SalidaTableAdapter As Farma24BDDSTableAdapters.SalidaTableAdapter
    Friend WithEvents PLPBindingSource1 As BindingSource
    Friend WithEvents btnAceptar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents PLPBindingSource2 As BindingSource
    Friend WithEvents MostrarPLPNuevoToolStrip As ToolStrip
    Friend WithEvents MostrarPLPNuevoToolStripButton As ToolStripButton
    Friend WithEvents PLPBindingSource3 As BindingSource
End Class
