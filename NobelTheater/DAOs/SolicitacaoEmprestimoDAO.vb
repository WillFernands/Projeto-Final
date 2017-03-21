Option Explicit On
Option Strict On

Imports System.Text

Public Class SolicitacaoEmprestimoDAO

    'OK
    Public Function Insert(ByVal solicitacao As SolicitacaoEmprestimo) As Long
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO SolicitacoesEmprestimos(dataSolicitacao, idCliente, statusSolicitacao) ")
        strSQL.Append("VALUES(@data, @idCliente, @status);")

        conn.AddParameter("@data", solicitacao.DataSolicitacao)
        conn.AddParameter("@idCliente", solicitacao.Cliente.ID)
        conn.AddParameter("@status", solicitacao.Status)

        If (conn.ExecuteCommand(strSQL.ToString) = False) Then Return 0

        conn = New Connection
        Return CLng(conn.ExecuteScalar("SELECT IDENT_CURRENT('SolicitacoesEmprestimos')"))

    End Function

    'OK
    Public Function UpdateStatus(ByVal solicitacao As SolicitacaoEmprestimo) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE SolicitacoesEmprestimos ")
        strSQL.Append("SET statusSolicitacao = @status ")
        strSQL.Append("WHERE id = @id;")

        conn.AddParameter("@id", solicitacao.ID)
        conn.AddParameter("@status", solicitacao.Status)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindByCliente(cliente As Cliente) As List(Of SolicitacaoEmprestimo)

        If (cliente Is Nothing) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@idCliente", cliente.ID)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM SolicitacoesEmprestimos WHERE idCliente = @idCliente;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of SolicitacaoEmprestimo)

        Dim solicitacoes As New List(Of SolicitacaoEmprestimo)

        For Each row As DataRow In dt.Rows
            Dim solicitacao As New SolicitacaoEmprestimo()
            solicitacao.ID = CLng(row.Item("id"))
            solicitacao.DataSolicitacao = CDate(row.Item("dataSolicitacao"))
            solicitacao.Cliente = cliente
            solicitacao.Status = CStr(row.Item("statusSolicitacao"))
            solicitacao.Itens = ItemEmprestimoBC.FindBySolicitacao(solicitacao)
            solicitacoes.Add(solicitacao)
        Next

        Return solicitacoes

    End Function

    'OK
    Public Function FindAll() As List(Of SolicitacaoEmprestimo)
        Dim conn As New Connection

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM SolicitacoesEmprestimos;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of SolicitacaoEmprestimo)

        Dim solicitacoes As New List(Of SolicitacaoEmprestimo)

        For Each row As DataRow In dt.Rows
            Dim solicitacao As New SolicitacaoEmprestimo()
            solicitacao.Id = CLng(row.Item("id"))
            solicitacao.DataSolicitacao = CDate(row.Item("dataSolicitacao"))
            solicitacao.Cliente = ClienteBC.FindByID(CLng(row.Item("idCliente")))
            solicitacao.Status = CStr(row.Item("statusSolicitacao"))
            solicitacao.Itens = ItemEmprestimoBC.FindBySolicitacao(solicitacao)
            solicitacoes.Add(solicitacao)
        Next

        Return solicitacoes

    End Function

    'OK
    Public Function FindByID(id As Long) As SolicitacaoEmprestimo

        If (id = 0) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@id", id)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM SolicitacoesEmprestimos WHERE id = @id;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return Nothing

        Dim solicitacao As New SolicitacaoEmprestimo()
        solicitacao.Id = CLng(dt.Rows(0).Item("id"))
        solicitacao.DataSolicitacao = CDate(dt.Rows(0).Item("dataSolicitacao"))
        solicitacao.Cliente = ClientePFBC.FindByID(CLng(dt.Rows(0).Item("idCliente")))
        solicitacao.Status = CStr(dt.Rows(0).Item("statusSolicitacao"))
        solicitacao.Itens = ItemEmprestimoBC.FindBySolicitacao(solicitacao)

        Return solicitacao

    End Function

End Class

