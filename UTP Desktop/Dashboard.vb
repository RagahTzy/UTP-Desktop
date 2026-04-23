Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub OpenCompetitor_Click(sender As Object, e As EventArgs) Handles Panel3.Click, PictureBox1.Click, Label1.Click
        Dim frmCompetitor As New Competitor()
        frmCompetitor.Show()
        Me.Hide()
    End Sub

    Private Sub Dashboard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub

    Private Sub lblTatamiID_Click(sender As Object, e As EventArgs) Handles lblTatamiID.Click

    End Sub
End Class