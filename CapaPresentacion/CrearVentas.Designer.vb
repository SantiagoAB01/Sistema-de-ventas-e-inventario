<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearVentas
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txb_subtotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txb_total = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbx_clientes = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.num_cantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbx_productos = New System.Windows.Forms.ComboBox()
        Me.dgv_producto = New System.Windows.Forms.DataGridView()
        Me.Panel_LineaPedido = New System.Windows.Forms.Panel()
        Me.btn_Enviar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txb_itbms = New System.Windows.Forms.TextBox()
        Me.txb_descripcion = New System.Windows.Forms.TextBox()
        Me.dgv_lineaPedidos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_linea = New System.Windows.Forms.Label()
        Me.id_ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITBMS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.num_cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_producto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_LineaPedido.SuspendLayout()
        CType(Me.dgv_lineaPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Controls.Add(Me.btn_new)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txb_subtotal)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txb_total)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbx_clientes)
        Me.Panel1.Location = New System.Drawing.Point(12, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(375, 296)
        Me.Panel1.TabIndex = 7
        '
        'btn_new
        '
        Me.btn_new.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_new.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_new.Location = New System.Drawing.Point(228, 187)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(125, 78)
        Me.btn_new.TabIndex = 12
        Me.btn_new.Text = "Nueva Linea"
        Me.btn_new.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(24, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 32)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "SUB TOTAL"
        '
        'txb_subtotal
        '
        Me.txb_subtotal.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_subtotal.Location = New System.Drawing.Point(24, 136)
        Me.txb_subtotal.Name = "txb_subtotal"
        Me.txb_subtotal.Size = New System.Drawing.Size(169, 38)
        Me.txb_subtotal.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(24, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TOTAL VENTA"
        '
        'txb_total
        '
        Me.txb_total.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_total.Location = New System.Drawing.Point(24, 225)
        Me.txb_total.Name = "txb_total"
        Me.txb_total.Size = New System.Drawing.Size(169, 38)
        Me.txb_total.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(24, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente"
        '
        'cbx_clientes
        '
        Me.cbx_clientes.FormattingEnabled = True
        Me.cbx_clientes.Location = New System.Drawing.Point(24, 51)
        Me.cbx_clientes.Name = "cbx_clientes"
        Me.cbx_clientes.Size = New System.Drawing.Size(170, 23)
        Me.cbx_clientes.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(217, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cantidad"
        '
        'num_cantidad
        '
        Me.num_cantidad.Location = New System.Drawing.Point(217, 58)
        Me.num_cantidad.Name = "num_cantidad"
        Me.num_cantidad.Size = New System.Drawing.Size(120, 23)
        Me.num_cantidad.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(21, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Producto"
        '
        'cbx_productos
        '
        Me.cbx_productos.FormattingEnabled = True
        Me.cbx_productos.Location = New System.Drawing.Point(21, 58)
        Me.cbx_productos.Name = "cbx_productos"
        Me.cbx_productos.Size = New System.Drawing.Size(170, 23)
        Me.cbx_productos.TabIndex = 2
        '
        'dgv_producto
        '
        Me.dgv_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_producto.Location = New System.Drawing.Point(393, 77)
        Me.dgv_producto.Name = "dgv_producto"
        Me.dgv_producto.RowTemplate.Height = 25
        Me.dgv_producto.Size = New System.Drawing.Size(659, 96)
        Me.dgv_producto.TabIndex = 8
        '
        'Panel_LineaPedido
        '
        Me.Panel_LineaPedido.BackColor = System.Drawing.Color.Bisque
        Me.Panel_LineaPedido.Controls.Add(Me.btn_Enviar)
        Me.Panel_LineaPedido.Controls.Add(Me.btn_agregar)
        Me.Panel_LineaPedido.Controls.Add(Me.btn_cancelar)
        Me.Panel_LineaPedido.Controls.Add(Me.Label6)
        Me.Panel_LineaPedido.Controls.Add(Me.Label5)
        Me.Panel_LineaPedido.Controls.Add(Me.txb_itbms)
        Me.Panel_LineaPedido.Controls.Add(Me.txb_descripcion)
        Me.Panel_LineaPedido.Controls.Add(Me.Label3)
        Me.Panel_LineaPedido.Controls.Add(Me.num_cantidad)
        Me.Panel_LineaPedido.Controls.Add(Me.cbx_productos)
        Me.Panel_LineaPedido.Controls.Add(Me.Label2)
        Me.Panel_LineaPedido.Location = New System.Drawing.Point(393, 183)
        Me.Panel_LineaPedido.Name = "Panel_LineaPedido"
        Me.Panel_LineaPedido.Size = New System.Drawing.Size(659, 190)
        Me.Panel_LineaPedido.TabIndex = 9
        Me.Panel_LineaPedido.Visible = False
        '
        'btn_Enviar
        '
        Me.btn_Enviar.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_Enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Enviar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_Enviar.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_Enviar.Location = New System.Drawing.Point(502, 148)
        Me.btn_Enviar.Name = "btn_Enviar"
        Me.btn_Enviar.Size = New System.Drawing.Size(95, 30)
        Me.btn_Enviar.TabIndex = 15
        Me.btn_Enviar.Text = "Enviar"
        Me.btn_Enviar.UseVisualStyleBackColor = False
        Me.btn_Enviar.Visible = False
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_agregar.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_agregar.Location = New System.Drawing.Point(21, 141)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(95, 30)
        Me.btn_agregar.TabIndex = 14
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.Crimson
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_cancelar.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_cancelar.Location = New System.Drawing.Point(21, 105)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(95, 30)
        Me.btn_cancelar.TabIndex = 13
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(217, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ITBMS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(372, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 21)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Descripcion"
        '
        'txb_itbms
        '
        Me.txb_itbms.Location = New System.Drawing.Point(217, 119)
        Me.txb_itbms.Name = "txb_itbms"
        Me.txb_itbms.Size = New System.Drawing.Size(100, 23)
        Me.txb_itbms.TabIndex = 4
        '
        'txb_descripcion
        '
        Me.txb_descripcion.Location = New System.Drawing.Point(372, 57)
        Me.txb_descripcion.Multiline = True
        Me.txb_descripcion.Name = "txb_descripcion"
        Me.txb_descripcion.Size = New System.Drawing.Size(225, 85)
        Me.txb_descripcion.TabIndex = 4
        '
        'dgv_lineaPedidos
        '
        Me.dgv_lineaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_lineaPedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.cliente_id, Me.Producto_id, Me.DataGridViewTextBoxColumn2, Me.cantidad, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.sub_total, Me.total_venta})
        Me.dgv_lineaPedidos.Location = New System.Drawing.Point(12, 436)
        Me.dgv_lineaPedidos.Name = "dgv_lineaPedidos"
        Me.dgv_lineaPedidos.RowTemplate.Height = 25
        Me.dgv_lineaPedidos.Size = New System.Drawing.Size(1040, 218)
        Me.dgv_lineaPedidos.TabIndex = 10
        Me.dgv_lineaPedidos.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Ingreso ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'cliente_id
        '
        Me.cliente_id.HeaderText = "Cliente ID"
        Me.cliente_id.Name = "cliente_id"
        '
        'Producto_id
        '
        Me.Producto_id.HeaderText = "Producto ID"
        Me.Producto_id.Name = "Producto_id"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "ITBMS"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'sub_total
        '
        Me.sub_total.HeaderText = "SUB TOTAL"
        Me.sub_total.Name = "sub_total"
        '
        'total_venta
        '
        Me.total_venta.HeaderText = "VENTA TOTAL"
        Me.total_venta.Name = "total_venta"
        '
        'lbl_linea
        '
        Me.lbl_linea.AutoSize = True
        Me.lbl_linea.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_linea.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_linea.Location = New System.Drawing.Point(12, 401)
        Me.lbl_linea.Name = "lbl_linea"
        Me.lbl_linea.Size = New System.Drawing.Size(171, 32)
        Me.lbl_linea.TabIndex = 13
        Me.lbl_linea.Text = "Linea Pedidos"
        Me.lbl_linea.Visible = False
        '
        'id_ingreso
        '
        Me.id_ingreso.HeaderText = "Ingreso ID"
        Me.id_ingreso.Name = "id_ingreso"
        '
        'cliente
        '
        Me.cliente.HeaderText = "cliente ID"
        Me.cliente.Name = "cliente"
        '
        'producto
        '
        Me.producto.HeaderText = "Producto ID"
        Me.producto.Name = "producto"
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'fecha
        '
        Me.fecha.HeaderText = "fecha"
        Me.fecha.Name = "fecha"
        '
        'ITBMS
        '
        Me.ITBMS.HeaderText = "ITBMS"
        Me.ITBMS.Name = "ITBMS"
        '
        'SubTotal
        '
        Me.SubTotal.HeaderText = "SubTotal"
        Me.SubTotal.Name = "SubTotal"
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
        Me.Panel2.TabIndex = 31
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
        Me.Label10.Size = New System.Drawing.Size(140, 25)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Generar Venta"
        '
        'CrearVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lbl_linea)
        Me.Controls.Add(Me.dgv_lineaPedidos)
        Me.Controls.Add(Me.Panel_LineaPedido)
        Me.Controls.Add(Me.dgv_producto)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CrearVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.num_cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_producto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_LineaPedido.ResumeLayout(False)
        Me.Panel_LineaPedido.PerformLayout()
        CType(Me.dgv_lineaPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents num_cantidad As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents cbx_productos As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbx_clientes As ComboBox
    Friend WithEvents dgv_producto As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents txb_subtotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txb_total As TextBox
    Friend WithEvents Panel_LineaPedido As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txb_itbms As TextBox
    Friend WithEvents txb_descripcion As TextBox
    Friend WithEvents btn_new As Button
    Friend WithEvents btn_Enviar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents dgv_lineaPedidos As DataGridView
    Friend WithEvents lbl_linea As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents cliente_id As DataGridViewTextBoxColumn
    Friend WithEvents Producto_id As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents sub_total As DataGridViewTextBoxColumn
    Friend WithEvents total_venta As DataGridViewTextBoxColumn
    Friend WithEvents id_ingreso As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents producto As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents ITBMS As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label10 As Label
End Class
