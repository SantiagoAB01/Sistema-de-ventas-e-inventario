<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgv_reportes = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cbx_year = New System.Windows.Forms.ComboBox()
        Me.cbx_cliente = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txb_buscar = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.lbl_CantidadStock = New System.Windows.Forms.Label()
        Me.cbx_mes = New System.Windows.Forms.ComboBox()
        Me.btn_Export = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_reportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.IconButton1)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(1, 0)
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
        Me.IconButton1.TabIndex = 3
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
        Me.Label10.Size = New System.Drawing.Size(92, 25)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Reportes"
        '
        'dgv_reportes
        '
        Me.dgv_reportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_reportes.GridColor = System.Drawing.Color.DarkGray
        Me.dgv_reportes.Location = New System.Drawing.Point(1, 239)
        Me.dgv_reportes.MultiSelect = False
        Me.dgv_reportes.Name = "dgv_reportes"
        Me.dgv_reportes.RowTemplate.Height = 25
        Me.dgv_reportes.Size = New System.Drawing.Size(1064, 416)
        Me.dgv_reportes.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.btn_Export)
        Me.Panel1.Controls.Add(Me.cbx_mes)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.cbx_year)
        Me.Panel1.Controls.Add(Me.cbx_cliente)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txb_buscar)
        Me.Panel1.Location = New System.Drawing.Point(52, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(958, 125)
        Me.Panel1.TabIndex = 9
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(289, 25)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(106, 19)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Habilitar Filtros"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cbx_year
        '
        Me.cbx_year.AutoCompleteCustomSource.AddRange(New String() {"Esta Semana", "Este Mes", "Este Año"})
        Me.cbx_year.Enabled = False
        Me.cbx_year.FormattingEnabled = True
        Me.cbx_year.Items.AddRange(New Object() {"-año-"})
        Me.cbx_year.Location = New System.Drawing.Point(458, 57)
        Me.cbx_year.Name = "cbx_year"
        Me.cbx_year.Size = New System.Drawing.Size(93, 23)
        Me.cbx_year.TabIndex = 10
        '
        'cbx_cliente
        '
        Me.cbx_cliente.Enabled = False
        Me.cbx_cliente.FormattingEnabled = True
        Me.cbx_cliente.Items.AddRange(New Object() {"-Cliente-"})
        Me.cbx_cliente.Location = New System.Drawing.Point(289, 57)
        Me.cbx_cliente.Name = "cbx_cliente"
        Me.cbx_cliente.Size = New System.Drawing.Size(163, 23)
        Me.cbx_cliente.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(208, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar"
        '
        'txb_buscar
        '
        Me.txb_buscar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_buscar.Location = New System.Drawing.Point(32, 25)
        Me.txb_buscar.Name = "txb_buscar"
        Me.txb_buscar.Size = New System.Drawing.Size(170, 29)
        Me.txb_buscar.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel3.Controls.Add(Me.lbl_CantidadStock)
        Me.Panel3.Controls.Add(Me.lbl_Total)
        Me.Panel3.Location = New System.Drawing.Point(747, 8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(197, 108)
        Me.Panel3.TabIndex = 12
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Total.ForeColor = System.Drawing.Color.ForestGreen
        Me.lbl_Total.Location = New System.Drawing.Point(12, 13)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(60, 21)
        Me.lbl_Total.TabIndex = 0
        Me.lbl_Total.Text = "Label2"
        '
        'lbl_CantidadStock
        '
        Me.lbl_CantidadStock.AutoSize = True
        Me.lbl_CantidadStock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_CantidadStock.ForeColor = System.Drawing.Color.ForestGreen
        Me.lbl_CantidadStock.Location = New System.Drawing.Point(12, 63)
        Me.lbl_CantidadStock.Name = "lbl_CantidadStock"
        Me.lbl_CantidadStock.Size = New System.Drawing.Size(60, 21)
        Me.lbl_CantidadStock.TabIndex = 1
        Me.lbl_CantidadStock.Text = "Label2"
        '
        'cbx_mes
        '
        Me.cbx_mes.AutoCompleteCustomSource.AddRange(New String() {"Esta Semana", "Este Mes", "Este Año"})
        Me.cbx_mes.Enabled = False
        Me.cbx_mes.FormattingEnabled = True
        Me.cbx_mes.Items.AddRange(New Object() {"-mes-"})
        Me.cbx_mes.Location = New System.Drawing.Point(557, 57)
        Me.cbx_mes.Name = "cbx_mes"
        Me.cbx_mes.Size = New System.Drawing.Size(92, 23)
        Me.cbx_mes.TabIndex = 13
        '
        'btn_Export
        '
        Me.btn_Export.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_Export.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.excel
        Me.btn_Export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Export.FlatAppearance.BorderSize = 0
        Me.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Export.Location = New System.Drawing.Point(32, 70)
        Me.btn_Export.Name = "btn_Export"
        Me.btn_Export.Size = New System.Drawing.Size(50, 46)
        Me.btn_Export.TabIndex = 32
        Me.btn_Export.UseVisualStyleBackColor = False
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv_reportes)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Reportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgv_reportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Button3 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents dgv_reportes As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents cbx_year As ComboBox
    Friend WithEvents cbx_cliente As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txb_buscar As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl_CantidadStock As Label
    Friend WithEvents lbl_Total As Label
    Friend WithEvents cbx_mes As ComboBox
    Friend WithEvents btn_Export As Button
End Class
