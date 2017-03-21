Option Explicit On
Option Strict On

Public Class NotaFiscalVendaBC

    Private Shared notaFiscalVendaDAO As New NotaFiscalVendaDAO

    Public Shared Function Validate(notaFiscalVenda As NotaFiscalVenda) As Boolean

        If (notaFiscalVenda Is Nothing) Then Return False
        If (notaFiscalVenda.DataAprovacao = Nothing) Then Return False
        If (notaFiscalVenda.DataAprovacao > Now) Then Return False

        If (StatusVenda.GetStatusList.Contains(notaFiscalVenda.Status) = False) Then Return False

        If (notaFiscalVenda.EmissaoNF = Nothing) Then Return False
        If (notaFiscalVenda.EmissaoNF > Now) Then Return False

        If (String.IsNullOrWhiteSpace(notaFiscalVenda.NumeroNF)) Then Return False

        If (OrcamentoBC.Validate(notaFiscalVenda.Orcamento) = False) Then Return False

        If (notaFiscalVenda.ItensVendidos Is Nothing) Then Return False

        For Each item As ItemVendido In notaFiscalVenda.ItensVendidos
            If (ItemVendidoBC.Validate(item) = False) Then Return False
        Next

        If (notaFiscalVenda.PagamentosRecebidos IsNot Nothing) Then
            For Each item As PagamentoRecebido In notaFiscalVenda.PagamentosRecebidos
                If (PagamentoRecebidoBC.Validate(item) = False) Then Return False
            Next
        End If

        If (notaFiscalVenda.VisitasTecnicas IsNot Nothing) Then
            For Each item As VisitaTecnica In notaFiscalVenda.VisitasTecnicas
                If (VisitaTecnicaBC.Validate(item) = False) Then Return False
            Next
        End If


        Return True
    End Function

    Public Shared Function Insert(notaFiscalVenda As NotaFiscalVenda) As Long
        If (NotaFiscalVendaBC.Validate(notaFiscalVenda)) Then
            Return notaFiscalVendaDAO.Insert(notaFiscalVenda)
        End If
        Return 0
    End Function

    Public Shared Function UpdateStatus(notaFiscalVenda As NotaFiscalVenda) As Boolean
        If (NotaFiscalVendaBC.Validate(notaFiscalVenda)) Then
            Return notaFiscalVendaDAO.UpdateStatus(notaFiscalVenda)
        End If
        Return False
    End Function

    Public Shared Function Update(notaFiscalVenda As NotaFiscalVenda) As Boolean
        If (NotaFiscalVendaBC.Validate(notaFiscalVenda)) Then
            Return notaFiscalVendaDAO.Update(notaFiscalVenda)
        End If
        Return False
    End Function

    Public Shared Function FindByID(id As Long) As NotaFiscalVenda
        Return notaFiscalVendaDAO.FindByID(id)
    End Function

    Public Shared Function FindAll() As List(Of NotaFiscalVenda)
        Return notaFiscalVendaDAO.FindAll()
    End Function

    Public Shared Function FindByVendedor(status As String) As List(Of NotaFiscalVenda)
        Return notaFiscalVendaDAO.FindByStatus(status)
    End Function

End Class