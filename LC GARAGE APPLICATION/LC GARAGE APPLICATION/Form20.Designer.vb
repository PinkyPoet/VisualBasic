<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form20
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BACKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STOCKDETAILSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STAFFDETAILSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SERVICECALCULATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Location = New System.Drawing.Point(0, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(108, 577)
        Me.Panel1.TabIndex = 22
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BACKToolStripMenuItem, Me.STOCKDETAILSToolStripMenuItem, Me.STAFFDETAILSToolStripMenuItem, Me.SERVICECALCULATIONToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(801, 31)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BACKToolStripMenuItem
        '
        Me.BACKToolStripMenuItem.Name = "BACKToolStripMenuItem"
        Me.BACKToolStripMenuItem.Size = New System.Drawing.Size(31, 27)
        Me.BACKToolStripMenuItem.Text = "<"
        '
        'STOCKDETAILSToolStripMenuItem
        '
        Me.STOCKDETAILSToolStripMenuItem.Name = "STOCKDETAILSToolStripMenuItem"
        Me.STOCKDETAILSToolStripMenuItem.Size = New System.Drawing.Size(99, 27)
        Me.STOCKDETAILSToolStripMenuItem.Text = "STOCK DB"
        '
        'STAFFDETAILSToolStripMenuItem
        '
        Me.STAFFDETAILSToolStripMenuItem.Name = "STAFFDETAILSToolStripMenuItem"
        Me.STAFFDETAILSToolStripMenuItem.Size = New System.Drawing.Size(96, 27)
        Me.STAFFDETAILSToolStripMenuItem.Text = "STAFF DB"
        '
        'SERVICECALCULATIONToolStripMenuItem
        '
        Me.SERVICECALCULATIONToolStripMenuItem.Name = "SERVICECALCULATIONToolStripMenuItem"
        Me.SERVICECALCULATIONToolStripMenuItem.Size = New System.Drawing.Size(228, 27)
        Me.SERVICECALCULATIONToolStripMenuItem.Text = "SERVICE CALCULATION DB"
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(114, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(666, 515)
        Me.Panel2.TabIndex = 24
        '
        'Form20
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 603)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form20"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form20"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BACKToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents STOCKDETAILSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents STAFFDETAILSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SERVICECALCULATIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
