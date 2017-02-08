Option Explicit On
Option Strict On

Imports System.Text

Public Class ClientePJDAO

    'OK
    Public Function Insert(ByVal cliente As ClientePJ) As Boolean

        Dim clienteDAO As New ClienteDAO

        cliente.ID = clienteDAO.Insert(cliente)

        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("Insert INTO ClientesPJ(cnpj, idCliente, razaoSocial) ")
        strSQL.Append("VALUES(@cnpj, @idCliente, @razaoSocial);")

        conn.AddParameter("@cnpj", cliente.CNPJ)
        conn.AddParameter("@idCliente", cliente.ID)
        conn.AddParameter("@razaoSocial", cliente.RazaoSocial)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function Update(ByVal cliente As ClientePJ) As Boolean

        Dim clienteDAO As New ClienteDAO

        If (clienteDAO.Update(cliente) = False) Then Return False

        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE ClientesPJ SET cnpj = @cnpj, razaoSocial = @razaoSocial ")
        strSQL.Append("WHERE idCliente = @idCliente;")

        conn.AddParameter("@cnpj", cliente.CNPJ)
        conn.AddParameter("@idCliente", cliente.ID)
        conn.AddParameter("@razaoSocial", cliente.RazaoSocial)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindAll() As List(Of ClientePJ)
        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT Clientes.id, Clientes.nome, Clientes.telefone, Clientes.dataCadastro, ClientesPJ.cnpj, ClientesPJ.razaoSocial FROM Clientes ")
        query.Append("INNER JOIN ClientesPJ On Clientes.id = ClientesPJ.idCliente")

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)

        Dim clientes As New List(Of ClientePJ)

        For Each row As DataRow In dt.Rows
            Dim cliente As New ClientePJ()
            cliente.ID = CLng(row.Item("id"))
            cliente.Nome = CStr(row.Item("nome"))
            cliente.Telefone = CStr(row.Item("telefone"))
            cliente.DataCadastro = CDate(row.Item("dataCadastro"))
            cliente.CNPJ = CLng(row.Item("cnpj"))
            cliente.RazaoSocial = CStr(row.Item("razaoSocial"))
            clientes.Add(cliente)
        Next

        Return clientes

    End Function

    Public Function FindByID(ByVal id As Long) As ClientePJ

        If (id = 0) Then Return Nothing

        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT Clientes.id, Clientes.nome, Clientes.telefone, Clientes.dataCadastro, ClientesPJ.cnpj, ClientesPJ.razaoSocial FROM Clientes ")
        query.Append("INNER JOIN ClientesPJ On Clientes.id = ClientesPJ.idCliente ")
        query.Append("WHERE Clientes.Id = @id")

        conn.AddParameter("@id", id)

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)

        Dim cliente As New ClientePJ()
        cliente.ID = CLng(dt.Rows(0).Item("id"))
        cliente.Nome = CStr(dt.Rows(0).Item("nome"))
        cliente.Telefone = CStr(dt.Rows(0).Item("telefone"))
        cliente.DataCadastro = CDate(dt.Rows(0).Item("dataCadastro"))
        cliente.CNPJ = CLng(CStr(dt.Rows(0).Item("cnpj")))
        cliente.RazaoSocial = CStr(dt.Rows(0).Item("razaoSocial"))

        Return cliente
    End Function

    Public Function FindByCNPJ(ByVal cnpj As String) As ClientePJ

        If (String.IsNullOrWhiteSpace(cnpj)) Then Return Nothing

        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT Clientes.id, Clientes.nome, Clientes.telefone, Clientes.dataCadastro, ClientesPJ.cnpj, ClientesPJ.razaoSocial FROM Clientes ")
        query.Append("INNER JOIN ClientesPJ On Clientes.id = ClientesPJ.idCliente ")
        query.Append("WHERE ClientesPJ.cnpj = @cnpj")

        conn.AddParameter("@cnpj", cnpj)

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)

        Dim cliente As New ClientePJ()
        cliente.ID = CLng(dt.Rows(0).Item("id"))
        cliente.Nome = CStr(dt.Rows(0).Item("nome"))
        cliente.Telefone = CStr(dt.Rows(0).Item("telefone"))
        cliente.DataCadastro = CDate(dt.Rows(0).Item("dataCadastro"))
        cliente.CNPJ = CLng(CStr(dt.Rows(0).Item("cnpj")))
        cliente.RazaoSocial = CStr(dt.Rows(0).Item("razaoSocial"))

        Return cliente
    End Function

    Public Function FindByNome(ByVal nome As String) As ClientePJ

        If (String.IsNullOrWhiteSpace(nome)) Then Return Nothing

        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT Clientes.id, Clientes.nome, Clientes.telefone, Clientes.dataCadastro, ClientesPJ.cnpj, ClientesPJ.razaoSocial FROM Clientes ")
        query.Append("INNER JOIN ClientesPJ On Clientes.id = ClientesPJ.idCliente ")
        query.Append("WHERE Clientes.nome = @nome")

        conn.AddParameter("@nome", nome)

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)

        Dim cliente As New ClientePJ()
        cliente.ID = CLng(dt.Rows(0).Item("id"))
        cliente.Nome = CStr(dt.Rows(0).Item("nome"))
        cliente.Telefone = CStr(dt.Rows(0).Item("telefone"))
        cliente.DataCadastro = CDate(dt.Rows(0).Item("dataCadastro"))
        cliente.CNPJ = CLng(CStr(dt.Rows(0).Item("cnpj")))
        cliente.RazaoSocial = CStr(dt.Rows(0).Item("razaoSocial"))

        Return cliente
    End Function

    Public Function FindByRazaoSocial(ByVal razaoSocial As String) As ClientePJ

        If (String.IsNullOrWhiteSpace(razaoSocial)) Then Return Nothing

        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT Clientes.id, Clientes.nome, Clientes.telefone, Clientes.dataCadastro, ClientesPJ.cnpj, ClientesPJ.razaoSocial FROM Clientes ")
        query.Append("INNER JOIN ClientesPJ On Clientes.id = ClientesPJ.idCliente ")
        query.Append("WHERE ClientesPJ.razaoSocial = @razaoSocial")

        conn.AddParameter("@razaoSocial ", razaoSocial)

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)

        Dim cliente As New ClientePJ()
        cliente.ID = CLng(dt.Rows(0).Item("id"))
        cliente.Nome = CStr(dt.Rows(0).Item("nome"))
        cliente.Telefone = CStr(dt.Rows(0).Item("telefone"))
        cliente.DataCadastro = CDate(dt.Rows(0).Item("dataCadastro"))
        cliente.CNPJ = CLng(CStr(dt.Rows(0).Item("cnpj")))
        cliente.RazaoSocial = CStr(dt.Rows(0).Item("razaoSocial"))

        Return cliente
    End Function
End Class

