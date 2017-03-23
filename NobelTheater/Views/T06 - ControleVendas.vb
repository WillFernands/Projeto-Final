Public Class ControleVendas

    Private clienteAtual As Cliente
    Private produtoAtual As Produto
    Private orcamentoAtual As Orcamento
    Private produtoAcompanharOrcamento As Produto
    Private vendaAtual As NotaFiscalVenda
    Private itensOrcados As New List(Of ItemOrcado)
    Private visitaAtual As VisitaTecnica
    'Private hiddenTabs As New List(Of TabPage)

    Private Sub ControleEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NomeTF.Text = "Nome: " & MenuPrincipal.funcionarioLogado.Nome
        MatriculaTF.Text = "Matricula: " & MenuPrincipal.funcionarioLogado.Matricula
        PerfilTF.Text = "Perfil: " & MenuPrincipal.funcionarioLogado.Perfil
        'hiddenTabs.Add(ControleVendasTabControl.TabPages.Item("AcompanharOrcamentoTab"))
        'ControleVendasTabControl.TabPages.RemoveByKey("AcompanharOrcamentoTab")
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

        For Each item As ItemOrcado In orcamento.Itens
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

    Private Sub EnderecosDT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub OrcamentosDT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles OrcamentosDT.CellContentClick
        If (OrcamentosDT.SelectedCells Is Nothing) Then Exit Sub

        If (e.ColumnIndex = 5 AndAlso OrcamentosDT.SelectedCells.Item(0).Value = "Ver Produtos") Then
            Dim visualizacao As New VerItensOrcados()
            visualizacao.ProdutosList = OrcamentoBC.FindByID(OrcamentosDT.Item(0, e.RowIndex).Value).Itens
            visualizacao.Show()
            Exit Sub
        Else
            If (MsgBox("Essa ação lhe redirecionará a aba de Acompanhar Orçamento, continuar ?", vbYesNo Or vbInformation Or vbMsgBoxSetForeground) = vbYes) Then
                ClearAcompanharOrcamento()
                orcamentoAtual = OrcamentoBC.FindByID(OrcamentosDT.Item(0, e.RowIndex).Value)
                'ControleVendasTabControl.TabPages.Insert(2, hiddenTabs.Find(Function(page As TabPage) page.Name = "AcompanharOrcamentoTab"))
                ControleVendasTabControl.SelectTab(2)
                PopulateAcompanharOrcamento()
            End If
        End If
    End Sub

    Private Sub OrcamentosAndamentoTab_Enter(sender As Object, e As EventArgs) Handles OrcamentosAndamentoTab.Enter
        RefreshDTOrcamentos()
    End Sub

    Private Sub RefreshDTOrcamentos()
        OrcamentosDT.Rows.Clear()

        For Each orcamento As Orcamento In OrcamentoBC.FindAll()
            Dim list As New List(Of Object)
            list.Add(orcamento.Id) : list.Add(orcamento.DataOrcamento) : list.Add(orcamento.Status) : list.Add(orcamento.Cliente.ID & " - " & orcamento.Cliente.Nome) : list.Add(orcamento.Vendedor.Matricula & " - " & orcamento.Vendedor.Nome) : list.Add("Ver Produtos")
            OrcamentosDT.Rows.Add(list.ToArray())
        Next
    End Sub

    Private Sub ClearAcompanharOrcamento()
        orcamentoAtual = Nothing
        ClienteAcompanharOrcamentoTF.Text = ""
        VendedorAcompanharOrcamentoTF.Text = ""
        ProdutoAcompanharOrcamentoTF.Text = ""
        CodigoProdutoAcompanharOrcamentoTF.Text = ""
        QtdeProdutoAcompanharOrcamentoTF.Value = 1
        StatusOrcamentoCB.Text = ""
        NumeroNFOrcamentoTF.Text = ""
        DataEmissaoNFOrcamentoTF.Text = ""
        ProdutosAcompanharOrcamentoDT.Rows.Clear()
    End Sub

    Private Sub PopulateAcompanharOrcamento()
        If (orcamentoAtual Is Nothing) Then Exit Sub
        ClienteAcompanharOrcamentoTF.Text = orcamentoAtual.Cliente.ID & " - " & orcamentoAtual.Cliente.Nome
        VendedorAcompanharOrcamentoTF.Text = orcamentoAtual.Vendedor.Matricula & " - " & orcamentoAtual.Vendedor.Nome
        StatusOrcamentoCB.Text = orcamentoAtual.Status
        ProdutosAcompanharOrcamentoDT.Rows.Clear()

        For Each item As ItemOrcado In orcamentoAtual.Itens
            Dim list As New List(Of Object)
            list.Add(item.Produto.Codigo) : list.Add(item.Produto.Nome) : list.Add(item.Produto.PrecoUnit) : list.Add(item.Quantidade) : list.Add(item.Produto.PrecoUnit * CInt(item.Quantidade)) : list.Add("Remover Produto")
            ProdutosAcompanharOrcamentoDT.Rows.Add(list.ToArray())
        Next

        ProdutosAcompanharOrcamentoDT.Sort(ProdutosAcompanharOrcamentoDT.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub ProdutosAcompanharOrcamentoDT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProdutosAcompanharOrcamentoDT.CellContentClick
        If (ProdutosAcompanharOrcamentoDT.SelectedCells Is Nothing) Then Exit Sub

        If (ProdutosAcompanharOrcamentoDT.SelectedCells.Item(0).Value = "Remover Produto" AndAlso e.ColumnIndex = 5) Then
            Dim item As ItemOrcado = orcamentoAtual.Itens.Find(Function(itemOrcado As ItemOrcado) itemOrcado.Produto.Codigo = ProdutosAcompanharOrcamentoDT.Item(0, e.RowIndex).Value)
            orcamentoAtual.Itens.Remove(item)
            RefreshDTProdutosAcompanharOrcamento()
            Exit Sub
        End If
    End Sub

    Private Sub RefreshDTProdutosAcompanharOrcamento()
        ProdutosAcompanharOrcamentoDT.Rows.Clear()

        For Each item As ItemOrcado In orcamentoAtual.Itens
            Dim list As New List(Of Object)
            list.Add(item.Produto.Codigo) : list.Add(item.Produto.Nome) : list.Add(item.Produto.PrecoUnit) : list.Add(item.Quantidade) : list.Add(item.Produto.PrecoUnit * CInt(item.Quantidade)) : list.Add("Remover Produto")
            ProdutosAcompanharOrcamentoDT.Rows.Add(list.ToArray())
        Next

        ProdutosAcompanharOrcamentoDT.Sort(ProdutosAcompanharOrcamentoDT.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub SelecionarProdutoAcompanharOrcamentoIMG_Click(sender As Object, e As EventArgs) Handles SelecionarProdutoAcompanharOrcamentoIMG.Click
        Dim busca As New BuscaProduto()
        busca.Caller = "ControleVendasProdutoAcompanharOrcamento"
        busca.Show()
    End Sub

    Public Sub PopulateProdutoAcompanharOrcamento(produto As Produto)
        produtoAcompanharOrcamento = produto
        ProdutoAcompanharOrcamentoTF.Text = produtoAcompanharOrcamento.Nome
        CodigoProdutoAcompanharOrcamentoTF.Text = produtoAcompanharOrcamento.Codigo
    End Sub

    Private Sub ConfimarProdutoAcompanharOrcamentoIMG_Click(sender As Object, e As EventArgs) Handles ConfimarProdutoAcompanharOrcamentoIMG.Click
        Dim item As New ItemOrcado(QtdeProdutoAcompanharOrcamentoTF.Value, produtoAcompanharOrcamento)
        Dim itemInserido As ItemOrcado = orcamentoAtual.Itens.Find(Function(ItemOrcado As ItemOrcado) ItemOrcado.Produto.Codigo = item.Produto.Codigo)
        If (itemInserido Is Nothing) Then
            orcamentoAtual.Itens.Add(item)
            RefreshDTProdutosAcompanharOrcamento()
            produtoAcompanharOrcamento = Nothing
            QtdeProdutoAcompanharOrcamentoTF.Value = 1
            CodigoProdutoAcompanharOrcamentoTF.Text = ""
            ProdutoAcompanharOrcamentoTF.Text = ""
        End If
    End Sub

    Private Sub SalvarAcompanharOrcamentoBT_Click(sender As Object, e As EventArgs) Handles SalvarAcompanharOrcamentoBT.Click
        orcamentoAtual.Status = StatusOrcamentoCB.Text
        If (orcamentoAtual.Itens Is Nothing OrElse orcamentoAtual.Itens.Count = 0) Then
            MsgBox("Cotação sem produtos", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (orcamentoAtual.Status = StatusOrcamento.Aprovado) Then
            If (MsgBox("Ao aprovar o orçamento, uma nota fiscal de venda será criada, deseja prosseguir ?", vbYesNo Or vbInformation Or vbMsgBoxSetForeground) = vbYes) Then
                If (NumeroNFOrcamentoTF.Text = "") Then
                    MsgBox("Numero da NF não preenchida", vbInformation Or vbMsgBoxSetForeground)
                    Exit Sub
                ElseIf (DataEmissaoNFOrcamentoTF.Text = "") Then
                    MsgBox("Data de emissão da NF não preenchida", vbInformation Or vbMsgBoxSetForeground)
                    Exit Sub
                End If
            Else Exit Sub
            End If
        End If

        ItemOrcadoBC.DeleteByOrcamento(orcamentoAtual)

        OrcamentoBC.UpdateStatus(orcamentoAtual)

        For Each item As ItemOrcado In orcamentoAtual.Itens
            item.Orcamento = orcamentoAtual

            If (ItemOrcadoBC.Insert(item) = False) Then
                MsgBox("Um problema ocorreu durante a criação de um item orçado", vbInformation Or vbMsgBoxSetForeground)
                Exit Sub
            End If
        Next



        If (orcamentoAtual.Status = StatusOrcamento.Aprovado) Then
            Dim nfVenda As New NotaFiscalVenda(StatusVenda.VendaEfetuada, Now, NumeroNFOrcamentoTF.Text, DataEmissaoNFOrcamentoTF.Text, orcamentoAtual)
            nfVenda.Id = NotaFiscalVendaBC.Insert(nfVenda)

            For Each item As ItemOrcado In orcamentoAtual.Itens
                Dim itemVendido As New ItemVendido(item.Produto, nfVenda, item.Quantidade)
                nfVenda.Itens.Add(itemVendido)
            Next

            For Each item As ItemVendido In nfVenda.Itens
                ItemVendidoBC.Insert(item)
            Next

            orcamentoAtual = Nothing
            ClienteAcompanharOrcamentoTF.Text = ""
            VendedorAcompanharOrcamentoTF.Text = ""
            ProdutoAcompanharOrcamentoTF.Text = ""
            CodigoProdutoAcompanharOrcamentoTF.Text = ""
            QtdeProdutoAcompanharOrcamentoTF.Value = 1
            StatusOrcamentoCB.Text = ""
            NumeroNFOrcamentoTF.Text = ""
            DataEmissaoNFOrcamentoTF.Text = ""
            ProdutosAcompanharOrcamentoDT.Rows.Clear()

            MsgBox("Orçamento Atualizado com sucesso. Uma nota fiscal foi aberta a partir desse orçamento, você será redirecionado a tela de Acompanhar Venda.", vbInformation Or vbMsgBoxSetForeground)

            vendaAtual = nfVenda

            ControleVendasTabControl.SelectTab(4)

        Else : MsgBox("Orçamento Atualizado com sucesso !!", vbInformation Or vbMsgBoxSetForeground)
        End If
    End Sub

    Private Sub AcompanharOrcamentoTab_Enter(sender As Object, e As EventArgs) Handles AcompanharOrcamentoTab.Enter
        StatusOrcamentoCB.Items.Clear()
        StatusOrcamentoCB.Items.AddRange(StatusOrcamento.GetStatusList().ToArray)
        PopulateAcompanharOrcamento()
    End Sub

    Private Sub AcompanharVendaTab_Enter(sender As Object, e As EventArgs) Handles AcompanharVendaTab.Enter
        If (vendaAtual IsNot Nothing) Then vendaAtual = NotaFiscalVendaBC.FindByID(vendaAtual.Id)
        StatusVendaAcompanharVendaCB.Items.Clear()
        TipoPagamentoCB.Items.Clear()
        StatusVendaAcompanharVendaCB.Items.AddRange(StatusOrcamento.GetStatusList().ToArray)
        TipoPagamentoCB.Items.AddRange(TipoPagamento.GetTiposList().ToArray)
        PopulateAcompanharVenda()
    End Sub

    Private Sub PopulateAcompanharVenda()
        If (vendaAtual IsNot Nothing) Then
            ClienteAcompanharVendaTF.Text = vendaAtual.Orcamento.Cliente.ID & " - " & vendaAtual.Orcamento.Cliente.Nome
            VendedorAcompanharVendaTF.Text = vendaAtual.Orcamento.Vendedor.Matricula & " - " & vendaAtual.Orcamento.Vendedor.Nome
            DataOrcamentoAcompanharVendaTF.Text = vendaAtual.Orcamento.DataOrcamento
            NumeroNFAcompanharVendaTF.Text = vendaAtual.NumeroNF
            DataEmissaoAcompanharVendaTF.Text = vendaAtual.EmissaoNF
            DataAprovacaoAcompanharVendaTF.Text = vendaAtual.DataAprovacao
            StatusVendaAcompanharVendaCB.Text = vendaAtual.Status
            RefreshDTPagamentosAcompanharVenda()
        End If
    End Sub

    Private Sub RefreshDTPagamentosAcompanharVenda()
        PagamentosAcompanharVendaDT.Rows.Clear()

        For Each pgto As PagamentoRecebido In vendaAtual.PagamentosRecebidos
            Dim list As New List(Of Object)
            list.Add(pgto.ID) : list.Add(pgto.Data) : list.Add(pgto.Tipo) : list.Add(pgto.Status) : list.Add(pgto.Valor) : list.Add("Remover Pgto")
            PagamentosAcompanharVendaDT.Rows.Add(list.ToArray())
        Next

        PagamentosAcompanharVendaDT.Sort(PagamentosAcompanharVendaDT.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub PagamentosAcompanharVendaDT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PagamentosAcompanharVendaDT.CellContentClick
        If (PagamentosAcompanharVendaDT.SelectedCells Is Nothing) Then Exit Sub

        If (PagamentosAcompanharVendaDT.SelectedCells.Item(0).Value = "Remover Pgto" AndAlso e.ColumnIndex = 5) Then
            Dim pgto As PagamentoRecebido = vendaAtual.PagamentosRecebidos.Find(Function(pgtoRecebido As PagamentoRecebido) pgtoRecebido.ID = PagamentosAcompanharVendaDT.Item(0, e.RowIndex).Value)
            vendaAtual.PagamentosRecebidos.Remove(pgto)
            RefreshDTPagamentosAcompanharVenda()
            Exit Sub
        End If
    End Sub

    Private Sub ConfirmarProdutoAcompanharVendaIMG_Click(sender As Object, e As EventArgs) Handles ConfirmarProdutoAcompanharVendaIMG.Click
        Dim pgto As New PagamentoRecebido(StatusPagamento.Finalizado, ValorPgtoTF.Text, DataPagamentoTF.Text, TipoPagamentoCB.Text, vendaAtual)
        vendaAtual.PagamentosRecebidos.Add(pgto)
        ValorPgtoTF.Text = ""
        TipoPagamentoCB.Text = ""
        DataPagamentoTF.Text = ""
        RefreshDTPagamentosAcompanharVenda()
    End Sub

    Private Sub SalvarVendaBT_Click(sender As Object, e As EventArgs) Handles SalvarVendaBT.Click

        If (String.IsNullOrWhiteSpace(NumeroNFAcompanharVendaTF.Text)) Then
            MsgBox("Número da Nota Fiscal não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(DataEmissaoAcompanharVendaTF.Text)) Then
            MsgBox("Data de emissão da Nota Fiscal não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(StatusVendaAcompanharVendaCB.Text)) Then
            MsgBox("Status da nota fiscal não preenchida", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If

        vendaAtual.Status = StatusVendaAcompanharVendaCB.Text
        vendaAtual.NumeroNF = NumeroNFAcompanharVendaTF.Text
        vendaAtual.EmissaoNF = DataEmissaoAcompanharVendaTF.Text

        PagamentoRecebidoBC.DeleteByVenda(vendaAtual)

        NotaFiscalVendaBC.Update(vendaAtual)

        For Each pgto As PagamentoRecebido In vendaAtual.PagamentosRecebidos
            pgto.NotaFiscal = vendaAtual

            If (PagamentoRecebidoBC.Insert(pgto) = False) Then
                MsgBox("Um problema ocorreu durante a criação de um pagamento", vbInformation Or vbMsgBoxSetForeground)
                Exit Sub
            End If
        Next

        MsgBox("Venda Atualizada com sucesso !!", vbInformation Or vbMsgBoxSetForeground)

    End Sub

    Private Sub VendasAndamentoTab_Enter(sender As Object, e As EventArgs) Handles VendasAndamentoTab.Enter
        RefreshDTVendas()
    End Sub

    Private Sub RefreshDTVendas()
        VendasDT.Rows.Clear()

        For Each venda As NotaFiscalVenda In NotaFiscalVendaBC.FindAll()
            Dim list As New List(Of Object)
            list.Add(venda.Id) : list.Add(venda.Orcamento.DataOrcamento) : list.Add(venda.Status) : list.Add(venda.DataAprovacao) : list.Add(venda.Orcamento.Cliente.ID & " - " & venda.Orcamento.Cliente.Nome) : list.Add(venda.NumeroNF) : list.Add("Ver Produtos")
            VendasDT.Rows.Add(list.ToArray())
        Next
    End Sub

    Private Sub VendasDT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles VendasDT.CellContentClick
        If (VendasDT.SelectedCells Is Nothing OrElse e.RowIndex = -1) Then Exit Sub

        If (e.ColumnIndex = 6 AndAlso VendasDT.SelectedCells.Item(0).Value = "Ver Produtos") Then
            Dim visualizacao As New VerItensVendidos()
            visualizacao.ProdutosList = NotaFiscalVendaBC.FindByID(VendasDT.Item(0, e.RowIndex).Value).Itens
            visualizacao.Show()
            Exit Sub
        Else
            If (MsgBox("Essa ação lhe redirecionará a aba de Acompanhar Venda, continuar ?", vbYesNo Or vbInformation Or vbMsgBoxSetForeground) = vbYes) Then
                ClearAcompanharVenda()
                vendaAtual = NotaFiscalVendaBC.FindByID(VendasDT.Item(0, e.RowIndex).Value)
                PopulateAcompanharVenda()
                ControleVendasTabControl.SelectTab(4)
            End If
        End If

    End Sub

    Private Sub ClearAcompanharVenda()
        vendaAtual = Nothing
        ClienteAcompanharVendaTF.Text = ""
        VendedorAcompanharVendaTF.Text = ""
        DataOrcamentoAcompanharVendaTF.Text = ""
        NumeroNFAcompanharVendaTF.Text = ""
        DataEmissaoAcompanharVendaTF.Text = ""
        DataAprovacaoAcompanharVendaTF.Text = ""
        StatusVendaAcompanharVendaCB.Text = ""
        DataPagamentoTF.Text = ""
        TipoPagamentoCB.Text = ""
        ValorPgtoTF.Text = ""
        PagamentosAcompanharVendaDT.Rows.Clear()
    End Sub

    Private Sub VerItensAcompanharVendaBT_Click(sender As Object, e As EventArgs) Handles VerItensAcompanharVendaBT.Click
        Dim visualizacao As New VerItensVendidos()
        visualizacao.ProdutosList = NotaFiscalVendaBC.FindByID(vendaAtual.Id).Itens
        visualizacao.Show()
    End Sub

    Private Sub CriarVisitaAcompanharVendaBT_Click(sender As Object, e As EventArgs) Handles CriarVisitaAcompanharVendaBT.Click
        CriarVisitaTecnica.PopulateVenda(vendaAtual)
        CriarVisitaTecnica.Show()
    End Sub

    Private Sub VisualizarVisitaBT_Click(sender As Object, e As EventArgs) Handles VisualizarVisitaBT.Click
        vendaAtual = NotaFiscalVendaBC.FindByID(vendaAtual.Id)
        ControleVendasTabControl.SelectTab(5)
    End Sub

    Private Sub VisualizarVisitasTab_Enter(sender As Object, e As EventArgs) Handles VisualizarVisitasTab.Enter
        If (vendaAtual Is Nothing) Then
            Exit Sub
        Else vendaAtual = NotaFiscalVendaBC.FindByID(vendaAtual.Id)
        End If
        TipoVisitaCB.Items.Clear()
        TipoVisitaCB.Items.AddRange(TipoVisita.GetTiposList().ToArray())
        RefreshDTVisitas()
    End Sub

    Private Sub RefreshDTVisitas()
        VisitasDT.Rows.Clear()

        For Each visita As VisitaTecnica In vendaAtual.VisitasTecnicas
            Dim list As New List(Of Object)
            list.Add(visita.Data) : list.Add(visita.NotaFiscal.Orcamento.Cliente.ID & " - " & visita.NotaFiscal.Orcamento.Cliente.Nome) : list.Add(visita.Tipo) : list.Add(visita.Supervisor.Matricula & " - " & visita.Supervisor.Nome) : list.Add(visita.Preco)
            VisitasDT.Rows.Add(list.ToArray())
        Next
    End Sub

    Private Sub VisitasDT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles VisitasDT.CellContentClick
        If (VisitasDT.SelectedCells Is Nothing OrElse e.RowIndex = -1) Then Exit Sub

        visitaAtual = vendaAtual.VisitasTecnicas(e.RowIndex)

        ClearAcompanharVisita()
        PopulateAcompanharVisita()

    End Sub

    Private Sub ClearAcompanharVisita()
        SupervisorVisitaTF.Text = ""
        ClienteVisitaTF.Text = ""
        DataVisitaTF.Text = ""
        TipoVisitaCB.Text = ""
        PrecoVisitaTF.Text = ""
        ParecerObraVisitaTF.Text = ""
    End Sub

    Private Sub PopulateAcompanharVisita()
        SupervisorVisitaTF.Text = visitaAtual.Supervisor.Matricula & " - " & visitaAtual.Supervisor.Nome
        ClienteVisitaTF.Text = visitaAtual.NotaFiscal.Orcamento.Cliente.ID & " - " & visitaAtual.NotaFiscal.Orcamento.Cliente.Nome
        DataVisitaTF.Text = visitaAtual.Data
        TipoVisitaCB.Text = visitaAtual.Tipo
        PrecoVisitaTF.Text = visitaAtual.Preco
        ParecerObraVisitaTF.Text = visitaAtual.ParecerObra
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SalvarAlteracoesVisitaBT.Click
        vendaAtual.VisitasTecnicas.Remove(visitaAtual)
        visitaAtual.Data = DataVisitaTF.Text
        visitaAtual.Tipo = TipoVisitaCB.Text
        visitaAtual.Preco = PrecoVisitaTF.Text
        vendaAtual.VisitasTecnicas.Add(visitaAtual)
        VisitaTecnicaBC.DeleteByVenda(vendaAtual)

        For Each visita As VisitaTecnica In vendaAtual.VisitasTecnicas
            VisitaTecnicaBC.Insert(visita)
        Next

        ClearAcompanharVisita()
        RefreshDTVisitas()
        MsgBox("Visita Atualizada com sucesso !!", vbInformation Or vbMsgBoxSetForeground)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        ControleCliente.Show()
    End Sub
End Class