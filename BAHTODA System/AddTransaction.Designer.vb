<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTransactions
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
        Me.TransactionFeeTextBox = New System.Windows.Forms.TextBox()
        Me.TransactionType = New System.Windows.Forms.ComboBox()
        Me.AddTransactionButton = New System.Windows.Forms.Button()
        Me.TransactionsTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.TransactionsTableAdapter()
        Me.TableAdapterManager = New BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager()
        Me.CancelTransactionButton = New System.Windows.Forms.Button()
        Me.TransactionDate = New System.Windows.Forms.Label()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        Me.lblTransNum = New System.Windows.Forms.Label()
        Me.TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BAHTODADataSet = New BAHTODASystem.BAHTODADataSet()
        Me.btnEdit = New System.Windows.Forms.Button()
        TransactionNumberLabel = New System.Windows.Forms.Label()
        TransactionTypeLabel = New System.Windows.Forms.Label()
        TransactionDateLabel = New System.Windows.Forms.Label()
        TransactionFeeLabel = New System.Windows.Forms.Label()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TransactionNumberLabel
        '
        TransactionNumberLabel.AutoSize = True
        TransactionNumberLabel.Location = New System.Drawing.Point(51, 101)
        TransactionNumberLabel.Name = "TransactionNumberLabel"
        TransactionNumberLabel.Size = New System.Drawing.Size(106, 13)
        TransactionNumberLabel.TabIndex = 0
        TransactionNumberLabel.Text = "Transaction Number:"
        '
        'TransactionTypeLabel
        '
        TransactionTypeLabel.AutoSize = True
        TransactionTypeLabel.Location = New System.Drawing.Point(51, 127)
        TransactionTypeLabel.Name = "TransactionTypeLabel"
        TransactionTypeLabel.Size = New System.Drawing.Size(93, 13)
        TransactionTypeLabel.TabIndex = 2
        TransactionTypeLabel.Text = "Transaction Type:"
        '
        'TransactionDateLabel
        '
        TransactionDateLabel.AutoSize = True
        TransactionDateLabel.Location = New System.Drawing.Point(52, 75)
        TransactionDateLabel.Name = "TransactionDateLabel"
        TransactionDateLabel.Size = New System.Drawing.Size(92, 13)
        TransactionDateLabel.TabIndex = 4
        TransactionDateLabel.Text = "Transaction Date:"
        '
        'TransactionFeeLabel
        '
        TransactionFeeLabel.AutoSize = True
        TransactionFeeLabel.Location = New System.Drawing.Point(51, 153)
        TransactionFeeLabel.Name = "TransactionFeeLabel"
        TransactionFeeLabel.Size = New System.Drawing.Size(87, 13)
        TransactionFeeLabel.TabIndex = 6
        TransactionFeeLabel.Text = "Transaction Fee:"
        '
        'TransactionFeeTextBox
        '
        Me.TransactionFeeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "TransactionFee", True))
        Me.TransactionFeeTextBox.Enabled = False
        Me.TransactionFeeTextBox.Location = New System.Drawing.Point(163, 150)
        Me.TransactionFeeTextBox.Name = "TransactionFeeTextBox"
        Me.TransactionFeeTextBox.ReadOnly = True
        Me.TransactionFeeTextBox.Size = New System.Drawing.Size(159, 20)
        Me.TransactionFeeTextBox.TabIndex = 1
        '
        'TransactionType
        '
        Me.TransactionType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "TransactionType", True))
        Me.TransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TransactionType.FormattingEnabled = True
        Me.TransactionType.Items.AddRange(New Object() {"Boundary", "Installment Pay", "Maintenance"})
        Me.TransactionType.Location = New System.Drawing.Point(163, 123)
        Me.TransactionType.Name = "TransactionType"
        Me.TransactionType.Size = New System.Drawing.Size(200, 21)
        Me.TransactionType.TabIndex = 0
        '
        'AddTransactionButton
        '
        Me.AddTransactionButton.Location = New System.Drawing.Point(100, 200)
        Me.AddTransactionButton.Name = "AddTransactionButton"
        Me.AddTransactionButton.Size = New System.Drawing.Size(85, 22)
        Me.AddTransactionButton.TabIndex = 2
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
        'CancelTransactionButton
        '
        Me.CancelTransactionButton.Location = New System.Drawing.Point(233, 200)
        Me.CancelTransactionButton.Name = "CancelTransactionButton"
        Me.CancelTransactionButton.Size = New System.Drawing.Size(85, 22)
        Me.CancelTransactionButton.TabIndex = 3
        Me.CancelTransactionButton.Text = "Cancel"
        Me.CancelTransactionButton.UseVisualStyleBackColor = True
        '
        'TransactionDate
        '
        Me.TransactionDate.AutoSize = True
        Me.TransactionDate.Location = New System.Drawing.Point(160, 75)
        Me.TransactionDate.Name = "TransactionDate"
        Me.TransactionDate.Size = New System.Drawing.Size(30, 13)
        Me.TransactionDate.TabIndex = 15
        Me.TransactionDate.Text = "Date"
        '
        'timClock
        '
        '
        'lblTransNum
        '
        Me.lblTransNum.AutoSize = True
        Me.lblTransNum.Location = New System.Drawing.Point(160, 101)
        Me.lblTransNum.Name = "lblTransNum"
        Me.lblTransNum.Size = New System.Drawing.Size(55, 13)
        Me.lblTransNum.TabIndex = 16
        Me.lblTransNum.Text = "00000000"
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
        'btnEdit
        '
        Me.btnEdit.AutoSize = True
        Me.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEdit.Location = New System.Drawing.Point(328, 148)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(35, 23)
        Me.btnEdit.TabIndex = 17
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'AddTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 254)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lblTransNum)
        Me.Controls.Add(Me.TransactionDate)
        Me.Controls.Add(Me.CancelTransactionButton)
        Me.Controls.Add(Me.AddTransactionButton)
        Me.Controls.Add(Me.TransactionType)
        Me.Controls.Add(TransactionNumberLabel)
        Me.Controls.Add(TransactionTypeLabel)
        Me.Controls.Add(TransactionDateLabel)
        Me.Controls.Add(TransactionFeeLabel)
        Me.Controls.Add(Me.TransactionFeeTextBox)
        Me.Name = "AddTransactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TransactionFeeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TransactionType As System.Windows.Forms.ComboBox
    Friend WithEvents AddTransactionButton As System.Windows.Forms.Button
    Friend WithEvents BAHTODADataSet As BAHTODASystem.BAHTODADataSet
    Friend WithEvents TransactionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransactionsTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.TransactionsTableAdapter
    Friend WithEvents TableAdapterManager As BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager
    Friend WithEvents CancelTransactionButton As System.Windows.Forms.Button
    Friend WithEvents TransactionDate As System.Windows.Forms.Label
    Friend WithEvents timClock As System.Windows.Forms.Timer
    Friend WithEvents lblTransNum As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Button
End Class
