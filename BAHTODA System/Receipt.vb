Public Class Receipt

    Private Sub Receipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DriverTransactionTableAdapter.FillByTransNumber(Me.BAHTODADataSet.DriverTransaction, EditTransaction.transNum)
        Me.rvReceipt.RefreshReport()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        EditTransaction.Close()
        ViewDriverTransactions.ViewTransactionInfo()
        ViewDriverTransactions.Show()
    End Sub
End Class