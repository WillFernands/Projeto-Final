Option Explicit On
Option Strict On

Public Class ClientePF : Inherits Cliente

    Private _cpf As Long

    Public Sub New(id As Long, nome As String, telefone As String, dataCadastro As Date, cpf As Long)
        MyBase.New(id, nome, telefone, dataCadastro)
        _cpf = cpf
    End Sub

    Property CPF As Long
        Get
            Return _cpf
        End Get
        Set(value As Long)
            _cpf = value
        End Set
    End Property

End Class
