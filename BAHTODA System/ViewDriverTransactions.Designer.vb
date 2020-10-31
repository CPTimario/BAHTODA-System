<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewDriverTransactions
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
        Dim NameLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnEditTransaction = New System.Windows.Forms.Button()
        Me.dgvViewTransaction = New System.Windows.Forms.DataGridView()
        Me.TransactionDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequestorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionFeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DriverTransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BAHTODADataSet = New BAHTODASystem.BAHTODADataSet()
        Me.btnAddTransaction = New System.Windows.Forms.Button()
        Me.txtSearchName = New System.Windows.Forms.TextBox()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.DriverTransactionTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.DriverTransactionTableAdapter()
        Me.TableAdapterManager = New BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnViewReport = New System.Windows.Forms.Button()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        NameLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvViewTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DriverTransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(31, 30)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(97, 13)
        NameLabel.TabIndex = 12
        NameLabel.Text = "Requestor's Name:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(32, 57)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(33, 13)
        Label1.TabIndex = 17
        Label1.Text = "From:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(211, 57)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(23, 13)
        Label2.TabIndex = 20
        Label2.Text = "To:"
        '
        'btnBack
        '
        Me.btnBack.AutoSize = True
        Me.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBack.Location = New System.Drawing.Point(605, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(42, 23)
        Me.btnBack.TabIndex = 16
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnEditTransaction
        '
        Me.btnEditTransaction.AutoSize = True
        Me.btnEditTransaction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEditTransaction.Location = New System.Drawing.Point(567, 109)
        Me.btnEditTransaction.Name = "btnEditTransaction"
        Me.btnEditTransaction.Size = New System.Drawing.Size(80, 23)
        Me.btnEditTransaction.TabIndex = 15
        Me.btnEditTransaction.Text = "Approve/Edit"
        Me.btnEditTransaction.UseVisualStyleBackColor = True
        '
        'dgvViewTransaction
        '
        Me.dgvViewTransaction.AllowUserToAddRows = False
        Me.dgvViewTransaction.AllowUserToDeleteRows = False
        Me.dgvViewTransaction.AllowUserToResizeColumns = False
        Me.dgvViewTransaction.AllowUserToResizeRows = False
        Me.dgvViewTransaction.AutoGenerateColumns = False
        Me.dgvViewTransaction.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvViewTransaction.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvViewTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvViewTransaction.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransactionDateDataGridViewTextBoxColumn, Me.TransactionNumberDataGridViewTextBoxColumn, Me.TransactionTypeDataGridViewTextBoxColumn, Me.RequestorDataGridViewTextBoxColumn, Me.TransactionFeeDataGridViewTextBoxColumn, Me.TransactionStatusDataGridViewTextBoxColumn, Me.UserIDDataGridViewTextBoxColumn})
        Me.dgvViewTransaction.DataSource = Me.DriverTransactionBindingSource
        Me.dgvViewTransaction.Location = New System.Drawing.Point(12, 144)
        Me.dgvViewTransaction.MultiSelect = False
        Me.dgvViewTransaction.Name = "dgvViewTransaction"
        Me.dgvViewTransaction.ReadOnly = True
        Me.dgvViewTransaction.RowHeadersVisible = False
        Me.dgvViewTransaction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvViewTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvViewTransaction.Size = New System.Drawing.Size(635, 236)
        Me.dgvViewTransaction.TabIndex = 11
        '
        'TransactionDateDataGridViewTextBoxColumn
        '
        Me.TransactionDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TransactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate"
        Me.TransactionDateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.TransactionDateDataGridViewTextBoxColumn.Name = "TransactionDateDataGridViewTextBoxColumn"
        Me.TransactionDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransactionDateDataGridViewTextBoxColumn.Width = 55
        '
        'TransactionNumberDataGridViewTextBoxColumn
        '
        Me.TransactionNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TransactionNumberDataGridViewTextBoxColumn.DataPropertyName = "TransactionNumber"
        DataGridViewCellStyle2.Format = "00000000"
        Me.TransactionNumberDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.TransactionNumberDataGridViewTextBoxColumn.HeaderText = "Transaction Number"
        Me.TransactionNumberDataGridViewTextBoxColumn.Name = "TransactionNumberDataGridViewTextBoxColumn"
        Me.TransactionNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransactionNumberDataGridViewTextBoxColumn.Width = 117
        '
        'TransactionTypeDataGridViewTextBoxColumn
        '
        Me.TransactionTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TransactionTypeDataGridViewTextBoxColumn.DataPropertyName = "TransactionType"
        Me.TransactionTypeDataGridViewTextBoxColumn.HeaderText = "Transaction Type"
        Me.TransactionTypeDataGridViewTextBoxColumn.Name = "TransactionTypeDataGridViewTextBoxColumn"
        Me.TransactionTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransactionTypeDataGridViewTextBoxColumn.Width = 105
        '
        'RequestorDataGridViewTextBoxColumn
        '
        Me.RequestorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RequestorDataGridViewTextBoxColumn.DataPropertyName = "Requestor"
        Me.RequestorDataGridViewTextBoxColumn.HeaderText = "Requestor"
        Me.RequestorDataGridViewTextBoxColumn.Name = "RequestorDataGridViewTextBoxColumn"
        Me.RequestorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransactionFeeDataGridViewTextBoxColumn
        '
        Me.TransactionFeeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TransactionFeeDataGridViewTextBoxColumn.DataPropertyName = "TransactionFee"
        DataGridViewCellStyle3.Format = "P0.00"
        Me.TransactionFeeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.TransactionFeeDataGridViewTextBoxColumn.HeaderText = "Fee"
        Me.TransactionFeeDataGridViewTextBoxColumn.Name = "TransactionFeeDataGridViewTextBoxColumn"
        Me.TransactionFeeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransactionFeeDataGridViewTextBoxColumn.Width = 50
        '
        'TransactionStatusDataGridViewTextBoxColumn
        '
        Me.TransactionStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TransactionStatusDataGridViewTextBoxColumn.DataPropertyName = "TransactionStatus"
        Me.TransactionStatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.TransactionStatusDataGridViewTextBoxColumn.Name = "TransactionStatusDataGridViewTextBoxColumn"
        Me.TransactionStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransactionStatusDataGridViewTextBoxColumn.Width = 62
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        Me.UserIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserIDDataGridViewTextBoxColumn.Visible = False
        '
        'DriverTransactionBindingSource
        '
        Me.DriverTransactionBindingSource.DataMember = "DriverTransaction"
        Me.DriverTransactionBindingSource.DataSource = Me.BAHTODADataSet
        '
        'BAHTODADataSet
        '
        Me.BAHTODADataSet.DataSetName = "BAHTODADataSet"
        Me.BAHTODADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAddTransaction
        '
        Me.btnAddTransaction.AutoSize = True
        Me.btnAddTransaction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddTransaction.Location = New System.Drawing.Point(500, 109)
        Me.btnAddTransaction.Name = "btnAddTransaction"
        Me.btnAddTransaction.Size = New System.Drawing.Size(61, 23)
        Me.btnAddTransaction.TabIndex = 14
        Me.btnAddTransaction.Text = "Add New"
        Me.btnAddTransaction.UseVisualStyleBackColor = True
        '
        'txtSearchName
        '
        Me.txtSearchName.Location = New System.Drawing.Point(136, 27)
        Me.txtSearchName.Name = "txtSearchName"
        Me.txtSearchName.Size = New System.Drawing.Size(238, 20)
        Me.txtSearchName.TabIndex = 13
        '
        'dtpFromDate
        '
        Me.dtpFromDate.CustomFormat = "MMMM dd, yyyy"
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFromDate.Location = New System.Drawing.Point(71, 53)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(134, 20)
        Me.dtpFromDate.TabIndex = 18
        '
        'dtpToDate
        '
        Me.dtpToDate.CustomFormat = "MMMM dd, yyyy"
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToDate.Location = New System.Drawing.Point(240, 53)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(134, 20)
        Me.dtpToDate.TabIndex = 19
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(31, 109)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(99, 13)
        Me.lblStatus.TabIndex = 22
        Me.lblStatus.Text = "Transaction Status:"
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"All", "Pending", "Finished"})
        Me.cmbStatus.Location = New System.Drawing.Point(136, 106)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(238, 21)
        Me.cmbStatus.TabIndex = 23
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"All", "Boundary", "Installment Pay", "Maintenance"})
        Me.cmbType.Location = New System.Drawing.Point(136, 79)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(238, 21)
        Me.cmbType.TabIndex = 25
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(31, 82)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(93, 13)
        Me.lblType.TabIndex = 24
        Me.lblType.Text = "Transaction Type:"
        '
        'DriverTransactionTableAdapter
        '
        Me.DriverTransactionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DriversTableAdapter = Nothing
        Me.TableAdapterManager.TransactionsTableAdapter = Nothing
        Me.TableAdapterManager.TricyclesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserAccountsTableAdapter = Nothing
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(380, 53)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 74)
        Me.btnSearch.TabIndex = 26
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnViewReport
        '
        Me.btnViewReport.AutoSize = True
        Me.btnViewReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnViewReport.Location = New System.Drawing.Point(291, 386)
        Me.btnViewReport.Name = "btnViewReport"
        Me.btnViewReport.Size = New System.Drawing.Size(73, 23)
        Me.btnViewReport.TabIndex = 27
        Me.btnViewReport.Text = "Print Report"
        Me.btnViewReport.UseVisualStyleBackColor = True
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.Location = New System.Drawing.Point(12, 9)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(114, 13)
        Me.lblClock.TabIndex = 28
        Me.lblClock.Text = "12/31/9999 88:88 AM"
        '
        'timClock
        '
        '
        'ViewDriverTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 421)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.btnViewReport)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.dtpToDate)
        Me.Controls.Add(Me.dtpFromDate)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnEditTransaction)
        Me.Controls.Add(Me.dgvViewTransaction)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.btnAddTransaction)
        Me.Controls.Add(Me.txtSearchName)
        Me.Name = "ViewDriverTransactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewDriverTransactions"
        CType(Me.dgvViewTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DriverTransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnEditTransaction As System.Windows.Forms.Button
    Friend WithEvents dgvViewTransaction As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddTransaction As System.Windows.Forms.Button
    Friend WithEvents txtSearchName As System.Windows.Forms.TextBox
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents BAHTODADataSet As BAHTODASystem.BAHTODADataSet
    Friend WithEvents DriverTransactionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DriverTransactionTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.DriverTransactionTableAdapter
    Friend WithEvents TableAdapterManager As BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager
    Friend WithEvents TransactionDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RequestorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionFeeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnViewReport As System.Windows.Forms.Button
    Friend WithEvents lblClock As System.Windows.Forms.Label
    Friend WithEvents timClock As System.Windows.Forms.Timer
End Class
