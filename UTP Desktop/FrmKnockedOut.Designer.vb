<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmKnockedOut
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

    ' Deklarasi Kontrol yang kurang
    Friend WithEvents LblCountdown As System.Windows.Forms.Label
    Friend WithEvents TimerKO As System.Windows.Forms.Timer
    Friend WithEvents BtnCloseKO As System.Windows.Forms.Button

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LblCountdown = New System.Windows.Forms.Label()
        Me.TimerKO = New System.Windows.Forms.Timer(Me.components)
        Me.BtnCloseKO = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblCountdown
        '
        Me.LblCountdown.AutoSize = True
        Me.LblCountdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCountdown.Location = New System.Drawing.Point(340, 150)
        Me.LblCountdown.Name = "LblCountdown"
        Me.LblCountdown.Size = New System.Drawing.Size(106, 73)
        Me.LblCountdown.TabIndex = 0
        Me.LblCountdown.Text = "09"
        Me.LblCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerKO
        '
        Me.TimerKO.Interval = 1000
        '
        'BtnCloseKO
        '
        Me.BtnCloseKO.Location = New System.Drawing.Point(350, 300)
        Me.BtnCloseKO.Name = "BtnCloseKO"
        Me.BtnCloseKO.Size = New System.Drawing.Size(100, 40)
        Me.BtnCloseKO.TabIndex = 1
        Me.BtnCloseKO.Text = "Close"
        Me.BtnCloseKO.UseVisualStyleBackColor = True
        '
        'FrmKnockedOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnCloseKO)
        Me.Controls.Add(Me.LblCountdown)
        Me.Name = "FrmKnockedOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmKnockedOut"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
End Class