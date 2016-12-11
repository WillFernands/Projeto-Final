Option Explicit On
Option Strict On

Public Class Funcionario
    Private _matricula As Long
    Private _cpf As Long
    Private _nome As String
    Private _telefone As String
    Private _dataContratacao As Date
    Private _perfil As String
    Private _cargo As String
    Private _logradouro As String
    Private _numero As String
    Private _bairro As String
    Private _cidade As String
    Private _estado As String
    Private _cep As Long
    Private _tipoEndereco As String

    Private _senha As String 'Esqueci no diagrama de classe e no DER

    Private _supervisor As Funcionario
    Private _salario As List(Of Salario)
    Private _registroPonto As List(Of RegistroPonto)

    Public Sub New(ByVal matricula As Long, ByVal cpf As Long, ByVal nome As String, ByVal telefone As String, ByVal dataContratacao As Date,
                   ByVal perfil As String, ByVal cargo As String, ByVal logradouro As String, ByVal numero As String,
                   ByVal bairro As String, ByVal cidade As String, ByVal estado As String, ByVal cep As Long, ByVal tipoEndereco As String)

        _matricula = matricula
        _cpf = cpf
        _nome = nome
        _telefone = telefone
        _dataContratacao = dataContratacao
        _perfil = perfil
        _cargo = cargo
        _logradouro = logradouro
        _numero = numero
        _bairro = bairro
        _cidade = cidade
        _estado = estado
        _cep = cep
        _tipoEndereco = tipoEndereco
    End Sub

End Class
