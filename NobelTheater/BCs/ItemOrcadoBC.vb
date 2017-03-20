Option Explicit On
Option Strict On

Public Class ItemOrcadoBC

    Private Shared itemOrcadoDAO As New ItemOrcadoDAO

    Public Shared Function Validate(itemOrcado As ItemOrcado) As Boolean
        If (itemOrcado Is Nothing) Then Return False
        If (itemOrcado.Orcamento Is Nothing) Then Return False
        If (itemOrcado.Orcamento.Id = 0) Then Return False
        If (itemOrcado.Quantidade = 0) Then Return False
        If (ProdutoBC.Validate(itemOrcado.Produto) = False) Then Return False
        Return True
    End Function

    Public Shared Function Insert(itemOrcado As ItemOrcado) As Boolean
        If (ItemOrcadoBC.Validate(itemOrcado)) Then
            Return itemOrcadoDAO.Insert(itemOrcado)
        End If
        Return False
    End Function

    Public Shared Function FindByOrcamento(orcamento As Orcamento) As List(Of ItemOrcado)
        Return itemOrcadoDAO.FindByOrcamento(orcamento)
    End Function

    Public Shared Function DeleteByOrcamento(orcamento As Orcamento) As Boolean
        Return itemOrcadoDAO.DeleteByOrcamento(orcamento)
    End Function

End Class