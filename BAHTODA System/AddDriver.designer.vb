<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDriver
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
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim DateOfBirthLabel As System.Windows.Forms.Label
        Dim LicenseLabel As System.Windows.Forms.Label
        Dim LicenseValidityLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim ContactNumberLabel As System.Windows.Forms.Label
        Dim DriverStatusLabel As System.Windows.Forms.Label
        Dim BodyNumberLabel As System.Windows.Forms.Label
        Dim PlateNumberLabel As System.Windows.Forms.Label
        Dim TricycleStatusLabel As System.Windows.Forms.Label
        Dim BrandNameLabel As System.Windows.Forms.Label
        Dim ModelLabel As System.Windows.Forms.Label
        Dim DateAcquiredLabel As System.Windows.Forms.Label
        Dim BalanceLabel As System.Windows.Forms.Label
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.UserAccountsTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.UserAccountsTableAdapter()
        Me.DriversTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.DriversTableAdapter()
        Me.TableAdapterManager = New BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager()
        Me.grpDriverInfo = New System.Windows.Forms.GroupBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.BalanceTextBox = New System.Windows.Forms.TextBox()
        Me.DriversBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BAHTODADataSet = New BAHTODASystem.BAHTODADataSet()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.dtpDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.txtLicence = New System.Windows.Forms.TextBox()
        Me.dtpLicenceValid = New System.Windows.Forms.DateTimePicker()
        Me.txtContactNum = New System.Windows.Forms.TextBox()
        Me.cbDriverStat = New System.Windows.Forms.ComboBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.TricyclesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TricyclesTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.TricyclesTableAdapter()
        Me.grpTricInfo = New System.Windows.Forms.GroupBox()
        Me.txtBodyNum = New System.Windows.Forms.TextBox()
        Me.txtPlateNum = New System.Windows.Forms.TextBox()
        Me.cbTricycleStat = New System.Windows.Forms.ComboBox()
        Me.txtBrandName = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.dtpDateAcquired = New System.Windows.Forms.DateTimePicker()
        Me.UserAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblClock = New System.Windows.Forms.Label()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        Me.DriverTransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DriverTransactionTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.DriverTransactionTableAdapter()
        UserIDLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        DateOfBirthLabel = New System.Windows.Forms.Label()
        LicenseLabel = New System.Windows.Forms.Label()
        LicenseValidityLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        ContactNumberLabel = New System.Windows.Forms.Label()
        DriverStatusLabel = New System.Windows.Forms.Label()
        BodyNumberLabel = New System.Windows.Forms.Label()
        PlateNumberLabel = New System.Windows.Forms.Label()
        TricycleStatusLabel = New System.Windows.Forms.Label()
        BrandNameLabel = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        DateAcquiredLabel = New System.Windows.Forms.Label()
        BalanceLabel = New System.Windows.Forms.Label()
        Me.grpDriverInfo.SuspendLayout()
        CType(Me.DriversBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TricyclesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTricInfo.SuspendLayout()
        CType(Me.UserAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DriverTransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Location = New System.Drawing.Point(30, 40)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(106, 24)
        UserIDLabel.TabIndex = 0
        UserIDLabel.Text = "ID Number:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(30, 110)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(104, 24)
        LastNameLabel.TabIndex = 2
        LastNameLabel.Text = "Last Name:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(30, 75)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(106, 24)
        FirstNameLabel.TabIndex = 4
        FirstNameLabel.Text = "First Name:"
        '
        'DateOfBirthLabel
        '
        DateOfBirthLabel.AutoSize = True
        DateOfBirthLabel.Location = New System.Drawing.Point(30, 146)
        DateOfBirthLabel.Name = "DateOfBirthLabel"
        DateOfBirthLabel.Size = New System.Drawing.Size(119, 24)
        DateOfBirthLabel.TabIndex = 6
        DateOfBirthLabel.Text = "Date Of Birth:"
        '
        'LicenseLabel
        '
        LicenseLabel.AutoSize = True
        LicenseLabel.Location = New System.Drawing.Point(30, 180)
        LicenseLabel.Name = "LicenseLabel"
        LicenseLabel.Size = New System.Drawing.Size(81, 24)
        LicenseLabel.TabIndex = 8
        LicenseLabel.Text = "License:"
        '
        'LicenseValidityLabel
        '
        LicenseValidityLabel.AutoSize = True
        LicenseValidityLabel.Location = New System.Drawing.Point(30, 216)
        LicenseValidityLabel.Name = "LicenseValidityLabel"
        LicenseValidityLabel.Size = New System.Drawing.Size(145, 24)
        LicenseValidityLabel.TabIndex = 10
        LicenseValidityLabel.Text = "License Validity:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(30, 250)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(85, 24)
        AddressLabel.TabIndex = 12
        AddressLabel.Text = "Address:"
        '
        'ContactNumberLabel
        '
        ContactNumberLabel.AutoSize = True
        ContactNumberLabel.Location = New System.Drawing.Point(30, 355)
        ContactNumberLabel.Name = "ContactNumberLabel"
        ContactNumberLabel.Size = New System.Drawing.Size(152, 24)
        ContactNumberLabel.TabIndex = 14
        ContactNumberLabel.Text = "Contact Number:"
        '
        'DriverStatusLabel
        '
        DriverStatusLabel.AutoSize = True
        DriverStatusLabel.Location = New System.Drawing.Point(30, 425)
        DriverStatusLabel.Name = "DriverStatusLabel"
        DriverStatusLabel.Size = New System.Drawing.Size(119, 24)
        DriverStatusLabel.TabIndex = 16
        DriverStatusLabel.Text = "Driver Status:"
        '
        'BodyNumberLabel
        '
        BodyNumberLabel.AutoSize = True
        BodyNumberLabel.Location = New System.Drawing.Point(34, 48)
        BodyNumberLabel.Name = "BodyNumberLabel"
        BodyNumberLabel.Size = New System.Drawing.Size(132, 24)
        BodyNumberLabel.TabIndex = 0
        BodyNumberLabel.Text = "Body Number:"
        '
        'PlateNumberLabel
        '
        PlateNumberLabel.AutoSize = True
        PlateNumberLabel.Location = New System.Drawing.Point(34, 84)
        PlateNumberLabel.Name = "PlateNumberLabel"
        PlateNumberLabel.Size = New System.Drawing.Size(130, 24)
        PlateNumberLabel.TabIndex = 4
        PlateNumberLabel.Text = "Plate Number:"
        '
        'TricycleStatusLabel
        '
        TricycleStatusLabel.AutoSize = True
        TricycleStatusLabel.Location = New System.Drawing.Point(34, 119)
        TricycleStatusLabel.Name = "TricycleStatusLabel"
        TricycleStatusLabel.Size = New System.Drawing.Size(136, 24)
        TricycleStatusLabel.TabIndex = 6
        TricycleStatusLabel.Text = "Tricycle Status:"
        '
        'BrandNameLabel
        '
        BrandNameLabel.AutoSize = True
        BrandNameLabel.Location = New System.Drawing.Point(34, 157)
        BrandNameLabel.Name = "BrandNameLabel"
        BrandNameLabel.Size = New System.Drawing.Size(121, 24)
        BrandNameLabel.TabIndex = 8
        BrandNameLabel.Text = "Brand Name:"
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Location = New System.Drawing.Point(34, 192)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(68, 24)
        ModelLabel.TabIndex = 10
        ModelLabel.Text = "Model:"
        '
        'DateAcquiredLabel
        '
        DateAcquiredLabel.AutoSize = True
        DateAcquiredLabel.Location = New System.Drawing.Point(34, 228)
        DateAcquiredLabel.Name = "DateAcquiredLabel"
        DateAcquiredLabel.Size = New System.Drawing.Size(135, 24)
        DateAcquiredLabel.TabIndex = 12
        DateAcquiredLabel.Text = "Date Acquired:"
        '
        'BalanceLabel
        '
        BalanceLabel.AutoSize = True
        BalanceLabel.Location = New System.Drawing.Point(30, 390)
        BalanceLabel.Name = "BalanceLabel"
        BalanceLabel.Size = New System.Drawing.Size(120, 24)
        BalanceLabel.TabIndex = 18
        BalanceLabel.Text = "Tricycle Fee:"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(342, 531)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(126, 39)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "Add"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(516, 531)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(126, 39)
        Me.cmdBack.TabIndex = 3
        Me.cmdBack.Text = "BACK"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'UserAccountsTableAdapter
        '
        Me.UserAccountsTableAdapter.ClearBeforeFill = True
        '
        'DriversTableAdapter
        '
        Me.DriversTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DriversTableAdapter = Me.DriversTableAdapter
        Me.TableAdapterManager.TransactionsTableAdapter = Nothing
        Me.TableAdapterManager.TricyclesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserAccountsTableAdapter = Me.UserAccountsTableAdapter
        '
        'grpDriverInfo
        '
        Me.grpDriverInfo.Controls.Add(Me.btnEdit)
        Me.grpDriverInfo.Controls.Add(BalanceLabel)
        Me.grpDriverInfo.Controls.Add(Me.BalanceTextBox)
        Me.grpDriverInfo.Controls.Add(UserIDLabel)
        Me.grpDriverInfo.Controls.Add(Me.txtUserID)
        Me.grpDriverInfo.Controls.Add(LastNameLabel)
        Me.grpDriverInfo.Controls.Add(FirstNameLabel)
        Me.grpDriverInfo.Controls.Add(Me.txtFirstName)
        Me.grpDriverInfo.Controls.Add(DateOfBirthLabel)
        Me.grpDriverInfo.Controls.Add(Me.dtpDateOfBirth)
        Me.grpDriverInfo.Controls.Add(LicenseLabel)
        Me.grpDriverInfo.Controls.Add(Me.txtLicence)
        Me.grpDriverInfo.Controls.Add(LicenseValidityLabel)
        Me.grpDriverInfo.Controls.Add(Me.dtpLicenceValid)
        Me.grpDriverInfo.Controls.Add(AddressLabel)
        Me.grpDriverInfo.Controls.Add(ContactNumberLabel)
        Me.grpDriverInfo.Controls.Add(Me.txtContactNum)
        Me.grpDriverInfo.Controls.Add(DriverStatusLabel)
        Me.grpDriverInfo.Controls.Add(Me.cbDriverStat)
        Me.grpDriverInfo.Controls.Add(Me.txtAddress)
        Me.grpDriverInfo.Controls.Add(Me.txtLastName)
        Me.grpDriverInfo.Location = New System.Drawing.Point(21, 25)
        Me.grpDriverInfo.Name = "grpDriverInfo"
        Me.grpDriverInfo.Size = New System.Drawing.Size(474, 478)
        Me.grpDriverInfo.TabIndex = 0
        Me.grpDriverInfo.TabStop = False
        Me.grpDriverInfo.Text = "Driver's Information"
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = True
        Me.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEdit.Location = New System.Drawing.Point(382, 385)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(52, 34)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'BalanceTextBox
        '
        Me.BalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriversBindingSource, "Balance", True))
        Me.BalanceTextBox.Enabled = False
        Me.BalanceTextBox.Location = New System.Drawing.Point(188, 387)
        Me.BalanceTextBox.Name = "BalanceTextBox"
        Me.BalanceTextBox.ReadOnly = True
        Me.BalanceTextBox.Size = New System.Drawing.Size(188, 29)
        Me.BalanceTextBox.TabIndex = 19
        Me.BalanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DriversBindingSource
        '
        Me.DriversBindingSource.DataMember = "Drivers"
        Me.DriversBindingSource.DataSource = Me.BAHTODADataSet
        '
        'BAHTODADataSet
        '
        Me.BAHTODADataSet.DataSetName = "BAHTODADataSet"
        Me.BAHTODADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(188, 37)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(246, 29)
        Me.txtUserID.TabIndex = 1
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(188, 72)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(246, 29)
        Me.txtFirstName.TabIndex = 0
        '
        'dtpDateOfBirth
        '
        Me.dtpDateOfBirth.CustomFormat = "MMMM dd, yyyy"
        Me.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateOfBirth.Location = New System.Drawing.Point(188, 142)
        Me.dtpDateOfBirth.Name = "dtpDateOfBirth"
        Me.dtpDateOfBirth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpDateOfBirth.Size = New System.Drawing.Size(246, 29)
        Me.dtpDateOfBirth.TabIndex = 2
        '
        'txtLicence
        '
        Me.txtLicence.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLicence.Location = New System.Drawing.Point(188, 177)
        Me.txtLicence.Name = "txtLicence"
        Me.txtLicence.Size = New System.Drawing.Size(246, 29)
        Me.txtLicence.TabIndex = 3
        '
        'dtpLicenceValid
        '
        Me.dtpLicenceValid.CustomFormat = "MMMM dd, yyyy"
        Me.dtpLicenceValid.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLicenceValid.Location = New System.Drawing.Point(188, 212)
        Me.dtpLicenceValid.Name = "dtpLicenceValid"
        Me.dtpLicenceValid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpLicenceValid.Size = New System.Drawing.Size(246, 29)
        Me.dtpLicenceValid.TabIndex = 4
        '
        'txtContactNum
        '
        Me.txtContactNum.Location = New System.Drawing.Point(188, 352)
        Me.txtContactNum.MaxLength = 11
        Me.txtContactNum.Name = "txtContactNum"
        Me.txtContactNum.Size = New System.Drawing.Size(246, 29)
        Me.txtContactNum.TabIndex = 6
        '
        'cbDriverStat
        '
        Me.cbDriverStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDriverStat.FormattingEnabled = True
        Me.cbDriverStat.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cbDriverStat.Location = New System.Drawing.Point(188, 422)
        Me.cbDriverStat.Name = "cbDriverStat"
        Me.cbDriverStat.Size = New System.Drawing.Size(246, 32)
        Me.cbDriverStat.TabIndex = 8
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(188, 247)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(246, 99)
        Me.txtAddress.TabIndex = 5
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(188, 107)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(246, 29)
        Me.txtLastName.TabIndex = 1
        '
        'TricyclesBindingSource
        '
        Me.TricyclesBindingSource.DataMember = "DriversTricycles"
        Me.TricyclesBindingSource.DataSource = Me.DriversBindingSource
        '
        'TricyclesTableAdapter
        '
        Me.TricyclesTableAdapter.ClearBeforeFill = True
        '
        'grpTricInfo
        '
        Me.grpTricInfo.Controls.Add(BodyNumberLabel)
        Me.grpTricInfo.Controls.Add(Me.txtBodyNum)
        Me.grpTricInfo.Controls.Add(PlateNumberLabel)
        Me.grpTricInfo.Controls.Add(Me.txtPlateNum)
        Me.grpTricInfo.Controls.Add(TricycleStatusLabel)
        Me.grpTricInfo.Controls.Add(Me.cbTricycleStat)
        Me.grpTricInfo.Controls.Add(BrandNameLabel)
        Me.grpTricInfo.Controls.Add(Me.txtBrandName)
        Me.grpTricInfo.Controls.Add(ModelLabel)
        Me.grpTricInfo.Controls.Add(Me.txtModel)
        Me.grpTricInfo.Controls.Add(DateAcquiredLabel)
        Me.grpTricInfo.Controls.Add(Me.dtpDateAcquired)
        Me.grpTricInfo.Location = New System.Drawing.Point(516, 87)
        Me.grpTricInfo.Name = "grpTricInfo"
        Me.grpTricInfo.Size = New System.Drawing.Size(474, 282)
        Me.grpTricInfo.TabIndex = 1
        Me.grpTricInfo.TabStop = False
        Me.grpTricInfo.Text = "Tricycle's Information"
        '
        'txtBodyNum
        '
        Me.txtBodyNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBodyNum.Location = New System.Drawing.Point(176, 45)
        Me.txtBodyNum.Name = "txtBodyNum"
        Me.txtBodyNum.Size = New System.Drawing.Size(246, 29)
        Me.txtBodyNum.TabIndex = 0
        '
        'txtPlateNum
        '
        Me.txtPlateNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlateNum.Location = New System.Drawing.Point(176, 81)
        Me.txtPlateNum.Name = "txtPlateNum"
        Me.txtPlateNum.Size = New System.Drawing.Size(246, 29)
        Me.txtPlateNum.TabIndex = 1
        '
        'cbTricycleStat
        '
        Me.cbTricycleStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTricycleStat.FormattingEnabled = True
        Me.cbTricycleStat.Items.AddRange(New Object() {"Operational", "Under Maintenance"})
        Me.cbTricycleStat.Location = New System.Drawing.Point(176, 116)
        Me.cbTricycleStat.Name = "cbTricycleStat"
        Me.cbTricycleStat.Size = New System.Drawing.Size(246, 32)
        Me.cbTricycleStat.TabIndex = 2
        '
        'txtBrandName
        '
        Me.txtBrandName.Location = New System.Drawing.Point(176, 154)
        Me.txtBrandName.Name = "txtBrandName"
        Me.txtBrandName.Size = New System.Drawing.Size(246, 29)
        Me.txtBrandName.TabIndex = 3
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(176, 189)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(246, 29)
        Me.txtModel.TabIndex = 4
        '
        'dtpDateAcquired
        '
        Me.dtpDateAcquired.CustomFormat = "MMMM dd, yyyy"
        Me.dtpDateAcquired.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateAcquired.Location = New System.Drawing.Point(176, 224)
        Me.dtpDateAcquired.Name = "dtpDateAcquired"
        Me.dtpDateAcquired.Size = New System.Drawing.Size(246, 29)
        Me.dtpDateAcquired.TabIndex = 5
        '
        'UserAccountsBindingSource
        '
        Me.UserAccountsBindingSource.DataMember = "UserAccounts"
        Me.UserAccountsBindingSource.DataSource = Me.BAHTODADataSet
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.Location = New System.Drawing.Point(825, 9)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(184, 24)
        Me.lblClock.TabIndex = 4
        Me.lblClock.Text = "12/99/9999 88:88 AM"
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
        'AddDriver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 606)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.grpTricInfo)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.grpDriverInfo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "AddDriver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddDriver"
        Me.grpDriverInfo.ResumeLayout(False)
        Me.grpDriverInfo.PerformLayout()
        CType(Me.DriversBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TricyclesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTricInfo.ResumeLayout(False)
        Me.grpTricInfo.PerformLayout()
        CType(Me.UserAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DriverTransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents BAHTODADataSet As BAHTODASystem.BAHTODADataSet
    Friend WithEvents UserAccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserAccountsTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.UserAccountsTableAdapter
    Friend WithEvents DriversBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DriversTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.DriversTableAdapter
    Friend WithEvents TableAdapterManager As BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager
    Friend WithEvents grpDriverInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents dtpDateOfBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtLicence As System.Windows.Forms.TextBox
    Friend WithEvents dtpLicenceValid As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtContactNum As System.Windows.Forms.TextBox
    Friend WithEvents cbDriverStat As System.Windows.Forms.ComboBox
    Friend WithEvents TricyclesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TricyclesTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.TricyclesTableAdapter
    Friend WithEvents grpTricInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtBodyNum As System.Windows.Forms.TextBox
    Friend WithEvents txtPlateNum As System.Windows.Forms.TextBox
    Friend WithEvents cbTricycleStat As System.Windows.Forms.ComboBox
    Friend WithEvents txtBrandName As System.Windows.Forms.TextBox
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents dtpDateAcquired As System.Windows.Forms.DateTimePicker
    Friend WithEvents BalanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents lblClock As System.Windows.Forms.Label
    Friend WithEvents timClock As System.Windows.Forms.Timer
    Friend WithEvents DriverTransactionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DriverTransactionTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.DriverTransactionTableAdapter
End Class
