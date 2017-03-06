Option Explicit On
Option Strict On

Public Class ItemOrdemBC

    Private Shared itemOrdemDAO As New ItemOrdemDAO

    Public Shared Function Validate(itemOrdem As ItemOrdem) As Boolean
        If (itemOrdem Is Nothing) Then Return False
        If (itemOrdem.OrdemServico Is Nothing) Then Return False
        If (itemOrdem.Quantidade = 0) Then Return False
        If (itemOrdem.DataEntrega = Nothing) Then Return False
        If (itemOrdem.DataEntrega > Now) Then Return False
        If (ProdutoBC.Validate(itemOrdem.Produto) = False) Then Return False
        Return True
    End Function

    Public Shared Function Insert(itemOrdem As ItemOrdem) As Boolean
        If (ItemOrdemBC.Validate(itemOrdem)) Then
            Return itemOrdemDAO.Insert(itemOrdem)
        End If
        Return False
    End Function

    Public Shared Function FindByOrdem(ordem As OrdemServico) As List(Of ItemOrdem)
        Return itemOrdemDAO.FindByOrdem(ordem)
    End Function

End Class