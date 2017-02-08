Option Explicit On
Option Strict On

Public Class Cliente
    Private _id As Long
    Private _nome As String
    Private _telefone As String
    Private _dataCadastro As Date

    Private _enderecos As List(Of EnderecoCliente)

    Public Sub New(id As Long, nome As String, telefone As String, dataCadastro As Date)
        _id = id
        _nome = nome
        _telefone = telefone
        _dataCadastro = dataCadastro
        _enderecos = New List(Of EnderecoCliente)
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

    Property Nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property

    Property Telefone As String
        Get
            Return _telefone
        End Get
        Set(value As String)
            _telefone = value
        End Set
    End Property

    Property DataCadastro As Date
        Get
            Return _dataCadastro
        End Get
        Set(value As Date)
            _dataCadastro = value
        End Set
    End Property

    Property Enderecos As List(Of EnderecoCliente)
        Get
            Return _enderecos
        End Get
        Set(value As List(Of EnderecoCliente))
            _enderecos = value
        End Set
    End Property

End Class
