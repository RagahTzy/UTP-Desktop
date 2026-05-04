<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmWinner
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

    ' Deklarasi kontrol yang kurang
    Friend WithEvents LblWinnerName As System.Windows.Forms.Label
    Friend WithEvents LblWinnerTeam As System.Windows.Forms.Label
    Friend WithEvents LblWinnerTeamInfo As System.Windows.Forms.Label
    Friend WithEvents PanelWinner As System.Windows.Forms.Panel
    Friend WithEvents LblWinnerTitle As System.Windows.Forms.Label
    Friend WithEvents BtnCloseWinner As System.Windows.Forms.Button
    Friend WithEvents TimerAutoClose As System.Windows.Forms.Timer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PanelWinner = New System.Windows.Forms.Panel()
        Me.LblWinnerTitle = New System.Windows.Forms.Label()
        Me.LblWinnerName = New System.Windows.Forms.Label()
        Me.LblWinnerTeam = New System.Windows.Forms.Label()
        Me.LblWinnerTeamInfo = New System.Windows.Forms.Label()
        Me.BtnCloseWinner = New System.Windows.Forms.Button()
        Me.TimerAutoClose = New System.Windows.Forms.Timer(Me.components)
        Me.PanelWinner.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelWinner
        '
        Me.PanelWinner.Controls.Add(Me.LblWinnerTitle)
        Me.PanelWinner.Controls.Add(Me.LblWinnerName)
        Me.PanelWinner.Controls.Add(Me.LblWinnerTeam)
        Me.PanelWinner.Controls.Add(Me.LblWinnerTeamInfo)
        Me.PanelWinner.Location = New System.Drawing.Point(150, 50)
        Me.PanelWinner.Name = "PanelWinner"
        Me.PanelWinner.Size = New System.Drawing.Size(500, 250)
        Me.PanelWinner.TabIndex = 0
        '
        'LblWinnerTitle
        '
        Me.LblWinnerTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWinnerTitle.ForeColor = System.Drawing.Color.White
        Me.LblWinnerTitle.Location = New System.Drawing.Point(0, 20)
        Me.LblWinnerTitle.Name = "LblWinnerTitle"
        Me.LblWinnerTitle.Size = New System.Drawing.Size(500, 40)
        Me.LblWinnerTitle.TabIndex = 0
        Me.LblWinnerTitle.Text = "WINNER"
        Me.LblWinnerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblWinnerName
        '
        Me.LblWinnerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWinnerName.ForeColor = System.Drawing.Color.White
        Me.LblWinnerName.Location = New System.Drawing.Point(0, 90)
        Me.LblWinnerName.Name = "LblWinnerName"
        Me.LblWinnerName.Size = New System.Drawing.Size(500, 30)
        Me.LblWinnerName.TabIndex = 1
        Me.LblWinnerName.Text = "Name"
        Me.LblWinnerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblWinnerTeam
        '
        Me.LblWinnerTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWinnerTeam.ForeColor = System.Drawing.Color.White
        Me.LblWinnerTeam.Location = New System.Drawing.Point(0, 140)
        Me.LblWinnerTeam.Name = "LblWinnerTeam"
        Me.LblWinnerTeam.Size = New System.Drawing.Size(500, 30)
        Me.LblWinnerTeam.TabIndex = 2
        Me.LblWinnerTeam.Text = "Team"
        Me.LblWinnerTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblWinnerTeamInfo
        '
        Me.LblWinnerTeamInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWinnerTeamInfo.ForeColor = System.Drawing.Color.White
        Me.LblWinnerTeamInfo.Location = New System.Drawing.Point(0, 190)
        Me.LblWinnerTeamInfo.Name = "LblWinnerTeamInfo"
        Me.LblWinnerTeamInfo.Size = New System.Drawing.Size(500, 30)
        Me.LblWinnerTeamInfo.TabIndex = 3
        Me.LblWinnerTeamInfo.Text = "Team Info"
        Me.LblWinnerTeamInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCloseWinner
        '
        Me.BtnCloseWinner.Location = New System.Drawing.Point(350, 350)
        Me.BtnCloseWinner.Name = "BtnCloseWinner"
        Me.BtnCloseWinner.Size = New System.Drawing.Size(100, 40)
        Me.BtnCloseWinner.TabIndex = 1
        Me.BtnCloseWinner.Text = "Close"
        Me.BtnCloseWinner.UseVisualStyleBackColor = True
        '
        'TimerAutoClose
        '
        Me.TimerAutoClose.Interval = 10000
        '
        'FrmWinner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnCloseWinner)
        Me.Controls.Add(Me.PanelWinner)
        Me.Name = "FrmWinner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmWinner"
        Me.PanelWinner.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
End Class