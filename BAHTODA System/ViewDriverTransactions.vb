Public Class ViewDriverTransactions

    Public fnx, transType, transStat, requestor As String
    Public currTransNum As Integer
    Public fromDate, toDate As DateTime
    Dim ind As Integer

    Public Sub ViewTransactionInfo()
        Select Case LoginForm.userType
            Case "Super Administrator"
                btnAddTransaction.Visible = True
                btnEditTransaction.Text = "Approve/Edit"
                ShowTransactions()
            Case "Administrator"
                btnAddTransaction.Visible = False
                btnEditTransaction.Text = "Approve"
                ShowTransactions()
        End Select
        EditEnabled()
    End Sub

    Private Sub ViewDriverTransactions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        timClock.Enabled = True
        btnEditTransaction.Enabled = False
        ViewTransactionInfo()
        cmbType.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1
        fromDate = dtpFromDate.Value.Date
        toDate = dtpToDate.Value.Date
        requestor = ""
        txtSearchName.Enabled = False
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        Select Case LoginForm.userType
            Case "Super Administrator"
                SuperAdminForm.Show()
            Case "Administrator"
                AdminForm.Show()
        End Select
    End Sub

    Private Sub dgvTransactionInfo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvViewTransaction.CellClick
        ind = dgvViewTransaction.CurrentCell.RowIndex
        currTransNum = dgvViewTransaction.Rows(ind).Cells(1).Value.ToString
    End Sub

    Private Sub btnEditTransactionInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditTransaction.Click
        fnx = "Edit"
        Me.Hide()
        EditTransaction.Show()
    End Sub

    Private Sub txtSearchName_TextChanged() Handles txtSearchName.TextChanged
        requestor = txtSearchName.Text
        ShowTransactions()
    End Sub

    Private Sub btnAddTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTransaction.Click
        fnx = "Add"
        Me.Hide()
        AddNewTransaction.Show()
    End Sub

    Private Sub EditEnabled()
        If dgvViewTransaction.RowCount > 0 Then
            ind = dgvViewTransaction.CurrentCell.RowIndex
            currTransNum = dgvViewTransaction.Rows(ind).Cells(1).Value.ToString
            If LoginForm.userType = "Administrator" And dgvViewTransaction.Rows(ind).Cells(5).Value.ToString = "Finished" Then
                btnEditTransaction.Enabled = False
            Else
                btnEditTransaction.Enabled = True
            End If
        Else
            btnEditTransaction.Enabled = False
        End If
    End Sub

    Private Sub dtpToDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpToDate.ValueChanged
        If dtpToDate.Value.Date < dtpFromDate.Value.Date Or dtpToDate.Value.Date > Date.Now Then
            MessageBox.Show("Invalid Input!")
            dtpToDate.Value = Date.Now
        End If
        toDate = dtpToDate.Value.Date
    End Sub

    Private Sub dtpFromDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFromDate.ValueChanged
        If dtpFromDate.Value.Date > Date.Now Then
            MessageBox.Show("Invalid Input!")
            dtpFromDate.Value = Date.Now
        End If
        fromDate = dtpFromDate.Value.Date
    End Sub

    Private Sub ShowTransactions()
        Try
            DriverTransactionTableAdapter.Search(Me.BAHTODADataSet.DriverTransaction, fromDate, toDate, requestor, transType, transStat)
            EditEnabled()
            If dgvViewTransaction.RowCount > 0 Then
                txtSearchName.Enabled = True
            Else
                txtSearchName.Enabled = False
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If cmbType.SelectedIndex >= 0 Or cmbStatus.SelectedIndex >= 0 Then
            ShowTransactions()
        Else
            MessageBox.Show("Kindly fill all necessary fields")
        End If
    End Sub

    Private Sub btnViewReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewReport.Click
        Me.Hide()
        TransactionReportForm.Show()
    End Sub

    Private Sub cmbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbType.SelectedIndexChanged
        If cmbType.SelectedIndex = 0 Then
            transType = ""
        Else
            transType = cmbType.Text
        End If
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStatus.SelectedIndexChanged
        If cmbStatus.SelectedIndex = 0 Then
            transStat = ""
        Else
            transStat = cmbStatus.Text
        End If
    End Sub

    Private Sub timClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timClock.Tick
        lblClock.Text = Format(Now, "MM/dd/yyyy hh:mm tt")
    End Sub
End Class