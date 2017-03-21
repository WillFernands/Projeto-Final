Public Class ControleFornecedor

    Private fornecedorAtual As Fornecedor
    Private fornecedorAtualNovaAssistencia As Fornecedor
    Private assistenciaAtual As Fornecedor
    Private fornecedorVincular As Fornecedor

    Private Sub ControleFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NomeTF.Text = "Nome: " & MenuPrincipal.funcionarioLogado.Nome
        MatriculaTF.Text = "Matricula: " & MenuPrincipal.funcionarioLogado.Matricula
        PerfilTF.Text = "Perfil: " & MenuPrincipal.funcionarioLogado.Perfil
        TipoNovoFornecedorCB.Items.Add(TipoFornecedor.Fornecedor)
        TipoNovoFornecedorCB.Items.Add(TipoFornecedor.FornecedorAssistencia)
        TipoEnderecoNovoFornecedorCB.Items.AddRange(TipoEndereco.GetTiposList().ToArray())
        TipoFornecedorAcompanharFornecedorCB.Items.AddRange(TipoFornecedor.GetTiposList().ToArray())
        TipoEnderecoAcompanharFornecedorCB.Items.AddRange(TipoEndereco.GetTiposList().ToArray())
        TipoEnderecoNovaAssistenciaCB.Items.AddRange(TipoEndereco.GetTiposList().ToArray())
        EstadoCB.Items.AddRange(EstadosEnum.GetEstadosList().ToArray())
        EstadoNovaAssistenciaCB.Items.AddRange(EstadosEnum.GetEstadosList().ToArray())
        EstadoAcompanharFornecedorCB.Items.AddRange(EstadosEnum.GetEstadosList().ToArray())
    End Sub

    Private Sub LimparNovoFornecedorBT_Click(sender As Object, e As EventArgs) Handles LimparNovoFornecedorBT.Click
        LimparCampos()
    End Sub

    Private Sub LimparCampos()
        CNPJNovoFornecedorMTF.Text = ""
        RazaoSociaNovoFornecedorTF.Text = ""
        FantasiaNovoFornecedorTF.Text = ""
        TelefoneNovoFornecedorMTF.Text = ""
        TipoNovoFornecedorCB.Text = ""
        LogradouroNovoFornecedorTF.Text = ""
        NumeroNovoFornecedorTF.Text = ""
        BairroTF.Text = ""
        CidadeTF.Text = ""
        EstadoCB.Text = ""
        CEPNovoFornecedorMTF.Text = ""
        TipoEnderecoNovoFornecedorCB.Text = ""
    End Sub

    Private Sub SalvarNovoFornecedorBT_Click(sender As Object, e As EventArgs) Handles SalvarNovoFornecedorBT.Click
        If (String.IsNullOrWhiteSpace(CNPJNovoFornecedorMTF.Text)) Then
            MsgBox("CNPJ do fornecedor não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(RazaoSociaNovoFornecedorTF.Text)) Then
            MsgBox("Razão social do fornecedor não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(FantasiaNovoFornecedorTF.Text)) Then
            MsgBox("Nome fantasia do fornecedor não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(TelefoneNovoFornecedorMTF.Text)) Then
            MsgBox("Telefone do fornecedor não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(TipoNovoFornecedorCB.Text)) Then
            MsgBox("Tipo do fornecedor não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(LogradouroNovoFornecedorTF.Text)) Then
            MsgBox("Logradouro do endereço do fornecedor não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(NumeroNovoFornecedorTF.Text)) Then
            MsgBox("Numero do endereço do fornecedor não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(CidadeTF.Text)) Then
            MsgBox("Cidade do endereço do fornecedor não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(EstadoCB.Text)) Then
            MsgBox("Estado do endereço do fornecedor não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(CEPNovoFornecedorMTF.Text)) Then
            MsgBox("CEP do endereço do fornecedor não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(TipoEnderecoNovoFornecedorCB.Text)) Then
            MsgBox("Tipo do endereço do fornecedor não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If

        Dim fornecedor As New Fornecedor(CNPJNovoFornecedorMTF.Text, RazaoSociaNovoFornecedorTF.Text, FantasiaNovoFornecedorTF.Text, TelefoneNovoFornecedorMTF.Text, Now, TipoNovoFornecedorCB.Text, LogradouroNovoFornecedorTF.Text, NumeroNovoFornecedorTF.Text, BairroTF.Text, CidadeTF.Text, EstadoCB.Text, CEPNovoFornecedorMTF.Text, TipoEnderecoNovoFornecedorCB.Text)
        FornecedorBC.Insert(fornecedor)

        MsgBox("Inclusão de fornecedor realizada com sucesso.", vbInformation Or vbMsgBoxSetForeground)
        LimparCampos()
    End Sub

    Private Sub SelecionarFornecedorAcompanharFornecedorIMG_Click(sender As Object, e As EventArgs) Handles SelecionarFornecedorAcompanharFornecedorIMG.Click
        Dim busca As New BuscaFornecedor()
        busca.Caller = "ControleFornecedorAcompanharFornecedor"
        busca.Show()
    End Sub

    Public Sub PopulateFornecedorAcompanharFornecedor(fornecedor As Fornecedor)
        fornecedorAtual = fornecedor
        FornecedorAcompanharFornecedorTF.Text = fornecedorAtual.Cnpj & " - " & fornecedorAtual.NomeFantasia

        RazaoAcompanharFornecedorTF.Enabled = True
        FantasiaAcompanharFornecedorTF.Enabled = True
        TelefoneAcompanharFornecedorMTF.Enabled = True
        TipoFornecedorAcompanharFornecedorCB.Enabled = True
        LogradouroAcompanharFornecedorTF.Enabled = True
        NumeroAcompanharFornecedorTF.Enabled = True
        BairroAcompanharFornecedorTF.Enabled = True
        CidadeAcompanharFornecedorTF.Enabled = True
        EstadoAcompanharFornecedorCB.Enabled = True
        CEPAcompanharFornecedorMTF.Enabled = True
        TipoEnderecoAcompanharFornecedorCB.Enabled = True

        CNPJAcompanharFornecedorMTF.Text = fornecedorAtual.Cnpj
        RazaoAcompanharFornecedorTF.Text = fornecedorAtual.RazaoSocial
        FantasiaAcompanharFornecedorTF.Text = fornecedorAtual.NomeFantasia
        TelefoneAcompanharFornecedorMTF.Text = fornecedorAtual.Telefone
        TipoFornecedorAcompanharFornecedorCB.Text = fornecedorAtual.TipoFornecedor
        LogradouroAcompanharFornecedorTF.Text = fornecedorAtual.Logradouro
        NumeroAcompanharFornecedorTF.Text = fornecedorAtual.Numero
        BairroAcompanharFornecedorTF.Text = fornecedorAtual.Bairro
        CidadeAcompanharFornecedorTF.Text = fornecedorAtual.Cidade
        EstadoAcompanharFornecedorCB.Text = fornecedorAtual.Estado
        CEPAcompanharFornecedorMTF.Text = fornecedorAtual.Cep
        TipoEnderecoAcompanharFornecedorCB.Text = fornecedorAtual.TipoEndereco

    End Sub

    Private Sub SalvarAcompanharFornecedorBT_Click(sender As Object, e As EventArgs) Handles SalvarAcompanharFornecedorBT.Click
        If (String.IsNullOrWhiteSpace(RazaoAcompanharFornecedorTF.Text)) Then
            MsgBox("Razão social do fornecedor não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(FantasiaAcompanharFornecedorTF.Text)) Then
            MsgBox("Nome fantasia do fornecedor não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(TelefoneAcompanharFornecedorMTF.Text)) Then
            MsgBox("Telefone do fornecedor não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(TipoFornecedorAcompanharFornecedorCB.Text)) Then
            MsgBox("Tipo do fornecedor não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(LogradouroAcompanharFornecedorTF.Text)) Then
            MsgBox("Logradouro do endereço do fornecedor não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(NumeroAcompanharFornecedorTF.Text)) Then
            MsgBox("Numero do endereço do fornecedor não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(CidadeAcompanharFornecedorTF.Text)) Then
            MsgBox("Cidade do endereço do fornecedor não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(EstadoAcompanharFornecedorCB.Text)) Then
            MsgBox("Estado do endereço do fornecedor não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(CEPAcompanharFornecedorMTF.Text)) Then
            MsgBox("CEP do endereço do fornecedor não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(TipoEnderecoAcompanharFornecedorCB.Text)) Then
            MsgBox("Tipo do endereço do fornecedor não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If

        fornecedorAtual.RazaoSocial = RazaoAcompanharFornecedorTF.Text
        fornecedorAtual.NomeFantasia = FantasiaAcompanharFornecedorTF.Text
        fornecedorAtual.Telefone = TelefoneAcompanharFornecedorMTF.Text
        fornecedorAtual.TipoFornecedor = TipoFornecedorAcompanharFornecedorCB.Text
        fornecedorAtual.Logradouro = LogradouroAcompanharFornecedorTF.Text
        fornecedorAtual.Numero = NumeroAcompanharFornecedorTF.Text
        fornecedorAtual.Bairro = BairroAcompanharFornecedorTF.Text
        fornecedorAtual.Cidade = CidadeAcompanharFornecedorTF.Text
        fornecedorAtual.Estado = EstadoAcompanharFornecedorCB.Text
        fornecedorAtual.Cep = CEPAcompanharFornecedorMTF.Text
        fornecedorAtual.TipoEndereco = TipoEnderecoAcompanharFornecedorCB.Text

        FornecedorBC.Update(fornecedorAtual)

        MsgBox("Atualização de fornecedor realizada com sucesso.", vbInformation Or vbMsgBoxSetForeground)
        LimparCamposAcompanharFornecedor()
    End Sub

    Private Sub LimparCamposAcompanharFornecedor()
        fornecedorAtual = Nothing

        RazaoAcompanharFornecedorTF.Enabled = False
        FantasiaAcompanharFornecedorTF.Enabled = False
        TelefoneAcompanharFornecedorMTF.Enabled = False
        TipoFornecedorAcompanharFornecedorCB.Enabled = False
        LogradouroAcompanharFornecedorTF.Enabled = False
        NumeroAcompanharFornecedorTF.Enabled = False
        BairroAcompanharFornecedorTF.Enabled = False
        CidadeAcompanharFornecedorTF.Enabled = False
        EstadoAcompanharFornecedorCB.Enabled = False
        CEPAcompanharFornecedorMTF.Enabled = False
        TipoEnderecoAcompanharFornecedorCB.Enabled = False

        FornecedorAcompanharFornecedorTF.Text = ""
        CNPJAcompanharFornecedorMTF.Text = ""
        RazaoAcompanharFornecedorTF.Text = ""
        FantasiaAcompanharFornecedorTF.Text = ""
        TelefoneAcompanharFornecedorMTF.Text = ""
        TipoFornecedorAcompanharFornecedorCB.Text = ""
        LogradouroAcompanharFornecedorTF.Text = ""
        NumeroAcompanharFornecedorTF.Text = ""
        BairroAcompanharFornecedorTF.Text = ""
        CidadeAcompanharFornecedorTF.Text = ""
        EstadoAcompanharFornecedorCB.Text = ""
        CEPAcompanharFornecedorMTF.Text = ""
        TipoEnderecoAcompanharFornecedorCB.Text = ""
    End Sub

    Private Sub SalvarNovaAssistenciaBT_Click(sender As Object, e As EventArgs) Handles SalvarNovaAssistenciaBT.Click
        If (String.IsNullOrWhiteSpace(CNPJNovaAssistenciaMTF.Text)) Then
            MsgBox("CNPJ da Assistência não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(RazaoNovaAssistenciaTF.Text)) Then
            MsgBox("Razão social da Assistência não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(FantasiaNovaAssistenciaTF.Text)) Then
            MsgBox("Nome fantasia da Assistência não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(TelefoneNovaAssistenciaMTF.Text)) Then
            MsgBox("Telefone da Assistência não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(LogradouroNovaAssistenciaTF.Text)) Then
            MsgBox("Logradouro do endereço da Assistência não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(NumeroNovaAssistenciaTF.Text)) Then
            MsgBox("Numero do endereço da Assistência não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(CidadeNovaAssistenciaTF.Text)) Then
            MsgBox("Cidade do endereço da Assistência não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(EstadoNovaAssistenciaCB.Text)) Then
            MsgBox("Estado do endereço da Assistência não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(CEPNovaAssistenciaMTF.Text)) Then
            MsgBox("CEP do endereço da Assistência não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(TipoEnderecoNovaAssistenciaCB.Text)) Then
            MsgBox("Tipo do endereço da Assistência não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (fornecedorAtualNovaAssistencia Is Nothing OrElse String.IsNullOrWhiteSpace(FornecedorNovaAssistenciaTF.Text)) Then
            MsgBox("Fornecedor não vinculado à Assistência", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If

        Dim assistencia As New Fornecedor(CNPJNovaAssistenciaMTF.Text, RazaoNovaAssistenciaTF.Text, FantasiaNovaAssistenciaTF.Text, TelefoneNovaAssistenciaMTF.Text, Now, TipoFornecedor.Assistencia, LogradouroNovaAssistenciaTF.Text, NumeroNovaAssistenciaTF.Text, BairroNovaAssistenciaTF.Text, CidadeNovaAssistenciaTF.Text, EstadoNovaAssistenciaCB.Text, CEPNovaAssistenciaMTF.Text, TipoEnderecoNovaAssistenciaCB.Text)
        assistencia.Assistencia = assistencia
        FornecedorBC.Insert(assistencia)

        fornecedorAtualNovaAssistencia.Assistencia = assistencia

        FornecedorBC.UpdateAssistencia(fornecedorAtualNovaAssistencia)

        MsgBox("Inclusão de assistência e vinculação com o fornecedor realizada com sucesso.", vbInformation Or vbMsgBoxSetForeground)
        LimparCamposNovaAssistencia()
    End Sub

    Private Sub LimparCamposNovaAssistencia()
        CNPJNovaAssistenciaMTF.Text = ""
        RazaoNovaAssistenciaTF.Text = ""
        FantasiaNovaAssistenciaTF.Text = ""
        TelefoneNovaAssistenciaMTF.Text = ""
        LogradouroNovaAssistenciaTF.Text = ""
        NumeroNovaAssistenciaTF.Text = ""
        BairroNovaAssistenciaTF.Text = ""
        CidadeNovaAssistenciaTF.Text = ""
        EstadoNovaAssistenciaCB.Text = ""
        CEPNovaAssistenciaMTF.Text = ""
        TipoEnderecoNovaAssistenciaCB.Text = ""
        FornecedorNovaAssistenciaTF.Text = ""
        fornecedorAtualNovaAssistencia = Nothing
    End Sub

    Private Sub LimparCamposNovaAssistenciaBT_Click(sender As Object, e As EventArgs) Handles LimparCamposNovaAssistenciaBT.Click
        LimparCamposNovaAssistencia()
    End Sub

    Private Sub ProcurarFornecedorNovaAssistenciaIMG_Click(sender As Object, e As EventArgs) Handles ProcurarFornecedorNovaAssistenciaIMG.Click
        Dim busca As New BuscaFornecedor()
        busca.Caller = "ControleFornecedorNovaAssistencia"
        busca.Show()
    End Sub

    Public Sub PopulateFornecedorNovaAssistencia(fornecedor As Fornecedor)
        fornecedorAtualNovaAssistencia = fornecedor
        FornecedorNovaAssistenciaTF.Text = fornecedor.Cnpj & " - " & fornecedor.NomeFantasia
    End Sub

    Private Sub SelecionarAssistenciaAcompanharAssistenciaIMG_Click(sender As Object, e As EventArgs) Handles SelecionarAssistenciaAcompanharAssistenciaIMG.Click
        Dim busca As New BuscaFornecedor()
        busca.Caller = "ControleFornecedorAssistenciaAcompanharAssistencia"
        busca.Show()
    End Sub

    Private Sub SelecionarFornecedorAcompanharAssistenciaIMG_Click(sender As Object, e As EventArgs) Handles SelecionarFornecedorAcompanharAssistenciaIMG.Click
        Dim busca As New BuscaFornecedor()
        busca.Caller = "ControleFornecedorFornecedorAcompanharAssistencia"
        busca.Show()
    End Sub

    Public Sub PopulateFornecedorAcompanharAssistencia(fornecedor As Fornecedor)
        fornecedorVincular = fornecedor
        FornecedorAcompanharAssistenciaTF.Text = fornecedor.Cnpj & " - " & fornecedor.NomeFantasia
    End Sub

    Public Sub PopulateAssistenciaAcompanharAssistencia(assistencia As Fornecedor)
        assistenciaAtual = assistencia
        AssistenciaAcompanharAssistenciaTF.Text = assistenciaAtual.Cnpj & " - " & assistenciaAtual.NomeFantasia

        RazaoAcompanharAssistenciaTF.Enabled = True
        FantasiaAcompanharAssistenciaTF.Enabled = True
        TelefoneAcompanharAssistenciaMTF.Enabled = True
        LogradouroAcompanharAssistenciaTF.Enabled = True
        NumeroAcompanharAssistenciaTF.Enabled = True
        BairroAcompanharAssistenciaTF.Enabled = True
        CidadeAcompanharAssistenciaTF.Enabled = True
        EstadoAcompanharAssistenciaCB.Enabled = True
        CEPAcompanharAssistenciaMTF.Enabled = True
        TipoEnderecoAcompanharAssistenciaCB.Enabled = True

        CNPJAcompanharAssistenciaMTF.Text = assistenciaAtual.Cnpj
        RazaoAcompanharAssistenciaTF.Text = assistenciaAtual.RazaoSocial
        FantasiaAcompanharAssistenciaTF.Text = assistenciaAtual.NomeFantasia
        TelefoneAcompanharAssistenciaMTF.Text = assistenciaAtual.Telefone
        LogradouroAcompanharAssistenciaTF.Text = assistenciaAtual.Logradouro
        NumeroAcompanharAssistenciaTF.Text = assistenciaAtual.Numero
        BairroAcompanharAssistenciaTF.Text = assistenciaAtual.Bairro
        CidadeAcompanharAssistenciaTF.Text = assistenciaAtual.Cidade
        EstadoAcompanharAssistenciaCB.Text = assistenciaAtual.Estado
        CEPAcompanharAssistenciaMTF.Text = assistenciaAtual.Cep
        TipoEnderecoAcompanharAssistenciaCB.Text = assistenciaAtual.TipoEndereco

    End Sub

    Private Sub SalvarAcompanharAssistenciaBT_Click(sender As Object, e As EventArgs) Handles SalvarAcompanharAssistenciaBT.Click
        If (String.IsNullOrWhiteSpace(RazaoAcompanharAssistenciaTF.Text)) Then
            MsgBox("Razão social da Assistência não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(FantasiaAcompanharAssistenciaTF.Text)) Then
            MsgBox("Nome fantasia da Assistência não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(TelefoneAcompanharAssistenciaMTF.Text)) Then
            MsgBox("Telefone da Assistência não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(LogradouroAcompanharAssistenciaTF.Text)) Then
            MsgBox("Logradouro do endereço da Assistência não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(NumeroAcompanharAssistenciaTF.Text)) Then
            MsgBox("Numero do endereço da Assistência não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(CidadeAcompanharAssistenciaTF.Text)) Then
            MsgBox("Cidade do endereço da Assistência não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(EstadoAcompanharAssistenciaCB.Text)) Then
            MsgBox("Estado do endereço da Assistência não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(CEPAcompanharAssistenciaMTF.Text)) Then
            MsgBox("CEP do endereço da Assistência não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(TipoEnderecoAcompanharAssistenciaCB.Text)) Then
            MsgBox("Tipo do endereço da Assistência não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If

        assistenciaAtual.RazaoSocial = RazaoAcompanharAssistenciaTF.Text
        assistenciaAtual.NomeFantasia = FantasiaAcompanharAssistenciaTF.Text
        assistenciaAtual.Telefone = TelefoneAcompanharAssistenciaMTF.Text
        assistenciaAtual.Logradouro = LogradouroAcompanharAssistenciaTF.Text
        assistenciaAtual.Numero = NumeroAcompanharAssistenciaTF.Text
        assistenciaAtual.Bairro = BairroAcompanharAssistenciaTF.Text
        assistenciaAtual.Cidade = CidadeAcompanharAssistenciaTF.Text
        assistenciaAtual.Estado = EstadoAcompanharAssistenciaCB.Text
        assistenciaAtual.Cep = CEPAcompanharAssistenciaMTF.Text
        assistenciaAtual.TipoEndereco = TipoEnderecoAcompanharAssistenciaCB.Text

        FornecedorBC.Update(assistenciaAtual)

        If (fornecedorVincular IsNot Nothing) Then
            fornecedorVincular.Assistencia = assistenciaAtual
            FornecedorBC.UpdateAssistencia(fornecedorVincular)
        End If

        MsgBox("Atualização de assistência realizada com sucesso.", vbInformation Or vbMsgBoxSetForeground)
        LimparCamposAcompanharAssistencia()
    End Sub

    Private Sub LimparCamposAcompanharAssistencia()
        AssistenciaAcompanharAssistenciaTF.Text = ""
        CNPJAcompanharAssistenciaMTF.Text = ""
        RazaoAcompanharAssistenciaTF.Text = ""
        FantasiaAcompanharAssistenciaTF.Text = ""
        TelefoneAcompanharAssistenciaMTF.Text = ""
        LogradouroAcompanharAssistenciaTF.Text = ""
        NumeroAcompanharAssistenciaTF.Text = ""
        BairroAcompanharAssistenciaTF.Text = ""
        CidadeAcompanharAssistenciaTF.Text = ""
        EstadoAcompanharAssistenciaCB.Text = ""
        CEPAcompanharAssistenciaMTF.Text = ""
        TipoEnderecoAcompanharAssistenciaCB.Text = ""
        FornecedorAcompanharAssistenciaTF.Text = ""
        fornecedorVincular = Nothing
        assistenciaAtual = Nothing

        RazaoAcompanharAssistenciaTF.Enabled = False
        FantasiaAcompanharAssistenciaTF.Enabled = False
        TelefoneAcompanharAssistenciaMTF.Enabled = False
        LogradouroAcompanharAssistenciaTF.Enabled = False
        NumeroAcompanharAssistenciaTF.Enabled = False
        BairroAcompanharAssistenciaTF.Enabled = False
        CidadeAcompanharAssistenciaTF.Enabled = False
        EstadoAcompanharAssistenciaCB.Enabled = False
        CEPAcompanharAssistenciaMTF.Enabled = False
        TipoEnderecoAcompanharAssistenciaCB.Enabled = False
    End Sub
End Class