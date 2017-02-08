﻿Imports NobelTheater

Public Class ItemComprado
    Private _produto As Produto
    Private _NotaFiscal As NotaFiscalCompra
    Private _quantidade As Integer

    Public Sub New(produto As Produto, NotaFiscal As NotaFiscalCompra, quantidade As Integer)
        _produto = produto
        _NotaFiscal = NotaFiscal
        _quantidade = quantidade
    End Sub

    Public Sub New()

    End Sub

    Public Property Produto As Produto
        Get
            Return _produto
        End Get
        Set(value As Produto)
            _produto = value
        End Set
    End Property

    Public Property NotaFiscal As NotaFiscalCompra
        Get
            Return _NotaFiscal
        End Get
        Set(value As NotaFiscalCompra)
            _NotaFiscal = value
        End Set
    End Property

    Public Property Quantidade As Integer
        Get
            Return _quantidade
        End Get
        Set(value As Integer)
            _quantidade = value
        End Set
    End Property

End Class
