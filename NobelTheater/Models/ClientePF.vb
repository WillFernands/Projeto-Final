Option Explicit On
Option Strict On

Public Class ClientePF : Inherits Cliente

    Private _cpf As String

    Public Sub New(id As Long, nome As String, telefone As String, dataCadastro As Date, cpf As String)
        MyBase.New(id, nome, telefone, dataCadastro)
        _cpf = cpf
    End Sub

    Public Sub New()

    End Sub

    Property CPF As String
        Get
            Return _cpf
        End Get
        Set(value As String)
            _cpf = value
        End Set
    End Property

End Class
