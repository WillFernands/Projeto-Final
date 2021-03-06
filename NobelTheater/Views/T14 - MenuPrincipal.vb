﻿Public Class MenuPrincipal

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
                MonitoramentoToolStripMenuItem.Enabled = False
                AcessosRevogadosToolStripMenuItem.Enabled = False
                BalançoDeCaixaToolStripMenuItem.Enabled = False
                FuncionáriosToolStripMenuItem.Enabled = False
            Case TipoPerfilFuncionario.AssistenteCont
                PermitirAcessos(False) : PermitirRecuperarPonto(True) : PermitirVenda(False)
                PermitirClientes(False) : PermitirFuncionarios(False) : PermitirEstoque(False)
                PermitirFornecedores(False) : PermitirCaixa(True)
                PermitirMonitoramento(False) : PermitirParecer(False)
                MonitoramentoToolStripMenuItem.Enabled = False
                AcessosRevogadosToolStripMenuItem.Enabled = False
                EstoqueToolStripMenuItem.Enabled = False
                FornecedoresToolStripMenuItem.Enabled = False
                VendasToolStripMenuItem.Enabled = False
                FuncionáriosToolStripMenuItem.Enabled = False
            Case TipoPerfilFuncionario.Gerente
                PermitirAcessos(True) : PermitirRecuperarPonto(True) : PermitirVenda(True)
                PermitirClientes(True) : PermitirFuncionarios(True) : PermitirEstoque(True)
                PermitirFornecedores(True) : PermitirCaixa(False)
                PermitirMonitoramento(False) : PermitirParecer(False)
                MonitoramentoToolStripMenuItem.Enabled = False
                BalançoDeCaixaToolStripMenuItem.Enabled = False
            Case TipoPerfilFuncionario.SupervisorObra
                PermitirAcessos(False) : PermitirRecuperarPonto(True) : PermitirVenda(False)
                PermitirClientes(False) : PermitirFuncionarios(False) : PermitirEstoque(False)
                PermitirFornecedores(False) : PermitirCaixa(False)
                PermitirMonitoramento(False) : PermitirParecer(True)
                MonitoramentoToolStripMenuItem.Enabled = False
                AcessosRevogadosToolStripMenuItem.Enabled = False
                EstoqueToolStripMenuItem.Enabled = False
                FornecedoresToolStripMenuItem.Enabled = False
                VendasToolStripMenuItem.Enabled = False
                BalançoDeCaixaToolStripMenuItem.Enabled = False
                FuncionáriosToolStripMenuItem.Enabled = False
            Case TipoPerfilFuncionario.Tecnico
                PermitirAcessos(False) : PermitirRecuperarPonto(True) : PermitirVenda(False)
                PermitirClientes(False) : PermitirFuncionarios(False) : PermitirEstoque(False)
                PermitirFornecedores(False) : PermitirCaixa(False)
                PermitirMonitoramento(False) : PermitirParecer(False)
                MonitoramentoToolStripMenuItem.Enabled = False
                AcessosRevogadosToolStripMenuItem.Enabled = False
                EstoqueToolStripMenuItem.Enabled = False
                FornecedoresToolStripMenuItem.Enabled = False
                VendasToolStripMenuItem.Enabled = False
                BalançoDeCaixaToolStripMenuItem.Enabled = False
                FuncionáriosToolStripMenuItem.Enabled = False
            Case TipoPerfilFuncionario.Vendedor
                PermitirAcessos(False) : PermitirRecuperarPonto(True) : PermitirVenda(True)
                PermitirClientes(False) : PermitirFuncionarios(False) : PermitirEstoque(False)
                PermitirFornecedores(False) : PermitirCaixa(False)
                PermitirMonitoramento(False) : PermitirParecer(False)
                MonitoramentoToolStripMenuItem.Enabled = False
                AcessosRevogadosToolStripMenuItem.Enabled = False
                EstoqueToolStripMenuItem.Enabled = False
                FornecedoresToolStripMenuItem.Enabled = False
                BalançoDeCaixaToolStripMenuItem.Enabled = False
                FuncionáriosToolStripMenuItem.Enabled = False
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

    Public Sub SetFocusOnForm(activeTab As Integer)
        Me.Show()
        Me.Select()
    End Sub

#Region "Funções do Menu Superior"
    Private Sub SairToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub GerenciarAcessosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenciarAcessosToolStripMenuItem.Click
        ControleAcessos.SetFocusOnForm(0)
    End Sub

    Private Sub AcessosRevogadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcessosRevogadosToolStripMenuItem.Click
        ControleAcessos.SetFocusOnForm(1)
    End Sub

    Private Sub NovaCotaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovaCotaçãoToolStripMenuItem.Click
        ControleEstoque.SetFocusOnForm(0)
    End Sub

    Private Sub AlertasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlertasToolStripMenuItem.Click
        ControleEstoque.SetFocusOnForm(1)
    End Sub

    Private Sub CotaçõesEmAndamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CotaçõesEmAndamentoToolStripMenuItem.Click
        ControleEstoque.SetFocusOnForm(2)
    End Sub

    Private Sub ComprasEmAndamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasEmAndamentoToolStripMenuItem.Click
        ControleEstoque.SetFocusOnForm(4)
    End Sub

    Private Sub EmprestarProdutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmprestarProdutoToolStripMenuItem.Click
        ControleEstoque.SetFocusOnForm(6)
    End Sub

    Private Sub ProdutosEmprestadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosEmprestadosToolStripMenuItem.Click
        ControleEstoque.SetFocusOnForm(7)
    End Sub

    Private Sub EnviarProdutoAAssistênciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarProdutoAAssistênciaToolStripMenuItem.Click
        ControleEstoque.SetFocusOnForm(8)
    End Sub

    Private Sub ProdutosNaAssistênciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosNaAssistênciaToolStripMenuItem.Click
        ControleEstoque.SetFocusOnForm(9)
    End Sub

    Private Sub RelatóriosDeComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatóriosDeComprasToolStripMenuItem.Click
        ControleEstoque.SetFocusOnForm(10)
    End Sub

    Private Sub CriarNovoProdutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CriarNovoProdutoToolStripMenuItem.Click
        ControleEstoque.SetFocusOnForm(11)
    End Sub

    Private Sub NovoFornecedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoFornecedorToolStripMenuItem.Click
        ControleFornecedor.SetFocusOnForm(0)
    End Sub

    Private Sub AcompanharFornecedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcompanharFornecedorToolStripMenuItem.Click
        ControleFornecedor.SetFocusOnForm(1)
    End Sub

    Private Sub NovaAssistênciaTécnicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovaAssistênciaTécnicaToolStripMenuItem.Click
        ControleFornecedor.SetFocusOnForm(2)
    End Sub

    Private Sub AcompanharAssistênciaTécnicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcompanharAssistênciaTécnicaToolStripMenuItem.Click
        ControleFornecedor.SetFocusOnForm(3)
    End Sub

    Private Sub NovoOrçamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoOrçamentoToolStripMenuItem.Click
        ControleVendas.SetFocusOnForm(0)
    End Sub

    Private Sub OrçamentosEmAndamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrçamentosEmAndamentoToolStripMenuItem.Click
        ControleVendas.SetFocusOnForm(1)
    End Sub

    Private Sub VendasEmAndamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendasEmAndamentoToolStripMenuItem.Click
        ControleVendas.SetFocusOnForm(3)
    End Sub

    Private Sub VisualizarVisitasTécnicasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarVisitasTécnicasToolStripMenuItem.Click
        ControleVendas.SetFocusOnForm(5)
    End Sub

    Private Sub RelatóriosDeVendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatóriosDeVendasToolStripMenuItem.Click
        ControleVendas.SetFocusOnForm(6)
    End Sub

    Private Sub RelatóriosDeBalançoDeCaixaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatóriosDeBalançoDeCaixaToolStripMenuItem.Click
        BalancoDeCaixa.SetFocusOnForm()
    End Sub

    Private Sub MonitorarAmbienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonitorarAmbienteToolStripMenuItem.Click
        MonitorarAmbiente.SetFocusOnForm()
    End Sub

    Private Sub NovoFuncionárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoFuncionárioToolStripMenuItem.Click
        ControleFuncionario.SetFocusOnForm(0)
    End Sub

    Private Sub AcompanharFuncionárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcompanharFuncionárioToolStripMenuItem.Click
        ControleFuncionario.SetFocusOnForm(1)
    End Sub

    Private Sub SobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem.Click
        MsgBox("Nobel HOME 2016-2017 © - Todos os direitos reservados - Versão 0.1", vbInformation Or vbMsgBoxSetForeground)
    End Sub
#End Region

End Class