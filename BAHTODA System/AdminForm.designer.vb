<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.TricyclesLabel = New System.Windows.Forms.Label()
        Me.TricyclesButton = New System.Windows.Forms.Button()
        Me.DriversLabel = New System.Windows.Forms.Label()
        Me.DriversButton = New System.Windows.Forms.Button()
        Me.TransactionsLabel = New System.Windows.Forms.Label()
        Me.TransactionsButton = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        Me.BAHTODADataSet = New BAHTODASystem.BAHTODADataSet()
        Me.UserAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserAccountsTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.UserAccountsTableAdapter()
        Me.TableAdapterManager = New BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(369, 20)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(173, 18)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "12/31/9999 88:88 PM"
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.Red
        Me.btnLogOut.BackgroundImage = CType(resources.GetObject("btnLogOut.BackgroundImage"), System.Drawing.Image)
        Me.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Location = New System.Drawing.Point(548, 12)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(40, 34)
        Me.btnLogOut.TabIndex = 2
        Me.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'TricyclesLabel
        '
        Me.TricyclesLabel.BackColor = System.Drawing.Color.Transparent
        Me.TricyclesLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TricyclesLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TricyclesLabel.Location = New System.Drawing.Point(395, 258)
        Me.TricyclesLabel.Name = "TricyclesLabel"
        Me.TricyclesLabel.Size = New System.Drawing.Size(100, 34)
        Me.TricyclesLabel.TabIndex = 11
        Me.TricyclesLabel.Text = "View/Edit Tricycles Info"
        Me.TricyclesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TricyclesButton
        '
        Me.TricyclesButton.BackgroundImage = CType(resources.GetObject("TricyclesButton.BackgroundImage"), System.Drawing.Image)
        Me.TricyclesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TricyclesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TricyclesButton.Location = New System.Drawing.Point(398, 173)
        Me.TricyclesButton.Name = "TricyclesButton"
        Me.TricyclesButton.Size = New System.Drawing.Size(90, 82)
        Me.TricyclesButton.TabIndex = 10
        Me.TricyclesButton.UseVisualStyleBackColor = True
        '
        'DriversLabel
        '
        Me.DriversLabel.BackColor = System.Drawing.Color.Transparent
        Me.DriversLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DriversLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DriversLabel.Location = New System.Drawing.Point(244, 258)
        Me.DriversLabel.Name = "DriversLabel"
        Me.DriversLabel.Size = New System.Drawing.Size(100, 33)
        Me.DriversLabel.TabIndex = 9
        Me.DriversLabel.Text = "View/Edit Drivers Info"
        Me.DriversLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DriversButton
        '
        Me.DriversButton.BackgroundImage = CType(resources.GetObject("DriversButton.BackgroundImage"), System.Drawing.Image)
        Me.DriversButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DriversButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DriversButton.Location = New System.Drawing.Point(247, 173)
        Me.DriversButton.Name = "DriversButton"
        Me.DriversButton.Size = New System.Drawing.Size(90, 82)
        Me.DriversButton.TabIndex = 8
        Me.DriversButton.UseVisualStyleBackColor = True
        '
        'TransactionsLabel
        '
        Me.TransactionsLabel.BackColor = System.Drawing.Color.Transparent
        Me.TransactionsLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionsLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TransactionsLabel.Location = New System.Drawing.Point(95, 259)
        Me.TransactionsLabel.Name = "TransactionsLabel"
        Me.TransactionsLabel.Size = New System.Drawing.Size(100, 32)
        Me.TransactionsLabel.TabIndex = 7
        Me.TransactionsLabel.Text = "View/Edit Transactions"
        Me.TransactionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TransactionsButton
        '
        Me.TransactionsButton.BackColor = System.Drawing.SystemColors.Control
        Me.TransactionsButton.BackgroundImage = CType(resources.GetObject("TransactionsButton.BackgroundImage"), System.Drawing.Image)
        Me.TransactionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TransactionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TransactionsButton.Location = New System.Drawing.Point(98, 173)
        Me.TransactionsButton.Name = "TransactionsButton"
        Me.TransactionsButton.Size = New System.Drawing.Size(90, 82)
        Me.TransactionsButton.TabIndex = 6
        Me.TransactionsButton.UseVisualStyleBackColor = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblWelcome.Location = New System.Drawing.Point(212, 103)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(175, 18)
        Me.lblWelcome.TabIndex = 12
        Me.lblWelcome.Text = "Welcome, Secretary!"
        '
        'timClock
        '
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
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(608, 400)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.TricyclesLabel)
        Me.Controls.Add(Me.TricyclesButton)
        Me.Controls.Add(Me.DriversLabel)
        Me.Controls.Add(Me.DriversButton)
        Me.Controls.Add(Me.TransactionsLabel)
        Me.Controls.Add(Me.TransactionsButton)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "AdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents TricyclesLabel As System.Windows.Forms.Label
    Friend WithEvents TricyclesButton As System.Windows.Forms.Button
    Friend WithEvents DriversLabel As System.Windows.Forms.Label
    Friend WithEvents DriversButton As System.Windows.Forms.Button
    Friend WithEvents TransactionsLabel As System.Windows.Forms.Label
    Friend WithEvents TransactionsButton As System.Windows.Forms.Button
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents timClock As System.Windows.Forms.Timer
    Friend WithEvents BAHTODADataSet As BAHTODASystem.BAHTODADataSet
    Friend WithEvents UserAccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserAccountsTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.UserAccountsTableAdapter
    Friend WithEvents TableAdapterManager As BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager

End Class
