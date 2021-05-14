<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducto
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
        Me.gbBarra = New System.Windows.Forms.GroupBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.txtBuscarID = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnBuscarID = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.gbDgv = New System.Windows.Forms.GroupBox()
        Me.btnCerrarSesion = New System.Windows.Forms.DataGridView()
        Me.gbControles = New System.Windows.Forms.GroupBox()
        Me.gbBtnCrud = New System.Windows.Forms.GroupBox()
        Me.gbCrud = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Farma24BDDS = New FarmaAppVB.Farma24BDDS()
        Me.Farma24BDDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnReportar = New System.Windows.Forms.Button()
        Me.btnInfoVendedores = New System.Windows.Forms.Button()
        Me.btnHistorial = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbBarra.SuspendLayout()
        Me.gbDgv.SuspendLayout()
        CType(Me.btnCerrarSesion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbControles.SuspendLayout()
        Me.gbBtnCrud.SuspendLayout()
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Farma24BDDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbBarra
        '
        Me.gbBarra.Controls.Add(Me.btnImprimir)
        Me.gbBarra.Controls.Add(Me.btnBuscarID)
        Me.gbBarra.Controls.Add(Me.btnBuscar)
        Me.gbBarra.Controls.Add(Me.txtBuscarID)
        Me.gbBarra.Controls.Add(Me.txtBuscar)
        Me.gbBarra.Location = New System.Drawing.Point(461, 33)
        Me.gbBarra.Name = "gbBarra"
        Me.gbBarra.Size = New System.Drawing.Size(675, 65)
        Me.gbBarra.TabIndex = 1
        Me.gbBarra.TabStop = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(28, 10)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(230, 22)
        Me.txtBuscar.TabIndex = 0
        '
        'txtBuscarID
        '
        Me.txtBuscarID.Location = New System.Drawing.Point(28, 38)
        Me.txtBuscarID.Name = "txtBuscarID"
        Me.txtBuscarID.Size = New System.Drawing.Size(231, 22)
        Me.txtBuscarID.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(266, 7)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(108, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnBuscarID
        '
        Me.btnBuscarID.Location = New System.Drawing.Point(266, 37)
        Me.btnBuscarID.Name = "btnBuscarID"
        Me.btnBuscarID.Size = New System.Drawing.Size(108, 23)
        Me.btnBuscarID.TabIndex = 3
        Me.btnBuscarID.Text = "Buscar ID"
        Me.btnBuscarID.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(594, 36)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'gbDgv
        '
        Me.gbDgv.Controls.Add(Me.btnCerrarSesion)
        Me.gbDgv.Location = New System.Drawing.Point(469, 224)
        Me.gbDgv.Name = "gbDgv"
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
        Me.btnCerrarSesion.DataSource = Me.Farma24BDDSBindingSource
        Me.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCerrarSesion.Location = New System.Drawing.Point(3, 18)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.ReadOnly = True
        Me.btnCerrarSesion.RowHeadersWidth = 51
        Me.btnCerrarSesion.RowTemplate.Height = 24
        Me.btnCerrarSesion.Size = New System.Drawing.Size(691, 357)
        Me.btnCerrarSesion.TabIndex = 0
        '
        'gbControles
        '
        Me.gbControles.BackColor = System.Drawing.Color.DodgerBlue
        Me.gbControles.Controls.Add(Me.Button1)
        Me.gbControles.Controls.Add(Me.btnReportar)
        Me.gbControles.Controls.Add(Me.btnInfoVendedores)
        Me.gbControles.Controls.Add(Me.btnHistorial)
        Me.gbControles.Controls.Add(Me.gbBtnCrud)
        Me.gbControles.Location = New System.Drawing.Point(-7, -10)
        Me.gbControles.Name = "gbControles"
        Me.gbControles.Size = New System.Drawing.Size(271, 622)
        Me.gbControles.TabIndex = 0
        Me.gbControles.TabStop = False
        '
        'gbBtnCrud
        '
        Me.gbBtnCrud.BackColor = System.Drawing.Color.DodgerBlue
        Me.gbBtnCrud.Controls.Add(Me.gbCrud)
        Me.gbBtnCrud.Location = New System.Drawing.Point(271, 0)
        Me.gbBtnCrud.Name = "gbBtnCrud"
        Me.gbBtnCrud.Size = New System.Drawing.Size(223, 643)
        Me.gbBtnCrud.TabIndex = 1
        Me.gbBtnCrud.TabStop = False
        '
        'gbCrud
        '
        Me.gbCrud.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbCrud.Location = New System.Drawing.Point(216, 102)
        Me.gbCrud.Name = "gbCrud"
        Me.gbCrud.Size = New System.Drawing.Size(160, 440)
        Me.gbCrud.TabIndex = 1
        Me.gbCrud.TabStop = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(305, 321)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(305, 365)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 8
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(305, 411)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Farma24BDDS
        '
        Me.Farma24BDDS.DataSetName = "Farma24BDDS"
        Me.Farma24BDDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Farma24BDDSBindingSource
        '
        Me.Farma24BDDSBindingSource.DataSource = Me.Farma24BDDS
        Me.Farma24BDDSBindingSource.Position = 0
        '
        'btnReportar
        '
        Me.btnReportar.Location = New System.Drawing.Point(44, 345)
        Me.btnReportar.Name = "btnReportar"
        Me.btnReportar.Size = New System.Drawing.Size(174, 23)
        Me.btnReportar.TabIndex = 12
        Me.btnReportar.Text = "Reportar Problema"
        Me.btnReportar.UseVisualStyleBackColor = True
        '
        'btnInfoVendedores
        '
        Me.btnInfoVendedores.Location = New System.Drawing.Point(44, 305)
        Me.btnInfoVendedores.Name = "btnInfoVendedores"
        Me.btnInfoVendedores.Size = New System.Drawing.Size(174, 23)
        Me.btnInfoVendedores.TabIndex = 11
        Me.btnInfoVendedores.Text = "Info. Vendedores"
        Me.btnInfoVendedores.UseVisualStyleBackColor = True
        '
        'btnHistorial
        '
        Me.btnHistorial.Location = New System.Drawing.Point(44, 263)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Size = New System.Drawing.Size(174, 23)
        Me.btnHistorial.TabIndex = 10
        Me.btnHistorial.Text = "Historial"
        Me.btnHistorial.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(44, 385)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Cerrar Sesion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1171, 606)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.gbDgv)
        Me.Controls.Add(Me.gbBarra)
        Me.Controls.Add(Me.gbControles)
        Me.Name = "frmProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProducto"
        Me.gbBarra.ResumeLayout(False)
        Me.gbBarra.PerformLayout()
        Me.gbDgv.ResumeLayout(False)
        CType(Me.btnCerrarSesion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbControles.ResumeLayout(False)
        Me.gbBtnCrud.ResumeLayout(False)
        CType(Me.Farma24BDDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Farma24BDDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button1 As Button
    Friend WithEvents btnReportar As Button
    Friend WithEvents btnInfoVendedores As Button
    Friend WithEvents btnHistorial As Button
    Private WithEvents btnCerrarSesion As DataGridView
End Class
