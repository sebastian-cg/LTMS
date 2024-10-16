<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReApply
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReApply))
        actionPanelUserEmail = New Panel()
        logoutBtnUser = New Button()
        statusBtnUser = New Button()
        emailsBtnUser = New Button()
        downloadBtnUser = New Button()
        dashboardBtnUser = New Button()
        Label1 = New Label()
        accPicBxStatus = New PictureBox()
        logoPicBoxUserStatus = New PictureBox()
        contentPanelUserStatus = New Panel()
        Panel1 = New Panel()
        mainDashboardStatusPanel = New Panel()
        emailMiniPanel = New Panel()
        statusLabel = New Label()
        accStatusTitleLabel = New Label()
        accDeclinedPicBx = New PictureBox()
        emailMainTxtBx = New TextBox()
        sendBtnEmail = New Button()
        actionPanelUserEmail.SuspendLayout()
        CType(accPicBxStatus, ComponentModel.ISupportInitialize).BeginInit()
        CType(logoPicBoxUserStatus, ComponentModel.ISupportInitialize).BeginInit()
        contentPanelUserStatus.SuspendLayout()
        mainDashboardStatusPanel.SuspendLayout()
        emailMiniPanel.SuspendLayout()
        CType(accDeclinedPicBx, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' actionPanelUserEmail
        ' 
        actionPanelUserEmail.BackColor = Color.FromArgb(CByte(182), CByte(187), CByte(196))
        actionPanelUserEmail.Controls.Add(logoutBtnUser)
        actionPanelUserEmail.Controls.Add(statusBtnUser)
        actionPanelUserEmail.Controls.Add(emailsBtnUser)
        actionPanelUserEmail.Controls.Add(downloadBtnUser)
        actionPanelUserEmail.Controls.Add(dashboardBtnUser)
        actionPanelUserEmail.Controls.Add(Label1)
        actionPanelUserEmail.Controls.Add(accPicBxStatus)
        actionPanelUserEmail.Dock = DockStyle.Left
        actionPanelUserEmail.Location = New Point(0, 0)
        actionPanelUserEmail.Name = "actionPanelUserEmail"
        actionPanelUserEmail.Size = New Size(250, 791)
        actionPanelUserEmail.TabIndex = 6
        ' 
        ' logoutBtnUser
        ' 
        logoutBtnUser.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        logoutBtnUser.FlatStyle = FlatStyle.Popup
        logoutBtnUser.ForeColor = SystemColors.ButtonHighlight
        logoutBtnUser.Location = New Point(26, 721)
        logoutBtnUser.Name = "logoutBtnUser"
        logoutBtnUser.Size = New Size(203, 41)
        logoutBtnUser.TabIndex = 6
        logoutBtnUser.Text = "Logout"
        logoutBtnUser.UseVisualStyleBackColor = False
        ' 
        ' statusBtnUser
        ' 
        statusBtnUser.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        statusBtnUser.FlatStyle = FlatStyle.Popup
        statusBtnUser.ForeColor = SystemColors.ButtonHighlight
        statusBtnUser.Location = New Point(46, 435)
        statusBtnUser.Name = "statusBtnUser"
        statusBtnUser.Size = New Size(158, 41)
        statusBtnUser.TabIndex = 5
        statusBtnUser.Text = "Status"
        statusBtnUser.UseVisualStyleBackColor = False
        ' 
        ' emailsBtnUser
        ' 
        emailsBtnUser.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        emailsBtnUser.FlatStyle = FlatStyle.Popup
        emailsBtnUser.ForeColor = SystemColors.ButtonHighlight
        emailsBtnUser.Location = New Point(46, 375)
        emailsBtnUser.Name = "emailsBtnUser"
        emailsBtnUser.Size = New Size(158, 41)
        emailsBtnUser.TabIndex = 4
        emailsBtnUser.Text = "Emails"
        emailsBtnUser.UseVisualStyleBackColor = False
        ' 
        ' downloadBtnUser
        ' 
        downloadBtnUser.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        downloadBtnUser.FlatStyle = FlatStyle.Popup
        downloadBtnUser.ForeColor = SystemColors.ButtonHighlight
        downloadBtnUser.Location = New Point(46, 316)
        downloadBtnUser.Name = "downloadBtnUser"
        downloadBtnUser.Size = New Size(158, 41)
        downloadBtnUser.TabIndex = 3
        downloadBtnUser.Text = "Download Details"
        downloadBtnUser.UseVisualStyleBackColor = False
        ' 
        ' dashboardBtnUser
        ' 
        dashboardBtnUser.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        dashboardBtnUser.FlatStyle = FlatStyle.Popup
        dashboardBtnUser.ForeColor = SystemColors.ButtonHighlight
        dashboardBtnUser.Location = New Point(46, 256)
        dashboardBtnUser.Name = "dashboardBtnUser"
        dashboardBtnUser.Size = New Size(158, 41)
        dashboardBtnUser.TabIndex = 2
        dashboardBtnUser.Text = "Dashboard"
        dashboardBtnUser.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("HarmonyOS Sans SC Medium", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(70, 166)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 23)
        Label1.TabIndex = 1
        Label1.Text = "User_123"
        ' 
        ' accPicBxStatus
        ' 
        accPicBxStatus.Image = My.Resources.Resources.account_2040484
        accPicBxStatus.Location = New Point(64, 62)
        accPicBxStatus.Name = "accPicBxStatus"
        accPicBxStatus.Size = New Size(110, 101)
        accPicBxStatus.SizeMode = PictureBoxSizeMode.Zoom
        accPicBxStatus.TabIndex = 0
        accPicBxStatus.TabStop = False
        ' 
        ' logoPicBoxUserStatus
        ' 
        logoPicBoxUserStatus.Image = My.Resources.Resources.school_bus_12404453
        logoPicBoxUserStatus.Location = New Point(1193, 45)
        logoPicBoxUserStatus.Name = "logoPicBoxUserStatus"
        logoPicBoxUserStatus.Size = New Size(68, 61)
        logoPicBoxUserStatus.SizeMode = PictureBoxSizeMode.Zoom
        logoPicBoxUserStatus.TabIndex = 1
        logoPicBoxUserStatus.TabStop = False
        ' 
        ' contentPanelUserStatus
        ' 
        contentPanelUserStatus.Controls.Add(Panel1)
        contentPanelUserStatus.Controls.Add(logoPicBoxUserStatus)
        contentPanelUserStatus.Controls.Add(mainDashboardStatusPanel)
        contentPanelUserStatus.Dock = DockStyle.Fill
        contentPanelUserStatus.Location = New Point(0, 0)
        contentPanelUserStatus.Name = "contentPanelUserStatus"
        contentPanelUserStatus.Size = New Size(1264, 791)
        contentPanelUserStatus.TabIndex = 7
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(182), CByte(187), CByte(196))
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1264, 39)
        Panel1.TabIndex = 2
        ' 
        ' mainDashboardStatusPanel
        ' 
        mainDashboardStatusPanel.BackColor = Color.FromArgb(CByte(182), CByte(187), CByte(196))
        mainDashboardStatusPanel.Controls.Add(sendBtnEmail)
        mainDashboardStatusPanel.Controls.Add(emailMainTxtBx)
        mainDashboardStatusPanel.Controls.Add(emailMiniPanel)
        mainDashboardStatusPanel.Location = New Point(271, 137)
        mainDashboardStatusPanel.Name = "mainDashboardStatusPanel"
        mainDashboardStatusPanel.Size = New Size(961, 627)
        mainDashboardStatusPanel.TabIndex = 0
        ' 
        ' emailMiniPanel
        ' 
        emailMiniPanel.BackColor = Color.White
        emailMiniPanel.Controls.Add(statusLabel)
        emailMiniPanel.Controls.Add(accStatusTitleLabel)
        emailMiniPanel.Controls.Add(accDeclinedPicBx)
        emailMiniPanel.Location = New Point(45, 35)
        emailMiniPanel.Name = "emailMiniPanel"
        emailMiniPanel.Size = New Size(240, 69)
        emailMiniPanel.TabIndex = 20
        ' 
        ' statusLabel
        ' 
        statusLabel.AutoSize = True
        statusLabel.Font = New Font("HarmonyOS Sans SC", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        statusLabel.ForeColor = Color.Red
        statusLabel.Location = New Point(74, 34)
        statusLabel.Name = "statusLabel"
        statusLabel.Size = New Size(94, 26)
        statusLabel.TabIndex = 3
        statusLabel.Text = "Declined"
        ' 
        ' accStatusTitleLabel
        ' 
        accStatusTitleLabel.AutoSize = True
        accStatusTitleLabel.Font = New Font("HarmonyOS Sans SC", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        accStatusTitleLabel.Location = New Point(74, 11)
        accStatusTitleLabel.Name = "accStatusTitleLabel"
        accStatusTitleLabel.Size = New Size(139, 23)
        accStatusTitleLabel.TabIndex = 2
        accStatusTitleLabel.Text = "Account Status "
        ' 
        ' accDeclinedPicBx
        ' 
        accDeclinedPicBx.Image = CType(resources.GetObject("accDeclinedPicBx.Image"), Image)
        accDeclinedPicBx.Location = New Point(18, 11)
        accDeclinedPicBx.Name = "accDeclinedPicBx"
        accDeclinedPicBx.Size = New Size(50, 49)
        accDeclinedPicBx.SizeMode = PictureBoxSizeMode.Zoom
        accDeclinedPicBx.TabIndex = 0
        accDeclinedPicBx.TabStop = False
        ' 
        ' emailMainTxtBx
        ' 
        emailMainTxtBx.Location = New Point(45, 121)
        emailMainTxtBx.Multiline = True
        emailMainTxtBx.Name = "emailMainTxtBx"
        emailMainTxtBx.Size = New Size(878, 410)
        emailMainTxtBx.TabIndex = 21
        ' 
        ' sendBtnEmail
        ' 
        sendBtnEmail.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        sendBtnEmail.FlatStyle = FlatStyle.Popup
        sendBtnEmail.ForeColor = SystemColors.ButtonHighlight
        sendBtnEmail.Location = New Point(765, 560)
        sendBtnEmail.Name = "sendBtnEmail"
        sendBtnEmail.Size = New Size(158, 41)
        sendBtnEmail.TabIndex = 7
        sendBtnEmail.Text = "Send"
        sendBtnEmail.UseVisualStyleBackColor = False
        ' 
        ' ReApply
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 791)
        Controls.Add(actionPanelUserEmail)
        Controls.Add(contentPanelUserStatus)
        Name = "ReApply"
        Text = "ReApply"
        actionPanelUserEmail.ResumeLayout(False)
        actionPanelUserEmail.PerformLayout()
        CType(accPicBxStatus, ComponentModel.ISupportInitialize).EndInit()
        CType(logoPicBoxUserStatus, ComponentModel.ISupportInitialize).EndInit()
        contentPanelUserStatus.ResumeLayout(False)
        mainDashboardStatusPanel.ResumeLayout(False)
        mainDashboardStatusPanel.PerformLayout()
        emailMiniPanel.ResumeLayout(False)
        emailMiniPanel.PerformLayout()
        CType(accDeclinedPicBx, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents actionPanelUserEmail As Panel
    Friend WithEvents logoutBtnUser As Button
    Friend WithEvents statusBtnUser As Button
    Friend WithEvents emailsBtnUser As Button
    Friend WithEvents downloadBtnUser As Button
    Friend WithEvents dashboardBtnUser As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents accPicBxStatus As PictureBox
    Friend WithEvents logoPicBoxUserStatus As PictureBox
    Friend WithEvents contentPanelUserStatus As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents mainDashboardStatusPanel As Panel
    Friend WithEvents emailMiniPanel As Panel
    Friend WithEvents statusLabel As Label
    Friend WithEvents accStatusTitleLabel As Label
    Friend WithEvents accDeclinedPicBx As PictureBox
    Friend WithEvents sendBtnEmail As Button
    Friend WithEvents emailMainTxtBx As TextBox
End Class
