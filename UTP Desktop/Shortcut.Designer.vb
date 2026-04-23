<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Shortcut
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelTop = New Panel()
        RadioButton1 = New RadioButton()
        btnToggle = New Button()
        lblTurnOff = New Label()
        lblStatusValue = New Label()
        lblStatusText = New Label()
        lstShortcuts = New ListView()
        colAction = New ColumnHeader()
        colKey = New ColumnHeader()
        btnChange = New Button()
        btnRemove = New Button()
        btnSave = New Button()
        picKeyboard = New PictureBox()
        btnReset = New Button()
        lblCurrentAction = New Label()
        txtDetails = New TextBox()
        PanelTop.SuspendLayout()
        CType(picKeyboard, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        ' PanelTop
        '
        PanelTop.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        PanelTop.Controls.Add(RadioButton1)
        PanelTop.Controls.Add(btnToggle)
        PanelTop.Controls.Add(lblTurnOff)
        PanelTop.Controls.Add(lblStatusValue)
        PanelTop.Controls.Add(lblStatusText)
        PanelTop.Dock = DockStyle.Top
        PanelTop.Location = New Point(0, 0)
        PanelTop.Margin = New Padding(3, 4, 3, 4)
        PanelTop.Name = "PanelTop"
        PanelTop.Size = New Size(496, 67)
        PanelTop.TabIndex = 0
        '
        ' RadioButton1
        '
        RadioButton1.AutoSize = True
        RadioButton1.ForeColor = Color.White
        RadioButton1.Location = New Point(304, 23)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(83, 24)
        RadioButton1.TabIndex = 4
        RadioButton1.TabStop = True
        RadioButton1.Text = "ON/OFF"
        RadioButton1.UseVisualStyleBackColor = True
        '
        ' btnToggle
        '
        btnToggle.BackColor = Color.DodgerBlue
        btnToggle.Cursor = Cursors.Hand
        btnToggle.FlatAppearance.BorderSize = 0
        btnToggle.FlatStyle = FlatStyle.Flat
        btnToggle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnToggle.ForeColor = Color.White
        btnToggle.Location = New Point(417, 16)
        btnToggle.Margin = New Padding(3, 4, 3, 4)
        btnToggle.Name = "btnToggle"
        btnToggle.Size = New Size(57, 33)
        btnToggle.TabIndex = 3
        btnToggle.Text = "●"
        btnToggle.TextAlign = ContentAlignment.MiddleRight
        btnToggle.UseVisualStyleBackColor = False
        '
        ' lblTurnOff
        '
        lblTurnOff.AutoSize = True
        lblTurnOff.Font = New Font("Segoe UI", 9.0F)
        lblTurnOff.ForeColor = Color.White
        lblTurnOff.Location = New Point(352, 23)
        lblTurnOff.Name = "lblTurnOff"
        lblTurnOff.Size = New Size(61, 20)
        lblTurnOff.TabIndex = 2
        lblTurnOff.Text = "Turn off"
        lblTurnOff.Visible = False
        '
        ' lblStatusValue
        '
        lblStatusValue.AutoSize = True
        lblStatusValue.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblStatusValue.ForeColor = Color.DeepSkyBlue
        lblStatusValue.Location = New Point(163, 16)
        lblStatusValue.Name = "lblStatusValue"
        lblStatusValue.Size = New Size(51, 32)
        lblStatusValue.TabIndex = 1
        lblStatusValue.Text = "ON"
        '
        ' lblStatusText
        '
        lblStatusText.AutoSize = True
        lblStatusText.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblStatusText.ForeColor = Color.White
        lblStatusText.Location = New Point(14, 20)
        lblStatusText.Name = "lblStatusText"
        lblStatusText.Size = New Size(141, 25)
        lblStatusText.TabIndex = 0
        lblStatusText.Text = "Current Status"
        '
        ' lstShortcuts
        '
        lstShortcuts.Columns.AddRange(New ColumnHeader() {colAction, colKey})
        lstShortcuts.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lstShortcuts.FullRowSelect = True
        lstShortcuts.HeaderStyle = ColumnHeaderStyle.None
        lstShortcuts.Location = New Point(18, 91)
        lstShortcuts.Margin = New Padding(3, 4, 3, 4)
        lstShortcuts.MultiSelect = False
        lstShortcuts.Name = "lstShortcuts"
        lstShortcuts.Size = New Size(299, 441)
        lstShortcuts.TabIndex = 1
        lstShortcuts.UseCompatibleStateImageBehavior = False
        lstShortcuts.View = View.Details
        '
        ' colAction
        '
        colAction.Text = "Action"
        colAction.Width = 150
        '
        ' colKey
        '
        colKey.Text = "Key"
        colKey.Width = 100
        '
        ' btnChange
        '
        btnChange.BackColor = Color.White
        btnChange.FlatStyle = FlatStyle.Popup
        btnChange.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnChange.Location = New Point(335, 91)
        btnChange.Margin = New Padding(3, 4, 3, 4)
        btnChange.Name = "btnChange"
        btnChange.Size = New Size(139, 43)
        btnChange.TabIndex = 2
        btnChange.Text = "Change ✏️"
        btnChange.UseVisualStyleBackColor = False
        '
        ' btnRemove
        '
        btnRemove.BackColor = Color.White
        btnRemove.FlatStyle = FlatStyle.Popup
        btnRemove.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnRemove.Location = New Point(335, 141)
        btnRemove.Margin = New Padding(3, 4, 3, 4)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(139, 43)
        btnRemove.TabIndex = 3
        btnRemove.Text = "Remove 🚫"
        btnRemove.UseVisualStyleBackColor = False
        '
        ' btnSave
        '
        btnSave.BackColor = Color.White
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnSave.ForeColor = Color.Gray
        btnSave.Location = New Point(335, 225)
        btnSave.Margin = New Padding(3, 4, 3, 4)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(139, 43)
        btnSave.TabIndex = 4
        btnSave.Text = "Save 💾"
        btnSave.UseVisualStyleBackColor = False
        '
        ' picKeyboard
        '
        picKeyboard.Location = New Point(357, 311)
        picKeyboard.Margin = New Padding(3, 4, 3, 4)
        picKeyboard.Name = "picKeyboard"
        picKeyboard.Size = New Size(98, 91)
        picKeyboard.SizeMode = PictureBoxSizeMode.Zoom
        picKeyboard.TabIndex = 5
        picKeyboard.TabStop = False
        '
        ' btnReset
        '
        btnReset.BackColor = Color.LightSalmon
        btnReset.FlatStyle = FlatStyle.Popup
        btnReset.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnReset.ForeColor = Color.White
        btnReset.Location = New Point(335, 491)
        btnReset.Margin = New Padding(3, 4, 3, 4)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(139, 43)
        btnReset.TabIndex = 6
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        '
        ' lblCurrentAction
        '
        lblCurrentAction.AutoSize = True
        lblCurrentAction.Location = New Point(15, 537)
        lblCurrentAction.Name = "lblCurrentAction"
        lblCurrentAction.Size = New Size(125, 20)
        lblCurrentAction.TabIndex = 7
        lblCurrentAction.Text = "Current Action :  -"
        '
        ' txtDetails
        '
        txtDetails.Location = New Point(18, 561)
        txtDetails.Margin = New Padding(3, 4, 3, 4)
        txtDetails.Multiline = True
        txtDetails.Name = "txtDetails"
        txtDetails.Size = New Size(299, 77)
        txtDetails.TabIndex = 8
        '
        ' Shortcut
        '
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        ClientSize = New Size(496, 656)
        Controls.Add(txtDetails)
        Controls.Add(lblCurrentAction)
        Controls.Add(btnReset)
        Controls.Add(picKeyboard)
        Controls.Add(btnSave)
        Controls.Add(btnRemove)
        Controls.Add(btnChange)
        Controls.Add(lstShortcuts)
        Controls.Add(PanelTop)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Shortcut"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Keyboard Shortcut Setup"
        PanelTop.ResumeLayout(False)
        PanelTop.PerformLayout()
        CType(picKeyboard, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents PanelTop As Panel
    Friend WithEvents lblStatusText As Label
    Friend WithEvents lblStatusValue As Label
    Friend WithEvents lblTurnOff As Label
    Friend WithEvents btnToggle As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents lstShortcuts As ListView
    Friend WithEvents colAction As ColumnHeader
    Friend WithEvents colKey As ColumnHeader
    Friend WithEvents btnChange As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents picKeyboard As PictureBox
    Friend WithEvents btnReset As Button
    Friend WithEvents lblCurrentAction As Label
    Friend WithEvents txtDetails As TextBox
End Class
