Public Class BalancoDeCaixa

    Private Sub BalancoDeCaixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NomeTF.Text = "Nome: " & MenuPrincipal.funcionarioLogado.Nome
        MatriculaTF.Text = "Matricula: " & MenuPrincipal.funcionarioLogado.Matricula
        PerfilTF.Text = "Perfil: " & MenuPrincipal.funcionarioLogado.Perfil

        Select Case MenuPrincipal.funcionarioLogado.Perfil
            Case TipoPerfilFuncionario.AssistenteAdm
                MonitoramentoToolStripMenuItem.Enabled = False
                AcessosRevogadosToolStripMenuItem.Enabled = False
                BalançoDeCaixaToolStripMenuItem.Enabled = False
                FuncionáriosToolStripMenuItem.Enabled = False
            Case TipoPerfilFuncionario.AssistenteCont
                MonitoramentoToolStripMenuItem.Enabled = False
                AcessosRevogadosToolStripMenuItem.Enabled = False
                EstoqueToolStripMenuItem.Enabled = False
                FornecedoresToolStripMenuItem.Enabled = False
                VendasToolStripMenuItem.Enabled = False
                FuncionáriosToolStripMenuItem.Enabled = False
            Case TipoPerfilFuncionario.Gerente
                MonitoramentoToolStripMenuItem.Enabled = False
                BalançoDeCaixaToolStripMenuItem.Enabled = False
            Case TipoPerfilFuncionario.SupervisorObra
                MonitoramentoToolStripMenuItem.Enabled = False
                AcessosRevogadosToolStripMenuItem.Enabled = False
                EstoqueToolStripMenuItem.Enabled = False
                FornecedoresToolStripMenuItem.Enabled = False
                VendasToolStripMenuItem.Enabled = False
                BalançoDeCaixaToolStripMenuItem.Enabled = False
                FuncionáriosToolStripMenuItem.Enabled = False
            Case TipoPerfilFuncionario.Tecnico
                MonitoramentoToolStripMenuItem.Enabled = False
                AcessosRevogadosToolStripMenuItem.Enabled = False
                EstoqueToolStripMenuItem.Enabled = False
                FornecedoresToolStripMenuItem.Enabled = False
                VendasToolStripMenuItem.Enabled = False
                BalançoDeCaixaToolStripMenuItem.Enabled = False
                FuncionáriosToolStripMenuItem.Enabled = False
            Case TipoPerfilFuncionario.Vendedor
                MonitoramentoToolStripMenuItem.Enabled = False
                AcessosRevogadosToolStripMenuItem.Enabled = False
                EstoqueToolStripMenuItem.Enabled = False
                FornecedoresToolStripMenuItem.Enabled = False
                BalançoDeCaixaToolStripMenuItem.Enabled = False
                FuncionáriosToolStripMenuItem.Enabled = False
        End Select
    End Sub

    Private Function CalcularSalarios() As List(Of Funcionario)
        ' Adicionar a cada tecnico R$ 80,00 por Visita (Verificar necessidade dessa parte)
        ' Adicionar a cada supervisor 25% do preco da visita
        ' Adicionar a cada vendedor 5% da Venda

        Dim funcionarios = FuncionarioBC.FindAll()

        For Each venda As NotaFiscalVenda In NotaFiscalVendaBC.FindAll()
            For Each funcionario As Funcionario In funcionarios
                'Validação pra testar se o funcionario é o vendedor
                If (funcionario.Matricula = venda.Orcamento.Vendedor.Matricula) Then
                    funcionario.Salarios(0).Valor += venda.ValorTotal * 0.05
                    Exit For
                End If

                For Each visita As VisitaTecnica In venda.VisitasTecnicas
                    'Validação pra testar se o funcionario é um supervisor
                    If (funcionario.Matricula = visita.Supervisor.Matricula) Then
                        funcionario.Salarios(0).Valor += visita.Preco * 0.25
                        Exit For
                    End If
                Next
            Next
        Next

        Return funcionarios

    End Function

    Public Sub SetFocusOnForm()
        Me.Show()
        Me.Select()
    End Sub
End Class