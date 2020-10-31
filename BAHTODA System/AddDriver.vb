Public Class AddDriver

    Dim tricFee As Double
    Public fnx, addString As String

    Private Sub AddDriver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BAHTODADataSet.DriverTransaction' table. You can move, or remove it, as needed.
        Me.DriverTransactionTableAdapter.Fill(Me.BAHTODADataSet.DriverTransaction)
        timClock.Enabled = True
        ResetFields()
    End Sub

    Private Sub ResetFields()
        txtUserID.Text = ""
        txtLastName.Text = ""
        txtFirstName.Text = ""
        dtpDateOfBirth.Value = Now
        txtLicence.Text = ""
        dtpLicenceValid.Value = Now
        txtAddress.Text = ""
        txtContactNum.Text = ""
        cbDriverStat.SelectedIndex = 0
        txtBodyNum.Text = ""
        txtPlateNum.Text = ""
        cbTricycleStat.SelectedIndex = 0
        txtBrandName.Text = ""
        dtpDateAcquired.Value = Now
        txtModel.Text = ""
        tricFee = 0
        BalanceTextBox.Text = Format(tricFee, "P#,0.00")
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            UserAccountsTableAdapter.Insert(txtUserID.Text, "bahtoda123", "User", txtFirstName.Text, txtLastName.Text)
            DriversTableAdapter.Insert(txtUserID.Text, dtpDateOfBirth.Value, txtLicence.Text, dtpLicenceValid.Value.Date, txtAddress.Text, txtContactNum.Text, cbDriverStat.Text, tricFee)
            TricyclesTableAdapter.Insert(txtBodyNum.Text, txtUserID.Text, txtPlateNum.Text, cbTricycleStat.Text, txtBrandName.Text, dtpDateAcquired.Value, txtModel.Text)
            MessageBox.Show("Added!")
            ResetFields()
        Catch ex As Exception
            MessageBox.Show("Please fill all necessary fields.")
        End Try
    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
        Me.Close()
        ViewAddDrivers.Show()
    End Sub

    Public Sub PrintTricFee()
        tricFee = InputFee.fee
        BalanceTextBox.Text = Format(tricFee, "P#,0.00")
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        fnx = "Add Driver"
        Me.Enabled = False
        InputFee.Show()
    End Sub

    Private Sub timClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timClock.Tick
        lblClock.Text = Format(Now, "MM/dd/yyyy hh:mm tt")
    End Sub
End Class