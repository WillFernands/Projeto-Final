Option Explicit On
Option Strict On

Public Class ClientePFBC

    Private Shared clientePFDAO As New ClientePFDAO

    Public Shared Function Validate(clientePF As ClientePF) As Boolean
        If (clientePF Is Nothing) Then Return False
        If (String.IsNullOrWhiteSpace(clientePF.CPF)) Then Return False
        If (ClienteBC.Validate(clientePF) = False) Then Return False

        Return True
    End Function

    Public Shared Function Insert(clientePF As ClientePF) As Boolean
        If (ClientePFBC.Validate(clientePF)) Then
            Return clientePFDAO.Insert(clientePF)
        End If
        Return False
    End Function

    Public Shared Function Update(clientePF As ClientePF) As Boolean
        If (ClientePFBC.Validate(clientePF)) Then
            Return clientePFDAO.Update(clientePF)
        End If
        Return False
    End Function

    Public Shared Function FindAll() As List(Of ClientePF)
        Return clientePFDAO.FindAll()
    End Function

    Public Shared Function FindByID(id As Long) As ClientePF
        Return clientePFDAO.FindByID(id)
    End Function

    Public Shared Function FindByCPF(cpf As String) As ClientePF
        Return clientePFDAO.FindByCPF(cpf)
    End Function

    Public Shared Function FindByNome(nome As String) As ClientePF
        Return clientePFDAO.FindByNome(nome)
    End Function

End Class