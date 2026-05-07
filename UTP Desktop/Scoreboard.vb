Imports System.Drawing
Imports System.Windows.Forms

Public Class Scoreboard

    ' Variabel Publik agar nanti skornya bisa diubah dari Kumite.vb
    Public LblAkaName As Label
    Public LblAoName As Label
    Public LblAkaScore As Label
    Public LblAoScore As Label
    Public LblTimer As Label
    Public LblTatami As Label
    Public LblMatchDesc As Label
    Public AkaPenLabels(4) As Label
    Public AoPenLabels(4) As Label

    Private Sub Scoreboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup Form agar Full Screen & Dark Mode
        Me.BackColor = Color.FromArgb(15, 15, 20)
        Me.FormBorderStyle = FormBorderStyle.None ' Hilangkan border silang atas
        Me.DoubleBuffered = True

        BuildUI()
    End Sub

    ' Fungsi untuk keluar dari mode fullscreen jika tombol ESC ditekan
    Private Sub Scoreboard_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    ' Fungsi pembuat UI persis gambar Anda
    Private Sub BuildUI()
        Dim mainLayout As New TableLayoutPanel()
        mainLayout.Dock = DockStyle.Fill
        mainLayout.RowCount = 3
        mainLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 30.0F)) ' Area Nama
        mainLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 45.0F)) ' Area Skor & Penalti
        mainLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0F)) ' Area Footer Timer
        Me.Controls.Add(mainLayout)

        ' ================= BARIS 1: NAMA PEMAIN =================
        Dim pnlHeader As New TableLayoutPanel() With {.Dock = DockStyle.Fill, .ColumnCount = 2}
        pnlHeader.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        pnlHeader.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        mainLayout.Controls.Add(pnlHeader, 0, 0)

        LblAkaName = New Label With {.Text = "Activation Required...", .ForeColor = Color.MediumBlue, .Font = New Font("Consolas", 32, FontStyle.Bold), .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.BottomCenter, .Padding = New Padding(0, 0, 0, 20)}
        LblAoName = New Label With {.Text = "Activation Required...", .ForeColor = Color.MediumBlue, .Font = New Font("Consolas", 32, FontStyle.Bold), .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.BottomCenter, .Padding = New Padding(0, 0, 0, 20)}
        pnlHeader.Controls.Add(LblAkaName, 0, 0)
        pnlHeader.Controls.Add(LblAoName, 1, 0)

        ' ================= BARIS 2: SKOR & PENALTI =================
        Dim pnlMid As New TableLayoutPanel() With {.Dock = DockStyle.Fill, .RowCount = 2}
        pnlMid.RowStyles.Add(New RowStyle(SizeType.Percent, 80.0F))
        pnlMid.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        mainLayout.Controls.Add(pnlMid, 0, 1)

        ' Area Kotak Skor Besar
        Dim pnlScore As New TableLayoutPanel() With {.Dock = DockStyle.Fill, .ColumnCount = 2}
        pnlScore.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        pnlScore.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        pnlMid.Controls.Add(pnlScore, 0, 0)

        ' Panel Merah (AKA) dan Biru (AO)
        Dim pnlAkaBox As New Panel With {.BackColor = Color.FromArgb(200, 20, 30), .Dock = DockStyle.Fill, .Margin = New Padding(50, 0, 20, 0)}
        Dim pnlAoBox As New Panel With {.BackColor = Color.FromArgb(20, 100, 200), .Dock = DockStyle.Fill, .Margin = New Padding(20, 0, 50, 0)}

        LblAkaScore = New Label With {.Text = "0", .ForeColor = Color.White, .Font = New Font("Arial", 180, FontStyle.Bold), .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleCenter}
        LblAoScore = New Label With {.Text = "0", .ForeColor = Color.White, .Font = New Font("Arial", 180, FontStyle.Bold), .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleCenter}

        pnlAkaBox.Controls.Add(LblAkaScore) : pnlAoBox.Controls.Add(LblAoScore)
        pnlScore.Controls.Add(pnlAkaBox, 0, 0) : pnlScore.Controls.Add(pnlAoBox, 1, 0)

        ' Area Baris Penalti Bawah Skor
        Dim pnlPenalty As New TableLayoutPanel() With {.Dock = DockStyle.Fill, .ColumnCount = 11, .BackColor = Color.FromArgb(25, 25, 25), .Margin = New Padding(50, 10, 50, 0)}
        For i As Integer = 0 To 10 : pnlPenalty.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F / 11.0F)) : Next
        pnlMid.Controls.Add(pnlPenalty, 0, 1)

        Dim penLabels() As String = {"1C", "2C", "3C", "HC", "H", "PENALTY", "H", "HC", "3C", "2C", "1C"}
        For i As Integer = 0 To 10
            Dim isCenter As Boolean = (i = 5)
            Dim lbl As New Label With {.Text = penLabels(i), .ForeColor = If(isCenter, Color.Gold, Color.LightGray), .Font = New Font("Arial", If(isCenter, 16, 14), FontStyle.Bold), .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleCenter}
            pnlPenalty.Controls.Add(lbl, i, 0)

            ' Simpan referensi label ke dalam Array agar bisa di-Remote dari Kumite.vb
            If i < 5 Then
                AkaPenLabels(i) = lbl ' Index 0-4 untuk AKA
            ElseIf i > 5 Then
                AoPenLabels(10 - i) = lbl ' Dibalik agar Index 0 = 1C, Index 4 = H untuk AO
            End If
        Next

        ' ================= BARIS 3: FOOTER (TIMER) =================
        Dim pnlFooter As New TableLayoutPanel() With {.Dock = DockStyle.Fill, .ColumnCount = 3}
        pnlFooter.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.0F))
        pnlFooter.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40.0F))
        pnlFooter.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.0F))
        mainLayout.Controls.Add(pnlFooter, 0, 2)

        LblTatami = New Label With {.Text = "TATAMI" & vbCrLf & "1", .ForeColor = Color.Gold, .Font = New Font("Arial", 36, FontStyle.Bold), .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleCenter}
        LblTimer = New Label With {.Text = "2:00.0", .ForeColor = Color.White, .Font = New Font("Arial", 120, FontStyle.Bold), .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleCenter}
        LblMatchDesc = New Label With {.Text = "Match Description...", .ForeColor = Color.DarkOrange, .Font = New Font("Arial", 28, FontStyle.Bold), .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleCenter}

        pnlFooter.Controls.Add(LblTatami, 0, 0)
        pnlFooter.Controls.Add(LblTimer, 1, 0)
        pnlFooter.Controls.Add(LblMatchDesc, 2, 0)
    End Sub

End Class