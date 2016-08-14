Option Explicit On
Option Strict On

Imports System.Net
Imports System.Text
Imports System.IO

'Código para acesso de páginas WEB via Request/Response
'Utilizar apenas funções públicas via chamadas Shared -> AbstractCodesWebServer.Function(param1)
'Não excluir as variáveis de Cookies (Armazenam Autenticação)
'Para trocar a implementação para outras páginas aunteticadas mudar a implementação da função getAuthorization
'Para utilizar páginas não autenticadas chamar a função Retrieve HTML + SendPostRequest (se necessário)

Public Module WebServerUtils

    'Variáveis para armazenamento da autenticação do login
    Private CookieContainer As New CookieContainer
    Private Cookies As New CookieCollection

    'Retorna os cookies de autenticação da página (O link está fixo dentro da função)
    Public Function GetAuthorization(ByVal user As String, ByVal pass As String) As Boolean
        Dim cookieCounter As Integer = 0
        cookieCounter += Cookies.Cast(Of Cookie).Where(Function(ck) ck.Name.Contains("cookieName")).Count()
        cookieCounter += Cookies.Cast(Of Cookie).Where(Function(ck) ck.Name.Contains("cookieName")).Count()
        If (cookieCounter = 1) Then Return True ' cookieCounter = números de cookies na webPage
        Dim req As HttpWebRequest = CreateNewRequest("https://google.com")
        LogIn(req, user, pass)
        Dim response As WebResponse = req.GetResponse()
        Cookies = req.CookieContainer.GetCookies(req.RequestUri)
        CookieContainer = req.CookieContainer
        Dim html As String = RetrieveHTML("https://google.com")
        Return True
    End Function

    'Retorna um HTML (String) que não precisa de Post (Informações como Parâmetro)
    Public Function RetrieveHTML(ByVal url As String) As String
        Dim objReader As StreamReader = Nothing
        Dim req As HttpWebRequest = Nothing
        Dim resp As HttpWebResponse = Nothing
        Dim str As New StringBuilder

        Try
            req = CreateNewRequest(url)
            resp = DirectCast(req.GetResponse(), HttpWebResponse)
            objReader = New StreamReader(resp.GetResponseStream, Encoding.UTF7)

            While Not objReader.EndOfStream
                Dim line As String = objReader.ReadLine()
                line = line.Replace("vblf", "")
                line = line.Replace("  ", " ")
                line = line.Replace("   ", " ")
                line = line.Replace("&nbsp;", "")
                If (String.IsNullOrWhiteSpace(line) = False) Then str.AppendLine(Trim(line))
            End While
            If (String.IsNullOrWhiteSpace(str.ToString)) Then Throw New Exception("Resposta vazia")
        Catch ex As Exception : MsgBox(ex.Message, vbInformation Or vbMsgBoxSetForeground)
        Finally
            objReader.Close()
            resp.Close()
        End Try
        Return str.ToString
    End Function

    'Retorna um HTML (String) que precisa de Post (Post é passado como String)
    Public Function RetrieveHTML(ByVal url As String, ByVal postAction As String, Optional ByVal formatBytes As Boolean = False) As String
        Dim objReader As StreamReader = Nothing
        Dim req As HttpWebRequest = Nothing
        Dim resp As HttpWebResponse = Nothing
        Dim str As New StringBuilder

        Try
            req = CreateNewRequest(url)
            SendPostRequest(req, postAction, formatBytes)
            resp = DirectCast(req.GetResponse(), HttpWebResponse)
            objReader = New StreamReader(resp.GetResponseStream, Encoding.UTF7)

            While Not objReader.EndOfStream
                Dim line As String = objReader.ReadLine()
                line = line.Replace("vblf", "")
                line = line.Replace("  ", " ")
                line = line.Replace("   ", " ")
                line = line.Replace("&nbsp;", "")
                If (String.IsNullOrWhiteSpace(line) = False) Then str.AppendLine(Trim(line))
            End While
            If (String.IsNullOrWhiteSpace(str.ToString)) Then Throw New Exception("Resposta vazia")
        Catch ex As Exception : MsgBox(ex.Message, vbInformation Or vbMsgBoxSetForeground)
        Finally
            objReader.Close()
            resp.Close()
        End Try
        Return str.ToString
    End Function

    'Cria um objeto semi-pronto do tipo HTTPWebRequest (Principais parâmetros já setados)
    Private Function CreateNewRequest(ByVal url As String) As HttpWebRequest
        Dim request As HttpWebRequest = CType(HttpWebRequest.Create(url), HttpWebRequest)
        request.ContentType = "application/x-www-form-urlencoded"
        request.Method = "Post"
        request.Headers.Add("Accept-Language", "pt-BR")
        request.UseDefaultCredentials = True
        request.Accept = "image/jpeg, application/x-ms-application, image/gif, application/xaml+xml, image/pjpeg, application/x-ms-xbap, application/vnd.ms-excel, application/vnd.ms-powerpoint, application/msword, */*"
        request.UserAgent = ".NET Framework Example Client"
        request.CookieContainer = CookieContainer
        request.Timeout = 5000 '5 Segundos
        request.ReadWriteTimeout = 5000 '5 Segundos
        Return request
    End Function

    'Manda um post para a página e retorna a página de resposta
    Public Function SendPostRequest(ByRef request As HttpWebRequest, ByVal postAction As String, Optional ByVal formatBytes As Boolean = False) As HttpWebRequest
        Dim stream As Stream = Nothing
        Try
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postAction)
            If (formatBytes) Then byteArray = FormatByteArray(byteArray)
            request.ContentLength = byteArray.Length
            stream = request.GetRequestStream()
            stream.Write(byteArray, 0, byteArray.Length)
            Return request
        Catch ex As Exception : Return Nothing
        Finally : stream.Close()
        End Try
    End Function

    'Faz Log-In na Página (Não dá pra validar se ele fez login)
    Private Function LogIn(ByRef request As HttpWebRequest, ByVal user As String, ByVal pass As String) As HttpWebRequest
        Dim stream As Stream = Nothing

        Try
            request.Credentials.GetCredential(request.RequestUri, "Basic").Password = pass
            request.Credentials.GetCredential(request.RequestUri, "Basic").UserName = user
            request.Credentials.GetCredential(request.RequestUri, "Basic").Domain = "google.com"
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes("_filler=&usuario=" & user & "&senha=" & pass)
            request.ContentLength = byteArray.Length
            stream = request.GetRequestStream()
            stream.Write(byteArray, 0, byteArray.Length)
            Return request
        Catch ex As Exception : Return Nothing
        Finally : stream.Close()
        End Try
    End Function

    'Arruma a acentuação (Codificação não resolve esses charse transformam nos Bytes errados)
    Public Function FormatByteArray(ByVal array As Byte()) As Byte()
        Dim byteList As New List(Of Byte)
        For Each b As Byte In array
            If (b >= 128 AndAlso b <= 191) Then : byteList.Add(b + CByte(64))
            ElseIf (b = 195) Then : Continue For
            End If
        Next
        Return byteList.ToArray
    End Function

End Module
