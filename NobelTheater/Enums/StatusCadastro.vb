Option Explicit On
Option Strict On

Public NotInheritable Class StatusCadastro
    Public Const Ativo As String = "Ativo"
    Public Const CancelLoja As String = "Cancelado (Loja)"
    Public Const CancelCliente As String = "Cancelado (Cliente)"
    Public Const Inatividade As String = "Suspenso (Inatividade)"
    Public Const Inadimplencia As String = "Bloqueado (Inadimplência)"
    Public Const Irregular As String = "Irregular"

    Public Shared Function GetStatusList() As List(Of String)
        Dim list As New List(Of String)
        list.Add(Ativo)
        list.Add(CancelLoja)
        list.Add(CancelCliente)
        list.Add(Inatividade)
        list.Add(Inadimplencia)
        list.Add(Irregular)
        Return list
    End Function

End Class
