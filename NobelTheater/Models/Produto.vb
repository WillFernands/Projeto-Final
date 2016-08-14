Option Explicit On
Option Strict On

Public Class Produto
    Private _id As Long
    Private _nomeProduto As String
    Private _tipoProduto As String
    Private _marca As String
    Private _fornecedor As Fornecedor

    Public Sub New(nome As String, tipoProduto As String, marca As String, fornecedor As Fornecedor)
        _nomeProduto = nome
        _marca = marca
        _fornecedor = fornecedor
        _tipoProduto = tipoProduto
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

    Property NomeProduto As String
        Get
            Return _nomeProduto
        End Get
        Set(value As String)
            _nomeProduto = value
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

    Property TipoProduto As String
        Get
            Return _tipoProduto
        End Get
        Set(value As String)
            _tipoProduto = value
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
End Class
