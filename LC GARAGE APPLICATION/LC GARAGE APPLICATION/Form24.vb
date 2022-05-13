Public Class Form24

    Private Sub StockBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LCDatabaseDataSet)

    End Sub

    Private Sub Form24_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LCDatabaseDataSet.stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.LCDatabaseDataSet.stock)

    End Sub
End Class