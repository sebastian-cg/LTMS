<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpForm
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
        SignRightSidePanel = New Panel()
        systemNameSign = New Label()
        signUpLogin = New PictureBox()
        aboutUsBtn = New LinkLabel()
        signUpMainBtn = New Button()
        passTxtBoxSign = New TextBox()
        usernameTxtBoxSign = New TextBox()
        signUpAccPicbox = New PictureBox()
        signLeftSidePanel = New Panel()
        backBtnSign = New PictureBox()
        reEnterPassSignUp = New TextBox()
        SignRightSidePanel.SuspendLayout()
        CType(signUpLogin, ComponentModel.ISupportInitialize).BeginInit()
        CType(signUpAccPicbox, ComponentModel.ISupportInitialize).BeginInit()
        signLeftSidePanel.SuspendLayout()
        CType(backBtnSign, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SignRightSidePanel
        ' 
        SignRightSidePanel.Controls.Add(systemNameSign)
        SignRightSidePanel.Controls.Add(signUpLogin)
        SignRightSidePanel.Dock = DockStyle.Right
        SignRightSidePanel.Location = New Point(458, 0)
        SignRightSidePanel.Name = "SignRightSidePanel"
        SignRightSidePanel.Size = New Size(806, 791)
        SignRightSidePanel.TabIndex = 2
        ' 
        ' systemNameSign
        ' 
        systemNameSign.Font = New Font("HarmonyOS Sans SC", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        systemNameSign.Location = New Point(202, 177)
        systemNameSign.Name = "systemNameSign"
        systemNameSign.Size = New Size(463, 55)
        systemNameSign.TabIndex = 1
        systemNameSign.Text = "Land Trasportation System"
        systemNameSign.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' signUpLogin
        ' 
        signUpLogin.Image = My.Resources.Resources.school_bus_12404453
        signUpLogin.Location = New Point(243, 285)
        signUpLogin.Name = "signUpLogin"
        signUpLogin.Size = New Size(380, 323)
        signUpLogin.SizeMode = PictureBoxSizeMode.Zoom
        signUpLogin.TabIndex = 0
        signUpLogin.TabStop = False
        ' 
        ' aboutUsBtn
        ' 
        aboutUsBtn.AutoSize = True
        aboutUsBtn.LinkColor = Color.Black
        aboutUsBtn.Location = New Point(184, 660)
        aboutUsBtn.Name = "aboutUsBtn"
        aboutUsBtn.Size = New Size(70, 20)
        aboutUsBtn.TabIndex = 5
        aboutUsBtn.TabStop = True
        aboutUsBtn.Text = "About Us"
        ' 
        ' signUpMainBtn
        ' 
        signUpMainBtn.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        signUpMainBtn.FlatStyle = FlatStyle.Popup
        signUpMainBtn.Font = New Font("HarmonyOS Sans SC", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        signUpMainBtn.ForeColor = SystemColors.ButtonHighlight
        signUpMainBtn.Location = New Point(155, 458)
        signUpMainBtn.Name = "signUpMainBtn"
        signUpMainBtn.Size = New Size(128, 40)
        signUpMainBtn.TabIndex = 3
        signUpMainBtn.Text = "Sign Up"
        signUpMainBtn.UseVisualStyleBackColor = False
        ' 
        ' passTxtBoxSign
        ' 
        passTxtBoxSign.Font = New Font("HarmonyOS Sans SC", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passTxtBoxSign.Location = New Point(45, 318)
        passTxtBoxSign.Name = "passTxtBoxSign"
        passTxtBoxSign.PasswordChar = "*"c
        passTxtBoxSign.PlaceholderText = "   Enter your password"
        passTxtBoxSign.Size = New Size(340, 31)
        passTxtBoxSign.TabIndex = 2
        ' 
        ' usernameTxtBoxSign
        ' 
        usernameTxtBoxSign.Font = New Font("HarmonyOS Sans SC", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usernameTxtBoxSign.Location = New Point(45, 263)
        usernameTxtBoxSign.Name = "usernameTxtBoxSign"
        usernameTxtBoxSign.PlaceholderText = "   Enter your username"
        usernameTxtBoxSign.Size = New Size(340, 31)
        usernameTxtBoxSign.TabIndex = 1
        ' 
        ' signUpAccPicbox
        ' 
        signUpAccPicbox.Image = My.Resources.Resources.account_2040484
        signUpAccPicbox.Location = New Point(165, 74)
        signUpAccPicbox.Name = "signUpAccPicbox"
        signUpAccPicbox.Size = New Size(108, 94)
        signUpAccPicbox.SizeMode = PictureBoxSizeMode.Zoom
        signUpAccPicbox.TabIndex = 0
        signUpAccPicbox.TabStop = False
        ' 
        ' signLeftSidePanel
        ' 
        signLeftSidePanel.BackColor = SystemColors.AppWorkspace
        signLeftSidePanel.Controls.Add(backBtnSign)
        signLeftSidePanel.Controls.Add(reEnterPassSignUp)
        signLeftSidePanel.Controls.Add(aboutUsBtn)
        signLeftSidePanel.Controls.Add(signUpMainBtn)
        signLeftSidePanel.Controls.Add(passTxtBoxSign)
        signLeftSidePanel.Controls.Add(usernameTxtBoxSign)
        signLeftSidePanel.Controls.Add(signUpAccPicbox)
        signLeftSidePanel.Location = New Point(28, 44)
        signLeftSidePanel.Name = "signLeftSidePanel"
        signLeftSidePanel.Size = New Size(424, 717)
        signLeftSidePanel.TabIndex = 3
        ' 
        ' backBtnSign
        ' 
        backBtnSign.Cursor = Cursors.Hand
        backBtnSign.Image = My.Resources.Resources.back_17212726
        backBtnSign.Location = New Point(16, 15)
        backBtnSign.Name = "backBtnSign"
        backBtnSign.Size = New Size(39, 41)
        backBtnSign.SizeMode = PictureBoxSizeMode.Zoom
        backBtnSign.TabIndex = 7
        backBtnSign.TabStop = False
        ' 
        ' reEnterPassSignUp
        ' 
        reEnterPassSignUp.Font = New Font("HarmonyOS Sans SC", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        reEnterPassSignUp.Location = New Point(45, 368)
        reEnterPassSignUp.Name = "reEnterPassSignUp"
        reEnterPassSignUp.PasswordChar = "*"c
        reEnterPassSignUp.PlaceholderText = "   Re-enter your password"
        reEnterPassSignUp.Size = New Size(340, 31)
        reEnterPassSignUp.TabIndex = 6
        ' 
        ' SignUpForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 791)
        Controls.Add(signLeftSidePanel)
        Controls.Add(SignRightSidePanel)
        Name = "SignUpForm"
        Text = "SignUpForm"
        SignRightSidePanel.ResumeLayout(False)
        CType(signUpLogin, ComponentModel.ISupportInitialize).EndInit()
        CType(signUpAccPicbox, ComponentModel.ISupportInitialize).EndInit()
        signLeftSidePanel.ResumeLayout(False)
        signLeftSidePanel.PerformLayout()
        CType(backBtnSign, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SignRightSidePanel As Panel
    Friend WithEvents systemNameSign As Label
    Friend WithEvents signUpLogin As PictureBox
    Friend WithEvents aboutUsBtn As LinkLabel
    Friend WithEvents signUpMainBtn As Button
    Friend WithEvents passTxtBoxSign As TextBox
    Friend WithEvents usernameTxtBoxSign As TextBox
    Friend WithEvents signUpAccPicbox As PictureBox
    Friend WithEvents signLeftSidePanel As Panel
    Friend WithEvents reEnterPassSignUp As TextBox
    Friend WithEvents backBtnSign As PictureBox
End Class
