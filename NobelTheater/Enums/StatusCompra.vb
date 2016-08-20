Option Explicit On
Option Strict On

Public NotInheritable Class StatusCompra
    Public Const Cotada As String = "Cotada"
    Public Const APagar As String = "A Pagar"
    Public Const Rejeitada As String = "Rejeitada"
    Public Const Finalizada As String = "Finalizada"

    Public Shared Function GetStatusList() As List(Of String)
        Dim list As New List(Of String)
        list.Add(Cotada)
        list.Add(APagar)
        list.Add(Rejeitada)
        list.Add(Finalizada)
        Return list
    End Function

End Class
