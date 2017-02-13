Option Explicit On
Option Strict On
Imports NobelTheater

Public Class NotaFiscalVenda
    Private _id As Long
    Private _status As String
    Private _dataAprovacao As Date
    Private _dataFinalObra As Date
    Private _numeroNF As Integer
    Private _emissaoNF As Date

    Private _Orcamento As Orcamento

    Private _pagamentoRecebido As New List(Of PagamentoRecebido)

    Public Sub New()

    End Sub

    Public Sub New(id As Long, status As String, dataAprovacao As Date, dataFinalObra As Date, numeroNF As Integer, emissaoNF As Date, Orcamento As Orcamento, pagamentoRecebido As List(Of PagamentoRecebido))
        _id = id
        _status = status
        _dataAprovacao = dataAprovacao
        _dataFinalObra = dataFinalObra
        _numeroNF = numeroNF
        _emissaoNF = emissaoNF
        _Orcamento = Orcamento
        _pagamentoRecebido = pagamentoRecebido
    End Sub

    Public Property Id As Long
        Get
            Return _id
        End Get
        Set(value As Long)
            _id = value
        End Set
    End Property

    Public Property Status As String
        Get
            Return _status
        End Get
        Set(value As String)
            _status = value
        End Set
    End Property

    Public Property DataAprovacao As Date
        Get
            Return _dataAprovacao
        End Get
        Set(value As Date)
            _dataAprovacao = value
        End Set
    End Property

    Public Property DataFinalObra As Date
        Get
            Return _dataFinalObra
        End Get
        Set(value As Date)
            _dataFinalObra = value
        End Set
    End Property

    Public Property NumeroNF As Integer
        Get
            Return _numeroNF
        End Get
        Set(value As Integer)
            _numeroNF = value
        End Set
    End Property

    Public Property EmissaoNF As Date
        Get
            Return _emissaoNF
        End Get
        Set(value As Date)
            _emissaoNF = value
        End Set
    End Property

    Public Property Orcamento As Orcamento
        Get
            Return _Orcamento
        End Get
        Set(value As Orcamento)
            _Orcamento = value
        End Set
    End Property

    Public Property PagamentoRecebido As List(Of PagamentoRecebido)
        Get
            Return _pagamentoRecebido
        End Get
        Set(value As List(Of PagamentoRecebido))
            _pagamentoRecebido = value
        End Set
    End Property
End Class
