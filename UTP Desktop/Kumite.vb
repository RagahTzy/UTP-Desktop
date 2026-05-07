Public Class Kumite
    ' Variabel lokal untuk menyimpan shortcut agar tidak terus-menerus memanggil Module
    Private localShortcuts As New Dictionary(Of String, String)

    ' ==================== Load Form ====================
    Private Sub Kumite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. PENTING: Harus True agar form bisa menangkap tombol keyboard
        Me.KeyPreview = True

        ' 2. Inisialisasi data default ke Module
        ModGlobalConfig.InitDefaultShortcuts()

        ' 3. Ambil data shortcut dari Module ke variabel lokal
        RefreshLocalSettings()
    End Sub

    ' Fungsi untuk menyegarkan data shortcut di Form Kumite jika ada perubahan di Form Shortcut
    Private Sub RefreshLocalSettings()
        localShortcuts.Clear()
        For Each kvp In ModGlobalConfig.ShortcutSettings
            localShortcuts.Add(kvp.Key, kvp.Value)
        Next
        ModGlobalConfig.NeedRefreshSettings = False
    End Sub

    ' ==================== MESIN PENDENGAR KEYBOARD (SHORTCUT) ====================
    Private Sub Kumite_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' CEK: Jika user baru saja mengubah shortcut di form sebelah, update datanya di sini
        If ModGlobalConfig.NeedRefreshSettings Then RefreshLocalSettings()

        ' 1. Cek apakah shortcut sedang aktif (ON/OFF)
        If ModGlobalConfig.IsShortcutEnabled = False Then Exit Sub

        ' 2. Susun kombinasi tombol yang ditekan
        Dim pressedKey As String = ""
        If e.Control Then pressedKey &= "Control+"
        If e.Shift Then pressedKey &= "Shift+"
        If e.Alt Then pressedKey &= "Alt+"
        pressedKey &= e.KeyCode.ToString()

        ' 3. Cari aksi yang sesuai di Dictionary lokal
        For Each kvp In localShortcuts
            If kvp.Value = pressedKey Then
                ' Hentikan fungsi asli tombol agar tidak bentrok dengan kontrol UI
                e.SuppressKeyPress = True
                e.Handled = True

                ' Jalankan fungsi berdasarkan nama aksi
                EksekusiAksiShortcut(kvp.Key)
                Exit For
            End If
        Next
    End Sub

    ' ==================== LOGIKA EKSEKUSI AKSI ====================
    ' Sesuaikan .PerformClick() dengan nama Name (ID) Button di desain form Anda
    Private Sub EksekusiAksiShortcut(namaAksi As String)
        Select Case namaAksi
            ' --- Kelompok AKA (Merah) ---
            Case "AKA - Yuko(1)"
                ' Contoh: BtnAkaYuko1.PerformClick()

            Case "AKA - Wazaari(2)"
                ' Contoh: BtnAkaWazaari2.PerformClick()

            Case "AKA - Ippon(3)"
                ' Contoh: BtnAkaIppon3.PerformClick()

            Case "AKA - SENSHU"
                ' Contoh: BtnAkaSenshu.PerformClick()

            ' --- Kelompok AO (Biru) ---
            Case "AO - Yuko(1)"
                ' Contoh: BtnAoYuko1.PerformClick()

            Case "AO - Wazaari(2)"
                ' Contoh: BtnAoWazaari2.PerformClick()

            Case "AO - Ippon(3)"
                ' Contoh: BtnAoIppon3.PerformClick()

            Case "AO - SENSHU"
                ' Contoh: BtnAoSenshu.PerformClick()

            ' --- Kelompok General ---
            Case "Match Timer Start-Stop"
                ' Contoh: BtnStartStopTimer.PerformClick()

            Case "Match Timer Reset"
                ' Contoh: BtnResetTimer.PerformClick()

            Case "Start-Close Scoreboard"
                ' Contoh: BtnDisplayScore.PerformClick()

            Case "Next Match"
                ' Contoh: BtnNextMatch.PerformClick()

            Case "Save Match Result"
                ' Contoh: BtnSaveMatch.PerformClick()

            Case "Show Winner"
                ' Contoh: BtnWinnerInfo.PerformClick()
        End Select
    End Sub

    ' ==================== Tombol Navigasi & Jendela Lain ====================

    Private Sub OpenCompetitor_Click(sender As Object, e As EventArgs) Handles BtnAkaIcon.Click, BtnAoIcon.Click, BtnAkaUserIcon1.Click, BtnAoUserIcon1.Click
        Dim frmCompetitor As New ListOfCompetitor()
        frmCompetitor.ShowDialog()
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

    Private Sub BtnHantei_Click(sender As Object, e As EventArgs) Handles BtnHantei.Click
        Dim frmDecision As New ManualDecision()
        frmDecision.ShowDialog()
    End Sub

    Private Sub Kumite_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Show()
    End Sub

End Class