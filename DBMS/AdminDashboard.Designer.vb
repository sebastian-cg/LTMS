<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        sidePanelAdminDB = New Panel()
        panelDropdown = New Panel()
        btnDeclineAccounts = New Button()
        btnPendingAccounts = New Button()
        btnCompletedAccounts = New Button()
        reportBtnAdminDB = New Button()
        logoutBtnAdminDB = New Button()
        SDBtnAdminDB = New Button()
        emailBtnAdminDB = New Button()
        userBtnAdminDB = New Button()
        dashboardBtnAdminDB = New Button()
        ic_accountAdminDb = New PictureBox()
        topPanelAdminDB = New Panel()
        ic_logoAdminDB = New PictureBox()
        centerPanelAdminDB = New Panel()
        adminIdAdminDb = New Label()
        welcomeLbl = New Label()
        mainPanelAdminDB = New Panel()
        DApanelAdminDB = New Panel()
        numDAadminDB = New Label()
        DAlblAdminDB = New Label()
        ic_DAadminDB = New PictureBox()
        CApanelAdminDB = New Panel()
        numCAadminDB = New Label()
        CAlblAdminDB = New Label()
        ic_CAadminDB = New PictureBox()
        panelPAadminDB = New Panel()
        numPAadminDB = New Label()
        PAlblAdminDB = New Label()
        ic_PAadminDB = New PictureBox()
        contentPanelAdminDB = New Panel()
        viewBtnAdminDb = New Button()
        searchBtnAdminDB = New Button()
        searchAdminDB = New TextBox()
        adminDGV = New DataGridView()
        DTPadminDB = New DateTimePicker()
        sidePanelAdminDB.SuspendLayout()
        panelDropdown.SuspendLayout()
        CType(ic_accountAdminDb, ComponentModel.ISupportInitialize).BeginInit()
        CType(ic_logoAdminDB, ComponentModel.ISupportInitialize).BeginInit()
        centerPanelAdminDB.SuspendLayout()
        mainPanelAdminDB.SuspendLayout()
        DApanelAdminDB.SuspendLayout()
        CType(ic_DAadminDB, ComponentModel.ISupportInitialize).BeginInit()
        CApanelAdminDB.SuspendLayout()
        CType(ic_CAadminDB, ComponentModel.ISupportInitialize).BeginInit()
        panelPAadminDB.SuspendLayout()
        CType(ic_PAadminDB, ComponentModel.ISupportInitialize).BeginInit()
        contentPanelAdminDB.SuspendLayout()
        CType(adminDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' sidePanelAdminDB
        ' 
        sidePanelAdminDB.BackColor = Color.FromArgb(CByte(182), CByte(187), CByte(196))
        sidePanelAdminDB.Controls.Add(panelDropdown)
        sidePanelAdminDB.Controls.Add(reportBtnAdminDB)
        sidePanelAdminDB.Controls.Add(logoutBtnAdminDB)
        sidePanelAdminDB.Controls.Add(SDBtnAdminDB)
        sidePanelAdminDB.Controls.Add(emailBtnAdminDB)
        sidePanelAdminDB.Controls.Add(userBtnAdminDB)
        sidePanelAdminDB.Controls.Add(dashboardBtnAdminDB)
        sidePanelAdminDB.Controls.Add(ic_accountAdminDb)
        sidePanelAdminDB.Dock = DockStyle.Left
        sidePanelAdminDB.Location = New Point(0, 0)
        sidePanelAdminDB.Name = "sidePanelAdminDB"
        sidePanelAdminDB.Size = New Size(250, 791)
        sidePanelAdminDB.TabIndex = 0
        ' 
        ' panelDropdown
        ' 
        panelDropdown.BackColor = Color.White
        panelDropdown.BorderStyle = BorderStyle.FixedSingle
        panelDropdown.Controls.Add(btnDeclineAccounts)
        panelDropdown.Controls.Add(btnPendingAccounts)
        panelDropdown.Controls.Add(btnCompletedAccounts)
        panelDropdown.Location = New Point(40, 402)
        panelDropdown.Name = "panelDropdown"
        panelDropdown.Size = New Size(158, 231)
        panelDropdown.TabIndex = 10
        panelDropdown.Visible = False
        ' 
        ' btnDeclineAccounts
        ' 
        btnDeclineAccounts.FlatStyle = FlatStyle.Popup
        btnDeclineAccounts.Location = New Point(3, 147)
        btnDeclineAccounts.Name = "btnDeclineAccounts"
        btnDeclineAccounts.Size = New Size(150, 72)
        btnDeclineAccounts.TabIndex = 2
        btnDeclineAccounts.Text = "Declined Accounts"
        btnDeclineAccounts.UseVisualStyleBackColor = True
        ' 
        ' btnPendingAccounts
        ' 
        btnPendingAccounts.FlatStyle = FlatStyle.Popup
        btnPendingAccounts.Location = New Point(3, 75)
        btnPendingAccounts.Name = "btnPendingAccounts"
        btnPendingAccounts.Size = New Size(150, 66)
        btnPendingAccounts.TabIndex = 1
        btnPendingAccounts.Text = "Pending Accounts"
        btnPendingAccounts.UseVisualStyleBackColor = True
        ' 
        ' btnCompletedAccounts
        ' 
        btnCompletedAccounts.FlatStyle = FlatStyle.Popup
        btnCompletedAccounts.Location = New Point(3, 12)
        btnCompletedAccounts.Name = "btnCompletedAccounts"
        btnCompletedAccounts.Size = New Size(150, 57)
        btnCompletedAccounts.TabIndex = 0
        btnCompletedAccounts.Text = "Completed Accounts"
        btnCompletedAccounts.UseVisualStyleBackColor = True
        ' 
        ' reportBtnAdminDB
        ' 
        reportBtnAdminDB.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        reportBtnAdminDB.FlatStyle = FlatStyle.Popup
        reportBtnAdminDB.Font = New Font("HarmonyOS Sans SC", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        reportBtnAdminDB.ForeColor = SystemColors.ButtonHighlight
        reportBtnAdminDB.Location = New Point(40, 358)
        reportBtnAdminDB.Name = "reportBtnAdminDB"
        reportBtnAdminDB.Size = New Size(158, 41)
        reportBtnAdminDB.TabIndex = 9
        reportBtnAdminDB.Text = "Reports"
        reportBtnAdminDB.UseVisualStyleBackColor = False
        ' 
        ' logoutBtnAdminDB
        ' 
        logoutBtnAdminDB.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        logoutBtnAdminDB.FlatStyle = FlatStyle.Popup
        logoutBtnAdminDB.ForeColor = SystemColors.ButtonHighlight
        logoutBtnAdminDB.Location = New Point(27, 732)
        logoutBtnAdminDB.Name = "logoutBtnAdminDB"
        logoutBtnAdminDB.Size = New Size(203, 41)
        logoutBtnAdminDB.TabIndex = 8
        logoutBtnAdminDB.Text = "Logout"
        logoutBtnAdminDB.UseVisualStyleBackColor = False
        ' 
        ' SDBtnAdminDB
        ' 
        SDBtnAdminDB.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        SDBtnAdminDB.FlatStyle = FlatStyle.Popup
        SDBtnAdminDB.Font = New Font("HarmonyOS Sans SC", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SDBtnAdminDB.ForeColor = SystemColors.ButtonHighlight
        SDBtnAdminDB.Location = New Point(40, 478)
        SDBtnAdminDB.Name = "SDBtnAdminDB"
        SDBtnAdminDB.Size = New Size(158, 49)
        SDBtnAdminDB.TabIndex = 7
        SDBtnAdminDB.Text = "Submitted Documents"
        SDBtnAdminDB.UseVisualStyleBackColor = False
        ' 
        ' emailBtnAdminDB
        ' 
        emailBtnAdminDB.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        emailBtnAdminDB.FlatStyle = FlatStyle.Popup
        emailBtnAdminDB.Font = New Font("HarmonyOS Sans SC", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        emailBtnAdminDB.ForeColor = SystemColors.ButtonHighlight
        emailBtnAdminDB.Location = New Point(40, 418)
        emailBtnAdminDB.Name = "emailBtnAdminDB"
        emailBtnAdminDB.Size = New Size(158, 41)
        emailBtnAdminDB.TabIndex = 6
        emailBtnAdminDB.Text = "Emails"
        emailBtnAdminDB.UseVisualStyleBackColor = False
        ' 
        ' userBtnAdminDB
        ' 
        userBtnAdminDB.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        userBtnAdminDB.FlatStyle = FlatStyle.Popup
        userBtnAdminDB.Font = New Font("HarmonyOS Sans SC", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        userBtnAdminDB.ForeColor = SystemColors.ButtonHighlight
        userBtnAdminDB.Location = New Point(40, 298)
        userBtnAdminDB.Name = "userBtnAdminDB"
        userBtnAdminDB.Size = New Size(158, 41)
        userBtnAdminDB.TabIndex = 4
        userBtnAdminDB.Text = "Users"
        userBtnAdminDB.UseVisualStyleBackColor = False
        ' 
        ' dashboardBtnAdminDB
        ' 
        dashboardBtnAdminDB.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        dashboardBtnAdminDB.FlatStyle = FlatStyle.Popup
        dashboardBtnAdminDB.Font = New Font("HarmonyOS Sans SC", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dashboardBtnAdminDB.ForeColor = SystemColors.ButtonHighlight
        dashboardBtnAdminDB.Location = New Point(40, 236)
        dashboardBtnAdminDB.Name = "dashboardBtnAdminDB"
        dashboardBtnAdminDB.Size = New Size(158, 41)
        dashboardBtnAdminDB.TabIndex = 3
        dashboardBtnAdminDB.Text = "Dashboard"
        dashboardBtnAdminDB.UseVisualStyleBackColor = False
        ' 
        ' ic_accountAdminDb
        ' 
        ic_accountAdminDb.Image = My.Resources.Resources.account_2040484
        ic_accountAdminDb.Location = New Point(53, 51)
        ic_accountAdminDb.Name = "ic_accountAdminDb"
        ic_accountAdminDb.Size = New Size(125, 113)
        ic_accountAdminDb.SizeMode = PictureBoxSizeMode.Zoom
        ic_accountAdminDb.TabIndex = 0
        ic_accountAdminDb.TabStop = False
        ' 
        ' topPanelAdminDB
        ' 
        topPanelAdminDB.BackColor = Color.FromArgb(CByte(182), CByte(187), CByte(196))
        topPanelAdminDB.Dock = DockStyle.Top
        topPanelAdminDB.Location = New Point(250, 0)
        topPanelAdminDB.Name = "topPanelAdminDB"
        topPanelAdminDB.Size = New Size(1014, 36)
        topPanelAdminDB.TabIndex = 1
        ' 
        ' ic_logoAdminDB
        ' 
        ic_logoAdminDB.Image = My.Resources.Resources.school_bus_12404453
        ic_logoAdminDB.Location = New Point(935, 6)
        ic_logoAdminDB.Name = "ic_logoAdminDB"
        ic_logoAdminDB.Size = New Size(67, 62)
        ic_logoAdminDB.SizeMode = PictureBoxSizeMode.Zoom
        ic_logoAdminDB.TabIndex = 2
        ic_logoAdminDB.TabStop = False
        ' 
        ' centerPanelAdminDB
        ' 
        centerPanelAdminDB.Controls.Add(adminIdAdminDb)
        centerPanelAdminDB.Controls.Add(welcomeLbl)
        centerPanelAdminDB.Controls.Add(mainPanelAdminDB)
        centerPanelAdminDB.Controls.Add(ic_logoAdminDB)
        centerPanelAdminDB.Dock = DockStyle.Fill
        centerPanelAdminDB.Location = New Point(250, 36)
        centerPanelAdminDB.Name = "centerPanelAdminDB"
        centerPanelAdminDB.Size = New Size(1014, 755)
        centerPanelAdminDB.TabIndex = 3
        ' 
        ' adminIdAdminDb
        ' 
        adminIdAdminDb.AutoSize = True
        adminIdAdminDb.Font = New Font("HarmonyOS Sans SC Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        adminIdAdminDb.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        adminIdAdminDb.Location = New Point(55, 38)
        adminIdAdminDb.Name = "adminIdAdminDb"
        adminIdAdminDb.Size = New Size(110, 30)
        adminIdAdminDb.TabIndex = 5
        adminIdAdminDb.Text = "AdminId"
        ' 
        ' welcomeLbl
        ' 
        welcomeLbl.AutoSize = True
        welcomeLbl.Font = New Font("HarmonyOS Sans SC", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        welcomeLbl.Location = New Point(26, 6)
        welcomeLbl.Name = "welcomeLbl"
        welcomeLbl.Size = New Size(145, 38)
        welcomeLbl.TabIndex = 4
        welcomeLbl.Text = "Welcome!"
        ' 
        ' mainPanelAdminDB
        ' 
        mainPanelAdminDB.BackColor = Color.FromArgb(CByte(182), CByte(187), CByte(196))
        mainPanelAdminDB.Controls.Add(DApanelAdminDB)
        mainPanelAdminDB.Controls.Add(CApanelAdminDB)
        mainPanelAdminDB.Controls.Add(panelPAadminDB)
        mainPanelAdminDB.Controls.Add(contentPanelAdminDB)
        mainPanelAdminDB.Location = New Point(26, 83)
        mainPanelAdminDB.Name = "mainPanelAdminDB"
        mainPanelAdminDB.Size = New Size(963, 654)
        mainPanelAdminDB.TabIndex = 3
        ' 
        ' DApanelAdminDB
        ' 
        DApanelAdminDB.BackColor = Color.White
        DApanelAdminDB.BorderStyle = BorderStyle.FixedSingle
        DApanelAdminDB.Controls.Add(numDAadminDB)
        DApanelAdminDB.Controls.Add(DAlblAdminDB)
        DApanelAdminDB.Controls.Add(ic_DAadminDB)
        DApanelAdminDB.Location = New Point(601, 15)
        DApanelAdminDB.Name = "DApanelAdminDB"
        DApanelAdminDB.Size = New Size(230, 70)
        DApanelAdminDB.TabIndex = 4
        ' 
        ' numDAadminDB
        ' 
        numDAadminDB.AutoSize = True
        numDAadminDB.Font = New Font("HarmonyOS Sans SC", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        numDAadminDB.ForeColor = Color.Red
        numDAadminDB.Location = New Point(59, 35)
        numDAadminDB.Name = "numDAadminDB"
        numDAadminDB.Size = New Size(24, 26)
        numDAadminDB.TabIndex = 2
        numDAadminDB.Text = "3"
        ' 
        ' DAlblAdminDB
        ' 
        DAlblAdminDB.AutoSize = True
        DAlblAdminDB.Font = New Font("HarmonyOS Sans SC", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DAlblAdminDB.Location = New Point(59, 12)
        DAlblAdminDB.Name = "DAlblAdminDB"
        DAlblAdminDB.Size = New Size(160, 23)
        DAlblAdminDB.TabIndex = 1
        DAlblAdminDB.Text = "Declined Accounts"
        ' 
        ' ic_DAadminDB
        ' 
        ic_DAadminDB.Image = CType(resources.GetObject("ic_DAadminDB.Image"), Image)
        ic_DAadminDB.Location = New Point(12, 12)
        ic_DAadminDB.Name = "ic_DAadminDB"
        ic_DAadminDB.Size = New Size(41, 42)
        ic_DAadminDB.SizeMode = PictureBoxSizeMode.Zoom
        ic_DAadminDB.TabIndex = 0
        ic_DAadminDB.TabStop = False
        ' 
        ' CApanelAdminDB
        ' 
        CApanelAdminDB.BackColor = Color.White
        CApanelAdminDB.BorderStyle = BorderStyle.FixedSingle
        CApanelAdminDB.Controls.Add(numCAadminDB)
        CApanelAdminDB.Controls.Add(CAlblAdminDB)
        CApanelAdminDB.Controls.Add(ic_CAadminDB)
        CApanelAdminDB.Location = New Point(302, 15)
        CApanelAdminDB.Name = "CApanelAdminDB"
        CApanelAdminDB.Size = New Size(248, 70)
        CApanelAdminDB.TabIndex = 3
        ' 
        ' numCAadminDB
        ' 
        numCAadminDB.AutoSize = True
        numCAadminDB.Font = New Font("HarmonyOS Sans SC", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        numCAadminDB.ForeColor = Color.Lime
        numCAadminDB.Location = New Point(59, 35)
        numCAadminDB.Name = "numCAadminDB"
        numCAadminDB.Size = New Size(24, 26)
        numCAadminDB.TabIndex = 2
        numCAadminDB.Text = "3"
        ' 
        ' CAlblAdminDB
        ' 
        CAlblAdminDB.AutoSize = True
        CAlblAdminDB.Font = New Font("HarmonyOS Sans SC", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CAlblAdminDB.Location = New Point(59, 12)
        CAlblAdminDB.Name = "CAlblAdminDB"
        CAlblAdminDB.Size = New Size(178, 23)
        CAlblAdminDB.TabIndex = 1
        CAlblAdminDB.Text = "Completed Accounts"
        ' 
        ' ic_CAadminDB
        ' 
        ic_CAadminDB.Image = CType(resources.GetObject("ic_CAadminDB.Image"), Image)
        ic_CAadminDB.Location = New Point(12, 12)
        ic_CAadminDB.Name = "ic_CAadminDB"
        ic_CAadminDB.Size = New Size(41, 42)
        ic_CAadminDB.SizeMode = PictureBoxSizeMode.Zoom
        ic_CAadminDB.TabIndex = 0
        ic_CAadminDB.TabStop = False
        ' 
        ' panelPAadminDB
        ' 
        panelPAadminDB.BackColor = Color.White
        panelPAadminDB.BorderStyle = BorderStyle.FixedSingle
        panelPAadminDB.Controls.Add(numPAadminDB)
        panelPAadminDB.Controls.Add(PAlblAdminDB)
        panelPAadminDB.Controls.Add(ic_PAadminDB)
        panelPAadminDB.Location = New Point(29, 15)
        panelPAadminDB.Name = "panelPAadminDB"
        panelPAadminDB.Size = New Size(230, 70)
        panelPAadminDB.TabIndex = 1
        ' 
        ' numPAadminDB
        ' 
        numPAadminDB.AutoSize = True
        numPAadminDB.Font = New Font("HarmonyOS Sans SC", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        numPAadminDB.ForeColor = Color.Red
        numPAadminDB.Location = New Point(59, 35)
        numPAadminDB.Name = "numPAadminDB"
        numPAadminDB.Size = New Size(24, 26)
        numPAadminDB.TabIndex = 2
        numPAadminDB.Text = "3"
        ' 
        ' PAlblAdminDB
        ' 
        PAlblAdminDB.AutoSize = True
        PAlblAdminDB.Font = New Font("HarmonyOS Sans SC", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PAlblAdminDB.Location = New Point(59, 12)
        PAlblAdminDB.Name = "PAlblAdminDB"
        PAlblAdminDB.Size = New Size(156, 23)
        PAlblAdminDB.TabIndex = 1
        PAlblAdminDB.Text = "Pending Accounts"
        ' 
        ' ic_PAadminDB
        ' 
        ic_PAadminDB.Image = My.Resources.Resources.pending_icon
        ic_PAadminDB.Location = New Point(12, 12)
        ic_PAadminDB.Name = "ic_PAadminDB"
        ic_PAadminDB.Size = New Size(41, 42)
        ic_PAadminDB.SizeMode = PictureBoxSizeMode.Zoom
        ic_PAadminDB.TabIndex = 0
        ic_PAadminDB.TabStop = False
        ' 
        ' contentPanelAdminDB
        ' 
        contentPanelAdminDB.BackColor = Color.White
        contentPanelAdminDB.BorderStyle = BorderStyle.FixedSingle
        contentPanelAdminDB.Controls.Add(viewBtnAdminDb)
        contentPanelAdminDB.Controls.Add(searchBtnAdminDB)
        contentPanelAdminDB.Controls.Add(searchAdminDB)
        contentPanelAdminDB.Controls.Add(adminDGV)
        contentPanelAdminDB.Controls.Add(DTPadminDB)
        contentPanelAdminDB.Location = New Point(29, 99)
        contentPanelAdminDB.Name = "contentPanelAdminDB"
        contentPanelAdminDB.Size = New Size(908, 536)
        contentPanelAdminDB.TabIndex = 0
        ' 
        ' viewBtnAdminDb
        ' 
        viewBtnAdminDb.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        viewBtnAdminDb.FlatStyle = FlatStyle.Popup
        viewBtnAdminDb.Font = New Font("HarmonyOS Sans SC", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        viewBtnAdminDb.ForeColor = SystemColors.ButtonHighlight
        viewBtnAdminDb.Location = New Point(747, 479)
        viewBtnAdminDb.Name = "viewBtnAdminDb"
        viewBtnAdminDb.Size = New Size(137, 37)
        viewBtnAdminDb.TabIndex = 7
        viewBtnAdminDb.Text = "View"
        viewBtnAdminDb.UseVisualStyleBackColor = False
        ' 
        ' searchBtnAdminDB
        ' 
        searchBtnAdminDB.BackColor = Color.FromArgb(CByte(49), CByte(48), CByte(77))
        searchBtnAdminDB.FlatStyle = FlatStyle.Popup
        searchBtnAdminDB.Font = New Font("HarmonyOS Sans SC", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchBtnAdminDB.ForeColor = Color.White
        searchBtnAdminDB.Location = New Point(790, 25)
        searchBtnAdminDB.Name = "searchBtnAdminDB"
        searchBtnAdminDB.Size = New Size(94, 27)
        searchBtnAdminDB.TabIndex = 3
        searchBtnAdminDB.Text = "Search"
        searchBtnAdminDB.UseVisualStyleBackColor = False
        ' 
        ' searchAdminDB
        ' 
        searchAdminDB.Font = New Font("HarmonyOS Sans SC", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchAdminDB.Location = New Point(463, 25)
        searchAdminDB.Name = "searchAdminDB"
        searchAdminDB.PlaceholderText = "Search user...."
        searchAdminDB.Size = New Size(321, 27)
        searchAdminDB.TabIndex = 2
        ' 
        ' adminDGV
        ' 
        adminDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        adminDGV.Location = New Point(24, 81)
        adminDGV.Name = "adminDGV"
        adminDGV.RowHeadersWidth = 51
        adminDGV.Size = New Size(860, 382)
        adminDGV.TabIndex = 1
        ' 
        ' DTPadminDB
        ' 
        DTPadminDB.Format = DateTimePickerFormat.Short
        DTPadminDB.Location = New Point(24, 25)
        DTPadminDB.Name = "DTPadminDB"
        DTPadminDB.Size = New Size(127, 27)
        DTPadminDB.TabIndex = 0
        ' 
        ' AdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 791)
        Controls.Add(centerPanelAdminDB)
        Controls.Add(topPanelAdminDB)
        Controls.Add(sidePanelAdminDB)
        Name = "AdminDashboard"
        Text = "AdminDashboard"
        sidePanelAdminDB.ResumeLayout(False)
        panelDropdown.ResumeLayout(False)
        CType(ic_accountAdminDb, ComponentModel.ISupportInitialize).EndInit()
        CType(ic_logoAdminDB, ComponentModel.ISupportInitialize).EndInit()
        centerPanelAdminDB.ResumeLayout(False)
        centerPanelAdminDB.PerformLayout()
        mainPanelAdminDB.ResumeLayout(False)
        DApanelAdminDB.ResumeLayout(False)
        DApanelAdminDB.PerformLayout()
        CType(ic_DAadminDB, ComponentModel.ISupportInitialize).EndInit()
        CApanelAdminDB.ResumeLayout(False)
        CApanelAdminDB.PerformLayout()
        CType(ic_CAadminDB, ComponentModel.ISupportInitialize).EndInit()
        panelPAadminDB.ResumeLayout(False)
        panelPAadminDB.PerformLayout()
        CType(ic_PAadminDB, ComponentModel.ISupportInitialize).EndInit()
        contentPanelAdminDB.ResumeLayout(False)
        contentPanelAdminDB.PerformLayout()
        CType(adminDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents sidePanelAdminDB As Panel
    Friend WithEvents ic_accountAdminDb As PictureBox
    Friend WithEvents topPanelAdminDB As Panel
    Friend WithEvents ic_logoAdminDB As PictureBox
    Friend WithEvents centerPanelAdminDB As Panel
    Friend WithEvents mainPanelAdminDB As Panel
    Friend WithEvents contentPanelAdminDB As Panel
    Friend WithEvents searchAdminDB As TextBox
    Friend WithEvents adminDGV As DataGridView
    Friend WithEvents DTPadminDB As DateTimePicker
    Friend WithEvents searchBtnAdminDB As Button
    Friend WithEvents adminIdAdminDb As Label
    Friend WithEvents welcomeLbl As Label
    Friend WithEvents panelPAadminDB As Panel
    Friend WithEvents PAlblAdminDB As Label
    Friend WithEvents ic_PAadminDB As PictureBox
    Friend WithEvents DApanelAdminDB As Panel
    Friend WithEvents numDAadminDB As Label
    Friend WithEvents DAlblAdminDB As Label
    Friend WithEvents ic_DAadminDB As PictureBox
    Friend WithEvents CApanelAdminDB As Panel
    Friend WithEvents numCAadminDB As Label
    Friend WithEvents CAlblAdminDB As Label
    Friend WithEvents ic_CAadminDB As PictureBox
    Friend WithEvents numPAadminDB As Label
    Friend WithEvents userBtnAdminDB As Button
    Friend WithEvents dashboardBtnAdminDB As Button
    Friend WithEvents SDBtnAdminDB As Button
    Friend WithEvents emailBtnAdminDB As Button
    Friend WithEvents logoutBtnAdminDB As Button
    Friend WithEvents viewBtnAdminDb As Button
    Friend WithEvents panelDropdown As Panel
    Friend WithEvents reportBtnAdminDB As Button
    Friend WithEvents btnDeclineAccounts As Button
    Friend WithEvents btnPendingAccounts As Button
    Friend WithEvents btnCompletedAccounts As Button
End Class
