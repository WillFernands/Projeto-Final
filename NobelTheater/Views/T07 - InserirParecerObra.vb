Public Class InserirParecerObra

    Private visitas As New List(Of VisitaTecnica)
    Private visitaAtual As VisitaTecnica

    Private Sub InserirParecerObra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        RefreshDTVisitas()
    End Sub

    Private Sub RefreshDTVisitas()
        VisitasDT.Rows.Clear()

        visitas = VisitaTecnicaBC.FindBySupervisor(MenuPrincipal.funcionarioLogado).FindAll(Function(visita) String.IsNullOrWhiteSpace(visita.ParecerObra))

        For Each visita As VisitaTecnica In visitas
            Dim list As New List(Of Object)
            list.Add(visita.Data) : list.Add(visita.Supervisor.Matricula & " - " & visita.Supervisor.Nome) : list.Add(visita.NotaFiscal.Orcamento.Cliente.ID & " - " & visita.NotaFiscal.Orcamento.Cliente.Nome) : list.Add(visita.Tipo) : list.Add(visita.Preco)
            VisitasDT.Rows.Add(list.ToArray())
        Next
    End Sub

    Private Sub VisitasDT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles VisitasDT.CellContentClick
        If (VisitasDT.SelectedCells Is Nothing) Then Exit Sub
        Dim visita = visitas.Item(e.RowIndex)
        PopulateVisita(visita)
    End Sub

    Private Sub PopulateVisita(visita As VisitaTecnica)
        ClearVisita()
        visitaAtual = visita
        ClienteTF.Text = visita.NotaFiscal.Orcamento.Cliente.ID & " - " & visita.NotaFiscal.Orcamento.Cliente.Nome
        MotivoVisitaCB.Text = visita.Tipo
        PrecoTF.Text = visita.Preco
    End Sub

    Private Sub ClearVisita()
        visitaAtual = Nothing
        ClienteTF.Text = ""
        MotivoVisitaCB.Text = ""
        PrecoTF.Text = ""
        ParecerObraTF.Text = ""
    End Sub

    Private Sub SalvarParecerBT_Click(sender As Object, e As EventArgs) Handles SalvarParecerBT.Click
        If (String.IsNullOrWhiteSpace(ParecerObraTF.Text)) Then
            MsgBox("Parecer não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If

        visitaAtual.ParecerObra = ParecerObraTF.Text
        If (VisitaTecnicaBC.UpdateParecer(visitaAtual)) Then
            MsgBox("Parecer inserido", vbInformation Or vbMsgBoxSetForeground)
            ClearVisita()
            RefreshDTVisitas()
        Else MsgBox("Um problema ocorreu durante a inserção do parecer", vbInformation Or vbMsgBoxSetForeground)
        End If

    End Sub

    Public Sub SetFocusOnForm()
        Me.Show()
        Me.Select()
    End Sub
End Class