Public Class Form12

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox2.Text = Nothing Or TextBox3.Text = Nothing Or TextBox1.Text = Nothing Then
            MsgBox("Please Enter Empty Fields", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            BookingBindingSource.EndEdit()
            BookingTableAdapter.Update(LCDatabaseDataSet.booking)
            MsgBox("Added Succesfully", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Error Occured", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LCDatabaseDataSet.booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.LCDatabaseDataSet.booking)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox1.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        BookingBindingSource.AddNew()
        MsgBox("New Field Added", MsgBoxStyle.Information)
    End Sub
End Class