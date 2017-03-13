Public Class VerItensComprados

    Private Sub T20___VerItensComprados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public ProdutosList As List(Of ItemComprado)

    Private Sub RefreshDTProdutos()
        ProdutosDT.Rows.Clear()

        For Each item As ItemComprado In ProdutosList
            Dim list As New List(Of Object)
            list.Add(item.Produto.Codigo) : list.Add(item.Produto.Nome) : list.Add(item.Produto.Descricao) : list.Add(item.Produto.PrecoUnit) : list.Add(item.Quantidade) : list.Add(item.Produto.PrecoUnit * CInt(item.Quantidade)) : list.Add("Remover Produto")
            ProdutosDT.Rows.Add(list.ToArray())
        Next

    End Sub
End Class