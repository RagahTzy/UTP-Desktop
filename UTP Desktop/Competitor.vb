Imports MySql.Data.MySqlClient

Public Class Competitor
    Dim connString As String = "server=localhost;user=root;password=;database=db_snek_track"

    Private Sub Competitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTeamsToComboBox()
        RefreshData()
        lblNewStatus.Text = "NEW"
    End Sub

    Private Sub LoadTeamsToComboBox()
        Using conn As New MySqlConnection(connString)
            Try
                Dim adapter As New MySqlDataAdapter("SELECT team_name FROM team", conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                cbTeam.DataSource = dt
                cbTeam.DisplayMember = "team_name"
                cbTeam.ValueMember = "team_name"
                cbTeam.SelectedIndex = -1
            Catch ex As Exception
            End Try
        End Using
    End Sub

    Private Sub RefreshData(Optional keyword As String = "")
        Dim query As String = "SELECT * FROM competitor"
        If Not String.IsNullOrEmpty(keyword) Then
            query &= " WHERE comp_name LIKE @key OR team_name LIKE @key"
        End If

        Using conn As New MySqlConnection(connString)
            Try
                Dim adapter As New MySqlDataAdapter(query, conn)
                adapter.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvCompetitors.DataSource = dt
                lblTotalRecords.Text = "Total: " & dgvCompetitors.RowCount
            Catch ex As Exception
                MsgBox("Gagal muat data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtName.Text = "" Or cbTeam.Text = "" Then
            MsgBox("Nama dan Tim wajib diisi!")
            Return
        End If

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim sql As String = ""

                If lblNewStatus.Text = "NEW" Then
                    sql = "INSERT INTO competitor (comp_name, team_name, comp_info) VALUES (@name, @team, @info)"
                Else
                    sql = "UPDATE competitor SET team_name=@team, comp_info=@info WHERE comp_name=@name"
                End If

                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@name", txtName.Text)
                cmd.Parameters.AddWithValue("@team", cbTeam.Text)
                cmd.Parameters.AddWithValue("@info", txtTeamInfo.Text)
                cmd.ExecuteNonQuery()

                MsgBox("Data berhasil disimpan!")
                btnClear_Click(Nothing, Nothing)
                RefreshData()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtName.Enabled = True
        cbTeam.SelectedIndex = -1
        txtTeamInfo.Clear()
        pbProfilePic.Image = Nothing
        lblNewStatus.Text = "NEW"
    End Sub

    Private Sub btnEditTeam_Click(sender As Object, e As EventArgs) Handles btnEditTeam.Click
        Dim frmTeam As New Team()
        frmTeam.ShowDialog()
        LoadTeamsToComboBox()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        RefreshData(txtSearch.Text)
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearch.Clear()
        RefreshData()
    End Sub

    Private Sub dgvCompetitors_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCompetitors.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvCompetitors.Rows(e.RowIndex)
            txtName.Text = row.Cells(0).Value.ToString()
            cbTeam.Text = row.Cells(1).Value.ToString()
            txtName.Enabled = False
            lblNewStatus.Text = "EDIT"
        End If
    End Sub

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        If MsgBox("Yakin hapus semua data kompetitor?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Using conn As New MySqlConnection(connString)
                Try
                    Dim cmd As New MySqlCommand("DELETE FROM competitor", conn)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    RefreshData()
                Catch ex As Exception
                    MsgBox("Gagal hapus: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    Private Sub cbTeam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTeam.SelectedIndexChanged
    End Sub

    Private Sub btnSelectPic_Click(sender As Object, e As EventArgs) Handles btnSelectPic.Click
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
    End Sub

    Private Sub btnImportExcel_Click(sender As Object, e As EventArgs) Handles btnImportExcel.Click
    End Sub

    Private Sub dgvTeams_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTeams.CellContentClick
    End Sub
End Class