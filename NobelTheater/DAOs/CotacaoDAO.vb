Option Explicit On
Option Strict On

Imports System.Text

Public Class CotacaoDAO

    'OK
    Public Function Insert(ByVal cotacao As Cotacao) As Long
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO Cotacoes(dataCotacao, cnpjFornecedor, statusCotacao) ")
        strSQL.Append("VALUES(@data, @cnpj, @status);")

        conn.AddParameter("@data", cotacao.DataCotacao)
        conn.AddParameter("@cnpj", cotacao.Fornecedor.Cnpj)
        conn.AddParameter("@status", cotacao.Status)

        If (conn.ExecuteCommand(strSQL.ToString) = False) Then Return 0

        conn = New Connection
        Return CLng(conn.ExecuteScalar("SELECT IDENT_CURRENT('Cotacoes')"))

    End Function

    'OK
    Public Function UpdateStatus(ByVal cotacao As Cotacao) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE Cotacoes ")
        strSQL.Append("SET statusCotacao = @status ")
        strSQL.Append("WHERE id = @id;")

        conn.AddParameter("@status", cotacao.Status)
        conn.AddParameter("@id", cotacao.ID)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindAll() As List(Of Cotacao)
        Dim conn As New Connection
        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM Cotacoes ORDER BY statusCotacao Asc, dataCotacao Asc;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of Cotacao)

        Dim cotacoes As New List(Of Cotacao)

        For Each row As DataRow In dt.Rows
            Dim cotacao As New Cotacao()
            cotacao.ID = CLng(row.Item("id"))
            cotacao.DataCotacao = CDate(row.Item("dataCotacao"))
            cotacao.Status = CStr(row.Item("statusCotacao"))
            cotacao.Fornecedor = FornecedorBC.FindByCNPJ(CStr(row.Item("cnpjFornecedor")))
            cotacoes.Add(cotacao)
        Next

        Return cotacoes

    End Function

    'OK
    Public Function FindByID(id As Long) As Cotacao

        If (id = 0) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@id", id)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM Cotacoes WHERE id = @id;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return Nothing

        Dim cotacao As New Cotacao()
        cotacao.ID = CLng(dt.Rows(0).Item("id"))
        cotacao.DataCotacao = CDate(dt.Rows(0).Item("dataCotacao"))
        cotacao.Status = CStr(dt.Rows(0).Item("statusCotacao"))
        cotacao.Fornecedor = FornecedorBC.FindByCNPJ(CStr(dt.Rows(0).Item("cnpjFornecedor")))
        cotacao.Itens = ItemCotadoBC.FindByCotacao(cotacao)

        Return cotacao

    End Function

    'OK
    Public Function FindByData(data As Date) As List(Of Cotacao)

        If (data = Nothing) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@data", data)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM Cotacoes WHERE data = @data ORDER BY statusCotacao Asc, dataCotacao Asc;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of Cotacao)

        Dim cotacoes As New List(Of Cotacao)

        For Each row As DataRow In dt.Rows
            Dim cotacao As New Cotacao()
            cotacao.ID = CLng(row.Item("id"))
            cotacao.DataCotacao = CDate(row.Item("dataCotacao"))
            cotacao.Status = CStr(row.Item("statusCotacao"))
            cotacao.Fornecedor = FornecedorBC.FindByCNPJ(CStr(row.Item("cnpjFornecedor")))
            cotacao.Itens = ItemCotadoBC.FindByCotacao(cotacao)
            cotacoes.Add(cotacao)
        Next

        Return cotacoes

    End Function

    'OK
    Public Function FindByStatus(status As String) As List(Of Cotacao)

        If (String.IsNullOrWhiteSpace(status)) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@status", status)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM Cotacoes WHERE status = @status;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of Cotacao)


        Dim cotacoes As New List(Of Cotacao)

        For Each row As DataRow In dt.Rows
            Dim cotacao As New Cotacao()
            cotacao.ID = CLng(row.Item("id"))
            cotacao.DataCotacao = CDate(row.Item("dataCotacao"))
            cotacao.Status = CStr(row.Item("statusCotacao"))
            cotacao.Fornecedor = FornecedorBC.FindByCNPJ(CStr(row.Item("cnpjFornecedor")))
            cotacao.Itens = ItemCotadoBC.FindByCotacao(cotacao)
            cotacoes.Add(cotacao)
        Next

        Return cotacoes

    End Function

End Class
