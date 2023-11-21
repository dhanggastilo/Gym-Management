<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardTrainer
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
        BtnLogout = New Button()
        BtnMembersPersonalRecords = New Button()
        BtnAttendanceMonitoring = New Button()
        LblPosition = New Label()
        LblFirstNameLastName = New Label()
        PicBoxProfileLogo = New PictureBox()
        MembersPersonalRecords = New TabPage()
        ComboBox2 = New ComboBox()
        Panel4 = New Panel()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        LvMembersRecords = New ListView()
        AttendanceMonitoring = New TabPage()
        ComboBox1 = New ComboBox()
        Panel3 = New Panel()
        PbSearch = New PictureBox()
        Label1 = New Label()
        TxtInputName = New TextBox()
        LvAttendance = New ListView()
        TabControl = New TabControl()
        Panel1.SuspendLayout()
        CType(PicBoxProfileLogo, ComponentModel.ISupportInitialize).BeginInit()
        MembersPersonalRecords.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        AttendanceMonitoring.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PbSearch, ComponentModel.ISupportInitialize).BeginInit()
        TabControl.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Info
        Panel1.Controls.Add(BtnLogout)
        Panel1.Controls.Add(BtnMembersPersonalRecords)
        Panel1.Controls.Add(BtnAttendanceMonitoring)
        Panel1.Controls.Add(LblPosition)
        Panel1.Controls.Add(LblFirstNameLastName)
        Panel1.Controls.Add(PicBoxProfileLogo)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 626)
        Panel1.TabIndex = 1
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
        ' BtnMembersPersonalRecords
        ' 
        BtnMembersPersonalRecords.BackColor = SystemColors.Info
        BtnMembersPersonalRecords.FlatAppearance.BorderSize = 0
        BtnMembersPersonalRecords.FlatStyle = FlatStyle.Flat
        BtnMembersPersonalRecords.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        BtnMembersPersonalRecords.Location = New Point(2, 294)
        BtnMembersPersonalRecords.Name = "BtnMembersPersonalRecords"
        BtnMembersPersonalRecords.Size = New Size(247, 39)
        BtnMembersPersonalRecords.TabIndex = 4
        BtnMembersPersonalRecords.Text = "Member's Personal Records"
        BtnMembersPersonalRecords.UseVisualStyleBackColor = False
        ' 
        ' BtnAttendanceMonitoring
        ' 
        BtnAttendanceMonitoring.AllowDrop = True
        BtnAttendanceMonitoring.BackColor = SystemColors.Info
        BtnAttendanceMonitoring.FlatAppearance.BorderSize = 0
        BtnAttendanceMonitoring.FlatStyle = FlatStyle.Flat
        BtnAttendanceMonitoring.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        BtnAttendanceMonitoring.Location = New Point(0, 249)
        BtnAttendanceMonitoring.Name = "BtnAttendanceMonitoring"
        BtnAttendanceMonitoring.Size = New Size(247, 39)
        BtnAttendanceMonitoring.TabIndex = 3
        BtnAttendanceMonitoring.Text = "Attendance Monitoring"
        BtnAttendanceMonitoring.UseVisualStyleBackColor = False
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
        ' MembersPersonalRecords
        ' 
        MembersPersonalRecords.Controls.Add(ComboBox2)
        MembersPersonalRecords.Controls.Add(Panel4)
        MembersPersonalRecords.Controls.Add(LvMembersRecords)
        MembersPersonalRecords.Location = New Point(4, 29)
        MembersPersonalRecords.Name = "MembersPersonalRecords"
        MembersPersonalRecords.Padding = New Padding(3)
        MembersPersonalRecords.Size = New Size(689, 565)
        MembersPersonalRecords.TabIndex = 2
        MembersPersonalRecords.Text = "Member's Record"
        MembersPersonalRecords.UseVisualStyleBackColor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Active", "Inactive"})
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
        ' LvMembersRecords
        ' 
        LvMembersRecords.Location = New Point(11, 65)
        LvMembersRecords.Name = "LvMembersRecords"
        LvMembersRecords.Size = New Size(666, 483)
        LvMembersRecords.TabIndex = 22
        LvMembersRecords.UseCompatibleStateImageBehavior = False
        LvMembersRecords.View = View.Details
        ' 
        ' AttendanceMonitoring
        ' 
        AttendanceMonitoring.Controls.Add(ComboBox1)
        AttendanceMonitoring.Controls.Add(Panel3)
        AttendanceMonitoring.Controls.Add(LvAttendance)
        AttendanceMonitoring.Location = New Point(4, 29)
        AttendanceMonitoring.Name = "AttendanceMonitoring"
        AttendanceMonitoring.Padding = New Padding(3)
        AttendanceMonitoring.Size = New Size(689, 565)
        AttendanceMonitoring.TabIndex = 1
        AttendanceMonitoring.Text = "Attendance"
        AttendanceMonitoring.UseVisualStyleBackColor = True
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
        ' TabControl
        ' 
        TabControl.Controls.Add(AttendanceMonitoring)
        TabControl.Controls.Add(MembersPersonalRecords)
        TabControl.Location = New Point(255, 15)
        TabControl.Name = "TabControl"
        TabControl.SelectedIndex = 0
        TabControl.Size = New Size(697, 598)
        TabControl.TabIndex = 2
        ' 
        ' DashboardTrainer
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(955, 622)
        Controls.Add(TabControl)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "DashboardTrainer"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DashboardTrainer"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PicBoxProfileLogo, ComponentModel.ISupportInitialize).EndInit()
        MembersPersonalRecords.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        AttendanceMonitoring.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PbSearch, ComponentModel.ISupportInitialize).EndInit()
        TabControl.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnInventoryRecords As Button
    Friend WithEvents BtnSalesRecords As Button
    Friend WithEvents BtnTrainersRecords As Button
    Friend WithEvents BtnMembersPersonalRecords As Button
    Friend WithEvents BtnAttendanceMonitoring As Button
    Friend WithEvents LblPosition As Label
    Friend WithEvents LblFirstNameLastName As Label
    Friend WithEvents PicBoxProfileLogo As PictureBox
    Friend WithEvents MembersPersonalRecords As TabPage
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LvMembersRecords As ListView
    Friend WithEvents AttendanceMonitoring As TabPage
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PbSearch As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtInputName As TextBox
    Friend WithEvents LvAttendance As ListView
    Friend WithEvents TabControl As TabControl
End Class
