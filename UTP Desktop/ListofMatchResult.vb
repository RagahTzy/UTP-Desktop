Imports System.Data.SQLite

Public Class ListofMatchResult
    Private Sub ListofMatchResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default date range: from start of current month to today
        DtFrom.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        DtTo.Value = DateTime.Now
        CboType.SelectedIndex = 0
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            Using conn As New SQLiteConnection("Data Source=DB_Karate.sqlite;Version=3;")
                conn.Open()
                ' SQL to select all required data
                Dim sql As String = "SELECT Id, Tatami, MatchType, DATE(MatchDateTime) as MatchDate, AkaName, AkaTeam, AkaScore, 'VS' as VS, AoScore, AoName, AoTeam, Winner FROM MatchResult WHERE 1=1"
                
                ' Filter Match Type
                If CboType.Text <> "ALL" Then
                    sql &= " AND MatchType = @type"
                End If
                
                ' Filter Date Range
                sql &= " AND DATE(MatchDateTime) BETWEEN @from AND @to"
                
                ' Filter Search Text
                If Not String.IsNullOrEmpty(TxtSearch.Text) Then
                    sql &= " AND (AkaName LIKE @search OR AoName LIKE @search OR Category LIKE @search OR AkaTeam LIKE @search OR AoTeam LIKE @search)"
                End If
                
                sql &= " ORDER BY Id DESC"
                
                Using cmd As New SQLiteCommand(sql, conn)
                    If CboType.Text <> "ALL" Then
                        cmd.Parameters.AddWithValue("@type", CboType.Text)
                    End If
                    
                    cmd.Parameters.AddWithValue("@from", DtFrom.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@to", DtTo.Value.ToString("yyyy-MM-dd"))
                    
                    If Not String.IsNullOrEmpty(TxtSearch.Text) Then
                        cmd.Parameters.AddWithValue("@search", "%" & TxtSearch.Text & "%")
                    End If
                    
                    Dim dt As New DataTable()
                    Using adapter As New SQLiteDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                    
                    ' Clear current columns to force regeneration
                    DgvResults.DataSource = Nothing
                    DgvResults.Columns.Clear()
                    
                    ' Add Button Columns first
                    Dim btnDeleteCol As New DataGridViewButtonColumn()
                    btnDeleteCol.Name = "BtnDeleteRow"
                    btnDeleteCol.HeaderText = "Delete"
                    btnDeleteCol.Text = "🗑️"
                    btnDeleteCol.UseColumnTextForButtonValue = True
                    btnDeleteCol.Width = 50
                    DgvResults.Columns.Add(btnDeleteCol)

                    Dim btnViewCol As New DataGridViewButtonColumn()
                    btnViewCol.Name = "BtnViewRow"
                    btnViewCol.HeaderText = "Details"
                    btnViewCol.Text = "👁️"
                    btnViewCol.UseColumnTextForButtonValue = True
                    btnViewCol.Width = 50
                    DgvResults.Columns.Add(btnViewCol)

                    DgvResults.DataSource = dt
                End Using
            End Using
            
            ' Formatting Columns
            FormatGrid()
            
        Catch ex As Exception
            MessageBox.Show("Error loading match results: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormatGrid()
        ' Ensure columns are generated
        If DgvResults.Columns.Count > 0 Then
            ' Style the Header
            DgvResults.EnableHeadersVisualStyles = False
            Dim headerStyle As New DataGridViewCellStyle()
            headerStyle.BackColor = Color.FromArgb(45, 45, 48)
            headerStyle.ForeColor = Color.White
            headerStyle.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DgvResults.ColumnHeadersDefaultCellStyle = headerStyle
            DgvResults.ColumnHeadersHeight = 45

            ' Renaming and ordering
            If DgvResults.Columns.Contains("Id") Then
                DgvResults.Columns("Id").HeaderText = "No"
                DgvResults.Columns("Id").Width = 40
                DgvResults.Columns("Id").DisplayIndex = 0
            End If

            If DgvResults.Columns.Contains("BtnDeleteRow") Then DgvResults.Columns("BtnDeleteRow").DisplayIndex = 1
            If DgvResults.Columns.Contains("BtnViewRow") Then DgvResults.Columns("BtnViewRow").DisplayIndex = 2

            If DgvResults.Columns.Contains("Tatami") Then 
                DgvResults.Columns("Tatami").HeaderText = "Tatami"
                DgvResults.Columns("Tatami").Width = 60
            End If
            
            If DgvResults.Columns.Contains("MatchType") Then 
                DgvResults.Columns("MatchType").HeaderText = "Type"
                DgvResults.Columns("MatchType").Width = 70
            End If

            If DgvResults.Columns.Contains("MatchDate") Then 
                DgvResults.Columns("MatchDate").HeaderText = "Match Date"
                DgvResults.Columns("MatchDate").Width = 90
            End If

            If DgvResults.Columns.Contains("AkaName") Then DgvResults.Columns("AkaName").HeaderText = "Name (AKA)"
            If DgvResults.Columns.Contains("AkaTeam") Then DgvResults.Columns("AkaTeam").HeaderText = "Team (AKA)"
            
            If DgvResults.Columns.Contains("AkaScore") Then
                DgvResults.Columns("AkaScore").HeaderText = "Score (AKA)"
                DgvResults.Columns("AkaScore").Width = 50
                DgvResults.Columns("AkaScore").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If
            
            If DgvResults.Columns.Contains("VS") Then
                DgvResults.Columns("VS").HeaderText = "Vs"
                DgvResults.Columns("VS").Width = 30
                DgvResults.Columns("VS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If

            If DgvResults.Columns.Contains("AoName") Then DgvResults.Columns("AoName").HeaderText = "Name (AO)"
            If DgvResults.Columns.Contains("AoTeam") Then DgvResults.Columns("AoTeam").HeaderText = "Team (AO)"
            
            If DgvResults.Columns.Contains("AoScore") Then
                DgvResults.Columns("AoScore").HeaderText = "Score (AO)"
                DgvResults.Columns("AoScore").Width = 50
                DgvResults.Columns("AoScore").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If
            
            If DgvResults.Columns.Contains("Winner") Then 
                DgvResults.Columns("Winner").HeaderText = "Winner"
                DgvResults.Columns("Winner").DefaultCellStyle.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            End If

            ' Row Styling
            DgvResults.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)
            DgvResults.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue
            DgvResults.DefaultCellStyle.SelectionForeColor = Color.White
            DgvResults.RowHeadersVisible = False
        End If
    End Sub

    Private Sub DgvResults_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvResults.CellContentClick
        If e.RowIndex < 0 Then Return

        If DgvResults.Columns(e.ColumnIndex).Name = "BtnDeleteRow" Then
            Dim id As Integer = CInt(DgvResults.Rows(e.RowIndex).Cells("Id").Value)
            Dim aka As String = DgvResults.Rows(e.RowIndex).Cells("AkaName").Value.ToString()
            Dim ao As String = DgvResults.Rows(e.RowIndex).Cells("AoName").Value.ToString()

            If MessageBox.Show($"Delete match result between {aka} and {ao}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                DeleteRecord(id)
            End If
        End If

        If DgvResults.Columns(e.ColumnIndex).Name = "BtnViewRow" Then
            Dim aka As String = DgvResults.Rows(e.RowIndex).Cells("AkaName").Value.ToString()
            Dim ao As String = DgvResults.Rows(e.RowIndex).Cells("AoName").Value.ToString()
            Dim akaTeam As String = DgvResults.Rows(e.RowIndex).Cells("AkaTeam").Value.ToString()
            Dim aoTeam As String = DgvResults.Rows(e.RowIndex).Cells("AoTeam").Value.ToString()
            Dim winner As String = DgvResults.Rows(e.RowIndex).Cells("Winner").Value.ToString()
            Dim type As String = DgvResults.Rows(e.RowIndex).Cells("MatchType").Value.ToString()
            
            MessageBox.Show($"Match Details ({type}):" & vbCrLf &
                            $"AKA: {aka} [{akaTeam}] (Score: {DgvResults.Rows(e.RowIndex).Cells("AkaScore").Value})" & vbCrLf &
                            $"AO: {ao} [{aoTeam}] (Score: {DgvResults.Rows(e.RowIndex).Cells("AoScore").Value})" & vbCrLf &
                            $"Winner: {winner}", "Match Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub DeleteRecord(id As Integer)
        Try
            Using conn As New SQLiteConnection("Data Source=DB_Karate.sqlite;Version=3;")
                conn.Open()
                Using cmd As New SQLiteCommand("DELETE FROM MatchResult WHERE Id = @id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Error deleting: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnApplyFilter_Click(sender As Object, e As EventArgs) Handles BtnApplyFilter.Click
        LoadData()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnExportExcel_Click(sender As Object, e As EventArgs) Handles BtnExportExcel.Click
        MessageBox.Show("Export to Excel feature triggered." & vbCrLf & "Data will be exported based on current filter.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If DgvResults.SelectedRows.Count > 0 Then
            If MessageBox.Show("Are you sure you want to delete the selected result?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Try
                    Dim id As Integer = CInt(DgvResults.SelectedRows(0).Cells("Id").Value)
                    Using conn As New SQLiteConnection("Data Source=DB_Karate.sqlite;Version=3;")
                        conn.Open()
                        Using cmd As New SQLiteCommand("DELETE FROM MatchResult WHERE Id = @id", conn)
                            cmd.Parameters.AddWithValue("@id", id)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using
                    LoadData()
                Catch ex As Exception
                    MessageBox.Show("Error deleting: " & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub BtnClearAll_Click(sender As Object, e As EventArgs) Handles BtnClearAll.Click
        If MessageBox.Show("DANGER: Clear all match results permanently?", "Confirm Clear All", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = DialogResult.Yes Then
            Try
                Using conn As New SQLiteConnection("Data Source=DB_Karate.sqlite;Version=3;")
                    conn.Open()
                    Using cmd As New SQLiteCommand("DELETE FROM MatchResult", conn)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                LoadData()
            Catch ex As Exception
                MessageBox.Show("Error clearing: " & ex.Message)
            End Try
        End If
    End Sub
End Class
