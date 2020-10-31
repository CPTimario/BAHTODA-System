Public Class AddNewTransaction

    Dim transFee As Double
    Dim userID As String

    Private Sub NewTransaction()
        Dim maxTransNum As Integer
        Try
            maxTransNum = TransactionsTableAdapter.GetMaxTransNumber()
        Catch ex As Exception
            maxTransNum = 0
        End Try
        TransactionDateDateTimePicker.Value = Date.Now
        TransactionNumberTextBox.Text = Format(maxTransNum + 1, "00000000")
        TransactionTypeComboBox.SelectedIndex = -1
        TransactionStatusComboBox.SelectedIndex = 0
        transFee = Val(TransactionFeeTextBox.Text)
        TransactionFeeTextBox.Text = Format(transFee, "P#,0.00")
        Me.DriverInformationTableAdapter.Fill(Me.BAHTODADataSet.DriverInformation)
        NameComboBox.SelectedIndex = -1
    End Sub

    Private Sub AddNewTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        timClock.Enabled = True
        pnlAddManual.Enabled = False
        NewTransaction()
    End Sub

    Private Sub TransactionTypeComboBox_SelectedIndexChanged() Handles TransactionTypeComboBox.SelectedIndexChanged
        Select Case TransactionTypeComboBox.SelectedIndex
            Case 0
                btnEdit.Enabled = False
                transFee = 180.0
                TransactionFeeTextBox.Text = Format(transFee, "P#,0.00")
            Case 1
                btnEdit.Enabled = True
                transFee = 300.0
                TransactionFeeTextBox.Text = Format(transFee, "P#,0.00")
            Case 2
                btnEdit.Enabled = False
                transFee = 0.0
                TransactionFeeTextBox.Text = Format(transFee, "P#,0.00")
        End Select
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Me.Enabled = False
        InputFee.Show()
    End Sub

    Public Sub PrintFee()
        transFee = InputFee.fee
        TransactionFeeTextBox.Text = Format(transFee, "P#,0.00")
    End Sub

    Private Sub AddTransactionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddTransactionButton.Click
        If TransactionTypeComboBox.Text = "Installment Pay" And transFee = 0 Then
            MessageBox.Show("Transaction Fee must have a value")
        Else
            Try
                TransactionsTableAdapter.Insert(Val(TransactionNumberTextBox.Text), TransactionTypeComboBox.Text, TransactionDateDateTimePicker.Value.Date, transFee, userID, TransactionStatusComboBox.Text)
                MessageBox.Show("Added!")
                NewTransaction()
            Catch ex As Exception
                MessageBox.Show("Please fill all necessary fields.")
            End Try
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        ViewDriverTransactions.ViewTransactionInfo()
        ViewDriverTransactions.Show()
    End Sub

    Private Sub rbManual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbManual.CheckedChanged
        If rbManual.Checked Then
            pnlAddManual.Enabled = True
        End If
    End Sub

    Private Sub rbImport_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbImport.CheckedChanged
        If rbImport.Checked Then
            Me.Close()
            ImportExcel.Show()
        End If
    End Sub

    Private Sub NameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameComboBox.SelectedIndexChanged
        userID = DriverInformationTableAdapter.GetUserID(NameComboBox.Text)
    End Sub

    Private Sub timClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timClock.Tick
        lblClock.Text = Format(Now, "MM/dd/yyyy hh:mm tt")
    End Sub
End Class