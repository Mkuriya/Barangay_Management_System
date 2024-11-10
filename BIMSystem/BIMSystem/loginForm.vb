Imports MySql.Data.MySqlClient

Public Class loginForm

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Dim exitBTN As String
        exitBTN = MsgBox("Are you sure you want to exit?", vbYesNo + vbQuestion)
        If exitBTN = vbYes Then

            Application.Exit()
        End If


    End Sub

    Private Sub loginBTN_Click(sender As Object, e As EventArgs) Handles loginBTN.Click
        Dim conn As New MySqlConnection("DataSource=localhost; database=bims_db; username=root;")
        conn.Open()
        Dim cmd As New MySqlCommand("Select * From login_db WHERE username=@username AND password=@password", conn)
        cmd.Parameters.AddWithValue("username", username.Text.Trim)
        cmd.Parameters.AddWithValue("password", password.Text.Trim)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        If reader.Read Then
            username.Clear()
            password.Clear()
            homeForm.Show()
            Me.Hide()
        Else
            MsgBox("Invalid Username or Password")
            username.Clear()
            password.Clear()
        End If
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        If password.PasswordChar = "*" Then
            password.PasswordChar = ""
        Else
            password.PasswordChar = "*"
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        passwordForm.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        registerForm.Show()
        Me.Hide()
    End Sub
End Class