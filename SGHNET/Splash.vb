Public Class Splash
    Dim t As Integer
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conBanco()
        tmrInicial.Start()
    End Sub

    Private Sub tmrInicial_Tick(sender As Object, e As EventArgs) Handles tmrInicial.Tick
        Dim loginLoad As New Login
        t = t + 1
        If t = 10 Then
            tmrInicial.Stop()
            loginLoad.Show()
            Hide()
        End If
    End Sub

    Private Sub Splash_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    End Sub
End Class