<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class passwordForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(passwordForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.newconTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.newpassTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.usernameTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.registerBTN = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(416, 69)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(65, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reset Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 23)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "Confirm Password" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 23)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "New Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 23)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Username"
        '
        'newconTB
        '
        Me.newconTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.newconTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.newconTB.DefaultText = ""
        Me.newconTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.newconTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.newconTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.newconTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.newconTB.FillColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.newconTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.newconTB.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newconTB.ForeColor = System.Drawing.Color.Black
        Me.newconTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.newconTB.IconLeft = CType(resources.GetObject("newconTB.IconLeft"), System.Drawing.Image)
        Me.newconTB.IconLeftSize = New System.Drawing.Size(45, 45)
        Me.newconTB.Location = New System.Drawing.Point(14, 300)
        Me.newconTB.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.newconTB.Name = "newconTB"
        Me.newconTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.newconTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.newconTB.PlaceholderText = "Confirm password"
        Me.newconTB.SelectedText = ""
        Me.newconTB.Size = New System.Drawing.Size(391, 48)
        Me.newconTB.TabIndex = 105
        '
        'newpassTB
        '
        Me.newpassTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.newpassTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.newpassTB.DefaultText = ""
        Me.newpassTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.newpassTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.newpassTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.newpassTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.newpassTB.FillColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.newpassTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.newpassTB.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newpassTB.ForeColor = System.Drawing.Color.Black
        Me.newpassTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.newpassTB.IconLeft = CType(resources.GetObject("newpassTB.IconLeft"), System.Drawing.Image)
        Me.newpassTB.IconLeftSize = New System.Drawing.Size(45, 45)
        Me.newpassTB.Location = New System.Drawing.Point(14, 222)
        Me.newpassTB.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.newpassTB.Name = "newpassTB"
        Me.newpassTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.newpassTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.newpassTB.PlaceholderText = "Type your password"
        Me.newpassTB.SelectedText = ""
        Me.newpassTB.Size = New System.Drawing.Size(391, 48)
        Me.newpassTB.TabIndex = 104
        '
        'usernameTB
        '
        Me.usernameTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.usernameTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usernameTB.DefaultText = ""
        Me.usernameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.usernameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.usernameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usernameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usernameTB.FillColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.usernameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usernameTB.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameTB.ForeColor = System.Drawing.Color.Black
        Me.usernameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usernameTB.IconLeft = CType(resources.GetObject("usernameTB.IconLeft"), System.Drawing.Image)
        Me.usernameTB.IconLeftSize = New System.Drawing.Size(45, 45)
        Me.usernameTB.Location = New System.Drawing.Point(14, 122)
        Me.usernameTB.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.usernameTB.Name = "usernameTB"
        Me.usernameTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.usernameTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.usernameTB.PlaceholderText = "Type your username"
        Me.usernameTB.SelectedText = ""
        Me.usernameTB.Size = New System.Drawing.Size(391, 48)
        Me.usernameTB.TabIndex = 103
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 20
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(215, 390)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(190, 45)
        Me.Guna2Button1.TabIndex = 110
        Me.Guna2Button1.Text = "CANCEL"
        '
        'registerBTN
        '
        Me.registerBTN.BackColor = System.Drawing.Color.Transparent
        Me.registerBTN.BorderRadius = 20
        Me.registerBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.registerBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.registerBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.registerBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.registerBTN.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.registerBTN.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerBTN.ForeColor = System.Drawing.Color.White
        Me.registerBTN.Location = New System.Drawing.Point(14, 390)
        Me.registerBTN.Name = "registerBTN"
        Me.registerBTN.Size = New System.Drawing.Size(186, 45)
        Me.registerBTN.TabIndex = 109
        Me.registerBTN.Text = "REGISTER"
        '
        'passwordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(416, 451)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.registerBTN)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.newconTB)
        Me.Controls.Add(Me.newpassTB)
        Me.Controls.Add(Me.usernameTB)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "passwordForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents newconTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents newpassTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents usernameTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents registerBTN As Guna.UI2.WinForms.Guna2Button
End Class
