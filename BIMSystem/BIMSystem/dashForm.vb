Imports MySql.Data.MySqlClient
Public Class dashForm
    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub register_Click(sender As Object, e As EventArgs)
        registerForm.Show()
    End Sub

    Private Sub dashForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strcon.Open()

        Dim totalpopulation As String
        Dim total As String
        Dim underage As String
        Dim under As String
        Dim middleage As String
        Dim middle As String
        Dim oldage As String
        Dim old As String

        totalpopulation = "SELECt count(*) FROM resident_info"
        cmd = New MySqlCommand(totalpopulation, strcon)
        total = cmd.ExecuteScalar()
        total_L.Text = total

        underage = "SELECt count(*) FROM resident_info WHERE Age <= '17'"
        cmd = New MySqlCommand(underage, strcon)
        under = cmd.ExecuteScalar()
        under_L.Text = under

        middleage = "SELECt count(*) FROM resident_info WHERE Age >= '18' and age<='60'"
        cmd = New MySqlCommand(middleage, strcon)
        middle = cmd.ExecuteScalar()
        middle_L.Text = middle

        oldage = "SELECt count(*) FROM resident_info WHERE Age >= '61'"
        cmd = New MySqlCommand(oldage, strcon)
        old = cmd.ExecuteScalar()
        old_L.Text = old

        strcon.Close()


    End Sub
End Class