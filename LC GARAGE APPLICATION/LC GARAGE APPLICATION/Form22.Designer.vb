<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form22
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
        Me.LCDatabaseDataSet = New LC_GARAGE_APPLICATION.LCDatabaseDataSet()
        Me.DecisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DecisionTableAdapter = New LC_GARAGE_APPLICATION.LCDatabaseDataSetTableAdapters.decisionTableAdapter()
        Me.TableAdapterManager = New LC_GARAGE_APPLICATION.LCDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.DecisionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.LCDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecisionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LCDatabaseDataSet
        '
        Me.LCDatabaseDataSet.DataSetName = "LCDatabaseDataSet"
        Me.LCDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DecisionBindingSource
        '
        Me.DecisionBindingSource.DataMember = "decision"
        Me.DecisionBindingSource.DataSource = Me.LCDatabaseDataSet
        '
        'DecisionTableAdapter
        '
        Me.DecisionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adminloginTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bookingTableAdapter = Nothing
        Me.TableAdapterManager.dbmanagerTableAdapter = Nothing
        Me.TableAdapterManager.decisionTableAdapter = Me.DecisionTableAdapter
        Me.TableAdapterManager.loginTableAdapter = Nothing
        Me.TableAdapterManager.returnAssesmentTableAdapter = Nothing
        Me.TableAdapterManager.serviceCalculationTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LC_GARAGE_APPLICATION.LCDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DecisionDataGridView
        '
        Me.DecisionDataGridView.AutoGenerateColumns = False
        Me.DecisionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DecisionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DecisionDataGridView.DataSource = Me.DecisionBindingSource
        Me.DecisionDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.DecisionDataGridView.Name = "DecisionDataGridView"
        Me.DecisionDataGridView.RowTemplate.Height = 24
        Me.DecisionDataGridView.Size = New System.Drawing.Size(343, 217)
        Me.DecisionDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "sortOfProblems"
        Me.DataGridViewTextBoxColumn1.HeaderText = "sortOfProblems"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "details"
        Me.DataGridViewTextBoxColumn2.HeaderText = "details"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "mechanic"
        Me.DataGridViewTextBoxColumn3.HeaderText = "mechanic"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Form22
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 293)
        Me.Controls.Add(Me.DecisionDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form22"
        Me.Text = "Form22"
        CType(Me.LCDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecisionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LCDatabaseDataSet As LC_GARAGE_APPLICATION.LCDatabaseDataSet
    Friend WithEvents DecisionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DecisionTableAdapter As LC_GARAGE_APPLICATION.LCDatabaseDataSetTableAdapters.decisionTableAdapter
    Friend WithEvents TableAdapterManager As LC_GARAGE_APPLICATION.LCDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DecisionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
