Public Class Login
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Close()
        Dim splashLoad As New Splash
        splashLoad.Close()
        Application.Exit()
    End Sub
    Private Sub btnAccess_Click(sender As Object, e As EventArgs) Handles btnAccess.Click
        Dim menuLoad As New Menu
        If txtUser.Text = String.Empty Or txtPasswd.Text = String.Empty Then
            MsgBox("Usuário e senha não podem estar vazios", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        Else
            Try
                sql = "select * from users where users='" & txtUser.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    If txtUser.Text = CStr(rs.Fields(0).Value) And txtPasswd.Text = CStr(rs.Fields(1).Value) Then
                        sessionLevel = CStr(rs.Fields(2).Value)
                        sessionUser = CStr(rs.Fields(0).Value)
                        session = True
                        menuLoad.Show()
                        Close()
                        CleanLogin()
                    Else
                        MsgBox("Usuário ou senha incorretos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                        CleanLogin()
                    End If
                Else
                    MsgBox("Usuário não encontrado", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                    CleanLogin()
                End If
            Catch ex As Exception
                MsgBox("Não foi possível acessar o banco de dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                CleanLogin()
            End Try
        End If
    End Sub
    Sub CleanLogin()
        Dim loginLoad As New Login
        With loginLoad
            .txtUser.Clear()
            .txtPasswd.Clear()
        End With
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim menuLoad As New Menu
        menuLoad.Close()
    End Sub
End Class


