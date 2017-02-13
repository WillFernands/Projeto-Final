Imports NobelTheater

Public Class SolicitacaoEmprestimo
    Private _id As Long
    Private _dataSolicitacao As Date
    Private _status As String

    Private _cliente As Cliente

    Private _itemEmprestimo As List(Of ItemEmprestimo)

    Public Sub New()

    End Sub

    Public Sub New(id As Long, dataSolicitacao As Date, cliente As Cliente, status As String, itemEmprestimo As List(Of ItemEmprestimo))
        _id = id
        _dataSolicitacao = dataSolicitacao
        _cliente = cliente
        _status = status
        _itemEmprestimo = itemEmprestimo
    End Sub

    Public Property Id As Long
        Get
            Return _id
        End Get
        Set(value As Long)
            _id = value
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

    Public Property Cliente As Cliente
        Get
            Return _cliente
        End Get
        Set(value As Cliente)
            _cliente = value
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

    Public Property ItemEmprestimo As List(Of ItemEmprestimo)
        Get
            Return _itemEmprestimo
        End Get
        Set(value As List(Of ItemEmprestimo))
            _itemEmprestimo = value
        End Set
    End Property
End Class
