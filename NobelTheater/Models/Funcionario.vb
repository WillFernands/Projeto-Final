Option Explicit On
Option Strict On
Imports NobelTheater

Public Class Funcionario
    Private _matricula As Long
    Private _cpf As Long
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
    Private _cep As Long
    Private _tipoEndereco As String

    Private _senha As String 'Esqueci no diagrama de classe e no DER

    Private _supervisor As Funcionario
    Private _salario As List(Of Salario)
    Private _registroPonto As List(Of RegistroPonto)

    Public Sub New(ByVal matricula As Long, ByVal cpf As Long, ByVal nome As String, ByVal telefone As String, ByVal dataContratacao As Date,
ByVal perfil As String, ByVal cargo As String, ByVal logradouro As String, ByVal numero As String,
ByVal bairro As String, ByVal cidade As String, ByVal estado As String, ByVal cep As Long, ByVal tipoEndereco As String, supervisor As Funcionario, salario As List(Of Salario), registroPonto As List(Of RegistroPonto))
        _matricula = matricula
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
        _supervisor = supervisor
        _salario = salario
        _registroPonto = registroPonto
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

    Public Property Cpf As Long
        Get
            Return _cpf
        End Get
        Set(value As Long)
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

    Public Property Cep As Long
        Get
            Return _cep
        End Get
        Set(value As Long)
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

    Public Property Salario As List(Of Salario)
        Get
            Return _salario
        End Get
        Set(value As List(Of Salario))
            _salario = value
        End Set
    End Property

    Public Property RegistroPonto As List(Of RegistroPonto)
        Get
            Return _registroPonto
        End Get
        Set(value As List(Of RegistroPonto))
            _registroPonto = value
        End Set
    End Property
End Class
