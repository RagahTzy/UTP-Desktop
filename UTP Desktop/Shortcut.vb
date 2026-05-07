Public Class Shortcut
    ' Variabel untuk menandai kita sedang merekam tombol keyboard
    Private isRecording As Boolean = False
    Private isShortcutActive As Boolean = True ' Status ON/OFF lokal

    Private Sub Shortcut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.KeyPreview = True ' Penting agar KeyDown form berfungsi

        ' Ambil status terakhir dari GlobalConfig agar tampilan Toggle sinkron
        isShortcutActive = ModGlobalConfig.IsShortcutEnabled
        UpdateToggleUI()

        If lvShortcuts IsNot Nothing Then
            lvShortcuts.OwnerDraw = True
            isiDataShortcut()

            ' Ambil data yang sudah tersimpan di GlobalConfig (jika ada) 
            ' agar ListView menampilkan shortcut yang sedang aktif saat ini
            MuatDariGlobalConfig()
        End If
    End Sub

    ' --- FUNGSI: MENGIRIM DATA KE MODULE ---
    Private Sub SimpanKeGlobalConfig()
        ModGlobalConfig.ShortcutSettings.Clear()
        For Each item As ListViewItem In lvShortcuts.Items
            Dim aksi As String = item.Text
            Dim tombol As String = item.SubItems(1).Text
            If tombol <> "None" Then
                ModGlobalConfig.ShortcutSettings(aksi) = tombol
            End If
        Next
        ModGlobalConfig.IsShortcutEnabled = isShortcutActive

        ' Signal ke form lain (Kumite) bahwa pengaturan telah berubah
        ModGlobalConfig.NeedRefreshSettings = True
    End Sub

    ' --- FUNGSI: MEMBACA DATA DARI MODULE KE LISTVIEW ---
    Private Sub MuatDariGlobalConfig()
        ' Jika module kosong, gunakan default dari isiDataShortcut()
        If ModGlobalConfig.ShortcutSettings.Count = 0 Then Exit Sub

        For Each item As ListViewItem In lvShortcuts.Items
            If ModGlobalConfig.ShortcutSettings.ContainsKey(item.Text) Then
                item.SubItems(1).Text = ModGlobalConfig.ShortcutSettings(item.Text)
            End If
        Next
    End Sub

    ' --- FUNGSI UTAMA: MENDETEKSI TOMBOL KEYBOARD ---
    Private Sub Shortcut_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If isRecording Then
            ' Abaikan jika hanya menekan tombol Modifier saja (Ctrl, Shift, Alt)
            If e.KeyCode = Keys.ControlKey Or e.KeyCode = Keys.ShiftKey Or e.KeyCode = Keys.Menu Then
                Exit Sub
            End If

            ' Stop tombol agar tidak menjalankan fungsi bawaan windows (misal Alt+F4)
            e.SuppressKeyPress = True

            Dim strShortcut As String = ""
            If e.Control Then strShortcut &= "Control+"
            If e.Shift Then strShortcut &= "Shift+"
            If e.Alt Then strShortcut &= "Alt+"
            strShortcut &= e.KeyCode.ToString()

            If lvShortcuts.SelectedItems.Count > 0 Then
                lvShortcuts.SelectedItems(0).SubItems(1).Text = strShortcut

                ' Reset State setelah merekam berhasil
                isRecording = False
                txtCurrentAction.Text = lvShortcuts.SelectedItems(0).Text
                txtCurrentAction.ForeColor = Color.Black
                btnChange.Enabled = True
                btnSave.Enabled = True
                btnSave.ForeColor = Color.Black
                lvShortcuts.Enabled = True

                ' Kembalikan fokus ke form agar tidak nyangkut di kontrol lain
                Me.Focus()
            End If
        End If
    End Sub

    ' --- LOGIKA TOMBOL CHANGE ---
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        If lvShortcuts.SelectedItems.Count > 0 Then
            isRecording = True
            txtCurrentAction.Text = ">>> SEKARANG TEKAN TOMBOL DI KEYBOARD ANDA... <<<"
            txtCurrentAction.ForeColor = Color.Red
            btnChange.Enabled = False
            lvShortcuts.Enabled = False

            ' Menghilangkan fokus dari tombol agar KeyDown form lebih responsif
            Me.ActiveControl = Nothing
        Else
            MessageBox.Show("Pilih salah satu item di tabel terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' --- LOGIKA TOMBOL REMOVE ---
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lvShortcuts.SelectedItems.Count > 0 Then
            lvShortcuts.SelectedItems(0).SubItems(1).Text = "None"
            btnSave.Enabled = True
            btnSave.ForeColor = Color.Black
        Else
            MessageBox.Show("Pilih action yang ingin dihapus shortcut-nya!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' --- LOGIKA TOMBOL SAVE ---
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SimpanKeGlobalConfig()
        MessageBox.Show("Pengaturan shortcut berhasil diterapkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        btnSave.Enabled = False
        btnSave.ForeColor = Color.DarkGray
        ' Disarankan menutup form setelah save agar fokus kembali ke Scoreboard
        Me.Close()
    End Sub

    ' --- LOGIKA TOMBOL TOGGLE ON/OFF ---
    Private Sub btnToggle_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        isShortcutActive = Not isShortcutActive
        UpdateToggleUI()

        ' Langsung update status global agar form Kumite tahu status terbaru
        ModGlobalConfig.IsShortcutEnabled = isShortcutActive
        ModGlobalConfig.NeedRefreshSettings = True
    End Sub

    Private Sub UpdateToggleUI()
        If isShortcutActive Then
            lblStatusValue.Text = "ON"
            lblStatusValue.ForeColor = Color.FromArgb(0, 192, 239)
            lblTurnOff.Text = "Turn off"
            btnToggle.BackColor = Color.FromArgb(0, 120, 215)
            btnToggle.TextAlign = ContentAlignment.MiddleRight
        Else
            lblStatusValue.Text = "OFF"
            lblStatusValue.ForeColor = Color.Gray
            lblTurnOff.Text = "Turn on"
            btnToggle.BackColor = Color.DarkGray
            btnToggle.TextAlign = ContentAlignment.MiddleLeft
        End If
    End Sub

    ' --- LOGIKA TOMBOL RESET ---
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim confirm = MessageBox.Show("Yakin ingin mereset ke default?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            isiDataShortcut()
            ' Otomatis simpan ke global setelah reset
            SimpanKeGlobalConfig()
            btnSave.Enabled = False
            btnSave.ForeColor = Color.DarkGray
        End If
    End Sub

    ' --- DATA DEFAULT ---
    Private Sub isiDataShortcut()
        If lvShortcuts Is Nothing Then Exit Sub
        lvShortcuts.Items.Clear()
        ' Daftar aksi standar Karate/Kumite
        tambahItem("Start-Close Scoreboard", "Control+B")
        tambahItem("Timer Waiting Start-Stop", "Control+W")
        tambahItem("Match Timer Start-Stop", "Space")
        tambahItem("Next Match", "Control+N")
        tambahItem("Save Match Result", "Control+S")
        tambahItem("Match Timer Reset", "Control+R")
        tambahItem("Show Winner", "Control+E")
        ' AKA Group
        tambahItem("AKA - Yuko(1)", "Shift+A")
        tambahItem("AKA - Wazaari(2)", "Shift+S")
        tambahItem("AKA - Ippon(3)", "Shift+D")
        tambahItem("AKA - SENSHU", "Shift+Q")
        ' AO Group
        tambahItem("AO - Yuko(1)", "Shift+J")
        tambahItem("AO - Wazaari(2)", "Shift+K")
        tambahItem("AO - Ippon(3)", "Shift+L")
        tambahItem("AO - SENSHU", "Shift+P")
    End Sub

    Private Sub tambahItem(action As String, shortcut As String)
        Dim lvi As New ListViewItem(action)
        lvi.SubItems.Add(shortcut)
        lvShortcuts.Items.Add(lvi)
    End Sub

    ' --- CUSTOM DRAWING (ListView UI) ---
    Private Sub lvShortcuts_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles lvShortcuts.DrawColumnHeader
        e.DrawDefault = True
    End Sub

    Private Sub lvShortcuts_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles lvShortcuts.DrawSubItem
        If e.Item Is Nothing Then Exit Sub

        ' Background highlight untuk baris terpilih
        If e.Item.Selected Then
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(135, 206, 250)), e.Bounds)
        Else
            e.Graphics.FillRectangle(Brushes.White, e.Bounds)
        End If

        ' Pewarnaan teks (Merah untuk AKA, Biru untuk AO)
        Dim textColor As Color = Color.Black
        If Not String.IsNullOrEmpty(e.Item.Text) Then
            If e.Item.Text.Contains("AKA") Then textColor = Color.Red
            If e.Item.Text.Contains("AO") Then textColor = Color.Blue
        End If

        ' Kolom shortcut selalu hitam agar mudah dibaca
        If e.ColumnIndex = 1 Then textColor = Color.Black

        Dim sf As New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Near}
        Dim textRect As New Rectangle(e.Bounds.X + 5, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
        e.Graphics.DrawString(e.SubItem.Text, lvShortcuts.Font, New SolidBrush(textColor), textRect, sf)
    End Sub

    Private Sub lvShortcuts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvShortcuts.SelectedIndexChanged
        If lvShortcuts.SelectedItems.Count > 0 Then
            Dim actionName As String = lvShortcuts.SelectedItems(0).Text
            lblCurrentAction.Text = "Current Action : " & actionName
            txtCurrentAction.Text = actionName
            txtCurrentAction.ForeColor = Color.Black
        End If
    End Sub
End Class