Public Class BuscaFuncionario
    Public Shared Caller As String
    Private funcionarioBC As New FuncionarioBC

    Private Sub BuscaFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim funcionarios As List(Of Funcionario) = FuncionarioBC.FindBySupervisor(MenuPrincipal.funcionarioLogado)
        ListBox1.DataSource = funcionarios
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        Dim funcionario As Funcionario = DirectCast(ListBox1.SelectedItem, Funcionario)
    End Sub
End Class