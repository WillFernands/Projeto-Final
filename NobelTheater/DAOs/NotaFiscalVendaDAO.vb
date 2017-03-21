Option Explicit On
Option Strict On

Imports System.Text

Public Class NotaFiscalVendaDAO

    'OK
    Public Function Insert(ByVal notaFiscal As NotaFiscalVenda) As Long
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO NotasFiscaisVendas(statusNF, emissaoNF, numeroNF, dataAprovacao, idOrcamento) ")
        strSQL.Append("VALUES(@status, @emissao, @numero, @dataAprovacao, @idOrcamento);")

        conn.AddParameter("@status", notaFiscal.Status)
        conn.AddParameter("@emissao", notaFiscal.EmissaoNF)
        conn.AddParameter("@numero", notaFiscal.NumeroNF)
        conn.AddParameter("@dataAprovacao", notaFiscal.DataAprovacao)
        conn.AddParameter("@idOrcamento", notaFiscal.Orcamento.Id)

        If (conn.ExecuteCommand(strSQL.ToString) = False) Then Return 0

        conn = New Connection
        Return CLng(conn.ExecuteScalar("SELECT IDENT_CURRENT('NotasFiscaisVendas')"))

    End Function

    'OK
    Public Function Update(ByVal notaFiscal As NotaFiscalVenda) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE NotasFiscaisVendas ")
        strSQL.Append("SET statusNF = @status, ")
        strSQL.Append("emissaoNF = @emissao, ")
        strSQL.Append("numeroNF = @numero ")
        strSQL.Append("WHERE id = @id;")

        conn.AddParameter("@status", notaFiscal.Status)
        conn.AddParameter("@emissao", notaFiscal.EmissaoNF)
        conn.AddParameter("@numero", notaFiscal.NumeroNF)
        conn.AddParameter("@id", notaFiscal.Id)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function UpdateStatus(ByVal notaFiscal As NotaFiscalVenda) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE NotasFiscaisVendas ")
        strSQL.Append("SET statusNF = @status ")
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
            If (IsDBNull(row.Item("dataFinalObra"))) Then
            Else notaFiscal.DataFinalObra = Nothing
                notaFiscal.DataFinalObra = CDate(row.Item("dataFinalObra"))
            End If
            notaFiscal.Status = CStr(row.Item("statusNF"))
            notaFiscal.EmissaoNF = CDate(row.Item("emissaoNF"))
            notaFiscal.NumeroNF = CStr(row.Item("numeroNF"))
            notaFiscal.Orcamento = OrcamentoBC.FindByID(CLng(row.Item("idOrcamento")))
            notaFiscal.VisitasTecnicas = VisitaTecnicaBC.FindByNotaFiscal(notaFiscal)
            notaFiscal.PagamentosRecebidos = PagamentoRecebidoBC.FindByNotaFiscal(notaFiscal)
            notaFiscal.Itens = ItemVendidoBC.FindByNotaFiscal(notaFiscal)
            notasFiscais.Add(notaFiscal)
        Next

        Return notasFiscais

    End Function

    'OK
    Public Function FindByStatus(status As String) As List(Of NotaFiscalVenda)

        If (String.IsNullOrWhiteSpace(status)) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@status", status)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM NotasFiscaisVendas WHERE statusNF = @status;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of NotaFiscalVenda)

        Dim notasFiscais As New List(Of NotaFiscalVenda)


        For Each row As DataRow In dt.Rows
            Dim notaFiscal As New NotaFiscalVenda()
            notaFiscal.Id = CLng(row.Item("id"))
            notaFiscal.DataAprovacao = CDate(row.Item("dataAprovacao"))
            If (IsDBNull(row.Item("dataFinalObra"))) Then
            Else notaFiscal.DataFinalObra = Nothing
                notaFiscal.DataFinalObra = CDate(row.Item("dataFinalObra"))
            End If
            notaFiscal.Status = CStr(row.Item("statusNF"))
            notaFiscal.EmissaoNF = CDate(row.Item("emissaoNF"))
            notaFiscal.NumeroNF = CStr(row.Item("numeroNF"))
            notaFiscal.Orcamento = OrcamentoBC.FindByID(CLng(row.Item("idOrcamento")))
            notaFiscal.VisitasTecnicas = VisitaTecnicaBC.FindByNotaFiscal(notaFiscal)
            notaFiscal.PagamentosRecebidos = PagamentoRecebidoBC.FindByNotaFiscal(notaFiscal)
            notaFiscal.Itens = ItemVendidoBC.FindByNotaFiscal(notaFiscal)
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
        If (IsDBNull(dt.Rows(0).Item("dataFinalObra"))) Then
        Else notaFiscal.DataFinalObra = Nothing
            notaFiscal.DataFinalObra = CDate(dt.Rows(0).Item("dataFinalObra"))
        End If
        notaFiscal.Status = CStr(dt.Rows(0).Item("statusNF"))
        notaFiscal.EmissaoNF = CDate(dt.Rows(0).Item("emissaoNF"))
        notaFiscal.NumeroNF = CStr(dt.Rows(0).Item("numeroNF"))
        notaFiscal.Orcamento = OrcamentoBC.FindByID(CLng(dt.Rows(0).Item("idOrcamento")))
        notaFiscal.VisitasTecnicas = VisitaTecnicaBC.FindByNotaFiscal(notaFiscal)
        notaFiscal.PagamentosRecebidos = PagamentoRecebidoBC.FindByNotaFiscal(notaFiscal)
        notaFiscal.Itens = ItemVendidoBC.FindByNotaFiscal(notaFiscal)

        Return notaFiscal

    End Function

End Class

