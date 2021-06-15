Public Class Doctor
    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Dim menuLoad As New Menu
        Close()
        menuLoad.Show()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtCrm.Text = String.Empty Or txtNome.Text = String.Empty Then
            MsgBox("O CRM ou Nome não podem estar vazios", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Else
            Try
                sql = "select * from medicos where crm='" & txtCrm.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    MsgBox("Usuário já existe", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    Try
                        sql = "insert into medicos values('" & txtCrm.Text & "','" & txtNome.Text & "','" & diretorio & "')"
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
    Private Sub cleanRegister()
        imgFoto.Load(Application.StartupPath & "\photos\user-add-icon.png")
        Dim doctorLoad As New Doctor
        With doctorLoad
            .txtCrm.Clear()
            .txtNome.Clear()
            .txtCrm.Focus()
        End With
    End Sub

    Private Sub imgFoto_Click(sender As Object, e As EventArgs) Handles imgFoto.Click
        Try
            With OpenFileDialog1
                .Title = "SELECIONE UMA FOTO"
                .InitialDirectory = Application.StartupPath & "\photos"
                .ShowDialog()
                diretorio = .FileName
                imgFoto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If sessionLevel = "admin" Then
            If txtCrm.Text = String.Empty Then
                MsgBox("Digite um CRM", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                txtCrm.Focus()
            Else
                Try
                    Dim resp As MsgBoxResult
                    resp = MsgBox("Tem certeza que deseja excluir o usuário?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo)
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete from medicos where crm = '" & txtCrm.Text & "'"
                        rs = db.Execute(sql)
                        MsgBox("Usuário excluido com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        cleanRegister()
                    Else
                        MsgBox("O usuário não foi apagado", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                        cleanRegister()
                    End If
                Catch ex As Exception
                    MsgBox("O usuário não foi apagado, erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                End Try
            End If
        Else
            MsgBox("Você não tem direitos exigidos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End If
    End Sub
End Class