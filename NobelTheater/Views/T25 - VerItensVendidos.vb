Public Class VerItensVendidos
    Public ProdutosList As List(Of ItemVendido)

    Private Sub VerItensVendidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDTProdutos()
    End Sub

    Private Sub RefreshDTProdutos()
        ProdutosDT.Rows.Clear()

        For Each item As ItemVendido In ProdutosList
            Dim list As New List(Of Object)
            list.Add(item.Produto.Codigo) : list.Add(item.Produto.Nome) : list.Add(item.Produto.Descricao) : list.Add(item.Produto.PrecoUnit) : list.Add(item.Quantidade) : list.Add(item.Produto.PrecoUnit * CInt(item.Quantidade))
            ProdutosDT.Rows.Add(list.ToArray())
        Next

    End Sub
End Class