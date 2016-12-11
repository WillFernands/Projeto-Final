Public Class ControleEstoque

    Private Sub ControleEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim list As New List(Of Object)
        list.Add("Projetor Philips") : list.Add("5.000,00") : list.Add("1") : list.Add("5.000,00") : list.Add("Remover Produto")
        ProdutosDT.Rows.Add(list.ToArray()) : list.Clear()
        list.Add("Lampadas LED Philips") : list.Add("120,00") : list.Add("10") : list.Add("1.200,00") : list.Add("Remover Produto")
        ProdutosDT.Rows.Add(list.ToArray()) : list.Clear()
        list.Add("Controladora Control 4") : list.Add("5.750,00") : list.Add("1") : list.Add("5.750,00") : list.Add("Remover Produto")
        ProdutosDT.Rows.Add(list.ToArray()) : list.Clear()
    End Sub

End Class