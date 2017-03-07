Public Class ControleVendas

    Private clienteAtual As Cliente
    Private produtoAtual As Produto
    Private itensOrcados As New List(Of ItemOrcado)

    Private Sub ControleEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NomeTF.Text = "Nome: " & MenuPrincipal.funcionarioLogado.Nome
        MatriculaTF.Text = "Matricula: " & MenuPrincipal.funcionarioLogado.Matricula
        PerfilTF.Text = "Perfil: " & MenuPrincipal.funcionarioLogado.Perfil
    End Sub

    Private Sub ClienteIMG_Click(sender As Object, e As EventArgs) Handles ClienteIMG.Click
        Dim busca As New BuscaCliente()
        busca.Caller = "ControleVenda"
        busca.Show()
    End Sub

    Public Sub PopulateCliente(cliente As ClientePF)
        clienteAtual = cliente
        SelecionarClienteNovoOrcamentoTF.Text = cliente.CPF & " - " & clienteAtual.Nome
    End Sub

    Public Sub PopulateCliente(cliente As ClientePJ)
        clienteAtual = cliente
        SelecionarClienteNovoOrcamentoTF.Text = cliente.CNPJ & " - " & clienteAtual.Nome
    End Sub

    Public Sub PopulateProduto(produto As Produto)
        produtoAtual = produto
        SelecionarProdutoNovoOrcamentoTF.Text = produtoAtual.Nome
        CodigoProdutoTF.Text = produtoAtual.Codigo
    End Sub

    Private Sub ProdutoIMG_Click(sender As Object, e As EventArgs) Handles ProdutoOrcamentoIMG.Click
        Dim busca As New BuscaProduto()
        busca.Caller = "ControleVendaOrcamento"
        busca.Show()
    End Sub

    Private Sub ConfirmaProdutoIMG_Click(sender As Object, e As EventArgs) Handles ConfirmaProdutoIMG.Click
        Dim item As New ItemOrcado(QtdeTF.Value, produtoAtual)
        Dim itemInserido As ItemOrcado = itensOrcados.Find(Function(itemOrcado As ItemOrcado) itemOrcado.Produto.Codigo = item.Produto.Codigo)
        If (itemInserido Is Nothing) Then
            itensOrcados.Add(item)
            RefreshDTProdutos()
        End If
    End Sub

    Private Sub ProdutosDT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProdutosDT.CellContentClick
        If (ProdutosDT.SelectedCells Is Nothing) Then Exit Sub

        If (ProdutosDT.SelectedCells.Item(0).Value = "Remover Produto" AndAlso e.ColumnIndex = 5) Then
            Dim item As ItemOrcado = itensOrcados.Find(Function(itemOrcado As ItemOrcado) itemOrcado.Produto.Codigo = ProdutosDT.Item(0, e.RowIndex).Value)
            itensOrcados.Remove(item)
            RefreshDTProdutos()
            Exit Sub
        End If
    End Sub

    Private Sub RefreshDTProdutos()
        ProdutosDT.Rows.Clear()

        For Each item As ItemOrcado In itensOrcados
            Dim list As New List(Of Object)
            list.Add(item.Produto.Codigo) : list.Add(item.Produto.Nome) : list.Add(item.Produto.PrecoUnit) : list.Add(item.Quantidade) : list.Add(item.Produto.PrecoUnit * CInt(item.Quantidade)) : list.Add("Remover Produto")
            ProdutosDT.Rows.Add(list.ToArray())
        Next

        ProdutosDT.Sort(ProdutosDT.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub FinalizarBT_Click(sender As Object, e As EventArgs) Handles FinalizarBT.Click
        If (String.IsNullOrWhiteSpace(SelecionarClienteNovoOrcamentoTF.Text) OrElse clienteAtual Is Nothing) Then
            MsgBox("Cliente não selecionado", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (itensOrcados Is Nothing OrElse itensOrcados.Count = 0) Then
            MsgBox("Orcamento sem produtos", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If

        Dim orcamento As New Orcamento(Now, MenuPrincipal.funcionarioLogado, clienteAtual, itensOrcados)

        orcamento.Id = OrcamentoBC.Insert(orcamento)

        If (orcamento.Id = 0) Then
            MsgBox("Um problema ocorreu durante a criação do orçamento", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If

        For Each item As ItemOrcado In orcamento.ItensOrcados
            item.Orcamento = orcamento
            If (ItemOrcadoBC.Insert(item) = False) Then
                MsgBox("Um problema ocorreu durante a criação de um item orçado", vbInformation Or vbMsgBoxSetForeground)
                Exit Sub
            End If
        Next

        MsgBox("Orçamento Criado com sucesso !!", vbInformation Or vbMsgBoxSetForeground)
        clienteAtual = Nothing
        produtoAtual = Nothing
        itensOrcados = New List(Of ItemOrcado)
        ProdutosDT.Rows.Clear()
    End Sub

    Private Sub EnderecosDT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EnderecosDT.CellContentClick

    End Sub
End Class