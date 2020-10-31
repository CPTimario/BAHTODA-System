Public Class EditDriverInfo

    Private Sub EditDriverInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        timClock.Enabled = True
        Me.UserAccountsTableAdapter.FillByUserID(Me.BAHTODADataSet.UserAccounts, ViewAddDrivers.currUserID)
        Me.TricyclesTableAdapter.FillByUserID(Me.BAHTODADataSet.Tricycles, ViewAddDrivers.currUserID)
        Me.DriversTableAdapter.FillByUserID(Me.BAHTODADataSet.Drivers, ViewAddDrivers.currUserID)
        btnSave.Enabled = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.DriversBindingSource.EndEdit()
        Me.TricyclesBindingSource.EndEdit()
        Me.DriversTableAdapter.Update(Me.BAHTODADataSet)
        Me.TricyclesTableAdapter.Update(Me.BAHTODADataSet)
        TableAdapterManager.UpdateAll(Me.BAHTODADataSet)
        MessageBox.Show("Saved!")
        btnBack.PerformClick()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        ViewAddDrivers.ViewDriverInfo()
        ViewAddDrivers.Show()
    End Sub

    Private Sub LastNameChanged() Handles LastNameTextBox.TextChanged
        lblUserID.Text = BodyNumberTextBox.Text + "-" + LastNameTextBox.Text
    End Sub

    Private Sub BodyNumberChanged() Handles BodyNumberTextBox.TextChanged
        lblUserID.Text = BodyNumberTextBox.Text + "-" + LastNameTextBox.Text
    End Sub

    Private Sub TextboxTextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlateNumberTextBox.TextChanged, ModelTextBox.TextChanged, LicenseTextBox.TextChanged, LastNameTextBox.TextChanged, FirstNameTextBox.TextChanged, ContactNumberTextBox.TextChanged, BrandNameTextBox.TextChanged, BodyNumberTextBox.TextChanged, AddressTextBox.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub DTPValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LicenseValidityDateTimePicker.ValueChanged, DateOfBirthDateTimePicker.ValueChanged, DateAcquiredDateTimePicker.ValueChanged
        btnSave.Enabled = True
    End Sub

    Private Sub ComboboxSelectedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TricycleStatusComboBox.SelectedValueChanged, DriverStatusComboBox.SelectedValueChanged
        btnSave.Enabled = True
    End Sub

    Private Sub timClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timClock.Tick
        lblClock.Text = Format(Now, "MM/dd/yyyy hh:mm tt")
    End Sub
End Class