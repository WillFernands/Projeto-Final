Public Class AlterarSenha

    Public funcionario As Funcionario

    Private Sub AlterarSenha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserTF.Text = funcionario.Matricula & " - " & funcionario.Nome
    End Sub

    Private Sub ConfirmarBT_Click(sender As Object, e As EventArgs) Handles ConfirmarBT.Click
        If (String.IsNullOrWhiteSpace(UserTF.Text)) Then
            MsgBox("Usuário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(PasswordTF.Text)) Then
            MsgBox("Senha não preenchida", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(PasswordNewTF.Text)) Then
            MsgBox("Nova senha não preenchida", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(ConfirmPasswordNewTF.Text)) Then
            MsgBox("Nova senha não confirmada", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (PasswordNewTF.Text.Equals(ConfirmPasswordNewTF.Text) = False) Then
            MsgBox("Nova senha e confirmação estão divergentes", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If

        If (funcionario IsNot Nothing) Then

            If (FuncionarioBC.IsRevogado(funcionario) = True) Then
                MsgBox("Seu acesso está revogado. Solicite uma nova senha ao seu gerente ou entre em contato com o administrador do sistema", vbInformation Or vbMsgBoxSetForeground)
                Exit Sub
            End If

            funcionario.Senha = PasswordTF.Text
            If (FuncionarioBC.VerifyPassword(funcionario) = False) Then
                MsgBox("Senha incorreta", vbInformation Or vbMsgBoxSetForeground)
                Exit Sub
            End If

            funcionario.Senha = PasswordNewTF.Text

            FuncionarioBC.UpdateSenha(funcionario)

            MsgBox("Senha alterada com sucesso", vbInformation Or vbMsgBoxSetForeground)
            Me.Close()
        Else
            MsgBox("Funcionário não cadastrado", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If
    End Sub
End Class