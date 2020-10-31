<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UserAccountsTableAdapter = New BAHTODASystem.BAHTODADataSetTableAdapters.UserAccountsTableAdapter()
        Me.TableAdapterManager = New BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager()
        Me.BAHTODADataSet = New BAHTODASystem.BAHTODADataSet()
        Me.UserAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(100, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 183)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(57, 277)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "USER I.D.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(57, 319)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PASSWORD:"
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.UserIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserIDTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserIDTextBox.Location = New System.Drawing.Point(173, 272)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(162, 29)
        Me.UserIDTextBox.TabIndex = 3
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(173, 314)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(10)
        Me.PasswordTextBox.MaxLength = 10
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(162, 29)
        Me.PasswordTextBox.TabIndex = 4
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.Color.Transparent
        Me.LoginButton.BackgroundImage = CType(resources.GetObject("LoginButton.BackgroundImage"), System.Drawing.Image)
        Me.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LoginButton.Location = New System.Drawing.Point(160, 372)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(84, 34)
        Me.LoginButton.TabIndex = 5
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Transparent
        Me.ExitButton.BackgroundImage = CType(resources.GetObject("ExitButton.BackgroundImage"), System.Drawing.Image)
        Me.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.FlatAppearance.BorderSize = 0
        Me.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.ForeColor = System.Drawing.Color.Transparent
        Me.ExitButton.Location = New System.Drawing.Point(350, 21)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(33, 27)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ExitButton.UseVisualStyleBackColor = False
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
        'LoginForm
        '
        Me.AcceptButton = Me.LoginButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(405, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UserIDTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BAHTODADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UserIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LoginButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents BAHTODADataSet As BAHTODASystem.BAHTODADataSet
    Friend WithEvents UserAccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserAccountsTableAdapter As BAHTODASystem.BAHTODADataSetTableAdapters.UserAccountsTableAdapter
    Friend WithEvents TableAdapterManager As BAHTODASystem.BAHTODADataSetTableAdapters.TableAdapterManager

End Class
