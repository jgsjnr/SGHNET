Public Class Menu
    Private Sub btnQuit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Menu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dispose()
        session = False
    End Sub

    Private Sub bntRegister_Click(sender As Object, e As EventArgs) Handles bntRegister.Click
        If sessionLevel = "admin" Then
            Dim registerLoad As New Register
            Close()
            registerLoad.Show()
        Else
            MsgBox("Não possui acesso a essa área", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End If
    End Sub

    Private Sub Menu_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAuth.Text = sessionUser
    End Sub

    Private Sub btnQuit_Click_1(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim loginLoad As New Login
        Dispose()
        loginLoad.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPaciente.Click
        If sessionLevel = "admin" Or sessionLevel = "user" Then
            updateLevel = False
            Dim recordLoad As New Record
            Close()
            recordLoad.Show()
        Else
            MsgBox("Não possui acesso a essa área", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End If
    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        If sessionLevel = "admin" Then
            Dim mainLoad As New Main
            Close()
            mainLoad.Show()
        Else
            MsgBox("Não possui acesso a essa área", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLaudo.Click
        If sessionLevel = "admin" Then
            Dim consultLoad As New Consult
            Close()
            consultLoad.Show()
        Else
            MsgBox("Não possui acesso a essa área", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnMedico.Click
        If sessionLevel = "admin" Then
            Dim doctorLoad As New Doctor
            Close()
            doctorLoad.Show()
        Else
            MsgBox("Não possui acesso a essa área", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnRelat.Click
        Dim searchLoad As New Search
        Close()
        searchLoad.Show()
    End Sub
End Class