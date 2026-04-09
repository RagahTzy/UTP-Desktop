Public Class Team

    Private Sub Team_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTotalRecords()
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxTeam.Clear()
        TextBoxTeamInfo.Clear()
        CheckBoxUseFlag.Checked = False
        ComboBoxCountry.SelectedIndex = -1
        ComboBoxCountry.Text = "--select--"
        PictureBoxTeam.Image = Nothing
        LabelNew.Text = "NEW"
        TextBoxTeam.Focus()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        If String.IsNullOrWhiteSpace(TextBoxTeam.Text) Then
            MessageBox.Show("Team harus diisi dulu ya!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        DataGridViewTeam.Rows.Add(Nothing, Nothing, TextBoxTeam.Text, TextBoxTeamInfo.Text, "Punya Gambar")
        
        MessageBox.Show("Yeay! Tim " & TextBoxTeam.Text & " berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        
        ButtonClear_Click(sender, e)
        UpdateTotalRecords()
    End Sub

    Private Sub DataGridViewTeam_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewTeam.CellContentClick
        If e.RowIndex >= 0 Then
            
            If e.ColumnIndex = 0 Then
                Dim result = MessageBox.Show("Yakin pengen ngehapus tim ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    DataGridViewTeam.Rows.RemoveAt(e.RowIndex)
                    UpdateTotalRecords()
                End If
                
            ElseIf e.ColumnIndex = 1 Then
                Dim row As DataGridViewRow = DataGridViewTeam.Rows(e.RowIndex)
                
                TextBoxTeam.Text = row.Cells(2).Value?.ToString()
                TextBoxTeamInfo.Text = row.Cells(3).Value?.ToString()
                LabelNew.Text = "EDIT"
                
                DataGridViewTeam.Rows.RemoveAt(e.RowIndex)
                UpdateTotalRecords()
            End If
            
        End If
    End Sub

    Private Sub UpdateTotalRecords()
        Dim jumlah As Integer = DataGridViewTeam.Rows.Count
        If DataGridViewTeam.AllowUserToAddRows Then jumlah -= 1
        
        LabelTotalRecords.Text = "Total Records : " & Math.Max(0, jumlah).ToString()
    End Sub

    Private Sub ButtonDeleteAll_Click(sender As Object, e As EventArgs) Handles ButtonDeleteAll.Click
        If DataGridViewTeam.Rows.Count > 0 Then
            Dim konfirmasi = MessageBox.Show("AWAS! Yakin mau hapus semua data?", "Konfirmasi Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If konfirmasi = DialogResult.Yes Then
                DataGridViewTeam.Rows.Clear()
                UpdateTotalRecords()
            End If
        End If
    End Sub

    Private Sub ButtonSelectPic_Click(sender As Object, e As EventArgs) Handles ButtonSelectPic.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Pilih Gambar (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"
        
        If ofd.ShowDialog() = DialogResult.OK Then
            PictureBoxTeam.Image = Image.FromFile(ofd.FileName)
            PictureBoxTeam.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        Dim kataKunci As String = TextBoxSearch.Text.ToLower()
        
        For Each baris As DataGridViewRow In DataGridViewTeam.Rows
            If Not baris.IsNewRow Then
                Dim namaTeam As String = baris.Cells(2).Value?.ToString().ToLower()
                If namaTeam IsNot Nothing AndAlso namaTeam.Contains(kataKunci) Then
                    baris.Visible = True
                Else
                    baris.Visible = False
                End If
            End If
        Next
    End Sub

    Private Sub ButtonClearSearch_Click(sender As Object, e As EventArgs) Handles ButtonClearSearch.Click
        TextBoxSearch.Clear()
        For Each baris As DataGridViewRow In DataGridViewTeam.Rows
            If Not baris.IsNewRow Then
                baris.Visible = True
            End If
        Next
    End Sub

    Private Sub CheckBoxUseFlag_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxUseFlag.CheckedChanged
        If CheckBoxUseFlag.Checked Then
            ComboBoxCountry.Enabled = True
            ButtonSelectPic.Enabled = False
        Else
            ComboBoxCountry.Enabled = False
            ButtonSelectPic.Enabled = True
        End If
    End Sub

    Private Sub ButtonExportExcel_Click(sender As Object, e As EventArgs) Handles ButtonExportExcel.Click
        
    End Sub

    Private Sub ButtonImportExcel_Click(sender As Object, e As EventArgs) Handles ButtonImportExcel.Click
        
    End Sub

End Class