Public Class Form26

    Private Sub ServiceCalculationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ServiceCalculationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LCDatabaseDataSet)

    End Sub

    Private Sub Form26_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LCDatabaseDataSet.serviceCalculation' table. You can move, or remove it, as needed.
        Me.ServiceCalculationTableAdapter.Fill(Me.LCDatabaseDataSet.serviceCalculation)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim imagebpm As New Bitmap(Me.ServiceCalculationDataGridView.Width, Me.ServiceCalculationDataGridView.Height)
        ServiceCalculationDataGridView.DrawToBitmap(imagebpm, New Rectangle(0, 0, Me.ServiceCalculationDataGridView.Width, Me.ServiceCalculationDataGridView.Height))
        e.Graphics.DrawImage(imagebpm, 0, 0)

    End Sub
End Class