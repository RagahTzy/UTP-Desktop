Public Module ModGlobalConfig
    ' 1. Dictionary untuk menyimpan daftar shortcut (Aksi -> Tombol)
    Public ShortcutSettings As New Dictionary(Of String, String)

    ' 2. Status ON/OFF shortcut secara global
    Public IsShortcutEnabled As Boolean = True

    ' 3. FLAG TERBARU: Untuk memberi tahu Form Kumite bahwa ada perubahan data
    ' (PENTING agar sinkronisasi real-time jalan)
    Public NeedRefreshSettings As Boolean = False

    ''' <summary>
    ''' Mengisi data default saat aplikasi pertama kali dijalankan
    ''' </summary>
    Public Sub InitDefaultShortcuts()
        ' Jangan isi ulang jika sudah ada datanya agar settingan user tidak tertimpa default
        If ShortcutSettings.Count > 0 Then Exit Sub

        ' Daftar Shortcut Standar (Sesuaikan teks ini dengan isiDataShortcut di Shortcut.vb)
        ShortcutSettings("Start-Close Scoreboard") = "Control+B"
        ShortcutSettings("Timer Waiting Start-Stop") = "Control+W"
        ShortcutSettings("Match Timer Start-Stop") = "Space"
        ShortcutSettings("Next Match") = "Control+N"
        ShortcutSettings("Save Match Result") = "Control+S"
        ShortcutSettings("Match Timer Reset") = "Control+R"
        ShortcutSettings("Show Winner") = "Control+E"

        ' AKA Group
        ShortcutSettings("AKA - Yuko(1)") = "Shift+A"
        ShortcutSettings("AKA - Wazaari(2)") = "Shift+S"
        ShortcutSettings("AKA - Ippon(3)") = "Shift+D"
        ShortcutSettings("AKA - SENSHU") = "Shift+Q"

        ' AO Group
        ShortcutSettings("AO - Yuko(1)") = "Shift+J"
        ShortcutSettings("AO - Wazaari(2)") = "Shift+K"
        ShortcutSettings("AO - Ippon(3)") = "Shift+L"
        ShortcutSettings("AO - SENSHU") = "Shift+P"
    End Sub
End Module