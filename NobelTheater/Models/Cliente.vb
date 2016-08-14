Option Explicit On
Option Strict On

Public Class Cliente : Inherits PessoaFisica
    Private _id As Long
    Private _inicioRelacionamento As Date
    Private _status As String

    Public Sub New(ByVal nome As String, ByVal cpf As String, ByVal endereco As Endereco, ByVal telefone As String)
        _nome = nome
        _CPF = CleanString(cpf)
        _inicioRelacionamento = Now
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
            If (StatusCadastro.GetStatusList().Contains(value)) Then
                _status = value
            Else : _status = StatusCadastro.Irregular
            End If
        End Set
    End Property

End Class
