Option Explicit On
Option Strict On

Imports System.Text

Public Class NotaFiscalCompraDAO

    'OK
    Public Function Insert(ByVal notaFiscal As NotaFiscalCompra) As Long
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO NotasFiscaisCompras(statusNF, emissaoNF, numeroNF, dataAprovacao, idCotacao) ")
        strSQL.Append("VALUES(@status, @emissao, @numero, @data, @idCotacao);")

        conn.AddParameter("@status", notaFiscal.Status)
        conn.AddParameter("@emissao", notaFiscal.EmissaoNF)
        conn.AddParameter("@numero", notaFiscal.NumeroNF)
        conn.AddParameter("@data", notaFiscal.DataAprovacao)
        conn.AddParameter("@idCotacao", notaFiscal.Cotacao.ID)

        If (conn.ExecuteCommand(strSQL.ToString) = False) Then Return 0

        conn = New Connection
        Return CLng(conn.ExecuteScalar("SELECT IDENT_CURRENT('NotasFiscaisCompras')"))

    End Function

    'OK
    Public Function Update(ByVal notaFiscal As NotaFiscalCompra) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE NotasFiscaisCompras ")
        strSQL.Append("SET statusNF = @status, ")
        strSQL.Append("emissaoNF = @emissao, ")
        strSQL.Append("numeroNF = @numero ")
        strSQL.Append("WHERE id = @id;")

        conn.AddParameter("@status", notaFiscal.Status)
        conn.AddParameter("@emissao", notaFiscal.EmissaoNF)
        conn.AddParameter("@numero", notaFiscal.NumeroNF)
        conn.AddParameter("@id", notaFiscal.ID)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function UpdateStatus(ByVal notaFiscal As NotaFiscalCompra) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE NotasFiscaisCompras ")
        strSQL.Append("SET statusNF = @status ")
        strSQL.Append("WHERE id = @id;")

        conn.AddParameter("@status", notaFiscal.Status)
        conn.AddParameter("@id", notaFiscal.ID)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindAll() As List(Of NotaFiscalCompra)
        Dim conn As New Connection
        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM NotasFiscaisCompras;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of NotaFiscalCompra)

        Dim notasFiscais As New List(Of NotaFiscalCompra)

        For Each row As DataRow In dt.Rows
            Dim notaFiscal As New NotaFiscalCompra()
            notaFiscal.ID = CLng(row.Item("id"))
            notaFiscal.DataAprovacao = CDate(row.Item("dataAprovacao"))
            notaFiscal.Status = CStr(row.Item("statusNF"))
            notaFiscal.EmissaoNF = CDate(row.Item("emissaoNF"))
            notaFiscal.NumeroNF = CStr(row.Item("numeroNF"))
            notaFiscal.Cotacao = CotacaoBC.FindByID(CLng(row.Item("idCotacao")))
            notaFiscal.Pagamentos = PagamentoEfetuadoBC.FindByNotaFiscal(notaFiscal)
            notaFiscal.Itens = ItemCompradoBC.FindByNotaFiscal(notaFiscal)
            notasFiscais.Add(notaFiscal)
        Next

        Return notasFiscais

    End Function

    'OK
    Public Function FindByStatus(status As String) As List(Of NotaFiscalCompra)

        If (String.IsNullOrWhiteSpace(status)) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@status", status)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM NotasFiscaisCompras WHERE statusNF = @status;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of NotaFiscalCompra)

        Dim notasFiscais As New List(Of NotaFiscalCompra)

        For Each row As DataRow In dt.Rows
            Dim notaFiscal As New NotaFiscalCompra()
            notaFiscal.ID = CLng(row.Item("id"))
            notaFiscal.DataAprovacao = CDate(row.Item("dataAprovacao"))
            notaFiscal.Status = CStr(row.Item("statusNF"))
            notaFiscal.EmissaoNF = CDate(row.Item("emissaoNF"))
            notaFiscal.NumeroNF = CStr(row.Item("numeroNF"))
            notaFiscal.Cotacao = CotacaoBC.FindByID(CLng(row.Item("idCotacao")))
            notaFiscal.Pagamentos = PagamentoEfetuadoBC.FindByNotaFiscal(notaFiscal)
            notaFiscal.Itens = ItemCompradoBC.FindByNotaFiscal(notaFiscal)
            notasFiscais.Add(notaFiscal)
        Next

        Return notasFiscais

    End Function

    'OK
    Public Function FindByID(id As Long) As NotaFiscalCompra

        If (id = 0) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@id", id)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM NotasFiscaisCompras WHERE id = @id;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return Nothing

        Dim notaFiscal As New NotaFiscalCompra()
        notaFiscal.ID = CLng(dt.Rows(0).Item("id"))
        notaFiscal.DataAprovacao = CDate(dt.Rows(0).Item("dataAprovacao"))
        notaFiscal.Status = CStr(dt.Rows(0).Item("statusNF"))
        notaFiscal.EmissaoNF = CDate(dt.Rows(0).Item("emissaoNF"))
        notaFiscal.NumeroNF = CStr(dt.Rows(0).Item("numeroNF"))
        notaFiscal.Cotacao = CotacaoBC.FindByID(CLng(dt.Rows(0).Item("idCotacao")))
        notaFiscal.Pagamentos = PagamentoEfetuadoBC.FindByNotaFiscal(notaFiscal)
        notaFiscal.Itens = ItemCompradoBC.FindByNotaFiscal(notaFiscal)

        Return notaFiscal

    End Function

End Class

