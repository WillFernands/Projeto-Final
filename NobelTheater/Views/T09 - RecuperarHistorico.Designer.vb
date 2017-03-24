<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecuperarHistorico
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PerfilTF = New System.Windows.Forms.Label()
        Me.MatriculaTF = New System.Windows.Forms.Label()
        Me.NomeTF = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RecuperarHistoricoTabControl = New System.Windows.Forms.TabControl()
        Me.RecuperarHistoricoTP = New System.Windows.Forms.TabPage()
        Me.FimDT = New System.Windows.Forms.DateTimePicker()
        Me.InicioDT = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RecuperarHistoricoFuncionariosTP = New System.Windows.Forms.TabPage()
        Me.FuncionariosDT = New System.Windows.Forms.DataGridView()
        Me.Matricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Funcionario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResetarSenha = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TodosFuncCB = New System.Windows.Forms.CheckBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.FuncionarioTF = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FimFuncDT = New System.Windows.Forms.DateTimePicker()
        Me.InicioFuncDT = New System.Windows.Forms.DateTimePicker()
        Me.GerarRelatorioBT = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.RecuperarHistoricoTabControl.SuspendLayout()
        Me.RecuperarHistoricoTP.SuspendLayout()
        Me.RecuperarHistoricoFuncionariosTP.SuspendLayout()
        CType(Me.FuncionariosDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcoesToolStripMenuItem, Me.AcessosToolStripMenuItem, Me.EstoqueToolStripMenuItem, Me.FornecedoresToolStripMenuItem, Me.VendasToolStripMenuItem, Me.BalançoDeCaixaToolStripMenuItem, Me.MonitoramentoToolStripMenuItem, Me.FuncionáriosToolStripMenuItem, Me.ClientesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(729, 24)
        Me.MenuStrip1.TabIndex = 8
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PerfilTF)
        Me.Panel1.Controls.Add(Me.MatriculaTF)
        Me.Panel1.Controls.Add(Me.NomeTF)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(705, 100)
        Me.Panel1.TabIndex = 6
        '
        'PerfilTF
        '
        Me.PerfilTF.AutoSize = True
        Me.PerfilTF.Location = New System.Drawing.Point(133, 71)
        Me.PerfilTF.Name = "PerfilTF"
        Me.PerfilTF.Size = New System.Drawing.Size(86, 13)
        Me.PerfilTF.TabIndex = 6
        Me.PerfilTF.Text = "Perfil de Acesso:"
        '
        'MatriculaTF
        '
        Me.MatriculaTF.AutoSize = True
        Me.MatriculaTF.Location = New System.Drawing.Point(133, 43)
        Me.MatriculaTF.Name = "MatriculaTF"
        Me.MatriculaTF.Size = New System.Drawing.Size(55, 13)
        Me.MatriculaTF.TabIndex = 5
        Me.MatriculaTF.Text = "Matrícula:"
        '
        'NomeTF
        '
        Me.NomeTF.AutoSize = True
        Me.NomeTF.Location = New System.Drawing.Point(133, 15)
        Me.NomeTF.Name = "NomeTF"
        Me.NomeTF.Size = New System.Drawing.Size(38, 13)
        Me.NomeTF.TabIndex = 4
        Me.NomeTF.Text = "Nome:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NobelTheater.My.Resources.Resources.HistoricoDePontoMain
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RecuperarHistoricoTabControl)
        Me.Panel2.Location = New System.Drawing.Point(12, 138)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(705, 374)
        Me.Panel2.TabIndex = 7
        '
        'RecuperarHistoricoTabControl
        '
        Me.RecuperarHistoricoTabControl.Controls.Add(Me.RecuperarHistoricoTP)
        Me.RecuperarHistoricoTabControl.Controls.Add(Me.RecuperarHistoricoFuncionariosTP)
        Me.RecuperarHistoricoTabControl.Location = New System.Drawing.Point(9, 10)
        Me.RecuperarHistoricoTabControl.Name = "RecuperarHistoricoTabControl"
        Me.RecuperarHistoricoTabControl.SelectedIndex = 0
        Me.RecuperarHistoricoTabControl.Size = New System.Drawing.Size(693, 361)
        Me.RecuperarHistoricoTabControl.TabIndex = 0
        '
        'RecuperarHistoricoTP
        '
        Me.RecuperarHistoricoTP.Controls.Add(Me.FimDT)
        Me.RecuperarHistoricoTP.Controls.Add(Me.InicioDT)
        Me.RecuperarHistoricoTP.Controls.Add(Me.Label8)
        Me.RecuperarHistoricoTP.Controls.Add(Me.Label9)
        Me.RecuperarHistoricoTP.Controls.Add(Me.Button2)
        Me.RecuperarHistoricoTP.Location = New System.Drawing.Point(4, 22)
        Me.RecuperarHistoricoTP.Name = "RecuperarHistoricoTP"
        Me.RecuperarHistoricoTP.Padding = New System.Windows.Forms.Padding(3)
        Me.RecuperarHistoricoTP.Size = New System.Drawing.Size(685, 335)
        Me.RecuperarHistoricoTP.TabIndex = 0
        Me.RecuperarHistoricoTP.Text = "Recuperar Histórico"
        Me.RecuperarHistoricoTP.UseVisualStyleBackColor = True
        '
        'FimDT
        '
        Me.FimDT.CustomFormat = "dd/MM/yyyy"
        Me.FimDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FimDT.Location = New System.Drawing.Point(179, 17)
        Me.FimDT.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.FimDT.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.FimDT.Name = "FimDT"
        Me.FimDT.Size = New System.Drawing.Size(98, 20)
        Me.FimDT.TabIndex = 29
        '
        'InicioDT
        '
        Me.InicioDT.CustomFormat = "dd/MM/yyyy"
        Me.InicioDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.InicioDT.Location = New System.Drawing.Point(43, 17)
        Me.InicioDT.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.InicioDT.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.InicioDT.Name = "InicioDT"
        Me.InicioDT.Size = New System.Drawing.Size(98, 20)
        Me.InicioDT.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "De:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(147, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Até:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(305, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Gerar Relatório"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RecuperarHistoricoFuncionariosTP
        '
        Me.RecuperarHistoricoFuncionariosTP.Controls.Add(Me.FuncionariosDT)
        Me.RecuperarHistoricoFuncionariosTP.Controls.Add(Me.TodosFuncCB)
        Me.RecuperarHistoricoFuncionariosTP.Controls.Add(Me.PictureBox7)
        Me.RecuperarHistoricoFuncionariosTP.Controls.Add(Me.FuncionarioTF)
        Me.RecuperarHistoricoFuncionariosTP.Controls.Add(Me.Label7)
        Me.RecuperarHistoricoFuncionariosTP.Controls.Add(Me.FimFuncDT)
        Me.RecuperarHistoricoFuncionariosTP.Controls.Add(Me.InicioFuncDT)
        Me.RecuperarHistoricoFuncionariosTP.Controls.Add(Me.GerarRelatorioBT)
        Me.RecuperarHistoricoFuncionariosTP.Controls.Add(Me.Label2)
        Me.RecuperarHistoricoFuncionariosTP.Controls.Add(Me.Label6)
        Me.RecuperarHistoricoFuncionariosTP.Location = New System.Drawing.Point(4, 22)
        Me.RecuperarHistoricoFuncionariosTP.Name = "RecuperarHistoricoFuncionariosTP"
        Me.RecuperarHistoricoFuncionariosTP.Padding = New System.Windows.Forms.Padding(3)
        Me.RecuperarHistoricoFuncionariosTP.Size = New System.Drawing.Size(685, 335)
        Me.RecuperarHistoricoFuncionariosTP.TabIndex = 1
        Me.RecuperarHistoricoFuncionariosTP.Text = "Recuperar Histórico dos Funcionários"
        Me.RecuperarHistoricoFuncionariosTP.UseVisualStyleBackColor = True
        '
        'FuncionariosDT
        '
        Me.FuncionariosDT.AllowUserToAddRows = False
        Me.FuncionariosDT.AllowUserToDeleteRows = False
        Me.FuncionariosDT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FuncionariosDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FuncionariosDT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Matricula, Me.Funcionario, Me.ResetarSenha})
        Me.FuncionariosDT.Location = New System.Drawing.Point(21, 120)
        Me.FuncionariosDT.Name = "FuncionariosDT"
        Me.FuncionariosDT.ReadOnly = True
        Me.FuncionariosDT.RowHeadersVisible = False
        Me.FuncionariosDT.Size = New System.Drawing.Size(629, 157)
        Me.FuncionariosDT.TabIndex = 30
        '
        'Matricula
        '
        Me.Matricula.HeaderText = "Matrícula"
        Me.Matricula.Name = "Matricula"
        Me.Matricula.ReadOnly = True
        '
        'Funcionario
        '
        Me.Funcionario.HeaderText = "Funcionário"
        Me.Funcionario.Name = "Funcionario"
        Me.Funcionario.ReadOnly = True
        Me.Funcionario.Width = 410
        '
        'ResetarSenha
        '
        Me.ResetarSenha.HeaderText = ""
        Me.ResetarSenha.Name = "ResetarSenha"
        Me.ResetarSenha.ReadOnly = True
        '
        'TodosFuncCB
        '
        Me.TodosFuncCB.AutoSize = True
        Me.TodosFuncCB.Location = New System.Drawing.Point(21, 88)
        Me.TodosFuncCB.Name = "TodosFuncCB"
        Me.TodosFuncCB.Size = New System.Drawing.Size(312, 17)
        Me.TodosFuncCB.TabIndex = 29
        Me.TodosFuncCB.Text = "Selecionar todos os funcionários sob minha responsabilidade"
        Me.TodosFuncCB.UseVisualStyleBackColor = True
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.NobelTheater.My.Resources.Resources.Busca
        Me.PictureBox7.Location = New System.Drawing.Point(590, 54)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(27, 20)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 28
        Me.PictureBox7.TabStop = False
        '
        'FuncionarioTF
        '
        Me.FuncionarioTF.Location = New System.Drawing.Point(143, 54)
        Me.FuncionarioTF.Name = "FuncionarioTF"
        Me.FuncionarioTF.Size = New System.Drawing.Size(443, 20)
        Me.FuncionarioTF.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Selecionar Funcionário:"
        '
        'FimFuncDT
        '
        Me.FimFuncDT.CustomFormat = "dd/MM/yyyy"
        Me.FimFuncDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FimFuncDT.Location = New System.Drawing.Point(190, 18)
        Me.FimFuncDT.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.FimFuncDT.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.FimFuncDT.Name = "FimFuncDT"
        Me.FimFuncDT.Size = New System.Drawing.Size(98, 20)
        Me.FimFuncDT.TabIndex = 25
        '
        'InicioFuncDT
        '
        Me.InicioFuncDT.CustomFormat = "dd/MM/yyyy"
        Me.InicioFuncDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.InicioFuncDT.Location = New System.Drawing.Point(54, 18)
        Me.InicioFuncDT.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.InicioFuncDT.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.InicioFuncDT.Name = "InicioFuncDT"
        Me.InicioFuncDT.Size = New System.Drawing.Size(98, 20)
        Me.InicioFuncDT.TabIndex = 24
        '
        'GerarRelatorioBT
        '
        Me.GerarRelatorioBT.Location = New System.Drawing.Point(294, 295)
        Me.GerarRelatorioBT.Name = "GerarRelatorioBT"
        Me.GerarRelatorioBT.Size = New System.Drawing.Size(103, 23)
        Me.GerarRelatorioBT.TabIndex = 23
        Me.GerarRelatorioBT.Text = "Gerar Relatório"
        Me.GerarRelatorioBT.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "De:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(158, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Até:"
        '
        'RecuperarHistorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 519)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "RecuperarHistorico"
        Me.Text = "Recuperar Historico de Ponto"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.RecuperarHistoricoTabControl.ResumeLayout(False)
        Me.RecuperarHistoricoTP.ResumeLayout(False)
        Me.RecuperarHistoricoTP.PerformLayout()
        Me.RecuperarHistoricoFuncionariosTP.ResumeLayout(False)
        Me.RecuperarHistoricoFuncionariosTP.PerformLayout()
        CType(Me.FuncionariosDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RecuperarHistoricoTabControl As System.Windows.Forms.TabControl
    Friend WithEvents RecuperarHistoricoTP As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RecuperarHistoricoFuncionariosTP As System.Windows.Forms.TabPage
    Friend WithEvents FimDT As System.Windows.Forms.DateTimePicker
    Friend WithEvents InicioDT As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents FimFuncDT As System.Windows.Forms.DateTimePicker
    Friend WithEvents InicioFuncDT As System.Windows.Forms.DateTimePicker
    Friend WithEvents GerarRelatorioBT As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TodosFuncCB As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents FuncionarioTF As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents FuncionariosDT As System.Windows.Forms.DataGridView
    Friend WithEvents Matricula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Funcionario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResetarSenha As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents PerfilTF As Label
    Friend WithEvents MatriculaTF As Label
    Friend WithEvents NomeTF As Label
End Class
