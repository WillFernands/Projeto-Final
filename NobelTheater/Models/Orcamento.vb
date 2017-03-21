Imports NobelTheater

Public Class Orcamento
    Private _id As Long
    Private _status As String
    Private _dataOrcamento As Date

    Private _vendedor As Funcionario

    Private _cliente As Cliente

    Private _itens As New List(Of ItemOrcado)

    Public Sub New()

    End Sub

    Public Sub New(dataOrcamento As Date, vendedor As Funcionario, cliente As Cliente, itensOrcados As List(Of ItemOrcado))
        _vendedor = vendedor
        _cliente = cliente
        _status = StatusOrcamento.Pendente
        _dataOrcamento = dataOrcamento
        _itens = itensOrcados
    End Sub


    Public Property Vendedor As Funcionario
        Get
            Return _vendedor
        End Get
        Set(value As Funcionario)
            _vendedor = value
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

    Public Property Id As Long
        Get
            Return _id
        End Get
        Set(value As Long)
            _id = value
        End Set
    End Property

    Public Property DataOrcamento As Date
        Get
            Return _dataOrcamento
        End Get
        Set(value As Date)
            _dataOrcamento = value
        End Set
    End Property

    Public Property Itens As List(Of ItemOrcado)
        Get
            Return _itens
        End Get
        Set(value As List(Of ItemOrcado))
            _itens = value
        End Set
    End Property
End Class
