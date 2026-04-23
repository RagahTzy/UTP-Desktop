Public Class Shortcut
    Private Sub Shortcut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKeyboardIcon()
        LoadShortcutList()
        RadioButton1.Checked = True
    End Sub

    Private Sub LoadKeyboardIcon()
        Dim imgPath As String = System.IO.Path.Combine(Application.StartupPath, "Resources", "keyboard.png")
        If System.IO.File.Exists(imgPath) Then
            picKeyboard.Image = Image.FromFile(imgPath)
        Else
            Dim projectPath As String = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Application.StartupPath.TrimEnd("\"c)), "..", "..", "..", "Resources", "keyboard.png")
            If System.IO.File.Exists(projectPath) Then
                picKeyboard.Image = Image.FromFile(projectPath)
            End If
        End If
    End Sub

    Private Sub LoadShortcutList()
        Dim item1 As New ListViewItem("Start-Close Scoreboard")
        item1.SubItems.Add("Control+B")

        Dim item2 As New ListViewItem("Timer Waiting Start-Stop")
        item2.SubItems.Add("Control+W")

        Dim item3 As New ListViewItem("Match Timer Start-Stop")
        item3.SubItems.Add("Space")

        Dim item4 As New ListViewItem("Next Match")
        item4.SubItems.Add("Control+N")

        Dim item5 As New ListViewItem("Save Match Result")
        item5.SubItems.Add("Control+S")

        Dim item6 As New ListViewItem("Match Timer Reset")
        item6.SubItems.Add("Control+R")

        Dim item7 As New ListViewItem("Show Winner")
        item7.SubItems.Add("Control+E")

        Dim item8 As New ListViewItem("AKA - Yuko(1)")
        item8.SubItems.Add("Shift+A")
        item8.UseItemStyleForSubItems = False
        item8.ForeColor = Color.Red
        item8.SubItems(0).ForeColor = Color.Red
        item8.SubItems(1).ForeColor = Color.Black

        Dim item9 As New ListViewItem("AKA – Wazaari(2)")
        item9.SubItems.Add("Shift+S")
        item9.UseItemStyleForSubItems = False
        item9.ForeColor = Color.Red
        item9.SubItems(0).ForeColor = Color.Red
        item9.SubItems(1).ForeColor = Color.Black

        Dim item10 As New ListViewItem("AKA – Ippon(3)")
        item10.SubItems.Add("Shift+D")
        item10.UseItemStyleForSubItems = False
        item10.ForeColor = Color.Red
        item10.SubItems(0).ForeColor = Color.Red
        item10.SubItems(1).ForeColor = Color.Black

        Dim item11 As New ListViewItem("AKA - SENSHU")
        item11.SubItems.Add("Shift+Q")
        item11.UseItemStyleForSubItems = False
        item11.ForeColor = Color.Red
        item11.SubItems(0).ForeColor = Color.Red
        item11.SubItems(1).ForeColor = Color.Black

        Dim item12 As New ListViewItem("AO – Yuko(1)")
        item12.SubItems.Add("Shift+J")
        item12.UseItemStyleForSubItems = False
        item12.ForeColor = Color.Blue
        item12.SubItems(0).ForeColor = Color.Blue
        item12.SubItems(1).ForeColor = Color.Black

        Dim item13 As New ListViewItem("AO – Wazaari(2)")
        item13.SubItems.Add("Shift+K")
        item13.UseItemStyleForSubItems = False
        item13.ForeColor = Color.Blue
        item13.SubItems(0).ForeColor = Color.Blue
        item13.SubItems(1).ForeColor = Color.Black

        Dim item14 As New ListViewItem("AO – Ippon(3)")
        item14.SubItems.Add("Shift+L")
        item14.UseItemStyleForSubItems = False
        item14.ForeColor = Color.Blue
        item14.SubItems(0).ForeColor = Color.Blue
        item14.SubItems(1).ForeColor = Color.Black

        Dim item15 As New ListViewItem("AO - SENSHU")
        item15.SubItems.Add("Shift+P")
        item15.UseItemStyleForSubItems = False
        item15.ForeColor = Color.Blue
        item15.SubItems(0).ForeColor = Color.Blue
        item15.SubItems(1).ForeColor = Color.Black

        lstShortcuts.Items.AddRange(New ListViewItem() {item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15})
    End Sub

    ' RadioButton1 - ON/OFF toggle
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            lblStatusValue.Text = "ON"
            lblStatusValue.ForeColor = Color.DeepSkyBlue
            btnToggle.BackColor = Color.DodgerBlue
            btnToggle.Text = "●"
            btnToggle.TextAlign = ContentAlignment.MiddleRight
        Else
            lblStatusValue.Text = "OFF"
            lblStatusValue.ForeColor = Color.Gray
            btnToggle.BackColor = Color.Gray
            btnToggle.Text = "●"
            btnToggle.TextAlign = ContentAlignment.MiddleLeft
        End If
    End Sub

    ' btnToggle
    Private Sub btnToggle_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        RadioButton1.Checked = Not RadioButton1.Checked
    End Sub

    ' btnChange
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click

    End Sub

    ' btnSave
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub

    ' btnReset
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lstShortcuts.Items.Clear()
        LoadShortcutList()
        lblCurrentAction.Text = "Current Action :  -"
        txtDetails.Text = ""
    End Sub

    ' btnRemove
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lstShortcuts.SelectedItems.Count > 0 Then
            lstShortcuts.Items.Remove(lstShortcuts.SelectedItems(0))
        End If
    End Sub

    ' lstShortcuts
    Private Sub lstShortcuts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstShortcuts.SelectedIndexChanged
        If lstShortcuts.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lstShortcuts.SelectedItems(0)
            lblCurrentAction.Text = "Current Action :  " & selectedItem.Text
            txtDetails.Text = selectedItem.Text & " = " & selectedItem.SubItems(1).Text
        End If
    End Sub
End Class
