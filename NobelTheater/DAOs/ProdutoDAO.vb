Option Explicit On
Option Strict On

Imports System.Text

Public Class ProdutoDAO

    'OK
    Public Function Insert(ByVal produto As Produto) As Long
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO Produtos(nome, precoUnit, descricao, tipo, unidade) ")
        strSQL.Append("VALUES(@nome, @precoUnit, @descricao, @tipo, @unidade);")

        conn.AddParameter("@nome", produto.Nome)
        conn.AddParameter("@precoUnit", produto.PrecoUnit)
        conn.AddParameter("@descricao", produto.Descricao)
        conn.AddParameter("@tipo", produto.Tipo)
        conn.AddParameter("@unidade", produto.Unidade)

        If (conn.ExecuteCommand(strSQL.ToString) = False) Then Return 0

        If (produto.Imagem IsNot Nothing) Then
            UpdateImage(produto)
        End If

        conn = New Connection
        Return CLng(conn.ExecuteScalar("SELECT IDENT_CURRENT('Produtos')"))

    End Function

    'OK
    Public Function Update(ByVal produto As Produto) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE Produtos ")
        strSQL.Append("SET nome = @nome, ")
        strSQL.Append("precoUnit = @precoUnit, ")
        strSQL.Append("descricao = @descricao, ")
        strSQL.Append("tipo = @tipo, ")
        strSQL.Append("unidade = @unidade ")
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

        conn.AddParameter("@imagem", produto.Imagem)
        conn.AddParameter("@codigo", produto.Codigo)

        Return conn.ExecuteCommand("UPDATE Produtos SET imagem = @imagem WHERE codigo = @codigo;")

    End Function

    'OK
    Public Function FindAll() As List(Of Produto)
        Dim conn As New Connection

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM Produtos;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of Produto)

        Dim produtos As New List(Of Produto)

        For Each row As DataRow In dt.Rows
            Dim produto As New Produto()
            produto.Codigo = CLng(row.Item("codigo"))
            produto.Nome = CStr(row.Item("nome"))
            produto.PrecoUnit = CDbl(row.Item("precoUnit"))
            produto.Descricao = CStr(row.Item("descricao"))
            produto.Tipo = CStr(row.Item("tipo"))
            produto.Unidade = CStr(row.Item("unidade"))
            If (IsDBNull(row.Item("imagem")) = False) Then
                produto.Imagem = DirectCast(row.Item("imagem"), Image)
            End If
            produtos.Add(produto)
        Next

        Return produtos

    End Function

    'OK
    Public Function FindByCodigo(codigo As Long) As Produto

        If (codigo = 0) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@codigo", codigo)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM Produtos WHERE codigo = @codigo;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return Nothing

        Dim produto As New Produto()
        produto.Codigo = CLng(dt.Rows(0).Item("codigo"))
        produto.Nome = CStr(dt.Rows(0).Item("nome"))
        produto.PrecoUnit = CDbl(dt.Rows(0).Item("precoUnit"))
        produto.Descricao = CStr(dt.Rows(0).Item("descricao"))
        produto.Tipo = CStr(dt.Rows(0).Item("tipo"))
        produto.Unidade = CStr(dt.Rows(0).Item("unidade"))
        If (IsDBNull(dt.Rows(0).Item("imagem")) = False) Then
            produto.Imagem = DirectCast(dt.Rows(0).Item("imagem"), Image)
        End If
        Return produto

    End Function

End Class


