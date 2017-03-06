Option Explicit On
Option Strict On

Public Class ClientePJ : Inherits Cliente
    Private _cnpj As String
    Private _razaoSocial As String

    Public Sub New(nome As String, telefone As String, dataCadastro As Date, cnpj As String, razaoSocial As String)
        MyBase.New(nome, telefone, dataCadastro)
        _cnpj = cnpj
        _razaoSocial = razaoSocial
    End Sub

    Public Sub New()

    End Sub

    Property CNPJ As String
        Get
            Return _cnpj
        End Get
        Set(value As String)
            _cnpj = value
        End Set
    End Property

    Property RazaoSocial As String
        Get
            Return _razaoSocial
        End Get
        Set(value As String)
            _razaoSocial = value
        End Set
    End Property

End Class
