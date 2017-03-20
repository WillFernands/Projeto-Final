Option Explicit On
Option Strict On

Public Class OrcamentoBC

    Private Shared orcamentoDAO As New OrcamentoDAO

    Public Shared Function Validate(orcamento As Orcamento) As Boolean
        If (orcamento Is Nothing) Then Return False
        If (orcamento.DataOrcamento = Nothing) Then Return False
        If (orcamento.DataOrcamento > Now) Then Return False

        If (StatusOrcamento.GetStatusList.Contains(orcamento.Status) = False) Then Return False

        If (FuncionarioBC.Validate(orcamento.Vendedor) = False) Then Return False
        If (ClienteBC.Validate(orcamento.Cliente) = False) Then Return False

        Return True
    End Function

    Public Shared Function Insert(orcamento As Orcamento) As Long
        If (OrcamentoBC.Validate(orcamento)) Then
            Return orcamentoDAO.Insert(orcamento)
        End If
        Return 0
    End Function

    Public Shared Function UpdateStatus(orcamento As Orcamento) As Boolean
        If (OrcamentoBC.Validate(orcamento)) Then
            Return orcamentoDAO.UpdateStatus(orcamento)
        End If
        Return False
    End Function

    Public Shared Function FindByID(id As Long) As Orcamento
        Return orcamentoDAO.FindByID(id)
    End Function

    Public Shared Function FindByCliente(cliente As Cliente) As List(Of Orcamento)
        Return orcamentoDAO.FindByCliente(cliente)
    End Function

    Public Shared Function FindByVendedor(vendedor As Funcionario) As List(Of Orcamento)
        Return orcamentoDAO.FindByVendedor(vendedor)
    End Function

    Public Shared Function FindAll() As List(Of Orcamento)
        Return orcamentoDAO.FindAll()
    End Function

End Class