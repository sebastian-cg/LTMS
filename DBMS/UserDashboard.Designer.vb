<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserDashboard
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
        actionPanelUser = New Panel()
        logoutBtnUser = New Button()
        statusBtnUser = New Button()
        emailsBtnUser = New Button()
        downloadBtnUser = New Button()
        dashboardBtnUser = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        contentPanelUser = New Panel()
        logoPicBoxUser = New PictureBox()
        mainDashboardPanel = New Panel()
        licenseExpiryPickerUserDashB = New DateTimePicker()
        licenseExpiryLblUserDashB = New Label()
        dLicenseNoTxtBxUserDashB = New TextBox()
        dLicenseNoLblUserDashB = New Label()
        nationalityTxtBxUserDashB = New TextBox()
        nationalityLblUserDashB = New Label()
        emailTxtBxUserDashB = New TextBox()
        emailLblUserDashB = New Label()
        phoneTxtBxUserDashB = New TextBox()
        phoneLblUserDashB = New Label()
        addressTxtBxUserDashB = New TextBox()
        addressLblUserDashB = New Label()
        datePickerUserDashB = New DateTimePicker()
        dateLblUserDashB = New Label()
        sexComboBxUserDashB = New ComboBox()
        sexLabelUserDashB = New Label()
        fullNameTxtBoxUserDashB = New TextBox()
        fullNameLblUserDashB = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        actionPanelUser.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        contentPanelUser.SuspendLayout()
        CType(logoPicBoxUser, ComponentModel.ISupportInitialize).BeginInit()
        mainDashboardPanel.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' actionPanelUser
        ' 
        actionPanelUser.BackColor = Color.FromArgb(CByte(182), CByte(187), CByte(196))
        actionPanelUser.Controls.Add(logoutBtnUser)
        actionPanelUser.Controls.Add(statusBtnUser)
        actionPanelUser.Controls.Add(emailsBtnUser)
        actionPanelUser.Controls.Add(downloadBtnUser)
        actionPanelUser.Controls.Add(dashboardBtnUser)
        actionPanelUser.Controls.Add(Label1)
        actionPanelUser.Controls.Add(PictureBox1)
        actionPanelUser.Dock = DockStyle.Left
        actionPanelUser.Location = New Point(0, 0)
        actionPanelUser.Name = "actionPanelUser"
        actionPanelUser.Size = New Size(250, 791)
        actionPanelUser.TabIndex = 0
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
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.account_2040484
        PictureBox1.Location = New Point(64, 62)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(110, 101)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' contentPanelUser
        ' 
        contentPanelUser.Controls.Add(logoPicBoxUser)
        contentPanelUser.Controls.Add(mainDashboardPanel)
        contentPanelUser.Dock = DockStyle.Fill
        contentPanelUser.Location = New Point(250, 0)
        contentPanelUser.Name = "contentPanelUser"
        contentPanelUser.Size = New Size(1014, 791)
        contentPanelUser.TabIndex = 1
        ' 
        ' logoPicBoxUser
        ' 
        logoPicBoxUser.Image = My.Resources.Resources.school_bus_12404453
        logoPicBoxUser.Location = New Point(943, 51)
        logoPicBoxUser.Name = "logoPicBoxUser"
        logoPicBoxUser.Size = New Size(68, 61)
        logoPicBoxUser.SizeMode = PictureBoxSizeMode.Zoom
        logoPicBoxUser.TabIndex = 1
        logoPicBoxUser.TabStop = False
        ' 
        ' mainDashboardPanel
        ' 
        mainDashboardPanel.BackColor = Color.FromArgb(CByte(182), CByte(187), CByte(196))
        mainDashboardPanel.Controls.Add(Panel2)
        mainDashboardPanel.Controls.Add(licenseExpiryPickerUserDashB)
        mainDashboardPanel.Controls.Add(licenseExpiryLblUserDashB)
        mainDashboardPanel.Controls.Add(dLicenseNoTxtBxUserDashB)
        mainDashboardPanel.Controls.Add(dLicenseNoLblUserDashB)
        mainDashboardPanel.Controls.Add(nationalityTxtBxUserDashB)
        mainDashboardPanel.Controls.Add(nationalityLblUserDashB)
        mainDashboardPanel.Controls.Add(emailTxtBxUserDashB)
        mainDashboardPanel.Controls.Add(emailLblUserDashB)
        mainDashboardPanel.Controls.Add(phoneTxtBxUserDashB)
        mainDashboardPanel.Controls.Add(phoneLblUserDashB)
        mainDashboardPanel.Controls.Add(addressTxtBxUserDashB)
        mainDashboardPanel.Controls.Add(addressLblUserDashB)
        mainDashboardPanel.Controls.Add(datePickerUserDashB)
        mainDashboardPanel.Controls.Add(dateLblUserDashB)
        mainDashboardPanel.Controls.Add(sexComboBxUserDashB)
        mainDashboardPanel.Controls.Add(sexLabelUserDashB)
        mainDashboardPanel.Controls.Add(fullNameTxtBoxUserDashB)
        mainDashboardPanel.Controls.Add(fullNameLblUserDashB)
        mainDashboardPanel.Location = New Point(28, 166)
        mainDashboardPanel.Name = "mainDashboardPanel"
        mainDashboardPanel.Size = New Size(961, 596)
        mainDashboardPanel.TabIndex = 0
        ' 
        ' licenseExpiryPickerUserDashB
        ' 
        licenseExpiryPickerUserDashB.Format = DateTimePickerFormat.Custom
        licenseExpiryPickerUserDashB.Location = New Point(696, 304)
        licenseExpiryPickerUserDashB.Name = "licenseExpiryPickerUserDashB"
        licenseExpiryPickerUserDashB.Size = New Size(131, 27)
        licenseExpiryPickerUserDashB.TabIndex = 18
        ' 
        ' licenseExpiryLblUserDashB
        ' 
        licenseExpiryLblUserDashB.AutoSize = True
        licenseExpiryLblUserDashB.Font = New Font("HarmonyOS Sans SC Medium", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        licenseExpiryLblUserDashB.Location = New Point(499, 304)
        licenseExpiryLblUserDashB.Name = "licenseExpiryLblUserDashB"
        licenseExpiryLblUserDashB.Size = New Size(188, 23)
        licenseExpiryLblUserDashB.TabIndex = 17
        licenseExpiryLblUserDashB.Text = "License Expiry Date:"
        ' 
        ' dLicenseNoTxtBxUserDashB
        ' 
        dLicenseNoTxtBxUserDashB.Location = New Point(696, 260)
        dLicenseNoTxtBxUserDashB.Name = "dLicenseNoTxtBxUserDashB"
        dLicenseNoTxtBxUserDashB.Size = New Size(232, 27)
        dLicenseNoTxtBxUserDashB.TabIndex = 16
        ' 
        ' dLicenseNoLblUserDashB
        ' 
        dLicenseNoLblUserDashB.AutoSize = True
        dLicenseNoLblUserDashB.Font = New Font("HarmonyOS Sans SC Medium", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dLicenseNoLblUserDashB.Location = New Point(499, 259)
        dLicenseNoLblUserDashB.Name = "dLicenseNoLblUserDashB"
        dLicenseNoLblUserDashB.Size = New Size(191, 23)
        dLicenseNoLblUserDashB.TabIndex = 15
        dLicenseNoLblUserDashB.Text = "Driving License No. :"
        ' 
        ' nationalityTxtBxUserDashB
        ' 
        nationalityTxtBxUserDashB.Location = New Point(651, 209)
        nationalityTxtBxUserDashB.Name = "nationalityTxtBxUserDashB"
        nationalityTxtBxUserDashB.Size = New Size(277, 27)
        nationalityTxtBxUserDashB.TabIndex = 14
        ' 
        ' nationalityLblUserDashB
        ' 
        nationalityLblUserDashB.AutoSize = True
        nationalityLblUserDashB.Font = New Font("HarmonyOS Sans SC Medium", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nationalityLblUserDashB.Location = New Point(499, 208)
        nationalityLblUserDashB.Name = "nationalityLblUserDashB"
        nationalityLblUserDashB.Size = New Size(113, 23)
        nationalityLblUserDashB.TabIndex = 13
        nationalityLblUserDashB.Text = "Nationality:"
        ' 
        ' emailTxtBxUserDashB
        ' 
        emailTxtBxUserDashB.Location = New Point(651, 156)
        emailTxtBxUserDashB.Name = "emailTxtBxUserDashB"
        emailTxtBxUserDashB.Size = New Size(277, 27)
        emailTxtBxUserDashB.TabIndex = 12
        ' 
        ' emailLblUserDashB
        ' 
        emailLblUserDashB.AutoSize = True
        emailLblUserDashB.Font = New Font("HarmonyOS Sans SC Medium", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        emailLblUserDashB.Location = New Point(499, 155)
        emailLblUserDashB.Name = "emailLblUserDashB"
        emailLblUserDashB.Size = New Size(63, 23)
        emailLblUserDashB.TabIndex = 11
        emailLblUserDashB.Text = "Email:"
        ' 
        ' phoneTxtBxUserDashB
        ' 
        phoneTxtBxUserDashB.Location = New Point(205, 355)
        phoneTxtBxUserDashB.Name = "phoneTxtBxUserDashB"
        phoneTxtBxUserDashB.Size = New Size(262, 27)
        phoneTxtBxUserDashB.TabIndex = 10
        ' 
        ' phoneLblUserDashB
        ' 
        phoneLblUserDashB.AutoSize = True
        phoneLblUserDashB.Font = New Font("HarmonyOS Sans SC Medium", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        phoneLblUserDashB.Location = New Point(53, 355)
        phoneLblUserDashB.Name = "phoneLblUserDashB"
        phoneLblUserDashB.Size = New Size(146, 23)
        phoneLblUserDashB.TabIndex = 9
        phoneLblUserDashB.Text = "Phone Number:"
        ' 
        ' addressTxtBxUserDashB
        ' 
        addressTxtBxUserDashB.Location = New Point(205, 304)
        addressTxtBxUserDashB.Name = "addressTxtBxUserDashB"
        addressTxtBxUserDashB.Size = New Size(262, 27)
        addressTxtBxUserDashB.TabIndex = 8
        ' 
        ' addressLblUserDashB
        ' 
        addressLblUserDashB.AutoSize = True
        addressLblUserDashB.Font = New Font("HarmonyOS Sans SC Medium", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addressLblUserDashB.Location = New Point(53, 304)
        addressLblUserDashB.Name = "addressLblUserDashB"
        addressLblUserDashB.Size = New Size(86, 23)
        addressLblUserDashB.TabIndex = 7
        addressLblUserDashB.Text = "Address:"
        ' 
        ' datePickerUserDashB
        ' 
        datePickerUserDashB.Format = DateTimePickerFormat.Custom
        datePickerUserDashB.Location = New Point(205, 258)
        datePickerUserDashB.Name = "datePickerUserDashB"
        datePickerUserDashB.Size = New Size(131, 27)
        datePickerUserDashB.TabIndex = 6
        ' 
        ' dateLblUserDashB
        ' 
        dateLblUserDashB.AutoSize = True
        dateLblUserDashB.Font = New Font("HarmonyOS Sans SC Medium", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dateLblUserDashB.Location = New Point(53, 257)
        dateLblUserDashB.Name = "dateLblUserDashB"
        dateLblUserDashB.Size = New Size(129, 23)
        dateLblUserDashB.TabIndex = 5
        dateLblUserDashB.Text = "Date of Birth:"
        ' 
        ' sexComboBxUserDashB
        ' 
        sexComboBxUserDashB.FormattingEnabled = True
        sexComboBxUserDashB.Items.AddRange(New Object() {"Male", "Female"})
        sexComboBxUserDashB.Location = New Point(205, 208)
        sexComboBxUserDashB.Name = "sexComboBxUserDashB"
        sexComboBxUserDashB.Size = New Size(131, 28)
        sexComboBxUserDashB.TabIndex = 4
        ' 
        ' sexLabelUserDashB
        ' 
        sexLabelUserDashB.AutoSize = True
        sexLabelUserDashB.Font = New Font("HarmonyOS Sans SC Medium", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        sexLabelUserDashB.Location = New Point(53, 208)
        sexLabelUserDashB.Name = "sexLabelUserDashB"
        sexLabelUserDashB.Size = New Size(47, 23)
        sexLabelUserDashB.TabIndex = 3
        sexLabelUserDashB.Text = "Sex:"
        ' 
        ' fullNameTxtBoxUserDashB
        ' 
        fullNameTxtBoxUserDashB.Location = New Point(205, 156)
        fullNameTxtBoxUserDashB.Name = "fullNameTxtBoxUserDashB"
        fullNameTxtBoxUserDashB.Size = New Size(262, 27)
        fullNameTxtBoxUserDashB.TabIndex = 2
        ' 
        ' fullNameLblUserDashB
        ' 
        fullNameLblUserDashB.AutoSize = True
        fullNameLblUserDashB.Font = New Font("HarmonyOS Sans SC Medium", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        fullNameLblUserDashB.Location = New Point(53, 155)
        fullNameLblUserDashB.Name = "fullNameLblUserDashB"
        fullNameLblUserDashB.Size = New Size(104, 23)
        fullNameLblUserDashB.TabIndex = 1
        fullNameLblUserDashB.Text = "Full Name:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(182), CByte(187), CByte(196))
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(250, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1014, 45)
        Panel1.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Location = New Point(53, 25)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(252, 80)
        Panel2.TabIndex = 19
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.id_card_12366448
        PictureBox2.Location = New Point(8, 10)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(69, 62)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("HarmonyOS Sans SC", 10.1999989F, FontStyle.Bold)
        Label2.Location = New Point(83, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 23)
        Label2.TabIndex = 1
        Label2.Text = "Account Status"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("HarmonyOS Sans SC", 11.999999F, FontStyle.Bold)
        Label3.ForeColor = Color.Lime
        Label3.Location = New Point(83, 33)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 26)
        Label3.TabIndex = 2
        Label3.Text = "Pending"
        ' 
        ' UserDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 791)
        Controls.Add(Panel1)
        Controls.Add(contentPanelUser)
        Controls.Add(actionPanelUser)
        Name = "UserDashboard"
        Text = "UserDashboard"
        actionPanelUser.ResumeLayout(False)
        actionPanelUser.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        contentPanelUser.ResumeLayout(False)
        CType(logoPicBoxUser, ComponentModel.ISupportInitialize).EndInit()
        mainDashboardPanel.ResumeLayout(False)
        mainDashboardPanel.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents actionPanelUser As Panel
    Friend WithEvents contentPanelUser As Panel
    Friend WithEvents logoutBtnUser As Button
    Friend WithEvents statusBtnUser As Button
    Friend WithEvents emailsBtnUser As Button
    Friend WithEvents downloadBtnUser As Button
    Friend WithEvents dashboardBtnUser As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents logoPicBoxUser As PictureBox
    Friend WithEvents mainDashboardPanel As Panel
    Friend WithEvents dateLblUserDashB As Label
    Friend WithEvents sexComboBxUserDashB As ComboBox
    Friend WithEvents sexLabelUserDashB As Label
    Friend WithEvents fullNameTxtBoxUserDashB As TextBox
    Friend WithEvents fullNameLblUserDashB As Label
    Friend WithEvents datePickerUserDashB As DateTimePicker
    Friend WithEvents phoneTxtBxUserDashB As TextBox
    Friend WithEvents phoneLblUserDashB As Label
    Friend WithEvents addressTxtBxUserDashB As TextBox
    Friend WithEvents addressLblUserDashB As Label
    Friend WithEvents dLicenseNoTxtBxUserDashB As TextBox
    Friend WithEvents dLicenseNoLblUserDashB As Label
    Friend WithEvents nationalityTxtBxUserDashB As TextBox
    Friend WithEvents nationalityLblUserDashB As Label
    Friend WithEvents emailTxtBxUserDashB As TextBox
    Friend WithEvents emailLblUserDashB As Label
    Friend WithEvents licenseExpiryPickerUserDashB As DateTimePicker
    Friend WithEvents licenseExpiryLblUserDashB As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
