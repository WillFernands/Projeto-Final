Option Explicit On
Option Strict On

Public Class OrdemServicoBC

    Private Shared ordemServicoDAO As New OrdemServicoDAO

    Public Shared Function Validate(ordemServico As OrdemServico) As Boolean

        If (ordemServico Is Nothing) Then Return False
        If (ordemServico.DataSolicitacao = Nothing) Then Return False
        If (ordemServico.DataSolicitacao > Now) Then Return False

        If (StatusOrdem.GetStatusList.Contains(ordemServico.Status) = False) Then Return False

        If (FornecedorBC.Validate(ordemServico.Fornecedor) = False) Then Return False
        If (ClienteBC.Validate(ordemServico.Cliente) = False) Then Return False

        If (ordemServico.ItensOrdem Is Nothing) Then Return False

        For Each item As ItemOrdem In ordemServico.ItensOrdem
            If (ItemOrdemBC.Validate(item) = False) Then Return False
        Next

        Return True
    End Function

    Public Shared Function Insert(ordemServico As OrdemServico) As Long
        If (OrdemServicoBC.Validate(ordemServico)) Then
            Return ordemServicoDAO.Insert(ordemServico)
        End If
        Return 0
    End Function

    Public Shared Function UpdateStatus(ordemServico As OrdemServico) As Boolean
        If (OrdemServicoBC.Validate(ordemServico)) Then
            Return ordemServicoDAO.UpdateStatus(ordemServico)
        End If
        Return False
    End Function

    Public Shared Function FindByID(id As Long) As OrdemServico
        Return ordemServicoDAO.FindByID(id)
    End Function

    Public Shared Function FindByCliente(cliente As Cliente) As List(Of OrdemServico)
        Return ordemServicoDAO.FindByCliente(cliente)
    End Function

    Public Shared Function FindByFornecedor(fornecedor As Fornecedor) As List(Of OrdemServico)
        Return ordemServicoDAO.FindByFornecedor(fornecedor)
    End Function

End Class