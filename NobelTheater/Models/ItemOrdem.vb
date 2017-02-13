Imports NobelTheater

Public Class ItemOrdem
    Private _quantidade As Integer
    Private _dataEntrega As Date
    Private _dataRecebimento As Date
    Private _dataDevolucao As Date

    Private _ordemServico As OrdemServico

    Private _produto As Produto

    Public Sub New()

    End Sub

    Public Sub New(quantidade As Integer, dataEntrega As Date, dataRecebimento As Date, dataDevolucao As Date, ordemServico As OrdemServico, produto As Produto)
        _quantidade = quantidade
        _dataEntrega = dataEntrega
        _dataRecebimento = dataRecebimento
        _dataDevolucao = dataDevolucao
        _ordemServico = ordemServico
        _produto = produto
    End Sub

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

    Public Property OrdemServico As OrdemServico
        Get
            Return _ordemServico
        End Get
        Set(value As OrdemServico)
            _ordemServico = value
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
