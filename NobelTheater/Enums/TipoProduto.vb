Option Explicit On
Option Strict On

Public NotInheritable Class TipoProduto
    Public Const Cabo As String = "Cabo"
    Public Const Projetor As String = "Projetor"
    Public Const Roteador As String = "Roteador"

    Public Shared Function GetTiposList() As List(Of String)
        Dim list As New List(Of String)
        list.Add(Cabo)
        list.Add(Projetor)
        list.Add(Roteador)
        Return list
    End Function

End Class
