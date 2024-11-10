Public Class updateForm
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub updateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            reload("SELECT * FROM resident_info", DataGridView1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If STB.Text = " " Then

            MessageBox.Show("Missing Data!")
        Else
            TryCast(DataGridView1.DataSource, DataTable).DefaultView.RowFilter =
              String.Format("LName like '%" & STB.Text & "%'")
            TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
            PCB.Text = DataGridView1.CurrentRow.Cells(1).Value
            HTB.Text = DataGridView1.CurrentRow.Cells(2).Value
            ECB.Text = DataGridView1.CurrentRow.Cells(3).Value
            TCB.Text = DataGridView1.CurrentRow.Cells(4).Value
            WCB.Text = DataGridView1.CurrentRow.Cells(5).Value
            HCB.Text = DataGridView1.CurrentRow.Cells(6).Value
            BCB.Text = DataGridView1.CurrentRow.Cells(7).Value
            FNAMETB.Text = DataGridView1.CurrentRow.Cells(8).Value
            MNAMETB.Text = DataGridView1.CurrentRow.Cells(9).Value
            SNAMETB.Text = DataGridView1.CurrentRow.Cells(10).Value
            BPICK.Text = DataGridView1.CurrentRow.Cells(11).Value
            AGETB.Text = DataGridView1.CurrentRow.Cells(12).Value
            GCB.Text = DataGridView1.CurrentRow.Cells(13).Value
            PCTB.Text = DataGridView1.CurrentRow.Cells(14).Value
            EATB.Text = DataGridView1.CurrentRow.Cells(15).Value
            OCTB.Text = DataGridView1.CurrentRow.Cells(16).Value
            RELTB.Text = DataGridView1.CurrentRow.Cells(17).Value
            PWDCB.Text = DataGridView1.CurrentRow.Cells(18).Value
            DISTB.Text = DataGridView1.CurrentRow.Cells(19).Value
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        PCB.Text = DataGridView1.CurrentRow.Cells(1).Value
        HTB.Text = DataGridView1.CurrentRow.Cells(2).Value
        ECB.Text = DataGridView1.CurrentRow.Cells(3).Value
        TCB.Text = DataGridView1.CurrentRow.Cells(4).Value
        WCB.Text = DataGridView1.CurrentRow.Cells(5).Value
        HCB.Text = DataGridView1.CurrentRow.Cells(6).Value
        BCB.Text = DataGridView1.CurrentRow.Cells(7).Value
        FNAMETB.Text = DataGridView1.CurrentRow.Cells(8).Value
        MNAMETB.Text = DataGridView1.CurrentRow.Cells(9).Value
        SNAMETB.Text = DataGridView1.CurrentRow.Cells(10).Value
        BPICK.Text = DataGridView1.CurrentRow.Cells(11).Value
        AGETB.Text = DataGridView1.CurrentRow.Cells(12).Value
        GCB.Text = DataGridView1.CurrentRow.Cells(13).Value
        PCTB.Text = DataGridView1.CurrentRow.Cells(14).Value
        EATB.Text = DataGridView1.CurrentRow.Cells(15).Value
        OCTB.Text = DataGridView1.CurrentRow.Cells(16).Value
        RELTB.Text = DataGridView1.CurrentRow.Cells(17).Value
        PWDCB.Text = DataGridView1.CurrentRow.Cells(18).Value
        DISTB.Text = DataGridView1.CurrentRow.Cells(19).Value
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
        BPICK.ResetText()
        STB.Clear()
        Try
            reload("SELECT * FROM resident_info", DataGridView1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try
            delete("DELETE from resident_info WHERE ID='" & TextBox1.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            reload("SELECT * FROM resident_info", DataGridView1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
        BPICK.ResetText()
        STB.Clear()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click

        Try
            updates("UPDATE resident_info SET  Purok='" & PCB.Text & "'
            , HNo='" & HTB.Text & "'
            , withE='" & ECB.Text & "',
            withT='" & TCB.Text & "',
            WS='" & WCB.Text & "',
            HM= '" & HCB.Text & "',
            BM='" & BCB.Text & "',
            FName = '" & FNAMETB.Text & "',
            MName= '" & MNAMETB.Text & "',
            LName = '" & SNAMETB.Text & "',
            Bday = '" & BPICK.Value.ToString("yyyy-M-d") & "',
            Age = '" & AGETB.Text & "',
            Sex = '" & GCB.Text & "',
            PC = '" & PCTB.Text & "',
            EA = '" & EATB.Text & "',
            OCC = '" & OCTB.Text & "',
            Rel = '" & RELTB.Text & "',
            PWD = '" & PWDCB.Text & "',
            Dis = '" & DISTB.Text & "' WHERE ID = '" & TextBox1.Text & " ' ")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            reload("SELECT * FROM resident_info", DataGridView1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
        BPICK.ResetText()
        STB.Clear()
    End Sub

    Private Sub showBTN_Click(sender As Object, e As EventArgs)
        If IsEmpty(Me) Then

            MessageBox.Show("Missing Data!")
        Else
            MessageBox.Show("Show")

        End If
    End Sub

    Private Sub STB_TextChanged(sender As Object, e As EventArgs) Handles STB.TextChanged
        TryCast(DataGridView1.DataSource, DataTable).DefaultView.RowFilter =
          String.Format("LName like '%" & STB.Text & "%'")
        '   TryCast(DataGridView1.DataSource, DataTable).DefaultView.RowFilter =
        '  String.Format("FName like '%" & STB.Text & "%'")
    End Sub
End Class