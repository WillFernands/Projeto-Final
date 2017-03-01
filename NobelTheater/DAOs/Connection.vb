' Observações !!
' Se um parametro passado a uma DAO for Nothing/Inválido                -> Retorna Nothing
' Se uma dt retornar Empty/Nothing e o retorno for um objeto            -> Retorna Nothing
' Se uma dt retornar Empty/Nothing e o retorno for uma lista de objetos -> Retorna New List(Of Object) 


Option Explicit On
Option Strict On

Imports System.Data.SqlClient

Public Class Connection

    Private Conn As SqlConnection
    Private Query As SqlCommand
    Private Const ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Leonardo\Documents\PUC Stuff\7 Periodo\Projeto Final\NobelTheater\NobelTheater\NobelTheater.mdf;Integrated Security=True;Connect Timeout=30"

    Public Sub New()
        Conn = New SqlConnection(ConnectionString)
        Conn.Open()
        Query = New SqlCommand("", Me.Conn)
    End Sub

    ReadOnly Property Connection As SqlConnection
        Get
            Return Conn
        End Get
    End Property

    Public Sub OpenConnection()
        If (Conn.State = ConnectionState.Closed) Then Conn.Open()
    End Sub

    Public Sub CloseConnection()
        If (Conn.State = ConnectionState.Open) Then Conn.Close()
    End Sub

    Public Function ExecuteCommand(ByVal cmd As String) As Boolean
        Try
            OpenConnection()
            Query.CommandText = cmd
            Query.Transaction = Conn.BeginTransaction()
            Query.ExecuteNonQuery()
            Query.Transaction.Commit()
            Return True
        Catch ex As Exception
            Return False
        Finally
            CloseConnection()
        End Try
    End Function

    Public Function ExecuteSelect(ByVal cmd As String) As DataTable
        Dim dt As New DataTable

        Try
            OpenConnection()

            Query.CommandText = cmd
            Query.Transaction = Conn.BeginTransaction()
            Query.Transaction.Commit()

            dt.Load(Query.ExecuteReader())

            Return dt
        Catch ex As Exception
            Return Nothing
        Finally
            CloseConnection()
        End Try
    End Function

    Public Function ExecuteScalar(ByVal cmd As String) As Object
        Try
            OpenConnection()

            Query.CommandText = cmd
            Query.Transaction = Conn.BeginTransaction()
            Query.Transaction.Commit()

            Return Query.ExecuteScalar()

        Catch ex As Exception
            Return Nothing
        Finally
            CloseConnection()
        End Try
    End Function

    Public Function AddParameter(tag As String, value As Object) As Boolean
        Try
            Query.Parameters.Add(New SqlParameter(tag, value))
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
