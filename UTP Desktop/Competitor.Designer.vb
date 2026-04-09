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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()

        Me.lblTitleTop = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblTeam = New System.Windows.Forms.Label()
        Me.cbTeam = New System.Windows.Forms.ComboBox()
        Me.btnEditTeam = New System.Windows.Forms.Button()
        Me.lblTeamInfo = New System.Windows.Forms.Label()
        Me.txtTeamInfo = New System.Windows.Forms.TextBox()
        Me.lblProfilePic = New System.Windows.Forms.Label()
        Me.pbProfilePic = New System.Windows.Forms.PictureBox()
        Me.btnSelectPic = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblNewStatus = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClearSearch = New System.Windows.Forms.Button()
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.btnImportExcel = New System.Windows.Forms.Button()
        Me.dgvTeams = New System.Windows.Forms.DataGridView()
        Me.colTeamMain = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCompetitors = New System.Windows.Forms.DataGridView()
        Me.colBlank1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBlank2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTeam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTeamInfo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCompPict = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTotalRecords = New System.Windows.Forms.Label()
        Me.btnDeleteAll = New System.Windows.Forms.Button()

        CType(Me.pbProfilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTeams, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCompetitors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '
        'lblTitleTop
        '
        Me.lblTitleTop.AutoSize = True
        Me.lblTitleTop.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitleTop.Location = New System.Drawing.Point(340, 15)
        Me.lblTitleTop.Name = "lblTitleTop"
        Me.lblTitleTop.Text = "Competitor Entries"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.Location = New System.Drawing.Point(80, 60)
        Me.lblName.Name = "lblName"
        Me.lblName.Text = "Name*"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(140, 57)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(300, 23)
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTeam.Location = New System.Drawing.Point(85, 90)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Text = "Team*"
        '
        'cbTeam
        '
        Me.cbTeam.FormattingEnabled = True
        Me.cbTeam.Items.AddRange(New Object() {"-- Select Team --"})
        Me.cbTeam.Location = New System.Drawing.Point(140, 87)
        Me.cbTeam.Name = "cbTeam"
        Me.cbTeam.Size = New System.Drawing.Size(300, 23)
        Me.cbTeam.Text = "-- Select Team --"
        '
        'btnEditTeam
        '
        Me.btnEditTeam.Location = New System.Drawing.Point(445, 86)
        Me.btnEditTeam.Name = "btnEditTeam"
        Me.btnEditTeam.Size = New System.Drawing.Size(35, 25)
        Me.btnEditTeam.Text = "📝"
        '
        'lblTeamInfo
        '
        Me.lblTeamInfo.AutoSize = True
        Me.lblTeamInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTeamInfo.Location = New System.Drawing.Point(62, 120)
        Me.lblTeamInfo.Name = "lblTeamInfo"
        Me.lblTeamInfo.Text = "Team Info"
        '
        'txtTeamInfo
        '
        Me.txtTeamInfo.BackColor = System.Drawing.Color.LightGray
        Me.txtTeamInfo.Location = New System.Drawing.Point(140, 117)
        Me.txtTeamInfo.Name = "txtTeamInfo"
        Me.txtTeamInfo.ReadOnly = True
        Me.txtTeamInfo.Size = New System.Drawing.Size(300, 23)
        '
        'lblProfilePic
        '
        Me.lblProfilePic.AutoSize = True
        Me.lblProfilePic.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblProfilePic.Location = New System.Drawing.Point(40, 155)
        Me.lblProfilePic.Name = "lblProfilePic"
        Me.lblProfilePic.Text = "Profile Picture"
        '
        'pbProfilePic
        '
        Me.pbProfilePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbProfilePic.Location = New System.Drawing.Point(140, 145)
        Me.pbProfilePic.Name = "pbProfilePic"
        Me.pbProfilePic.Size = New System.Drawing.Size(40, 40)
        '
        'btnSelectPic
        '
        Me.btnSelectPic.Location = New System.Drawing.Point(190, 155)
        Me.btnSelectPic.Name = "btnSelectPic"
        Me.btnSelectPic.Size = New System.Drawing.Size(60, 23)
        Me.btnSelectPic.Text = "Select"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(630, 50)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(140, 30)
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightGreen
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.Location = New System.Drawing.Point(630, 85)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(140, 30)
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblNewStatus
        '
        Me.lblNewStatus.AutoSize = True
        Me.lblNewStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblNewStatus.Location = New System.Drawing.Point(680, 125)
        Me.lblNewStatus.Name = "lblNewStatus"
        Me.lblNewStatus.Text = "NEW"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(10, 205)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(180, 23)
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(195, 204)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(30, 25)
        Me.btnSearch.Text = "🔍"
        '
        'btnClearSearch
        '
        Me.btnClearSearch.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.btnClearSearch.Location = New System.Drawing.Point(230, 204)
        Me.btnClearSearch.Name = "btnClearSearch"
        Me.btnClearSearch.Size = New System.Drawing.Size(30, 25)
        Me.btnClearSearch.Text = "✖"
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Location = New System.Drawing.Point(540, 204)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(110, 25)
        Me.btnExportExcel.Text = "Export to Excel"
        '
        'btnImportExcel
        '
        Me.btnImportExcel.Location = New System.Drawing.Point(660, 204)
        Me.btnImportExcel.Name = "btnImportExcel"
        Me.btnImportExcel.Size = New System.Drawing.Size(120, 25)
        Me.btnImportExcel.Text = "Import from Excel"
        '
        'dgvTeams
        '
        Me.dgvTeams.AllowUserToAddRows = False
        Me.dgvTeams.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.dgvTeams.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTeams.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTeamMain})
        Me.dgvTeams.EnableHeadersVisualStyles = False
        Me.dgvTeams.Location = New System.Drawing.Point(0, 240)
        Me.dgvTeams.Name = "dgvTeams"
        Me.dgvTeams.RowHeadersVisible = False
        Me.dgvTeams.Size = New System.Drawing.Size(180, 310)
        '
        'colTeamMain
        '
        Me.colTeamMain.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colTeamMain.HeaderText = "Team"
        Me.colTeamMain.Name = "colTeamMain"
        Me.colTeamMain.ReadOnly = True
        '
        'dgvCompetitors
        '
        Me.dgvCompetitors.AllowUserToAddRows = False
        Me.dgvCompetitors.BackgroundColor = System.Drawing.Color.White
        Me.dgvCompetitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompetitors.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBlank1, Me.colBlank2, Me.colName, Me.colTeam, Me.colTeamInfo, Me.colCompPict})
        Me.dgvCompetitors.Location = New System.Drawing.Point(180, 240)
        Me.dgvCompetitors.Name = "dgvCompetitors"
        Me.dgvCompetitors.RowHeadersVisible = False
        Me.dgvCompetitors.Size = New System.Drawing.Size(620, 310)
        '
        'colBlank1
        '
        Me.colBlank1.HeaderText = ""
        Me.colBlank1.Name = "colBlank1"
        Me.colBlank1.Width = 30
        '
        'colBlank2
        '
        Me.colBlank2.HeaderText = ""
        Me.colBlank2.Name = "colBlank2"
        Me.colBlank2.Width = 30
        '
        'colName
        '
        Me.colName.HeaderText = "Name"
        Me.colName.Name = "colName"
        Me.colName.Width = 150
        '
        'colTeam
        '
        Me.colTeam.HeaderText = "Team"
        Me.colTeam.Name = "colTeam"
        Me.colTeam.Width = 120
        '
        'colTeamInfo
        '
        Me.colTeamInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colTeamInfo.HeaderText = "Team Info"
        Me.colTeamInfo.Name = "colTeamInfo"
        '
        'colCompPict
        '
        Me.colCompPict.HeaderText = "Comp. Pict"
        Me.colCompPict.Name = "colCompPict"
        Me.colCompPict.Width = 120
        '
        'lblTotalRecords
        '
        Me.lblTotalRecords.AutoSize = True
        Me.lblTotalRecords.Location = New System.Drawing.Point(10, 565)
        Me.lblTotalRecords.Name = "lblTotalRecords"
        Me.lblTotalRecords.Text = "Total Records : 0"
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.BackColor = System.Drawing.Color.LightSalmon
        Me.btnDeleteAll.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteAll.Location = New System.Drawing.Point(650, 560)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(140, 30)
        Me.btnDeleteAll.Text = "Delete All"
        Me.btnDeleteAll.UseVisualStyleBackColor = False
        '
        'Competitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.btnDeleteAll)
        Me.Controls.Add(Me.lblTotalRecords)
        Me.Controls.Add(Me.dgvCompetitors)
        Me.Controls.Add(Me.dgvTeams)
        Me.Controls.Add(Me.btnImportExcel)
        Me.Controls.Add(Me.btnExportExcel)
        Me.Controls.Add(Me.btnClearSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblNewStatus)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSelectPic)
        Me.Controls.Add(Me.pbProfilePic)
        Me.Controls.Add(Me.lblProfilePic)
        Me.Controls.Add(Me.txtTeamInfo)
        Me.Controls.Add(Me.lblTeamInfo)
        Me.Controls.Add(Me.btnEditTeam)
        Me.Controls.Add(Me.cbTeam)
        Me.Controls.Add(Me.lblTeam)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTitleTop)
        Me.Name = "Competitor"
        Me.Text = "Competitor Entries"

        CType(Me.pbProfilePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTeams, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCompetitors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

End Class