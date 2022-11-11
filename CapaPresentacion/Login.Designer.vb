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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.btnLogin = New FontAwesome.Sharp.IconButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(374, 184)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(262, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PanelTitleBar)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(704, 441)
        Me.Panel1.TabIndex = 5
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Usuario"
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
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(94, 275)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(211, 23)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(94, 212)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(211, 23)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(74, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(562, 114)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido al sistema " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de inventario Macintosh!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(55, 351)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 61)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Registro"
        Me.Button1.UseVisualStyleBackColor = True
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
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
