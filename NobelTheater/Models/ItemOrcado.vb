Imports NobelTheater

Public Class ItemOrcado
    Private _produto As Produto
    Private _orcamento As Orcamento
    Private _quantidade As Integer

    Public Sub New(produto As Produto, orcamento As Orcamento, quantidade As Integer)
        _produto = produto
        _orcamento = orcamento
        _quantidade = quantidade
    End Sub

    Public Sub New()

    End Sub

    Public Property Produto As Produto
        Get
            Return _produto
        End Get
        Set(value As Produto)
            _produto = value
        End Set
    End Property

    Public Property Orcamento As Orcamento
        Get
            Return _orcamento
        End Get
        Set(value As Orcamento)
            _orcamento = value
        End Set
    End Property

    Public Property Quantidade As Integer
        Get
            Return _quantidade
        End Get
        Set(value As Integer)
            _quantidade = value
        End Set
    End Property

End Class
