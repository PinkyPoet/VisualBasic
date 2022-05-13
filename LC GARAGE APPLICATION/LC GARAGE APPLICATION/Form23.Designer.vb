<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form23
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
        Me.ReturnAssesmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReturnAssesmentTableAdapter = New LC_GARAGE_APPLICATION.LCDatabaseDataSetTableAdapters.returnAssesmentTableAdapter()
        Me.TableAdapterManager = New LC_GARAGE_APPLICATION.LCDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.ReturnAssesmentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.LCDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReturnAssesmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReturnAssesmentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LCDatabaseDataSet
        '
        Me.LCDatabaseDataSet.DataSetName = "LCDatabaseDataSet"
        Me.LCDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReturnAssesmentBindingSource
        '
        Me.ReturnAssesmentBindingSource.DataMember = "returnAssesment"
        Me.ReturnAssesmentBindingSource.DataSource = Me.LCDatabaseDataSet
        '
        'ReturnAssesmentTableAdapter
        '
        Me.ReturnAssesmentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adminloginTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bookingTableAdapter = Nothing
        Me.TableAdapterManager.dbmanagerTableAdapter = Nothing
        Me.TableAdapterManager.decisionTableAdapter = Nothing
        Me.TableAdapterManager.loginTableAdapter = Nothing
        Me.TableAdapterManager.returnAssesmentTableAdapter = Me.ReturnAssesmentTableAdapter
        Me.TableAdapterManager.serviceCalculationTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LC_GARAGE_APPLICATION.LCDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ReturnAssesmentDataGridView
        '
        Me.ReturnAssesmentDataGridView.AutoGenerateColumns = False
        Me.ReturnAssesmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReturnAssesmentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.ReturnAssesmentDataGridView.DataSource = Me.ReturnAssesmentBindingSource
        Me.ReturnAssesmentDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.ReturnAssesmentDataGridView.Name = "ReturnAssesmentDataGridView"
        Me.ReturnAssesmentDataGridView.RowTemplate.Height = 24
        Me.ReturnAssesmentDataGridView.Size = New System.Drawing.Size(345, 209)
        Me.ReturnAssesmentDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "staffID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "staffID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "bookingID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "bookingID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "assessment"
        Me.DataGridViewTextBoxColumn3.HeaderText = "assessment"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Form23
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 284)
        Me.Controls.Add(Me.ReturnAssesmentDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form23"
        Me.Text = "Form23"
        CType(Me.LCDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReturnAssesmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReturnAssesmentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LCDatabaseDataSet As LC_GARAGE_APPLICATION.LCDatabaseDataSet
    Friend WithEvents ReturnAssesmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReturnAssesmentTableAdapter As LC_GARAGE_APPLICATION.LCDatabaseDataSetTableAdapters.returnAssesmentTableAdapter
    Friend WithEvents TableAdapterManager As LC_GARAGE_APPLICATION.LCDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ReturnAssesmentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
