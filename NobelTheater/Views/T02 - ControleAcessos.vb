Public Class ControleAcessos

    Private Sub ControleAcessos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim list As New List(Of Object)
        list.Add("02500") : list.Add("Bruno das Neves") : list.Add("15/04/2016") : list.Add("Resetar senha")
        RevogadosDT.Rows.Add(list.ToArray()) : list.Clear()
        list.Add("02515") : list.Add("Alisson Jr.") : list.Add("22/05/2016") : list.Add("Resetar senha")
        RevogadosDT.Rows.Add(list.ToArray()) : list.Clear()
        list.Add("02543") : list.Add("Bruna Oliveira") : list.Add("01/07/2016") : list.Add("Resetar senha")
        RevogadosDT.Rows.Add(list.ToArray()) : list.Clear()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class