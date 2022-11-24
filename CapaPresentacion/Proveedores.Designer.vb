<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores
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
        Me.txb_buscar = New System.Windows.Forms.TextBox()
        Me.dgv_Proveedores = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.Panel_Registro = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txb_url = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txb_email = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txb_telefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txb_direccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txb_documento = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txb_sector = New System.Windows.Forms.TextBox()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txb_nombre = New System.Windows.Forms.TextBox()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_Proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Registro.SuspendLayout()
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
        Me.Panel2.TabIndex = 31
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
        Me.Label10.Size = New System.Drawing.Size(124, 25)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Proveedores"
        '
        'txb_buscar
        '
        Me.txb_buscar.Location = New System.Drawing.Point(58, 95)
        Me.txb_buscar.Name = "txb_buscar"
        Me.txb_buscar.Size = New System.Drawing.Size(182, 23)
        Me.txb_buscar.TabIndex = 34
        '
        'dgv_Proveedores
        '
        Me.dgv_Proveedores.AllowUserToAddRows = False
        Me.dgv_Proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Proveedores.Location = New System.Drawing.Point(58, 142)
        Me.dgv_Proveedores.MultiSelect = False
        Me.dgv_Proveedores.Name = "dgv_Proveedores"
        Me.dgv_Proveedores.ReadOnly = True
        Me.dgv_Proveedores.RowTemplate.Height = 25
        Me.dgv_Proveedores.Size = New System.Drawing.Size(844, 434)
        Me.dgv_Proveedores.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(59, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 19)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Buscar"
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Nuevo.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_Nuevo.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_Nuevo.Location = New System.Drawing.Point(276, 82)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(125, 40)
        Me.btn_Nuevo.TabIndex = 35
        Me.btn_Nuevo.Text = "Nuevo"
        Me.btn_Nuevo.UseVisualStyleBackColor = False
        '
        'Panel_Registro
        '
        Me.Panel_Registro.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel_Registro.Controls.Add(Me.Label7)
        Me.Panel_Registro.Controls.Add(Me.txb_url)
        Me.Panel_Registro.Controls.Add(Me.Label6)
        Me.Panel_Registro.Controls.Add(Me.txb_email)
        Me.Panel_Registro.Controls.Add(Me.Label5)
        Me.Panel_Registro.Controls.Add(Me.txb_telefono)
        Me.Panel_Registro.Controls.Add(Me.Label4)
        Me.Panel_Registro.Controls.Add(Me.txb_direccion)
        Me.Panel_Registro.Controls.Add(Me.Label3)
        Me.Panel_Registro.Controls.Add(Me.txb_documento)
        Me.Panel_Registro.Controls.Add(Me.Label1)
        Me.Panel_Registro.Controls.Add(Me.txb_sector)
        Me.Panel_Registro.Controls.Add(Me.btn_actualizar)
        Me.Panel_Registro.Controls.Add(Me.btn_eliminar)
        Me.Panel_Registro.Controls.Add(Me.lbl_titulo)
        Me.Panel_Registro.Controls.Add(Me.Label9)
        Me.Panel_Registro.Controls.Add(Me.Label8)
        Me.Panel_Registro.Controls.Add(Me.txb_nombre)
        Me.Panel_Registro.Controls.Add(Me.btn_Cancelar)
        Me.Panel_Registro.Controls.Add(Me.btn_Agregar)
        Me.Panel_Registro.Location = New System.Drawing.Point(562, 82)
        Me.Panel_Registro.Name = "Panel_Registro"
        Me.Panel_Registro.Size = New System.Drawing.Size(490, 511)
        Me.Panel_Registro.TabIndex = 36
        Me.Panel_Registro.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(277, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 15)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Direccion URL"
        '
        'txb_url
        '
        Me.txb_url.Location = New System.Drawing.Point(275, 256)
        Me.txb_url.Name = "txb_url"
        Me.txb_url.Size = New System.Drawing.Size(183, 23)
        Me.txb_url.TabIndex = 80
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(277, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 15)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "E-Mail"
        '
        'txb_email
        '
        Me.txb_email.Location = New System.Drawing.Point(275, 179)
        Me.txb_email.Name = "txb_email"
        Me.txb_email.Size = New System.Drawing.Size(183, 23)
        Me.txb_email.TabIndex = 78
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(275, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Telefono"
        '
        'txb_telefono
        '
        Me.txb_telefono.Location = New System.Drawing.Point(273, 110)
        Me.txb_telefono.Name = "txb_telefono"
        Me.txb_telefono.Size = New System.Drawing.Size(183, 23)
        Me.txb_telefono.TabIndex = 76
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(31, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Direccion"
        '
        'txb_direccion
        '
        Me.txb_direccion.Location = New System.Drawing.Point(29, 332)
        Me.txb_direccion.Name = "txb_direccion"
        Me.txb_direccion.Size = New System.Drawing.Size(183, 23)
        Me.txb_direccion.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(31, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 15)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Numero Documento"
        '
        'txb_documento
        '
        Me.txb_documento.Location = New System.Drawing.Point(29, 256)
        Me.txb_documento.Name = "txb_documento"
        Me.txb_documento.Size = New System.Drawing.Size(183, 23)
        Me.txb_documento.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(29, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 15)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Sector Comercial"
        '
        'txb_sector
        '
        Me.txb_sector.Location = New System.Drawing.Point(27, 179)
        Me.txb_sector.Name = "txb_sector"
        Me.txb_sector.Size = New System.Drawing.Size(183, 23)
        Me.txb_sector.TabIndex = 70
        '
        'btn_actualizar
        '
        Me.btn_actualizar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_actualizar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_actualizar.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_actualizar.Location = New System.Drawing.Point(354, 416)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(125, 40)
        Me.btn_actualizar.TabIndex = 69
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Crimson
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_eliminar.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_eliminar.Location = New System.Drawing.Point(354, 12)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(125, 40)
        Me.btn_eliminar.TabIndex = 68
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
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
        Me.Label8.Location = New System.Drawing.Point(29, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 15)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Nombre Proveedor"
        '
        'txb_nombre
        '
        Me.txb_nombre.Location = New System.Drawing.Point(27, 110)
        Me.txb_nombre.Name = "txb_nombre"
        Me.txb_nombre.Size = New System.Drawing.Size(183, 23)
        Me.txb_nombre.TabIndex = 56
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.BackColor = System.Drawing.Color.Gray
        Me.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancelar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_Cancelar.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_Cancelar.Location = New System.Drawing.Point(215, 416)
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
        Me.btn_Agregar.Location = New System.Drawing.Point(354, 416)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(125, 40)
        Me.btn_Agregar.TabIndex = 29
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.UseVisualStyleBackColor = False
        '
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.Controls.Add(Me.Panel_Registro)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.txb_buscar)
        Me.Controls.Add(Me.dgv_Proveedores)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Proveedores"
        Me.Text = "Proveedores"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgv_Proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Registro.ResumeLayout(False)
        Me.Panel_Registro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Button3 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txb_buscar As TextBox
    Friend WithEvents dgv_Proveedores As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_Nuevo As Button
    Friend WithEvents Panel_Registro As Panel
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txb_nombre As TextBox
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Agregar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txb_url As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txb_email As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txb_telefono As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txb_direccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txb_documento As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txb_sector As TextBox
End Class
