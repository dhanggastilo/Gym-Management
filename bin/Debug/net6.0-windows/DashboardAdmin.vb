Public Class DashboardAdmin
    Private Sub BtnAccountCreation_Click(sender As Object, e As EventArgs) Handles BtnAccountCreation.Click
        TabControl.SelectedTab = AccountCreation
    End Sub

    Private Sub BtnAccountManagement_Click(sender As Object, e As EventArgs) Handles BtnAccountManagement.Click
        TabControl.SelectedTab = AccountManagement
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub
End Class