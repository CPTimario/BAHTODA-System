Public Class EditTricycleInfo

    Private Sub EditTricycleInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        timClock.Enabled = True
        lblFullName.Text = UserAccountsTableAdapter.GetFirstName(ViewAddTricycles.currUserID) + " " + UserAccountsTableAdapter.GetLastName(ViewAddTricycles.currUserID)
        TricyclesTableAdapter.FillByUserID(Me.BAHTODADataSet.Tricycles, ViewAddTricycles.currUserID)
        btnSave.Enabled = False
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        ViewAddTricycles.Show()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.TricyclesBindingSource.EndEdit()
        Me.TricyclesTableAdapter.Update(Me.BAHTODADataSet)
        TableAdapterManager.UpdateAll(Me.BAHTODADataSet)
        MessageBox.Show("Saved!")
        btnBack.PerformClick()
    End Sub

    Private Sub TextboxTextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TricycleStatusComboBox.TextChanged, PlateNumberTextBox.TextChanged, ModelTextBox.TextChanged, BrandNameTextBox.TextChanged, BodyNumberTextBox.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub DateAcquiredDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateAcquiredDateTimePicker.ValueChanged
        btnSave.Enabled = True
    End Sub

    Private Sub timClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timClock.Tick
        lblClock.Text = Format(Now, "MM/dd/yyyy hh:mm tt")
    End Sub
End Class