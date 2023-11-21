<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardManager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Button3 = New Button()
        BtnLogout = New Button()
        BtnInventoryRecords = New Button()
        BtnSalesRecords = New Button()
        BtnTrainersRecords = New Button()
        BtnAttendanceRecords = New Button()
        BtnCurrentlyTimeIn = New Button()
        LblPosition = New Label()
        LblFirstNameLastName = New Label()
        PicBoxProfileLogo = New PictureBox()
        TabControl = New TabControl()
        CurrentlyTimeIn = New TabPage()
        Panel2 = New Panel()
        Button2 = New Button()
        BtnViewActiveMember = New Button()
        LblTotalMemberNumber = New Label()
        LblActiveMemberNumber = New Label()
        LblTotalMember = New Label()
        LblActiveMember = New Label()
        AttendanceRecords = New TabPage()
        ComboBox1 = New ComboBox()
        Panel3 = New Panel()
        PbSearch = New PictureBox()
        Label1 = New Label()
        TxtInputName = New TextBox()
        LvAttendance = New ListView()
        TrainerRecords = New TabPage()
        ComboBox2 = New ComboBox()
        Panel4 = New Panel()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        LvTrainers = New ListView()
        SalesRecords = New TabPage()
        ComboBox4 = New ComboBox()
        ComboBox3 = New ComboBox()
        Panel5 = New Panel()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        LvSales = New ListView()
        InventoryRecords = New TabPage()
        ComboBox6 = New ComboBox()
        Panel6 = New Panel()
        PictureBox3 = New PictureBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        LvInventory = New ListView()
        MembersRecords = New TabPage()
        ComboBox5 = New ComboBox()
        Panel7 = New Panel()
        PictureBox4 = New PictureBox()
        Label5 = New Label()
        TextBox4 = New TextBox()
        manMemLst = New ListView()
        LblActiveMembers = New Label()
        LblTotalMembers = New Label()
        LblActiveMembersNumber = New Label()
        LblTotalMembersNumber = New Label()
        BtnViewActiveMembers = New Button()
        Button1 = New Button()
        closeBtn = New Button()
        Panel1.SuspendLayout()
        CType(PicBoxProfileLogo, ComponentModel.ISupportInitialize).BeginInit()
        TabControl.SuspendLayout()
        CurrentlyTimeIn.SuspendLayout()
        Panel2.SuspendLayout()
        AttendanceRecords.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PbSearch, ComponentModel.ISupportInitialize).BeginInit()
        TrainerRecords.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SalesRecords.SuspendLayout()
        Panel5.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        InventoryRecords.SuspendLayout()
        Panel6.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        MembersRecords.SuspendLayout()
        Panel7.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Info
        Panel1.Controls.Add(closeBtn)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(BtnLogout)
        Panel1.Controls.Add(BtnInventoryRecords)
        Panel1.Controls.Add(BtnSalesRecords)
        Panel1.Controls.Add(BtnTrainersRecords)
        Panel1.Controls.Add(BtnAttendanceRecords)
        Panel1.Controls.Add(BtnCurrentlyTimeIn)
        Panel1.Controls.Add(LblPosition)
        Panel1.Controls.Add(LblFirstNameLastName)
        Panel1.Controls.Add(PicBoxProfileLogo)
        Panel1.Location = New Point(-1, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 626)
        Panel1.TabIndex = 0
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.Info
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(0, 474)
        Button3.Name = "Button3"
        Button3.Size = New Size(247, 39)
        Button3.TabIndex = 9
        Button3.Text = "Total Members"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' BtnLogout
        ' 
        BtnLogout.BackColor = SystemColors.Info
        BtnLogout.FlatAppearance.BorderSize = 0
        BtnLogout.FlatStyle = FlatStyle.Flat
        BtnLogout.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point)
        BtnLogout.Location = New Point(0, 584)
        BtnLogout.Name = "BtnLogout"
        BtnLogout.Size = New Size(73, 39)
        BtnLogout.TabIndex = 8
        BtnLogout.Text = "Logout"
        BtnLogout.UseVisualStyleBackColor = False
        ' 
        ' BtnInventoryRecords
        ' 
        BtnInventoryRecords.BackColor = SystemColors.Info
        BtnInventoryRecords.FlatAppearance.BorderSize = 0
        BtnInventoryRecords.FlatStyle = FlatStyle.Flat
        BtnInventoryRecords.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        BtnInventoryRecords.Location = New Point(0, 429)
        BtnInventoryRecords.Name = "BtnInventoryRecords"
        BtnInventoryRecords.Size = New Size(247, 39)
        BtnInventoryRecords.TabIndex = 7
        BtnInventoryRecords.Text = "Inventory Records"
        BtnInventoryRecords.UseVisualStyleBackColor = False
        ' 
        ' BtnSalesRecords
        ' 
        BtnSalesRecords.BackColor = SystemColors.Info
        BtnSalesRecords.FlatAppearance.BorderSize = 0
        BtnSalesRecords.FlatStyle = FlatStyle.Flat
        BtnSalesRecords.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSalesRecords.Location = New Point(0, 384)
        BtnSalesRecords.Name = "BtnSalesRecords"
        BtnSalesRecords.Size = New Size(247, 39)
        BtnSalesRecords.TabIndex = 6
        BtnSalesRecords.Text = "Sales Records"
        BtnSalesRecords.UseVisualStyleBackColor = False
        ' 
        ' BtnTrainersRecords
        ' 
        BtnTrainersRecords.BackColor = SystemColors.Info
        BtnTrainersRecords.FlatAppearance.BorderSize = 0
        BtnTrainersRecords.FlatStyle = FlatStyle.Flat
        BtnTrainersRecords.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        BtnTrainersRecords.Location = New Point(0, 339)
        BtnTrainersRecords.Name = "BtnTrainersRecords"
        BtnTrainersRecords.Size = New Size(247, 39)
        BtnTrainersRecords.TabIndex = 5
        BtnTrainersRecords.Text = "Trainers Records"
        BtnTrainersRecords.UseVisualStyleBackColor = False
        ' 
        ' BtnAttendanceRecords
        ' 
        BtnAttendanceRecords.BackColor = SystemColors.Info
        BtnAttendanceRecords.FlatAppearance.BorderSize = 0
        BtnAttendanceRecords.FlatStyle = FlatStyle.Flat
        BtnAttendanceRecords.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        BtnAttendanceRecords.Location = New Point(2, 294)
        BtnAttendanceRecords.Name = "BtnAttendanceRecords"
        BtnAttendanceRecords.Size = New Size(247, 39)
        BtnAttendanceRecords.TabIndex = 4
        BtnAttendanceRecords.Text = "Attendance Records"
        BtnAttendanceRecords.UseVisualStyleBackColor = False
        ' 
        ' BtnCurrentlyTimeIn
        ' 
        BtnCurrentlyTimeIn.BackColor = SystemColors.Info
        BtnCurrentlyTimeIn.FlatAppearance.BorderSize = 0
        BtnCurrentlyTimeIn.FlatStyle = FlatStyle.Flat
        BtnCurrentlyTimeIn.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCurrentlyTimeIn.Location = New Point(0, 249)
        BtnCurrentlyTimeIn.Name = "BtnCurrentlyTimeIn"
        BtnCurrentlyTimeIn.Size = New Size(247, 39)
        BtnCurrentlyTimeIn.TabIndex = 3
        BtnCurrentlyTimeIn.Text = "Currently Time In"
        BtnCurrentlyTimeIn.UseVisualStyleBackColor = False
        ' 
        ' LblPosition
        ' 
        LblPosition.AutoSize = True
        LblPosition.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point)
        LblPosition.Location = New Point(94, 192)
        LblPosition.Name = "LblPosition"
        LblPosition.Size = New Size(61, 20)
        LblPosition.TabIndex = 2
        LblPosition.Text = "Position"
        ' 
        ' LblFirstNameLastName
        ' 
        LblFirstNameLastName.AutoSize = True
        LblFirstNameLastName.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        LblFirstNameLastName.Location = New Point(42, 169)
        LblFirstNameLastName.Name = "LblFirstNameLastName"
        LblFirstNameLastName.Size = New Size(169, 23)
        LblFirstNameLastName.TabIndex = 1
        LblFirstNameLastName.Text = "FirstName LastName"
        ' 
        ' PicBoxProfileLogo
        ' 
        PicBoxProfileLogo.BackgroundImage = My.Resources.Resources.profile
        PicBoxProfileLogo.BackgroundImageLayout = ImageLayout.Zoom
        PicBoxProfileLogo.Location = New Point(54, 28)
        PicBoxProfileLogo.Name = "PicBoxProfileLogo"
        PicBoxProfileLogo.Size = New Size(143, 128)
        PicBoxProfileLogo.TabIndex = 0
        PicBoxProfileLogo.TabStop = False
        ' 
        ' TabControl
        ' 
        TabControl.Controls.Add(CurrentlyTimeIn)
        TabControl.Controls.Add(AttendanceRecords)
        TabControl.Controls.Add(TrainerRecords)
        TabControl.Controls.Add(SalesRecords)
        TabControl.Controls.Add(InventoryRecords)
        TabControl.Controls.Add(MembersRecords)
        TabControl.Location = New Point(255, 12)
        TabControl.Name = "TabControl"
        TabControl.SelectedIndex = 0
        TabControl.Size = New Size(697, 598)
        TabControl.TabIndex = 1
        ' 
        ' CurrentlyTimeIn
        ' 
        CurrentlyTimeIn.Controls.Add(Panel2)
        CurrentlyTimeIn.Location = New Point(4, 29)
        CurrentlyTimeIn.Name = "CurrentlyTimeIn"
        CurrentlyTimeIn.Padding = New Padding(3)
        CurrentlyTimeIn.Size = New Size(689, 565)
        CurrentlyTimeIn.TabIndex = 0
        CurrentlyTimeIn.Text = "Time In"
        CurrentlyTimeIn.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.MenuBar
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(BtnViewActiveMember)
        Panel2.Controls.Add(LblTotalMemberNumber)
        Panel2.Controls.Add(LblActiveMemberNumber)
        Panel2.Controls.Add(LblTotalMember)
        Panel2.Controls.Add(LblActiveMember)
        Panel2.Location = New Point(66, 113)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(565, 313)
        Panel2.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Salmon
        Button2.FlatAppearance.BorderColor = Color.Black
        Button2.FlatAppearance.MouseDownBackColor = Color.Gray
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ControlText
        Button2.Location = New Point(187, 226)
        Button2.Name = "Button2"
        Button2.Size = New Size(180, 35)
        Button2.TabIndex = 13
        Button2.Text = "View Members"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' BtnViewActiveMember
        ' 
        BtnViewActiveMember.BackColor = Color.Lime
        BtnViewActiveMember.FlatAppearance.BorderColor = Color.Black
        BtnViewActiveMember.FlatAppearance.MouseDownBackColor = Color.Gray
        BtnViewActiveMember.FlatStyle = FlatStyle.Flat
        BtnViewActiveMember.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        BtnViewActiveMember.ForeColor = SystemColors.ControlText
        BtnViewActiveMember.Location = New Point(148, 98)
        BtnViewActiveMember.Name = "BtnViewActiveMember"
        BtnViewActiveMember.Size = New Size(253, 35)
        BtnViewActiveMember.TabIndex = 12
        BtnViewActiveMember.Text = "View Active Members"
        BtnViewActiveMember.UseVisualStyleBackColor = False
        ' 
        ' LblTotalMemberNumber
        ' 
        LblTotalMemberNumber.AutoSize = True
        LblTotalMemberNumber.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        LblTotalMemberNumber.Location = New Point(363, 182)
        LblTotalMemberNumber.Name = "LblTotalMemberNumber"
        LblTotalMemberNumber.Size = New Size(52, 41)
        LblTotalMemberNumber.TabIndex = 3
        LblTotalMemberNumber.Text = "00"
        ' 
        ' LblActiveMemberNumber
        ' 
        LblActiveMemberNumber.AutoSize = True
        LblActiveMemberNumber.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        LblActiveMemberNumber.Location = New Point(416, 37)
        LblActiveMemberNumber.Name = "LblActiveMemberNumber"
        LblActiveMemberNumber.Size = New Size(75, 60)
        LblActiveMemberNumber.TabIndex = 2
        LblActiveMemberNumber.Text = "00"
        ' 
        ' LblTotalMember
        ' 
        LblTotalMember.AutoSize = True
        LblTotalMember.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        LblTotalMember.Location = New Point(121, 182)
        LblTotalMember.Name = "LblTotalMember"
        LblTotalMember.Size = New Size(236, 41)
        LblTotalMember.TabIndex = 1
        LblTotalMember.Text = "Total Members:"
        ' 
        ' LblActiveMember
        ' 
        LblActiveMember.AutoSize = True
        LblActiveMember.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        LblActiveMember.Location = New Point(52, 37)
        LblActiveMember.Name = "LblActiveMember"
        LblActiveMember.Size = New Size(373, 60)
        LblActiveMember.TabIndex = 0
        LblActiveMember.Text = "Active Members:"
        ' 
        ' AttendanceRecords
        ' 
        AttendanceRecords.Controls.Add(ComboBox1)
        AttendanceRecords.Controls.Add(Panel3)
        AttendanceRecords.Controls.Add(LvAttendance)
        AttendanceRecords.Location = New Point(4, 29)
        AttendanceRecords.Name = "AttendanceRecords"
        AttendanceRecords.Padding = New Padding(3)
        AttendanceRecords.Size = New Size(689, 565)
        AttendanceRecords.TabIndex = 1
        AttendanceRecords.Text = "Attendance"
        AttendanceRecords.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly"})
        ComboBox1.Location = New Point(596, 27)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(82, 28)
        ComboBox1.TabIndex = 21
        ComboBox1.Text = "Sort by:"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.Control
        Panel3.Controls.Add(PbSearch)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(TxtInputName)
        Panel3.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Panel3.Location = New Point(12, 23)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(391, 42)
        Panel3.TabIndex = 20
        ' 
        ' PbSearch
        ' 
        PbSearch.BackgroundImage = My.Resources.Resources.search
        PbSearch.BackgroundImageLayout = ImageLayout.Stretch
        PbSearch.Location = New Point(3, 7)
        PbSearch.Name = "PbSearch"
        PbSearch.Size = New Size(29, 29)
        PbSearch.TabIndex = 3
        PbSearch.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(33, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 17)
        Label1.TabIndex = 1
        Label1.Text = "Search Name"
        ' 
        ' TxtInputName
        ' 
        TxtInputName.BackColor = SystemColors.MenuBar
        TxtInputName.Location = New Point(124, 10)
        TxtInputName.Name = "TxtInputName"
        TxtInputName.Size = New Size(261, 25)
        TxtInputName.TabIndex = 0
        ' 
        ' LvAttendance
        ' 
        LvAttendance.Location = New Point(12, 71)
        LvAttendance.Name = "LvAttendance"
        LvAttendance.Size = New Size(666, 483)
        LvAttendance.TabIndex = 0
        LvAttendance.UseCompatibleStateImageBehavior = False
        LvAttendance.View = View.Details
        ' 
        ' TrainerRecords
        ' 
        TrainerRecords.Controls.Add(ComboBox2)
        TrainerRecords.Controls.Add(Panel4)
        TrainerRecords.Controls.Add(LvTrainers)
        TrainerRecords.Location = New Point(4, 29)
        TrainerRecords.Name = "TrainerRecords"
        TrainerRecords.Padding = New Padding(3)
        TrainerRecords.Size = New Size(689, 565)
        TrainerRecords.TabIndex = 2
        TrainerRecords.Text = "Trainers"
        TrainerRecords.UseVisualStyleBackColor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Date of Joining"})
        ComboBox2.Location = New Point(595, 21)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(82, 28)
        ComboBox2.TabIndex = 24
        ComboBox2.Text = "Sort by:"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.Control
        Panel4.Controls.Add(PictureBox1)
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(TextBox1)
        Panel4.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Panel4.Location = New Point(11, 17)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(391, 42)
        Panel4.TabIndex = 23
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.search
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(3, 7)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(29, 29)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(33, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 17)
        Label2.TabIndex = 1
        Label2.Text = "Search Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.MenuBar
        TextBox1.Location = New Point(124, 10)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(261, 25)
        TextBox1.TabIndex = 0
        ' 
        ' LvTrainers
        ' 
        LvTrainers.Location = New Point(11, 65)
        LvTrainers.Name = "LvTrainers"
        LvTrainers.Size = New Size(666, 483)
        LvTrainers.TabIndex = 22
        LvTrainers.UseCompatibleStateImageBehavior = False
        LvTrainers.View = View.Details
        ' 
        ' SalesRecords
        ' 
        SalesRecords.Controls.Add(ComboBox4)
        SalesRecords.Controls.Add(ComboBox3)
        SalesRecords.Controls.Add(Panel5)
        SalesRecords.Controls.Add(LvSales)
        SalesRecords.Location = New Point(4, 29)
        SalesRecords.Name = "SalesRecords"
        SalesRecords.Padding = New Padding(3)
        SalesRecords.Size = New Size(689, 565)
        SalesRecords.TabIndex = 3
        SalesRecords.Text = "Sales"
        SalesRecords.UseVisualStyleBackColor = True
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly"})
        ComboBox4.Location = New Point(507, 21)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(82, 28)
        ComboBox4.TabIndex = 28
        ComboBox4.Text = "Sort by:"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"Date", "Transaction Number", "Level of Membership", "Total Amount"})
        ComboBox3.Location = New Point(595, 21)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(82, 28)
        ComboBox3.TabIndex = 27
        ComboBox3.Text = "Sort by:"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.Control
        Panel5.Controls.Add(PictureBox2)
        Panel5.Controls.Add(Label3)
        Panel5.Controls.Add(TextBox2)
        Panel5.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Panel5.Location = New Point(11, 17)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(391, 42)
        Panel5.TabIndex = 26
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.search
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(3, 7)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(29, 29)
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(33, 15)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 17)
        Label3.TabIndex = 1
        Label3.Text = "Search Transaction"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.MenuBar
        TextBox2.Location = New Point(157, 10)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(228, 25)
        TextBox2.TabIndex = 0
        ' 
        ' LvSales
        ' 
        LvSales.Location = New Point(11, 65)
        LvSales.Name = "LvSales"
        LvSales.Size = New Size(666, 483)
        LvSales.TabIndex = 25
        LvSales.UseCompatibleStateImageBehavior = False
        LvSales.View = View.Details
        ' 
        ' InventoryRecords
        ' 
        InventoryRecords.Controls.Add(ComboBox6)
        InventoryRecords.Controls.Add(Panel6)
        InventoryRecords.Controls.Add(LvInventory)
        InventoryRecords.Location = New Point(4, 29)
        InventoryRecords.Name = "InventoryRecords"
        InventoryRecords.Padding = New Padding(3)
        InventoryRecords.Size = New Size(689, 565)
        InventoryRecords.TabIndex = 4
        InventoryRecords.Text = "Inventory"
        InventoryRecords.UseVisualStyleBackColor = True
        ' 
        ' ComboBox6
        ' 
        ComboBox6.FormattingEnabled = True
        ComboBox6.Items.AddRange(New Object() {"Date", "Serial Number", "Type / Class", "Unit Cost", "Qty", "Total Amount", "Last Maintenance"})
        ComboBox6.Location = New Point(595, 21)
        ComboBox6.Name = "ComboBox6"
        ComboBox6.Size = New Size(82, 28)
        ComboBox6.TabIndex = 31
        ComboBox6.Text = "Sort by:"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.Control
        Panel6.Controls.Add(PictureBox3)
        Panel6.Controls.Add(Label4)
        Panel6.Controls.Add(TextBox3)
        Panel6.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Panel6.Location = New Point(11, 17)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(391, 42)
        Panel6.TabIndex = 30
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = My.Resources.Resources.search
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(3, 7)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(29, 29)
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(33, 15)
        Label4.Name = "Label4"
        Label4.Size = New Size(119, 17)
        Label4.TabIndex = 1
        Label4.Text = "Search Equipment"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.MenuBar
        TextBox3.Location = New Point(157, 10)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(228, 25)
        TextBox3.TabIndex = 0
        ' 
        ' LvInventory
        ' 
        LvInventory.Location = New Point(11, 65)
        LvInventory.Name = "LvInventory"
        LvInventory.Size = New Size(666, 483)
        LvInventory.TabIndex = 29
        LvInventory.UseCompatibleStateImageBehavior = False
        LvInventory.View = View.Details
        ' 
        ' MembersRecords
        ' 
        MembersRecords.Controls.Add(ComboBox5)
        MembersRecords.Controls.Add(Panel7)
        MembersRecords.Controls.Add(manMemLst)
        MembersRecords.Location = New Point(4, 29)
        MembersRecords.Name = "MembersRecords"
        MembersRecords.Padding = New Padding(3)
        MembersRecords.Size = New Size(689, 565)
        MembersRecords.TabIndex = 5
        MembersRecords.Text = "Members"
        MembersRecords.UseVisualStyleBackColor = True
        ' 
        ' ComboBox5
        ' 
        ComboBox5.FormattingEnabled = True
        ComboBox5.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly"})
        ComboBox5.Location = New Point(595, 21)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(82, 28)
        ComboBox5.TabIndex = 24
        ComboBox5.Text = "Sort by:"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.Control
        Panel7.Controls.Add(PictureBox4)
        Panel7.Controls.Add(Label5)
        Panel7.Controls.Add(TextBox4)
        Panel7.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Panel7.Location = New Point(11, 17)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(391, 42)
        Panel7.TabIndex = 23
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = My.Resources.Resources.search
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(3, 7)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(29, 29)
        PictureBox4.TabIndex = 3
        PictureBox4.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(33, 15)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 17)
        Label5.TabIndex = 1
        Label5.Text = "Search Name"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.MenuBar
        TextBox4.Location = New Point(124, 10)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(261, 25)
        TextBox4.TabIndex = 0
        ' 
        ' manMemLst
        ' 
        manMemLst.Location = New Point(11, 65)
        manMemLst.Name = "manMemLst"
        manMemLst.Size = New Size(666, 483)
        manMemLst.TabIndex = 22
        manMemLst.UseCompatibleStateImageBehavior = False
        manMemLst.View = View.Details
        ' 
        ' LblActiveMembers
        ' 
        LblActiveMembers.AutoSize = True
        LblActiveMembers.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        LblActiveMembers.Location = New Point(81, 37)
        LblActiveMembers.Name = "LblActiveMembers"
        LblActiveMembers.Size = New Size(314, 50)
        LblActiveMembers.TabIndex = 0
        ' 
        ' LblTotalMembers
        ' 
        LblTotalMembers.AutoSize = True
        LblTotalMembers.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        LblTotalMembers.Location = New Point(133, 184)
        LblTotalMembers.Name = "LblTotalMembers"
        LblTotalMembers.Size = New Size(220, 38)
        LblTotalMembers.TabIndex = 1
        ' 
        ' LblActiveMembersNumber
        ' 
        LblActiveMembersNumber.AutoSize = True
        LblActiveMembersNumber.Font = New Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        LblActiveMembersNumber.Location = New Point(401, 37)
        LblActiveMembersNumber.Name = "LblActiveMembersNumber"
        LblActiveMembersNumber.Size = New Size(62, 50)
        LblActiveMembersNumber.TabIndex = 2
        ' 
        ' LblTotalMembersNumber
        ' 
        LblTotalMembersNumber.AutoSize = True
        LblTotalMembersNumber.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        LblTotalMembersNumber.Location = New Point(359, 184)
        LblTotalMembersNumber.Name = "LblTotalMembersNumber"
        LblTotalMembersNumber.Size = New Size(47, 38)
        LblTotalMembersNumber.TabIndex = 3
        ' 
        ' BtnViewActiveMembers
        ' 
        BtnViewActiveMembers.BackColor = Color.SpringGreen
        BtnViewActiveMembers.FlatAppearance.BorderSize = 0
        BtnViewActiveMembers.FlatStyle = FlatStyle.Flat
        BtnViewActiveMembers.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        BtnViewActiveMembers.Location = New Point(148, 90)
        BtnViewActiveMembers.Name = "BtnViewActiveMembers"
        BtnViewActiveMembers.Size = New Size(247, 32)
        BtnViewActiveMembers.TabIndex = 9
        BtnViewActiveMembers.Text = "View Active Members"
        BtnViewActiveMembers.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Salmon
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(181, 229)
        Button1.Name = "Button1"
        Button1.Size = New Size(184, 32)
        Button1.TabIndex = 10
        Button1.Text = "View Members"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' closeBtn
        ' 
        closeBtn.BackColor = SystemColors.Info
        closeBtn.Location = New Point(0, 0)
        closeBtn.Name = "closeBtn"
        closeBtn.Size = New Size(31, 29)
        closeBtn.TabIndex = 25
        closeBtn.Text = "X"
        closeBtn.UseVisualStyleBackColor = False
        ' 
        ' DashboardManager
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(955, 622)
        Controls.Add(TabControl)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "DashboardManager"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DashboardManager"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PicBoxProfileLogo, ComponentModel.ISupportInitialize).EndInit()
        TabControl.ResumeLayout(False)
        CurrentlyTimeIn.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        AttendanceRecords.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PbSearch, ComponentModel.ISupportInitialize).EndInit()
        TrainerRecords.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        SalesRecords.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        InventoryRecords.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        MembersRecords.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblPosition As Label
    Friend WithEvents LblFirstNameLastName As Label
    Friend WithEvents PicBoxProfileLogo As PictureBox
    Friend WithEvents TabControl As TabControl
    Friend WithEvents SalesRecords As TabPage
    Friend WithEvents InventoryRecords As TabPage
    Friend WithEvents BtnCurrentlyTimeIn As Button
    Friend WithEvents BtnTrainersRecords As Button
    Friend WithEvents BtnAttendanceRecords As Button
    Friend WithEvents BtnSalesRecords As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LvSales As ListView
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents AttendanceRecords As TabPage
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PbSearch As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtInputName As TextBox
    Friend WithEvents LvAttendance As ListView
    Friend WithEvents TrainerRecords As TabPage
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LvTrainers As ListView
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents LvInventory As ListView
    Friend WithEvents BtnInventoryRecords As Button
    Friend WithEvents CurrentlyTimeIn As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblActiveMembers As Label
    Friend WithEvents LblTotalMembers As Label
    Friend WithEvents LblActiveMembersNumber As Label
    Friend WithEvents LblTotalMembersNumber As Label
    Friend WithEvents BtnViewActiveMembers As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents LblActiveMember As Label
    Friend WithEvents LblTotalMember As Label
    Friend WithEvents LblTotalMemberNumber As Label
    Friend WithEvents LblActiveMemberNumber As Label
    Friend WithEvents BtnViewActiveMember As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents MembersRecords As TabPage
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents manMemLst As ListView
    Friend WithEvents closeBtn As Button
End Class
