Public Class ControleFornecedor

    Private fornecedorAtual As Fornecedor

    Private Sub ControleFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TipoNovoFornecedorCB.Items.Add(TipoFornecedor.Fornecedor)
        TipoNovoFornecedorCB.Items.Add(TipoFornecedor.FornecedorAssistencia)
        TipoEnderecoNovoFornecedorCB.Items.AddRange(TipoEndereco.GetTiposList().ToArray())
        TipoFornecedorAcompanharFornecedorCB.Items.AddRange(TipoFornecedor.GetTiposList().ToArray())
        TipoEnderecoAcompanharFornecedorCB.Items.AddRange(TipoEndereco.GetTiposList().ToArray())
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
End Class