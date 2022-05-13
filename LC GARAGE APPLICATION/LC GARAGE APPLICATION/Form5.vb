Public Class Form5

    Private Sub CUSTOMERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOOKINGSToolStripMenuItem.Click
        switchPanel(Form12)
        Label1.Hide()
    End Sub

    Sub switchPanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub DECISIONSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUSTOMERSToolStripMenuItem.Click
        switchPanel(Form13)
        Label1.Hide()
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DECISIONSYSTEMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DECISIONSYSTEMToolStripMenuItem.Click
        switchPanel(Form14)
        Label1.Hide()
    End Sub

    Private Sub RETURNASSESSMENTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RETURNASSESSMENTToolStripMenuItem.Click
        switchPanel(Form11)
        Label1.Hide()
    End Sub

    Private Sub BACKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACKToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        Me.Close()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class