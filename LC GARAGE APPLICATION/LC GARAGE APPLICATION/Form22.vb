Public Class Form22

    Private Sub DecisionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DecisionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LCDatabaseDataSet)

    End Sub

    Private Sub Form22_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LCDatabaseDataSet.decision' table. You can move, or remove it, as needed.
        Me.DecisionTableAdapter.Fill(Me.LCDatabaseDataSet.decision)

    End Sub
End Class