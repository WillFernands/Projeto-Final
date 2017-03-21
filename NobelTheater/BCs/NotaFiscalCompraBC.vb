Option Explicit On
Option Strict On

Public Class NotaFiscalCompraBC

    Private Shared notaFiscalCompraDAO As New NotaFiscalCompraDAO

    Public Shared Function Validate(notaFiscalCompra As NotaFiscalCompra) As Boolean

        If (notaFiscalCompra Is Nothing) Then Return False
        If (notaFiscalCompra.DataAprovacao = Nothing) Then Return False
        If (notaFiscalCompra.DataAprovacao > Now) Then Return False

        If (StatusCompra.GetStatusList.Contains(notaFiscalCompra.Status) = False) Then Return False

        If (notaFiscalCompra.EmissaoNF = Nothing) Then Return False
        If (notaFiscalCompra.EmissaoNF > Now) Then Return False

        If (String.IsNullOrWhiteSpace(notaFiscalCompra.NumeroNF)) Then Return False

        If (CotacaoBC.Validate(notaFiscalCompra.Cotacao) = False) Then Return False

        For Each item As ItemComprado In notaFiscalCompra.Items
            If (ItemCompradoBC.Validate(item) = False) Then Return False
        Next

        For Each item As PagamentoEfetuado In notaFiscalCompra.Pagamentos
            If (PagamentoEfetuadoBC.Validate(item) = False) Then Return False
        Next

        Return True
    End Function

    Public Shared Function Insert(notaFiscalCompra As NotaFiscalCompra) As Long
        If (NotaFiscalCompraBC.Validate(notaFiscalCompra)) Then
            Return notaFiscalCompraDAO.Insert(notaFiscalCompra)
        End If
        Return 0
    End Function

    Public Shared Function UpdateStatus(notaFiscalCompra As NotaFiscalCompra) As Boolean
        If (NotaFiscalCompraBC.Validate(notaFiscalCompra)) Then
            Return notaFiscalCompraDAO.UpdateStatus(notaFiscalCompra)
        End If
        Return False
    End Function

    Public Shared Function Update(notaFiscalCompra As NotaFiscalCompra) As Boolean
        If (NotaFiscalCompraBC.Validate(notaFiscalCompra)) Then
            Return notaFiscalCompraDAO.Update(notaFiscalCompra)
        End If
        Return False
    End Function

    Public Shared Function FindByID(id As Long) As NotaFiscalCompra
        Return notaFiscalCompraDAO.FindByID(id)
    End Function

    Public Shared Function FindAll() As List(Of NotaFiscalCompra)
        Return notaFiscalCompraDAO.FindAll()
    End Function

    Public Shared Function FindByVendedor(status As String) As List(Of NotaFiscalCompra)
        Return notaFiscalCompraDAO.FindByStatus(status)
    End Function

End Class