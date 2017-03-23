<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonitorarAmbiente
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
        Me.VideoIMG = New System.Windows.Forms.PictureBox()
        Me.IniciarStreamingBT = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcoesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcessosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerenciarAcessosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcessosRevogadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovaCotaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlertasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasEmAndamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosEmprestadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosNaAssistênciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosDeComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoFornecedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcompanharFornecedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovaAssistênciaTécnicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcompanharAssistênciaTécnicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoOrçamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasEmAndamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosDeVendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BalançoDeCaixaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosDeReceitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosDeDespesasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosDeBalançoDeCaixaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonitoramentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonitorarAmbienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoFuncionárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcompanharFuncionárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcompanharClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalvarImagemBT = New System.Windows.Forms.Button()
        Me.PerfilTF = New System.Windows.Forms.Label()
        Me.MatriculaTF = New System.Windows.Forms.Label()
        Me.NomeTF = New System.Windows.Forms.Label()
        Me.PararStreamingBT = New System.Windows.Forms.Button()
        CType(Me.VideoIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'VideoIMG
        '
        Me.VideoIMG.Image = Global.NobelTheater.My.Resources.Resources.camblue
        Me.VideoIMG.Location = New System.Drawing.Point(4, 3)
        Me.VideoIMG.Name = "VideoIMG"
        Me.VideoIMG.Size = New System.Drawing.Size(698, 327)
        Me.VideoIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.VideoIMG.TabIndex = 0
        Me.VideoIMG.TabStop = False
        '
        'IniciarStreamingBT
        '
        Me.IniciarStreamingBT.Location = New System.Drawing.Point(166, 340)
        Me.IniciarStreamingBT.Name = "IniciarStreamingBT"
        Me.IniciarStreamingBT.Size = New System.Drawing.Size(99, 23)
        Me.IniciarStreamingBT.TabIndex = 1
        Me.IniciarStreamingBT.Text = "Iniciar Streaming"
        Me.IniciarStreamingBT.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PerfilTF)
        Me.Panel1.Controls.Add(Me.MatriculaTF)
        Me.Panel1.Controls.Add(Me.NomeTF)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(705, 100)
        Me.Panel1.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NobelTheater.My.Resources.Resources.MonitoramentoDeAmbienteMain
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PararStreamingBT)
        Me.Panel2.Controls.Add(Me.SalvarImagemBT)
        Me.Panel2.Controls.Add(Me.VideoIMG)
        Me.Panel2.Controls.Add(Me.IniciarStreamingBT)
        Me.Panel2.Location = New System.Drawing.Point(12, 131)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(705, 374)
        Me.Panel2.TabIndex = 10
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcoesToolStripMenuItem, Me.AcessosToolStripMenuItem, Me.EstoqueToolStripMenuItem, Me.FornecedoresToolStripMenuItem, Me.VendasToolStripMenuItem, Me.BalançoDeCaixaToolStripMenuItem, Me.MonitoramentoToolStripMenuItem, Me.FuncionáriosToolStripMenuItem, Me.ClientesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(729, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcoesToolStripMenuItem
        '
        Me.OpcoesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem, Me.SobreToolStripMenuItem, Me.SairToolStripMenuItem1})
        Me.OpcoesToolStripMenuItem.Name = "OpcoesToolStripMenuItem"
        Me.OpcoesToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.OpcoesToolStripMenuItem.Text = "Opções"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.SairToolStripMenuItem.Text = "Ajuda"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        '
        'SairToolStripMenuItem1
        '
        Me.SairToolStripMenuItem1.Name = "SairToolStripMenuItem1"
        Me.SairToolStripMenuItem1.Size = New System.Drawing.Size(104, 22)
        Me.SairToolStripMenuItem1.Text = "Sair"
        '
        'AcessosToolStripMenuItem
        '
        Me.AcessosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GerenciarAcessosToolStripMenuItem, Me.AcessosRevogadosToolStripMenuItem})
        Me.AcessosToolStripMenuItem.Name = "AcessosToolStripMenuItem"
        Me.AcessosToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.AcessosToolStripMenuItem.Text = "Acessos"
        '
        'GerenciarAcessosToolStripMenuItem
        '
        Me.GerenciarAcessosToolStripMenuItem.Name = "GerenciarAcessosToolStripMenuItem"
        Me.GerenciarAcessosToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.GerenciarAcessosToolStripMenuItem.Text = "Gerenciar Acessos"
        '
        'AcessosRevogadosToolStripMenuItem
        '
        Me.AcessosRevogadosToolStripMenuItem.Name = "AcessosRevogadosToolStripMenuItem"
        Me.AcessosRevogadosToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.AcessosRevogadosToolStripMenuItem.Text = "Acessos Revogados"
        '
        'EstoqueToolStripMenuItem
        '
        Me.EstoqueToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovaCotaçãoToolStripMenuItem, Me.AlertasToolStripMenuItem, Me.ComprasEmAndamentoToolStripMenuItem, Me.ProdutosEmprestadosToolStripMenuItem, Me.ProdutosNaAssistênciaToolStripMenuItem, Me.RelatóriosDeComprasToolStripMenuItem})
        Me.EstoqueToolStripMenuItem.Name = "EstoqueToolStripMenuItem"
        Me.EstoqueToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.EstoqueToolStripMenuItem.Text = "Estoque"
        '
        'NovaCotaçãoToolStripMenuItem
        '
        Me.NovaCotaçãoToolStripMenuItem.Name = "NovaCotaçãoToolStripMenuItem"
        Me.NovaCotaçãoToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.NovaCotaçãoToolStripMenuItem.Text = "Nova Cotação"
        '
        'AlertasToolStripMenuItem
        '
        Me.AlertasToolStripMenuItem.Name = "AlertasToolStripMenuItem"
        Me.AlertasToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.AlertasToolStripMenuItem.Text = "Alertas"
        '
        'ComprasEmAndamentoToolStripMenuItem
        '
        Me.ComprasEmAndamentoToolStripMenuItem.Name = "ComprasEmAndamentoToolStripMenuItem"
        Me.ComprasEmAndamentoToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ComprasEmAndamentoToolStripMenuItem.Text = "Compras em Andamento"
        '
        'ProdutosEmprestadosToolStripMenuItem
        '
        Me.ProdutosEmprestadosToolStripMenuItem.Name = "ProdutosEmprestadosToolStripMenuItem"
        Me.ProdutosEmprestadosToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ProdutosEmprestadosToolStripMenuItem.Text = "Produtos Emprestados"
        '
        'ProdutosNaAssistênciaToolStripMenuItem
        '
        Me.ProdutosNaAssistênciaToolStripMenuItem.Name = "ProdutosNaAssistênciaToolStripMenuItem"
        Me.ProdutosNaAssistênciaToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ProdutosNaAssistênciaToolStripMenuItem.Text = "Produtos na Assistência"
        '
        'RelatóriosDeComprasToolStripMenuItem
        '
        Me.RelatóriosDeComprasToolStripMenuItem.Name = "RelatóriosDeComprasToolStripMenuItem"
        Me.RelatóriosDeComprasToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.RelatóriosDeComprasToolStripMenuItem.Text = "Relatórios de Compras"
        '
        'FornecedoresToolStripMenuItem
        '
        Me.FornecedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoFornecedorToolStripMenuItem, Me.AcompanharFornecedorToolStripMenuItem, Me.NovaAssistênciaTécnicaToolStripMenuItem, Me.AcompanharAssistênciaTécnicaToolStripMenuItem})
        Me.FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem"
        Me.FornecedoresToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.FornecedoresToolStripMenuItem.Text = "Fornecedores"
        '
        'NovoFornecedorToolStripMenuItem
        '
        Me.NovoFornecedorToolStripMenuItem.Name = "NovoFornecedorToolStripMenuItem"
        Me.NovoFornecedorToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.NovoFornecedorToolStripMenuItem.Text = "Novo Fornecedor"
        '
        'AcompanharFornecedorToolStripMenuItem
        '
        Me.AcompanharFornecedorToolStripMenuItem.Name = "AcompanharFornecedorToolStripMenuItem"
        Me.AcompanharFornecedorToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.AcompanharFornecedorToolStripMenuItem.Text = "Acompanhar Fornecedor"
        '
        'NovaAssistênciaTécnicaToolStripMenuItem
        '
        Me.NovaAssistênciaTécnicaToolStripMenuItem.Name = "NovaAssistênciaTécnicaToolStripMenuItem"
        Me.NovaAssistênciaTécnicaToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.NovaAssistênciaTécnicaToolStripMenuItem.Text = "Nova Assistência Técnica"
        '
        'AcompanharAssistênciaTécnicaToolStripMenuItem
        '
        Me.AcompanharAssistênciaTécnicaToolStripMenuItem.Name = "AcompanharAssistênciaTécnicaToolStripMenuItem"
        Me.AcompanharAssistênciaTécnicaToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.AcompanharAssistênciaTécnicaToolStripMenuItem.Text = "Acompanhar Assistência Técnica"
        '
        'VendasToolStripMenuItem
        '
        Me.VendasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoOrçamentoToolStripMenuItem, Me.VendasEmAndamentoToolStripMenuItem, Me.RelatóriosDeVendasToolStripMenuItem})
        Me.VendasToolStripMenuItem.Name = "VendasToolStripMenuItem"
        Me.VendasToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.VendasToolStripMenuItem.Text = "Vendas"
        '
        'NovoOrçamentoToolStripMenuItem
        '
        Me.NovoOrçamentoToolStripMenuItem.Name = "NovoOrçamentoToolStripMenuItem"
        Me.NovoOrçamentoToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.NovoOrçamentoToolStripMenuItem.Text = "Novo Orçamento"
        '
        'VendasEmAndamentoToolStripMenuItem
        '
        Me.VendasEmAndamentoToolStripMenuItem.Name = "VendasEmAndamentoToolStripMenuItem"
        Me.VendasEmAndamentoToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.VendasEmAndamentoToolStripMenuItem.Text = "Vendas em Andamento"
        '
        'RelatóriosDeVendasToolStripMenuItem
        '
        Me.RelatóriosDeVendasToolStripMenuItem.Name = "RelatóriosDeVendasToolStripMenuItem"
        Me.RelatóriosDeVendasToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.RelatóriosDeVendasToolStripMenuItem.Text = "Relatórios de Vendas"
        '
        'BalançoDeCaixaToolStripMenuItem
        '
        Me.BalançoDeCaixaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RelatóriosDeReceitaToolStripMenuItem, Me.RelatóriosDeDespesasToolStripMenuItem, Me.RelatóriosDeBalançoDeCaixaToolStripMenuItem})
        Me.BalançoDeCaixaToolStripMenuItem.Name = "BalançoDeCaixaToolStripMenuItem"
        Me.BalançoDeCaixaToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.BalançoDeCaixaToolStripMenuItem.Text = "Balanço de Caixa"
        '
        'RelatóriosDeReceitaToolStripMenuItem
        '
        Me.RelatóriosDeReceitaToolStripMenuItem.Name = "RelatóriosDeReceitaToolStripMenuItem"
        Me.RelatóriosDeReceitaToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.RelatóriosDeReceitaToolStripMenuItem.Text = "Relatórios de Receita"
        '
        'RelatóriosDeDespesasToolStripMenuItem
        '
        Me.RelatóriosDeDespesasToolStripMenuItem.Name = "RelatóriosDeDespesasToolStripMenuItem"
        Me.RelatóriosDeDespesasToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.RelatóriosDeDespesasToolStripMenuItem.Text = "Relatórios de Despesas"
        '
        'RelatóriosDeBalançoDeCaixaToolStripMenuItem
        '
        Me.RelatóriosDeBalançoDeCaixaToolStripMenuItem.Name = "RelatóriosDeBalançoDeCaixaToolStripMenuItem"
        Me.RelatóriosDeBalançoDeCaixaToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.RelatóriosDeBalançoDeCaixaToolStripMenuItem.Text = "Relatórios de Balanço de Caixa"
        '
        'MonitoramentoToolStripMenuItem
        '
        Me.MonitoramentoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MonitorarAmbienteToolStripMenuItem})
        Me.MonitoramentoToolStripMenuItem.Name = "MonitoramentoToolStripMenuItem"
        Me.MonitoramentoToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.MonitoramentoToolStripMenuItem.Text = "Monitoramento"
        '
        'MonitorarAmbienteToolStripMenuItem
        '
        Me.MonitorarAmbienteToolStripMenuItem.Name = "MonitorarAmbienteToolStripMenuItem"
        Me.MonitorarAmbienteToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.MonitorarAmbienteToolStripMenuItem.Text = "Monitorar Ambiente"
        '
        'FuncionáriosToolStripMenuItem
        '
        Me.FuncionáriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoFuncionárioToolStripMenuItem, Me.AcompanharFuncionárioToolStripMenuItem})
        Me.FuncionáriosToolStripMenuItem.Name = "FuncionáriosToolStripMenuItem"
        Me.FuncionáriosToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.FuncionáriosToolStripMenuItem.Text = "Funcionários"
        '
        'NovoFuncionárioToolStripMenuItem
        '
        Me.NovoFuncionárioToolStripMenuItem.Name = "NovoFuncionárioToolStripMenuItem"
        Me.NovoFuncionárioToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.NovoFuncionárioToolStripMenuItem.Text = "Novo Funcionário"
        '
        'AcompanharFuncionárioToolStripMenuItem
        '
        Me.AcompanharFuncionárioToolStripMenuItem.Name = "AcompanharFuncionárioToolStripMenuItem"
        Me.AcompanharFuncionárioToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.AcompanharFuncionárioToolStripMenuItem.Text = "Acompanhar Funcionário"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoClienteToolStripMenuItem, Me.AcompanharClienteToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'NovoClienteToolStripMenuItem
        '
        Me.NovoClienteToolStripMenuItem.Name = "NovoClienteToolStripMenuItem"
        Me.NovoClienteToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.NovoClienteToolStripMenuItem.Text = "Novo Cliente"
        '
        'AcompanharClienteToolStripMenuItem
        '
        Me.AcompanharClienteToolStripMenuItem.Name = "AcompanharClienteToolStripMenuItem"
        Me.AcompanharClienteToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AcompanharClienteToolStripMenuItem.Text = "Acompanhar Cliente"
        '
        'SalvarImagemBT
        '
        Me.SalvarImagemBT.Location = New System.Drawing.Point(440, 340)
        Me.SalvarImagemBT.Name = "SalvarImagemBT"
        Me.SalvarImagemBT.Size = New System.Drawing.Size(99, 23)
        Me.SalvarImagemBT.TabIndex = 2
        Me.SalvarImagemBT.Text = "Salvar Imagem"
        Me.SalvarImagemBT.UseVisualStyleBackColor = True
        '
        'PerfilTF
        '
        Me.PerfilTF.AutoSize = True
        Me.PerfilTF.Location = New System.Drawing.Point(140, 72)
        Me.PerfilTF.Name = "PerfilTF"
        Me.PerfilTF.Size = New System.Drawing.Size(86, 13)
        Me.PerfilTF.TabIndex = 15
        Me.PerfilTF.Text = "Perfil de Acesso:"
        '
        'MatriculaTF
        '
        Me.MatriculaTF.AutoSize = True
        Me.MatriculaTF.Location = New System.Drawing.Point(140, 44)
        Me.MatriculaTF.Name = "MatriculaTF"
        Me.MatriculaTF.Size = New System.Drawing.Size(55, 13)
        Me.MatriculaTF.TabIndex = 14
        Me.MatriculaTF.Text = "Matrícula:"
        '
        'NomeTF
        '
        Me.NomeTF.AutoSize = True
        Me.NomeTF.Location = New System.Drawing.Point(140, 16)
        Me.NomeTF.Name = "NomeTF"
        Me.NomeTF.Size = New System.Drawing.Size(38, 13)
        Me.NomeTF.TabIndex = 13
        Me.NomeTF.Text = "Nome:"
        '
        'PararStreamingBT
        '
        Me.PararStreamingBT.Location = New System.Drawing.Point(303, 340)
        Me.PararStreamingBT.Name = "PararStreamingBT"
        Me.PararStreamingBT.Size = New System.Drawing.Size(99, 23)
        Me.PararStreamingBT.TabIndex = 3
        Me.PararStreamingBT.Text = "Parar Streaming"
        Me.PararStreamingBT.UseVisualStyleBackColor = True
        '
        'MonitorarAmbiente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 519)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MonitorarAmbiente"
        Me.Text = "Monitorar Ambiente"
        CType(Me.VideoIMG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VideoIMG As System.Windows.Forms.PictureBox
    Friend WithEvents IniciarStreamingBT As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcoesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcessosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GerenciarAcessosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcessosRevogadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstoqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovaCotaçãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlertasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasEmAndamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdutosEmprestadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdutosNaAssistênciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelatóriosDeComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovoFornecedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcompanharFornecedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovaAssistênciaTécnicaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcompanharAssistênciaTécnicaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovoOrçamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendasEmAndamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelatóriosDeVendasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BalançoDeCaixaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelatóriosDeReceitaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelatóriosDeDespesasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelatóriosDeBalançoDeCaixaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonitoramentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonitorarAmbienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuncionáriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovoFuncionárioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcompanharFuncionárioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovoClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcompanharClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalvarImagemBT As Button
    Friend WithEvents PerfilTF As Label
    Friend WithEvents MatriculaTF As Label
    Friend WithEvents NomeTF As Label
    Friend WithEvents PararStreamingBT As Button
End Class
