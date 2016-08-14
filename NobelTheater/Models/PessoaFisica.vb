Option Explicit On
Option Strict On

Public MustInherit Class PessoaFisica : Inherits Pessoa
    Protected _nome As String
    Protected _CPF As String

    Property Nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property

    Property CPF As String
        Get
            Return _CPF
        End Get
        Set(value As String)
            _CPF = CleanString(value)
        End Set
    End Property

End Class
