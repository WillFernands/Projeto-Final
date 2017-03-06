Option Explicit On
Option Strict On

Public Class ClienteBC

    Private Shared clienteDAO As New ClienteDAO

    Public Shared Function Validate(cliente As Cliente) As Boolean
        If (cliente Is Nothing) Then Return False
        If (cliente.DataCadastro = Nothing) Then Return False
        If (cliente.DataCadastro > Now) Then Return False
        If (String.IsNullOrWhiteSpace(cliente.Nome)) Then Return False
        If (String.IsNullOrWhiteSpace(cliente.Telefone)) Then Return False
        For Each item As EnderecoCliente In cliente.Enderecos
            If (EnderecoClienteBC.Validate(item) = False) Then Return False
        Next
        Return True
    End Function

    Public Shared Function Insert(cliente As Cliente) As Long
        If (ClienteBC.Validate(cliente)) Then
            Return clienteDAO.Insert(cliente)
        End If
        Return 0
    End Function

    Public Shared Function Update(cliente As Cliente) As Boolean
        If (ClienteBC.Validate(cliente)) Then
            Return clienteDAO.Update(cliente)
        End If
        Return False
    End Function

    Public Shared Function FindByID(id As Long) As Cliente
        Return clienteDAO.FindByID(id)
    End Function

End Class