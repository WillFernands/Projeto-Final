Imports Microsoft.Office.Interop.Excel

Public Class RecuperarHistorico

    Private funcionarios As New List(Of Funcionario)

    Private Sub RecuperarHistorico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim registros As List(Of RegistroPonto) = RegistroPontoBC.FindByMatricula(MenuPrincipal.funcionarioLogado, InicioDT.Value, FimDT.Value)

        Dim App As New Application()
        Dim WorkBook As Workbook = App.Workbooks.Open("C:\Users\Leonardo\Desktop\Modelo ponto.xlsx")
        Dim WorkSheet As Worksheet = WorkBook.Worksheets("Plan1")

        Dim arrayRegistros(registros.Count, 4) As String

        For cont As Integer = 0 To registros.Count - 1
            arrayRegistros(cont, 0) = registros(cont).Funcionario.Matricula
            arrayRegistros(cont, 1) = registros(cont).Funcionario.Nome
            arrayRegistros(cont, 2) = registros(cont).DataRegistro.ToString
            arrayRegistros(cont, 3) = registros(cont).Tipo
        Next

        WorkSheet.Range("A3:D" & 3 + registros.Count).Value = arrayRegistros

        WorkBook.SaveCopyAs("C:\Users\Leonardo\Desktop\Modelo ponto teste.xlsx")
        ExcelUtils.FinalizeExcelApp(app)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim busca As New BuscaFuncionario()
        busca.Caller = "RecuperarHistorico"
        busca.Show()
    End Sub

    Public Sub PopulateFuncionario(func As Funcionario)
        FuncionarioTF.Text = func.Matricula & " - " & func.Nome
        AdicionarFuncionario(func)
    End Sub

    Private Sub AdicionarFuncionario(func As Funcionario)
        If (funcionarios.Contains(func) = False) Then funcionarios.Add(func)

        Dim list As New List(Of Object)
        list.Add(func.Matricula) : list.Add(func.Nome) : list.Add("Retirar")
        FuncionariosDT.Rows.Add(list.ToArray())

    End Sub

    Private Sub TodosFuncCB_CheckedChanged(sender As Object, e As EventArgs) Handles TodosFuncCB.CheckedChanged
        If (TodosFuncCB.Checked) Then
            FuncionariosDT.Rows.Clear()
            funcionarios = FuncionarioBC.FindBySupervisor(MenuPrincipal.funcionarioLogado)

            For Each funcionario As Funcionario In funcionarios
                Dim list As New List(Of Object)
                list.Add(funcionario.Matricula) : list.Add(funcionario.Nome) : list.Add("Retirar")
                FuncionariosDT.Rows.Add(list.ToArray())
            Next
        Else
            If (MsgBox("Desmarcar essa opção limpará a lista, continuar com a escolha ?", vbYesNo Or vbMsgBoxSetForeground Or vbInformation) = vbYes) Then
                FuncionariosDT.Rows.Clear()
                funcionarios.Clear()
            Else : TodosFuncCB.Checked = True
            End If
        End If
    End Sub

    Private Sub FuncionariosDT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles FuncionariosDT.CellContentClick
        If (FuncionariosDT.SelectedCells Is Nothing) Then Exit Sub

        If (FuncionariosDT.SelectedCells.Item(0).Value = "Retirar" AndAlso e.ColumnIndex = 2) Then
            Dim funcionario As Funcionario = funcionarios.Find(Function(func As Funcionario) func.Matricula = FuncionariosDT.Item(0, e.RowIndex).Value)
            funcionarios.Remove(funcionario)
            RefreshDT()
            Exit Sub
        End If
    End Sub

    Private Sub RefreshDT()
        FuncionariosDT.Rows.Clear()

        For Each funcionario As Funcionario In funcionarios
            Dim list As New List(Of Object)
            list.Add(funcionario.Matricula) : list.Add(funcionario.Nome) : list.Add("Retirar")
            FuncionariosDT.Rows.Add(list.ToArray())
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GerarRelatorioBT.Click

        Dim registros As New List(Of RegistroPonto)

        For Each Funcionario As Funcionario In funcionarios
            registros.AddRange(RegistroPontoBC.FindByMatricula(Funcionario, InicioFuncDT.Value, FimFuncDT.Value))
        Next

        Dim App As New Application()
        Dim WorkBook As Workbook = App.Workbooks.Open("C:\Users\Leonardo\Desktop\Modelo ponto.xlsx")
        Dim WorkSheet As Worksheet = WorkBook.Worksheets("Plan1")

        Dim arrayRegistros(registros.Count, 4) As String

        For cont As Integer = 0 To registros.Count - 1
            arrayRegistros(cont, 0) = registros(cont).Funcionario.Matricula
            arrayRegistros(cont, 1) = registros(cont).Funcionario.Nome
            arrayRegistros(cont, 2) = registros(cont).DataRegistro.ToString
            arrayRegistros(cont, 3) = registros(cont).Tipo
        Next

        WorkSheet.Range("A3:D" & 3 + registros.Count).Value = arrayRegistros

        WorkBook.SaveCopyAs("C:\Users\Leonardo\Desktop\Modelo ponto teste.xlsx")
        ExcelUtils.FinalizeExcelApp(App)
    End Sub

    Public Sub SetFocusOnForm(activeTab As Integer)
        Me.Show()
        Me.Select()
        Try : RecuperarHistoricoTabControl.SelectTab(activeTab)
        Catch ex As NullReferenceException
        End Try
    End Sub
End Class