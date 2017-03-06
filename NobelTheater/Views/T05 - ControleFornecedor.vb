Public Class ControleFornecedor

    
    Private Sub EnderecosDT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EnderecosDT.CellContentClick

    End Sub

    Private Sub ControleFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim list As New List(Of Object)
        list.Add("Rua da pátria") : list.Add("320") : list.Add("Agua Verde") : list.Add("Curitiba") : list.Add("PR") : list.Add("81-290-800") : list.Add("Escritório") : list.Add("Remover")
        EnderecosDT.Rows.Add(list.ToArray()) : list.Clear()
        list.Add("Avenida das bandeiras") : list.Add("2150") : list.Add("Cabral") : list.Add("Curitiba") : list.Add("PR") : list.Add("80-400-240") : list.Add("Escritório") : list.Add("Remover")
        EnderecosDT.Rows.Add(list.ToArray()) : list.Clear()
        End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
End Class