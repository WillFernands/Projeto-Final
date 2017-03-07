Public Class VerProdutos

    Public ProdutosList As List(Of ItemCotado)

    Private Sub VerProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDTProdutos()
    End Sub

    Private Sub RefreshDTProdutos()
        ProdutosDT.Rows.Clear()

        For Each item As ItemCotado In ProdutosList
            Dim list As New List(Of Object)
            list.Add(item.Produto.Codigo) : list.Add(item.Produto.Nome) : list.Add(item.Produto.Descricao) : list.Add(item.Produto.PrecoUnit) : list.Add(item.Quantidade) : list.Add(item.Produto.PrecoUnit * CInt(item.Quantidade)) : list.Add("Remover Produto")
            ProdutosDT.Rows.Add(list.ToArray())
        Next

    End Sub
End Class