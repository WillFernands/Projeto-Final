Public Class ControleFornecedor

    
    Private Sub EnderecosDT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EnderecosDT.CellContentClick

    End Sub

    Private Sub ControleFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TipoNovoFornecedorCB.Items.Add(TipoFornecedor.Fornecedor)
        TipoNovoFornecedorCB.Items.Add(TipoFornecedor.FornecedorAssistencia)
        TipoEnderecoNovoFornecedorCB.Items.AddRange(TipoEndereco.GetTiposList().ToArray())

        Dim list As New List(Of Object)
        list.Add("Rua da pátria") : list.Add("320") : list.Add("Agua Verde") : list.Add("Curitiba") : list.Add("PR") : list.Add("81-290-800") : list.Add("Escritório") : list.Add("Remover")
        EnderecosDT.Rows.Add(list.ToArray()) : list.Clear()
        list.Add("Avenida das bandeiras") : list.Add("2150") : list.Add("Cabral") : list.Add("Curitiba") : list.Add("PR") : list.Add("80-400-240") : list.Add("Escritório") : list.Add("Remover")
        EnderecosDT.Rows.Add(list.ToArray()) : list.Clear()
        End Sub

End Class