Public Class ControleFuncionario

    Private supervisorAtual As Funcionario
    Private funcionarioAtual As Funcionario

    Private Sub ControleFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NomeTF.Text = "Nome: " & MenuPrincipal.funcionarioLogado.Nome
        MatriculaTF.Text = "Matricula: " & MenuPrincipal.funcionarioLogado.Matricula
        PerfilTF.Text = "Perfil: " & MenuPrincipal.funcionarioLogado.Perfil

        EstadoNovoFuncionarioCB.Items.AddRange(EstadosEnum.GetEstadosList().ToArray())
        TipoEnderecoNovoFuncionarioCB.Items.AddRange(TipoEndereco.GetTiposList().ToArray())
        CargoNovoFuncionarioCB.Items.AddRange(TipoCargo.GetTiposList().ToArray())
        PerfilNovoFuncionarioCB.Items.AddRange(TipoPerfilFuncionario.GetTiposList().ToArray())
        EstadoAcompanharFuncCB.Items.AddRange(EstadosEnum.GetEstadosList().ToArray())
        TipoEnderecoAcompanharFuncCB.Items.AddRange(TipoEndereco.GetTiposList().ToArray())
        CargoAcompanharFuncCB.Items.AddRange(TipoCargo.GetTiposList().ToArray())
        NumeroNovoFuncionarioTF.Text = "S/N"
        EstadoNovoFuncionarioCB.Text = "PR"
        SalarioNovoFuncionarioTF.Text = "0.00"
    End Sub

    Private Sub LimparNovoBT_Click(sender As Object, e As EventArgs) Handles LimparNovoFuncionarioBT.Click
        If (MsgBox("Essa ação limpará todos os campos, tem certeza que deseja prosseguir?", vbYes, vbInformation Or vbMsgBoxSetForeground) = vbYes) Then
            LimparCampos()
        End If
    End Sub

    Private Sub LimparCampos()
        NomeNovoFuncionarioTF.Text = ""
        CPFNovoFuncionarioTF.Text = ""
        TelefoneNovoFuncionarioTF.Text = ""
        CEPNovoFuncionarioTF.Text = ""
        LogradouroNovoFuncionarioTF.Text = ""
        NumeroNovoFuncionarioTF.Text = ""
        BairroNovoFuncionarioTF.Text = ""
        CidadeNovoFuncionarioTF.Text = ""
        EstadoNovoFuncionarioCB.Text = ""
        TipoEnderecoNovoFuncionarioCB.Text = ""
        CargoNovoFuncionarioCB.Text = ""
        PerfilNovoFuncionarioCB.Text = ""
        SalarioNovoFuncionarioTF.Text = ""
    End Sub

    Private Sub SalvarNovoBT_Click(sender As Object, e As EventArgs) Handles SalvarNovoFuncionarioBT.Click
        If (String.IsNullOrWhiteSpace(NomeNovoFuncionarioTF.Text)) Then
            MsgBox("Nome do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(CPFNovoFuncionarioTF.Text)) Then
            MsgBox("CPF do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(TelefoneNovoFuncionarioTF.Text)) Then
            MsgBox("Telefone do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(CEPNovoFuncionarioTF.Text)) Then
            MsgBox("CEP do endereço do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(LogradouroNovoFuncionarioTF.Text)) Then
            MsgBox("Logradouro do endereço do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(NumeroNovoFuncionarioTF.Text)) Then
            MsgBox("Numero do endereço do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(CidadeNovoFuncionarioTF.Text)) Then
            MsgBox("Cidade do endereço do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(EstadoNovoFuncionarioCB.Text)) Then
            MsgBox("Estado do endereço do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(TipoEnderecoNovoFuncionarioCB.Text)) Then
            MsgBox("Tipo do endereço do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(CargoNovoFuncionarioCB.Text)) Then
            MsgBox("Cargo do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(PerfilNovoFuncionarioCB.Text)) Then
            MsgBox("Perfil do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(SalarioNovoFuncionarioTF.Text)) Then
            MsgBox("Salário do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If

        Dim funcionario As New Funcionario(CPFNovoFuncionarioTF.Text, NomeNovoFuncionarioTF.Text, TelefoneNovoFuncionarioTF.Text, Now, PerfilNovoFuncionarioCB.Text, CargoNovoFuncionarioCB.Text, LogradouroNovoFuncionarioTF.Text, NumeroNovoFuncionarioTF.Text, BairroNovoFuncionarioTF.Text, CidadeNovoFuncionarioTF.Text, EstadoNovoFuncionarioCB.Text, CEPNovoFuncionarioTF.Text, TipoEnderecoNovoFuncionarioCB.Text)
        funcionario.Supervisor = supervisorAtual
        funcionario.Matricula = FuncionarioBC.Insert(funcionario)
        FuncionarioBC.UpdateSupervisor(funcionario)
        funcionario.Salarios.Add(New Salario(SalarioNovoFuncionarioTF.Text, Now, Nothing, "Salário Inicial", funcionario))
        For Each salario As Salario In funcionario.Salarios
            SalarioBC.Insert(salario)
        Next

        funcionario.Senha = FuncionarioBC.RetrieveSenha(funcionario)

        MsgBox("Inclusão de funcionário realizada com sucesso, informe ao funcionário suas informações de acesso" & Chr(10) &
               "Matricula: " & funcionario.Matricula & "." & Chr(10) &
               "Senha: " & funcionario.Senha & ".", vbInformation Or vbMsgBoxSetForeground)
        LimparCampos()
    End Sub

    Private Sub SupervisorIMG_Click(sender As Object, e As EventArgs) Handles SupervisorIMG.Click
        Dim busca As New BuscaFuncionario()
        busca.Caller = "NovoFuncionario"
        busca.Show()
    End Sub

    Public Sub PopulateSupervisor(func As Funcionario)
        SupervisorNovoFuncionarioTF.Text = func.Matricula & " - " & func.Nome
        supervisorAtual = func
    End Sub

    Public Sub PopulateFuncionario(func As Funcionario)
        LimparCamposAcompanharFunc()
        MatriculaFuncionarioAcompanharFuncTF.Text = func.Matricula
        FuncionarioAcompanharFuncTF.Text = func.Nome
        funcionarioAtual = func
        NomeFuncionarioAcompanharFuncTF.Text = func.Nome
        CPFAcompanharFuncMT.Text = func.Cpf
        DataContratacaoAcompanharFuncTF.Text = func.DataContratacao
        CargoAcompanharFuncCB.Text = func.Cargo
        TelefoneAcompanharFuncTF.Text = func.Telefone
        LogradouroAcompanharFuncTF.Text = func.Logradouro
        NumeroAcompanharFuncTF.Text = func.Numero
        BairroAcompanharFuncTF.Text = func.Bairro
        CidadeAcompanharFuncTF.Text = func.Cidade
        EstadoAcompanharFuncCB.Text = func.Estado
        CEPAcompanharFuncTF.Text = func.Cep
        TipoEnderecoAcompanharFuncCB.Text = func.TipoEndereco

        NomeFuncionarioAcompanharFuncTF.Enabled = True
        CPFAcompanharFuncMT.Enabled = True
        CargoAcompanharFuncCB.Enabled = True
        TelefoneAcompanharFuncTF.Enabled = True
        NumeroAcompanharFuncTF.Enabled = True
        BairroAcompanharFuncTF.Enabled = True
        CidadeAcompanharFuncTF.Enabled = True
        EstadoAcompanharFuncCB.Enabled = True
        CEPAcompanharFuncTF.Enabled = True
        TipoEnderecoAcompanharFuncCB.Enabled = True
        VerSalariosAcompanharFuncBT.Enabled = True
        SalvarAcompanharFuncBT.Enabled = True
    End Sub

    Private Sub LimparCamposAcompanharFunc()
        MatriculaFuncionarioAcompanharFuncTF.Text = ""
        FuncionarioAcompanharFuncTF.Text = ""
        funcionarioAtual = Nothing
        NomeFuncionarioAcompanharFuncTF.Text = ""
        CPFAcompanharFuncMT.Text = ""
        DataContratacaoAcompanharFuncTF.Text = ""
        CargoAcompanharFuncCB.Text = ""
        TelefoneAcompanharFuncTF.Text = ""
        LogradouroAcompanharFuncTF.Text = ""
        NumeroAcompanharFuncTF.Text = ""
        BairroAcompanharFuncTF.Text = ""
        CidadeAcompanharFuncTF.Text = ""
        EstadoAcompanharFuncCB.Text = ""
        CEPAcompanharFuncTF.Text = ""
        TipoEnderecoAcompanharFuncCB.Text = ""

        NomeFuncionarioAcompanharFuncTF.Enabled = False
        CPFAcompanharFuncMT.Enabled = False
        CargoAcompanharFuncCB.Enabled = False
        TelefoneAcompanharFuncTF.Enabled = False
        NumeroAcompanharFuncTF.Enabled = False
        BairroAcompanharFuncTF.Enabled = False
        CidadeAcompanharFuncTF.Enabled = False
        EstadoAcompanharFuncCB.Enabled = False
        CEPAcompanharFuncTF.Enabled = False
        TipoEnderecoAcompanharFuncCB.Enabled = False
        VerSalariosAcompanharFuncBT.Enabled = False
        SalvarAcompanharFuncBT.Enabled = False

    End Sub

    Private Sub SelecionarFuncionarioIMG_Click(sender As Object, e As EventArgs) Handles SelecionarFuncionarioIMG.Click
        Dim busca As New BuscaFuncionario()
        busca.Caller = "ControleFuncionario"
        busca.Show()
    End Sub

    Private Sub SalvarAcompanharFuncBT_Click(sender As Object, e As EventArgs) Handles SalvarAcompanharFuncBT.Click
        If (String.IsNullOrWhiteSpace(NomeFuncionarioAcompanharFuncTF.Text)) Then
            MsgBox("Nome do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(CPFAcompanharFuncMT.Text)) Then
            MsgBox("CPF do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(TelefoneAcompanharFuncTF.Text)) Then
            MsgBox("Telefone do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(CEPAcompanharFuncTF.Text)) Then
            MsgBox("CEP do endereço do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(LogradouroAcompanharFuncTF.Text)) Then
            MsgBox("Logradouro do endereço do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(NumeroAcompanharFuncTF.Text)) Then
            MsgBox("Numero do endereço do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(CidadeAcompanharFuncTF.Text)) Then
            MsgBox("Cidade do endereço do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(EstadoAcompanharFuncCB.Text)) Then
            MsgBox("Estado do endereço do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(TipoEnderecoAcompanharFuncCB.Text)) Then
            MsgBox("Tipo do endereço do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(CargoAcompanharFuncCB.Text)) Then
            MsgBox("Cargo do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If

        funcionarioAtual.Nome = NomeFuncionarioAcompanharFuncTF.Text
        funcionarioAtual.Cpf = CPFAcompanharFuncMT.Text
        funcionarioAtual.Cargo = CargoAcompanharFuncCB.Text
        funcionarioAtual.Telefone = TelefoneAcompanharFuncTF.Text
        funcionarioAtual.Logradouro = LogradouroAcompanharFuncTF.Text
        funcionarioAtual.Numero = NumeroAcompanharFuncTF.Text
        funcionarioAtual.Bairro = BairroAcompanharFuncTF.Text
        funcionarioAtual.Cidade = CidadeAcompanharFuncTF.Text
        funcionarioAtual.Estado = EstadoAcompanharFuncCB.Text
        funcionarioAtual.Cep = CEPAcompanharFuncTF.Text
        funcionarioAtual.TipoEndereco = TipoEnderecoAcompanharFuncCB.Text

        FuncionarioBC.Update(funcionarioAtual)
        MsgBox("Atualização realizada com sucesso.", vbInformation Or vbMsgBoxSetForeground)
        LimparCamposAcompanharFunc()
    End Sub

    Private Sub VerSalariosAcompanharFuncBT_Click(sender As Object, e As EventArgs) Handles VerSalariosAcompanharFuncBT.Click
        Dim view As New VerSalarios()
        view.FuncionarioAtual = funcionarioAtual
        view.Show()
    End Sub
End Class