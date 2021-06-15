<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDisable = New System.Windows.Forms.Button()
        Me.btnInserir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnVoltar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.Location = New System.Drawing.Point(265, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(530, 361)
        Me.DataGridView1.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSearch.Location = New System.Drawing.Point(0, 201)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(259, 40)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Procurar"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnDisable
        '
        Me.btnDisable.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnDisable.Enabled = False
        Me.btnDisable.FlatAppearance.BorderSize = 0
        Me.btnDisable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnDisable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisable.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDisable.Location = New System.Drawing.Point(0, 281)
        Me.btnDisable.Name = "btnDisable"
        Me.btnDisable.Size = New System.Drawing.Size(259, 40)
        Me.btnDisable.TabIndex = 2
        Me.btnDisable.Text = "Desabilitar"
        Me.btnDisable.UseVisualStyleBackColor = True
        '
        'btnInserir
        '
        Me.btnInserir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnInserir.FlatAppearance.BorderSize = 0
        Me.btnInserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnInserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInserir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnInserir.Location = New System.Drawing.Point(0, 241)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(259, 40)
        Me.btnInserir.TabIndex = 3
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.btnInserir)
        Me.Panel1.Controls.Add(Me.btnDisable)
        Me.Panel1.Controls.Add(Me.btnVoltar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(259, 361)
        Me.Panel1.TabIndex = 5
        '
        'btnUpdate
        '
        Me.btnUpdate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnUpdate.Location = New System.Drawing.Point(0, 161)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(259, 40)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "Atualizar"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(12, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(238, 39)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "ADMINISTRAÇÃO"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SGHNET.My.Resources.Resources.admin_line
        Me.PictureBox2.Location = New System.Drawing.Point(79, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(107, 102)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'btnVoltar
        '
        Me.btnVoltar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnVoltar.FlatAppearance.BorderSize = 0
        Me.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnVoltar.Location = New System.Drawing.Point(0, 321)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(259, 40)
        Me.btnVoltar.TabIndex = 7
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(794, 361)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnDisable As Button
    Friend WithEvents btnInserir As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnVoltar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btnUpdate As Button
End Class
