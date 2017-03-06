Option Explicit On
Option Strict On
Imports NobelTheater

Public Class Fornecedor
    Private _id As Long
    Private _cnpj As String
    Private _razaoSocial As String
    Private _nomeFantasia As String
    Private _telefone As String
    Private _inicioRelacionamento As Date
    Private _tipoFornecedor As String
    Private _logradouro As String
    Private _numero As String
    Private _bairro As String
    Private _cidade As String
    Private _estado As String
    Private _cep As String
    Private _tipoEndereco As String
    Private _Assistencia As Fornecedor

    Public Sub New()

    End Sub

    Public Sub New(cnpj As String, razaoSocial As String, nomeFantasia As String, telefone As String, inicioRelacionamento As Date, tipoFornecedor As String, logradouro As String, numero As String, bairro As String, cidade As String, estado As String, cep As String, tipoEndereco As String)
        _cnpj = cnpj
        _razaoSocial = razaoSocial
        _nomeFantasia = nomeFantasia
        _telefone = telefone
        _inicioRelacionamento = inicioRelacionamento
        _tipoFornecedor = tipoFornecedor
        _logradouro = logradouro
        _numero = numero
        _bairro = bairro
        _cidade = cidade
        _estado = estado
        _cep = cep
        _tipoEndereco = tipoEndereco
    End Sub

    Public Property Id As Long
        Get
            Return _id
        End Get
        Set(value As Long)
            _id = value
        End Set
    End Property

    Public Property Cnpj As String
        Get
            Return _cnpj
        End Get
        Set(value As String)
            _cnpj = value
        End Set
    End Property

    Public Property RazaoSocial As String
        Get
            Return _razaoSocial
        End Get
        Set(value As String)
            _razaoSocial = value
        End Set
    End Property

    Public Property NomeFantasia As String
        Get
            Return _nomeFantasia
        End Get
        Set(value As String)
            _nomeFantasia = value
        End Set
    End Property

    Public Property Telefone As String
        Get
            Return _telefone
        End Get
        Set(value As String)
            _telefone = value
        End Set
    End Property

    Public Property InicioRelacionamento As Date
        Get
            Return _inicioRelacionamento
        End Get
        Set(value As Date)
            _inicioRelacionamento = value
        End Set
    End Property

    Public Property TipoFornecedor As String
        Get
            Return _tipoFornecedor
        End Get
        Set(value As String)
            _tipoFornecedor = value
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

    Public Property TipoEndereco As String
        Get
            Return _tipoEndereco
        End Get
        Set(value As String)
            _tipoEndereco = value
        End Set
    End Property

    Public Property Assistencia As Fornecedor
        Get
            Return _Assistencia
        End Get
        Set(value As Fornecedor)
            _Assistencia = value
        End Set
    End Property

End Class
