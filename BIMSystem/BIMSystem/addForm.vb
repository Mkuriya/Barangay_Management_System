Imports MySql.Data.MySqlClient



Public Class addForm

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            addBTN.Enabled = True
        Else
            addBTN.Enabled = False
        End If

    End Sub

    Private Sub clearBTN_Click(sender As Object, e As EventArgs) Handles clearBTN.Click
        PCB.Text = " "
        HTB.Text = " "
        ECB.Text = " "
        TCB.Text = " "
        WCB.Text = " "
        HCB.Text = " "
        BCB.Text = " "
        FNAMETB.Text = " "
        MNAMETB.Text = " "
        SNAMETB.Text = " "
        AGETB.Text = " "
        GCB.Text = " "
        PCTB.Text = " "
        EATB.Text = " "
        OCTB.Text = " "
        RELTB.Text = " "
        PWDCB.Text = " "
        DISTB.Text = " "
        CheckBox1.Checked = False


    End Sub

    Private Sub updateBTN_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub addBTN_Click(sender As Object, e As EventArgs) Handles addBTN.Click
        If PCB.Text = "" Or HTB.Text = "" Or ECB.Text = "" Or TCB.Text = "" Or WCB.Text = "" Or
            HCB.Text = "" Or BCB.Text = "" Or FNAMETB.Text = "" Or MNAMETB.Text = "" Or SNAMETB.Text = "" Or
            AGETB.Text = "" Or GCB.Text = "" Or PCTB.Text = "" Or EATB.Text = "" Or OCTB.Text = "" Or
            RELTB.Text = "" Or PWDCB.Text = "" Or DISTB.Text = "" Then
            MessageBox.Show("MISSING INFORMATION!!!")

        Else
            Try
                create("INSERT INTO `resident_info`(`Purok`, `HNo`, `withE`, `withT`, `WS`, `HM`, `BM`, `FName`, `MName`, `LName`, `Bday`, `Age`, `Sex`, `PC`, `EA`, `OCC`, `Rel`, `PWD`, `Dis`) VALUES 
('" & PCB.Text & "','" & HTB.Text & "','" & ECB.Text & "','" & TCB.Text & "','" & WCB.Text & "','" & HCB.Text & "','" & BCB.Text & "',
'" & FNAMETB.Text & "','" & MNAMETB.Text & "','" & SNAMETB.Text & "','" & BPICK.Value.ToString("yyyy-M-d") & "','" & AGETB.Text & "','" & GCB.Text & "',
'" & PCTB.Text & "','" & EATB.Text & "','" & OCTB.Text & "','" & RELTB.Text & "','" & PWDCB.Text & "','" & DISTB.Text & "')")

                PCB.Text = ""
                HTB.Text = ""
                ECB.Text = ""
                TCB.Text = ""
                WCB.Text = ""
                HCB.Text = ""
                BCB.Text = ""
                FNAMETB.Text = ""
                MNAMETB.Text = ""
                SNAMETB.Text = ""
                AGETB.Text = ""
                GCB.Text = ""
                PCTB.Text = ""
                EATB.Text = ""
                OCTB.Text = ""
                RELTB.Text = ""
                PWDCB.Text = ""
                DISTB.Text = ""
                BPICK.ResetText()
                CheckBox1.Checked = False
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


        End If
    End Sub

End Class