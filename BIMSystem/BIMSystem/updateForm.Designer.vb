<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class updateForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(updateForm))
        Me.EATB = New System.Windows.Forms.ComboBox()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.clearBTN = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PWDCB = New System.Windows.Forms.ComboBox()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STB = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EATB
        '
        Me.EATB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EATB.FormattingEnabled = True
        Me.EATB.Items.AddRange(New Object() {"No Formal Education", "Primary Education", "Secondary Education", "Vocational/Technical Training", "Associate's Degree", "Bachelor's Degree", "Master's Degree", "Doctorate"})
        Me.EATB.Location = New System.Drawing.Point(460, 499)
        Me.EATB.Name = "EATB"
        Me.EATB.Size = New System.Drawing.Size(218, 28)
        Me.EATB.TabIndex = 133
        '
        'PCB
        '
        Me.PCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PCB.FormattingEnabled = True
        Me.PCB.Items.AddRange(New Object() {"Purok 1A", "Purok 1B", "Purok 2", "Purok 3", "Purok 4", "Purok 5A", "Purok 5B", "Purok 6", "Purok 7", "Purok 8", "Purok 9A", "Purok 9B"})
        Me.PCB.Location = New System.Drawing.Point(115, 285)
        Me.PCB.Name = "PCB"
        Me.PCB.Size = New System.Drawing.Size(218, 28)
        Me.PCB.TabIndex = 132
        '
        'GCB
        '
        Me.GCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GCB.FormattingEnabled = True
        Me.GCB.Items.AddRange(New Object() {"Male", "Female"})
        Me.GCB.Location = New System.Drawing.Point(460, 427)
        Me.GCB.Name = "GCB"
        Me.GCB.Size = New System.Drawing.Size(217, 28)
        Me.GCB.TabIndex = 131
        '
        'DISTB
        '
        Me.DISTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DISTB.Location = New System.Drawing.Point(460, 618)
        Me.DISTB.Name = "DISTB"
        Me.DISTB.Size = New System.Drawing.Size(218, 26)
        Me.DISTB.TabIndex = 130
        '
        'BCB
        '
        Me.BCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCB.FormattingEnabled = True
        Me.BCB.Items.AddRange(New Object() {"Own", "Rent", "Other"})
        Me.BCB.Location = New System.Drawing.Point(460, 354)
        Me.BCB.Name = "BCB"
        Me.BCB.Size = New System.Drawing.Size(225, 28)
        Me.BCB.TabIndex = 129
        '
        'HCB
        '
        Me.HCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HCB.FormattingEnabled = True
        Me.HCB.Items.AddRange(New Object() {"Concrete", "Semi-Concrete", "Light Materials"})
        Me.HCB.Location = New System.Drawing.Point(460, 320)
        Me.HCB.Name = "HCB"
        Me.HCB.Size = New System.Drawing.Size(225, 28)
        Me.HCB.TabIndex = 128
        '
        'WCB
        '
        Me.WCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WCB.FormattingEnabled = True
        Me.WCB.Items.AddRange(New Object() {"Nawasa", "Jetmatic", "Deep Well", "Others"})
        Me.WCB.Location = New System.Drawing.Point(460, 286)
        Me.WCB.Name = "WCB"
        Me.WCB.Size = New System.Drawing.Size(225, 28)
        Me.WCB.TabIndex = 127
        '
        'TCB
        '
        Me.TCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCB.FormattingEnabled = True
        Me.TCB.Items.AddRange(New Object() {"Yes", "No"})
        Me.TCB.Location = New System.Drawing.Point(115, 390)
        Me.TCB.Name = "TCB"
        Me.TCB.Size = New System.Drawing.Size(218, 28)
        Me.TCB.TabIndex = 126
        '
        'ECB
        '
        Me.ECB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ECB.FormattingEnabled = True
        Me.ECB.Items.AddRange(New Object() {"Yes", "No"})
        Me.ECB.Location = New System.Drawing.Point(115, 354)
        Me.ECB.Name = "ECB"
        Me.ECB.Size = New System.Drawing.Size(218, 28)
        Me.ECB.TabIndex = 125
        '
        'BPICK
        '
        Me.BPICK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BPICK.Location = New System.Drawing.Point(115, 541)
        Me.BPICK.Name = "BPICK"
        Me.BPICK.Size = New System.Drawing.Size(220, 26)
        Me.BPICK.TabIndex = 124
        '
        'RELTB
        '
        Me.RELTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RELTB.Location = New System.Drawing.Point(460, 575)
        Me.RELTB.Name = "RELTB"
        Me.RELTB.Size = New System.Drawing.Size(218, 26)
        Me.RELTB.TabIndex = 123
        '
        'HTB
        '
        Me.HTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HTB.Location = New System.Drawing.Point(115, 320)
        Me.HTB.Name = "HTB"
        Me.HTB.Size = New System.Drawing.Size(218, 26)
        Me.HTB.TabIndex = 122
        '
        'OCTB
        '
        Me.OCTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OCTB.Location = New System.Drawing.Point(460, 539)
        Me.OCTB.Name = "OCTB"
        Me.OCTB.Size = New System.Drawing.Size(218, 26)
        Me.OCTB.TabIndex = 121
        '
        'PCTB
        '
        Me.PCTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PCTB.Location = New System.Drawing.Point(460, 464)
        Me.PCTB.Name = "PCTB"
        Me.PCTB.Size = New System.Drawing.Size(218, 26)
        Me.PCTB.TabIndex = 120
        '
        'AGETB
        '
        Me.AGETB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AGETB.Location = New System.Drawing.Point(115, 575)
        Me.AGETB.Name = "AGETB"
        Me.AGETB.Size = New System.Drawing.Size(218, 26)
        Me.AGETB.TabIndex = 119
        '
        'SNAMETB
        '
        Me.SNAMETB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SNAMETB.Location = New System.Drawing.Point(115, 503)
        Me.SNAMETB.Name = "SNAMETB"
        Me.SNAMETB.Size = New System.Drawing.Size(220, 26)
        Me.SNAMETB.TabIndex = 118
        '
        'MNAMETB
        '
        Me.MNAMETB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MNAMETB.Location = New System.Drawing.Point(115, 467)
        Me.MNAMETB.Name = "MNAMETB"
        Me.MNAMETB.Size = New System.Drawing.Size(220, 26)
        Me.MNAMETB.TabIndex = 117
        '
        'FNAMETB
        '
        Me.FNAMETB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNAMETB.Location = New System.Drawing.Point(115, 432)
        Me.FNAMETB.Name = "FNAMETB"
        Me.FNAMETB.Size = New System.Drawing.Size(220, 26)
        Me.FNAMETB.TabIndex = 116
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label20.Location = New System.Drawing.Point(382, 618)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(70, 19)
        Me.label20.TabIndex = 115
        Me.label20.Text = "Disability"
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label19.Location = New System.Drawing.Point(64, 618)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(41, 19)
        Me.label19.TabIndex = 114
        Me.label19.Text = "PWD"
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label18.Location = New System.Drawing.Point(392, 578)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(62, 19)
        Me.label18.TabIndex = 113
        Me.label18.Text = "Religion"
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label17.Location = New System.Drawing.Point(378, 543)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(83, 19)
        Me.label17.TabIndex = 112
        Me.label17.Text = "Occupation"
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label16.Location = New System.Drawing.Point(344, 506)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(116, 19)
        Me.label16.TabIndex = 111
        Me.label16.Text = "Education Attain"
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label15.Location = New System.Drawing.Point(333, 470)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(128, 19)
        Me.label15.TabIndex = 110
        Me.label15.Text = "Physical Condition"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.Location = New System.Drawing.Point(405, 436)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(56, 19)
        Me.label14.TabIndex = 109
        Me.label14.Text = "Gender"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.Location = New System.Drawing.Point(64, 579)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(34, 19)
        Me.label13.TabIndex = 108
        Me.label13.Text = "Age"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(38, 542)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(63, 19)
        Me.label12.TabIndex = 107
        Me.label12.Text = "Birthday"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(26, 510)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(78, 19)
        Me.label11.TabIndex = 106
        Me.label11.Text = "Last Name"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(11, 472)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(96, 19)
        Me.label10.TabIndex = 105
        Me.label10.Text = "Middle Name"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(27, 439)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(79, 19)
        Me.label9.TabIndex = 104
        Me.label9.Text = "First Name"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(351, 358)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(103, 19)
        Me.label8.TabIndex = 103
        Me.label8.Text = "Building Made"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(357, 324)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(91, 19)
        Me.label7.TabIndex = 102
        Me.label7.Text = "House Made"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(357, 287)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(95, 19)
        Me.label6.TabIndex = 101
        Me.label6.Text = "Water Source"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(29, 394)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(80, 19)
        Me.label5.TabIndex = 100
        Me.label5.Text = "With Toilet"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(1, 358)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(108, 19)
        Me.label4.TabIndex = 99
        Me.label4.Text = "With Electricity"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(64, 292)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(45, 19)
        Me.label3.TabIndex = 98
        Me.label3.Text = "Purok"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(4, 324)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(105, 19)
        Me.Label21.TabIndex = 97
        Me.Label21.Text = "House Number"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Panel1.Controls.Add(Me.clearBTN)
        Me.Panel1.Controls.Add(Me.Guna2Button4)
        Me.Panel1.Controls.Add(Me.Guna2Button2)
        Me.Panel1.Controls.Add(Me.Guna2Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(714, 50)
        Me.Panel1.TabIndex = 94
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
        Me.clearBTN.Location = New System.Drawing.Point(352, 18)
        Me.clearBTN.Name = "clearBTN"
        Me.clearBTN.Size = New System.Drawing.Size(96, 32)
        Me.clearBTN.TabIndex = 140
        Me.clearBTN.Text = "CLEAR"
        '
        'Guna2Button4
        '
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.FillColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Guna2Button4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button4.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button4.Image = CType(resources.GetObject("Guna2Button4.Image"), System.Drawing.Image)
        Me.Guna2Button4.Location = New System.Drawing.Point(562, 18)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(96, 32)
        Me.Guna2Button4.TabIndex = 139
        Me.Guna2Button4.Text = "UPDATE"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), System.Drawing.Image)
        Me.Guna2Button2.Location = New System.Drawing.Point(460, 18)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(96, 32)
        Me.Guna2Button2.TabIndex = 135
        Me.Guna2Button2.Text = "DELETE"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2Button1.Location = New System.Drawing.Point(664, 0)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(47, 45)
        Me.Guna2Button1.TabIndex = 137
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 30)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "RESIDENT INFORMATION"
        '
        'PWDCB
        '
        Me.PWDCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PWDCB.FormattingEnabled = True
        Me.PWDCB.Items.AddRange(New Object() {"YES", "NO"})
        Me.PWDCB.Location = New System.Drawing.Point(115, 614)
        Me.PWDCB.Name = "PWDCB"
        Me.PWDCB.Size = New System.Drawing.Size(218, 28)
        Me.PWDCB.TabIndex = 134
        '
        'Guna2Button3
        '
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button3.Image = CType(resources.GetObject("Guna2Button3.Image"), System.Drawing.Image)
        Me.Guna2Button3.Location = New System.Drawing.Point(668, 56)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(31, 35)
        Me.Guna2Button3.TabIndex = 138
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(460, 397)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 13)
        Me.TextBox1.TabIndex = 140
        Me.TextBox1.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column15, Me.Column16, Me.Column17, Me.Column18, Me.Column19, Me.Column20})
        Me.DataGridView1.GridColor = System.Drawing.Color.Black
        Me.DataGridView1.Location = New System.Drawing.Point(5, 97)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(706, 163)
        Me.DataGridView1.TabIndex = 139
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID"
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.DataPropertyName = "FName"
        Me.Column9.FillWeight = 270.2703!
        Me.Column9.HeaderText = "First Name"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 76
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.DataPropertyName = "MName"
        Me.Column10.FillWeight = 233.0107!
        Me.Column10.HeaderText = "Middle Name"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 87
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column11.DataPropertyName = "LName"
        Me.Column11.FillWeight = 201.0513!
        Me.Column11.HeaderText = "Last Name"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 77
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column12.DataPropertyName = "Bday"
        Me.Column12.FillWeight = 173.6379!
        Me.Column12.HeaderText = "Birthday"
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 70
        '
        'Column13
        '
        Me.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column13.DataPropertyName = "Age"
        Me.Column13.FillWeight = 150.1241!
        Me.Column13.HeaderText = "Age"
        Me.Column13.Name = "Column13"
        Me.Column13.Width = 51
        '
        'Column14
        '
        Me.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column14.DataPropertyName = "Sex"
        Me.Column14.FillWeight = 129.955!
        Me.Column14.HeaderText = "Gender"
        Me.Column14.Name = "Column14"
        Me.Column14.Width = 67
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.DataPropertyName = "Purok"
        Me.Column2.FillWeight = 112.6549!
        Me.Column2.HeaderText = "Purok"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 60
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.DataPropertyName = "HNo"
        Me.Column3.FillWeight = 97.81573!
        Me.Column3.HeaderText = "House Number"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 95
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.DataPropertyName = "withE"
        Me.Column4.FillWeight = 85.08739!
        Me.Column4.HeaderText = "With Electricity"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 94
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.DataPropertyName = "withT"
        Me.Column5.FillWeight = 74.16964!
        Me.Column5.HeaderText = "With Toilet"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 77
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.DataPropertyName = "WS"
        Me.Column6.FillWeight = 64.80489!
        Me.Column6.HeaderText = "Water Source"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 90
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.DataPropertyName = "HM"
        Me.Column7.FillWeight = 56.77225!
        Me.Column7.HeaderText = "House Made"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 86
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.DataPropertyName = "BM"
        Me.Column8.FillWeight = 49.88226!
        Me.Column8.HeaderText = "Building Made"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 91
        '
        'Column15
        '
        Me.Column15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column15.DataPropertyName = "PC"
        Me.Column15.FillWeight = 43.97234!
        Me.Column15.HeaderText = "Physical Condition"
        Me.Column15.Name = "Column15"
        Me.Column15.Width = 108
        '
        'Column16
        '
        Me.Column16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column16.DataPropertyName = "EA"
        Me.Column16.FillWeight = 38.90308!
        Me.Column16.HeaderText = "Education Attain"
        Me.Column16.Name = "Column16"
        Me.Column16.Width = 101
        '
        'Column17
        '
        Me.Column17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column17.DataPropertyName = "OCC"
        Me.Column17.FillWeight = 34.55491!
        Me.Column17.HeaderText = "Occupation"
        Me.Column17.Name = "Column17"
        Me.Column17.Width = 87
        '
        'Column18
        '
        Me.Column18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column18.DataPropertyName = "Rel"
        Me.Column18.FillWeight = 30.82528!
        Me.Column18.HeaderText = "Religion"
        Me.Column18.Name = "Column18"
        Me.Column18.Width = 70
        '
        'Column19
        '
        Me.Column19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column19.DataPropertyName = "PWD"
        Me.Column19.FillWeight = 27.62616!
        Me.Column19.HeaderText = "PWD"
        Me.Column19.Name = "Column19"
        Me.Column19.Width = 58
        '
        'Column20
        '
        Me.Column20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column20.DataPropertyName = "Dis"
        Me.Column20.FillWeight = 24.88211!
        Me.Column20.HeaderText = "Disability"
        Me.Column20.Name = "Column20"
        Me.Column20.Width = 73
        '
        'STB
        '
        Me.STB.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STB.Location = New System.Drawing.Point(478, 56)
        Me.STB.Name = "STB"
        Me.STB.Size = New System.Drawing.Size(190, 35)
        Me.STB.TabIndex = 141
        '
        'updateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(714, 656)
        Me.ControlBox = False
        Me.Controls.Add(Me.STB)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PWDCB)
        Me.Controls.Add(Me.Guna2Button3)
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
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "updateForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents EATB As ComboBox
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Private WithEvents PWDCB As ComboBox
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents clearBTN As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Private WithEvents STB As TextBox
End Class
