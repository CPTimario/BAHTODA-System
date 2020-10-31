<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditAccounts
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
        Dim UserIDLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim UserTypeLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Me.BAHTODADataSet = New BAHTODASystem.BAHTODADataSet()
        Me.UserAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserAccountsTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.UserAccountsTableAdapter()
        Me.TableAdapterManager = New BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UserTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        UserIDLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        UserTypeLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Location = New System.Drawing.Point(31, 92)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(46, 13)
        UserIDLabel.TabIndex = 0
        UserIDLabel.Text = "User ID:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(31, 118)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "Password:"
        '
        'UserTypeLabel
        '
        UserTypeLabel.AutoSize = True
        UserTypeLabel.Location = New System.Drawing.Point(31, 144)
        UserTypeLabel.Name = "UserTypeLabel"
        UserTypeLabel.Size = New System.Drawing.Size(59, 13)
        UserTypeLabel.TabIndex = 4
        UserTypeLabel.Text = "User Type:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(31, 171)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 6
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(31, 197)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 8
        LastNameLabel.Text = "Last Name:"
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
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountsBindingSource, "UserID", True))
        Me.UserIDTextBox.Location = New System.Drawing.Point(98, 89)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(187, 20)
        Me.UserIDTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountsBindingSource, "Password", True))
        Me.PasswordTextBox.Enabled = False
        Me.PasswordTextBox.Location = New System.Drawing.Point(98, 115)
        Me.PasswordTextBox.MaxLength = 10
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.ReadOnly = True
        Me.PasswordTextBox.Size = New System.Drawing.Size(187, 20)
        Me.PasswordTextBox.TabIndex = 3
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'UserTypeComboBox
        '
        Me.UserTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountsBindingSource, "UserType", True))
        Me.UserTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UserTypeComboBox.FormattingEnabled = True
        Me.UserTypeComboBox.Items.AddRange(New Object() {"User", "Administrator", "Super Administrator"})
        Me.UserTypeComboBox.Location = New System.Drawing.Point(98, 141)
        Me.UserTypeComboBox.Name = "UserTypeComboBox"
        Me.UserTypeComboBox.Size = New System.Drawing.Size(187, 21)
        Me.UserTypeComboBox.TabIndex = 5
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountsBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(98, 168)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(187, 20)
        Me.FirstNameTextBox.TabIndex = 7
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountsBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(98, 194)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(187, 20)
        Me.LastNameTextBox.TabIndex = 9
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(253, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 17
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.Location = New System.Drawing.Point(197, 233)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(42, 23)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.AutoSize = True
        Me.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnReset.Location = New System.Drawing.Point(97, 233)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(94, 23)
        Me.btnReset.TabIndex = 18
        Me.btnReset.Text = "Reset Password"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.Location = New System.Drawing.Point(12, 9)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(114, 13)
        Me.lblClock.TabIndex = 19
        Me.lblClock.Text = "12/31/9999 88:88 AM"
        '
        'timClock
        '
        '
        'EditAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 309)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(UserIDLabel)
        Me.Controls.Add(Me.UserIDTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(UserTypeLabel)
        Me.Controls.Add(Me.UserTypeComboBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Name = "EditAccounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditAccounts"
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BAHTODADataSet As BAHTODASystem.BAHTODADataSet
    Friend WithEvents UserAccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserAccountsTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.UserAccountsTableAdapter
    Friend WithEvents TableAdapterManager As BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblClock As System.Windows.Forms.Label
    Friend WithEvents timClock As System.Windows.Forms.Timer
End Class
