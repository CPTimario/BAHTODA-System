Imports System.Data.OleDb
Public Class ImportExcel

    Public Shared Function ImportExceltoDatatable(ByVal filepath As String) As DataTable
        Dim dt As New DataTable
        Try
            Dim ds As New DataSet()
            Dim constring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & filepath & ";Extended Properties=""Excel 12.0;HDR=YES;"""
            Dim con As New OleDbConnection(constring & "")

            con.Open()

            Dim myTableName = con.GetSchema("Tables").Rows(0)("TABLE_NAME")
            Dim sqlquery As String = String.Format("SELECT * FROM [{0}]", myTableName)
            Dim da As New OleDbDataAdapter(sqlquery, con)
            da.Fill(ds)
            dt = ds.Tables(0)
            Return dt
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical)
            Return dt
        End Try
    End Function

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "Excel files |*.xls;*.xlsx"
        dialog.InitialDirectory = "C:\%userprofile%\Downloads"
        dialog.Title = "Import excel file"
        If dialog.ShowDialog() = DialogResult.OK Then
            Dim dt As DataTable
            dt = ImportExceltoDatatable(dialog.FileName)
            If dt.Columns(0).ColumnName = "Timestamp" And dt.Columns(1).ColumnName = "ID Number" And dt.Columns(2).ColumnName = "First Name" And dt.Columns(3).ColumnName = "Last Name" And dt.Columns(4).ColumnName = "Tricycle Body Number" And dt.Columns(5).ColumnName = "Transaction" Then
                dgvExcelData.DataSource = dt
                dgvExcelData.Visible = True
                MsgBox("Import Successful!", MsgBoxStyle.Information)
                btnExport.Enabled = True
            Else
                MsgBox("Invalid File!", MsgBoxStyle.Critical)
                dgvExcelData.DataSource = Nothing
                btnExport.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Dim exported As Boolean = False
        Dim transNum As Integer
        Dim userID, transType As String
        Dim transDate As DateTime
        Dim fee As Double
        For Each excelRow As DataGridViewRow In dgvExcelData.Rows
            Try
                userID = excelRow.Cells("ID Number").Value.ToString
                transDate = excelRow.Cells("Timestamp").Value
                transType = excelRow.Cells("Transaction").Value.ToString
                Select Case transType
                    Case "Boundary"
                        fee = 180
                    Case "Installment Pay"
                        fee = 300
                    Case "Maintenance"
                        fee = 0
                End Select

                If IsNothing(TransactionsTableAdapter.ExistingRecord(transType, transDate.Date, fee, userID)) Then
                    Try
                        transNum = TransactionsTableAdapter.GetMaxTransNumber() + 1
                    Catch ex As Exception
                        transNum = 1
                    End Try
                    TransactionsTableAdapter.Insert(transNum, transType, transDate.Date, fee, userID, "Pending")
                    exported = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        Next
        If exported Then
            MsgBox("Export Successful!", MsgBoxStyle.Information)
            Me.Close()
            ViewDriverTransactions.ViewTransactionInfo()
            ViewDriverTransactions.Show()
        Else
            MsgBox("Records are already existing in the databse!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        ViewDriverTransactions.Show()
    End Sub

    Private Sub ImportExcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        timClock.Enabled = True
        btnExport.Enabled = False
    End Sub

    Private Sub timClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timClock.Tick
        lblClock.Text = Format(Now, "MM/dd/yyyy hh:mm tt")
    End Sub
End Class