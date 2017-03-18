<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerItensOrdem
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
        Me.Quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusGB = New System.Windows.Forms.GroupBox()
        Me.AtualizarProdutoIMG = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataRecebimentoTF = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataEntregaTF = New System.Windows.Forms.TextBox()
        Me.DataEmissaoNFCotacaoLB = New System.Windows.Forms.Label()
        Me.DataDevolucaoTF = New System.Windows.Forms.TextBox()
        Me.SalvarItensBT = New System.Windows.Forms.Button()
        CType(Me.ProdutosDT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusGB.SuspendLayout()
        CType(Me.AtualizarProdutoIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProdutosDT
        '
        Me.ProdutosDT.AllowUserToAddRows = False
        Me.ProdutosDT.AllowUserToDeleteRows = False
        Me.ProdutosDT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProdutosDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProdutosDT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.DataGridViewTextBoxColumn1, Me.Descricao, Me.Quantidade, Me.Column1, Me.Column2, Me.Column3})
        Me.ProdutosDT.Location = New System.Drawing.Point(5, 85)
        Me.ProdutosDT.Name = "ProdutosDT"
        Me.ProdutosDT.ReadOnly = True
        Me.ProdutosDT.RowHeadersVisible = False
        Me.ProdutosDT.Size = New System.Drawing.Size(768, 263)
        Me.ProdutosDT.TabIndex = 12
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
        'Quantidade
        '
        Me.Quantidade.HeaderText = "Qtde"
        Me.Quantidade.Name = "Quantidade"
        Me.Quantidade.ReadOnly = True
        Me.Quantidade.Width = 50
        '
        'Column1
        '
        Me.Column1.HeaderText = "Data Entrega"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Data Recebimento"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Data Devolução"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'StatusGB
        '
        Me.StatusGB.Controls.Add(Me.AtualizarProdutoIMG)
        Me.StatusGB.Controls.Add(Me.Label2)
        Me.StatusGB.Controls.Add(Me.DataRecebimentoTF)
        Me.StatusGB.Controls.Add(Me.Label1)
        Me.StatusGB.Controls.Add(Me.DataEntregaTF)
        Me.StatusGB.Controls.Add(Me.DataEmissaoNFCotacaoLB)
        Me.StatusGB.Controls.Add(Me.DataDevolucaoTF)
        Me.StatusGB.Location = New System.Drawing.Point(71, 12)
        Me.StatusGB.Name = "StatusGB"
        Me.StatusGB.Size = New System.Drawing.Size(635, 67)
        Me.StatusGB.TabIndex = 31
        Me.StatusGB.TabStop = False
        '
        'AtualizarProdutoIMG
        '
        Me.AtualizarProdutoIMG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AtualizarProdutoIMG.Image = Global.NobelTheater.My.Resources.Resources.Confirmar
        Me.AtualizarProdutoIMG.Location = New System.Drawing.Point(590, 26)
        Me.AtualizarProdutoIMG.Name = "AtualizarProdutoIMG"
        Me.AtualizarProdutoIMG.Size = New System.Drawing.Size(27, 20)
        Me.AtualizarProdutoIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AtualizarProdutoIMG.TabIndex = 14
        Me.AtualizarProdutoIMG.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(277, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Data de Recebimento da Assistência:"
        '
        'DataRecebimentoTF
        '
        Me.DataRecebimentoTF.Location = New System.Drawing.Point(468, 26)
        Me.DataRecebimentoTF.Name = "DataRecebimentoTF"
        Me.DataRecebimentoTF.Size = New System.Drawing.Size(100, 20)
        Me.DataRecebimentoTF.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Data Entrega à Assistência:"
        '
        'DataEntregaTF
        '
        Me.DataEntregaTF.Location = New System.Drawing.Point(166, 13)
        Me.DataEntregaTF.Name = "DataEntregaTF"
        Me.DataEntregaTF.Size = New System.Drawing.Size(100, 20)
        Me.DataEntregaTF.TabIndex = 4
        '
        'DataEmissaoNFCotacaoLB
        '
        Me.DataEmissaoNFCotacaoLB.AutoSize = True
        Me.DataEmissaoNFCotacaoLB.Location = New System.Drawing.Point(7, 41)
        Me.DataEmissaoNFCotacaoLB.Name = "DataEmissaoNFCotacaoLB"
        Me.DataEmissaoNFCotacaoLB.Size = New System.Drawing.Size(153, 13)
        Me.DataEmissaoNFCotacaoLB.TabIndex = 3
        Me.DataEmissaoNFCotacaoLB.Text = "Data de Devolução ao Cliente:"
        '
        'DataDevolucaoTF
        '
        Me.DataDevolucaoTF.Location = New System.Drawing.Point(166, 38)
        Me.DataDevolucaoTF.Name = "DataDevolucaoTF"
        Me.DataDevolucaoTF.Size = New System.Drawing.Size(100, 20)
        Me.DataDevolucaoTF.TabIndex = 1
        '
        'SalvarItensBT
        '
        Me.SalvarItensBT.Location = New System.Drawing.Point(332, 360)
        Me.SalvarItensBT.Name = "SalvarItensBT"
        Me.SalvarItensBT.Size = New System.Drawing.Size(112, 23)
        Me.SalvarItensBT.TabIndex = 32
        Me.SalvarItensBT.Text = "Salvar Alterações"
        Me.SalvarItensBT.UseVisualStyleBackColor = True
        '
        'VerItensOrdem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 391)
        Me.Controls.Add(Me.SalvarItensBT)
        Me.Controls.Add(Me.StatusGB)
        Me.Controls.Add(Me.ProdutosDT)
        Me.Name = "VerItensOrdem"
        Me.Text = "VerItensOrdem"
        CType(Me.ProdutosDT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusGB.ResumeLayout(False)
        Me.StatusGB.PerformLayout()
        CType(Me.AtualizarProdutoIMG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProdutosDT As DataGridView
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Descricao As DataGridViewTextBoxColumn
    Friend WithEvents Quantidade As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents StatusGB As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataRecebimentoTF As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataEntregaTF As TextBox
    Friend WithEvents DataEmissaoNFCotacaoLB As Label
    Friend WithEvents DataDevolucaoTF As TextBox
    Friend WithEvents AtualizarProdutoIMG As PictureBox
    Friend WithEvents SalvarItensBT As Button
End Class
