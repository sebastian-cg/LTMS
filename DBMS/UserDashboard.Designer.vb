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
        topDesignPanel = New FlowLayoutPanel()
        contentPanelUser = New Panel()
        SuspendLayout()
        ' 
        ' actionPanelUser
        ' 
        actionPanelUser.BackColor = Color.FromArgb(CByte(182), CByte(187), CByte(196))
        actionPanelUser.Dock = DockStyle.Left
        actionPanelUser.Location = New Point(0, 0)
        actionPanelUser.Name = "actionPanelUser"
        actionPanelUser.Size = New Size(250, 791)
        actionPanelUser.TabIndex = 0
        ' 
        ' topDesignPanel
        ' 
        topDesignPanel.BackColor = Color.FromArgb(CByte(182), CByte(187), CByte(196))
        topDesignPanel.Dock = DockStyle.Top
        topDesignPanel.Location = New Point(250, 0)
        topDesignPanel.Name = "topDesignPanel"
        topDesignPanel.Size = New Size(1014, 42)
        topDesignPanel.TabIndex = 0
        ' 
        ' contentPanelUser
        ' 
        contentPanelUser.Dock = DockStyle.Fill
        contentPanelUser.Location = New Point(250, 42)
        contentPanelUser.Name = "contentPanelUser"
        contentPanelUser.Size = New Size(1014, 749)
        contentPanelUser.TabIndex = 1
        ' 
        ' UserDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 791)
        Controls.Add(contentPanelUser)
        Controls.Add(topDesignPanel)
        Controls.Add(actionPanelUser)
        Name = "UserDashboard"
        Text = "UserDashboard"
        ResumeLayout(False)
    End Sub

    Friend WithEvents actionPanelUser As Panel
    Friend WithEvents topDesignPanel As FlowLayoutPanel
    Friend WithEvents contentPanelUser As Panel
End Class
