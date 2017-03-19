Public Class BalancoDeCaixa

    Private Sub BalancoDeCaixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class