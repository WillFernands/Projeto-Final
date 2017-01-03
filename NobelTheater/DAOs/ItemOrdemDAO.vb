Option Explicit On
Option Strict On

Imports System.Text

Public Class ItemOrdemDAO

    'OK
    Public Function Insert(ByVal item As ItemOrdem) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO ItensOrdens(codigoProduto, idOrdem, quantidade, dataEntrega, dataRecebimento, dataDevolucao) ")
        strSQL.Append("VALUES(@codigo, @idOrdem, @quantidade, @dataEntrega, @dataRecebimento, @dataDevolucao);")

        conn.AddParameter("@codigo", item.Produto.Codigo)
        conn.AddParameter("@idOrdem", item.Ordem.ID)
        conn.AddParameter("@quantidade", item.Quantidade)
        conn.AddParameter("@dataEntrega", item.DataEntrega)
        conn.AddParameter("@dataRecebimento", item.DataRecebimento)
        conn.AddParameter("@dataDevolucao", item.DataDevolucao)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindByOrdem(ordem As OrdemServico) As List(Of ItemOrdem)
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM ItensOrcados ")
        strSQL.Append("WHERE idOrdem = @idOrdem;")

        conn.AddParameter("@idOrdem", ordem.ID)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        Dim produtoDAO As New ProdutoDAO()
        Dim ordemServicoDAO As New OrdemServicoDAO()

        Dim itens As New List(Of ItemOrdem)

        For Each row As DataRow In dt.Rows
            Dim item As New ItemOrdem()
            item.Produto = produtoDAO.FindByCodigo(CLng(row.Item("codigoProduto")))
            item.Ordem = ordemServicoDAO.FindByID(CLng(row.Item("idOrdem")))
            item.Quantidade = CInt(row.Item("quantidade"))
            item.DataEntrega = CDate(row.Item("dataEntrega"))
            item.DataRecebimento = CDate(row.Item("dataRecebimento"))
            item.DataDevolucao = CDate(row.Item("dataDevolucao"))
            itens.Add(item)
        Next

        Return itens

    End Function

End Class

