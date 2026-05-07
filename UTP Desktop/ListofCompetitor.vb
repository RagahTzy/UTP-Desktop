Imports System.Data.SQLite

Public Class ListOfCompetitor

    ' Samakan dengan Competitor.vb dan Team.vb
    Dim connString As String = "Data Source=DB_Karate.sqlite;Version=3;"

    ' Property untuk menyimpan data yang dipilih
    Public SelectedCompetitorId As Integer = 0
    Public SelectedCompetitorName As String = ""
    Public SelectedTeamName As String = ""
    Public SelectedTeamInfo As String = ""

    Private Sub ListOfCompetitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTeam()
        LoadCompetitor("")
    End Sub

    ' LOAD TEAM KE LISTBOX
    Private Sub LoadTeam()
        Using conn As New SQLiteConnection(connString)
            Try
                conn.Open()
                ' Ambil daftar nama tim langsung dari tabel Competitor, bukan dari tabel Team yang bikin error
                Dim query As String = "SELECT DISTINCT TeamName FROM Competitor WHERE TeamName IS NOT NULL AND TeamName <> ''"
                Using cmd As New SQLiteCommand(query, conn)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        ListBoxTeam.Items.Clear()
                        While reader.Read()
                            ListBoxTeam.Items.Add(reader("TeamName").ToString())
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Gagal load team: " & ex.Message)
            End Try
        End Using
    End Sub

    ' KLIK TEAM → LOAD DATA GRID
    Private Sub ListBoxTeam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTeam.SelectedIndexChanged
        If ListBoxTeam.SelectedItem IsNot Nothing Then
            LoadCompetitor("", ListBoxTeam.SelectedItem.ToString())
        End If
    End Sub

    ' LOAD COMPETITOR
    Private Sub LoadCompetitor(Optional keyword As String = "", Optional filterTeam As String = "")
        Dim query As String = "SELECT ID, Name, TeamName, TeamInfo FROM Competitor WHERE (Name LIKE @key OR TeamName LIKE @key)"
        If Not String.IsNullOrEmpty(filterTeam) Then
            query &= " AND TeamName = @filterTeam"
        End If

        Using conn As New SQLiteConnection(connString)
            Try
                conn.Open()
                Dim cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@key", "%" & keyword & "%")
                If Not String.IsNullOrEmpty(filterTeam) Then
                    cmd.Parameters.AddWithValue("@filterTeam", filterTeam)
                End If

                Dim adapter As New SQLiteDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                DataGridView1.DataSource = dt

                ' Sembunyikan kolom ID
                If DataGridView1.Columns.Contains("ID") Then
                    DataGridView1.Columns("ID").Visible = False
                End If
            Catch ex As Exception
                MessageBox.Show("Gagal load competitor: " & ex.Message)
            End Try
        End Using
    End Sub

    ' SEARCH
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        LoadCompetitor(TxtSearch.Text)
    End Sub

    Private Sub BtnClearSearch_Click(sender As Object, e As EventArgs) Handles BtnClearSearch.Click
        TxtSearch.Clear()
        ListBoxTeam.ClearSelected()
        LoadCompetitor("")
    End Sub

    ' CLEAR FILTER TEAM
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ListBoxTeam.ClearSelected()
        TxtSearch.Clear()
        LoadCompetitor("")
    End Sub

    ' CLOSE
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    ' SELECT - tutup form dan kembalikan data yang dipilih
    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim drv As DataRowView = CType(row.DataBoundItem, DataRowView)

            SelectedCompetitorId = Convert.ToInt32(drv("ID"))
            SelectedCompetitorName = drv("Name").ToString()
            SelectedTeamName = If(drv("TeamName") IsNot Nothing, drv("TeamName").ToString(), "")
            SelectedTeamInfo = If(drv("TeamInfo") IsNot Nothing, drv("TeamInfo").ToString(), "")

            Me.Close()
        Else
            MessageBox.Show("Pilih kompetitor terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class