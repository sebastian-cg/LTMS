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
        reportBtnNewUser = New Button()
        dashboardBtnUser = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Label2 = New Label()
        mainDashboardStatusPanel = New Panel()
        submitBtnFF = New Button()
        licenseExpiryPickerNU = New DateTimePicker()
        licenseExpiryLblUserStatus = New Label()
        dLicenseNoTxtBxNU = New TextBox()
        dLicenseNoLblUserStatus = New Label()
        nationalityTxtBxNU = New TextBox()
        nationalityLblUserStatus = New Label()
        emailTxtBxNU = New TextBox()
        emailLblUserStatus = New Label()
        phoneTxtBxNU = New TextBox()
        phoneLblUserStatus = New Label()
        addressTxtBxNU = New TextBox()
        addressLblUserStatus = New Label()
        datePickerNU = New DateTimePicker()
        dateLblUserStatus = New Label()
        sexComboBxNU = New ComboBox()
        sexLabelUserStatus = New Label()
        fullNameTxtBoxNU = New TextBox()
        fullNameLblUserStatus = New Label()
        logoPicBoxUser = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        mainDashboardStatusPanel.SuspendLayout()
        CType(logoPicBoxUser, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(182), CByte(187), CByte(196))
        Panel1.Controls.Add(logoutBtnUser)
        Panel1.Controls.Add(reportBtnNewUser)
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
        ' reportBtnNewUser
        ' 
        reportBtnNewUser.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        reportBtnNewUser.FlatStyle = FlatStyle.Popup
        reportBtnNewUser.ForeColor = SystemColors.ButtonHighlight
        reportBtnNewUser.Location = New Point(44, 299)
        reportBtnNewUser.Name = "reportBtnNewUser"
        reportBtnNewUser.Size = New Size(158, 41)
        reportBtnNewUser.TabIndex = 10
        reportBtnNewUser.Text = "Report"
        reportBtnNewUser.UseVisualStyleBackColor = False
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
        ' mainDashboardStatusPanel
        ' 
        mainDashboardStatusPanel.BackColor = Color.FromArgb(CByte(182), CByte(187), CByte(196))
        mainDashboardStatusPanel.Controls.Add(submitBtnFF)
        mainDashboardStatusPanel.Controls.Add(licenseExpiryPickerNU)
        mainDashboardStatusPanel.Controls.Add(licenseExpiryLblUserStatus)
        mainDashboardStatusPanel.Controls.Add(dLicenseNoTxtBxNU)
        mainDashboardStatusPanel.Controls.Add(dLicenseNoLblUserStatus)
        mainDashboardStatusPanel.Controls.Add(nationalityTxtBxNU)
        mainDashboardStatusPanel.Controls.Add(nationalityLblUserStatus)
        mainDashboardStatusPanel.Controls.Add(emailTxtBxNU)
        mainDashboardStatusPanel.Controls.Add(emailLblUserStatus)
        mainDashboardStatusPanel.Controls.Add(phoneTxtBxNU)
        mainDashboardStatusPanel.Controls.Add(phoneLblUserStatus)
        mainDashboardStatusPanel.Controls.Add(addressTxtBxNU)
        mainDashboardStatusPanel.Controls.Add(addressLblUserStatus)
        mainDashboardStatusPanel.Controls.Add(datePickerNU)
        mainDashboardStatusPanel.Controls.Add(dateLblUserStatus)
        mainDashboardStatusPanel.Controls.Add(sexComboBxNU)
        mainDashboardStatusPanel.Controls.Add(sexLabelUserStatus)
        mainDashboardStatusPanel.Controls.Add(fullNameTxtBoxNU)
        mainDashboardStatusPanel.Controls.Add(fullNameLblUserStatus)
        mainDashboardStatusPanel.Location = New Point(26, 116)
        mainDashboardStatusPanel.Name = "mainDashboardStatusPanel"
        mainDashboardStatusPanel.Size = New Size(961, 596)
        mainDashboardStatusPanel.TabIndex = 3
        ' 
        ' submitBtnFF
        ' 
        submitBtnFF.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        submitBtnFF.FlatStyle = FlatStyle.Popup
        submitBtnFF.ForeColor = SystemColors.ButtonHighlight
        submitBtnFF.Location = New Point(770, 505)
        submitBtnFF.Name = "submitBtnFF"
        submitBtnFF.Size = New Size(158, 41)
        submitBtnFF.TabIndex = 19
        submitBtnFF.Text = "Submit"
        submitBtnFF.UseVisualStyleBackColor = False
        ' 
        ' licenseExpiryPickerNU
        ' 
        licenseExpiryPickerNU.Format = DateTimePickerFormat.Custom
        licenseExpiryPickerNU.Location = New Point(696, 304)
        licenseExpiryPickerNU.Name = "licenseExpiryPickerNU"
        licenseExpiryPickerNU.Size = New Size(131, 27)
        licenseExpiryPickerNU.TabIndex = 18
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
        ' dLicenseNoTxtBxNU
        ' 
        dLicenseNoTxtBxNU.Location = New Point(696, 260)
        dLicenseNoTxtBxNU.Name = "dLicenseNoTxtBxNU"
        dLicenseNoTxtBxNU.PlaceholderText = "   xxxx-xxx-xxxx"
        dLicenseNoTxtBxNU.Size = New Size(232, 27)
        dLicenseNoTxtBxNU.TabIndex = 16
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
        ' nationalityTxtBxNU
        ' 
        nationalityTxtBxNU.Location = New Point(651, 209)
        nationalityTxtBxNU.Name = "nationalityTxtBxNU"
        nationalityTxtBxNU.PlaceholderText = "   Enter your name"
        nationalityTxtBxNU.Size = New Size(277, 27)
        nationalityTxtBxNU.TabIndex = 14
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
        ' emailTxtBxNU
        ' 
        emailTxtBxNU.Location = New Point(651, 156)
        emailTxtBxNU.Name = "emailTxtBxNU"
        emailTxtBxNU.PlaceholderText = "   Enter your name"
        emailTxtBxNU.Size = New Size(277, 27)
        emailTxtBxNU.TabIndex = 12
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
        ' phoneTxtBxNU
        ' 
        phoneTxtBxNU.Location = New Point(205, 355)
        phoneTxtBxNU.Name = "phoneTxtBxNU"
        phoneTxtBxNU.Size = New Size(262, 27)
        phoneTxtBxNU.TabIndex = 10
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
        ' addressTxtBxNU
        ' 
        addressTxtBxNU.Location = New Point(205, 304)
        addressTxtBxNU.Name = "addressTxtBxNU"
        addressTxtBxNU.PlaceholderText = "   Enter your address"
        addressTxtBxNU.Size = New Size(262, 27)
        addressTxtBxNU.TabIndex = 8
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
        ' datePickerNU
        ' 
        datePickerNU.Format = DateTimePickerFormat.Custom
        datePickerNU.Location = New Point(205, 258)
        datePickerNU.Name = "datePickerNU"
        datePickerNU.Size = New Size(131, 27)
        datePickerNU.TabIndex = 6
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
        ' sexComboBxNU
        ' 
        sexComboBxNU.FormattingEnabled = True
        sexComboBxNU.Items.AddRange(New Object() {"Male", "Female"})
        sexComboBxNU.Location = New Point(205, 208)
        sexComboBxNU.Name = "sexComboBxNU"
        sexComboBxNU.Size = New Size(131, 28)
        sexComboBxNU.TabIndex = 4
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
        ' fullNameTxtBoxNU
        ' 
        fullNameTxtBoxNU.Location = New Point(205, 156)
        fullNameTxtBoxNU.Name = "fullNameTxtBoxNU"
        fullNameTxtBoxNU.PlaceholderText = "   Enter your name"
        fullNameTxtBoxNU.Size = New Size(262, 27)
        fullNameTxtBoxNU.TabIndex = 2
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
        mainDashboardStatusPanel.ResumeLayout(False)
        mainDashboardStatusPanel.PerformLayout()
        CType(logoPicBoxUser, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents logoutBtnUser As Button
    Friend WithEvents reportBtnNewUser As Button
    Friend WithEvents dashboardBtnUser As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents logoPicBoxUser As PictureBox
    Friend WithEvents mainDashboardStatusPanel As Panel
    Friend WithEvents licenseExpiryPickerNU As DateTimePicker
    Friend WithEvents licenseExpiryLblUserStatus As Label
    Friend WithEvents dLicenseNoTxtBxNU As TextBox
    Friend WithEvents dLicenseNoLblUserStatus As Label
    Friend WithEvents nationalityTxtBxNU As TextBox
    Friend WithEvents nationalityLblUserStatus As Label
    Friend WithEvents emailTxtBxNU As TextBox
    Friend WithEvents emailLblUserStatus As Label
    Friend WithEvents phoneTxtBxNU As TextBox
    Friend WithEvents phoneLblUserStatus As Label
    Friend WithEvents addressTxtBxNU As TextBox
    Friend WithEvents addressLblUserStatus As Label
    Friend WithEvents datePickerNU As DateTimePicker
    Friend WithEvents dateLblUserStatus As Label
    Friend WithEvents sexComboBxNU As ComboBox
    Friend WithEvents sexLabelUserStatus As Label
    Friend WithEvents fullNameTxtBoxNU As TextBox
    Friend WithEvents fullNameLblUserStatus As Label
    Friend WithEvents submitBtnFF As Button
    Friend WithEvents Label2 As Label
End Class
