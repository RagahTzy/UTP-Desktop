Public Class FrmKnockedOut

    Private countdownValue As Integer = 9

    Private Sub FrmKnockedOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tampilkan nilai awal
        LblCountdown.Text = countdownValue.ToString("D2")

        ' Mulai countdown
        TimerKO.Interval = 1000 ' 1 detik
        TimerKO.Start()
    End Sub

    Private Sub TimerKO_Tick(sender As Object, e As EventArgs) Handles TimerKO.Tick
        countdownValue -= 1
        LblCountdown.Text = countdownValue.ToString("D2")

        If countdownValue <= 0 Then
            TimerKO.Stop()
            LblCountdown.Text = "00"
            MessageBox.Show("Waktu Knocked Out Habis!", "KO Time Up", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub BtnCloseKO_Click(sender As Object, e As EventArgs) Handles BtnCloseKO.Click
        TimerKO.Stop()
        Me.Close()
    End Sub

End Class