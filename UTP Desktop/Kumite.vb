Public Class Kumite

    ' ==================== Buka Jendela ListOfCompetitor ====================
    ' Menggabungkan 4 tombol menjadi 1 fungsi agar kode lebih bersih
    Private Sub OpenCompetitor_Click(sender As Object, e As EventArgs) Handles BtnAkaIcon.Click, BtnAoIcon.Click, BtnAkaUserIcon1.Click, BtnAoUserIcon1.Click
        Dim frmCompetitor As New ListOfCompetitor()
        frmCompetitor.ShowDialog()
    End Sub

    ' ==================== Buka Jendela Pengaturan & Log ====================
    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click
        Dim frmSettings As New FrmScoreboardSetting()
        frmSettings.ShowDialog()
    End Sub

    Private Sub BtnLogActivity_Click(sender As Object, e As EventArgs) Handles BtnLogActivity.Click
        Dim frmLog As New Log_Activity() ' Pastikan nama class-nya sesuai (Log_Activity atau LogActivity)
        frmLog.ShowDialog()
    End Sub

    Private Sub BtnShortcut_Click(sender As Object, e As EventArgs) Handles BtnShortcut.Click
        Dim frmShortcut As New Shortcut()
        frmShortcut.ShowDialog()
    End Sub

    ' ==================== Buka Jendela Hantei (Manual Decision) ====================
    Private Sub BtnHantei_Click(sender As Object, e As EventArgs) Handles BtnHantei.Click
        Dim frmDecision As New ManualDecision()
        frmDecision.ShowDialog()
    End Sub

    ' ==================== Form Closed (Penting untuk alur aplikasi) ====================
    ' Jangan lupa tambahkan ini agar saat Kumite ditutup, aplikasi kembali ke Dashboard
    Private Sub Kumite_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Show()
    End Sub

    Private Sub DgvAkaHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvAkaHistory.CellContentClick, DgvAkaHistory.CellContentClick

    End Sub
End Class