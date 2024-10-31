<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FillUpForm
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
        logoutBtnUser = New Button()
        downloadBtnUser = New Button()
        dashboardBtnUser = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Panel3 = New Panel()
        logoPicBoxUser = New PictureBox()
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
        addressLblUserStatus = New Label()
        datePickerUserStatus = New DateTimePicker()
        dateLblUserStatus = New Label()
        sexComboBxUserStatus = New ComboBox()
        sexLabelUserStatus = New Label()
        mainDashboardStatusPanel = New Panel()
        addressTxtBxUserStatus = New TextBox()
        fullNameTxtBoxUserStatus = New TextBox()
        fullNameLblUserStatus = New Label()
        Button1 = New Button()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(logoPicBoxUser, ComponentModel.ISupportInitialize).BeginInit()
        mainDashboardStatusPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(182), CByte(187), CByte(196))
        Panel1.Controls.Add(logoutBtnUser)
        Panel1.Controls.Add(downloadBtnUser)
        Panel1.Controls.Add(dashboardBtnUser)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 791)
        Panel1.TabIndex = 0
        ' 
        ' logoutBtnUser
        ' 
        logoutBtnUser.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        logoutBtnUser.FlatStyle = FlatStyle.Popup
        logoutBtnUser.ForeColor = SystemColors.ButtonHighlight
        logoutBtnUser.Location = New Point(24, 704)
        logoutBtnUser.Name = "logoutBtnUser"
        logoutBtnUser.Size = New Size(203, 41)
        logoutBtnUser.TabIndex = 11
        logoutBtnUser.Text = "Logout"
        logoutBtnUser.UseVisualStyleBackColor = False
        ' 
        ' downloadBtnUser
        ' 
        downloadBtnUser.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        downloadBtnUser.FlatStyle = FlatStyle.Popup
        downloadBtnUser.ForeColor = SystemColors.ButtonHighlight
        downloadBtnUser.Location = New Point(44, 299)
        downloadBtnUser.Name = "downloadBtnUser"
        downloadBtnUser.Size = New Size(158, 41)
        downloadBtnUser.TabIndex = 10
        downloadBtnUser.Text = "Report"
        downloadBtnUser.UseVisualStyleBackColor = False
        ' 
        ' dashboardBtnUser
        ' 
        dashboardBtnUser.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        dashboardBtnUser.FlatStyle = FlatStyle.Popup
        dashboardBtnUser.ForeColor = SystemColors.ButtonHighlight
        dashboardBtnUser.Location = New Point(44, 239)
        dashboardBtnUser.Name = "dashboardBtnUser"
        dashboardBtnUser.Size = New Size(158, 41)
        dashboardBtnUser.TabIndex = 9
        dashboardBtnUser.Text = "Fill up"
        dashboardBtnUser.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("HarmonyOS Sans SC Medium", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(68, 149)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 23)
        Label1.TabIndex = 8
        Label1.Text = "User_123"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.account_2040484
        PictureBox1.Location = New Point(62, 45)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(110, 101)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(182), CByte(187), CByte(196))
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(250, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1014, 45)
        Panel2.TabIndex = 3
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(mainDashboardStatusPanel)
        Panel3.Controls.Add(logoPicBoxUser)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(250, 45)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1014, 746)
        Panel3.TabIndex = 4
        ' 
        ' logoPicBoxUser
        ' 
        logoPicBoxUser.Image = My.Resources.Resources.school_bus_12404453
        logoPicBoxUser.Location = New Point(943, 3)
        logoPicBoxUser.Name = "logoPicBoxUser"
        logoPicBoxUser.Size = New Size(68, 61)
        logoPicBoxUser.SizeMode = PictureBoxSizeMode.Zoom
        logoPicBoxUser.TabIndex = 2
        logoPicBoxUser.TabStop = False
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
        ' mainDashboardStatusPanel
        ' 
        mainDashboardStatusPanel.BackColor = Color.FromArgb(CByte(182), CByte(187), CByte(196))
        mainDashboardStatusPanel.Controls.Add(Button1)
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
        mainDashboardStatusPanel.Location = New Point(26, 116)
        mainDashboardStatusPanel.Name = "mainDashboardStatusPanel"
        mainDashboardStatusPanel.Size = New Size(961, 596)
        mainDashboardStatusPanel.TabIndex = 3
        ' 
        ' addressTxtBxUserStatus
        ' 
        addressTxtBxUserStatus.Location = New Point(205, 304)
        addressTxtBxUserStatus.Name = "addressTxtBxUserStatus"
        addressTxtBxUserStatus.PlaceholderText = "   Enter your address"
        addressTxtBxUserStatus.Size = New Size(262, 27)
        addressTxtBxUserStatus.TabIndex = 8
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
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        Button1.FlatStyle = FlatStyle.Popup
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(770, 505)
        Button1.Name = "Button1"
        Button1.Size = New Size(158, 41)
        Button1.TabIndex = 19
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("HarmonyOS Sans SC", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label2.Location = New Point(26, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(893, 30)
        Label2.TabIndex = 4
        Label2.Text = "Hello, new user! Fill up this form first before you to redirect from our dashboard."
        ' 
        ' FillUpForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 791)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "FillUpForm"
        Text = "FillUpForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(logoPicBoxUser, ComponentModel.ISupportInitialize).EndInit()
        mainDashboardStatusPanel.ResumeLayout(False)
        mainDashboardStatusPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents logoutBtnUser As Button
    Friend WithEvents downloadBtnUser As Button
    Friend WithEvents dashboardBtnUser As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents logoPicBoxUser As PictureBox
    Friend WithEvents mainDashboardStatusPanel As Panel
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class
