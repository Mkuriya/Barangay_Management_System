
Public Class homeForm

    Private Sub homeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dashboard As New dashForm()
        dashboard.TopLevel = False
        dashboard.WindowState = FormWindowState.Maximized
        dashboard.Visible = True
        displayPanel.Controls.Add(dashboard)
        dashboard.BringToFront()
        dashboard.Show()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim logoutBTN As String
        logoutBTN = MsgBox("Are you sure you want to log-out?", vbYesNo + vbQuestion)
        If logoutBTN = vbYes Then
            Me.Hide()
            loginForm.Show()

        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim dashboard As New dashForm()
        dashboard.TopLevel = False
        dashboard.WindowState = FormWindowState.Maximized
        dashboard.Visible = True
        displayPanel.Controls.Add(dashboard)
        dashboard.BringToFront()
        dashboard.Show()

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim list As New ressForm()
        list.TopLevel = False
        list.WindowState = FormWindowState.Maximized
        list.Visible = True
        displayPanel.Controls.Add(list)
        list.BringToFront()
        list.Show()

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click

        Dim addResident As New addForm()
        addResident.TopLevel = False
        addResident.WindowState = FormWindowState.Maximized
        addResident.Visible = True
        displayPanel.Controls.Add(addResident)
        addResident.BringToFront()
        addResident.Show()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub displayPanel_Paint(sender As Object, e As PaintEventArgs) Handles displayPanel.Paint

    End Sub
End Class