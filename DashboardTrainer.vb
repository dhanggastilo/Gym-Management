Public Class DashboardTrainer
    Private Sub DashboardTrainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AttendanceColumnHeader()
        MembersRecordColumnHeader()
    End Sub

    Private Sub AttendanceColumnHeader()
        Dim ColumnWidth As Int16
        ColumnWidth = LvAttendance.Width / 5

        LvAttendance.Columns.Add("Date", ColumnWidth, HorizontalAlignment.Left)
        LvAttendance.Columns.Add("Member's Name", ColumnWidth * 2, HorizontalAlignment.Left)
        LvAttendance.Columns.Add("Time In", ColumnWidth, HorizontalAlignment.Left)
        LvAttendance.Columns.Add("Time In", ColumnWidth, HorizontalAlignment.Left)
    End Sub

    Private Sub MembersRecordColumnHeader()
        Dim ColumnWidth As Int16
        ColumnWidth = LvMembersRecords.Width / 8

        LvMembersRecords.Columns.Add("Membership ID", ColumnWidth, HorizontalAlignment.Left)
        LvMembersRecords.Columns.Add("Member Name", ColumnWidth * 2, HorizontalAlignment.Left)
        LvMembersRecords.Columns.Add("Height", ColumnWidth, HorizontalAlignment.Left)
        LvMembersRecords.Columns.Add("Weight", ColumnWidth, HorizontalAlignment.Left)
        LvMembersRecords.Columns.Add("Max.Weight Lifted", ColumnWidth, HorizontalAlignment.Left)
        LvMembersRecords.Columns.Add("Target Routines", ColumnWidth, HorizontalAlignment.Left)
        LvMembersRecords.Columns.Add("Status", ColumnWidth, HorizontalAlignment.Left)
    End Sub

    Private Sub BtnAttendanceMonitoring_Click(sender As Object, e As EventArgs) Handles BtnAttendanceMonitoring.Click
        TabControl.SelectedTab = AttendanceMonitoring
    End Sub

    Private Sub BtnMembersPersonalRecords_Click(sender As Object, e As EventArgs) Handles BtnMembersPersonalRecords.Click
        TabControl.SelectedTab = MembersPersonalRecords
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Close()
        Login.Show()
    End Sub
End Class