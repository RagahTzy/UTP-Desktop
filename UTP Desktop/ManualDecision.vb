Public Class ManualDecision

    Dim juriVote(3) As Object
    Dim wasitPilih As Object

    Private Sub ManualDecision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAKA1.Tag = "1" : btnAKA2.Tag = "2"
        btnAKA3.Tag = "3" : btnAKA4.Tag = "4"
        btnAO1.Tag = "1" : btnAO2.Tag = "2"
        btnAO3.Tag = "3" : btnAO4.Tag = "4"

        For Each btn As Button In {btnAKA1, btnAKA2, btnAKA3, btnAKA4}
            AddHandler btn.Paint, AddressOf PaintJuriAKA
        Next
        For Each btn As Button In {btnAO1, btnAO2, btnAO3, btnAO4}
            AddHandler btn.Paint, AddressOf PaintJuriAO
        Next
        AddHandler btnWinnerAKA.Paint, AddressOf PaintWasitAKA
        AddHandler btnWinnerAO.Paint, AddressOf PaintWasitAO

        ResetSemua()
    End Sub

    ' ============================================================
    ' PAINT — TOMBOL JURI AKA
    ' ============================================================
    Private Sub PaintJuriAKA(sender As Object, e As PaintEventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim aktif As Boolean = (btn.BackColor = Color.FromArgb(72, 52, 120))

        ' Background
        g.Clear(btn.BackColor)

        ' Bendera merah
        Dim flagClr As Color = If(aktif, Color.OrangeRed, Color.Red)
        GambarBendera(g, btn, flagClr, aktif)

        ' Border
        If aktif Then
            ' Border biru tebal
            Using p As New Pen(Color.CornflowerBlue, 2.5F)
                g.DrawRectangle(p, 1, 1, btn.Width - 3, btn.Height - 3)
            End Using
        Else
            ' Border abu tipis — SELALU tampil walau belum dipilih
            Using p As New Pen(Color.Silver, 1.2F)
                g.DrawRectangle(p, 0, 0, btn.Width - 1, btn.Height - 1)
            End Using
        End If
    End Sub

    ' ============================================================
    ' PAINT — TOMBOL JURI AO
    ' ============================================================
    Private Sub PaintJuriAO(sender As Object, e As PaintEventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim aktif As Boolean = (btn.BackColor = Color.FromArgb(72, 52, 120))

        g.Clear(btn.BackColor)

        Dim flagClr As Color = If(aktif, Color.DeepSkyBlue, Color.RoyalBlue)
        GambarBendera(g, btn, flagClr, aktif)

        If aktif Then
            Using p As New Pen(Color.CornflowerBlue, 2.5F)
                g.DrawRectangle(p, 1, 1, btn.Width - 3, btn.Height - 3)
            End Using
        Else
            Using p As New Pen(Color.Silver, 1.2F)
                g.DrawRectangle(p, 0, 0, btn.Width - 1, btn.Height - 1)
            End Using
        End If
    End Sub

    ' ============================================================
    ' HELPER — Gambar bendera + nomor di tengah tombol
    ' ============================================================
    Private Sub GambarBendera(g As Graphics, btn As Button,
                               flagColor As Color, aktif As Boolean)
        Dim w As Integer = btn.Width
        Dim h As Integer = btn.Height

        ' Posisi tiang: agak ke kiri tengah
        Dim tiangX As Integer = CInt(w * 0.38)
        Dim tiangTop As Integer = CInt(h * 0.12)
        Dim tiangBot As Integer = CInt(h * 0.78)
        Dim tiangClr As Color = If(aktif, Color.LightGray, Color.FromArgb(90, 90, 90))

        ' Tiang
        Using p As New Pen(tiangClr, 2.2F)
            g.DrawLine(p, tiangX, tiangTop, tiangX, tiangBot)
        End Using

        ' Bendera segitiga
        Dim flagTop As Integer = tiangTop
        Dim flagMid As Integer = CInt(tiangTop + (tiangBot - tiangTop) * 0.42)
        Dim flagBot As Integer = CInt(tiangTop + (tiangBot - tiangTop) * 0.75)
        Dim flagRight As Integer = CInt(tiangX + w * 0.42)

        Dim pts() As Point = {
            New Point(tiangX, flagTop),
            New Point(flagRight, flagMid),
            New Point(tiangX, flagBot)
        }
        Using br As New SolidBrush(flagColor)
            g.FillPolygon(br, pts)
        End Using

        ' Nomor di bawah bendera
        Dim numStr As String = If(btn.Tag IsNot Nothing, btn.Tag.ToString(), "")
        Using fnt As New Font("Segoe UI", 8.0F, FontStyle.Bold)
            Using sf As New StringFormat() With {
                .Alignment = StringAlignment.Center,
                .LineAlignment = StringAlignment.Center}
                Using br As New SolidBrush(If(aktif, Color.White, Color.Black))
                    g.DrawString(numStr, fnt, br,
                                 New RectangleF(0, h - 20, w, 18), sf)
                End Using
            End Using
        End Using
    End Sub

    ' ============================================================
    ' PAINT — TOMBOL WASIT AKA
    ' ============================================================
    Private Sub PaintWasitAKA(sender As Object, e As PaintEventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.Clear(btn.BackColor)

        Dim enabled As Boolean = btn.Enabled
        Dim dipilih As Boolean = (wasitPilih IsNot Nothing AndAlso
                                  wasitPilih.ToString() = "AKA")

        ' Teks AKA
        Using fnt As New Font("Segoe UI", 9.0F, FontStyle.Regular)
            Using sf As New StringFormat() With {
                .Alignment = StringAlignment.Near,
                .LineAlignment = StringAlignment.Center}
                Using br As New SolidBrush(If(enabled, Color.Black, Color.DarkGray))
                    g.DrawString("AKA", fnt, br,
                                 New RectangleF(8, 0, btn.Width - 38, btn.Height), sf)
                End Using
            End Using
        End Using

        ' Bendera kecil merah di kanan
        Dim flagClr As Color = If(enabled, Color.Red, Color.Gray)
        GambarBenderaKecil(g, btn, flagClr)

        ' Border
        If dipilih Then
            Using p As New Pen(Color.CornflowerBlue, 2.0F)
                g.DrawRectangle(p, 1, 1, btn.Width - 3, btn.Height - 3)
            End Using
        Else
            Using p As New Pen(Color.Silver, 1.0F)
                g.DrawRectangle(p, 0, 0, btn.Width - 1, btn.Height - 1)
            End Using
        End If
    End Sub

    ' ============================================================
    ' PAINT — TOMBOL WASIT AO
    ' ============================================================
    Private Sub PaintWasitAO(sender As Object, e As PaintEventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.Clear(btn.BackColor)

        Dim enabled As Boolean = btn.Enabled
        Dim dipilih As Boolean = (wasitPilih IsNot Nothing AndAlso
                                  wasitPilih.ToString() = "AO")

        Using fnt As New Font("Segoe UI", 9.0F, FontStyle.Regular)
            Using sf As New StringFormat() With {
                .Alignment = StringAlignment.Near,
                .LineAlignment = StringAlignment.Center}
                Using br As New SolidBrush(If(enabled, Color.Black, Color.DarkGray))
                    g.DrawString("AO", fnt, br,
                                 New RectangleF(8, 0, btn.Width - 38, btn.Height), sf)
                End Using
            End Using
        End Using

        Dim flagClr As Color = If(enabled, Color.RoyalBlue, Color.Gray)
        GambarBenderaKecil(g, btn, flagClr)

        If dipilih Then
            Using p As New Pen(Color.CornflowerBlue, 2.0F)
                g.DrawRectangle(p, 1, 1, btn.Width - 3, btn.Height - 3)
            End Using
        Else
            Using p As New Pen(Color.Silver, 1.0F)
                g.DrawRectangle(p, 0, 0, btn.Width - 1, btn.Height - 1)
            End Using
        End If
    End Sub

    ' ============================================================
    ' HELPER — Bendera kecil untuk tombol wasit
    ' ============================================================
    Private Sub GambarBenderaKecil(g As Graphics, btn As Button, flagColor As Color)
        Dim cx As Integer = btn.Width - 26
        Dim cy As Integer = btn.Height \ 2
        Using p As New Pen(Color.DimGray, 1.5F)
            g.DrawLine(p, cx, cy - 12, cx, cy + 12)
        End Using
        Dim pts() As Point = {
            New Point(cx, cy - 12),
            New Point(cx + 18, cy - 3),
            New Point(cx, cy + 5)
        }
        Using br As New SolidBrush(flagColor)
            g.FillPolygon(br, pts)
        End Using
    End Sub

    ' ============================================================
    ' CLICK HANDLER
    ' ============================================================
    Private Sub btnAKA1_Click(s As Object, e As EventArgs) Handles btnAKA1.Click
        PilihJuri(0, "AKA")
    End Sub
    Private Sub btnAKA2_Click(s As Object, e As EventArgs) Handles btnAKA2.Click
        PilihJuri(1, "AKA")
    End Sub
    Private Sub btnAKA3_Click(s As Object, e As EventArgs) Handles btnAKA3.Click
        PilihJuri(2, "AKA")
    End Sub
    Private Sub btnAKA4_Click(s As Object, e As EventArgs) Handles btnAKA4.Click
        PilihJuri(3, "AKA")
    End Sub
    Private Sub btnAO1_Click(s As Object, e As EventArgs) Handles btnAO1.Click
        PilihJuri(0, "AO")
    End Sub
    Private Sub btnAO2_Click(s As Object, e As EventArgs) Handles btnAO2.Click
        PilihJuri(1, "AO")
    End Sub
    Private Sub btnAO3_Click(s As Object, e As EventArgs) Handles btnAO3.Click
        PilihJuri(2, "AO")
    End Sub
    Private Sub btnAO4_Click(s As Object, e As EventArgs) Handles btnAO4.Click
        PilihJuri(3, "AO")
    End Sub

    Private Sub btnWinnerAKA_Click(s As Object, e As EventArgs) Handles btnWinnerAKA.Click
        If HitungSkor("AKA") = 2 AndAlso HitungSkor("AO") = 2 Then
            PilihWasit("AKA")
        End If
    End Sub
    Private Sub btnWinnerAO_Click(s As Object, e As EventArgs) Handles btnWinnerAO.Click
        If HitungSkor("AKA") = 2 AndAlso HitungSkor("AO") = 2 Then
            PilihWasit("AO")
        End If
    End Sub

    ' ============================================================
    ' LOGIKA
    ' ============================================================
    Private Sub PilihJuri(index As Integer, pilihan As String)
        Dim lawan As String = If(pilihan = "AKA", "AO", "AKA")

        ' Toggle: klik sama = reset semua
        If juriVote(index) IsNot Nothing AndAlso
       juriVote(index).ToString() = pilihan Then
            For i As Integer = 0 To 3
                juriVote(i) = Nothing
            Next
        Else
            ' Index yang diklik dan semua DIBAWAHNYA (0 s/d index) = pilihan ini
            ' Index DIATASNYA (index+1 s/d 3) = lawan otomatis
            For i As Integer = 0 To 3
                If i <= index Then
                    juriVote(i) = pilihan   ' sama + dibawah = ikut pilihan
                Else
                    juriVote(i) = lawan     ' diatas = lawan
                End If
            Next
        End If

        ' Reset wasit jika tidak seri 2-2
        If Not (HitungSkor("AKA") = 2 AndAlso HitungSkor("AO") = 2) Then
            wasitPilih = Nothing
        End If

        UpdateTampilan()
    End Sub

    Private Sub PilihWasit(pilihan As String)
        If wasitPilih IsNot Nothing AndAlso
           wasitPilih.ToString() = pilihan Then
            wasitPilih = Nothing
        Else
            wasitPilih = pilihan
        End If
        UpdateTampilan()
    End Sub

    Private Function HitungSkor(pihak As String) As Integer
        Dim skor As Integer = 0
        For i As Integer = 0 To 3
            If juriVote(i) IsNot Nothing AndAlso
               juriVote(i).ToString() = pihak Then skor += 1
        Next
        Return skor
    End Function

    ' ============================================================
    ' UPDATE TAMPILAN
    ' ============================================================
    Private Sub UpdateTampilan()
        Dim skorAKA As Integer = HitungSkor("AKA")
        Dim skorAO As Integer = HitungSkor("AO")

        lblAKA.Text = "AKA      =      " & skorAKA.ToString()
        lblAO.Text = "AO         =      " & skorAO.ToString()

        ' Warna tombol juri
        Dim btnsAKA() As Button = {btnAKA1, btnAKA2, btnAKA3, btnAKA4}
        Dim btnsAO() As Button = {btnAO1, btnAO2, btnAO3, btnAO4}

        For i As Integer = 0 To 3
            btnsAKA(i).BackColor = If(
                juriVote(i) IsNot Nothing AndAlso juriVote(i).ToString() = "AKA",
                Color.FromArgb(72, 52, 120), Color.White)

            btnsAO(i).BackColor = If(
                juriVote(i) IsNot Nothing AndAlso juriVote(i).ToString() = "AO",
                Color.FromArgb(72, 52, 120), Color.White)

            btnsAKA(i).Invalidate()
            btnsAO(i).Invalidate()
        Next

        ' Wasit aktif hanya saat seri 2-2
        Dim seri As Boolean = (skorAKA = 2 AndAlso skorAO = 2)
        btnWinnerAKA.Enabled = seri
        btnWinnerAO.Enabled = seri
        btnWinnerAKA.Invalidate()
        btnWinnerAO.Invalidate()

        TentukanPemenang(skorAKA, skorAO)
    End Sub

    Private Sub TentukanPemenang(skorAKA As Integer, skorAO As Integer)
        If skorAKA + skorAO = 0 Then
            lblWinner.Text = "Winner :"
            lblWinner.BackColor = Color.Gold
            lblWinner.ForeColor = Color.Black
            Return
        End If

        If skorAKA > skorAO Then
            TampilPemenang("AKA")
        ElseIf skorAO > skorAKA Then
            TampilPemenang("AO")
        Else
            If wasitPilih IsNot Nothing Then
                TampilPemenang(wasitPilih.ToString())
            Else
                lblWinner.Text = "Winner :          Seri 2-2 — pilih wasit"
                lblWinner.BackColor = Color.Orange
                lblWinner.ForeColor = Color.White
            End If
        End If
    End Sub

    Private Sub TampilPemenang(pemenang As String)
        ' Format "Winner :     AO" seperti screenshot
        lblWinner.Text = "Winner :          " & pemenang
        lblWinner.BackColor = Color.Gold
        lblWinner.ForeColor = Color.Black
    End Sub

    ' ============================================================
    ' CLEAR / SAVE / CLOSE
    ' ============================================================
    Private Sub btnClear_Click(s As Object, e As EventArgs) Handles btnClear.Click
        ResetSemua()
    End Sub

    Private Sub ResetSemua()
        For i As Integer = 0 To 3
            juriVote(i) = Nothing
        Next
        wasitPilih = Nothing

        lblAKA.Text = "AKA      =      0"
        lblAO.Text = "AO         =      0"
        lblWinner.Text = "Winner :"
        lblWinner.BackColor = Color.Gold
        lblWinner.ForeColor = Color.Black

        For Each btn As Button In {btnAKA1, btnAKA2, btnAKA3, btnAKA4,
                                   btnAO1, btnAO2, btnAO3, btnAO4}
            btn.BackColor = Color.White
            btn.Invalidate()
        Next

        btnWinnerAKA.Enabled = False
        btnWinnerAO.Enabled = False
        btnWinnerAKA.BackColor = Color.White
        btnWinnerAO.BackColor = Color.White
        btnWinnerAKA.Invalidate()
        btnWinnerAO.Invalidate()
    End Sub

    Private Sub btnSave_Click(s As Object, e As EventArgs) Handles btnSave.Click
        If lblWinner.Text.Trim() = "Winner :" OrElse
           lblWinner.Text.Contains("Seri") Then
            MessageBox.Show("Pemenang belum ditentukan.", "Hantei",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim hasil As String = lblWinner.Text.Replace("Winner :", "").Trim()
        ' Simpan ke DB dan beri tahu kumite untuk tampilkan pemenang
        ModGlobalConfig.LogActivity("Hantei", "Hasil: " & hasil, "Hantei", "", Environment.UserName)

        ' Kirim hasil ke form Kumite melalui event: set langsung pada public controls
        Try
            Dim parent = CType(Me.Owner, Kumite)
            If parent IsNot Nothing Then
                If hasil = "AKA" Then
                    parent.ShowAkaWinner()
                ElseIf hasil = "AO" Then
                    parent.ShowAoWinner()
                End If
            End If
        Catch
            ' ignore
        End Try

        MessageBox.Show("Hasil Hantei disimpan: " & hasil, "Hantei",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btnClose_Click(s As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class