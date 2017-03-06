Option Explicit On
Option Strict On

Public NotInheritable Class EstadosEnum

    Public Shared Function GetEstadosList() As List(Of String)
        Dim list As New List(Of String)
        list.Add("AC") : list.Add("AL") : list.Add("AM") : list.Add("AP") : list.Add("BA") : list.Add("CE") : list.Add("DF")
        list.Add("ES") : list.Add("GO") : list.Add("MA") : list.Add("MG") : list.Add("MS") : list.Add("MT") : list.Add("PA")
        list.Add("PB") : list.Add("PE") : list.Add("PI") : list.Add("PR") : list.Add("RJ") : list.Add("RN") : list.Add("RO")
        list.Add("RR") : list.Add("RS") : list.Add("SC") : list.Add("SE") : list.Add("SP") : list.Add("TO")
        list.Sort()
        Return list
    End Function

End Class
