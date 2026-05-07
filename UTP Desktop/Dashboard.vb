Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    ' ==================== Buka Competitor ====================
    Private Sub OpenCompetitor_Click(sender As Object, e As EventArgs) Handles pnlCompetitors.Click, pbCompetitors.Click, lblCompetitors.Click
        Dim frmCompetitor As New Competitor()
        frmCompetitor.Show()
        Me.Hide()
    End Sub

    ' ==================== Buka Kumite ====================
    Private Sub OpenKumite_Click(sender As Object, e As EventArgs) Handles pnlKumite.Click, pbKumite.Click, lblKumite.Click
        Dim frmKumite As New Kumite()
        frmKumite.Show()
        Me.Hide()
    End Sub

    ' ==================== Form Closed ====================
    Private Sub Dashboard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Perintah ini yang akan menghentikan seluruh aplikasi secara total
        Application.Exit()
    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint
        ' Biarkan kosong jika tidak ada custom paint
    End Sub

    Private Sub lblTatamiID_Click(sender As Object, e As EventArgs) Handles lblTatamiID.Click
        ' Biarkan kosong jika tidak ada aksi saat diklik
    End Sub

End Class