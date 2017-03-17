Public Class LoginUsuario
    Implements IMessageFilter 'Allows an application to capture a message before it is dispatched to a control or form

    Private errorCounter As Integer = 0
    Public Shared secondsCount As Integer = 0 'Counts innactivity

    Public Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
        Dim mouse As Boolean = (m.Msg >= &H200 AndAlso m.Msg <= &H20D) OrElse (m.Msg >= &HA0 AndAlso m.Msg <= &HAD) 'Check for mouse movements and / or clicks
        Dim kbd As Boolean = (m.Msg >= &H100 AndAlso m.Msg <= &H109) 'Check for keyboard button presses
        If mouse Or kbd Then secondsCount = 0
        Return False
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If secondsCount > 900 Then '15 Minutes
            Timer1.Enabled = False
            MsgBox("Aplicação será encerrada após 15 minutos de inatividade", vbInformation)
            Application.Exit()
        Else secondsCount += 1
        End If
    End Sub

    Private Sub LoginUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.AddMessageFilter(Me)
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
        'SQLTableManager.DropEnderecosClientes()
        'SQLTableManager.DropClientes()
        'SQLTableManager.DropClientesPF()
        'SQLTableManager.DropClientesPJ()
        'SQLTableManager.CreateClientes()
        'SQLTableManager.CreateClientesPF()
        'SQLTableManager.CreateClientesPJ()
        'SQLTableManager.CreateEnderecosClientes()
        'SQLTableManager.PopulateClientesPF()
        'SQLTableManager.PopulateClientesPJ()
        'SQLTableManager.DropOrcamentos()
        'SQLTableManager.DropItensOrcados()
        'SQLTableManager.CreateOrcamentos()
        'SQLTableManager.CreateItensOrcados()
        'SQLTableManager.DropSalarios()
        'SQLTableManager.CreateSalarios()
        'SQLTableManager.DropItensComprados()
        'SQLTableManager.CreateItensComprados()
        'SQLTableManager.DropSolicitacoesEmprestimos()
        'SQLTableManager.CreateSolicitacoesEmprestimos()
        'SQLTableManager.DropItensEmprestimos()
        'SQLTableManager.CreateItensEmprestimos()
        'SQLTableManager.CreateOrdensServicos()
        'SQLTableManager.CreateItensOrdens()
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles LogarBT.Click

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles RegistrarPontoBT.Click
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

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles EsqueciSenhaLL.LinkClicked
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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AlterarSenhaLL.LinkClicked
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
