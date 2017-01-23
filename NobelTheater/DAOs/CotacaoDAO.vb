Option Explicit On
Option Strict On

Imports System.Text

Public Class CotacaoDAO

    'OK
    Public Function Insert(ByVal cotacao As Cotacao) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO Cotacoes(dataCotacao, cnpjFornecedor, statusCotacao) ")
        strSQL.Append("VALUES(@data, @cnpj, @status);")

        conn.AddParameter("@data", cotacao.DataCotacao)
        conn.AddParameter("@cnpj", cotacao.Fornecedor.CNPJ)
        conn.AddParameter("@status", cotacao.Status)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function UpdateStatus(ByVal cotacao As Cotacao) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE Cotacoes ")
        strSQL.Append("SET status = @status ")
        strSQL.Append("WHERE id = @id;")

        conn.AddParameter("@status", cotacao.Status)
        conn.AddParameter("@id", cotacao.ID)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindAll() As List(Of Cotacao)
        Dim conn As New Connection
        Dim produtoDAO As New ProdutoDAO
        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM Cotacoes;")

        Dim fornecedorDAO As New FornecedorDAO()

        Dim cotacoes As New List(Of Cotacao)

        For Each row As DataRow In dt.Rows
            Dim cotacao As New Cotacao()
            cotacao.ID = CLng(row.Item("id"))
            cotacao.DataCotacao = CDate(row.Item("dataCotacao"))
            cotacao.Status = CStr(row.Item("statusCotacao"))
            cotacao.Fornecedor = fornecedorDAO.FindByCodigo(CStr(row.Item("cnpjFornecedor")))
            cotacoes.Add(Cotacao)
        Next

        Return cotacoes

    End Function

    'OK
    Public Function FindByID(id As Long) As Cotacao
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM Cotacoes ")
        strSQL.Append("WHERE id = @id;")

        conn.AddParameter("@id", id)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        Dim fornecedorDAO As New FornecedorDAO()

        Dim cotacao As New Cotacao()
        cotacao.ID = CLng(dt.Rows(0).Item("id"))
        cotacao.DataCotacao = CDate(dt.Rows(0).Item("dataCotacao"))
        cotacao.Status = CStr(dt.Rows(0).Item("statusCotacao"))
        cotacao.Fornecedor = fornecedorDAO.FindByCNPJ(CStr(dt.Rows(0).Item("cnpjFornecedor")))

        Return Cotacao

    End Function

    'OK
    Public Function FindByData(data As Date) As List(Of Cotacao)
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM Cotacoes ")
        strSQL.Append("WHERE data = @data;")

        conn.AddParameter("@data", data)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        Dim fornecedorDAO As New FornecedorDAO()

        Dim cotacoes As New List(Of Cotacao)

        For Each row As DataRow In dt.Rows
            Dim cotacao As New Cotacao()
            cotacao.ID = CLng(row.Item("id"))
            cotacao.DataCotacao = CDate(row.Item("dataCotacao"))
            cotacao.Status = CStr(row.Item("statusCotacao"))
            cotacao.Fornecedor = fornecedorDAO.FindByCNPJ(CStr(row.Item("cnpjFornecedor")))
            cotacoes.Add(cotacao)
        Next

        Return cotacoes

    End Function

    'OK
    Public Function FindByStatus(status As String) As List(Of Cotacao)
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM Cotacoes ")
        strSQL.Append("WHERE status = @status;")

        conn.AddParameter("@status", status)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        Dim fornecedorDAO As New FornecedorDAO()

        Dim cotacoes As New List(Of Cotacao)

        For Each row As DataRow In dt.Rows
            Dim cotacao As New Cotacao()
            cotacao.ID = CLng(row.Item("id"))
            cotacao.DataCotacao = CDate(row.Item("dataCotacao"))
            cotacao.Status = CStr(row.Item("statusCotacao"))
            cotacao.Fornecedor = fornecedorDAO.FindByCNPJ(CStr(row.Item("cnpjFornecedor")))
            cotacoes.Add(cotacao)
        Next

        Return cotacoes

    End Function

End Class
