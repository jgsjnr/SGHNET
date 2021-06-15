Public Class Consult
    Dim consultValues(5) As String
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If rdFebreYes.Checked = True Then
            consultValues(0) = "Sim"
        Else
            If rdFebreNo.Checked = True Then
                consultValues(0) = "Não"
            End If
        End If
        If rdFadigaYes.Checked = True Then
            consultValues(1) = "Sim"
        Else
            If rdFadigaNo.Checked = True Then
                consultValues(1) = "Não"
            End If
        End If
        If rdArYes.Checked = True Then
            consultValues(2) = "Sim"
        Else
            If rdArNo.Checked = True Then
                consultValues(2) = "Não"
            End If
        End If
        If rdDoresYes.Checked = True Then
            consultValues(3) = "Sim"
        Else
            If rdDoresNo.Checked = True Then
                consultValues(3) = "Não"
            End If
        End If
        If rdCoronaYes.Checked = True Then
            consultValues(4) = "Sim"
        Else
            If rdCoronaNo.Checked = True Then
                consultValues(4) = "Não"
            End If
        End If
        Try
            sql = "insert into relat values('" & txtCpf.Text & "'" _
                                            & ",'" & txtCrm.Text & "'" _
                                            & ",'" & consultValues(0) & "'" _
                                            & ",'" & consultValues(1) & "'" _
                                            & ",'" & consultValues(2) & "'" _
                                            & ",'" & consultValues(3) & "'" _
                                            & ",'" & consultValues(4) & "'" _
                                            & ",'" & cmbReceita.Text & "'" _
                                            & ",'" & cmbIntern.Text & "'" _
                                            & ",'" & txtObs.Text & "')"
            rs = db.Execute(sql)
            MsgBox("Adicionado laudo com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            clearConsult()
        Catch ex As Exception
            MsgBox("Não foi possivel adicionar o laudo", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim menuLoad As New Menu
        Close()
        menuLoad.Show()
    End Sub

    Private Sub txtCpf_LostFocus(sender As Object, e As EventArgs) Handles txtCpf.LostFocus
        If txtCpf.Text = String.Empty Then
            MsgBox("Preencha o campo do CPF", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Else
            Try
                sql = "select * from info where cpf='" & txtCpf.Text & "'"
                rs = db.Execute(sql)
                If rs.Fields(22).Value.ToString = String.Empty Then
                    MsgBox("Foto indisponível", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    If rs.EOF = False Then
                        imgFotoPaciente.Load(rs.Fields(21).Value)
                    Else
                        MsgBox("Foto indisponível", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    End If
                End If
            Catch ex As Exception
                MsgBox("Não foi possível acessar o banco de dados", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End Try
        End If

    End Sub

    Private Sub txtCrm_LostFocus(sender As Object, e As EventArgs) Handles txtCrm.LostFocus
        If txtCrm.Text = String.Empty Then
            MsgBox("Preencha o campo do CRM", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Else
            Try
                sql = "select * from medicos where crm='" & txtCrm.Text & "'"
                rs = db.Execute(sql)
                If rs.Fields(2).Value.ToString = String.Empty Then
                    MsgBox("Foto indisponível", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    If rs.EOF = False Then
                        imgFotoMedico.Load(rs.Fields(2).Value)
                    Else
                        MsgBox("Foto indisponível", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    End If
                End If
            Catch ex As Exception
                MsgBox("Não foi possível acessar o banco de dados", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End Try
        End If

    End Sub

    Sub clearConsult()
        With Me
            .txtCpf.Focus()
            .txtCpf.Text = String.Empty
            .txtCrm.Text = String.Empty
            .txtObs.Text = String.Empty
            .cmbIntern.SelectedIndex = 0
            .cmbReceita.SelectedIndex = 0
            .imgFotoMedico.Load(Application.StartupPath & "\photos\admin-line.png")
            .imgFotoPaciente.Load(Application.StartupPath & "\photos\surgical-mask-line.png")
        End With
    End Sub

    Private Sub Consult_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class