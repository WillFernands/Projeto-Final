Option Explicit On
Option Strict On

Public Class PagamentoEfetuadoBC

    Private Shared pagamentoEfetuadoDAO As New PagamentoEfetuadoDAO

    Public Shared Function Validate(pagamentoEfetuado As PagamentoEfetuado) As Boolean
        If (pagamentoEfetuado Is Nothing) Then Return False
        If (pagamentoEfetuado.NotaFiscal Is Nothing) Then Return False
        If (pagamentoEfetuado.Data = Nothing) Then Return False
        If (pagamentoEfetuado.Data > Now) Then Return False
        If (pagamentoEfetuado.Valor = 0.0) Then Return False
        If (TipoPagamento.GetTiposList.Contains(pagamentoEfetuado.Tipo) = False) Then Return False
        If (StatusPagamento.GetStatusList.Contains(pagamentoEfetuado.Status) = False) Then Return False
        Return True
    End Function

    Public Shared Function Insert(pagamentoEfetuado As PagamentoEfetuado) As Boolean
        If (PagamentoEfetuadoBC.Validate(pagamentoEfetuado)) Then
            Return pagamentoEfetuadoDAO.Insert(pagamentoEfetuado)
        End If
        Return False
    End Function

    Public Shared Function UpdateStatus(pagamentoEfetuado As PagamentoEfetuado) As Boolean
        If (PagamentoEfetuadoBC.Validate(pagamentoEfetuado)) Then
            Return pagamentoEfetuadoDAO.UpdateStatus(pagamentoEfetuado)
        End If
        Return False
    End Function

    Public Shared Function FindByNotaFiscal(notaFiscal As NotaFiscalCompra) As List(Of PagamentoEfetuado)
        Return pagamentoEfetuadoDAO.FindByNotaFiscal(notaFiscal)
    End Function

    Public Shared Function DeleteByCompra(notaFiscal As NotaFiscalCompra) As Boolean
        Return pagamentoEfetuadoDAO.DeleteByCompra(notaFiscal)
    End Function

End Class