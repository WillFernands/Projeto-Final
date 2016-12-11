Option Explicit On
Option Strict On

Public Class NotaFiscalCompra
    Private _id As Long
    Private _status As String
    Private _dataAprovacao As Date
    Private _numeroNF As Integer
    Private _emissaoNF As Date

    Private _cotacao As Cotacao

    Private _pagamentos As New List(Of PagamentoEfetuado)
    Private _items As New List(Of ItemComprado)

    Public Sub New()
        'fazer construtor
    End Sub

    Property NumeroNF As Integer
        Get
            Return _numeroNF
        End Get
        Set(value As Integer)
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
        Set(value As String)
            _cotacao = value
        End Set
    End Property

End Class
