﻿Option Explicit On
Option Strict On

Imports System.Text

Public Class NotaFiscalCompraDAO

    'OK
    Public Function Insert(ByVal notaFiscal As NotaFiscalCompra) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO NotasFiscaisCompras(statusNF, emissaoNF, numeroNF, dataAprovacao, idCotacao) ")
        strSQL.Append("VALUES(@status, @emissao, @numero, @data, @idCotacao);")

        conn.AddParameter("@status", notaFiscal.Status)
        conn.AddParameter("@emissao", notaFiscal.EmissaoNF)
        conn.AddParameter("@numero", notaFiscal.NumeroNF)
        conn.AddParameter("@data", notaFiscal.DataAprovacao)
        conn.AddParameter("@idCotacao", notaFiscal.Cotacao.ID)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function UpdateStatus(ByVal notaFiscal As NotaFiscalCompra) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE NotasFiscaisCompras ")
        strSQL.Append("SET status = @status ")
        strSQL.Append("WHERE id = @id;")

        conn.AddParameter("@status", notaFiscal.Status)
        conn.AddParameter("@id", notaFiscal.ID)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindAll() As List(Of NotaFiscalCompra)
        Dim conn As New Connection
        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM NotasFiscaisCompras;")

        Dim cotacaoDAO As New CotacaoDAO()

        Dim notasFiscais As New List(Of NotaFiscalCompra)

        For Each row As DataRow In dt.Rows
            Dim notaFiscal As New NotaFiscalCompra()
            notaFiscal.ID = CLng(row.Item("id"))
            notaFiscal.DataAprovacao = CDate(row.Item("dataAprovacao"))
            notaFiscal.Status = CStr(row.Item("statusNF"))
            notaFiscal.EmissaoNF = CDate(row.Item("emissaoNF"))
            notaFiscal.NumeroNF = CStr(row.Item("numeroNF"))
            notaFiscal.Cotacao = cotacaoDAO.FindByID(CLng(row.Item("idCotacao")))
            notasFiscais.Add(notaFiscal)
        Next

        Return notasFiscais

    End Function

    'OK
    Public Function FindByStatus(status As String) As List(Of NotaFiscalCompra)

        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM NotasFiscaisCompras WHERE status = @status;")

        conn.AddParameter("@status", status)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        Dim cotacaoDAO As New CotacaoDAO()

        Dim notasFiscais As New List(Of NotaFiscalCompra)

        For Each row As DataRow In dt.Rows
            Dim notaFiscal As New NotaFiscalCompra()
            notaFiscal.ID = CLng(row.Item("id"))
            notaFiscal.DataAprovacao = CDate(row.Item("dataAprovacao"))
            notaFiscal.Status = CStr(row.Item("statusNF"))
            notaFiscal.EmissaoNF = CDate(row.Item("emissaoNF"))
            notaFiscal.NumeroNF = CStr(row.Item("numeroNF"))
            notaFiscal.Cotacao = cotacaoDAO.FindByID(CLng(row.Item("idCotacao")))
            notasFiscais.Add(notaFiscal)
        Next

        Return notasFiscais

    End Function

End Class

