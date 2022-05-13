Public Class Form15

    Private Sub StockBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LCDatabaseDataSet)

    End Sub

    Private Sub Form15_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LCDatabaseDataSet.stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.LCDatabaseDataSet.stock)

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox19.Clear()
        TextBox20.Clear()
        TextBox21.Clear()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If TextBox2.Text = Nothing Or TextBox3.Text = Nothing Or TextBox21.Text = Nothing Then
            MsgBox("Please Enter Empty Fields", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            StockBindingSource.EndEdit()
            StockTableAdapter.Update(LCDatabaseDataSet.stock)
            MsgBox("Saved Succesfully", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Error Occured", MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        On Error GoTo saveErr
        StockBindingSource.EndEdit()
        StockTableAdapter.Update(LCDatabaseDataSet.stock)
saveErr:
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MessageBox.Show("Do you want to Delete this record?", "Message", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            StockBindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        StockBindingSource.AddNew()
        MsgBox("New Field Added", MsgBoxStyle.Information)
    End Sub
End Class