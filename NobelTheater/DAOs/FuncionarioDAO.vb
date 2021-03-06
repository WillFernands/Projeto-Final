﻿Option Explicit On
Option Strict On

Imports System.Text

Public Class FuncionarioDAO

    'OK
    Public Function Insert(ByVal funcionario As Funcionario) As Long
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO Funcionarios(cpf, nome, telefone, dataContratacao, perfil, cargo, logradouro, numero, bairro, cidade, estado, cep, tipoEndereco, senha) ")
        strSQL.Append("VALUES(@cpf, @nome, @telefone, @dataContratacao, @perfil, @cargo, @logradouro, @numero, @bairro, @cidade, @estado, @cep, @tipoEndereco, @senha);")

        conn.AddParameter("@cpf", funcionario.Cpf)
        conn.AddParameter("@nome", funcionario.Nome)
        conn.AddParameter("@telefone", funcionario.Telefone)
        conn.AddParameter("@dataContratacao", funcionario.DataContratacao)
        conn.AddParameter("@perfil", funcionario.Perfil)
        conn.AddParameter("@cargo", funcionario.Cargo)
        conn.AddParameter("@logradouro", funcionario.Logradouro)
        conn.AddParameter("@numero", funcionario.Numero)
        conn.AddParameter("@bairro", funcionario.Bairro)
        conn.AddParameter("@cidade", funcionario.Cidade)
        conn.AddParameter("@estado", funcionario.Estado)
        conn.AddParameter("@cep", funcionario.Cep)
        conn.AddParameter("@tipoEndereco", funcionario.TipoEndereco)
        conn.AddParameter("@senha", GenericUtils.GenerateSenha)

        If (conn.ExecuteCommand(strSQL.ToString) = False) Then Return 0

        conn = New Connection
        Return CLng(conn.ExecuteScalar("SELECT IDENT_CURRENT('Funcionarios')"))

    End Function

    'OK
    Public Function Update(ByVal funcionario As Funcionario) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE funcionarios ")
        strSQL.Append("SET cpf = @cpf, ")
        strSQL.Append("nome = @nome, ")
        strSQL.Append("telefone = @telefone, ")
        strSQL.Append("dataContratacao = @dataContratacao, ")
        strSQL.Append("perfil = @perfil, ")
        strSQL.Append("cargo = @cargo, ")
        strSQL.Append("logradouro = @logradouro, ")
        strSQL.Append("numero = @numero, ")
        strSQL.Append("bairro = @bairro, ")
        strSQL.Append("cidade = @cidade, ")
        strSQL.Append("estado = @estado, ")
        strSQL.Append("cep = @cep, ")
        strSQL.Append("tipoEndereco = @tipoEndereco, ")
        strSQL.Append("matriculaSupervisor = @matriculaSupervisor ")
        strSQL.Append("WHERE matricula = @matricula;")

        conn.AddParameter("@cpf", funcionario.CPF)
        conn.AddParameter("@nome", funcionario.Nome)
        conn.AddParameter("@telefone", funcionario.Telefone)
        conn.AddParameter("@dataContratacao", funcionario.DataContratacao)
        conn.AddParameter("@perfil", funcionario.Perfil)
        conn.AddParameter("@cargo", funcionario.Cargo)
        conn.AddParameter("@logradouro", funcionario.Logradouro)
        conn.AddParameter("@numero", funcionario.Numero)
        conn.AddParameter("@bairro", funcionario.Bairro)
        conn.AddParameter("@cidade", funcionario.Cidade)
        conn.AddParameter("@estado", funcionario.Estado)
        conn.AddParameter("@cep", funcionario.CEP)
        conn.AddParameter("@tipoEndereco", funcionario.TipoEndereco)
        conn.AddParameter("@matriculaSupervisor", funcionario.Supervisor.Matricula)
        conn.AddParameter("@matricula", funcionario.Matricula)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function UpdateSupervisor(ByVal funcionario As Funcionario) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE funcionarios ")
        strSQL.Append("SET matriculaSupervisor = @matriculaSupervisor ")
        strSQL.Append("WHERE matricula = @matricula;")

        conn.AddParameter("@matricula", funcionario.Matricula)
        conn.AddParameter("@matriculaSupervisor", funcionario.Supervisor.Matricula)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function RevogarAcesso(ByVal funcionario As Funcionario) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE funcionarios ")
        strSQL.Append("SET revogado = 1, ")
        strSQL.Append("dataRevogacao = @dataRevogacao, ")
        strSQL.Append("senha = @senha, ")
        strSQL.Append("WHERE matricula = @matricula;")

        conn.AddParameter("@senha", GenericUtils.GenerateSenha)
        conn.AddParameter("@dataRevogacao", Now)
        conn.AddParameter("@matricula", funcionario.Matricula)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function ResetarSenha(ByVal funcionario As Funcionario) As String
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE funcionarios ")
        strSQL.Append("SET senha = @senha, ")
        strSQL.Append("revogado = 0, ")
        strSQL.Append("dataRevogacao = NULL ")
        strSQL.Append("WHERE matricula = @matricula;")

        conn.AddParameter("@matricula", funcionario.Matricula)
        conn.AddParameter("@senha", GenericUtils.GenerateSenha())

        If (conn.ExecuteCommand(strSQL.ToString) = False) Then Return ""

        strSQL.Clear()
        conn = New Connection

        strSQL.Append("SELECT senha FROM funcionarios where matricula = @mat")
        conn.AddParameter("@mat", funcionario.Matricula)

        Return CStr(conn.ExecuteScalar(strSQL.ToString))

    End Function

    'OK
    Public Function UpdateSenha(ByVal funcionario As Funcionario) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE funcionarios ")
        strSQL.Append("SET senha = @senha ")
        strSQL.Append("WHERE matricula = @matricula;")

        conn.AddParameter("@matricula", funcionario.Matricula)
        conn.AddParameter("@senha", funcionario.Senha)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindByMatricula(matricula As Long) As Funcionario

        If (matricula = 0) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@matricula", matricula)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM funcionarios WHERE matricula = @matricula;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return Nothing

        Dim funcionario As New Funcionario()
        funcionario.Matricula = matricula
        funcionario.Cpf = CStr(dt.Rows(0).Item("cpf"))
        funcionario.Nome = CStr(dt.Rows(0).Item("nome"))
        funcionario.Telefone = CStr(dt.Rows(0).Item("telefone"))
        funcionario.DataContratacao = CDate(dt.Rows(0).Item("dataContratacao"))
        funcionario.Perfil = CStr(dt.Rows(0).Item("perfil"))
        funcionario.Cargo = CStr(dt.Rows(0).Item("cargo"))
        funcionario.Logradouro = CStr(dt.Rows(0).Item("logradouro"))
        funcionario.Numero = CStr(dt.Rows(0).Item("numero"))
        funcionario.Bairro = CStr(dt.Rows(0).Item("bairro"))
        funcionario.Cidade = CStr(dt.Rows(0).Item("cidade"))
        funcionario.Estado = CStr(dt.Rows(0).Item("estado"))
        funcionario.Cep = CStr(dt.Rows(0).Item("cep"))
        funcionario.TipoEndereco = CStr(dt.Rows(0).Item("tipoEndereco"))
        funcionario.Revogado = CBool(dt.Rows(0).Item("revogado"))
        If (funcionario.Revogado) Then
            funcionario.DataRevogacao = CDate(dt.Rows(0).Item("dataRevogacao"))
        End If
        funcionario.Supervisor = FindSupervisorByMatricula(CLng(dt.Rows(0).Item("matriculaSupervisor")))
        funcionario.Salarios = SalarioBC.FindByMatricula(funcionario)
        Return funcionario

    End Function

    'OK
    Public Function FindBySupervisor(supervisor As Funcionario) As List(Of Funcionario)

        If (supervisor Is Nothing) Then Return Nothing

        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM Funcionarios ")
        strSQL.Append("WHERE matriculaSupervisor = @matricula AND matricula != @matricula2;")

        conn.AddParameter("@matricula", supervisor.Matricula)
        conn.AddParameter("@matricula2", supervisor.Matricula)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of Funcionario)

        Dim funcionarios As New List(Of Funcionario)

        For Each row As DataRow In dt.Rows
            Dim funcionario As New Funcionario()
            funcionario.Matricula = CLng(row.Item("matricula"))
            funcionario.Cpf = CStr(row.Item("cpf"))
            funcionario.Nome = CStr(row.Item("nome"))
            funcionario.Telefone = CStr(row.Item("telefone"))
            funcionario.DataContratacao = CDate(row.Item("dataContratacao"))
            funcionario.Perfil = CStr(row.Item("perfil"))
            funcionario.Cargo = CStr(row.Item("cargo"))
            funcionario.Logradouro = CStr(row.Item("logradouro"))
            funcionario.Numero = CStr(row.Item("numero"))
            funcionario.Bairro = CStr(row.Item("bairro"))
            funcionario.Cidade = CStr(row.Item("cidade"))
            funcionario.Estado = CStr(row.Item("estado"))
            funcionario.Cep = CStr(row.Item("cep"))
            funcionario.TipoEndereco = CStr(row.Item("tipoEndereco"))
            funcionario.Revogado = CBool(dt.Rows(0).Item("revogado"))
            If (funcionario.Revogado) Then
                funcionario.DataRevogacao = CDate(dt.Rows(0).Item("dataRevogacao"))
            End If
            funcionario.Supervisor = supervisor
            funcionario.Salarios = SalarioBC.FindByMatricula(funcionario)
            funcionarios.Add(funcionario)
        Next

        Return funcionarios

    End Function

    'OK
    Public Function FindAcessosRevogados(supervisor As Funcionario) As List(Of Funcionario)

        If (supervisor Is Nothing) Then Return Nothing

        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM Funcionarios ")
        strSQL.Append("WHERE matriculaSupervisor = @matricula AND revogado = 1 AND matricula != @matricula2;")

        conn.AddParameter("@matricula", supervisor.Matricula)
        conn.AddParameter("@matricula2", supervisor.Matricula)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of Funcionario)

        Dim funcionarios As New List(Of Funcionario)

        For Each row As DataRow In dt.Rows
            Dim funcionario As New Funcionario()
            funcionario.Matricula = CLng(row.Item("matricula"))
            funcionario.Cpf = CStr(row.Item("cpf"))
            funcionario.Nome = CStr(row.Item("nome"))
            funcionario.Telefone = CStr(row.Item("telefone"))
            funcionario.DataContratacao = CDate(row.Item("dataContratacao"))
            funcionario.Perfil = CStr(row.Item("perfil"))
            funcionario.Cargo = CStr(row.Item("cargo"))
            funcionario.Logradouro = CStr(row.Item("logradouro"))
            funcionario.Numero = CStr(row.Item("numero"))
            funcionario.Bairro = CStr(row.Item("bairro"))
            funcionario.Cidade = CStr(row.Item("cidade"))
            funcionario.Estado = CStr(row.Item("estado"))
            funcionario.Cep = CStr(row.Item("cep"))
            funcionario.TipoEndereco = CStr(row.Item("tipoEndereco"))
            funcionario.Revogado = CBool(dt.Rows(0).Item("revogado"))
            If (funcionario.Revogado) Then
                funcionario.DataRevogacao = CDate(dt.Rows(0).Item("dataRevogacao"))
            End If
            funcionario.Supervisor = supervisor
            funcionario.Salarios = SalarioBC.FindByMatricula(funcionario)
            funcionarios.Add(funcionario)
        Next

        Return funcionarios

    End Function

    'OK
    Public Function FindAll() As List(Of Funcionario)
        Dim conn As New Connection

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM Funcionarios;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of Funcionario)

        Dim funcionarios As New List(Of Funcionario)

        For Each row As DataRow In dt.Rows
            Dim funcionario As New Funcionario()
            funcionario.Matricula = CLng(row.Item("matricula"))
            funcionario.Cpf = CStr(row.Item("cpf"))
            funcionario.Nome = CStr(row.Item("nome"))
            funcionario.Telefone = CStr(row.Item("telefone"))
            funcionario.DataContratacao = CDate(row.Item("dataContratacao"))
            funcionario.Perfil = CStr(row.Item("perfil"))
            funcionario.Cargo = CStr(row.Item("cargo"))
            funcionario.Logradouro = CStr(row.Item("logradouro"))
            funcionario.Numero = CStr(row.Item("numero"))
            funcionario.Bairro = CStr(row.Item("bairro"))
            funcionario.Cidade = CStr(row.Item("cidade"))
            funcionario.Estado = CStr(row.Item("estado"))
            funcionario.Cep = CStr(row.Item("cep"))
            funcionario.TipoEndereco = CStr(row.Item("tipoEndereco"))
            funcionario.Revogado = CBool(dt.Rows(0).Item("revogado"))
            If (funcionario.Revogado) Then
                funcionario.DataRevogacao = CDate(dt.Rows(0).Item("dataRevogacao"))
            End If
            funcionario.Supervisor = FindSupervisorByMatricula(CLng(dt.Rows(0).Item("matriculaSupervisor")))
            funcionario.Salarios = SalarioBC.FindByMatricula(funcionario)
            funcionarios.Add(funcionario)
        Next

        Return funcionarios

    End Function

    'OK
    Public Function FindByCPF(cpf As String) As Funcionario

        If (String.IsNullOrWhiteSpace(cpf)) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@cpf", cpf)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM funcionarios WHERE cpf = @cpf;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return Nothing

        Dim funcionario As New Funcionario()
        funcionario.Matricula = CLng(dt.Rows(0).Item("matricula"))
        funcionario.Cpf = CStr(dt.Rows(0).Item("cpf"))
        funcionario.Nome = CStr(dt.Rows(0).Item("nome"))
        funcionario.Telefone = CStr(dt.Rows(0).Item("telefone"))
        funcionario.DataContratacao = CDate(dt.Rows(0).Item("dataContratacao"))
        funcionario.Perfil = CStr(dt.Rows(0).Item("perfil"))
        funcionario.Cargo = CStr(dt.Rows(0).Item("cargo"))
        funcionario.Logradouro = CStr(dt.Rows(0).Item("logradouro"))
        funcionario.Numero = CStr(dt.Rows(0).Item("numero"))
        funcionario.Bairro = CStr(dt.Rows(0).Item("bairro"))
        funcionario.Cidade = CStr(dt.Rows(0).Item("cidade"))
        funcionario.Estado = CStr(dt.Rows(0).Item("estado"))
        funcionario.Cep = CStr(dt.Rows(0).Item("cep"))
        funcionario.TipoEndereco = CStr(dt.Rows(0).Item("tipoEndereco"))
        funcionario.Revogado = CBool(dt.Rows(0).Item("revogado"))
        If (funcionario.Revogado) Then
            funcionario.DataRevogacao = CDate(dt.Rows(0).Item("dataRevogacao"))
        End If
        funcionario.Supervisor = FindSupervisorByMatricula(CLng(dt.Rows(0).Item("matriculaSupervisor")))
        funcionario.Salarios = SalarioBC.FindByMatricula(funcionario)

        Return funcionario

    End Function

    'OK
    Public Function FindSupervisorByMatricula(matricula As Long) As Funcionario

        If (matricula = 0) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@matricula", matricula)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM funcionarios WHERE matricula = @matricula;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return Nothing

        Dim funcionario As New Funcionario()
        funcionario.Matricula = CLng(dt.Rows(0).Item("matricula"))
        funcionario.Cpf = CStr(dt.Rows(0).Item("cpf"))
        funcionario.Nome = CStr(dt.Rows(0).Item("nome"))
        funcionario.Telefone = CStr(dt.Rows(0).Item("telefone"))
        funcionario.DataContratacao = CDate(dt.Rows(0).Item("dataContratacao"))
        funcionario.Perfil = CStr(dt.Rows(0).Item("perfil"))
        funcionario.Cargo = CStr(dt.Rows(0).Item("cargo"))
        funcionario.Logradouro = CStr(dt.Rows(0).Item("logradouro"))
        funcionario.Numero = CStr(dt.Rows(0).Item("numero"))
        funcionario.Bairro = CStr(dt.Rows(0).Item("bairro"))
        funcionario.Cidade = CStr(dt.Rows(0).Item("cidade"))
        funcionario.Estado = CStr(dt.Rows(0).Item("estado"))
        funcionario.Cep = CStr(dt.Rows(0).Item("cep"))
        funcionario.TipoEndereco = CStr(dt.Rows(0).Item("tipoEndereco"))
        funcionario.Revogado = CBool(dt.Rows(0).Item("revogado"))
        If (funcionario.Revogado) Then
            funcionario.DataRevogacao = CDate(dt.Rows(0).Item("dataRevogacao"))
        End If
        funcionario.Supervisor = funcionario
        funcionario.Salarios = SalarioBC.FindByMatricula(funcionario)

        Return funcionario

    End Function

    Public Function VerifyPassword(ByVal func As Funcionario) As Boolean
        Dim conn As New Connection

        If (func Is Nothing OrElse func.Matricula = 0) Then Return False

        conn.AddParameter("@mat", func.Matricula)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT Senha FROM Funcionarios WHERE Matricula = @mat")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return False

        If (func.Senha.Equals(dt.Rows(0).Item("Senha"))) Then Return True

        Return False
    End Function

    Public Function RetrieveSenha(ByVal func As Funcionario) As String
        Dim conn As New Connection

        If (func Is Nothing OrElse func.Matricula = 0) Then Return ""

        conn.AddParameter("@mat", func.Matricula)

        Dim senha As String = CStr(conn.ExecuteScalar("SELECT Senha FROM Funcionarios WHERE Matricula = @mat"))

        If (senha Is Nothing) Then Return ""

        Return senha

    End Function

    Public Function IsRevogado(ByVal func As Funcionario) As Boolean
        Dim conn As New Connection

        If (func Is Nothing OrElse func.Matricula = 0) Then Return True

        conn.AddParameter("@mat", func.Matricula)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT Revogado FROM Funcionarios WHERE Matricula = @mat")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return True

        If (CInt(dt.Rows(0).Item("Revogado")) = 1) Then Return True

        Return False
    End Function

End Class