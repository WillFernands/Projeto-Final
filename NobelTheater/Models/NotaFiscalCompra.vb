Option Explicit On
Option Strict On
Imports NobelTheater

Public Class NotaFiscalCompra
    Private _id As Long
    Private _status As String
    Private _dataAprovacao As Date
    Private _numeroNF As String
    Private _emissaoNF As Date

    Private _cotacao As Cotacao

    Private _pagamentos As New List(Of PagamentoEfetuado)
    Private _items As New List(Of ItemComprado)

    Public Sub New(status As String, dataAprovacao As Date, numeroNF As String, emissaoNF As Date, cotacao As Cotacao)
        _status = status
        _dataAprovacao = dataAprovacao
        _numeroNF = numeroNF
        _emissaoNF = emissaoNF
        _cotacao = cotacao
    End Sub

    Public Sub New()

    End Sub

    Property NumeroNF As String
        Get
            Return _numeroNF
        End Get
        Set(value As String)
            _numeroNF = value
        End Set
    End Property

    Property EmissaoNF As Date
        Get
            Return _emissaoNF
        End Get
        Set(value As Date)
            _emissaoNF = value
        End Set
    End Property

    Property Items As List(Of ItemComprado)
        Get
            Return _items
        End Get
        Set(value As List(Of ItemComprado))
            _items = value
        End Set
    End Property

    Property ID As Long
        Get
            Return _id
        End Get
        Set(value As Long)
            _id = value
        End Set
    End Property

    Property DataAprovacao As Date
        Get
            Return _dataAprovacao
        End Get
        Set(value As Date)
            _dataAprovacao = value
        End Set
    End Property

    Property Status As String
        Get
            Return _status
        End Get
        Set(value As String)
            _status = value
        End Set
    End Property

    Property Pagamentos As List(Of PagamentoEfetuado)
        Get
            Return _pagamentos
        End Get
        Set(value As List(Of PagamentoEfetuado))
            _pagamentos = value
        End Set
    End Property

    Property Cotacao As Cotacao
        Get
            Return _cotacao
        End Get
        Set(value As Cotacao)
            _cotacao = value
        End Set
    End Property

End Class
