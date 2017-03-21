Imports NobelTheater

Public Class OrdemServico
    Private _id As Long
    Private _dataSolicitacao As Date
    Private _status As String

    Private _assistencia As Fornecedor
    Private _cliente As Cliente

    Private _itens As List(Of ItemOrdem)

    Public Sub New()

    End Sub

    Public Sub New(assistencia As Fornecedor, cliente As Cliente, dataSolicitacao As Date, status As String)
        _assistencia = assistencia
        _cliente = cliente
        _dataSolicitacao = dataSolicitacao
        _status = status
        _itens = New List(Of ItemOrdem)
    End Sub

    Public Property Id As Long
        Get
            Return _id
        End Get
        Set(value As Long)
            _id = value
        End Set
    End Property

    Public Property Fornecedor As Fornecedor
        Get
            Return _assistencia
        End Get
        Set(value As Fornecedor)
            _assistencia = value
        End Set
    End Property

    Public Property Cliente As Cliente
        Get
            Return _cliente
        End Get
        Set(value As Cliente)
            _cliente = value
        End Set
    End Property

    Public Property DataSolicitacao As Date
        Get
            Return _dataSolicitacao
        End Get
        Set(value As Date)
            _dataSolicitacao = value
        End Set
    End Property

    Public Property Status As String
        Get
            Return _status
        End Get
        Set(value As String)
            _status = value
        End Set
    End Property

    Public Property Itens As List(Of ItemOrdem)
        Get
            Return _itens
        End Get
        Set(value As List(Of ItemOrdem))
            _itens = value
        End Set
    End Property
End Class
