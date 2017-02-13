Public NotInheritable Class StatusEmprestimo
    Public Const Solicitado As String = "Emprestimo Solicitado"
    Public Const ProdutoComCliente As String = "Produto com Cliente em Emprestimo"
    Public Const Finalizada As String = "Emprestimo Finalizado"

    Public Shared Function GetStatusList() As List(Of String)
        Dim list As New List(Of String)
        list.Add(Solicitado)
        list.Add(ProdutoComCliente)
        list.Add(Finalizada)
        Return list
    End Function
End Class
