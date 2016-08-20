Option Explicit On
Option Strict On

Public Class NotaFiscal
    Private _id As Long
    Private _numeroNF As Integer
    Private _emissao As Date
    Private _produtos As New List(Of Produto)
    Private _tipo As String
    Private _compra As Compra
    Private _venda As Venda

    Public Sub New(numeroNF As Integer, emissao As Date, compra As Compra)
        _numeroNF = numeroNF
        _emissao = emissao
        _tipo = TipoNotaFiscal.Entrada
        _compra = compra
        _venda = Nothing
    End Sub

    Public Sub New(numeroNF As Integer, emissao As Date, venda As Venda)
        _numeroNF = numeroNF
        _emissao = emissao
        _tipo = TipoNotaFiscal.Saida
        _venda = venda
        _compra = Nothing
    End Sub

    Property ID As Long
        Get
            Return _id
        End Get
        Set(value As Long)
            _id = value
        End Set
    End Property

    Property NumeroNF As Integer
        Get
            Return _numeroNF
        End Get
        Set(value As Integer)
            _numeroNF = value
        End Set
    End Property

    Property Emissao As Date
        Get
            Return _emissao
        End Get
        Set(value As Date)
            _emissao = value
        End Set
    End Property

    Property Produtos As List(Of Produto)
        Get
            Return _produtos
        End Get
        Set(value As List(Of Produto))
            _produtos = value
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
