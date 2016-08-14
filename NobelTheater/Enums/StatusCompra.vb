Option Explicit On
Option Strict On

Public NotInheritable Class StatusCompra
    Public Const PgtoPendente As String = "Pagamento Pendente"
    Public Const Finalizada As String = "Finalizada"
    
    Public Shared Function GetStatusList() As List(Of String)
        Dim list As New List(Of String)
        list.Add(PgtoPendente)
        list.Add(Finalizada)
        Return list
    End Function

End Class
