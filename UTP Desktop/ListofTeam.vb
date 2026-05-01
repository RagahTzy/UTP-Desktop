Imports System.Data.SQLite
Imports System.IO

Public Class ListofTeam
    Dim connString As String = "Data Source=DB_Karate.sqlite;Version=3;"

    ' Property untuk menyimpan data tim yang dipilih
    Public SelectedTeamId As Integer = 0
    Public SelectedTeamName As String = ""
    Public SelectedTeamInfo As String = ""

    Private Sub ListofTeam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTeamData()
    End Sub

    Private Sub LoadTeamData(Optional keyword As String = "")
        Using conn As New SQLiteConnection(connString)
            Try
                conn.Open()
                Dim query As String = "SELECT ID, TeamName, TeamInfo, Pict FROM Team WHERE TeamName LIKE @search OR TeamInfo LIKE @search"
                Dim cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@search", "%" & keyword & "%")

                Dim adapter As New SQLiteDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                ' Bind data ke DataGridView
                If DataGridViewTeamList IsNot Nothing Then
                    DataGridViewTeamList.DataSource = dt
                    If DataGridViewTeamList.Columns.Contains("ID") Then
                        DataGridViewTeamList.Columns("ID").Visible = False
                    End If
                    If DataGridViewTeamList.Columns.Contains("Pict") Then
                        DataGridViewTeamList.Columns("Pict").Visible = False
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show("Gagal load data tim: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        LoadTeamData(TxtSearch.Text)
    End Sub

    Private Sub BtnClearSearch_Click(sender As Object, e As EventArgs) Handles BtnClearSearch.Click
        TxtSearch.Clear()
        LoadTeamData("")
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        If DataGridViewTeamList.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridViewTeamList.SelectedRows(0)
            Dim drv As DataRowView = CType(row.DataBoundItem, DataRowView)

            SelectedTeamId = Convert.ToInt32(drv("ID"))
            SelectedTeamName = drv("TeamName").ToString()
            SelectedTeamInfo = If(drv("TeamInfo") IsNot Nothing, drv("TeamInfo").ToString(), "")

            Me.Close()
        Else
            MessageBox.Show("Pilih tim terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

End Class
