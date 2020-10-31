Public Class ViewAddDrivers


    Public currUserID As String
    Dim ind As Integer

    Public Sub ViewDriverInfo()
        Select Case LoginForm.userType
            Case "Super Administrator"
                btnAddNewDriver.Visible = True
            Case "Administrator"
                btnAddNewDriver.Visible = False
        End Select
        Me.DriverInformationTableAdapter.FillByStatus(Me.BAHTODADataSet.DriverInformation, cmbStatus.Text, SearchNameTextbox.Text)
        If dgvDriverInfo.RowCount > 0 Then
            btnEditDriverInfo.Enabled = True
            ind = 0
            currUserID = dgvDriverInfo.Rows(0).Cells(0).Value.ToString
        End If
    End Sub

    Private Sub AddViewDriver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        timClock.Enabled = True
        btnEditDriverInfo.Enabled = False
        ViewDriverInfo()
    End Sub

    Private Sub SearchNameTextbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchNameTextbox.TextChanged
        Try
            Me.DriverInformationTableAdapter.FillByStatus(Me.BAHTODADataSet.DriverInformation, cmbStatus.Text, SearchNameTextbox.Text)
            If dgvDriverInfo.RowCount > 0 Then
                btnEditDriverInfo.Enabled = True
                ind = 0
                currUserID = dgvDriverInfo.Rows(0).Cells(0).Value.ToString
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AddNewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewDriver.Click
        Me.Close()
        AddDriver.Show()
    End Sub

    Private Sub dgvDriverInfo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDriverInfo.CellClick
        ind = dgvDriverInfo.CurrentCell.RowIndex
        currUserID = dgvDriverInfo.Rows(ind).Cells(0).Value.ToString
    End Sub

    Private Sub btnEditDriverInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditDriverInfo.Click
        Me.Hide()
        EditDriverInfo.Show()
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

    Private Sub cmbStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStatus.SelectedIndexChanged
        Me.DriverInformationTableAdapter.FillByStatus(Me.BAHTODADataSet.DriverInformation, cmbStatus.Text, SearchNameTextbox.Text)
        If dgvDriverInfo.RowCount > 0 Then
            btnEditDriverInfo.Enabled = True
            ind = 0
            currUserID = dgvDriverInfo.Rows(0).Cells(0).Value.ToString
        End If
    End Sub

    Private Sub timClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timClock.Tick
        lblClock.Text = Format(Now, "MM/dd/yyyy hh:mm tt")
    End Sub
End Class