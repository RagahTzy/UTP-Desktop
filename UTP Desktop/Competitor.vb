Public Class Competitor

    Private Sub Competitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' TODO: Load daftar tim dari database ke cbTeam
        ' TODO: Load data kompetitor dari database ke dgvCompetitors
        ' TODO: Load jumlah records ke lblTotalRecords
    End Sub

    ' --- AREA FORM INPUT ---

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' TODO: Validasi inputan (txtName, cbTeam)
        ' TODO: Jika lblNewStatus.Text = "NEW" -> Insert data kompetitor baru
        ' TODO: Jika lblNewStatus.Text = "EDIT" -> Update data kompetitor
        ' TODO: Refresh DataGridView dgvCompetitors dan kosongkan form
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' TODO: Kosongkan txtName, cbTeam, txtTeamInfo
        ' TODO: Hapus gambar dari pbProfilePic
        lblNewStatus.Text = "NEW"
    End Sub

    Private Sub cbTeam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTeam.SelectedIndexChanged
        ' TODO: Saat user memilih Tim, ambil "Team Info" dari database 
        ' TODO: Tampilkan informasi tim tersebut di txtTeamInfo
    End Sub

    Private Sub btnEditTeam_Click(sender As Object, e As EventArgs) Handles btnEditTeam.Click
        ' Membuka Form Team sebagai Dialog (jendela mengunci form competitor)
        Dim frmTeam As New Team()
        frmTeam.ShowDialog()

        ' TODO: (Jalankan setelah jendela Team ditutup)
        ' Refresh/Reload daftar tim di cbTeam agar tim yang baru saja ditambah/diedit langsung muncul
    End Sub

    Private Sub btnSelectPic_Click(sender As Object, e As EventArgs) Handles btnSelectPic.Click
        ' TODO: Buka OpenFileDialog, pilih gambar, dan setel ke pbProfilePic
    End Sub

    ' --- AREA PENCARIAN & EXPORT/IMPORT ---

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' TODO: Filter dgvCompetitors berdasarkan kata kunci di txtSearch
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearch.Clear()
        ' TODO: Load kembali semua data dgvCompetitors tanpa filter
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        ' TODO: Export data di dgvCompetitors ke file Excel (.xlsx)
    End Sub

    Private Sub btnImportExcel_Click(sender As Object, e As EventArgs) Handles btnImportExcel.Click
        ' TODO: Buka OpenFileDialog untuk Excel, baca isinya, simpan ke database/dgvCompetitors
    End Sub

    ' --- AREA DATAGRIDVIEW & DELETE ---

    Private Sub dgvCompetitors_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCompetitors.CellContentClick
        ' TODO: Handle jika user mengklik cell tertentu (contoh: baris mana yang mau diedit)
        ' Lalu pindahkan data dari cell ke txtName, cbTeam, pbProfilePic
        ' lblNewStatus.Text = "EDIT"
    End Sub

    Private Sub dgvTeams_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTeams.CellContentClick
        ' TODO: Handle filter spesifik jika user mengklik daftar tim di dgvTeams (sebelah kiri)
        ' Tampilkan hanya anggota dari tim tersebut di dgvCompetitors
    End Sub

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        ' TODO: Beri MessageBox peringatan Konfirmasi Penghapusan
        ' TODO: Hapus semua data dari tabel Competitor
        ' TODO: Refresh DataGridView
    End Sub

End Class