<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoProducto
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
        Me.btn_codigo = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbx_codigo = New System.Windows.Forms.TextBox()
        Me.cbx_categoria = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txb_descripcion = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.txb_nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.img_codigo = New System.Windows.Forms.PictureBox()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Actualizar = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.txb_id = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txb_preciocompra = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txb_precioventa = New System.Windows.Forms.TextBox()
        Me.cbx_Proveedores = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.img_codigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_codigo
        '
        Me.btn_codigo.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_codigo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_codigo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_codigo.Location = New System.Drawing.Point(443, 92)
        Me.btn_codigo.Name = "btn_codigo"
        Me.btn_codigo.Size = New System.Drawing.Size(108, 47)
        Me.btn_codigo.TabIndex = 34
        Me.btn_codigo.Text = "Generar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Codigo"
        Me.btn_codigo.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(317, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 19)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Codigo : "
        '
        'tbx_codigo
        '
        Me.tbx_codigo.Enabled = False
        Me.tbx_codigo.Location = New System.Drawing.Point(317, 105)
        Me.tbx_codigo.Name = "tbx_codigo"
        Me.tbx_codigo.Size = New System.Drawing.Size(115, 23)
        Me.tbx_codigo.TabIndex = 32
        '
        'cbx_categoria
        '
        Me.cbx_categoria.FormattingEnabled = True
        Me.cbx_categoria.Location = New System.Drawing.Point(29, 373)
        Me.cbx_categoria.Name = "cbx_categoria"
        Me.cbx_categoria.Size = New System.Drawing.Size(226, 23)
        Me.cbx_categoria.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(29, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 19)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Categoria : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(32, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 19)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Descripción : "
        '
        'txb_descripcion
        '
        Me.txb_descripcion.Location = New System.Drawing.Point(32, 176)
        Me.txb_descripcion.Multiline = True
        Me.txb_descripcion.Name = "txb_descripcion"
        Me.txb_descripcion.Size = New System.Drawing.Size(223, 92)
        Me.txb_descripcion.TabIndex = 28
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Nombre.Location = New System.Drawing.Point(32, 78)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(77, 19)
        Me.Nombre.TabIndex = 27
        Me.Nombre.Text = "Nombre : "
        '
        'txb_nombre
        '
        Me.txb_nombre.Location = New System.Drawing.Point(32, 105)
        Me.txb_nombre.Name = "txb_nombre"
        Me.txb_nombre.Size = New System.Drawing.Size(223, 23)
        Me.txb_nombre.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.SeaShell
        Me.Label1.Location = New System.Drawing.Point(32, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 32)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "DETALLES DE PRODUCTO"
        '
        'img_codigo
        '
        Me.img_codigo.Location = New System.Drawing.Point(368, 213)
        Me.img_codigo.Name = "img_codigo"
        Me.img_codigo.Size = New System.Drawing.Size(182, 119)
        Me.img_codigo.TabIndex = 36
        Me.img_codigo.TabStop = False
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackColor = System.Drawing.Color.Crimson
        Me.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Eliminar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_Eliminar.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_Eliminar.Location = New System.Drawing.Point(468, 14)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(83, 37)
        Me.btn_Eliminar.TabIndex = 45
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'btn_Actualizar
        '
        Me.btn_Actualizar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Actualizar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_Actualizar.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_Actualizar.Location = New System.Drawing.Point(478, 405)
        Me.btn_Actualizar.Name = "btn_Actualizar"
        Me.btn_Actualizar.Size = New System.Drawing.Size(90, 37)
        Me.btn_Actualizar.TabIndex = 44
        Me.btn_Actualizar.Text = "Actualizar"
        Me.btn_Actualizar.UseVisualStyleBackColor = False
        '
        'btn_reset
        '
        Me.btn_reset.Location = New System.Drawing.Point(453, 145)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(78, 40)
        Me.btn_reset.TabIndex = 46
        Me.btn_reset.Text = "Limpiar Codigo"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.Silver
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_cancelar.ForeColor = System.Drawing.SystemColors.InfoText
        Me.btn_cancelar.Location = New System.Drawing.Point(368, 405)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(81, 37)
        Me.btn_cancelar.TabIndex = 47
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'txb_id
        '
        Me.txb_id.Location = New System.Drawing.Point(349, 23)
        Me.txb_id.Name = "txb_id"
        Me.txb_id.Size = New System.Drawing.Size(100, 23)
        Me.txb_id.TabIndex = 48
        Me.txb_id.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(165, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 19)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Precio Compra"
        '
        'txb_preciocompra
        '
        Me.txb_preciocompra.Location = New System.Drawing.Point(165, 309)
        Me.txb_preciocompra.Name = "txb_preciocompra"
        Me.txb_preciocompra.Size = New System.Drawing.Size(90, 23)
        Me.txb_preciocompra.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(32, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 19)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Precio Venta"
        '
        'txb_precioventa
        '
        Me.txb_precioventa.Location = New System.Drawing.Point(32, 309)
        Me.txb_precioventa.Name = "txb_precioventa"
        Me.txb_precioventa.Size = New System.Drawing.Size(90, 23)
        Me.txb_precioventa.TabIndex = 49
        '
        'cbx_Proveedores
        '
        Me.cbx_Proveedores.FormattingEnabled = True
        Me.cbx_Proveedores.Location = New System.Drawing.Point(32, 438)
        Me.cbx_Proveedores.Name = "cbx_Proveedores"
        Me.cbx_Proveedores.Size = New System.Drawing.Size(226, 23)
        Me.cbx_Proveedores.TabIndex = 54
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(32, 411)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 19)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Proveedores : "
        '
        'InfoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(580, 491)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbx_Proveedores)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txb_preciocompra)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txb_precioventa)
        Me.Controls.Add(Me.txb_id)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Actualizar)
        Me.Controls.Add(Me.img_codigo)
        Me.Controls.Add(Me.btn_codigo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbx_codigo)
        Me.Controls.Add(Me.cbx_categoria)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txb_descripcion)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.txb_nombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InfoProducto"
        Me.Text = "InfoProducto"
        CType(Me.img_codigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_codigo As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents tbx_codigo As TextBox
    Friend WithEvents cbx_categoria As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txb_descripcion As TextBox
    Friend WithEvents Nombre As Label
    Friend WithEvents txb_nombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents img_codigo As PictureBox
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents btn_Actualizar As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents txb_id As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txb_preciocompra As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txb_precioventa As TextBox
    Friend WithEvents cbx_Proveedores As ComboBox
    Friend WithEvents Label8 As Label
End Class
