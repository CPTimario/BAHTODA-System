Public Class ViewAddTricycles

    Public currUserID As String
    Dim ind As Integer

    Private Sub btnEditTricInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditTricInfo.Click
        Me.Hide()
        EditTricycleInfo.Show()
    End Sub

    Private Sub ViewTricycleInfo()
        Me.ViewTricycleInformationTableAdapter.Search(Me.BAHTODADataSet.ViewTricycleInformation, txtSearch.Text, cmbStatus.Text)
        If dgvTricycleInfo.RowCount > 0 Then
            btnEditTricInfo.Enabled = True
            ind = 0
            currUserID = dgvTricycleInfo.Rows(ind).Cells(0).Value.ToString
        Else
            btnEditTricInfo.Enabled = False
        End If
    End Sub

    Private Sub ViewAddTricycle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        timClock.Enabled = True
        btnEditTricInfo.Enabled = False
        ViewTricycleInfo()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            Me.ViewTricycleInformationTableAdapter.Search(Me.BAHTODADataSet.ViewTricycleInformation, txtSearch.Text, cmbStatus.Text)
            If dgvTricycleInfo.RowCount > 0 Then
                btnEditTricInfo.Enabled = True
                ind = 0
                currUserID = dgvTricycleInfo.Rows(ind).Cells(0).Value.ToString
            Else
                btnEditTricInfo.Enabled = False
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvDriverInfo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTricycleInfo.CellClick
        ind = dgvTricycleInfo.CurrentCell.RowIndex
        currUserID = dgvTricycleInfo.Rows(ind).Cells(0).Value.ToString
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
        Try
            Me.ViewTricycleInformationTableAdapter.Search(Me.BAHTODADataSet.ViewTricycleInformation, txtSearch.Text, cmbStatus.Text)
            If dgvTricycleInfo.RowCount > 0 Then
                btnEditTricInfo.Enabled = True
                ind = 0
                currUserID = dgvTricycleInfo.Rows(ind).Cells(0).Value.ToString
            Else
                btnEditTricInfo.Enabled = False
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub timClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timClock.Tick
        lblClock.Text = Format(Now, "MM/dd/yyyy hh:mm tt")
    End Sub
End Class