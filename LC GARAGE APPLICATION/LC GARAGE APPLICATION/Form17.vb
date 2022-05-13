Public Class Form17

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        TextBox1.Clear()
        TextBox15.Clear()
        TextBox16.Clear()
        TextBox17.Clear()
        TextBox18.Clear()
        
    End Sub

    Private Sub Form17_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LCDatabaseDataSet.serviceCalculation' table. You can move, or remove it, as needed.
        Me.ServiceCalculationTableAdapter.Fill(Me.LCDatabaseDataSet.serviceCalculation)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim CostDecimal As Decimal
        CostDecimal = Decimal.Parse(TextBox1.Text, Globalization.NumberStyles.Currency)
        Dim ServiceDecimal As Decimal
        ServiceDecimal = Decimal.Parse(TextBox16.Text, Globalization.NumberStyles.Currency)

        Dim SubtotalDecimal As Decimal
        SubtotalDecimal = CostDecimal + ServiceDecimal
        TextBox15.Text = SubtotalDecimal.ToString("C")
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If TextBox1.Text = Nothing Or TextBox15.Text = Nothing Or TextBox16.Text = Nothing Then
            MsgBox("Please Enter Empty Fields", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            ServiceCalculationBindingSource.EndEdit()
            ServiceCalculationTableAdapter.Update(LCDatabaseDataSet.serviceCalculation)
            MsgBox("Saved Succesfully", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Error Occured", MsgBoxStyle.Information)
        End Try


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ServiceCalculationBindingSource.AddNew()
        MsgBox("Field Created", MsgBoxStyle.Information)
    End Sub
End Class