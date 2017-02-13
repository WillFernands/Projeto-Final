Public NotInheritable Class TipoCargo
    Public Const GerenteAdm As String = "Gerente Administrativo"
    Public Const GerenteCont As String = "Gerente Contabil"
    Public Const GerenteAlmox As String = "Gerente de Almoxerifado"
    Public Const AssistenteAdm As String = "Assistente Administrativo"
    Public Const AssistenteCont As String = "Assistente Contabil"
    Public Const Vendedor As String = "Vendedor"
    Public Const Tecnico As String = "Tecnico"
    Public Const SupervisorObra As String = "Supervisor da Obra"

    Public Shared Function GetTiposList() As List(Of String)
        Dim list As New List(Of String)
        list.Add(GerenteAdm)
        list.Add(GerenteAlmox)
        list.Add(GerenteCont)
        list.Add(AssistenteAdm)
        list.Add(AssistenteCont)
        list.Add(Vendedor)
        list.Add(Tecnico)
        list.Add(SupervisorObra)
        Return list
    End Function

End Class
