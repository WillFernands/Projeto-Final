Option Explicit On
Option Strict On

Public Class RegistroPontoBC

    Private Shared registroPontoDAO As New RegistroPontoDAO

    Public Shared Function Validate(registroPonto As RegistroPonto) As Boolean
        If (registroPonto Is Nothing) Then Return False
        If (registroPonto.Funcionario Is Nothing) Then Return False
        If (registroPonto.DataRegistro = Nothing) Then Return False
        If (registroPonto.DataRegistro > Now) Then Return False
        If (TipoRegistro.GetTiposList.Contains(registroPonto.Tipo) = False) Then Return False
        Return True
    End Function

    Public Shared Function Insert(registroPonto As RegistroPonto) As Boolean
        If (RegistroPontoBC.Validate(registroPonto)) Then
            Return registroPontoDAO.Insert(registroPonto)
        End If
        Return False
    End Function

    Public Shared Function FindByMatricula(matricula As Long, inicio As Date, fim As Date) As List(Of RegistroPonto)
        Return registroPontoDAO.FindByMatricula(matricula, inicio, fim)
    End Function

    Public Shared Function FindByMatricula(funcionario As Funcionario, inicio As Date, fim As Date) As List(Of RegistroPonto)
        Return registroPontoDAO.FindByMatricula(funcionario, inicio, fim)
    End Function

End Class