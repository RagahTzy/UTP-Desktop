Public Class FrmWinner

    ' ==================== Setup data winner ====================
    Public Sub SetWinner(name As String, team As String, teamInfo As String, side As String)
        ' Isi label sesuai data pemenang
        LblWinnerName.Text = name
        LblWinnerTeam.Text = team
        LblWinnerTeamInfo.Text = teamInfo

        ' Warna background sesuai sisi (AKA = merah, AO = biru)
        If side = "AKA" Then
            Me.BackColor = Color.FromArgb(180, 0, 0)
            PanelWinner.BackColor = Color.FromArgb(200, 0, 0)
            LblWinnerTitle.Text = "🏆  AKA WINNER  🏆"
        ElseIf side = "AO" Then
            Me.BackColor = Color.FromArgb(0, 80, 180)
            PanelWinner.BackColor = Color.FromArgb(0, 100, 200)
            LblWinnerTitle.Text = "🏆  AO WINNER  🏆"
        End If
    End Sub

    Private Sub BtnCloseWinner_Click(sender As Object, e As EventArgs) Handles BtnCloseWinner.Click
        Me.Close()
    End Sub

    ' Auto close setelah 10 detik (opsional)
    Private Sub FrmWinner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerAutoClose.Interval = 10000 ' 10 detik
        TimerAutoClose.Start()
    End Sub

    Private Sub TimerAutoClose_Tick(sender As Object, e As EventArgs) Handles TimerAutoClose.Tick
        TimerAutoClose.Stop()
        Me.Close()
    End Sub

End Class