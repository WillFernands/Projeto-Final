Option Explicit On
Option Strict On

Public NotInheritable Class TipoFornecedor
    Public Const Fornecedor As String = "Fornecedor"
    Public Const Assistencia As String = "Assistencia"
    Public Const FornecedorAssistencia As String = "Fornecedor e Assistencia"

    Public Shared Function GetTiposList() As List(Of String)
        Dim list As New List(Of String)
        list.Add(Fornecedor)
        list.Add(Assistencia)
        list.Add(FornecedorAssistencia)
        Return list
    End Function

End Class
