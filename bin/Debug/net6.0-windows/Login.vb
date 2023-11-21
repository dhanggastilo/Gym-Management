Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Login
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim con As New SqlConnection("Data Source=NORLINE\SQLEXPRESS;Initial Catalog=gymDB;Integrated Security=True;TrustServerCertificate=True")
        Dim cmd As New SqlCommand
        Dim sd As New SqlDataAdapter
        Dim dt As New DataTable
        Dim rdr As SqlDataReader

        If TxtUsername.Text = "" Then
            MsgBox("Enter Username")
            TxtUsername.Focus()
        End If
        If TxtPassword.Text = "" Then
            MsgBox("Enter Password")
            TxtPassword.Focus()
        End If

        Try
            con = New SqlConnection("Data Source=NORLINE\SQLEXPRESS;Initial Catalog=gymDB;Integrated Security=True;TrustServerCertificate=True")
            con.Open()
            'cmd.Connection = con 'add,edit, delete
            cmd = New SqlCommand("Select * from tbl_USERS where Username='" + TxtUsername.Text + "' and Password='" + TxtPassword.Text + "'", con)
            rdr = cmd.ExecuteReader()

            If (rdr.Read()) Then

                If (rdr("Username") = "admin") Then
                    DashboardAdmin.Show()
                ElseIf (rdr("Username") = "cashier") Then
                    DashboardCashier.Show()
                ElseIf (rdr("Username") = "manager") Then
                    DashboardManager.Show()
                ElseIf (rdr("Username") = "encoder") Then
                    DashboardEncoder.Show()
                ElseIf (rdr("Username") = "trainer") Then
                    DashboardTrainer.Show()
                End If
            Else
                MsgBox("Enter a valid Username and/or Password.")
                TxtUsername.Text = ""
                TxtPassword.Text = ""
            End If
            con.Close()

        Catch ex As Exception

        End Try
    End Sub

End Class