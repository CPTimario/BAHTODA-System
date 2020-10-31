<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAddTricycles
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
        Me.btnEditTricInfo = New System.Windows.Forms.Button()
        Me.dgvTricycleInfo = New System.Windows.Forms.DataGridView()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DriverDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BodyNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlateNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateAcquiredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TricycleStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewTricycleInformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BAHTODADataSet = New BAHTODASystem.BAHTODADataSet()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.TricyclesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnBack = New System.Windows.Forms.Button()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.TricyclesTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.TricyclesTableAdapter()
        Me.TableAdapterManager = New BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager()
        Me.ViewTricycleInformationTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.ViewTricycleInformationTableAdapter()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        Me.lblClock = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvTricycleInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewTricycleInformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TricyclesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(33, 62)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(75, 13)
        NameLabel.TabIndex = 5
        NameLabel.Text = "Search Driver:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(33, 88)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(80, 13)
        Label1.TabIndex = 13
        Label1.Text = "Tricycle Status:"
        '
        'btnEditTricInfo
        '
        Me.btnEditTricInfo.AutoSize = True
        Me.btnEditTricInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEditTricInfo.Location = New System.Drawing.Point(591, 83)
        Me.btnEditTricInfo.Name = "btnEditTricInfo"
        Me.btnEditTricInfo.Size = New System.Drawing.Size(35, 23)
        Me.btnEditTricInfo.TabIndex = 8
        Me.btnEditTricInfo.Text = "Edit"
        Me.btnEditTricInfo.UseVisualStyleBackColor = True
        '
        'dgvTricycleInfo
        '
        Me.dgvTricycleInfo.AllowUserToAddRows = False
        Me.dgvTricycleInfo.AllowUserToDeleteRows = False
        Me.dgvTricycleInfo.AllowUserToOrderColumns = True
        Me.dgvTricycleInfo.AllowUserToResizeColumns = False
        Me.dgvTricycleInfo.AllowUserToResizeRows = False
        Me.dgvTricycleInfo.AutoGenerateColumns = False
        Me.dgvTricycleInfo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTricycleInfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTricycleInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTricycleInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIDDataGridViewTextBoxColumn, Me.DriverDataGridViewTextBoxColumn, Me.BodyNumberDataGridViewTextBoxColumn, Me.BrandNameDataGridViewTextBoxColumn, Me.ModelDataGridViewTextBoxColumn, Me.PlateNumberDataGridViewTextBoxColumn, Me.DateAcquiredDataGridViewTextBoxColumn, Me.TricycleStatusDataGridViewTextBoxColumn})
        Me.dgvTricycleInfo.DataSource = Me.ViewTricycleInformationBindingSource
        Me.dgvTricycleInfo.Location = New System.Drawing.Point(12, 112)
        Me.dgvTricycleInfo.MultiSelect = False
        Me.dgvTricycleInfo.Name = "dgvTricycleInfo"
        Me.dgvTricycleInfo.ReadOnly = True
        Me.dgvTricycleInfo.RowHeadersVisible = False
        Me.dgvTricycleInfo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgvTricycleInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTricycleInfo.Size = New System.Drawing.Size(618, 303)
        Me.dgvTricycleInfo.TabIndex = 6
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        Me.UserIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserIDDataGridViewTextBoxColumn.Visible = False
        '
        'DriverDataGridViewTextBoxColumn
        '
        Me.DriverDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DriverDataGridViewTextBoxColumn.DataPropertyName = "Driver"
        Me.DriverDataGridViewTextBoxColumn.HeaderText = "Driver"
        Me.DriverDataGridViewTextBoxColumn.Name = "DriverDataGridViewTextBoxColumn"
        Me.DriverDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BodyNumberDataGridViewTextBoxColumn
        '
        Me.BodyNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.BodyNumberDataGridViewTextBoxColumn.DataPropertyName = "BodyNumber"
        Me.BodyNumberDataGridViewTextBoxColumn.HeaderText = "Body Number"
        Me.BodyNumberDataGridViewTextBoxColumn.Name = "BodyNumberDataGridViewTextBoxColumn"
        Me.BodyNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.BodyNumberDataGridViewTextBoxColumn.Width = 96
        '
        'BrandNameDataGridViewTextBoxColumn
        '
        Me.BrandNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.BrandNameDataGridViewTextBoxColumn.DataPropertyName = "BrandName"
        Me.BrandNameDataGridViewTextBoxColumn.HeaderText = "Brand Name"
        Me.BrandNameDataGridViewTextBoxColumn.Name = "BrandNameDataGridViewTextBoxColumn"
        Me.BrandNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.BrandNameDataGridViewTextBoxColumn.Width = 91
        '
        'ModelDataGridViewTextBoxColumn
        '
        Me.ModelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ModelDataGridViewTextBoxColumn.DataPropertyName = "Model"
        Me.ModelDataGridViewTextBoxColumn.HeaderText = "Model"
        Me.ModelDataGridViewTextBoxColumn.Name = "ModelDataGridViewTextBoxColumn"
        Me.ModelDataGridViewTextBoxColumn.ReadOnly = True
        Me.ModelDataGridViewTextBoxColumn.Width = 61
        '
        'PlateNumberDataGridViewTextBoxColumn
        '
        Me.PlateNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PlateNumberDataGridViewTextBoxColumn.DataPropertyName = "PlateNumber"
        Me.PlateNumberDataGridViewTextBoxColumn.HeaderText = "Plate Number"
        Me.PlateNumberDataGridViewTextBoxColumn.Name = "PlateNumberDataGridViewTextBoxColumn"
        Me.PlateNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.PlateNumberDataGridViewTextBoxColumn.Width = 96
        '
        'DateAcquiredDataGridViewTextBoxColumn
        '
        Me.DateAcquiredDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DateAcquiredDataGridViewTextBoxColumn.DataPropertyName = "DateAcquired"
        Me.DateAcquiredDataGridViewTextBoxColumn.HeaderText = "Date Acquired"
        Me.DateAcquiredDataGridViewTextBoxColumn.Name = "DateAcquiredDataGridViewTextBoxColumn"
        Me.DateAcquiredDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TricycleStatusDataGridViewTextBoxColumn
        '
        Me.TricycleStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TricycleStatusDataGridViewTextBoxColumn.DataPropertyName = "TricycleStatus"
        Me.TricycleStatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.TricycleStatusDataGridViewTextBoxColumn.Name = "TricycleStatusDataGridViewTextBoxColumn"
        Me.TricycleStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.TricycleStatusDataGridViewTextBoxColumn.Width = 62
        '
        'ViewTricycleInformationBindingSource
        '
        Me.ViewTricycleInformationBindingSource.DataMember = "ViewTricycleInformation"
        Me.ViewTricycleInformationBindingSource.DataSource = Me.BAHTODADataSet
        '
        'BAHTODADataSet
        '
        Me.BAHTODADataSet.DataSetName = "BAHTODADataSet"
        Me.BAHTODADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(119, 59)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(205, 20)
        Me.txtSearch.TabIndex = 7
        '
        'TricyclesBindingSource
        '
        Me.TricyclesBindingSource.DataMember = "Tricycles"
        Me.TricyclesBindingSource.DataSource = Me.BAHTODADataSet
        '
        'btnBack
        '
        Me.btnBack.AutoSize = True
        Me.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBack.Location = New System.Drawing.Point(591, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(42, 23)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Operational", "Under Maintenance"})
        Me.cmbStatus.Location = New System.Drawing.Point(119, 85)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(205, 21)
        Me.cmbStatus.TabIndex = 12
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
        Me.TableAdapterManager.UserAccountsTableAdapter = Nothing
        '
        'ViewTricycleInformationTableAdapter
        '
        Me.ViewTricycleInformationTableAdapter.ClearBeforeFill = True
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
        Me.lblClock.TabIndex = 14
        Me.lblClock.Text = "12/31/9999 88:88 AM"
        '
        'ViewAddTricycles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 427)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnEditTricInfo)
        Me.Controls.Add(Me.dgvTricycleInfo)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.txtSearch)
        Me.Name = "ViewAddTricycles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewAddTricycles"
        CType(Me.dgvTricycleInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewTricycleInformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TricyclesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEditTricInfo As System.Windows.Forms.Button
    Friend WithEvents dgvTricycleInfo As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents BAHTODADataSet As BAHTODASystem.BAHTODADataSet
    Friend WithEvents TricyclesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TricyclesTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.TricyclesTableAdapter
    Friend WithEvents TableAdapterManager As BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager
    Friend WithEvents ViewTricycleInformationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViewTricycleInformationTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.ViewTricycleInformationTableAdapter
    Friend WithEvents UserIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DriverDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BodyNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BrandNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlateNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateAcquiredDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TricycleStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents timClock As System.Windows.Forms.Timer
    Friend WithEvents lblClock As System.Windows.Forms.Label
End Class
