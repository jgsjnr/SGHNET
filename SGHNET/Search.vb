Public Class Search
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtCpf.Text = String.Empty Then
            MsgBox("Preencha o campo do CPF", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Else
            Dim reportLoad As New Reports
            pesquisa = txtCpf.Text.ToString
            reportLoad.Show()
            Close()
        End If
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim menuLoad As New Menu
        Close()
        menuLoad.Show()
    End Sub
End Class