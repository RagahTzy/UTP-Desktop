Public Class Kumite

    ' ==================== Buka Jendela ListOfCompetitor ====================
    Private Sub OpenCompetitor_Click(sender As Object, e As EventArgs) Handles BtnAkaIcon.Click, BtnAoIcon.Click, BtnAkaUserIcon1.Click, BtnAoUserIcon1.Click
        Dim frmCompetitor As New ListOfCompetitor()
        frmCompetitor.ShowDialog()

        Dim clickedButton = CType(sender, Button)

        If frmCompetitor.SelectedCompetitorName <> "" Then
            If clickedButton.Name = "BtnAkaIcon" Or clickedButton.Name = "BtnAkaUserIcon1" Then
                TxtAkaNameMain.Text = frmCompetitor.SelectedCompetitorName
                TxtAkaTeam.Text = frmCompetitor.SelectedTeamName
                TxtAkaTeamInfo.Text = frmCompetitor.SelectedTeamInfo
            ElseIf clickedButton.Name = "BtnAoIcon" Or clickedButton.Name = "BtnAoUserIcon1" Then
                TxtAoNameMain.Text = frmCompetitor.SelectedCompetitorName
                TxtAoTeam.Text = frmCompetitor.SelectedTeamName
                TxtAoTeamInfo.Text = frmCompetitor.SelectedTeamInfo
            End If
        End If
    End Sub

    ' ==================== Buka Jendela Pengaturan & Log ====================
    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click
        Dim frmSettings As New FrmScoreboardSetting()
        frmSettings.ShowDialog()
    End Sub

    Private Sub BtnLogActivity_Click(sender As Object, e As EventArgs) Handles BtnLogActivity.Click
        Dim frmLog As New Log_Activity()
        frmLog.ShowDialog()
    End Sub

    Private Sub BtnShortcut_Click(sender As Object, e As EventArgs) Handles BtnShortcut.Click
        Dim frmShortcut As New Shortcut()
        frmShortcut.ShowDialog()
    End Sub

    ' ==================== Buka Jendela Hantei ====================
    Private Sub BtnHantei_Click(sender As Object, e As EventArgs) Handles BtnHantei.Click
        Dim frmDecision As New ManualDecision()
        frmDecision.ShowDialog()
    End Sub

    ' ==================== Form Closed ====================
    Private Sub Kumite_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Show()
    End Sub

    ' ====================================================================================
    '                              AKA SECTION
    ' ====================================================================================

    ' Button1 dipencet → AO jadi winner
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowAoWinner()
    End Sub

    ' BtnAkaShikkaku dipencet → AO jadi winner
    Private Sub BtnAkaShikkaku_Click(sender As Object, e As EventArgs) Handles BtnAkaShikkaku.Click
        ShowAoWinner()
    End Sub

    ' BtnAkaKnockedOut dipencet → Muncul jendela Knocked Out Countdown
    Private Sub BtnAkaKnockedOut_Click(sender As Object, e As EventArgs) Handles BtnAkaKnockedOut.Click
        ShowKnockedOutCountdown()
    End Sub

    ' ==================== AKA PENALTY BUTTONS ====================
    ' BtnAka1C → hanya 1C merah
    Private Sub BtnAka1C_Click(sender As Object, e As EventArgs) Handles BtnAka1C.Click
        If BtnAka1C.BackColor = Color.Red And BtnAka2C.BackColor = SystemColors.Control Then
            ' Toggle off jika sudah merah sendirian
            BtnAka1C.BackColor = SystemColors.Control
            BtnAka1C.ForeColor = Color.Black
        Else
            BtnAka1C.BackColor = Color.Red : BtnAka1C.ForeColor = Color.White
            BtnAka2C.BackColor = SystemColors.Control : BtnAka2C.ForeColor = Color.Black
            BtnAka3C.BackColor = SystemColors.Control : BtnAka3C.ForeColor = Color.Black
            BtnAkaHC.BackColor = SystemColors.Control : BtnAkaHC.ForeColor = Color.Black
            BtnAkaH.BackColor = SystemColors.Control : BtnAkaH.ForeColor = Color.Black
        End If
    End Sub

    ' BtnAka2C → 1C dan 2C merah
    Private Sub BtnAka2C_Click(sender As Object, e As EventArgs) Handles BtnAka2C.Click
        BtnAka1C.BackColor = Color.Red : BtnAka1C.ForeColor = Color.White
        BtnAka2C.BackColor = Color.Red : BtnAka2C.ForeColor = Color.White
        BtnAka3C.BackColor = SystemColors.Control : BtnAka3C.ForeColor = Color.Black
        BtnAkaHC.BackColor = SystemColors.Control : BtnAkaHC.ForeColor = Color.Black
        BtnAkaH.BackColor = SystemColors.Control : BtnAkaH.ForeColor = Color.Black
    End Sub

    ' BtnAka3C → 1C, 2C, 3C merah
    Private Sub BtnAka3C_Click(sender As Object, e As EventArgs) Handles BtnAka3C.Click
        BtnAka1C.BackColor = Color.Red : BtnAka1C.ForeColor = Color.White
        BtnAka2C.BackColor = Color.Red : BtnAka2C.ForeColor = Color.White
        BtnAka3C.BackColor = Color.Red : BtnAka3C.ForeColor = Color.White
        BtnAkaHC.BackColor = SystemColors.Control : BtnAkaHC.ForeColor = Color.Black
        BtnAkaH.BackColor = SystemColors.Control : BtnAkaH.ForeColor = Color.Black
    End Sub

    ' BtnAkaHC → 1C, 2C, 3C, HC merah
    Private Sub BtnAkaHC_Click(sender As Object, e As EventArgs) Handles BtnAkaHC.Click
        BtnAka1C.BackColor = Color.Red : BtnAka1C.ForeColor = Color.White
        BtnAka2C.BackColor = Color.Red : BtnAka2C.ForeColor = Color.White
        BtnAka3C.BackColor = Color.Red : BtnAka3C.ForeColor = Color.White
        BtnAkaHC.BackColor = Color.Red : BtnAkaHC.ForeColor = Color.White
        BtnAkaH.BackColor = SystemColors.Control : BtnAkaH.ForeColor = Color.Black
    End Sub

    ' BtnAkaH → Semua merah, lalu AO jadi winner (Hansoku)
    Private Sub BtnAkaH_Click(sender As Object, e As EventArgs) Handles BtnAkaH.Click
        BtnAka1C.BackColor = Color.Red : BtnAka1C.ForeColor = Color.White
        BtnAka2C.BackColor = Color.Red : BtnAka2C.ForeColor = Color.White
        BtnAka3C.BackColor = Color.Red : BtnAka3C.ForeColor = Color.White
        BtnAkaHC.BackColor = Color.Red : BtnAkaHC.ForeColor = Color.White
        BtnAkaH.BackColor = Color.Red : BtnAkaH.ForeColor = Color.White
        ShowAoWinner() ' Jika AKA Hansoku, maka AO menang
    End Sub

    ' ==================== AKA VR ====================
    ' BtnAkaVR dipencet → toggle kuning
    Private Sub BtnAkaVR_Click(sender As Object, e As EventArgs) Handles BtnAkaVR.Click
        If BtnAkaVR.BackColor = Color.Yellow Then
            BtnAkaVR.BackColor = SystemColors.Control
            BtnAkaVR.ForeColor = Color.Black
        Else
            BtnAkaVR.BackColor = Color.Yellow
            BtnAkaVR.ForeColor = Color.Black
        End If
    End Sub

    ' ==================== AKA SENSHU ====================
    ' BtnAkaSenshu dipencet → toggle kuning
    Private Sub BtnAkaSenshu_Click(sender As Object, e As EventArgs) Handles BtnAkaSenshu.Click
        If BtnAkaSenshu.BackColor = Color.Yellow Then
            BtnAkaSenshu.BackColor = SystemColors.Control
            BtnAkaSenshu.ForeColor = Color.Black
        Else
            BtnAkaSenshu.BackColor = Color.Yellow
            BtnAkaSenshu.ForeColor = Color.Black
        End If
    End Sub

    ' ==================== AKA SCORE HISTORY ====================
    ' BtnAkaYuko → tambah Yuko ke history
    Private Sub BtnAkaYuko_Click(sender As Object, e As EventArgs) Handles BtnAkaYuko.Click
        AddScoreToHistory(DgvAkaHistory, "(1)-Yuko", LblMatchTimerValue.Text)
        UpdateAkaMainScore()
    End Sub

    ' BtnAkaWazaari → tambah Waza-ari ke history
    Private Sub BtnAkaWazaari_Click(sender As Object, e As EventArgs) Handles BtnAkaWazaari.Click
        AddScoreToHistory(DgvAkaHistory, "(2)-Waza-ari", LblMatchTimerValue.Text)
        UpdateAkaMainScore()
    End Sub

    ' BtnAkaIppon → tambah Ippon ke history
    Private Sub BtnAkaIppon_Click(sender As Object, e As EventArgs) Handles BtnAkaIppon.Click
        AddScoreToHistory(DgvAkaHistory, "(3)-Ippon", LblMatchTimerValue.Text)
        UpdateAkaMainScore()
    End Sub

    ' ==================== AKA RESET SCORE ====================
    ' BtnAkaResetScore → hapus semua data di DgvAkaHistory
    Private Sub BtnAkaResetScore_Click(sender As Object, e As EventArgs) Handles BtnAkaResetScore.Click
        DgvAkaHistory.Rows.Clear()
        LblAkaMainScore.Text = "0"
    End Sub

    ' ==================== AKA SHOW WINNER ====================
    ' BtnAkaShowWinner → tampilkan pemenang AKA
    Private Sub BtnAkaShowWinner_Click(sender As Object, e As EventArgs) Handles BtnAkaShowWinner.Click
        ShowAkaWinner()
    End Sub

    ' ==================== AKA SEARCH TEAM ====================
    Private Sub BtnAkaSearch2_Click(sender As Object, e As EventArgs) Handles BtnAkaSearch2.Click
        Dim frmTeam As New ListofTeam()
        frmTeam.ShowDialog()

        If frmTeam.SelectedTeamName <> "" Then
            TxtAkaTeam.Text = frmTeam.SelectedTeamName
            TxtAkaTeamInfo.Text = frmTeam.SelectedTeamInfo
        End If
    End Sub

    ' ====================================================================================
    '                              AO SECTION
    ' ====================================================================================

    Private Sub BtnAoKiken_Click(sender As Object, e As EventArgs) Handles BtnAoKiken.Click
        ShowAkaWinner()
    End Sub

    Private Sub BtnAoShikkaku_Click(sender As Object, e As EventArgs) Handles BtnAoShikkaku.Click
        ShowAkaWinner()
    End Sub

    Private Sub BtnAoKnockedOut_Click(sender As Object, e As EventArgs) Handles BtnAoKnockedOut.Click
        ShowKnockedOutCountdown()
    End Sub

    ' ==================== AO PENALTY BUTTONS ====================
    Private Sub BtnAo1C_Click(sender As Object, e As EventArgs) Handles BtnAo1C.Click
        If BtnAo1C.BackColor = Color.Blue And BtnAo2C.BackColor = SystemColors.Control Then
            BtnAo1C.BackColor = SystemColors.Control
            BtnAo1C.ForeColor = Color.Black
        Else
            BtnAo1C.BackColor = Color.Blue : BtnAo1C.ForeColor = Color.White
            BtnAo2C.BackColor = SystemColors.Control : BtnAo2C.ForeColor = Color.Black
            BtnAo3C.BackColor = SystemColors.Control : BtnAo3C.ForeColor = Color.Black
            BtnAoHC.BackColor = SystemColors.Control : BtnAoHC.ForeColor = Color.Black
            BtnAoH.BackColor = SystemColors.Control : BtnAoH.ForeColor = Color.Black
        End If
    End Sub

    Private Sub BtnAo2C_Click(sender As Object, e As EventArgs) Handles BtnAo2C.Click
        BtnAo1C.BackColor = Color.Blue : BtnAo1C.ForeColor = Color.White
        BtnAo2C.BackColor = Color.Blue : BtnAo2C.ForeColor = Color.White
        BtnAo3C.BackColor = SystemColors.Control : BtnAo3C.ForeColor = Color.Black
        BtnAoHC.BackColor = SystemColors.Control : BtnAoHC.ForeColor = Color.Black
        BtnAoH.BackColor = SystemColors.Control : BtnAoH.ForeColor = Color.Black
    End Sub

    Private Sub BtnAo3C_Click(sender As Object, e As EventArgs) Handles BtnAo3C.Click
        BtnAo1C.BackColor = Color.Blue : BtnAo1C.ForeColor = Color.White
        BtnAo2C.BackColor = Color.Blue : BtnAo2C.ForeColor = Color.White
        BtnAo3C.BackColor = Color.Blue : BtnAo3C.ForeColor = Color.White
        BtnAoHC.BackColor = SystemColors.Control : BtnAoHC.ForeColor = Color.Black
        BtnAoH.BackColor = SystemColors.Control : BtnAoH.ForeColor = Color.Black
    End Sub

    Private Sub BtnAoHC_Click(sender As Object, e As EventArgs) Handles BtnAoHC.Click
        BtnAo1C.BackColor = Color.Blue : BtnAo1C.ForeColor = Color.White
        BtnAo2C.BackColor = Color.Blue : BtnAo2C.ForeColor = Color.White
        BtnAo3C.BackColor = Color.Blue : BtnAo3C.ForeColor = Color.White
        BtnAoHC.BackColor = Color.Blue : BtnAoHC.ForeColor = Color.White
        BtnAoH.BackColor = SystemColors.Control : BtnAoH.ForeColor = Color.Black
    End Sub

    Private Sub BtnAoH_Click(sender As Object, e As EventArgs) Handles BtnAoH.Click
        BtnAo1C.BackColor = Color.Blue : BtnAo1C.ForeColor = Color.White
        BtnAo2C.BackColor = Color.Blue : BtnAo2C.ForeColor = Color.White
        BtnAo3C.BackColor = Color.Blue : BtnAo3C.ForeColor = Color.White
        BtnAoHC.BackColor = Color.Blue : BtnAoHC.ForeColor = Color.White
        BtnAoH.BackColor = Color.Blue : BtnAoH.ForeColor = Color.White
        ShowAkaWinner()
    End Sub

    ' ==================== AO VR & SENSHU ====================
    Private Sub BtnAoVR_Click(sender As Object, e As EventArgs) Handles BtnAoVR.Click
        If BtnAoVR.BackColor = Color.Yellow Then
            BtnAoVR.BackColor = SystemColors.Control
            BtnAoVR.ForeColor = Color.Black
        Else
            BtnAoVR.BackColor = Color.Yellow
            BtnAoVR.ForeColor = Color.Black
        End If
    End Sub

    Private Sub BtnAoSenshu_Click(sender As Object, e As EventArgs) Handles BtnAoSenshu.Click
        If BtnAoSenshu.BackColor = Color.Yellow Then
            BtnAoSenshu.BackColor = SystemColors.Control
            BtnAoSenshu.ForeColor = Color.Black
        Else
            BtnAoSenshu.BackColor = Color.Yellow
            BtnAoSenshu.ForeColor = Color.Black
        End If
    End Sub

    ' ==================== AO SCORE HISTORY ====================
    Private Sub BtnAoYuko_Click(sender As Object, e As EventArgs) Handles BtnAoYuko.Click
        AddScoreToHistory(DgvAoHistory, "(1)-Yuko", LblMatchTimerValue.Text)
        UpdateAoMainScore()
    End Sub

    Private Sub BtnAoWazaari_Click(sender As Object, e As EventArgs) Handles BtnAoWazaari.Click
        AddScoreToHistory(DgvAoHistory, "(2)-Waza-ari", LblMatchTimerValue.Text)
        UpdateAoMainScore()
    End Sub

    Private Sub BtnAoIppon_Click(sender As Object, e As EventArgs) Handles BtnAoIppon.Click
        AddScoreToHistory(DgvAoHistory, "(3)-Ippon", LblMatchTimerValue.Text)
        UpdateAoMainScore()
    End Sub

    ' ==================== AO RESET SCORE ====================
    Private Sub BtnAoResetScore_Click(sender As Object, e As EventArgs) Handles BtnAoResetScore.Click
        DgvAoHistory.Rows.Clear()
        LblAoMainScore.Text = "0"
    End Sub

    ' ==================== AO SHOW WINNER ====================
    Private Sub BtnAoShowWinner_Click(sender As Object, e As EventArgs) Handles BtnAoShowWinner.Click
        ShowAoWinner()
    End Sub

    ' ==================== AO SEARCH TEAM ====================
    Private Sub BtnAoSearch2_Click(sender As Object, e As EventArgs) Handles BtnAoSearch2.Click
        Dim frmTeam As New ListofTeam()
        frmTeam.ShowDialog()

        If frmTeam.SelectedTeamName <> "" Then
            TxtAoTeam.Text = frmTeam.SelectedTeamName
            TxtAoTeamInfo.Text = frmTeam.SelectedTeamInfo
        End If
    End Sub

    ' ====================================================================================
    '                         HELPER / SHARED FUNCTIONS
    ' ====================================================================================

    Private Sub CheckPointGap()
        Dim akaScore As Integer = 0
        Dim aoScore As Integer = 0

        Integer.TryParse(LblAkaMainScore.Text, akaScore)
        Integer.TryParse(LblAoMainScore.Text, aoScore)

        Dim winGap As Integer = CInt(NumWinPoint.Value)
        Dim currentGap As Integer = Math.Abs(akaScore - aoScore)

        If currentGap >= winGap Then
            If akaScore > aoScore Then
                MessageBox.Show("Selisih " & winGap & " poin tercapai!" & vbCrLf & "AKA Menang!", "Pertandingan Selesai", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ShowAkaWinner()
            Else
                MessageBox.Show("Selisih " & winGap & " poin tercapai!" & vbCrLf & "AO Menang!", "Pertandingan Selesai", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ShowAoWinner()
            End If
        End If
    End Sub

    Private Sub ShowAoWinner()
        Dim winnerName As String = TxtAoNameMain.Text
        Dim teamName As String = TxtAoTeam.Text
        Dim teamInfo As String = TxtAoTeamInfo.Text

        If String.IsNullOrEmpty(winnerName) Then
            MessageBox.Show("Pilih peserta AO terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim frmWinner As New FrmWinner()
        frmWinner.SetWinner(winnerName, teamName, teamInfo, "AO")
        frmWinner.ShowDialog()
    End Sub

    Private Sub ShowAkaWinner()
        Dim winnerName As String = TxtAkaNameMain.Text
        Dim teamName As String = TxtAkaTeam.Text
        Dim teamInfo As String = TxtAkaTeamInfo.Text

        If String.IsNullOrEmpty(winnerName) Then
            MessageBox.Show("Pilih peserta AKA terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim frmWinner As New FrmWinner()
        frmWinner.SetWinner(winnerName, teamName, teamInfo, "AKA")
        frmWinner.ShowDialog()
    End Sub

    Private Sub ShowKnockedOutCountdown()
        Dim frmKO As New FrmKnockedOut()
        frmKO.ShowDialog()
    End Sub

    Private Sub AddScoreToHistory(datagrid As DataGridView, scoreType As String, timer As String)
        Dim noRow As Integer = datagrid.Rows.Count + 1
        datagrid.Rows.Add(noRow, timer, scoreType)
    End Sub

    Private Sub UpdateAoMainScore()
        Dim totalScore As Integer = 0
        For Each row As DataGridViewRow In DgvAoHistory.Rows
            Dim typeStr As String = If(row.Cells(2).Value IsNot Nothing, row.Cells(2).Value.ToString(), "")
            If typeStr.Contains("(3)") Then
                totalScore += 3
            ElseIf typeStr.Contains("(2)") Then
                totalScore += 2
            ElseIf typeStr.Contains("(1)") Then
                totalScore += 1
            End If
        Next
        LblAoMainScore.Text = totalScore.ToString()
        CheckPointGap()
    End Sub

    Private Sub UpdateAkaMainScore()
        Dim totalScore As Integer = 0
        For Each row As DataGridViewRow In DgvAkaHistory.Rows
            Dim typeStr As String = If(row.Cells(2).Value IsNot Nothing, row.Cells(2).Value.ToString(), "")
            If typeStr.Contains("(3)") Then
                totalScore += 3
            ElseIf typeStr.Contains("(2)") Then
                totalScore += 2
            ElseIf typeStr.Contains("(1)") Then
                totalScore += 1
            End If
        Next
        LblAkaMainScore.Text = totalScore.ToString()
        CheckPointGap()
    End Sub

End Class