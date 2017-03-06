Public Class LoginUsuario
    Private errorCounter As Integer = 0

    Private Sub LoginUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SQLTableManager.DropRegistrosPontos()
        'SQLTableManager.DropSalarios()
        'SQLTableManager.DropFuncionarios()
        'SQLTableManager.DropFornecedores()
        'SQLTableManager.DropCotacoes()
        'SQLTableManager.DropItensCotados()
        'SQLTableManager.DropAlertas()
        'SQLTableManager.DropProdutos()
        'SQLTableManager.CreateFuncionarios()
        'SQLTableManager.CreateRegistrosPontos()
        'SQLTableManager.CreateSalarios()
        'SQLTableManager.PopulateFuncionarios()
        'SQLTableManager.PopulateRegistrosPontos()
        'SQLTableManager.DropFornecedores()
        'SQLTableManager.CreateFornecedores()
        'SQLTableManager.PopulateFornecedores()
        'SQLTableManager.CreateProdutos()
        'SQLTableManager.CreateCotacoes()
        'SQLTableManager.CreateItensCotados()
        'SQLTableManager.PopulateProdutos()
        'SQLTableManager.CreateAlertas()
    End Sub

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

            If (FuncionarioBC.IsRevogado(funcionario) = True) Then

                MsgBox("Seu acesso está revogado. Solicite uma nova senha ao seu gerente ou entre em contato com o administrador do sistema", vbInformation Or vbMsgBoxSetForeground)

                Exit Sub
            End If

            funcionario.Senha = PasswordTF.Text
            If (FuncionarioBC.VerifyPassword(funcionario) = False) Then
                errorCounter += 1

                If (errorCounter = 3) Then
                    FuncionarioBC.RevogarAcesso(funcionario)
                    MsgBox("Senha incorreta. Após 3 tentativas de acesso sua senha foi revogada. Solicite uma nova senha ao seu gerente ou entre em contato com o administrador do sistema", vbInformation Or vbMsgBoxSetForeground)
                Else
                    MsgBox("Senha incorreta", vbInformation Or vbMsgBoxSetForeground)
                End If

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


    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles EntradaRB.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
            ElseIf (EntradaRB.Checked = False AndAlso SaidaRB.Checked = False) Then
                MsgBox("Favor selecionar se o registro é de entrada ou saída", vbInformation Or vbMsgBoxSetForeground)
                Exit Sub
            End If

            Dim registro As New RegistroPonto(Now, "", funcionario)

            If (EntradaRB.Checked) Then registro.Tipo = TipoRegistro.Entrada
            If (SaidaRB.Checked) Then registro.Tipo = TipoRegistro.Saida

            RegistroPontoBC.Insert(registro)

            MsgBox("Ponto registrado com sucesso", vbInformation Or vbMsgBoxSetForeground)

        Else
            MsgBox("Funcionário não cadastrado", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If (String.IsNullOrWhiteSpace(UserTF.Text)) Then
            MsgBox("Usuário não preenchido", vbInformation Or vbMsgBoxSetForeground)
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
            FuncionarioBC.RevogarAcesso(funcionario)
            MsgBox("Solicitação de senha efetuada, aguarde até que seu supervisor resete e receba a nova senha", vbInformation Or vbMsgBoxSetForeground)
        Else
            MsgBox("Funcionário não cadastrado", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If (String.IsNullOrWhiteSpace(UserTF.Text)) Then
            MsgBox("Usuário não preenchido", vbInformation Or vbMsgBoxSetForeground)
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

            Dim trocarSenha As New TrocarSenha
            trocarSenha.funcionario = funcionario
            trocarSenha.Show()

        Else
            MsgBox("Funcionário não cadastrado", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If
    End Sub
End Class
