Public Class ControleEstoque

    Private fornecedorAtual As Fornecedor
    Private produtoAtual As Produto
    Private produtoAlertaAtual As Produto
    Private itensCotados As New List(Of ItemCotado)
    Private cotacaoAtual As Cotacao

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
        If (ProdutosDT.SelectedCells Is Nothing) Then Exit Sub

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

    Private Sub RefreshDTProdutosAcompanharCotacao()
        ProdutosAcompanharCotacaoDT.Rows.Clear()

        For Each item As ItemCotado In cotacaoAtual.Itens
            Dim list As New List(Of Object)
            list.Add(item.Produto.Codigo) : list.Add(item.Produto.Nome) : list.Add(item.Produto.PrecoUnit) : list.Add(item.Quantidade) : list.Add(item.Produto.PrecoUnit * CInt(item.Quantidade)) : list.Add("Remover Produto")
            ProdutosAcompanharCotacaoDT.Rows.Add(list.ToArray())
        Next

        ProdutosAcompanharCotacaoDT.Sort(ProdutosAcompanharCotacaoDT.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
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
        If (AlertasDT.SelectedCells Is Nothing) Then Exit Sub

        If (AlertasDT.SelectedCells.Item(0).Value = "Remover" AndAlso e.ColumnIndex = 4) Then
            Dim alerta As New Alerta(AlertasDT.Item(0, e.RowIndex).Value, AlertasDT.Item(3, e.RowIndex).Value, ProdutoBC.FindByCodigo(CLng(AlertasDT.Item(1, e.RowIndex).Value)))
            AlertaBC.Delete(alerta)
            RefreshDTAlertas()
            Exit Sub
        End If
    End Sub

    Private Sub CotacoesAndamentoTab_GotFocus(sender As Object, e As EventArgs) Handles CotacoesAndamentoTab.Enter
        RefreshDTCotacoes()
    End Sub

    Private Sub RefreshDTCotacoes()
        CotacoesDT.Rows.Clear()

        For Each cotacao As Cotacao In CotacaoBC.FindAll()
            Dim list As New List(Of Object)
            list.Add(cotacao.ID) : list.Add(cotacao.DataCotacao) : list.Add(cotacao.Status) : list.Add(cotacao.Fornecedor.Cnpj & " - " & cotacao.Fornecedor.NomeFantasia) : list.Add("Ver Produtos")
            CotacoesDT.Rows.Add(list.ToArray())
        Next

    End Sub

    Private Sub CotacoesDT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CotacoesDT.CellContentClick
        If (CotacoesDT.SelectedCells Is Nothing) Then Exit Sub

        If (e.ColumnIndex = 4 AndAlso CotacoesDT.SelectedCells.Item(0).Value = "Ver Produtos") Then
            Dim visualizacao As New VerProdutos()
            visualizacao.ProdutosList = CotacaoBC.FindByID(CotacoesDT.Item(0, e.RowIndex).Value).Itens
            visualizacao.Show()
            Exit Sub
        Else
            If (MsgBox("Essa ação lhe redirecionará a aba de Acompanhar Cotação, continuar ?", vbYesNo Or vbInformation Or vbMsgBoxSetForeground) = vbYes) Then
                ClearAcompanharCotacao()
                cotacaoAtual = CotacaoBC.FindByID(CotacoesDT.Item(0, e.RowIndex).Value)
                PopulateAcompanharCotacao()
                TabControl1.SelectTab(3)
            End If
        End If
    End Sub

    Private Sub ClearAcompanharCotacao()
        cotacaoAtual = Nothing
        FornecedorAcompanharCotacaoTF.Text = ""
        ProdutoAcompanharCotacaoTF.Text = ""
        CodigoProdutoAcompanharCotacaoTF.Text = ""
        QtdeProdutoAcompanharCotacaoTF.Value = 1
        StatusCotacaoCB.Text = ""
        NumeroNFCotacaoTF.Text = ""
        DataEmissaoNFCotacaoTF.Text = ""
        ProdutosAcompanharCotacaoDT.Rows.Clear()
    End Sub

    Private Sub PopulateAcompanharCotacao()
        FornecedorAcompanharCotacaoTF.Text = cotacaoAtual.Fornecedor.Cnpj & " - " & cotacaoAtual.Fornecedor.NomeFantasia
        StatusCotacaoCB.Text = cotacaoAtual.Status
        ProdutosAcompanharCotacaoDT.Rows.Clear()

        For Each item As ItemCotado In cotacaoAtual.Itens

            Dim list As New List(Of Object)
            list.Add(item.Produto.Codigo) : list.Add(item.Produto.Nome) : list.Add(item.Produto.PrecoUnit) : list.Add(item.Quantidade) : list.Add(item.Produto.PrecoUnit * CInt(item.Quantidade)) : list.Add("Remover Produto")
            ProdutosAcompanharCotacaoDT.Rows.Add(list.ToArray())
        Next

        ProdutosAcompanharCotacaoDT.Sort(ProdutosAcompanharCotacaoDT.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click, PictureBox2.Click
        ControleFornecedor.Show()
    End Sub

    Private Sub AcompanharCotacaoTab_Enter(sender As Object, e As EventArgs) Handles AcompanharCotacaoTab.Enter
        StatusCotacaoCB.Items.AddRange(StatusCotacao.GetStatusList().ToArray())
        EnableNFControls()
    End Sub

    Private Sub StatusCotacaoCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StatusCotacaoCB.SelectedIndexChanged
        EnableNFControls()
    End Sub

    Private Sub EnableNFControls()
        If (StatusCotacaoCB.SelectedItem = StatusCotacao.Aprovada) Then
            NumeroNFCotacaoLB.Visible = True
            NumeroNFCotacaoTF.Visible = True
            DataEmissaoNFCotacaoLB.Visible = True
            DataEmissaoNFCotacaoTF.Visible = True
        Else
            NumeroNFCotacaoLB.Visible = False
            NumeroNFCotacaoTF.Visible = False
            DataEmissaoNFCotacaoLB.Visible = False
            DataEmissaoNFCotacaoTF.Visible = False
            NumeroNFCotacaoTF.Text = ""
            DataEmissaoNFCotacaoTF.Text = ""
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim busca As New BuscaFornecedor()
        busca.Caller = "ControleEstoqueAcompanharCotacao"
        busca.Show()
    End Sub

    Private Sub PopulateFornecedorCotacao(forn As Fornecedor)
        cotacaoAtual.Fornecedor = forn
        FornecedorAcompanharCotacaoTF.Text = cotacaoAtual.Fornecedor.Cnpj & " - " & cotacaoAtual.Fornecedor.NomeFantasia
    End Sub

    Private Sub ProdutosAcompanharCotacaoDT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProdutosAcompanharCotacaoDT.CellContentClick
        If (ProdutosAcompanharCotacaoDT.SelectedCells Is Nothing) Then Exit Sub

        If (ProdutosAcompanharCotacaoDT.SelectedCells.Item(0).Value = "Remover Produto" AndAlso e.ColumnIndex = 5) Then
            Dim item As ItemCotado = cotacaoAtual.Itens.Find(Function(itemCotado As ItemCotado) itemCotado.Produto.Codigo = ProdutosAcompanharCotacaoDT.Item(0, e.RowIndex).Value)
            cotacaoAtual.Itens.Remove(item)
            RefreshDTProdutosAcompanharCotacao()
            Exit Sub
        End If
    End Sub
End Class