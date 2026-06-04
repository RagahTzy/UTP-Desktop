Imports System.Data.SQLite

Public Class Kata
    Public Sub New()
        InitializeComponent()
    End Sub

    Private lastWinnerSide As String = ""
    Private scoreboardActive As Boolean = False
    Private splashForm As FrmSplashKata = Nothing

    Private Sub Kata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetJudgeCount(GetCurrentJudgeCount())
        ResetFlagPanelColors()
        UpdateFlagCountLabels()
        RecalculateTotalScores()
        PanelJudgeScore.Visible = RadScore.Checked
        PanelFlagSystem.Visible = RadFlagSystem.Checked
        BtnAkaShowWinner.Enabled = False
        BtnAoShowWinner.Enabled = False
        UpdateShowWinnerButtonAppearance()
    End Sub

    ''' <summary>
    ''' Variable untuk menyimpan data kompetitor yang dipilih dari header
    ''' </summary>
    Private akaSelectedName As String = ""
    Private akaSelectedTeam As String = ""
    Private akaSelectedTeamInfo As String = ""
    Private aoSelectedName As String = ""
    Private aoSelectedTeam As String = ""
    Private aoSelectedTeamInfo As String = ""

    ''' <summary>
    ''' Public properties untuk akses dari KataScoreboard
    ''' </summary>
    Public ReadOnly Property AkaCompetitorNameValue As String
        Get
            Return TxtAkaNameHeader.Text
        End Get
    End Property

    Public ReadOnly Property AoCompetitorNameValue As String
        Get
            Return TxtAoNameHeader.Text
        End Get
    End Property

    Public ReadOnly Property AkaTeamNameValue As String
        Get
            Return akaSelectedTeam
        End Get
    End Property

    Public ReadOnly Property AoTeamNameValue As String
        Get
            Return aoSelectedTeam
        End Get
    End Property

    ''' <summary>
    ''' Helper function untuk logging activity ke database
    ''' </summary>
    Private Sub LogActivityToDb(category As String, activity As String, activityType As String, Optional matchTime As String = "")
        Try
            ModGlobalConfig.LogActivity(category, activity, activityType, matchTime, Environment.UserName)
        Catch ex As Exception
            ' Silent fail - jangan interrupt UI
            Debug.WriteLine("Log Activity Error: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Mengatur perubahan tampilan utama berdasarkan tipe scoring yang dipilih juri
    ''' </summary>
    Private Sub RadScore_CheckedChanged(sender As Object, e As EventArgs) Handles RadScore.CheckedChanged
        If RadScore.Checked Then
            PanelJudgeScore.Visible = True
            PanelFlagSystem.Visible = False
            EvaluateWinner()
        End If
    End Sub

    Private Sub RadFlagSystem_CheckedChanged(sender As Object, e As EventArgs) Handles RadFlagSystem.CheckedChanged
        If RadFlagSystem.Checked Then
            PanelJudgeScore.Visible = False
            PanelFlagSystem.Visible = True
            EvaluateWinner()
        End If
    End Sub

    ''' <summary>
    ''' BtnAkaIconHeader - Buka List of Competitor untuk header AKA
    ''' </summary>
    Private Sub BtnAkaIconHeader_Click(sender As Object, e As EventArgs) Handles BtnAkaIconHeader.Click
        Try
            Dim formList As New ListOfCompetitor()
            formList.ShowDialog()
            If formList.DialogResult = DialogResult.OK AndAlso Not String.IsNullOrEmpty(formList.SelectedCompetitorName) Then
                TxtAkaNameHeader.Text = formList.SelectedCompetitorName
                ' Simpan data kompetitor ke variable
                akaSelectedName = formList.SelectedCompetitorName
                akaSelectedTeam = formList.SelectedTeamName
                akaSelectedTeamInfo = formList.SelectedTeamInfo
                LogActivityToDb("Header", $"Select Competitor for AKA Header: {formList.SelectedCompetitorName}", "Selection")
            End If
            formList.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LogActivityToDb("Header", $"Error selecting AKA competitor: {ex.Message}", "Error")
        End Try
    End Sub

    ''' <summary>
    ''' BtnAoIconHeader - Buka List of Competitor untuk header AO
    ''' </summary>
    Private Sub BtnAoIconHeader_Click(sender As Object, e As EventArgs) Handles BtnAoIconHeader.Click
        Try
            Dim formList As New ListOfCompetitor()
            formList.ShowDialog()
            If formList.DialogResult = DialogResult.OK AndAlso Not String.IsNullOrEmpty(formList.SelectedCompetitorName) Then
                TxtAoNameHeader.Text = formList.SelectedCompetitorName
                ' Simpan data kompetitor ke variable
                aoSelectedName = formList.SelectedCompetitorName
                aoSelectedTeam = formList.SelectedTeamName
                aoSelectedTeamInfo = formList.SelectedTeamInfo
                LogActivityToDb("Header", $"Select Competitor for AO Header: {formList.SelectedCompetitorName}", "Selection")
            End If
            formList.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LogActivityToDb("Header", $"Error selecting AO competitor: {ex.Message}", "Error")
        End Try
    End Sub

    ''' <summary>
    ''' BtnAkaUserIcon - Buka List of Competitor untuk detail AKA
    ''' </summary>
    Private Sub BtnAkaUserIcon_Click(sender As Object, e As EventArgs) Handles BtnAkaUserIcon.Click
        Try
            Dim formList As New ListOfCompetitor()
            formList.ShowDialog()
            If formList.DialogResult = DialogResult.OK AndAlso Not String.IsNullOrEmpty(formList.SelectedCompetitorName) Then
                TxtAkaName.Text = formList.SelectedCompetitorName
                TxtAkaTeam.Text = formList.SelectedTeamName
                TxtAkaTeamInfo.Text = formList.SelectedTeamInfo
                LogActivityToDb("AKA Detail", $"Select Competitor: {formList.SelectedCompetitorName} | Team: {formList.SelectedTeamName}", "Selection")
            End If
            formList.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LogActivityToDb("AKA Detail", $"Error selecting competitor: {ex.Message}", "Error")
        End Try
    End Sub

    ''' <summary>
    ''' BtnAoUserIcon - Buka List of Competitor untuk detail AO
    ''' </summary>
    Private Sub BtnAoUserIcon_Click(sender As Object, e As EventArgs) Handles BtnAoUserIcon.Click
        Try
            Dim formList As New ListOfCompetitor()
            formList.ShowDialog()
            If formList.DialogResult = DialogResult.OK AndAlso Not String.IsNullOrEmpty(formList.SelectedCompetitorName) Then
                TxtAoName.Text = formList.SelectedCompetitorName
                TxtAoTeam.Text = formList.SelectedTeamName
                TxtAoTeamInfo.Text = formList.SelectedTeamInfo
                LogActivityToDb("AO Detail", $"Select Competitor: {formList.SelectedCompetitorName} | Team: {formList.SelectedTeamName}", "Selection")
            End If
            formList.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LogActivityToDb("AO Detail", $"Error selecting competitor: {ex.Message}", "Error")
        End Try
    End Sub

    ''' <summary>
    ''' BtnLoadNextMatch - Copy data dari header ke detail panel
    ''' </summary>
    Private Sub BtnLoadNextMatch_Click(sender As Object, e As EventArgs) Handles BtnLoadNextMatch.Click
        Try
            ' Copy AKA data from header (variables) to detail panel
            TxtAkaName.Text = akaSelectedName
            TxtAkaTeam.Text = akaSelectedTeam
            TxtAkaTeamInfo.Text = akaSelectedTeamInfo

            ' Copy AO data from header (variables) to detail panel
            TxtAoName.Text = aoSelectedName
            TxtAoTeam.Text = aoSelectedTeam
            TxtAoTeamInfo.Text = aoSelectedTeamInfo

            LogActivityToDb("Match Load", $"Load Next Match: {akaSelectedName} vs {aoSelectedName}", "Action")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LogActivityToDb("Match Load", $"Error loading match: {ex.Message}", "Error")
        End Try
    End Sub

    ''' <summary>
    ''' BtnLogActivity - Buka Form Log Activity
    ''' </summary>
    Private Sub BtnLogActivity_Click(sender As Object, e As EventArgs) Handles BtnLogActivity.Click
        Try
            Dim formLog As New Log_Activity()
            formLog.ShowDialog()
            LogActivityToDb("UI", "Open Log Activity Form", "Action")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' BtnShortcut - Buka Form Shortcut
    ''' </summary>
    Private Sub BtnShortcut_Click(sender As Object, e As EventArgs) Handles BtnShortcut.Click
        Try
            Dim formShortcut As New Shortcut()
            formShortcut.ShowDialog()
            LogActivityToDb("UI", "Open Shortcut Form", "Action")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click
        Try
            Dim formSettings As New FrmScoreboardSetting()
            formSettings.ShowDialog()
            LogActivityToDb("UI", "Open Scoreboard Setting Form", "Action")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LogActivityToDb("UI", $"Error opening Scoreboard Setting Form: {ex.Message}", "Error")
        End Try
    End Sub

    Private Sub ScoreValueChanged(sender As Object, e As EventArgs) Handles NumAkaJ1.ValueChanged, NumAkaJ2.ValueChanged, NumAkaJ3.ValueChanged, NumAkaJ4.ValueChanged, NumAkaJ5.ValueChanged, NumAkaJ6.ValueChanged, NumAkaJ7.ValueChanged, NumAoJ1.ValueChanged, NumAoJ2.ValueChanged, NumAoJ3.ValueChanged, NumAoJ4.ValueChanged, NumAoJ5.ValueChanged, NumAoJ6.ValueChanged, NumAoJ7.ValueChanged
        RecalculateTotalScores()
        EvaluateWinner()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles APIInfo.Click
        Try
            Dim formQr As New QrGenerated()
            formQr.ShowDialog()
            LogActivityToDb("UI", "Open QR Generated Form", "Action")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LogActivityToDb("UI", $"Error opening QR Generated Form: {ex.Message}", "Error")
        End Try
    End Sub

    ''' <summary>
    ''' Event handler untuk RadJudge5 CheckedChanged
    ''' Mengatur visibilitas judge panels dan flag panels untuk 5 judge
    ''' </summary>
    Private Sub RadJudge5_CheckedChanged(sender As Object, e As EventArgs) Handles RadJudge5.CheckedChanged
        If RadJudge5.Checked Then
            SetJudgeCount(5)
            LogActivityToDb("Judge Selection", "Selected 5 Judges", "Selection")
        End If
    End Sub

    ''' <summary>
    ''' Event handler untuk RadJudge7 CheckedChanged
    ''' Mengatur visibilitas judge panels dan flag panels untuk 7 judge
    ''' </summary>
    Private Sub RadJudge7_CheckedChanged(sender As Object, e As EventArgs) Handles RadJudge7.CheckedChanged
        If RadJudge7.Checked Then
            SetJudgeCount(7)
            LogActivityToDb("Judge Selection", "Selected 7 Judges", "Selection")
        End If
    End Sub

    ''' <summary>
    ''' Event handler untuk RadJudge3 CheckedChanged
    ''' Mengatur visibilitas judge panels dan flag panels untuk 3 judge
    ''' </summary>
    Private Sub RadJudge3_CheckedChanged(sender As Object, e As EventArgs) Handles RadJudge3.CheckedChanged
        If RadJudge3.Checked Then
            SetJudgeCount(3)
            LogActivityToDb("Judge Selection", "Selected 3 Judges", "Selection")
        End If
    End Sub

    ''' <summary>
    ''' Helper subroutine untuk mengatur jumlah judge dan visibility komponen terkait
    ''' </summary>
    Private Sub SafeSetVisible(ctrl As Control, visible As Boolean)
        If ctrl IsNot Nothing Then
            ctrl.Visible = visible
        End If
    End Sub

    Private Sub SetJudgeCount(judgeCount As Integer)
        ' Skip if controls not yet created (during InitializeComponent)
        If PanelAkaFlag1 Is Nothing AndAlso PnlJ1 Is Nothing Then
            Return
        End If

        ' Hide semua judge panels terlebih dahulu
        SafeSetVisible(PnlJ1, judgeCount >= 1)
        SafeSetVisible(PnlJ2, judgeCount >= 2)
        SafeSetVisible(PnlJ3, judgeCount >= 3)
        SafeSetVisible(PnlJ4, judgeCount >= 4)
        SafeSetVisible(PnlJ5, judgeCount >= 5)
        SafeSetVisible(PnlJ6, judgeCount >= 6)
        SafeSetVisible(PnlJ7, judgeCount >= 7)

        ' Hide semua flag panels terlebih dahulu
        SafeSetVisible(PanelAkaFlag5, judgeCount >= 5)
        SafeSetVisible(PanelAkaFlag4, judgeCount >= 4)
        SafeSetVisible(PanelAkaFlag3, judgeCount >= 3)
        SafeSetVisible(PanelAkaFlag2, judgeCount >= 2)
        SafeSetVisible(PanelAkaFlag1, judgeCount >= 1)
        SafeSetVisible(PanelAkaFlag6, judgeCount >= 6)
        SafeSetVisible(PanelAkaFlag7, judgeCount >= 7)

        SafeSetVisible(PanelAoFlag5, judgeCount >= 5)
        SafeSetVisible(PanelAoFlag4, judgeCount >= 4)
        SafeSetVisible(PanelAoFlag3, judgeCount >= 3)
        SafeSetVisible(PanelAoFlag2, judgeCount >= 2)
        SafeSetVisible(PanelAoFlag1, judgeCount >= 1)
        SafeSetVisible(PanelAoFlag6, judgeCount >= 6)
        SafeSetVisible(PanelAoFlag7, judgeCount >= 7)

        ' Update Judge label visibility sesuai count
        SafeSetVisible(LblJ1, judgeCount >= 1)
        SafeSetVisible(LblJ2, judgeCount >= 2)
        SafeSetVisible(LblJ3, judgeCount >= 3)
        SafeSetVisible(LblJ4, judgeCount >= 4)
        SafeSetVisible(LblJ5, judgeCount >= 5)
        SafeSetVisible(LblJ6, judgeCount >= 6)
        SafeSetVisible(LblJ7, judgeCount >= 7)

        ' Update button visibility
        SafeSetVisible(BtnJ1Login, judgeCount >= 1)
        SafeSetVisible(BtnJ1Scoring, judgeCount >= 1)
        SafeSetVisible(BtnJ2Login, judgeCount >= 2)
        SafeSetVisible(BtnJ2Scoring, judgeCount >= 2)
        SafeSetVisible(BtnJ3Login, judgeCount >= 3)
        SafeSetVisible(BtnJ3Scoring, judgeCount >= 3)
        SafeSetVisible(BtnJ4Login, judgeCount >= 4)
        SafeSetVisible(BtnJ4Scoring, judgeCount >= 4)
        SafeSetVisible(BtnJ5Login, judgeCount >= 5)
        SafeSetVisible(BtnJ5Scoring, judgeCount >= 5)
        SafeSetVisible(BtnJ6Login, judgeCount >= 6)
        SafeSetVisible(BtnJ6Scoring, judgeCount >= 6)
        SafeSetVisible(BtnJ7Login, judgeCount >= 7)
        SafeSetVisible(BtnJ7Scoring, judgeCount >= 7)

        SafeSetVisible(LblAkaJ4, judgeCount >= 4)
        SafeSetVisible(NumAkaJ4, judgeCount >= 4)
        SafeSetVisible(LblAkaJ5, judgeCount >= 5)
        SafeSetVisible(NumAkaJ5, judgeCount >= 5)
        SafeSetVisible(LblAkaJ6, judgeCount >= 6)
        SafeSetVisible(NumAkaJ6, judgeCount >= 6)
        SafeSetVisible(LblAkaJ7, judgeCount >= 7)
        SafeSetVisible(NumAkaJ7, judgeCount >= 7)

        SafeSetVisible(LblAoJ4, judgeCount >= 4)
        SafeSetVisible(NumAoJ4, judgeCount >= 4)
        SafeSetVisible(LblAoJ5, judgeCount >= 5)
        SafeSetVisible(NumAoJ5, judgeCount >= 5)
        SafeSetVisible(LblAoJ6, judgeCount >= 6)
        SafeSetVisible(NumAoJ6, judgeCount >= 6)
        SafeSetVisible(LblAoJ7, judgeCount >= 7)
        SafeSetVisible(NumAoJ7, judgeCount >= 7)

        ' preserve current winner button state across judge count changes
        Dim prevWinner As String = lastWinnerSide

        ResetHiddenScores(judgeCount)
        ResetFlagPanelColors()
        UpdateFlagCountLabels()
        RecalculateTotalScores()
        EvaluateWinner()

        If Not String.IsNullOrEmpty(prevWinner) Then
            lastWinnerSide = prevWinner
            BtnAkaShowWinner.Enabled = (prevWinner = "AKA")
            BtnAoShowWinner.Enabled = (prevWinner = "AO")
            UpdateShowWinnerButtonAppearance()
        End If
    End Sub

    Private Sub ResetHiddenScores(judgeCount As Integer)
        If judgeCount < 7 Then
            NumAkaJ7.Value = 0D
            NumAoJ7.Value = 0D
        End If
        If judgeCount < 6 Then
            NumAkaJ6.Value = 0D
            NumAoJ6.Value = 0D
        End If
        If judgeCount < 5 Then
            NumAkaJ5.Value = 0D
            NumAoJ5.Value = 0D
        End If
        If judgeCount < 4 Then
            NumAkaJ4.Value = 0D
            NumAoJ4.Value = 0D
        End If
    End Sub

    Private Sub UpdateFlagCountLabels()
        Dim akaCount = CountAkaFlags()
        Dim aoCount = CountAoFlags()
        LblAkaFlagCount.Text = akaCount.ToString()
        LblAoFlagCount.Text = aoCount.ToString()
    End Sub

    Private Sub UpdateShowWinnerButtonAppearance()
        BtnAkaShowWinner.BackColor = If(BtnAkaShowWinner.Enabled, Color.Red, SystemColors.Control)
        BtnAkaShowWinner.ForeColor = If(BtnAkaShowWinner.Enabled, Color.White, Color.Black)
        BtnAoShowWinner.BackColor = If(BtnAoShowWinner.Enabled, Color.Blue, SystemColors.Control)
        BtnAoShowWinner.ForeColor = If(BtnAoShowWinner.Enabled, Color.White, Color.Black)
    End Sub

    Private Function CountAkaFlags() As Integer
        Dim count = 0
        If PanelAkaFlag1.BackColor = Color.Red Then count += 1
        If PanelAkaFlag2.BackColor = Color.Red Then count += 1
        If PanelAkaFlag3.BackColor = Color.Red Then count += 1
        If PanelAkaFlag4.BackColor = Color.Red Then count += 1
        If PanelAkaFlag5.BackColor = Color.Red Then count += 1
        If PanelAkaFlag6.BackColor = Color.Red Then count += 1
        If PanelAkaFlag7.BackColor = Color.Red Then count += 1
        Return count
    End Function

    Private Function CountAoFlags() As Integer
        Dim count = 0
        If PanelAoFlag1.BackColor = Color.Blue Then count += 1
        If PanelAoFlag2.BackColor = Color.Blue Then count += 1
        If PanelAoFlag3.BackColor = Color.Blue Then count += 1
        If PanelAoFlag4.BackColor = Color.Blue Then count += 1
        If PanelAoFlag5.BackColor = Color.Blue Then count += 1
        If PanelAoFlag6.BackColor = Color.Blue Then count += 1
        If PanelAoFlag7.BackColor = Color.Blue Then count += 1
        Return count
    End Function

    Private Sub RecalculateTotalScores()
        Dim judgeCount = GetCurrentJudgeCount()
        Dim akaTotal As Decimal = 0D
        Dim aoTotal As Decimal = 0D

        If judgeCount >= 1 Then
            akaTotal += NumAkaJ1.Value
            aoTotal += NumAoJ1.Value
        End If
        If judgeCount >= 2 Then
            akaTotal += NumAkaJ2.Value
            aoTotal += NumAoJ2.Value
        End If
        If judgeCount >= 3 Then
            akaTotal += NumAkaJ3.Value
            aoTotal += NumAoJ3.Value
        End If
        If judgeCount >= 4 Then
            akaTotal += NumAkaJ4.Value
            aoTotal += NumAoJ4.Value
        End If
        If judgeCount >= 5 Then
            akaTotal += NumAkaJ5.Value
            aoTotal += NumAoJ5.Value
        End If
        If judgeCount >= 6 Then
            akaTotal += NumAkaJ6.Value
            aoTotal += NumAoJ6.Value
        End If
        If judgeCount >= 7 Then
            akaTotal += NumAkaJ7.Value
            aoTotal += NumAoJ7.Value
        End If

        NumAkaTotalScore.Value = Math.Min(Math.Max(akaTotal, NumAkaTotalScore.Minimum), NumAkaTotalScore.Maximum)
        NumAoTotalScore.Value = Math.Min(Math.Max(aoTotal, NumAoTotalScore.Minimum), NumAoTotalScore.Maximum)
    End Sub

    Private Sub EvaluateWinner()
        Dim winnerSide As String = ""

        If RadFlagSystem.Checked Then
            Dim akaCount = CountAkaFlags()
            Dim aoCount = CountAoFlags()
            If akaCount > aoCount Then
                winnerSide = "AKA"
            ElseIf aoCount > akaCount Then
                winnerSide = "AO"
            End If
        ElseIf RadScore.Checked Then
            RecalculateTotalScores()
            If NumAkaTotalScore.Value > NumAoTotalScore.Value Then
                winnerSide = "AKA"
            ElseIf NumAoTotalScore.Value > NumAkaTotalScore.Value Then
                winnerSide = "AO"
            End If
        End If

        ' Do not show winner dialog automatically. Enable the appropriate show-winner button instead.
        If winnerSide <> "" Then
            lastWinnerSide = winnerSide
            BtnAkaShowWinner.Enabled = (winnerSide = "AKA")
            BtnAoShowWinner.Enabled = (winnerSide = "AO")
        Else
            BtnAkaShowWinner.Enabled = False
            BtnAoShowWinner.Enabled = False
        End If
        UpdateShowWinnerButtonAppearance()
    End Sub

    Private Sub ShowWinnerDialog(side As String)
        Dim winnerName As String
        Dim winnerTeam As String
        Dim winnerTeamInfo As String

        If side = "AKA" Then
            winnerName = If(String.IsNullOrWhiteSpace(TxtAkaName.Text), TxtAkaNameHeader.Text, TxtAkaName.Text)
            winnerTeam = TxtAkaTeam.Text
            winnerTeamInfo = TxtAkaTeamInfo.Text
        Else
            winnerName = If(String.IsNullOrWhiteSpace(TxtAoName.Text), TxtAoNameHeader.Text, TxtAoName.Text)
            winnerTeam = TxtAoTeam.Text
            winnerTeamInfo = TxtAoTeamInfo.Text
        End If

        Dim frmWinner As New FrmWinner()
        frmWinner.SetWinner(winnerName, winnerTeam, winnerTeamInfo, side)
        frmWinner.ShowDialog()
    End Sub

    ' Show-winner buttons (manual trigger)
    Private Sub BtnAkaShowWinner_Click(sender As Object, e As EventArgs) Handles BtnAkaShowWinner.Click
        If BtnAkaShowWinner.Enabled Then
            ShowWinnerDialog("AKA")
        End If
    End Sub

    Private Sub BtnAoShowWinner_Click(sender As Object, e As EventArgs) Handles BtnAoShowWinner.Click
        If BtnAoShowWinner.Enabled Then
            ShowWinnerDialog("AO")
        End If
    End Sub

    Private Sub SetDecisionWinner(winnerSide As String, decisionType As String)
        lastWinnerSide = winnerSide
        BtnAkaShowWinner.Enabled = (winnerSide = "AKA")
        BtnAoShowWinner.Enabled = (winnerSide = "AO")
        UpdateShowWinnerButtonAppearance()
        LogActivityToDb("Decision", $"{decisionType} - Winner set to {winnerSide}", "Action")
    End Sub

    Private Sub BtnAkaDisqualification_Click(sender As Object, e As EventArgs) Handles BtnAkaDisqualification.Click
        SetDecisionWinner("AO", "AKA disqualification")
    End Sub

    Private Sub BtnAoDisqualification_Click(sender As Object, e As EventArgs) Handles BtnAoDisqualification.Click
        SetDecisionWinner("AKA", "AO disqualification")
    End Sub

    Private Sub BtnAkaKiken_Click(sender As Object, e As EventArgs) Handles BtnAkaKiken.Click
        SetDecisionWinner("AO", "AKA kiken")
    End Sub

    Private Sub BtnAoKiken_Click(sender As Object, e As EventArgs) Handles BtnAoKiken.Click
        SetDecisionWinner("AKA", "AO kiken")
    End Sub

    ' Flag reset buttons
    Private Sub BtnAkaFlagReset_Click(sender As Object, e As EventArgs) Handles BtnAkaFlagReset.Click
        PanelAkaFlag1.BackColor = Color.White
        PanelAkaFlag2.BackColor = Color.White
        PanelAkaFlag3.BackColor = Color.White
        PanelAkaFlag4.BackColor = Color.White
        PanelAkaFlag5.BackColor = Color.White
        PanelAkaFlag6.BackColor = Color.White
        PanelAkaFlag7.BackColor = Color.White
        UpdateFlagCountLabels()
        ' Clear any stored winner when resetting flags
        lastWinnerSide = ""
        BtnAkaShowWinner.Enabled = False
        BtnAoShowWinner.Enabled = False
        UpdateShowWinnerButtonAppearance()
        EvaluateWinner()
        LogActivityToDb("Flag", "AKA flags reset", "Action")
    End Sub

    Private Sub BtnAoFlagReset_Click(sender As Object, e As EventArgs) Handles BtnAoFlagReset.Click
        PanelAoFlag1.BackColor = Color.White
        PanelAoFlag2.BackColor = Color.White
        PanelAoFlag3.BackColor = Color.White
        PanelAoFlag4.BackColor = Color.White
        PanelAoFlag5.BackColor = Color.White
        PanelAoFlag6.BackColor = Color.White
        PanelAoFlag7.BackColor = Color.White
        UpdateFlagCountLabels()
        ' Clear any stored winner when resetting flags
        lastWinnerSide = ""
        BtnAkaShowWinner.Enabled = False
        BtnAoShowWinner.Enabled = False
        UpdateShowWinnerButtonAppearance()
        EvaluateWinner()
        LogActivityToDb("Flag", "AO flags reset", "Action")
    End Sub

    ' Score reset buttons
    Private Sub BtnAkaResetScore_Click(sender As Object, e As EventArgs) Handles BtnAkaResetScore.Click
        NumAkaJ1.Value = 0D
        NumAkaJ2.Value = 0D
        NumAkaJ3.Value = 0D
        NumAkaJ4.Value = 0D
        NumAkaJ5.Value = 0D
        NumAkaJ6.Value = 0D
        NumAkaJ7.Value = 0D
        RecalculateTotalScores()
        ' Clear any stored winner when resetting scores
        lastWinnerSide = ""
        BtnAkaShowWinner.Enabled = False
        BtnAoShowWinner.Enabled = False
        UpdateShowWinnerButtonAppearance()
        EvaluateWinner()
        LogActivityToDb("Score", "AKA scores reset", "Action")
    End Sub

    Private Sub BtnAoResetScore_Click(sender As Object, e As EventArgs) Handles BtnAoResetScore.Click
        NumAoJ1.Value = 0D
        NumAoJ2.Value = 0D
        NumAoJ3.Value = 0D
        NumAoJ4.Value = 0D
        NumAoJ5.Value = 0D
        NumAoJ6.Value = 0D
        NumAoJ7.Value = 0D
        RecalculateTotalScores()
        ' Clear any stored winner when resetting scores
        lastWinnerSide = ""
        BtnAkaShowWinner.Enabled = False
        BtnAoShowWinner.Enabled = False
        UpdateShowWinnerButtonAppearance()
        EvaluateWinner()
        LogActivityToDb("Score", "AO scores reset", "Action")
    End Sub

    ''' <summary>
    ''' Helper subroutine untuk reset warna semua flag panels ke warna default
    ''' </summary>
    Private Sub ResetFlagPanelColors()
        ' Reset AKA flags
        PanelAkaFlag1.BackColor = Color.White
        PanelAkaFlag2.BackColor = Color.White
        PanelAkaFlag3.BackColor = Color.White
        PanelAkaFlag4.BackColor = Color.White
        PanelAkaFlag5.BackColor = Color.White
        PanelAkaFlag6.BackColor = Color.White
        PanelAkaFlag7.BackColor = Color.White

        ' Reset AO flags
        PanelAoFlag1.BackColor = Color.White
        PanelAoFlag2.BackColor = Color.White
        PanelAoFlag3.BackColor = Color.White
        PanelAoFlag4.BackColor = Color.White
        PanelAoFlag5.BackColor = Color.White
        PanelAoFlag6.BackColor = Color.White
        PanelAoFlag7.BackColor = Color.White
    End Sub

    ''' <summary>
    ''' Helper subroutine untuk set warna flag panels
    ''' Enforce invariant: total flag yang berubah warna = judgeCount
    ''' Jika AKA memiliki N flag berwarna, AO memiliki (judgeCount - N) flag berwarna
    ''' </summary>
    Private Sub SetFlagColors(akaPanelNumber As Integer, Optional aoPanelNumber As Integer = -1)
        ResetFlagPanelColors()

        ' Tentukan jumlah judge: prefer menghitung dari panel judge yang terlihat (lebih dapat diandalkan saat mode flag/score berganti)
        Dim visibleJudgeCount As Integer = 0
        If PnlJ1 IsNot Nothing AndAlso PnlJ1.Visible Then visibleJudgeCount += 1
        If PnlJ2 IsNot Nothing AndAlso PnlJ2.Visible Then visibleJudgeCount += 1
        If PnlJ3 IsNot Nothing AndAlso PnlJ3.Visible Then visibleJudgeCount += 1
        If PnlJ4 IsNot Nothing AndAlso PnlJ4.Visible Then visibleJudgeCount += 1
        If PnlJ5 IsNot Nothing AndAlso PnlJ5.Visible Then visibleJudgeCount += 1
        If PnlJ6 IsNot Nothing AndAlso PnlJ6.Visible Then visibleJudgeCount += 1
        If PnlJ7 IsNot Nothing AndAlso PnlJ7.Visible Then visibleJudgeCount += 1

        Dim judgeCount As Integer = If(visibleJudgeCount > 0, visibleJudgeCount, GetCurrentJudgeCount())

        ' Enforce invariant: total flags colored tidak boleh melebihi judgeCount
        Dim totalFlags As Integer = Math.Min(Math.Max(judgeCount, 0), 7)

        ' Jika aoPanelNumber tidak diberikan, hitung dari totalFlags - akaPanelNumber
        If aoPanelNumber = -1 Then
            aoPanelNumber = totalFlags - akaPanelNumber
        End If

        ' Clamp aoPanelNumber ke rentang 0..totalFlags untuk menghindari nilai negatif/lebih
        aoPanelNumber = Math.Min(Math.Max(aoPanelNumber, 0), totalFlags)

        ' Clamp akaPanelNumber juga ke rentang 0..totalFlags
        akaPanelNumber = Math.Min(Math.Max(akaPanelNumber, 0), totalFlags)

        ' Debug log untuk membantu pelacakan masalah perhitungan flag
        LogActivityToDb("FlagDebug", $"SetFlagColors called: visibleJudgeCount={visibleJudgeCount}, judgeCount={judgeCount}, totalFlags={totalFlags}, aka={akaPanelNumber}, ao={aoPanelNumber}", "Debug")

        ' Set warna merah untuk AKA panels 1 hingga akaPanelNumber
        For i = 1 To Math.Min(akaPanelNumber, 7)
            Select Case i
                Case 1 : PanelAkaFlag1.BackColor = Color.Red
                Case 2 : PanelAkaFlag2.BackColor = Color.Red
                Case 3 : PanelAkaFlag3.BackColor = Color.Red
                Case 4 : PanelAkaFlag4.BackColor = Color.Red
                Case 5 : PanelAkaFlag5.BackColor = Color.Red
                Case 6 : PanelAkaFlag6.BackColor = Color.Red
                Case 7 : PanelAkaFlag7.BackColor = Color.Red
            End Select
        Next

        ' Set warna biru untuk AO panels (computed untuk enforce total = judgeCount)
        For i = 1 To Math.Min(aoPanelNumber, 7)
            Select Case i
                Case 1 : PanelAoFlag1.BackColor = Color.Blue
                Case 2 : PanelAoFlag2.BackColor = Color.Blue
                Case 3 : PanelAoFlag3.BackColor = Color.Blue
                Case 4 : PanelAoFlag4.BackColor = Color.Blue
                Case 5 : PanelAoFlag5.BackColor = Color.Blue
                Case 6 : PanelAoFlag6.BackColor = Color.Blue
                Case 7 : PanelAoFlag7.BackColor = Color.Blue
            End Select
        Next

        UpdateFlagCountLabels()
        ' Debug log counts after setting
        LogActivityToDb("FlagDebug", $"After SetFlagColors: CountAka={CountAkaFlags()}, CountAo={CountAoFlags()}", "Debug")
        EvaluateWinner()
    End Sub

    ''' <summary>
    ''' Helper function untuk mendapatkan current judge count
    ''' </summary>
    Private Function GetCurrentJudgeCount() As Integer
        If RadJudge3.Checked Then Return 3
        If RadJudge7.Checked Then Return 7
        Return 5 ' Default to 5 judges
    End Function

    ''' <summary>
    ''' Event handler untuk PanelAkaFlag1 Click
    ''' </summary>
    Private Sub PanelAkaFlag1_Click(sender As Object, e As EventArgs) Handles PanelAkaFlag1.Click, LblAkaFlag1.Click, LblAkaNum1.Click
        SetFlagColors(1)
        LogActivityToDb("Flag", "AKA Flag 1 clicked", "Action")
    End Sub

    ''' <summary>
    ''' Event handler untuk PanelAkaFlag2 Click
    ''' </summary>
    Private Sub PanelAkaFlag2_Click(sender As Object, e As EventArgs) Handles PanelAkaFlag2.Click, LblAkaFlag2.Click, LblAkaNum2.Click
        SetFlagColors(2)
        LogActivityToDb("Flag", "AKA Flag 2 clicked", "Action")
    End Sub

    ''' <summary>
    ''' Event handler untuk PanelAkaFlag3 Click
    ''' </summary>
    Private Sub PanelAkaFlag3_Click(sender As Object, e As EventArgs) Handles PanelAkaFlag3.Click, LblAkaFlag3.Click, LblAkaNum3.Click
        SetFlagColors(3)
        LogActivityToDb("Flag", "AKA Flag 3 clicked", "Action")
    End Sub

    ''' <summary>
    ''' Event handler untuk PanelAkaFlag4 Click
    ''' </summary>
    Private Sub PanelAkaFlag4_Click(sender As Object, e As EventArgs) Handles PanelAkaFlag4.Click, LblAkaFlag4.Click, LblAkaNum4.Click
        SetFlagColors(4)
        LogActivityToDb("Flag", "AKA Flag 4 clicked", "Action")
    End Sub

    ''' <summary>
    ''' Event handler untuk PanelAkaFlag5 Click
    ''' </summary>
    Private Sub PanelAkaFlag5_Click(sender As Object, e As EventArgs) Handles PanelAkaFlag5.Click, LblAkaFlag5.Click, LblAkaNum5.Click
        SetFlagColors(5)
        LogActivityToDb("Flag", "AKA Flag 5 clicked", "Action")
    End Sub

    ''' <summary>
    ''' Event handler untuk PanelAoFlag1 Click
    ''' </summary>
    Private Sub PanelAoFlag1_Click(sender As Object, e As EventArgs) Handles PanelAoFlag1.Click, LblAoFlag1.Click, LblAoNum1.Click
        Dim judgeCount = GetCurrentJudgeCount()
        SetFlagColors(judgeCount - 1, 1)
        LogActivityToDb("Flag", "AO Flag 1 clicked", "Action")
    End Sub

    ''' <summary>
    ''' Event handler untuk PanelAoFlag2 Click
    ''' </summary>
    Private Sub PanelAoFlag2_Click(sender As Object, e As EventArgs) Handles PanelAoFlag2.Click, LblAoFlag2.Click, LblAoNum2.Click
        Dim judgeCount = GetCurrentJudgeCount()
        SetFlagColors(judgeCount - 2, 2)
        LogActivityToDb("Flag", "AO Flag 2 clicked", "Action")
    End Sub

    ''' <summary>
    ''' Event handler untuk PanelAoFlag3 Click
    ''' </summary>
    Private Sub PanelAoFlag3_Click(sender As Object, e As EventArgs) Handles PanelAoFlag3.Click, LblAoFlag3.Click, LblAoNum3.Click
        Dim judgeCount = GetCurrentJudgeCount()
        SetFlagColors(judgeCount - 3, 3)
        LogActivityToDb("Flag", "AO Flag 3 clicked", "Action")
    End Sub

    ''' <summary>
    ''' Event handler untuk PanelAoFlag4 Click
    ''' </summary>
    Private Sub PanelAoFlag4_Click(sender As Object, e As EventArgs) Handles PanelAoFlag4.Click, LblAoFlag4.Click, LblAoNum4.Click
        Dim judgeCount = GetCurrentJudgeCount()
        SetFlagColors(judgeCount - 4, 4)
        LogActivityToDb("Flag", "AO Flag 4 clicked", "Action")
    End Sub

    ''' <summary>
    ''' Event handler untuk PanelAoFlag5 Click
    ''' </summary>
    Private Sub PanelAoFlag5_Click(sender As Object, e As EventArgs) Handles PanelAoFlag5.Click, LblAoFlag5.Click, LblAoNum5.Click
        Dim judgeCount = GetCurrentJudgeCount()
        SetFlagColors(judgeCount - 5, 5)
        LogActivityToDb("Flag", "AO Flag 5 clicked", "Action")
    End Sub

    ''' <summary>
    ''' Event handler untuk PanelAkaFlag6 Click
    ''' </summary>
    Private Sub PanelAkaFlag6_Click(sender As Object, e As EventArgs) Handles PanelAkaFlag6.Click, LblAkaFlag6.Click, LblAkaNum6.Click
        SetFlagColors(6)
        LogActivityToDb("Flag", "AKA Flag 6 clicked", "Action")
    End Sub

    ''' <summary>
    ''' Event handler untuk PanelAkaFlag7 Click
    ''' </summary>
    Private Sub PanelAkaFlag7_Click(sender As Object, e As EventArgs) Handles PanelAkaFlag7.Click, LblAkaFlag7.Click, LblAkaNum7.Click
        SetFlagColors(7)
        LogActivityToDb("Flag", "AKA Flag 7 clicked", "Action")
    End Sub

    ''' <summary>
    ''' Event handler untuk PanelAoFlag6 Click
    ''' </summary>
    Private Sub PanelAoFlag6_Click(sender As Object, e As EventArgs) Handles PanelAoFlag6.Click, LblAoFlag6.Click, LblAoNum6.Click
        Dim judgeCount = GetCurrentJudgeCount()
        SetFlagColors(judgeCount - 6, 6)
        LogActivityToDb("Flag", "AO Flag 6 clicked", "Action")
    End Sub

    ''' <summary>
    ''' Event handler untuk PanelAoFlag7 Click
    ''' </summary>
    Private Sub PanelAoFlag7_Click(sender As Object, e As EventArgs) Handles PanelAoFlag7.Click, LblAoFlag7.Click, LblAoNum7.Click
        Dim judgeCount = GetCurrentJudgeCount()
        SetFlagColors(judgeCount - 7, 7)
        LogActivityToDb("Flag", "AO Flag 7 clicked", "Action")
    End Sub
    Private Sub BtnStartScoreboardRight_Click(sender As Object, e As EventArgs) Handles BtnStartScoreboardRight.Click
        If scoreboardActive Then
            TutupScoreboard()
        Else
            If Screen.AllScreens.Length < 2 Then
                Dim hasil As DialogResult = MessageBox.Show(
                    "No extended display detected." & vbNewLine &
                    "Please connect a second screen and set it to Extend mode." & vbNewLine &
                    "Continue show in main screen?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                )
                If hasil = DialogResult.Yes Then
                    BukaScoreboard()
                End If
            Else
                BukaScoreboard()
            End If
        End If
    End Sub

    Private Sub BukaScoreboard()
        splashForm = New FrmSplashKata(Me)
        AddHandler splashForm.FormClosed, AddressOf SplashClosed
        AddHandler splashForm.ScoreboardOpened, AddressOf OnScoreboardOpened
        splashForm.Show()
        scoreboardActive = True
        BtnStartScoreboardRight.Text = "Close Scoreboard"
        BtnStartScoreboardRight.BackColor = Color.OrangeRed
    End Sub

    Private Sub SplashClosed(sender As Object, e As EventArgs)
        ' Splash sudah tutup, tunggu ScoreboardClosed
    End Sub

    Private Sub OnScoreboardOpened(scoreboard As KataScoreboard)
        AddHandler scoreboard.FormClosed, AddressOf ScoreboardClosed
    End Sub

    Private Sub TutupScoreboard()
        If splashForm IsNot Nothing AndAlso Not splashForm.IsDisposed Then
            splashForm.Close()
        End If
        ScoreboardClosed(Nothing, Nothing)
    End Sub

    Private Sub ScoreboardClosed(sender As Object, e As EventArgs)
        scoreboardActive = False
        splashForm = Nothing
        BtnStartScoreboardRight.Text = "Start Scoreboard"
        BtnStartScoreboardRight.BackColor = Color.LimeGreen
    End Sub

    ' === HELPER METHODS UNTUK KATASCOREBBOARD ===
    Public Function GetAkaTeamName() As String
        ' Baca dari TxtAkaTeam (nama team yang ditampilkan)
        If TxtAkaTeam IsNot Nothing AndAlso Not String.IsNullOrEmpty(TxtAkaTeam.Text) Then
            Return TxtAkaTeam.Text
        End If
        ' Fallback ke variable
        If Not String.IsNullOrEmpty(akaSelectedTeam) Then
            Return akaSelectedTeam
        End If
        Return ""
    End Function

    Public Function GetAoTeamName() As String
        ' Baca dari TxtAoTeam (nama team yang ditampilkan)
        If TxtAoTeam IsNot Nothing AndAlso Not String.IsNullOrEmpty(TxtAoTeam.Text) Then
            Return TxtAoTeam.Text
        End If
        ' Fallback ke variable
        If Not String.IsNullOrEmpty(aoSelectedTeam) Then
            Return aoSelectedTeam
        End If
        Return ""
    End Function

    Public Function GetAkaScore() As Integer
        If RadFlagSystem.Checked Then
            Return CountAkaFlags()
        Else
            Return CInt(NumAkaTotalScore.Value)
        End If
    End Function

    Public Function GetAoScore() As Integer
        If RadFlagSystem.Checked Then
            Return CountAoFlags()
        Else
            Return CInt(NumAoTotalScore.Value)
        End If
    End Function

End Class
