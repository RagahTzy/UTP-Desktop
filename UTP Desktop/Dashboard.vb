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
        Application.Exit()
    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub

    Private Sub lblTatamiID_Click(sender As Object, e As EventArgs) Handles lblTatamiID.Click

    End Sub

End Class