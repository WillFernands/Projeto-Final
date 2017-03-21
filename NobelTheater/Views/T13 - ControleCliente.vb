Public Class ControleCliente

    Private clientePFAtual As ClientePF
    Private clientePJAtual As ClientePJ

    Private Sub ControleCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NomeTF.Text = "Nome: " & MenuPrincipal.funcionarioLogado.Nome
        MatriculaTF.Text = "Matricula: " & MenuPrincipal.funcionarioLogado.Matricula
        PerfilTF.Text = "Perfil: " & MenuPrincipal.funcionarioLogado.Perfil
    End Sub


    Private Sub NovoClienteTab_Enter(sender As Object, e As EventArgs) Handles NovoClienteTab.Enter
        EstadoNovoClienteCB.Items.Clear()
        EstadoNovoClienteCB.Items.AddRange(EstadosEnum.GetEstadosList().ToArray())
        TipoEnderecoNovoClienteCB.Items.Clear()
        TipoEnderecoNovoClienteCB.Items.AddRange(TipoEndereco.GetTiposList().ToArray())
    End Sub

    Private Sub AcompanharClienteTab_Enter(sender As Object, e As EventArgs) Handles AcompanharClienteTab.Enter
        EstadoAcompanharClienteCB.Items.Clear()
        EstadoAcompanharClienteCB.Items.AddRange(EstadosEnum.GetEstadosList().ToArray())
        TipoEnderecoAcompanharClienteCB.Items.Clear()
        TipoEnderecoAcompanharClienteCB.Items.AddRange(TipoEndereco.GetTiposList().ToArray())
    End Sub

    Private Sub PessoaFisicaRB_CheckedChanged(sender As Object, e As EventArgs) Handles PessoaFisicaRB.CheckedChanged
        If (PessoaFisicaRB.Checked) Then
            RazaoSocialNovoClienteLB.Visible = False
            RazaoSocialNovoClienteTF.Visible = False
            RazaoSocialNovoClienteTF.Text = ""
            DocumentoNovoClienteLB.Text = "CPF:"
        End If
    End Sub

    Private Sub PessoaJuridicaRB_CheckedChanged(sender As Object, e As EventArgs) Handles PessoaJuridicaRB.CheckedChanged
        If (PessoaJuridicaRB.Checked) Then
            RazaoSocialNovoClienteLB.Visible = True
            RazaoSocialNovoClienteTF.Visible = True
            DocumentoNovoClienteLB.Text = "CNPJ:"
        End If
    End Sub

    Private Sub LimparNovoClienteBT_Click(sender As Object, e As EventArgs) Handles LimparNovoClienteBT.Click
        ClearNovoCliente()
    End Sub

    Private Sub ClearNovoCliente()
        RazaoSocialNovoClienteTF.Text = ""
        NomeNovoClienteTF.Text = ""
        TelefoneNovoClienteTF.Text = ""
        DocumentoNovoClienteMTF.Text = ""
        LogradouroNovoClienteTF.Text = ""
        NumeroNovoClienteTF.Text = ""
        BairroNovoClienteTF.Text = ""
        CidadeNovoClienteTF.Text = ""
        EstadoNovoClienteCB.Text = ""
        CEPNovoClienteMTF.Text = ""
        TipoEnderecoNovoClienteCB.Text = ""
    End Sub

    Private Sub SalvarNovoClienteBT_Click(sender As Object, e As EventArgs) Handles SalvarNovoClienteBT.Click
        If (PessoaJuridicaRB.Checked) Then
            If (String.IsNullOrWhiteSpace(RazaoSocialNovoClienteTF.Text)) Then
                MsgBox("Razão Social do cliente não preenchido", vbInformation Or vbMsgBoxSetForeground)
                Exit Sub
            End If
        End If

        If (String.IsNullOrWhiteSpace(NomeNovoClienteTF.Text)) Then
            MsgBox("Nome do cliente não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(TelefoneNovoClienteTF.Text)) Then
            MsgBox("Telefone do cliente não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(DocumentoNovoClienteMTF.Text)) Then
            If (PessoaJuridicaRB.Checked) Then
                MsgBox("CNPJ do cliente não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Else MsgBox("CPF do cliente não preenchido", vbInformation Or vbMsgBoxSetForeground)
            End If
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(LogradouroNovoClienteTF.Text)) Then
            MsgBox("Logradouro do endereço não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(NumeroNovoClienteTF.Text)) Then
            MsgBox("Número do endereço não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(CidadeNovoClienteTF.Text)) Then
            MsgBox("Cidade do endereço não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(EstadoNovoClienteCB.Text)) Then
            MsgBox("Estado do endereço não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(CEPNovoClienteMTF.Text)) Then
            MsgBox("CEP do endereço não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(TipoEnderecoNovoClienteCB.Text)) Then
            MsgBox("Tipo do endereço não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If

        Dim endereco As EnderecoCliente

        If (PessoaJuridicaRB.Checked) Then
            Dim clientepj As New ClientePJ(NomeNovoClienteTF.Text, TelefoneNovoClienteTF.Text, Now, DocumentoNovoClienteMTF.Text, RazaoSocialNovoClienteTF.Text)
            ClientePJBC.Insert(clientepj)
            endereco = New EnderecoCliente(clientepj, LogradouroNovoClienteTF.Text, NumeroNovoClienteTF.Text, BairroNovoClienteTF.Text, CidadeNovoClienteTF.Text, EstadoNovoClienteCB.Text, CEPNovoClienteMTF.Text, TipoEnderecoNovoClienteCB.Text)
        Else
            Dim clientepf As New ClientePF(NomeNovoClienteTF.Text, TelefoneNovoClienteTF.Text, Now, DocumentoNovoClienteMTF.Text)
            ClientePFBC.Insert(clientepf)
            endereco = New EnderecoCliente(clientepf, LogradouroNovoClienteTF.Text, NumeroNovoClienteTF.Text, BairroNovoClienteTF.Text, CidadeNovoClienteTF.Text, EstadoNovoClienteCB.Text, CEPNovoClienteMTF.Text, TipoEnderecoNovoClienteCB.Text)
        End If

        EnderecoClienteBC.Insert(endereco)

        MsgBox("Inclusão de cliente realizada com sucesso.", vbInformation Or vbMsgBoxSetForeground)
        ClearNovoCliente()
    End Sub

    Private Sub SelecionarClienteIMG_Click(sender As Object, e As EventArgs) Handles SelecionarClienteIMG.Click
        Dim busca As New BuscaCliente()
        busca.Caller = "ControleCliente"
        busca.Show()
    End Sub

    Public Sub PopulateCliente(cliente As ClientePF)
        ClearAcompanharCliente()

        NomeAcompanharClienteTF.Enabled = True
        TelefoneAcompanharClienteTF.Enabled = True
        LogradouroAcompanharClienteTF.Enabled = True
        NumeroAcompanharClienteTF.Enabled = True
        BairroAcompanharClienteTF.Enabled = True
        CidadeAcompanharClienteTF.Enabled = True
        EstadoAcompanharClienteCB.Enabled = True
        CEPAcompanharClienteTF.Enabled = True
        TipoEnderecoAcompanharClienteCB.Enabled = True

        clientePFAtual = cliente
        ClienteTF.Text = cliente.CPF & " - " & cliente.Nome
        NomeAcompanharClienteTF.Text = cliente.Nome
        TelefoneAcompanharClienteTF.Text = cliente.Telefone
        DocumentoAcompanharClienteTF.Text = cliente.CPF
        LogradouroAcompanharClienteTF.Text = cliente.Enderecos.Item(0).Logradouro
        NumeroAcompanharClienteTF.Text = cliente.Enderecos.Item(0).Numero
        BairroAcompanharClienteTF.Text = cliente.Enderecos.Item(0).Bairro
        CidadeAcompanharClienteTF.Text = cliente.Enderecos.Item(0).Cidade
        EstadoAcompanharClienteCB.Text = cliente.Enderecos.Item(0).Estado
        CEPAcompanharClienteTF.Text = cliente.Enderecos.Item(0).Cep
        TipoEnderecoAcompanharClienteCB.Text = cliente.Enderecos.Item(0).Tipo
    End Sub

    Public Sub PopulateCliente(cliente As ClientePJ)
        ClearAcompanharCliente()
        clientePJAtual = cliente
        RazaoSocialAcompanharClienteTF.Enabled = True
        NomeAcompanharClienteTF.Enabled = True
        TelefoneAcompanharClienteTF.Enabled = True
        LogradouroAcompanharClienteTF.Enabled = True
        NumeroAcompanharClienteTF.Enabled = True
        BairroAcompanharClienteTF.Enabled = True
        CidadeAcompanharClienteTF.Enabled = True
        EstadoAcompanharClienteCB.Enabled = True
        CEPAcompanharClienteTF.Enabled = True
        TipoEnderecoAcompanharClienteCB.Enabled = True

        ClienteTF.Text = cliente.CNPJ & " - " & cliente.Nome
        RazaoSocialAcompanharClienteTF.Text = cliente.RazaoSocial
        RazaoSocialAcompanharClienteLB.Visible = True
        RazaoSocialAcompanharClienteTF.Visible = True
        NomeAcompanharClienteTF.Text = cliente.Nome
        TelefoneAcompanharClienteTF.Text = cliente.Telefone
        DocumentoAcompanharClienteTF.Text = cliente.CNPJ
        DocumentoAcompanharClienteLB.Text = "CNPJ:"
        LogradouroAcompanharClienteTF.Text = cliente.Enderecos.Item(0).Logradouro
        NumeroAcompanharClienteTF.Text = cliente.Enderecos.Item(0).Numero
        BairroAcompanharClienteTF.Text = cliente.Enderecos.Item(0).Bairro
        CidadeAcompanharClienteTF.Text = cliente.Enderecos.Item(0).Cidade
        EstadoAcompanharClienteCB.Text = cliente.Enderecos.Item(0).Estado
        CEPAcompanharClienteTF.Text = cliente.Enderecos.Item(0).Cep
        TipoEnderecoAcompanharClienteCB.Text = cliente.Enderecos.Item(0).Tipo
    End Sub

    Private Sub SalvarAcompanharClienteBT_Click(sender As Object, e As EventArgs) Handles SalvarAcompanharClienteBT.Click
        If (clientePJAtual IsNot Nothing) Then
            If (String.IsNullOrWhiteSpace(RazaoSocialAcompanharClienteTF.Text)) Then
                MsgBox("Razão Social do cliente não preenchido", vbInformation Or vbMsgBoxSetForeground)
                Exit Sub
            End If
        End If

        If (String.IsNullOrWhiteSpace(NomeAcompanharClienteTF.Text)) Then
            MsgBox("Nome do cliente não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(TelefoneAcompanharClienteTF.Text)) Then
            MsgBox("Telefone do cliente não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(DocumentoAcompanharClienteTF.Text)) Then
            If (PessoaJuridicaRB.Checked) Then
                MsgBox("CNPJ do cliente não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Else MsgBox("CPF do cliente não preenchido", vbInformation Or vbMsgBoxSetForeground)
            End If
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(LogradouroAcompanharClienteTF.Text)) Then
            MsgBox("Logradouro do endereço não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(NumeroAcompanharClienteTF.Text)) Then
            MsgBox("Número do endereço não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(CidadeAcompanharClienteTF.Text)) Then
            MsgBox("Cidade do endereço não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(EstadoAcompanharClienteCB.Text)) Then
            MsgBox("Estado do endereço não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(CEPAcompanharClienteTF.Text)) Then
            MsgBox("CEP do endereço não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(TipoEnderecoAcompanharClienteCB.Text)) Then
            MsgBox("Tipo do endereço não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If

        If (clientePFAtual IsNot Nothing) Then
            clientePFAtual.Nome = NomeAcompanharClienteTF.Text
            clientePFAtual.Telefone = TelefoneAcompanharClienteTF.Text
            clientePFAtual.CPF = DocumentoAcompanharClienteTF.Text
            clientePFAtual.Enderecos.Item(0).Logradouro = LogradouroAcompanharClienteTF.Text
            clientePFAtual.Enderecos.Item(0).Numero = NumeroAcompanharClienteTF.Text
            clientePFAtual.Enderecos.Item(0).Bairro = BairroAcompanharClienteTF.Text
            clientePFAtual.Enderecos.Item(0).Cidade = CidadeAcompanharClienteTF.Text
            clientePFAtual.Enderecos.Item(0).Estado = EstadoAcompanharClienteCB.Text
            clientePFAtual.Enderecos.Item(0).Cep = CEPAcompanharClienteTF.Text
            clientePFAtual.Enderecos.Item(0).Tipo = TipoEnderecoAcompanharClienteCB.Text


            If (ClientePFBC.Update(clientePFAtual) = False) Then
                MsgBox("Um problema ocorreu durante a atualização do cliente", vbInformation Or vbMsgBoxSetForeground)
                Exit Sub
            End If

            If (EnderecoClienteBC.Update(clientePFAtual.Enderecos.Item(0)) = False) Then
                MsgBox("Um problema ocorreu durante a atualização do endereço do cliente", vbInformation Or vbMsgBoxSetForeground)
                Exit Sub
            End If

        ElseIf (clientePJAtual IsNot Nothing) Then

            clientePJAtual.RazaoSocial = RazaoSocialAcompanharClienteTF.Text
            clientePJAtual.Nome = NomeAcompanharClienteTF.Text
            clientePJAtual.Telefone = TelefoneAcompanharClienteTF.Text
            clientePJAtual.CNPJ = DocumentoAcompanharClienteTF.Text
            clientePJAtual.Enderecos.Item(0).Logradouro = LogradouroAcompanharClienteTF.Text
            clientePJAtual.Enderecos.Item(0).Numero = NumeroAcompanharClienteTF.Text
            clientePJAtual.Enderecos.Item(0).Bairro = BairroAcompanharClienteTF.Text
            clientePJAtual.Enderecos.Item(0).Cidade = CidadeAcompanharClienteTF.Text
            clientePJAtual.Enderecos.Item(0).Estado = EstadoAcompanharClienteCB.Text
            clientePJAtual.Enderecos.Item(0).Cep = CEPAcompanharClienteTF.Text
            clientePJAtual.Enderecos.Item(0).Tipo = TipoEnderecoAcompanharClienteCB.Text

            If (ClientePJBC.Update(clientePJAtual) = False) Then
                MsgBox("Um problema ocorreu durante a atualização do cliente", vbInformation Or vbMsgBoxSetForeground)
                Exit Sub
            End If

            If (EnderecoClienteBC.Update(clientePJAtual.Enderecos.Item(0)) = False) Then
                MsgBox("Um problema ocorreu durante a atualização do endereço do cliente", vbInformation Or vbMsgBoxSetForeground)
                Exit Sub
            End If

        Else Exit Sub
        End If
        MsgBox("Cliente atualizado com sucesso", vbInformation Or vbMsgBoxSetForeground)
        ClearAcompanharCliente()
    End Sub

    Private Sub ClearAcompanharCliente()
        clientePFAtual = Nothing
        clientePJAtual = Nothing
        ClienteTF.Text = ""
        RazaoSocialAcompanharClienteTF.Text = ""
        RazaoSocialAcompanharClienteLB.Visible = False
        RazaoSocialAcompanharClienteTF.Visible = False
        NomeAcompanharClienteTF.Text = ""
        TelefoneAcompanharClienteTF.Text = ""
        DocumentoAcompanharClienteTF.Text = ""
        DocumentoAcompanharClienteLB.Text = "CPF:"
        LogradouroAcompanharClienteTF.Text = ""
        NumeroAcompanharClienteTF.Text = ""
        BairroAcompanharClienteTF.Text = ""
        CidadeAcompanharClienteTF.Text = ""
        EstadoAcompanharClienteCB.Text = ""
        CEPAcompanharClienteTF.Text = ""
        TipoEnderecoAcompanharClienteCB.Text = ""
    End Sub
End Class