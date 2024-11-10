Public Class Loading

    Dim startPoint As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        startPoint += 2
        loadingbar.Value = startPoint

        If loadingbar.Value = 100 Then
            loadingbar.Value = 0
            Me.Hide()
            loginForm.Show()
            Timer1.Stop()

        End If

    End Sub

    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
