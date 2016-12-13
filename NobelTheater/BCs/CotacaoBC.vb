Option Explicit On
Option Strict On

Public Class CotacaoBC
    Public Shared Function Validate(cotacao As Cotacao) As Boolean
        If (cotacao Is Nothing) Then Return False
        If (cotacao.DataCotacao = Nothing) Then Return False
        If (cotacao.DataCotacao > Now) Then Return False
        If (cotacao.Fornecedor Is Nothing) Then Return False
        If (FornecedorBC.Validate(cotacao.Fornecedor) = False) Then Return False
        If (cotacao.Itens Is Nothing) Then Return False
        If (cotacao.Itens.Count = 0) Then Return False
        For Each item As ItemCotado In cotacao.Itens
            If (ItemCotadoBC.Validate(item) = False) Then Return False
        Next
        If (StatusCotacao.GetStatusList.Contains(cotacao.Status) = False) Then Return False
        Return True
    End Function

    Public Shared Function Insert(cotacao As Cotacao) As Boolean
        If (CotacaoBC.Validate(cotacao)) Then
            Return CotacaoDAO.Insert(cotacao)
        End If
        Return False
    End Function

    Public Shared Function Update(cotacao As Cotacao) As Boolean
        If (CotacaoBC.Validate(cotacao)) Then
            Return CotacaoDAO.Update(cotacao)
        End If
        Return False
    End Function

    Public Shared Function Delete(cotacao As Cotacao) As Boolean
        If (CotacaoBC.Validate(cotacao)) Then
            Return CotacaoDAO.Delete(cotacao)
        End If
        Return False
    End Function
End Class