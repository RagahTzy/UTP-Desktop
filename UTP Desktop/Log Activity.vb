Imports System.Data.SQLite
Imports ClosedXML.Excel

Public Class Log_Activity

    Dim connString As String = "Data Source=DB_Karate.sqlite;Version=3;"

    Private Sub CreateTableIfNotExists()
        Try
            Using conn As New SQLiteConnection(connString)
                conn.Open()
                Dim sql As String = "CREATE TABLE IF NOT EXISTS LogActivity (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Categories TEXT,
                    Activity TEXT,
                    ActivityType TEXT,
                    DateTime TEXT,
                    MatchTime TEXT,
                    UserName TEXT
                )"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal buat tabel: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadData()
        Try
            Using conn As New SQLiteConnection(connString)
                conn.Open()

                Dim sql As String = "SELECT Categories, Activity, ActivityType, DateTime, MatchTime, UserName FROM LogActivity WHERE 1=1"

                sql &= " AND DATE(DateTime) = '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "'"

                If chkFilter.Checked AndAlso cmbCategories.SelectedItem IsNot Nothing AndAlso cmbCategories.SelectedItem.ToString() <> "" Then
                    sql &= " AND Categories = '" & cmbCategories.SelectedItem.ToString() & "'"
                End If

                If chkTop100.Checked Then
                    sql &= " ORDER BY DateTime DESC LIMIT 100"
                Else
                    sql &= " ORDER BY DateTime DESC"
                End If

                Dim adapter As New SQLiteDataAdapter(sql, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                DataGridView1.AutoGenerateColumns = False
                DataGridView1.DataSource = dt

                colCategories.DataPropertyName = "Categories"
                colActivity.DataPropertyName = "Activity"
                colActivityType.DataPropertyName = "ActivityType"
                colDateTime.DataPropertyName = "DateTime"
                colMatchTime.DataPropertyName = "MatchTime"
                colUserName.DataPropertyName = "UserName"
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal load data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Log_Activity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateTableIfNotExists()
        DateTimePicker1.Value = DateTime.Today
        LoadData()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        LoadData()
    End Sub

    Private Sub chkFilter_CheckedChanged(sender As Object, e As EventArgs) Handles chkFilter.CheckedChanged
        cmbCategories.Enabled = chkFilter.Checked
        LoadData()
    End Sub

    Private Sub cmbCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategories.SelectedIndexChanged
        LoadData()
    End Sub

    Private Sub chkTop100_CheckedChanged(sender As Object, e As EventArgs) Handles chkTop100.CheckedChanged
        LoadData()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            If DataGridView1.Rows.Count = 0 Then
                MessageBox.Show("Tidak ada data untuk diexport!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Excel Files|*.xlsx"
            saveDialog.FileName = "LogActivity_" & DateTime.Now.ToString("yyyyMMdd_HHmmss")

            If saveDialog.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = saveDialog.FileName

                Using wb As New XLWorkbook()
                    Dim ws = wb.Worksheets.Add("Log Activity")

                    Dim headers() As String = {"Categories", "Activity", "ActivityType", "Date Time", "MatchTime"}
                    For i = 0 To headers.Length - 1
                        ws.Cell(1, i + 1).Value = headers(i)
                        ws.Cell(1, i + 1).Style.Font.Bold = True
                        ws.Cell(1, i + 1).Style.Fill.BackgroundColor = XLColor.FromArgb(173, 216, 230)
                    Next

                    For row = 0 To DataGridView1.Rows.Count - 1
                        For col = 0 To DataGridView1.Columns.Count - 1
                            Dim cellValue = DataGridView1.Rows(row).Cells(col).Value
                            ws.Cell(row + 2, col + 1).Value = If(cellValue IsNot Nothing, cellValue.ToString(), "")
                        Next
                    Next

                    ws.Columns().AdjustToContents()
                    wb.SaveAs(filePath)
                End Using

                MessageBox.Show("Data successfully export!.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Export gagal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

End Class