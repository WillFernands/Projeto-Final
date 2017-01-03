Option Explicit On
Option Strict On

Imports System.Text

Public Class ItemCotadoDAO

    'OK
    Public Function Insert(ByVal item As ItemCotado) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO ItensCotados(codigoProduto, idCotacao, quantidade) ")
        strSQL.Append("VALUES(@codigo, @idCotacao, @quantidade);")

        conn.AddParameter("@codigo", item.Produto.Codigo)
        conn.AddParameter("@idCotacao", item.Cotacao.ID)
        conn.AddParameter("@quantidade", item.Quantidade)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindByCotacao(cotacao As Cotacao) As List(Of ItemCotado)
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM ItensCotados ")
        strSQL.Append("WHERE idCotacao = @idCotacao;")

        conn.AddParameter("@idCotacao", cotacao.ID)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        Dim produtoDAO As New ProdutoDAO()
        Dim cotacaoDAO As New CotacaoDAO()

        Dim itens As New List(Of ItemCotado)

        For Each row As DataRow In dt.Rows
            Dim item As New ItemCotado()
            item.Produto = produtoDAO.FindByCodigo(CLng(row.Item("codigoProduto")))
            item.Cotacao = cotacaoDAO.FindByID(CLng(row.Item("idCotacao")))
            item.Quantidade = CInt(row.Item("quantidade"))
            itens.Add(item)
        Next

        Return itens

    End Function

End Class

