Public Class Form19

    Private Sub CUSTOMERSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BOOKINGSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOOKINGSToolStripMenuItem.Click
        switchPanel(Form21)
    End Sub

    Sub switchPanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub DECISIONSYSTEMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DECISIONSYSTEMToolStripMenuItem.Click
        switchPanel(Form22)
    End Sub

    Private Sub RETURNASSESSMENTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RETURNASSESSMENTToolStripMenuItem.Click
        switchPanel(Form23)
    End Sub

    Private Sub BACKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACKToolStripMenuItem.Click
        Form10.Show()
        Me.Hide()
    End Sub
End Class