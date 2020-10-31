Public Class EditAccounts

    Private Sub EditAccounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        timClock.Enabled = True
        Me.UserAccountsTableAdapter.FillByUserID(Me.BAHTODADataSet.UserAccounts, ManageAccounts.currUserID)
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        ManageAccounts.ViewAccountsInfo()
        ManageAccounts.Show()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.UserAccountsBindingSource.EndEdit()
        Me.UserAccountsTableAdapter.Update(Me.BAHTODADataSet)
        TableAdapterManager.UpdateAll(Me.BAHTODADataSet)
        MessageBox.Show("Saved!")
        btnBack.PerformClick()
    End Sub

    Private Sub TextboxTextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserIDTextBox.TextChanged, PasswordTextBox.TextChanged, LastNameTextBox.TextChanged, FirstNameTextBox.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub UserTypeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserTypeComboBox.SelectedIndexChanged
        btnSave.Enabled = True
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        PasswordTextBox.Text = "bahtoda123"
        Me.Validate()
        Me.UserAccountsBindingSource.EndEdit()
        Me.UserAccountsTableAdapter.Update(Me.BAHTODADataSet)
        TableAdapterManager.UpdateAll(Me.BAHTODADataSet)
        MessageBox.Show("Password reset successful!")
    End Sub

    Private Sub timClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timClock.Tick
        lblClock.Text = Format(Now, "MM/dd/yyyy hh:mm tt")
    End Sub
End Class