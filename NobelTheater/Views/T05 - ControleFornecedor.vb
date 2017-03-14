Public Class ControleFornecedor

    Private Sub ControleFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TipoNovoFornecedorCB.Items.Add(TipoFornecedor.Fornecedor)
        TipoNovoFornecedorCB.Items.Add(TipoFornecedor.FornecedorAssistencia)
        TipoEnderecoNovoFornecedorCB.Items.AddRange(TipoEndereco.GetTiposList().ToArray())
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
End Class