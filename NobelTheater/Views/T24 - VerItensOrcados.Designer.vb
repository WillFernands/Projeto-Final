<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerItensOrcados
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ProdutosDT = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ProdutosDT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProdutosDT
        '
        Me.ProdutosDT.AllowUserToAddRows = False
        Me.ProdutosDT.AllowUserToDeleteRows = False
        Me.ProdutosDT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProdutosDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProdutosDT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.DataGridViewTextBoxColumn1, Me.Descricao, Me.DataGridViewTextBoxColumn3, Me.Quantidade, Me.PrecoTotal})
        Me.ProdutosDT.Location = New System.Drawing.Point(5, 1)
        Me.ProdutosDT.Name = "ProdutosDT"
        Me.ProdutosDT.ReadOnly = True
        Me.ProdutosDT.RowHeadersVisible = False
        Me.ProdutosDT.Size = New System.Drawing.Size(661, 318)
        Me.ProdutosDT.TabIndex = 10
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 50
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 250
        '
        'Descricao
        '
        Me.Descricao.HeaderText = "Descricao"
        Me.Descricao.Name = "Descricao"
        Me.Descricao.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Preço Unit"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 90
        '
        'Quantidade
        '
        Me.Quantidade.HeaderText = "Qtde"
        Me.Quantidade.Name = "Quantidade"
        Me.Quantidade.ReadOnly = True
        Me.Quantidade.Width = 50
        '
        'PrecoTotal
        '
        Me.PrecoTotal.HeaderText = "Preço Total"
        Me.PrecoTotal.Name = "PrecoTotal"
        Me.PrecoTotal.ReadOnly = True
        '
        'VerItensOrcados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 321)
        Me.Controls.Add(Me.ProdutosDT)
        Me.Name = "VerItensOrcados"
        Me.Text = "VerItensOrcados"
        CType(Me.ProdutosDT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProdutosDT As DataGridView
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Descricao As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Quantidade As DataGridViewTextBoxColumn
    Friend WithEvents PrecoTotal As DataGridViewTextBoxColumn
End Class
