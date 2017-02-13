﻿Option Explicit On
Option Strict On

Imports System.Text

Public Class FuncionarioDAO

    'OK
    Public Function Insert(ByVal funcionario As Funcionario) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO Funcionarios(cpf, nome, telefone, dataContratacao, perfil, cargo, logradouro, numero, bairro, cidade, estado, cep, tipoEndereco, matriculaSupervisor) ")
        strSQL.Append("VALUES(@cpf, @nome, @telefone, dataContratacao, @perfil, @cargo, @logradouro, @numero, @bairro, @cidade, @estado, @cep, @tipoEndereco, @matriculaSupervisor);")

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

        Return conn.ExecuteCommand(strSQL.ToString)

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

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindByMatricula(matricula As Long) As Funcionario
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM funcionarios ")
        strSQL.Append("WHERE matricula = @matricula;")

        conn.AddParameter("@matricula", matricula)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        Dim funcionario As New Funcionario()
        funcionario.CPF = CStr(dt.Rows(0).Item("cpf"))
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
        funcionario.CEP = CStr(dt.Rows(0).Item("cep"))
        funcionario.TipoEndereco = CStr(dt.Rows(0).Item("tipoEndereco"))
        funcionario.Supervisor = FindFuncionarioByMatricula(CLng(dt.Rows(0).Item("matriculaSupervisor")))

        Return funcionario

    End Function

    'OK
    Public Function FindByCPF(cpf As String) As Funcionario
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM funcionarios ")
        strSQL.Append("WHERE cpf = @cpf;")

        conn.AddParameter("@cpf", cpf)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        Dim funcionario As New Funcionario()
        funcionario.CPF = CStr(dt.Rows(0).Item("cpf"))
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
        funcionario.CEP = CStr(dt.Rows(0).Item("cep"))
        funcionario.TipoEndereco = CStr(dt.Rows(0).Item("tipoEndereco"))
        funcionario.Supervisor = FindFuncionarioByMatricula(CLng(dt.Rows(0).Item("matriculaSupervisor")))

        Return funcionario

    End Function

    'OK
    Public Function FindFuncionarioByMatricula(matricula As Long) As Funcionario
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM funcionarios ")
        strSQL.Append("WHERE matricula = @matricula;")

        conn.AddParameter("@matricula", matricula)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        Dim funcionario As New Funcionario()
        funcionario.CPF = CStr(dt.Rows(0).Item("cpf"))
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
        funcionario.CEP = CStr(dt.Rows(0).Item("cep"))
        funcionario.TipoEndereco = CStr(dt.Rows(0).Item("tipoEndereco"))
        funcionario.Supervisor = funcionario

        Return funcionario

    End Function

End Class