Option Explicit On
Option Strict On

Public Class AlertaBC

    Private Shared alertaDAO As AlertaDAO

    Public Sub New()
        alertaDAO = New AlertaDAO()
    End Sub

    Public Shared Function Validate(alerta As Alerta) As Boolean
        If (alerta Is Nothing) Then Return False
        If (alerta.Data = Nothing) Then Return False
        If (alerta.Data > Now) Then Return False
        If (alerta.Observacao Is Nothing) Then Return False
        If (alerta.Produto Is Nothing) Then Return False
        If (ProdutoBC.Validate(alerta.Produto) = False) Then Return False

        Return True
    End Function

    Public Shared Function Insert(alerta As Alerta) As Boolean
        If (AlertaBC.Validate(alerta)) Then
            Return alertaDAO.Insert(alerta)
        End If
        Return False
    End Function

    Public Shared Function Update(alerta As Alerta) As Boolean
        If (AlertaBC.Validate(alerta)) Then
            Return alertaDAO.Update(alerta)
        End If
        Return False
    End Function

    Public Shared Function FindAll() As List(Of Alerta)
        Return alertaDAO.FindAll()
    End Function

    Public Shared Function FindByProduto(produto As Produto) As List(Of Alerta)
        Return alertaDAO.FindByProduto(produto)
    End Function

    Public Shared Function FindByData(data As Date) As List(Of Alerta)
        Return alertaDAO.FindByData(data)
    End Function

    Public Shared Function Delete(alerta As Alerta) As Boolean
        Return alertaDAO.Delete(alerta)
    End Function

End Class