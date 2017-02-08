Option Explicit On
Option Strict On
Imports NobelTheater

Public Class Fornecedor : Inherits PessoaJuridica
    Private _id As Long
    Private _inscricaoEstadual As String

    Public Sub New()

    End Sub

    Public Sub New(razaoSocial As String, cnpj As String, endereco As EnderecoCliente, telefone As String, inscricao As String)
        _razaoSocial = razaoSocial
        _CNPJ = AddZeros(CleanString(cnpj), "CNPJ")
        _endereco = endereco
        _telefone = CleanString(telefone)
        _inscricaoEstadual = inscricao
    End Sub

    Public Property ID As Long
        Get
            Return _id
        End Get
        Set(value As Long)
            _id = value
        End Set
    End Property

    Public Property InscricaoEstadual As String
        Get
            Return _inscricaoEstadual
        End Get
        Set(value As String)
            _inscricaoEstadual = value
        End Set
    End Property

End Class
