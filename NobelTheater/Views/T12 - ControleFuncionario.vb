Public Class ControleFuncionario

    Private supervisorAtual As Funcionario

    Private Sub ControleFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NomeTF.Text = "Nome: " & MenuPrincipal.funcionarioLogado.Nome
        MatriculaTF.Text = "Matricula: " & MenuPrincipal.funcionarioLogado.Matricula
        PerfilTF.Text = "Perfil: " & MenuPrincipal.funcionarioLogado.Perfil

        EstadoNovoCB.Items.AddRange(EstadosEnum.GetEstadosList().ToArray())
        TipoEnderecoNovoCB.Items.AddRange(TipoEndereco.GetTiposList().ToArray())
        CargoNovoCB.Items.AddRange(TipoCargo.GetTiposList().ToArray())
        PerfilNovoCB.Items.AddRange(TipoPerfilFuncionario.GetTiposList().ToArray())
        NumeroNovoTF.Text = "S/N"
        EstadoNovoCB.Text = "PR"
        SalarioNovoTF.Text = "0.00"
    End Sub

    Private Sub LimparNovoBT_Click(sender As Object, e As EventArgs) Handles LimparNovoBT.Click
        If (MsgBox("Essa ação limpará todos os campos, tem certeza que deseja prosseguir?", vbYes, vbInformation Or vbMsgBoxSetForeground) = vbYes) Then
            LimparCampos()
        End If
    End Sub

    Private Sub LimparCampos()
        NomeNovoTF.Text = ""
        CPFNovoTF.Text = ""
        TelefoneNovoTF.Text = ""
        CEPNovoTF.Text = ""
        LogradouroNovoTF.Text = ""
        NumeroNovoTF.Text = ""
        BairroNovoTF.Text = ""
        CidadeNovoTF.Text = ""
        EstadoNovoCB.Text = ""
        TipoEnderecoNovoCB.Text = ""
        CargoNovoCB.Text = ""
        PerfilNovoCB.Text = ""
        SalarioNovoTF.Text = ""
    End Sub

    Private Sub SalvarNovoBT_Click(sender As Object, e As EventArgs) Handles SalvarNovoBT.Click
        If (String.IsNullOrWhiteSpace(NomeNovoTF.Text)) Then
            MsgBox("Nome do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(CPFNovoTF.Text)) Then
            MsgBox("CPF do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(TelefoneNovoTF.Text)) Then
            MsgBox("Telefone do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(CEPNovoTF.Text)) Then
            MsgBox("CEP do endereço do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(LogradouroNovoTF.Text)) Then
            MsgBox("Logradouro do endereço do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(NumeroNovoTF.Text)) Then
            MsgBox("Numero do endereço do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(CidadeNovoTF.Text)) Then
            MsgBox("Cidade do endereço do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(EstadoNovoCB.Text)) Then
            MsgBox("Estado do endereço do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(TipoEnderecoNovoCB.Text)) Then
            MsgBox("Tipo do endereço do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(CargoNovoCB.Text)) Then
            MsgBox("Cargo do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(PerfilNovoCB.Text)) Then
            MsgBox("Perfil do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(SalarioNovoTF.Text)) Then
            MsgBox("Salário do funcionário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If

        Dim funcionario As New Funcionario(CPFNovoTF.Text, NomeNovoTF.Text, TelefoneNovoTF.Text, Now, PerfilNovoCB.Text, CargoNovoCB.Text, LogradouroNovoTF.Text, NumeroNovoTF.Text, BairroNovoTF.Text, CidadeNovoTF.Text, EstadoNovoCB.Text, CEPNovoTF.Text, TipoEnderecoNovoCB.Text)
        funcionario.Supervisor = supervisorAtual
        funcionario.Matricula = FuncionarioBC.Insert(funcionario)
        FuncionarioBC.UpdateSupervisor(funcionario)
        funcionario.Salarios.Add(New Salario(SalarioNovoTF.Text, Now, Nothing, "Salário Inicial", funcionario))
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
        SupervisorNovoTF.Text = func.Matricula & " - " & func.Nome
        supervisorAtual = func
    End Sub
End Class