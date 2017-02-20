Imports NobelTheater

Public Class RegistroPonto
    Private _dataRegistro As Date
    Private _tipo As String
    Private _funcionario As Funcionario

    Public Sub New()

    End Sub

    Public Sub New(dataRegistro As Date, tipo As String, funcionario As Funcionario)
        _dataRegistro = dataRegistro
        _tipo = tipo
        _funcionario = funcionario
    End Sub

    Public Property DataRegistro As Date
        Get
            Return _dataRegistro
        End Get
        Set(value As Date)
            _dataRegistro = value
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

    Public Property Funcionario As Funcionario
        Get
            Return _funcionario
        End Get
        Set(value As Funcionario)
            _funcionario = value
        End Set
    End Property
End Class
