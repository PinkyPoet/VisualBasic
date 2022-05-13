Public Class Form11

    Private Sub Form11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LCDatabaseDataSet.returnAssesment' table. You can move, or remove it, as needed.
        Me.ReturnAssesmentTableAdapter.Fill(Me.LCDatabaseDataSet.returnAssesment)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If TextBox6.Text = Nothing Or TextBox7.Text = Nothing Or TextBox8.Text = Nothing Then
            MsgBox("Please Enter Empty Fields", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Try
            ReturnAssesmentBindingSource.EndEdit()
            ReturnAssesmentTableAdapter.Update(LCDatabaseDataSet.returnAssesment)
            MsgBox("Added Succesfully", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Error Occured", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Radiator")
        ComboBox1.Items.Add("Battery")
        ComboBox1.Items.Add("Alternator")
        ComboBox1.Items.Add("Axle")
        ComboBox1.Items.Add("Brake Rotor")
        ComboBox1.Items.Add("Shock Absorber")
        ComboBox1.Text = "Select from"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ComboBox2.SelectedIndex > -1 Then
            Dim Index2 As Integer
            Index2 = ComboBox2.SelectedIndex
            Dim item2 As Object
            item2 = ComboBox2.SelectedItem
            ListBox2.Items.Add(item2)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ComboBox1.SelectedIndex > -1 Then
            Dim Index1 As Integer
            Index1 = ComboBox1.SelectedIndex
            Dim item1 As Object
            item1 = ComboBox1.SelectedItem
            ListBox1.Items.Add(item1)
        End If

    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click
        ComboBox2.Items.Clear()
        ComboBox2.Items.Add("Yes")
        ComboBox2.Items.Add("No")
        ComboBox2.Text = "Select from"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ReturnAssesmentBindingSource.AddNew()
        MsgBox("New Field Added", MsgBoxStyle.Information)
    End Sub
End Class