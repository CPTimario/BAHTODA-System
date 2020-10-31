Public Class ManageAccounts

    Public currUserID As String
    Dim ind As Integer

    Public Sub ViewAccountsInfo()
        Me.ViewUserAccountsTableAdapter.Fill(Me.BAHTODADataSet.ViewUserAccounts)
        If dgvUserAccounts.RowCount > 0 Then
            btnEditAccount.Enabled = True
            ind = 0
            currUserID = dgvUserAccounts.Rows(0).Cells(1).Value.ToString
        End If
    End Sub

    Private Sub ManageAccounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        timClock.Enabled = True
        btnEditAccount.Enabled = False
        ViewAccountsInfo()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        SuperAdminForm.Show()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            Me.ViewUserAccountsTableAdapter.SearchByName(Me.BAHTODADataSet.ViewUserAccounts, txtSearch.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvUserAccounts_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUserAccounts.CellClick
        ind = dgvUserAccounts.CurrentCell.RowIndex
        currUserID = dgvUserAccounts.Rows(ind).Cells(1).Value.ToString
    End Sub

    Private Sub btnEditAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditAccount.Click
        Me.Hide()
        EditAccounts.Show()
    End Sub

    Private Sub timClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timClock.Tick
        lblClock.Text = Format(Now, "MM/dd/yyyy hh:mm tt")
    End Sub
End Class