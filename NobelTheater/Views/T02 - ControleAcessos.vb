Public Class ControleAcessos

    Private funcAtual As Funcionario

    Private Sub ControleAcessos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim revogados As List(Of Funcionario) = FuncionarioBC.FindAcessosRevogados(funcAtual)

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
End Class