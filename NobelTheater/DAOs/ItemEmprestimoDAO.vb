﻿Option Explicit On
Option Strict On

Imports System.Text

Public Class ItemEmprestimoDAO

    'OK
    Public Function Insert(ByVal item As ItemEmprestimo) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO ItensEmprestimos(codigoProduto, idSolicitacao, quantidade, dataEmprestimo) ")
        strSQL.Append("VALUES(@codigo, @idSolicitacao, @quantidade, @dataEmprestimo);")

        conn.AddParameter("@codigo", item.Produto.Codigo)
        conn.AddParameter("@idSolicitacao", item.SolicitacaoEmprestimo.ID)
        conn.AddParameter("@quantidade", item.Quantidade)
        conn.AddParameter("@dataEmprestimo", item.DataEmprestimo)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function UpdateDataDevolucao(ByVal item As ItemEmprestimo) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE ItensEmprestimos ")
        strSQL.Append("SET dataDevolucao = @data ")
        strSQL.Append("WHERE codigoProduto = @codigo ")
        strSQL.Append("AND idSolicitacao = @idSolicitacao ")
        strSQL.Append("AND dataEmprestimo = @dataEmprestimo;")

        conn.AddParameter("@data", item.DataDevolucao)
        conn.AddParameter("@codigo", item.Produto.Codigo)
        conn.AddParameter("@idSolicitacao", item.SolicitacaoEmprestimo.Id)
        conn.AddParameter("@dataEmprestimo", item.DataEmprestimo)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindBySolicitacao(solicitacao As SolicitacaoEmprestimo) As List(Of ItemEmprestimo)

        If (solicitacao Is Nothing) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@idSolicitacao", solicitacao.Id)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM ItensEmprestimos WHERE idSolicitacao = @idSolicitacao;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of ItemEmprestimo)

        Dim itens As New List(Of ItemEmprestimo)

        For Each row As DataRow In dt.Rows
            Dim item As New ItemEmprestimo()
            item.Produto = ProdutoBC.FindByCodigo(CLng(row.Item("codigoProduto")))
            item.SolicitacaoEmprestimo = solicitacao
            item.Quantidade = CInt(row.Item("quantidade"))
            item.DataEmprestimo = CDate(row.Item("dataEmprestimo"))
            If (IsDBNull(row.Item("dataDevolucao")) = False) Then
                item.DataDevolucao = CDate(row.Item("dataDevolucao"))
            End If
            itens.Add(item)
        Next

        Return itens

    End Function

End Class

