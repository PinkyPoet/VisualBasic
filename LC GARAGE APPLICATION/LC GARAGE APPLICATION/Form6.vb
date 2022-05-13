Public Class Form6
    Private Sub BACKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACKToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub STOCKDETAILSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STOCKDETAILSToolStripMenuItem.Click
        switchPanel(Form15)
        Label24.Hide()
    End Sub

    Sub switchPanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()

    End Sub


    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub STAFFDETAILSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STAFFDETAILSToolStripMenuItem.Click
        switchPanel(Form16)
        Label24.Hide()
    End Sub

    Private Sub SERVICECALCULATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SERVICECALCULATIONToolStripMenuItem.Click
        switchPanel(Form17)
        Label24.Hide()
    End Sub

    Private Sub SALARIESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALARIESToolStripMenuItem.Click
        switchPanel(Form18)
        Label24.Hide()
    End Sub

    Private Sub Label25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label25.Click
        Me.Close()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 
        
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) 
        
    End Sub
End Class