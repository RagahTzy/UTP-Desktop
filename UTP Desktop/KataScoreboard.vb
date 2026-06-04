Imports System.ComponentModel
Imports System.ComponentModel.Design.Serialization

Public Class KataScoreboard
    Inherits System.Windows.Forms.Form

    Private animTimer As New Timer()
    Private updateTimer As New Timer()
    Private dotCount As Integer = 0

    ' === REFERENCE KE KATA FORM ===
    Private kataForm As Kata = Nothing

    ' === DATA COMPETITOR DAN SCORING ===
    Private _akaCompetitorName As String = ""
    Private _akaTeamName As String = ""
    Private _aoCompetitorName As String = ""
    Private _aoTeamName As String = ""
    Private _usesFlagSystem As Boolean = False
    Private _akaScore As Integer = 0
    Private _aoScore As Integer = 0

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property AkaCompetitorName As String
        Get
            Return _akaCompetitorName
        End Get
        Set(value As String)
            _akaCompetitorName = value
        End Set
    End Property

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property AkaTeamName As String
        Get
            Return _akaTeamName
        End Get
        Set(value As String)
            _akaTeamName = value
        End Set
    End Property

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property AoCompetitorName As String
        Get
            Return _aoCompetitorName
        End Get
        Set(value As String)
            _aoCompetitorName = value
        End Set
    End Property

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property AoTeamName As String
        Get
            Return _aoTeamName
        End Get
        Set(value As String)
            _aoTeamName = value
        End Set
    End Property

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property UsesFlagSystem As Boolean
        Get
            Return _usesFlagSystem
        End Get
        Set(value As Boolean)
            _usesFlagSystem = value
        End Set
    End Property

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property AkaScore As Integer
        Get
            Return _akaScore
        End Get
        Set(value As Integer)
            _akaScore = value
        End Set
    End Property

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property AoScore As Integer
        Get
            Return _aoScore
        End Get
        Set(value As Integer)
            _aoScore = value
        End Set
    End Property

    Private Sub KataScoreboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.None
        Me.BackColor = Color.Black
        Me.DoubleBuffered = True
        Me.KeyPreview = True

        animTimer.Interval = 500
        AddHandler animTimer.Tick, AddressOf AnimDots
        animTimer.Start()

        ' === START UPDATE TIMER UNTUK REAL-TIME UPDATE ===
        updateTimer.Interval = 500 ' Update setiap 500ms
        AddHandler updateTimer.Tick, AddressOf UpdateDataFromKata
        updateTimer.Start()

        ' === HANDLE FORM CLOSING ===
        AddHandler Me.FormClosing, AddressOf KataScoreboard_FormClosing
    End Sub

    Private Sub KataScoreboard_FormClosing(sender As Object, e As FormClosingEventArgs)
        If animTimer IsNot Nothing Then animTimer.Stop()
        If updateTimer IsNot Nothing Then updateTimer.Stop()
    End Sub

    ' === METHOD UNTUK SET REFERENCE KATA ===
    Public Sub SetKataReference(kata As Kata)
        kataForm = kata
    End Sub

    ' === METHOD UNTUK UPDATE DATA DARI KATA SECARA REAL-TIME ===
    Private Sub UpdateDataFromKata(sender As Object, e As EventArgs)
        If kataForm IsNot Nothing Then
            Try
                ' Prefer detail panel name if set (TxtAkaName/TxtAoName), otherwise use header name
                Dim akaNameVal As String = ""
                Try
                    If kataForm.TxtAkaName IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(kataForm.TxtAkaName.Text) Then
                        akaNameVal = kataForm.TxtAkaName.Text
                    Else
                        akaNameVal = kataForm.TxtAkaNameHeader.Text
                    End If
                Catch exNameA As Exception
                    akaNameVal = kataForm.TxtAkaNameHeader.Text
                End Try

                Dim akaTeamVal As String = ""
                Try
                    akaTeamVal = kataForm.GetAkaTeamName()
                Catch exTeamA As Exception
                    akaTeamVal = ""
                End Try

                Dim aoNameVal As String = ""
                Try
                    If kataForm.TxtAoName IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(kataForm.TxtAoName.Text) Then
                        aoNameVal = kataForm.TxtAoName.Text
                    Else
                        aoNameVal = kataForm.TxtAoNameHeader.Text
                    End If
                Catch exNameO As Exception
                    aoNameVal = kataForm.TxtAoNameHeader.Text
                End Try

                Dim aoTeamVal As String = ""
                Try
                    aoTeamVal = kataForm.GetAoTeamName()
                Catch exTeamO As Exception
                    aoTeamVal = ""
                End Try

                ' Debug - log setiap kali update
                Debug.WriteLine($"[UpdateDataFromKata] AKA: '{akaNameVal}' | Team: '{akaTeamVal}' | AO: '{aoNameVal}' | Team: '{aoTeamVal}'")

                _akaCompetitorName = akaNameVal
                _akaTeamName = akaTeamVal
                _aoCompetitorName = aoNameVal
                _aoTeamName = aoTeamVal
                _usesFlagSystem = kataForm.RadFlagSystem.Checked
                _akaScore = kataForm.GetAkaScore()
                _aoScore = kataForm.GetAoScore()

                ' Refresh UI
                Me.Invalidate()
            Catch ex As Exception
                Debug.WriteLine($"Error updating data: {ex.Message}")
            End Try
        Else
            Debug.WriteLine("kataForm is Nothing in UpdateDataFromKata!")
        End If
    End Sub

    ' === METHOD UNTUK UPDATE DATA DAN REFRESH UI (LEGACY) ===
    Public Sub UpdateData(akaName As String, akaTeam As String, aoName As String, aoTeam As String, flagSystem As Boolean, akaScoreVal As Integer, aoScoreVal As Integer)
        _akaCompetitorName = akaName
        _akaTeamName = akaTeam
        _aoCompetitorName = aoName
        _aoTeamName = aoTeam
        _usesFlagSystem = flagSystem
        _akaScore = akaScoreVal
        _aoScore = aoScoreVal
        Me.Invalidate()
    End Sub

    Private Sub AnimDots(sender As Object, e As EventArgs)
        dotCount = (dotCount + 1) Mod 4
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim W As Integer = Me.ClientSize.Width
        Dim H As Integer = Me.ClientSize.Height

        ' === BACKGROUND HITAM ===
        g.FillRectangle(Brushes.Black, 0, 0, W, H)

        ' === MAIN CONTENT AREA ===
        Dim marginX As Integer = CInt(W * 0.05)
        Dim marginY As Integer = CInt(H * 0.08)
        Dim contentWidth As Integer = W - (marginX * 2)
        Dim contentHeight As Integer = H - (marginY * 2)

        ' === TITLE ===
        Dim titleFont As New Font("Arial", CInt(H * 0.05), FontStyle.Bold)
        Dim titleText As String = "KATA Category Detail"
        Dim titleSize As SizeF = g.MeasureString(titleText, titleFont)
        Dim titleX As Single = (W - titleSize.Width) / 2
        g.DrawString(titleText, titleFont, Brushes.Yellow, titleX, marginY)

        ' === SEPARATOR ===
        Dim separatorY As Integer = marginY + CInt(H * 0.08)
        g.DrawLine(New Pen(Color.FromArgb(80, 80, 80), 2), marginX, separatorY, W - marginX, separatorY)

        ' === LEFT PANEL (AKA - RED) ===
        Dim leftPanelX As Integer = marginX
        Dim leftPanelY As Integer = separatorY + CInt(H * 0.05)
        Dim panelWidth As Integer = CInt(contentWidth / 2 - CInt(H * 0.02))
        Dim panelHeight As Integer = CInt(contentHeight / 2)

        ' AKA Background (dark red)
        g.FillRectangle(New SolidBrush(Color.FromArgb(40, 0, 0)), leftPanelX, leftPanelY, panelWidth, panelHeight)
        g.DrawRectangle(New Pen(Color.FromArgb(200, 0, 0), 3), leftPanelX, leftPanelY, panelWidth, panelHeight)

        ' AKA Text
        Dim akaFont As New Font("Arial", CInt(H * 0.04), FontStyle.Bold)
        Dim akaLabelFont As New Font("Arial", CInt(H * 0.025), FontStyle.Regular)
        Dim akaSmallFont As New Font("Arial", CInt(H * 0.018), FontStyle.Regular)

        Dim akaTextX As Integer = leftPanelX + CInt(H * 0.02)
        Dim akaTextY As Integer = leftPanelY + CInt(H * 0.02)

        ' AKA Label
        g.DrawString("AKA", akaFont, Brushes.Red, akaTextX, akaTextY)

        ' AKA Competitor Name
        akaTextY += CInt(H * 0.06)
        g.DrawString("Competitor:", akaLabelFont, Brushes.White, akaTextX, akaTextY)
        akaTextY += CInt(H * 0.035)
        g.DrawString(If(String.IsNullOrEmpty(AkaCompetitorName), "-", AkaCompetitorName), akaSmallFont, Brushes.Yellow, akaTextX + CInt(H * 0.01), akaTextY)

        ' AKA Team
        akaTextY += CInt(H * 0.04)
        g.DrawString("Team:", akaLabelFont, Brushes.White, akaTextX, akaTextY)
        akaTextY += CInt(H * 0.035)
        g.DrawString(If(String.IsNullOrEmpty(AkaTeamName), "-", AkaTeamName), akaSmallFont, Brushes.Yellow, akaTextX + CInt(H * 0.01), akaTextY)

        ' AKA Score/Flag
        akaTextY += CInt(H * 0.04)
        Dim scoreLabel As String = If(UsesFlagSystem, "Flags:", "Score:")
        g.DrawString(scoreLabel, akaLabelFont, Brushes.White, akaTextX, akaTextY)
        akaTextY += CInt(H * 0.035)
        Dim akaScoreText As String = AkaScore.ToString()
        g.DrawString(akaScoreText, New Font("Arial", CInt(H * 0.06), FontStyle.Bold), Brushes.Yellow, akaTextX + CInt(H * 0.01), akaTextY)

        ' === RIGHT PANEL (AO - BLUE) ===
        Dim rightPanelX As Integer = leftPanelX + panelWidth + CInt(H * 0.04)
        Dim rightPanelY As Integer = leftPanelY

        ' AO Background (dark blue)
        g.FillRectangle(New SolidBrush(Color.FromArgb(0, 0, 40)), rightPanelX, rightPanelY, panelWidth, panelHeight)
        g.DrawRectangle(New Pen(Color.FromArgb(0, 0, 200), 3), rightPanelX, rightPanelY, panelWidth, panelHeight)

        ' AO Text
        Dim aoFont As New Font("Arial", CInt(H * 0.04), FontStyle.Bold)
        Dim aoLabelFont As New Font("Arial", CInt(H * 0.025), FontStyle.Regular)
        Dim aoSmallFont As New Font("Arial", CInt(H * 0.018), FontStyle.Regular)

        Dim aoTextX As Integer = rightPanelX + CInt(H * 0.02)
        Dim aoTextY As Integer = rightPanelY + CInt(H * 0.02)

        ' AO Label
        g.DrawString("AO", aoFont, Brushes.Blue, aoTextX, aoTextY)

        ' AO Competitor Name
        aoTextY += CInt(H * 0.06)
        g.DrawString("Competitor:", aoLabelFont, Brushes.White, aoTextX, aoTextY)
        aoTextY += CInt(H * 0.035)
        g.DrawString(If(String.IsNullOrEmpty(AoCompetitorName), "-", AoCompetitorName), aoSmallFont, Brushes.Yellow, aoTextX + CInt(H * 0.01), aoTextY)

        ' AO Team
        aoTextY += CInt(H * 0.04)
        g.DrawString("Team:", aoLabelFont, Brushes.White, aoTextX, aoTextY)
        aoTextY += CInt(H * 0.035)
        g.DrawString(If(String.IsNullOrEmpty(AoTeamName), "-", AoTeamName), aoSmallFont, Brushes.Yellow, aoTextX + CInt(H * 0.01), aoTextY)

        ' AO Score/Flag
        aoTextY += CInt(H * 0.04)
        g.DrawString(scoreLabel, aoLabelFont, Brushes.White, aoTextX, aoTextY)
        aoTextY += CInt(H * 0.035)
        Dim aoScoreText As String = AoScore.ToString()
        g.DrawString(aoScoreText, New Font("Arial", CInt(H * 0.06), FontStyle.Bold), Brushes.Yellow, aoTextX + CInt(H * 0.01), aoTextY)

        ' === FOOTER ===
        Dim footerH As Integer = CInt(H * 0.08)
        Dim footerY As Integer = H - footerH
        g.FillRectangle(New SolidBrush(Color.FromArgb(18, 18, 18)), 0, footerY, W, footerH)
        g.DrawLine(New Pen(Color.FromArgb(50, 50, 50), 1), 0, footerY, W, footerY)

        Dim footFont As New Font("Arial", CInt(H * 0.028), FontStyle.Bold)
        Dim studioY As Single = footerY + (footerH - footFont.GetHeight(g)) / 2
        g.DrawString("Yabinya Studio", footFont, Brushes.White, CInt(W * 0.018), studioY)

        Dim tatamiText As String = "TATAMI  1"
        Dim tatamiSize As SizeF = g.MeasureString(tatamiText, footFont)
        g.DrawString(tatamiText, footFont, Brushes.White, W - tatamiSize.Width - CInt(W * 0.018), studioY)

        ' Cleanup
        titleFont.Dispose()
        akaFont.Dispose()
        akaLabelFont.Dispose()
        akaSmallFont.Dispose()
        aoFont.Dispose()
        aoLabelFont.Dispose()
        aoSmallFont.Dispose()
        footFont.Dispose()
    End Sub

    Private Sub KataScoreboard_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            animTimer.Stop()
            updateTimer.Stop()
            Me.Close()
        End If
    End Sub

End Class
