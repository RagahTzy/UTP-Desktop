Imports System.Text
Imports System.IO
Imports System.Net.Http ' Menggunakan library HTTP modern

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

        ' 1. Isi TextBox URL (Menggunakan bantuan Logika Function "BikinTokenJuri")
        TxtJ1.Text = BikinTokenJuri(baseUrl, tatami, "J1")
        TxtJ2.Text = BikinTokenJuri(baseUrl, tatami, "J2")
        TxtJ3.Text = BikinTokenJuri(baseUrl, tatami, "J3")
        TxtJ4.Text = BikinTokenJuri(baseUrl, tatami, "J4")
        TxtJ5.Text = BikinTokenJuri(baseUrl, tatami, "J5")
        TxtJ6.Text = BikinTokenJuri(baseUrl, tatami, "J6")
        TxtJ7.Text = BikinTokenJuri(baseUrl, tatami, "J7")

        ' 2. Generate QR Code ke masing-masing PictureBox menggunakan API Google (Bebas Eror Library)
        PicJudge1.Image = AmbilGambarQR(TxtJ1.Text)
        PicJudge2.Image = AmbilGambarQR(TxtJ2.Text)
        PicJudge3.Image = AmbilGambarQR(TxtJ3.Text)
        PicJudge4.Image = AmbilGambarQR(TxtJ4.Text)
        PicJudge5.Image = AmbilGambarQR(TxtJ5.Text)
        PicJudge6.Image = AmbilGambarQR(TxtJ6.Text)
        PicJudge7.Image = AmbilGambarQR(TxtJ7.Text)
    End Sub

    ''' <summary>
    ''' LOGIKA FUNCTION UTAMA: Menggabungkan data Tatami + Juri, Enkripsi ke Base64, dan membentuk URL Final
    ''' </summary>
    Private Function BikinTokenJuri(ByVal baseUrl As String, ByVal tatamiId As String, ByVal nomorJuri As String) As String
        Try
            ' A. Format data mentah asli sebelum di-encode (Contoh: TM-0E02ABD84C23|J1)
            Dim rawData As String = $"{tatamiId}|{nomorJuri}"

            ' B. Encode string mentah tersebut ke format Base64 String
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(rawData)
            Dim base64String As String = Convert.ToBase64String(bytes)

            ' C. URL Encode agar aman dibaca browser (Mengubah tanda '=' menjadi '%3D')
            Dim secureToken As String = Uri.EscapeDataString(base64String)

            ' D. Kembalikan URL utuh terenkripsi untuk diisikan ke TextBox juri
            Return $"{baseUrl}/login.php?id={secureToken}"
        Catch ex As Exception
            Return ""
        End Try
    End Function

    ''' <summary>
    ''' LOGIKA FUNCTION PENDUKUNG: Mengambil gambar QR Code menggunakan HttpClient (Bebas Obsolete Warning)
    ''' </summary>
    Private Function AmbilGambarQR(ByVal textData As String) As Image
        Try
            Dim apiUrl As String = "https://chart.googleapis.com/chart?chs=200x200&cht=qr&chl=" & Uri.EscapeDataString(textData)

            ' Menggunakan HttpClient sesuai saran dari kompiler .NET
            Using client As New HttpClient()
                ' Mengunduh data gambar dalam bentuk Bytes secara sinkron
                Dim imageBytes As Byte() = client.GetByteArrayAsync(apiUrl).GetAwaiter().GetResult()
                Using ms As New MemoryStream(imageBytes)
                    Return Image.FromStream(ms)
                End Using
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ' 3. Fungsi Copy masing-masing tombol (Sama persis seperti bawaanmu)
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