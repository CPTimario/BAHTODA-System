Public Class UserForm

    Dim balance As Double

    Private Sub UserForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        timClock.Enabled = True
        DriverInformationTableAdapter.FillByUserID(Me.BAHTODADataSet.DriverInformation, LoginForm.userID)
        DriverTransactionTableAdapter.FillPendingTransaction(Me.BAHTODADataSet.DriverTransaction, LoginForm.userID)
        balance = Val(lblBalanceRemain.Text)
        lblBalanceRemain.Text = Format(balance, "P#,0.00")
    End Sub

    Private Sub Logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Logout.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        Me.Close()
        AddTransactions.Show()
    End Sub

    Private Sub timClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timClock.Tick
        lblDate.Text = Format(Now, "MM/dd/yyyy hh:mm tt")
    End Sub
End Class
