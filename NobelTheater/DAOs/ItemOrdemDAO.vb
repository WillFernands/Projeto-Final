Option Explicit On
Option Strict On

Imports System.Text

Public Class ItemOrdemDAO

    'OK
    Public Function Insert(ByVal item As ItemOrdem) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO ItensOrdens(codigoProduto, idOrdem, quantidade, dataEntrega) ")
        strSQL.Append("VALUES(@codigo, @idOrdem, @quantidade, @dataEntrega);")

        conn.AddParameter("@codigo", item.Produto.Codigo)
        conn.AddParameter("@idOrdem", item.OrdemServico.Id)
        conn.AddParameter("@quantidade", item.Quantidade)
        conn.AddParameter("@dataEntrega", item.DataEntrega)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindByOrdem(ordem As OrdemServico) As List(Of ItemOrdem)
        If (ordem Is Nothing) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@idOrdem", ordem.ID)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM ItensOrcados WHERE idOrdem = @idOrdem;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of ItemOrdem)

        Dim itens As New List(Of ItemOrdem)

        For Each row As DataRow In dt.Rows
            Dim item As New ItemOrdem()
            item.Produto = ProdutoBC.FindByCodigo(CLng(row.Item("codigoProduto")))
            item.OrdemServico = ordem
            item.Quantidade = CInt(row.Item("quantidade"))
            item.DataEntrega = CDate(row.Item("dataEntrega"))
            item.DataRecebimento = CDate(row.Item("dataRecebimento"))
            item.DataDevolucao = CDate(row.Item("dataDevolucao"))
            itens.Add(item)
        Next

        Return itens

    End Function

End Class

