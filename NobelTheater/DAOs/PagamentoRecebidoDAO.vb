Option Explicit On
Option Strict On

Imports System.Text

Public Class PagamentoRecebidoDAO

    'OK
    Public Function Insert(ByVal pagamento As PagamentoRecebido) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO PagamentosRecebidos(idNotaFiscal, dataPagamento, valor, statusPagamento, tipo) ")
        strSQL.Append("VALUES(@idNotaFiscal, @data, @valor, @status, @tipo);")

        conn.AddParameter("@idNotaFiscal", pagamento.NotaFiscal.ID)
        conn.AddParameter("@data", pagamento.Data)
        conn.AddParameter("@valor", pagamento.Valor)
        conn.AddParameter("@status", pagamento.Status)
        conn.AddParameter("@tipo", pagamento.Tipo)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function UpdateStatus(ByVal pagamento As PagamentoRecebido) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE PagamentosRecebidos ")
        strSQL.Append("SET statusPagamento = @status ")
        strSQL.Append("WHERE idNotaFiscal = @idNotaFiscal ")
        strSQL.Append("AND dataPagamento = @data ")
        strSQL.Append("AND tipo = @tipo ")
        strSQL.Append("AND valor = @valor;")

        conn.AddParameter("@idNotaFiscal", pagamento.NotaFiscal.ID)
        conn.AddParameter("@data", pagamento.Data)
        conn.AddParameter("@valor", pagamento.Valor)
        conn.AddParameter("@status", pagamento.Status)
        conn.AddParameter("@tipo", pagamento.Tipo)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindByNotaFiscal(nota As NotaFiscalVenda) As List(Of PagamentoRecebido)

        If (nota Is Nothing) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@idNotaFiscal", nota.ID)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM PagamentosRecebidos WHERE idNotaFiscal = @idNotaFiscal;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of PagamentoRecebido)

        Dim pagamentos As New List(Of PagamentoRecebido)

        For Each row As DataRow In dt.Rows
            Dim pagamento As New PagamentoRecebido()
            pagamento.Data = CDate(row.Item("dataPagamento"))
            pagamento.Valor = CDbl(row.Item("valor"))
            pagamento.Status = CStr(row.Item("statusPagamento"))
            pagamento.Tipo = CStr(row.Item("tipo"))
            pagamento.NotaFiscal = nota
            pagamentos.Add(pagamento)
        Next

        Return pagamentos

    End Function

End Class