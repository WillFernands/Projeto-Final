Option Explicit On
Option Strict On

Public Class FornecedorBC

    Private Shared FornecedorDAO As New FornecedorDAO

    Public Shared Function Validate(fornecedor As Fornecedor) As Boolean
        If (fornecedor Is Nothing) Then Return False
        If (fornecedor.InicioRelacionamento = Nothing) Then Return False
        If (fornecedor.InicioRelacionamento > Now) Then Return False
        If (String.IsNullOrWhiteSpace(fornecedor.Cnpj)) Then Return False
        If (String.IsNullOrWhiteSpace(fornecedor.RazaoSocial)) Then Return False
        If (String.IsNullOrWhiteSpace(fornecedor.NomeFantasia)) Then Return False
        If (String.IsNullOrWhiteSpace(fornecedor.Telefone)) Then Return False
        If (String.IsNullOrWhiteSpace(fornecedor.Logradouro)) Then Return False
        If (String.IsNullOrWhiteSpace(fornecedor.Numero)) Then Return False
        If (String.IsNullOrWhiteSpace(fornecedor.Cidade)) Then Return False
        If (String.IsNullOrWhiteSpace(fornecedor.Estado)) Then Return False
        If (String.IsNullOrWhiteSpace(fornecedor.Cep)) Then Return False
        If (TipoImovel.GetTiposList.Contains(fornecedor.TipoEndereco) = False) Then Return False
        If (TipoFornecedor.GetTiposList.Contains(fornecedor.TipoFornecedor) = False) Then Return False
        If (FornecedorBC.ValidateAssistencia(fornecedor.Assistencia) = False) Then Return False
        Return True
    End Function

    Public Shared Function ValidateAssistencia(fornecedor As Fornecedor) As Boolean
        If (fornecedor Is Nothing) Then Return False
        If (fornecedor.InicioRelacionamento = Nothing) Then Return False
        If (fornecedor.InicioRelacionamento > Now) Then Return False
        If (String.IsNullOrWhiteSpace(fornecedor.Cnpj)) Then Return False
        If (String.IsNullOrWhiteSpace(fornecedor.RazaoSocial)) Then Return False
        If (String.IsNullOrWhiteSpace(fornecedor.NomeFantasia)) Then Return False
        If (String.IsNullOrWhiteSpace(fornecedor.Telefone)) Then Return False
        If (String.IsNullOrWhiteSpace(fornecedor.Logradouro)) Then Return False
        If (String.IsNullOrWhiteSpace(fornecedor.Numero)) Then Return False
        If (String.IsNullOrWhiteSpace(fornecedor.Cidade)) Then Return False
        If (String.IsNullOrWhiteSpace(fornecedor.Estado)) Then Return False
        If (String.IsNullOrWhiteSpace(fornecedor.Cep)) Then Return False
        If (TipoImovel.GetTiposList.Contains(fornecedor.TipoEndereco) = False) Then Return False
        If (TipoFornecedor.GetTiposList.Contains(fornecedor.TipoFornecedor) = False) Then Return False
        Return True
    End Function

    Public Shared Function Insert(Fornecedor As Fornecedor) As Boolean
        If (FornecedorBC.Validate(Fornecedor)) Then
            Return FornecedorDAO.Insert(Fornecedor)
        End If
        Return False
    End Function

    Public Shared Function Update(Fornecedor As Fornecedor) As Boolean
        If (FornecedorBC.Validate(Fornecedor)) Then
            Return FornecedorDAO.Update(Fornecedor)
        End If
        Return False
    End Function

    Public Shared Function UpdateAssistencia(Fornecedor As Fornecedor) As Boolean
        If (FornecedorBC.Validate(Fornecedor)) Then
            Return FornecedorDAO.UpdateAssistencia(Fornecedor)
        End If
        Return False
    End Function

    Public Shared Function FindByCNPJ(cnpj As String) As Fornecedor
        Return FornecedorDAO.FindByCNPJ(cnpj)
    End Function

    Public Shared Function FindAll() As List(Of Fornecedor)
        Return FornecedorDAO.FindAll()
    End Function

    Public Shared Function FindByRazaoSocial(razao As String) As Fornecedor
        Return FornecedorDAO.FindByRazaoSocial(razao)
    End Function

    Public Shared Function FindByNomeFantasia(nome As String) As Fornecedor
        Return FornecedorDAO.FindByNomeFantasia(nome)
    End Function

    Public Shared Function FindAssistenciaByCNPJ(cnpj As String) As Fornecedor
        Return FornecedorDAO.FindAssistenciaByCNPJ(cnpj)
    End Function

End Class