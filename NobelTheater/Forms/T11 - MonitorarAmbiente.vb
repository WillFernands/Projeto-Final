Imports MjpegProcessor
Imports System.Windows

Public Class MonitorarAmbiente
    Private WithEvents decoder As New MjpegDecoder

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles IniciarStreamingBT.Click
        decoder.ParseStream(New Uri("http://192.168.2.200/img/video.mjpeg"))
    End Sub

    Private Sub Decoder_FrameReady(sender As Object, e As FrameReadyEventArgs) Handles decoder.FrameReady
        VideoPB.Image = DirectCast(e.Bitmap, Image)
    End Sub

  
End Class