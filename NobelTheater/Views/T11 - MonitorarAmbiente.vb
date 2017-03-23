Imports MjpegProcessor
Imports System.Windows

Public Class MonitorarAmbiente
    Private WithEvents decoder As New MjpegDecoder

    Private Sub MonitorarAmbiente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NomeTF.Text = "Nome: " & MenuPrincipal.funcionarioLogado.Nome
        MatriculaTF.Text = "Matricula: " & MenuPrincipal.funcionarioLogado.Matricula
        PerfilTF.Text = "Perfil: " & MenuPrincipal.funcionarioLogado.Perfil
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles IniciarStreamingBT.Click
        decoder.ParseStream(New Uri("http://192.168.2.200/img/video.mjpeg"))
    End Sub

    Private Sub Decoder_FrameReady(sender As Object, e As FrameReadyEventArgs) Handles decoder.FrameReady
        VideoIMG.Image = DirectCast(e.Bitmap, Image)
    End Sub

    Private Sub SalvarImagemBT_Click(sender As Object, e As EventArgs) Handles SalvarImagemBT.Click
        VideoIMG.Image.Save("C:\Users\Leonardo\Desktop\teste " & Replace(Now, "/", "-") & ".jpeg")
    End Sub

    Private Sub PararStreamingBT_Click(sender As Object, e As EventArgs) Handles PararStreamingBT.Click
        decoder.StopStream()
    End Sub
End Class