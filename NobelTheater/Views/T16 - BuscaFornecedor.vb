Public Class BuscaFornecedor
    Public Caller As String
    Private fornecedorBC As New FornecedorBC

    Private fornecedores As List(Of Fornecedor)

    Private Sub BuscaFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fornecedores = FornecedorBC.FindAll()
        PopulateList()
    End Sub

    Private Sub PopulateList()
        ListBox1.Items.Clear()

        For Each forn As Fornecedor In fornecedores
            ListBox1.Items.Add(forn.Cnpj & " - " & forn.NomeFantasia)
        Next

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick

        If (ListBox1.SelectedItem Is Nothing) Then Exit Sub

        Dim cnpj As String = Trim(DirectCast(ListBox1.SelectedItem, String).Split("-")(0)).ToString

        Dim fornecedor As Fornecedor = fornecedores.Find(Function(forn As Fornecedor) forn.Cnpj = cnpj)

        If (Caller = "ControleEstoque") Then
            ControleEstoque.PopulateFornecedor(fornecedor)
            Me.Close()
        ElseIf (Caller = "ControleFornecedorAcompanharFornecedor") Then
            ControleFornecedor.PopulateFornecedorAcompanharFornecedor(fornecedor)
            Me.Close()
        ElseIf (Caller = "ControleFornecedorNovaAssistencia") Then
            ControleFornecedor.PopulateFornecedorNovaAssistencia(fornecedor)
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