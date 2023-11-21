<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Panel1 = New Panel()
        PicBoxGuiyabLogo = New PictureBox()
        BtnForgotPassword = New Button()
        BtnLogin = New Button()
        LblPassword = New Label()
        LblUsername = New Label()
        TxtPassword = New TextBox()
        TxtUsername = New TextBox()
        Panel1.SuspendLayout()
        CType(PicBoxGuiyabLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.MenuBar
        Panel1.Controls.Add(PicBoxGuiyabLogo)
        Panel1.Controls.Add(BtnForgotPassword)
        Panel1.Controls.Add(BtnLogin)
        Panel1.Controls.Add(LblPassword)
        Panel1.Controls.Add(LblUsername)
        Panel1.Controls.Add(TxtPassword)
        Panel1.Controls.Add(TxtUsername)
        Panel1.Location = New Point(238, 121)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(485, 360)
        Panel1.TabIndex = 0
        ' 
        ' PicBoxGuiyabLogo
        ' 
        PicBoxGuiyabLogo.BackgroundImage = My.Resources.Resources.Guiyab_Gym_Logo___transparent
        PicBoxGuiyabLogo.BackgroundImageLayout = ImageLayout.Zoom
        PicBoxGuiyabLogo.Location = New Point(174, 3)
        PicBoxGuiyabLogo.Name = "PicBoxGuiyabLogo"
        PicBoxGuiyabLogo.Size = New Size(148, 131)
        PicBoxGuiyabLogo.TabIndex = 11
        PicBoxGuiyabLogo.TabStop = False
        ' 
        ' BtnForgotPassword
        ' 
        BtnForgotPassword.FlatAppearance.BorderSize = 0
        BtnForgotPassword.FlatStyle = FlatStyle.Flat
        BtnForgotPassword.Font = New Font("Segoe UI Semilight", 7.20000029F, FontStyle.Italic, GraphicsUnit.Point)
        BtnForgotPassword.Location = New Point(349, 196)
        BtnForgotPassword.Name = "BtnForgotPassword"
        BtnForgotPassword.Size = New Size(120, 28)
        BtnForgotPassword.TabIndex = 10
        BtnForgotPassword.Text = "Forgot Password?"
        BtnForgotPassword.TextAlign = ContentAlignment.BottomCenter
        BtnForgotPassword.UseVisualStyleBackColor = True
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = SystemColors.ActiveBorder
        BtnLogin.Cursor = Cursors.Hand
        BtnLogin.FlatStyle = FlatStyle.Popup
        BtnLogin.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        BtnLogin.Image = CType(resources.GetObject("BtnLogin.Image"), Image)
        BtnLogin.ImageAlign = ContentAlignment.MiddleLeft
        BtnLogin.Location = New Point(380, 287)
        BtnLogin.Margin = New Padding(3, 4, 3, 4)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(80, 36)
        BtnLogin.TabIndex = 9
        BtnLogin.Text = "Login"
        BtnLogin.TextAlign = ContentAlignment.MiddleRight
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' LblPassword
        ' 
        LblPassword.AutoSize = True
        LblPassword.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        LblPassword.Location = New Point(38, 228)
        LblPassword.Name = "LblPassword"
        LblPassword.Size = New Size(101, 28)
        LblPassword.TabIndex = 8
        LblPassword.Text = "Password:"
        ' 
        ' LblUsername
        ' 
        LblUsername.AutoSize = True
        LblUsername.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        LblUsername.Location = New Point(36, 161)
        LblUsername.Name = "LblUsername"
        LblUsername.Size = New Size(108, 28)
        LblUsername.TabIndex = 7
        LblUsername.Text = "Username:"
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Cursor = Cursors.IBeam
        TxtPassword.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPassword.Location = New Point(145, 222)
        TxtPassword.Margin = New Padding(3, 4, 3, 4)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.PasswordChar = "•"c
        TxtPassword.Size = New Size(315, 31)
        TxtPassword.TabIndex = 6
        ' 
        ' TxtUsername
        ' 
        TxtUsername.Cursor = Cursors.IBeam
        TxtUsername.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtUsername.Location = New Point(145, 155)
        TxtUsername.Margin = New Padding(3, 4, 3, 4)
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(315, 31)
        TxtUsername.TabIndex = 5
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(955, 622)
        Controls.Add(Panel1)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PicBoxGuiyabLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnLogin As Button
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents BtnForgotPassword As Button
    Friend WithEvents PicBoxGuiyabLogo As PictureBox
End Class
