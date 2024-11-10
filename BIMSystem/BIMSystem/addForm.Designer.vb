<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.addBTN = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clearBTN = New Guna.UI2.WinForms.Guna2Button()
        Me.PCB = New System.Windows.Forms.ComboBox()
        Me.GCB = New System.Windows.Forms.ComboBox()
        Me.DISTB = New System.Windows.Forms.TextBox()
        Me.BCB = New System.Windows.Forms.ComboBox()
        Me.HCB = New System.Windows.Forms.ComboBox()
        Me.WCB = New System.Windows.Forms.ComboBox()
        Me.TCB = New System.Windows.Forms.ComboBox()
        Me.ECB = New System.Windows.Forms.ComboBox()
        Me.BPICK = New System.Windows.Forms.DateTimePicker()
        Me.RELTB = New System.Windows.Forms.TextBox()
        Me.HTB = New System.Windows.Forms.TextBox()
        Me.OCTB = New System.Windows.Forms.TextBox()
        Me.PCTB = New System.Windows.Forms.TextBox()
        Me.AGETB = New System.Windows.Forms.TextBox()
        Me.SNAMETB = New System.Windows.Forms.TextBox()
        Me.MNAMETB = New System.Windows.Forms.TextBox()
        Me.FNAMETB = New System.Windows.Forms.TextBox()
        Me.label20 = New System.Windows.Forms.Label()
        Me.label19 = New System.Windows.Forms.Label()
        Me.label18 = New System.Windows.Forms.Label()
        Me.label17 = New System.Windows.Forms.Label()
        Me.label16 = New System.Windows.Forms.Label()
        Me.label15 = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.EATB = New System.Windows.Forms.ComboBox()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.PWDCB = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Panel1.Controls.Add(Me.addBTN)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.clearBTN)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(711, 50)
        Me.Panel1.TabIndex = 2
        '
        'addBTN
        '
        Me.addBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addBTN.Enabled = False
        Me.addBTN.FillColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.addBTN.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBTN.ForeColor = System.Drawing.Color.Black
        Me.addBTN.Image = CType(resources.GetObject("addBTN.Image"), System.Drawing.Image)
        Me.addBTN.Location = New System.Drawing.Point(503, 22)
        Me.addBTN.Name = "addBTN"
        Me.addBTN.Size = New System.Drawing.Size(96, 32)
        Me.addBTN.TabIndex = 8
        Me.addBTN.Text = "ADD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ADD RESIDENT"
        '
        'clearBTN
        '
        Me.clearBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.clearBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.clearBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.clearBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.clearBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.clearBTN.FillColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.clearBTN.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBTN.ForeColor = System.Drawing.Color.Black
        Me.clearBTN.Image = CType(resources.GetObject("clearBTN.Image"), System.Drawing.Image)
        Me.clearBTN.ImageSize = New System.Drawing.Size(30, 30)
        Me.clearBTN.Location = New System.Drawing.Point(605, 22)
        Me.clearBTN.Name = "clearBTN"
        Me.clearBTN.Size = New System.Drawing.Size(96, 32)
        Me.clearBTN.TabIndex = 6
        Me.clearBTN.Text = "CLEAR"
        '
        'PCB
        '
        Me.PCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PCB.FormattingEnabled = True
        Me.PCB.Items.AddRange(New Object() {"Purok 1A", "Purok 1B", "Purok 2", "Purok 3", "Purok 4", "Purok 5A", "Purok 5B", "Purok 6", "Purok 7", "Purok 8", "Purok 9A", "Purok 9B"})
        Me.PCB.Location = New System.Drawing.Point(121, 61)
        Me.PCB.Name = "PCB"
        Me.PCB.Size = New System.Drawing.Size(218, 28)
        Me.PCB.TabIndex = 90
        '
        'GCB
        '
        Me.GCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GCB.FormattingEnabled = True
        Me.GCB.Items.AddRange(New Object() {"Male", "Female"})
        Me.GCB.Location = New System.Drawing.Point(481, 234)
        Me.GCB.Name = "GCB"
        Me.GCB.Size = New System.Drawing.Size(217, 28)
        Me.GCB.TabIndex = 89
        '
        'DISTB
        '
        Me.DISTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DISTB.Location = New System.Drawing.Point(121, 472)
        Me.DISTB.Name = "DISTB"
        Me.DISTB.Size = New System.Drawing.Size(218, 26)
        Me.DISTB.TabIndex = 88
        '
        'BCB
        '
        Me.BCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCB.FormattingEnabled = True
        Me.BCB.Items.AddRange(New Object() {"Own", "Rent", "Other"})
        Me.BCB.Location = New System.Drawing.Point(468, 135)
        Me.BCB.Name = "BCB"
        Me.BCB.Size = New System.Drawing.Size(225, 28)
        Me.BCB.TabIndex = 82
        '
        'HCB
        '
        Me.HCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HCB.FormattingEnabled = True
        Me.HCB.Items.AddRange(New Object() {"Concrete", "Semi-Concrete", "Light Materials"})
        Me.HCB.Location = New System.Drawing.Point(468, 101)
        Me.HCB.Name = "HCB"
        Me.HCB.Size = New System.Drawing.Size(225, 28)
        Me.HCB.TabIndex = 81
        '
        'WCB
        '
        Me.WCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WCB.FormattingEnabled = True
        Me.WCB.Items.AddRange(New Object() {"Nawasa", "Jetmatic", "Deep Well", "Others"})
        Me.WCB.Location = New System.Drawing.Point(468, 67)
        Me.WCB.Name = "WCB"
        Me.WCB.Size = New System.Drawing.Size(225, 28)
        Me.WCB.TabIndex = 80
        '
        'TCB
        '
        Me.TCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCB.FormattingEnabled = True
        Me.TCB.Items.AddRange(New Object() {"Yes", "No"})
        Me.TCB.Location = New System.Drawing.Point(121, 166)
        Me.TCB.Name = "TCB"
        Me.TCB.Size = New System.Drawing.Size(218, 28)
        Me.TCB.TabIndex = 79
        '
        'ECB
        '
        Me.ECB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ECB.FormattingEnabled = True
        Me.ECB.Items.AddRange(New Object() {"Yes", "No"})
        Me.ECB.Location = New System.Drawing.Point(121, 130)
        Me.ECB.Name = "ECB"
        Me.ECB.Size = New System.Drawing.Size(218, 28)
        Me.ECB.TabIndex = 78
        '
        'BPICK
        '
        Me.BPICK.CustomFormat = ""
        Me.BPICK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BPICK.Location = New System.Drawing.Point(121, 344)
        Me.BPICK.Name = "BPICK"
        Me.BPICK.Size = New System.Drawing.Size(220, 26)
        Me.BPICK.TabIndex = 77
        '
        'RELTB
        '
        Me.RELTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RELTB.Location = New System.Drawing.Point(481, 382)
        Me.RELTB.Name = "RELTB"
        Me.RELTB.Size = New System.Drawing.Size(218, 26)
        Me.RELTB.TabIndex = 76
        '
        'HTB
        '
        Me.HTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HTB.Location = New System.Drawing.Point(121, 96)
        Me.HTB.Name = "HTB"
        Me.HTB.Size = New System.Drawing.Size(218, 26)
        Me.HTB.TabIndex = 75
        '
        'OCTB
        '
        Me.OCTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OCTB.Location = New System.Drawing.Point(481, 346)
        Me.OCTB.Name = "OCTB"
        Me.OCTB.Size = New System.Drawing.Size(218, 26)
        Me.OCTB.TabIndex = 74
        '
        'PCTB
        '
        Me.PCTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PCTB.Location = New System.Drawing.Point(481, 271)
        Me.PCTB.Name = "PCTB"
        Me.PCTB.Size = New System.Drawing.Size(218, 26)
        Me.PCTB.TabIndex = 72
        '
        'AGETB
        '
        Me.AGETB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AGETB.Location = New System.Drawing.Point(121, 378)
        Me.AGETB.Name = "AGETB"
        Me.AGETB.Size = New System.Drawing.Size(218, 26)
        Me.AGETB.TabIndex = 71
        '
        'SNAMETB
        '
        Me.SNAMETB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SNAMETB.Location = New System.Drawing.Point(121, 306)
        Me.SNAMETB.Name = "SNAMETB"
        Me.SNAMETB.Size = New System.Drawing.Size(220, 26)
        Me.SNAMETB.TabIndex = 70
        '
        'MNAMETB
        '
        Me.MNAMETB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MNAMETB.Location = New System.Drawing.Point(121, 270)
        Me.MNAMETB.Name = "MNAMETB"
        Me.MNAMETB.Size = New System.Drawing.Size(220, 26)
        Me.MNAMETB.TabIndex = 69
        '
        'FNAMETB
        '
        Me.FNAMETB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNAMETB.Location = New System.Drawing.Point(121, 235)
        Me.FNAMETB.Name = "FNAMETB"
        Me.FNAMETB.Size = New System.Drawing.Size(220, 26)
        Me.FNAMETB.TabIndex = 68
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label20.Location = New System.Drawing.Point(30, 472)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(70, 19)
        Me.label20.TabIndex = 67
        Me.label20.Text = "Disability"
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label19.Location = New System.Drawing.Point(59, 442)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(41, 19)
        Me.label19.TabIndex = 66
        Me.label19.Text = "PWD"
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label18.Location = New System.Drawing.Point(413, 385)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(62, 19)
        Me.label18.TabIndex = 65
        Me.label18.Text = "Religion"
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label17.Location = New System.Drawing.Point(399, 350)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(83, 19)
        Me.label17.TabIndex = 64
        Me.label17.Text = "Occupation"
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label16.Location = New System.Drawing.Point(365, 313)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(116, 19)
        Me.label16.TabIndex = 63
        Me.label16.Text = "Education Attain"
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label15.Location = New System.Drawing.Point(354, 277)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(128, 19)
        Me.label15.TabIndex = 62
        Me.label15.Text = "Physical Condition"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.Location = New System.Drawing.Point(426, 243)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(56, 19)
        Me.label14.TabIndex = 61
        Me.label14.Text = "Gender"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.Location = New System.Drawing.Point(59, 382)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(34, 19)
        Me.label13.TabIndex = 60
        Me.label13.Text = "Age"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(33, 345)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(63, 19)
        Me.label12.TabIndex = 59
        Me.label12.Text = "Birthday"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(21, 313)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(78, 19)
        Me.label11.TabIndex = 58
        Me.label11.Text = "Last Name"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(6, 275)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(96, 19)
        Me.label10.TabIndex = 57
        Me.label10.Text = "Middle Name"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(22, 242)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(79, 19)
        Me.label9.TabIndex = 56
        Me.label9.Text = "First Name"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(359, 139)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(103, 19)
        Me.label8.TabIndex = 55
        Me.label8.Text = "Building Made"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(369, 102)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(91, 19)
        Me.label7.TabIndex = 54
        Me.label7.Text = "House Made"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(365, 68)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(95, 19)
        Me.label6.TabIndex = 53
        Me.label6.Text = "Water Source"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(35, 170)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(80, 19)
        Me.label5.TabIndex = 52
        Me.label5.Text = "With Toilet"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(7, 134)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(108, 19)
        Me.label4.TabIndex = 51
        Me.label4.Text = "With Electricity"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(70, 68)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(45, 19)
        Me.label3.TabIndex = 50
        Me.label3.Text = "Purok"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(10, 100)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(105, 19)
        Me.Label21.TabIndex = 49
        Me.Label21.Text = "House Number"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(-16, 218)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(827, 10)
        Me.Panel4.TabIndex = 47
        '
        'EATB
        '
        Me.EATB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EATB.FormattingEnabled = True
        Me.EATB.Items.AddRange(New Object() {"No Formal Education", "Primary Education", "Secondary Education", "Vocational/Technical Training", "Associates Degree", "Bachelors Degree", "Master's Degree", "Doctorate"})
        Me.EATB.Location = New System.Drawing.Point(481, 306)
        Me.EATB.Name = "EATB"
        Me.EATB.Size = New System.Drawing.Size(218, 28)
        Me.EATB.TabIndex = 91
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.panel3.Location = New System.Drawing.Point(-12, 414)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(827, 10)
        Me.panel3.TabIndex = 48
        '
        'PWDCB
        '
        Me.PWDCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PWDCB.FormattingEnabled = True
        Me.PWDCB.Items.AddRange(New Object() {"YES", "NO"})
        Me.PWDCB.Location = New System.Drawing.Point(121, 438)
        Me.PWDCB.Name = "PWDCB"
        Me.PWDCB.Size = New System.Drawing.Size(218, 28)
        Me.PWDCB.TabIndex = 92
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Centaur", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(365, 451)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(330, 31)
        Me.CheckBox1.TabIndex = 93
        Me.CheckBox1.Text = "I agree to the terms and condition"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'addForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(711, 514)
        Me.ControlBox = False
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.PWDCB)
        Me.Controls.Add(Me.EATB)
        Me.Controls.Add(Me.PCB)
        Me.Controls.Add(Me.GCB)
        Me.Controls.Add(Me.DISTB)
        Me.Controls.Add(Me.BCB)
        Me.Controls.Add(Me.HCB)
        Me.Controls.Add(Me.WCB)
        Me.Controls.Add(Me.TCB)
        Me.Controls.Add(Me.ECB)
        Me.Controls.Add(Me.BPICK)
        Me.Controls.Add(Me.RELTB)
        Me.Controls.Add(Me.HTB)
        Me.Controls.Add(Me.OCTB)
        Me.Controls.Add(Me.PCTB)
        Me.Controls.Add(Me.AGETB)
        Me.Controls.Add(Me.SNAMETB)
        Me.Controls.Add(Me.MNAMETB)
        Me.Controls.Add(Me.FNAMETB)
        Me.Controls.Add(Me.label20)
        Me.Controls.Add(Me.label19)
        Me.Controls.Add(Me.label18)
        Me.Controls.Add(Me.label17)
        Me.Controls.Add(Me.label16)
        Me.Controls.Add(Me.label15)
        Me.Controls.Add(Me.label14)
        Me.Controls.Add(Me.label13)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "addForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents addBTN As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents clearBTN As Guna.UI2.WinForms.Guna2Button
    Private WithEvents PCB As ComboBox
    Private WithEvents GCB As ComboBox
    Private WithEvents DISTB As TextBox
    Private WithEvents BCB As ComboBox
    Private WithEvents HCB As ComboBox
    Private WithEvents WCB As ComboBox
    Private WithEvents TCB As ComboBox
    Private WithEvents ECB As ComboBox
    Private WithEvents BPICK As DateTimePicker
    Private WithEvents RELTB As TextBox
    Private WithEvents HTB As TextBox
    Private WithEvents OCTB As TextBox
    Private WithEvents PCTB As TextBox
    Private WithEvents AGETB As TextBox
    Private WithEvents SNAMETB As TextBox
    Private WithEvents MNAMETB As TextBox
    Private WithEvents FNAMETB As TextBox
    Private WithEvents label20 As Label
    Private WithEvents label19 As Label
    Private WithEvents label18 As Label
    Private WithEvents label17 As Label
    Private WithEvents label16 As Label
    Private WithEvents label15 As Label
    Private WithEvents label14 As Label
    Private WithEvents label13 As Label
    Private WithEvents label12 As Label
    Private WithEvents label11 As Label
    Private WithEvents label10 As Label
    Private WithEvents label9 As Label
    Private WithEvents label8 As Label
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents Label21 As Label
    Private WithEvents Panel4 As Panel
    Private WithEvents EATB As ComboBox
    Private WithEvents panel3 As Panel
    Private WithEvents PWDCB As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
