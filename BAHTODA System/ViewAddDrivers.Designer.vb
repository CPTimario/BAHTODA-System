<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAddDrivers
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnEditDriverInfo = New System.Windows.Forms.Button()
        Me.dgvDriverInfo = New System.Windows.Forms.DataGridView()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LicenseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LicenseValidityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BodyNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DriverStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DriverInformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BAHTODADataSet = New BAHTODASystem.BAHTODADataSet()
        Me.btnAddNewDriver = New System.Windows.Forms.Button()
        Me.SearchNameTextbox = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.DriverInformationTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.DriverInformationTableAdapter()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        NameLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvDriverInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DriverInformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(38, 46)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(75, 13)
        NameLabel.TabIndex = 6
        NameLabel.Text = "Search Name:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(42, 72)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(71, 13)
        Label1.TabIndex = 12
        Label1.Text = "Driver Status:"
        '
        'btnEditDriverInfo
        '
        Me.btnEditDriverInfo.AutoSize = True
        Me.btnEditDriverInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEditDriverInfo.Location = New System.Drawing.Point(525, 67)
        Me.btnEditDriverInfo.Name = "btnEditDriverInfo"
        Me.btnEditDriverInfo.Size = New System.Drawing.Size(35, 23)
        Me.btnEditDriverInfo.TabIndex = 9
        Me.btnEditDriverInfo.Text = "Edit"
        Me.btnEditDriverInfo.UseVisualStyleBackColor = True
        '
        'dgvDriverInfo
        '
        Me.dgvDriverInfo.AllowUserToAddRows = False
        Me.dgvDriverInfo.AllowUserToDeleteRows = False
        Me.dgvDriverInfo.AllowUserToResizeColumns = False
        Me.dgvDriverInfo.AllowUserToResizeRows = False
        Me.dgvDriverInfo.AutoGenerateColumns = False
        Me.dgvDriverInfo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDriverInfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDriverInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDriverInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.LicenseDataGridViewTextBoxColumn, Me.LicenseValidityDataGridViewTextBoxColumn, Me.BodyNumberDataGridViewTextBoxColumn, Me.BalanceDataGridViewTextBoxColumn, Me.DriverStatusDataGridViewTextBoxColumn})
        Me.dgvDriverInfo.DataSource = Me.DriverInformationBindingSource
        Me.dgvDriverInfo.Location = New System.Drawing.Point(12, 96)
        Me.dgvDriverInfo.MultiSelect = False
        Me.dgvDriverInfo.Name = "dgvDriverInfo"
        Me.dgvDriverInfo.ReadOnly = True
        Me.dgvDriverInfo.RowHeadersVisible = False
        Me.dgvDriverInfo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgvDriverInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDriverInfo.Size = New System.Drawing.Size(615, 303)
        Me.dgvDriverInfo.TabIndex = 5
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        Me.UserIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserIDDataGridViewTextBoxColumn.Visible = False
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        Me.AgeDataGridViewTextBoxColumn.ReadOnly = True
        Me.AgeDataGridViewTextBoxColumn.Width = 51
        '
        'LicenseDataGridViewTextBoxColumn
        '
        Me.LicenseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.LicenseDataGridViewTextBoxColumn.DataPropertyName = "License"
        Me.LicenseDataGridViewTextBoxColumn.HeaderText = "License Number"
        Me.LicenseDataGridViewTextBoxColumn.Name = "LicenseDataGridViewTextBoxColumn"
        Me.LicenseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LicenseValidityDataGridViewTextBoxColumn
        '
        Me.LicenseValidityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.LicenseValidityDataGridViewTextBoxColumn.DataPropertyName = "LicenseValidity"
        Me.LicenseValidityDataGridViewTextBoxColumn.HeaderText = "License Validity"
        Me.LicenseValidityDataGridViewTextBoxColumn.Name = "LicenseValidityDataGridViewTextBoxColumn"
        Me.LicenseValidityDataGridViewTextBoxColumn.ReadOnly = True
        Me.LicenseValidityDataGridViewTextBoxColumn.Width = 96
        '
        'BodyNumberDataGridViewTextBoxColumn
        '
        Me.BodyNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.BodyNumberDataGridViewTextBoxColumn.DataPropertyName = "BodyNumber"
        Me.BodyNumberDataGridViewTextBoxColumn.HeaderText = "Body Number"
        Me.BodyNumberDataGridViewTextBoxColumn.Name = "BodyNumberDataGridViewTextBoxColumn"
        Me.BodyNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.BodyNumberDataGridViewTextBoxColumn.Width = 88
        '
        'BalanceDataGridViewTextBoxColumn
        '
        Me.BalanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.BalanceDataGridViewTextBoxColumn.DataPropertyName = "Balance"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "P#,0.00"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.BalanceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.BalanceDataGridViewTextBoxColumn.HeaderText = "Balance"
        Me.BalanceDataGridViewTextBoxColumn.Name = "BalanceDataGridViewTextBoxColumn"
        Me.BalanceDataGridViewTextBoxColumn.ReadOnly = True
        Me.BalanceDataGridViewTextBoxColumn.Width = 71
        '
        'DriverStatusDataGridViewTextBoxColumn
        '
        Me.DriverStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DriverStatusDataGridViewTextBoxColumn.DataPropertyName = "DriverStatus"
        Me.DriverStatusDataGridViewTextBoxColumn.HeaderText = "Driver Status"
        Me.DriverStatusDataGridViewTextBoxColumn.Name = "DriverStatusDataGridViewTextBoxColumn"
        Me.DriverStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.DriverStatusDataGridViewTextBoxColumn.Width = 86
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
        'btnAddNewDriver
        '
        Me.btnAddNewDriver.AutoSize = True
        Me.btnAddNewDriver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddNewDriver.Location = New System.Drawing.Point(566, 67)
        Me.btnAddNewDriver.Name = "btnAddNewDriver"
        Me.btnAddNewDriver.Size = New System.Drawing.Size(61, 23)
        Me.btnAddNewDriver.TabIndex = 8
        Me.btnAddNewDriver.Text = "Add New"
        Me.btnAddNewDriver.UseVisualStyleBackColor = True
        '
        'SearchNameTextbox
        '
        Me.SearchNameTextbox.Location = New System.Drawing.Point(119, 43)
        Me.SearchNameTextbox.Name = "SearchNameTextbox"
        Me.SearchNameTextbox.Size = New System.Drawing.Size(244, 20)
        Me.SearchNameTextbox.TabIndex = 7
        '
        'btnBack
        '
        Me.btnBack.AutoSize = True
        Me.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBack.Location = New System.Drawing.Point(592, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(42, 23)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cmbStatus.Location = New System.Drawing.Point(119, 69)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(244, 21)
        Me.cmbStatus.TabIndex = 11
        '
        'DriverInformationTableAdapter
        '
        Me.DriverInformationTableAdapter.ClearBeforeFill = True
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.Location = New System.Drawing.Point(12, 9)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(114, 13)
        Me.lblClock.TabIndex = 13
        Me.lblClock.Text = "12/31/9999 88:88 AM"
        '
        'timClock
        '
        '
        'ViewAddDrivers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 411)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnEditDriverInfo)
        Me.Controls.Add(Me.dgvDriverInfo)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.btnAddNewDriver)
        Me.Controls.Add(Me.SearchNameTextbox)
        Me.Name = "ViewAddDrivers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewAddDrivers"
        CType(Me.dgvDriverInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DriverInformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEditDriverInfo As System.Windows.Forms.Button
    Friend WithEvents dgvDriverInfo As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddNewDriver As System.Windows.Forms.Button
    Friend WithEvents SearchNameTextbox As System.Windows.Forms.TextBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents BAHTODADataSet As BAHTODASystem.BAHTODADataSet
    Friend WithEvents DriverInformationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DriverInformationTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.DriverInformationTableAdapter
    Friend WithEvents UserIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LicenseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LicenseValidityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BodyNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BalanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DriverStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblClock As System.Windows.Forms.Label
    Friend WithEvents timClock As System.Windows.Forms.Timer
End Class
