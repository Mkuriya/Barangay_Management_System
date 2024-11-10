Imports MySql.Data.MySqlClient

Module connection_DB
    Public Function conn() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;password=;database=bims_db")
    End Function
    Public strcon As MySqlConnection = conn()

    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable


    Public Sub create(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Failed to save the ata", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Information has been save!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub
    'retrieving data sa db'
    Public Sub reload(ByVal sql As String, ByVal DTG As Object)

        Try
            dt = New DataTable
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.datasource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub

    Public Sub updates(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Failed to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data has been updated", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub delete(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Failed to delete the Data in database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data has been deleted in database", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub



    Public allSet As Boolean

    Function IsEmpty(ByVal portion As Control) As Boolean
        Dim ctrl As New Control
        Dim tex As New TextBox
        For Each ctrl In portion.Controls.OfType(Of TextBox)()
            tex = TryCast(ctrl, TextBox)
            If tex.Text = "" Then
                tex.Focus()
                allSet = True
            Else
                allSet = False
            End If
        Next
        For Each ctrl In portion.Controls.OfType(Of ComboBox)()
            Dim combo As New ComboBox
            combo = TryCast(ctrl, ComboBox)
            If combo.Text = "" Then
                combo.Focus()
                allSet = True
            Else
                allSet = False
            End If

        Next
        Return allSet
    End Function


End Module
