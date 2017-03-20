Public Class VerItensOrdem

    Public OrdemAtual As OrdemServico
    Private itemAtual As ItemOrdem

    Private Sub VerItensOrdem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDTProdutos()
    End Sub

    Private Sub RefreshDTProdutos()
        ProdutosDT.Rows.Clear()

        For Each item As ItemOrdem In OrdemAtual.ItensOrdem
            Dim list As New List(Of Object)
            list.Add(item.Produto.Codigo) : list.Add(item.Produto.Nome) : list.Add(item.Produto.Descricao) : list.Add(item.Quantidade)
            If (item.DataEntrega = Nothing) Then
                list.Add("A informar")
            Else list.Add(item.DataEntrega)
            End If
            If (item.DataRecebimento = Nothing) Then
                list.Add("A informar")
            Else list.Add(item.DataRecebimento)
            End If
            If (item.DataDevolucao = Nothing) Then
                list.Add("A informar")
            Else list.Add(item.DataDevolucao)
            End If
            ProdutosDT.Rows.Add(list.ToArray())
        Next

        ProdutosDT.Sort(ProdutosDT.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub AtualizarProdutoIMG_Click(sender As Object, e As EventArgs) Handles AtualizarProdutoIMG.Click
        Dim item = OrdemAtual.ItensOrdem.Find(Function(itemOrdem As ItemOrdem) itemOrdem.Produto.Codigo = itemAtual.Produto.Codigo)
        OrdemAtual.ItensOrdem.Remove(item)
        If (String.IsNullOrWhiteSpace(DataDevolucaoTF.Text) = False) Then
            itemAtual.DataDevolucao = CDate(DataDevolucaoTF.Text)
        End If
        If (String.IsNullOrWhiteSpace(DataRecebimentoTF.Text) = False) Then
            itemAtual.DataRecebimento = CDate(DataRecebimentoTF.Text)
        End If
        OrdemAtual.ItensOrdem.Add(itemAtual)
        OrdemAtual.ItensOrdem.Sort()
        DataRecebimentoTF.Text = ""
        DataDevolucaoTF.Text = ""
        CodigoAtualTF.Text = ""
        DataEntregaTF.Text = ""
        RefreshDTProdutos()
    End Sub

    Private Sub SalvarItensBT_Click(sender As Object, e As EventArgs) Handles SalvarItensBT.Click
        ItemOrdemBC.DeleteByOrdem(OrdemAtual)
        For Each item As ItemOrdem In OrdemAtual.ItensOrdem
            ItemOrdemBC.Insert(item)
            ItemOrdemBC.UpdateDatas(item)
        Next
        MsgBox("Itens atualizados", vbMsgBoxSetForeground Or vbInformation)
    End Sub

    Private Sub ProdutosDT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProdutosDT.CellContentClick
        If (ProdutosDT.SelectedCells Is Nothing OrElse e.ColumnIndex = -1) Then Exit Sub
        itemAtual = OrdemAtual.ItensOrdem.Find(Function(itemOrdem As ItemOrdem) itemOrdem.Produto.Codigo = ProdutosDT.Item(0, e.RowIndex).Value)
        DataEntregaTF.Text = itemAtual.DataEntrega
        CodigoAtualTF.Text = itemAtual.Produto.Codigo
        If (itemAtual.DataRecebimento <> Nothing) Then DataRecebimentoTF.Text = itemAtual.DataRecebimento
        If (itemAtual.DataDevolucao <> Nothing) Then DataDevolucaoTF.Text = itemAtual.DataDevolucao
    End Sub

End Class