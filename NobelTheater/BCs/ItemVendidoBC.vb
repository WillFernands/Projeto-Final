Option Explicit On
Option Strict On

Public Class ItemVendidoBC

    Private Shared itemVendidoDAO As New ItemVendidoDAO

    Public Shared Function Validate(itemVendido As ItemVendido) As Boolean
        If (itemVendido Is Nothing) Then Return False
        If (itemVendido.NotaFiscal Is Nothing) Then Return False
        If (itemVendido.Quantidade = 0) Then Return False
        If (ProdutoBC.Validate(itemVendido.Produto) = False) Then Return False
        Return True
    End Function

    Public Shared Function Insert(itemVendido As ItemVendido) As Boolean
        If (ItemVendidoBC.Validate(itemVendido)) Then
            Return itemVendidoDAO.Insert(itemVendido)
        End If
        Return False
    End Function

    Public Shared Function FindByNotaFiscal(notaFiscal As NotaFiscalVenda) As List(Of ItemVendido)
        Return itemVendidoDAO.FindByNotaFiscal(notaFiscal)
    End Function

End Class