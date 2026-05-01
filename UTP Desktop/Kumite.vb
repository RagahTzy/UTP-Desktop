Public Class Kumite

    ' ==================== Buka Jendela ListOfCompetitor ====================
    ' Menggabungkan 4 tombol menjadi 1 fungsi agar kode lebih bersih
    Private Sub OpenCompetitor_Click(sender As Object, e As EventArgs) Handles BtnAkaIcon.Click, BtnAoIcon.Click, BtnAkaUserIcon1.Click, BtnAoUserIcon1.Click
        Dim frmCompetitor As New ListOfCompetitor()
        frmCompetitor.ShowDialog()

        ' Tentukan tombol mana yang di-click
        Dim clickedButton = CType(sender, Button)

        ' Jika ada data yang dipilih, isi ke text box yang sesuai
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
        Dim frmLog As New Log_Activity() ' Pastikan nama class-nya sesuai (Log_Activity atau LogActivity)
        frmLog.ShowDialog()
    End Sub

    Private Sub BtnShortcut_Click(sender As Object, e As EventArgs) Handles BtnShortcut.Click
        Dim frmShortcut As New Shortcut()
        frmShortcut.ShowDialog()
    End Sub

    ' ==================== Buka Jendela Hantei (Manual Decision) ====================
    Private Sub BtnHantei_Click(sender As Object, e As EventArgs) Handles BtnHantei.Click
        Dim frmDecision As New ManualDecision()
        frmDecision.ShowDialog()
    End Sub

    ' ==================== Form Closed (Penting untuk alur aplikasi) ====================
    ' Jangan lupa tambahkan ini agar saat Kumite ditutup, aplikasi kembali ke Dashboard
    Private Sub Kumite_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Show()
    End Sub

    ' ==================== AO WINNER HANDLERS ====================
    Private Sub BtnAoKiken_Click(sender As Object, e As EventArgs) Handles BtnAoKiken.Click
        ShowAkaWinner()
    End Sub

    Private Sub BtnAoShikkaku_Click(sender As Object, e As EventArgs) Handles BtnAoShikkaku.Click
        ShowAkaWinner()
    End Sub

    ' ==================== AO KNOCKED OUT ====================
    Private Sub BtnAoKnockedOut_Click(sender As Object, e As EventArgs) Handles BtnAoKnockedOut.Click
        ShowKnockedOutCountdown()
    End Sub

    Private Sub CheckPointGap()
        Dim akaScore As Integer = 0
        Dim aoScore As Integer = 0

        ' Mengambil skor dari label
        Integer.TryParse(LblAkaMainScore.Text, akaScore)
        Integer.TryParse(LblAoMainScore.Text, aoScore)

        ' Ambil target poin kemenangan dari inputan NumWinPoint (Bawaannya 8)
        Dim winGap As Integer = CInt(NumWinPoint.Value)

        ' Hitung selisih absolut antara AKA dan AO
        Dim currentGap As Integer = Math.Abs(akaScore - aoScore)

        ' Jika selisihnya sudah 8 atau lebih
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

    ' ==================== AO PENALTY BUTTONS ====================
    Private Sub BtnAo1C_Click(sender As Object, e As EventArgs) Handles BtnAo1C.Click
        ' Jika 1C adalah satu-satunya yang biru dan dipencet lagi, hapus semua penalti (reset ke 0)
        If BtnAo1C.BackColor = Color.Blue And BtnAo2C.BackColor = SystemColors.Control Then
            BtnAo1C.BackColor = SystemColors.Control
            BtnAo1C.ForeColor = Color.Black
        Else
            ' Nyalakan 1C, matikan yang di kanannya
            BtnAo1C.BackColor = Color.Blue : BtnAo1C.ForeColor = Color.White

            BtnAo2C.BackColor = SystemColors.Control : BtnAo2C.ForeColor = Color.Black
            BtnAo3C.BackColor = SystemColors.Control : BtnAo3C.ForeColor = Color.Black
            BtnAoHC.BackColor = SystemColors.Control : BtnAoHC.ForeColor = Color.Black
            BtnAoH.BackColor = SystemColors.Control : BtnAoH.ForeColor = Color.Black
        End If
    End Sub

    Private Sub BtnAo2C_Click(sender As Object, e As EventArgs) Handles BtnAo2C.Click
        ' Nyalakan 1C & 2C
        BtnAo1C.BackColor = Color.Blue : BtnAo1C.ForeColor = Color.White
        BtnAo2C.BackColor = Color.Blue : BtnAo2C.ForeColor = Color.White

        ' Matikan yang di kanannya (3C, HC, H kembali seperti semula)
        BtnAo3C.BackColor = SystemColors.Control : BtnAo3C.ForeColor = Color.Black
        BtnAoHC.BackColor = SystemColors.Control : BtnAoHC.ForeColor = Color.Black
        BtnAoH.BackColor = SystemColors.Control : BtnAoH.ForeColor = Color.Black
    End Sub

    Private Sub BtnAo3C_Click(sender As Object, e As EventArgs) Handles BtnAo3C.Click
        ' Nyalakan 1C, 2C, 3C
        BtnAo1C.BackColor = Color.Blue : BtnAo1C.ForeColor = Color.White
        BtnAo2C.BackColor = Color.Blue : BtnAo2C.ForeColor = Color.White
        BtnAo3C.BackColor = Color.Blue : BtnAo3C.ForeColor = Color.White

        ' Matikan yang di kanannya
        BtnAoHC.BackColor = SystemColors.Control : BtnAoHC.ForeColor = Color.Black
        BtnAoH.BackColor = SystemColors.Control : BtnAoH.ForeColor = Color.Black
    End Sub

    Private Sub BtnAoHC_Click(sender As Object, e As EventArgs) Handles BtnAoHC.Click
        ' Nyalakan 1C, 2C, 3C, HC
        BtnAo1C.BackColor = Color.Blue : BtnAo1C.ForeColor = Color.White
        BtnAo2C.BackColor = Color.Blue : BtnAo2C.ForeColor = Color.White
        BtnAo3C.BackColor = Color.Blue : BtnAo3C.ForeColor = Color.White
        BtnAoHC.BackColor = Color.Blue : BtnAoHC.ForeColor = Color.White

        ' Matikan yang di kanannya
        BtnAoH.BackColor = SystemColors.Control : BtnAoH.ForeColor = Color.Black
    End Sub

    Private Sub BtnAoH_Click(sender As Object, e As EventArgs) Handles BtnAoH.Click
        ' Nyalakan Semua
        BtnAo1C.BackColor = Color.Blue : BtnAo1C.ForeColor = Color.White
        BtnAo2C.BackColor = Color.Blue : BtnAo2C.ForeColor = Color.White
        BtnAo3C.BackColor = Color.Blue : BtnAo3C.ForeColor = Color.White
        BtnAoHC.BackColor = Color.Blue : BtnAoHC.ForeColor = Color.White
        BtnAoH.BackColor = Color.Blue : BtnAoH.ForeColor = Color.White

        ShowAkaWinner() ' Jika Ao Hansoku, maka Aka Menang
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

        ' Jika ada tim yang dipilih, isi ke text box AO
        If frmTeam.SelectedTeamName <> "" Then
            TxtAoTeam.Text = frmTeam.SelectedTeamName
            TxtAoTeamInfo.Text = frmTeam.SelectedTeamInfo
        End If
    End Sub

    ' ==================== AKA SEARCH TEAM ====================
    Private Sub BtnAkaSearch2_Click(sender As Object, e As EventArgs) Handles BtnAkaSearch2.Click
        Dim frmTeam As New ListofTeam()
        frmTeam.ShowDialog()

        ' Jika ada tim yang dipilih, isi ke text box AKA
        If frmTeam.SelectedTeamName <> "" Then
            TxtAkaTeam.Text = frmTeam.SelectedTeamName
            TxtAkaTeamInfo.Text = frmTeam.SelectedTeamInfo
        End If
    End Sub

    ' ==================== HELPER FUNCTIONS ====================
    Private Sub ShowAoWinner()
        Dim winnerName As String = TxtAoNameMain.Text
        Dim teamName As String = TxtAoTeam.Text
        Dim teamInfo As String = TxtAoTeamInfo.Text

        If String.IsNullOrEmpty(winnerName) Then
            MessageBox.Show("Pilih peserta terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Tampilkan form winner
        ' Anda bisa membuat form khusus atau menampilkan message box yang lebih menarik
        MessageBox.Show("PEMENANG:" & vbCrLf & winnerName & vbCrLf & teamName & vbCrLf & teamInfo, "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowAkaWinner()
        Dim winnerName As String = TxtAkaNameMain.Text
        Dim teamName As String = TxtAkaTeam.Text
        Dim teamInfo As String = TxtAkaTeamInfo.Text

        If String.IsNullOrEmpty(winnerName) Then
            MessageBox.Show("Pilih peserta terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        MessageBox.Show("PEMENANG:" & vbCrLf & winnerName & vbCrLf & teamName & vbCrLf & teamInfo, "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowKnockedOutCountdown()
        ' Tampilkan form Knocked Out dengan countdown 09 detik
        MessageBox.Show("Knocked Out Countdown: 09", "Knocked Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

        ' Panggil fungsi cek selisih skor setiap ada update
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
    End Sub
End Class