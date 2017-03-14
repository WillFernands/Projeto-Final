Public Class BuscaProduto
    Public Caller As String
    Private produtoBC As New ProdutoBC

    Private produtos As List(Of Produto)

    Private Sub BuscaProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        produtos = ProdutoBC.FindAll()
        PopulateList()
    End Sub

    Private Sub PopulateList()
        ListBox1.Items.Clear()

        For Each prod As Produto In produtos
            ListBox1.Items.Add(prod.Codigo & " - " & prod.Nome)
        Next

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick

        If (ListBox1.SelectedItem Is Nothing) Then Exit Sub

        Dim codigo As Long = CLng(Trim(DirectCast(ListBox1.SelectedItem, String).Split("-")(0)))

        Dim produto As Produto = produtos.Find(Function(prod As Produto) prod.Codigo = codigo)

        If (Caller = "ControleEstoqueCotacao") Then
            ControleEstoque.PopulateProduto(produto)
            Me.Close()
        ElseIf (Caller = "ControleEstoqueAlerta") Then
            ControleEstoque.PopulateProdutoAlerta(produto)
            Me.Close()
        ElseIf (Caller = "ControleVendaOrcamento") Then
            ControleVendas.PopulateProduto(produto)
            Me.Close()
        ElseIf (Caller = "ControleEstoqueProdutoCotacao") Then
            ControleEstoque.PopulateProdutoCotacao(produto)
            Me.Close()
        ElseIf (Caller = "ControleEstoqueEmprestarProduto") Then
            ControleEstoque.PopulateProdutoEmprestimoAtual(produto)
            Me.Close()
        ElseIf (Caller = "ControleEstoqueProdutosEmprestados") Then
            ControleEstoque.PopulateProdutoEmprestimo(produto)
            Me.Close()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        PopulateList()
Back:   For Each item As String In ListBox1.Items
            If (item.Contains(TextBox1.Text) = False) Then
                ListBox1.Items.Remove(item)
                GoTo Back
            End If
        Next
    End Sub
End Class