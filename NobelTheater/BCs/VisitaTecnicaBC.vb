﻿Option Explicit On
Option Strict On

Public Class VisitaTecnicaBC

    Private Shared visitaTecnicaDAO As VisitaTecnicaDAO

    Public Sub New()
        visitaTecnicaDAO = New VisitaTecnicaDAO()
    End Sub

    Public Shared Function Validate(visitaTecnica As VisitaTecnica) As Boolean

        If (visitaTecnica Is Nothing) Then Return False
        If (visitaTecnica.NotaFiscal Is Nothing) Then Return False

        If (String.IsNullOrWhiteSpace(visitaTecnica.ParecerObra)) Then Return False
        If (visitaTecnica.Preco = 0.0) Then Return False

        If (TipoVisita.GetTiposList.Contains(visitaTecnica.Tipo) = False) Then Return False

        If (FuncionarioBC.Validate(visitaTecnica.Supervisor)) Then Return False

        If (visitaTecnica.Data = Nothing) Then Return False
        If (visitaTecnica.Data > Now) Then Return False

        Return True
    End Function

    Public Shared Function Insert(visitaTecnica As VisitaTecnica) As Boolean
        If (VisitaTecnicaBC.Validate(visitaTecnica)) Then
            Return visitaTecnicaDAO.Insert(visitaTecnica)
        End If
        Return False
    End Function

    Public Shared Function UpdateParecer(visita As VisitaTecnica) As Boolean
        If (VisitaTecnicaBC.Validate(visita)) Then
            Return visitaTecnicaDAO.UpdateParecer(visita)
        End If
        Return False
    End Function

    Public Shared Function FindByNotaFiscal(notaFiscal As NotaFiscalVenda) As List(Of VisitaTecnica)
        Return visitaTecnicaDAO.FindByNotaFiscal(notaFiscal)
    End Function

End Class