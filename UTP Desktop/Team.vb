Public Class Team

    Private Sub Team_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' TODO: Load data dari database ke DataGridViewTeam
        ' TODO: Update LabelTotalRecords
    End Sub

    ' --- AREA FORM INPUT ---

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        ' TODO: Validasi data (TextBoxTeam, TextBoxTeamInfo)
        ' TODO: Jika LabelNew.Text = "NEW" -> Insert data tim baru ke database
        ' TODO: Jika LabelNew.Text = "EDIT" -> Update data tim
        ' TODO: Refresh DataGridViewTeam
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        ' Kosongkan form input
        TextBoxTeam.Clear()
        TextBoxTeamInfo.Clear()
        CheckBoxUseFlag.Checked = False
        ComboBoxCountry.SelectedIndex = 0
        PictureBoxTeam.Image = Nothing
        LabelNew.Text = "NEW"
    End Sub

    Private Sub CheckBoxUseFlag_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxUseFlag.CheckedChanged
        ' TODO: Jika CheckBoxUseFlag dicentang, aktifkan ComboBoxCountry dan disabled ButtonSelectPic
        ' TODO: Jika tidak dicentang, nonaktifkan ComboBoxCountry dan izinkan user memilih gambar manual via ButtonSelectPic
    End Sub

    Private Sub ButtonSelectPic_Click(sender As Object, e As EventArgs) Handles ButtonSelectPic.Click
        ' TODO: Buka OpenFileDialog dan set gambar ke PictureBoxTeam
    End Sub

    ' --- AREA PENCARIAN & EXPORT/IMPORT ---

    Private Sub ButtonExportExcel_Click(sender As Object, e As EventArgs) Handles ButtonExportExcel.Click
        ' TODO: Proses export data dari DataGridViewTeam ke Excel
    End Sub

    Private Sub ButtonImportExcel_Click(sender As Object, e As EventArgs) Handles ButtonImportExcel.Click
        ' TODO: Baca file Excel dan simpan record ke database Team
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        ' TODO: Filter DataGridViewTeam sesuai isi TextBoxSearch
    End Sub

    Private Sub ButtonClearSearch_Click(sender As Object, e As EventArgs) Handles ButtonClearSearch.Click
        TextBoxSearch.Clear()
        ' TODO: Load kembali semua data tim tanpa filter
    End Sub

    ' --- AREA DATAGRIDVIEW & DELETE ---

    Private Sub DataGridViewTeam_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewTeam.CellContentClick
        ' Abaikan jika header yang diklik
        If e.RowIndex < 0 Then Return

        ' Cek jika yang diklik adalah kolom tombol DELETE (ColDelete)
        If e.ColumnIndex = DataGridViewTeam.Columns("ColDelete").Index Then
            ' TODO: Konfirmasi penghapusan dan eksekusi query DELETE
            ' TODO: Refresh DataGridViewTeam

            ' Cek jika yang diklik adalah kolom tombol EDIT (ColEdit)
        ElseIf e.ColumnIndex = DataGridViewTeam.Columns("ColEdit").Index Then
            ' TODO: Ambil nilai baris (row) ini, lempar ke TextBoxTeam, TextBoxTeamInfo, dsb
            ' Ubah status teks menjadi edit
            LabelNew.Text = "EDIT"
        End If
    End Sub

    Private Sub ButtonDeleteAll_Click(sender As Object, e As EventArgs) Handles ButtonDeleteAll.Click
        ' TODO: Tampilkan prompt MessageBox peringatan keras!
        ' TODO: Eksekusi TRUNCATE atau DELETE ALL untuk data Team (hati-hati dengan relasi ke data Competitor)
        ' TODO: Refresh DataGridViewTeam
    End Sub

End Class