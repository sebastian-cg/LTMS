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
        leftSidePanel = New Panel()
        aboutUsBtn = New LinkLabel()
        signUpBtn = New LinkLabel()
        orTextBoxLogin = New Label()
        loginBtn = New Button()
        passTxtBoxLogin = New TextBox()
        loginTxtBoxUser = New TextBox()
        loginAccPicbox = New PictureBox()
        loginRightSidePanel = New Panel()
        systemNameLogin = New Label()
        logoLogin = New PictureBox()
        leftSidePanel.SuspendLayout()
        CType(loginAccPicbox, ComponentModel.ISupportInitialize).BeginInit()
        loginRightSidePanel.SuspendLayout()
        CType(logoLogin, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' leftSidePanel
        ' 
        leftSidePanel.BackColor = Color.FromArgb(CByte(182), CByte(187), CByte(196))
        leftSidePanel.Controls.Add(aboutUsBtn)
        leftSidePanel.Controls.Add(signUpBtn)
        leftSidePanel.Controls.Add(orTextBoxLogin)
        leftSidePanel.Controls.Add(loginBtn)
        leftSidePanel.Controls.Add(passTxtBoxLogin)
        leftSidePanel.Controls.Add(loginTxtBoxUser)
        leftSidePanel.Controls.Add(loginAccPicbox)
        leftSidePanel.Location = New Point(28, 38)
        leftSidePanel.Name = "leftSidePanel"
        leftSidePanel.Size = New Size(424, 717)
        leftSidePanel.TabIndex = 0
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
        ' signUpBtn
        ' 
        signUpBtn.AutoSize = True
        signUpBtn.Font = New Font("DecoType Naskh Extensions", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        signUpBtn.LinkColor = Color.White
        signUpBtn.Location = New Point(178, 470)
        signUpBtn.Name = "signUpBtn"
        signUpBtn.Size = New Size(83, 28)
        signUpBtn.TabIndex = 4
        signUpBtn.TabStop = True
        signUpBtn.Text = "Sign Up?"
        ' 
        ' orTextBoxLogin
        ' 
        orTextBoxLogin.AutoSize = True
        orTextBoxLogin.Font = New Font("HarmonyOS Sans SC Medium", 10F)
        orTextBoxLogin.Location = New Point(206, 436)
        orTextBoxLogin.Name = "orTextBoxLogin"
        orTextBoxLogin.Size = New Size(27, 23)
        orTextBoxLogin.TabIndex = 2
        orTextBoxLogin.Text = "or"
        ' 
        ' loginBtn
        ' 
        loginBtn.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        loginBtn.FlatStyle = FlatStyle.Popup
        loginBtn.Font = New Font("HarmonyOS Sans SC", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loginBtn.ForeColor = SystemColors.ButtonHighlight
        loginBtn.Location = New Point(155, 382)
        loginBtn.Name = "loginBtn"
        loginBtn.Size = New Size(128, 40)
        loginBtn.TabIndex = 3
        loginBtn.Text = "Login"
        loginBtn.UseVisualStyleBackColor = False
        ' 
        ' passTxtBoxLogin
        ' 
        passTxtBoxLogin.Font = New Font("HarmonyOS Sans SC", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passTxtBoxLogin.Location = New Point(45, 318)
        passTxtBoxLogin.Name = "passTxtBoxLogin"
        passTxtBoxLogin.PasswordChar = "*"c
        passTxtBoxLogin.PlaceholderText = "   Enter your password"
        passTxtBoxLogin.Size = New Size(340, 31)
        passTxtBoxLogin.TabIndex = 2
        ' 
        ' loginTxtBoxUser
        ' 
        loginTxtBoxUser.Font = New Font("HarmonyOS Sans SC", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loginTxtBoxUser.Location = New Point(45, 263)
        loginTxtBoxUser.Name = "loginTxtBoxUser"
        loginTxtBoxUser.PlaceholderText = "   Enter your username"
        loginTxtBoxUser.Size = New Size(340, 31)
        loginTxtBoxUser.TabIndex = 1
        ' 
        ' loginAccPicbox
        ' 
        loginAccPicbox.Image = My.Resources.Resources.account_2040484
        loginAccPicbox.Location = New Point(165, 74)
        loginAccPicbox.Name = "loginAccPicbox"
        loginAccPicbox.Size = New Size(108, 94)
        loginAccPicbox.SizeMode = PictureBoxSizeMode.Zoom
        loginAccPicbox.TabIndex = 0
        loginAccPicbox.TabStop = False
        ' 
        ' loginRightSidePanel
        ' 
        loginRightSidePanel.Controls.Add(systemNameLogin)
        loginRightSidePanel.Controls.Add(logoLogin)
        loginRightSidePanel.Dock = DockStyle.Right
        loginRightSidePanel.Location = New Point(458, 0)
        loginRightSidePanel.Name = "loginRightSidePanel"
        loginRightSidePanel.Size = New Size(806, 791)
        loginRightSidePanel.TabIndex = 1
        ' 
        ' systemNameLogin
        ' 
        systemNameLogin.Font = New Font("HarmonyOS Sans SC", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        systemNameLogin.Location = New Point(202, 177)
        systemNameLogin.Name = "systemNameLogin"
        systemNameLogin.Size = New Size(463, 55)
        systemNameLogin.TabIndex = 1
        systemNameLogin.Text = "Land Trasportation System"
        systemNameLogin.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' logoLogin
        ' 
        logoLogin.Image = My.Resources.Resources.school_bus_12404453
        logoLogin.Location = New Point(243, 285)
        logoLogin.Name = "logoLogin"
        logoLogin.Size = New Size(380, 323)
        logoLogin.SizeMode = PictureBoxSizeMode.Zoom
        logoLogin.TabIndex = 0
        logoLogin.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 791)
        Controls.Add(loginRightSidePanel)
        Controls.Add(leftSidePanel)
        Name = "Form1"
        Text = "Login"
        leftSidePanel.ResumeLayout(False)
        leftSidePanel.PerformLayout()
        CType(loginAccPicbox, ComponentModel.ISupportInitialize).EndInit()
        loginRightSidePanel.ResumeLayout(False)
        CType(logoLogin, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents leftSidePanel As Panel
    Friend WithEvents loginAccPicbox As PictureBox
    Friend WithEvents loginRightSidePanel As Panel
    Friend WithEvents loginTxtBoxUser As TextBox
    Friend WithEvents passTxtBoxLogin As TextBox
    Friend WithEvents systemNameLogin As Label
    Friend WithEvents logoLogin As PictureBox
    Friend WithEvents loginBtn As Button
    Friend WithEvents orTextBoxLogin As Label
    Friend WithEvents signUpBtn As LinkLabel
    Friend WithEvents aboutUsBtn As LinkLabel

End Class
