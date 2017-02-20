Option Explicit On
Option Strict On

Imports System.Text

Public Class ProdutoDAO

    'OK
    Public Function Insert(ByVal produto As Produto) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO Produtos(nome, precoUnit, descricao) ")
        strSQL.Append("VALUES(@nome, @precoUnit, @descricao);")

        conn.AddParameter("@nome", produto.Nome)
        conn.AddParameter("@precoUnit", produto.PrecoUnit)
        conn.AddParameter("@descricao", produto.Descricao)

        If (conn.ExecuteCommand(strSQL.ToString) = False) Then Return False

        If (produto.Imagem IsNot Nothing) Then
            conn = New Connection
            produto.Codigo = CLng(conn.ExecuteScalar("SELECT IDENT_CURRENT('Produtos')"))
            Return UpdateImage(produto)
        End If

        Return True

    End Function

    'OK
    Public Function Update(ByVal produto As Produto) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE Produtos ")
        strSQL.Append("SET nome = @nome, ")
        strSQL.Append("precoUnit = @precoUnit, ")
        strSQL.Append("descricao = @descricao, ")
        strSQL.Append("WHERE codigo = @codigo;")

        conn.AddParameter("@nome", produto.Nome)
        conn.AddParameter("@precoUnit", produto.PrecoUnit)
        conn.AddParameter("@descricao", produto.Descricao)
        conn.AddParameter("@codigo", produto.Codigo)

        If (conn.ExecuteCommand(strSQL.ToString) = False) Then Return False

        If (produto.Imagem IsNot Nothing) Then Return UpdateImage(produto)

        Return True

    End Function

    'OK
    Public Function UpdateImage(ByVal produto As Produto) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE Produtos ")
        strSQL.Append("SET imagem = @imagem ")
        strSQL.Append("WHERE codigo = @codigo;")

        conn.AddParameter("@imagem", produto.Imagem)
        conn.AddParameter("@codigo", produto.Codigo)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindAll() As List(Of Produto)
        Dim conn As New Connection

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM Produtos;")

        Dim produtos As New List(Of Produto)

        For Each row As DataRow In dt.Rows
            Dim produto As New Produto()
            produto.Codigo = CLng(row.Item("codigo"))
            produto.Nome = CStr(row.Item("nome"))
            produto.PrecoUnit = CDbl(row.Item("precoUnit"))
            produto.Descricao = CStr(row.Item("descricao"))
            produto.Imagem = DirectCast(row.Item("imagem"), Image)
            produtos.Add(produto)
        Next

        Return produtos

    End Function

    'OK
    Public Function FindByCodigo(codigo As Long) As Produto
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM Produtos ")
        strSQL.Append("WHERE codigo = @codigo;")

        conn.AddParameter("@codigo", codigo)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        Dim produto As New Produto()
        produto.Codigo = CLng(dt.Rows(0).Item("codigo"))
        produto.Nome = CStr(dt.Rows(0).Item("nome"))
        produto.PrecoUnit = CDbl(dt.Rows(0).Item("precoUnit"))
        produto.Descricao = CStr(dt.Rows(0).Item("descricao"))
        produto.Imagem = DirectCast(dt.Rows(0).Item("imagem"), Image)

        Return produto

    End Function

End Class


