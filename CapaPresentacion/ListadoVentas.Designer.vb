<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoVentas
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgv_ventas = New System.Windows.Forms.DataGridView()
        Me.btn_Export = New System.Windows.Forms.Button()
        Me.txb_buscar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.IconButton1)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1064, 45)
        Me.Panel2.TabIndex = 7
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.SteelBlue
        Me.IconButton1.ForeColor = System.Drawing.Color.SteelBlue
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeftLong
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(12, 3)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(50, 39)
        Me.IconButton1.TabIndex = 4
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.icone_cercle_rempli_gris
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(1017, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 36)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.SystemColors.Window
        Me.Label10.Location = New System.Drawing.Point(102, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 25)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Lista de Ventas"
        '
        'dgv_ventas
        '
        Me.dgv_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ventas.Location = New System.Drawing.Point(91, 142)
        Me.dgv_ventas.Name = "dgv_ventas"
        Me.dgv_ventas.RowTemplate.Height = 25
        Me.dgv_ventas.Size = New System.Drawing.Size(841, 463)
        Me.dgv_ventas.TabIndex = 9
        '
        'btn_Export
        '
        Me.btn_Export.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_Export.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.excel
        Me.btn_Export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Export.FlatAppearance.BorderSize = 0
        Me.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Export.Location = New System.Drawing.Point(10, 192)
        Me.btn_Export.Name = "btn_Export"
        Me.btn_Export.Size = New System.Drawing.Size(50, 46)
        Me.btn_Export.TabIndex = 31
        Me.btn_Export.UseVisualStyleBackColor = False
        '
        'txb_buscar
        '
        Me.txb_buscar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_buscar.Location = New System.Drawing.Point(91, 111)
        Me.txb_buscar.Name = "txb_buscar"
        Me.txb_buscar.Size = New System.Drawing.Size(254, 25)
        Me.txb_buscar.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(91, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 25)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Buscar"
        '
        'ListadoVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.Controls.Add(Me.btn_Export)
        Me.Controls.Add(Me.txb_buscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgv_ventas)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "ListadoVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        CType(Me.dgv_ventas,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents dgv_ventas As DataGridView
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Export As Button
    Friend WithEvents txb_buscar As TextBox
    Friend WithEvents Label3 As Label
End Class
