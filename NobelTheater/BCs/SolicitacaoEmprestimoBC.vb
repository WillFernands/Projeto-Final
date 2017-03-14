Option Explicit On
Option Strict On

Public Class SolicitacaoEmprestimoBC

    Private Shared solicitacaoEmprestimoDAO As New SolicitacaoEmprestimoDAO

    Public Shared Function Validate(solicitacaoEmprestimo As SolicitacaoEmprestimo) As Boolean

        If (solicitacaoEmprestimo Is Nothing) Then Return False
        If (solicitacaoEmprestimo.DataSolicitacao = Nothing) Then Return False
        If (solicitacaoEmprestimo.DataSolicitacao > Now) Then Return False

        If (StatusEmprestimo.GetStatusList.Contains(solicitacaoEmprestimo.Status) = False) Then Return False

        If (ClienteBC.Validate(solicitacaoEmprestimo.Cliente) = False) Then Return False

        If (solicitacaoEmprestimo.ItensEmprestimo Is Nothing) Then Return False
        If (solicitacaoEmprestimo.ItensEmprestimo.Count = 0) Then Return False

        For Each item As ItemEmprestimo In solicitacaoEmprestimo.ItensEmprestimo
            If (ItemEmprestimoBC.Validate(item) = False) Then Return False
        Next

        Return True
    End Function

    Public Shared Function Insert(solicitacaoEmprestimo As SolicitacaoEmprestimo) As Long
        If (SolicitacaoEmprestimoBC.Validate(solicitacaoEmprestimo)) Then
            Return solicitacaoEmprestimoDAO.Insert(solicitacaoEmprestimo)
        End If
        Return 0
    End Function

    Public Shared Function UpdateStatus(solicitacaoEmprestimo As SolicitacaoEmprestimo) As Boolean
        If (SolicitacaoEmprestimoBC.Validate(solicitacaoEmprestimo)) Then
            Return solicitacaoEmprestimoDAO.UpdateStatus(solicitacaoEmprestimo)
        End If
        Return False
    End Function

    Public Shared Function FindByID(id As Long) As SolicitacaoEmprestimo
        Return solicitacaoEmprestimoDAO.FindByID(id)
    End Function

    Public Shared Function FindByCliente(cliente As Cliente) As List(Of SolicitacaoEmprestimo)
        Return solicitacaoEmprestimoDAO.FindByCliente(cliente)
    End Function

    Public Shared Function FindAll() As List(Of SolicitacaoEmprestimo)
        Return solicitacaoEmprestimoDAO.FindAll()
    End Function

End Class