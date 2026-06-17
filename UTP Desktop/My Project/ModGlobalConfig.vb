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
                Dim createSql As String = "CREATE TABLE IF NOT EXISTS LogActivity (Id INTEGER PRIMARY KEY AUTOINCREMENT, Categories TEXT, Activity TEXT, ActivityType TEXT, DateTime TEXT, MatchTime TEXT)"
                Using cc As New SQLiteCommand(createSql, conn)
                    cc.ExecuteNonQuery()
                End Using

                Dim sql As String = "INSERT INTO LogActivity (Categories, Activity, ActivityType, DateTime, MatchTime) VALUES (@cat,@act,@type,@dt,@mt)"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@cat", category)
                    cmd.Parameters.AddWithValue("@act", activity)
                    cmd.Parameters.AddWithValue("@type", activityType)
                    cmd.Parameters.AddWithValue("@dt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                    cmd.Parameters.AddWithValue("@mt", matchTime)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            ' Fail silently to avoid breaking UI
        End Try
    End Sub

    Public Sub InitMatchResultTable()
        Try
            Using conn As New SQLiteConnection("Data Source=DB_Karate.sqlite;Version=3;")
                conn.Open()
                Dim sql As String = "CREATE TABLE IF NOT EXISTS MatchResult (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    MatchType TEXT,
                    AkaName TEXT,
                    AkaTeam TEXT,
                    AoName TEXT,
                    AoTeam TEXT,
                    AkaScore TEXT,
                    AoScore TEXT,
                    Winner TEXT,
                    MatchDateTime TEXT,
                    Category TEXT,
                    Class TEXT,
                    Tatami TEXT
                )"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.ExecuteNonQuery()
                End Using

                ' Try to add Tatami column if it doesn't exist (for existing databases)
                Try
                    Using cmd As New SQLiteCommand("ALTER TABLE MatchResult ADD COLUMN Tatami TEXT", conn)
                        cmd.ExecuteNonQuery()
                    End Using
                Catch
                    ' Column might already exist
                End Try
            End Using
        Catch ex As Exception
            Debug.WriteLine("InitMatchResultTable Error: " & ex.Message)
        End Try
    End Sub

    Public Sub SaveMatchResult(matchType As String, akaName As String, akaTeam As String, aoName As String, aoTeam As String, akaScore As String, aoScore As String, winner As String, category As String, matchClass As String, tatami As String)
        Try
            InitMatchResultTable()
            Using conn As New SQLiteConnection("Data Source=DB_Karate.sqlite;Version=3;")
                conn.Open()
                Dim sql As String = "INSERT INTO MatchResult (MatchType, AkaName, AkaTeam, AoName, AoTeam, AkaScore, AoScore, Winner, MatchDateTime, Category, Class, Tatami) 
                                   VALUES (@type, @akaN, @akaT, @aoN, @aoT, @akaS, @aoS, @winner, @dt, @cat, @class, @tatami)"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@type", matchType)
                    cmd.Parameters.AddWithValue("@akaN", akaName)
                    cmd.Parameters.AddWithValue("@akaT", akaTeam)
                    cmd.Parameters.AddWithValue("@aoN", aoName)
                    cmd.Parameters.AddWithValue("@aoT", aoTeam)
                    cmd.Parameters.AddWithValue("@akaS", akaScore)
                    cmd.Parameters.AddWithValue("@aoS", aoScore)
                    cmd.Parameters.AddWithValue("@winner", winner)
                    cmd.Parameters.AddWithValue("@dt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                    cmd.Parameters.AddWithValue("@cat", category)
                    cmd.Parameters.AddWithValue("@class", matchClass)
                    cmd.Parameters.AddWithValue("@tatami", tatami)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            LogActivity("Match", "Saved " & matchType & " result: " & akaName & " vs " & aoName, "Save")
        Catch ex As Exception
            MessageBox.Show("Error saving match result: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
