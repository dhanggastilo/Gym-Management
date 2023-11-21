<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardAdmin
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
        BtnAccountManagement = New Button()
        BtnAccountCreation = New Button()
        LblPosition = New Label()
        LblFirstNameLastName = New Label()
        PicBoxProfileLogo = New PictureBox()
        TabControl = New TabControl()
        AccountCreation = New TabPage()
        AccountManagement = New TabPage()
        closeBtn = New Button()
        Panel1.SuspendLayout()
        CType(PicBoxProfileLogo, ComponentModel.ISupportInitialize).BeginInit()
        TabControl.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Info
        Panel1.Controls.Add(closeBtn)
        Panel1.Controls.Add(BtnLogout)
        Panel1.Controls.Add(BtnAccountManagement)
        Panel1.Controls.Add(BtnAccountCreation)
        Panel1.Controls.Add(LblPosition)
        Panel1.Controls.Add(LblFirstNameLastName)
        Panel1.Controls.Add(PicBoxProfileLogo)
        Panel1.Location = New Point(-1, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 626)
        Panel1.TabIndex = 2
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
        ' BtnAccountManagement
        ' 
        BtnAccountManagement.BackColor = SystemColors.Info
        BtnAccountManagement.FlatAppearance.BorderSize = 0
        BtnAccountManagement.FlatStyle = FlatStyle.Flat
        BtnAccountManagement.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        BtnAccountManagement.Location = New Point(2, 294)
        BtnAccountManagement.Name = "BtnAccountManagement"
        BtnAccountManagement.Size = New Size(247, 39)
        BtnAccountManagement.TabIndex = 4
        BtnAccountManagement.Text = "Account Management"
        BtnAccountManagement.UseVisualStyleBackColor = False
        ' 
        ' BtnAccountCreation
        ' 
        BtnAccountCreation.AllowDrop = True
        BtnAccountCreation.BackColor = SystemColors.Info
        BtnAccountCreation.FlatAppearance.BorderSize = 0
        BtnAccountCreation.FlatStyle = FlatStyle.Flat
        BtnAccountCreation.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        BtnAccountCreation.Location = New Point(0, 249)
        BtnAccountCreation.Name = "BtnAccountCreation"
        BtnAccountCreation.Size = New Size(247, 39)
        BtnAccountCreation.TabIndex = 3
        BtnAccountCreation.Text = "Account Creation"
        BtnAccountCreation.UseVisualStyleBackColor = False
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
        TabControl.Controls.Add(AccountCreation)
        TabControl.Controls.Add(AccountManagement)
        TabControl.Location = New Point(255, 12)
        TabControl.Name = "TabControl"
        TabControl.SelectedIndex = 0
        TabControl.Size = New Size(697, 598)
        TabControl.TabIndex = 3
        ' 
        ' AccountCreation
        ' 
        AccountCreation.Location = New Point(4, 29)
        AccountCreation.Name = "AccountCreation"
        AccountCreation.Padding = New Padding(3)
        AccountCreation.Size = New Size(689, 565)
        AccountCreation.TabIndex = 1
        AccountCreation.Text = "Account Creation"
        AccountCreation.UseVisualStyleBackColor = True
        ' 
        ' AccountManagement
        ' 
        AccountManagement.Location = New Point(4, 29)
        AccountManagement.Name = "AccountManagement"
        AccountManagement.Padding = New Padding(3)
        AccountManagement.Size = New Size(689, 565)
        AccountManagement.TabIndex = 2
        AccountManagement.Text = "Account Management"
        AccountManagement.UseVisualStyleBackColor = True
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
        ' DashboardAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(955, 622)
        Controls.Add(TabControl)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "DashboardAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DashboardAdmin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PicBoxProfileLogo, ComponentModel.ISupportInitialize).EndInit()
        TabControl.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnAccountManagement As Button
    Friend WithEvents BtnAccountCreation As Button
    Friend WithEvents LblPosition As Label
    Friend WithEvents LblFirstNameLastName As Label
    Friend WithEvents PicBoxProfileLogo As PictureBox
    Friend WithEvents TabControl As TabControl
    Friend WithEvents AccountCreation As TabPage
    Friend WithEvents AccountManagement As TabPage
    Friend WithEvents closeBtn As Button
End Class
