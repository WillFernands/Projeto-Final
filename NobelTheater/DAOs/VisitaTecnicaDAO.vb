Option Explicit On
Option Strict On

Imports System.Text

Public Class VisitaTecnicaDAO

    'OK
    Public Function Insert(ByVal visita As VisitaTecnica) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO VisitasTecnicas(idNotaFiscal, dataVisita, tipo, preco, parecerObra, matriculaSupervisor) ")
        strSQL.Append("VALUES(@idNotaFiscal, @data, @tipo, @preco, @parecerObra, @matriculaSupervisor);")

        conn.AddParameter("@idNotaFiscal", visita.NotaFiscal.ID)
        conn.AddParameter("@data", visita.Data)
        conn.AddParameter("@tipo", visita.Tipo)
        conn.AddParameter("@preco", visita.Preco)
        conn.AddParameter("@parecerObra", visita.ParecerObra)
        conn.AddParameter("@matriculaSupervisor", visita.MatriculaSupervisor)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function UpdateParecer(ByVal visita As VisitaTecnica) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE VisitasTecnicas ")
        strSQL.Append("SET parecerObra = @parecerObra ")
        strSQL.Append("WHERE idNotaFiscal = @idNotaFiscal ")
        strSQL.Append("AND dataVisita = @data ")
        strSQL.Append("AND tipo = @tipo ")
        strSQL.Append("AND matriculaSupervisor = @matriculaSupervisor;")

        conn.AddParameter("@idNotaFiscal", visita.NotaFiscal.ID)
        conn.AddParameter("@data", visita.Data)
        conn.AddParameter("@tipo", visita.Tipo)
        conn.AddParameter("@parecerObra", visita.ParecerObra)
        conn.AddParameter("@matriculaSupervisor", visita.MatriculaSupervisor)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    'OK
    Public Function FindByNotaFiscal(nota As NotaFiscalVenda) As List(Of VisitaTecnica)
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM VisitasTecnicas ")
        strSQL.Append("WHERE idNotaFiscal = @idNotaFiscal;")

        conn.AddParameter("@idNotaFiscal", nota.ID)

        Dim dt As DataTable = conn.ExecuteSelect(strSQL.ToString)

        Dim visitas As New List(Of VisitaTecnica)

        For Each row As DataRow In dt.Rows
            Dim visita As New VisitaTecnica()
            visita.Data = CDate(row.Item("dataVisita"))
            visita.Tipo = CStr(row.Item("tipo"))
            visita.Preco = CDbl(row.Item("preco"))
            visita.ParecerObra = CStr(row.Item("parecerObra"))
            visita.MatriculaSupervisor = CStr(row.Item("matriculaSupervisor"))
            visita.NotaFiscal = nota
            visitas.Add(visita)
        Next

        Return visita

    End Function

End Class
