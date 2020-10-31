Public Class EditTransaction

    Dim transFee1, transFee2, balance As Double
    Public transNum As Integer
    Dim approve As Boolean

    Private Sub EditTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        timClock.Enabled = True
        Me.TransactionsTableAdapter.FillByTransNum(Me.BAHTODADataSet.Transactions, ViewDriverTransactions.currTransNum)
        ResetView()
    End Sub

    Private Sub ResetView()
        approve = False
        RemainingBalanceVisible()
        transNum = Val(TransactionNumberTextBox.Text)
        TransactionNumberTextBox.Text = Format(transNum, "00000000")
        transFee1 = Val(TransactionFeeTextBox.Text)
        If TransactionTypeComboBox.SelectedIndex = 1 Then
            transFee2 = Val(TransactionFeeTextBox.Text)
        End If
        TransactionFeeTextBox.Text = Format(transFee1, "P#,0.00")
        Select Case LoginForm.userType
            Case "Super Administrator"
                TransactionTypeComboBox.Enabled = True
                TransactionDateDateTimePicker.Enabled = True
            Case "Administrator"
                TransactionTypeComboBox.Enabled = False
                TransactionDateDateTimePicker.Enabled = False
        End Select
        If TransactionStatusComboBox.SelectedIndex = 0 Then
            btnApprove.Enabled = True
        Else
            btnApprove.Enabled = False
        End If
        btnSave.Enabled = False
    End Sub

    Private Sub RemainingBalanceVisible()
        If TransactionTypeComboBox.SelectedIndex = 1 Then
            Me.DriversTableAdapter.FillByUserID(Me.BAHTODADataSet.Drivers, lblUserID.Text)
            lblBalance.Visible = True
            BalanceTextBox.Visible = True
            balance = Val(BalanceTextBox.Text)
            BalanceTextBox.Text = Format(balance, "P#,0.00")
        Else
            lblBalance.Visible = False
            BalanceTextBox.Visible = False
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        ViewDriverTransactions.ViewTransactionInfo()
        ViewDriverTransactions.Show()
    End Sub

    Private Sub TransactionTypeComboBox_SelectedIndexChanged() Handles TransactionTypeComboBox.SelectedIndexChanged
        Select Case TransactionTypeComboBox.SelectedIndex
            Case 0
                btnEdit.Enabled = False
                transFee1 = 180.0
                TransactionFeeTextBox.Text = Format(transFee1, "P#,0.00")
            Case 1
                btnEdit.Enabled = True
                transFee1 = 300.0
                TransactionFeeTextBox.Text = Format(transFee1, "P#,0.00")
            Case 2
                btnEdit.Enabled = False
                transFee1 = 0.0
                TransactionFeeTextBox.Text = Format(transFee1, "P#,0.00")
        End Select
        RemainingBalanceVisible()
    End Sub

    Private Sub TextboxTextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionNumberTextBox.TextChanged, TransactionFeeTextBox.TextChanged
        btnSave.Enabled = True
        btnApprove.Enabled = False
    End Sub

    Private Sub TransactionDateDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionDateDateTimePicker.ValueChanged
        btnSave.Enabled = True
        btnApprove.Enabled = False
    End Sub

    Private Sub ComboboxIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionTypeComboBox.SelectedValueChanged, TransactionStatusComboBox.SelectedValueChanged
        btnSave.Enabled = True
        btnApprove.Enabled = False
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Me.Enabled = False
        InputFee.Show()
    End Sub

    Public Sub PrintFee()
        transFee1 = InputFee.fee
        TransactionFeeTextBox.Text = Format(transFee1, "P#,0.00")
    End Sub

    Private Sub btnApprove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApprove.Click
        approve = True
        TransactionStatusComboBox.SelectedIndex = 1
        btnSave.PerformClick()
        Me.Hide()
        Receipt.Show()
    End Sub

    Private Sub TransactionStatusComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionStatusComboBox.SelectedIndexChanged

    End Sub

    Private Sub timClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timClock.Tick
        lblClock.Text = Format(Now, "MM/dd/yyyy hh:mm tt")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim msg As String
        If TransactionTypeComboBox.Text = "Installment Pay" And transFee1 = 0 Then
            MessageBox.Show("Transaction Fee must have a value.")
        Else
            If TransactionTypeComboBox.Text = "Installment Pay" Then
                If TransactionStatusComboBox.Text = "Finished" Then
                    If transFee2 = transFee1 Then
                        balance = balance - transFee1
                    Else
                        balance = balance + transFee2 - transFee1
                    End If
                End If
            Else
                balance = balance - transFee1
            End If
            BalanceTextBox.Text = Str(balance)
            TransactionFeeTextBox.Text = Str(transFee1)
            Me.Validate()
            Me.TransactionsBindingSource.EndEdit()
            Me.DriversBindingSource.EndEdit()
            Me.TransactionsTableAdapter.Update(Me.BAHTODADataSet)
            Me.DriversTableAdapter.Update(Me.BAHTODADataSet)
            TableAdapterManager.UpdateAll(Me.BAHTODADataSet)
            If approve Then
                msg = "Approved!"
            Else
                msg = "Saved!"
            End If
            MessageBox.Show(msg)
            ResetView()
        End If
    End Sub
End Class