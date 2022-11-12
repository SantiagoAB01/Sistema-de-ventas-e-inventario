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
        Me.dgv_proveedores = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.txb_buscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel_Registro = New System.Windows.Forms.Panel()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.txb_url = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txb_email = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txb_telefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txb_direccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txb_numdoc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txb_sector = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txb_nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dgv_proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Registro.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_proveedores
        '
        Me.dgv_proveedores.AllowUserToAddRows = False
        Me.dgv_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_proveedores.Location = New System.Drawing.Point(12, 154)
        Me.dgv_proveedores.Name = "dgv_proveedores"
        Me.dgv_proveedores.RowTemplate.Height = 25
        Me.dgv_proveedores.Size = New System.Drawing.Size(854, 476)
        Me.dgv_proveedores.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Crimson
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.SystemColors.Window
        Me.Button2.Location = New System.Drawing.Point(741, 97)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 40)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Borrar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.SystemColors.Window
        Me.Button1.Location = New System.Drawing.Point(574, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 40)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Editar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_new
        '
        Me.btn_new.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_new.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_new.Location = New System.Drawing.Point(408, 97)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(125, 40)
        Me.btn_new.TabIndex = 14
        Me.btn_new.Text = "Nuevo"
        Me.btn_new.UseVisualStyleBackColor = False
        '
        'txb_buscar
        '
        Me.txb_buscar.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_buscar.Location = New System.Drawing.Point(12, 104)
        Me.txb_buscar.Name = "txb_buscar"
        Me.txb_buscar.Size = New System.Drawing.Size(232, 31)
        Me.txb_buscar.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 25)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Buscar"
        '
        'Panel_Registro
        '
        Me.Panel_Registro.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel_Registro.Controls.Add(Me.btn_Cancelar)
        Me.Panel_Registro.Controls.Add(Me.btn_Agregar)
        Me.Panel_Registro.Controls.Add(Me.txb_url)
        Me.Panel_Registro.Controls.Add(Me.Label8)
        Me.Panel_Registro.Controls.Add(Me.txb_email)
        Me.Panel_Registro.Controls.Add(Me.Label6)
        Me.Panel_Registro.Controls.Add(Me.txb_telefono)
        Me.Panel_Registro.Controls.Add(Me.Label7)
        Me.Panel_Registro.Controls.Add(Me.txb_direccion)
        Me.Panel_Registro.Controls.Add(Me.Label5)
        Me.Panel_Registro.Controls.Add(Me.txb_numdoc)
        Me.Panel_Registro.Controls.Add(Me.Label4)
        Me.Panel_Registro.Controls.Add(Me.txb_sector)
        Me.Panel_Registro.Controls.Add(Me.Label3)
        Me.Panel_Registro.Controls.Add(Me.txb_nombre)
        Me.Panel_Registro.Controls.Add(Me.Label1)
        Me.Panel_Registro.Location = New System.Drawing.Point(719, 154)
        Me.Panel_Registro.Name = "Panel_Registro"
        Me.Panel_Registro.Size = New System.Drawing.Size(333, 476)
        Me.Panel_Registro.TabIndex = 28
        Me.Panel_Registro.Visible = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.BackColor = System.Drawing.Color.Crimson
        Me.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancelar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_Cancelar.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_Cancelar.Location = New System.Drawing.Point(22, 420)
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
        Me.btn_Agregar.Location = New System.Drawing.Point(190, 420)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(125, 40)
        Me.btn_Agregar.TabIndex = 29
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.UseVisualStyleBackColor = False
        '
        'txb_url
        '
        Me.txb_url.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_url.Location = New System.Drawing.Point(49, 381)
        Me.txb_url.Name = "txb_url"
        Me.txb_url.Size = New System.Drawing.Size(232, 23)
        Me.txb_url.TabIndex = 42
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(51, 358)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 15)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Direccion URL"
        '
        'txb_email
        '
        Me.txb_email.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_email.Location = New System.Drawing.Point(49, 325)
        Me.txb_email.Name = "txb_email"
        Me.txb_email.Size = New System.Drawing.Size(232, 23)
        Me.txb_email.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(51, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 15)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "E-mail"
        '
        'txb_telefono
        '
        Me.txb_telefono.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_telefono.Location = New System.Drawing.Point(49, 268)
        Me.txb_telefono.Name = "txb_telefono"
        Me.txb_telefono.Size = New System.Drawing.Size(232, 23)
        Me.txb_telefono.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(51, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 15)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Telefono"
        '
        'txb_direccion
        '
        Me.txb_direccion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_direccion.Location = New System.Drawing.Point(49, 213)
        Me.txb_direccion.Name = "txb_direccion"
        Me.txb_direccion.Size = New System.Drawing.Size(232, 23)
        Me.txb_direccion.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(51, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 15)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Direccion"
        '
        'txb_numdoc
        '
        Me.txb_numdoc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_numdoc.Location = New System.Drawing.Point(49, 156)
        Me.txb_numdoc.Name = "txb_numdoc"
        Me.txb_numdoc.Size = New System.Drawing.Size(232, 23)
        Me.txb_numdoc.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(51, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 15)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Numero de Documento"
        '
        'txb_sector
        '
        Me.txb_sector.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_sector.Location = New System.Drawing.Point(49, 101)
        Me.txb_sector.Name = "txb_sector"
        Me.txb_sector.Size = New System.Drawing.Size(232, 23)
        Me.txb_sector.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(51, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 15)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Sector Comercial"
        '
        'txb_nombre
        '
        Me.txb_nombre.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_nombre.Location = New System.Drawing.Point(49, 46)
        Me.txb_nombre.Name = "txb_nombre"
        Me.txb_nombre.Size = New System.Drawing.Size(232, 23)
        Me.txb_nombre.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(51, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Nombre"
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
        Me.Panel2.TabIndex = 29
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
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel_Registro)
        Me.Controls.Add(Me.txb_buscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.dgv_proveedores)
        Me.Name = "Proveedores"
        Me.Text = "Proveedores"
        CType(Me.dgv_proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Registro.ResumeLayout(False)
        Me.Panel_Registro.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_proveedores As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_new As Button
    Friend WithEvents txb_buscar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel_Registro As Panel
    Friend WithEvents txb_email As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txb_telefono As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txb_direccion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txb_numdoc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txb_sector As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txb_nombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txb_url As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Agregar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Button3 As Button
    Friend WithEvents Label10 As Label
End Class
