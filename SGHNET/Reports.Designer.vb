<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.relatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sghDataSet = New SGHNET.sghDataSet()
        Me.relatTableAdapter = New SGHNET.sghDataSetTableAdapters.relatTableAdapter()
        Me.SghDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.relatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sghDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SghDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetRelat"
        ReportDataSource1.Value = Me.relatBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SGHNET.ReportStatus.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1034, 602)
        Me.ReportViewer1.TabIndex = 0
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.SteelBlue
        Me.btnQuit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnQuit.FlatAppearance.BorderSize = 0
        Me.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnQuit.Location = New System.Drawing.Point(0, 567)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(1034, 35)
        Me.btnQuit.TabIndex = 7
        Me.btnQuit.Text = "Sair"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'relatBindingSource
        '
        Me.relatBindingSource.DataMember = "relat"
        Me.relatBindingSource.DataSource = Me.sghDataSet
        '
        'sghDataSet
        '
        Me.sghDataSet.DataSetName = "sghDataSet"
        Me.sghDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'relatTableAdapter
        '
        Me.relatTableAdapter.ClearBeforeFill = True
        '
        'SghDataSetBindingSource
        '
        Me.SghDataSetBindingSource.DataSource = Me.sghDataSet
        Me.SghDataSetBindingSource.Position = 0
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 602)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reports"
        Me.Text = "Reports"
        CType(Me.relatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sghDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SghDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents relatBindingSource As BindingSource
    Friend WithEvents sghDataSet As sghDataSet
    Friend WithEvents relatTableAdapter As sghDataSetTableAdapters.relatTableAdapter
    Friend WithEvents SghDataSetBindingSource As BindingSource
    Friend WithEvents btnQuit As Button
End Class
