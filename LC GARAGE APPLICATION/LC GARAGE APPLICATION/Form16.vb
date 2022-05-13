Public Class Form16

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox11.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub

    Private Sub Form16_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LCDatabaseDataSet.staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.LCDatabaseDataSet.staff)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If TextBox11.Text = Nothing Or TextBox12.Text = Nothing Or TextBox14.Text = Nothing Or ComboBox1.Text = Nothing Then
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        StaffBindingSource.AddNew()
        MsgBox("New Staff Field Added", MsgBoxStyle.Information)
    End Sub
End Class