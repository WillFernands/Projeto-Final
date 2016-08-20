Option Explicit On
Option Strict On

Public NotInheritable Class TipoNotaFiscal
    Public Const Entrada As String = "Entrada"
    Public Const Saida As String = "Saida"
    
    Public Shared Function GetTiposList() As List(Of String)
        Dim list As New List(Of String)
        list.Add(Entrada)
        list.Add(Saida)
        Return list
    End Function

End Class
