Public Class DashboardCashier
    Private Sub DashboardCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MonitoringColumnHeader()
        SalesColumnHeader()
    End Sub

    Private Sub MonitoringColumnHeader()
        Dim ColumnWidth As Int16
        ColumnWidth = LvAccountMonitoring.Width / 7

        LvAccountMonitoring.Columns.Add("Date of Joining", ColumnWidth, HorizontalAlignment.Left)
        LvAccountMonitoring.Columns.Add("Membership ID", ColumnWidth, HorizontalAlignment.Left)
        LvAccountMonitoring.Columns.Add("Member Name", ColumnWidth * 2, HorizontalAlignment.Left)
        LvAccountMonitoring.Columns.Add("Membership Category", ColumnWidth, HorizontalAlignment.Left)
        LvAccountMonitoring.Columns.Add("Status", ColumnWidth, HorizontalAlignment.Left)
        LvAccountMonitoring.Columns.Add("Remarks", ColumnWidth, HorizontalAlignment.Left)
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

    Private Sub BtnPOS_Click(sender As Object, e As EventArgs) Handles BtnPOS.Click
        TabControl.SelectedTab = PointOfSale
    End Sub

    Private Sub BtnMembershipRegistration_Click(sender As Object, e As EventArgs) Handles BtnMembershipRegistration.Click
        TabControl.SelectedTab = MembershipRegistration
    End Sub

    Private Sub BtnMonitoring_Click(sender As Object, e As EventArgs) Handles BtnMonitoring.Click
        TabControl.SelectedTab = AccountMonitoring
    End Sub

    Private Sub BtnSalesRecords_Click(sender As Object, e As EventArgs) Handles BtnSalesRecords.Click
        TabControl.SelectedTab = SalesRecords
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Login.Show()
        Me.Close()
    End Sub
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub
End Class