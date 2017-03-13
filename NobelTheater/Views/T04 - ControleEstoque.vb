﻿Public Class ControleEstoque

    Private fornecedorAtual As Fornecedor
    Private produtoAtual As Produto
    Private produtoAlertaAtual As Produto
    Private produtoCotacaoAtual As Produto
    Private produtoEmprestimoAtual As Produto
    Private itensCotados As New List(Of ItemCotado)
    Private itensEmprestimos As New List(Of ItemEmprestimo)
    Private cotacaoAtual As Cotacao
    Private compraAtual As NotaFiscalCompra
    Private clienteAtual As Cliente

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

    Public Sub PopulateProdutoCotacao(produto As Produto)
        produtoCotacaoAtual = produto
        ProdutoAcompanharCotacaoTF.Text = produtoCotacaoAtual.Nome
        CodigoProdutoAcompanharCotacaoTF.Text = produtoCotacaoAtual.Codigo
    End Sub

    Public Sub PopulateProdutoEmprestimo(produto As Produto)
        produtoEmprestimoAtual = produto
        NomeProdutoEmprestarProdutoTF.Text = produtoEmprestimoAtual.Nome
        CodigoProdutoEmprestarProdutoTF.Text = produtoEmprestimoAtual.Codigo
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

    Private Sub ComprasAndamentoTab_GotFocus(sender As Object, e As EventArgs) Handles ComprasAndamentoTab.Enter
        RefreshDTCompras()
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

    Private Sub RefreshDTCompras()
        ComprasDT.Rows.Clear()

        For Each compra As NotaFiscalCompra In NotaFiscalCompraBC.FindAll()
            Dim list As New List(Of Object)
            list.Add(compra.ID) : list.Add(compra.Cotacao.DataCotacao) : list.Add(compra.Status) : list.Add(compra.DataAprovacao) : list.Add(compra.Cotacao.Fornecedor.Cnpj & " - " & compra.Cotacao.Fornecedor.NomeFantasia) : list.Add(compra.NumeroNF) : list.Add("Ver Produtos") : list.Add("Ver Pagamentos")
            ComprasDT.Rows.Add(list.ToArray())
        Next
    End Sub

    Private Sub CotacoesDT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CotacoesDT.CellContentClick
        If (CotacoesDT.SelectedCells Is Nothing) Then Exit Sub

        If (e.ColumnIndex = 4 AndAlso CotacoesDT.SelectedCells.Item(0).Value = "Ver Produtos") Then
            Dim visualizacao As New VerItensCotados()
            visualizacao.ProdutosList = CotacaoBC.FindByID(CotacoesDT.Item(0, e.RowIndex).Value).Itens
            visualizacao.Show()
            Exit Sub
        Else
            If (MsgBox("Essa ação lhe redirecionará a aba de Acompanhar Cotação, continuar ?", vbYesNo Or vbInformation Or vbMsgBoxSetForeground) = vbYes) Then
                ClearAcompanharCotacao()
                cotacaoAtual = CotacaoBC.FindByID(CotacoesDT.Item(0, e.RowIndex).Value)
                PopulateAcompanharCotacao()
                ControleEstoqueTab.SelectTab(3)
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

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
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

    Private Sub ConfimarProdutoAcompanharCotacaoTF_Click(sender As Object, e As EventArgs) Handles ConfimarProdutoAcompanharCotacaoTF.Click
        Dim item As New ItemCotado(QtdeProdutoAcompanharCotacaoTF.Value, produtoCotacaoAtual)
        Dim itemInserido As ItemCotado = cotacaoAtual.Itens.Find(Function(itemCotado As ItemCotado) itemCotado.Produto.Codigo = item.Produto.Codigo)
        If (itemInserido Is Nothing) Then
            cotacaoAtual.Itens.Add(item)
            RefreshDTProdutosAcompanharCotacao()
            produtoCotacaoAtual = Nothing
            QtdeProdutoAcompanharCotacaoTF.Value = 1
            CodigoProdutoAcompanharCotacaoTF.Text = ""
            ProdutoAcompanharCotacaoTF.Text = ""
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)
        Dim busca As New BuscaProduto()
        busca.Caller = "ControleEstoqueProdutoCotacao"
        busca.Show()
    End Sub

    Private Sub SalvarBT_Click(sender As Object, e As EventArgs) Handles SalvarBT.Click
        cotacaoAtual.Status = StatusCotacaoCB.Text
        If (cotacaoAtual.Itens Is Nothing OrElse cotacaoAtual.Itens.Count = 0) Then
            MsgBox("Cotação sem produtos", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (cotacaoAtual.Status = StatusCotacao.Aprovada) Then
            If (MsgBox("Ao aprovar a cotação, uma nota fiscal de compra será criada, deseja prosseguir ?", vbYesNo Or vbInformation Or vbMsgBoxSetForeground) = vbYes) Then
                If (NumeroNFCotacaoTF.Text = "") Then
                    MsgBox("Numero da NF não preenchida", vbInformation Or vbMsgBoxSetForeground)
                    Exit Sub
                ElseIf (DataEmissaoNFCotacaoTF.Text = "") Then
                    MsgBox("Data de emissão da NF não preenchida", vbInformation Or vbMsgBoxSetForeground)
                    Exit Sub
                End If
            Else Exit Sub
            End If
        End If

        ItemCotadoBC.DeleteByCotacao(cotacaoAtual)

        CotacaoBC.UpdateStatus(cotacaoAtual)

        For Each item As ItemCotado In cotacaoAtual.Itens
            item.Cotacao = cotacaoAtual

            If (ItemCotadoBC.Insert(item) = False) Then
                MsgBox("Um problema ocorreu durante a criação de um item cotado", vbInformation Or vbMsgBoxSetForeground)
                Exit Sub
            End If
        Next



        If (cotacaoAtual.Status = StatusCotacao.Aprovada) Then
            Dim nfCompra As New NotaFiscalCompra(StatusCompra.APagar, Now, NumeroNFCotacaoTF.Text, DataEmissaoNFCotacaoTF.Text, cotacaoAtual)
            nfCompra.ID = NotaFiscalCompraBC.Insert(nfCompra)

            For Each item As ItemCotado In cotacaoAtual.Itens
                Dim itemComprado As New ItemComprado(item.Produto, nfCompra, item.Quantidade)
                nfCompra.Items.Add(itemComprado)
            Next

            For Each item As ItemComprado In nfCompra.Items
                ItemCompradoBC.Insert(item)
            Next

            cotacaoAtual = Nothing
            FornecedorAcompanharCotacaoTF.Text = ""
            ProdutoAcompanharCotacaoTF.Text = ""
            CodigoProdutoAcompanharCotacaoTF.Text = ""
            QtdeProdutoAcompanharCotacaoTF.Value = 1
            StatusCotacaoCB.Text = ""
            NumeroNFCotacaoTF.Text = ""
            DataEmissaoNFCotacaoTF.Text = ""
            ProdutosAcompanharCotacaoDT.Rows.Clear()

            MsgBox("Cotação Atualizada com sucesso. Uma nota fiscal foi aberta a partir dessa cotação, você será redirecionado a tela de Acompanhar Compra.", vbInformation Or vbMsgBoxSetForeground)

            compraAtual = nfCompra

            ControleEstoqueTab.SelectTab(5)

            'Aguardar a criação dos componentes em Acompanhar Compra
        Else : MsgBox("Cotação Atualizada com sucesso !!", vbInformation Or vbMsgBoxSetForeground)
        End If

    End Sub

    Private Sub PictureBox8_Click_1(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim busca As New BuscaProduto()
        busca.Caller = "ControleEstoqueProdutoCotacao"
        busca.Show()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles BuscarClienteEmprestarProdutoIMG.Click
        Dim busca As New BuscaCliente()
        busca.Caller = "ControleEstoqueEmprestarProduto"
        busca.Show()
    End Sub

    Public Sub PopulateClienteEmprestarProduto(cliente As ClientePF)
        clienteAtual = cliente
        ClienteEmprestarProdutoTF.Text = cliente.CPF & " - " & cliente.Nome
    End Sub

    Public Sub PopulateClienteEmprestarProduto(cliente As ClientePJ)
        clienteAtual = cliente
        ClienteEmprestarProdutoTF.Text = cliente.CNPJ & " - " & cliente.Nome
    End Sub

    Private Sub BuscarProdutoEmprestarProdutoIMG_Click(sender As Object, e As EventArgs) Handles BuscarProdutoEmprestarProdutoIMG.Click
        Dim busca As New BuscaProduto()
        busca.Caller = "ControleEstoqueEmprestarProduto"
        busca.Show()
    End Sub

    Private Sub ConfirmarProdutoEmprestarProdutoIMG_Click(sender As Object, e As EventArgs) Handles ConfirmarProdutoEmprestarProdutoIMG.Click
        Dim item As New ItemEmprestimo(produtoEmprestimoAtual, QtdeEmprestarProdutoTF.Value, Now)
        Dim itemInserido As ItemEmprestimo = itensEmprestimos.Find(Function(itemEmprestimo As ItemEmprestimo) itemEmprestimo.Produto.Codigo = item.Produto.Codigo)
        If (itemInserido Is Nothing) Then
            itensEmprestimos.Add(item)
            RefreshDTEmprestimos()
            produtoEmprestimoAtual = Nothing
            QtdeEmprestarProdutoTF.Value = 1
            CodigoProdutoEmprestarProdutoTF.Text = ""
            NomeProdutoEmprestarProdutoTF.Text = ""
        End If
    End Sub

    Private Sub RefreshDTEmprestimos()
        ProdutosEmprestimoDT.Rows.Clear()

        For Each item As ItemEmprestimo In itensEmprestimos
            Dim list As New List(Of Object)
            list.Add(item.Produto.Codigo) : list.Add(item.Produto.Nome) : list.Add(item.Quantidade) : list.Add("Remover Produto")
            ProdutosEmprestimoDT.Rows.Add(list.ToArray())
        Next

        ProdutosEmprestimoDT.Sort(ProdutosEmprestimoDT.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub ProdutosEmprestimoDT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProdutosEmprestimoDT.CellContentClick
        If (ProdutosEmprestimoDT.SelectedCells Is Nothing) Then Exit Sub

        If (ProdutosEmprestimoDT.SelectedCells.Item(0).Value = "Remover Produto" AndAlso e.ColumnIndex = 3) Then
            Dim item As ItemEmprestimo = itensEmprestimos.Find(Function(itemEmprestimo As ItemEmprestimo) itemEmprestimo.Produto.Codigo = ProdutosEmprestimoDT.Item(0, e.RowIndex).Value)
            itensEmprestimos.Remove(item)
            RefreshDTEmprestimos()
            Exit Sub
        End If
    End Sub

    Private Sub FinalizarEmprestimoBT_Click(sender As Object, e As EventArgs) Handles FinalizarEmprestimoBT.Click
        If (String.IsNullOrWhiteSpace(ClienteEmprestarProdutoTF.Text) OrElse clienteAtual Is Nothing) Then
            MsgBox("Cliente não selecionado", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (itensEmprestimos Is Nothing OrElse itensEmprestimos.Count = 0) Then
            MsgBox("Solicitação sem produtos", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If

        Dim solicitacao As New SolicitacaoEmprestimo(Now, clienteAtual, itensEmprestimos)
        solicitacao.Id = SolicitacaoEmprestimoBC.Insert(solicitacao)

        If (solicitacao.Id = 0) Then
            MsgBox("Um problema ocorreu durante a criação da solicitação", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If

        For Each item As ItemEmprestimo In solicitacao.ItensEmprestimo
            item.SolicitacaoEmprestimo = solicitacao

            If (ItemEmprestimoBC.Insert(item) = False) Then
                MsgBox("Um problema ocorreu durante a criação de um item do empréstimo", vbInformation Or vbMsgBoxSetForeground)
                Exit Sub
            End If
        Next

        MsgBox("Solicitação Criada com sucesso !!", vbInformation Or vbMsgBoxSetForeground)
        clienteAtual = Nothing
        ClienteEmprestarProdutoTF.Text = ""
        produtoEmprestimoAtual = Nothing
        itensEmprestimos = New List(Of ItemEmprestimo)
        ProdutosEmprestimoDT.Rows.Clear()
    End Sub

    Private Sub AcompanharCompraTab_Enter(sender As Object, e As EventArgs) Handles AcompanharCompraTab.Enter
        StatusCompraAcompanharCompraCB.Items.AddRange(StatusCompra.GetStatusList().ToArray)
        TipoPagamentoCB.Items.AddRange(TipoPagamento.GetTiposList().ToArray)
        PopulateAcompanharCompraTab()
    End Sub

    Private Sub PopulateAcompanharCompraTab()
        If (compraAtual IsNot Nothing) Then
            FornecedorAcompanharCompraTF.Text = compraAtual.Cotacao.Fornecedor.Cnpj & " " & compraAtual.Cotacao.Fornecedor.NomeFantasia
            DataCotacaoAcompanharCompraTF.Text = compraAtual.Cotacao.DataCotacao
            NumeroNFAcompanharCompraTF.Text = compraAtual.NumeroNF
            DataEmissaoAcompanharCompraTF.Text = compraAtual.EmissaoNF
            DataAprovacaoAcompanharCompraTF.Text = compraAtual.DataAprovacao
            StatusCompraAcompanharCompraCB.Text = compraAtual.Status
            RefreshDTPagamentos()
        End If
    End Sub

    Private Sub RefreshDTPagamentos()
        PagamentosDT.Rows.Clear()

        For Each pgto As PagamentoEfetuado In compraAtual.Pagamentos
            Dim list As New List(Of Object)
            list.Add(pgto.ID) : list.Add(pgto.Data) : list.Add(pgto.Tipo) : list.Add(pgto.Status) : list.Add(pgto.Valor) : list.Add("Remover Pgto")
            PagamentosDT.Rows.Add(list.ToArray())
        Next

        PagamentosDT.Sort(PagamentosDT.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub ComprasDT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ComprasDT.CellContentClick
        If (ComprasDT.SelectedCells Is Nothing OrElse e.RowIndex = -1) Then Exit Sub

        If (e.ColumnIndex = 6 AndAlso ComprasDT.SelectedCells.Item(0).Value = "Ver Produtos") Then
            Dim visualizacao As New VerItensComprados()
            visualizacao.ProdutosList = NotaFiscalCompraBC.FindByID(ComprasDT.Item(0, e.RowIndex).Value).Items
            visualizacao.Show()
            Exit Sub
        Else
            If (MsgBox("Essa ação lhe redirecionará a aba de Acompanhar Compra, continuar ?", vbYesNo Or vbInformation Or vbMsgBoxSetForeground) = vbYes) Then
                ClearAcompanharCompra()
                compraAtual = NotaFiscalCompraBC.FindByID(ComprasDT.Item(0, e.RowIndex).Value)
                PopulateAcompanharCompraTab()
                ControleEstoqueTab.SelectTab(5)
            End If
        End If
    End Sub

    Private Sub ClearAcompanharCompra()
        compraAtual = Nothing
        FornecedorAcompanharCompraTF.Text = ""
        DataCotacaoAcompanharCompraTF.Text = ""
        NumeroNFAcompanharCompraTF.Text = ""
        DataEmissaoAcompanharCompraTF.Text = ""
        DataAprovacaoAcompanharCompraTF.Text = ""
        StatusCompraAcompanharCompraCB.Text = ""
        DataPagamentoTF.Text = ""
        TipoPagamentoCB.Text = ""
        ValorPgtoTF.Text = ""
        PagamentosDT.Rows.Clear()
    End Sub

    Private Sub VerItensAcompanharCompraBT_Click(sender As Object, e As EventArgs) Handles VerItensAcompanharCompraBT.Click
        Dim visualizacao As New VerItensComprados()
        visualizacao.ProdutosList = NotaFiscalCompraBC.FindByID(compraAtual.ID).Items
        visualizacao.Show()
    End Sub
End Class