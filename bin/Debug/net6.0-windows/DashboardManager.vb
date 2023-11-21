Public Class DashboardManager
    Private Sub DashboardManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AttendanceColumnHeader()
        TrainersColumnHeader()
        SalesColumnHeader()
        InventoryColumnHeader()
    End Sub

    Private Sub AttendanceColumnHeader()
        Dim ColumnWidth As Int16
        ColumnWidth = LvAttendance.Width / 5

        LvAttendance.Columns.Add("Date", ColumnWidth, HorizontalAlignment.Left)
        LvAttendance.Columns.Add("Member's Name", ColumnWidth * 2, HorizontalAlignment.Left)
        LvAttendance.Columns.Add("Time In", ColumnWidth, HorizontalAlignment.Left)
        LvAttendance.Columns.Add("Time In", ColumnWidth, HorizontalAlignment.Left)
    End Sub

    Private Sub TrainersColumnHeader()
        Dim ColumnWidth As Int16
        ColumnWidth = LvTrainers.Width / 5

        LvTrainers.Columns.Add("Date of Joining", ColumnWidth, HorizontalAlignment.Left)
        LvTrainers.Columns.Add("Trainer's Name", ColumnWidth, HorizontalAlignment.Left)
        LvTrainers.Columns.Add("Gym Schedule", ColumnWidth, HorizontalAlignment.Left)
        LvTrainers.Columns.Add("Contact Number", ColumnWidth, HorizontalAlignment.Left)
        LvTrainers.Columns.Add("Remarks", ColumnWidth, HorizontalAlignment.Left)
    End Sub

    Private Sub SalesColumnHeader()
        Dim ColumnWidth As Int16
        ColumnWidth = LvSales.Width / 6

        LvSales.Columns.Add("Date", ColumnWidth, HorizontalAlignment.Left)
        LvSales.Columns.Add("Time", ColumnWidth, HorizontalAlignment.Left)
        LvSales.Columns.Add("Transaction Number", ColumnWidth, HorizontalAlignment.Left)
        LvSales.Columns.Add("Membership Category", ColumnWidth, HorizontalAlignment.Left)
        LvSales.Columns.Add("Total Amounts", ColumnWidth, HorizontalAlignment.Left)
        LvSales.Columns.Add("Remarks", ColumnWidth, HorizontalAlignment.Left)
    End Sub

    Private Sub InventoryColumnHeader()
        Dim ColumnWidth As Int16
        ColumnWidth = LvInventory.Width / 9

        LvInventory.Columns.Add("Date", ColumnWidth, HorizontalAlignment.Left)
        LvInventory.Columns.Add("Equipment Name", ColumnWidth, HorizontalAlignment.Left)
        LvInventory.Columns.Add("Serial Number", ColumnWidth, HorizontalAlignment.Left)
        LvInventory.Columns.Add("Type / Class", ColumnWidth, HorizontalAlignment.Left)
        LvInventory.Columns.Add("Unit Cost", ColumnWidth, HorizontalAlignment.Left)
        LvInventory.Columns.Add("Qty", ColumnWidth, HorizontalAlignment.Left)
        LvInventory.Columns.Add("Total Amounts", ColumnWidth, HorizontalAlignment.Left)
        LvInventory.Columns.Add("Last Maintenance", ColumnWidth, HorizontalAlignment.Left)
        LvInventory.Columns.Add("Remarks", ColumnWidth, HorizontalAlignment.Left)
    End Sub

    Private Sub BtnCurrentlyTimeIn_Click(sender As Object, e As EventArgs) Handles BtnCurrentlyTimeIn.Click
        TabControl.SelectedTab = CurrentlyTimeIn
    End Sub

    Private Sub BtnAttendanceRecords_Click(sender As Object, e As EventArgs) Handles BtnAttendanceRecords.Click
        TabControl.SelectedTab = AttendanceRecords
    End Sub

    Private Sub BtnTrainersRecords_Click(sender As Object, e As EventArgs) Handles BtnTrainersRecords.Click
        TabControl.SelectedTab = TrainerRecords
    End Sub

    Private Sub BtnSalesRecords_Click(sender As Object, e As EventArgs) Handles BtnSalesRecords.Click
        TabControl.SelectedTab = SalesRecords
    End Sub

    Private Sub BtnInventoryRecords_Click(sender As Object, e As EventArgs) Handles BtnInventoryRecords.Click
        TabControl.SelectedTab = InventoryRecords
    End Sub
    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl.SelectedTab = MembersRecords
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub
End Class