Option Explicit On
Option Strict On

Imports System.Text

Public Class ItemEmprestimoDAO

    'OK
    Public Function Insert(ByVal item As ItemEmprestimo) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO ItensEmprestimos(codigoProduto, idSolicitacao, quantidade, dataEmprestimo, dataDevolucao) ")
        strSQL.Append("VALUES(@codigo, @idSolicitacao, @quantidade, @dataEmprestimo, @dataDevolucao);")

        conn.AddParameter("@codigo", item.Produto.Codigo)
        conn.AddParameter("@idSolicitacao", item.SolicitacaoEmprestimo.ID)
        conn.AddParameter("@quantidade", item.Quantidade)
        conn.AddParameter("@dataEmprestimo", item.DataEmprestimo)
        conn.AddParameter("@dataDevolucao", item.DataDevolucao)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindBySolicitacao(solicitacao As SolicitacaoEmprestimo) As List(Of ItemEmprestimo)
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM ItensEmprestimos ")
        strSQL.Append("WHERE idSolicitacao = @idSolicitacao;")

        conn.AddParameter("@idSolicitacao", solicitacao.ID)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        Dim produtoDAO As New ProdutoDAO()
        Dim solicitacaoEmprestimoDAO As New SolicitacaoEmprestimoDAO()

        Dim itens As New List(Of ItemEmprestimo)

        For Each row As DataRow In dt.Rows
            Dim item As New ItemEmprestimo()
            item.Produto = produtoDAO.FindByCodigo(CLng(row.Item("codigoProduto")))
            item.SolicitacaoEmprestimo = solicitacaoEmprestimoDAO.FindByID(CLng(row.Item("idSolicitacao")))
            item.Quantidade = CInt(row.Item("quantidade"))
            item.DataEmprestimo = CDate(row.Item("dataEmprestimo"))
            item.DataDevolucao = CDate(row.Item("dataDevolucao"))
            itens.Add(item)
        Next

        Return itens

    End Function

End Class

