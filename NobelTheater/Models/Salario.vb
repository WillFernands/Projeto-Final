Imports NobelTheater

Public Class Salario
    Private _valor As Double
    Private _inicio As Date
    Private _fim As Date
    Private _motivo As String
    Private _funcionario As Funcionario

    Public Sub New()

    End Sub

    Public Sub New(valor As Double, inicio As Date, fim As Date, motivo As String, funcionario As Funcionario)
        _valor = valor
        _inicio = inicio
        _fim = fim
        _motivo = motivo
        _funcionario = funcionario
    End Sub

    Public Property Valor As Double
        Get
            Return _valor
        End Get
        Set(value As Double)
            _valor = value
        End Set
    End Property

    Public Property Inicio As Date
        Get
            Return _inicio
        End Get
        Set(value As Date)
            _inicio = value
        End Set
    End Property

    Public Property Fim As Date
        Get
            Return _fim
        End Get
        Set(value As Date)
            _fim = value
        End Set
    End Property

    Public Property Motivo As String
        Get
            Return _motivo
        End Get
        Set(value As String)
            _motivo = value
        End Set
    End Property

    Public Property Funcionario As Funcionario
        Get
            Return _funcionario
        End Get
        Set(value As Funcionario)
            _funcionario = value
        End Set
    End Property
End Class
