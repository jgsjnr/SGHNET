<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consult
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.rdFebreYes = New System.Windows.Forms.RadioButton()
        Me.txtObs = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdFebreNo = New System.Windows.Forms.RadioButton()
        Me.rdArNo = New System.Windows.Forms.RadioButton()
        Me.rdArYes = New System.Windows.Forms.RadioButton()
        Me.rdFadigaNo = New System.Windows.Forms.RadioButton()
        Me.rdFadigaYes = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdCoronaYes = New System.Windows.Forms.RadioButton()
        Me.rdCoronaNo = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbIntern = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbReceita = New System.Windows.Forms.ComboBox()
        Me.txtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCrm = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rdDoresYes = New System.Windows.Forms.RadioButton()
        Me.rdDoresNo = New System.Windows.Forms.RadioButton()
        Me.imgFotoPaciente = New System.Windows.Forms.PictureBox()
        Me.imgFotoMedico = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.imgFotoPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgFotoMedico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.btnSubmit)
        Me.Panel1.Controls.Add(Me.btnQuit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(153, 390)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SGHNET.My.Resources.Resources.surgical_mask_line
        Me.PictureBox2.Location = New System.Drawing.Point(30, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(87, 80)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'btnSubmit
        '
        Me.btnSubmit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSubmit.Location = New System.Drawing.Point(0, 320)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(153, 35)
        Me.btnSubmit.TabIndex = 1
        Me.btnSubmit.Text = "Enviar Análise"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnQuit.FlatAppearance.BorderSize = 0
        Me.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnQuit.Location = New System.Drawing.Point(0, 355)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(153, 35)
        Me.btnQuit.TabIndex = 0
        Me.btnQuit.Text = "Sair"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'rdFebreYes
        '
        Me.rdFebreYes.AutoSize = True
        Me.rdFebreYes.Location = New System.Drawing.Point(23, 17)
        Me.rdFebreYes.Name = "rdFebreYes"
        Me.rdFebreYes.Size = New System.Drawing.Size(42, 17)
        Me.rdFebreYes.TabIndex = 1
        Me.rdFebreYes.TabStop = True
        Me.rdFebreYes.Text = "Sim"
        Me.rdFebreYes.UseVisualStyleBackColor = True
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(159, 296)
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(649, 84)
        Me.txtObs.TabIndex = 2
        Me.txtObs.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(159, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Observações"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdFebreNo)
        Me.GroupBox1.Controls.Add(Me.rdFebreYes)
        Me.GroupBox1.Location = New System.Drawing.Point(440, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 52)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Febre"
        '
        'rdFebreNo
        '
        Me.rdFebreNo.AutoSize = True
        Me.rdFebreNo.Location = New System.Drawing.Point(125, 20)
        Me.rdFebreNo.Name = "rdFebreNo"
        Me.rdFebreNo.Size = New System.Drawing.Size(45, 17)
        Me.rdFebreNo.TabIndex = 2
        Me.rdFebreNo.TabStop = True
        Me.rdFebreNo.Text = "Não"
        Me.rdFebreNo.UseVisualStyleBackColor = True
        '
        'rdArNo
        '
        Me.rdArNo.AutoSize = True
        Me.rdArNo.Location = New System.Drawing.Point(125, 19)
        Me.rdArNo.Name = "rdArNo"
        Me.rdArNo.Size = New System.Drawing.Size(45, 17)
        Me.rdArNo.TabIndex = 8
        Me.rdArNo.TabStop = True
        Me.rdArNo.Text = "Não"
        Me.rdArNo.UseVisualStyleBackColor = True
        '
        'rdArYes
        '
        Me.rdArYes.AutoSize = True
        Me.rdArYes.Location = New System.Drawing.Point(23, 19)
        Me.rdArYes.Name = "rdArYes"
        Me.rdArYes.Size = New System.Drawing.Size(42, 17)
        Me.rdArYes.TabIndex = 7
        Me.rdArYes.TabStop = True
        Me.rdArYes.Text = "Sim"
        Me.rdArYes.UseVisualStyleBackColor = True
        '
        'rdFadigaNo
        '
        Me.rdFadigaNo.AutoSize = True
        Me.rdFadigaNo.Location = New System.Drawing.Point(125, 21)
        Me.rdFadigaNo.Name = "rdFadigaNo"
        Me.rdFadigaNo.Size = New System.Drawing.Size(45, 17)
        Me.rdFadigaNo.TabIndex = 6
        Me.rdFadigaNo.TabStop = True
        Me.rdFadigaNo.Text = "Não"
        Me.rdFadigaNo.UseVisualStyleBackColor = True
        '
        'rdFadigaYes
        '
        Me.rdFadigaYes.AutoSize = True
        Me.rdFadigaYes.Location = New System.Drawing.Point(23, 20)
        Me.rdFadigaYes.Name = "rdFadigaYes"
        Me.rdFadigaYes.Size = New System.Drawing.Size(42, 17)
        Me.rdFadigaYes.TabIndex = 5
        Me.rdFadigaYes.TabStop = True
        Me.rdFadigaYes.Text = "Sim"
        Me.rdFadigaYes.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Receita Médica?"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdCoronaYes)
        Me.GroupBox2.Controls.Add(Me.rdCoronaNo)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cmbIntern)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cmbReceita)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(642, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(165, 166)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Laudo"
        '
        'rdCoronaYes
        '
        Me.rdCoronaYes.AutoSize = True
        Me.rdCoronaYes.Location = New System.Drawing.Point(39, 129)
        Me.rdCoronaYes.Name = "rdCoronaYes"
        Me.rdCoronaYes.Size = New System.Drawing.Size(42, 17)
        Me.rdCoronaYes.TabIndex = 17
        Me.rdCoronaYes.TabStop = True
        Me.rdCoronaYes.Text = "Sim"
        Me.rdCoronaYes.UseVisualStyleBackColor = True
        '
        'rdCoronaNo
        '
        Me.rdCoronaNo.AutoSize = True
        Me.rdCoronaNo.Location = New System.Drawing.Point(83, 129)
        Me.rdCoronaNo.Name = "rdCoronaNo"
        Me.rdCoronaNo.Size = New System.Drawing.Size(45, 17)
        Me.rdCoronaNo.TabIndex = 16
        Me.rdCoronaNo.TabStop = True
        Me.rdCoronaNo.Text = "Não"
        Me.rdCoronaNo.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(25, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Positivo para COVID-19"
        '
        'cmbIntern
        '
        Me.cmbIntern.FormattingEnabled = True
        Me.cmbIntern.Items.AddRange(New Object() {"Urgente", "Não"})
        Me.cmbIntern.Location = New System.Drawing.Point(5, 83)
        Me.cmbIntern.Name = "cmbIntern"
        Me.cmbIntern.Size = New System.Drawing.Size(156, 21)
        Me.cmbIntern.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Internação"
        '
        'cmbReceita
        '
        Me.cmbReceita.FormattingEnabled = True
        Me.cmbReceita.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cmbReceita.Location = New System.Drawing.Point(5, 36)
        Me.cmbReceita.Name = "cmbReceita"
        Me.cmbReceita.Size = New System.Drawing.Size(156, 21)
        Me.cmbReceita.TabIndex = 6
        '
        'txtCpf
        '
        Me.txtCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.txtCpf.Location = New System.Drawing.Point(159, 43)
        Me.txtCpf.Mask = "000.000.000-00"
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(136, 20)
        Me.txtCpf.TabIndex = 8
        Me.txtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(159, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "CPF do Paciente"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Impact", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(663, 192)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 16)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "USE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(652, 206)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(147, 39)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "MASCARA"
        '
        'txtCrm
        '
        Me.txtCrm.Location = New System.Drawing.Point(299, 43)
        Me.txtCrm.Mask = "000000"
        Me.txtCrm.Name = "txtCrm"
        Me.txtCrm.Size = New System.Drawing.Size(136, 20)
        Me.txtCrm.TabIndex = 21
        Me.txtCrm.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(299, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "CRM Médico"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdFadigaNo)
        Me.GroupBox3.Controls.Add(Me.rdFadigaYes)
        Me.GroupBox3.Location = New System.Drawing.Point(440, 68)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(197, 52)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fadiga"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rdArYes)
        Me.GroupBox4.Controls.Add(Me.rdArNo)
        Me.GroupBox4.Location = New System.Drawing.Point(440, 126)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(197, 52)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Falta de ar"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rdDoresYes)
        Me.GroupBox5.Controls.Add(Me.rdDoresNo)
        Me.GroupBox5.Location = New System.Drawing.Point(440, 188)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(197, 52)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Dores e Tosse seca"
        '
        'rdDoresYes
        '
        Me.rdDoresYes.AutoSize = True
        Me.rdDoresYes.Location = New System.Drawing.Point(24, 19)
        Me.rdDoresYes.Name = "rdDoresYes"
        Me.rdDoresYes.Size = New System.Drawing.Size(42, 17)
        Me.rdDoresYes.TabIndex = 9
        Me.rdDoresYes.TabStop = True
        Me.rdDoresYes.Text = "Sim"
        Me.rdDoresYes.UseVisualStyleBackColor = True
        '
        'rdDoresNo
        '
        Me.rdDoresNo.AutoSize = True
        Me.rdDoresNo.Location = New System.Drawing.Point(126, 19)
        Me.rdDoresNo.Name = "rdDoresNo"
        Me.rdDoresNo.Size = New System.Drawing.Size(45, 17)
        Me.rdDoresNo.TabIndex = 10
        Me.rdDoresNo.TabStop = True
        Me.rdDoresNo.Text = "Não"
        Me.rdDoresNo.UseVisualStyleBackColor = True
        '
        'imgFotoPaciente
        '
        Me.imgFotoPaciente.Image = Global.SGHNET.My.Resources.Resources.admin_line
        Me.imgFotoPaciente.InitialImage = Global.SGHNET.My.Resources.Resources.admin_line
        Me.imgFotoPaciente.Location = New System.Drawing.Point(159, 69)
        Me.imgFotoPaciente.Name = "imgFotoPaciente"
        Me.imgFotoPaciente.Size = New System.Drawing.Size(135, 171)
        Me.imgFotoPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFotoPaciente.TabIndex = 23
        Me.imgFotoPaciente.TabStop = False
        '
        'imgFotoMedico
        '
        Me.imgFotoMedico.Image = Global.SGHNET.My.Resources.Resources.surgical_mask_line
        Me.imgFotoMedico.Location = New System.Drawing.Point(300, 69)
        Me.imgFotoMedico.Name = "imgFotoMedico"
        Me.imgFotoMedico.Size = New System.Drawing.Size(135, 171)
        Me.imgFotoMedico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFotoMedico.TabIndex = 24
        Me.imgFotoMedico.TabStop = False
        '
        'Consult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(818, 390)
        Me.Controls.Add(Me.imgFotoMedico)
        Me.Controls.Add(Me.imgFotoPaciente)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtCrm)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCpf)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Consult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consult"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.imgFotoPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgFotoMedico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents rdFebreYes As RadioButton
    Friend WithEvents txtObs As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdArNo As RadioButton
    Friend WithEvents rdArYes As RadioButton
    Friend WithEvents rdFadigaNo As RadioButton
    Friend WithEvents rdFadigaYes As RadioButton
    Friend WithEvents rdFebreNo As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbIntern As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbReceita As ComboBox
    Friend WithEvents txtCpf As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents rdCoronaYes As RadioButton
    Friend WithEvents rdCoronaNo As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtCrm As MaskedTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rdDoresYes As RadioButton
    Friend WithEvents rdDoresNo As RadioButton
    Friend WithEvents imgFotoPaciente As PictureBox
    Friend WithEvents imgFotoMedico As PictureBox
End Class
