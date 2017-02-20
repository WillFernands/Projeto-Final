﻿Option Explicit On
Option Strict On

Public Class RegistroPontoBC

    Private Shared registroPontoDAO As RegistroPontoDAO

    Public Sub New()
        registroPontoDAO = New RegistroPontoDAO()
    End Sub

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

    Public Shared Function FindByMatricula(matricula As Long) As List(Of RegistroPonto)
        Return registroPontoDAO.FindByMatricula(matricula)
    End Function

    Public Shared Function FindByMatricula(funcionario As Funcionario) As List(Of RegistroPonto)
        Return registroPontoDAO.FindByMatricula(funcionario)
    End Function

End Class