Public NotInheritable Class TipoVisita

    Public Const Manutencao As String = "Manutenção"
    Public Const Retorno As String = "Retorno"
    Public Const Orientacao As String = "Orientacao"

    Public Shared Function GetTiposList() As List(Of String)
        Dim list As New List(Of String)
        list.Add(Manutencao)
        list.Add(Retorno)
        list.Add(Orientacao)
        Return list
    End Function

End Class
