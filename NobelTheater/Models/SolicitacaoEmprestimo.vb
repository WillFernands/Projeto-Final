Imports NobelTheater

Public Class SolicitacaoEmprestimo
    Private _id As Long
    Private _dataSolicitacao As Date
    Private _cliente As Cliente
    Private _status As String

    Public Sub New()

    End Sub

    Public Sub New(id As Long, dataSolicitacao As Date, cliente As Cliente, status As String)
        _id = id
        _dataSolicitacao = dataSolicitacao
        _cliente = cliente
        _status = status
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
End Class
