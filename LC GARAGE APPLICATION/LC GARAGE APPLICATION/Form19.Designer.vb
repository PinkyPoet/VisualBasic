<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form19
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BACKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BOOKINGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DECISIONSYSTEMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RETURNASSESSMENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BACKToolStripMenuItem, Me.BOOKINGSToolStripMenuItem, Me.DECISIONSYSTEMToolStripMenuItem, Me.RETURNASSESSMENTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(801, 31)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BACKToolStripMenuItem
        '
        Me.BACKToolStripMenuItem.Name = "BACKToolStripMenuItem"
        Me.BACKToolStripMenuItem.Size = New System.Drawing.Size(31, 27)
        Me.BACKToolStripMenuItem.Text = "<"
        '
        'BOOKINGSToolStripMenuItem
        '
        Me.BOOKINGSToolStripMenuItem.Name = "BOOKINGSToolStripMenuItem"
        Me.BOOKINGSToolStripMenuItem.Size = New System.Drawing.Size(135, 27)
        Me.BOOKINGSToolStripMenuItem.Text = "BOOKINGS DB"
        '
        'DECISIONSYSTEMToolStripMenuItem
        '
        Me.DECISIONSYSTEMToolStripMenuItem.Name = "DECISIONSYSTEMToolStripMenuItem"
        Me.DECISIONSYSTEMToolStripMenuItem.Size = New System.Drawing.Size(192, 27)
        Me.DECISIONSYSTEMToolStripMenuItem.Text = "DECISION SYSTEM DB"
        '
        'RETURNASSESSMENTToolStripMenuItem
        '
        Me.RETURNASSESSMENTToolStripMenuItem.Name = "RETURNASSESSMENTToolStripMenuItem"
        Me.RETURNASSESSMENTToolStripMenuItem.Size = New System.Drawing.Size(223, 27)
        Me.RETURNASSESSMENTToolStripMenuItem.Text = "RETURN ASSESSMENT DB"
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(123, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(666, 515)
        Me.Panel2.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Location = New System.Drawing.Point(0, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(108, 577)
        Me.Panel1.TabIndex = 21
        '
        'Form19
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 603)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form19"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form19"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BACKToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BOOKINGSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DECISIONSYSTEMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RETURNASSESSMENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
