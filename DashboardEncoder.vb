Public Class DashboardEncoder
    Private Sub DashboardEncoder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InventoryColumnHeader()
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
    Private Sub BtnInventory_Click(sender As Object, e As EventArgs) Handles BtnInventory.Click
        TabControl.SelectedTab = InventoryRecords
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub
End Class