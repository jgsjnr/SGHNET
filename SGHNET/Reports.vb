Public Class Reports
    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'sghDataSet.relat' table. You can move, or remove it, as needed.

        Try
            sql = "select * from relat where cpf='" & pesquisa & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                MsgBox("Relatório encontrado com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Me.relatTableAdapter.queryConsulta(Me.sghDataSet.relat, pesquisa)
                Me.ReportViewer1.RefreshReport()
            Else
                MsgBox("Não foi encontrado relatório", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                btnQuit.PerformClick()
            End If
        Catch ex As Exception
            MsgBox("Não foi possível acessar o banco de dados", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim searchLoad As New Search
        Close()
        searchLoad.Show()
    End Sub
End Class