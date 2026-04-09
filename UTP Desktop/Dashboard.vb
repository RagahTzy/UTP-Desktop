Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' TODO: Inisialisasi awal dashboard (misalnya load koneksi atau cek status awal)
    End Sub

    ' Klik pada Panel, Icon, atau Teks akan membuka form Competitor
    Private Sub OpenCompetitor_Click(sender As Object, e As EventArgs) Handles Panel3.Click, PictureBox1.Click, Label1.Click
        Dim frmCompetitor As New Competitor()
        frmCompetitor.Show()

        ' (Opsional) Sembunyikan form dashboard agar tidak menumpuk
        ' Me.Hide()
    End Sub

End Class