Option Explicit On
Option Strict On

Public NotInheritable Class StatusVenda
    Public Const VendaEfetuada As String = "Venda Efetuada" 'Orçamento foi aprovado pelo cliente, serviço e pagamento a serem efetuados
    Public Const ServicoFinalizado As String = "Serviço Finalizado, Pagamento Pendente" 'Obra foi finalizada, mas pagamento ainda não foi completado
    Public Const ServicoPago As String = "Pagamento Efetuado, Serviço Pendente" 'Pagamento já foi realizado, mas obra ainda não foi finalizada
    Public Const ServicoFinalizadoEPago As String = "Serviço e Pagamento Finalizados" 'Obra e Pagamento estão OK (Finalização do Orçamento)

    Public Shared Function GetStatusList() As List(Of String)
        Dim list As New List(Of String)
        list.Add(VendaEfetuada)
        list.Add(ServicoFinalizado)
        list.Add(ServicoPago)
        list.Add(ServicoFinalizadoEPago)
        Return list
    End Function

End Class
