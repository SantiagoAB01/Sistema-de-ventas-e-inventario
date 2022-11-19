<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Productos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txb_nombre = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txb_descripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbx_categoria = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbx_codigo = New System.Windows.Forms.TextBox()
        Me.btn_codigo = New System.Windows.Forms.Button()
        Me.dgv_prouctos = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_vercodigo = New System.Windows.Forms.Button()
        Me.txb_buscar = New System.Windows.Forms.TextBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txb_precioventa = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txb_preciocompra = New System.Windows.Forms.TextBox()
        Me.cbx_Proveedores = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgv_prouctos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        'txb_nombre
        '
        Me.txb_nombre.Location = New System.Drawing.Point(31, 164)
        Me.txb_nombre.Name = "txb_nombre"
        Me.txb_nombre.Size = New System.Drawing.Size(223, 23)
        Me.txb_nombre.TabIndex = 10
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
        'txb_descripcion
        '
        Me.txb_descripcion.Location = New System.Drawing.Point(31, 235)
        Me.txb_descripcion.Multiline = True
        Me.txb_descripcion.Name = "txb_descripcion"
        Me.txb_descripcion.Size = New System.Drawing.Size(223, 92)
        Me.txb_descripcion.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(31, 388)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 19)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Categoria : "
        '
        'cbx_categoria
        '
        Me.cbx_categoria.FormattingEnabled = True
        Me.cbx_categoria.Location = New System.Drawing.Point(31, 415)
        Me.cbx_categoria.Name = "cbx_categoria"
        Me.cbx_categoria.Size = New System.Drawing.Size(226, 23)
        Me.cbx_categoria.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(31, 507)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 19)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Codigo : "
        '
        'tbx_codigo
        '
        Me.tbx_codigo.Enabled = False
        Me.tbx_codigo.Location = New System.Drawing.Point(31, 534)
        Me.tbx_codigo.Name = "tbx_codigo"
        Me.tbx_codigo.Size = New System.Drawing.Size(115, 23)
        Me.tbx_codigo.TabIndex = 18
        '
        'btn_codigo
        '
        Me.btn_codigo.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_codigo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_codigo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_codigo.Location = New System.Drawing.Point(149, 521)
        Me.btn_codigo.Name = "btn_codigo"
        Me.btn_codigo.Size = New System.Drawing.Size(108, 47)
        Me.btn_codigo.TabIndex = 20
        Me.btn_codigo.Text = "Generar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Codigo"
        Me.btn_codigo.UseVisualStyleBackColor = False
        '
        'dgv_prouctos
        '
        Me.dgv_prouctos.AllowUserToAddRows = False
        Me.dgv_prouctos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_prouctos.Location = New System.Drawing.Point(338, 137)
        Me.dgv_prouctos.MultiSelect = False
        Me.dgv_prouctos.Name = "dgv_prouctos"
        Me.dgv_prouctos.ReadOnly = True
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
        Me.Button2.BackColor = System.Drawing.Color.SeaGreen
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(156, 617)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 47)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "AGREGAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_vercodigo
        '
        Me.btn_vercodigo.Location = New System.Drawing.Point(49, 580)
        Me.btn_vercodigo.Name = "btn_vercodigo"
        Me.btn_vercodigo.Size = New System.Drawing.Size(75, 23)
        Me.btn_vercodigo.TabIndex = 24
        Me.btn_vercodigo.Text = "ver codigo"
        Me.btn_vercodigo.UseVisualStyleBackColor = True
        '
        'txb_buscar
        '
        Me.txb_buscar.Location = New System.Drawing.Point(337, 108)
        Me.txb_buscar.Name = "txb_buscar"
        Me.txb_buscar.Size = New System.Drawing.Size(182, 23)
        Me.txb_buscar.TabIndex = 25
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.SteelBlue
        Me.IconButton1.ForeColor = System.Drawing.Color.SteelBlue
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeftLong
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(13, 3)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(50, 39)
        Me.IconButton1.TabIndex = 26
        Me.IconButton1.UseVisualStyleBackColor = False
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
        Me.Panel2.TabIndex = 30
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(31, 330)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 19)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Precio Venta"
        '
        'txb_precioventa
        '
        Me.txb_precioventa.Location = New System.Drawing.Point(31, 357)
        Me.txb_precioventa.Name = "txb_precioventa"
        Me.txb_precioventa.Size = New System.Drawing.Size(90, 23)
        Me.txb_precioventa.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(164, 330)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 19)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Precio Compra"
        '
        'txb_preciocompra
        '
        Me.txb_preciocompra.Location = New System.Drawing.Point(164, 357)
        Me.txb_preciocompra.Name = "txb_preciocompra"
        Me.txb_preciocompra.Size = New System.Drawing.Size(90, 23)
        Me.txb_preciocompra.TabIndex = 33
        '
        'cbx_Proveedores
        '
        Me.cbx_Proveedores.FormattingEnabled = True
        Me.cbx_Proveedores.Location = New System.Drawing.Point(31, 475)
        Me.cbx_Proveedores.Name = "cbx_Proveedores"
        Me.cbx_Proveedores.Size = New System.Drawing.Size(226, 23)
        Me.cbx_Proveedores.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(31, 448)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 19)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Proveedores : "
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.Controls.Add(Me.cbx_Proveedores)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txb_preciocompra)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txb_precioventa)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txb_buscar)
        Me.Controls.Add(Me.btn_vercodigo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv_prouctos)
        Me.Controls.Add(Me.btn_codigo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbx_codigo)
        Me.Controls.Add(Me.cbx_categoria)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txb_descripcion)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txb_nombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informacion del programa"
        CType(Me.dgv_prouctos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txb_nombre As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Nombre As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txb_descripcion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbx_categoria As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbx_codigo As TextBox
    Friend WithEvents btn_codigo As Button
    Friend WithEvents dgv_prouctos As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_vercodigo As Button
    Friend WithEvents txb_buscar As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txb_precioventa As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txb_preciocompra As TextBox
    Friend WithEvents cbx_Proveedores As ComboBox
    Friend WithEvents Label8 As Label
End Class
