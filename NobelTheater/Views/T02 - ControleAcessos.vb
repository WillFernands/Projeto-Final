Public Class ControleAcessos

    Private funcAtual As Funcionario
    Private revogados As List(Of Funcionario)

    Private Sub ControleAcessos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateRevogados()
    End Sub

    Private Sub PopulateRevogados()
        RevogadosDT.Rows.Clear()
        revogados = FuncionarioBC.FindAcessosRevogados(MenuPrincipal.funcionarioLogado)

        For Each revogado As Funcionario In revogados
            Dim list As New List(Of Object)
            list.Add(revogado.Matricula) : list.Add(revogado.Nome) : list.Add(revogado.DataRevogacao) : list.Add("Resetar senha")
            RevogadosDT.Rows.Add(list.ToArray())
        Next
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim busca As New BuscaFuncionario()
        busca.Caller = "ControleAcessos"
        busca.Show()
    End Sub

    Public Sub PopulateFuncionario(func As Funcionario)
        FuncionarioTF.Text = func.Matricula & " - " & func.Nome
        PerfilAtualTF.Text = func.Perfil

        For Each perfil As String In TipoPerfilFuncionario.GetTiposList()
            NovoPerfilCB.Items.Add(perfil)
        Next

        funcAtual = func
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (funcAtual Is Nothing Or String.IsNullOrWhiteSpace(FuncionarioTF.Text)) Then
            MsgBox("Funcionário não selecionado", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(NovoPerfilCB.SelectedItem.ToString)) Then
            MsgBox("Novo perfil não selecionado", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (TipoPerfilFuncionario.GetTiposList.Contains(NovoPerfilCB.SelectedItem.ToString) = False) Then
            MsgBox("Novo perfil inexistente", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If

        funcAtual.Perfil = NovoPerfilCB.SelectedItem.ToString
        FuncionarioBC.Update(funcAtual)
    End Sub

    Private Sub RevogadosDT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles RevogadosDT.CellContentClick
        If (RevogadosDT.SelectedCells.Item(0).Value = "Resetar senha" AndAlso e.ColumnIndex = 3) Then
            Dim funcionario As Funcionario = FuncionarioBC.FindByMatricula(RevogadosDT.Item(0, e.RowIndex).Value)
            Dim novaSenha As String = FuncionarioBC.ResetarSenha(funcionario)
            MsgBox("Senha resetada, a nova do senha do funcionário é: " & novaSenha & ". Informe-a a seu funcionário e em seguida oriente-o a escolher uma nova na opção Alterar Senha", vbInformation Or vbMsgBoxSetForeground)
            PopulateRevogados()
            Exit Sub
        End If
    End Sub
End Class