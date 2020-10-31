<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditDriverInfo
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
        Me.TransactionsTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.TransactionsTableAdapter()
        Me.TableAdapterManager = New BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager()
        Me.DriversTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.DriversTableAdapter()
        Me.TricyclesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DriversBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BAHTODADataSet = New BAHTODASystem.BAHTODADataSet()
        Me.TricyclesTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.TricyclesTableAdapter()
        Me.grpDriverInfo = New System.Windows.Forms.GroupBox()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.UserAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.DateOfBirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LicenseTextBox = New System.Windows.Forms.TextBox()
        Me.LicenseValidityDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ContactNumberTextBox = New System.Windows.Forms.TextBox()
        Me.DriverStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.grpTricInfo = New System.Windows.Forms.GroupBox()
        Me.BodyNumberTextBox = New System.Windows.Forms.TextBox()
        Me.PlateNumberTextBox = New System.Windows.Forms.TextBox()
        Me.TricycleStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.BrandNameTextBox = New System.Windows.Forms.TextBox()
        Me.ModelTextBox = New System.Windows.Forms.TextBox()
        Me.DateAcquiredDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserAccountsTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.UserAccountsTableAdapter()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        Me.lblClock = New System.Windows.Forms.Label()
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
        CType(Me.TricyclesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DriversBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDriverInfo.SuspendLayout()
        CType(Me.UserAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTricInfo.SuspendLayout()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Location = New System.Drawing.Point(17, 32)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(61, 13)
        UserIDLabel.TabIndex = 0
        UserIDLabel.Text = "ID Number:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(17, 58)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 2
        LastNameLabel.Text = "Last Name:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(17, 84)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 4
        FirstNameLabel.Text = "First Name:"
        '
        'DateOfBirthLabel
        '
        DateOfBirthLabel.AutoSize = True
        DateOfBirthLabel.Location = New System.Drawing.Point(17, 111)
        DateOfBirthLabel.Name = "DateOfBirthLabel"
        DateOfBirthLabel.Size = New System.Drawing.Size(71, 13)
        DateOfBirthLabel.TabIndex = 6
        DateOfBirthLabel.Text = "Date Of Birth:"
        '
        'LicenseLabel
        '
        LicenseLabel.AutoSize = True
        LicenseLabel.Location = New System.Drawing.Point(17, 136)
        LicenseLabel.Name = "LicenseLabel"
        LicenseLabel.Size = New System.Drawing.Size(47, 13)
        LicenseLabel.TabIndex = 8
        LicenseLabel.Text = "License:"
        '
        'LicenseValidityLabel
        '
        LicenseValidityLabel.AutoSize = True
        LicenseValidityLabel.Location = New System.Drawing.Point(17, 163)
        LicenseValidityLabel.Name = "LicenseValidityLabel"
        LicenseValidityLabel.Size = New System.Drawing.Size(83, 13)
        LicenseValidityLabel.TabIndex = 10
        LicenseValidityLabel.Text = "License Validity:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(17, 188)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 12
        AddressLabel.Text = "Address:"
        '
        'ContactNumberLabel
        '
        ContactNumberLabel.AutoSize = True
        ContactNumberLabel.Location = New System.Drawing.Point(17, 267)
        ContactNumberLabel.Name = "ContactNumberLabel"
        ContactNumberLabel.Size = New System.Drawing.Size(87, 13)
        ContactNumberLabel.TabIndex = 14
        ContactNumberLabel.Text = "Contact Number:"
        '
        'DriverStatusLabel
        '
        DriverStatusLabel.AutoSize = True
        DriverStatusLabel.Location = New System.Drawing.Point(17, 293)
        DriverStatusLabel.Name = "DriverStatusLabel"
        DriverStatusLabel.Size = New System.Drawing.Size(71, 13)
        DriverStatusLabel.TabIndex = 16
        DriverStatusLabel.Text = "Driver Status:"
        '
        'BodyNumberLabel
        '
        BodyNumberLabel.AutoSize = True
        BodyNumberLabel.Location = New System.Drawing.Point(22, 34)
        BodyNumberLabel.Name = "BodyNumberLabel"
        BodyNumberLabel.Size = New System.Drawing.Size(74, 13)
        BodyNumberLabel.TabIndex = 0
        BodyNumberLabel.Text = "Body Number:"
        '
        'PlateNumberLabel
        '
        PlateNumberLabel.AutoSize = True
        PlateNumberLabel.Location = New System.Drawing.Point(22, 61)
        PlateNumberLabel.Name = "PlateNumberLabel"
        PlateNumberLabel.Size = New System.Drawing.Size(74, 13)
        PlateNumberLabel.TabIndex = 4
        PlateNumberLabel.Text = "Plate Number:"
        '
        'TricycleStatusLabel
        '
        TricycleStatusLabel.AutoSize = True
        TricycleStatusLabel.Location = New System.Drawing.Point(22, 87)
        TricycleStatusLabel.Name = "TricycleStatusLabel"
        TricycleStatusLabel.Size = New System.Drawing.Size(80, 13)
        TricycleStatusLabel.TabIndex = 6
        TricycleStatusLabel.Text = "Tricycle Status:"
        '
        'BrandNameLabel
        '
        BrandNameLabel.AutoSize = True
        BrandNameLabel.Location = New System.Drawing.Point(22, 114)
        BrandNameLabel.Name = "BrandNameLabel"
        BrandNameLabel.Size = New System.Drawing.Size(69, 13)
        BrandNameLabel.TabIndex = 8
        BrandNameLabel.Text = "Brand Name:"
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Location = New System.Drawing.Point(22, 140)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(39, 13)
        ModelLabel.TabIndex = 10
        ModelLabel.Text = "Model:"
        '
        'DateAcquiredLabel
        '
        DateAcquiredLabel.AutoSize = True
        DateAcquiredLabel.Location = New System.Drawing.Point(22, 167)
        DateAcquiredLabel.Name = "DateAcquiredLabel"
        DateAcquiredLabel.Size = New System.Drawing.Size(78, 13)
        DateAcquiredLabel.TabIndex = 12
        DateAcquiredLabel.Text = "Date Acquired:"
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
        'DriversTableAdapter
        '
        Me.DriversTableAdapter.ClearBeforeFill = True
        '
        'TricyclesBindingSource
        '
        Me.TricyclesBindingSource.DataMember = "DriversTricycles"
        Me.TricyclesBindingSource.DataSource = Me.DriversBindingSource
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
        'TricyclesTableAdapter
        '
        Me.TricyclesTableAdapter.ClearBeforeFill = True
        '
        'grpDriverInfo
        '
        Me.grpDriverInfo.Controls.Add(Me.lblUserID)
        Me.grpDriverInfo.Controls.Add(UserIDLabel)
        Me.grpDriverInfo.Controls.Add(LastNameLabel)
        Me.grpDriverInfo.Controls.Add(Me.LastNameTextBox)
        Me.grpDriverInfo.Controls.Add(FirstNameLabel)
        Me.grpDriverInfo.Controls.Add(Me.FirstNameTextBox)
        Me.grpDriverInfo.Controls.Add(DateOfBirthLabel)
        Me.grpDriverInfo.Controls.Add(Me.DateOfBirthDateTimePicker)
        Me.grpDriverInfo.Controls.Add(LicenseLabel)
        Me.grpDriverInfo.Controls.Add(Me.LicenseTextBox)
        Me.grpDriverInfo.Controls.Add(LicenseValidityLabel)
        Me.grpDriverInfo.Controls.Add(Me.LicenseValidityDateTimePicker)
        Me.grpDriverInfo.Controls.Add(AddressLabel)
        Me.grpDriverInfo.Controls.Add(ContactNumberLabel)
        Me.grpDriverInfo.Controls.Add(Me.ContactNumberTextBox)
        Me.grpDriverInfo.Controls.Add(DriverStatusLabel)
        Me.grpDriverInfo.Controls.Add(Me.DriverStatusComboBox)
        Me.grpDriverInfo.Controls.Add(Me.AddressTextBox)
        Me.grpDriverInfo.Location = New System.Drawing.Point(25, 43)
        Me.grpDriverInfo.Name = "grpDriverInfo"
        Me.grpDriverInfo.Size = New System.Drawing.Size(329, 324)
        Me.grpDriverInfo.TabIndex = 1
        Me.grpDriverInfo.TabStop = False
        Me.grpDriverInfo.Text = "Driver's Information"
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountsBindingSource, "UserID", True))
        Me.lblUserID.Location = New System.Drawing.Point(84, 32)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(38, 13)
        Me.lblUserID.TabIndex = 18
        Me.lblUserID.Text = "userID"
        '
        'UserAccountsBindingSource
        '
        Me.UserAccountsBindingSource.DataMember = "UserAccounts"
        Me.UserAccountsBindingSource.DataSource = Me.BAHTODADataSet
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountsBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(110, 55)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LastNameTextBox.TabIndex = 3
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountsBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(110, 81)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FirstNameTextBox.TabIndex = 5
        '
        'DateOfBirthDateTimePicker
        '
        Me.DateOfBirthDateTimePicker.CustomFormat = "MMMM dd, yyyy"
        Me.DateOfBirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DriversBindingSource, "DateOfBirth", True))
        Me.DateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOfBirthDateTimePicker.Location = New System.Drawing.Point(110, 107)
        Me.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker"
        Me.DateOfBirthDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateOfBirthDateTimePicker.TabIndex = 7
        '
        'LicenseTextBox
        '
        Me.LicenseTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LicenseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriversBindingSource, "License", True))
        Me.LicenseTextBox.Location = New System.Drawing.Point(110, 133)
        Me.LicenseTextBox.Name = "LicenseTextBox"
        Me.LicenseTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LicenseTextBox.TabIndex = 9
        '
        'LicenseValidityDateTimePicker
        '
        Me.LicenseValidityDateTimePicker.CustomFormat = "MMMM dd, yyyy"
        Me.LicenseValidityDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DriversBindingSource, "LicenseValidity", True))
        Me.LicenseValidityDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LicenseValidityDateTimePicker.Location = New System.Drawing.Point(110, 159)
        Me.LicenseValidityDateTimePicker.Name = "LicenseValidityDateTimePicker"
        Me.LicenseValidityDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.LicenseValidityDateTimePicker.TabIndex = 11
        '
        'ContactNumberTextBox
        '
        Me.ContactNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriversBindingSource, "ContactNumber", True))
        Me.ContactNumberTextBox.Location = New System.Drawing.Point(110, 264)
        Me.ContactNumberTextBox.Name = "ContactNumberTextBox"
        Me.ContactNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ContactNumberTextBox.TabIndex = 15
        '
        'DriverStatusComboBox
        '
        Me.DriverStatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriversBindingSource, "DriverStatus", True))
        Me.DriverStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DriverStatusComboBox.FormattingEnabled = True
        Me.DriverStatusComboBox.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.DriverStatusComboBox.Location = New System.Drawing.Point(110, 290)
        Me.DriverStatusComboBox.Name = "DriverStatusComboBox"
        Me.DriverStatusComboBox.Size = New System.Drawing.Size(200, 21)
        Me.DriverStatusComboBox.TabIndex = 17
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriversBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(110, 185)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(200, 73)
        Me.AddressTextBox.TabIndex = 13
        '
        'grpTricInfo
        '
        Me.grpTricInfo.Controls.Add(BodyNumberLabel)
        Me.grpTricInfo.Controls.Add(Me.BodyNumberTextBox)
        Me.grpTricInfo.Controls.Add(PlateNumberLabel)
        Me.grpTricInfo.Controls.Add(Me.PlateNumberTextBox)
        Me.grpTricInfo.Controls.Add(TricycleStatusLabel)
        Me.grpTricInfo.Controls.Add(Me.TricycleStatusComboBox)
        Me.grpTricInfo.Controls.Add(BrandNameLabel)
        Me.grpTricInfo.Controls.Add(Me.BrandNameTextBox)
        Me.grpTricInfo.Controls.Add(ModelLabel)
        Me.grpTricInfo.Controls.Add(Me.ModelTextBox)
        Me.grpTricInfo.Controls.Add(DateAcquiredLabel)
        Me.grpTricInfo.Controls.Add(Me.DateAcquiredDateTimePicker)
        Me.grpTricInfo.Location = New System.Drawing.Point(369, 111)
        Me.grpTricInfo.Name = "grpTricInfo"
        Me.grpTricInfo.Size = New System.Drawing.Size(330, 201)
        Me.grpTricInfo.TabIndex = 2
        Me.grpTricInfo.TabStop = False
        Me.grpTricInfo.Text = "Tricycle's Information"
        '
        'BodyNumberTextBox
        '
        Me.BodyNumberTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BodyNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TricyclesBindingSource, "BodyNumber", True))
        Me.BodyNumberTextBox.Location = New System.Drawing.Point(108, 31)
        Me.BodyNumberTextBox.Name = "BodyNumberTextBox"
        Me.BodyNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BodyNumberTextBox.TabIndex = 1
        '
        'PlateNumberTextBox
        '
        Me.PlateNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TricyclesBindingSource, "PlateNumber", True))
        Me.PlateNumberTextBox.Location = New System.Drawing.Point(108, 58)
        Me.PlateNumberTextBox.Name = "PlateNumberTextBox"
        Me.PlateNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PlateNumberTextBox.TabIndex = 5
        '
        'TricycleStatusComboBox
        '
        Me.TricycleStatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TricyclesBindingSource, "TricycleStatus", True))
        Me.TricycleStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TricycleStatusComboBox.FormattingEnabled = True
        Me.TricycleStatusComboBox.Items.AddRange(New Object() {"Operational", "Under Maintenance"})
        Me.TricycleStatusComboBox.Location = New System.Drawing.Point(108, 84)
        Me.TricycleStatusComboBox.Name = "TricycleStatusComboBox"
        Me.TricycleStatusComboBox.Size = New System.Drawing.Size(200, 21)
        Me.TricycleStatusComboBox.TabIndex = 7
        '
        'BrandNameTextBox
        '
        Me.BrandNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TricyclesBindingSource, "BrandName", True))
        Me.BrandNameTextBox.Location = New System.Drawing.Point(108, 111)
        Me.BrandNameTextBox.Name = "BrandNameTextBox"
        Me.BrandNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BrandNameTextBox.TabIndex = 9
        '
        'ModelTextBox
        '
        Me.ModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TricyclesBindingSource, "Model", True))
        Me.ModelTextBox.Location = New System.Drawing.Point(108, 137)
        Me.ModelTextBox.Name = "ModelTextBox"
        Me.ModelTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ModelTextBox.TabIndex = 11
        '
        'DateAcquiredDateTimePicker
        '
        Me.DateAcquiredDateTimePicker.CustomFormat = "MMMM dd, yyyy"
        Me.DateAcquiredDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TricyclesBindingSource, "DateAcquired", True))
        Me.DateAcquiredDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateAcquiredDateTimePicker.Location = New System.Drawing.Point(108, 163)
        Me.DateAcquiredDateTimePicker.Name = "DateAcquiredDateTimePicker"
        Me.DateAcquiredDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateAcquiredDateTimePicker.TabIndex = 13
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(531, 344)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(612, 344)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'TransactionsBindingSource
        '
        Me.TransactionsBindingSource.DataMember = "Transactions"
        Me.TransactionsBindingSource.DataSource = Me.BAHTODADataSet
        '
        'UserAccountsTableAdapter
        '
        Me.UserAccountsTableAdapter.ClearBeforeFill = True
        '
        'timClock
        '
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.Location = New System.Drawing.Point(599, 9)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(114, 13)
        Me.lblClock.TabIndex = 4
        Me.lblClock.Text = "12/31/9999 88:88 AM"
        '
        'EditDriverInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 393)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpTricInfo)
        Me.Controls.Add(Me.grpDriverInfo)
        Me.Name = "EditDriverInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditDriverInfo"
        CType(Me.TricyclesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DriversBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDriverInfo.ResumeLayout(False)
        Me.grpDriverInfo.PerformLayout()
        CType(Me.UserAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTricInfo.ResumeLayout(False)
        Me.grpTricInfo.PerformLayout()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BAHTODADataSet As BAHTODASystem.BAHTODADataSet
    Friend WithEvents TransactionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransactionsTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.TransactionsTableAdapter
    Friend WithEvents TableAdapterManager As BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager
    Friend WithEvents DriversBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DriversTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.DriversTableAdapter
    Friend WithEvents TricyclesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TricyclesTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.TricyclesTableAdapter
    Friend WithEvents grpDriverInfo As System.Windows.Forms.GroupBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateOfBirthDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LicenseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LicenseValidityDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DriverStatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents grpTricInfo As System.Windows.Forms.GroupBox
    Friend WithEvents BodyNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlateNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TricycleStatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BrandNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ModelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateAcquiredDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents UserAccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserAccountsTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.UserAccountsTableAdapter
    Friend WithEvents timClock As System.Windows.Forms.Timer
    Friend WithEvents lblClock As System.Windows.Forms.Label
End Class
