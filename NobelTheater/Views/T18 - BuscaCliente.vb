Public Class BuscaCliente
    Public Caller As String
    Private clientePFBC As New ClientePFBC
    Private clientePJBC As New ClientePJBC
    Private clientesPF As List(Of ClientePF)
    Private clientesPJ As List(Of ClientePJ)

    Private Sub BuscaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateLists()
    End Sub

    Private Sub PFRB_CheckedChanged(sender As Object, e As EventArgs) Handles PFRB.CheckedChanged
        UpdateLists()
    End Sub

    Private Sub PJRB_CheckedChanged(sender As Object, e As EventArgs) Handles PJRB.CheckedChanged
        UpdateLists()
    End Sub

    Private Sub PopulateListPF()
        ListBox1.Items.Clear()

        For Each cli As ClientePF In clientesPF
            ListBox1.Items.Add(cli.ID & " - " & cli.CPF & " - " & cli.Nome)
        Next
    End Sub

    Private Sub PopulateListPJ()
        ListBox1.Items.Clear()

        For Each cli As ClientePJ In clientesPJ
            ListBox1.Items.Add(cli.ID & " - " & cli.CNPJ & " - " & cli.Nome)
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick

        If (ListBox1.SelectedItem Is Nothing) Then Exit Sub

        Dim id As Long = CLng(Trim(DirectCast(ListBox1.SelectedItem, String).Split("-")(0)))

        If (PFRB.Checked) Then
            Dim clientePF As ClientePF = clientesPF.Find(Function(cli As Cliente) cli.ID = id)
            If (Caller = "ControleVenda") Then
                ControleVendas.PopulateCliente(clientePF)
                Me.Close()
            ElseIf (Caller = "ControleEstoqueEmprestarProduto") Then
                ControleEstoque.PopulateClienteEmprestarProduto(clientePF)
                Me.Close()
            End If
        ElseIf (PJRB.Checked) Then
            Dim clientePJ As ClientePJ = clientesPJ.Find(Function(cli As Cliente) cli.ID = id)
            If (Caller = "ControleVenda") Then
                ControleVendas.PopulateCliente(clientePJ)
                Me.Close()
            ElseIf (Caller = "ControleEstoqueEmprestarProduto") Then
                ControleEstoque.PopulateClienteEmprestarProduto(clientePJ)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If (PFRB.Checked) Then : PopulateListPF()
        Else : PopulateListPJ()
        End If

Back:   For Each item As String In ListBox1.Items
            If (item.Contains(TextBox1.Text) = False) Then
                ListBox1.Items.Remove(item)
                GoTo Back
            End If
        Next
    End Sub

    Private Sub UpdateLists()
        If (PFRB.Checked) Then
            clientesPF = ClientePFBC.FindAll()
            PopulateListPF()
        Else
            clientesPJ = ClientePJBC.FindAll()
            PopulateListPJ()
        End If
    End Sub

End Class