Imports System.Data.SQLite
Imports System.IO

Public Class Competitor
    Dim connString As String = "Data Source=DB_Karate.sqlite;Version=3;"
    Dim selectedCompetitorId As Integer = 0

    Private Sub Competitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCompetitors.AutoGenerateColumns = False
        colName.DataPropertyName = "Name"
        colTeam.DataPropertyName = "TeamName"
        colTeamInfo.DataPropertyName = "TeamInfo"
        colCompPict.DataPropertyName = "ProfilePic"

        BuatTabelOtomatis()
        LoadDropdownTeam()
        LoadGridTeams()
        RefreshData()
        lblNewStatus.Text = "NEW"
    End Sub

    Private Sub BuatTabelOtomatis()
        Using conn As New SQLiteConnection(connString)
            conn.Open()
            Dim query As String = "CREATE TABLE IF NOT EXISTS Competitor (
                                    ID INTEGER PRIMARY KEY AUTOINCREMENT, 
                                    Name TEXT, 
                                    TeamName TEXT, 
                                    TeamInfo TEXT, 
                                    ProfilePic BLOB)"
            Using cmd As New SQLiteCommand(query, conn)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub LoadDropdownTeam()
        Using conn As New SQLiteConnection(connString)
            Try
                Dim adapter As New SQLiteDataAdapter("SELECT TeamName, TeamInfo FROM Team", conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                cbTeam.DataSource = dt
                cbTeam.DisplayMember = "TeamName"
                cbTeam.ValueMember = "TeamName"
                cbTeam.SelectedIndex = -1
            Catch ex As Exception
            End Try
        End Using
    End Sub

    Private Sub LoadGridTeams()
        Using conn As New SQLiteConnection(connString)
            Try
                Dim adapter As New SQLiteDataAdapter("SELECT TeamName FROM Team", conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvTeams.DataSource = dt
            Catch ex As Exception
            End Try
        End Using
    End Sub

    Private Sub RefreshData(Optional keyword As String = "", Optional filterTeam As String = "")
        Dim query As String = "SELECT ID, Name, TeamName, TeamInfo, ProfilePic FROM Competitor WHERE (Name LIKE @key OR TeamName LIKE @key)"
        If Not String.IsNullOrEmpty(filterTeam) Then
            query &= " AND TeamName = @filterTeam"
        End If

        Using conn As New SQLiteConnection(connString)
            Try
                Dim cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@key", "%" & keyword & "%")
                If Not String.IsNullOrEmpty(filterTeam) Then cmd.Parameters.AddWithValue("@filterTeam", filterTeam)

                Dim adapter As New SQLiteDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvCompetitors.DataSource = dt
                If dgvCompetitors.Columns.Contains("ID") Then dgvCompetitors.Columns("ID").Visible = False

                lblTotalRecords.Text = "Total: " & dgvCompetitors.RowCount
            Catch ex As Exception
                MessageBox.Show("Gagal muat data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub cbTeam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTeam.SelectedIndexChanged
        If cbTeam.SelectedIndex <> -1 AndAlso TypeOf cbTeam.SelectedItem Is DataRowView Then
            Dim row As DataRowView = CType(cbTeam.SelectedItem, DataRowView)
            txtTeamInfo.Text = row("TeamInfo").ToString()
        End If
    End Sub

    Private Sub btnSelectPic_Click(sender As Object, e As EventArgs) Handles btnSelectPic.Click
        Dim ofd As New OpenFileDialog() With {.Filter = "Image Files|*.jpg;*.png;*.jpeg"}
        If ofd.ShowDialog() = DialogResult.OK Then
            pbProfilePic.Image = Image.FromFile(ofd.FileName)
            pbProfilePic.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        cbTeam.SelectedIndex = -1
        txtTeamInfo.Clear()
        pbProfilePic.Image = Nothing
        lblNewStatus.Text = "NEW"
        selectedCompetitorId = 0
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtName.Text.Trim() = "" OrElse cbTeam.Text.Trim() = "" Then
            MessageBox.Show("Nama dan Tim wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim imgBytes As Byte() = Nothing
        If pbProfilePic.Image IsNot Nothing Then
            Using ms As New MemoryStream()
                pbProfilePic.Image.Save(ms, pbProfilePic.Image.RawFormat)
                imgBytes = ms.ToArray()
            End Using
        End If

        Using conn As New SQLiteConnection(connString)
            Try
                conn.Open()
                Dim sql As String = ""

                If lblNewStatus.Text = "NEW" Then
                    sql = "INSERT INTO Competitor (Name, TeamName, TeamInfo, ProfilePic) VALUES (@name, @team, @info, @pic)"
                Else
                    sql = "UPDATE Competitor SET Name=@name, TeamName=@team, TeamInfo=@info, ProfilePic=@pic WHERE ID=@id"
                End If

                Dim cmd As New SQLiteCommand(sql, conn)
                cmd.Parameters.AddWithValue("@name", txtName.Text)
                cmd.Parameters.AddWithValue("@team", cbTeam.Text)
                cmd.Parameters.AddWithValue("@info", txtTeamInfo.Text)
                cmd.Parameters.AddWithValue("@pic", If(imgBytes IsNot Nothing, imgBytes, DBNull.Value))

                If lblNewStatus.Text = "EDIT" Then cmd.Parameters.AddWithValue("@id", selectedCompetitorId)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil disimpan!", "Sukses")
                btnClear.PerformClick()
                RefreshData()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub dgvCompetitors_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCompetitors.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvCompetitors.Rows(e.RowIndex)
            selectedCompetitorId = Convert.ToInt32(row.Cells("ID").Value)

            txtName.Text = row.Cells("Name").Value.ToString()
            cbTeam.Text = row.Cells("TeamName").Value.ToString()
            txtTeamInfo.Text = row.Cells("TeamInfo").Value.ToString()
            lblNewStatus.Text = "EDIT"

            If Not IsDBNull(row.Cells("ProfilePic").Value) Then
                Dim imgBytes As Byte() = CType(row.Cells("ProfilePic").Value, Byte())
                Using ms As New MemoryStream(imgBytes)
                    pbProfilePic.Image = Image.FromStream(ms)
                    pbProfilePic.SizeMode = PictureBoxSizeMode.Zoom
                End Using
            Else
                pbProfilePic.Image = Nothing
            End If
        End If
    End Sub

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        If MessageBox.Show("Yakin hapus semua data kompetitor?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then
            Using conn As New SQLiteConnection(connString)
                Try
                    Dim cmd As New SQLiteCommand("DELETE FROM Competitor", conn)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    RefreshData()
                Catch ex As Exception
                    MessageBox.Show("Gagal hapus: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        RefreshData(txtSearch.Text)
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearch.Clear()
        RefreshData()
    End Sub

    Private Sub dgvTeams_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTeams.CellContentClick

        If e.RowIndex >= 0 Then
            Dim teamName As String = dgvTeams.Rows(e.RowIndex).Cells("TeamName").Value.ToString()
            RefreshData("", teamName)
        End If
    End Sub

    Private Sub btnEditTeam_Click(sender As Object, e As EventArgs) Handles btnEditTeam.Click
        Dim frmTeam As New Team()
        frmTeam.ShowDialog()
        LoadDropdownTeam()
        LoadGridTeams()
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        Dim sfd As New SaveFileDialog() With {.Filter = "Excel CSV (*.csv)|*.csv", .FileName = "DataCompetitor.csv"}
        If sfd.ShowDialog() = DialogResult.OK Then
            Dim sb As New System.Text.StringBuilder()
            sb.AppendLine("Name,TeamName,TeamInfo")
            For Each row As DataGridViewRow In dgvCompetitors.Rows
                If Not row.IsNewRow Then
                    Dim nama = row.Cells("Name").Value?.ToString().Replace(",", " ")
                    Dim team = row.Cells("TeamName").Value?.ToString().Replace(",", " ")
                    Dim info = row.Cells("TeamInfo").Value?.ToString().Replace(",", " ")
                    sb.AppendLine($"{nama},{team},{info}")
                End If
            Next
            File.WriteAllText(sfd.FileName, sb.ToString())
            MessageBox.Show("Export ke CSV berhasil!", "Sukses")
        End If
    End Sub

    Private Sub btnImportExcel_Click(sender As Object, e As EventArgs) Handles btnImportExcel.Click
        Dim ofd As New OpenFileDialog() With {.Filter = "Excel CSV (*.csv)|*.csv"}
        If ofd.ShowDialog() = DialogResult.OK Then
            Dim lines As String() = File.ReadAllLines(ofd.FileName)
            Using conn As New SQLiteConnection(connString)
                conn.Open()
                For i As Integer = 1 To lines.Length - 1
                    Dim cols As String() = lines(i).Split(","c)
                    If cols.Length >= 3 Then
                        Using cmd As New SQLiteCommand("INSERT INTO Competitor (Name, TeamName, TeamInfo) VALUES (@nama, @team, @info)", conn)
                            cmd.Parameters.AddWithValue("@nama", cols(0))
                            cmd.Parameters.AddWithValue("@team", cols(1))
                            cmd.Parameters.AddWithValue("@info", cols(2))
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                Next
            End Using
            MessageBox.Show("Import data berhasil!", "Sukses")
            RefreshData()
        End If
    End Sub

    Private Sub Competitor_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Show()
    End Sub
End Class