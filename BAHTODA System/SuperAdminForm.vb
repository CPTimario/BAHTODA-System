Public Class SuperAdminForm

    Private Sub SuperAdminForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        timClock.Enabled = True
        lblWelcome.Text = "Welcome " + UserAccountsTableAdapter.GetFirstName(LoginForm.userID) + "!"
    End Sub

    Private Sub btnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub timClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timClock.Tick
        lblTime.Text = Format(Now, "MM/dd/yyyy hh:mm tt")
    End Sub

    Private Sub ViewEditDriver(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DriversLabel.Click, DriversButton.Click
        Me.Close()
        ViewAddDrivers.Show()
    End Sub

    Private Sub ViewEditTricycle(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TricyclesLabel.Click, TricyclesButton.Click
        Me.Close()
        ViewAddTricycles.Show()
    End Sub

    Private Sub ManageAccount(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountsLabel.Click, AccountsButton.Click
        Me.Close()
        ManageAccounts.Show()
    End Sub

    Private Sub ViewEditTransaction(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionsLabel.Click, TransactionsButton.Click
        Me.Close()
        ViewDriverTransactions.Show()
    End Sub
End Class
