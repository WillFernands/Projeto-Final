Option Explicit On
Option Strict On

Public NotInheritable Class ItemEmprestimo
    Private _produto As Produto
    Private _solicitacaoEmprestimo As Long
    Private _quantidade As Integer
    Private _dataEmprestimo As Date
    Private _dataDevolucao As Date

    Public Sub New(produto As Produto, solicitacaoEmprestimo As Long, quantidade As Integer, DataEmprestimo As Date, DataDevolucao As Date)
        _produto = produto
        _solicitacaoEmprestimo = solicitacaoEmprestimo
        _quantidade = quantidade
        _dataEmprestimo = DataEmprestimo
        _dataDevolucao = DataDevolucao
    End Sub

    Public Sub New()

    End Sub

    Property Produto As Produto
        Get
            Return _produto
        End Get
        Set(value As Produto)
            _produto = value
        End Set
    End Property

    Public Property SolicitacaoEmprestimo As Long
        Get
            Return _solicitacaoEmprestimo
        End Get
        Set(value As Long)
            _solicitacaoEmprestimo = value
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

    Public Property DataEmprestimo As Date
        Get
            Return _dataEmprestimo
        End Get
        Set(value As Date)
            _dataEmprestimo = value
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
