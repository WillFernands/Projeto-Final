Option Explicit On
Option Strict On

Public Class EnderecoClienteBC

    Private Shared enderecoClienteDAO As New EnderecoClienteDAO

    Public Shared Function Validate(enderecoCliente As EnderecoCliente) As Boolean
        If (enderecoCliente Is Nothing) Then Return False
        If (enderecoCliente.Cliente Is Nothing) Then Return False

        If (String.IsNullOrWhiteSpace(enderecoCliente.Logradouro)) Then Return False
        If (String.IsNullOrWhiteSpace(enderecoCliente.Numero)) Then Return False
        If (String.IsNullOrWhiteSpace(enderecoCliente.Cidade)) Then Return False
        If (String.IsNullOrWhiteSpace(enderecoCliente.Estado)) Then Return False
        If (String.IsNullOrWhiteSpace(enderecoCliente.Cep)) Then Return False
        If (TipoImovel.GetTiposList.Contains(enderecoCliente.Tipo) = False) Then Return False
        Return True
    End Function

    Public Shared Function Insert(enderecoCliente As EnderecoCliente) As Long
        If (EnderecoClienteBC.Validate(enderecoCliente)) Then
            Return enderecoClienteDAO.Insert(enderecoCliente)
        End If
        Return 0
    End Function

    Public Shared Function Update(enderecoCliente As EnderecoCliente) As Boolean
        If (EnderecoClienteBC.Validate(enderecoCliente)) Then
            Return enderecoClienteDAO.Update(enderecoCliente)
        End If
        Return False
    End Function

    Public Shared Function FindByCliente(cliente As Cliente) As List(Of EnderecoCliente)
        Return enderecoClienteDAO.FindByCliente(cliente)
    End Function

    Public Shared Function Delete(enderecoCliente As EnderecoCliente) As Boolean
        If (EnderecoClienteBC.Validate(enderecoCliente)) Then
            Return enderecoClienteDAO.Delete(enderecoCliente)
        End If
        Return False
    End Function

End Class