<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.Transaction = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Logout = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DriverInformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BAHTODADataSet = New BAHTODASystem.BAHTODADataSet()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DriverInformationTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.DriverInformationTableAdapter()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        Me.DriverTransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DriverTransactionTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.DriverTransactionTableAdapter()
        Me.TableAdapterManager = New BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager()
        Me.dgvViewTransaction = New System.Windows.Forms.DataGridView()
        Me.TransactionDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequestorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionFeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lblBalanceRemain = New System.Windows.Forms.Label()
        CType(Me.DriverInformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DriverTransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvViewTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.Blue
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.ForeColor = System.Drawing.Color.White
        Me.AddButton.Location = New System.Drawing.Point(370, 529)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(159, 52)
        Me.AddButton.TabIndex = 4
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'Transaction
        '
        Me.Transaction.AutoSize = True
        Me.Transaction.BackColor = System.Drawing.Color.Yellow
        Me.Transaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Transaction.ForeColor = System.Drawing.Color.Black
        Me.Transaction.Location = New System.Drawing.Point(251, 256)
        Me.Transaction.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Transaction.Name = "Transaction"
        Me.Transaction.Size = New System.Drawing.Size(403, 37)
        Me.Transaction.TabIndex = 5
        Me.Transaction.Text = "PENDING TRANSACTION"
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Honeydew
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Green
        Me.lblDate.Location = New System.Drawing.Point(549, 13)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(225, 28)
        Me.lblDate.TabIndex = 7
        Me.lblDate.Text = "12/31/9999 88:88 AM"
        '
        'Logout
        '
        Me.Logout.BackColor = System.Drawing.Color.DarkRed
        Me.Logout.ForeColor = System.Drawing.Color.White
        Me.Logout.Location = New System.Drawing.Point(782, 13)
        Me.Logout.Margin = New System.Windows.Forms.Padding(4)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(100, 28)
        Me.Logout.TabIndex = 8
        Me.Logout.Text = "Logout"
        Me.Logout.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(32, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(32, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "License"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(32, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(163, 25)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "License Validity"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(412, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 25)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Body Number"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriverInformationBindingSource, "Name", True))
        Me.Label11.Location = New System.Drawing.Point(123, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 16)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Label11"
        '
        'DriverInformationBindingSource
        '
        Me.DriverInformationBindingSource.DataMember = "DriverInformation"
        Me.DriverInformationBindingSource.DataSource = Me.BAHTODADataSet
        '
        'BAHTODADataSet
        '
        Me.BAHTODADataSet.DataSetName = "BAHTODADataSet"
        Me.BAHTODADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriverInformationBindingSource, "License", True))
        Me.Label15.Location = New System.Drawing.Point(230, 151)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 16)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Label15"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriverInformationBindingSource, "LicenseValidity", True))
        Me.Label16.Location = New System.Drawing.Point(230, 197)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 16)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Label16"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriverInformationBindingSource, "BodyNumber", True))
        Me.Label17.Location = New System.Drawing.Point(582, 75)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 16)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Label17"
        '
        'DriverInformationTableAdapter
        '
        Me.DriverInformationTableAdapter.ClearBeforeFill = True
        '
        'timClock
        '
        '
        'DriverTransactionBindingSource
        '
        Me.DriverTransactionBindingSource.DataMember = "DriverTransaction"
        Me.DriverTransactionBindingSource.DataSource = Me.BAHTODADataSet
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvViewTransaction.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvViewTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvViewTransaction.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransactionDateDataGridViewTextBoxColumn, Me.TransactionNumberDataGridViewTextBoxColumn, Me.TransactionTypeDataGridViewTextBoxColumn, Me.RequestorDataGridViewTextBoxColumn, Me.TransactionFeeDataGridViewTextBoxColumn, Me.TransactionStatusDataGridViewTextBoxColumn, Me.UserIDDataGridViewTextBoxColumn})
        Me.dgvViewTransaction.DataSource = Me.DriverTransactionBindingSource
        Me.dgvViewTransaction.Location = New System.Drawing.Point(12, 306)
        Me.dgvViewTransaction.MultiSelect = False
        Me.dgvViewTransaction.Name = "dgvViewTransaction"
        Me.dgvViewTransaction.ReadOnly = True
        Me.dgvViewTransaction.RowHeadersVisible = False
        Me.dgvViewTransaction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvViewTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvViewTransaction.Size = New System.Drawing.Size(878, 216)
        Me.dgvViewTransaction.TabIndex = 24
        '
        'TransactionDateDataGridViewTextBoxColumn
        '
        Me.TransactionDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TransactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate"
        Me.TransactionDateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.TransactionDateDataGridViewTextBoxColumn.Name = "TransactionDateDataGridViewTextBoxColumn"
        Me.TransactionDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransactionNumberDataGridViewTextBoxColumn
        '
        Me.TransactionNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TransactionNumberDataGridViewTextBoxColumn.DataPropertyName = "TransactionNumber"
        DataGridViewCellStyle2.Format = "00000000"
        Me.TransactionNumberDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.TransactionNumberDataGridViewTextBoxColumn.HeaderText = "Transaction Number"
        Me.TransactionNumberDataGridViewTextBoxColumn.Name = "TransactionNumberDataGridViewTextBoxColumn"
        Me.TransactionNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransactionTypeDataGridViewTextBoxColumn
        '
        Me.TransactionTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TransactionTypeDataGridViewTextBoxColumn.DataPropertyName = "TransactionType"
        Me.TransactionTypeDataGridViewTextBoxColumn.HeaderText = "Transaction Type"
        Me.TransactionTypeDataGridViewTextBoxColumn.Name = "TransactionTypeDataGridViewTextBoxColumn"
        Me.TransactionTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RequestorDataGridViewTextBoxColumn
        '
        Me.RequestorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RequestorDataGridViewTextBoxColumn.DataPropertyName = "Requestor"
        Me.RequestorDataGridViewTextBoxColumn.HeaderText = "Requestor"
        Me.RequestorDataGridViewTextBoxColumn.Name = "RequestorDataGridViewTextBoxColumn"
        Me.RequestorDataGridViewTextBoxColumn.ReadOnly = True
        Me.RequestorDataGridViewTextBoxColumn.Visible = False
        '
        'TransactionFeeDataGridViewTextBoxColumn
        '
        Me.TransactionFeeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TransactionFeeDataGridViewTextBoxColumn.DataPropertyName = "TransactionFee"
        DataGridViewCellStyle3.Format = "P0.00"
        Me.TransactionFeeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.TransactionFeeDataGridViewTextBoxColumn.HeaderText = "Fee"
        Me.TransactionFeeDataGridViewTextBoxColumn.Name = "TransactionFeeDataGridViewTextBoxColumn"
        Me.TransactionFeeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransactionStatusDataGridViewTextBoxColumn
        '
        Me.TransactionStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TransactionStatusDataGridViewTextBoxColumn.DataPropertyName = "TransactionStatus"
        Me.TransactionStatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.TransactionStatusDataGridViewTextBoxColumn.Name = "TransactionStatusDataGridViewTextBoxColumn"
        Me.TransactionStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        Me.UserIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserIDDataGridViewTextBoxColumn.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(32, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Age"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriverInformationBindingSource, "Age", True))
        Me.Label14.Location = New System.Drawing.Point(123, 114)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 16)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Label14"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.ForeColor = System.Drawing.Color.White
        Me.lblBalance.Location = New System.Drawing.Point(412, 114)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(198, 25)
        Me.lblBalance.TabIndex = 25
        Me.lblBalance.Text = "Remaining Balance"
        '
        'lblBalanceRemain
        '
        Me.lblBalanceRemain.AutoSize = True
        Me.lblBalanceRemain.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriverInformationBindingSource, "Balance", True))
        Me.lblBalanceRemain.Location = New System.Drawing.Point(628, 121)
        Me.lblBalanceRemain.Name = "lblBalanceRemain"
        Me.lblBalanceRemain.Size = New System.Drawing.Size(49, 16)
        Me.lblBalanceRemain.TabIndex = 26
        Me.lblBalanceRemain.Text = "Label1"
        '
        'UserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(902, 632)
        Me.Controls.Add(Me.lblBalanceRemain)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.dgvViewTransaction)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Transaction)
        Me.Controls.Add(Me.AddButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UserForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserForm"
        CType(Me.DriverInformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DriverTransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvViewTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents Transaction As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Logout As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents BAHTODADataSet As BAHTODASystem.BAHTODADataSet
    Friend WithEvents DriverInformationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DriverInformationTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.DriverInformationTableAdapter
    Friend WithEvents timClock As System.Windows.Forms.Timer
    Friend WithEvents DriverTransactionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DriverTransactionTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.DriverTransactionTableAdapter
    Friend WithEvents TableAdapterManager As BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvViewTransaction As System.Windows.Forms.DataGridView
    Friend WithEvents TransactionDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RequestorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionFeeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents lblBalanceRemain As System.Windows.Forms.Label

End Class
