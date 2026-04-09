<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Team
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PanelHeader = New Panel()
        LabelTitle = New Label()
        LabelTeam = New Label()
        TextBoxTeam = New TextBox()
        LabelTeamInfo = New Label()
        TextBoxTeamInfo = New TextBox()
        CheckBoxUseFlag = New CheckBox()
        LabelCountry = New Label()
        ComboBoxCountry = New ComboBox()
        LabelTeamPic = New Label()
        PictureBoxTeam = New PictureBox()
        ButtonSelectPic = New Button()
        ButtonAdd = New Button()
        ButtonClear = New Button()
        LabelNew = New Label()
        PanelSeparator1 = New Panel()
        LabelTotalRecords = New Label()
        PanelSeparator2 = New Panel()
        ButtonExportExcel = New Button()
        ButtonImportExcel = New Button()
        DataGridViewTeam = New DataGridView()
        ColDelete = New DataGridViewButtonColumn()
        ColEdit = New DataGridViewButtonColumn()
        ColTeamName = New DataGridViewTextBoxColumn()
        ColInfo = New DataGridViewTextBoxColumn()
        ColPict = New DataGridViewTextBoxColumn()
        PanelBottom = New Panel()
        TextBoxSearch = New TextBox()
        ButtonSearch = New Button()
        ButtonClearSearch = New Button()
        ButtonDeleteAll = New Button()
        PanelHeader.SuspendLayout()
        CType(PictureBoxTeam, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridViewTeam, ComponentModel.ISupportInitialize).BeginInit()
        PanelBottom.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.WhiteSmoke
        PanelHeader.BorderStyle = BorderStyle.FixedSingle
        PanelHeader.Controls.Add(LabelTitle)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(860, 36)
        PanelHeader.TabIndex = 0
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTitle.Location = New Point(375, 9)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(133, 28)
        LabelTitle.TabIndex = 0
        LabelTitle.Text = "Team Entries"
        ' 
        ' LabelTeam
        ' 
        LabelTeam.AutoSize = True
        LabelTeam.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTeam.Location = New Point(40, 54)
        LabelTeam.Name = "LabelTeam"
        LabelTeam.Size = New Size(51, 19)
        LabelTeam.TabIndex = 1
        LabelTeam.Text = "Team*"
        ' 
        ' TextBoxTeam
        ' 
        TextBoxTeam.Location = New Point(100, 51)
        TextBoxTeam.Name = "TextBoxTeam"
        TextBoxTeam.Size = New Size(200, 23)
        TextBoxTeam.TabIndex = 2
        ' 
        ' LabelTeamInfo
        ' 
        LabelTeamInfo.AutoSize = True
        LabelTeamInfo.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTeamInfo.Location = New Point(23, 76)
        LabelTeamInfo.Name = "LabelTeamInfo"
        LabelTeamInfo.Size = New Size(75, 19)
        LabelTeamInfo.TabIndex = 3
        LabelTeamInfo.Text = "Team Info"
        ' 
        ' TextBoxTeamInfo
        ' 
        TextBoxTeamInfo.Location = New Point(100, 73)
        TextBoxTeamInfo.Name = "TextBoxTeamInfo"
        TextBoxTeamInfo.Size = New Size(200, 23)
        TextBoxTeamInfo.TabIndex = 4
        ' 
        ' CheckBoxUseFlag
        ' 
        CheckBoxUseFlag.AutoSize = True
        CheckBoxUseFlag.Location = New Point(100, 98)
        CheckBoxUseFlag.Name = "CheckBoxUseFlag"
        CheckBoxUseFlag.Size = New Size(185, 21)
        CheckBoxUseFlag.TabIndex = 5
        CheckBoxUseFlag.Text = "Use Country Flag (Logo)"
        CheckBoxUseFlag.UseVisualStyleBackColor = True
        ' 
        ' LabelCountry
        ' 
        LabelCountry.AutoSize = True
        LabelCountry.Location = New Point(43, 121)
        LabelCountry.Name = "LabelCountry"
        LabelCountry.Size = New Size(57, 17)
        LabelCountry.TabIndex = 6
        LabelCountry.Text = "Country"
        ' 
        ' ComboBoxCountry
        ' 
        ComboBoxCountry.FormattingEnabled = True
        ComboBoxCountry.Items.AddRange(New Object() {"--select--", "Indonesia", "Malaysia", "Singapore"})
        ComboBoxCountry.Location = New Point(100, 118)
        ComboBoxCountry.Name = "ComboBoxCountry"
        ComboBoxCountry.Size = New Size(121, 25)
        ComboBoxCountry.TabIndex = 7
        ComboBoxCountry.Text = "--select--"
        ' 
        ' LabelTeamPic
        ' 
        LabelTeamPic.AutoSize = True
        LabelTeamPic.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTeamPic.Location = New Point(340, 43)
        LabelTeamPic.Name = "LabelTeamPic"
        LabelTeamPic.Size = New Size(96, 19)
        LabelTeamPic.TabIndex = 8
        LabelTeamPic.Text = "Team Picture"
        ' 
        ' PictureBoxTeam
        ' 
        PictureBoxTeam.BackColor = Color.LightGray
        PictureBoxTeam.BorderStyle = BorderStyle.FixedSingle
        PictureBoxTeam.Location = New Point(350, 58)
        PictureBoxTeam.Name = "PictureBoxTeam"
        PictureBoxTeam.Size = New Size(55, 49)
        PictureBoxTeam.TabIndex = 9
        PictureBoxTeam.TabStop = False
        ' 
        ' ButtonSelectPic
        ' 
        ButtonSelectPic.Location = New Point(340, 112)
        ButtonSelectPic.Name = "ButtonSelectPic"
        ButtonSelectPic.Size = New Size(75, 21)
        ButtonSelectPic.TabIndex = 10
        ButtonSelectPic.Text = "Select"
        ButtonSelectPic.UseVisualStyleBackColor = True
        ' 
        ' ButtonAdd
        ' 
        ButtonAdd.BackColor = Color.DeepSkyBlue
        ButtonAdd.FlatAppearance.BorderSize = 0
        ButtonAdd.FlatStyle = FlatStyle.Flat
        ButtonAdd.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonAdd.ForeColor = Color.White
        ButtonAdd.Location = New Point(520, 49)
        ButtonAdd.Name = "ButtonAdd"
        ButtonAdd.Size = New Size(150, 27)
        ButtonAdd.TabIndex = 11
        ButtonAdd.Text = "Add"
        ButtonAdd.UseVisualStyleBackColor = False
        ' 
        ' ButtonClear
        ' 
        ButtonClear.BackColor = Color.LightGreen
        ButtonClear.FlatAppearance.BorderSize = 0
        ButtonClear.FlatStyle = FlatStyle.Flat
        ButtonClear.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonClear.ForeColor = Color.White
        ButtonClear.Location = New Point(520, 85)
        ButtonClear.Name = "ButtonClear"
        ButtonClear.Size = New Size(150, 27)
        ButtonClear.TabIndex = 12
        ButtonClear.Text = "Clear"
        ButtonClear.UseVisualStyleBackColor = False
        ' 
        ' LabelNew
        ' 
        LabelNew.AutoSize = True
        LabelNew.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelNew.Location = New Point(575, 121)
        LabelNew.Name = "LabelNew"
        LabelNew.Size = New Size(44, 20)
        LabelNew.TabIndex = 13
        LabelNew.Text = "NEW"
        ' 
        ' PanelSeparator1
        ' 
        PanelSeparator1.BorderStyle = BorderStyle.FixedSingle
        PanelSeparator1.Location = New Point(0, 148)
        PanelSeparator1.Name = "PanelSeparator1"
        PanelSeparator1.Size = New Size(860, 1)
        PanelSeparator1.TabIndex = 14
        ' 
        ' LabelTotalRecords
        ' 
        LabelTotalRecords.AutoSize = True
        LabelTotalRecords.Location = New Point(15, 161)
        LabelTotalRecords.Name = "LabelTotalRecords"
        LabelTotalRecords.Size = New Size(117, 17)
        LabelTotalRecords.TabIndex = 15
        LabelTotalRecords.Text = "Total Records : 5"
        ' 
        ' PanelSeparator2
        ' 
        PanelSeparator2.BorderStyle = BorderStyle.FixedSingle
        PanelSeparator2.Location = New Point(0, 183)
        PanelSeparator2.Name = "PanelSeparator2"
        PanelSeparator2.Size = New Size(860, 1)
        PanelSeparator2.TabIndex = 16
        ' 
        ' ButtonExportExcel
        ' 
        ButtonExportExcel.Location = New Point(600, 157)
        ButtonExportExcel.Name = "ButtonExportExcel"
        ButtonExportExcel.Size = New Size(110, 21)
        ButtonExportExcel.TabIndex = 17
        ButtonExportExcel.Text = "Export to Excel x"
        ButtonExportExcel.UseVisualStyleBackColor = True
        ' 
        ' ButtonImportExcel
        ' 
        ButtonImportExcel.Location = New Point(720, 157)
        ButtonImportExcel.Name = "ButtonImportExcel"
        ButtonImportExcel.Size = New Size(120, 21)
        ButtonImportExcel.TabIndex = 18
        ButtonImportExcel.Text = "Import from Excel x"
        ButtonImportExcel.UseVisualStyleBackColor = True
        ' 
        ' DataGridViewTeam
        ' 
        DataGridViewTeam.AllowUserToAddRows = False
        DataGridViewTeam.BackgroundColor = Color.White
        DataGridViewTeam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewTeam.Columns.AddRange(New DataGridViewColumn() {ColDelete, ColEdit, ColTeamName, ColInfo, ColPict})
        DataGridViewTeam.Location = New Point(0, 184)
        DataGridViewTeam.Name = "DataGridViewTeam"
        DataGridViewTeam.RowHeadersWidth = 30
        DataGridViewTeam.Size = New Size(860, 424)
        DataGridViewTeam.TabIndex = 19
        ' 
        ' ColDelete
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.Red
        ColDelete.DefaultCellStyle = DataGridViewCellStyle1
        ColDelete.HeaderText = ""
        ColDelete.MinimumWidth = 6
        ColDelete.Name = "ColDelete"
        ColDelete.Text = "X"
        ColDelete.UseColumnTextForButtonValue = True
        ColDelete.Width = 30
        ' 
        ' ColEdit
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.ForeColor = Color.Blue
        ColEdit.DefaultCellStyle = DataGridViewCellStyle2
        ColEdit.HeaderText = ""
        ColEdit.MinimumWidth = 6
        ColEdit.Name = "ColEdit"
        ColEdit.Text = "E"
        ColEdit.UseColumnTextForButtonValue = True
        ColEdit.Width = 30
        ' 
        ' ColTeamName
        ' 
        ColTeamName.HeaderText = "Team"
        ColTeamName.MinimumWidth = 6
        ColTeamName.Name = "ColTeamName"
        ColTeamName.Width = 200
        ' 
        ' ColInfo
        ' 
        ColInfo.HeaderText = "Team Info"
        ColInfo.MinimumWidth = 6
        ColInfo.Name = "ColInfo"
        ColInfo.Width = 200
        ' 
        ' ColPict
        ' 
        ColPict.HeaderText = "Team Pict"
        ColPict.MinimumWidth = 6
        ColPict.Name = "ColPict"
        ColPict.Width = 150
        ' 
        ' PanelBottom
        ' 
        PanelBottom.BackColor = Color.Crimson
        PanelBottom.Controls.Add(TextBoxSearch)
        PanelBottom.Controls.Add(ButtonSearch)
        PanelBottom.Controls.Add(ButtonClearSearch)
        PanelBottom.Controls.Add(ButtonDeleteAll)
        PanelBottom.Dock = DockStyle.Bottom
        PanelBottom.Location = New Point(0, 608)
        PanelBottom.Name = "PanelBottom"
        PanelBottom.Size = New Size(860, 45)
        PanelBottom.TabIndex = 20
        ' 
        ' TextBoxSearch
        ' 
        TextBoxSearch.Location = New Point(15, 13)
        TextBoxSearch.Name = "TextBoxSearch"
        TextBoxSearch.Size = New Size(180, 23)
        TextBoxSearch.TabIndex = 0
        ' 
        ' ButtonSearch
        ' 
        ButtonSearch.Location = New Point(200, 12)
        ButtonSearch.Name = "ButtonSearch"
        ButtonSearch.Size = New Size(30, 22)
        ButtonSearch.TabIndex = 1
        ButtonSearch.Text = "🔍"
        ButtonSearch.UseVisualStyleBackColor = True
        ' 
        ' ButtonClearSearch
        ' 
        ButtonClearSearch.ForeColor = Color.DeepSkyBlue
        ButtonClearSearch.Location = New Point(235, 12)
        ButtonClearSearch.Name = "ButtonClearSearch"
        ButtonClearSearch.Size = New Size(30, 22)
        ButtonClearSearch.TabIndex = 2
        ButtonClearSearch.Text = "X"
        ButtonClearSearch.UseVisualStyleBackColor = True
        ' 
        ' ButtonDeleteAll
        ' 
        ButtonDeleteAll.BackColor = Color.LightSalmon
        ButtonDeleteAll.FlatStyle = FlatStyle.Flat
        ButtonDeleteAll.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonDeleteAll.Location = New Point(710, 9)
        ButtonDeleteAll.Name = "ButtonDeleteAll"
        ButtonDeleteAll.Size = New Size(130, 27)
        ButtonDeleteAll.TabIndex = 3
        ButtonDeleteAll.Text = "Delete All"
        ButtonDeleteAll.UseVisualStyleBackColor = False
        ' 
        ' Team
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 17.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(860, 653)
        Controls.Add(PanelBottom)
        Controls.Add(DataGridViewTeam)
        Controls.Add(ButtonImportExcel)
        Controls.Add(ButtonExportExcel)
        Controls.Add(PanelSeparator2)
        Controls.Add(LabelTotalRecords)
        Controls.Add(PanelSeparator1)
        Controls.Add(LabelNew)
        Controls.Add(ButtonClear)
        Controls.Add(ButtonAdd)
        Controls.Add(ButtonSelectPic)
        Controls.Add(PictureBoxTeam)
        Controls.Add(LabelTeamPic)
        Controls.Add(ComboBoxCountry)
        Controls.Add(LabelCountry)
        Controls.Add(CheckBoxUseFlag)
        Controls.Add(TextBoxTeamInfo)
        Controls.Add(LabelTeamInfo)
        Controls.Add(TextBoxTeam)
        Controls.Add(LabelTeam)
        Controls.Add(PanelHeader)
        Font = New Font("Microsoft Sans Serif", 8.25F)
        Name = "Team"
        Text = "Team Entries"
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        CType(PictureBoxTeam, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridViewTeam, ComponentModel.ISupportInitialize).EndInit()
        PanelBottom.ResumeLayout(False)
        PanelBottom.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents LabelTeam As System.Windows.Forms.Label
    Friend WithEvents TextBoxTeam As System.Windows.Forms.TextBox
    Friend WithEvents LabelTeamInfo As System.Windows.Forms.Label
    Friend WithEvents TextBoxTeamInfo As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxUseFlag As System.Windows.Forms.CheckBox
    Friend WithEvents LabelCountry As System.Windows.Forms.Label
    Friend WithEvents ComboBoxCountry As System.Windows.Forms.ComboBox
    Friend WithEvents LabelTeamPic As System.Windows.Forms.Label
    Friend WithEvents PictureBoxTeam As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonSelectPic As System.Windows.Forms.Button
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents LabelNew As System.Windows.Forms.Label
    Friend WithEvents PanelSeparator1 As System.Windows.Forms.Panel
    Friend WithEvents LabelTotalRecords As System.Windows.Forms.Label
    Friend WithEvents PanelSeparator2 As System.Windows.Forms.Panel
    Friend WithEvents ButtonExportExcel As System.Windows.Forms.Button
    Friend WithEvents ButtonImportExcel As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTeam As System.Windows.Forms.DataGridView
    Friend WithEvents ColDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ColEdit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ColTeamName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColInfo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPict As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PanelBottom As System.Windows.Forms.Panel
    Friend WithEvents TextBoxSearch As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSearch As System.Windows.Forms.Button
    Friend WithEvents ButtonClearSearch As System.Windows.Forms.Button
    Friend WithEvents ButtonDeleteAll As System.Windows.Forms.Button

End Class
