Public Class AddTransactions

    Dim username As String = LoginForm.userID
    Dim transFee As Double = 0
    Public fnx As String

    Private Sub AddTransactions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        timClock.Enabled = True
        Dim maxTransNum As Integer
        Try
            maxTransNum = TransactionsTableAdapter.GetMaxTransNumber()
        Catch ex As Exception
            maxTransNum = 0
        End Try
        TransactionType.SelectedItem = "Boundary"
        lblTransNum.Text = Format(maxTransNum + 1, "00000000")
    End Sub

    Private Sub TransactionType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionType.SelectedIndexChanged
        Select Case TransactionType.SelectedItem
            Case "Boundary"
                transFee = 180
                TransactionFeeTextBox.Text = Format(transFee, "P#,0.00")
            Case "Installment Pay"
                transFee = 0
                TransactionFeeTextBox.Text = Format(transFee, "P#,0.00")
            Case "Maintenance"
                transFee = 0
                TransactionFeeTextBox.Text = Format(transFee, "P#,0.00")
        End Select
    End Sub

    Private Sub AddTransactionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddTransactionButton.Click
        If TransactionType.Text = "Installment Pay" And transFee = 0 Then
            MessageBox.Show("Transaction Fee must have a value")
        Else
            TransactionsTableAdapter.Insert(Val(lblTransNum.Text), TransactionType.Text, Now.Date, transFee, username, "Pending")
            MessageBox.Show("Added!", "Add Transaction", MessageBoxButtons.OK)
            Me.Close()
            UserForm.Show()
        End If
    End Sub

    Private Sub CancelTransactionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelTransactionButton.Click
        Me.Close()
        UserForm.Show()
    End Sub

    Private Sub timClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timClock.Tick
        TransactionDate.Text = Format(Now, "MM/dd/yyyy hh:mm tt")
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        fnx = "Add Transaction"
        Me.Enabled = False
        InputFee.Show()
    End Sub

    Public Sub PrintFee()
        transFee = InputFee.fee
        TransactionFeeTextBox.Text = Format(transFee, "P#,0.00")
    End Sub
End Class