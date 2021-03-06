﻿Option Explicit On
Option Strict On

Imports System.Text

Public Class ItemVendidoDAO

    'OK
    Public Function Insert(ByVal item As ItemVendido) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO ItensVendidos(codigoProduto, idNotaFiscal, quantidade) ")
        strSQL.Append("VALUES(@codigo, @idNotaFiscal, @quantidade);")

        conn.AddParameter("@codigo", item.Produto.Codigo)
        conn.AddParameter("@idNotaFiscal", item.NotaFiscal.ID)
        conn.AddParameter("@quantidade", item.Quantidade)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindByNotaFiscal(notaFiscal As NotaFiscalVenda) As List(Of ItemVendido)

        If (notaFiscal Is Nothing) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@idNotaFiscal", notaFiscal.ID)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM ItensVendidos WHERE idNotaFiscal = @idNotaFiscal;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of ItemVendido)

        Dim itens As New List(Of ItemVendido)

        For Each row As DataRow In dt.Rows
            Dim item As New ItemVendido()
            item.Produto = ProdutoBC.FindByCodigo(CLng(row.Item("codigoProduto")))
            item.NotaFiscal = notaFiscal
            item.Quantidade = CInt(row.Item("quantidade"))
            itens.Add(item)
        Next

        Return itens

    End Function

    'OK
    Public Function DeleteByVenda(venda As NotaFiscalVenda) As Boolean

        If (venda Is Nothing) Then Return False

        Dim conn As New Connection

        conn.AddParameter("@idNotaFiscal", venda.Id)

        Return conn.ExecuteCommand("DELETE FROM ItensComprados WHERE idNotaFiscal = @idNotaFiscal;")

    End Function

End Class

