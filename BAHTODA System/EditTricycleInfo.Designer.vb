<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditTricycleInfo
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
        Dim BodyNumberLabel As System.Windows.Forms.Label
        Dim PlateNumberLabel As System.Windows.Forms.Label
        Dim TricycleStatusLabel As System.Windows.Forms.Label
        Dim BrandNameLabel As System.Windows.Forms.Label
        Dim ModelLabel As System.Windows.Forms.Label
        Dim DateAcquiredLabel As System.Windows.Forms.Label
        Me.BodyNumberTextBox = New System.Windows.Forms.TextBox()
        Me.TricyclesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BAHTODADataSet = New BAHTODASystem.BAHTODADataSet()
        Me.PlateNumberTextBox = New System.Windows.Forms.TextBox()
        Me.TricycleStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.BrandNameTextBox = New System.Windows.Forms.TextBox()
        Me.ModelTextBox = New System.Windows.Forms.TextBox()
        Me.DateAcquiredDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.TricyclesTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.TricyclesTableAdapter()
        Me.TableAdapterManager = New BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager()
        Me.UserAccountsTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.UserAccountsTableAdapter()
        Me.DriverInformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DriverInformationTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.DriverInformationTableAdapter()
        Me.UserAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblClock = New System.Windows.Forms.Label()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        BodyNumberLabel = New System.Windows.Forms.Label()
        PlateNumberLabel = New System.Windows.Forms.Label()
        TricycleStatusLabel = New System.Windows.Forms.Label()
        BrandNameLabel = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        DateAcquiredLabel = New System.Windows.Forms.Label()
        CType(Me.TricyclesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DriverInformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BodyNumberLabel
        '
        BodyNumberLabel.AutoSize = True
        BodyNumberLabel.Location = New System.Drawing.Point(35, 108)
        BodyNumberLabel.Name = "BodyNumberLabel"
        BodyNumberLabel.Size = New System.Drawing.Size(74, 13)
        BodyNumberLabel.TabIndex = 0
        BodyNumberLabel.Text = "Body Number:"
        '
        'PlateNumberLabel
        '
        PlateNumberLabel.AutoSize = True
        PlateNumberLabel.Location = New System.Drawing.Point(35, 212)
        PlateNumberLabel.Name = "PlateNumberLabel"
        PlateNumberLabel.Size = New System.Drawing.Size(74, 13)
        PlateNumberLabel.TabIndex = 4
        PlateNumberLabel.Text = "Plate Number:"
        '
        'TricycleStatusLabel
        '
        TricycleStatusLabel.AutoSize = True
        TricycleStatusLabel.Location = New System.Drawing.Point(35, 238)
        TricycleStatusLabel.Name = "TricycleStatusLabel"
        TricycleStatusLabel.Size = New System.Drawing.Size(80, 13)
        TricycleStatusLabel.TabIndex = 6
        TricycleStatusLabel.Text = "Tricycle Status:"
        '
        'BrandNameLabel
        '
        BrandNameLabel.AutoSize = True
        BrandNameLabel.Location = New System.Drawing.Point(35, 134)
        BrandNameLabel.Name = "BrandNameLabel"
        BrandNameLabel.Size = New System.Drawing.Size(69, 13)
        BrandNameLabel.TabIndex = 8
        BrandNameLabel.Text = "Brand Name:"
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Location = New System.Drawing.Point(35, 160)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(39, 13)
        ModelLabel.TabIndex = 10
        ModelLabel.Text = "Model:"
        '
        'DateAcquiredLabel
        '
        DateAcquiredLabel.AutoSize = True
        DateAcquiredLabel.Location = New System.Drawing.Point(35, 187)
        DateAcquiredLabel.Name = "DateAcquiredLabel"
        DateAcquiredLabel.Size = New System.Drawing.Size(78, 13)
        DateAcquiredLabel.TabIndex = 12
        DateAcquiredLabel.Text = "Date Acquired:"
        '
        'BodyNumberTextBox
        '
        Me.BodyNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TricyclesBindingSource, "BodyNumber", True))
        Me.BodyNumberTextBox.Location = New System.Drawing.Point(121, 105)
        Me.BodyNumberTextBox.Name = "BodyNumberTextBox"
        Me.BodyNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BodyNumberTextBox.TabIndex = 1
        '
        'TricyclesBindingSource
        '
        Me.TricyclesBindingSource.DataMember = "Tricycles"
        Me.TricyclesBindingSource.DataSource = Me.BAHTODADataSet
        '
        'BAHTODADataSet
        '
        Me.BAHTODADataSet.DataSetName = "BAHTODADataSet"
        Me.BAHTODADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PlateNumberTextBox
        '
        Me.PlateNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TricyclesBindingSource, "PlateNumber", True))
        Me.PlateNumberTextBox.Location = New System.Drawing.Point(121, 209)
        Me.PlateNumberTextBox.Name = "PlateNumberTextBox"
        Me.PlateNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PlateNumberTextBox.TabIndex = 5
        '
        'TricycleStatusComboBox
        '
        Me.TricycleStatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TricyclesBindingSource, "TricycleStatus", True))
        Me.TricycleStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TricycleStatusComboBox.Enabled = False
        Me.TricycleStatusComboBox.FormattingEnabled = True
        Me.TricycleStatusComboBox.Items.AddRange(New Object() {"Operational", "Under Maintenance"})
        Me.TricycleStatusComboBox.Location = New System.Drawing.Point(121, 235)
        Me.TricycleStatusComboBox.Name = "TricycleStatusComboBox"
        Me.TricycleStatusComboBox.Size = New System.Drawing.Size(200, 21)
        Me.TricycleStatusComboBox.TabIndex = 7
        '
        'BrandNameTextBox
        '
        Me.BrandNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TricyclesBindingSource, "BrandName", True))
        Me.BrandNameTextBox.Location = New System.Drawing.Point(121, 131)
        Me.BrandNameTextBox.Name = "BrandNameTextBox"
        Me.BrandNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BrandNameTextBox.TabIndex = 9
        '
        'ModelTextBox
        '
        Me.ModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TricyclesBindingSource, "Model", True))
        Me.ModelTextBox.Location = New System.Drawing.Point(121, 157)
        Me.ModelTextBox.Name = "ModelTextBox"
        Me.ModelTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ModelTextBox.TabIndex = 11
        '
        'DateAcquiredDateTimePicker
        '
        Me.DateAcquiredDateTimePicker.CustomFormat = "MMMM dd, yyyy     hh:mm tt"
        Me.DateAcquiredDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TricyclesBindingSource, "DateAcquired", True))
        Me.DateAcquiredDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateAcquiredDateTimePicker.Location = New System.Drawing.Point(121, 183)
        Me.DateAcquiredDateTimePicker.Name = "DateAcquiredDateTimePicker"
        Me.DateAcquiredDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateAcquiredDateTimePicker.TabIndex = 13
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(35, 82)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(76, 13)
        Me.lblName.TabIndex = 14
        Me.lblName.Text = "Driver's Name:"
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Location = New System.Drawing.Point(117, 82)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(54, 13)
        Me.lblFullName.TabIndex = 15
        Me.lblFullName.Text = "Full Name"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(147, 279)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(275, 25)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 17
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'TricyclesTableAdapter
        '
        Me.TricyclesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DriversTableAdapter = Nothing
        Me.TableAdapterManager.TransactionsTableAdapter = Nothing
        Me.TableAdapterManager.TricyclesTableAdapter = Me.TricyclesTableAdapter
        Me.TableAdapterManager.UpdateOrder = BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserAccountsTableAdapter = Me.UserAccountsTableAdapter
        '
        'UserAccountsTableAdapter
        '
        Me.UserAccountsTableAdapter.ClearBeforeFill = True
        '
        'DriverInformationBindingSource
        '
        Me.DriverInformationBindingSource.DataMember = "DriverInformation"
        Me.DriverInformationBindingSource.DataSource = Me.BAHTODADataSet
        '
        'DriverInformationTableAdapter
        '
        Me.DriverInformationTableAdapter.ClearBeforeFill = True
        '
        'UserAccountsBindingSource
        '
        Me.UserAccountsBindingSource.DataMember = "UserAccounts"
        Me.UserAccountsBindingSource.DataSource = Me.BAHTODADataSet
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.Location = New System.Drawing.Point(12, 9)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(114, 13)
        Me.lblClock.TabIndex = 18
        Me.lblClock.Text = "12/31/9999 88:88 AM"
        '
        'timClock
        '
        '
        'EditTricycleInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 324)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(BodyNumberLabel)
        Me.Controls.Add(Me.BodyNumberTextBox)
        Me.Controls.Add(PlateNumberLabel)
        Me.Controls.Add(Me.PlateNumberTextBox)
        Me.Controls.Add(TricycleStatusLabel)
        Me.Controls.Add(Me.TricycleStatusComboBox)
        Me.Controls.Add(BrandNameLabel)
        Me.Controls.Add(Me.BrandNameTextBox)
        Me.Controls.Add(ModelLabel)
        Me.Controls.Add(Me.ModelTextBox)
        Me.Controls.Add(DateAcquiredLabel)
        Me.Controls.Add(Me.DateAcquiredDateTimePicker)
        Me.Name = "EditTricycleInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditTricycleInfo"
        CType(Me.TricyclesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DriverInformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BAHTODADataSet As BAHTODASystem.BAHTODADataSet
    Friend WithEvents TricyclesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TricyclesTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.TricyclesTableAdapter
    Friend WithEvents TableAdapterManager As BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager
    Friend WithEvents BodyNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlateNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TricycleStatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BrandNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ModelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateAcquiredDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents DriverInformationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DriverInformationTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.DriverInformationTableAdapter
    Friend WithEvents UserAccountsTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.UserAccountsTableAdapter
    Friend WithEvents UserAccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblClock As System.Windows.Forms.Label
    Friend WithEvents timClock As System.Windows.Forms.Timer
End Class
