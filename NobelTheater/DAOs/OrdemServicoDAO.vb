Option Explicit On
Option Strict On

Imports System.Text

Public Class OrdemServicoDAO

    'OK
    Public Function Insert(ByVal ordem As OrdemServico) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO OrdensServicos(cnpjFornecedor, idCliente, dataSolicitacao, statusOrdem) ")
        strSQL.Append("VALUES(@cnpj, @idCliente, @data, @status);")

        conn.AddParameter("@cnpj", ordem.Fornecedor.CNPJ)
        conn.AddParameter("@idCliente", ordem.Cliente.ID)
        conn.AddParameter("@data", ordem.Data)
        conn.AddParameter("@status", ordem.Status)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function UpdateStatus(ByVal ordem As OrdemServico) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE OrdensServicos ")
        strSQL.Append("SET statusOrdem = @status ")
        strSQL.Append("WHERE id = @id;")

        conn.AddParameter("@id", ordem.ID)
        conn.AddParameter("@status", ordem.Status)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindByCliente(cliente As Cliente) As List(Of OrdemServico)
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM OrdensServicos ")
        strSQL.Append("WHERE idCliente = @idCliente;")

        conn.AddParameter("@idCliente", cliente.ID)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        Dim fornecedorDAO As New FornecedorDAO

        Dim ordens As New List(Of OrdemServico)

        For Each row As DataRow In dt.Rows
            Dim ordem As New OrdemServico()
            ordem.ID = CLng(row.Item("id"))
            ordem.DataSolicitacao = CDate(row.Item("dataSolicitacao"))
            ordem.Fornecedor = fornecedorDAO.FindByCNPJ(CLng(row.Item("cnpjFornecedor")))
            ordem.Cliente = cliente
            ordem.Status = CStr(row.Item("statusOrdem"))
            ordens.Add(ordem)
        Next

        Return ordens

    End Function

    'OK
    Public Function FindByFornecedor(fornecedor As Fornecedor) As List(Of OrdemServico)
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM OrdensServicos ")
        strSQL.Append("WHERE cnpjFornecedor = @cnpj;")

        conn.AddParameter("@cnpj", fornecedor.CNPJ)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        Dim clienteDAO As New ClienteDAO

        Dim ordens As New List(Of OrdemServico)

        For Each row As DataRow In dt.Rows
            Dim ordem As New OrdemServico()
            ordem.ID = CLng(row.Item("id"))
            ordem.DataSolicitacao = CDate(row.Item("dataSolicitacao"))
            ordem.Fornecedor = fornecedor
            ordem.Cliente = clienteDAO.FindByID(CLng(row.Item("idCliente")))
            ordem.Status = CStr(row.Item("statusOrdem"))
            ordens.Add(ordem)
        Next

        Return ordens

    End Function

End Class

