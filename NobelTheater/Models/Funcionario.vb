Option Explicit On
Option Strict On
Imports NobelTheater

Public Class Funcionario
    Private _matricula As Long
    Private _cpf As String
    Private _nome As String
    Private _telefone As String
    Private _dataContratacao As Date
    Private _perfil As String
    Private _cargo As String
    Private _logradouro As String
    Private _numero As String
    Private _bairro As String
    Private _cidade As String
    Private _estado As String
    Private _cep As String
    Private _tipoEndereco As String
    Private _dataRevogacao As Date
    Private _revogado As Boolean

    Private _senha As String 'Esqueci no diagrama de classe e no DER

    Private _supervisor As Funcionario
    Private _salarios As New List(Of Salario)
    Private _registrosPontos As New List(Of RegistroPonto)

    Public Sub New(ByVal cpf As String, ByVal nome As String, ByVal telefone As String, ByVal dataContratacao As Date,
ByVal perfil As String, ByVal cargo As String, ByVal logradouro As String, ByVal numero As String,
ByVal bairro As String, ByVal cidade As String, ByVal estado As String, ByVal cep As String, ByVal tipoEndereco As String)
        _cpf = cpf
        _nome = nome
        _telefone = telefone
        _dataContratacao = dataContratacao
        _perfil = perfil
        _cargo = cargo
        _logradouro = logradouro
        _numero = numero
        _bairro = bairro
        _cidade = cidade
        _estado = estado
        _cep = cep
        _tipoEndereco = tipoEndereco
    End Sub

    Public Sub New()

    End Sub

    Public Property Matricula As Long
        Get
            Return _matricula
        End Get
        Set(value As Long)
            _matricula = value
        End Set
    End Property

    Public Property Cpf As String
        Get
            Return _cpf
        End Get
        Set(value As String)
            _cpf = value
        End Set
    End Property

    Public Property Nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
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

    Public Property DataContratacao As Date
        Get
            Return _dataContratacao
        End Get
        Set(value As Date)
            _dataContratacao = value
        End Set
    End Property

    Public Property Perfil As String
        Get
            Return _perfil
        End Get
        Set(value As String)
            _perfil = value
        End Set
    End Property

    Public Property Cargo As String
        Get
            Return _cargo
        End Get
        Set(value As String)
            _cargo = value
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

    Public Property Senha As String
        Get
            Return _senha
        End Get
        Set(value As String)
            _senha = value
        End Set
    End Property

    Public Property Supervisor As Funcionario
        Get
            Return _supervisor
        End Get
        Set(value As Funcionario)
            _supervisor = value
        End Set
    End Property

    Public Property Salarios As List(Of Salario)
        Get
            Return _salarios
        End Get
        Set(value As List(Of Salario))
            _salarios = value
        End Set
    End Property

    Public Property RegistroPontos As List(Of RegistroPonto)
        Get
            Return _registrosPontos
        End Get
        Set(value As List(Of RegistroPonto))
            _registrosPontos = value
        End Set
    End Property

    Public Property DataRevogacao As Date
        Get
            Return _dataRevogacao
        End Get
        Set(value As Date)
            _dataRevogacao = value
        End Set
    End Property

    Public Property Revogado As Boolean
        Get
            Return _revogado
        End Get
        Set(value As Boolean)
            _revogado = value
        End Set
    End Property
End Class
