Option Explicit On
Option Strict On

Public Class Pagamento
    Private _id As Long
    Private _status As String
    Private _valor As Double
    Private _data As Date
    Private _tipo As String
    Private _parcela As Integer
    Private _compra As Compra
    Private _venda As Venda
    
    Public Sub New(status As String, valor As Double, data As Date, tipo As String, parcela As Integer, compra As Compra)
        _status = status
        _valor = valor
        _data = data
        _tipo = tipo
        _parcela = parcela
        _compra = compra
        _venda = Nothing
    End Sub

    Public Sub New(status As String, valor As Double, data As Date, tipo As String, parcela As Integer, venda As Venda)
        _status = status
        _valor = valor
        _data = data
        _tipo = tipo
        _parcela = parcela
        _compra = Nothing
        _venda = Venda
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

    Property Parcela As Integer
        Get
            Return _parcela
        End Get
        Set(value As Integer)
            _parcela = value
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

    Property Compra As Compra
        Get
            Return _compra
        End Get
        Set(value As Compra)
            _compra = value
        End Set
    End Property

    Property Venda As Venda
        Get
            Return _venda
        End Get
        Set(value As Venda)
            _venda = value
        End Set
    End Property
End Class
