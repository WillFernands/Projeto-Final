Option Explicit On
Option Strict On

Public NotInheritable Class Alerta
    Private _data As Date
    Private _observacao As String
    Private _produto As Cliente
    
    Public Sub New(data As Date, observacao As String, produto As Cliente)
        _data = data
        _observacao = observacao
        _produto = produto
    End Sub

    Property Data As Date
        Get
            Return _data
        End Get
        Set(value As Date)
            _data = value
        End Set
    End Property

    Property Observacao As String
        Get
            Return _observacao
        End Get
        Set(value As String)
            _observacao = value
        End Set
    End Property

    Property Produto As Cliente
        Get
            Return _produto
        End Get
        Set(value As Cliente)
            _produto = value
        End Set
    End Property

End Class
