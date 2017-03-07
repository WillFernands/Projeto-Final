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

        If (solicitacao Is Nothing) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@idSolicitacao", solicitacao.Id)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM ItensEmprestimos WHERE idSolicitacao = @idSolicitacao;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of ItemEmprestimo)

        Dim itens As New List(Of ItemEmprestimo)

        For Each row As DataRow In dt.Rows
            Dim item As New ItemEmprestimo()
            item.Produto = ProdutoBC.FindByCodigo(CLng(row.Item("codigoProduto")))
            item.SolicitacaoEmprestimo = solicitacao
            item.Quantidade = CInt(row.Item("quantidade"))
            item.DataEmprestimo = CDate(row.Item("dataEmprestimo"))
            item.DataDevolucao = CDate(row.Item("dataDevolucao"))
            itens.Add(item)
        Next

        Return itens

    End Function

End Class

