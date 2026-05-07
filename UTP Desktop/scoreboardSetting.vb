Imports System.Drawing

Public Class scoreboardSetting

    Private alertItems() As String = {
        "End of Timer",
        "15 Second Timer",
        "Winner by Point",
        "Get Point",
        "Get Penalties",
        "Hantei",
        "Knocked Out",
        "VAR Alert",
        "Manual Alert"
    }

    Public Sub New()
        InitializeComponent()
        LoadAlertUI() ' LANGSUNG DIPANGGIL DI SINI
    End Sub

    Private Sub LoadAlertUI()

        Dim y As Integer = 25

        For i As Integer = 0 To alertItems.Length - 1

            ' Label
            Dim lbl As New Label()
            lbl.Text = alertItems(i)
            lbl.Location = New Point(10, y)
            lbl.Size = New Size(130, 22)

            ' Textbox
            Dim txt As New TextBox()
            txt.Location = New Point(150, y)
            txt.Size = New Size(280, 22)
            txt.Text = "C:\Yabin...KarateScoreBo..."
            txt.ReadOnly = True

            ' Select Button
            Dim btnSelect As New Button()
            btnSelect.Text = "Select"
            btnSelect.Location = New Point(440, y)
            btnSelect.Size = New Size(55, 22)

            ' X Button
            Dim btnX As New Button()
            btnX.Text = "X"
            btnX.Location = New Point(500, y)
            btnX.Size = New Size(30, 22)

            ' Play Button
            Dim btnPlay As New Button()
            btnPlay.Text = "Play"
            btnPlay.Location = New Point(535, y)
            btnPlay.Size = New Size(55, 22)

            ' Tambahkan ke GroupBox
            grpAlert.Controls.Add(lbl)
            grpAlert.Controls.Add(txt)
            grpAlert.Controls.Add(btnSelect)
            grpAlert.Controls.Add(btnX)
            grpAlert.Controls.Add(btnPlay)

            y += 28
        Next

    End Sub

End Class