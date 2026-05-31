
Public Class KataScoreboard
        Inherits System.Windows.Forms.Form

        Private animTimer As New Timer()
    Private dotCount As Integer = 0

    Private Sub KataScoreboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.None
        Me.BackColor = Color.Black
        Me.DoubleBuffered = True
        Me.KeyPreview = True

        animTimer.Interval = 500
        AddHandler animTimer.Tick, AddressOf AnimDots
        animTimer.Start()
    End Sub

    Private Sub AnimDots(sender As Object, e As EventArgs)
        dotCount = (dotCount + 1) Mod 4
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim W As Integer = Me.ClientSize.Width
        Dim H As Integer = Me.ClientSize.Height

        ' === BACKGROUND HITAM ===
        g.FillRectangle(Brushes.Black, 0, 0, W, H)

        ' === HEADER GRADIENT merah-biru ===
        Dim headerH As Integer = CInt(H * 0.1)
        Using br As New Drawing2D.LinearGradientBrush(
            New Rectangle(0, 0, W, headerH),
            Color.FromArgb(150, 0, 0),
            Color.FromArgb(0, 0, 180),
            Drawing2D.LinearGradientMode.Horizontal)
            g.FillRectangle(br, 0, 0, W, headerH)
        End Using

        ' === GRADASI BIRU MEMUDAR KE BAWAH (efek glow bawah header) ===
        Dim glowH As Integer = CInt(H * 0.18)
        Using glowBr As New Drawing2D.LinearGradientBrush(
            New Rectangle(0, headerH, W, glowH),
            Color.FromArgb(80, 0, 30, 120),
            Color.FromArgb(0, 0, 0, 0),
            Drawing2D.LinearGradientMode.Vertical)
            g.FillRectangle(glowBr, 0, headerH, W, glowH)
        End Using

        ' === JUDUL "KATA Category Detail" ===
        Dim titleFont As New Font("Arial", CInt(H * 0.046), FontStyle.Bold)
        Dim titleText As String = "KATA Category Detail"
        Dim titleSize As SizeF = g.MeasureString(titleText, titleFont)
        Dim titleX As Single = (W - titleSize.Width) / 2
        Dim titleY As Single = (headerH - titleSize.Height) / 2
        g.DrawString(titleText, titleFont, Brushes.Yellow, titleX, titleY)

        ' === TEKS "Activation Required..." ===
        Dim actFont As New Font("Courier New", CInt(H * 0.058), FontStyle.Bold)
        g.DrawString("Activation Required...", actFont, Brushes.White,
                     CInt(W * 0.02), CInt(H * 0.14))

        ' === DOTS KUNING (kecil) ===
        Dim dotStr As String = String.Concat(Enumerable.Repeat("• ", dotCount + 1))
        Dim dotFontSmall As New Font("Courier New", CInt(H * 0.022), FontStyle.Bold)
        g.DrawString(dotStr, dotFontSmall, Brushes.Yellow,
                     CInt(W * 0.02), CInt(H * 0.44))

        ' === DOTS PUTIH (sedikit lebih besar) ===
        Dim dotFontMed As New Font("Courier New", CInt(H * 0.026), FontStyle.Regular)
        g.DrawString(dotStr, dotFontMed, Brushes.White,
                     CInt(W * 0.02), CInt(H * 0.52))

        ' === FOOTER ===
        Dim footerH As Integer = CInt(H * 0.075)
        Dim footerY As Integer = H - footerH
        g.FillRectangle(New SolidBrush(Color.FromArgb(18, 18, 18)), 0, footerY, W, footerH)
        g.DrawLine(New Pen(Color.FromArgb(50, 50, 50), 1), 0, footerY, W, footerY)

        Dim footFont As New Font("Arial", CInt(H * 0.028), FontStyle.Bold)

        ' Yabinya Studio kiri
        Dim studioY As Single = footerY + (footerH - footFont.GetHeight(g)) / 2
        g.DrawString("Yabinya Studio", footFont, Brushes.White, CInt(W * 0.018), studioY)

        ' TATAMI 1 kanan
        Dim tatamiText As String = "TATAMI  1"
        Dim tatamiSize As SizeF = g.MeasureString(tatamiText, footFont)
        g.DrawString(tatamiText, footFont, Brushes.White,
                     W - tatamiSize.Width - CInt(W * 0.018), studioY)

        ' Cleanup
        titleFont.Dispose()
        actFont.Dispose()
        dotFontSmall.Dispose()
        dotFontMed.Dispose()
        footFont.Dispose()
    End Sub

    Private Sub KataScoreboard_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            animTimer.Stop()
            Me.Close()
        End If
    End Sub

End Class
