Public Class passwordForm
    Private Sub registerBTN_Click(sender As Object, e As EventArgs) Handles registerBTN.Click
        If newpassTB.Text = newconTB.Text Then
            Try
                updates("UPDATE login_db SET  password='" & newpassTB.Text & "' WHERE username='" & usernameTB.Text & " ' ")
                newpassTB.Clear()
                newconTB.Clear()
                usernameTB.Clear()

            Catch ex As Exception
                MsgBox(ex.Message, MessageBoxIcon.Error)
            End Try
            loginForm.Show()
            Me.Hide()

        Else
            MessageBox.Show("Password doesn't match!")
            newpassTB.Clear()
            newconTB.Clear()
            usernameTB.Clear()
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        loginForm.Show()
    End Sub

    Private Sub passwordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class