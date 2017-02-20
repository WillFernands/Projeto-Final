Imports NobelTheater

Public Class ItemCotado
    Private _quantidade As Integer
    Private _cotacao As Cotacao
    Private _produto As Produto

    Public Sub New(quantidade As Integer, cotacao As Cotacao, produto As Produto)
        _quantidade = quantidade
        _cotacao = cotacao
        _produto = produto
    End Sub

    Public Sub New()

    End Sub

    Public Property Quantidade As Integer
        Get
            Return _quantidade
        End Get
        Set(value As Integer)
            _quantidade = value
        End Set
    End Property

    Public Property Cotacao As Cotacao
        Get
            Return _cotacao
        End Get
        Set(value As Cotacao)
            _cotacao = value
        End Set
    End Property

    Public Property Produto As Produto
        Get
            Return _produto
        End Get
        Set(value As Produto)
            _produto = value
        End Set
    End Property
End Class
