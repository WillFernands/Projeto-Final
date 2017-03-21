Option Explicit On
Option Strict On

Imports System.Text

Public Class ClienteDAO

    'OK
    Public Function Insert(ByVal cliente As Cliente) As Long
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("Insert INTO Clientes(nome, telefone, dataCadastro) ")
        strSQL.Append("VALUES(@nome, @telefone, @dataCadastro);")

        conn.AddParameter("@nome", cliente.Nome)
        conn.AddParameter("@telefone", cliente.Telefone)
        conn.AddParameter("@dataCadastro", cliente.DataCadastro)

        If (conn.ExecuteCommand(strSQL.ToString) = False) Then Return 0

        conn = New Connection
        Return CLng(conn.ExecuteScalar("SELECT IDENT_CURRENT('Clientes')"))

    End Function

    'OK
    Public Function Update(ByVal cliente As Cliente) As Boolean

        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE Clientes ")
        strSQL.Append("SET nome = @nome, ")
        strSQL.Append("telefone = @telefone, ")
        strSQL.Append("dataCadastro = @dataCadastro ")
        strSQL.Append("WHERE id = @idCliente;")

        conn.AddParameter("@nome", cliente.Nome)
        conn.AddParameter("@telefone", cliente.Telefone)
        conn.AddParameter("@dataCadastro", cliente.DataCadastro)
        conn.AddParameter("@idCliente", cliente.ID)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindByID(ByVal id As Long) As Cliente

        If (id = 0) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@id", id)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM Clientes WHERE Clientes.Id = @id")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return Nothing

        Dim cliente As New Cliente()
        cliente.ID = CLng(dt.Rows(0).Item("ID"))
        cliente.Nome = CStr(dt.Rows(0).Item("Nome"))
        cliente.Telefone = CStr(dt.Rows(0).Item("Telefone"))
        cliente.DataCadastro = CDate(dt.Rows(0).Item("DataCadastro"))

        Return cliente
    End Function
End Class
