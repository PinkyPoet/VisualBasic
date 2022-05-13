Public Class Form21

    Private Sub BookingBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BookingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LCDatabaseDataSet)

    End Sub

    Private Sub Form21_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LCDatabaseDataSet.booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.LCDatabaseDataSet.booking)

    End Sub
End Class