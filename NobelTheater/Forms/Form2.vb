Imports MjpegProcessor
Imports System.Windows

Public Class Form2
    Private WithEvents decoder As New MjpegDecoder

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Button1.Click
        decoder.ParseStream(New Uri("http://192.168.2.200/img/video.mjpeg"))
    End Sub

    Private Sub Decoder_FrameReady(sender As Object, e As FrameReadyEventArgs) Handles decoder.FrameReady
        PictureBox1.Image = DirectCast(e.Bitmap, Image)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class