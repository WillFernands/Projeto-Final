Option Explicit On
Option Strict On

Imports System.Text

Public Class SolicitacaoEmprestimoDAO

    'OK
    Public Function Insert(ByVal solicitacao As SolicitacaoEmprestimo) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO SolicitacoesEmprestimos(dataSolicitacao, idCliente, statusSolicitacao) ")
        strSQL.Append("VALUES(@data, @idCliente, @status);")

        conn.AddParameter("@data", solicitacao.DataSolicitacao)
        conn.AddParameter("@idCliente", solicitacao.Cliente.ID)
        conn.AddParameter("@status", solicitacao.Status)

        Return conn.ExecuteCommand(strSQL.ToString)

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
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM SolicitacoesEmprestimos ")
        strSQL.Append("WHERE idCliente = @idCliente;")

        conn.AddParameter("@idCliente", cliente.ID)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of SolicitacaoEmprestimo)

        Dim solicitacoes As New List(Of SolicitacaoEmprestimo)

        For Each row As DataRow In dt.Rows
            Dim solicitacao As New SolicitacaoEmprestimo()
            solicitacao.ID = CLng(row.Item("id"))
            solicitacao.DataSolicitacao = CDate(row.Item("dataSolicitacao"))
            solicitacao.Cliente = cliente
            solicitacao.Status = CStr(row.Item("statusSolicitacao"))
            solicitacoes.Add(solicitacao)
        Next

        Return solicitacoes

    End Function

    'OK
    Public Function FindByID(id As Long) As SolicitacaoEmprestimo

        If (id = 0) Then Return Nothing

        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM SolicitacoesEmprestimos ")
        strSQL.Append("WHERE id = @id;")

        conn.AddParameter("@id", id)

        Dim clientePFDAO As New ClientePFDAO

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return Nothing

        Dim solicitacao As New SolicitacaoEmprestimo()
        solicitacao.Id = CLng(dt.Rows(0).Item("id"))
        solicitacao.DataSolicitacao = CDate(dt.Rows(0).Item("dataSolicitacao"))
        solicitacao.Cliente = clientePFDAO.FindByID(CLng(dt.Rows(0).Item("idCliente")))
        solicitacao.Status = CStr(dt.Rows(0).Item("statusSolicitacao"))

        Return solicitacao

    End Function

End Class

