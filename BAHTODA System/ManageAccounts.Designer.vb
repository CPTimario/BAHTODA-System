<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageAccounts
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BAHTODADataSet = New BAHTODASystem.BAHTODADataSet()
        Me.UserAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserAccountsTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.UserAccountsTableAdapter()
        Me.TableAdapterManager = New BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnEditAccount = New System.Windows.Forms.Button()
        Me.dgvUserAccounts = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewUserAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAddAccount = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.ViewUserAccountsTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.ViewUserAccountsTableAdapter()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        Me.lblClock = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUserAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewUserAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(37, 72)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(75, 13)
        NameLabel.TabIndex = 12
        NameLabel.Text = "Search Name:"
        '
        'BAHTODADataSet
        '
        Me.BAHTODADataSet.DataSetName = "BAHTODADataSet"
        Me.BAHTODADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserAccountsBindingSource
        '
        Me.UserAccountsBindingSource.DataMember = "UserAccounts"
        Me.UserAccountsBindingSource.DataSource = Me.BAHTODADataSet
        '
        'UserAccountsTableAdapter
        '
        Me.UserAccountsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DriversTableAdapter = Nothing
        Me.TableAdapterManager.TransactionsTableAdapter = Nothing
        Me.TableAdapterManager.TricyclesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserAccountsTableAdapter = Me.UserAccountsTableAdapter
        '
        'btnBack
        '
        Me.btnBack.AutoSize = True
        Me.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBack.Location = New System.Drawing.Point(592, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(42, 23)
        Me.btnBack.TabIndex = 16
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnEditAccount
        '
        Me.btnEditAccount.AutoSize = True
        Me.btnEditAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEditAccount.Location = New System.Drawing.Point(566, 67)
        Me.btnEditAccount.Name = "btnEditAccount"
        Me.btnEditAccount.Size = New System.Drawing.Size(35, 23)
        Me.btnEditAccount.TabIndex = 15
        Me.btnEditAccount.Text = "Edit"
        Me.btnEditAccount.UseVisualStyleBackColor = True
        '
        'dgvUserAccounts
        '
        Me.dgvUserAccounts.AllowUserToAddRows = False
        Me.dgvUserAccounts.AllowUserToDeleteRows = False
        Me.dgvUserAccounts.AllowUserToResizeColumns = False
        Me.dgvUserAccounts.AllowUserToResizeRows = False
        Me.dgvUserAccounts.AutoGenerateColumns = False
        Me.dgvUserAccounts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUserAccounts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUserAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserAccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.UserIDDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.UserTypeDataGridViewTextBoxColumn})
        Me.dgvUserAccounts.DataSource = Me.ViewUserAccountsBindingSource
        Me.dgvUserAccounts.Location = New System.Drawing.Point(12, 96)
        Me.dgvUserAccounts.MultiSelect = False
        Me.dgvUserAccounts.Name = "dgvUserAccounts"
        Me.dgvUserAccounts.ReadOnly = True
        Me.dgvUserAccounts.RowHeadersVisible = False
        Me.dgvUserAccounts.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgvUserAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUserAccounts.Size = New System.Drawing.Size(615, 303)
        Me.dgvUserAccounts.TabIndex = 11
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "User ID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        Me.UserIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserIDDataGridViewTextBoxColumn.Width = 68
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        DataGridViewCellStyle2.Format = "************"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.PasswordDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.ReadOnly = True
        Me.PasswordDataGridViewTextBoxColumn.Width = 78
        '
        'UserTypeDataGridViewTextBoxColumn
        '
        Me.UserTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UserTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType"
        Me.UserTypeDataGridViewTextBoxColumn.HeaderText = "User Type"
        Me.UserTypeDataGridViewTextBoxColumn.Name = "UserTypeDataGridViewTextBoxColumn"
        Me.UserTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserTypeDataGridViewTextBoxColumn.Width = 81
        '
        'ViewUserAccountsBindingSource
        '
        Me.ViewUserAccountsBindingSource.DataMember = "ViewUserAccounts"
        Me.ViewUserAccountsBindingSource.DataSource = Me.BAHTODADataSet
        '
        'btnAddAccount
        '
        Me.btnAddAccount.AutoSize = True
        Me.btnAddAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddAccount.Location = New System.Drawing.Point(499, 67)
        Me.btnAddAccount.Name = "btnAddAccount"
        Me.btnAddAccount.Size = New System.Drawing.Size(61, 23)
        Me.btnAddAccount.TabIndex = 14
        Me.btnAddAccount.Text = "Add New"
        Me.btnAddAccount.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(118, 69)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(341, 20)
        Me.txtSearch.TabIndex = 13
        '
        'ViewUserAccountsTableAdapter
        '
        Me.ViewUserAccountsTableAdapter.ClearBeforeFill = True
        '
        'timClock
        '
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.Location = New System.Drawing.Point(12, 9)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(108, 13)
        Me.lblClock.TabIndex = 17
        Me.lblClock.Text = "12/3/9999 88:88 AM"
        '
        'ManageAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 411)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnEditAccount)
        Me.Controls.Add(Me.dgvUserAccounts)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.btnAddAccount)
        Me.Controls.Add(Me.txtSearch)
        Me.Name = "ManageAccounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageAccounts"
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUserAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewUserAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BAHTODADataSet As BAHTODASystem.BAHTODADataSet
    Friend WithEvents UserAccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserAccountsTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.UserAccountsTableAdapter
    Friend WithEvents TableAdapterManager As BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnEditAccount As System.Windows.Forms.Button
    Friend WithEvents dgvUserAccounts As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddAccount As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents ViewUserAccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViewUserAccountsTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.ViewUserAccountsTableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents timClock As System.Windows.Forms.Timer
    Friend WithEvents lblClock As System.Windows.Forms.Label
End Class
