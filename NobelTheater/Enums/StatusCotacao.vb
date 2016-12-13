Option Explicit On
Option Strict On

Public NotInheritable Class StatusCotacao

    Public Const Cotada As String = "Cotada"
    Public Const Aprovada As String = "Aprovada"
    Public Const Rejeitada As String = "Rejeitada"

    Public Shared Function GetStatusList() As List(Of String)
        Dim list As New List(Of String)
        list.Add(Cotada)
        list.Add(Aprovada)
        list.Add(Rejeitada)
        Return list
    End Function

End Class
