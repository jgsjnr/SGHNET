<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.bntRegister = New System.Windows.Forms.Button()
        Me.lblAuthText = New System.Windows.Forms.Label()
        Me.lblAuth = New System.Windows.Forms.Label()
        Me.btnPaciente = New System.Windows.Forms.Button()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnLaudo = New System.Windows.Forms.Button()
        Me.btnMedico = New System.Windows.Forms.Button()
        Me.btnRelat = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnQuit
        '
        Me.btnQuit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnQuit.FlatAppearance.BorderSize = 0
        Me.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnQuit.Location = New System.Drawing.Point(0, 356)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(177, 35)
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "Sair"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'bntRegister
        '
        Me.bntRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.bntRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.bntRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bntRegister.Location = New System.Drawing.Point(39, 127)
        Me.bntRegister.Name = "bntRegister"
        Me.bntRegister.Size = New System.Drawing.Size(206, 35)
        Me.bntRegister.TabIndex = 7
        Me.bntRegister.Text = "Cadastrar/Remover usuário"
        Me.bntRegister.UseVisualStyleBackColor = True
        '
        'lblAuthText
        '
        Me.lblAuthText.AutoSize = True
        Me.lblAuthText.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblAuthText.Location = New System.Drawing.Point(21, 206)
        Me.lblAuthText.Name = "lblAuthText"
        Me.lblAuthText.Size = New System.Drawing.Size(96, 13)
        Me.lblAuthText.TabIndex = 8
        Me.lblAuthText.Text = "Autenticado como:"
        '
        'lblAuth
        '
        Me.lblAuth.AutoSize = True
        Me.lblAuth.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblAuth.Location = New System.Drawing.Point(135, 206)
        Me.lblAuth.Name = "lblAuth"
        Me.lblAuth.Size = New System.Drawing.Size(0, 13)
        Me.lblAuth.TabIndex = 9
        '
        'btnPaciente
        '
        Me.btnPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaciente.Location = New System.Drawing.Point(39, 206)
        Me.btnPaciente.Name = "btnPaciente"
        Me.btnPaciente.Size = New System.Drawing.Size(206, 35)
        Me.btnPaciente.TabIndex = 10
        Me.btnPaciente.Text = "Cadastrar paciente"
        Me.btnPaciente.UseVisualStyleBackColor = True
        '
        'btnMain
        '
        Me.btnMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMain.Location = New System.Drawing.Point(39, 246)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(206, 35)
        Me.btnMain.TabIndex = 11
        Me.btnMain.Text = "Acessar dados"
        Me.btnMain.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnQuit)
        Me.Panel1.Controls.Add(Me.lblAuthText)
        Me.Panel1.Controls.Add(Me.lblAuth)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(384, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(177, 391)
        Me.Panel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(36, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 60)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "MENU"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SGHNET.My.Resources.Resources.menu_5_line
        Me.PictureBox1.Location = New System.Drawing.Point(47, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SGHNET.My.Resources.Resources.admin_line
        Me.PictureBox2.Location = New System.Drawing.Point(105, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(86, 81)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'btnLaudo
        '
        Me.btnLaudo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnLaudo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnLaudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaudo.Location = New System.Drawing.Point(39, 286)
        Me.btnLaudo.Name = "btnLaudo"
        Me.btnLaudo.Size = New System.Drawing.Size(206, 35)
        Me.btnLaudo.TabIndex = 13
        Me.btnLaudo.Text = "Novo laudo"
        Me.btnLaudo.UseVisualStyleBackColor = True
        '
        'btnMedico
        '
        Me.btnMedico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnMedico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedico.Location = New System.Drawing.Point(39, 166)
        Me.btnMedico.Name = "btnMedico"
        Me.btnMedico.Size = New System.Drawing.Size(206, 35)
        Me.btnMedico.TabIndex = 14
        Me.btnMedico.Text = "Cadastrar/Remover médico"
        Me.btnMedico.UseVisualStyleBackColor = True
        '
        'btnRelat
        '
        Me.btnRelat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnRelat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnRelat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRelat.Location = New System.Drawing.Point(39, 327)
        Me.btnRelat.Name = "btnRelat"
        Me.btnRelat.Size = New System.Drawing.Size(206, 35)
        Me.btnRelat.TabIndex = 15
        Me.btnRelat.Text = "Relatórios"
        Me.btnRelat.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(561, 391)
        Me.Controls.Add(Me.btnRelat)
        Me.Controls.Add(Me.btnMedico)
        Me.Controls.Add(Me.btnLaudo)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.btnPaciente)
        Me.Controls.Add(Me.bntRegister)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnQuit As Button
    Friend WithEvents bntRegister As Button
    Friend WithEvents lblAuthText As Label
    Friend WithEvents lblAuth As Label
    Friend WithEvents btnPaciente As Button
    Friend WithEvents btnMain As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLaudo As Button
    Friend WithEvents btnMedico As Button
    Friend WithEvents btnRelat As Button
End Class
