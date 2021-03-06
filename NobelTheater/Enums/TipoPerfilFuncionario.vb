﻿Option Explicit On
Option Strict On

Public NotInheritable Class TipoPerfilFuncionario
    Public Const Gerente As String = "Gerente"
    Public Const AssistenteAdm As String = "Assistente Administrativo"
    Public Const AssistenteCont As String = "Assistente Contabil"
    Public Const Vendedor As String = "Vendedor"
    Public Const Tecnico As String = "Tecnico"
    Public Const SupervisorObra As String = "Supervisor da Obra"
    Public Const Patrocinador As String = "Patrocinador"

    Public Shared Function GetTiposList() As List(Of String)
        Dim list As New List(Of String)
        list.Add(Gerente)
        list.Add(AssistenteAdm)
        list.Add(AssistenteCont)
        list.Add(Vendedor)
        list.Add(Tecnico)
        list.Add(SupervisorObra)
        list.Add(Patrocinador)
        Return list
    End Function
End Class
