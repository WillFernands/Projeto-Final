Option Explicit On
Option Strict On

Public MustInherit Class Pessoa
    Protected _telefone As String
    Protected _endereco As Endereco

    Public Property Endereco As Endereco
        Get
            Return _endereco
        End Get
        Set(value As Endereco)
            _endereco = value
        End Set
    End Property

    Public Property Telefone As String
        Get
            Return _telefone
        End Get
        Set(value As String)
            _telefone = CleanString(value)
        End Set
    End Property



End Class
