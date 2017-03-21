Option Explicit On
Option Strict On

Imports System.Text

Public Class OrdemServicoDAO

    'OK
    Public Function Insert(ByVal ordem As OrdemServico) As Long
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO OrdensServicos(cnpjFornecedor, idCliente, dataSolicitacao, statusOrdem) ")
        strSQL.Append("VALUES(@cnpj, @idCliente, @data, @status);")

        conn.AddParameter("@cnpj", ordem.Fornecedor.Cnpj)
        conn.AddParameter("@idCliente", ordem.Cliente.ID)
        conn.AddParameter("@data", ordem.DataSolicitacao)
        conn.AddParameter("@status", ordem.Status)

        If (conn.ExecuteCommand(strSQL.ToString) = False) Then Return 0

        conn = New Connection
        Return CLng(conn.ExecuteScalar("SELECT IDENT_CURRENT('OrdensServicos')"))

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

        If (cliente Is Nothing) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@idCliente", cliente.ID)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM OrdensServicos WHERE idCliente = @idCliente;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of OrdemServico)

        Dim ordens As New List(Of OrdemServico)

        For Each row As DataRow In dt.Rows
            Dim ordem As New OrdemServico()
            ordem.ID = CLng(row.Item("id"))
            ordem.DataSolicitacao = CDate(row.Item("dataSolicitacao"))
            ordem.Fornecedor = FornecedorBC.FindByCNPJ(CStr(row.Item("cnpjFornecedor")))
            ordem.Cliente = cliente
            ordem.Status = CStr(row.Item("statusOrdem"))
            ordem.Itens = ItemOrdemBC.FindByOrdem(ordem)
            ordens.Add(ordem)
        Next

        Return ordens

    End Function

    'OK
    Public Function FindByFornecedor(fornecedor As Fornecedor) As List(Of OrdemServico)

        If (fornecedor Is Nothing) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@cnpj", fornecedor.CNPJ)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM OrdensServicos WHERE cnpjFornecedor = @cnpj;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of OrdemServico)

        Dim ordens As New List(Of OrdemServico)

        For Each row As DataRow In dt.Rows
            Dim ordem As New OrdemServico()
            ordem.ID = CLng(row.Item("id"))
            ordem.DataSolicitacao = CDate(row.Item("dataSolicitacao"))
            ordem.Fornecedor = fornecedor
            ordem.Cliente = ClienteBC.FindByID(CLng(row.Item("idCliente")))
            ordem.Status = CStr(row.Item("statusOrdem"))
            ordem.Itens = ItemOrdemBC.FindByOrdem(ordem)
            ordens.Add(ordem)
        Next

        Return ordens

    End Function

    'OK
    Public Function FindAll() As List(Of OrdemServico)

        Dim conn As New Connection

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM OrdensServicos;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of OrdemServico)

        Dim ordens As New List(Of OrdemServico)

        For Each row As DataRow In dt.Rows
            Dim ordem As New OrdemServico()
            ordem.Id = CLng(row.Item("id"))
            ordem.DataSolicitacao = CDate(row.Item("dataSolicitacao"))
            ordem.Fornecedor = FornecedorBC.FindByCNPJ(CStr(row.Item("cnpjFornecedor")))
            ordem.Cliente = ClienteBC.FindByID(CLng(row.Item("idCliente")))
            ordem.Status = CStr(row.Item("statusOrdem"))
            ordem.Itens = ItemOrdemBC.FindByOrdem(ordem)
            ordens.Add(ordem)
        Next

        Return ordens

    End Function

    'OK
    Public Function FindByID(id As Long) As OrdemServico

        If (id = 0) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@id", id)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM OrdensServicos WHERE id = @id;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return Nothing

        Dim ordem As New OrdemServico()
        ordem.Id = CLng(dt.Rows(0).Item("id"))
        ordem.DataSolicitacao = CDate(dt.Rows(0).Item("dataSolicitacao"))
        ordem.Fornecedor = FornecedorBC.FindByCNPJ(CStr(dt.Rows(0).Item("cnpjFornecedor")))
        ordem.Cliente = ClienteBC.FindByID(CLng(dt.Rows(0).Item("idCliente")))
        ordem.Status = CStr(dt.Rows(0).Item("statusOrdem"))
        ordem.Itens = ItemOrdemBC.FindByOrdem(ordem)

        Return ordem

    End Function

End Class

