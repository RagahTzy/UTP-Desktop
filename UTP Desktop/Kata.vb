Public Class Kata
    ''' <summary>
    ''' Mengatur perubahan tampilan utama berdasarkan tipe scoring yang dipilih juri
    ''' </summary>
    Private Sub RadScore_CheckedChanged(sender As Object, e As EventArgs) Handles RadScore.CheckedChanged
        If RadScore.Checked Then
            PanelJudgeScore.Visible = True
            PanelFlagSystem.Visible = False
        End If
    End Sub

    Private Sub RadFlagSystem_CheckedChanged(sender As Object, e As EventArgs) Handles RadFlagSystem.CheckedChanged
        If RadFlagSystem.Checked Then
            PanelJudgeScore.Visible = False
            PanelFlagSystem.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles APIInfo.Click

    End Sub
End Class