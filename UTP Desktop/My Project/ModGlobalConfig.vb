Imports System.Data.SQLite

Public Module ModGlobalConfig
    Public ShortcutSettings As New Dictionary(Of String, String)
    Public IsShortcutEnabled As Boolean = True

    ' FLAG: Sangat penting agar Form Kumite tahu kapan harus refresh data
    Public NeedRefreshSettings As Boolean = False

    Public Sub InitDefaultShortcuts()
        ' Jangan isi ulang jika sudah ada datanya
        If ShortcutSettings.Count > 0 Then Exit Sub

        ' Pastikan Nama Aksi (Key) di sini sama dengan yang ada di Kumite.vb
        ShortcutSettings("Start-Close Scoreboard") = "Control+B"
        ShortcutSettings("Match Timer Start-Stop") = "Space"
        ShortcutSettings("Match Timer Reset") = "Control+R"

        ' AKA Group
        ShortcutSettings("AKA - Yuko(1)") = "Shift+A"
        ShortcutSettings("AKA - Wazaari(2)") = "Shift+S"
        ShortcutSettings("AKA - Ippon(3)") = "Shift+D"
        ShortcutSettings("AKA - SENSHU") = "Shift+Q"

        ' AO Group
        ShortcutSettings("AO - Yuko(1)") = "Shift+J"
        ShortcutSettings("AO - Wazaari(2)") = "Shift+K"
        ShortcutSettings("AO - Ippon(3)") = "Shift+L"
        ShortcutSettings("AO - SENSHU") = "Shift+P"
    End Sub

    ' Simple logger helper to insert activity into LogActivity table
    Public Sub LogActivity(category As String, activity As String, activityType As String, Optional matchTime As String = "", Optional userName As String = "")
        Try
            Using conn As New SQLiteConnection("Data Source=DB_Karate.sqlite;Version=3;")
                conn.Open()
                ' Ensure table exists so logging works even if Log_Activity form not opened
                Dim createSql As String = "CREATE TABLE IF NOT EXISTS LogActivity (Id INTEGER PRIMARY KEY AUTOINCREMENT, Categories TEXT, Activity TEXT, ActivityType TEXT, DateTime TEXT, MatchTime TEXT, UserName TEXT)"
                Using cc As New SQLiteCommand(createSql, conn)
                    cc.ExecuteNonQuery()
                End Using

                Dim sql As String = "INSERT INTO LogActivity (Categories, Activity, ActivityType, DateTime, MatchTime, UserName) VALUES (@cat,@act,@type,@dt,@mt,@user)"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@cat", category)
                    cmd.Parameters.AddWithValue("@act", activity)
                    cmd.Parameters.AddWithValue("@type", activityType)
                    cmd.Parameters.AddWithValue("@dt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                    cmd.Parameters.AddWithValue("@mt", matchTime)
                    cmd.Parameters.AddWithValue("@user", If(String.IsNullOrEmpty(userName), Environment.UserName, userName))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            ' Fail silently to avoid breaking UI
        End Try
    End Sub
End Module
