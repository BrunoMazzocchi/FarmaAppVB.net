﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSalida
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
        Me.gbEntradas = New System.Windows.Forms.GroupBox()
        Me.dgvSalid = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New MaterialSkin.Controls.MaterialButton()
        Me.btnAceptar = New MaterialSkin.Controls.MaterialButton()
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
        Me.cbIdUsuario = New System.Windows.Forms.ComboBox()
        Me.IdSalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaSalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantSalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioSalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoSalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPLPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Farma24BDDS = New FarmaAppVB.Farma24BDDS()
        Me.SalidaTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.SalidaTableAdapter()
        Me.Farma24BDDS1 = New FarmaAppVB.Farma24BDDS()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.UsuarioTableAdapter()
        Me.PLPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLPTableAdapter = New FarmaAppVB.Farma24BDDSTableAdapters.PLPTableAdapter()
        Me.gbEntradas.SuspendLayout()
        CType(Me.dgvSalid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Farma24BDDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbEntradas
        '
        Me.gbEntradas.Controls.Add(Me.dgvSalid)
        Me.gbEntradas.Location = New System.Drawing.Point(12, 346)
        Me.gbEntradas.Name = "gbEntradas"
        Me.gbEntradas.Size = New System.Drawing.Size(946, 147)
        Me.gbEntradas.TabIndex = 76
        Me.gbEntradas.TabStop = False
        Me.gbEntradas.Text = "Salidas"
        '
        'dgvSalid
        '
        Me.dgvSalid.AllowUserToAddRows = False
        Me.dgvSalid.AllowUserToDeleteRows = False
        Me.dgvSalid.AutoGenerateColumns = False
        Me.dgvSalid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdSalidaDataGridViewTextBoxColumn, Me.IdUserDataGridViewTextBoxColumn, Me.FechaSalidaDataGridViewTextBoxColumn, Me.CantSalidaDataGridViewTextBoxColumn, Me.PrecioSalidaDataGridViewTextBoxColumn, Me.ObservacionDataGridViewTextBoxColumn, Me.EstadoSalidaDataGridViewTextBoxColumn, Me.IdPLPDataGridViewTextBoxColumn})
        Me.dgvSalid.DataSource = Me.SalidaBindingSource
        Me.dgvSalid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSalid.Location = New System.Drawing.Point(3, 18)
        Me.dgvSalid.Name = "dgvSalid"
        Me.dgvSalid.ReadOnly = True
        Me.dgvSalid.RowHeadersWidth = 51
        Me.dgvSalid.RowTemplate.Height = 24
        Me.dgvSalid.Size = New System.Drawing.Size(940, 126)
        Me.dgvSalid.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancelar.Depth = 0
        Me.btnCancelar.DrawShadows = True
        Me.btnCancelar.HighEmphasis = True
        Me.btnCancelar.Icon = Nothing
        Me.btnCancelar.Location = New System.Drawing.Point(576, 280)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(96, 36)
        Me.btnCancelar.TabIndex = 75
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
        Me.btnAceptar.Location = New System.Drawing.Point(274, 280)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 36)
        Me.btnAceptar.TabIndex = 74
        Me.btnAceptar.Text = "    Aceptar     "
        Me.btnAceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnAceptar.UseAccentColor = False
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lbOb
        '
        Me.lbOb.AutoSize = True
        Me.lbOb.Location = New System.Drawing.Point(573, 152)
        Me.lbOb.Name = "lbOb"
        Me.lbOb.Size = New System.Drawing.Size(88, 17)
        Me.lbOb.TabIndex = 73
        Me.lbOb.Text = "Observacion"
        '
        'lbCantidad
        '
        Me.lbCantidad.AutoSize = True
        Me.lbCantidad.Location = New System.Drawing.Point(197, 152)
        Me.lbCantidad.Name = "lbCantidad"
        Me.lbCantidad.Size = New System.Drawing.Size(64, 17)
        Me.lbCantidad.TabIndex = 72
        Me.lbCantidad.Text = "Cantidad"
        '
        'lbPrecio
        '
        Me.lbPrecio.AutoSize = True
        Me.lbPrecio.Location = New System.Drawing.Point(573, 90)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.Size = New System.Drawing.Size(48, 17)
        Me.lbPrecio.TabIndex = 71
        Me.lbPrecio.Text = "Precio"
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Location = New System.Drawing.Point(197, 90)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(52, 17)
        Me.lbEstado.TabIndex = 70
        Me.lbEstado.Text = "Estado"
        '
        'lbPLP
        '
        Me.lbPLP.AutoSize = True
        Me.lbPLP.Location = New System.Drawing.Point(573, 27)
        Me.lbPLP.Name = "lbPLP"
        Me.lbPLP.Size = New System.Drawing.Size(34, 17)
        Me.lbPLP.TabIndex = 69
        Me.lbPLP.Text = "PLP"
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.Location = New System.Drawing.Point(197, 27)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(57, 17)
        Me.lbUsuario.TabIndex = 68
        Me.lbUsuario.Text = "Usuario"
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(197, 218)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(200, 22)
        Me.dtp.TabIndex = 67
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(197, 172)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(200, 22)
        Me.txtCantidad.TabIndex = 66
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(576, 110)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(200, 22)
        Me.txtPrecio.TabIndex = 65
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(576, 172)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(200, 68)
        Me.txtObservacion.TabIndex = 64
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(197, 110)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(200, 22)
        Me.txtEstado.TabIndex = 63
        '
        'cbIdPlp
        '
        Me.cbIdPlp.DataSource = Me.PLPBindingSource
        Me.cbIdPlp.DisplayMember = "idPLP"
        Me.cbIdPlp.FormattingEnabled = True
        Me.cbIdPlp.Location = New System.Drawing.Point(576, 50)
        Me.cbIdPlp.Name = "cbIdPlp"
        Me.cbIdPlp.Size = New System.Drawing.Size(200, 24)
        Me.cbIdPlp.TabIndex = 62
        Me.cbIdPlp.ValueMember = "idPLP"
        '
        'cbIdUsuario
        '
        Me.cbIdUsuario.DataSource = Me.UsuarioBindingSource
        Me.cbIdUsuario.DisplayMember = "nombres"
        Me.cbIdUsuario.FormattingEnabled = True
        Me.cbIdUsuario.Location = New System.Drawing.Point(197, 50)
        Me.cbIdUsuario.Name = "cbIdUsuario"
        Me.cbIdUsuario.Size = New System.Drawing.Size(200, 24)
        Me.cbIdUsuario.TabIndex = 61
        Me.cbIdUsuario.ValueMember = "idUser"
        '
        'IdSalidaDataGridViewTextBoxColumn
        '
        Me.IdSalidaDataGridViewTextBoxColumn.DataPropertyName = "idSalida"
        Me.IdSalidaDataGridViewTextBoxColumn.HeaderText = "idSalida"
        Me.IdSalidaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdSalidaDataGridViewTextBoxColumn.Name = "IdSalidaDataGridViewTextBoxColumn"
        Me.IdSalidaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdSalidaDataGridViewTextBoxColumn.Width = 125
        '
        'IdUserDataGridViewTextBoxColumn
        '
        Me.IdUserDataGridViewTextBoxColumn.DataPropertyName = "idUser"
        Me.IdUserDataGridViewTextBoxColumn.HeaderText = "idUser"
        Me.IdUserDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdUserDataGridViewTextBoxColumn.Name = "IdUserDataGridViewTextBoxColumn"
        Me.IdUserDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdUserDataGridViewTextBoxColumn.Width = 125
        '
        'FechaSalidaDataGridViewTextBoxColumn
        '
        Me.FechaSalidaDataGridViewTextBoxColumn.DataPropertyName = "fechaSalida"
        Me.FechaSalidaDataGridViewTextBoxColumn.HeaderText = "fechaSalida"
        Me.FechaSalidaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaSalidaDataGridViewTextBoxColumn.Name = "FechaSalidaDataGridViewTextBoxColumn"
        Me.FechaSalidaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaSalidaDataGridViewTextBoxColumn.Width = 125
        '
        'CantSalidaDataGridViewTextBoxColumn
        '
        Me.CantSalidaDataGridViewTextBoxColumn.DataPropertyName = "cantSalida"
        Me.CantSalidaDataGridViewTextBoxColumn.HeaderText = "cantSalida"
        Me.CantSalidaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CantSalidaDataGridViewTextBoxColumn.Name = "CantSalidaDataGridViewTextBoxColumn"
        Me.CantSalidaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantSalidaDataGridViewTextBoxColumn.Width = 125
        '
        'PrecioSalidaDataGridViewTextBoxColumn
        '
        Me.PrecioSalidaDataGridViewTextBoxColumn.DataPropertyName = "precioSalida"
        Me.PrecioSalidaDataGridViewTextBoxColumn.HeaderText = "precioSalida"
        Me.PrecioSalidaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrecioSalidaDataGridViewTextBoxColumn.Name = "PrecioSalidaDataGridViewTextBoxColumn"
        Me.PrecioSalidaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioSalidaDataGridViewTextBoxColumn.Width = 125
        '
        'ObservacionDataGridViewTextBoxColumn
        '
        Me.ObservacionDataGridViewTextBoxColumn.DataPropertyName = "observacion"
        Me.ObservacionDataGridViewTextBoxColumn.HeaderText = "observacion"
        Me.ObservacionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ObservacionDataGridViewTextBoxColumn.Name = "ObservacionDataGridViewTextBoxColumn"
        Me.ObservacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObservacionDataGridViewTextBoxColumn.Width = 125
        '
        'EstadoSalidaDataGridViewTextBoxColumn
        '
        Me.EstadoSalidaDataGridViewTextBoxColumn.DataPropertyName = "estadoSalida"
        Me.EstadoSalidaDataGridViewTextBoxColumn.HeaderText = "estadoSalida"
        Me.EstadoSalidaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EstadoSalidaDataGridViewTextBoxColumn.Name = "EstadoSalidaDataGridViewTextBoxColumn"
        Me.EstadoSalidaDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoSalidaDataGridViewTextBoxColumn.Width = 125
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
        'SalidaBindingSource
        '
        Me.SalidaBindingSource.DataMember = "Salida"
        Me.SalidaBindingSource.DataSource = Me.Farma24BDDS
        '
        'Farma24BDDS
        '
        Me.Farma24BDDS.DataSetName = "Farma24BDDS"
        Me.Farma24BDDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalidaTableAdapter
        '
        Me.SalidaTableAdapter.ClearBeforeFill = True
        '
        'Farma24BDDS1
        '
        Me.Farma24BDDS1.DataSetName = "Farma24BDDS"
        Me.Farma24BDDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.Farma24BDDS1
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'PLPBindingSource
        '
        Me.PLPBindingSource.DataMember = "PLP"
        Me.PLPBindingSource.DataSource = Me.Farma24BDDS1
        '
        'PLPTableAdapter
        '
        Me.PLPTableAdapter.ClearBeforeFill = True
        '
        'frmSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 520)
        Me.Controls.Add(Me.gbEntradas)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
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
        Me.Name = "frmSalida"
        Me.Text = "Salidas"
        Me.gbEntradas.ResumeLayout(False)
        CType(Me.dgvSalid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Farma24BDDS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbEntradas As GroupBox
    Friend WithEvents dgvSalid As DataGridView
    Friend WithEvents btnCancelar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnAceptar As MaterialSkin.Controls.MaterialButton
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
    Friend WithEvents Farma24BDDS As Farma24BDDS
    Friend WithEvents SalidaBindingSource As BindingSource
    Friend WithEvents SalidaTableAdapter As Farma24BDDSTableAdapters.SalidaTableAdapter
    Friend WithEvents IdSalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdUserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaSalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantSalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioSalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoSalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdPLPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Farma24BDDS1 As Farma24BDDS
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As Farma24BDDSTableAdapters.UsuarioTableAdapter
    Friend WithEvents PLPBindingSource As BindingSource
    Friend WithEvents PLPTableAdapter As Farma24BDDSTableAdapters.PLPTableAdapter
End Class