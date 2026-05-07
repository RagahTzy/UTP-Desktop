Public Class Kumite
    ' ==================== TAMBAHAN UNTUK SHORTCUT ====================
    ' Variabel lokal untuk menyimpan shortcut agar tidak terus-menerus memanggil Module
    Private localShortcuts As New Dictionary(Of String, String)

    ' Fungsi untuk menyegarkan data shortcut di Form Kumite jika ada perubahan di Form Shortcut
    Private Sub RefreshLocalSettings()
        localShortcuts.Clear()
        For Each kvp In ModGlobalConfig.ShortcutSettings
            localShortcuts.Add(kvp.Key, kvp.Value)
        Next
        ModGlobalConfig.NeedRefreshSettings = False
    End Sub

    ' Mesin Pendengar Keyboard
    Private Sub Kumite_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Cek apakah perlu refresh setting
        If ModGlobalConfig.NeedRefreshSettings Then RefreshLocalSettings()

        ' Cek apakah shortcut ON
        If ModGlobalConfig.IsShortcutEnabled = False Then Exit Sub

        ' Susun kombinasi tombol
        Dim pressedKey As String = ""
        If e.Control Then pressedKey &= "Control+"
        If e.Shift Then pressedKey &= "Shift+"
        If e.Alt Then pressedKey &= "Alt+"
        pressedKey &= e.KeyCode.ToString()

        ' Cari aksi yang sesuai
        For Each kvp In localShortcuts
            If kvp.Value = pressedKey Then
                e.SuppressKeyPress = True
                e.Handled = True
                EksekusiAksiShortcut(kvp.Key)
                Exit For
            End If
        Next
    End Sub

    ' Logika Eksekusi (Menghubungkan Nama di Shortcut ke Tombol Asli)
    Private Sub EksekusiAksiShortcut(namaAksi As String)
        Select Case namaAksi
            Case "Start-Close Scoreboard"
                BtnStartScoreboard.PerformClick()
            Case "Match Timer Start-Stop"
                ' Tambahkan tombol timer kamu di sini jika sudah ada
            Case "Match Timer Reset"
                ' Tambahkan tombol reset timer kamu di sini jika sudah ada
            Case "AKA - Yuko(1)"
                BtnAkaYuko.PerformClick()
            Case "AKA - Wazaari(2)"
                BtnAkaWazaari.PerformClick()
            Case "AKA - Ippon(3)"
                BtnAkaIppon.PerformClick()
            Case "AKA - SENSHU"
                BtnAkaSenshu.PerformClick()
            Case "AO - Yuko(1)"
                BtnAoYuko.PerformClick()
            Case "AO - Wazaari(2)"
                BtnAoWazaari.PerformClick()
            Case "AO - Ippon(3)"
                BtnAoIppon.PerformClick()
            Case "AO - SENSHU"
                BtnAoSenshu.PerformClick()
        End Select
    End Sub
    ' ==================== END SHORTCUT SECTION ====================


    ' ==================== Load Form ====================
    Private Sub Kumite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. PENTING: Harus True agar form bisa menangkap tombol keyboard
        Me.KeyPreview = True

        ' 2. Inisialisasi data default ke Module
        ModGlobalConfig.InitDefaultShortcuts()

        ' 3. Ambil data shortcut dari Module ke variabel lokal
        RefreshLocalSettings()
    End Sub


    ' ==================== Tombol Navigasi & Jendela Lain ====================

    Public Shared AkaPenaltyColor As Color = Color.Red
    Public frmScoreboard As Scoreboard

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

    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click
        Dim frmSettings As New FrmScoreboardSetting()
        frmSettings.ShowDialog()
    End Sub

    Private Sub BtnLogActivity_Click(sender As Object, e As EventArgs) Handles BtnLogActivity.Click
        Dim frmLog As New Log_Activity()
        frmLog.ShowDialog()
    End Sub

    Private Sub BtnShortcut_Click(sender As Object, e As EventArgs) Handles BtnShortcut.Click
        ' Membuka pengaturan shortcut
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
    '                                 AKA SECTION
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
    ' BtnAka1C → hanya 1C terwarna
    Private Sub BtnAka1C_Click(sender As Object, e As EventArgs) Handles BtnAka1C.Click
        If BtnAka1C.BackColor = AkaPenaltyColor And BtnAka2C.BackColor = SystemColors.Control Then
            ' Toggle off jika sudah terwarna sendirian
            BtnAka1C.BackColor = SystemColors.Control
            BtnAka1C.ForeColor = Color.Black
        Else
            BtnAka1C.BackColor = AkaPenaltyColor
            BtnAka1C.ForeColor = Color.White
            BtnAka2C.BackColor = SystemColors.Control
            BtnAka2C.ForeColor = Color.Black
            BtnAka3C.BackColor = SystemColors.Control
            BtnAka3C.ForeColor = Color.Black
            BtnAkaHC.BackColor = SystemColors.Control
            BtnAkaHC.ForeColor = Color.Black
            BtnAkaH.BackColor = SystemColors.Control
            BtnAkaH.ForeColor = Color.Black
        End If
    End Sub

    ' Lakukan hal yang sama untuk tombol lainnya:
    Private Sub BtnAka2C_Click(sender As Object, e As EventArgs) Handles BtnAka2C.Click
        BtnAka1C.BackColor = AkaPenaltyColor
        BtnAka1C.ForeColor = Color.White
        BtnAka2C.BackColor = AkaPenaltyColor
        BtnAka2C.ForeColor = Color.White
        BtnAka3C.BackColor = SystemColors.Control
        BtnAka3C.ForeColor = Color.Black
        BtnAkaHC.BackColor = SystemColors.Control
        BtnAkaHC.ForeColor = Color.Black
        BtnAkaH.BackColor = SystemColors.Control
        BtnAkaH.ForeColor = Color.Black
    End Sub

    Private Sub BtnAka3C_Click(sender As Object, e As EventArgs) Handles BtnAka3C.Click
        BtnAka1C.BackColor = AkaPenaltyColor
        BtnAka1C.ForeColor = Color.White
        BtnAka2C.BackColor = AkaPenaltyColor
        BtnAka2C.ForeColor = Color.White
        BtnAka3C.BackColor = AkaPenaltyColor
        BtnAka3C.ForeColor = Color.White
        BtnAkaHC.BackColor = SystemColors.Control
        BtnAkaHC.ForeColor = Color.Black
        BtnAkaH.BackColor = SystemColors.Control
        BtnAkaH.ForeColor = Color.Black
    End Sub

    Private Sub BtnAkaHC_Click(sender As Object, e As EventArgs) Handles BtnAkaHC.Click
        BtnAka1C.BackColor = AkaPenaltyColor
        BtnAka1C.ForeColor = Color.White
        BtnAka2C.BackColor = AkaPenaltyColor
        BtnAka2C.ForeColor = Color.White
        BtnAka3C.BackColor = AkaPenaltyColor
        BtnAka3C.ForeColor = Color.White
        BtnAkaHC.BackColor = AkaPenaltyColor
        BtnAkaHC.ForeColor = Color.White
        BtnAkaH.BackColor = SystemColors.Control
        BtnAkaH.ForeColor = Color.Black
    End Sub

    Private Sub BtnAkaH_Click(sender As Object, e As EventArgs) Handles BtnAkaH.Click
        BtnAka1C.BackColor = AkaPenaltyColor
        BtnAka1C.ForeColor = Color.White
        BtnAka2C.BackColor = AkaPenaltyColor
        BtnAka2C.ForeColor = Color.White
        BtnAka3C.BackColor = AkaPenaltyColor
        BtnAka3C.ForeColor = Color.White
        BtnAkaHC.BackColor = AkaPenaltyColor
        BtnAkaHC.ForeColor = Color.White
        BtnAkaH.BackColor = AkaPenaltyColor
        BtnAkaH.ForeColor = Color.White
        ShowAoWinner()
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
    '                                 AO SECTION
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
            BtnAo1C.BackColor = Color.Blue
            BtnAo1C.ForeColor = Color.White
            BtnAo2C.BackColor = SystemColors.Control
            BtnAo2C.ForeColor = Color.Black
            BtnAo3C.BackColor = SystemColors.Control
            BtnAo3C.ForeColor = Color.Black
            BtnAoHC.BackColor = SystemColors.Control
            BtnAoHC.ForeColor = Color.Black
            BtnAoH.BackColor = SystemColors.Control
            BtnAoH.ForeColor = Color.Black
        End If
    End Sub

    Private Sub BtnAo2C_Click(sender As Object, e As EventArgs) Handles BtnAo2C.Click
        BtnAo1C.BackColor = Color.Blue
        BtnAo1C.ForeColor = Color.White
        BtnAo2C.BackColor = Color.Blue
        BtnAo2C.ForeColor = Color.White
        BtnAo3C.BackColor = SystemColors.Control
        BtnAo3C.ForeColor = Color.Black
        BtnAoHC.BackColor = SystemColors.Control
        BtnAoHC.ForeColor = Color.Black
        BtnAoH.BackColor = SystemColors.Control
        BtnAoH.ForeColor = Color.Black
    End Sub

    Private Sub BtnAo3C_Click(sender As Object, e As EventArgs) Handles BtnAo3C.Click
        BtnAo1C.BackColor = Color.Blue
        BtnAo1C.ForeColor = Color.White
        BtnAo2C.BackColor = Color.Blue
        BtnAo2C.ForeColor = Color.White
        BtnAo3C.BackColor = Color.Blue
        BtnAo3C.ForeColor = Color.White
        BtnAoHC.BackColor = SystemColors.Control
        BtnAoHC.ForeColor = Color.Black
        BtnAoH.BackColor = SystemColors.Control
        BtnAoH.ForeColor = Color.Black
    End Sub

    Private Sub BtnAoHC_Click(sender As Object, e As EventArgs) Handles BtnAoHC.Click
        BtnAo1C.BackColor = Color.Blue
        BtnAo1C.ForeColor = Color.White
        BtnAo2C.BackColor = Color.Blue
        BtnAo2C.ForeColor = Color.White
        BtnAo3C.BackColor = Color.Blue
        BtnAo3C.ForeColor = Color.White
        BtnAoHC.BackColor = Color.Blue
        BtnAoHC.ForeColor = Color.White
        BtnAoH.BackColor = SystemColors.Control
        BtnAoH.ForeColor = Color.Black
    End Sub

    Private Sub BtnAoH_Click(sender As Object, e As EventArgs) Handles BtnAoH.Click
        BtnAo1C.BackColor = Color.Blue
        BtnAo1C.ForeColor = Color.White
        BtnAo2C.BackColor = Color.Blue
        BtnAo2C.ForeColor = Color.White
        BtnAo3C.BackColor = Color.Blue
        BtnAo3C.ForeColor = Color.White
        BtnAoHC.BackColor = Color.Blue
        BtnAoHC.ForeColor = Color.White
        BtnAoH.BackColor = Color.Blue
        BtnAoH.ForeColor = Color.White
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
    '                               HELPER / SHARED FUNCTIONS
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

    Private Sub BtnStartScoreboard_Click(sender As Object, e As EventArgs) Handles BtnStartScoreboard.Click
        ' Jika form scoreboard belum ada atau tidak sengaja tertutup, buat baru
        If frmScoreboard Is Nothing OrElse frmScoreboard.IsDisposed Then
            frmScoreboard = New Scoreboard()
        End If

        ' Logika Deteksi Monitor Kedua (Projector / TV)
        If Screen.AllScreens.Length > 1 Then
            ' Ambil data monitor kedua (index 1)
            Dim secondMonitor As Screen = Screen.AllScreens(1)

            ' Tampilkan di monitor kedua secara Full Screen
            frmScoreboard.StartPosition = FormStartPosition.Manual
            frmScoreboard.Location = secondMonitor.Bounds.Location
            frmScoreboard.WindowState = FormWindowState.Maximized
        Else
            ' Jika sedang tidak colok proyektor/monitor kedua, tampilkan di layar utama
            frmScoreboard.StartPosition = FormStartPosition.CenterScreen
            frmScoreboard.WindowState = FormWindowState.Maximized
        End If

        ' Tampilkan form ke layar
        frmScoreboard.Show()

        ' Panggil fungsi untuk langsung mengirim data nama & skor ke layar extend
        UpdateScoreboardDisplay()
    End Sub

    ' ==================== SINKRONISASI DATA KE TAMPILAN EXTEND ====================
    Public Sub UpdateScoreboardDisplay()
        If frmScoreboard IsNot Nothing AndAlso Not frmScoreboard.IsDisposed Then
            ' 1. Kirim Data Nama Pemain + Tim + Info Tim (Menjadi 2 Baris)
            frmScoreboard.LblAkaName.Text = TxtAkaNameMain.Text & vbCrLf & TxtAkaTeam.Text & " (" & TxtAkaTeamInfo.Text & ")"
            frmScoreboard.LblAoName.Text = TxtAoNameMain.Text & vbCrLf & TxtAoTeam.Text & " (" & TxtAoTeamInfo.Text & ")"

            ' Sesuaikan font sedikit agar 2 baris teks muat dengan rapi
            frmScoreboard.LblAkaName.Font = New Font("Consolas", 24, FontStyle.Bold)
            frmScoreboard.LblAoName.Font = New Font("Consolas", 24, FontStyle.Bold)

            ' 2. Kirim Data Skor & Footer Info
            frmScoreboard.LblAkaScore.Text = LblAkaMainScore.Text
            frmScoreboard.LblAoScore.Text = LblAoMainScore.Text
            frmScoreboard.LblTimer.Text = LblMatchTimerValue.Text
            frmScoreboard.LblTatami.Text = "TATAMI" & vbCrLf & NumTatami.Value.ToString()
            frmScoreboard.LblMatchDesc.Text = TxtMatchDesc.Text

            ' 3. Sinkronisasi Warna Penalti
            UpdateScoreboardPenalties()
        End If
    End Sub

    ' Fungsi Khusus Mendeteksi Warna Penalti
    Public Sub UpdateScoreboardPenalties()
        If frmScoreboard IsNot Nothing AndAlso Not frmScoreboard.IsDisposed Then
            ' Urutan tombol dari Kumite.vb
            Dim akaBtns = {BtnAka1C, BtnAka2C, BtnAka3C, BtnAkaHC, BtnAkaH}
            Dim aoBtns = {BtnAo1C, BtnAo2C, BtnAo3C, BtnAoHC, BtnAoH}

            For i = 0 To 4
                ' ================== LOGIKA AKA ==================
                If akaBtns(i).BackColor = AkaPenaltyColor Then
                    frmScoreboard.AkaPenLabels(i).BackColor = AkaPenaltyColor
                    frmScoreboard.AkaPenLabels(i).ForeColor = Color.White
                Else
                    frmScoreboard.AkaPenLabels(i).BackColor = Color.Transparent
                    frmScoreboard.AkaPenLabels(i).ForeColor = Color.LightGray
                End If

                ' ================== LOGIKA AO ==================
                If aoBtns(i).BackColor = Color.Blue Then
                    frmScoreboard.AoPenLabels(i).BackColor = Color.Blue
                    frmScoreboard.AoPenLabels(i).ForeColor = Color.White
                Else
                    frmScoreboard.AoPenLabels(i).BackColor = Color.Transparent
                    frmScoreboard.AoPenLabels(i).ForeColor = Color.LightGray
                End If
            Next
        End If
    End Sub

    ' ==================== FUNGSI "LIVE" LISTENER (TRIGGER OTOMATIS) ====================

    ' 1. Otomatis ter-update jika Anda MENGUBAH TEKS apapun di UI
    Private Sub SyncTextToExtend_Live(sender As Object, e As EventArgs) Handles TxtAkaNameMain.TextChanged, TxtAkaTeam.TextChanged, TxtAkaTeamInfo.TextChanged, TxtAoNameMain.TextChanged, TxtAoTeam.TextChanged, TxtAoTeamInfo.TextChanged, TxtMatchDesc.TextChanged
        UpdateScoreboardDisplay()
    End Sub

    ' 2. Otomatis ter-update jika SKOR BERTAMBAH/BERKURANG
    Private Sub SyncScoreToExtend_Live(sender As Object, e As EventArgs) Handles LblAkaMainScore.TextChanged, LblAoMainScore.TextChanged
        UpdateScoreboardDisplay()
    End Sub

    ' 3. Otomatis ter-update jika TIMER BERUBAH DETIKNYA
    Private Sub SyncTimerToExtend_Live(sender As Object, e As EventArgs) Handles LblMatchTimerValue.TextChanged
        If frmScoreboard IsNot Nothing AndAlso Not frmScoreboard.IsDisposed Then
            frmScoreboard.LblTimer.Text = LblMatchTimerValue.Text
        End If
    End Sub

    ' 4. Otomatis ter-update HANYA SAAT WARNA TOMBOL PENALTI DIKLIK
    Private Sub SyncPenaltyToExtend_Live(sender As Object, e As EventArgs) Handles BtnAka1C.BackColorChanged, BtnAka2C.BackColorChanged, BtnAka3C.BackColorChanged, BtnAkaHC.BackColorChanged, BtnAkaH.BackColorChanged, BtnAo1C.BackColorChanged, BtnAo2C.BackColorChanged, BtnAo3C.BackColorChanged, BtnAoHC.BackColorChanged, BtnAoH.BackColorChanged
        UpdateScoreboardPenalties()
    End Sub

    ' ==================== HENTIKAN/TUTUP SCOREBOARD ====================
    Private Sub StopScoreboard_Click(sender As Object, e As EventArgs) Handles StopScoreboard.Click
        ' Cek apakah form scoreboard sedang aktif/terbuka
        If frmScoreboard IsNot Nothing AndAlso Not frmScoreboard.IsDisposed Then
            frmScoreboard.Close()     ' Tutup jendela extend scoreboard
            frmScoreboard = Nothing   ' Kosongkan variabel dari memori
            MessageBox.Show("Scoreboard Extend telah dihentikan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Scoreboard Extend sedang tidak berjalan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class