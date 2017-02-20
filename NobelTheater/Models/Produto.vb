Option Explicit On
Option Strict On

Public Class Produto
    Private _codigo As Long
    Private _nome As String
    Private _precoUnit As Double
    Private _descricao As String
    Private _imagem As Image

    Private _tipo As String
    Private _unidade As String

    Private _alertas As New List(Of Alerta)

    Public Sub New(codigo As Long, nome As String, preco As Double, descricao As String, tipo As String, unidade As String)
        _codigo = codigo
        _nome = nome
        _precoUnit = preco
        _descricao = descricao
        _tipo = tipo
        _unidade = unidade
    End Sub

    Public Sub New()

    End Sub

    Property Codigo As Long
        Get
            Return _codigo
        End Get
        Set(value As Long)
            _codigo = value
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

    Property Tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property

End Class
