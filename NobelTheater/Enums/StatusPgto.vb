Option Explicit On
Option Strict On

Public NotInheritable Class StatusPgto
    Public Const PgtoPendente As String = "Pagamento Pendente"
    Public Const Finalizado As String = "Finalizado"

    Public Shared Function GetStatusList() As List(Of String)
        Dim list As New List(Of String)
        list.Add(PgtoPendente)
        list.Add(Finalizado)
        Return list
    End Function

End Class
