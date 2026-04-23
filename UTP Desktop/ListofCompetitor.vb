Imports System.Data.SQLite

Public Class ListOfCompetitor

    Dim connString As String = "Data Source=database.db;Version=3;"

    Private Sub ListOfCompetitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTeam()
    End Sub

    ' LOAD TEAM KE LISTBOX
    Private Sub LoadTeam()
        Using conn As New SQLiteConnection(connString)
            conn.Open()

            Dim query As String = "SELECT nama_team FROM team"
            Using cmd As New SQLiteCommand(query, conn)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    ListBoxTeam.Items.Clear()

                    While reader.Read()
                        ListBoxTeam.Items.Add(reader("nama_team").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    ' KLIK TEAM → LOAD DATA GRID
    Private Sub ListBoxTeam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTeam.SelectedIndexChanged
        If ListBoxTeam.SelectedItem IsNot Nothing Then
            LoadCompetitor(ListBoxTeam.SelectedItem.ToString())
        End If
    End Sub

    Private Sub LoadCompetitor(team As String)
        Using conn As New SQLiteConnection(connString)
            conn.Open()

            Dim query As String = "SELECT name, team, team_info FROM competitor WHERE team = @team"
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@team", team)

                Dim adapter As New SQLiteDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                DataGridView1.DataSource = dt
            End Using
        End Using
    End Sub
    Private Sub InitDatabase()
        Using conn As New SQLiteConnection(connString)
            conn.Open()

            Dim sql As String = "
        CREATE TABLE IF NOT EXISTS team (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            nama_team TEXT
        );

        CREATE TABLE IF NOT EXISTS competitor (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            name TEXT,
            team TEXT,
            team_info TEXT
        );"

            Using cmd As New SQLiteCommand(sql, conn)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class