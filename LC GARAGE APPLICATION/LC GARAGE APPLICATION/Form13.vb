Public Class Form13

    Private Sub Form13_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LCDatabaseDataSet.booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.LCDatabaseDataSet.booking)

    End Sub
End Class