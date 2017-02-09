Imports NobelTheater

Public Class ItemVendido
    Private _produto As Produto
    Private _notaFiscal As NotaFiscalVenda
    Private _quantidade As Integer

    Public Sub New()

    End Sub

    Public Sub New(produto As Produto, notaFiscal As NotaFiscalVenda, quantidade As Integer)
        _produto = produto
        _notaFiscal = notaFiscal
        _quantidade = quantidade
    End Sub

    Public Property Produto As Produto
        Get
            Return _produto
        End Get
        Set(value As Produto)
            _produto = value
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

    Public Property Quantidade As Integer
        Get
            Return _quantidade
        End Get
        Set(value As Integer)
            _quantidade = value
        End Set
    End Property
End Class
