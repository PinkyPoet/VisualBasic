Public Class Form14

    Private Sub Form14_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LCDatabaseDataSet.decision' table. You can move, or remove it, as needed.
        Me.DecisionTableAdapter.Fill(Me.LCDatabaseDataSet.decision)

    End Sub
End Class