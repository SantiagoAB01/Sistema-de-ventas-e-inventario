<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbx_categoria = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbx_codigo = New System.Windows.Forms.TextBox()
        Me.btn_codigo = New System.Windows.Forms.Button()
        Me.dgv_prouctos = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_prouctos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.IconButton1)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(0, 1)
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
        Me.Label10.Size = New System.Drawing.Size(104, 25)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Productos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(31, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "DETALLES DE PRODUCTO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(338, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "LISTA DE PRODUCTOS"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(31, 164)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(223, 23)
        Me.TextBox1.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Location = New System.Drawing.Point(289, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 586)
        Me.Panel1.TabIndex = 11
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Nombre.Location = New System.Drawing.Point(31, 137)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(70, 19)
        Me.Nombre.TabIndex = 12
        Me.Nombre.Text = "Nombre : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(31, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Descripción : "
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(31, 235)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(223, 147)
        Me.TextBox2.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(28, 405)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 19)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Categoria : "
        '
        'cbx_categoria
        '
        Me.cbx_categoria.FormattingEnabled = True
        Me.cbx_categoria.Location = New System.Drawing.Point(28, 432)
        Me.cbx_categoria.Name = "cbx_categoria"
        Me.cbx_categoria.Size = New System.Drawing.Size(226, 23)
        Me.cbx_categoria.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(28, 477)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 19)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Codigo : "
        '
        'tbx_codigo
        '
        Me.tbx_codigo.Enabled = False
        Me.tbx_codigo.Location = New System.Drawing.Point(28, 504)
        Me.tbx_codigo.Name = "tbx_codigo"
        Me.tbx_codigo.Size = New System.Drawing.Size(115, 23)
        Me.tbx_codigo.TabIndex = 18
        '
        'btn_codigo
        '
        Me.btn_codigo.Location = New System.Drawing.Point(146, 491)
        Me.btn_codigo.Name = "btn_codigo"
        Me.btn_codigo.Size = New System.Drawing.Size(108, 47)
        Me.btn_codigo.TabIndex = 20
        Me.btn_codigo.Text = "Generar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Codigo"
        Me.btn_codigo.UseVisualStyleBackColor = True
        '
        'dgv_prouctos
        '
        Me.dgv_prouctos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_prouctos.Location = New System.Drawing.Point(338, 137)
        Me.dgv_prouctos.Name = "dgv_prouctos"
        Me.dgv_prouctos.RowTemplate.Height = 25
        Me.dgv_prouctos.Size = New System.Drawing.Size(692, 527)
        Me.dgv_prouctos.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 617)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 47)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "LIMPIAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(156, 617)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 47)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "AGREGAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv_prouctos)
        Me.Controls.Add(Me.btn_codigo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbx_codigo)
        Me.Controls.Add(Me.cbx_categoria)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informacion del programa"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgv_prouctos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Button3 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Nombre As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbx_categoria As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbx_codigo As TextBox
    Friend WithEvents btn_codigo As Button
    Friend WithEvents dgv_prouctos As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
