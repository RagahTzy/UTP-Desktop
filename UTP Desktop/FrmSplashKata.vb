Public Class FrmSplashKata
    Inherits System.Windows.Forms.Form

    Private splashTimer As New Timer()  ' ← BARU
    Public Event ScoreboardOpened(scoreboard As KataScoreboard)

    Private Sub FrmSplashKata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Black

        ' ← BARU: Timer 5 detik
        splashTimer.Interval = 5000
        AddHandler splashTimer.Tick, AddressOf SplashSelesai
        splashTimer.Start()
    End Sub

    ' ← BARU: Setelah 5 detik, pindah ke KataScoreboard
    Private Sub SplashSelesai(sender As Object, e As EventArgs)
        splashTimer.Stop()
        Dim scoreboard As New KataScoreboard()
        RaiseEvent ScoreboardOpened(scoreboard)
        scoreboard.Show()
        Me.Close()
    End Sub

    ' ← INI PUNYA KAMU, TETAP SAMA, TIDAK DIUBAH
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        Dim W As Integer = Me.ClientSize.Width
        Dim H As Integer = Me.ClientSize.Height
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        g.FillRectangle(Brushes.Black, 0, 0, W, H)

        Dim cx As Single = W / 2
        Dim cy As Single = H * 0.42
        Dim s As Single = H * 0.22

        ' === SAYAP KIRI (putih) ===
        Dim wing() As PointF = {
            New PointF(cx - s * 1.1, cy - s * 0.1),
            New PointF(cx + s * 0.05, cy - s * 0.35),
            New PointF(cx - s * 0.05, cy - s * 0.05),
            New PointF(cx - s * 1.0, cy + s * 0.2)
        }
        g.FillPolygon(New SolidBrush(Color.FromArgb(240, 240, 240)), wing)

        ' === BADAN KANAN ATAS (emas terang) ===
        Dim bodyRight() As PointF = {
            New PointF(cx - s * 0.05, cy - s * 0.35),
            New PointF(cx + s * 0.85, cy - s * 0.7),
            New PointF(cx + s * 0.5, cy + s * 0.1),
            New PointF(cx - s * 0.05, cy - s * 0.05)
        }
        g.FillPolygon(New SolidBrush(Color.FromArgb(218, 170, 20)), bodyRight)

        ' === BADAN TENGAH BAWAH (emas gelap) ===
        Dim bodyMid() As PointF = {
            New PointF(cx - s * 0.05, cy - s * 0.05),
            New PointF(cx + s * 0.5, cy + s * 0.1),
            New PointF(cx + s * 0.3, cy + s * 0.6),
            New PointF(cx - s * 0.2, cy + s * 0.3)
        }
        g.FillPolygon(New SolidBrush(Color.FromArgb(130, 90, 5)), bodyMid)

        ' === EKOR BAWAH (emas terang) ===
        Dim tail() As PointF = {
            New PointF(cx - s * 0.2, cy + s * 0.3),
            New PointF(cx + s * 0.3, cy + s * 0.6),
            New PointF(cx + s * 0.1, cy + s * 0.85),
            New PointF(cx - s * 0.35, cy + s * 0.55)
        }
        g.FillPolygon(New SolidBrush(Color.FromArgb(218, 170, 20)), tail)

        ' === TEKS "Yabinya Studio" ===
        Dim font As New Font("Arial", CInt(H * 0.055), FontStyle.Bold)
        Dim text As String = "Yabinya Studio"
        Dim sz As SizeF = g.MeasureString(text, font)
        g.DrawString(text, font, Brushes.White, (W - sz.Width) / 2, CSng(cy + s * 1.05))
        font.Dispose()
    End Sub

End Class