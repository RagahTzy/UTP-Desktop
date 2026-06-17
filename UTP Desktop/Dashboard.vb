Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        ' Pastikan table MatchResult sudah ada
        ModGlobalConfig.InitMatchResultTable()
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

    Private Sub OpenKata_Click(sender As Object, e As EventArgs) Handles pnlKata.Click, pbKata.Click
        Dim Kata As New Kata()
        Kata.Show()
        Me.Hide()
    End Sub

    ' ==================== Buka List of Match Result ====================
    Private Sub OpenResult_Click(sender As Object, e As EventArgs) Handles pnlResult.Click, pbResult.Click, lblResult.Click
        Dim frmResult As New ListofMatchResult()
        frmResult.ShowDialog()
    End Sub

    Private Sub lblWebsite_Click(sender As Object, e As EventArgs)

    End Sub
End Class