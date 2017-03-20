Public NotInheritable Class StatusOrcamento
    Public Const Pendente As String = "Orçamento Pendente" 'Orçamento foi entregue ao cliente mas ainda não houve resposta
    Public Const Declinado As String = "Orçamento Declinado" 'Orçamento foi declinado pelo cliente (Finalização do Orçamento)
    Public Const Expirado As String = "Orçamento Expirado" 'Prazo de resposta de 10 dias expirou (Habilitar opção de renovar por + 10 dias)
    Public Const Aprovado As String = "Orçamento Aprovado" 'Cliente aprovou o orçamento

    Public Shared Function GetStatusList() As List(Of String)
        Dim list As New List(Of String)
        list.Add(Pendente)
        list.Add(Declinado)
        list.Add(Expirado)
        list.Add(Aprovado)
        Return list
    End Function
End Class
