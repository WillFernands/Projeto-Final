﻿Imports NobelTheater

Public Class VisitaTecnica
    Private _data As Date
    Private _tipo As String
    Private _preco As Double
    Private _parecerObra As String

    Private _supervisor As Funcionario

    Private _notaFiscal As NotaFiscalVenda

    Public Sub New()

    End Sub

    Public Sub New(data As Date, tipo As String, preco As Double, supervisor As Funcionario, notaFiscal As NotaFiscalVenda)
        _data = data
        _tipo = tipo
        _preco = preco
        _supervisor = supervisor
        _notaFiscal = notaFiscal
    End Sub

    Public Property Data As Date
        Get
            Return _data
        End Get
        Set(value As Date)
            _data = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property

    Public Property Preco As Double
        Get
            Return _preco
        End Get
        Set(value As Double)
            _preco = value
        End Set
    End Property

    Public Property ParecerObra As String
        Get
            Return _parecerObra
        End Get
        Set(value As String)
            _parecerObra = value
        End Set
    End Property

    Public Property NotaFiscal As NotaFiscalVenda
        Get
            Return _notaFiscal
        End Get
        Set(value As NotaFiscalVenda)
            _notaFiscal = value
        End Set
    End Property

    Public Property Supervisor As Funcionario
        Get
            Return _supervisor
        End Get
        Set(value As Funcionario)
            _supervisor = value
        End Set
    End Property
End Class
