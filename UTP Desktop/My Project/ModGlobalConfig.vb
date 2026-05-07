Public Module ModGlobalConfig
    Public ShortcutSettings As New Dictionary(Of String, String)
    Public IsShortcutEnabled As Boolean = True

    ' FLAG: Sangat penting agar Form Kumite tahu kapan harus refresh data
    Public NeedRefreshSettings As Boolean = False

    Public Sub InitDefaultShortcuts()
        ' Jangan isi ulang jika sudah ada datanya
        If ShortcutSettings.Count > 0 Then Exit Sub

        ' Pastikan Nama Aksi (Key) di sini sama dengan yang ada di Kumite.vb
        ShortcutSettings("Start-Close Scoreboard") = "Control+B"
        ShortcutSettings("Match Timer Start-Stop") = "Space"
        ShortcutSettings("Match Timer Reset") = "Control+R"

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