Option Explicit On
Option Strict On

Public Class ClientePF : Inherits PessoaFisica

    Private _id As Long
    Private _inicioRelacionamento As Date
    Private _status As String

    Public Sub New(ByVal nome As String, ByVal cpf As String, ByVal endereco As Endereco, ByVal telefone As String, ByVal inicioRelac As Date)
        _nome = nome
        _CPF = AddZeros(CleanString(cpf), "CPF")
        _inicioRelacionamento = inicioRelac
        _endereco = endereco
        _telefone = CleanString(telefone)
    End Sub

    Property ID As Long
        Get
            Return _id
        End Get
        Set(value As Long)
            _id = value
        End Set
    End Property

    Property InicioRelacionamento As Date
        Get
            Return _inicioRelacionamento
        End Get
        Set(value As Date)
            _inicioRelacionamento = value
        End Set
    End Property

    Property Status As String
        Get
            Return _status
        End Get
        Set(value As String)
            _status = value
        End Set
    End Property

End Class
