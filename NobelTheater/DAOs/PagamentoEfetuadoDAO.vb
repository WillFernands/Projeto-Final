Option Explicit On
Option Strict On

Imports System.Text

Public Class PagamentoEfetuadoDAO

    'OK
    Public Function Insert(ByVal pagamento As PagamentoEfetuado) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO PagamentosEfetuados(idNotaFiscal, dataPagamento, valor, statusPagamento, tipo) ")
        strSQL.Append("VALUES(@idNotaFiscal, @data, @valor, @status, @tipo);")

        conn.AddParameter("@idNotaFiscal", pagamento.NotaFiscal.ID)
        conn.AddParameter("@data", pagamento.Data)
        conn.AddParameter("@valor", pagamento.Valor)
        conn.AddParameter("@status", pagamento.Status)
        conn.AddParameter("@tipo", pagamento.Tipo)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function UpdateStatus(ByVal pagamento As PagamentoEfetuado) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE PagamentosEfetuados ")
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
    Public Function FindByNotaFiscal(nota As NotaFiscalCompra) As List(Of PagamentoEfetuado)
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM PagamentosEfetuados ")
        strSQL.Append("WHERE idNotaFiscal = @idNotaFiscal;")

        conn.AddParameter("@idNotaFiscal", nota.ID)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        Dim pagamentos As New List(Of PagamentoEfetuado)

        For Each row As DataRow In dt.Rows
            Dim pagamento As New PagamentoEfetuado()
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