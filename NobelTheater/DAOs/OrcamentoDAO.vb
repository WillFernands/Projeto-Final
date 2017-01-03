Option Explicit On
Option Strict On

Imports System.Text

Public Class OrcamentoDAO

    'OK
    Public Function Insert(ByVal orcamento As Orcamento) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO Orcamentos(dataOrcamento, matriculaVendedor, idCliente, statusOrcamento) ")
        strSQL.Append("VALUES(@data, @matricula, @idCliente, @status);")

        conn.AddParameter("@data", orcamento.Data)
        conn.AddParameter("@matricula", orcamento.Vendedor.Matricula)
        conn.AddParameter("@idCliente", orcamento.Cliente.ID)
        conn.AddParameter("@status", orcamento.Status)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function UpdateStatus(ByVal orcamento As Orcamento) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE Orcamentos ")
        strSQL.Append("SET status = @status ")
        strSQL.Append("WHERE id = @id;")

        conn.AddParameter("@id", orcamento.ID)
        conn.AddParameter("@status", orcamento.Status)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindByCliente(cliente As Cliente) As List(Of Orcamento)
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM Orcamentos ")
        strSQL.Append("WHERE idCliente = @idCliente;")

        conn.AddParameter("@idCliente", cliente.ID)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        Dim funcionarioDAO As New FuncionarioDAO

        Dim orcamentos As New List(Of Orcamento)

        For Each row As DataRow In dt.Rows
            Dim orcamento As New Orcamento()
            orcamento.ID = CLng(row.Item("id"))
            orcamento.DataOrcamento = CDate(row.Item("dataOrcamento"))
            orcamento.Vendedor = FuncionarioDAO.FindByMatricula(CLng(row.Item("matriculaVendedor")))
            orcamento.Cliente = cliente
            orcamento.Status = CStr(row.Item("statusOrcamento"))
            orcamentos.Add(orcamento)
        Next

        Return orcamentos

    End Function

    'OK
    Public Function FindByVendedor(vendedor As Funcionario) As List(Of Orcamento)
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM Orcamentos ")
        strSQL.Append("WHERE matriculaVendedor = @vendedor;")

        conn.AddParameter("@vendedor", vendedor.Matricula)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        Dim clienteDAO As New ClienteDAO

        Dim orcamentos As New List(Of Orcamento)

        For Each row As DataRow In dt.Rows
            Dim orcamento As New Orcamento()
            orcamento.ID = CLng(row.Item("id"))
            orcamento.DataOrcamento = CDate(row.Item("dataOrcamento"))
            orcamento.Vendedor = vendedor
            orcamento.Cliente = clienteDAO.FindByID(CLng(row.Item("idCliente")))
            orcamento.Status = CStr(row.Item("statusOrcamento"))
            orcamentos.Add(orcamento)
        Next

        Return orcamentos

    End Function

End Class
