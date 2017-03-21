Public Class BuscaFuncionario
    Public Caller As String
    Private funcionarioBC As New FuncionarioBC

    Private funcionarios As List(Of Funcionario)

    Private Sub BuscaFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Caller = "ControleAcessos" OrElse Caller = "RecuperarHistorico" OrElse Caller = "ControleFuncionario") Then
            funcionarios = FuncionarioBC.FindBySupervisor(MenuPrincipal.funcionarioLogado)
        ElseIf (Caller = "NovoFuncionario") Then
            funcionarios = FuncionarioBC.FindAll()
        ElseIf (Caller = "SupervisorCriarVisita") Then
            funcionarios = FuncionarioBC.FindAll().FindAll(Function(func As Funcionario) func.Perfil = TipoPerfilFuncionario.SupervisorObra)
        End If
        PopulateList()
    End Sub

    Private Sub PopulateList()
        ListBox1.Items.Clear()

        For Each func As Funcionario In funcionarios
            ListBox1.Items.Add(func.Matricula & " - " & func.Nome)
        Next

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick

        If (ListBox1.SelectedItem Is Nothing) Then Exit Sub

        Dim matricula As Long = CLng(Trim(DirectCast(ListBox1.SelectedItem, String).Split("-")(0)))

        Dim funcionario As Funcionario = funcionarios.Find(Function(func As Funcionario) func.Matricula = matricula)

        If (Caller = "ControleAcessos") Then
            ControleAcessos.PopulateFuncionario(funcionario)
            Me.Close()
        ElseIf (Caller = "RecuperarHistorico") Then
            RecuperarHistorico.PopulateFuncionario(funcionario)
            Me.Close()
        ElseIf (Caller = "NovoFuncionario") Then
            ControleFuncionario.PopulateSupervisor(funcionario)
            Me.Close()
        ElseIf (Caller = "ControleFuncionario") Then
            ControleFuncionario.PopulateFuncionario(funcionario)
            Me.Close()
        ElseIf (Caller = "SupervisorCriarVisita") Then
            CriarVisitaTecnica.PopulateSupervisor(funcionario)
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