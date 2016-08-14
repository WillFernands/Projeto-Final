Option Explicit On
Option Strict On

Public Class NotaFiscal
    Private _id As Long
    Private _numeroNF As Integer
    Private _emissao As Date
    Private _produtos As List(Of Produto)
    Private _fornecedor As Fornecedor

    Public Sub New(numeroNF As Integer, emissao As Date, fornecedor As Fornecedor)
        _fornecedor = fornecedor
        _numeroNF = numeroNF
        _emissao = emissao
        _produtos = New List(Of Produto)
    End Sub

    Public Sub New()

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

    Property Fornecedor As Fornecedor
        Get
            Return _fornecedor
        End Get
        Set(value As Fornecedor)
            _fornecedor = value
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
End Class
