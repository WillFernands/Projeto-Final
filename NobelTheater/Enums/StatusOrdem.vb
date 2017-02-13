Public NotInheritable Class StatusOrdem
    Public Const Criada As String = "Ordem Criada"
    Public Const ProdutoNaAssistencia As String = "Produto na Assistencia Tecnica"
    Public Const Finalizada As String = "Ordem Finalizada"

    Public Shared Function GetStatusList() As List(Of String)
        Dim list As New List(Of String)
        list.Add(Criada)
        list.Add(ProdutoNaAssistencia)
        list.Add(Finalizada)
        Return list
    End Function
End Class
