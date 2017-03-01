﻿Option Explicit On
Option Strict On

Imports System.Text

Public Class FornecedorDAO

    'OK
    Public Function Insert(ByVal fornecedor As Fornecedor) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO Fornecedores(cnpj, razaoSocial, nomeFantasia, telefone, inicioRelacionamento, tipoFornecedor, logradouro, numero, bairro, cidade, estado, cep, tipoEndereco, cnpjAssistencia) ")
        strSQL.Append("VALUES(@cnpj, @razaoSocial, @nomeFantasia, @telefone, inicioRelacionamento, @tipoFornecedor, @logradouro, @numero, @bairro, @cidade, @estado, @cep, @tipoEndereco, @cnpjAssistencia);")

        conn.AddParameter("@cnpj", fornecedor.CNPJ)
        conn.AddParameter("@razaoSocial", fornecedor.RazaoSocial)
        conn.AddParameter("@nomeFantasia", fornecedor.NomeFantasia)
        conn.AddParameter("@telefone", fornecedor.Telefone)
        conn.AddParameter("@inicioRelacionamento", fornecedor.InicioRelacionamento)
        conn.AddParameter("@tipoFornecedor", fornecedor.TipoFornecedor)
        conn.AddParameter("@logradouro", fornecedor.Logradouro)
        conn.AddParameter("@numero", fornecedor.Numero)
        conn.AddParameter("@bairro", fornecedor.Bairro)
        conn.AddParameter("@cidade", fornecedor.Cidade)
        conn.AddParameter("@estado", fornecedor.Estado)
        conn.AddParameter("@cep", fornecedor.CEP)
        conn.AddParameter("@tipoEndereco", fornecedor.TipoEndereco)
        conn.AddParameter("@cnpjAssistencia", fornecedor.Assistencia.CNPJ)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function Update(ByVal fornecedor As Fornecedor) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE Fornecedores ")
        strSQL.Append("SET razaoSocial = @razaoSocial, ")
        strSQL.Append("nomeFantasia = @nomeFantasia, ")
        strSQL.Append("telefone = @telefone, ")
        strSQL.Append("inicioRelacionamento = @inicioRelacionamento, ")
        strSQL.Append("tipoFornecedor = @tipoFornecedor, ")
        strSQL.Append("logradouro = @logradouro, ")
        strSQL.Append("numero = @numero, ")
        strSQL.Append("bairro = @bairro, ")
        strSQL.Append("cidade = @cidade, ")
        strSQL.Append("estado = @estado, ")
        strSQL.Append("cep = @cep, ")
        strSQL.Append("tipoEndereco = @tipoEndereco, ")
        strSQL.Append("cnpjAssistencia = @cnpjAssistencia ")
        strSQL.Append("WHERE cnpj = @cnpj;")

        conn.AddParameter("@razaoSocial", fornecedor.RazaoSocial)
        conn.AddParameter("@nomeFantasia", fornecedor.NomeFantasia)
        conn.AddParameter("@telefone", fornecedor.Telefone)
        conn.AddParameter("@inicioRelacionamento", fornecedor.InicioRelacionamento)
        conn.AddParameter("@tipoFornecedor", fornecedor.TipoFornecedor)
        conn.AddParameter("@logradouro", fornecedor.Logradouro)
        conn.AddParameter("@numero", fornecedor.Numero)
        conn.AddParameter("@bairro", fornecedor.Bairro)
        conn.AddParameter("@cidade", fornecedor.Cidade)
        conn.AddParameter("@estado", fornecedor.Estado)
        conn.AddParameter("@cep", fornecedor.CEP)
        conn.AddParameter("@tipoEndereco", fornecedor.TipoEndereco)
        conn.AddParameter("@cnpjAssistencia", fornecedor.Assistencia.CNPJ)
        conn.AddParameter("@cnpj", fornecedor.CNPJ)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindByCNPJ(cnpj As String) As Fornecedor

        If (String.IsNullOrWhiteSpace(cnpj)) Then Return Nothing

        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM Fornecedores ")
        strSQL.Append("WHERE cnpj = @cnpj;")

        conn.AddParameter("@cnpj", cnpj)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return Nothing

        Dim fornecedor As New Fornecedor()
        fornecedor.Cnpj = CStr(dt.Rows(0).Item("cnpj"))
        fornecedor.RazaoSocial = CStr(dt.Rows(0).Item("razaoSocial"))
        fornecedor.NomeFantasia = CStr(dt.Rows(0).Item("nomeFantasia"))
        fornecedor.Telefone = CStr(dt.Rows(0).Item("telefone"))
        fornecedor.InicioRelacionamento = CDate(dt.Rows(0).Item("inicioRelacionamento"))
        fornecedor.TipoFornecedor = CStr(dt.Rows(0).Item("tipoFornecedor"))
        fornecedor.Logradouro = CStr(dt.Rows(0).Item("logradouro"))
        fornecedor.Numero = CStr(dt.Rows(0).Item("numero"))
        fornecedor.Bairro = CStr(dt.Rows(0).Item("bairro"))
        fornecedor.Cidade = CStr(dt.Rows(0).Item("cidade"))
        fornecedor.Estado = CStr(dt.Rows(0).Item("estado"))
        fornecedor.Cep = CStr(dt.Rows(0).Item("cep"))
        fornecedor.TipoEndereco = CStr(dt.Rows(0).Item("tipoEndereco"))
        fornecedor.Assistencia = FindAssistenciaByCNPJ(CStr(dt.Rows(0).Item("cnpjAssistencia")))

        Return fornecedor

    End Function

    'OK
    Public Function FindByRazaoSocial(razaoSocial As String) As Fornecedor

        If (String.IsNullOrWhiteSpace(razaoSocial)) Then Return Nothing

        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM Fornecedores ")
        strSQL.Append("WHERE razaoSocial = @razaoSocial;")

        conn.AddParameter("@razaoSocial", razaoSocial)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return Nothing

        Dim fornecedor As New Fornecedor()
        fornecedor.Cnpj = CStr(dt.Rows(0).Item("cnpj"))
        fornecedor.RazaoSocial = CStr(dt.Rows(0).Item("razaoSocial"))
        fornecedor.NomeFantasia = CStr(dt.Rows(0).Item("nomeFantasia"))
        fornecedor.Telefone = CStr(dt.Rows(0).Item("telefone"))
        fornecedor.InicioRelacionamento = CDate(dt.Rows(0).Item("inicioRelacionamento"))
        fornecedor.TipoFornecedor = CStr(dt.Rows(0).Item("tipoFornecedor"))
        fornecedor.Logradouro = CStr(dt.Rows(0).Item("logradouro"))
        fornecedor.Numero = CStr(dt.Rows(0).Item("numero"))
        fornecedor.Bairro = CStr(dt.Rows(0).Item("bairro"))
        fornecedor.Cidade = CStr(dt.Rows(0).Item("cidade"))
        fornecedor.Estado = CStr(dt.Rows(0).Item("estado"))
        fornecedor.Cep = CStr(dt.Rows(0).Item("cep"))
        fornecedor.TipoEndereco = CStr(dt.Rows(0).Item("tipoEndereco"))
        fornecedor.Assistencia = FindAssistenciaByCNPJ(CStr(dt.Rows(0).Item("cnpjAssistencia")))

        Return fornecedor

    End Function

    'OK
    Public Function FindByNomeFantasia(nomeFantasia As String) As Fornecedor

        If (String.IsNullOrWhiteSpace(nomeFantasia)) Then Return Nothing

        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM Fornecedores ")
        strSQL.Append("WHERE nomeFantasia = @nomeFantasia;")

        conn.AddParameter("@nomeFantasia", nomeFantasia)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return Nothing

        Dim fornecedor As New Fornecedor()
        fornecedor.Cnpj = CStr(dt.Rows(0).Item("cnpj"))
        fornecedor.RazaoSocial = CStr(dt.Rows(0).Item("razaoSocial"))
        fornecedor.NomeFantasia = CStr(dt.Rows(0).Item("nomeFantasia"))
        fornecedor.Telefone = CStr(dt.Rows(0).Item("telefone"))
        fornecedor.InicioRelacionamento = CDate(dt.Rows(0).Item("inicioRelacionamento"))
        fornecedor.TipoFornecedor = CStr(dt.Rows(0).Item("tipoFornecedor"))
        fornecedor.Logradouro = CStr(dt.Rows(0).Item("logradouro"))
        fornecedor.Numero = CStr(dt.Rows(0).Item("numero"))
        fornecedor.Bairro = CStr(dt.Rows(0).Item("bairro"))
        fornecedor.Cidade = CStr(dt.Rows(0).Item("cidade"))
        fornecedor.Estado = CStr(dt.Rows(0).Item("estado"))
        fornecedor.Cep = CStr(dt.Rows(0).Item("cep"))
        fornecedor.TipoEndereco = CStr(dt.Rows(0).Item("tipoEndereco"))
        fornecedor.Assistencia = FindAssistenciaByCNPJ(CStr(dt.Rows(0).Item("cnpjAssistencia")))

        Return fornecedor

    End Function

    'OK
    Public Function FindAssistenciaByCNPJ(cnpj As String) As Fornecedor

        If (String.IsNullOrWhiteSpace(cnpj)) Then Return Nothing

        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM Fornecedores ")
        strSQL.Append("WHERE cnpj = @cnpj;")

        conn.AddParameter("@cnpj", cnpj)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return Nothing

        Dim fornecedor As New Fornecedor()
        fornecedor.CNPJ = CStr(dt.Rows(0).Item("cnpj"))
        fornecedor.RazaoSocial = CStr(dt.Rows(0).Item("razaoSocial"))
        fornecedor.NomeFantasia = CStr(dt.Rows(0).Item("nomeFantasia"))
        fornecedor.Telefone = CStr(dt.Rows(0).Item("telefone"))
        fornecedor.InicioRelacionamento = CDate(dt.Rows(0).Item("inicioRelacionamento"))
        fornecedor.TipoFornecedor = CStr(dt.Rows(0).Item("tipoFornecedor"))
        fornecedor.Logradouro = CStr(dt.Rows(0).Item("logradouro"))
        fornecedor.Numero = CStr(dt.Rows(0).Item("numero"))
        fornecedor.Bairro = CStr(dt.Rows(0).Item("bairro"))
        fornecedor.Cidade = CStr(dt.Rows(0).Item("cidade"))
        fornecedor.Estado = CStr(dt.Rows(0).Item("estado"))
        fornecedor.CEP = CStr(dt.Rows(0).Item("cep"))
        fornecedor.TipoEndereco = CStr(dt.Rows(0).Item("tipoEndereco"))
        fornecedor.Assistencia = fornecedor

        Return fornecedor

    End Function

End Class