Option Explicit On
Option Strict On

Public Class Cotacao

    Private _id As Long
    Private _dataCotacao As Date
    Private _status As String

    Private _fornecedor As Fornecedor
    Private _itens As List(Of ItemCotado)

    Public Sub New()

    End Sub

    Public Sub New(data As Date, fornecedor As Fornecedor, itens As List(Of ItemCotado))
        _dataCotacao = data
        _status = StatusCotacao.Cotada
        _fornecedor = fornecedor
        _itens = itens
        '_fornedor = New Fornecedor()
        '_fornecedor.Cotacao = Me
    End Sub

    Property ID As Long
        Get
            Return _id
        End Get
        Set(value As Long)
            _id = value
        End Set
    End Property

    Property DataCotacao As Date
        Get
            Return _dataCotacao
        End Get
        Set(value As Date)
            _dataCotacao = value
        End Set
    End Property

    Property Status As String
        Get
            Return _status
        End Get
        Set(value As String)
            If (StatusCotacao.GetStatusList.Contains(value)) Then
                _status = value
            Else : _status = StatusCotacao.Cotada
            End If
        End Set
    End Property

    Property Fornecedor As Fornecedor
        Get
            Return _fornecedor
        End Get
        Set(value As Fornecedor)
            _fornecedor = value
        End Set
    End Property

    Property Itens As List(Of ItemCotado)
        Get
            Return _itens
        End Get
        Set(value As List(Of ItemCotado))
            _itens = value
        End Set
    End Property
End Class