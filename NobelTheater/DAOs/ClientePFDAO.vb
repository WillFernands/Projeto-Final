Option Explicit On
Option Strict On

Imports System.Text

Public Class ClientePFDAO

    'OK
    Public Function Insert(ByVal cliente As ClientePF) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("Insert INTO Cliente(Nome, Telefone, DataCadastro) ")
        strSQL.Append("VALUES(@nome, @telefone, @dataCadastro);")

        conn.AddParameter("@nome", cliente.Nome)
        conn.AddParameter("@telefone", cliente.Telefone)
        conn.AddParameter("@dataCadastro", cliente.DataCadastro)

        If (conn.ExecuteCommand(strSQL.ToString) = False) Then Return False

        cliente.ID = CLng(conn.ExecuteScalar("SELECT TOP 1 FROM Cliente ORDER BY id DESC"))

        If (cliente.ID = 0) Then Return False

        conn = New Connection
        strSQL = New StringBuilder

        strSQL.Append("Insert INTO ClientePF(CPF, IdCliente) ")
        strSQL.Append("VALUES(@cpf, @idCliente);")

        conn.AddParameter("@cpf", cliente.CPF)
        conn.AddParameter("@idCliente", cliente.ID)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    Public Function Update(ByVal cliente As ClientePF) As Boolean

        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("Update ClientesPF ")
        strSQL.Append("SET CPF = @cpf ")
        strSQL.Append("WHERE IdCliente = @idCliente;")

        conn.AddParameter("@cpf", cliente.CPF)
        conn.AddParameter("@idCliente", cliente.ID)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindAll() As List(Of ClientePF)
        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT Cliente.ID, Cliente.Nome, Cliente.Telefone, Cliente.DataCadastro, ClientePF.CPF FROM Cliente ")
        query.Append("INNER JOIN ClientePF On Cliente.Id = ClientePF.IdCliente")

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)

        Dim clientes As New List(Of ClientePF)

        For Each row As DataRow In dt.Rows
            Dim cliente As New ClientePF()
            cliente.ID = CLng(row.Item("ID"))
            cliente.Nome = CStr(row.Item("Nome"))
            cliente.Telefone = CStr(row.Item("Telefone"))
            cliente.DataCadastro = CDate(row.Item("DataCadastro"))
            cliente.CPF = CLng(row.Item("CPF"))
            clientes.Add(cliente)
        Next

        Return clientes

    End Function

    Public Function FindByID(ByVal id As Integer) As ClientePF
        If (id = 0) Then Return Nothing

        Dim conn As New Connection
        Dim daoInstance As New PetDAO

        conn.AddParameter("@id", id)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM Clientes WHERE ID = @id")

        Dim cliente As New Cliente()

        cliente.ID = dt.Rows(0).Item("Id")
        cliente.Nome = dt.Rows(0).Item("Nome")
        cliente.CPF = dt.Rows(0).Item("CPF")
        cliente.InicioRelacionamento = dt.Rows(0).Item("InicioRelacionamento")
        cliente.Desconto = dt.Rows(0).Item("Desconto")
        cliente.TipoCliente = dt.Rows(0).Item("TipoCliente")
        cliente.Pets = daoInstance.FindByIDCliente(cliente.ID)
        cliente.Endereco = dt.Rows(0).Item("Endereco")
        cliente.Telefone = dt.Rows(0).Item("Telefone")
        cliente.Status = dt.Rows(0).Item("Status")

        Return cliente
    End Function

    Public Function FindByCPF(ByVal cpf As String) As Cliente

        If (String.IsNullOrWhiteSpace(cpf)) Then Return Nothing

        Dim conn As New Connection
        Dim daoInstance As New PetDAO

        conn.AddParameter("@cpf", CleanString(cpf))

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM Clientes WHERE CPF = @cpf")

        If (dt.Rows.Count = 0) Then Return Nothing

        Dim cliente As New Cliente()

        cliente.ID = dt.Rows(0).Item("Id")
        cliente.Nome = dt.Rows(0).Item("Nome")
        cliente.CPF = dt.Rows(0).Item("CPF")
        cliente.InicioRelacionamento = dt.Rows(0).Item("InicioRelacionamento")
        cliente.Desconto = dt.Rows(0).Item("Desconto")
        cliente.TipoCliente = dt.Rows(0).Item("TipoCliente")
        cliente.Pets = daoInstance.FindByIDCliente(cliente.ID)
        cliente.Endereco = dt.Rows(0).Item("Endereco")
        cliente.Telefone = dt.Rows(0).Item("Telefone")
        cliente.Status = dt.Rows(0).Item("Status")

        Return cliente
    End Function

    Public Function FindByNome(ByVal nome As String) As Cliente
        If (String.IsNullOrWhiteSpace(nome)) Then Return Nothing
        Dim conn As New Connection
        Dim daoInstance As New PetDAO

        conn.AddParameter("@nome", nome)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM Clientes WHERE Nome = @nome")

        If (dt.Rows.Count = 0) Then Return Nothing

        Dim cliente As New Cliente()

        cliente.ID = dt.Rows(0).Item("Id")
        cliente.Nome = dt.Rows(0).Item("Nome")
        cliente.CPF = dt.Rows(0).Item("CPF")
        cliente.InicioRelacionamento = dt.Rows(0).Item("InicioRelacionamento")
        cliente.Desconto = dt.Rows(0).Item("Desconto")
        cliente.TipoCliente = dt.Rows(0).Item("TipoCliente")
        cliente.Pets = daoInstance.FindByIDCliente(cliente.ID)
        cliente.Endereco = dt.Rows(0).Item("Endereco")
        cliente.Telefone = dt.Rows(0).Item("Telefone")
        cliente.Status = dt.Rows(0).Item("Status")

        Return cliente
    End Function

    Public Function Delete(ByVal id As Integer) As Boolean
        Dim conn As New Connection

        conn.AddParameter("@id", id)

        Return conn.ExecuteCommand("DELETE FROM ClientesPF WHERE ID = @id")
    End Function
End Class

