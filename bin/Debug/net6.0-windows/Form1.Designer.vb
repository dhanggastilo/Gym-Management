<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PbGuiyabLogo = New PictureBox()
        BtnEnter = New Button()
        CType(PbGuiyabLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PbGuiyabLogo
        ' 
        PbGuiyabLogo.BackgroundImage = My.Resources.Resources.Guiyab_Gym_Logo___transparent
        PbGuiyabLogo.BackgroundImageLayout = ImageLayout.Zoom
        PbGuiyabLogo.Location = New Point(12, 12)
        PbGuiyabLogo.Name = "PbGuiyabLogo"
        PbGuiyabLogo.Size = New Size(451, 429)
        PbGuiyabLogo.TabIndex = 0
        PbGuiyabLogo.TabStop = False
        ' 
        ' BtnEnter
        ' 
        BtnEnter.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        BtnEnter.Location = New Point(186, 447)
        BtnEnter.Name = "BtnEnter"
        BtnEnter.Size = New Size(111, 31)
        BtnEnter.TabIndex = 1
        BtnEnter.Text = "Enter"
        BtnEnter.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(475, 490)
        Controls.Add(BtnEnter)
        Controls.Add(PbGuiyabLogo)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PbGuiyabLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PbGuiyabLogo As PictureBox
    Friend WithEvents BtnEnter As Button
End Class
