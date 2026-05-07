<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListofTeam
    Inherits System.Windows.Forms.Form

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
        PanelMain = New Panel()
        DataGridViewTeamList = New DataGridView()
        ColTeamId = New DataGridViewTextBoxColumn()
        ColTeamName = New DataGridViewTextBoxColumn()
        ColTeamInfo = New DataGridViewTextBoxColumn()
        PanelBottom = New Panel()
        TxtSearch = New TextBox()
        BtnSearch = New Button()
        BtnClearSearch = New Button()
        BtnClose = New Button()
        BtnSelect = New Button()
        PanelMain.SuspendLayout()
        CType(DataGridViewTeamList, ComponentModel.ISupportInitialize).BeginInit()
        PanelBottom.SuspendLayout()
        SuspendLayout()
        '
        ' PanelMain
        '
        PanelMain.Controls.Add(DataGridViewTeamList)
        PanelMain.Controls.Add(PanelBottom)
        PanelMain.Dock = DockStyle.Fill
        PanelMain.Location = New Point(0, 0)
        PanelMain.Name = "PanelMain"
        PanelMain.Size = New Size(700, 400)
        PanelMain.TabIndex = 0
        '
        ' DataGridViewTeamList
        '
        DataGridViewTeamList.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
        DataGridViewTeamList.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        DataGridViewTeamList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewTeamList.BorderStyle = BorderStyle.FixedSingle
        DataGridViewTeamList.CellBorderStyle = DataGridViewCellBorderStyle.Single
        DataGridViewTeamList.GridColor = Color.Black
        DataGridViewTeamList.EnableHeadersVisualStyles = False
        DataGridViewTeamList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewTeamList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewTeamList.ColumnHeadersHeight = 29
        DataGridViewTeamList.Dock = DockStyle.Fill
        DataGridViewTeamList.Location = New Point(0, 0)
        DataGridViewTeamList.MultiSelect = False
        DataGridViewTeamList.Name = "DataGridViewTeamList"
        DataGridViewTeamList.RowHeadersVisible = False
        DataGridViewTeamList.RowHeadersWidth = 51
        DataGridViewTeamList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewTeamList.Size = New Size(700, 340)
        DataGridViewTeamList.TabIndex = 0
        '
        ' ColTeamId
        '
        ColTeamId.DataPropertyName = "ID"
        ColTeamId.HeaderText = "ID"
        ColTeamId.Name = "ColTeamId"
        ColTeamId.Visible = False
        '
        ' ColTeamName
        '
        ColTeamName.DataPropertyName = "TeamName"
        ColTeamName.HeaderText = "Team Name"
        ColTeamName.Name = "ColTeamName"
        '
        ' ColTeamInfo
        '
        ColTeamInfo.DataPropertyName = "TeamInfo"
        ColTeamInfo.HeaderText = "Team Info"
        ColTeamInfo.Name = "ColTeamInfo"
        '
        ' PanelBottom
        '
        PanelBottom.BackColor = Color.Crimson
        PanelBottom.Controls.Add(TxtSearch)
        PanelBottom.Controls.Add(BtnSearch)
        PanelBottom.Controls.Add(BtnClearSearch)
        PanelBottom.Controls.Add(BtnClose)
        PanelBottom.Controls.Add(BtnSelect)
        PanelBottom.Dock = DockStyle.Bottom
        PanelBottom.Location = New Point(0, 340)
        PanelBottom.Name = "PanelBottom"
        PanelBottom.Size = New Size(700, 60)
        PanelBottom.TabIndex = 1
        '
        ' TxtSearch
        '
        TxtSearch.Location = New Point(10, 18)
        TxtSearch.Name = "TxtSearch"
        TxtSearch.Size = New Size(200, 27)
        TxtSearch.TabIndex = 0
        '
        ' BtnSearch
        '
        BtnSearch.Location = New Point(220, 15)
        BtnSearch.Name = "BtnSearch"
        BtnSearch.Size = New Size(40, 30)
        BtnSearch.TabIndex = 1
        BtnSearch.Text = "🔍"
        '
        ' BtnClearSearch
        '
        BtnClearSearch.Location = New Point(270, 15)
        BtnClearSearch.Name = "BtnClearSearch"
        BtnClearSearch.Size = New Size(40, 30)
        BtnClearSearch.TabIndex = 2
        BtnClearSearch.Text = "X"
        '
        ' BtnClose
        '
        BtnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnClose.BackColor = Color.Orange
        BtnClose.Location = New Point(560, 12)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New Size(60, 30)
        BtnClose.TabIndex = 3
        BtnClose.Text = "Close"
        BtnClose.UseVisualStyleBackColor = False
        '
        ' BtnSelect
        '
        BtnSelect.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnSelect.BackColor = Color.DeepSkyBlue
        BtnSelect.Location = New Point(630, 12)
        BtnSelect.Name = "BtnSelect"
        BtnSelect.Size = New Size(60, 30)
        BtnSelect.TabIndex = 4
        BtnSelect.Text = "Select"
        BtnSelect.UseVisualStyleBackColor = False
        '
        ' ListofTeam
        '
        ClientSize = New Size(700, 400)
        Controls.Add(PanelMain)
        Name = "ListofTeam"
        Text = "List of Team"
        PanelMain.ResumeLayout(False)
        CType(DataGridViewTeamList, ComponentModel.ISupportInitialize).EndInit()
        PanelBottom.ResumeLayout(False)
        PanelBottom.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMain As Panel
    Friend WithEvents DataGridViewTeamList As DataGridView
    Friend WithEvents ColTeamId As DataGridViewTextBoxColumn
    Friend WithEvents ColTeamName As DataGridViewTextBoxColumn
    Friend WithEvents ColTeamInfo As DataGridViewTextBoxColumn
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnClearSearch As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnSelect As Button

End Class
