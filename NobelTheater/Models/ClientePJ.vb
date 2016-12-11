﻿Option Explicit On
Option Strict On

Public Class ClientePJ : Inherits Cliente

    Private _cnpj As Long
    Private _razaoSocial As String

    Public Sub New(id As Long, nome As String, telefone As String, dataCadastro As Date, cnpj As Long, razaoSocial As String)
        MyBase.New(id, nome, telefone, dataCadastro)
        _cnpj = cnpj
        _razaoSocial = razaoSocial
    End Sub

    Property CNPJ As Long
        Get
            Return _cnpj
        End Get
        Set(value As Long)
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
