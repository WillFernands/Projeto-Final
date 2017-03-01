Option Explicit On
Option Strict On

Imports System.Text

Public Class ItemCompradoDAO

    'OK
    Public Function Insert(ByVal item As ItemComprado) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO ItensComprados(codigoProduto, idNotaFiscal, quantidade) ")
        strSQL.Append("VALUES(@codigo, @idNotaFiscal, @quantidade);")

        conn.AddParameter("@codigo", item.Produto.Codigo)
        conn.AddParameter("@idNotaFiscal", item.NotaFiscal.ID)
        conn.AddParameter("@quantidade", item.Quantidade)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindByNotaFiscal(notaFiscal As NotaFiscalCompra) As List(Of ItemComprado)

        If (notaFiscal Is Nothing) Then Return Nothing

        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM ItensComprados ")
        strSQL.Append("WHERE idNotaFiscal = @idNotaFiscal;")

        conn.AddParameter("@idNotaFiscal", notaFiscal.ID)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of ItemComprado)

        Dim produtoDAO As New ProdutoDAO()
        Dim notaFiscalCompraDAO As New NotaFiscalCompraDAO()

        Dim itens As New List(Of ItemComprado)

        For Each row As DataRow In dt.Rows
            Dim item As New ItemComprado()
            item.Produto = produtoDAO.FindByCodigo(CLng(row.Item("codigoProduto")))
            item.NotaFiscal = notaFiscalCompraDAO.FindByID(CLng(row.Item("idNotaFiscal")))
            item.Quantidade = CInt(row.Item("quantidade"))
            itens.Add(item)
        Next

        Return itens

    End Function

End Class

