Option Explicit On
Option Strict On

Imports System.Text

Public Class EnderecoClienteDAO

    'OK
    Public Function Insert(ByVal endereco As EnderecoCliente) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO EnderecosClientes(idCliente, logradouro, numero, bairro, cidade, estado, cep, tipo) ")
        strSQL.Append("VALUES(@idCliente, @logradouro, @numero, @bairro, @cidade, @estado, @cep, @tipo);")

        conn.AddParameter("@idCliente", endereco.Cliente.ID)
        conn.AddParameter("@logradouro", endereco.Logradouro)
        conn.AddParameter("@numero", endereco.Numero)
        conn.AddParameter("@bairro", endereco.Bairro)
        conn.AddParameter("@cidade", endereco.Cidade)
        conn.AddParameter("@estado", endereco.Estado)
        conn.AddParameter("@cep", endereco.CEP)
        conn.AddParameter("@tipo", endereco.Tipo)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function Update(ByVal endereco As EnderecoCliente) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE EnderecosClientes ")
        strSQL.Append("SET logradouro = @logradouro, ")
        strSQL.Append("numero = @numero, ")
        strSQL.Append("bairro = @bairro, ")
        strSQL.Append("cidade = @cidade, ")
        strSQL.Append("estado = @estado, ")
        strSQL.Append("cep = @cep, ")
        strSQL.Append("tipo = @tipo ")
        strSQL.Append("WHERE id = @id;")

        conn.AddParameter("@logradouro", endereco.Logradouro)
        conn.AddParameter("@numero", endereco.Numero)
        conn.AddParameter("@bairro", endereco.Bairro)
        conn.AddParameter("@cidade", endereco.Cidade)
        conn.AddParameter("@estado", endereco.Estado)
        conn.AddParameter("@cep", endereco.CEP)
        conn.AddParameter("@tipo", endereco.Tipo)
        conn.AddParameter("@id", endereco.ID)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindByCliente(cliente As Cliente) As List(Of EnderecoCliente)
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM EnderecosClientes ")
        strSQL.Append("WHERE idCliente = @idCliente;")

        conn.AddParameter("@idCliente", cliente.ID)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        Dim enderecos As New List(Of EnderecoCliente)

        For Each row As DataRow In dt.Rows
            Dim endereco As New EnderecoCliente()
            endereco.Logradouro = CStr(row.Item("logradouro"))
            endereco.Numero = CStr(row.Item("numero"))
            endereco.Bairro = CStr(row.Item("bairro"))
            endereco.Cidade = CStr(row.Item("cidade"))
            endereco.Estado = CStr(row.Item("estado"))
            endereco.CEP = CStr(row.Item("cep"))
            endereco.Tipo = CStr(row.Item("tipo"))
            endereco.ID = CStr(row.Item("id"))
            endereco.Cliente = cliente

            enderecos.Add(endereco)
        Next

        Return enderecos

    End Function

    'OK
    Public Function Delete(ByVal endereco As EnderecoCliente) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("DELETE EnderecosClientes WHERE id = @id;")

        conn.AddParameter("@id", endereco.ID)

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

End Class