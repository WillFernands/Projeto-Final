Option Explicit On
Option Strict On

Public NotInheritable Class UnidadeProduto
    Public Const Metro As String = "Metro"
    Public Const Peca As String = "Peca"
    Public Const Pacote As String = "Pacote"
    
    Public Shared Function GetUnidadesList() As List(Of String)
        Dim list As New List(Of String)
        list.Add(Metro)
        list.Add(Peca)
        list.Add(Pacote)
        Return list
    End Function

End Class
