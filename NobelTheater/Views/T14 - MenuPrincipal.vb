Public Class MenuPrincipal

    Public Shared funcionarioLogado As Funcionario

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NomeTF.Text = "Nome: " & funcionarioLogado.Nome
        MatriculaTF.Text = "Matricula: " & funcionarioLogado.Matricula
        PerfilTF.Text = "Perfil: " & funcionarioLogado.Perfil

        Select Case funcionarioLogado.Perfil 'Verificar quais perfis tem acesso a qual funcionalidade
            Case TipoPerfilFuncionario.AssistenteAdm
                PermitirAcessos(False) : PermitirRecuperarPonto(True) : PermitirVenda(True)
                PermitirClientes(True) : PermitirFuncionarios(False) : PermitirEstoque(True)
                PermitirFornecedores(True) : PermitirCaixa(False)
                PermitirMonitoramento(False) : PermitirParecer(False)
            Case TipoPerfilFuncionario.AssistenteCont
                PermitirAcessos(False) : PermitirRecuperarPonto(True) : PermitirVenda(False)
                PermitirClientes(False) : PermitirFuncionarios(False) : PermitirEstoque(False)
                PermitirFornecedores(False) : PermitirCaixa(True)
                PermitirMonitoramento(False) : PermitirParecer(False)
            Case TipoPerfilFuncionario.Gerente
                PermitirAcessos(True) : PermitirRecuperarPonto(True) : PermitirVenda(True)
                PermitirClientes(True) : PermitirFuncionarios(True) : PermitirEstoque(True)
                PermitirFornecedores(True) : PermitirCaixa(False)
                PermitirMonitoramento(False) : PermitirParecer(False)
            Case TipoPerfilFuncionario.SupervisorObra
                PermitirAcessos(False) : PermitirRecuperarPonto(True) : PermitirVenda(False)
                PermitirClientes(False) : PermitirFuncionarios(False) : PermitirEstoque(False)
                PermitirFornecedores(False) : PermitirCaixa(False)
                PermitirMonitoramento(False) : PermitirParecer(True)
            Case TipoPerfilFuncionario.Tecnico
                PermitirAcessos(False) : PermitirRecuperarPonto(True) : PermitirVenda(False)
                PermitirClientes(False) : PermitirFuncionarios(False) : PermitirEstoque(False)
                PermitirFornecedores(False) : PermitirCaixa(False)
                PermitirMonitoramento(False) : PermitirParecer(False)
            Case TipoPerfilFuncionario.Vendedor
                PermitirAcessos(False) : PermitirRecuperarPonto(True) : PermitirVenda(True)
                PermitirClientes(False) : PermitirFuncionarios(False) : PermitirEstoque(False)
                PermitirFornecedores(False) : PermitirCaixa(False)
                PermitirMonitoramento(False) : PermitirParecer(False)
            Case TipoPerfilFuncionario.Patrocinador
                PermitirAcessos(True) : PermitirRecuperarPonto(True) : PermitirVenda(True)
                PermitirClientes(True) : PermitirFuncionarios(True) : PermitirEstoque(True)
                PermitirFornecedores(True) : PermitirCaixa(True)
                PermitirMonitoramento(True) : PermitirParecer(False)
        End Select

    End Sub

    Private Sub PermitirParecer(status As Boolean)
        ParecerIMG.Enabled = status : ParecerLB.Enabled = status : ParecerPanel.Enabled = status
    End Sub

    Private Sub PermitirMonitoramento(status As Boolean)
        MonitoramentoIMG.Enabled = status : MonitoramentoLB.Enabled = status : MonitoramentoPanel.Enabled = status
    End Sub

    Private Sub PermitirCaixa(status As Boolean)
        CaixaIMG.Enabled = status : CaixaLB.Enabled = status : CaixaPanel.Enabled = status
    End Sub

    Private Sub PermitirFornecedores(status As Boolean)
        FornecedoresIMG.Enabled = status : FornecedoresLB.Enabled = status : FornecedoresPanel.Enabled = status
    End Sub


    Private Sub PermitirEstoque(status As Boolean)
        EstoqueIMG.Enabled = status : EstoqueLB.Enabled = status : EstoquePanel.Enabled = status
    End Sub


    Private Sub PermitirFuncionarios(status As Boolean)
        FuncionariosIMG.Enabled = status : FuncionariosLB.Enabled = status : FuncionariosPanel.Enabled = status
    End Sub

    Private Sub PermitirClientes(status As Boolean)
        ClientesIMG.Enabled = status : ClientesLB.Enabled = status : ClientesPanel.Enabled = status
    End Sub

    Private Sub PermitirAcessos(status As Boolean)
        AcessosIMG.Enabled = status : AcessosLB.Enabled = status : AcessosPanel.Enabled = status
    End Sub

    Private Sub PermitirRecuperarPonto(status As Boolean)
        PontoIMG.Enabled = status : PontoLB.Enabled = status : PontoPanel.Enabled = status
    End Sub

    Private Sub PermitirVenda(status As Boolean)
        VendasIMG.Enabled = status : VendasLB.Enabled = status : VendasPanel.Enabled = status
    End Sub

    Private Sub AcessosClick(sender As Object, e As EventArgs) Handles AcessosIMG.Click, AcessosLB.Click, AcessosPanel.Click
        ControleAcessos.Show()
    End Sub

    Private Sub PontoClick(sender As Object, e As EventArgs) Handles PontoIMG.Click, PontoLB.Click, PontoPanel.Click
        RecuperarHistorico.Show()
    End Sub

    Private Sub VendasClick(sender As Object, e As EventArgs) Handles VendasIMG.Click, VendasLB.Click, VendasPanel.Click
        ControleVendas.Show()
    End Sub

    Private Sub ClientesClick(sender As Object, e As EventArgs) Handles ClientesIMG.Click, ClientesLB.Click, ClientesPanel.Click
        ControleCliente.Show()
    End Sub

    Private Sub FuncionariosClick(sender As Object, e As EventArgs) Handles FuncionariosIMG.Click, FuncionariosLB.Click, FuncionariosPanel.Click
        ControleFuncionario.Show()
    End Sub

    Private Sub EstoqueClick(sender As Object, e As EventArgs) Handles EstoqueIMG.Click, EstoqueLB.Click, EstoquePanel.Click
        ControleEstoque.Show()
    End Sub

    Private Sub FornecedoresClick(sender As Object, e As EventArgs) Handles FornecedoresIMG.Click, FornecedoresLB.Click, FornecedoresPanel.Click
        ControleFornecedor.Show()
    End Sub

    Private Sub CaixaClick(sender As Object, e As EventArgs) Handles CaixaIMG.Click, CaixaLB.Click, CaixaPanel.Click
        BalancoDeCaixa.Show()
    End Sub

    Private Sub MonitoramentoClick(sender As Object, e As EventArgs) Handles MonitoramentoIMG.Click, MonitoramentoLB.Click, MonitoramentoPanel.Click
        MonitorarAmbiente.Show()
    End Sub

    Private Sub ParecerClick(sender As Object, e As EventArgs) Handles ParecerIMG.Click, ParecerLB.Click, ParecerPanel.Click
        InserirParecerObra.Show()
    End Sub

End Class