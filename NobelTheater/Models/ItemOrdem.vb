Imports NobelTheater

Public Class ItemOrdem
    Private _produto As Produto
    Private _quantidade As Integer
    Private _dataEntrega As Date
    Private _dataRecebimento As Date
    Private _dataDevolucao As Date

    Public Sub New()

    End Sub

    Public Sub New(produto As Produto, quantidade As Integer, dataEntrega As Date, dataRecebimento As Date, dataDevolucao As Date)
        _produto = produto
        _quantidade = quantidade
        _dataEntrega = dataEntrega
        _dataRecebimento = dataRecebimento
        _dataDevolucao = dataDevolucao
    End Sub

    Public Property Produto As Produto
        Get
            Return _produto
        End Get
        Set(value As Produto)
            _produto = value
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

    Public Property DataEntrega As Date
        Get
            Return _dataEntrega
        End Get
        Set(value As Date)
            _dataEntrega = value
        End Set
    End Property

    Public Property DataRecebimento As Date
        Get
            Return _dataRecebimento
        End Get
        Set(value As Date)
            _dataRecebimento = value
        End Set
    End Property

    Public Property DataDevolucao As Date
        Get
            Return _dataDevolucao
        End Get
        Set(value As Date)
            _dataDevolucao = value
        End Set
    End Property

End Class
