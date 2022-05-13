Public Class Form18

    Private Sub Form18_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LCDatabaseDataSet.staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.LCDatabaseDataSet.staff)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox4.Text = Nothing Or TextBox5.Text = Nothing Or TextBox10.Text = Nothing Or TextBox8.Text = Nothing Then
            MsgBox("Please Enter Empty Fields", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            StaffBindingSource.EndEdit()
            StaffTableAdapter.Update(LCDatabaseDataSet.staff)
            MsgBox("Saved Succesfully", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Error Occured", MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        StaffBindingSource.AddNew()
        MsgBox("New Field Added", MsgBoxStyle.Information)
    End Sub
End Class