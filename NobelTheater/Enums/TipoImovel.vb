Option Explicit On
Option Strict On

Public NotInheritable Class TipoImovel
    Public Const Casa As String = "Casa"
    Public Const Apartamento As String = "Apartamento"
    Public Const Sobrado As String = "Sobrado"
    Public Const Fabrica As String = "Fábrica"
    Public Const Escritorio As String = "Escritório"

    Public Shared Function GetTiposList() As List(Of String)
        Dim list As New List(Of String)
        list.Add(Casa)
        list.Add(Apartamento)
        list.Add(Sobrado)
        list.Add(Fabrica)
        list.Add(Escritorio)
        Return list
    End Function

End Class
