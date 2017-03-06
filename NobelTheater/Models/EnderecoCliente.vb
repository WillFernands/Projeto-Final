Option Explicit On
Option Strict On
Imports NobelTheater

Public Class EnderecoCliente
    Private _id As Long
    Private _cliente As Cliente
    Private _logradouro As String
    Private _numero As String
    Private _bairro As String
    Private _cidade As String
    Private _estado As String
    Private _cep As String
    Private _tipo As String

    Public Sub New()

    End Sub

    Public Sub New(cliente As Cliente, logradouro As String, numero As String, bairro As String, cidade As String, estado As String, cep As String, tipo As String)
        _cliente = cliente
        _logradouro = logradouro
        _numero = numero
        _bairro = bairro
        _cidade = cidade
        _estado = estado
        _cep = cep
        _tipo = tipo
    End Sub

    Public Property Id As Long
        Get
            Return _id
        End Get
        Set(value As Long)
            _id = value
        End Set
    End Property

    Public Property Cliente As Cliente
        Get
            Return _cliente
        End Get
        Set(value As Cliente)
            _cliente = value
        End Set
    End Property

    Public Property Logradouro As String
        Get
            Return _logradouro
        End Get
        Set(value As String)
            _logradouro = value
        End Set
    End Property

    Public Property Numero As String
        Get
            Return _numero
        End Get
        Set(value As String)
            _numero = value
        End Set
    End Property

    Public Property Bairro As String
        Get
            Return _bairro
        End Get
        Set(value As String)
            _bairro = value
        End Set
    End Property

    Public Property Cidade As String
        Get
            Return _cidade
        End Get
        Set(value As String)
            _cidade = value
        End Set
    End Property

    Public Property Estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property

    Public Property Cep As String
        Get
            Return _cep
        End Get
        Set(value As String)
            _cep = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property
End Class

