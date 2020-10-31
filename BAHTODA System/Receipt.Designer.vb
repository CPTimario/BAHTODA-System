<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Receipt
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DriverTransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BAHTODADataSet = New BAHTODASystem.BAHTODADataSet()
        Me.rvReceipt = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DriverTransactionTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.DriverTransactionTableAdapter()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.DriverTransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DriverTransactionBindingSource
        '
        Me.DriverTransactionBindingSource.DataMember = "DriverTransaction"
        Me.DriverTransactionBindingSource.DataSource = Me.BAHTODADataSet
        '
        'BAHTODADataSet
        '
        Me.BAHTODADataSet.DataSetName = "BAHTODADataSet"
        Me.BAHTODADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rvReceipt
        '
        ReportDataSource1.Name = "Receipt"
        ReportDataSource1.Value = Me.DriverTransactionBindingSource
        Me.rvReceipt.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvReceipt.LocalReport.ReportEmbeddedResource = "BAHTODASystem.ReceiptReport.rdlc"
        Me.rvReceipt.Location = New System.Drawing.Point(12, 41)
        Me.rvReceipt.Name = "rvReceipt"
        Me.rvReceipt.ShowBackButton = False
        Me.rvReceipt.ShowExportButton = False
        Me.rvReceipt.ShowFindControls = False
        Me.rvReceipt.ShowRefreshButton = False
        Me.rvReceipt.ShowStopButton = False
        Me.rvReceipt.Size = New System.Drawing.Size(500, 323)
        Me.rvReceipt.TabIndex = 0
        Me.rvReceipt.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'DriverTransactionTableAdapter
        '
        Me.DriverTransactionTableAdapter.ClearBeforeFill = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(437, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 376)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.rvReceipt)
        Me.Name = "Receipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receipt"
        CType(Me.DriverTransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rvReceipt As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DriverTransactionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BAHTODADataSet As BAHTODASystem.BAHTODADataSet
    Friend WithEvents DriverTransactionTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.DriverTransactionTableAdapter
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
