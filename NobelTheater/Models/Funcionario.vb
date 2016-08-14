Option Explicit On
Option Strict On

Public Class Funcionario : Inherits PessoaFisica
    Private _id As Long
    Private _matricula As String
    Private _perfil As String
    Private _salario As Double
    Private _senha As String

    Public Sub New(ByVal cpf As String, ByVal nome As String, ByVal matricula As String, ByVal perfil As String, ByVal salario As Double)
        _CPF = CleanString(cpf)
        _nome = nome
        _matricula = matricula
        _perfil = perfil
        _salario = salario
    End Sub

    Public Sub New(ByVal id As Integer, ByVal cpf As String, ByVal nome As String, ByVal matricula As String, ByVal perfil As String, ByVal salario As Double)
        Me.New(cpf, nome, matricula, perfil, salario)
        _id = id
    End Sub

    Sub New()

    End Sub

    Property ID As Long
        Get
            Return _id
        End Get
        Set(value As Long)
            _id = value
        End Set
    End Property

    Property Senha As String
        Get
            Return _senha
        End Get
        Set(value As String)
            _senha = value
        End Set
    End Property

    Property Matricula As String
        Get
            Return _matricula
        End Get
        Set(value As String)
            _matricula = value
        End Set
    End Property

    Property Perfil As String
        Get
            Return _perfil
        End Get
        Set(value As String)
            _perfil = value
        End Set
    End Property

    Property Salario As Double
        Get
            Return _salario
        End Get
        Set(value As Double)
            _salario = value
        End Set
    End Property
End Class
