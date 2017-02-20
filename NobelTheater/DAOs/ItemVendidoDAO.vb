Option Explicit On
Option Strict On

Imports System.Text

Public Class ItemVendidoDAO

    'OK
    Public Function Insert(ByVal item As ItemVendido) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO ItensVendidos(codigoProduto, idNotaFiscal, quantidade) ")
        strSQL.Append("VALUES(@codigo, @idNotaFiscal, @quantidade);")

        conn.AddParameter("@codigo", item.Produto.Codigo)
        conn.AddParameter("@idNotaFiscal", item.NotaFiscal.ID)
        conn.AddParameter("@quantidade", item.Quantidade)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindByNotaFiscal(notaFiscal As NotaFiscalVenda) As List(Of ItemVendido)
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM ItensVendidos ")
        strSQL.Append("WHERE idNotaFiscal = @idNotaFiscal;")

        conn.AddParameter("@idNotaFiscal", notaFiscal.ID)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        Dim produtoDAO As New ProdutoDAO()
        Dim notaFiscalVendaDAO As New NotaFiscalVendaDAO()

        Dim itens As New List(Of ItemVendido)

        For Each row As DataRow In dt.Rows
            Dim item As New ItemVendido()
            item.Produto = produtoDAO.FindByCodigo(CLng(row.Item("codigoProduto")))
            item.NotaFiscal = notaFiscalVendaDAO.FindByID(CLng(row.Item("idNotaFiscal")))
            item.Quantidade = CInt(row.Item("quantidade"))
            itens.Add(item)
        Next

        Return itens

    End Function

End Class

