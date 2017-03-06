Option Explicit On
Option Strict On

Imports System.Text

Public Class AlertaDAO

    'OK
    Public Function Insert(ByVal alerta As Alerta) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO Alertas(dataAlerta, observacao, codigoProduto) ")
        strSQL.Append("VALUES(@data, @observacao, @codigo);")

        conn.AddParameter("@data", alerta.Data)
        conn.AddParameter("@observacao", alerta.Observacao)
        conn.AddParameter("@codigo", alerta.Produto.Codigo)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function Update(ByVal alerta As Alerta) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE Alertas ")
        strSQL.Append("SET observacao = @observacao ")
        strSQL.Append("WHERE codigoProduto = @codigo ")
        strSQL.Append("AND dataAlerta = @data;")

        conn.AddParameter("@data", alerta.Data)
        conn.AddParameter("@observacao", alerta.Observacao)
        conn.AddParameter("@codigo", alerta.Produto.Codigo)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindAll() As List(Of Alerta)
        Dim conn As New Connection
        Dim produtoDAO As New ProdutoDAO
        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM Alertas;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of Alerta)

        Dim alertas As New List(Of Alerta)

        For Each row As DataRow In dt.Rows
            Dim alerta As New Alerta()
            alerta.Data = CDate(row.Item("dataAlerta"))
            alerta.Observacao = CStr(row.Item("observacao"))
            alerta.Produto = produtoDAO.FindByCodigo(CInt(row.Item("codigoProduto")))
            alertas.Add(alerta)
        Next

        Return alertas

    End Function

    'OK
    Public Function FindByProduto(produto As Produto) As List(Of Alerta)

        If (produto Is Nothing) Then Return Nothing

        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT dataAlerta, observacao FROM Alertas ")
        strSQL.Append("WHERE codigoProduto = @codigo;")

        conn.AddParameter("@codigo", produto.Codigo)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of Alerta)

        Dim alertas As New List(Of Alerta)

        For Each row As DataRow In dt.Rows
            Dim alerta As New Alerta()
            alerta.Data = CDate(row.Item("dataAlerta"))
            alerta.Observacao = CStr(row.Item("observacao"))
            alerta.Produto = produto
            alertas.Add(alerta)
        Next

        Return alertas

    End Function

    'OK
    Public Function FindByData(data As Date) As List(Of Alerta)

        If (data = Nothing) Then Return Nothing

        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM Alertas ")
        strSQL.Append("WHERE Cast(dataAlerta As Date) = Cast(@data As Date);")

        conn.AddParameter("@data", data)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of Alerta)
        Dim produtoDAO As New ProdutoDAO
        Dim alertas As New List(Of Alerta)

        For Each row As DataRow In dt.Rows
            Dim alerta As New Alerta()
            alerta.Data = CDate(row.Item("dataAlerta"))
            alerta.Observacao = CStr(row.Item("observacao"))
            alerta.Produto = produtoDAO.FindByCodigo(CInt(row.Item("codigoProduto")))
            alertas.Add(alerta)
        Next

        Return alertas

    End Function

    'OK
    Public Function Delete(ByVal alerta As Alerta) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("DELETE Alertas ")
        strSQL.Append("WHERE codigoProduto = @codigo ")
        strSQL.Append("AND observacao = @observacao ")
        strSQL.Append("AND dataAlerta = @data;")

        conn.AddParameter("@data", alerta.Data)
        conn.AddParameter("@observacao", alerta.Observacao)
        conn.AddParameter("@codigo", alerta.Produto.Codigo)

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

End Class