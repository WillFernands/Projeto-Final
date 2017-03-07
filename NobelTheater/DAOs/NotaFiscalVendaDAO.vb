Option Explicit On
Option Strict On

Imports System.Text

Public Class NotaFiscalVendaDAO

    'OK
    Public Function Insert(ByVal notaFiscal As NotaFiscalVenda) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO NotasFiscaisVendas(statusNF, emissaoNF, numeroNF, dataAprovacao, dataFinalObra, idOrcamento) ")
        strSQL.Append("VALUES(@status, @emissao, @numero, @dataAprovacao, @dataFinalObra, @idOrcamento);")

        conn.AddParameter("@status", notaFiscal.Status)
        conn.AddParameter("@emissao", notaFiscal.EmissaoNF)
        conn.AddParameter("@numero", notaFiscal.NumeroNF)
        conn.AddParameter("@dataAprovacao", notaFiscal.DataAprovacao)
        conn.AddParameter("@dataFinalObra", notaFiscal.DataFinalObra)
        conn.AddParameter("@idOrcamento", notaFiscal.Orcamento.ID)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function UpdateStatus(ByVal notaFiscal As NotaFiscalVenda) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE NotasFiscaisVendas ")
        strSQL.Append("SET status = @status ")
        strSQL.Append("WHERE id = @id;")

        conn.AddParameter("@status", notaFiscal.Status)
        conn.AddParameter("@id", notaFiscal.ID)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindAll() As List(Of NotaFiscalVenda)
        Dim conn As New Connection
        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM NotasFiscaisVendas;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of NotaFiscalVenda)

        Dim notasFiscais As New List(Of NotaFiscalVenda)

        For Each row As DataRow In dt.Rows
            Dim notaFiscal As New NotaFiscalVenda()
            notaFiscal.ID = CLng(row.Item("id"))
            notaFiscal.DataAprovacao = CDate(row.Item("dataAprovacao"))
            notaFiscal.DataFinalObra = CDate(row.Item("dataFinalObra"))
            notaFiscal.Status = CStr(row.Item("statusNF"))
            notaFiscal.EmissaoNF = CDate(row.Item("emissaoNF"))
            notaFiscal.NumeroNF = CStr(row.Item("numeroNF"))
            notaFiscal.Orcamento = OrcamentoBC.FindByID(CLng(row.Item("idOrcamento")))
            notaFiscal.VisitasTecnicas = VisitaTecnicaBC.FindByNotaFiscal(notaFiscal)
            notaFiscal.PagamentosRecebidos = PagamentoRecebidoBC.FindByNotaFiscal(notaFiscal)
            notaFiscal.ItensVendidos = ItemVendidoBC.FindByNotaFiscal(notaFiscal)
            notasFiscais.Add(notaFiscal)
        Next

        Return notasFiscais

    End Function

    'OK
    Public Function FindByStatus(status As String) As List(Of NotaFiscalVenda)

        If (String.IsNullOrWhiteSpace(status)) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@status", status)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM NotasFiscaisVendas WHERE status = @status;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of NotaFiscalVenda)

        Dim notasFiscais As New List(Of NotaFiscalVenda)


        For Each row As DataRow In dt.Rows
            Dim notaFiscal As New NotaFiscalVenda()
            notaFiscal.Id = CLng(row.Item("id"))
            notaFiscal.DataAprovacao = CDate(row.Item("dataAprovacao"))
            notaFiscal.DataFinalObra = CDate(row.Item("dataFinalObra"))
            notaFiscal.Status = CStr(row.Item("statusNF"))
            notaFiscal.EmissaoNF = CDate(row.Item("emissaoNF"))
            notaFiscal.NumeroNF = CStr(row.Item("numeroNF"))
            notaFiscal.Orcamento = OrcamentoBC.FindByID(CLng(row.Item("idOrcamento")))
            notaFiscal.VisitasTecnicas = VisitaTecnicaBC.FindByNotaFiscal(notaFiscal)
            notaFiscal.PagamentosRecebidos = PagamentoRecebidoBC.FindByNotaFiscal(notaFiscal)
            notaFiscal.ItensVendidos = ItemVendidoBC.FindByNotaFiscal(notaFiscal)
            notasFiscais.Add(notaFiscal)
        Next

        Return notasFiscais

    End Function

    'OK
    Public Function FindByID(id As Long) As NotaFiscalVenda

        If (id = 0) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@id", id)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM NotasFiscaisVendas WHERE id = @id;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return Nothing

        Dim notasFiscais As New List(Of NotaFiscalVenda)

        Dim notaFiscal As New NotaFiscalVenda()
        notaFiscal.Id = CLng(dt.Rows(0).Item("id"))
        notaFiscal.DataAprovacao = CDate(dt.Rows(0).Item("dataAprovacao"))
        notaFiscal.DataFinalObra = CDate(dt.Rows(0).Item("dataFinalObra"))
        notaFiscal.Status = CStr(dt.Rows(0).Item("statusNF"))
        notaFiscal.EmissaoNF = CDate(dt.Rows(0).Item("emissaoNF"))
        notaFiscal.NumeroNF = CStr(dt.Rows(0).Item("numeroNF"))
        notaFiscal.Orcamento = OrcamentoBC.FindByID(CLng(dt.Rows(0).Item("idOrcamento")))
        notaFiscal.VisitasTecnicas = VisitaTecnicaBC.FindByNotaFiscal(notaFiscal)
        notaFiscal.PagamentosRecebidos = PagamentoRecebidoBC.FindByNotaFiscal(notaFiscal)
        notaFiscal.ItensVendidos = ItemVendidoBC.FindByNotaFiscal(notaFiscal)

        Return notaFiscal

    End Function

End Class

