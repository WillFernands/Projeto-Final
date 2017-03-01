﻿Option Explicit On
Option Strict On

Imports System.Text

Public Class RegistroPontoDAO

    'OK
    Public Function Insert(ByVal registro As RegistroPonto) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO RegistrosPontos(dataRegistro, tipo, matriculaFuncionario) ")
        strSQL.Append("VALUES(@data, @tipo, @matricula);")

        conn.AddParameter("@data", registro.DataRegistro)
        conn.AddParameter("@tipo", registro.Tipo)
        conn.AddParameter("@matricula", registro.Funcionario)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindByMatricula(matricula As Long) As List(Of RegistroPonto)

        If (matricula = 0) Then Return Nothing

        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT dataRegistro, tipo FROM RegistrosPontos ")
        strSQL.Append("WHERE matriculaFuncionario = @matricula ")
        strSQL.Append("ORDER BY dataRegistro DESC")

        conn.AddParameter("@matricula", matricula)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of RegistroPonto)

        Dim funcionarioDAO As New FuncionarioDAO()

        Dim registros As New List(Of RegistroPonto)

        For Each row As DataRow In dt.Rows
            Dim registro As New RegistroPonto()
            registro.DataRegistro = CDate(row.Item("dataRegistro"))
            registro.Tipo = CStr(row.Item("tipo"))
            registro.Funcionario = funcionarioDAO.FindByMatricula(CLng(row.Item("matriculaFuncionario")))
            registros.Add(registro)
        Next

        Return registros

    End Function

    'OK
    Public Function FindByMatricula(funcionario As Funcionario) As List(Of RegistroPonto)

        If (funcionario Is Nothing) Then Return Nothing

        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT dataRegistro, tipo FROM RegistrosPontos ")
        strSQL.Append("WHERE matriculaFuncionario = @matricula ")
        strSQL.Append("ORDER BY dataRegistro DESC")

        conn.AddParameter("@matricula", funcionario.Matricula)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of RegistroPonto)

        Dim registros As New List(Of RegistroPonto)

        For Each row As DataRow In dt.Rows
            Dim registro As New RegistroPonto()
            registro.DataRegistro = CDate(row.Item("dataRegistro"))
            registro.Tipo = CStr(row.Item("tipo"))
            registro.Funcionario = funcionario
            registros.Add(registro)
        Next

        Return registros

    End Function

End Class


