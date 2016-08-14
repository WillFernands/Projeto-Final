Option Explicit On
Option Strict On

Public NotInheritable Class Endereco
    Private _id As Long
    Private _cliente As Cliente
    Private _fornecedor As Fornecedor
    Private _logradouro As String
    Private _bairro As String
    Private _cidade As String
    Private _estado As String
    Private _cep As String
    Private _tipoImovel As TipoImovel

    Public Sub New(cliente As Cliente, logradouro As String, bairro As String, cidade As String, estado As String, cep As String, tipoImovel As TipoImovel)
        _cliente = cliente
        _logradouro = logradouro
        _bairro = bairro
        _cidade = cidade
        _estado = estado
        _cep = cep
        _tipoImovel = tipoImovel
    End Sub

    Public Sub New(fornecedor As Fornecedor, logradouro As String, bairro As String, cidade As String, estado As String, cep As String, tipoImovel As TipoImovel)
        _fornecedor = fornecedor
        _logradouro = logradouro
        _bairro = bairro
        _cidade = cidade
        _estado = estado
        _cep = cep
        _tipoImovel = tipoImovel
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

    Property Cliente As Cliente
        Get
            Return _cliente
        End Get
        Set(value As Cliente)
            _cliente = value
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

    Property Logradouro As String
        Get
            Return _logradouro
        End Get
        Set(value As String)
            _logradouro = value
        End Set
    End Property

    Property Bairro As String
        Get
            Return _bairro
        End Get
        Set(value As String)
            _bairro = value
        End Set
    End Property

    Property Cidade As String
        Get
            Return _cidade
        End Get
        Set(value As String)
            _cidade = value
        End Set
    End Property

    Property Estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property

    Property CEP As String
        Get
            Return _cep
        End Get
        Set(value As String)
            _cep = value
        End Set
    End Property

    Property TipoImovel As TipoImovel
        Get
            Return _tipoImovel
        End Get
        Set(value As TipoImovel)
            _tipoImovel = value
        End Set
    End Property
End Class
