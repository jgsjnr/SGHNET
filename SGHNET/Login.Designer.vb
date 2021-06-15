<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.btnAccess = New System.Windows.Forms.Button()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPasswd = New System.Windows.Forms.TextBox()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAccess
        '
        Me.btnAccess.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAccess.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnAccess.FlatAppearance.BorderSize = 0
        Me.btnAccess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnAccess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccess.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAccess.Location = New System.Drawing.Point(0, 206)
        Me.btnAccess.Name = "btnAccess"
        Me.btnAccess.Size = New System.Drawing.Size(205, 35)
        Me.btnAccess.TabIndex = 0
        Me.btnAccess.Text = "Acessar"
        Me.btnAccess.UseVisualStyleBackColor = False
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblUsuario.Location = New System.Drawing.Point(10, 114)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 1
        Me.lblUsuario.Text = "Usuário"
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.SeaShell
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUser.Location = New System.Drawing.Point(10, 130)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(177, 13)
        Me.txtUser.TabIndex = 1
        '
        'txtPasswd
        '
        Me.txtPasswd.BackColor = System.Drawing.Color.SeaShell
        Me.txtPasswd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPasswd.Location = New System.Drawing.Point(10, 172)
        Me.txtPasswd.Name = "txtPasswd"
        Me.txtPasswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswd.Size = New System.Drawing.Size(177, 13)
        Me.txtPasswd.TabIndex = 2
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblSenha.Location = New System.Drawing.Point(10, 157)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(38, 13)
        Me.lblSenha.TabIndex = 3
        Me.lblSenha.Text = "Senha"
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.SteelBlue
        Me.btnQuit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnQuit.FlatAppearance.BorderSize = 0
        Me.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnQuit.Location = New System.Drawing.Point(0, 241)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(205, 35)
        Me.btnQuit.TabIndex = 5
        Me.btnQuit.Text = "Sair"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SGHNET.My.Resources.Resources.login_circle_line
        Me.PictureBox1.Location = New System.Drawing.Point(64, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 74)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(205, 93)
        Me.Panel1.TabIndex = 6
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(205, 276)
        Me.Controls.Add(Me.btnAccess)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.txtPasswd)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acesso de Usuário"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAccess As Button
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPasswd As TextBox
    Friend WithEvents lblSenha As Label
    Friend WithEvents btnQuit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
