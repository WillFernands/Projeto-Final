Option Explicit On
Option Strict On

Imports System.Text

Public Class SalarioDAO
    'Ao Inserir o novo salário inserir também Now no antigo 
    Public Function Insert(ByVal salario As Salario) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO Salarios(matriculaFuncionario, valor, inicio, fim, motivo) ")
        strSQL.Append("VALUES(@matricula, @valor, @inicio, @fim, @motivo);")

        conn.AddParameter("@matricula", salario.Funcionario.Matricula)
        conn.AddParameter("@valor", salario.Valor)
        conn.AddParameter("@inicio", salario.Inicio)
        If (salario.Fim = Nothing) Then
            conn.AddParameter("@fim", DBNull.Value)
        Else : conn.AddParameter("@fim", salario.Fim)
        End If
        conn.AddParameter("@motivo", salario.Motivo)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindByMatricula(funcionario As Funcionario) As List(Of Salario)

        If (funcionario Is Nothing) Then Return Nothing

        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT valor, inicio, fim, motivo FROM Salarios ")
        strSQL.Append("WHERE matriculaFuncionario = @matricula ")
        strSQL.Append("ORDER BY inicio ASC")

        conn.AddParameter("@matricula", funcionario.Matricula)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        Dim salarios As New List(Of Salario)

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of Salario)

        For Each row As DataRow In dt.Rows
            Dim salario As New Salario()
            salario.Valor = CDbl(row.Item("valor"))
            salario.Inicio = CDate(row.Item("inicio"))
            If (IsDBNull(row.Item("fim"))) Then
                salario.Fim = Nothing
            Else : salario.Fim = CDate(row.Item("fim"))
            End If
            salario.Motivo = CStr(row.Item("motivo"))
            salario.funcionario = funcionario
            salarios.Add(salario)
        Next

        Return salarios

    End Function

    'OK
    Public Function DeleteByMatricula(funcionario As Funcionario) As Boolean

        If (funcionario Is Nothing) Then Return False

        Dim conn As New Connection

        conn.AddParameter("@matricula", funcionario.Matricula)

        Return conn.ExecuteCommand("DELETE Salarios WHERE matriculaFuncionario = @matricula;")

    End Function

End Class