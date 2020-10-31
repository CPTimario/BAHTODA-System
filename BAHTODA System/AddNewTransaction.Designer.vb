<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewTransaction
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
        Me.TransactionNumberTextBox = New System.Windows.Forms.TextBox()
        Me.TransactionTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.TransactionDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TransactionFeeTextBox = New System.Windows.Forms.TextBox()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.DriverInformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BAHTODADataSet = New BAHTODASystem.BAHTODADataSet()
        Me.TransactionStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.AddTransactionButton = New System.Windows.Forms.Button()
        Me.TransactionsTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.TransactionsTableAdapter()
        Me.TableAdapterManager = New BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager()
        Me.TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pnlAddManual = New System.Windows.Forms.Panel()
        Me.rbManual = New System.Windows.Forms.RadioButton()
        Me.rbImport = New System.Windows.Forms.RadioButton()
        Me.DriverInformationTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.DriverInformationTableAdapter()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        Me.lblClock = New System.Windows.Forms.Label()
        TransactionNumberLabel = New System.Windows.Forms.Label()
        TransactionTypeLabel = New System.Windows.Forms.Label()
        TransactionDateLabel = New System.Windows.Forms.Label()
        TransactionFeeLabel = New System.Windows.Forms.Label()
        UserIDLabel = New System.Windows.Forms.Label()
        TransactionStatusLabel = New System.Windows.Forms.Label()
        CType(Me.DriverInformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAddManual.SuspendLayout()
        Me.SuspendLayout()
        '
        'TransactionNumberLabel
        '
        TransactionNumberLabel.AutoSize = True
        TransactionNumberLabel.Location = New System.Drawing.Point(7, 40)
        TransactionNumberLabel.Name = "TransactionNumberLabel"
        TransactionNumberLabel.Size = New System.Drawing.Size(106, 13)
        TransactionNumberLabel.TabIndex = 0
        TransactionNumberLabel.Text = "Transaction Number:"
        '
        'TransactionTypeLabel
        '
        TransactionTypeLabel.AutoSize = True
        TransactionTypeLabel.Location = New System.Drawing.Point(7, 92)
        TransactionTypeLabel.Name = "TransactionTypeLabel"
        TransactionTypeLabel.Size = New System.Drawing.Size(93, 13)
        TransactionTypeLabel.TabIndex = 2
        TransactionTypeLabel.Text = "Transaction Type:"
        '
        'TransactionDateLabel
        '
        TransactionDateLabel.AutoSize = True
        TransactionDateLabel.Location = New System.Drawing.Point(7, 15)
        TransactionDateLabel.Name = "TransactionDateLabel"
        TransactionDateLabel.Size = New System.Drawing.Size(92, 13)
        TransactionDateLabel.TabIndex = 4
        TransactionDateLabel.Text = "Transaction Date:"
        '
        'TransactionFeeLabel
        '
        TransactionFeeLabel.AutoSize = True
        TransactionFeeLabel.Location = New System.Drawing.Point(7, 119)
        TransactionFeeLabel.Name = "TransactionFeeLabel"
        TransactionFeeLabel.Size = New System.Drawing.Size(87, 13)
        TransactionFeeLabel.TabIndex = 6
        TransactionFeeLabel.Text = "Transaction Fee:"
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Location = New System.Drawing.Point(7, 66)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(38, 13)
        UserIDLabel.TabIndex = 8
        UserIDLabel.Text = "Name:"
        '
        'TransactionStatusLabel
        '
        TransactionStatusLabel.AutoSize = True
        TransactionStatusLabel.Location = New System.Drawing.Point(7, 145)
        TransactionStatusLabel.Name = "TransactionStatusLabel"
        TransactionStatusLabel.Size = New System.Drawing.Size(99, 13)
        TransactionStatusLabel.TabIndex = 10
        TransactionStatusLabel.Text = "Transaction Status:"
        '
        'TransactionNumberTextBox
        '
        Me.TransactionNumberTextBox.Enabled = False
        Me.TransactionNumberTextBox.Location = New System.Drawing.Point(119, 37)
        Me.TransactionNumberTextBox.Name = "TransactionNumberTextBox"
        Me.TransactionNumberTextBox.ReadOnly = True
        Me.TransactionNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TransactionNumberTextBox.TabIndex = 1
        '
        'TransactionTypeComboBox
        '
        Me.TransactionTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TransactionTypeComboBox.FormattingEnabled = True
        Me.TransactionTypeComboBox.Items.AddRange(New Object() {"Boundary", "Installment Pay", "Maintenance"})
        Me.TransactionTypeComboBox.Location = New System.Drawing.Point(119, 89)
        Me.TransactionTypeComboBox.Name = "TransactionTypeComboBox"
        Me.TransactionTypeComboBox.Size = New System.Drawing.Size(200, 21)
        Me.TransactionTypeComboBox.TabIndex = 3
        '
        'TransactionDateDateTimePicker
        '
        Me.TransactionDateDateTimePicker.CustomFormat = "MMMM dd, yyyy     hh:mm tt"
        Me.TransactionDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TransactionDateDateTimePicker.Location = New System.Drawing.Point(119, 11)
        Me.TransactionDateDateTimePicker.Name = "TransactionDateDateTimePicker"
        Me.TransactionDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.TransactionDateDateTimePicker.TabIndex = 5
        '
        'TransactionFeeTextBox
        '
        Me.TransactionFeeTextBox.Enabled = False
        Me.TransactionFeeTextBox.Location = New System.Drawing.Point(119, 116)
        Me.TransactionFeeTextBox.Name = "TransactionFeeTextBox"
        Me.TransactionFeeTextBox.ReadOnly = True
        Me.TransactionFeeTextBox.Size = New System.Drawing.Size(159, 20)
        Me.TransactionFeeTextBox.TabIndex = 7
        '
        'NameComboBox
        '
        Me.NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NameComboBox.DataSource = Me.DriverInformationBindingSource
        Me.NameComboBox.DisplayMember = "Name"
        Me.NameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(119, 63)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(200, 21)
        Me.NameComboBox.TabIndex = 9
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
        'TransactionStatusComboBox
        '
        Me.TransactionStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TransactionStatusComboBox.FormattingEnabled = True
        Me.TransactionStatusComboBox.Items.AddRange(New Object() {"Pending", "Finished"})
        Me.TransactionStatusComboBox.Location = New System.Drawing.Point(119, 142)
        Me.TransactionStatusComboBox.Name = "TransactionStatusComboBox"
        Me.TransactionStatusComboBox.Size = New System.Drawing.Size(200, 21)
        Me.TransactionStatusComboBox.TabIndex = 11
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = True
        Me.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEdit.Location = New System.Drawing.Point(284, 114)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(35, 23)
        Me.btnEdit.TabIndex = 22
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'AddTransactionButton
        '
        Me.AddTransactionButton.Location = New System.Drawing.Point(130, 196)
        Me.AddTransactionButton.Name = "AddTransactionButton"
        Me.AddTransactionButton.Size = New System.Drawing.Size(85, 22)
        Me.AddTransactionButton.TabIndex = 23
        Me.AddTransactionButton.Text = "Add"
        Me.AddTransactionButton.UseVisualStyleBackColor = True
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
        'TransactionsBindingSource
        '
        Me.TransactionsBindingSource.DataMember = "Transactions"
        Me.TransactionsBindingSource.DataSource = Me.BAHTODADataSet
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(352, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 24
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'pnlAddManual
        '
        Me.pnlAddManual.Controls.Add(Me.AddTransactionButton)
        Me.pnlAddManual.Controls.Add(Me.btnEdit)
        Me.pnlAddManual.Controls.Add(TransactionNumberLabel)
        Me.pnlAddManual.Controls.Add(Me.TransactionNumberTextBox)
        Me.pnlAddManual.Controls.Add(TransactionTypeLabel)
        Me.pnlAddManual.Controls.Add(Me.TransactionTypeComboBox)
        Me.pnlAddManual.Controls.Add(TransactionDateLabel)
        Me.pnlAddManual.Controls.Add(Me.TransactionDateDateTimePicker)
        Me.pnlAddManual.Controls.Add(TransactionFeeLabel)
        Me.pnlAddManual.Controls.Add(Me.TransactionFeeTextBox)
        Me.pnlAddManual.Controls.Add(UserIDLabel)
        Me.pnlAddManual.Controls.Add(Me.NameComboBox)
        Me.pnlAddManual.Controls.Add(TransactionStatusLabel)
        Me.pnlAddManual.Controls.Add(Me.TransactionStatusComboBox)
        Me.pnlAddManual.Location = New System.Drawing.Point(49, 109)
        Me.pnlAddManual.Name = "pnlAddManual"
        Me.pnlAddManual.Size = New System.Drawing.Size(332, 232)
        Me.pnlAddManual.TabIndex = 25
        '
        'rbManual
        '
        Me.rbManual.AutoSize = True
        Me.rbManual.Location = New System.Drawing.Point(24, 60)
        Me.rbManual.Name = "rbManual"
        Me.rbManual.Size = New System.Drawing.Size(60, 17)
        Me.rbManual.TabIndex = 26
        Me.rbManual.Text = "Manual"
        Me.rbManual.UseVisualStyleBackColor = True
        '
        'rbImport
        '
        Me.rbImport.AutoSize = True
        Me.rbImport.Location = New System.Drawing.Point(100, 60)
        Me.rbImport.Name = "rbImport"
        Me.rbImport.Size = New System.Drawing.Size(98, 17)
        Me.rbImport.TabIndex = 27
        Me.rbImport.Text = "Import excel file"
        Me.rbImport.UseVisualStyleBackColor = True
        '
        'DriverInformationTableAdapter
        '
        Me.DriverInformationTableAdapter.ClearBeforeFill = True
        '
        'timClock
        '
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
        'AddNewTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 395)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.rbImport)
        Me.Controls.Add(Me.rbManual)
        Me.Controls.Add(Me.pnlAddManual)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "AddNewTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddNewTransaction"
        CType(Me.DriverInformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAddManual.ResumeLayout(False)
        Me.pnlAddManual.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BAHTODADataSet As BAHTODASystem.BAHTODADataSet
    Friend WithEvents TransactionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransactionsTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.TransactionsTableAdapter
    Friend WithEvents TableAdapterManager As BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager
    Friend WithEvents TransactionNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TransactionTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TransactionDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TransactionFeeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TransactionStatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents AddTransactionButton As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents pnlAddManual As System.Windows.Forms.Panel
    Friend WithEvents rbManual As System.Windows.Forms.RadioButton
    Friend WithEvents rbImport As System.Windows.Forms.RadioButton
    Friend WithEvents DriverInformationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DriverInformationTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.DriverInformationTableAdapter
    Friend WithEvents timClock As System.Windows.Forms.Timer
    Friend WithEvents lblClock As System.Windows.Forms.Label
End Class
