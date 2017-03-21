Option Explicit On
Option Strict On

Public Class PagamentoRecebidoBC

    Private Shared pagamentoRecebidoDAO As New PagamentoRecebidoDAO

    Public Shared Function Validate(pagamentoRecebido As PagamentoRecebido) As Boolean
        If (pagamentoRecebido Is Nothing) Then Return False
        If (pagamentoRecebido.NotaFiscal Is Nothing) Then Return False
        If (pagamentoRecebido.Data = Nothing) Then Return False
        If (pagamentoRecebido.Data > Now) Then Return False
        If (pagamentoRecebido.Valor = 0.0) Then Return False
        If (TipoPagamento.GetTiposList.Contains(pagamentoRecebido.Tipo) = False) Then Return False
        If (StatusPagamento.GetStatusList.Contains(pagamentoRecebido.Status) = False) Then Return False
        Return True
    End Function

    Public Shared Function Insert(pagamentoRecebido As PagamentoRecebido) As Boolean
        If (PagamentoRecebidoBC.Validate(pagamentoRecebido)) Then
            Return pagamentoRecebidoDAO.Insert(pagamentoRecebido)
        End If
        Return False
    End Function

    Public Shared Function UpdateStatus(pagamentoRecebido As PagamentoRecebido) As Boolean
        If (PagamentoRecebidoBC.Validate(pagamentoRecebido)) Then
            Return pagamentoRecebidoDAO.UpdateStatus(pagamentoRecebido)
        End If
        Return False
    End Function

    Public Shared Function FindByNotaFiscal(notaFiscal As NotaFiscalVenda) As List(Of PagamentoRecebido)
        Return pagamentoRecebidoDAO.FindByNotaFiscal(notaFiscal)
    End Function

    Public Shared Function DeleteByVenda(notaFiscal As NotaFiscalVenda) As Boolean
        Return pagamentoRecebidoDAO.DeleteByVenda(notaFiscal)
    End Function

End Class