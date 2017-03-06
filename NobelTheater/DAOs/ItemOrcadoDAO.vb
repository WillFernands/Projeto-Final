Option Explicit On
Option Strict On

Imports System.Text

Public Class ItemOrcadoDAO

    'OK
    Public Function Insert(ByVal item As ItemOrcado) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO ItensOrcados(codigoProduto, idOrcamento, quantidade) ")
        strSQL.Append("VALUES(@codigo, @idOrcamento, @quantidade);")

        conn.AddParameter("@codigo", item.Produto.Codigo)
        conn.AddParameter("@idOrcamento", item.Orcamento.ID)
        conn.AddParameter("@quantidade", item.Quantidade)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindByOrcamento(orcamento As Orcamento) As List(Of ItemOrcado)

        If (orcamento Is Nothing) Then Return Nothing

        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM ItensOrcados ")
        strSQL.Append("WHERE idOrcamento = @idOrcamento;")

        conn.AddParameter("@idOrcamento", orcamento.ID)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of ItemOrcado)

        Dim produtoDAO As New ProdutoDAO()
        Dim orcamentoDAO As New OrcamentoDAO()

        Dim itens As New List(Of ItemOrcado)

        For Each row As DataRow In dt.Rows
            Dim item As New ItemOrcado()
            item.Produto = produtoDAO.FindByCodigo(CLng(row.Item("codigoProduto")))
            item.Orcamento = orcamentoDAO.FindByID(CLng(row.Item("idOrcado")))
            item.Quantidade = CInt(row.Item("quantidade"))
            itens.Add(item)
        Next

        Return itens

    End Function

End Class

