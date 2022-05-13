<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form17
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ServiceCalculationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LCDatabaseDataSet = New LC_GARAGE_APPLICATION.LCDatabaseDataSet()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ServiceCalculationTableAdapter = New LC_GARAGE_APPLICATION.LCDatabaseDataSetTableAdapters.serviceCalculationTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        CType(Me.ServiceCalculationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button8)
        Me.Panel3.Controls.Add(Me.Button9)
        Me.Panel3.Controls.Add(Me.Button10)
        Me.Panel3.Location = New System.Drawing.Point(56, 134)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(380, 69)
        Me.Panel3.TabIndex = 49
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(286, 16)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(85, 37)
        Me.Button8.TabIndex = 38
        Me.Button8.Text = "Print"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(101, 16)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(85, 37)
        Me.Button9.TabIndex = 37
        Me.Button9.Text = "Save"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(192, 16)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(85, 37)
        Me.Button10.TabIndex = 36
        Me.Button10.Text = "Clear"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiceCalculationBindingSource, "vehicleCost", True))
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(105, 55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(87, 26)
        Me.TextBox1.TabIndex = 48
        '
        'ServiceCalculationBindingSource
        '
        Me.ServiceCalculationBindingSource.DataMember = "serviceCalculation"
        Me.ServiceCalculationBindingSource.DataSource = Me.LCDatabaseDataSet
        '
        'LCDatabaseDataSet
        '
        Me.LCDatabaseDataSet.DataSetName = "LCDatabaseDataSet"
        Me.LCDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(3, 55)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(93, 19)
        Me.Label21.TabIndex = 47
        Me.Label21.Text = "Vehicle cost:"
        '
        'TextBox15
        '
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiceCalculationBindingSource, "total", True))
        Me.TextBox15.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.Location = New System.Drawing.Point(322, 102)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(110, 26)
        Me.TextBox15.TabIndex = 46
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(219, 104)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 19)
        Me.Label19.TabIndex = 45
        Me.Label19.Text = "Total"
        '
        'TextBox16
        '
        Me.TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiceCalculationBindingSource, "serviceFees", True))
        Me.TextBox16.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(321, 56)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(87, 26)
        Me.TextBox16.TabIndex = 44
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(219, 56)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(95, 19)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "Service Fees:"
        '
        'TextBox17
        '
        Me.TextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiceCalculationBindingSource, "customerID", True))
        Me.TextBox17.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox17.Location = New System.Drawing.Point(321, 7)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(111, 26)
        Me.TextBox17.TabIndex = 42
        '
        'TextBox18
        '
        Me.TextBox18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiceCalculationBindingSource, "staffID", True))
        Me.TextBox18.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox18.Location = New System.Drawing.Point(104, 7)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(91, 26)
        Me.TextBox18.TabIndex = 41
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(219, 9)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 19)
        Me.Label22.TabIndex = 40
        Me.Label22.Text = "Customer ID:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(12, 9)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(63, 19)
        Me.Label23.TabIndex = 39
        Me.Label23.Text = "Staff ID:"
        '
        'ServiceCalculationTableAdapter
        '
        Me.ServiceCalculationTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(113, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 33)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Compute"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(10, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 37)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form17
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 217)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TextBox17)
        Me.Controls.Add(Me.TextBox18)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form17"
        Me.Text = "Form17"
        Me.Panel3.ResumeLayout(False)
        CType(Me.ServiceCalculationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents LCDatabaseDataSet As LC_GARAGE_APPLICATION.LCDatabaseDataSet
    Friend WithEvents ServiceCalculationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ServiceCalculationTableAdapter As LC_GARAGE_APPLICATION.LCDatabaseDataSetTableAdapters.serviceCalculationTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
