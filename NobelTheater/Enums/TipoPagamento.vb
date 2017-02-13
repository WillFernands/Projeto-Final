Option Explicit On
Option Strict On

Public NotInheritable Class TipoPagamento
    Public Const Parcelado As String = "Parcelado"
    Public Const AVistaDeposito As String = "A Vista (Deposito)"
    Public Const AVistaCredito As String = "A Vista (Credito)"
    Public Const AVistaDebito As String = "A Vista (Debito)"
    Public Const Outros As String = "Outros"

    Public Shared Function GetTiposList() As List(Of String)
        Dim list As New List(Of String)
        list.Add(Parcelado)
        list.Add(AVistaCredito)
        list.Add(AVistaDebito)
        list.Add(AVistaDeposito)
        list.Add(Outros)
        Return list
    End Function

End Class
