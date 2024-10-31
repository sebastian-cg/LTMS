<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportNewUser
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
        actionPanelNewUserEmail = New Panel()
        logoutBtnNewUser = New Button()
        reportBtnNewUser = New Button()
        fillUpBtn = New Button()
        usernameLbl = New Label()
        accPicBxNewUser = New PictureBox()
        topPanelNewUser = New Panel()
        centerPanelNewUser = New Panel()
        ic_logoNewUser = New PictureBox()
        mainDashboardNewUserPanel = New Panel()
        sendBtnEmailNewUser = New Button()
        emailNewUserTxtBx = New TextBox()
        actionPanelNewUserEmail.SuspendLayout()
        CType(accPicBxNewUser, ComponentModel.ISupportInitialize).BeginInit()
        centerPanelNewUser.SuspendLayout()
        CType(ic_logoNewUser, ComponentModel.ISupportInitialize).BeginInit()
        mainDashboardNewUserPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' actionPanelNewUserEmail
        ' 
        actionPanelNewUserEmail.BackColor = Color.FromArgb(CByte(182), CByte(187), CByte(196))
        actionPanelNewUserEmail.Controls.Add(logoutBtnNewUser)
        actionPanelNewUserEmail.Controls.Add(reportBtnNewUser)
        actionPanelNewUserEmail.Controls.Add(fillUpBtn)
        actionPanelNewUserEmail.Controls.Add(usernameLbl)
        actionPanelNewUserEmail.Controls.Add(accPicBxNewUser)
        actionPanelNewUserEmail.Dock = DockStyle.Left
        actionPanelNewUserEmail.Location = New Point(0, 0)
        actionPanelNewUserEmail.Name = "actionPanelNewUserEmail"
        actionPanelNewUserEmail.Size = New Size(250, 791)
        actionPanelNewUserEmail.TabIndex = 7
        ' 
        ' logoutBtnNewUser
        ' 
        logoutBtnNewUser.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        logoutBtnNewUser.FlatStyle = FlatStyle.Popup
        logoutBtnNewUser.ForeColor = SystemColors.ButtonHighlight
        logoutBtnNewUser.Location = New Point(26, 721)
        logoutBtnNewUser.Name = "logoutBtnNewUser"
        logoutBtnNewUser.Size = New Size(203, 41)
        logoutBtnNewUser.TabIndex = 6
        logoutBtnNewUser.Text = "Logout"
        logoutBtnNewUser.UseVisualStyleBackColor = False
        ' 
        ' reportBtnNewUser
        ' 
        reportBtnNewUser.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        reportBtnNewUser.FlatStyle = FlatStyle.Popup
        reportBtnNewUser.ForeColor = SystemColors.ButtonHighlight
        reportBtnNewUser.Location = New Point(46, 316)
        reportBtnNewUser.Name = "reportBtnNewUser"
        reportBtnNewUser.Size = New Size(158, 41)
        reportBtnNewUser.TabIndex = 3
        reportBtnNewUser.Text = "Report"
        reportBtnNewUser.UseVisualStyleBackColor = False
        ' 
        ' fillUpBtn
        ' 
        fillUpBtn.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        fillUpBtn.FlatStyle = FlatStyle.Popup
        fillUpBtn.ForeColor = SystemColors.ButtonHighlight
        fillUpBtn.Location = New Point(46, 256)
        fillUpBtn.Name = "fillUpBtn"
        fillUpBtn.Size = New Size(158, 41)
        fillUpBtn.TabIndex = 2
        fillUpBtn.Text = "Fill up"
        fillUpBtn.UseVisualStyleBackColor = False
        ' 
        ' usernameLbl
        ' 
        usernameLbl.AutoSize = True
        usernameLbl.Font = New Font("HarmonyOS Sans SC Medium", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        usernameLbl.Location = New Point(70, 166)
        usernameLbl.Name = "usernameLbl"
        usernameLbl.Size = New Size(90, 23)
        usernameLbl.TabIndex = 1
        usernameLbl.Text = "User_123"
        ' 
        ' accPicBxNewUser
        ' 
        accPicBxNewUser.Image = My.Resources.Resources.account_2040484
        accPicBxNewUser.Location = New Point(64, 62)
        accPicBxNewUser.Name = "accPicBxNewUser"
        accPicBxNewUser.Size = New Size(110, 101)
        accPicBxNewUser.SizeMode = PictureBoxSizeMode.Zoom
        accPicBxNewUser.TabIndex = 0
        accPicBxNewUser.TabStop = False
        ' 
        ' topPanelNewUser
        ' 
        topPanelNewUser.BackColor = Color.FromArgb(CByte(182), CByte(187), CByte(196))
        topPanelNewUser.Dock = DockStyle.Top
        topPanelNewUser.Location = New Point(250, 0)
        topPanelNewUser.Name = "topPanelNewUser"
        topPanelNewUser.Size = New Size(1014, 45)
        topPanelNewUser.TabIndex = 8
        ' 
        ' centerPanelNewUser
        ' 
        centerPanelNewUser.Controls.Add(ic_logoNewUser)
        centerPanelNewUser.Controls.Add(mainDashboardNewUserPanel)
        centerPanelNewUser.Dock = DockStyle.Fill
        centerPanelNewUser.Location = New Point(250, 45)
        centerPanelNewUser.Name = "centerPanelNewUser"
        centerPanelNewUser.Size = New Size(1014, 746)
        centerPanelNewUser.TabIndex = 9
        ' 
        ' ic_logoNewUser
        ' 
        ic_logoNewUser.Image = My.Resources.Resources.school_bus_12404453
        ic_logoNewUser.Location = New Point(943, 0)
        ic_logoNewUser.Name = "ic_logoNewUser"
        ic_logoNewUser.Size = New Size(68, 61)
        ic_logoNewUser.SizeMode = PictureBoxSizeMode.Zoom
        ic_logoNewUser.TabIndex = 2
        ic_logoNewUser.TabStop = False
        ' 
        ' mainDashboardNewUserPanel
        ' 
        mainDashboardNewUserPanel.BackColor = Color.FromArgb(CByte(182), CByte(187), CByte(196))
        mainDashboardNewUserPanel.Controls.Add(sendBtnEmailNewUser)
        mainDashboardNewUserPanel.Controls.Add(emailNewUserTxtBx)
        mainDashboardNewUserPanel.Location = New Point(27, 90)
        mainDashboardNewUserPanel.Name = "mainDashboardNewUserPanel"
        mainDashboardNewUserPanel.Size = New Size(961, 627)
        mainDashboardNewUserPanel.TabIndex = 1
        ' 
        ' sendBtnEmailNewUser
        ' 
        sendBtnEmailNewUser.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        sendBtnEmailNewUser.FlatStyle = FlatStyle.Popup
        sendBtnEmailNewUser.ForeColor = SystemColors.ButtonHighlight
        sendBtnEmailNewUser.Location = New Point(765, 560)
        sendBtnEmailNewUser.Name = "sendBtnEmailNewUser"
        sendBtnEmailNewUser.Size = New Size(158, 41)
        sendBtnEmailNewUser.TabIndex = 7
        sendBtnEmailNewUser.Text = "Send"
        sendBtnEmailNewUser.UseVisualStyleBackColor = False
        ' 
        ' emailNewUserTxtBx
        ' 
        emailNewUserTxtBx.Location = New Point(45, 121)
        emailNewUserTxtBx.Multiline = True
        emailNewUserTxtBx.Name = "emailNewUserTxtBx"
        emailNewUserTxtBx.Size = New Size(878, 410)
        emailNewUserTxtBx.TabIndex = 21
        ' 
        ' ReportNewUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 791)
        Controls.Add(centerPanelNewUser)
        Controls.Add(topPanelNewUser)
        Controls.Add(actionPanelNewUserEmail)
        Name = "ReportNewUser"
        Text = "ReportNewUser"
        actionPanelNewUserEmail.ResumeLayout(False)
        actionPanelNewUserEmail.PerformLayout()
        CType(accPicBxNewUser, ComponentModel.ISupportInitialize).EndInit()
        centerPanelNewUser.ResumeLayout(False)
        CType(ic_logoNewUser, ComponentModel.ISupportInitialize).EndInit()
        mainDashboardNewUserPanel.ResumeLayout(False)
        mainDashboardNewUserPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents actionPanelNewUserEmail As Panel
    Friend WithEvents logoutBtnNewUser As Button
    Friend WithEvents reportBtnNewUser As Button
    Friend WithEvents fillUpBtn As Button
    Friend WithEvents usernameLbl As Label
    Friend WithEvents accPicBxNewUser As PictureBox
    Friend WithEvents topPanelNewUser As Panel
    Friend WithEvents centerPanelNewUser As Panel
    Friend WithEvents mainDashboardNewUserPanel As Panel
    Friend WithEvents sendBtnEmailNewUser As Button
    Friend WithEvents emailNewUserTxtBx As TextBox
    Friend WithEvents ic_logoNewUser As PictureBox
End Class
