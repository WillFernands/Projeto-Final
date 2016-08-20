Option Explicit On
Option Strict On

Public Class Produto
    Private _id As Long
    Private _nome As String
    Private _tipo As String
    Private _descricao As String
    Private _marca As String
    Private _notaFiscal As NotaFiscal
    Private _quantidade As Integer
    Private _unidade As String
    Private _precoUnit As Double
    Private _imagem As Image

    Public Sub New(nome As String, tipo As String, descricao As String, marca As String, notaFiscal As NotaFiscal, qtde As Integer, unidade As String, preco As Double)
        _nome = nome
        _descricao = descricao
        _marca = marca
        _notaFiscal = notaFiscal
        _tipo = tipo
        _quantidade = qtde
        _unidade = unidade
        _precoUnit = preco
    End Sub

    Property ID As Long
        Get
            Return _id
        End Get
        Set(value As Long)
            _id = value
        End Set
    End Property

    Property Imagem As Image
        Get
            Return _imagem
        End Get
        Set(value As Image)
            _imagem = value
        End Set
    End Property

    Property Nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property

    Property Descricao As String
        Get
            Return _descricao
        End Get
        Set(value As String)
            _descricao = value
        End Set
    End Property

    Property Quantidade As Integer
        Get
            Return _quantidade
        End Get
        Set(value As Integer)
            _quantidade = value
        End Set
    End Property

    Property Unidade As String
        Get
            Return _unidade
        End Get
        Set(value As String)
            _unidade = value
        End Set
    End Property

    Property PrecoUnit As Double
        Get
            Return _precoUnit
        End Get
        Set(value As Double)
            _precoUnit = value
        End Set
    End Property

    Property Marca As String
        Get
            Return _marca
        End Get
        Set(value As String)
            _marca = value
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

    Property NotaFiscal As NotaFiscal
        Get
            Return _notaFiscal
        End Get
        Set(value As NotaFiscal)
            _notaFiscal = value
        End Set
    End Property
End Class
