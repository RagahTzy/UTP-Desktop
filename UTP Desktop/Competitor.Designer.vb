<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Competitor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' DEKLARASI KOMPONEN UI
    Friend WithEvents lblTitleTop As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblTeam As Label
    Friend WithEvents cbTeam As ComboBox
    Friend WithEvents btnEditTeam As Button
    Friend WithEvents lblTeamInfo As Label
    Friend WithEvents txtTeamInfo As TextBox
    Friend WithEvents lblProfilePic As Label
    Friend WithEvents pbProfilePic As PictureBox
    Friend WithEvents btnSelectPic As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblNewStatus As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnClearSearch As Button
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents btnImportExcel As Button
    Friend WithEvents dgvTeams As DataGridView
    Friend WithEvents colTeamMain As DataGridViewTextBoxColumn
    Friend WithEvents dgvCompetitors As DataGridView
    Friend WithEvents colBlank1 As DataGridViewTextBoxColumn
    Friend WithEvents colBlank2 As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colTeam As DataGridViewTextBoxColumn
    Friend WithEvents colTeamInfo As DataGridViewTextBoxColumn
    Friend WithEvents colCompPict As DataGridViewTextBoxColumn
    Friend WithEvents lblTotalRecords As Label
    Friend WithEvents btnDeleteAll As Button

    'NOTE: The following procedure is required by the Windows Form Designer
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblTitleTop = New Label()
        lblName = New Label()
        txtName = New TextBox()
        lblTeam = New Label()
        cbTeam = New ComboBox()
        btnEditTeam = New Button()
        lblTeamInfo = New Label()
        txtTeamInfo = New TextBox()
        lblProfilePic = New Label()
        pbProfilePic = New PictureBox()
        btnSelectPic = New Button()
        btnAdd = New Button()
        btnClear = New Button()
        lblNewStatus = New Label()
        txtSearch = New TextBox()
        btnSearch = New Button()
        btnClearSearch = New Button()
        btnExportExcel = New Button()
        btnImportExcel = New Button()
        dgvTeams = New DataGridView()
        colTeamMain = New DataGridViewTextBoxColumn()
        dgvCompetitors = New DataGridView()
        colBlank1 = New DataGridViewTextBoxColumn()
        colBlank2 = New DataGridViewTextBoxColumn()
        colName = New DataGridViewTextBoxColumn()
        colTeam = New DataGridViewTextBoxColumn()
        colTeamInfo = New DataGridViewTextBoxColumn()
        colCompPict = New DataGridViewTextBoxColumn()
        lblTotalRecords = New Label()
        btnDeleteAll = New Button()
        CType(pbProfilePic, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTeams, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvCompetitors, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitleTop
        ' 
        lblTitleTop.AutoSize = True
        lblTitleTop.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblTitleTop.Location = New Point(340, 15)
        lblTitleTop.Name = "lblTitleTop"
        lblTitleTop.Size = New Size(153, 21)
        lblTitleTop.TabIndex = 22
        lblTitleTop.Text = "Competitor Entries"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblName.Location = New Point(80, 60)
        lblName.Name = "lblName"
        lblName.Size = New Size(45, 15)
        lblName.TabIndex = 21
        lblName.Text = "Name*"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(140, 57)
        txtName.Name = "txtName"
        txtName.Size = New Size(300, 23)
        txtName.TabIndex = 20
        ' 
        ' lblTeam
        ' 
        lblTeam.AutoSize = True
        lblTeam.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblTeam.Location = New Point(85, 90)
        lblTeam.Name = "lblTeam"
        lblTeam.Size = New Size(42, 15)
        lblTeam.TabIndex = 19
        lblTeam.Text = "Team*"
        ' 
        ' cbTeam
        ' 
        cbTeam.FormattingEnabled = True
        cbTeam.Items.AddRange(New Object() {"-- Select Team --"})
        cbTeam.Location = New Point(140, 87)
        cbTeam.Name = "cbTeam"
        cbTeam.Size = New Size(300, 23)
        cbTeam.TabIndex = 18
        cbTeam.Text = "-- Select Team --"
        ' 
        ' btnEditTeam
        ' 
        btnEditTeam.Location = New Point(445, 86)
        btnEditTeam.Name = "btnEditTeam"
        btnEditTeam.Size = New Size(35, 25)
        btnEditTeam.TabIndex = 17
        btnEditTeam.Text = "📝"
        ' 
        ' lblTeamInfo
        ' 
        lblTeamInfo.AutoSize = True
        lblTeamInfo.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblTeamInfo.Location = New Point(62, 120)
        lblTeamInfo.Name = "lblTeamInfo"
        lblTeamInfo.Size = New Size(63, 15)
        lblTeamInfo.TabIndex = 16
        lblTeamInfo.Text = "Team Info"
        ' 
        ' txtTeamInfo
        ' 
        txtTeamInfo.BackColor = Color.LightGray
        txtTeamInfo.Location = New Point(140, 117)
        txtTeamInfo.Name = "txtTeamInfo"
        txtTeamInfo.ReadOnly = True
        txtTeamInfo.Size = New Size(300, 23)
        txtTeamInfo.TabIndex = 15
        ' 
        ' lblProfilePic
        ' 
        lblProfilePic.AutoSize = True
        lblProfilePic.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblProfilePic.Location = New Point(40, 155)
        lblProfilePic.Name = "lblProfilePic"
        lblProfilePic.Size = New Size(87, 15)
        lblProfilePic.TabIndex = 14
        lblProfilePic.Text = "Profile Picture"
        ' 
        ' pbProfilePic
        ' 
        pbProfilePic.BorderStyle = BorderStyle.FixedSingle
        pbProfilePic.Location = New Point(140, 145)
        pbProfilePic.Name = "pbProfilePic"
        pbProfilePic.Size = New Size(40, 40)
        pbProfilePic.TabIndex = 13
        pbProfilePic.TabStop = False
        ' 
        ' btnSelectPic
        ' 
        btnSelectPic.Location = New Point(190, 155)
        btnSelectPic.Name = "btnSelectPic"
        btnSelectPic.Size = New Size(60, 23)
        btnSelectPic.TabIndex = 12
        btnSelectPic.Text = "Select"
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.DeepSkyBlue
        btnAdd.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(630, 50)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(140, 30)
        btnAdd.TabIndex = 11
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.LightGreen
        btnClear.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnClear.Location = New Point(630, 85)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(140, 30)
        btnClear.TabIndex = 10
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' lblNewStatus
        ' 
        lblNewStatus.AutoSize = True
        lblNewStatus.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblNewStatus.Location = New Point(680, 125)
        lblNewStatus.Name = "lblNewStatus"
        lblNewStatus.Size = New Size(41, 19)
        lblNewStatus.TabIndex = 9
        lblNewStatus.Text = "NEW"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(10, 205)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(180, 23)
        txtSearch.TabIndex = 8
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(195, 204)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(30, 25)
        btnSearch.TabIndex = 7
        btnSearch.Text = "🔍"
        ' 
        ' btnClearSearch
        ' 
        btnClearSearch.ForeColor = Color.DeepSkyBlue
        btnClearSearch.Location = New Point(230, 204)
        btnClearSearch.Name = "btnClearSearch"
        btnClearSearch.Size = New Size(30, 25)
        btnClearSearch.TabIndex = 6
        btnClearSearch.Text = "✖"
        ' 
        ' btnExportExcel
        ' 
        btnExportExcel.Location = New Point(540, 204)
        btnExportExcel.Name = "btnExportExcel"
        btnExportExcel.Size = New Size(110, 25)
        btnExportExcel.TabIndex = 5
        btnExportExcel.Text = "Export to Excel"
        ' 
        ' btnImportExcel
        ' 
        btnImportExcel.Location = New Point(660, 204)
        btnImportExcel.Name = "btnImportExcel"
        btnImportExcel.Size = New Size(120, 25)
        btnImportExcel.TabIndex = 4
        btnImportExcel.Text = "Import from Excel"
        ' 
        ' dgvTeams
        ' 
        dgvTeams.AllowUserToAddRows = False
        dgvTeams.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.Crimson
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        dgvTeams.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvTeams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTeams.Columns.AddRange(New DataGridViewColumn() {colTeamMain})
        dgvTeams.EnableHeadersVisualStyles = False
        dgvTeams.Location = New Point(0, 240)
        dgvTeams.Name = "dgvTeams"
        dgvTeams.RowHeadersVisible = False
        dgvTeams.Size = New Size(180, 310)
        dgvTeams.TabIndex = 3
        ' 
        ' colTeamMain
        ' 
        colTeamMain.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colTeamMain.HeaderText = "Team"
        colTeamMain.Name = "colTeamMain"
        colTeamMain.ReadOnly = True
        ' 
        ' dgvCompetitors
        ' 
        dgvCompetitors.AllowUserToAddRows = False
        dgvCompetitors.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dgvCompetitors.BackgroundColor = Color.White
        dgvCompetitors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCompetitors.Columns.AddRange(New DataGridViewColumn() {colBlank1, colBlank2, colName, colTeam, colTeamInfo, colCompPict})
        dgvCompetitors.Location = New Point(180, 240)
        dgvCompetitors.Name = "dgvCompetitors"
        dgvCompetitors.RowHeadersVisible = False
        dgvCompetitors.Size = New Size(620, 310)
        dgvCompetitors.TabIndex = 2
        ' 
        ' colBlank1
        ' 
        colBlank1.HeaderText = ""
        colBlank1.Name = "colBlank1"
        colBlank1.Width = 30
        ' 
        ' colBlank2
        ' 
        colBlank2.HeaderText = ""
        colBlank2.Name = "colBlank2"
        colBlank2.Width = 30
        ' 
        ' colName
        ' 
        colName.HeaderText = "Name"
        colName.Name = "colName"
        colName.Width = 150
        ' 
        ' colTeam
        ' 
        colTeam.HeaderText = "Team"
        colTeam.Name = "colTeam"
        colTeam.Width = 120
        ' 
        ' colTeamInfo
        ' 
        colTeamInfo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colTeamInfo.HeaderText = "Team Info"
        colTeamInfo.Name = "colTeamInfo"
        ' 
        ' colCompPict
        ' 
        colCompPict.HeaderText = "Comp. Pict"
        colCompPict.Name = "colCompPict"
        colCompPict.Width = 120
        ' 
        ' lblTotalRecords
        ' 
        lblTotalRecords.AutoSize = True
        lblTotalRecords.Location = New Point(10, 565)
        lblTotalRecords.Name = "lblTotalRecords"
        lblTotalRecords.Size = New Size(93, 15)
        lblTotalRecords.TabIndex = 1
        lblTotalRecords.Text = "Total Records : 0"
        ' 
        ' btnDeleteAll
        ' 
        btnDeleteAll.BackColor = Color.LightSalmon
        btnDeleteAll.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnDeleteAll.Location = New Point(650, 560)
        btnDeleteAll.Name = "btnDeleteAll"
        btnDeleteAll.Size = New Size(140, 30)
        btnDeleteAll.TabIndex = 0
        btnDeleteAll.Text = "Delete All"
        btnDeleteAll.UseVisualStyleBackColor = False
        ' 
        ' Competitor
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(800, 600)
        Controls.Add(btnDeleteAll)
        Controls.Add(lblTotalRecords)
        Controls.Add(dgvCompetitors)
        Controls.Add(dgvTeams)
        Controls.Add(btnImportExcel)
        Controls.Add(btnExportExcel)
        Controls.Add(btnClearSearch)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(lblNewStatus)
        Controls.Add(btnClear)
        Controls.Add(btnAdd)
        Controls.Add(btnSelectPic)
        Controls.Add(pbProfilePic)
        Controls.Add(lblProfilePic)
        Controls.Add(txtTeamInfo)
        Controls.Add(lblTeamInfo)
        Controls.Add(btnEditTeam)
        Controls.Add(cbTeam)
        Controls.Add(lblTeam)
        Controls.Add(txtName)
        Controls.Add(lblName)
        Controls.Add(lblTitleTop)
        Name = "Competitor"
        Text = "Competitor Entries"
        CType(pbProfilePic, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTeams, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvCompetitors, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

End Class