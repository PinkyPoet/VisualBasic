Public Class Form20

    Private Sub BACKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACKToolStripMenuItem.Click
        Form10.Show()
        Me.Hide()
    End Sub

    Private Sub STOCKDETAILSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STOCKDETAILSToolStripMenuItem.Click
        switchPanel(Form24)
    End Sub

    Sub switchPanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub STAFFDETAILSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STAFFDETAILSToolStripMenuItem.Click
        switchPanel(Form25)
    End Sub

    Private Sub SERVICECALCULATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SERVICECALCULATIONToolStripMenuItem.Click
        switchPanel(Form26)
    End Sub
End Class