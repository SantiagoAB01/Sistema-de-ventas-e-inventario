﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inventario
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txb_buscar = New System.Windows.Forms.TextBox()
        Me.dgv_inventario = New System.Windows.Forms.DataGridView()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_Export = New System.Windows.Forms.Button()
        Me.Panel_Registro = New System.Windows.Forms.Panel()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.num_Cantidad = New System.Windows.Forms.NumericUpDown()
        Me.txb_PrecioCompra = New System.Windows.Forms.TextBox()
        Me.txb_PrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txb_id_Producto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txb_buscarProducto = New System.Windows.Forms.TextBox()
        Me.dte_Vencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dte_FechaProduccion = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbx_Proveedores = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_productos = New System.Windows.Forms.DataGridView()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dgv_inventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Registro.SuspendLayout()
        CType(Me.num_Cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(32, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Buscar"
        '
        'txb_buscar
        '
        Me.txb_buscar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_buscar.Location = New System.Drawing.Point(32, 111)
        Me.txb_buscar.Name = "txb_buscar"
        Me.txb_buscar.Size = New System.Drawing.Size(254, 25)
        Me.txb_buscar.TabIndex = 9
        '
        'dgv_inventario
        '
        Me.dgv_inventario.AllowUserToAddRows = False
        Me.dgv_inventario.AllowUserToOrderColumns = True
        Me.dgv_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_inventario.Location = New System.Drawing.Point(32, 156)
        Me.dgv_inventario.Name = "dgv_inventario"
        Me.dgv_inventario.RowTemplate.Height = 25
        Me.dgv_inventario.Size = New System.Drawing.Size(998, 420)
        Me.dgv_inventario.TabIndex = 10
        '
        'btn_new
        '
        Me.btn_new.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_new.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_new.Location = New System.Drawing.Point(311, 96)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(125, 40)
        Me.btn_new.TabIndex = 11
        Me.btn_new.Text = "Nuevo"
        Me.btn_new.UseVisualStyleBackColor = False
        '
        'btn_Export
        '
        Me.btn_Export.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_Export.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.excel
        Me.btn_Export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Export.FlatAppearance.BorderSize = 0
        Me.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Export.Location = New System.Drawing.Point(482, 90)
        Me.btn_Export.Name = "btn_Export"
        Me.btn_Export.Size = New System.Drawing.Size(50, 46)
        Me.btn_Export.TabIndex = 28
        Me.btn_Export.UseVisualStyleBackColor = False
        '
        'Panel_Registro
        '
        Me.Panel_Registro.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel_Registro.Controls.Add(Me.lbl_titulo)
        Me.Panel_Registro.Controls.Add(Me.num_Cantidad)
        Me.Panel_Registro.Controls.Add(Me.txb_PrecioCompra)
        Me.Panel_Registro.Controls.Add(Me.txb_PrecioVenta)
        Me.Panel_Registro.Controls.Add(Me.Label11)
        Me.Panel_Registro.Controls.Add(Me.txb_id_Producto)
        Me.Panel_Registro.Controls.Add(Me.Label9)
        Me.Panel_Registro.Controls.Add(Me.Label8)
        Me.Panel_Registro.Controls.Add(Me.txb_buscarProducto)
        Me.Panel_Registro.Controls.Add(Me.dte_Vencimiento)
        Me.Panel_Registro.Controls.Add(Me.Label7)
        Me.Panel_Registro.Controls.Add(Me.dte_FechaProduccion)
        Me.Panel_Registro.Controls.Add(Me.Label6)
        Me.Panel_Registro.Controls.Add(Me.Label5)
        Me.Panel_Registro.Controls.Add(Me.Label4)
        Me.Panel_Registro.Controls.Add(Me.cbx_Proveedores)
        Me.Panel_Registro.Controls.Add(Me.Label1)
        Me.Panel_Registro.Controls.Add(Me.dgv_productos)
        Me.Panel_Registro.Controls.Add(Me.btn_Cancelar)
        Me.Panel_Registro.Controls.Add(Me.btn_Agregar)
        Me.Panel_Registro.Controls.Add(Me.Label2)
        Me.Panel_Registro.Location = New System.Drawing.Point(562, 63)
        Me.Panel_Registro.Name = "Panel_Registro"
        Me.Panel_Registro.Size = New System.Drawing.Size(490, 606)
        Me.Panel_Registro.TabIndex = 29
        Me.Panel_Registro.Visible = False
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_titulo.Location = New System.Drawing.Point(23, 28)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(94, 30)
        Me.lbl_titulo.TabIndex = 65
        Me.lbl_titulo.Text = "Label12"
        '
        'num_Cantidad
        '
        Me.num_Cantidad.Location = New System.Drawing.Point(342, 111)
        Me.num_Cantidad.Name = "num_Cantidad"
        Me.num_Cantidad.Size = New System.Drawing.Size(100, 23)
        Me.num_Cantidad.TabIndex = 64
        '
        'txb_PrecioCompra
        '
        Me.txb_PrecioCompra.Location = New System.Drawing.Point(342, 240)
        Me.txb_PrecioCompra.Name = "txb_PrecioCompra"
        Me.txb_PrecioCompra.Size = New System.Drawing.Size(100, 23)
        Me.txb_PrecioCompra.TabIndex = 63
        '
        'txb_PrecioVenta
        '
        Me.txb_PrecioVenta.Location = New System.Drawing.Point(342, 174)
        Me.txb_PrecioVenta.Name = "txb_PrecioVenta"
        Me.txb_PrecioVenta.Size = New System.Drawing.Size(100, 23)
        Me.txb_PrecioVenta.TabIndex = 62
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(23, 476)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(212, 25)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Producto Seleccionado:"
        '
        'txb_id_Producto
        '
        Me.txb_id_Producto.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_id_Producto.Location = New System.Drawing.Point(27, 507)
        Me.txb_id_Producto.Name = "txb_id_Producto"
        Me.txb_id_Producto.ReadOnly = True
        Me.txb_id_Producto.Size = New System.Drawing.Size(208, 31)
        Me.txb_id_Producto.TabIndex = 59
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(27, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 15)
        Me.Label9.TabIndex = 58
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(25, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 15)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Buscar Producto"
        '
        'txb_buscarProducto
        '
        Me.txb_buscarProducto.Location = New System.Drawing.Point(23, 240)
        Me.txb_buscarProducto.Name = "txb_buscarProducto"
        Me.txb_buscarProducto.Size = New System.Drawing.Size(183, 23)
        Me.txb_buscarProducto.TabIndex = 56
        '
        'dte_Vencimiento
        '
        Me.dte_Vencimiento.Location = New System.Drawing.Point(184, 111)
        Me.dte_Vencimiento.Name = "dte_Vencimiento"
        Me.dte_Vencimiento.Size = New System.Drawing.Size(135, 23)
        Me.dte_Vencimiento.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(186, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 15)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Fecha de Vencimiento"
        '
        'dte_FechaProduccion
        '
        Me.dte_FechaProduccion.Location = New System.Drawing.Point(23, 111)
        Me.dte_FechaProduccion.Name = "dte_FechaProduccion"
        Me.dte_FechaProduccion.Size = New System.Drawing.Size(135, 23)
        Me.dte_FechaProduccion.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(342, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 15)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Precio Compra"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(342, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Precio Venta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(25, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Proveedor"
        '
        'cbx_Proveedores
        '
        Me.cbx_Proveedores.FormattingEnabled = True
        Me.cbx_Proveedores.Location = New System.Drawing.Point(23, 174)
        Me.cbx_Proveedores.Name = "cbx_Proveedores"
        Me.cbx_Proveedores.Size = New System.Drawing.Size(244, 23)
        Me.cbx_Proveedores.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(344, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Cantidad Inicial"
        '
        'dgv_productos
        '
        Me.dgv_productos.AllowUserToOrderColumns = True
        Me.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_productos.Location = New System.Drawing.Point(27, 269)
        Me.dgv_productos.Name = "dgv_productos"
        Me.dgv_productos.ReadOnly = True
        Me.dgv_productos.RowTemplate.Height = 25
        Me.dgv_productos.Size = New System.Drawing.Size(441, 182)
        Me.dgv_productos.TabIndex = 44
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.BackColor = System.Drawing.Color.Crimson
        Me.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancelar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_Cancelar.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_Cancelar.Location = New System.Drawing.Point(215, 553)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(125, 40)
        Me.btn_Cancelar.TabIndex = 43
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = False
        '
        'btn_Agregar
        '
        Me.btn_Agregar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Agregar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_Agregar.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_Agregar.Location = New System.Drawing.Point(362, 553)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(125, 40)
        Me.btn_Agregar.TabIndex = 29
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(25, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 15)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Fecha de Produccion"
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
        Me.Panel2.TabIndex = 30
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
        Me.Label10.Size = New System.Drawing.Size(104, 25)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Inventario"
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel_Registro)
        Me.Controls.Add(Me.btn_Export)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.dgv_inventario)
        Me.Controls.Add(Me.txb_buscar)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario"
        CType(Me.dgv_inventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Registro.ResumeLayout(False)
        Me.Panel_Registro.PerformLayout()
        CType(Me.num_Cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txb_buscar As TextBox
    Friend WithEvents dgv_inventario As DataGridView
    Friend WithEvents btn_new As Button
    Friend WithEvents btn_Export As Button
    Friend WithEvents Panel_Registro As Panel
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Agregar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txb_buscarProducto As TextBox
    Friend WithEvents dte_Vencimiento As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents dte_FechaProduccion As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbx_Proveedores As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_productos As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents txb_id_Producto As TextBox
    Friend WithEvents num_Cantidad As NumericUpDown
    Friend WithEvents txb_PrecioCompra As TextBox
    Friend WithEvents txb_PrecioVenta As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_titulo As Label
End Class
