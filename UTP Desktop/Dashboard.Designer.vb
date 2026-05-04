<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        pnlHeader = New Panel()
        pbLogo = New PictureBox()
        btnActivation = New Button()
        lblActivationReq = New Label()
        lblTatamiVal = New Label()
        lblTatamiID = New Label()
        pnlMain = New Panel()
        lblWebsite = New Label()
        btnManageJudge = New Button()
        btnKataServer = New Button()
        pnlStatusTable = New Panel()
        lblLocalStatus = New Label()
        lblYabinyaStatus = New Label()
        lblStatusHeader = New Label()
        pnlKata = New Panel()
        lblKata = New Label()
        pbKata = New PictureBox()
        pnlKumite = New Panel()
        lblKumite = New Label()
        pbKumite = New PictureBox()
        pnlCompetitors = New Panel()
        lblCompetitors = New Label()
        pbCompetitors = New PictureBox()
        pnlResult = New Panel()
        lblResult = New Label()
        pbResult = New PictureBox()
        pnlHeader.SuspendLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlMain.SuspendLayout()
        pnlStatusTable.SuspendLayout()
        pnlKata.SuspendLayout()
        CType(pbKata, ComponentModel.ISupportInitialize).BeginInit()
        pnlKumite.SuspendLayout()
        CType(pbKumite, ComponentModel.ISupportInitialize).BeginInit()
        pnlCompetitors.SuspendLayout()
        CType(pbCompetitors, ComponentModel.ISupportInitialize).BeginInit()
        pnlResult.SuspendLayout()
        CType(pbResult, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        pnlHeader.Controls.Add(pbLogo)
        pnlHeader.Controls.Add(btnActivation)
        pnlHeader.Controls.Add(lblActivationReq)
        pnlHeader.Controls.Add(lblTatamiVal)
        pnlHeader.Controls.Add(lblTatamiID)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(800, 130)
        pnlHeader.TabIndex = 0
        ' 
        ' pbLogo
        ' 
        pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), Image)
        pbLogo.Location = New Point(670, 15)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(100, 100)
        pbLogo.SizeMode = PictureBoxSizeMode.Zoom
        pbLogo.TabIndex = 4
        pbLogo.TabStop = False
        ' 
        ' btnActivation
        ' 
        btnActivation.FlatAppearance.BorderColor = Color.Cyan
        btnActivation.FlatStyle = FlatStyle.Flat
        btnActivation.Font = New Font("Segoe UI", 10.0F)
        btnActivation.ForeColor = Color.Cyan
        btnActivation.Location = New Point(400, 55)
        btnActivation.Name = "btnActivation"
        btnActivation.Size = New Size(220, 35)
        btnActivation.TabIndex = 3
        btnActivation.Text = "Enter Activation Code"
        btnActivation.UseVisualStyleBackColor = True
        ' 
        ' lblActivationReq
        ' 
        lblActivationReq.AutoSize = True
        lblActivationReq.Font = New Font("Segoe UI Black", 12.0F, FontStyle.Bold)
        lblActivationReq.ForeColor = Color.Red
        lblActivationReq.Location = New Point(400, 25)
        lblActivationReq.Name = "lblActivationReq"
        lblActivationReq.Size = New Size(167, 21)
        lblActivationReq.TabIndex = 2
        lblActivationReq.Text = "Activation Required"
        ' 
        ' lblTatamiVal
        ' 
        lblTatamiVal.AutoSize = True
        lblTatamiVal.Font = New Font("Segoe UI Black", 20.0F, FontStyle.Bold)
        lblTatamiVal.ForeColor = Color.White
        lblTatamiVal.Location = New Point(25, 45)
        lblTatamiVal.Name = "lblTatamiVal"
        lblTatamiVal.Size = New Size(299, 37)
        lblTatamiVal.TabIndex = 1
        lblTatamiVal.Text = "Karate Scoring Board"
        ' 
        ' lblTatamiID
        ' 
        lblTatamiID.AutoSize = True
        lblTatamiID.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblTatamiID.ForeColor = Color.Yellow
        lblTatamiID.Location = New Point(30, 20)
        lblTatamiID.Name = "lblTatamiID"
        lblTatamiID.Size = New Size(90, 19)
        lblTatamiID.TabIndex = 0
        lblTatamiID.Text = "Kelompok 1"
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        pnlMain.Controls.Add(lblWebsite)
        pnlMain.Controls.Add(btnManageJudge)
        pnlMain.Controls.Add(btnKataServer)
        pnlMain.Controls.Add(pnlStatusTable)
        pnlMain.Controls.Add(pnlKata)
        pnlMain.Controls.Add(pnlKumite)
        pnlMain.Controls.Add(pnlCompetitors)
        pnlMain.Controls.Add(pnlResult)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 130)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(800, 431)
        pnlMain.TabIndex = 1
        ' 
        ' lblWebsite
        ' 
        lblWebsite.Dock = DockStyle.Bottom
        lblWebsite.Font = New Font("Segoe UI", 9.0F)
        lblWebsite.ForeColor = Color.DimGray
        lblWebsite.Location = New Point(0, 406)
        lblWebsite.Name = "lblWebsite"
        lblWebsite.Size = New Size(800, 25)
        lblWebsite.TabIndex = 7
        lblWebsite.Text = "www.yabinyastudio.com"
        lblWebsite.TextAlign = ContentAlignment.TopCenter
        ' 
        ' btnManageJudge
        ' 
        btnManageJudge.BackColor = Color.White
        btnManageJudge.FlatAppearance.BorderColor = Color.LightGray
        btnManageJudge.FlatStyle = FlatStyle.Flat
        btnManageJudge.ForeColor = Color.SaddleBrown
        btnManageJudge.Location = New Point(550, 310)
        btnManageJudge.Name = "btnManageJudge"
        btnManageJudge.Size = New Size(180, 40)
        btnManageJudge.TabIndex = 6
        btnManageJudge.Text = "Manage KATA Judge"
        btnManageJudge.UseVisualStyleBackColor = False
        ' 
        ' btnKataServer
        ' 
        btnKataServer.BackColor = Color.White
        btnKataServer.FlatAppearance.BorderColor = Color.LightGray
        btnKataServer.FlatStyle = FlatStyle.Flat
        btnKataServer.ForeColor = Color.SaddleBrown
        btnKataServer.Location = New Point(550, 260)
        btnKataServer.Name = "btnKataServer"
        btnKataServer.Size = New Size(180, 40)
        btnKataServer.TabIndex = 5
        btnKataServer.Text = "Kata Scoring Server"
        btnKataServer.UseVisualStyleBackColor = False
        ' 
        ' pnlStatusTable
        ' 
        pnlStatusTable.BackColor = Color.White
        pnlStatusTable.BorderStyle = BorderStyle.FixedSingle
        pnlStatusTable.Controls.Add(lblLocalStatus)
        pnlStatusTable.Controls.Add(lblYabinyaStatus)
        pnlStatusTable.Controls.Add(lblStatusHeader)
        pnlStatusTable.Location = New Point(280, 260)
        pnlStatusTable.Name = "pnlStatusTable"
        pnlStatusTable.Size = New Size(240, 90)
        pnlStatusTable.TabIndex = 4
        ' 
        ' lblLocalStatus
        ' 
        lblLocalStatus.AutoSize = True
        lblLocalStatus.Font = New Font("Segoe UI", 9.0F)
        lblLocalStatus.Location = New Point(10, 60)
        lblLocalStatus.Name = "lblLocalStatus"
        lblLocalStatus.Size = New Size(157, 15)
        lblLocalStatus.TabIndex = 2
        lblLocalStatus.Text = "Local Server    [Unregistered]"
        ' 
        ' lblYabinyaStatus
        ' 
        lblYabinyaStatus.AutoSize = True
        lblYabinyaStatus.Font = New Font("Segoe UI", 9.0F)
        lblYabinyaStatus.Location = New Point(10, 35)
        lblYabinyaStatus.Name = "lblYabinyaStatus"
        lblYabinyaStatus.Size = New Size(161, 15)
        lblYabinyaStatus.TabIndex = 1
        lblYabinyaStatus.Text = "Yabinya Server [Unregistered]"
        ' 
        ' lblStatusHeader
        ' 
        lblStatusHeader.BackColor = Color.Crimson
        lblStatusHeader.Dock = DockStyle.Top
        lblStatusHeader.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblStatusHeader.ForeColor = Color.White
        lblStatusHeader.Location = New Point(0, 0)
        lblStatusHeader.Name = "lblStatusHeader"
        lblStatusHeader.Size = New Size(238, 25)
        lblStatusHeader.TabIndex = 0
        lblStatusHeader.Text = "Kata Scoring Server Status"
        lblStatusHeader.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlKata
        ' 
        pnlKata.Controls.Add(lblKata)
        pnlKata.Controls.Add(pbKata)
        pnlKata.Location = New Point(550, 40)
        pnlKata.Name = "pnlKata"
        pnlKata.Size = New Size(160, 180)
        pnlKata.TabIndex = 2
        ' 
        ' lblKata
        ' 
        lblKata.Dock = DockStyle.Bottom
        lblKata.Font = New Font("Segoe UI Black", 12.0F, FontStyle.Bold)
        lblKata.Location = New Point(0, 145)
        lblKata.Name = "lblKata"
        lblKata.Size = New Size(160, 35)
        lblKata.TabIndex = 1
        lblKata.Text = "KATA"
        lblKata.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pbKata
        ' 
        pbKata.Location = New Point(15, 10)
        pbKata.Name = "pbKata"
        pbKata.Size = New Size(130, 130)
        pbKata.SizeMode = PictureBoxSizeMode.Zoom
        pbKata.TabIndex = 0
        pbKata.TabStop = False
        ' 
        ' pnlKumite
        ' 
        pnlKumite.Controls.Add(lblKumite)
        pnlKumite.Controls.Add(pbKumite)
        pnlKumite.Location = New Point(320, 40)
        pnlKumite.Name = "pnlKumite"
        pnlKumite.Size = New Size(160, 180)
        pnlKumite.TabIndex = 1
        ' 
        ' lblKumite
        ' 
        lblKumite.Dock = DockStyle.Bottom
        lblKumite.Font = New Font("Segoe UI Black", 12.0F, FontStyle.Bold)
        lblKumite.Location = New Point(0, 145)
        lblKumite.Name = "lblKumite"
        lblKumite.Size = New Size(160, 35)
        lblKumite.TabIndex = 1
        lblKumite.Text = "KUMITE"
        lblKumite.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pbKumite
        ' 
        pbKumite.Image = CType(resources.GetObject("pbKumite.Image"), Image)
        pbKumite.Location = New Point(15, 10)
        pbKumite.Name = "pbKumite"
        pbKumite.Size = New Size(130, 130)
        pbKumite.SizeMode = PictureBoxSizeMode.Zoom
        pbKumite.TabIndex = 0
        pbKumite.TabStop = False
        ' 
        ' pnlCompetitors
        ' 
        pnlCompetitors.Controls.Add(lblCompetitors)
        pnlCompetitors.Controls.Add(pbCompetitors)
        pnlCompetitors.Location = New Point(90, 40)
        pnlCompetitors.Name = "pnlCompetitors"
        pnlCompetitors.Size = New Size(160, 180)
        pnlCompetitors.TabIndex = 0
        ' 
        ' lblCompetitors
        ' 
        lblCompetitors.Dock = DockStyle.Bottom
        lblCompetitors.Font = New Font("Segoe UI Black", 12.0F, FontStyle.Bold)
        lblCompetitors.Location = New Point(0, 145)
        lblCompetitors.Name = "lblCompetitors"
        lblCompetitors.Size = New Size(160, 35)
        lblCompetitors.TabIndex = 1
        lblCompetitors.Text = "Competitors"
        lblCompetitors.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pbCompetitors
        ' 
        pbCompetitors.Image = CType(resources.GetObject("pbCompetitors.Image"), Image)
        pbCompetitors.Location = New Point(15, 10)
        pbCompetitors.Name = "pbCompetitors"
        pbCompetitors.Size = New Size(130, 130)
        pbCompetitors.SizeMode = PictureBoxSizeMode.Zoom
        pbCompetitors.TabIndex = 0
        pbCompetitors.TabStop = False
        ' 
        ' pnlResult
        ' 
        pnlResult.Controls.Add(lblResult)
        pnlResult.Controls.Add(pbResult)
        pnlResult.Location = New Point(90, 240)
        pnlResult.Name = "pnlResult"
        pnlResult.Size = New Size(160, 150)
        pnlResult.TabIndex = 3
        ' 
        ' lblResult
        ' 
        lblResult.Dock = DockStyle.Bottom
        lblResult.Font = New Font("Segoe UI Black", 10.0F, FontStyle.Bold)
        lblResult.Location = New Point(0, 120)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(160, 30)
        lblResult.TabIndex = 1
        lblResult.Text = "List of Match Result"
        lblResult.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pbResult
        ' 
        pbResult.Location = New Point(30, 10)
        pbResult.Name = "pbResult"
        pbResult.Size = New Size(100, 100)
        pbResult.SizeMode = PictureBoxSizeMode.Zoom
        pbResult.TabIndex = 0
        pbResult.TabStop = False
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 561)
        Controls.Add(pnlMain)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Yabinya ScoringBoard Karate v3.0 | 2026"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlMain.ResumeLayout(False)
        pnlStatusTable.ResumeLayout(False)
        pnlStatusTable.PerformLayout()
        pnlKata.ResumeLayout(False)
        CType(pbKata, ComponentModel.ISupportInitialize).EndInit()
        pnlKumite.ResumeLayout(False)
        CType(pbKumite, ComponentModel.ISupportInitialize).EndInit()
        pnlCompetitors.ResumeLayout(False)
        CType(pbCompetitors, ComponentModel.ISupportInitialize).EndInit()
        pnlResult.ResumeLayout(False)
        CType(pbResult, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTatamiID As Label
    Friend WithEvents lblTatamiVal As Label
    Friend WithEvents lblActivationReq As Label
    Friend WithEvents btnActivation As Button
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlCompetitors As Panel
    Friend WithEvents pbCompetitors As PictureBox
    Friend WithEvents lblCompetitors As Label
    Friend WithEvents pnlKumite As Panel
    Friend WithEvents lblKumite As Label
    Friend WithEvents pbKumite As PictureBox
    Friend WithEvents pnlKata As Panel
    Friend WithEvents lblKata As Label
    Friend WithEvents pbKata As PictureBox
    Friend WithEvents pnlResult As Panel
    Friend WithEvents lblResult As Label
    Friend WithEvents pbResult As PictureBox
    Friend WithEvents pnlStatusTable As Panel
    Friend WithEvents lblStatusHeader As Label
    Friend WithEvents lblYabinyaStatus As Label
    Friend WithEvents lblLocalStatus As Label
    Friend WithEvents btnKataServer As Button
    Friend WithEvents btnManageJudge As Button
    Friend WithEvents lblWebsite As Label
End Class