Option Explicit On
Option Strict On

Public Class FuncionarioBC

    Private Shared funcionarioDAO As New FuncionarioDAO

    Public Shared Function Validate(funcionario As Funcionario) As Boolean
        If (String.IsNullOrWhiteSpace(funcionario.Cpf)) Then Return False
        If (String.IsNullOrWhiteSpace(funcionario.Nome)) Then Return False
        If (String.IsNullOrWhiteSpace(funcionario.Telefone)) Then Return False
        If (String.IsNullOrWhiteSpace(funcionario.Cargo)) Then Return False
        If (funcionario.DataContratacao = Nothing) Then Return False
        If (funcionario.DataContratacao > Now) Then Return False

        If (String.IsNullOrWhiteSpace(funcionario.Logradouro)) Then Return False
        If (String.IsNullOrWhiteSpace(funcionario.Numero)) Then Return False
        If (String.IsNullOrWhiteSpace(funcionario.Cidade)) Then Return False
        If (String.IsNullOrWhiteSpace(funcionario.Estado)) Then Return False
        If (String.IsNullOrWhiteSpace(funcionario.Cep)) Then Return False
        If (TipoImovel.GetTiposList.Contains(funcionario.TipoEndereco) = False) Then Return False
        If (TipoPerfilFuncionario.GetTiposList.Contains(funcionario.Perfil) = False) Then Return False

        For Each item As Salario In funcionario.Salarios
            If (SalarioBC.Validate(item) = False) Then Return False
        Next

        For Each item As RegistroPonto In funcionario.RegistroPontos
            If (RegistroPontoBC.Validate(item) = False) Then Return False
        Next

        If (FuncionarioBC.ValidateSupervisor(funcionario.Supervisor) = False) Then Return False

        Return True
    End Function

    Public Shared Function ValidateSupervisor(funcionario As Funcionario) As Boolean
        If (String.IsNullOrWhiteSpace(funcionario.Cpf)) Then Return False
        If (String.IsNullOrWhiteSpace(funcionario.Nome)) Then Return False
        If (String.IsNullOrWhiteSpace(funcionario.Telefone)) Then Return False
        If (String.IsNullOrWhiteSpace(funcionario.Cargo)) Then Return False
        If (TipoPerfilFuncionario.GetTiposList.Contains(funcionario.Perfil) = False) Then Return False
        Return True
    End Function

    Public Shared Function Insert(funcionario As Funcionario) As Long
        If (FuncionarioBC.Validate(funcionario)) Then
            Return funcionarioDAO.Insert(funcionario)
        End If
        Return 0
    End Function

    Public Shared Function Update(funcionario As Funcionario) As Boolean
        If (FuncionarioBC.Validate(funcionario)) Then
            Return funcionarioDAO.Update(funcionario)
        End If
        Return False
    End Function

    Public Shared Function UpdateSupervisor(funcionario As Funcionario) As Boolean
        If (FuncionarioBC.Validate(funcionario)) Then
            Return funcionarioDAO.UpdateSupervisor(funcionario)
        End If
        Return False
    End Function

    Public Shared Function RevogarAcesso(funcionario As Funcionario) As Boolean
        If (FuncionarioBC.Validate(funcionario)) Then
            Return funcionarioDAO.RevogarAcesso(funcionario)
        End If
        Return False
    End Function

    Public Shared Function UpdateSenha(funcionario As Funcionario) As Boolean
        If (FuncionarioBC.Validate(funcionario)) Then
            Return funcionarioDAO.UpdateSenha(funcionario)
        End If
        Return False
    End Function

    Public Shared Function ResetarSenha(funcionario As Funcionario) As String
        If (FuncionarioBC.Validate(funcionario)) Then
            Return funcionarioDAO.ResetarSenha(funcionario)
        End If
        Return ""
    End Function

    Public Shared Function FindByMatricula(matricula As Long) As Funcionario
        Return funcionarioDAO.FindByMatricula(matricula)
    End Function

    Public Shared Function FindByCPF(cpf As String) As Funcionario
        Return funcionarioDAO.FindByCPF(cpf)
    End Function

    Public Shared Function FindSupervisorByMatricula(matricula As Long) As Funcionario
        Return funcionarioDAO.FindSupervisorByMatricula(matricula)
    End Function

    Public Shared Function FindBySupervisor(supervisor As Funcionario) As List(Of Funcionario)
        Return funcionarioDAO.FindBySupervisor(supervisor)
    End Function

    Public Shared Function FindAcessosRevogados(supervisor As Funcionario) As List(Of Funcionario)
        Return funcionarioDAO.FindAcessosRevogados(supervisor)
    End Function

    Public Shared Function FindAll() As List(Of Funcionario)
        Return funcionarioDAO.FindAll()
    End Function

    Public Shared Function VerifyPassword(funcionario As Funcionario) As Boolean
        Return funcionarioDAO.VerifyPassword(funcionario)
    End Function

    Public Shared Function IsRevogado(funcionario As Funcionario) As Boolean
        Return funcionarioDAO.IsRevogado(funcionario)
    End Function

End Class