Imports System.Data.SQLite
Imports System.IO

Public Class Team
    Dim connString As String = "Data Source=DB_Karate.sqlite;Version=3;"
    Dim selectedTeamId As Integer = 0

    Private Sub Team_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewTeam.AutoGenerateColumns = False

        ColTeamName.DataPropertyName = "TeamName"
        ColInfo.DataPropertyName = "TeamInfo"
        ColPict.DataPropertyName = "Pict"

        BuatTabelOtomatis()
        LoadDataTeam()
    End Sub

    Private Sub BuatTabelOtomatis()
        Using conn As New SQLiteConnection(connString)
            conn.Open()
            Dim query As String = "CREATE TABLE IF NOT EXISTS Team (
                                    ID INTEGER PRIMARY KEY AUTOINCREMENT, 
                                    TeamName TEXT, 
                                    TeamInfo TEXT, 
                                    UseFlag INTEGER, 
                                    Country TEXT, 
                                    Pict BLOB)"
            Using cmd As New SQLiteCommand(query, conn)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub LoadDataTeam(Optional keyword As String = "")
        Using conn As New SQLiteConnection(connString)
            Dim query As String = "SELECT ID, TeamName, TeamInfo, Pict FROM Team WHERE TeamName LIKE @search OR TeamInfo LIKE @search"
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@search", "%" & keyword & "%")
                Dim adapter As New SQLiteDataAdapter(cmd)
                Dim dt As New DataTable()

                Try
                    conn.Open()
                    adapter.Fill(dt)
                    DataGridViewTeam.DataSource = dt

                    ' Ini sebenarnya tidak diperlukan lagi, tapi dibiarkan untuk keamanan
                    If DataGridViewTeam.Columns.Contains("ID") Then DataGridViewTeam.Columns("ID").Visible = False

                    LabelTotalRecords.Text = "Total Records : " & dt.Rows.Count.ToString()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub CheckBoxUseFlag_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxUseFlag.CheckedChanged
        ComboBoxCountry.Enabled = CheckBoxUseFlag.Checked
        If Not CheckBoxUseFlag.Checked Then ComboBoxCountry.SelectedIndex = -1
    End Sub

    Private Sub ButtonSelectPic_Click(sender As Object, e As EventArgs) Handles ButtonSelectPic.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If ofd.ShowDialog() = DialogResult.OK Then
            PictureBoxTeam.Image = Image.FromFile(ofd.FileName)
            PictureBoxTeam.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxTeam.Clear()
        TextBoxTeamInfo.Clear()
        CheckBoxUseFlag.Checked = False
        ComboBoxCountry.SelectedIndex = -1
        PictureBoxTeam.Image = Nothing
        LabelNew.Text = "NEW"
        selectedTeamId = 0
        TextBoxTeam.Focus()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        If String.IsNullOrWhiteSpace(TextBoxTeam.Text) Then
            MessageBox.Show("Nama Team harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim imgBytes As Byte() = Nothing
        If PictureBoxTeam.Image IsNot Nothing Then
            Using ms As New MemoryStream()
                PictureBoxTeam.Image.Save(ms, PictureBoxTeam.Image.RawFormat)
                imgBytes = ms.ToArray()
            End Using
        End If

        Using conn As New SQLiteConnection(connString)
            Dim query As String
            If LabelNew.Text = "NEW" Then
                query = "INSERT INTO Team (TeamName, TeamInfo, UseFlag, Country, Pict) VALUES (@name, @info, @flag, @country, @pict)"
            Else
                query = "UPDATE Team SET TeamName=@name, TeamInfo=@info, UseFlag=@flag, Country=@country, Pict=@pict WHERE ID=@id"
            End If

            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", TextBoxTeam.Text)
                cmd.Parameters.AddWithValue("@info", TextBoxTeamInfo.Text)
                cmd.Parameters.AddWithValue("@flag", If(CheckBoxUseFlag.Checked, 1, 0))
                cmd.Parameters.AddWithValue("@country", If(ComboBoxCountry.SelectedItem IsNot Nothing, ComboBoxCountry.Text, DBNull.Value))

                If imgBytes IsNot Nothing Then
                    cmd.Parameters.AddWithValue("@pict", imgBytes)
                Else
                    cmd.Parameters.AddWithValue("@pict", DBNull.Value)
                End If

                If LabelNew.Text = "EDIT" Then cmd.Parameters.AddWithValue("@id", selectedTeamId)

                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ButtonClear.PerformClick()
                LoadDataTeam()
            End Using
        End Using
    End Sub

    Private Sub DataGridViewTeam_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewTeam.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridViewTeam.Rows(e.RowIndex)

            ' CARA BENAR MENGAMBIL ID: Ambil dari DataRowView (sumber datanya), bukan dari row grid-nya.
            Dim drv As DataRowView = CType(row.DataBoundItem, DataRowView)
            selectedTeamId = Convert.ToInt32(drv("ID"))

            Dim namaKolom As String = DataGridViewTeam.Columns(e.ColumnIndex).Name

            ' Mengecek aksi berdasarkan nama kolom (Lebih Aman)
            If namaKolom = "ColDelete" Then
                If MessageBox.Show("Yakin hapus tim ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Using conn As New SQLiteConnection(connString)
                        Using cmd As New SQLiteCommand("DELETE FROM Team WHERE ID=@id", conn)
                            cmd.Parameters.AddWithValue("@id", selectedTeamId)
                            conn.Open()
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using
                    LoadDataTeam()
                End If

            ElseIf namaKolom = "ColEdit" Then
                LabelNew.Text = "EDIT"

                ' Mengambil data juga menggunakan DataRowView agar pasti terbaca
                TextBoxTeam.Text = drv("TeamName").ToString()
                TextBoxTeamInfo.Text = drv("TeamInfo").ToString()

                If Not IsDBNull(drv("Pict")) AndAlso drv("Pict") IsNot Nothing Then
                    Dim imgBytes As Byte() = CType(drv("Pict"), Byte())
                    Using ms As New MemoryStream(imgBytes)
                        PictureBoxTeam.Image = Image.FromStream(ms)
                        PictureBoxTeam.SizeMode = PictureBoxSizeMode.Zoom
                    End Using
                Else
                    PictureBoxTeam.Image = Nothing
                End If
            End If
        End If
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        LoadDataTeam(TextBoxSearch.Text)
    End Sub

    Private Sub ButtonClearSearch_Click(sender As Object, e As EventArgs) Handles ButtonClearSearch.Click
        TextBoxSearch.Clear()
        LoadDataTeam()
    End Sub

    Private Sub ButtonDeleteAll_Click(sender As Object, e As EventArgs) Handles ButtonDeleteAll.Click
        If MessageBox.Show("Hapus SEMUA data tim?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then
            Using conn As New SQLiteConnection(connString)
                Using cmd As New SQLiteCommand("DELETE FROM Team", conn)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            LoadDataTeam()
        End If
    End Sub

    Private Sub ButtonExportExcel_Click(sender As Object, e As EventArgs) Handles ButtonExportExcel.Click
        Dim sfd As New SaveFileDialog() With {.Filter = "Excel CSV (*.csv)|*.csv", .FileName = "DataTeam.csv"}
        If sfd.ShowDialog() = DialogResult.OK Then
            Dim sb As New System.Text.StringBuilder()
            sb.AppendLine("ID,TeamName,TeamInfo")
            For Each row As DataGridViewRow In DataGridViewTeam.Rows
                If Not row.IsNewRow Then
                    ' Gunakan DataBoundItem agar nilainya pasti valid saat diexport
                    Dim drv As DataRowView = CType(row.DataBoundItem, DataRowView)
                    Dim id = drv("ID").ToString()
                    Dim nama = drv("TeamName")?.ToString().Replace(",", " ")
                    Dim info = drv("TeamInfo")?.ToString().Replace(",", " ")
                    sb.AppendLine($"{id},{nama},{info}")
                End If
            Next
            File.WriteAllText(sfd.FileName, sb.ToString())
            MessageBox.Show("Berhasil Export ke Excel (CSV)!", "Sukses")
        End If
    End Sub

    Private Sub ButtonImportExcel_Click(sender As Object, e As EventArgs) Handles ButtonImportExcel.Click
        Dim ofd As New OpenFileDialog() With {.Filter = "Excel CSV (*.csv)|*.csv"}
        If ofd.ShowDialog() = DialogResult.OK Then
            Dim lines As String() = File.ReadAllLines(ofd.FileName)
            Using conn As New SQLiteConnection(connString)
                conn.Open()
                For i As Integer = 1 To lines.Length - 1
                    Dim cols As String() = lines(i).Split(","c)
                    If cols.Length >= 3 Then
                        Using cmd As New SQLiteCommand("INSERT INTO Team (TeamName, TeamInfo) VALUES (@nama, @info)", conn)
                            cmd.Parameters.AddWithValue("@nama", cols(1))
                            cmd.Parameters.AddWithValue("@info", cols(2))
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                Next
            End Using
            MessageBox.Show("Data berhasil di-import!", "Sukses")
            LoadDataTeam()
        End If
    End Sub

End Class