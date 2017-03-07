Public Class ControleFuncionario

    Private supervisorAtual As Funcionario

    Private Sub ControleFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NomeTF.Text = "Nome: " & MenuPrincipal.funcionarioLogado.Nome
        MatriculaTF.Text = "Matricula: " & MenuPrincipal.funcionarioLogado.Matricula
        PerfilTF.Text = "Perfil: " & MenuPrincipal.funcionarioLogado.Perfil

        EstadoNovoFuncionarioCB.Items.AddRange(EstadosEnum.GetEstadosList().ToArray())
        TipoEnderecoNovoFuncionarioCB.Items.AddRange(TipoEndereco.GetTiposList().ToArray())
        CargoNovoFuncionarioCB.Items.AddRange(TipoCargo.GetTiposList().ToArray())
        PerfilNovoFuncionarioCB.Items.AddRange(TipoPerfilFuncionario.GetTiposList().ToArray())
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

    Private Sub AcompanharFuncionarioDT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AcompanharFuncionarioDT.CellContentClick

    End Sub
End Class