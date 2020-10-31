Public Class TransactionReportForm

    Dim dateNow As DateTime = Date.Now

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fromDate = ViewDriverTransactions.fromDate
        Dim toDate = ViewDriverTransactions.toDate
        Dim requestor = ViewDriverTransactions.requestor
        Dim transType = ViewDriverTransactions.transType
        Dim transStat = ViewDriverTransactions.transStat
        Me.DriverTransactionTableAdapter.Search(Me.BAHTODADataSet.DriverTransaction, fromDate, toDate, requestor, transType, transStat)
        Me.TransactionReport.RefreshReport()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        ViewDriverTransactions.Show()
    End Sub

    Private Sub TransactionReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionReport.Load

    End Sub
End Class