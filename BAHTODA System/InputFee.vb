Public Class InputFee

    Public fee As Double
    Dim strFee, fnx As String

    Private Sub InputFee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strFee = txtCash.Text
        fee = Val(strFee)
        txtCash.Text = Format(fee, "P#,0.00")
        If ViewDriverTransactions.fnx Is Nothing Then
            If AddDriver.fnx Is Nothing Then
                fnx = AddTransactions.fnx
            Else
                fnx = AddDriver.fnx
            End If
        Else
            fnx = ViewDriverTransactions.fnx
        End If
    End Sub

    Private Sub InputNum(ByVal btn As Button, ByVal num As Integer)
        strFee = strFee + Str(num)
        fee = Val(strFee)
        txtCash.Text = Format(fee, "P#,0.00")
    End Sub

    Private Sub Button0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button0.Click
        InputNum(Button0, 0)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        InputNum(Button9, 9)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        InputNum(Button2, 2)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        InputNum(Button3, 3)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        InputNum(Button4, 4)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        InputNum(Button5, 5)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        InputNum(Button6, 6)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        InputNum(Button7, 7)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        InputNum(Button8, 8)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        InputNum(Button1, 1)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        strFee = ""
        InputNum(Button0, 0)
    End Sub

    Private Sub btnFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinish.Click
        Select Case fnx
            Case "Add"
                AddNewTransaction.Enabled = True
                AddNewTransaction.PrintFee()
            Case "Edit"
                EditTransaction.Enabled = True
                EditTransaction.PrintFee()
            Case "Add Driver"
                AddDriver.Enabled = True
                AddDriver.PrintTricFee()
            Case "Add Transaction"
                AddTransactions.Enabled = True
                AddTransactions.PrintFee()
        End Select
        Me.Close()
    End Sub
End Class