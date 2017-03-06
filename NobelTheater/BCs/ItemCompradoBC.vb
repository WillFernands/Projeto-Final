Option Explicit On
Option Strict On

Public Class ItemCompradoBC

    Private Shared itemCompradoDAO As New ItemCompradoDAO

    Public Shared Function Validate(itemComprado As ItemComprado) As Boolean
        If (itemComprado Is Nothing) Then Return False
        If (itemComprado.NotaFiscal Is Nothing) Then Return False
        If (itemComprado.Quantidade = 0) Then Return False
        If (ProdutoBC.Validate(itemComprado.Produto) = False) Then Return False
        Return True
    End Function

    Public Shared Function Insert(itemComprado As ItemComprado) As Boolean
        If (ItemCompradoBC.Validate(itemComprado)) Then
            Return itemCompradoDAO.Insert(itemComprado)
        End If
        Return False
    End Function

    Public Shared Function FindByNotaFiscal(notaFiscal As NotaFiscalCompra) As List(Of ItemComprado)
        Return itemCompradoDAO.FindByNotaFiscal(notaFiscal)
    End Function

End Class