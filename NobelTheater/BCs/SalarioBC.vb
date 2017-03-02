Option Explicit On
Option Strict On

Public Class SalarioBC

    Private Shared salarioDAO As New SalarioDAO

    Public Shared Function Validate(salario As Salario) As Boolean

        If (salario Is Nothing) Then Return False
        If (salario.funcionario Is Nothing) Then Return False
        If (String.IsNullOrWhiteSpace(salario.Motivo)) Then Return False
        If (salario.Inicio = Nothing) Then Return False
        If (salario.Inicio > Now) Then Return False
        If (salario.Valor = 0.0) Then Return False

        Return True
    End Function

    Public Shared Function Insert(salario As Salario) As Boolean
        If (SalarioBC.Validate(salario)) Then
            Return salarioDAO.Insert(salario)
        End If
        Return False
    End Function

    Public Shared Function FindByMatricula(matricula As Long) As List(Of Salario)
        Return salarioDAO.FindByMatricula(matricula)
    End Function

    Public Shared Function FindByMatricula(funcionario As Funcionario) As List(Of Salario)
        Return salarioDAO.FindByMatricula(funcionario)
    End Function

End Class