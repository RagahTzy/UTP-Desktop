Public Class Kumite

    ' ==================== Scoring Buttons AKA ====================
    Private Sub BtnIpponAKA_Click(sender As Object, e As EventArgs) Handles BtnIpponAKA.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    ' ==================== Buka ListOfCompetitor ====================
    ' Button4 = tombol pilih kompetitor di area AKA (dekat TxtNameAKA)
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm As New ListOfCompetitor()
        frm.ShowDialog()
    End Sub

    ' Button5 = tombol pilih kompetitor di area AKA (dekat TxtTeamAKA)
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frm As New ListOfCompetitor()
        frm.ShowDialog()
    End Sub

    ' Button9 = tombol pilih kompetitor di area AO (dekat TxtNameAO)
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim frm As New ListOfCompetitor()
        frm.ShowDialog()
    End Sub

    ' Button10 = tombol di PanelTop (area AKA)
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim frm As New ListOfCompetitor()
        frm.ShowDialog()
    End Sub

    ' Button11 = tombol di PanelTop (area AO)
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim frm As New ListOfCompetitor()
        frm.ShowDialog()
    End Sub

    ' ==================== Bottom Panel Buttons ====================
    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click
        Dim frm As New FrmScoreboardSetting()
        frm.ShowDialog()
    End Sub

    Private Sub BtnLogActivity_Click(sender As Object, e As EventArgs) Handles BtnLogActivity.Click
        Dim frm As New Log_Activity()
        frm.ShowDialog()
    End Sub

    Private Sub BtnShortcut_Click(sender As Object, e As EventArgs) Handles BtnShortcut.Click
        Dim frm As New Shortcut()
        frm.ShowDialog()
    End Sub

    Private Sub BtnHantei_Click(sender As Object, e As EventArgs) Handles BtnHantei.Click
        Dim frmDecision As New ManualDecision()
        frmDecision.ShowDialog()
    End Sub

    ' ==================== Form Closed ====================
    ' Mengembalikan user ke form Dashboard ketika form Kumite ditutup
    Private Sub Kumite_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Show()
    End Sub

End Class