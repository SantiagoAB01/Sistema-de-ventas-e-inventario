<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tx = New System.Windows.Forms.Label()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.btnLogin = New FontAwesome.Sharp.IconButton()
        Me.txb_password = New System.Windows.Forms.TextBox()
        Me.txb_cedula = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CapaPresentacion.My.Resources.Resources.logo_ds8
        Me.PictureBox1.Location = New System.Drawing.Point(3, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(245, 196)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tx)
        Me.Panel1.Controls.Add(Me.PanelTitleBar)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.txb_password)
        Me.Panel1.Controls.Add(Me.txb_cedula)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(704, 441)
        Me.Panel1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(55, 351)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 61)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Registro"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Contraseña"
        '
        'tx
        '
        Me.tx.AutoSize = True
        Me.tx.Location = New System.Drawing.Point(94, 184)
        Me.tx.Name = "tx"
        Me.tx.Size = New System.Drawing.Size(44, 15)
        Me.tx.TabIndex = 7
        Me.tx.Text = "Cedula"
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.Green
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(704, 35)
        Me.PanelTitleBar.TabIndex = 6
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Green
        Me.btnLogin.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.btnLogin.IconColor = System.Drawing.Color.White
        Me.btnLogin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogin.Location = New System.Drawing.Point(214, 351)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Padding = New System.Windows.Forms.Padding(5)
        Me.btnLogin.Size = New System.Drawing.Size(167, 63)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txb_password
        '
        Me.txb_password.Location = New System.Drawing.Point(94, 275)
        Me.txb_password.Name = "txb_password"
        Me.txb_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txb_password.PlaceholderText = "*******"
        Me.txb_password.Size = New System.Drawing.Size(211, 23)
        Me.txb_password.TabIndex = 2
        '
        'txb_cedula
        '
        Me.txb_cedula.Location = New System.Drawing.Point(94, 212)
        Me.txb_cedula.Name = "txb_cedula"
        Me.txb_cedula.PlaceholderText = "0-000-000"
        Me.txb_cedula.Size = New System.Drawing.Size(211, 23)
        Me.txb_cedula.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Azure
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(453, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(269, 407)
        Me.Panel2.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(40, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(365, 72)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Iniciar Sesion"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 441)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenido"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txb_password As TextBox
    Friend WithEvents txb_cedula As TextBox
    Friend WithEvents btnLogin As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents tx As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
End Class
