Public Class Form25

    Private Sub StaffBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LCDatabaseDataSet)

    End Sub

    Private Sub Form25_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LCDatabaseDataSet.staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.LCDatabaseDataSet.staff)

    End Sub
End Class