Public Class CriarVisitaTecnica

    Public vendaAtual As NotaFiscalVenda
    Public supervisorAtual As Funcionario

    Private Sub CriarVisitaTecnica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MotivoVisitaCB.Items.Clear()
        MotivoVisitaCB.Items.AddRange(TipoVisita.GetTiposList().ToArray())
        NomeTF.Text = "Nome: " & MenuPrincipal.funcionarioLogado.Nome
        MatriculaTF.Text = "Matricula: " & MenuPrincipal.funcionarioLogado.Matricula
        PerfilTF.Text = "Perfil: " & MenuPrincipal.funcionarioLogado.Perfil
    End Sub

    Public Sub PopulateVenda(venda As NotaFiscalVenda)
        vendaAtual = venda
        ClienteTF.Text = venda.Orcamento.Cliente.ID & " - " & venda.Orcamento.Cliente.Nome
    End Sub

    Private Sub CriarVisitaTecnicaBT_Click(sender As Object, e As EventArgs) Handles CriarVisitaTecnicaBT.Click
        If (supervisorAtual Is Nothing OrElse String.IsNullOrWhiteSpace(SupervisorResponsavelTF.Text)) Then
            MsgBox("Supervisor não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(MotivoVisitaCB.Text)) Then
            MsgBox("Motivo não selecionado", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(PrecoTF.Text)) Then
            MsgBox("Preço não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If

        Dim visita As New VisitaTecnica(Now, MotivoVisitaCB.Text, PrecoTF.Text, supervisorAtual, vendaAtual)
        If (VisitaTecnicaBC.Insert(visita)) Then
            MsgBox("Visita Tecnica criada", vbInformation Or vbMsgBoxSetForeground)
            SupervisorResponsavelTF.Text = ""
            ClienteTF.Text = ""
            MotivoVisitaCB.Text = ""
            PrecoTF.Text = ""
            vendaAtual = Nothing
            supervisorAtual = Nothing
            Me.Hide()
        Else MsgBox("Um problema ocorreu durante a criação da visita técnica", vbInformation Or vbMsgBoxSetForeground)
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim busca As New BuscaFuncionario()
        busca.Caller = "SupervisorCriarVisita"
        busca.Show()
    End Sub

    Public Sub PopulateSupervisor(func As Funcionario)
        SupervisorResponsavelTF.Text = func.Matricula & " - " & func.Nome
        supervisorAtual = func
    End Sub

    Private Sub NaoCobrarVisitaCHECKBOX_CheckedChanged(sender As Object, e As EventArgs) Handles NaoCobrarVisitaCB.CheckedChanged
        If (NaoCobrarVisitaCB.Checked) Then
            PrecoTF.Text = "0.00"
            PrecoTF.Enabled = False
        Else PrecoTF.Enabled = True
        End If
    End Sub
End Class