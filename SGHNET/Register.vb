Public Class Register
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtUser.Text = String.Empty Or txtPasswd.Text = String.Empty Or cmbLevel.SelectedIndex = -1 Then
            MsgBox("Todos os campos devem estar completos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Else
            Try
                sql = "select * from users where users='" & txtUser.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    MsgBox("Usuário já existe", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    Try
                        sql = "insert into users values('" & txtUser.Text & "','" & txtPasswd.Text & "','" & cmbLevel.Text & "')"
                        rs = db.Execute(sql)
                        MsgBox("Usuário adicionado com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        cleanRegister()
                    Catch ex As Exception
                        MsgBox("Não foi possível adicionar um usuário", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                        cleanRegister()
                    End Try
                End If
            Catch ex As Exception
                MsgBox("Não foi possível acessar o banco de dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            End Try
        End If

    End Sub

    Private Sub Cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmbLevel.SelectedIndex = 0
    End Sub
    Private Sub cleanRegister()
        With Me
            .txtUser.Clear()
            .txtPasswd.Clear()
            .cmbLevel.SelectedIndex = 1
            .txtUser.Focus()
        End With
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If sessionLevel = "admin" Then
            If txtUser.Text = String.Empty Then
                MsgBox("Digite um usuário", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                txtUser.Focus()
            Else
                Try
                    Dim resp As MsgBoxResult
                    resp = MsgBox("Tem certeza que deseja excluir o usuário?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo)
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete from users where users = '" & txtUser.Text & "'"
                        rs = db.Execute(sql)
                        MsgBox("Usuário excluido com sucesso", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                        cleanRegister()
                    Else
                        MsgBox("O usuário não foi apagado", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                        cleanRegister()
                    End If
                Catch ex As Exception

                End Try
            End If
        Else
            MsgBox("Você não tem direitos exigidos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End If
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim menuLoad As New Menu
        menuLoad.Show()
        Close()
    End Sub
End Class