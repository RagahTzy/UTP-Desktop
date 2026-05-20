<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QrGenerated
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
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.PanelTatami = New System.Windows.Forms.Panel()
        Me.LabelTatami = New System.Windows.Forms.Label()
        Me.TxtTatamiID = New System.Windows.Forms.TextBox()
        Me.LblDefaultURL = New System.Windows.Forms.Label()
        Me.LblTimestamp = New System.Windows.Forms.Label()

        Me.PanelRight = New System.Windows.Forms.Panel()
        Me.GroupBoxServer = New System.Windows.Forms.GroupBox()
        Me.RbOwnServer = New System.Windows.Forms.RadioButton()
        Me.RbYabinya = New System.Windows.Forms.RadioButton()
        Me.LblBaseUrl = New System.Windows.Forms.Label()
        Me.TxtBaseURL = New System.Windows.Forms.TextBox()
        Me.BtnSavePdf = New System.Windows.Forms.Button()
        Me.PanelValues = New System.Windows.Forms.Panel()
        Me.LblValuesHeader = New System.Windows.Forms.Label()

        ' Individual controls for judges (no loops)
        Me.PicJudge1 = New System.Windows.Forms.PictureBox()
        Me.PicJudge2 = New System.Windows.Forms.PictureBox()
        Me.PicJudge3 = New System.Windows.Forms.PictureBox()
        Me.PicJudge4 = New System.Windows.Forms.PictureBox()
        Me.PicJudge5 = New System.Windows.Forms.PictureBox()
        Me.PicJudge6 = New System.Windows.Forms.PictureBox()
        Me.PicJudge7 = New System.Windows.Forms.PictureBox()

        Me.LblJudge1 = New System.Windows.Forms.Label()
        Me.LblJudge2 = New System.Windows.Forms.Label()
        Me.LblJudge3 = New System.Windows.Forms.Label()
        Me.LblJudge4 = New System.Windows.Forms.Label()
        Me.LblJudge5 = New System.Windows.Forms.Label()
        Me.LblJudge6 = New System.Windows.Forms.Label()
        Me.LblJudge7 = New System.Windows.Forms.Label()

        Me.BtnSaveJudge1 = New System.Windows.Forms.Button()
        Me.BtnSaveJudge2 = New System.Windows.Forms.Button()
        Me.BtnSaveJudge3 = New System.Windows.Forms.Button()
        Me.BtnSaveJudge4 = New System.Windows.Forms.Button()
        Me.BtnSaveJudge5 = New System.Windows.Forms.Button()
        Me.BtnSaveJudge6 = New System.Windows.Forms.Button()
        Me.BtnSaveJudge7 = New System.Windows.Forms.Button()

        ' Right side values controls
        Me.LblJ1 = New System.Windows.Forms.Label()
        Me.LblJ2 = New System.Windows.Forms.Label()
        Me.LblJ3 = New System.Windows.Forms.Label()
        Me.LblJ4 = New System.Windows.Forms.Label()
        Me.LblJ5 = New System.Windows.Forms.Label()
        Me.LblJ6 = New System.Windows.Forms.Label()
        Me.LblJ7 = New System.Windows.Forms.Label()

        Me.TxtJ1 = New System.Windows.Forms.TextBox()
        Me.TxtJ2 = New System.Windows.Forms.TextBox()
        Me.TxtJ3 = New System.Windows.Forms.TextBox()
        Me.TxtJ4 = New System.Windows.Forms.TextBox()
        Me.TxtJ5 = New System.Windows.Forms.TextBox()
        Me.TxtJ6 = New System.Windows.Forms.TextBox()
        Me.TxtJ7 = New System.Windows.Forms.TextBox()

        Me.BtnCopy1 = New System.Windows.Forms.Button()
        Me.BtnCopy2 = New System.Windows.Forms.Button()
        Me.BtnCopy3 = New System.Windows.Forms.Button()
        Me.BtnCopy4 = New System.Windows.Forms.Button()
        Me.BtnCopy5 = New System.Windows.Forms.Button()
        Me.BtnCopy6 = New System.Windows.Forms.Button()
        Me.BtnCopy7 = New System.Windows.Forms.Button()

        Me.PanelLeft.SuspendLayout()
        Me.PanelTatami.SuspendLayout()
        Me.PanelRight.SuspendLayout()
        Me.GroupBoxServer.SuspendLayout()
        Me.PanelValues.SuspendLayout()
        Me.SuspendLayout()

        '
        ' PanelLeft (QR Codes Area)
        '
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeft.Width = 620

        ' Positions for three columns
        ' Row 1
        Me.PicJudge1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicJudge1.Location = New System.Drawing.Point(20, 50)
        Me.PicJudge1.Size = New System.Drawing.Size(150, 150)
        Me.PicJudge1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom

        Me.PicJudge2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicJudge2.Location = New System.Drawing.Point(210, 50)
        Me.PicJudge2.Size = New System.Drawing.Size(150, 150)
        Me.PicJudge2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom

        Me.PicJudge3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicJudge3.Location = New System.Drawing.Point(400, 50)
        Me.PicJudge3.Size = New System.Drawing.Size(150, 150)
        Me.PicJudge3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom

        ' Row 2
        Me.PicJudge4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicJudge4.Location = New System.Drawing.Point(20, 250)
        Me.PicJudge4.Size = New System.Drawing.Size(150, 150)
        Me.PicJudge4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom

        Me.PicJudge5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicJudge5.Location = New System.Drawing.Point(210, 250)
        Me.PicJudge5.Size = New System.Drawing.Size(150, 150)
        Me.PicJudge5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom

        Me.PicJudge6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicJudge6.Location = New System.Drawing.Point(400, 250)
        Me.PicJudge6.Size = New System.Drawing.Size(150, 150)
        Me.PicJudge6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom

        ' Row 3 (only first column)
        Me.PicJudge7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicJudge7.Location = New System.Drawing.Point(20, 450)
        Me.PicJudge7.Size = New System.Drawing.Size(150, 150)
        Me.PicJudge7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom

        ' Labels and Save buttons
        Me.LblJudge1.Text = "JUDGE 1": Me.LblJudge1.Location = New System.Drawing.Point(20, 210): Me.LblJudge1.AutoSize = True
        Me.LblJudge2.Text = "JUDGE 2": Me.LblJudge2.Location = New System.Drawing.Point(210, 210): Me.LblJudge2.AutoSize = True
        Me.LblJudge3.Text = "JUDGE 3": Me.LblJudge3.Location = New System.Drawing.Point(400, 210): Me.LblJudge3.AutoSize = True
        Me.LblJudge4.Text = "JUDGE 4": Me.LblJudge4.Location = New System.Drawing.Point(20, 410): Me.LblJudge4.AutoSize = True
        Me.LblJudge5.Text = "JUDGE 5": Me.LblJudge5.Location = New System.Drawing.Point(210, 410): Me.LblJudge5.AutoSize = True
        Me.LblJudge6.Text = "JUDGE 6": Me.LblJudge6.Location = New System.Drawing.Point(400, 410): Me.LblJudge6.AutoSize = True
        Me.LblJudge7.Text = "JUDGE 7": Me.LblJudge7.Location = New System.Drawing.Point(20, 610): Me.LblJudge7.AutoSize = True

        Me.BtnSaveJudge1.Text = "Save": Me.BtnSaveJudge1.Location = New System.Drawing.Point(100, 205): Me.BtnSaveJudge1.Size = New System.Drawing.Size(70, 25)
        Me.BtnSaveJudge2.Text = "Save": Me.BtnSaveJudge2.Location = New System.Drawing.Point(290, 205): Me.BtnSaveJudge2.Size = New System.Drawing.Size(70, 25)
        Me.BtnSaveJudge3.Text = "Save": Me.BtnSaveJudge3.Location = New System.Drawing.Point(480, 205): Me.BtnSaveJudge3.Size = New System.Drawing.Size(70, 25)
        Me.BtnSaveJudge4.Text = "Save": Me.BtnSaveJudge4.Location = New System.Drawing.Point(100, 405): Me.BtnSaveJudge4.Size = New System.Drawing.Size(70, 25)
        Me.BtnSaveJudge5.Text = "Save": Me.BtnSaveJudge5.Location = New System.Drawing.Point(290, 405): Me.BtnSaveJudge5.Size = New System.Drawing.Size(70, 25)
        Me.BtnSaveJudge6.Text = "Save": Me.BtnSaveJudge6.Location = New System.Drawing.Point(480, 405): Me.BtnSaveJudge6.Size = New System.Drawing.Size(70, 25)
        Me.BtnSaveJudge7.Text = "Save": Me.BtnSaveJudge7.Location = New System.Drawing.Point(100, 605): Me.BtnSaveJudge7.Size = New System.Drawing.Size(70, 25)

        Me.PanelLeft.Controls.Add(Me.PicJudge1)
        Me.PanelLeft.Controls.Add(Me.PicJudge2)
        Me.PanelLeft.Controls.Add(Me.PicJudge3)
        Me.PanelLeft.Controls.Add(Me.PicJudge4)
        Me.PanelLeft.Controls.Add(Me.PicJudge5)
        Me.PanelLeft.Controls.Add(Me.PicJudge6)
        Me.PanelLeft.Controls.Add(Me.PicJudge7)

        Me.PanelLeft.Controls.Add(Me.LblJudge1)
        Me.PanelLeft.Controls.Add(Me.LblJudge2)
        Me.PanelLeft.Controls.Add(Me.LblJudge3)
        Me.PanelLeft.Controls.Add(Me.LblJudge4)
        Me.PanelLeft.Controls.Add(Me.LblJudge5)
        Me.PanelLeft.Controls.Add(Me.LblJudge6)
        Me.PanelLeft.Controls.Add(Me.LblJudge7)

        Me.PanelLeft.Controls.Add(Me.BtnSaveJudge1)
        Me.PanelLeft.Controls.Add(Me.BtnSaveJudge2)
        Me.PanelLeft.Controls.Add(Me.BtnSaveJudge3)
        Me.PanelLeft.Controls.Add(Me.BtnSaveJudge4)
        Me.PanelLeft.Controls.Add(Me.BtnSaveJudge5)
        Me.PanelLeft.Controls.Add(Me.BtnSaveJudge6)
        Me.PanelLeft.Controls.Add(Me.BtnSaveJudge7)

        ' Label Header Kiri
        Dim LblTitle As New System.Windows.Forms.Label()
        LblTitle.Text = "QR Code For Direct Access Judges"
        LblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        LblTitle.Location = New System.Drawing.Point(130, 10)
        LblTitle.AutoSize = True
        Me.PanelLeft.Controls.Add(LblTitle)

        ' Panel Tatami (Dipindah ke Kiri Bawah)
        Me.PanelTatami.Controls.Add(Me.LabelTatami)
        Me.PanelTatami.Controls.Add(Me.TxtTatamiID)
        Me.PanelTatami.Controls.Add(Me.LblDefaultURL)
        Me.PanelTatami.Controls.Add(Me.LblTimestamp)
        Me.PanelTatami.Location = New System.Drawing.Point(210, 450)
        Me.PanelTatami.Size = New System.Drawing.Size(350, 120)

        Me.LabelTatami.Text = "TATAMI ID"
        Me.LabelTatami.BackColor = System.Drawing.Color.DarkGray
        Me.LabelTatami.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTatami.AutoSize = True
        Me.LabelTatami.Location = New System.Drawing.Point(0, 0)

        Me.TxtTatamiID.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.TxtTatamiID.Location = New System.Drawing.Point(0, 25)
        Me.TxtTatamiID.Size = New System.Drawing.Size(300, 36)
        Me.TxtTatamiID.ReadOnly = True
        Me.TxtTatamiID.Text = "TM-0E02ABD84C23"

        Me.LblDefaultURL.Text = "Default URL Access :" & vbCrLf & "https://kata.yabinya.com/scbscoring"
        Me.LblDefaultURL.Location = New System.Drawing.Point(0, 70)
        Me.LblDefaultURL.AutoSize = True

        Me.LblTimestamp.Text = "5/20/2026 9:08 PM"
        Me.LblTimestamp.Location = New System.Drawing.Point(200, 95)
        Me.LblTimestamp.AutoSize = True

        Me.PanelLeft.Controls.Add(Me.PanelTatami)

        '
        ' PanelRight
        '
        Me.PanelRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRight.Controls.Add(Me.GroupBoxServer)
        Me.PanelRight.Controls.Add(Me.LblBaseUrl)
        Me.PanelRight.Controls.Add(Me.TxtBaseURL)
        Me.PanelRight.Controls.Add(Me.BtnSavePdf)
        Me.PanelRight.Controls.Add(Me.PanelValues)

        ' Server Selection
        Me.GroupBoxServer.Controls.Add(Me.RbOwnServer)
        Me.GroupBoxServer.Controls.Add(Me.RbYabinya)
        Me.GroupBoxServer.Location = New System.Drawing.Point(20, 10)
        Me.GroupBoxServer.Size = New System.Drawing.Size(300, 50)

        Me.RbYabinya.Text = "Yabinya Server"
        Me.RbYabinya.Checked = True
        Me.RbYabinya.Location = New System.Drawing.Point(20, 20)
        Me.RbYabinya.AutoSize = True

        Me.RbOwnServer.Text = "Own Server"
        Me.RbOwnServer.Location = New System.Drawing.Point(150, 20)
        Me.RbOwnServer.AutoSize = True

        ' Base URL
        Me.LblBaseUrl.Text = "Base URL"
        Me.LblBaseUrl.Location = New System.Drawing.Point(20, 75)
        Me.LblBaseUrl.AutoSize = True

        Me.TxtBaseURL.Location = New System.Drawing.Point(80, 72)
        Me.TxtBaseURL.Size = New System.Drawing.Size(240, 23)
        Me.TxtBaseURL.Text = "https://kata.yabinya.com/scbscoring"

        ' PDF Button
        Me.BtnSavePdf.Text = "Save QR Code to PDF"
        Me.BtnSavePdf.Location = New System.Drawing.Point(120, 110)
        Me.BtnSavePdf.Size = New System.Drawing.Size(200, 35)

        ' Panel Values (Kuning)
        Me.PanelValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelValues.Location = New System.Drawing.Point(20, 180)
        Me.PanelValues.Size = New System.Drawing.Size(350, 300)

        Me.LblValuesHeader.Text = "QR Code value set"
        Me.LblValuesHeader.BackColor = System.Drawing.Color.Yellow
        Me.LblValuesHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LblValuesHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblValuesHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblValuesHeader.Height = 25
        Me.PanelValues.Controls.Add(Me.LblValuesHeader)

        ' Add right-side value rows (explicit positions)
        Me.LblJ1.Text = "J1"
        Me.LblJ1.Location = New System.Drawing.Point(10, 43)
        Me.LblJ1.AutoSize = True
        Me.TxtJ1.Location = New System.Drawing.Point(40, 40)
        Me.TxtJ1.Size = New System.Drawing.Size(250, 23)
        Me.BtnCopy1.Text = "📋"
        Me.BtnCopy1.Location = New System.Drawing.Point(300, 38)
        Me.BtnCopy1.Size = New System.Drawing.Size(30, 27)

        Me.LblJ2.Text = "J2"
        Me.LblJ2.Location = New System.Drawing.Point(10, 78)
        Me.LblJ2.AutoSize = True
        Me.TxtJ2.Location = New System.Drawing.Point(40, 75)
        Me.TxtJ2.Size = New System.Drawing.Size(250, 23)
        Me.BtnCopy2.Text = "📋"
        Me.BtnCopy2.Location = New System.Drawing.Point(300, 73)
        Me.BtnCopy2.Size = New System.Drawing.Size(30, 27)

        Me.LblJ3.Text = "J3"
        Me.LblJ3.Location = New System.Drawing.Point(10, 113)
        Me.LblJ3.AutoSize = True
        Me.TxtJ3.Location = New System.Drawing.Point(40, 110)
        Me.TxtJ3.Size = New System.Drawing.Size(250, 23)
        Me.BtnCopy3.Text = "📋"
        Me.BtnCopy3.Location = New System.Drawing.Point(300, 108)
        Me.BtnCopy3.Size = New System.Drawing.Size(30, 27)

        Me.LblJ4.Text = "J4"
        Me.LblJ4.Location = New System.Drawing.Point(10, 148)
        Me.LblJ4.AutoSize = True
        Me.TxtJ4.Location = New System.Drawing.Point(40, 145)
        Me.TxtJ4.Size = New System.Drawing.Size(250, 23)
        Me.BtnCopy4.Text = "📋"
        Me.BtnCopy4.Location = New System.Drawing.Point(300, 143)
        Me.BtnCopy4.Size = New System.Drawing.Size(30, 27)

        Me.LblJ5.Text = "J5"
        Me.LblJ5.Location = New System.Drawing.Point(10, 183)
        Me.LblJ5.AutoSize = True
        Me.TxtJ5.Location = New System.Drawing.Point(40, 180)
        Me.TxtJ5.Size = New System.Drawing.Size(250, 23)
        Me.BtnCopy5.Text = "📋"
        Me.BtnCopy5.Location = New System.Drawing.Point(300, 178)
        Me.BtnCopy5.Size = New System.Drawing.Size(30, 27)

        Me.LblJ6.Text = "J6"
        Me.LblJ6.Location = New System.Drawing.Point(10, 218)
        Me.LblJ6.AutoSize = True
        Me.TxtJ6.Location = New System.Drawing.Point(40, 215)
        Me.TxtJ6.Size = New System.Drawing.Size(250, 23)
        Me.BtnCopy6.Text = "📋"
        Me.BtnCopy6.Location = New System.Drawing.Point(300, 213)
        Me.BtnCopy6.Size = New System.Drawing.Size(30, 27)

        Me.LblJ7.Text = "J7"
        Me.LblJ7.Location = New System.Drawing.Point(10, 253)
        Me.LblJ7.AutoSize = True
        Me.TxtJ7.Location = New System.Drawing.Point(40, 250)
        Me.TxtJ7.Size = New System.Drawing.Size(250, 23)
        Me.BtnCopy7.Text = "📋"
        Me.BtnCopy7.Location = New System.Drawing.Point(300, 248)
        Me.BtnCopy7.Size = New System.Drawing.Size(30, 27)

        Me.PanelValues.Controls.Add(Me.LblJ1)
        Me.PanelValues.Controls.Add(Me.TxtJ1)
        Me.PanelValues.Controls.Add(Me.BtnCopy1)
        Me.PanelValues.Controls.Add(Me.LblJ2)
        Me.PanelValues.Controls.Add(Me.TxtJ2)
        Me.PanelValues.Controls.Add(Me.BtnCopy2)
        Me.PanelValues.Controls.Add(Me.LblJ3)
        Me.PanelValues.Controls.Add(Me.TxtJ3)
        Me.PanelValues.Controls.Add(Me.BtnCopy3)
        Me.PanelValues.Controls.Add(Me.LblJ4)
        Me.PanelValues.Controls.Add(Me.TxtJ4)
        Me.PanelValues.Controls.Add(Me.BtnCopy4)
        Me.PanelValues.Controls.Add(Me.LblJ5)
        Me.PanelValues.Controls.Add(Me.TxtJ5)
        Me.PanelValues.Controls.Add(Me.BtnCopy5)
        Me.PanelValues.Controls.Add(Me.LblJ6)
        Me.PanelValues.Controls.Add(Me.TxtJ6)
        Me.PanelValues.Controls.Add(Me.BtnCopy6)
        Me.PanelValues.Controls.Add(Me.LblJ7)
        Me.PanelValues.Controls.Add(Me.TxtJ7)
        Me.PanelValues.Controls.Add(Me.BtnCopy7)

        ' Form Settings
        Me.ClientSize = New System.Drawing.Size(1020, 600)
        Me.Controls.Add(Me.PanelRight)
        Me.Controls.Add(Me.PanelLeft)
        Me.Name = "QrGenerated"
        Me.Text = "QR Generated"
        Me.BackColor = System.Drawing.Color.White

        Me.PanelLeft.ResumeLayout(False)
        Me.PanelLeft.PerformLayout()
        Me.PanelTatami.ResumeLayout(False)
        Me.PanelTatami.PerformLayout()
        Me.PanelRight.ResumeLayout(False)
        Me.PanelRight.PerformLayout()
        Me.GroupBoxServer.ResumeLayout(False)
        Me.GroupBoxServer.PerformLayout()
        Me.PanelValues.ResumeLayout(False)
        Me.PanelValues.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents PanelLeft As Panel
    Friend WithEvents PanelRight As Panel
    Friend WithEvents PanelTatami As Panel
    Friend WithEvents LabelTatami As Label
    Friend WithEvents TxtTatamiID As TextBox
    Friend WithEvents LblTimestamp As Label
    Friend WithEvents LblDefaultURL As Label

    ' Array variables WITHOUT WithEvents
    Friend WithEvents PicJudge1 As PictureBox
    Friend WithEvents PicJudge2 As PictureBox
    Friend WithEvents PicJudge3 As PictureBox
    Friend WithEvents PicJudge4 As PictureBox
    Friend WithEvents PicJudge5 As PictureBox
    Friend WithEvents PicJudge6 As PictureBox
    Friend WithEvents PicJudge7 As PictureBox

    Friend WithEvents LblJudge1 As Label
    Friend WithEvents LblJudge2 As Label
    Friend WithEvents LblJudge3 As Label
    Friend WithEvents LblJudge4 As Label
    Friend WithEvents LblJudge5 As Label
    Friend WithEvents LblJudge6 As Label
    Friend WithEvents LblJudge7 As Label

    Friend WithEvents BtnSaveJudge1 As Button
    Friend WithEvents BtnSaveJudge2 As Button
    Friend WithEvents BtnSaveJudge3 As Button
    Friend WithEvents BtnSaveJudge4 As Button
    Friend WithEvents BtnSaveJudge5 As Button
    Friend WithEvents BtnSaveJudge6 As Button
    Friend WithEvents BtnSaveJudge7 As Button

    Friend WithEvents GroupBoxServer As GroupBox
    Friend WithEvents RbOwnServer As RadioButton
    Friend WithEvents RbYabinya As RadioButton
    Friend WithEvents LblBaseUrl As Label
    Friend WithEvents TxtBaseURL As TextBox
    Friend WithEvents BtnSavePdf As Button

    Friend WithEvents PanelValues As Panel
    Friend WithEvents LblValuesHeader As Label

    ' Array variables WITHOUT WithEvents
    Friend WithEvents LblJ1 As Label
    Friend WithEvents LblJ2 As Label
    Friend WithEvents LblJ3 As Label
    Friend WithEvents LblJ4 As Label
    Friend WithEvents LblJ5 As Label
    Friend WithEvents LblJ6 As Label
    Friend WithEvents LblJ7 As Label

    Friend WithEvents TxtJ1 As TextBox
    Friend WithEvents TxtJ2 As TextBox
    Friend WithEvents TxtJ3 As TextBox
    Friend WithEvents TxtJ4 As TextBox
    Friend WithEvents TxtJ5 As TextBox
    Friend WithEvents TxtJ6 As TextBox
    Friend WithEvents TxtJ7 As TextBox

    Friend WithEvents BtnCopy1 As Button
    Friend WithEvents BtnCopy2 As Button
    Friend WithEvents BtnCopy3 As Button
    Friend WithEvents BtnCopy4 As Button
    Friend WithEvents BtnCopy5 As Button
    Friend WithEvents BtnCopy6 As Button
    Friend WithEvents BtnCopy7 As Button

End Class