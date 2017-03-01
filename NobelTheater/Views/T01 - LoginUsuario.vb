Public Class LoginUsuario

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click


        If (String.IsNullOrWhiteSpace(UserTF.Text)) Then
            MsgBox("Usuário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(PasswordTF.Text)) Then
            MsgBox("Senha não preenchida", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If

        Dim funcionario As Funcionario

        Try
            funcionario = FuncionarioBC.FindByMatricula(CLng(UserTF.Text))
        Catch ex As InvalidCastException
            MsgBox("Matricula invalida", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End Try

        If (funcionario IsNot Nothing) Then
            funcionario.Senha = PasswordTF.Text
            If (FuncionarioBC.VerifyPassword(funcionario) = False) Then
                MsgBox("Senha incorreta", vbInformation Or vbMsgBoxSetForeground)
                Exit Sub
            End If
            MenuPrincipal.funcionarioLogado = funcionario
            MenuPrincipal.Show()
            Me.Close()
        Else
            MsgBox("Funcionário não cadastrado", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If
    End Sub

    Private Sub LoginUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub
End Class
