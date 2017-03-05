Option Explicit On
Option Strict On

Public Class CotacaoBC

    Private Shared cotacaoDAO As New CotacaoDAO


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

    Public Shared Function Insert(cotacao As Cotacao) As Long
        If (CotacaoBC.Validate(cotacao)) Then
            Return cotacaoDAO.Insert(cotacao)
        End If
        Return 0
    End Function

    Public Shared Function UpdateStatus(cotacao As Cotacao) As Boolean
        If (CotacaoBC.Validate(cotacao)) Then
            Return cotacaoDAO.UpdateStatus(cotacao)
        End If
        Return False
    End Function

    Public Shared Function FindAll() As List(Of Cotacao)
        Return CotacaoDAO.FindAll()
    End Function

    Public Shared Function FindByID(id As Long) As Cotacao
        Return cotacaoDAO.FindByID(id)
    End Function

    Public Shared Function FindByData(data As Date) As List(Of Cotacao)
        Return cotacaoDAO.FindByData(data)
    End Function

    Public Shared Function FindByStatus(status As String) As List(Of Cotacao)
        Return cotacaoDAO.FindByStatus(status)
    End Function

End Class