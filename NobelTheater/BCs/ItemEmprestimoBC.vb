Option Explicit On
Option Strict On

Public Class ItemEmprestimoBC

    Private Shared itemEmprestimoDAO As New ItemEmprestimoDAO

    Public Shared Function Validate(itemEmprestimo As ItemEmprestimo) As Boolean
        If (itemEmprestimo Is Nothing) Then Return False
        If (itemEmprestimo.SolicitacaoEmprestimo Is Nothing) Then Return False
        If (itemEmprestimo.Quantidade = 0) Then Return False
        If (itemEmprestimo.DataEmprestimo = Nothing) Then Return False
        If (itemEmprestimo.DataEmprestimo > Now) Then Return False
        If (ProdutoBC.Validate(itemEmprestimo.Produto) = False) Then Return False
        Return True
    End Function

    Public Shared Function Insert(itemEmprestimo As ItemEmprestimo) As Boolean
        If (ItemEmprestimoBC.Validate(itemEmprestimo)) Then
            Return itemEmprestimoDAO.Insert(itemEmprestimo)
        End If
        Return False
    End Function

    Public Shared Function FindBySolicitacao(solicitacao As SolicitacaoEmprestimo) As List(Of ItemEmprestimo)
        Return itemEmprestimoDAO.FindBySolicitacao(solicitacao)
    End Function

End Class