<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductoBuscadoID
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
        Me.gbEncontrados = New System.Windows.Forms.GroupBox()
        Me.dgvProdID = New System.Windows.Forms.DataGridView()
        Me.btnImprimir = New MaterialSkin.Controls.MaterialButton()
        Me.gbEncontrados.SuspendLayout()
        CType(Me.dgvProdID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbEncontrados
        '
        Me.gbEncontrados.Controls.Add(Me.dgvProdID)
        Me.gbEncontrados.Location = New System.Drawing.Point(11, 78)
        Me.gbEncontrados.Margin = New System.Windows.Forms.Padding(2)
        Me.gbEncontrados.Name = "gbEncontrados"
        Me.gbEncontrados.Padding = New System.Windows.Forms.Padding(2)
        Me.gbEncontrados.Size = New System.Drawing.Size(734, 324)
        Me.gbEncontrados.TabIndex = 1
        Me.gbEncontrados.TabStop = False
        Me.gbEncontrados.Text = "Encontrado"
        '
        'dgvProdID
        '
        Me.dgvProdID.AllowUserToAddRows = False
        Me.dgvProdID.AllowUserToDeleteRows = False
        Me.dgvProdID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProdID.Location = New System.Drawing.Point(2, 15)
        Me.dgvProdID.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvProdID.Name = "dgvProdID"
        Me.dgvProdID.ReadOnly = True
        Me.dgvProdID.RowHeadersWidth = 51
        Me.dgvProdID.RowTemplate.Height = 24
        Me.dgvProdID.Size = New System.Drawing.Size(730, 307)
        Me.dgvProdID.TabIndex = 0
        '
        'btnImprimir
        '
        Me.btnImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnImprimir.Depth = 0
        Me.btnImprimir.DrawShadows = True
        Me.btnImprimir.HighEmphasis = True
        Me.btnImprimir.Icon = Nothing
        Me.btnImprimir.Location = New System.Drawing.Point(584, 34)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnImprimir.MaximumSize = New System.Drawing.Size(158, 36)
        Me.btnImprimir.MinimumSize = New System.Drawing.Size(158, 36)
        Me.btnImprimir.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(158, 36)
        Me.btnImprimir.TabIndex = 2
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnImprimir.UseAccentColor = False
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'frmProductoBuscadoID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 412)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.gbEncontrados)
        Me.MaximumSize = New System.Drawing.Size(771, 451)
        Me.MinimumSize = New System.Drawing.Size(771, 451)
        Me.Name = "frmProductoBuscadoID"
        Me.Text = "Producto ID"
        Me.gbEncontrados.ResumeLayout(False)
        CType(Me.dgvProdID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbEncontrados As GroupBox
    Friend WithEvents dgvProdID As DataGridView
    Friend WithEvents btnImprimir As MaterialSkin.Controls.MaterialButton
End Class
