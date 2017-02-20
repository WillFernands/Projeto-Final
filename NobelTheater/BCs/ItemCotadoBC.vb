Option Explicit On
Option Strict On

Public Class ItemCotadoBC

    Private Shared itemCotadoDAO As ItemCotadoDAO

    Public Sub New()
        itemCotadoDAO = New ItemCotadoDAO()
    End Sub

    Public Shared Function Validate(itemCotado As ItemCotado) As Boolean
        If (itemCotado Is Nothing) Then Return False
        If (itemCotado.Cotacao Is Nothing) Then Return False
        If (itemCotado.Quantidade = 0) Then Return False
        If (ProdutoBC.Validate(itemCotado.Produto) = False) Then Return False
        Return True
    End Function

    Public Shared Function Insert(itemCotado As ItemCotado) As Boolean
        If (ItemCotadoBC.Validate(itemCotado)) Then
            Return itemCotadoDAO.Insert(itemCotado)
        End If
        Return False
    End Function

    Public Shared Function FindByCotacao(cotacao As Cotacao) As List(Of ItemCotado)
        Return itemCotadoDAO.FindByCotacao(cotacao)
    End Function

End Class