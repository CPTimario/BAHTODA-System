<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportExcel
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvExcelData = New System.Windows.Forms.DataGridView()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.TransactionsTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.TransactionsTableAdapter()
        Me.TableAdapterManager = New BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager()
        Me.BAHTODADataSet = New BAHTODASystem.BAHTODADataSet()
        Me.TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvExcelData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvExcelData
        '
        Me.dgvExcelData.AllowUserToAddRows = False
        Me.dgvExcelData.AllowUserToDeleteRows = False
        Me.dgvExcelData.AllowUserToResizeColumns = False
        Me.dgvExcelData.AllowUserToResizeRows = False
        Me.dgvExcelData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvExcelData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvExcelData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvExcelData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvExcelData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvExcelData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExcelData.Location = New System.Drawing.Point(12, 68)
        Me.dgvExcelData.MultiSelect = False
        Me.dgvExcelData.Name = "dgvExcelData"
        Me.dgvExcelData.ReadOnly = True
        Me.dgvExcelData.RowHeadersVisible = False
        Me.dgvExcelData.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgvExcelData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExcelData.Size = New System.Drawing.Size(579, 303)
        Me.dgvExcelData.TabIndex = 6
        '
        'btnBrowse
        '
        Me.btnBrowse.AutoSize = True
        Me.btnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBrowse.Location = New System.Drawing.Point(12, 39)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(52, 23)
        Me.btnBrowse.TabIndex = 10
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.AutoSize = True
        Me.btnExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnExport.Location = New System.Drawing.Point(246, 377)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(102, 23)
        Me.btnExport.TabIndex = 12
        Me.btnExport.Text = "Export to Databse"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'TransactionsTableAdapter
        '
        Me.TransactionsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DriversTableAdapter = Nothing
        Me.TableAdapterManager.TransactionsTableAdapter = Me.TransactionsTableAdapter
        Me.TableAdapterManager.TricyclesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserAccountsTableAdapter = Nothing
        '
        'BAHTODADataSet
        '
        Me.BAHTODADataSet.DataSetName = "BAHTODADataSet"
        Me.BAHTODADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransactionsBindingSource
        '
        Me.TransactionsBindingSource.DataMember = "Transactions"
        Me.TransactionsBindingSource.DataSource = Me.BAHTODADataSet
        '
        'btnBack
        '
        Me.btnBack.AutoSize = True
        Me.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBack.Location = New System.Drawing.Point(549, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(42, 23)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.Location = New System.Drawing.Point(9, 9)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(114, 13)
        Me.lblClock.TabIndex = 14
        Me.lblClock.Text = "12/31/9999 88:88 AM"
        '
        'timClock
        '
        '
        'ImportExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 430)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.dgvExcelData)
        Me.Name = "ImportExcel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ImportExcel"
        CType(Me.dgvExcelData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvExcelData As System.Windows.Forms.DataGridView
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents BAHTODADataSet As BAHTODASystem.BAHTODADataSet
    Friend WithEvents TransactionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransactionsTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.TransactionsTableAdapter
    Friend WithEvents TableAdapterManager As BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblClock As System.Windows.Forms.Label
    Friend WithEvents timClock As System.Windows.Forms.Timer
End Class
