Public NotInheritable Class StatusOrcamento
    Public Const OrcamentoPendente As String = "Orçamento Pendente" 'Orçamento foi entregue ao cliente mas ainda não houve resposta
    Public Const OrcamentoDeclinado As String = "Orçamento Declinado" 'Orçamento foi declinado pelo cliente (Finalização do Orçamento)
    Public Const OrcamentoExpirado As String = "Orçamento Expirado" 'Prazo de resposta de 10 dias expirou (Habilitar opção de renovar por + 10 dias)

    Public Shared Function GetStatusList() As List(Of String)
        Dim list As New List(Of String)
        list.Add(OrcamentoPendente)
        list.Add(OrcamentoDeclinado)
        list.Add(OrcamentoExpirado)
        Return list
    End Function
End Class
