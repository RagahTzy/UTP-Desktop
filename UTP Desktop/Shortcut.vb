Public Class Shortcut
    ' Variabel untuk menandai kita sedang merekam tombol keyboard
    Private isRecording As Boolean = False
    Private isShortcutActive As Boolean = True ' Status ON/OFF

    Private Sub Shortcut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        ' PENTING: Form harus bisa menangkap tombol keyboard sebelum fokus ke kontrol lain
        Me.KeyPreview = True

        If lvShortcuts IsNot Nothing Then
            lvShortcuts.OwnerDraw = True
            isiDataShortcut()
        End If
    End Sub

    ' --- FUNGSI UTAMA: MENDETEKSI TOMBOL KEYBOARD ---
    Private Sub Shortcut_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If isRecording Then
            ' Jangan rekam jika hanya menekan tombol modifier sendirian
            If e.KeyCode = Keys.ControlKey Or e.KeyCode = Keys.ShiftKey Or e.KeyCode = Keys.Menu Then
                Exit Sub
            End If

            ' Mencegah bunyi "ding" Windows dan mencegah tombol memicu kontrol lain (seperti spasi)
            e.SuppressKeyPress = True

            ' Susun nama shortcut secara otomatis
            Dim strShortcut As String = ""
            If e.Control Then strShortcut &= "Control+"
            If e.Shift Then strShortcut &= "Shift+"
            If e.Alt Then strShortcut &= "Alt+"
            strShortcut &= e.KeyCode.ToString()

            ' Masukkan ke kolom shortcut yang dipilih
            If lvShortcuts.SelectedItems.Count > 0 Then
                lvShortcuts.SelectedItems(0).SubItems(1).Text = strShortcut

                ' Selesai merekam, kembalikan tampilan
                isRecording = False
                txtCurrentAction.Text = lvShortcuts.SelectedItems(0).Text
                txtCurrentAction.ForeColor = Color.Black
                btnChange.Enabled = True
                btnSave.Enabled = True
                btnSave.ForeColor = Color.Black
                lvShortcuts.Enabled = True ' Aktifkan tabel kembali
            End If
        End If
    End Sub

    ' --- LOGIKA TOMBOL CHANGE ---
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        If lvShortcuts.SelectedItems.Count > 0 Then
            ' Aktifkan mode mendengarkan keyboard
            isRecording = True
            txtCurrentAction.Text = ">>> SEKARANG TEKAN TOMBOL DI KEYBOARD ANDA... <<<"
            txtCurrentAction.ForeColor = Color.Red
            btnChange.Enabled = False

            ' Trik: Kunci tabel sementara agar user tidak klik baris lain saat merekam
            lvShortcuts.Enabled = False

            ' Trik: Lepaskan fokus dari tombol agar KeyDown form bekerja sempurna
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
        MessageBox.Show("Pengaturan shortcut berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        btnSave.Enabled = False
        btnSave.ForeColor = Color.DarkGray
    End Sub

    ' --- LOGIKA TOMBOL TOGGLE ON/OFF (DENGAN ANIMASI SWITCH) ---
    Private Sub btnToggle_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        isShortcutActive = Not isShortcutActive

        If isShortcutActive Then
            ' --- Tampilan Saat ON ---
            lblStatusValue.Text = "ON"
            lblStatusValue.ForeColor = Color.FromArgb(0, 192, 239) ' Warna Cyan
            lblTurnOff.Text = "Turn off"

            ' Animasi Switch ke Kanan (Biru)
            btnToggle.BackColor = Color.FromArgb(0, 120, 215)
            btnToggle.TextAlign = ContentAlignment.MiddleRight
        Else
            ' --- Tampilan Saat OFF ---
            lblStatusValue.Text = "OFF"
            lblStatusValue.ForeColor = Color.Gray
            lblTurnOff.Text = "Turn on"

            ' Animasi Switch ke Kiri (Abu-abu)
            btnToggle.BackColor = Color.DarkGray
            btnToggle.TextAlign = ContentAlignment.MiddleLeft
        End If
    End Sub

    ' --- LOGIKA TOMBOL RESET ---
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim confirm = MessageBox.Show("Yakin ingin mereset ke default?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            isiDataShortcut()
            btnSave.Enabled = True
            btnSave.ForeColor = Color.Black
        End If
    End Sub

    ' --- LOGIKA TABEL & TAMPILAN (TIDAK ADA YANG DIUBAH) ---
    Private Sub isiDataShortcut()
        If lvShortcuts Is Nothing Then Exit Sub
        lvShortcuts.Items.Clear()
        ' Group General
        tambahItem("Start-Close Scoreboard", "Control+B")
        tambahItem("Timer Waiting Start-Stop", "Control+W")
        tambahItem("Match Timer Start-Stop", "Space")
        tambahItem("Next Match", "Control+N")
        tambahItem("Save Match Result", "Control+S")
        tambahItem("Match Timer Reset", "Control+R")
        tambahItem("Show Winner", "Control+E")
        ' Group AKA (Merah)
        tambahItem("AKA - Yuko(1)", "Shift+A")
        tambahItem("AKA - Wazaari(2)", "Shift+S")
        tambahItem("AKA - Ippon(3)", "Shift+D")
        tambahItem("AKA - SENSHU", "Shift+Q")
        ' Group AO (Biru)
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

    Private Sub lvShortcuts_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles lvShortcuts.DrawColumnHeader
        e.DrawDefault = True
    End Sub

    Private Sub lvShortcuts_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles lvShortcuts.DrawSubItem
        If e.Item Is Nothing Then Exit Sub
        If e.Item.Selected Then
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(135, 206, 250)), e.Bounds)
        Else
            e.Graphics.FillRectangle(Brushes.White, e.Bounds)
        End If
        Dim textColor As Color = Color.Black
        If Not String.IsNullOrEmpty(e.Item.Text) Then
            If e.Item.Text.StartsWith("AKA") Then textColor = Color.Red
            If e.Item.Text.StartsWith("AO") Then textColor = Color.Blue
        End If
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