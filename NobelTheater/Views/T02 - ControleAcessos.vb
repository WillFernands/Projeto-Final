Public Class ControleAcessos

    Private funcAtual As Funcionario

    Private Sub ControleAcessos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim list As New List(Of Object)
        list.Add("02500") : list.Add("Bruno das Neves") : list.Add("15/04/2016") : list.Add("Resetar senha")
        RevogadosDT.Rows.Add(list.ToArray()) : list.Clear()
        list.Add("02515") : list.Add("Alisson Jr.") : list.Add("22/05/2016") : list.Add("Resetar senha")
        RevogadosDT.Rows.Add(list.ToArray()) : list.Clear()
        list.Add("02543") : list.Add("Bruna Oliveira") : list.Add("01/07/2016") : list.Add("Resetar senha")
        RevogadosDT.Rows.Add(list.ToArray()) : list.Clear()
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