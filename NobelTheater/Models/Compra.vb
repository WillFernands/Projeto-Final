Option Explicit On
Option Strict On

Public Class Compra
    Private _id As Long
    Private _dataCotacao As Date
    Private _status As String
    Private _dataAprovacao As Date
    Private _dataPagamento As Date
    Private _notaFiscal As NotaFiscal
    Private _fornecedor As Fornecedor
    Private _pagamentos As New List(Of Pagamento)

    Public Sub New(dataCotacao As Date, status As String, notaFiscal As NotaFiscal, fornecedor As Fornecedor)
        _dataCotacao = dataCotacao
        _status = status
        _notaFiscal = notaFiscal
        _fornecedor = fornecedor
    End Sub

    Property ID As Long
        Get
            Return _id
        End Get
        Set(value As Long)
            _id = value
        End Set
    End Property

    Property DataCotacao As Date
        Get
            Return _dataCotacao
        End Get
        Set(value As Date)
            _dataCotacao = value
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

    Property NotaFiscal As NotaFiscal
        Get
            Return _notaFiscal
        End Get
        Set(value As NotaFiscal)
            _notaFiscal = value
        End Set
    End Property

    Property Fornecedor As Fornecedor
        Get
            Return _fornecedor
        End Get
        Set(value As Fornecedor)
            _fornecedor = value
        End Set
    End Property

    Property Pagamentos As List(Of Pagamento)
        Get
            Return _pagamentos
        End Get
        Set(value As List(Of Pagamento))
            _pagamentos = value
        End Set
    End Property
End Class
