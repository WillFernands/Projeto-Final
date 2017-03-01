Public Class MenuPrincipal

    Public Shared funcionarioLogado As Funcionario

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NomeTF.Text = "Nome: " & funcionarioLogado.Nome
        MatriculaTF.Text = "Matricula: " & funcionarioLogado.Matricula
        PerfilTF.Text = "Perfil: " & funcionarioLogado.Perfil
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