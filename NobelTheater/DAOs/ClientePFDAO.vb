Option Explicit On
Option Strict On

Imports System.Text

Public Class ClientePFDAO

    'OK
    Public Function Insert(ByVal cliente As ClientePF) As Boolean

        Dim clienteDAO As New ClienteDAO

        cliente.ID = clienteDAO.Insert(cliente)

        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("Insert INTO ClientesPF(cpf, idCliente) ")
        strSQL.Append("VALUES(@cpf, @idCliente);")

        conn.AddParameter("@cpf", cliente.CPF)
        conn.AddParameter("@idCliente", cliente.ID)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function Update(ByVal cliente As ClientePF) As Boolean

        Dim clienteDAO As New ClienteDAO

        If (clienteDAO.Update(cliente) = False) Then Return False

        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE ClientesPF SET cpf = @cpf ")
        strSQL.Append("WHERE idCliente = @idCliente;")

        conn.AddParameter("@cpf", cliente.CPF)
        conn.AddParameter("@idCliente", cliente.ID)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindAll() As List(Of ClientePF)
        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT Clientes.id, Clientes.nome, Clientes.telefone, Clientes.dataCadastro, ClientesPF.cpf FROM Clientes ")
        query.Append("INNER JOIN ClientesPF On Clientes.id = ClientesPF.idCliente")

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)

        Dim clientes As New List(Of ClientePF)

        For Each row As DataRow In dt.Rows
            Dim cliente As New ClientePF()
            cliente.ID = CLng(row.Item("ID"))
            cliente.Nome = CStr(row.Item("Nome"))
            cliente.Telefone = CStr(row.Item("Telefone"))
            cliente.DataCadastro = CDate(row.Item("DataCadastro"))
            cliente.CPF = CStr(row.Item("CPF"))
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

        Dim cliente As New ClientePF()
        cliente.ID = CLng(dt.Rows(0).Item("ID"))
        cliente.Nome = CStr(dt.Rows(0).Item("Nome"))
        cliente.Telefone = CStr(dt.Rows(0).Item("Telefone"))
        cliente.DataCadastro = CDate(dt.Rows(0).Item("DataCadastro"))
        cliente.CPF = CStr(dt.Rows(0).Item("CPF"))

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

        Dim cliente As New ClientePF()
        cliente.ID = CLng(dt.Rows(0).Item("ID"))
        cliente.Nome = CStr(dt.Rows(0).Item("Nome"))
        cliente.Telefone = CStr(dt.Rows(0).Item("Telefone"))
        cliente.DataCadastro = CDate(dt.Rows(0).Item("DataCadastro"))
        cliente.CPF = CStr(dt.Rows(0).Item("CPF"))

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

        Dim cliente As New ClientePF()
        cliente.ID = CLng(dt.Rows(0).Item("ID"))
        cliente.Nome = CStr(dt.Rows(0).Item("Nome"))
        cliente.Telefone = CStr(dt.Rows(0).Item("Telefone"))
        cliente.DataCadastro = CDate(dt.Rows(0).Item("DataCadastro"))
        cliente.CPF = CStr(dt.Rows(0).Item("CPF"))

        Return cliente
    End Function
End Class

