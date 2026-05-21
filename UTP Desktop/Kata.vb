Imports System.Data.SQLite

Public Class Kata
    ''' <summary>
    ''' Variable untuk menyimpan data kompetitor yang dipilih dari header
    ''' </summary>
    Private akaSelectedName As String = ""
    Private akaSelectedTeam As String = ""
    Private akaSelectedTeamInfo As String = ""
    Private aoSelectedName As String = ""
    Private aoSelectedTeam As String = ""
    Private aoSelectedTeamInfo As String = ""

    ''' <summary>
    ''' Helper function untuk logging activity ke database
    ''' </summary>
    Private Sub LogActivityToDb(category As String, activity As String, activityType As String, Optional matchTime As String = "")
        Try
            ModGlobalConfig.LogActivity(category, activity, activityType, matchTime, Environment.UserName)
        Catch ex As Exception
            ' Silent fail - jangan interrupt UI
            Debug.WriteLine("Log Activity Error: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Mengatur perubahan tampilan utama berdasarkan tipe scoring yang dipilih juri
    ''' </summary>
    Private Sub RadScore_CheckedChanged(sender As Object, e As EventArgs) Handles RadScore.CheckedChanged
        If RadScore.Checked Then
            PanelJudgeScore.Visible = True
            PanelFlagSystem.Visible = False
        End If
    End Sub

    Private Sub RadFlagSystem_CheckedChanged(sender As Object, e As EventArgs) Handles RadFlagSystem.CheckedChanged
        If RadFlagSystem.Checked Then
            PanelJudgeScore.Visible = False
            PanelFlagSystem.Visible = True
        End If
    End Sub

    ''' <summary>
    ''' BtnAkaIconHeader - Buka List of Competitor untuk header AKA
    ''' </summary>
    Private Sub BtnAkaIconHeader_Click(sender As Object, e As EventArgs) Handles BtnAkaIconHeader.Click
        Try
            Dim formList As New ListOfCompetitor()
            formList.ShowDialog()
            If formList.DialogResult = DialogResult.OK AndAlso Not String.IsNullOrEmpty(formList.SelectedCompetitorName) Then
                TxtAkaNameHeader.Text = formList.SelectedCompetitorName
                ' Simpan data kompetitor ke variable
                akaSelectedName = formList.SelectedCompetitorName
                akaSelectedTeam = formList.SelectedTeamName
                akaSelectedTeamInfo = formList.SelectedTeamInfo
                LogActivityToDb("Header", $"Select Competitor for AKA Header: {formList.SelectedCompetitorName}", "Selection")
            End If
            formList.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LogActivityToDb("Header", $"Error selecting AKA competitor: {ex.Message}", "Error")
        End Try
    End Sub

    ''' <summary>
    ''' BtnAoIconHeader - Buka List of Competitor untuk header AO
    ''' </summary>
    Private Sub BtnAoIconHeader_Click(sender As Object, e As EventArgs) Handles BtnAoIconHeader.Click
        Try
            Dim formList As New ListOfCompetitor()
            formList.ShowDialog()
            If formList.DialogResult = DialogResult.OK AndAlso Not String.IsNullOrEmpty(formList.SelectedCompetitorName) Then
                TxtAoNameHeader.Text = formList.SelectedCompetitorName
                ' Simpan data kompetitor ke variable
                aoSelectedName = formList.SelectedCompetitorName
                aoSelectedTeam = formList.SelectedTeamName
                aoSelectedTeamInfo = formList.SelectedTeamInfo
                LogActivityToDb("Header", $"Select Competitor for AO Header: {formList.SelectedCompetitorName}", "Selection")
            End If
            formList.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LogActivityToDb("Header", $"Error selecting AO competitor: {ex.Message}", "Error")
        End Try
    End Sub

    ''' <summary>
    ''' BtnAkaUserIcon - Buka List of Competitor untuk detail AKA
    ''' </summary>
    Private Sub BtnAkaUserIcon_Click(sender As Object, e As EventArgs) Handles BtnAkaUserIcon.Click
        Try
            Dim formList As New ListOfCompetitor()
            formList.ShowDialog()
            If formList.DialogResult = DialogResult.OK AndAlso Not String.IsNullOrEmpty(formList.SelectedCompetitorName) Then
                TxtAkaName.Text = formList.SelectedCompetitorName
                TxtAkaTeam.Text = formList.SelectedTeamName
                TxtAkaTeamInfo.Text = formList.SelectedTeamInfo
                LogActivityToDb("AKA Detail", $"Select Competitor: {formList.SelectedCompetitorName} | Team: {formList.SelectedTeamName}", "Selection")
            End If
            formList.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LogActivityToDb("AKA Detail", $"Error selecting competitor: {ex.Message}", "Error")
        End Try
    End Sub

    ''' <summary>
    ''' BtnAoUserIcon - Buka List of Competitor untuk detail AO
    ''' </summary>
    Private Sub BtnAoUserIcon_Click(sender As Object, e As EventArgs) Handles BtnAoUserIcon.Click
        Try
            Dim formList As New ListOfCompetitor()
            formList.ShowDialog()
            If formList.DialogResult = DialogResult.OK AndAlso Not String.IsNullOrEmpty(formList.SelectedCompetitorName) Then
                TxtAoName.Text = formList.SelectedCompetitorName
                TxtAoTeam.Text = formList.SelectedTeamName
                TxtAoTeamInfo.Text = formList.SelectedTeamInfo
                LogActivityToDb("AO Detail", $"Select Competitor: {formList.SelectedCompetitorName} | Team: {formList.SelectedTeamName}", "Selection")
            End If
            formList.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LogActivityToDb("AO Detail", $"Error selecting competitor: {ex.Message}", "Error")
        End Try
    End Sub

    ''' <summary>
    ''' BtnLoadNextMatch - Copy data dari header ke detail panel
    ''' </summary>
    Private Sub BtnLoadNextMatch_Click(sender As Object, e As EventArgs) Handles BtnLoadNextMatch.Click
        Try
            ' Copy AKA data from header (variables) to detail panel
            TxtAkaName.Text = akaSelectedName
            TxtAkaTeam.Text = akaSelectedTeam
            TxtAkaTeamInfo.Text = akaSelectedTeamInfo

            ' Copy AO data from header (variables) to detail panel
            TxtAoName.Text = aoSelectedName
            TxtAoTeam.Text = aoSelectedTeam
            TxtAoTeamInfo.Text = aoSelectedTeamInfo

            LogActivityToDb("Match Load", $"Load Next Match: {akaSelectedName} vs {aoSelectedName}", "Action")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LogActivityToDb("Match Load", $"Error loading match: {ex.Message}", "Error")
        End Try
    End Sub

    ''' <summary>
    ''' BtnLogActivity - Buka Form Log Activity
    ''' </summary>
    Private Sub BtnLogActivity_Click(sender As Object, e As EventArgs) Handles BtnLogActivity.Click
        Try
            Dim formLog As New Log_Activity()
            formLog.ShowDialog()
            LogActivityToDb("UI", "Open Log Activity Form", "Action")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' BtnShortcut - Buka Form Shortcut
    ''' </summary>
    Private Sub BtnShortcut_Click(sender As Object, e As EventArgs) Handles BtnShortcut.Click
        Try
            Dim formShortcut As New Shortcut()
            formShortcut.ShowDialog()
            LogActivityToDb("UI", "Open Shortcut Form", "Action")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles APIInfo.Click

    End Sub
End Class