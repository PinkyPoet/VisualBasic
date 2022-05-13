<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BACKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STOCKDETAILSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STAFFDETAILSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SERVICECALCULATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALARIESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LCDatabaseDataSet = New LC_GARAGE_APPLICATION.LCDatabaseDataSet()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockTableAdapter = New LC_GARAGE_APPLICATION.LCDatabaseDataSetTableAdapters.stockTableAdapter()
        Me.StaffTableAdapter = New LC_GARAGE_APPLICATION.LCDatabaseDataSetTableAdapters.staffTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BACKToolStripMenuItem, Me.STOCKDETAILSToolStripMenuItem, Me.STAFFDETAILSToolStripMenuItem, Me.SERVICECALCULATIONToolStripMenuItem, Me.SALARIESToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(783, 31)
        Me.MenuStrip1.TabIndex = 1
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
        Me.STOCKDETAILSToolStripMenuItem.Size = New System.Drawing.Size(139, 27)
        Me.STOCKDETAILSToolStripMenuItem.Text = "STOCK DETAILS"
        '
        'STAFFDETAILSToolStripMenuItem
        '
        Me.STAFFDETAILSToolStripMenuItem.Name = "STAFFDETAILSToolStripMenuItem"
        Me.STAFFDETAILSToolStripMenuItem.Size = New System.Drawing.Size(136, 27)
        Me.STAFFDETAILSToolStripMenuItem.Text = "STAFF DETAILS"
        '
        'SERVICECALCULATIONToolStripMenuItem
        '
        Me.SERVICECALCULATIONToolStripMenuItem.Name = "SERVICECALCULATIONToolStripMenuItem"
        Me.SERVICECALCULATIONToolStripMenuItem.Size = New System.Drawing.Size(201, 27)
        Me.SERVICECALCULATIONToolStripMenuItem.Text = "SERVICE CALCULATION"
        '
        'SALARIESToolStripMenuItem
        '
        Me.SALARIESToolStripMenuItem.Name = "SALARIESToolStripMenuItem"
        Me.SALARIESToolStripMenuItem.Size = New System.Drawing.Size(97, 27)
        Me.SALARIESToolStripMenuItem.Text = "SALARIES"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(108, 544)
        Me.Panel1.TabIndex = 2
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "staff"
        Me.StaffBindingSource.DataSource = Me.LCDatabaseDataSet
        '
        'LCDatabaseDataSet
        '
        Me.LCDatabaseDataSet.DataSetName = "LCDatabaseDataSet"
        Me.LCDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(320, 517)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(233, 23)
        Me.Label24.TabIndex = 9
        Me.Label24.Text = "Select from the above Items"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(753, 9)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(18, 19)
        Me.Label25.TabIndex = 19
        Me.Label25.Text = "X"
        '
        'StockBindingSource
        '
        Me.StockBindingSource.DataMember = "stock"
        Me.StockBindingSource.DataSource = Me.LCDatabaseDataSet
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(124, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(633, 470)
        Me.Panel2.TabIndex = 20
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 549)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INVENTORY"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BACKToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents STOCKDETAILSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents STAFFDETAILSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SERVICECALCULATIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALARIESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents LCDatabaseDataSet As LC_GARAGE_APPLICATION.LCDatabaseDataSet
    Friend WithEvents StockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockTableAdapter As LC_GARAGE_APPLICATION.LCDatabaseDataSetTableAdapters.stockTableAdapter
    Friend WithEvents StaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StaffTableAdapter As LC_GARAGE_APPLICATION.LCDatabaseDataSetTableAdapters.staffTableAdapter
    Friend WithEvents Panel2 As Panel
End Class
