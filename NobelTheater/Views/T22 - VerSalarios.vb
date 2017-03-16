Public Class VerSalarios

    Public FuncionarioAtual As Funcionario

    Private Sub VerSalarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDTSalarios()
    End Sub

    Private Sub RefreshDTSalarios()
        SalariosDT.Rows.Clear()

        For Each salario As Salario In FuncionarioAtual.Salarios
            Dim list As New List(Of Object)
            list.Add(salario.Motivo) : list.Add(salario.Valor) : list.Add(salario.Inicio)
            If (salario.Fim = Nothing) Then
                list.Add("Atualmente")
            Else list.Add(salario.Fim)
            End If
            SalariosDT.Rows.Add(list.ToArray())
        Next

    End Sub

    Private Sub AdicionarSalarioIMG_Click(sender As Object, e As EventArgs) Handles AdicionarSalarioIMG.Click
        Dim salario As New Salario(SalarioNovoTF.Text, Now, Nothing, MotivoTF.Text, FuncionarioAtual)
        For Each salarioAntigo As Salario In FuncionarioAtual.Salarios
            If (salarioAntigo.Fim = Nothing) Then salarioAntigo.Fim = Now
        Next
        FuncionarioAtual.Salarios.Add(salario)
        RefreshDTSalarios()
    End Sub

    Private Sub SalvarSalariosBT_Click(sender As Object, e As EventArgs) Handles SalvarSalariosBT.Click
        SalarioBC.DeleteByMatricula(FuncionarioAtual)
        For Each salario As Salario In FuncionarioAtual.Salarios
            SalarioBC.Insert(salario)
        Next
        MsgBox("Salários atualizados", vbMsgBoxSetForeground Or vbInformation)
    End Sub
End Class