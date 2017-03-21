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

        conn.AddParameter("@idNotaFiscal", notaFiscal.ID)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM ItensComprados WHERE idNotaFiscal = @idNotaFiscal;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of ItemComprado)

        Dim itens As New List(Of ItemComprado)

        For Each row As DataRow In dt.Rows
            Dim item As New ItemComprado()
            item.Produto = ProdutoBC.FindByCodigo(CLng(row.Item("codigoProduto")))
            item.NotaFiscal = notaFiscal
            item.Quantidade = CInt(row.Item("quantidade"))
            itens.Add(item)
        Next

        Return itens

    End Function

    'OK
    Public Function DeleteByCompra(compra As NotaFiscalCompra) As Boolean

        If (compra Is Nothing) Then Return False

        Dim conn As New Connection

        conn.AddParameter("@idNotaFiscal", compra.ID)

        Return conn.ExecuteCommand("DELETE FROM ItensComprados WHERE idNotaFiscal = @idNotaFiscal;")

    End Function

End Class

