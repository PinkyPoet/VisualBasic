
Imports System.Data.OleDb

Public Class Form3
    ReadOnly con As New OleDbConnection(My.Settings.LCDatabaseConnectionString)

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Me.Close()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Or TextBox3.Text = Nothing Or ComboBox1.Text = Nothing Then
            MsgBox("Please Enter Empty Fields", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using command As New OleDbCommand("SELECT COUNT(*) FROM login WHERE username=@username AND password=@password", con)
            command.Parameters.AddWithValue("@username", OleDbType.VarChar).Value = TextBox1.Text.Trim
            command.Parameters.AddWithValue("@password", OleDbType.VarChar).Value = TextBox2.Text.Trim

            Dim count = Convert.ToInt32(command.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("Username And Password already exists")
                Exit Sub
            End If

        End Using

        Using create As New OleDbCommand("INSERT INTO login([name],[username],[password],[usertype]) VALUES (@name,@username,@password,@usertype)", con)
            create.Parameters.AddWithValue("@name", OleDbType.VarChar).Value = TextBox1.Text.Trim
            create.Parameters.AddWithValue("@username", OleDbType.VarChar).Value = TextBox2.Text.Trim
            create.Parameters.AddWithValue("@password", OleDbType.VarChar).Value = TextBox3.Text.Trim
            create.Parameters.AddWithValue("@usertype", OleDbType.VarChar).Value = ComboBox1.Text.Trim

            If create.ExecuteNonQuery Then
                MsgBox("Account Created", MsgBoxStyle.Information)
                Me.Close()
                Form2.Show()
            Else
                MsgBox("Registration Error")
            End If

            con.Close()

        End Using
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LCDatabaseDataSet.login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.LCDatabaseDataSet.login)
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox3.UseSystemPasswordChar = False
        Else
            TextBox3.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class