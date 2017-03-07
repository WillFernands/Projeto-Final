Option Explicit On
Option Strict On

Imports System.Text

Public Class OrcamentoDAO

    'OK
    Public Function Insert(ByVal orcamento As Orcamento) As Long
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO Orcamentos(dataOrcamento, matriculaVendedor, idCliente, statusOrcamento) ")
        strSQL.Append("VALUES(@data, @matricula, @idCliente, @status);")

        conn.AddParameter("@data", orcamento.DataOrcamento)
        conn.AddParameter("@matricula", orcamento.Vendedor.Matricula)
        conn.AddParameter("@idCliente", orcamento.Cliente.ID)
        conn.AddParameter("@status", orcamento.Status)

        If (conn.ExecuteCommand(strSQL.ToString) = False) Then Return 0

        conn = New Connection
        Return CLng(conn.ExecuteScalar("SELECT IDENT_CURRENT('Orcamentos')"))

    End Function

    'OK
    Public Function UpdateStatus(ByVal orcamento As Orcamento) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE Orcamentos ")
        strSQL.Append("SET statusOrcamento = @status ")
        strSQL.Append("WHERE id = @id;")

        conn.AddParameter("@id", orcamento.ID)
        conn.AddParameter("@status", orcamento.Status)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindByCliente(cliente As Cliente) As List(Of Orcamento)

        If (cliente Is Nothing) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@idCliente", cliente.ID)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM Orcamentos WHERE idCliente = @idCliente;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of Orcamento)

        Dim orcamentos As New List(Of Orcamento)

        For Each row As DataRow In dt.Rows
            Dim orcamento As New Orcamento()
            orcamento.ID = CLng(row.Item("id"))
            orcamento.DataOrcamento = CDate(row.Item("dataOrcamento"))
            orcamento.Vendedor = FuncionarioBC.FindByMatricula(CLng(row.Item("matriculaVendedor")))
            orcamento.Cliente = cliente
            orcamento.Status = CStr(row.Item("statusOrcamento"))
            orcamentos.Add(orcamento)
        Next

        Return orcamentos

    End Function

    'OK
    Public Function FindByVendedor(vendedor As Funcionario) As List(Of Orcamento)

        If (vendedor Is Nothing) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@vendedor", vendedor.Matricula)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM Orcamentos WHERE matriculaVendedor = @vendedor;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return New List(Of Orcamento)

        Dim orcamentos As New List(Of Orcamento)

        For Each row As DataRow In dt.Rows
            Dim orcamento As New Orcamento()
            orcamento.ID = CLng(row.Item("id"))
            orcamento.DataOrcamento = CDate(row.Item("dataOrcamento"))
            orcamento.Vendedor = vendedor
            orcamento.Cliente = ClienteBC.FindByID(CLng(row.Item("idCliente")))
            orcamento.Status = CStr(row.Item("statusOrcamento"))
            orcamentos.Add(orcamento)
        Next

        Return orcamentos

    End Function

    'OK
    Public Function FindByID(id As Long) As Orcamento

        If (id = 0) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@id", id)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM Orcamentos WHERE id = @id;")

        If (dt Is Nothing OrElse dt.Rows.Count = 0) Then Return Nothing

        Dim orcamento As New Orcamento()
        orcamento.Id = CLng(dt.Rows(0).Item("id"))
        orcamento.DataOrcamento = CDate(dt.Rows(0).Item("dataOrcamento"))
        orcamento.Vendedor = FuncionarioBC.FindByMatricula(CLng(dt.Rows(0).Item("matriculaVendedor")))
        orcamento.Cliente = ClienteBC.FindByID(CLng(dt.Rows(0).Item("idCliente")))
        orcamento.Status = CStr(dt.Rows(0).Item("statusOrcamento"))

        Return orcamento

    End Function

End Class
