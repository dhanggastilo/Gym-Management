Imports System.Data.SqlClient
Imports System.Runtime.Intrinsics.Arm

Public Class Attendance
    Dim con As New SqlConnection("Data Source=NORLINE\SQLEXPRESS;Initial Catalog=gymDB;Integrated Security=True;TrustServerCertificate=True")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable

    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        DataRefresh()
    End Sub

    Private Sub DataRefresh()
        cmd = New SqlCommand("Select * from tbl_NameTrackerAttendance where FirstName LIKE'%" & TxtSearchName.Text & "%' OR LastName LIKE'%" & TxtSearchName.Text & "%' ", con)
        da = New SqlDataAdapter(cmd)
        dt = New DataTable()
        da.Fill(dt)
        DgvSearchNameAttendance.DataSource = dt
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Date.Now.ToString("dd-MMMM-yyyy hh:mm:ss")
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub TxtSearhName_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtSearchName.KeyUp
        If (e.KeyCode = Keys.Enter) Then
            DataRefresh()
        End If
    End Sub

    Private Sub DgvSearchNameAttendance_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSearchNameAttendance.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DgvSearchNameAttendance.Rows(index)
        TxtSearchName.Text = String.Format("{0} {1}", selectedRow.Cells(0).Value, selectedRow.Cells(1).Value)
    End Sub
End Class