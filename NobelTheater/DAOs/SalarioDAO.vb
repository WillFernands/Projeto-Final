Option Explicit On
Option Strict On

Imports System.Text

Public Class SalarioDAO
    'OK
    Public Function Insert(ByVal salario As Salario) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO Salarios(matriculaFuncionario, valor, inicio, fim, motivo) ")
        strSQL.Append("VALUES(@matricula, @valor, @inicio, @fim, @motivo);")

        conn.AddParameter("@matricula", salario.Funcionario.Matricula)
        conn.AddParameter("@valor", salario.Valor)
        conn.AddParameter("@inicio", salario.Inicio)
        conn.AddParameter("@fim", salario.Fim)
        conn.AddParameter("@motivo", salario.Motivo)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindByMatricula(matricula As Long) As List(Of Salario)
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT valor, inicio, fim, motivo FROM Salarios ")
        strSQL.Append("WHERE matriculaFuncionario = @matricula;")
        strSQL.Append("ORDER BY dataRegistro DESC")

        conn.AddParameter("@matricula", matricula)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        Dim salarios As New List(Of Salario)

        For Each row As DataRow In dt.Rows
            Dim salario As New Salario()
            salario.Valor = CDbl(row.Item("valor"))
            salario.Inicio = CDate(row.Item("inicio"))
            salario.Fim = CDate(row.Item("fim"))
            salario.Motivo = CDate(row.Item("motivo"))
            salario.Funcionario = FuncionarioDAO.FindByMatricula(CLng(row.Item("matriculaFuncionario")))
            salarios.Add(salario)
        Next

        Return salarios

    End Function

    'OK
    Public Function FindByMatricula(funcionario As Funcionario) As List(Of Salario)
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT valor, inicio, fim, motivo FROM Salarios ")
        strSQL.Append("WHERE matriculaFuncionario = @matricula ")
        strSQL.Append("ORDER BY dataRegistro DESC")

        conn.AddParameter("@matricula", funcionario.Matricula)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        Dim salarios As New List(Of Salario)

        For Each row As DataRow In dt.Rows
            Dim salario As New Salario()
            salario.Valor = CDbl(row.Item("valor"))
            salario.Inicio = CDate(row.Item("inicio"))
            salario.Fim = CDate(row.Item("fim"))
            salario.Motivo = CDate(row.Item("motivo"))
            salario.Funcionario = funcionario
            salarios.Add(salario)
        Next

        Return salarios

    End Function

End Class