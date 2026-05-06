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
        grpWinner = New GroupBox()
        btnWinnerAKA = New Button()
        btnWinnerAO = New Button()
        lblWinner = New Label()
        btnClear = New Button()
        btnClose = New Button()
        btnSave = New Button()
        PictureBox1 = New PictureBox()
        grpHantei.SuspendLayout()
        grpWinner.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()


        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblTitle.Location = New Point(120, 10)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(287, 28)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Manual Decision is Required."


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
        grpHantei.Font = New Font("Clarendon BT", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpHantei.Location = New Point(20, 41)
        grpHantei.Name = "grpHantei"
        grpHantei.Size = New Size(500, 296)
        grpHantei.TabIndex = 1
        grpHantei.TabStop = False
        grpHantei.Text = "HANTEI"


        btnAKA1.BackColor = Color.Red
        btnAKA1.Location = New Point(20, 30)
        btnAKA1.Name = "btnAKA1"
        btnAKA1.Size = New Size(60, 50)
        btnAKA1.TabIndex = 0
        btnAKA1.Text = "1"
        btnAKA1.UseVisualStyleBackColor = False


        btnAKA2.BackColor = Color.Red
        btnAKA2.Location = New Point(90, 30)
        btnAKA2.Name = "btnAKA2"
        btnAKA2.Size = New Size(60, 50)
        btnAKA2.TabIndex = 1
        btnAKA2.Text = "2"
        btnAKA2.UseVisualStyleBackColor = False


        btnAKA3.BackColor = Color.Red
        btnAKA3.Location = New Point(160, 30)
        btnAKA3.Name = "btnAKA3"
        btnAKA3.Size = New Size(60, 50)
        btnAKA3.TabIndex = 2
        btnAKA3.Text = "3"
        btnAKA3.UseVisualStyleBackColor = False


        btnAKA4.BackColor = Color.Red
        btnAKA4.Location = New Point(230, 30)
        btnAKA4.Name = "btnAKA4"
        btnAKA4.Size = New Size(60, 50)
        btnAKA4.TabIndex = 3
        btnAKA4.Text = "4"
        btnAKA4.UseVisualStyleBackColor = False


        btnAO1.BackColor = Color.RoyalBlue
        btnAO1.Location = New Point(20, 100)
        btnAO1.Name = "btnAO1"
        btnAO1.Size = New Size(60, 50)
        btnAO1.TabIndex = 4
        btnAO1.Text = "1"
        btnAO1.UseVisualStyleBackColor = False


        btnAO2.BackColor = Color.RoyalBlue
        btnAO2.Location = New Point(90, 100)
        btnAO2.Name = "btnAO2"
        btnAO2.Size = New Size(60, 50)
        btnAO2.TabIndex = 5
        btnAO2.Text = "2"
        btnAO2.UseVisualStyleBackColor = False


        btnAO3.BackColor = Color.RoyalBlue
        btnAO3.Location = New Point(160, 100)
        btnAO3.Name = "btnAO3"
        btnAO3.Size = New Size(60, 50)
        btnAO3.TabIndex = 6
        btnAO3.Text = "3"
        btnAO3.UseVisualStyleBackColor = False


        btnAO4.BackColor = Color.RoyalBlue
        btnAO4.Location = New Point(230, 100)
        btnAO4.Name = "btnAO4"
        btnAO4.Size = New Size(60, 50)
        btnAO4.TabIndex = 7
        btnAO4.Text = "4"
        btnAO4.UseVisualStyleBackColor = False



        lblAKA.Location = New Point(320, 40)
        lblAKA.Name = "lblAKA"
        lblAKA.Size = New Size(150, 30)
        lblAKA.TabIndex = 8
        lblAKA.Text = "AKA      =      0"



        lblAO.Location = New Point(320, 110)
        lblAO.Name = "lblAO"
        lblAO.Size = New Size(150, 30)
        lblAO.TabIndex = 9
        lblAO.Text = "AO        =      0"



        grpWinner.Controls.Add(btnWinnerAKA)
        grpWinner.Controls.Add(btnWinnerAO)
        grpWinner.Font = New Font("Clarendon BT", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpWinner.Location = New Point(20, 250)
        grpWinner.Name = "grpWinner"
        grpWinner.Size = New Size(300, 80)
        grpWinner.TabIndex = 2
        grpWinner.TabStop = False
        grpWinner.Text = "Referee Selected Winner"



        btnWinnerAKA.Location = New Point(33, 25)
        btnWinnerAKA.Name = "btnWinnerAKA"
        btnWinnerAKA.Size = New Size(100, 40)
        btnWinnerAKA.TabIndex = 0
        btnWinnerAKA.Text = "AKA"



        btnWinnerAO.Location = New Point(170, 25)
        btnWinnerAO.Name = "btnWinnerAO"
        btnWinnerAO.Size = New Size(100, 40)
        btnWinnerAO.TabIndex = 1
        btnWinnerAO.Text = "AO"



        lblWinner.BackColor = Color.Gold
        lblWinner.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblWinner.Location = New Point(20, 340)
        lblWinner.Name = "lblWinner"
        lblWinner.Size = New Size(500, 40)
        lblWinner.TabIndex = 3
        lblWinner.Text = "Winner :"



        btnClear.Location = New Point(150, 400)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 27)
        btnClear.TabIndex = 4
        btnClear.Text = "Clear"



        btnClose.Location = New Point(250, 400)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 27)
        btnClose.TabIndex = 5
        btnClose.Text = "Close"



        btnSave.Location = New Point(350, 400)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 27)
        btnSave.TabIndex = 6
        btnSave.Text = "Save"



        PictureBox1.Location = New Point(422, 268)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(32, 33)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False



        ClientSize = New Size(553, 463)
        Controls.Add(PictureBox1)
        Controls.Add(lblTitle)
        Controls.Add(grpWinner)
        Controls.Add(lblWinner)
        Controls.Add(btnClear)
        Controls.Add(btnClose)
        Controls.Add(btnSave)
        Controls.Add(grpHantei)
        Name = "ManualDecision"
        Text = "Manual Decision"
        grpHantei.ResumeLayout(False)
        grpWinner.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
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

    Friend WithEvents grpWinner As GroupBox
    Friend WithEvents btnWinnerAKA As Button
    Friend WithEvents btnWinnerAO As Button

    Friend WithEvents lblWinner As Label

    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
