Imports QRCoder

Public Class QrGenerated

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub QrGenerated_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default values
        TxtBaseURL.Text = "https://kata.yabinya.com/scbscoring"
        TxtTatamiID.Text = "TM-" & Guid.NewGuid().ToString("N").Substring(0, 12).ToUpper()
        LblTimestamp.Text = DateTime.Now.ToString("M/d/yyyy h:mm tt")

        Dim baseUrl As String = TxtBaseURL.Text
        Dim tatami As String = TxtTatamiID.Text

        ' 1. Isi TextBox URL
        TxtJ1.Text = $"{baseUrl}/login.php?judge=1&tatami={tatami}"
        TxtJ2.Text = $"{baseUrl}/login.php?judge=2&tatami={tatami}"
        TxtJ3.Text = $"{baseUrl}/login.php?judge=3&tatami={tatami}"
        TxtJ4.Text = $"{baseUrl}/login.php?judge=4&tatami={tatami}"
        TxtJ5.Text = $"{baseUrl}/login.php?judge=5&tatami={tatami}"
        TxtJ6.Text = $"{baseUrl}/login.php?judge=6&tatami={tatami}"
        TxtJ7.Text = $"{baseUrl}/login.php?judge=7&tatami={tatami}"

        ' 2. Generate QR Code ke masing-masing PictureBox
        Dim qrGen As New QRCodeGenerator()

        PicJudge1.Image = New QRCode(qrGen.CreateQrCode(TxtJ1.Text, QRCodeGenerator.ECCLevel.Q)).GetGraphic(5)
        PicJudge2.Image = New QRCode(qrGen.CreateQrCode(TxtJ2.Text, QRCodeGenerator.ECCLevel.Q)).GetGraphic(5)
        PicJudge3.Image = New QRCode(qrGen.CreateQrCode(TxtJ3.Text, QRCodeGenerator.ECCLevel.Q)).GetGraphic(5)
        PicJudge4.Image = New QRCode(qrGen.CreateQrCode(TxtJ4.Text, QRCodeGenerator.ECCLevel.Q)).GetGraphic(5)
        PicJudge5.Image = New QRCode(qrGen.CreateQrCode(TxtJ5.Text, QRCodeGenerator.ECCLevel.Q)).GetGraphic(5)
        PicJudge6.Image = New QRCode(qrGen.CreateQrCode(TxtJ6.Text, QRCodeGenerator.ECCLevel.Q)).GetGraphic(5)
        PicJudge7.Image = New QRCode(qrGen.CreateQrCode(TxtJ7.Text, QRCodeGenerator.ECCLevel.Q)).GetGraphic(5)
    End Sub

    ' 3. Fungsi Copy masing-masing tombol
    Private Sub BtnCopy1_Click(sender As Object, e As EventArgs) Handles BtnCopy1.Click
        CopyText(TxtJ1.Text, 1)
    End Sub
    Private Sub BtnCopy2_Click(sender As Object, e As EventArgs) Handles BtnCopy2.Click
        CopyText(TxtJ2.Text, 2)
    End Sub
    Private Sub BtnCopy3_Click(sender As Object, e As EventArgs) Handles BtnCopy3.Click
        CopyText(TxtJ3.Text, 3)
    End Sub
    Private Sub BtnCopy4_Click(sender As Object, e As EventArgs) Handles BtnCopy4.Click
        CopyText(TxtJ4.Text, 4)
    End Sub
    Private Sub BtnCopy5_Click(sender As Object, e As EventArgs) Handles BtnCopy5.Click
        CopyText(TxtJ5.Text, 5)
    End Sub
    Private Sub BtnCopy6_Click(sender As Object, e As EventArgs) Handles BtnCopy6.Click
        CopyText(TxtJ6.Text, 6)
    End Sub
    Private Sub BtnCopy7_Click(sender As Object, e As EventArgs) Handles BtnCopy7.Click
        CopyText(TxtJ7.Text, 7)
    End Sub

    ' Sub-routine untuk proses copy
    Private Sub CopyText(textToCopy As String, judgeNum As Integer)
        If Not String.IsNullOrEmpty(textToCopy) Then
            Clipboard.SetText(textToCopy)
            MessageBox.Show($"URL J{judgeNum} berhasil disalin ke clipboard!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnSavePdf_Click(sender As Object, e As EventArgs) Handles BtnSavePdf.Click
        MessageBox.Show("Save to PDF not implemented yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class