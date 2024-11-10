Public Class registerForm
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Dispose()
        loginForm.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            registerBTN.Enabled = True
        Else
            registerBTN.Enabled = False
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub registerBTN_Click(sender As Object, e As EventArgs) Handles registerBTN.Click
        If IsEmpty(usernameTB) Or IsEmpty(passwordTB) Or IsEmpty(confirmTB) Then
            MessageBox.Show("MISSING INFORMATION!!!")

        Else

            If passwordTB.Text = confirmTB.Text Then
                Try
                    create("INSERT INTO login_db (username,password)  VALUES('" & usernameTB.Text & "','" & passwordTB.Text & "')")
                    usernameTB.Clear()
                    passwordTB.Clear()
                    confirmTB.Clear()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                loginForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Incorrect Password")
                usernameTB.Clear()
                passwordTB.Clear()
                confirmTB.Clear()
                CheckBox1.Checked = False
            End If


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        loginForm.Show()
    End Sub
End Class