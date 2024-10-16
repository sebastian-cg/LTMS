<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatusView
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
        contentPanelUserStatus = New Panel()
        logoPicBoxUserStatus = New PictureBox()
        mainDashboardStatusPanel = New Panel()
        licenseExpiryPickerUserStatus = New DateTimePicker()
        licenseExpiryLblUserStatus = New Label()
        dLicenseNoTxtBxUserStatus = New TextBox()
        dLicenseNoLblUserStatus = New Label()
        nationalityTxtBxUserStatus = New TextBox()
        nationalityLblUserStatus = New Label()
        emailTxtBxUserStatus = New TextBox()
        emailLblUserStatus = New Label()
        phoneTxtBxUserStatus = New TextBox()
        phoneLblUserStatus = New Label()
        addressTxtBxUserStatus = New TextBox()
        addressLblUserStatus = New Label()
        datePickerUserStatus = New DateTimePicker()
        dateLblUserStatus = New Label()
        sexComboBxUserStatus = New ComboBox()
        sexLabelUserStatus = New Label()
        fullNameTxtBoxUserStatus = New TextBox()
        fullNameLblUserStatus = New Label()
        topPanelStatus = New Panel()
        actionPanelUserStatus = New Panel()
        logoutBtnUser = New Button()
        statusBtnUser = New Button()
        emailsBtnUser = New Button()
        downloadBtnUser = New Button()
        dashboardBtnUser = New Button()
        Label1 = New Label()
        accPicBxStatus = New PictureBox()
        statusMiniPanel = New Panel()
        statusPicBx = New PictureBox()
        statusTitleLabel = New Label()
        statusLabel = New Label()
        contentPanelUserStatus.SuspendLayout()
        CType(logoPicBoxUserStatus, ComponentModel.ISupportInitialize).BeginInit()
        mainDashboardStatusPanel.SuspendLayout()
        actionPanelUserStatus.SuspendLayout()
        CType(accPicBxStatus, ComponentModel.ISupportInitialize).BeginInit()
        statusMiniPanel.SuspendLayout()
        CType(statusPicBx, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' contentPanelUserStatus
        ' 
        contentPanelUserStatus.Controls.Add(logoPicBoxUserStatus)
        contentPanelUserStatus.Controls.Add(mainDashboardStatusPanel)
        contentPanelUserStatus.Dock = DockStyle.Fill
        contentPanelUserStatus.Location = New Point(250, 45)
        contentPanelUserStatus.Name = "contentPanelUserStatus"
        contentPanelUserStatus.Size = New Size(1014, 746)
        contentPanelUserStatus.TabIndex = 4
        ' 
        ' logoPicBoxUserStatus
        ' 
        logoPicBoxUserStatus.Image = My.Resources.Resources.school_bus_12404453
        logoPicBoxUserStatus.Location = New Point(946, 6)
        logoPicBoxUserStatus.Name = "logoPicBoxUserStatus"
        logoPicBoxUserStatus.Size = New Size(68, 61)
        logoPicBoxUserStatus.SizeMode = PictureBoxSizeMode.Zoom
        logoPicBoxUserStatus.TabIndex = 1
        logoPicBoxUserStatus.TabStop = False
        ' 
        ' mainDashboardStatusPanel
        ' 
        mainDashboardStatusPanel.BackColor = Color.FromArgb(CByte(182), CByte(187), CByte(196))
        mainDashboardStatusPanel.Controls.Add(statusMiniPanel)
        mainDashboardStatusPanel.Controls.Add(licenseExpiryPickerUserStatus)
        mainDashboardStatusPanel.Controls.Add(licenseExpiryLblUserStatus)
        mainDashboardStatusPanel.Controls.Add(dLicenseNoTxtBxUserStatus)
        mainDashboardStatusPanel.Controls.Add(dLicenseNoLblUserStatus)
        mainDashboardStatusPanel.Controls.Add(nationalityTxtBxUserStatus)
        mainDashboardStatusPanel.Controls.Add(nationalityLblUserStatus)
        mainDashboardStatusPanel.Controls.Add(emailTxtBxUserStatus)
        mainDashboardStatusPanel.Controls.Add(emailLblUserStatus)
        mainDashboardStatusPanel.Controls.Add(phoneTxtBxUserStatus)
        mainDashboardStatusPanel.Controls.Add(phoneLblUserStatus)
        mainDashboardStatusPanel.Controls.Add(addressTxtBxUserStatus)
        mainDashboardStatusPanel.Controls.Add(addressLblUserStatus)
        mainDashboardStatusPanel.Controls.Add(datePickerUserStatus)
        mainDashboardStatusPanel.Controls.Add(dateLblUserStatus)
        mainDashboardStatusPanel.Controls.Add(sexComboBxUserStatus)
        mainDashboardStatusPanel.Controls.Add(sexLabelUserStatus)
        mainDashboardStatusPanel.Controls.Add(fullNameTxtBoxUserStatus)
        mainDashboardStatusPanel.Controls.Add(fullNameLblUserStatus)
        mainDashboardStatusPanel.Location = New Point(28, 121)
        mainDashboardStatusPanel.Name = "mainDashboardStatusPanel"
        mainDashboardStatusPanel.Size = New Size(961, 596)
        mainDashboardStatusPanel.TabIndex = 0
        ' 
        ' licenseExpiryPickerUserStatus
        ' 
        licenseExpiryPickerUserStatus.Format = DateTimePickerFormat.Custom
        licenseExpiryPickerUserStatus.Location = New Point(696, 304)
        licenseExpiryPickerUserStatus.Name = "licenseExpiryPickerUserStatus"
        licenseExpiryPickerUserStatus.Size = New Size(131, 27)
        licenseExpiryPickerUserStatus.TabIndex = 18
        ' 
        ' licenseExpiryLblUserStatus
        ' 
        licenseExpiryLblUserStatus.AutoSize = True
        licenseExpiryLblUserStatus.Font = New Font("HarmonyOS Sans SC Medium", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        licenseExpiryLblUserStatus.Location = New Point(499, 304)
        licenseExpiryLblUserStatus.Name = "licenseExpiryLblUserStatus"
        licenseExpiryLblUserStatus.Size = New Size(188, 23)
        licenseExpiryLblUserStatus.TabIndex = 17
        licenseExpiryLblUserStatus.Text = "License Expiry Date:"
        ' 
        ' dLicenseNoTxtBxUserStatus
        ' 
        dLicenseNoTxtBxUserStatus.Location = New Point(696, 260)
        dLicenseNoTxtBxUserStatus.Name = "dLicenseNoTxtBxUserStatus"
        dLicenseNoTxtBxUserStatus.PlaceholderText = "   xxxx-xxx-xxxx"
        dLicenseNoTxtBxUserStatus.Size = New Size(232, 27)
        dLicenseNoTxtBxUserStatus.TabIndex = 16
        ' 
        ' dLicenseNoLblUserStatus
        ' 
        dLicenseNoLblUserStatus.AutoSize = True
        dLicenseNoLblUserStatus.Font = New Font("HarmonyOS Sans SC Medium", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dLicenseNoLblUserStatus.Location = New Point(499, 259)
        dLicenseNoLblUserStatus.Name = "dLicenseNoLblUserStatus"
        dLicenseNoLblUserStatus.Size = New Size(191, 23)
        dLicenseNoLblUserStatus.TabIndex = 15
        dLicenseNoLblUserStatus.Text = "Driving License No. :"
        ' 
        ' nationalityTxtBxUserStatus
        ' 
        nationalityTxtBxUserStatus.Location = New Point(651, 209)
        nationalityTxtBxUserStatus.Name = "nationalityTxtBxUserStatus"
        nationalityTxtBxUserStatus.PlaceholderText = "   Enter your name"
        nationalityTxtBxUserStatus.Size = New Size(277, 27)
        nationalityTxtBxUserStatus.TabIndex = 14
        ' 
        ' nationalityLblUserStatus
        ' 
        nationalityLblUserStatus.AutoSize = True
        nationalityLblUserStatus.Font = New Font("HarmonyOS Sans SC Medium", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nationalityLblUserStatus.Location = New Point(499, 208)
        nationalityLblUserStatus.Name = "nationalityLblUserStatus"
        nationalityLblUserStatus.Size = New Size(113, 23)
        nationalityLblUserStatus.TabIndex = 13
        nationalityLblUserStatus.Text = "Nationality:"
        ' 
        ' emailTxtBxUserStatus
        ' 
        emailTxtBxUserStatus.Location = New Point(651, 156)
        emailTxtBxUserStatus.Name = "emailTxtBxUserStatus"
        emailTxtBxUserStatus.PlaceholderText = "   Enter your name"
        emailTxtBxUserStatus.Size = New Size(277, 27)
        emailTxtBxUserStatus.TabIndex = 12
        ' 
        ' emailLblUserStatus
        ' 
        emailLblUserStatus.AutoSize = True
        emailLblUserStatus.Font = New Font("HarmonyOS Sans SC Medium", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        emailLblUserStatus.Location = New Point(499, 155)
        emailLblUserStatus.Name = "emailLblUserStatus"
        emailLblUserStatus.Size = New Size(63, 23)
        emailLblUserStatus.TabIndex = 11
        emailLblUserStatus.Text = "Email:"
        ' 
        ' phoneTxtBxUserStatus
        ' 
        phoneTxtBxUserStatus.Location = New Point(205, 355)
        phoneTxtBxUserStatus.Name = "phoneTxtBxUserStatus"
        phoneTxtBxUserStatus.Size = New Size(262, 27)
        phoneTxtBxUserStatus.TabIndex = 10
        ' 
        ' phoneLblUserStatus
        ' 
        phoneLblUserStatus.AutoSize = True
        phoneLblUserStatus.Font = New Font("HarmonyOS Sans SC Medium", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        phoneLblUserStatus.Location = New Point(53, 355)
        phoneLblUserStatus.Name = "phoneLblUserStatus"
        phoneLblUserStatus.Size = New Size(146, 23)
        phoneLblUserStatus.TabIndex = 9
        phoneLblUserStatus.Text = "Phone Number:"
        ' 
        ' addressTxtBxUserStatus
        ' 
        addressTxtBxUserStatus.Location = New Point(205, 304)
        addressTxtBxUserStatus.Name = "addressTxtBxUserStatus"
        addressTxtBxUserStatus.PlaceholderText = "   Enter your address"
        addressTxtBxUserStatus.Size = New Size(262, 27)
        addressTxtBxUserStatus.TabIndex = 8
        ' 
        ' addressLblUserStatus
        ' 
        addressLblUserStatus.AutoSize = True
        addressLblUserStatus.Font = New Font("HarmonyOS Sans SC Medium", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addressLblUserStatus.Location = New Point(53, 304)
        addressLblUserStatus.Name = "addressLblUserStatus"
        addressLblUserStatus.Size = New Size(86, 23)
        addressLblUserStatus.TabIndex = 7
        addressLblUserStatus.Text = "Address:"
        ' 
        ' datePickerUserStatus
        ' 
        datePickerUserStatus.Format = DateTimePickerFormat.Custom
        datePickerUserStatus.Location = New Point(205, 258)
        datePickerUserStatus.Name = "datePickerUserStatus"
        datePickerUserStatus.Size = New Size(131, 27)
        datePickerUserStatus.TabIndex = 6
        ' 
        ' dateLblUserStatus
        ' 
        dateLblUserStatus.AutoSize = True
        dateLblUserStatus.Font = New Font("HarmonyOS Sans SC Medium", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dateLblUserStatus.Location = New Point(53, 257)
        dateLblUserStatus.Name = "dateLblUserStatus"
        dateLblUserStatus.Size = New Size(129, 23)
        dateLblUserStatus.TabIndex = 5
        dateLblUserStatus.Text = "Date of Birth:"
        ' 
        ' sexComboBxUserStatus
        ' 
        sexComboBxUserStatus.FormattingEnabled = True
        sexComboBxUserStatus.Items.AddRange(New Object() {"Male", "Female"})
        sexComboBxUserStatus.Location = New Point(205, 208)
        sexComboBxUserStatus.Name = "sexComboBxUserStatus"
        sexComboBxUserStatus.Size = New Size(131, 28)
        sexComboBxUserStatus.TabIndex = 4
        ' 
        ' sexLabelUserStatus
        ' 
        sexLabelUserStatus.AutoSize = True
        sexLabelUserStatus.Font = New Font("HarmonyOS Sans SC Medium", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        sexLabelUserStatus.Location = New Point(53, 208)
        sexLabelUserStatus.Name = "sexLabelUserStatus"
        sexLabelUserStatus.Size = New Size(47, 23)
        sexLabelUserStatus.TabIndex = 3
        sexLabelUserStatus.Text = "Sex:"
        ' 
        ' fullNameTxtBoxUserStatus
        ' 
        fullNameTxtBoxUserStatus.Location = New Point(205, 156)
        fullNameTxtBoxUserStatus.Name = "fullNameTxtBoxUserStatus"
        fullNameTxtBoxUserStatus.PlaceholderText = "   Enter your name"
        fullNameTxtBoxUserStatus.Size = New Size(262, 27)
        fullNameTxtBoxUserStatus.TabIndex = 2
        ' 
        ' fullNameLblUserStatus
        ' 
        fullNameLblUserStatus.AutoSize = True
        fullNameLblUserStatus.Font = New Font("HarmonyOS Sans SC Medium", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        fullNameLblUserStatus.Location = New Point(53, 155)
        fullNameLblUserStatus.Name = "fullNameLblUserStatus"
        fullNameLblUserStatus.Size = New Size(104, 23)
        fullNameLblUserStatus.TabIndex = 1
        fullNameLblUserStatus.Text = "Full Name:"
        ' 
        ' topPanelStatus
        ' 
        topPanelStatus.BackColor = Color.FromArgb(CByte(182), CByte(187), CByte(196))
        topPanelStatus.Dock = DockStyle.Top
        topPanelStatus.Location = New Point(250, 0)
        topPanelStatus.Name = "topPanelStatus"
        topPanelStatus.Size = New Size(1014, 45)
        topPanelStatus.TabIndex = 5
        ' 
        ' actionPanelUserStatus
        ' 
        actionPanelUserStatus.BackColor = Color.FromArgb(CByte(182), CByte(187), CByte(196))
        actionPanelUserStatus.Controls.Add(logoutBtnUser)
        actionPanelUserStatus.Controls.Add(statusBtnUser)
        actionPanelUserStatus.Controls.Add(emailsBtnUser)
        actionPanelUserStatus.Controls.Add(downloadBtnUser)
        actionPanelUserStatus.Controls.Add(dashboardBtnUser)
        actionPanelUserStatus.Controls.Add(Label1)
        actionPanelUserStatus.Controls.Add(accPicBxStatus)
        actionPanelUserStatus.Dock = DockStyle.Left
        actionPanelUserStatus.Location = New Point(0, 0)
        actionPanelUserStatus.Name = "actionPanelUserStatus"
        actionPanelUserStatus.Size = New Size(250, 791)
        actionPanelUserStatus.TabIndex = 3
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
        ' statusMiniPanel
        ' 
        statusMiniPanel.BackColor = Color.White
        statusMiniPanel.Controls.Add(statusLabel)
        statusMiniPanel.Controls.Add(statusTitleLabel)
        statusMiniPanel.Controls.Add(statusPicBx)
        statusMiniPanel.Location = New Point(729, 17)
        statusMiniPanel.Name = "statusMiniPanel"
        statusMiniPanel.Size = New Size(213, 69)
        statusMiniPanel.TabIndex = 20
        ' 
        ' statusPicBx
        ' 
        statusPicBx.Image = My.Resources.Resources.Status
        statusPicBx.Location = New Point(18, 11)
        statusPicBx.Name = "statusPicBx"
        statusPicBx.Size = New Size(50, 49)
        statusPicBx.SizeMode = PictureBoxSizeMode.Zoom
        statusPicBx.TabIndex = 0
        statusPicBx.TabStop = False
        ' 
        ' statusTitleLabel
        ' 
        statusTitleLabel.AutoSize = True
        statusTitleLabel.Font = New Font("HarmonyOS Sans SC", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        statusTitleLabel.Location = New Point(74, 11)
        statusTitleLabel.Name = "statusTitleLabel"
        statusTitleLabel.Size = New Size(62, 23)
        statusTitleLabel.TabIndex = 2
        statusTitleLabel.Text = "Status"
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
        ' StatusView
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 791)
        Controls.Add(contentPanelUserStatus)
        Controls.Add(topPanelStatus)
        Controls.Add(actionPanelUserStatus)
        Name = "StatusView"
        Text = "StatusView"
        contentPanelUserStatus.ResumeLayout(False)
        CType(logoPicBoxUserStatus, ComponentModel.ISupportInitialize).EndInit()
        mainDashboardStatusPanel.ResumeLayout(False)
        mainDashboardStatusPanel.PerformLayout()
        actionPanelUserStatus.ResumeLayout(False)
        actionPanelUserStatus.PerformLayout()
        CType(accPicBxStatus, ComponentModel.ISupportInitialize).EndInit()
        statusMiniPanel.ResumeLayout(False)
        statusMiniPanel.PerformLayout()
        CType(statusPicBx, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents contentPanelUserStatus As Panel
    Friend WithEvents logoPicBoxUserStatus As PictureBox
    Friend WithEvents mainDashboardStatusPanel As Panel
    Friend WithEvents submitBtnUserDashB As Button
    Friend WithEvents licenseExpiryPickerUserStatus As DateTimePicker
    Friend WithEvents licenseExpiryLblUserStatus As Label
    Friend WithEvents dLicenseNoTxtBxUserStatus As TextBox
    Friend WithEvents dLicenseNoLblUserStatus As Label
    Friend WithEvents nationalityTxtBxUserStatus As TextBox
    Friend WithEvents nationalityLblUserStatus As Label
    Friend WithEvents emailTxtBxUserStatus As TextBox
    Friend WithEvents emailLblUserStatus As Label
    Friend WithEvents phoneTxtBxUserStatus As TextBox
    Friend WithEvents phoneLblUserStatus As Label
    Friend WithEvents addressTxtBxUserStatus As TextBox
    Friend WithEvents addressLblUserStatus As Label
    Friend WithEvents datePickerUserStatus As DateTimePicker
    Friend WithEvents dateLblUserStatus As Label
    Friend WithEvents sexComboBxUserStatus As ComboBox
    Friend WithEvents sexLabelUserStatus As Label
    Friend WithEvents fullNameTxtBoxUserStatus As TextBox
    Friend WithEvents fullNameLblUserStatus As Label
    Friend WithEvents topPanelStatus As Panel
    Friend WithEvents actionPanelUserStatus As Panel
    Friend WithEvents logoutBtnUser As Button
    Friend WithEvents statusBtnUser As Button
    Friend WithEvents emailsBtnUser As Button
    Friend WithEvents downloadBtnUser As Button
    Friend WithEvents dashboardBtnUser As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents accPicBxStatus As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents statusTitleLabel As Label
    Friend WithEvents statusPicBx As PictureBox
    Friend WithEvents statusLabel As Label
    Friend WithEvents statusMiniPanel As Panel
End Class
