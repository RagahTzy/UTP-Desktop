<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class scoreboardSetting
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grpAlert = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'grpAlert
        '
        Me.grpAlert.Location = New System.Drawing.Point(12, 12)
        Me.grpAlert.Name = "grpAlert"
        Me.grpAlert.Size = New System.Drawing.Size(620, 300)
        Me.grpAlert.TabIndex = 0
        Me.grpAlert.TabStop = False
        Me.grpAlert.Text = "Alert"
        '
        'scoreboardSetting
        '
        Me.ClientSize = New System.Drawing.Size(650, 330)
        Me.Controls.Add(Me.grpAlert)
        Me.Name = "scoreboardSetting"
        Me.Text = "Scoreboard Setting"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpAlert As GroupBox

End Class