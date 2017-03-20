Option Explicit On
Option Strict On

Public Class PagamentoRecebido
    Private _id As Long
    Private _status As String
    Private _valor As Double
    Private _data As Date
    Private _tipo As String

    Private _notaFiscal As NotaFiscalVenda

    Public Sub New()

    End Sub

    Public Sub New(status As String, valor As Double, data As Date, tipo As String, notaFiscal As NotaFiscalVenda)
        _status = status
        _valor = valor
        _data = data
        _tipo = tipo
        _notaFiscal = notaFiscal
    End Sub

    Property ID As Long
        Get
            Return _id
        End Get
        Set(value As Long)
            _id = value
        End Set
    End Property

    Property Valor As Double
        Get
            Return _valor
        End Get
        Set(value As Double)
            _valor = value
        End Set
    End Property

    Property Data As Date
        Get
            Return _data
        End Get
        Set(value As Date)
            _data = value
        End Set
    End Property

    Property Tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
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

    Property NotaFiscal As NotaFiscalVenda
        Get
            Return _notaFiscal
        End Get
        Set(value As NotaFiscalVenda)
            _notaFiscal = value
        End Set
    End Property
End Class
