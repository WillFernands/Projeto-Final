Option Explicit On
Option Strict On

Public Class ClientePJBC

    Private Shared clientePJDAO As New ClientePJDAO

    Public Shared Function Validate(clientePJ As ClientePJ) As Boolean
        If (clientePJ Is Nothing) Then Return False
        If (String.IsNullOrWhiteSpace(clientePJ.CNPJ)) Then Return False
        If (String.IsNullOrWhiteSpace(clientePJ.RazaoSocial)) Then Return False
        If (ClienteBC.Validate(clientePJ) = False) Then Return False

        Return True
    End Function

    Public Shared Function Insert(clientePJ As ClientePJ) As Boolean
        If (ClientePJBC.Validate(clientePJ)) Then
            Return clientePJDAO.Insert(clientePJ)
        End If
        Return False
    End Function

    Public Shared Function Update(clientePJ As ClientePJ) As Boolean
        If (ClientePJBC.Validate(clientePJ)) Then
            Return clientePJDAO.Update(clientePJ)
        End If
        Return False
    End Function

    Public Shared Function FindAll() As List(Of ClientePJ)
        Return clientePJDAO.FindAll()
    End Function

    Public Shared Function FindByID(id As Long) As ClientePJ
        Return clientePJDAO.FindByID(id)
    End Function

    Public Shared Function FindByCNPJ(cnpj As String) As ClientePJ
        Return clientePJDAO.FindByCNPJ(cnpj)
    End Function

    Public Shared Function FindByNome(nome As String) As ClientePJ
        Return clientePJDAO.FindByNome(nome)
    End Function

    Public Shared Function FindByRazaoSocial(razao As String) As ClientePJ
        Return clientePJDAO.FindByRazaoSocial(razao)
    End Function

End Class