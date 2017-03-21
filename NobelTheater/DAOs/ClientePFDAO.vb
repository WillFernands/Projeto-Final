Option Explicit On
Option Strict On

Imports System.Text

Public Class ClientePFDAO

    'OK
    Public Function Insert(ByVal cliente As ClientePF) As Boolean

        cliente.ID = ClienteBC.Insert(cliente)

        Dim conn As New Connection

        conn.AddParameter("@cpf", cliente.CPF)
        conn.AddParameter("@idCliente", cliente.ID)

        Return conn.ExecuteCommand("Insert INTO ClientesPF(cpf, idCliente) VALUES(@cpf, @idCliente);")

    End Function

    'OK
    Public Function Update(ByVal cliente As ClientePF) As Boolean

        If (ClienteBC.Update(cliente) = False) Then Return False

        Dim conn As New Connection

        conn.AddParameter("@cpf", cliente.CPF)
        conn.AddParameter("@idCliente", cliente.ID)

        Return conn.ExecuteCommand("UPDATE ClientesPF SET cpf = @cpf WHERE idCliente = @idCliente;")

    End Function

    'OK
    Public Function FindAll() As List(Of ClientePF)
        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT Clientes.id, Clientes.nome, Clientes.telefone, Clientes.dataCadastro, ClientesPF.cpf FROM Clientes ")
        query.Append("INNER JOIN ClientesPF On Clientes.id = ClientesPF.idCliente")

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of ClientePF)

        Dim clientes As New List(Of ClientePF)

        For Each row As DataRow In dt.Rows
            Dim cliente As New ClientePF()
            cliente.ID = CLng(row.Item("ID"))
            cliente.Nome = CStr(row.Item("Nome"))
            cliente.Telefone = CStr(row.Item("Telefone"))
            cliente.DataCadastro = CDate(row.Item("DataCadastro"))
            cliente.CPF = CStr(row.Item("CPF"))
            cliente.Enderecos = EnderecoClienteBC.FindByCliente(cliente)
            clientes.Add(cliente)
        Next

        Return clientes

    End Function

    Public Function FindByID(ByVal id As Long) As ClientePF

        If (id = 0) Then Return Nothing

        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT Clientes.id, Clientes.nome, Clientes.telefone, Clientes.dataCadastro, ClientesPF.cpf FROM Clientes ")
        query.Append("INNER JOIN ClientesPF On Clientes.id = ClientesPF.idCliente ")
        query.Append("WHERE Clientes.Id = @id")

        conn.AddParameter("@id", id)

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return Nothing

        Dim cliente As New ClientePF()
        cliente.ID = CLng(dt.Rows(0).Item("ID"))
        cliente.Nome = CStr(dt.Rows(0).Item("Nome"))
        cliente.Telefone = CStr(dt.Rows(0).Item("Telefone"))
        cliente.DataCadastro = CDate(dt.Rows(0).Item("DataCadastro"))
        cliente.CPF = CStr(dt.Rows(0).Item("CPF"))
        cliente.Enderecos = EnderecoClienteBC.FindByCliente(cliente)

        Return cliente
    End Function

    Public Function FindByCPF(ByVal cpf As String) As ClientePF

        If (String.IsNullOrWhiteSpace(cpf)) Then Return Nothing

        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT Clientes.id, Clientes.nome, Clientes.telefone, Clientes.dataCadastro, ClientesPF.cpf FROM Clientes ")
        query.Append("INNER JOIN ClientesPF On Clientes.id = ClientesPF.idCliente ")
        query.Append("WHERE ClientesPF.cpf = @cpf")

        conn.AddParameter("@cpf", cpf)

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return Nothing

        Dim cliente As New ClientePF()
        cliente.ID = CLng(dt.Rows(0).Item("ID"))
        cliente.Nome = CStr(dt.Rows(0).Item("Nome"))
        cliente.Telefone = CStr(dt.Rows(0).Item("Telefone"))
        cliente.DataCadastro = CDate(dt.Rows(0).Item("DataCadastro"))
        cliente.CPF = CStr(dt.Rows(0).Item("CPF"))
        cliente.Enderecos = EnderecoClienteBC.FindByCliente(cliente)

        Return cliente
    End Function

    Public Function FindByNome(ByVal nome As String) As ClientePF

        If (String.IsNullOrWhiteSpace(nome)) Then Return Nothing

        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT Clientes.id, Clientes.nome, Clientes.telefone, Clientes.dataCadastro, ClientesPF.cpf FROM Clientes ")
        query.Append("INNER JOIN ClientesPF On Clientes.id = ClientesPF.idCliente ")
        query.Append("WHERE Clientes.nome = @nome")

        conn.AddParameter("@nome", nome)

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return Nothing

        Dim cliente As New ClientePF()
        cliente.ID = CLng(dt.Rows(0).Item("ID"))
        cliente.Nome = CStr(dt.Rows(0).Item("Nome"))
        cliente.Telefone = CStr(dt.Rows(0).Item("Telefone"))
        cliente.DataCadastro = CDate(dt.Rows(0).Item("DataCadastro"))
        cliente.CPF = CStr(dt.Rows(0).Item("CPF"))
        cliente.Enderecos = EnderecoClienteBC.FindByCliente(cliente)

        Return cliente
    End Function
End Class

