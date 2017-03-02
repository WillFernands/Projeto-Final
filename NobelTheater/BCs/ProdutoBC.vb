Option Explicit On
Option Strict On

Public Class ProdutoBC

    Private Shared produtoDAO As New ProdutoDAO

    Public Shared Function Validate(produto As Produto, Optional validateImage As Boolean = False) As Boolean

        If (produto Is Nothing) Then Return False
        If (produto.Codigo = 0) Then Return False
        If (String.IsNullOrWhiteSpace(produto.Nome)) Then Return False
        If (produto.PrecoUnit = 0.0) Then Return False
        If (String.IsNullOrWhiteSpace(produto.Descricao)) Then Return False
        If (TipoProduto.GetTiposList.Contains(produto.Tipo) = False) Then Return False
        If (validateImage AndAlso produto.Imagem Is Nothing) Then Return False
        If (UnidadeProduto.GetUnidadesList.Contains(produto.Unidade) = False) Then Return False

        Return True
    End Function

    Public Shared Function Insert(produto As Produto) As Boolean
        If (ProdutoBC.Validate(produto)) Then
            Return produtoDAO.Insert(produto)
        End If
        Return False
    End Function

    Public Shared Function Update(produto As Produto) As Boolean
        If (ProdutoBC.Validate(produto)) Then
            Return produtoDAO.Update(produto)
        End If
        Return False
    End Function

    Public Shared Function UpdateImage(produto As Produto) As Boolean
        If (ProdutoBC.Validate(produto, True)) Then
            Return produtoDAO.UpdateImage(produto)
        End If
        Return False
    End Function

    Public Shared Function FindAll() As List(Of Produto)
        Return produtoDAO.FindAll()
    End Function

    Public Shared Function FindByCodigo(codigo As Long) As Produto
        Return produtoDAO.FindByCodigo(codigo)
    End Function

End Class