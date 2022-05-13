<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BACKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BOOKINGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CUSTOMERSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DECISIONSYSTEMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RETURNASSESSMENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BACKToolStripMenuItem, Me.BOOKINGSToolStripMenuItem, Me.CUSTOMERSToolStripMenuItem, Me.DECISIONSYSTEMToolStripMenuItem, Me.RETURNASSESSMENTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(801, 31)
        Me.MenuStrip1.TabIndex = 0
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
        Me.BOOKINGSToolStripMenuItem.Size = New System.Drawing.Size(108, 27)
        Me.BOOKINGSToolStripMenuItem.Text = "BOOKINGS"
        '
        'CUSTOMERSToolStripMenuItem
        '
        Me.CUSTOMERSToolStripMenuItem.Name = "CUSTOMERSToolStripMenuItem"
        Me.CUSTOMERSToolStripMenuItem.Size = New System.Drawing.Size(120, 27)
        Me.CUSTOMERSToolStripMenuItem.Text = "CUSTOMERS"
        '
        'DECISIONSYSTEMToolStripMenuItem
        '
        Me.DECISIONSYSTEMToolStripMenuItem.Name = "DECISIONSYSTEMToolStripMenuItem"
        Me.DECISIONSYSTEMToolStripMenuItem.Size = New System.Drawing.Size(165, 27)
        Me.DECISIONSYSTEMToolStripMenuItem.Text = "DECISION SYSTEM"
        '
        'RETURNASSESSMENTToolStripMenuItem
        '
        Me.RETURNASSESSMENTToolStripMenuItem.Name = "RETURNASSESSMENTToolStripMenuItem"
        Me.RETURNASSESSMENTToolStripMenuItem.Size = New System.Drawing.Size(196, 27)
        Me.RETURNASSESSMENTToolStripMenuItem.Text = "RETURN ASSESSMENT"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(108, 577)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(297, 571)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Select from the above Items"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(771, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 19)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "X"
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(123, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(666, 515)
        Me.Panel2.TabIndex = 19
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 603)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SERVICE"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BACKToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BOOKINGSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CUSTOMERSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DECISIONSYSTEMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RETURNASSESSMENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As Panel
End Class
