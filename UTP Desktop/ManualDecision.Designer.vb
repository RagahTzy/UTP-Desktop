<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManualDecision
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitle = New Label()
        grpHantei = New GroupBox()
        btnAKA1 = New Button()
        btnAKA2 = New Button()
        btnAKA3 = New Button()
        btnAKA4 = New Button()
        btnAO1 = New Button()
        btnAO2 = New Button()
        btnAO3 = New Button()
        btnAO4 = New Button()
        lblAKA = New Label()
        lblAO = New Label()
        grpReferee = New GroupBox()
        btnWinnerAKA = New Button()
        btnWinnerAO = New Button()
        PicRefAKA = New PictureBox()
        PicRefAO = New PictureBox()
        PictureBoxReferee = New PictureBox()
        lblWinner = New Label()
        btnClear = New Button()
        btnClose = New Button()
        btnSave = New Button()
        grpHantei.SuspendLayout()
        grpReferee.SuspendLayout()
        CType(PicRefAKA, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicRefAO, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxReferee, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        ' ──────────────────────────────────────────
        ' FORM
        ' ──────────────────────────────────────────
        Me.ClientSize = New Size(584, 480)
        Me.Text = "Manual Decision"
        Me.Name = "ManualDecision"
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.White

        ' ──────────────────────────────────────────
        ' lblTitle — "Manual Decision is Required."
        ' ──────────────────────────────────────────
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.Black
        lblTitle.Text = "Manual Decision is Required."
        lblTitle.Location = New Point(148, 12)
        lblTitle.Name = "lblTitle"
        lblTitle.TabIndex = 0

        ' ──────────────────────────────────────────
        ' grpHantei — GroupBox "HANTEI"
        ' ──────────────────────────────────────────
        grpHantei.Text = "HANTEI"
        grpHantei.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        grpHantei.Location = New Point(12, 42)
        grpHantei.Size = New Size(560, 290)
        grpHantei.Name = "grpHantei"
        grpHantei.TabIndex = 1
        grpHantei.TabStop = False
        grpHantei.BackColor = Color.White

        ' --- AKA Buttons (baris merah) ---
        ' btnAKA1
        btnAKA1.Name = "btnAKA1"
        btnAKA1.Size = New Size(72, 64)
        btnAKA1.Location = New Point(18, 30)
        btnAKA1.BackColor = Color.White
        btnAKA1.FlatStyle = FlatStyle.Flat
        btnAKA1.FlatAppearance.BorderColor = Color.Silver
        btnAKA1.FlatAppearance.BorderSize = 1
        btnAKA1.ImageAlign = ContentAlignment.TopCenter
        btnAKA1.TextAlign = ContentAlignment.BottomCenter
        btnAKA1.Text = "1"
        btnAKA1.Font = New Font("Segoe UI", 8.0F)
        btnAKA1.ForeColor = Color.Black
        btnAKA1.TabIndex = 0
        btnAKA1.UseVisualStyleBackColor = False

        ' btnAKA2
        btnAKA2.Name = "btnAKA2"
        btnAKA2.Size = New Size(72, 64)
        btnAKA2.Location = New Point(100, 30)
        btnAKA2.BackColor = Color.White
        btnAKA2.FlatStyle = FlatStyle.Flat
        btnAKA2.FlatAppearance.BorderColor = Color.Silver
        btnAKA2.FlatAppearance.BorderSize = 1
        btnAKA2.ImageAlign = ContentAlignment.TopCenter
        btnAKA2.TextAlign = ContentAlignment.BottomCenter
        btnAKA2.Text = "2"
        btnAKA2.Font = New Font("Segoe UI", 8.0F)
        btnAKA2.ForeColor = Color.Black
        btnAKA2.TabIndex = 1
        btnAKA2.UseVisualStyleBackColor = False

        ' btnAKA3
        btnAKA3.Name = "btnAKA3"
        btnAKA3.Size = New Size(72, 64)
        btnAKA3.Location = New Point(182, 30)
        btnAKA3.BackColor = Color.White
        btnAKA3.FlatStyle = FlatStyle.Flat
        btnAKA3.FlatAppearance.BorderColor = Color.Silver
        btnAKA3.FlatAppearance.BorderSize = 1
        btnAKA3.ImageAlign = ContentAlignment.TopCenter
        btnAKA3.TextAlign = ContentAlignment.BottomCenter
        btnAKA3.Text = "3"
        btnAKA3.Font = New Font("Segoe UI", 8.0F)
        btnAKA3.ForeColor = Color.Black
        btnAKA3.TabIndex = 2
        btnAKA3.UseVisualStyleBackColor = False

        ' btnAKA4
        btnAKA4.Name = "btnAKA4"
        btnAKA4.Size = New Size(72, 64)
        btnAKA4.Location = New Point(264, 30)
        btnAKA4.BackColor = Color.White
        btnAKA4.FlatStyle = FlatStyle.Flat
        btnAKA4.FlatAppearance.BorderColor = Color.Silver
        btnAKA4.FlatAppearance.BorderSize = 1
        btnAKA4.ImageAlign = ContentAlignment.TopCenter
        btnAKA4.TextAlign = ContentAlignment.BottomCenter
        btnAKA4.Text = "4"
        btnAKA4.Font = New Font("Segoe UI", 8.0F)
        btnAKA4.ForeColor = Color.Black
        btnAKA4.TabIndex = 3
        btnAKA4.UseVisualStyleBackColor = False

        ' --- AO Buttons (baris biru) ---
        ' btnAO1
        btnAO1.Name = "btnAO1"
        btnAO1.Size = New Size(72, 64)
        btnAO1.Location = New Point(18, 110)
        btnAO1.BackColor = Color.White
        btnAO1.FlatStyle = FlatStyle.Flat
        btnAO1.FlatAppearance.BorderColor = Color.Silver
        btnAO1.FlatAppearance.BorderSize = 1
        btnAO1.ImageAlign = ContentAlignment.TopCenter
        btnAO1.TextAlign = ContentAlignment.BottomCenter
        btnAO1.Text = "1"
        btnAO1.Font = New Font("Segoe UI", 8.0F)
        btnAO1.ForeColor = Color.Black
        btnAO1.TabIndex = 4
        btnAO1.UseVisualStyleBackColor = False

        ' btnAO2
        btnAO2.Name = "btnAO2"
        btnAO2.Size = New Size(72, 64)
        btnAO2.Location = New Point(100, 110)
        btnAO2.BackColor = Color.White
        btnAO2.FlatStyle = FlatStyle.Flat
        btnAO2.FlatAppearance.BorderColor = Color.Silver
        btnAO2.FlatAppearance.BorderSize = 1
        btnAO2.ImageAlign = ContentAlignment.TopCenter
        btnAO2.TextAlign = ContentAlignment.BottomCenter
        btnAO2.Text = "2"
        btnAO2.Font = New Font("Segoe UI", 8.0F)
        btnAO2.ForeColor = Color.Black
        btnAO2.TabIndex = 5
        btnAO2.UseVisualStyleBackColor = False

        ' btnAO3
        btnAO3.Name = "btnAO3"
        btnAO3.Size = New Size(72, 64)
        btnAO3.Location = New Point(182, 110)
        btnAO3.BackColor = Color.White
        btnAO3.FlatStyle = FlatStyle.Flat
        btnAO3.FlatAppearance.BorderColor = Color.Silver
        btnAO3.FlatAppearance.BorderSize = 1
        btnAO3.ImageAlign = ContentAlignment.TopCenter
        btnAO3.TextAlign = ContentAlignment.BottomCenter
        btnAO3.Text = "3"
        btnAO3.Font = New Font("Segoe UI", 8.0F)
        btnAO3.ForeColor = Color.Black
        btnAO3.TabIndex = 6
        btnAO3.UseVisualStyleBackColor = False

        ' btnAO4
        btnAO4.Name = "btnAO4"
        btnAO4.Size = New Size(72, 64)
        btnAO4.Location = New Point(264, 110)
        btnAO4.BackColor = Color.White
        btnAO4.FlatStyle = FlatStyle.Flat
        btnAO4.FlatAppearance.BorderColor = Color.Silver
        btnAO4.FlatAppearance.BorderSize = 1
        btnAO4.ImageAlign = ContentAlignment.TopCenter
        btnAO4.TextAlign = ContentAlignment.BottomCenter
        btnAO4.Text = "4"
        btnAO4.Font = New Font("Segoe UI", 8.0F)
        btnAO4.ForeColor = Color.Black
        btnAO4.TabIndex = 7
        btnAO4.UseVisualStyleBackColor = False

        ' --- lblAKA ---
        lblAKA.Text = "AKA      =      0"
        lblAKA.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblAKA.ForeColor = Color.Black
        lblAKA.Location = New Point(358, 48)
        lblAKA.Size = New Size(185, 28)
        lblAKA.Name = "lblAKA"
        lblAKA.TabIndex = 8

        ' --- lblAO ---
        lblAO.Text = "AO         =      0"
        lblAO.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblAO.ForeColor = Color.Black
        lblAO.Location = New Point(358, 128)
        lblAO.Size = New Size(185, 28)
        lblAO.Name = "lblAO"
        lblAO.TabIndex = 9

        ' ──────────────────────────────────────────
        ' grpReferee — "Referee Selected Winner"
        ' ──────────────────────────────────────────
        grpReferee.Text = "Referee Selected Winner"
        grpReferee.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular)
        grpReferee.ForeColor = Color.DimGray
        grpReferee.Location = New Point(18, 200)
        grpReferee.Size = New Size(295, 72)
        grpReferee.Name = "grpReferee"
        grpReferee.TabIndex = 10
        grpReferee.TabStop = False
        grpReferee.BackColor = Color.White

        ' btnWinnerAKA — tombol AKA + ikon bendera abu-abu di dalam grpReferee
        btnWinnerAKA.Name = "btnWinnerAKA"
        btnWinnerAKA.Size = New Size(110, 42)
        btnWinnerAKA.Location = New Point(14, 18)
        btnWinnerAKA.BackColor = Color.White
        btnWinnerAKA.FlatStyle = FlatStyle.Flat
        btnWinnerAKA.FlatAppearance.BorderColor = Color.Silver
        btnWinnerAKA.FlatAppearance.BorderSize = 1
        btnWinnerAKA.Text = "AKA"
        btnWinnerAKA.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        btnWinnerAKA.ForeColor = Color.DimGray
        btnWinnerAKA.ImageAlign = ContentAlignment.MiddleRight
        btnWinnerAKA.TextAlign = ContentAlignment.MiddleLeft
        btnWinnerAKA.Enabled = False
        btnWinnerAKA.TabIndex = 0
        btnWinnerAKA.UseVisualStyleBackColor = False

        ' btnWinnerAO — tombol AO + ikon bendera abu-abu di dalam grpReferee
        btnWinnerAO.Name = "btnWinnerAO"
        btnWinnerAO.Size = New Size(110, 42)
        btnWinnerAO.Location = New Point(162, 18)
        btnWinnerAO.BackColor = Color.White
        btnWinnerAO.FlatStyle = FlatStyle.Flat
        btnWinnerAO.FlatAppearance.BorderColor = Color.Silver
        btnWinnerAO.FlatAppearance.BorderSize = 1
        btnWinnerAO.Text = "AO"
        btnWinnerAO.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        btnWinnerAO.ForeColor = Color.DimGray
        btnWinnerAO.ImageAlign = ContentAlignment.MiddleRight
        btnWinnerAO.TextAlign = ContentAlignment.MiddleLeft
        btnWinnerAO.Enabled = False
        btnWinnerAO.TabIndex = 1
        btnWinnerAO.UseVisualStyleBackColor = False

        ' PicRefAKA — ikon bendera kecil di sebelah kanan teks AKA
        PicRefAKA.Name = "PicRefAKA"
        PicRefAKA.Size = New Size(28, 28)
        PicRefAKA.Location = New Point(76, 7)
        PicRefAKA.BackColor = Color.Transparent
        PicRefAKA.TabStop = False
        PicRefAKA.SizeMode = PictureBoxSizeMode.Zoom

        ' PicRefAO — ikon bendera kecil di sebelah kanan teks AO
        PicRefAO.Name = "PicRefAO"
        PicRefAO.Size = New Size(28, 28)
        PicRefAO.Location = New Point(224, 7)
        PicRefAO.BackColor = Color.Transparent
        PicRefAO.TabStop = False
        PicRefAO.SizeMode = PictureBoxSizeMode.Zoom

        ' ──────────────────────────────────────────
        ' PictureBoxReferee — ikon orang (wasit) kanan bawah
        ' ──────────────────────────────────────────
        PictureBoxReferee.Name = "PictureBoxReferee"
        PictureBoxReferee.Size = New Size(44, 50)
        PictureBoxReferee.Location = New Point(490, 215)
        PictureBoxReferee.BackColor = Color.White
        PictureBoxReferee.TabStop = False
        PictureBoxReferee.SizeMode = PictureBoxSizeMode.Zoom

        ' ──────────────────────────────────────────
        ' lblWinner — bar kuning "Winner :"
        ' ──────────────────────────────────────────
        lblWinner.Text = "Winner :"
        lblWinner.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblWinner.ForeColor = Color.Black
        lblWinner.BackColor = Color.Gold
        lblWinner.TextAlign = ContentAlignment.MiddleCenter
        lblWinner.Location = New Point(12, 345)
        lblWinner.Size = New Size(560, 46)
        lblWinner.Name = "lblWinner"
        lblWinner.TabIndex = 2

        ' ──────────────────────────────────────────
        ' btnClear
        ' ──────────────────────────────────────────
        btnClear.Text = "Clear"
        btnClear.Font = New Font("Segoe UI", 9.5F)
        btnClear.Location = New Point(168, 408)
        btnClear.Size = New Size(88, 32)
        btnClear.FlatStyle = FlatStyle.System
        btnClear.Name = "btnClear"
        btnClear.TabIndex = 3

        ' ──────────────────────────────────────────
        ' btnClose
        ' ──────────────────────────────────────────
        btnClose.Text = "Close"
        btnClose.Font = New Font("Segoe UI", 9.5F)
        btnClose.Location = New Point(270, 408)
        btnClose.Size = New Size(88, 32)
        btnClose.FlatStyle = FlatStyle.System
        btnClose.Name = "btnClose"
        btnClose.TabIndex = 4

        ' ──────────────────────────────────────────
        ' btnSave
        ' ──────────────────────────────────────────
        btnSave.Text = "Save"
        btnSave.Font = New Font("Segoe UI", 9.5F)
        btnSave.Location = New Point(372, 408)
        btnSave.Size = New Size(88, 32)
        btnSave.FlatStyle = FlatStyle.System
        btnSave.Name = "btnSave"
        btnSave.TabIndex = 5

        ' ──────────────────────────────────────────
        ' Susun grpHantei → tambah semua child
        ' ──────────────────────────────────────────
        grpHantei.Controls.Add(btnAKA1)
        grpHantei.Controls.Add(btnAKA2)
        grpHantei.Controls.Add(btnAKA3)
        grpHantei.Controls.Add(btnAKA4)
        grpHantei.Controls.Add(btnAO1)
        grpHantei.Controls.Add(btnAO2)
        grpHantei.Controls.Add(btnAO3)
        grpHantei.Controls.Add(btnAO4)
        grpHantei.Controls.Add(lblAKA)
        grpHantei.Controls.Add(lblAO)
        grpHantei.Controls.Add(grpReferee)
        grpHantei.Controls.Add(PictureBoxReferee)

        ' ──────────────────────────────────────────
        ' Susun grpReferee → tambah child
        ' ──────────────────────────────────────────
        grpReferee.Controls.Add(btnWinnerAKA)
        grpReferee.Controls.Add(btnWinnerAO)
        grpReferee.Controls.Add(PicRefAKA)
        grpReferee.Controls.Add(PicRefAO)

        ' ──────────────────────────────────────────
        ' Form → tambah semua top-level control
        ' ──────────────────────────────────────────
        Controls.Add(lblTitle)
        Controls.Add(grpHantei)
        Controls.Add(lblWinner)
        Controls.Add(btnClear)
        Controls.Add(btnClose)
        Controls.Add(btnSave)

        grpHantei.ResumeLayout(False)
        grpReferee.ResumeLayout(False)
        CType(PicRefAKA, ComponentModel.ISupportInitialize).EndInit()
        CType(PicRefAO, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxReferee, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents grpHantei As GroupBox

    Friend WithEvents btnAKA1 As Button
    Friend WithEvents btnAKA2 As Button
    Friend WithEvents btnAKA3 As Button
    Friend WithEvents btnAKA4 As Button

    Friend WithEvents btnAO1 As Button
    Friend WithEvents btnAO2 As Button
    Friend WithEvents btnAO3 As Button
    Friend WithEvents btnAO4 As Button

    Friend WithEvents lblAKA As Label
    Friend WithEvents lblAO As Label

    Friend WithEvents grpReferee As GroupBox
    Friend WithEvents btnWinnerAKA As Button
    Friend WithEvents btnWinnerAO As Button
    Friend WithEvents PicRefAKA As PictureBox
    Friend WithEvents PicRefAO As PictureBox
    Friend WithEvents PictureBoxReferee As PictureBox

    Friend WithEvents lblWinner As Label

    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button

End Class