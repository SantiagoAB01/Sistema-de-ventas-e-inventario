<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarCliente
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
        Me.txb_nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txb_apellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txb_cedula = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txb_direccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txb_email = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txb_telefono = New System.Windows.Forms.TextBox()
        Me.dat_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbx_sexo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txb_nombre
        '
        Me.txb_nombre.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_nombre.Location = New System.Drawing.Point(194, 70)
        Me.txb_nombre.Name = "txb_nombre"
        Me.txb_nombre.Size = New System.Drawing.Size(166, 23)
        Me.txb_nombre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(194, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(194, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Apellido"
        '
        'txb_apellido
        '
        Me.txb_apellido.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_apellido.Location = New System.Drawing.Point(194, 120)
        Me.txb_apellido.Name = "txb_apellido"
        Me.txb_apellido.Size = New System.Drawing.Size(166, 23)
        Me.txb_apellido.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(194, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cedula"
        '
        'txb_cedula
        '
        Me.txb_cedula.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_cedula.Location = New System.Drawing.Point(194, 171)
        Me.txb_cedula.Name = "txb_cedula"
        Me.txb_cedula.Size = New System.Drawing.Size(166, 23)
        Me.txb_cedula.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(194, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Direccion"
        '
        'txb_direccion
        '
        Me.txb_direccion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_direccion.Location = New System.Drawing.Point(194, 221)
        Me.txb_direccion.Name = "txb_direccion"
        Me.txb_direccion.Size = New System.Drawing.Size(166, 23)
        Me.txb_direccion.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(194, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "E-mail"
        '
        'txb_email
        '
        Me.txb_email.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_email.Location = New System.Drawing.Point(194, 271)
        Me.txb_email.Name = "txb_email"
        Me.txb_email.Size = New System.Drawing.Size(166, 23)
        Me.txb_email.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(194, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Telefono"
        '
        'txb_telefono
        '
        Me.txb_telefono.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_telefono.Location = New System.Drawing.Point(194, 321)
        Me.txb_telefono.Name = "txb_telefono"
        Me.txb_telefono.Size = New System.Drawing.Size(166, 23)
        Me.txb_telefono.TabIndex = 10
        '
        'dat_fecha
        '
        Me.dat_fecha.Location = New System.Drawing.Point(408, 67)
        Me.dat_fecha.Name = "dat_fecha"
        Me.dat_fecha.Size = New System.Drawing.Size(200, 23)
        Me.dat_fecha.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(408, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 25)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Fecha de Nacimiento"
        '
        'cbx_sexo
        '
        Me.cbx_sexo.FormattingEnabled = True
        Me.cbx_sexo.Items.AddRange(New Object() {"F", "M"})
        Me.cbx_sexo.Location = New System.Drawing.Point(408, 120)
        Me.cbx_sexo.Name = "cbx_sexo"
        Me.cbx_sexo.Size = New System.Drawing.Size(121, 23)
        Me.cbx_sexo.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(408, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 25)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Sexo"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.SystemColors.Window
        Me.Button2.Location = New System.Drawing.Point(663, 398)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 40)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Agregar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.Crimson
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_cancelar.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_cancelar.Location = New System.Drawing.Point(510, 398)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(125, 40)
        Me.btn_cancelar.TabIndex = 17
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'AgregarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbx_sexo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dat_fecha)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txb_telefono)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txb_email)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txb_direccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txb_cedula)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txb_apellido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txb_nombre)
        Me.Name = "AgregarCliente"
        Me.Text = "Añadir Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txb_nombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txb_apellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txb_cedula As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txb_direccion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txb_email As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txb_telefono As TextBox
    Friend WithEvents dat_fecha As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents cbx_sexo As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_cancelar As Button
End Class
