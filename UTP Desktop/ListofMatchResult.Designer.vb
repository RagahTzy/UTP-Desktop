<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListofMatchResult
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        PanelHeader = New Panel()
        BtnExportExcel = New Button()
        LblTitle = New Label()
        BtnClose = New Button()
        PanelSidebar = New Panel()
        BtnApplyFilter = New Button()
        TxtSearch = New TextBox()
        LblSearch = New Label()
        DtTo = New DateTimePicker()
        LblTo = New Label()
        DtFrom = New DateTimePicker()
        LblFrom = New Label()
        CboType = New ComboBox()
        LblFilterType = New Label()
        DgvResults = New DataGridView()
        PanelFooter = New Panel()
        BtnDelete = New Button()
        BtnClearAll = New Button()
        PanelHeader.SuspendLayout()
        PanelSidebar.SuspendLayout()
        CType(DgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        PanelFooter.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        PanelHeader.Controls.Add(BtnExportExcel)
        PanelHeader.Controls.Add(LblTitle)
        PanelHeader.Controls.Add(BtnClose)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(1000, 60)
        PanelHeader.TabIndex = 0
        ' 
        ' BtnExportExcel
        ' 
        BtnExportExcel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnExportExcel.BackColor = Color.SeaGreen
        BtnExportExcel.FlatStyle = FlatStyle.Flat
        BtnExportExcel.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        BtnExportExcel.ForeColor = Color.White
        BtnExportExcel.Location = New Point(800, 15)
        BtnExportExcel.Name = "BtnExportExcel"
        BtnExportExcel.Size = New Size(140, 30)
        BtnExportExcel.TabIndex = 2
        BtnExportExcel.Text = "Export to Excel 📊"
        BtnExportExcel.UseVisualStyleBackColor = False
        ' 
        ' LblTitle
        ' 
        LblTitle.AutoSize = True
        LblTitle.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        LblTitle.ForeColor = Color.White
        LblTitle.Location = New Point(20, 15)
        LblTitle.Name = "LblTitle"
        LblTitle.Size = New Size(265, 30)
        LblTitle.TabIndex = 0
        LblTitle.Text = "LIST OF MATCH RESULT"
        ' 
        ' BtnClose
        ' 
        BtnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnClose.FlatAppearance.BorderSize = 0
        BtnClose.FlatStyle = FlatStyle.Flat
        BtnClose.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        BtnClose.ForeColor = Color.White
        BtnClose.Location = New Point(955, 12)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New Size(35, 35)
        BtnClose.TabIndex = 1
        BtnClose.Text = "X"
        BtnClose.UseVisualStyleBackColor = True
        ' 
        ' PanelSidebar
        ' 
        PanelSidebar.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        PanelSidebar.Controls.Add(BtnApplyFilter)
        PanelSidebar.Controls.Add(TxtSearch)
        PanelSidebar.Controls.Add(LblSearch)
        PanelSidebar.Controls.Add(DtTo)
        PanelSidebar.Controls.Add(LblTo)
        PanelSidebar.Controls.Add(DtFrom)
        PanelSidebar.Controls.Add(LblFrom)
        PanelSidebar.Controls.Add(CboType)
        PanelSidebar.Controls.Add(LblFilterType)
        PanelSidebar.Dock = DockStyle.Left
        PanelSidebar.Location = New Point(0, 60)
        PanelSidebar.Name = "PanelSidebar"
        PanelSidebar.Padding = New Padding(15)
        PanelSidebar.Size = New Size(220, 540)
        PanelSidebar.TabIndex = 1
        ' 
        ' BtnApplyFilter
        ' 
        BtnApplyFilter.BackColor = Color.DodgerBlue
        BtnApplyFilter.FlatStyle = FlatStyle.Flat
        BtnApplyFilter.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        BtnApplyFilter.ForeColor = Color.White
        BtnApplyFilter.Location = New Point(15, 300)
        BtnApplyFilter.Name = "BtnApplyFilter"
        BtnApplyFilter.Size = New Size(190, 35)
        BtnApplyFilter.TabIndex = 8
        BtnApplyFilter.Text = "Apply Filter 🔍"
        BtnApplyFilter.UseVisualStyleBackColor = False
        ' 
        ' TxtSearch
        ' 
        TxtSearch.Location = New Point(15, 255)
        TxtSearch.Name = "TxtSearch"
        TxtSearch.PlaceholderText = "Search athlete/category..."
        TxtSearch.Size = New Size(190, 23)
        TxtSearch.TabIndex = 7
        ' 
        ' LblSearch
        ' 
        LblSearch.AutoSize = True
        LblSearch.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblSearch.Location = New Point(15, 235)
        LblSearch.Name = "LblSearch"
        LblSearch.Size = New Size(48, 15)
        LblSearch.TabIndex = 6
        LblSearch.Text = "Search:"
        ' 
        ' DtTo
        ' 
        DtTo.Format = DateTimePickerFormat.Short
        DtTo.Location = New Point(15, 195)
        DtTo.Name = "DtTo"
        DtTo.Size = New Size(190, 23)
        DtTo.TabIndex = 5
        ' 
        ' LblTo
        ' 
        LblTo.AutoSize = True
        LblTo.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblTo.Location = New Point(15, 175)
        LblTo.Name = "LblTo"
        LblTo.Size = New Size(23, 15)
        LblTo.TabIndex = 4
        LblTo.Text = "To:"
        ' 
        ' DtFrom
        ' 
        DtFrom.Format = DateTimePickerFormat.Short
        DtFrom.Location = New Point(15, 135)
        DtFrom.Name = "DtFrom"
        DtFrom.Size = New Size(190, 23)
        DtFrom.TabIndex = 3
        ' 
        ' LblFrom
        ' 
        LblFrom.AutoSize = True
        LblFrom.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblFrom.Location = New Point(15, 115)
        LblFrom.Name = "LblFrom"
        LblFrom.Size = New Size(39, 15)
        LblFrom.TabIndex = 2
        LblFrom.Text = "From:"
        ' 
        ' CboType
        ' 
        CboType.DropDownStyle = ComboBoxStyle.DropDownList
        CboType.FormattingEnabled = True
        CboType.Items.AddRange(New Object() {"ALL", "KUMITE", "KATA"})
        CboType.Location = New Point(15, 75)
        CboType.Name = "CboType"
        CboType.Size = New Size(190, 23)
        CboType.TabIndex = 1
        ' 
        ' LblFilterType
        ' 
        LblFilterType.AutoSize = True
        LblFilterType.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblFilterType.Location = New Point(15, 55)
        LblFilterType.Name = "LblFilterType"
        LblFilterType.Size = New Size(74, 15)
        LblFilterType.TabIndex = 0
        LblFilterType.Text = "Match Type:"
        ' 
        ' DgvResults
        ' 
        DgvResults.AllowUserToAddRows = False
        DgvResults.AllowUserToDeleteRows = False
        DgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvResults.BackgroundColor = Color.White
        DgvResults.BorderStyle = BorderStyle.None
        DgvResults.ColumnHeadersHeight = 40
        DgvResults.Dock = DockStyle.Fill
        DgvResults.GridColor = Color.LightGray
        DgvResults.Location = New Point(220, 60)
        DgvResults.Name = "DgvResults"
        DgvResults.ReadOnly = True
        DgvResults.RowHeadersVisible = False
        DgvResults.RowTemplate.Height = 35
        DgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvResults.Size = New Size(780, 490)
        DgvResults.TabIndex = 2
        ' 
        ' PanelFooter
        ' 
        PanelFooter.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        PanelFooter.Controls.Add(BtnDelete)
        PanelFooter.Controls.Add(BtnClearAll)
        PanelFooter.Dock = DockStyle.Bottom
        PanelFooter.Location = New Point(220, 550)
        PanelFooter.Name = "PanelFooter"
        PanelFooter.Size = New Size(780, 50)
        PanelFooter.TabIndex = 3
        ' 
        ' BtnDelete
        ' 
        BtnDelete.BackColor = Color.Firebrick
        BtnDelete.FlatStyle = FlatStyle.Flat
        BtnDelete.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        BtnDelete.ForeColor = Color.White
        BtnDelete.Location = New Point(15, 10)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(120, 30)
        BtnDelete.TabIndex = 0
        BtnDelete.Text = "Delete Selected"
        BtnDelete.UseVisualStyleBackColor = False
        ' 
        ' BtnClearAll
        ' 
        BtnClearAll.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnClearAll.BackColor = Color.Gray
        BtnClearAll.FlatStyle = FlatStyle.Flat
        BtnClearAll.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        BtnClearAll.ForeColor = Color.White
        BtnClearAll.Location = New Point(645, 10)
        BtnClearAll.Name = "BtnClearAll"
        BtnClearAll.Size = New Size(120, 30)
        BtnClearAll.TabIndex = 1
        BtnClearAll.Text = "Clear All"
        BtnClearAll.UseVisualStyleBackColor = False
        ' 
        ' ListofMatchResult
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 600)
        Controls.Add(DgvResults)
        Controls.Add(PanelFooter)
        Controls.Add(PanelSidebar)
        Controls.Add(PanelHeader)
        FormBorderStyle = FormBorderStyle.None
        Name = "ListofMatchResult"
        StartPosition = FormStartPosition.CenterScreen
        Text = "List of Match Result"
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        PanelSidebar.ResumeLayout(False)
        PanelSidebar.PerformLayout()
        CType(DgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        PanelFooter.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents LblTitle As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnExportExcel As Button
    Friend WithEvents PanelSidebar As Panel
    Friend WithEvents LblFilterType As Label
    Friend WithEvents CboType As ComboBox
    Friend WithEvents LblFrom As Label
    Friend WithEvents DtFrom As DateTimePicker
    Friend WithEvents LblTo As Label
    Friend WithEvents DtTo As DateTimePicker
    Friend WithEvents LblSearch As Label
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents BtnApplyFilter As Button
    Friend WithEvents DgvResults As DataGridView
    Friend WithEvents PanelFooter As Panel
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnClearAll As Button
End Class
