Option Explicit On
Option Strict On

Public Class NotaFiscalVenda
    Private _id As Long
    Private _dataOrcamento As Date
    Private _status As String
    Private _dataAprovacao As Date
    Private _dataFinalObra As Date
    Private _dataPagamento As Date
    Private _clientePF As ClientePF
    Private _clientePJ As ClientePJ
    Private _pagamentos As New List(Of PagamentoRecebido)
    Private _numeroNF As Integer
    Private _emissaoNF As Date
    Private _produtos As New List(Of Cliente)

    Public Sub New(dataOrcamento As Date, status As String, numeroNF As Integer, emissaoNF As Date, clientePF As ClientePF)
        _dataOrcamento = dataOrcamento
        _status = status
        _numeroNF = numeroNF
        _emissaoNF = emissaoNF
        _clientePF = clientePF
        _clientePJ = Nothing
    End Sub

    Public Sub New(dataOrcamento As Date, status As String, numeroNF As Integer, emissaoNF As Date, clientePJ As ClientePJ)
        _dataOrcamento = dataOrcamento
        _status = status
        _numeroNF = numeroNF
        _emissaoNF = emissaoNF
        _clientePJ = clientePJ
        _clientePF = Nothing
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

    Property Produtos As List(Of Cliente)
        Get
            Return _produtos
        End Get
        Set(value As List(Of Cliente))
            _produtos = value
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

    Property DataOrcamento As Date
        Get
            Return _dataOrcamento
        End Get
        Set(value As Date)
            _dataOrcamento = value
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

    Property DataFinalObra As Date
        Get
            Return _dataFinalObra
        End Get
        Set(value As Date)
            _dataFinalObra = value
        End Set
    End Property

    Property DataPagamento As Date
        Get
            Return _dataPagamento
        End Get
        Set(value As Date)
            _dataPagamento = value
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

    Property ClientePF As ClientePF
        Get
            Return _clientePF
        End Get
        Set(value As ClientePF)
            _clientePF = value
        End Set
    End Property

    Property ClientePJ As ClientePJ
        Get
            Return _clientePJ
        End Get
        Set(value As ClientePJ)
            _clientePJ = value
        End Set
    End Property

    Property Pagamentos As List(Of PagamentoRecebido)
        Get
            Return _pagamentos
        End Get
        Set(value As List(Of PagamentoRecebido))
            _pagamentos = value
        End Set
    End Property
End Class
