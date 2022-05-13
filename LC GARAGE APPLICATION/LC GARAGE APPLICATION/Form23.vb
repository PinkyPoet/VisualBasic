Public Class Form23

    Private Sub ReturnAssesmentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ReturnAssesmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LCDatabaseDataSet)

    End Sub

    Private Sub Form23_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LCDatabaseDataSet.returnAssesment' table. You can move, or remove it, as needed.
        Me.ReturnAssesmentTableAdapter.Fill(Me.LCDatabaseDataSet.returnAssesment)

    End Sub
End Class