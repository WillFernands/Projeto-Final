Option Explicit On
Option Strict On

Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Globalization

Public Module GenericUtils

    Private Declare Function GetWindowThreadProcessId Lib "user32.dll" (ByVal hWnd As IntPtr, ByRef lpdwProcessId As Integer) As Integer
    Private Declare Function FindWindow Lib "user32.dll" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    Public Declare Function GetForegroundWindow Lib "user32.dll" () As IntPtr

    ''' <summary>
    ''' Open a Windows Explorer window (Path must be a folder)
    ''' </summary>
    Public Sub OpenWindowExplorer(ByVal path As String)
        Directory.CreateDirectory(path)
        Process.Start("explorer.exe", path)
    End Sub

    ''' <summary>
    ''' Kill ANY processes associated with the name plus the ones that matches the name
    ''' </summary>
    Public Sub KillProcess(ByVal processName As String)
        Dim processes = Array.FindAll(Process.GetProcesses(), Function(proc As Process) proc.ProcessName = processName)
        Array.ForEach(processes, Sub(proc As Process) proc.Kill())
    End Sub

    ''' <summary>
    ''' Check if a App is currently running
    ''' </summary>
    Public Function IsOpen(ByVal app As String) As Boolean
        For Each proc As Process In Process.GetProcesses()
            If (proc.MainWindowTitle.Contains(app)) Then Return True
        Next
        Return False
    End Function

    ''' <summary>
    ''' Returns the current user logged in the machine
    ''' </summary>
    Public Function GetUser() As String
        Return Environment.UserName
    End Function

    ''' <summary>
    ''' Returns the current String
    ''' </summary>
    Public Function GetCurrentString(ByVal str As String) As String
        Return Decimal.Parse(str).ToString("c", New CultureInfo("pt-BR"))
    End Function


    ''' <summary>
    ''' Set the String to a 11/14 sized String adding trailing zeros
    ''' </summary>
    Public Function AddZeros(str As String, type As String) As String
        str = CleanString(str)
        Dim length As Integer = 0
        Select Case type
            Case "CPF" : length = 11
            Case "CNPJ" : length = 14
            Case Else : Return str
        End Select

        Do While Len(str) < length : str = "0" + str : Loop

        Return str
    End Function

    ''' <summary>
    ''' Remove Trailing Zeros
    ''' </summary>
    Public Function RemoveZeros(ByVal str As String) As String
        str = CleanString(str)
        Do While Left(str, 1) = "0" : str = Mid(str, 2) : Loop
        Return str
    End Function

    ''' <summary>
    ''' Compare Two Strings (Ignoring Case) and return True / False if equals or not
    ''' </summary>
    Public Function StrCompIgCase(ByVal str1 As String, ByVal str2 As String) As Boolean
        If (String.Compare(str1, str2, StringComparison.OrdinalIgnoreCase) = 0) Then Return True
        Return False
    End Function

    ''' <summary>
    ''' Removes punctuation of the String
    ''' </summary>
    Public Function CleanString(str As String) As String
        If (String.IsNullOrWhiteSpace(str)) Then Return ""
        Return Regex.Replace(str, "[^\w]", "")
    End Function

    ''' <summary>
    ''' Validate a CPF Using Regex
    ''' </summary>
    Public Function ValidadorCPF(ByVal cpf As String) As Boolean
        Dim i As Integer = 0
        Dim n1 As Double = 0.0
        Dim n2 As Double = 0.0

        cpf = AddZeros(cpf, "CPF")

        For cont As Integer = 0 To 1
            For i = 0 To 8 + cont : n1 += Val(cpf.Substring(i, 1)) * (10 + cont - i) : Next
            n2 = 11 - (n1 - (Int(n1 / 11) * 11))
            If (n2 = 10 OrElse n2 = 11) Then n2 = 0
            If (n2 <> Val(cpf.Substring(9 + cont, 1))) Then Return False
        Next
        Return True
    End Function

    ''' <summary>
    ''' Validate a CNPJ Using Regex
    ''' </summary>
    Public Function ValidadorCNPJ(ByVal cnpj As String) As Boolean
        cnpj = AddZeros(cnpj, "CNPJ")
        Dim a As Double = 0
        Dim j As Double = 5
        Dim d1 As Double = 0
        Dim d2 As Double = 0
        Dim i As Integer = 0

        For i = 1 To 12
            a += (Val(Mid(cnpj, i, 1)) * j)
            j = Convert.ToDouble(IIf(j > 2, j - 1, 9))
        Next

        a = a Mod 11
        d1 = Convert.ToDouble(IIf(a > 1, 11 - a, 0))
        a = 0
        i = 0
        j = 6

        For i = 1 To 13
            a += Val(Mid(cnpj, i, 1)) * j
            j = Convert.ToDouble(IIf(j > 2, j - 1, 9))
        Next

        a = a Mod 11
        d2 = Convert.ToDouble(IIf(a > 1, 11 - a, 0))
        If (d1 = Val(Mid(cnpj, 13, 1)) AndAlso d2 = Val(Mid(cnpj, 14, 1))) Then Return True

        Return False
    End Function

    ''' <summary>
    ''' Delete all controls of the type informed
    ''' </summary>
    Public Sub ClearControls(ByRef form As Form, ByVal controlType As String)
        For Each control As Control In form.Controls.Cast(Of Control).Where(Function(ctrl) ctrl.GetType.Name = controlType)
            form.Controls.Remove(control)
        Next
    End Sub

    ''' <summary>
    ''' Converts a Hexadecimal to Integer
    ''' </summary>
    Public Function HexToInt(ByVal hex As String) As Integer
        Return Convert.ToInt32(hex, 16)
    End Function

    ''' <summary>
    ''' Kill the process that matches the PID of the name given
    ''' </summary>
    Public Sub CloseExternalApp(ByVal name As String)
        Try : Process.GetProcessById(GetProcessID(FindWindow(Nothing, name))).Kill()
        Catch ex As Exception
        End Try
    End Sub

    ''' <summary>
    ''' Focus at the main window of the process that matches the PID of the name given
    ''' </summary>
    Public Sub FocusExternalApp(ByVal name As String)
        Try : AppActivate(GetProcessID(FindWindow(Nothing, name))) : Catch ex As Exception : End Try
    End Sub
    Public Sub FocusExternalApp(ByVal iHandle As IntPtr)
        Try : AppActivate(GetProcessID(iHandle)) : Catch ex As Exception : End Try
    End Sub

    ''' <summary>
    ''' Get a process ID (PID) using a Pointer of an application
    ''' </summary>
    Public Function GetProcessID(ByVal ihandle As IntPtr) As Integer
        Try
            Dim processID As Integer
            GetWindowThreadProcessId(ihandle, processID)
            Return processID
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function FindMatches(ByVal mensagem As String, ByVal pattern As String) As List(Of String)
        Dim matches As MatchCollection = Regex.Matches(mensagem, pattern, RegexOptions.IgnoreCase)
        Dim matchesStrings As New List(Of String)
        For Each Match As Match In matches : matchesStrings.Add(Match.Value) : Next
        Return matchesStrings
    End Function

    Public Sub UpdateAppAndNotifyUser()
        Try
            If (My.Application.Deployment.CheckForUpdate = True) Then
                MsgBox("Aplicativo Pendente de Atualização. Aplicativo será encerrado para atualização", vbInformation Or vbMsgBoxSetForeground)
                My.Application.Deployment.Update()
                'FormMain.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function GenerateSenha() As String
        Dim gen As New Random
        Dim pass As String = ""
        pass += Chr(gen.Next(65, 90))
        For cont = 1 To 3 : pass += Chr(gen.Next(97, 122)) : Next
        For cont = 1 To 4 : pass += gen.Next(0, 9).ToString() : Next
        Return pass
    End Function

    Public Function ConvertImage(ByVal img As Image) As Byte()

        Dim stream As New MemoryStream
        img.Save(stream, Imaging.ImageFormat.Jpeg)

        Dim myBytes(CInt(stream.Length - 1)) As Byte
        stream.Position = 0

        stream.Read(myBytes, 0, CInt(stream.Length))

        Return myBytes

    End Function

End Module