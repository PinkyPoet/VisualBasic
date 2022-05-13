﻿Imports System.Data.OleDb
Imports System.Data

Public Class Form2

    ReadOnly con As New OleDbConnection(My.Settings.LCDatabaseConnectionString)

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        TextBox1.Clear()
        TextBox2.Clear()
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Then
            MsgBox("Please Enter Credentials", MsgBoxStyle.Exclamation)
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
                Me.Hide()
                Form4.Show()
            Else
                MessageBox.Show("Invalid Password or Username")
            End If

            TextBox1.Clear()
            TextBox2.Clear()

        End Using
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        TextBox1.Clear()
        TextBox2.Clear()
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub
End Class