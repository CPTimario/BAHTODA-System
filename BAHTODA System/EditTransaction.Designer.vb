<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditTransaction
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
        Dim TransactionNumberLabel As System.Windows.Forms.Label
        Dim TransactionTypeLabel As System.Windows.Forms.Label
        Dim TransactionDateLabel As System.Windows.Forms.Label
        Dim TransactionFeeLabel As System.Windows.Forms.Label
        Dim UserIDLabel As System.Windows.Forms.Label
        Dim TransactionStatusLabel As System.Windows.Forms.Label
        Me.btnBack = New System.Windows.Forms.Button()
        Me.TransactionNumberTextBox = New System.Windows.Forms.TextBox()
        Me.TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BAHTODADataSet = New BAHTODASystem.BAHTODADataSet()
        Me.TransactionTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.TransactionDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TransactionFeeTextBox = New System.Windows.Forms.TextBox()
        Me.TransactionStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager()
        Me.TransactionsTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.TransactionsTableAdapter()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.DriversBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DriversTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.DriversTableAdapter()
        Me.BalanceTextBox = New System.Windows.Forms.TextBox()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        Me.btnSave = New System.Windows.Forms.Button()
        TransactionNumberLabel = New System.Windows.Forms.Label()
        TransactionTypeLabel = New System.Windows.Forms.Label()
        TransactionDateLabel = New System.Windows.Forms.Label()
        TransactionFeeLabel = New System.Windows.Forms.Label()
        UserIDLabel = New System.Windows.Forms.Label()
        TransactionStatusLabel = New System.Windows.Forms.Label()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DriversBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TransactionNumberLabel
        '
        TransactionNumberLabel.AutoSize = True
        TransactionNumberLabel.Location = New System.Drawing.Point(34, 129)
        TransactionNumberLabel.Name = "TransactionNumberLabel"
        TransactionNumberLabel.Size = New System.Drawing.Size(106, 13)
        TransactionNumberLabel.TabIndex = 10
        TransactionNumberLabel.Text = "Transaction Number:"
        '
        'TransactionTypeLabel
        '
        TransactionTypeLabel.AutoSize = True
        TransactionTypeLabel.Location = New System.Drawing.Point(34, 155)
        TransactionTypeLabel.Name = "TransactionTypeLabel"
        TransactionTypeLabel.Size = New System.Drawing.Size(93, 13)
        TransactionTypeLabel.TabIndex = 12
        TransactionTypeLabel.Text = "Transaction Type:"
        '
        'TransactionDateLabel
        '
        TransactionDateLabel.AutoSize = True
        TransactionDateLabel.Location = New System.Drawing.Point(34, 104)
        TransactionDateLabel.Name = "TransactionDateLabel"
        TransactionDateLabel.Size = New System.Drawing.Size(92, 13)
        TransactionDateLabel.TabIndex = 14
        TransactionDateLabel.Text = "Transaction Date:"
        '
        'TransactionFeeLabel
        '
        TransactionFeeLabel.AutoSize = True
        TransactionFeeLabel.Location = New System.Drawing.Point(34, 182)
        TransactionFeeLabel.Name = "TransactionFeeLabel"
        TransactionFeeLabel.Size = New System.Drawing.Size(87, 13)
        TransactionFeeLabel.TabIndex = 16
        TransactionFeeLabel.Text = "Transaction Fee:"
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Location = New System.Drawing.Point(34, 77)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(61, 13)
        UserIDLabel.TabIndex = 18
        UserIDLabel.Text = "ID Number:"
        '
        'TransactionStatusLabel
        '
        TransactionStatusLabel.AutoSize = True
        TransactionStatusLabel.Location = New System.Drawing.Point(34, 208)
        TransactionStatusLabel.Name = "TransactionStatusLabel"
        TransactionStatusLabel.Size = New System.Drawing.Size(99, 13)
        TransactionStatusLabel.TabIndex = 18
        TransactionStatusLabel.Text = "Transaction Status:"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(310, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'TransactionNumberTextBox
        '
        Me.TransactionNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "TransactionNumber", True))
        Me.TransactionNumberTextBox.Enabled = False
        Me.TransactionNumberTextBox.Location = New System.Drawing.Point(146, 126)
        Me.TransactionNumberTextBox.Name = "TransactionNumberTextBox"
        Me.TransactionNumberTextBox.ReadOnly = True
        Me.TransactionNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TransactionNumberTextBox.TabIndex = 11
        '
        'TransactionsBindingSource
        '
        Me.TransactionsBindingSource.DataMember = "Transactions"
        Me.TransactionsBindingSource.DataSource = Me.BAHTODADataSet
        '
        'BAHTODADataSet
        '
        Me.BAHTODADataSet.DataSetName = "BAHTODADataSet"
        Me.BAHTODADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransactionTypeComboBox
        '
        Me.TransactionTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "TransactionType", True))
        Me.TransactionTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TransactionTypeComboBox.FormattingEnabled = True
        Me.TransactionTypeComboBox.Items.AddRange(New Object() {"Boundary", "Installment Pay", "Maintenance"})
        Me.TransactionTypeComboBox.Location = New System.Drawing.Point(146, 152)
        Me.TransactionTypeComboBox.Name = "TransactionTypeComboBox"
        Me.TransactionTypeComboBox.Size = New System.Drawing.Size(200, 21)
        Me.TransactionTypeComboBox.TabIndex = 13
        '
        'TransactionDateDateTimePicker
        '
        Me.TransactionDateDateTimePicker.CustomFormat = "MMMM dd, yyyy     hh:mm tt"
        Me.TransactionDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TransactionsBindingSource, "TransactionDate", True))
        Me.TransactionDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TransactionDateDateTimePicker.Location = New System.Drawing.Point(146, 100)
        Me.TransactionDateDateTimePicker.Name = "TransactionDateDateTimePicker"
        Me.TransactionDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.TransactionDateDateTimePicker.TabIndex = 15
        '
        'TransactionFeeTextBox
        '
        Me.TransactionFeeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "TransactionFee", True))
        Me.TransactionFeeTextBox.Enabled = False
        Me.TransactionFeeTextBox.Location = New System.Drawing.Point(146, 179)
        Me.TransactionFeeTextBox.Name = "TransactionFeeTextBox"
        Me.TransactionFeeTextBox.ReadOnly = True
        Me.TransactionFeeTextBox.Size = New System.Drawing.Size(159, 20)
        Me.TransactionFeeTextBox.TabIndex = 17
        '
        'TransactionStatusComboBox
        '
        Me.TransactionStatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "TransactionStatus", True))
        Me.TransactionStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TransactionStatusComboBox.Enabled = False
        Me.TransactionStatusComboBox.FormattingEnabled = True
        Me.TransactionStatusComboBox.Items.AddRange(New Object() {"Pending", "Finished"})
        Me.TransactionStatusComboBox.Location = New System.Drawing.Point(146, 205)
        Me.TransactionStatusComboBox.Name = "TransactionStatusComboBox"
        Me.TransactionStatusComboBox.Size = New System.Drawing.Size(200, 21)
        Me.TransactionStatusComboBox.TabIndex = 19
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "UserID", True))
        Me.lblUserID.Location = New System.Drawing.Point(101, 77)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(38, 13)
        Me.lblUserID.TabIndex = 20
        Me.lblUserID.Text = "userID"
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
        'TransactionsTableAdapter
        '
        Me.TransactionsTableAdapter.ClearBeforeFill = True
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = True
        Me.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEdit.Location = New System.Drawing.Point(311, 177)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(35, 23)
        Me.btnEdit.TabIndex = 21
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnApprove
        '
        Me.btnApprove.Location = New System.Drawing.Point(209, 281)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(75, 23)
        Me.btnApprove.TabIndex = 22
        Me.btnApprove.Text = "Approve"
        Me.btnApprove.UseVisualStyleBackColor = True
        '
        'DriversBindingSource
        '
        Me.DriversBindingSource.DataMember = "Drivers"
        Me.DriversBindingSource.DataSource = Me.BAHTODADataSet
        '
        'DriversTableAdapter
        '
        Me.DriversTableAdapter.ClearBeforeFill = True
        '
        'BalanceTextBox
        '
        Me.BalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriversBindingSource, "Balance", True))
        Me.BalanceTextBox.Enabled = False
        Me.BalanceTextBox.Location = New System.Drawing.Point(146, 232)
        Me.BalanceTextBox.Name = "BalanceTextBox"
        Me.BalanceTextBox.ReadOnly = True
        Me.BalanceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BalanceTextBox.TabIndex = 23
        Me.BalanceTextBox.Visible = False
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Location = New System.Drawing.Point(34, 235)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(102, 13)
        Me.lblBalance.TabIndex = 24
        Me.lblBalance.Text = "Remaining Balance:"
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.Location = New System.Drawing.Point(12, 9)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(114, 13)
        Me.lblClock.TabIndex = 25
        Me.lblClock.Text = "12/31/9999 88:88 AM"
        '
        'timClock
        '
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(128, 281)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'EditTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 337)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.BalanceTextBox)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(TransactionStatusLabel)
        Me.Controls.Add(Me.TransactionStatusComboBox)
        Me.Controls.Add(TransactionNumberLabel)
        Me.Controls.Add(Me.TransactionNumberTextBox)
        Me.Controls.Add(TransactionTypeLabel)
        Me.Controls.Add(Me.TransactionTypeComboBox)
        Me.Controls.Add(TransactionDateLabel)
        Me.Controls.Add(Me.TransactionDateDateTimePicker)
        Me.Controls.Add(TransactionFeeLabel)
        Me.Controls.Add(Me.TransactionFeeTextBox)
        Me.Controls.Add(UserIDLabel)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "EditTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditTransaction"
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DriversBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BAHTODADataSet As BAHTODASystem.BAHTODADataSet
    Friend WithEvents TableAdapterManager As BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents TransactionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransactionsTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.TransactionsTableAdapter
    Friend WithEvents TransactionNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TransactionTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TransactionDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TransactionFeeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TransactionStatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnApprove As System.Windows.Forms.Button
    Friend WithEvents DriversBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DriversTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.DriversTableAdapter
    Friend WithEvents BalanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents lblClock As System.Windows.Forms.Label
    Friend WithEvents timClock As System.Windows.Forms.Timer
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
