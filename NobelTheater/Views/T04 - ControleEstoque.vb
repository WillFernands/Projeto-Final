Public Class ControleEstoque

    Private fornecedorAtual As Fornecedor
    Private produtoAtual As Produto
    Private produtoAlertaAtual As Produto
    Private itensCotados As New List(Of ItemCotado)

    Private Sub ControleEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NomeTF.Text = "Nome: " & MenuPrincipal.funcionarioLogado.Nome
        MatriculaTF.Text = "Matricula: " & MenuPrincipal.funcionarioLogado.Matricula
        PerfilTF.Text = "Perfil: " & MenuPrincipal.funcionarioLogado.Perfil

        RefreshDTAlertas()
    End Sub

    Private Sub FornecedorIMG_Click(sender As Object, e As EventArgs) Handles FornecedorIMG.Click
        Dim busca As New BuscaFornecedor()
        busca.Caller = "ControleEstoque"
        busca.Show()
    End Sub

    Public Sub PopulateFornecedor(fornecedor As Fornecedor)
        fornecedorAtual = fornecedor
        FornecedorTF.Text = fornecedorAtual.Cnpj & " - " & fornecedorAtual.NomeFantasia
    End Sub

    Public Sub PopulateProduto(produto As Produto)
        produtoAtual = produto
        NomeProdutoTF.Text = produtoAtual.Nome
        CodigoProdutoTF.Text = produtoAtual.Codigo
    End Sub

    Public Sub PopulateProdutoAlerta(produto As Produto)
        produtoAlertaAtual = produto
        ProdutoAlertaTF.Text = produtoAlertaAtual.Codigo & " - " & produtoAlertaAtual.Nome
    End Sub

    Private Sub ProdutoIMG_Click(sender As Object, e As EventArgs) Handles ProdutoCotacaoIMG.Click
        Dim busca As New BuscaProduto()
        busca.Caller = "ControleEstoqueCotacao"
        busca.Show()
    End Sub

    Private Sub ConfirmaProdutoIMG_Click(sender As Object, e As EventArgs) Handles ConfirmaProdutoIMG.Click
        Dim item As New ItemCotado(QtdeTF.Value, produtoAtual)
        Dim itemInserido As ItemCotado = itensCotados.Find(Function(itemCotado As ItemCotado) itemCotado.Produto.Codigo = item.Produto.Codigo)
        If (itemInserido Is Nothing) Then
            itensCotados.Add(item)
            RefreshDTProdutos()
        End If
    End Sub

    Private Sub ProdutosDT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProdutosDT.CellContentClick
        If (ProdutosDT.SelectedCells.Item(0).Value = "Remover Produto" AndAlso e.ColumnIndex = 5) Then
            Dim item As ItemCotado = itensCotados.Find(Function(itemCotado As ItemCotado) itemCotado.Produto.Codigo = ProdutosDT.Item(0, e.RowIndex).Value)
            itensCotados.Remove(item)
            RefreshDTProdutos()
            Exit Sub
        End If
    End Sub

    Private Sub RefreshDTProdutos()
        ProdutosDT.Rows.Clear()

        For Each item As ItemCotado In itensCotados
            Dim list As New List(Of Object)
            list.Add(item.Produto.Codigo) : list.Add(item.Produto.Nome) : list.Add(item.Produto.PrecoUnit) : list.Add(item.Quantidade) : list.Add(item.Produto.PrecoUnit * CInt(item.Quantidade)) : list.Add("Remover Produto")
            ProdutosDT.Rows.Add(list.ToArray())
        Next

        ProdutosDT.Sort(ProdutosDT.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub RefreshDTAlertas()
        AlertasDT.Rows.Clear()

        For Each alerta As Alerta In AlertaBC.FindAll()
            Dim list As New List(Of Object)
            list.Add(alerta.Data) : list.Add(alerta.Produto.Codigo) : list.Add(alerta.Produto.Nome) : list.Add(alerta.Observacao) : list.Add("Remover")
            AlertasDT.Rows.Add(list.ToArray())
        Next

    End Sub

    Private Sub FinalizarBT_Click(sender As Object, e As EventArgs) Handles FinalizarBT.Click
        If (String.IsNullOrWhiteSpace(FornecedorTF.Text) OrElse fornecedorAtual Is Nothing) Then
            MsgBox("Fornecedor não selecionado", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (itensCotados Is Nothing OrElse itensCotados.Count = 0) Then
            MsgBox("Cotação sem produtos", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If

        Dim cotacao As New Cotacao(Now, fornecedorAtual, itensCotados)
        cotacao.ID = CotacaoBC.Insert(cotacao)

        If (cotacao.ID = 0) Then
            MsgBox("Um problema ocorreu durante a criação da cotação", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If

        For Each item As ItemCotado In cotacao.Itens
            item.Cotacao = cotacao

            If (ItemCotadoBC.Insert(item) = False) Then
                MsgBox("Um problema ocorreu durante a criação de um item cotado", vbInformation Or vbMsgBoxSetForeground)
                Exit Sub
            End If
        Next

        MsgBox("Cotação Criada com sucesso !!", vbInformation Or vbMsgBoxSetForeground)
        fornecedorAtual = Nothing
        produtoAtual = Nothing
        itensCotados = New List(Of ItemCotado)
        ProdutosDT.Rows.Clear()

    End Sub

    Private Sub ProdutoAlertaIMG_Click(sender As Object, e As EventArgs) Handles ProdutoAlertaIMG.Click
        Dim busca As New BuscaProduto()
        busca.Caller = "ControleEstoqueAlerta"
        busca.Show()
    End Sub

    Private Sub CriarAlertaBT_Click(sender As Object, e As EventArgs) Handles CriarAlertaBT.Click

        If (String.IsNullOrWhiteSpace(ObservacaoTF.Text)) Then
            MsgBox("Observação não preenchida", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(ProdutoAlertaTF.Text) OrElse produtoAlertaAtual Is Nothing) Then
            MsgBox("Produto não selecionado", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If

        Dim alerta = New Alerta(Now, ObservacaoTF.Text, produtoAlertaAtual)
        AlertaBC.Insert(alerta)
        RefreshDTAlertas()
    End Sub

    Private Sub AlertasDT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AlertasDT.CellContentClick
        If (AlertasDT.SelectedCells.Item(0).Value = "Remover" AndAlso e.ColumnIndex = 4) Then
            Dim alerta As New Alerta(AlertasDT.Item(0, e.RowIndex).Value, AlertasDT.Item(3, e.RowIndex).Value, ProdutoBC.FindByCodigo(CLng(AlertasDT.Item(1, e.RowIndex).Value)))
            AlertaBC.Delete(alerta)
            RefreshDTAlertas()
            Exit Sub
        End If
    End Sub
End Class