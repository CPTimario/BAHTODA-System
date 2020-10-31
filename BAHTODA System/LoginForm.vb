Public Class LoginForm

    Public userID, userType As String

    Private Sub Login()
        Dim password As String
        Dim userPassword As String
        userID = UserIDTextBox.Text
        password = PasswordTextbox.Text
        userPassword = UserAccountsTableAdapter.GetPassword(userID)
        userType = UserAccountsTableAdapter.LoginQuery(userID, password)

        If userID = "" Or password = "" Then
            MessageBox.Show("Kindly fill all necessary fields.", "ERROR", MessageBoxButtons.OK)
            PasswordTextBox.Clear()
            UserIDTextBox.Focus()
        ElseIf password = userPassword Then
            Select Case userType
                Case "Super Administrator"
                    Me.Hide()
                    SuperAdminForm.Show()
                    PasswordTextBox.Clear()
                Case "Administrator"
                    Me.Hide()
                    AdminForm.Show()
                    PasswordTextBox.Clear()
                Case "User"
                    Me.Hide()
                    UserForm.Show()
                    PasswordTextBox.Clear()
            End Select
        Else
            MessageBox.Show("Incorrect User ID and/or Password.", "ERROR", MessageBoxButtons.OK)
            PasswordTextBox.Clear()
            PasswordTextBox.Focus()
        End If
    End Sub

    Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click
        Login()
    End Sub

    Private Sub UserIDTextbox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UserIDTextBox.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            Login()
        End If
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UserIDTextBox.Focus()
    End Sub

    Private Sub UserAccountsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UserAccountsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BAHTODADataSet)
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
