Option Explicit On
Option Strict On

Public MustInherit Class PessoaJuridica : Inherits Pessoa
    Protected _razaoSocial As String
    Protected _CNPJ As String

    Property RazaoSocial As String
        Get
            Return _razaoSocial
        End Get
        Set(value As String)
            _razaoSocial = value
        End Set
    End Property

    Property CNPJ As String
        Get
            Return _CNPJ
        End Get
        Set(value As String)
            _CNPJ = CleanString(value)
        End Set
    End Property

End Class
