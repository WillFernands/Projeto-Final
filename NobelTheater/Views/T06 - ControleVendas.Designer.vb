<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControleVendas
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PerfilTF = New System.Windows.Forms.Label()
        Me.MatriculaTF = New System.Windows.Forms.Label()
        Me.NomeTF = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ControleVendasTabControl = New System.Windows.Forms.TabControl()
        Me.CriarNovoOrcamentoTP = New System.Windows.Forms.TabPage()
        Me.FinalizarBT = New System.Windows.Forms.Button()
        Me.SelecionarClienteNovoOrcamentoTF = New System.Windows.Forms.TextBox()
        Me.SelecionarClienteNovoOrcamentoLB = New System.Windows.Forms.Label()
        Me.QtdeTF = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CodigoProdutoTF = New System.Windows.Forms.TextBox()
        Me.ProdutosDT = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remover = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.SelecionarProdutoNovoOrcamentoTF = New System.Windows.Forms.TextBox()
        Me.SelecionarProdutoNovoOrcamentoLB = New System.Windows.Forms.Label()
        Me.OrcamentosAndamentoTab = New System.Windows.Forms.TabPage()
        Me.OrcamentosDT = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.AcompanharOrcamentoTab = New System.Windows.Forms.TabPage()
        Me.VendedorAcompanharOrcamentoTF = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ClienteAcompanharOrcamentoTF = New System.Windows.Forms.TextBox()
        Me.ProdutoAcompanharOrcamentoTF = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.QtdeProdutoAcompanharOrcamentoTF = New System.Windows.Forms.NumericUpDown()
        Me.CodigoProdutoAcompanharOrcamentoTF = New System.Windows.Forms.TextBox()
        Me.StatusGB = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.StatusOrcamentoCB = New System.Windows.Forms.ComboBox()
        Me.DataEmissaoNFCotacaoLB = New System.Windows.Forms.Label()
        Me.NumeroNFCotacaoLB = New System.Windows.Forms.Label()
        Me.DataEmissaoNFOrcamentoTF = New System.Windows.Forms.TextBox()
        Me.NumeroNFOrcamentoTF = New System.Windows.Forms.TextBox()
        Me.SalvarAcompanharOrcamentoBT = New System.Windows.Forms.Button()
        Me.ProdutosAcompanharOrcamentoDT = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn6 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.VendasAndamentoTab = New System.Windows.Forms.TabPage()
        Me.VendasDT = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotaFiscal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerProd = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.AcompanharVendaTab = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TipoPagamentoCB = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.DataPagamentoTF = New System.Windows.Forms.TextBox()
        Me.ValorPgtoTF = New System.Windows.Forms.TextBox()
        Me.SalvarVendaBT = New System.Windows.Forms.Button()
        Me.PagamentosAcompanharVendaDT = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn4 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ClienteAcompanharVendaTF = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VerItensAcompanharVendaBT = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CriarVisitaAcompanharVendaBT = New System.Windows.Forms.Button()
        Me.VendedorAcompanharVendaTF = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DataAprovacaoAcompanharVendaTF = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DataOrcamentoAcompanharVendaTF = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.StatusVendaAcompanharVendaCB = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DataEmissaoAcompanharVendaTF = New System.Windows.Forms.TextBox()
        Me.NumeroNFAcompanharVendaTF = New System.Windows.Forms.TextBox()
        Me.VisualizarInfoVisitaTP = New System.Windows.Forms.TabPage()
        Me.InfoVisitaTecnicaDG = New System.Windows.Forms.DataGridView()
        Me.ClienteVisitaTecnica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataVisita = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupervisorResponsavel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDaVisita = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewButtonColumn3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.RemoverVisita = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.SupervisorVisitaTF = New System.Windows.Forms.TextBox()
        Me.SupervisorVisitaLB = New System.Windows.Forms.Label()
        Me.ClienteDocumentoVisitaMT = New System.Windows.Forms.MaskedTextBox()
        Me.ClienteNomeVisitaTF = New System.Windows.Forms.TextBox()
        Me.ClienteNomeVisitaLB = New System.Windows.Forms.Label()
        Me.ClienteDocumentoVisitaLB = New System.Windows.Forms.Label()
        Me.SelecionarPorAcompanharVisitaLB = New System.Windows.Forms.Label()
        Me.ExtrairRelatoriosVendasTP = New System.Windows.Forms.TabPage()
        Me.FimDT = New System.Windows.Forms.DateTimePicker()
        Me.InicioDT = New System.Windows.Forms.DateTimePicker()
        Me.DeLB = New System.Windows.Forms.Label()
        Me.AteLB = New System.Windows.Forms.Label()
        Me.GerarRelatorioVendaBT = New System.Windows.Forms.Button()
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.ClienteIMG = New System.Windows.Forms.PictureBox()
        Me.ConfirmaProdutoIMG = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ProdutoOrcamentoIMG = New System.Windows.Forms.PictureBox()
        Me.ConfimarProdutoAcompanharOrcamentoIMG = New System.Windows.Forms.PictureBox()
        Me.SelecionarProdutoAcompanharOrcamentoIMG = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.ConfirmarProdutoAcompanharVendaIMG = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ControleVendasTabControl.SuspendLayout()
        Me.CriarNovoOrcamentoTP.SuspendLayout()
        CType(Me.QtdeTF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosDT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OrcamentosAndamentoTab.SuspendLayout()
        CType(Me.OrcamentosDT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AcompanharOrcamentoTab.SuspendLayout()
        CType(Me.QtdeProdutoAcompanharOrcamentoTF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusGB.SuspendLayout()
        CType(Me.ProdutosAcompanharOrcamentoDT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VendasAndamentoTab.SuspendLayout()
        CType(Me.VendasDT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AcompanharVendaTab.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PagamentosAcompanharVendaDT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.VisualizarInfoVisitaTP.SuspendLayout()
        CType(Me.InfoVisitaTecnicaDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExtrairRelatoriosVendasTP.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfirmaProdutoIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutoOrcamentoIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfimarProdutoAcompanharOrcamentoIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelecionarProdutoAcompanharOrcamentoIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfirmarProdutoAcompanharVendaIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.TabIndex = 5
        '
        'PerfilTF
        '
        Me.PerfilTF.AutoSize = True
        Me.PerfilTF.Location = New System.Drawing.Point(140, 72)
        Me.PerfilTF.Name = "PerfilTF"
        Me.PerfilTF.Size = New System.Drawing.Size(86, 13)
        Me.PerfilTF.TabIndex = 12
        Me.PerfilTF.Text = "Perfil de Acesso:"
        '
        'MatriculaTF
        '
        Me.MatriculaTF.AutoSize = True
        Me.MatriculaTF.Location = New System.Drawing.Point(140, 44)
        Me.MatriculaTF.Name = "MatriculaTF"
        Me.MatriculaTF.Size = New System.Drawing.Size(55, 13)
        Me.MatriculaTF.TabIndex = 11
        Me.MatriculaTF.Text = "Matrícula:"
        '
        'NomeTF
        '
        Me.NomeTF.AutoSize = True
        Me.NomeTF.Location = New System.Drawing.Point(140, 16)
        Me.NomeTF.Name = "NomeTF"
        Me.NomeTF.Size = New System.Drawing.Size(38, 13)
        Me.NomeTF.TabIndex = 10
        Me.NomeTF.Text = "Nome:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ControleVendasTabControl)
        Me.Panel2.Location = New System.Drawing.Point(12, 131)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(705, 374)
        Me.Panel2.TabIndex = 6
        '
        'ControleVendasTabControl
        '
        Me.ControleVendasTabControl.Controls.Add(Me.CriarNovoOrcamentoTP)
        Me.ControleVendasTabControl.Controls.Add(Me.OrcamentosAndamentoTab)
        Me.ControleVendasTabControl.Controls.Add(Me.AcompanharOrcamentoTab)
        Me.ControleVendasTabControl.Controls.Add(Me.VendasAndamentoTab)
        Me.ControleVendasTabControl.Controls.Add(Me.AcompanharVendaTab)
        Me.ControleVendasTabControl.Controls.Add(Me.VisualizarInfoVisitaTP)
        Me.ControleVendasTabControl.Controls.Add(Me.ExtrairRelatoriosVendasTP)
        Me.ControleVendasTabControl.Location = New System.Drawing.Point(9, 10)
        Me.ControleVendasTabControl.Name = "ControleVendasTabControl"
        Me.ControleVendasTabControl.SelectedIndex = 0
        Me.ControleVendasTabControl.Size = New System.Drawing.Size(693, 361)
        Me.ControleVendasTabControl.TabIndex = 0
        '
        'CriarNovoOrcamentoTP
        '
        Me.CriarNovoOrcamentoTP.Controls.Add(Me.FinalizarBT)
        Me.CriarNovoOrcamentoTP.Controls.Add(Me.PictureBox6)
        Me.CriarNovoOrcamentoTP.Controls.Add(Me.ClienteIMG)
        Me.CriarNovoOrcamentoTP.Controls.Add(Me.SelecionarClienteNovoOrcamentoTF)
        Me.CriarNovoOrcamentoTP.Controls.Add(Me.SelecionarClienteNovoOrcamentoLB)
        Me.CriarNovoOrcamentoTP.Controls.Add(Me.ConfirmaProdutoIMG)
        Me.CriarNovoOrcamentoTP.Controls.Add(Me.QtdeTF)
        Me.CriarNovoOrcamentoTP.Controls.Add(Me.Label6)
        Me.CriarNovoOrcamentoTP.Controls.Add(Me.Label2)
        Me.CriarNovoOrcamentoTP.Controls.Add(Me.CodigoProdutoTF)
        Me.CriarNovoOrcamentoTP.Controls.Add(Me.ProdutosDT)
        Me.CriarNovoOrcamentoTP.Controls.Add(Me.PictureBox3)
        Me.CriarNovoOrcamentoTP.Controls.Add(Me.ProdutoOrcamentoIMG)
        Me.CriarNovoOrcamentoTP.Controls.Add(Me.SelecionarProdutoNovoOrcamentoTF)
        Me.CriarNovoOrcamentoTP.Controls.Add(Me.SelecionarProdutoNovoOrcamentoLB)
        Me.CriarNovoOrcamentoTP.Location = New System.Drawing.Point(4, 22)
        Me.CriarNovoOrcamentoTP.Name = "CriarNovoOrcamentoTP"
        Me.CriarNovoOrcamentoTP.Padding = New System.Windows.Forms.Padding(3)
        Me.CriarNovoOrcamentoTP.Size = New System.Drawing.Size(685, 335)
        Me.CriarNovoOrcamentoTP.TabIndex = 0
        Me.CriarNovoOrcamentoTP.Text = "Criar Novo Orçamento"
        Me.CriarNovoOrcamentoTP.UseVisualStyleBackColor = True
        '
        'FinalizarBT
        '
        Me.FinalizarBT.Location = New System.Drawing.Point(281, 306)
        Me.FinalizarBT.Name = "FinalizarBT"
        Me.FinalizarBT.Size = New System.Drawing.Size(122, 23)
        Me.FinalizarBT.TabIndex = 6
        Me.FinalizarBT.Text = "Finalizar Orçamento"
        Me.FinalizarBT.UseVisualStyleBackColor = True
        '
        'SelecionarClienteNovoOrcamentoTF
        '
        Me.SelecionarClienteNovoOrcamentoTF.Enabled = False
        Me.SelecionarClienteNovoOrcamentoTF.Location = New System.Drawing.Point(150, 16)
        Me.SelecionarClienteNovoOrcamentoTF.Name = "SelecionarClienteNovoOrcamentoTF"
        Me.SelecionarClienteNovoOrcamentoTF.Size = New System.Drawing.Size(463, 20)
        Me.SelecionarClienteNovoOrcamentoTF.TabIndex = 1
        '
        'SelecionarClienteNovoOrcamentoLB
        '
        Me.SelecionarClienteNovoOrcamentoLB.AutoSize = True
        Me.SelecionarClienteNovoOrcamentoLB.Location = New System.Drawing.Point(49, 19)
        Me.SelecionarClienteNovoOrcamentoLB.Name = "SelecionarClienteNovoOrcamentoLB"
        Me.SelecionarClienteNovoOrcamentoLB.Size = New System.Drawing.Size(95, 13)
        Me.SelecionarClienteNovoOrcamentoLB.TabIndex = 14
        Me.SelecionarClienteNovoOrcamentoLB.Text = "Selecionar Cliente:"
        '
        'QtdeTF
        '
        Me.QtdeTF.Location = New System.Drawing.Point(573, 61)
        Me.QtdeTF.Name = "QtdeTF"
        Me.QtdeTF.Size = New System.Drawing.Size(42, 20)
        Me.QtdeTF.TabIndex = 4
        Me.QtdeTF.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(577, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Qtde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(536, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Cod"
        '
        'CodigoProdutoTF
        '
        Me.CodigoProdutoTF.Enabled = False
        Me.CodigoProdutoTF.Location = New System.Drawing.Point(531, 61)
        Me.CodigoProdutoTF.Name = "CodigoProdutoTF"
        Me.CodigoProdutoTF.Size = New System.Drawing.Size(37, 20)
        Me.CodigoProdutoTF.TabIndex = 3
        '
        'ProdutosDT
        '
        Me.ProdutosDT.AllowUserToAddRows = False
        Me.ProdutosDT.AllowUserToDeleteRows = False
        Me.ProdutosDT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProdutosDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProdutosDT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.Quantidade, Me.PrecoTotal, Me.Remover})
        Me.ProdutosDT.Location = New System.Drawing.Point(18, 92)
        Me.ProdutosDT.Name = "ProdutosDT"
        Me.ProdutosDT.ReadOnly = True
        Me.ProdutosDT.RowHeadersVisible = False
        Me.ProdutosDT.Size = New System.Drawing.Size(661, 209)
        Me.ProdutosDT.TabIndex = 5
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Cod"
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
        '
        'PrecoTotal
        '
        Me.PrecoTotal.HeaderText = "Preço Total"
        Me.PrecoTotal.Name = "PrecoTotal"
        Me.PrecoTotal.ReadOnly = True
        '
        'Remover
        '
        Me.Remover.HeaderText = "Remover"
        Me.Remover.Name = "Remover"
        Me.Remover.ReadOnly = True
        '
        'SelecionarProdutoNovoOrcamentoTF
        '
        Me.SelecionarProdutoNovoOrcamentoTF.Enabled = False
        Me.SelecionarProdutoNovoOrcamentoTF.Location = New System.Drawing.Point(150, 61)
        Me.SelecionarProdutoNovoOrcamentoTF.Name = "SelecionarProdutoNovoOrcamentoTF"
        Me.SelecionarProdutoNovoOrcamentoTF.Size = New System.Drawing.Size(375, 20)
        Me.SelecionarProdutoNovoOrcamentoTF.TabIndex = 2
        '
        'SelecionarProdutoNovoOrcamentoLB
        '
        Me.SelecionarProdutoNovoOrcamentoLB.AutoSize = True
        Me.SelecionarProdutoNovoOrcamentoLB.Location = New System.Drawing.Point(49, 64)
        Me.SelecionarProdutoNovoOrcamentoLB.Name = "SelecionarProdutoNovoOrcamentoLB"
        Me.SelecionarProdutoNovoOrcamentoLB.Size = New System.Drawing.Size(100, 13)
        Me.SelecionarProdutoNovoOrcamentoLB.TabIndex = 3
        Me.SelecionarProdutoNovoOrcamentoLB.Text = "Selecionar Produto:"
        '
        'OrcamentosAndamentoTab
        '
        Me.OrcamentosAndamentoTab.Controls.Add(Me.OrcamentosDT)
        Me.OrcamentosAndamentoTab.Location = New System.Drawing.Point(4, 22)
        Me.OrcamentosAndamentoTab.Name = "OrcamentosAndamentoTab"
        Me.OrcamentosAndamentoTab.Size = New System.Drawing.Size(685, 335)
        Me.OrcamentosAndamentoTab.TabIndex = 8
        Me.OrcamentosAndamentoTab.Text = "Orcamentos em Andamento"
        Me.OrcamentosAndamentoTab.UseVisualStyleBackColor = True
        '
        'OrcamentosDT
        '
        Me.OrcamentosDT.AllowUserToAddRows = False
        Me.OrcamentosDT.AllowUserToDeleteRows = False
        Me.OrcamentosDT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OrcamentosDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrcamentosDT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.Vendedor, Me.DataGridViewButtonColumn1})
        Me.OrcamentosDT.Location = New System.Drawing.Point(6, 6)
        Me.OrcamentosDT.Name = "OrcamentosDT"
        Me.OrcamentosDT.ReadOnly = True
        Me.OrcamentosDT.RowHeadersVisible = False
        Me.OrcamentosDT.Size = New System.Drawing.Size(673, 323)
        Me.OrcamentosDT.TabIndex = 23
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 50
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Data do Orçamento"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 75
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Status da Cotação"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 150
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 300
        '
        'Vendedor
        '
        Me.Vendedor.HeaderText = "Vendedor"
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.ReadOnly = True
        '
        'DataGridViewButtonColumn1
        '
        Me.DataGridViewButtonColumn1.HeaderText = "Ver Produtos"
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.ReadOnly = True
        '
        'AcompanharOrcamentoTab
        '
        Me.AcompanharOrcamentoTab.Controls.Add(Me.VendedorAcompanharOrcamentoTF)
        Me.AcompanharOrcamentoTab.Controls.Add(Me.Label5)
        Me.AcompanharOrcamentoTab.Controls.Add(Me.ClienteAcompanharOrcamentoTF)
        Me.AcompanharOrcamentoTab.Controls.Add(Me.ProdutoAcompanharOrcamentoTF)
        Me.AcompanharOrcamentoTab.Controls.Add(Me.Label4)
        Me.AcompanharOrcamentoTab.Controls.Add(Me.QtdeProdutoAcompanharOrcamentoTF)
        Me.AcompanharOrcamentoTab.Controls.Add(Me.CodigoProdutoAcompanharOrcamentoTF)
        Me.AcompanharOrcamentoTab.Controls.Add(Me.StatusGB)
        Me.AcompanharOrcamentoTab.Controls.Add(Me.SalvarAcompanharOrcamentoBT)
        Me.AcompanharOrcamentoTab.Controls.Add(Me.ProdutosAcompanharOrcamentoDT)
        Me.AcompanharOrcamentoTab.Controls.Add(Me.Label3)
        Me.AcompanharOrcamentoTab.Controls.Add(Me.ConfimarProdutoAcompanharOrcamentoIMG)
        Me.AcompanharOrcamentoTab.Controls.Add(Me.SelecionarProdutoAcompanharOrcamentoIMG)
        Me.AcompanharOrcamentoTab.Controls.Add(Me.PictureBox7)
        Me.AcompanharOrcamentoTab.Location = New System.Drawing.Point(4, 22)
        Me.AcompanharOrcamentoTab.Name = "AcompanharOrcamentoTab"
        Me.AcompanharOrcamentoTab.Padding = New System.Windows.Forms.Padding(3)
        Me.AcompanharOrcamentoTab.Size = New System.Drawing.Size(685, 335)
        Me.AcompanharOrcamentoTab.TabIndex = 9
        Me.AcompanharOrcamentoTab.Text = "Acompanhar Orcamento"
        Me.AcompanharOrcamentoTab.UseVisualStyleBackColor = True
        '
        'VendedorAcompanharOrcamentoTF
        '
        Me.VendedorAcompanharOrcamentoTF.Enabled = False
        Me.VendedorAcompanharOrcamentoTF.Location = New System.Drawing.Point(166, 40)
        Me.VendedorAcompanharOrcamentoTF.Name = "VendedorAcompanharOrcamentoTF"
        Me.VendedorAcompanharOrcamentoTF.Size = New System.Drawing.Size(443, 20)
        Me.VendedorAcompanharOrcamentoTF.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Vendedor:"
        '
        'ClienteAcompanharOrcamentoTF
        '
        Me.ClienteAcompanharOrcamentoTF.Enabled = False
        Me.ClienteAcompanharOrcamentoTF.Location = New System.Drawing.Point(166, 14)
        Me.ClienteAcompanharOrcamentoTF.Name = "ClienteAcompanharOrcamentoTF"
        Me.ClienteAcompanharOrcamentoTF.Size = New System.Drawing.Size(443, 20)
        Me.ClienteAcompanharOrcamentoTF.TabIndex = 41
        '
        'ProdutoAcompanharOrcamentoTF
        '
        Me.ProdutoAcompanharOrcamentoTF.Enabled = False
        Me.ProdutoAcompanharOrcamentoTF.Location = New System.Drawing.Point(166, 66)
        Me.ProdutoAcompanharOrcamentoTF.Name = "ProdutoAcompanharOrcamentoTF"
        Me.ProdutoAcompanharOrcamentoTF.Size = New System.Drawing.Size(355, 20)
        Me.ProdutoAcompanharOrcamentoTF.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Selecionar Produto:"
        '
        'QtdeProdutoAcompanharOrcamentoTF
        '
        Me.QtdeProdutoAcompanharOrcamentoTF.Location = New System.Drawing.Point(567, 66)
        Me.QtdeProdutoAcompanharOrcamentoTF.Name = "QtdeProdutoAcompanharOrcamentoTF"
        Me.QtdeProdutoAcompanharOrcamentoTF.Size = New System.Drawing.Size(42, 20)
        Me.QtdeProdutoAcompanharOrcamentoTF.TabIndex = 38
        Me.QtdeProdutoAcompanharOrcamentoTF.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CodigoProdutoAcompanharOrcamentoTF
        '
        Me.CodigoProdutoAcompanharOrcamentoTF.Enabled = False
        Me.CodigoProdutoAcompanharOrcamentoTF.Location = New System.Drawing.Point(525, 66)
        Me.CodigoProdutoAcompanharOrcamentoTF.Name = "CodigoProdutoAcompanharOrcamentoTF"
        Me.CodigoProdutoAcompanharOrcamentoTF.Size = New System.Drawing.Size(37, 20)
        Me.CodigoProdutoAcompanharOrcamentoTF.TabIndex = 37
        '
        'StatusGB
        '
        Me.StatusGB.Controls.Add(Me.Label11)
        Me.StatusGB.Controls.Add(Me.StatusOrcamentoCB)
        Me.StatusGB.Controls.Add(Me.DataEmissaoNFCotacaoLB)
        Me.StatusGB.Controls.Add(Me.NumeroNFCotacaoLB)
        Me.StatusGB.Controls.Add(Me.DataEmissaoNFOrcamentoTF)
        Me.StatusGB.Controls.Add(Me.NumeroNFOrcamentoTF)
        Me.StatusGB.Location = New System.Drawing.Point(12, 91)
        Me.StatusGB.Name = "StatusGB"
        Me.StatusGB.Size = New System.Drawing.Size(661, 38)
        Me.StatusGB.TabIndex = 42
        Me.StatusGB.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Status Orçamento:"
        '
        'StatusOrcamentoCB
        '
        Me.StatusOrcamentoCB.FormattingEnabled = True
        Me.StatusOrcamentoCB.Location = New System.Drawing.Point(104, 12)
        Me.StatusOrcamentoCB.Name = "StatusOrcamentoCB"
        Me.StatusOrcamentoCB.Size = New System.Drawing.Size(165, 21)
        Me.StatusOrcamentoCB.TabIndex = 4
        '
        'DataEmissaoNFCotacaoLB
        '
        Me.DataEmissaoNFCotacaoLB.AutoSize = True
        Me.DataEmissaoNFCotacaoLB.Location = New System.Drawing.Point(457, 15)
        Me.DataEmissaoNFCotacaoLB.Name = "DataEmissaoNFCotacaoLB"
        Me.DataEmissaoNFCotacaoLB.Size = New System.Drawing.Size(92, 13)
        Me.DataEmissaoNFCotacaoLB.TabIndex = 3
        Me.DataEmissaoNFCotacaoLB.Text = "Data Emissão NF:"
        '
        'NumeroNFCotacaoLB
        '
        Me.NumeroNFCotacaoLB.AutoSize = True
        Me.NumeroNFCotacaoLB.Location = New System.Drawing.Point(273, 15)
        Me.NumeroNFCotacaoLB.Name = "NumeroNFCotacaoLB"
        Me.NumeroNFCotacaoLB.Size = New System.Drawing.Size(64, 13)
        Me.NumeroNFCotacaoLB.TabIndex = 2
        Me.NumeroNFCotacaoLB.Text = "Número NF:"
        '
        'DataEmissaoNFOrcamentoTF
        '
        Me.DataEmissaoNFOrcamentoTF.Location = New System.Drawing.Point(555, 12)
        Me.DataEmissaoNFOrcamentoTF.Name = "DataEmissaoNFOrcamentoTF"
        Me.DataEmissaoNFOrcamentoTF.Size = New System.Drawing.Size(100, 20)
        Me.DataEmissaoNFOrcamentoTF.TabIndex = 1
        '
        'NumeroNFOrcamentoTF
        '
        Me.NumeroNFOrcamentoTF.Location = New System.Drawing.Point(349, 12)
        Me.NumeroNFOrcamentoTF.Name = "NumeroNFOrcamentoTF"
        Me.NumeroNFOrcamentoTF.Size = New System.Drawing.Size(100, 20)
        Me.NumeroNFOrcamentoTF.TabIndex = 0
        '
        'SalvarAcompanharOrcamentoBT
        '
        Me.SalvarAcompanharOrcamentoBT.Location = New System.Drawing.Point(300, 297)
        Me.SalvarAcompanharOrcamentoBT.Name = "SalvarAcompanharOrcamentoBT"
        Me.SalvarAcompanharOrcamentoBT.Size = New System.Drawing.Size(103, 23)
        Me.SalvarAcompanharOrcamentoBT.TabIndex = 43
        Me.SalvarAcompanharOrcamentoBT.Text = "Salvar Alterações"
        Me.SalvarAcompanharOrcamentoBT.UseVisualStyleBackColor = True
        '
        'ProdutosAcompanharOrcamentoDT
        '
        Me.ProdutosAcompanharOrcamentoDT.AllowUserToAddRows = False
        Me.ProdutosAcompanharOrcamentoDT.AllowUserToDeleteRows = False
        Me.ProdutosAcompanharOrcamentoDT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProdutosAcompanharOrcamentoDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProdutosAcompanharOrcamentoDT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewButtonColumn6})
        Me.ProdutosAcompanharOrcamentoDT.Location = New System.Drawing.Point(12, 139)
        Me.ProdutosAcompanharOrcamentoDT.Name = "ProdutosAcompanharOrcamentoDT"
        Me.ProdutosAcompanharOrcamentoDT.ReadOnly = True
        Me.ProdutosAcompanharOrcamentoDT.RowHeadersVisible = False
        Me.ProdutosAcompanharOrcamentoDT.Size = New System.Drawing.Size(661, 142)
        Me.ProdutosAcompanharOrcamentoDT.TabIndex = 32
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 50
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 250
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "Preço Unit"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 90
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "Qtde"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 50
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "Preço Total"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewButtonColumn6
        '
        Me.DataGridViewButtonColumn6.HeaderText = "Remover"
        Me.DataGridViewButtonColumn6.Name = "DataGridViewButtonColumn6"
        Me.DataGridViewButtonColumn6.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Cliente:"
        '
        'VendasAndamentoTab
        '
        Me.VendasAndamentoTab.Controls.Add(Me.VendasDT)
        Me.VendasAndamentoTab.Location = New System.Drawing.Point(4, 22)
        Me.VendasAndamentoTab.Name = "VendasAndamentoTab"
        Me.VendasAndamentoTab.Padding = New System.Windows.Forms.Padding(3)
        Me.VendasAndamentoTab.Size = New System.Drawing.Size(685, 335)
        Me.VendasAndamentoTab.TabIndex = 2
        Me.VendasAndamentoTab.Text = "Vendas em Andamento"
        Me.VendasAndamentoTab.UseVisualStyleBackColor = True
        '
        'VendasDT
        '
        Me.VendasDT.AllowUserToAddRows = False
        Me.VendasDT.AllowUserToDeleteRows = False
        Me.VendasDT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.VendasDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VendasDT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.Fornecedor, Me.NotaFiscal, Me.VerProd})
        Me.VendasDT.Location = New System.Drawing.Point(6, 6)
        Me.VendasDT.Name = "VendasDT"
        Me.VendasDT.ReadOnly = True
        Me.VendasDT.RowHeadersVisible = False
        Me.VendasDT.Size = New System.Drawing.Size(673, 323)
        Me.VendasDT.TabIndex = 21
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Data do Orçamento"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Status da Venda"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Data Aprovação"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'Fornecedor
        '
        Me.Fornecedor.HeaderText = "Cliente"
        Me.Fornecedor.Name = "Fornecedor"
        Me.Fornecedor.ReadOnly = True
        '
        'NotaFiscal
        '
        Me.NotaFiscal.HeaderText = "NotaFiscal"
        Me.NotaFiscal.Name = "NotaFiscal"
        Me.NotaFiscal.ReadOnly = True
        '
        'VerProd
        '
        Me.VerProd.HeaderText = "Ver Produtos"
        Me.VerProd.Name = "VerProd"
        Me.VerProd.ReadOnly = True
        '
        'AcompanharVendaTab
        '
        Me.AcompanharVendaTab.Controls.Add(Me.GroupBox2)
        Me.AcompanharVendaTab.Controls.Add(Me.SalvarVendaBT)
        Me.AcompanharVendaTab.Controls.Add(Me.PagamentosAcompanharVendaDT)
        Me.AcompanharVendaTab.Controls.Add(Me.GroupBox1)
        Me.AcompanharVendaTab.Location = New System.Drawing.Point(4, 22)
        Me.AcompanharVendaTab.Name = "AcompanharVendaTab"
        Me.AcompanharVendaTab.Padding = New System.Windows.Forms.Padding(3)
        Me.AcompanharVendaTab.Size = New System.Drawing.Size(685, 335)
        Me.AcompanharVendaTab.TabIndex = 6
        Me.AcompanharVendaTab.Text = "Acompanhar Venda"
        Me.AcompanharVendaTab.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ConfirmarProdutoAcompanharVendaIMG)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.TipoPagamentoCB)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.DataPagamentoTF)
        Me.GroupBox2.Controls.Add(Me.ValorPgtoTF)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(661, 38)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(176, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 13)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Tipo Pgto:"
        '
        'TipoPagamentoCB
        '
        Me.TipoPagamentoCB.FormattingEnabled = True
        Me.TipoPagamentoCB.Location = New System.Drawing.Point(236, 13)
        Me.TipoPagamentoCB.Name = "TipoPagamentoCB"
        Me.TipoPagamentoCB.Size = New System.Drawing.Size(151, 21)
        Me.TipoPagamentoCB.TabIndex = 4
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 13)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Data Pgto:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(402, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 13)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Valor Pgto:"
        '
        'DataPagamentoTF
        '
        Me.DataPagamentoTF.Location = New System.Drawing.Point(70, 13)
        Me.DataPagamentoTF.Name = "DataPagamentoTF"
        Me.DataPagamentoTF.Size = New System.Drawing.Size(100, 20)
        Me.DataPagamentoTF.TabIndex = 1
        '
        'ValorPgtoTF
        '
        Me.ValorPgtoTF.Location = New System.Drawing.Point(467, 13)
        Me.ValorPgtoTF.Name = "ValorPgtoTF"
        Me.ValorPgtoTF.Size = New System.Drawing.Size(100, 20)
        Me.ValorPgtoTF.TabIndex = 0
        '
        'SalvarVendaBT
        '
        Me.SalvarVendaBT.Location = New System.Drawing.Point(300, 300)
        Me.SalvarVendaBT.Name = "SalvarVendaBT"
        Me.SalvarVendaBT.Size = New System.Drawing.Size(103, 23)
        Me.SalvarVendaBT.TabIndex = 47
        Me.SalvarVendaBT.Text = "Salvar Alterações"
        Me.SalvarVendaBT.UseVisualStyleBackColor = True
        '
        'PagamentosAcompanharVendaDT
        '
        Me.PagamentosAcompanharVendaDT.AllowUserToAddRows = False
        Me.PagamentosAcompanharVendaDT.AllowUserToDeleteRows = False
        Me.PagamentosAcompanharVendaDT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PagamentosAcompanharVendaDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PagamentosAcompanharVendaDT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewButtonColumn4})
        Me.PagamentosAcompanharVendaDT.Location = New System.Drawing.Point(12, 179)
        Me.PagamentosAcompanharVendaDT.Name = "PagamentosAcompanharVendaDT"
        Me.PagamentosAcompanharVendaDT.ReadOnly = True
        Me.PagamentosAcompanharVendaDT.RowHeadersVisible = False
        Me.PagamentosAcompanharVendaDT.Size = New System.Drawing.Size(661, 112)
        Me.PagamentosAcompanharVendaDT.TabIndex = 45
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 250
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 90
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 50
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.HeaderText = "Valor"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewButtonColumn4
        '
        Me.DataGridViewButtonColumn4.HeaderText = "Remover"
        Me.DataGridViewButtonColumn4.Name = "DataGridViewButtonColumn4"
        Me.DataGridViewButtonColumn4.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ClienteAcompanharVendaTF)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.VerItensAcompanharVendaBT)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.CriarVisitaAcompanharVendaBT)
        Me.GroupBox1.Controls.Add(Me.VendedorAcompanharVendaTF)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.DataAprovacaoAcompanharVendaTF)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.DataOrcamentoAcompanharVendaTF)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.StatusVendaAcompanharVendaCB)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.DataEmissaoAcompanharVendaTF)
        Me.GroupBox1.Controls.Add(Me.NumeroNFAcompanharVendaTF)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(661, 134)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'ClienteAcompanharVendaTF
        '
        Me.ClienteAcompanharVendaTF.Enabled = False
        Me.ClienteAcompanharVendaTF.Location = New System.Drawing.Point(112, 15)
        Me.ClienteAcompanharVendaTF.Name = "ClienteAcompanharVendaTF"
        Me.ClienteAcompanharVendaTF.Size = New System.Drawing.Size(537, 20)
        Me.ClienteAcompanharVendaTF.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Cliente:"
        '
        'VerItensAcompanharVendaBT
        '
        Me.VerItensAcompanharVendaBT.Location = New System.Drawing.Point(391, 104)
        Me.VerItensAcompanharVendaBT.Name = "VerItensAcompanharVendaBT"
        Me.VerItensAcompanharVendaBT.Size = New System.Drawing.Size(120, 23)
        Me.VerItensAcompanharVendaBT.TabIndex = 44
        Me.VerItensAcompanharVendaBT.Text = "Ver Itens da Venda"
        Me.VerItensAcompanharVendaBT.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 107)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(103, 13)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Data de Aprovação:"
        '
        'CriarVisitaAcompanharVendaBT
        '
        Me.CriarVisitaAcompanharVendaBT.Location = New System.Drawing.Point(517, 104)
        Me.CriarVisitaAcompanharVendaBT.Name = "CriarVisitaAcompanharVendaBT"
        Me.CriarVisitaAcompanharVendaBT.Size = New System.Drawing.Size(136, 23)
        Me.CriarVisitaAcompanharVendaBT.TabIndex = 0
        Me.CriarVisitaAcompanharVendaBT.Text = "Criar nova visita técnica"
        Me.CriarVisitaAcompanharVendaBT.UseVisualStyleBackColor = True
        '
        'VendedorAcompanharVendaTF
        '
        Me.VendedorAcompanharVendaTF.Enabled = False
        Me.VendedorAcompanharVendaTF.Location = New System.Drawing.Point(112, 43)
        Me.VendedorAcompanharVendaTF.Name = "VendedorAcompanharVendaTF"
        Me.VendedorAcompanharVendaTF.Size = New System.Drawing.Size(537, 20)
        Me.VendedorAcompanharVendaTF.TabIndex = 41
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 47)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 13)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Vendedor:"
        '
        'DataAprovacaoAcompanharVendaTF
        '
        Me.DataAprovacaoAcompanharVendaTF.Enabled = False
        Me.DataAprovacaoAcompanharVendaTF.Location = New System.Drawing.Point(112, 104)
        Me.DataAprovacaoAcompanharVendaTF.Name = "DataAprovacaoAcompanharVendaTF"
        Me.DataAprovacaoAcompanharVendaTF.Size = New System.Drawing.Size(90, 20)
        Me.DataAprovacaoAcompanharVendaTF.TabIndex = 8
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 78)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(103, 13)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Data do Orçamento:"
        '
        'DataOrcamentoAcompanharVendaTF
        '
        Me.DataOrcamentoAcompanharVendaTF.Enabled = False
        Me.DataOrcamentoAcompanharVendaTF.Location = New System.Drawing.Point(112, 75)
        Me.DataOrcamentoAcompanharVendaTF.Name = "DataOrcamentoAcompanharVendaTF"
        Me.DataOrcamentoAcompanharVendaTF.Size = New System.Drawing.Size(90, 20)
        Me.DataOrcamentoAcompanharVendaTF.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(207, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Status Venda:"
        '
        'StatusVendaAcompanharVendaCB
        '
        Me.StatusVendaAcompanharVendaCB.FormattingEnabled = True
        Me.StatusVendaAcompanharVendaCB.Location = New System.Drawing.Point(292, 104)
        Me.StatusVendaAcompanharVendaCB.Name = "StatusVendaAcompanharVendaCB"
        Me.StatusVendaAcompanharVendaCB.Size = New System.Drawing.Size(90, 21)
        Me.StatusVendaAcompanharVendaCB.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(455, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Data Emissão NF:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(246, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Número NF:"
        '
        'DataEmissaoAcompanharVendaTF
        '
        Me.DataEmissaoAcompanharVendaTF.Location = New System.Drawing.Point(559, 75)
        Me.DataEmissaoAcompanharVendaTF.Name = "DataEmissaoAcompanharVendaTF"
        Me.DataEmissaoAcompanharVendaTF.Size = New System.Drawing.Size(90, 20)
        Me.DataEmissaoAcompanharVendaTF.TabIndex = 1
        '
        'NumeroNFAcompanharVendaTF
        '
        Me.NumeroNFAcompanharVendaTF.Location = New System.Drawing.Point(321, 75)
        Me.NumeroNFAcompanharVendaTF.Name = "NumeroNFAcompanharVendaTF"
        Me.NumeroNFAcompanharVendaTF.Size = New System.Drawing.Size(90, 20)
        Me.NumeroNFAcompanharVendaTF.TabIndex = 0
        '
        'VisualizarInfoVisitaTP
        '
        Me.VisualizarInfoVisitaTP.Controls.Add(Me.InfoVisitaTecnicaDG)
        Me.VisualizarInfoVisitaTP.Controls.Add(Me.SupervisorVisitaTF)
        Me.VisualizarInfoVisitaTP.Controls.Add(Me.SupervisorVisitaLB)
        Me.VisualizarInfoVisitaTP.Controls.Add(Me.ClienteDocumentoVisitaMT)
        Me.VisualizarInfoVisitaTP.Controls.Add(Me.ClienteNomeVisitaTF)
        Me.VisualizarInfoVisitaTP.Controls.Add(Me.ClienteNomeVisitaLB)
        Me.VisualizarInfoVisitaTP.Controls.Add(Me.ClienteDocumentoVisitaLB)
        Me.VisualizarInfoVisitaTP.Controls.Add(Me.SelecionarPorAcompanharVisitaLB)
        Me.VisualizarInfoVisitaTP.Controls.Add(Me.PictureBox8)
        Me.VisualizarInfoVisitaTP.Controls.Add(Me.PictureBox5)
        Me.VisualizarInfoVisitaTP.Location = New System.Drawing.Point(4, 22)
        Me.VisualizarInfoVisitaTP.Name = "VisualizarInfoVisitaTP"
        Me.VisualizarInfoVisitaTP.Padding = New System.Windows.Forms.Padding(3)
        Me.VisualizarInfoVisitaTP.Size = New System.Drawing.Size(685, 335)
        Me.VisualizarInfoVisitaTP.TabIndex = 5
        Me.VisualizarInfoVisitaTP.Text = "Visualizar Informações da Visita"
        Me.VisualizarInfoVisitaTP.UseVisualStyleBackColor = True
        '
        'InfoVisitaTecnicaDG
        '
        Me.InfoVisitaTecnicaDG.AllowUserToAddRows = False
        Me.InfoVisitaTecnicaDG.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.InfoVisitaTecnicaDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InfoVisitaTecnicaDG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClienteVisitaTecnica, Me.DataVisita, Me.SupervisorResponsavel, Me.ValorDaVisita, Me.DataGridViewButtonColumn2, Me.DataGridViewButtonColumn3, Me.RemoverVisita})
        Me.InfoVisitaTecnicaDG.Location = New System.Drawing.Point(6, 103)
        Me.InfoVisitaTecnicaDG.Name = "InfoVisitaTecnicaDG"
        Me.InfoVisitaTecnicaDG.RowHeadersVisible = False
        Me.InfoVisitaTecnicaDG.Size = New System.Drawing.Size(673, 226)
        Me.InfoVisitaTecnicaDG.TabIndex = 22
        '
        'ClienteVisitaTecnica
        '
        Me.ClienteVisitaTecnica.HeaderText = "Cliente"
        Me.ClienteVisitaTecnica.Name = "ClienteVisitaTecnica"
        Me.ClienteVisitaTecnica.Width = 75
        '
        'DataVisita
        '
        Me.DataVisita.HeaderText = "Data da Visita"
        Me.DataVisita.Name = "DataVisita"
        Me.DataVisita.Width = 75
        '
        'SupervisorResponsavel
        '
        Me.SupervisorResponsavel.HeaderText = "Supervisor Responsável"
        Me.SupervisorResponsavel.Name = "SupervisorResponsavel"
        Me.SupervisorResponsavel.Width = 75
        '
        'ValorDaVisita
        '
        Me.ValorDaVisita.HeaderText = "Preço"
        Me.ValorDaVisita.Name = "ValorDaVisita"
        Me.ValorDaVisita.Width = 75
        '
        'DataGridViewButtonColumn2
        '
        Me.DataGridViewButtonColumn2.HeaderText = "Ver Produtos"
        Me.DataGridViewButtonColumn2.Name = "DataGridViewButtonColumn2"
        '
        'DataGridViewButtonColumn3
        '
        Me.DataGridViewButtonColumn3.HeaderText = "Ver Pagamentos"
        Me.DataGridViewButtonColumn3.Name = "DataGridViewButtonColumn3"
        '
        'RemoverVisita
        '
        Me.RemoverVisita.HeaderText = "Remover"
        Me.RemoverVisita.Name = "RemoverVisita"
        '
        'SupervisorVisitaTF
        '
        Me.SupervisorVisitaTF.Location = New System.Drawing.Point(137, 77)
        Me.SupervisorVisitaTF.Name = "SupervisorVisitaTF"
        Me.SupervisorVisitaTF.Size = New System.Drawing.Size(490, 20)
        Me.SupervisorVisitaTF.TabIndex = 20
        '
        'SupervisorVisitaLB
        '
        Me.SupervisorVisitaLB.AutoSize = True
        Me.SupervisorVisitaLB.Location = New System.Drawing.Point(6, 80)
        Me.SupervisorVisitaLB.Name = "SupervisorVisitaLB"
        Me.SupervisorVisitaLB.Size = New System.Drawing.Size(125, 13)
        Me.SupervisorVisitaLB.TabIndex = 19
        Me.SupervisorVisitaLB.Text = "Supervisor Responsável:"
        '
        'ClienteDocumentoVisitaMT
        '
        Me.ClienteDocumentoVisitaMT.Location = New System.Drawing.Point(137, 46)
        Me.ClienteDocumentoVisitaMT.Name = "ClienteDocumentoVisitaMT"
        Me.ClienteDocumentoVisitaMT.Size = New System.Drawing.Size(154, 20)
        Me.ClienteDocumentoVisitaMT.TabIndex = 18
        '
        'ClienteNomeVisitaTF
        '
        Me.ClienteNomeVisitaTF.Location = New System.Drawing.Point(382, 46)
        Me.ClienteNomeVisitaTF.Name = "ClienteNomeVisitaTF"
        Me.ClienteNomeVisitaTF.Size = New System.Drawing.Size(245, 20)
        Me.ClienteNomeVisitaTF.TabIndex = 3
        '
        'ClienteNomeVisitaLB
        '
        Me.ClienteNomeVisitaLB.AutoSize = True
        Me.ClienteNomeVisitaLB.Location = New System.Drawing.Point(297, 50)
        Me.ClienteNomeVisitaLB.Name = "ClienteNomeVisitaLB"
        Me.ClienteNomeVisitaLB.Size = New System.Drawing.Size(79, 13)
        Me.ClienteNomeVisitaLB.TabIndex = 2
        Me.ClienteNomeVisitaLB.Text = "Cliente - Nome:"
        '
        'ClienteDocumentoVisitaLB
        '
        Me.ClienteDocumentoVisitaLB.AutoSize = True
        Me.ClienteDocumentoVisitaLB.Location = New System.Drawing.Point(6, 49)
        Me.ClienteDocumentoVisitaLB.Name = "ClienteDocumentoVisitaLB"
        Me.ClienteDocumentoVisitaLB.Size = New System.Drawing.Size(116, 13)
        Me.ClienteDocumentoVisitaLB.TabIndex = 1
        Me.ClienteDocumentoVisitaLB.Text = "Cliente - CPNJ ou CPF:"
        '
        'SelecionarPorAcompanharVisitaLB
        '
        Me.SelecionarPorAcompanharVisitaLB.AutoSize = True
        Me.SelecionarPorAcompanharVisitaLB.Location = New System.Drawing.Point(6, 18)
        Me.SelecionarPorAcompanharVisitaLB.Name = "SelecionarPorAcompanharVisitaLB"
        Me.SelecionarPorAcompanharVisitaLB.Size = New System.Drawing.Size(78, 13)
        Me.SelecionarPorAcompanharVisitaLB.TabIndex = 0
        Me.SelecionarPorAcompanharVisitaLB.Text = "Selecionar por:"
        '
        'ExtrairRelatoriosVendasTP
        '
        Me.ExtrairRelatoriosVendasTP.Controls.Add(Me.FimDT)
        Me.ExtrairRelatoriosVendasTP.Controls.Add(Me.InicioDT)
        Me.ExtrairRelatoriosVendasTP.Controls.Add(Me.DeLB)
        Me.ExtrairRelatoriosVendasTP.Controls.Add(Me.AteLB)
        Me.ExtrairRelatoriosVendasTP.Controls.Add(Me.GerarRelatorioVendaBT)
        Me.ExtrairRelatoriosVendasTP.Location = New System.Drawing.Point(4, 22)
        Me.ExtrairRelatoriosVendasTP.Name = "ExtrairRelatoriosVendasTP"
        Me.ExtrairRelatoriosVendasTP.Padding = New System.Windows.Forms.Padding(3)
        Me.ExtrairRelatoriosVendasTP.Size = New System.Drawing.Size(685, 335)
        Me.ExtrairRelatoriosVendasTP.TabIndex = 4
        Me.ExtrairRelatoriosVendasTP.Text = "Extrair Relatórios de Vendas"
        Me.ExtrairRelatoriosVendasTP.UseVisualStyleBackColor = True
        '
        'FimDT
        '
        Me.FimDT.CustomFormat = "dd/MM/yyyy"
        Me.FimDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FimDT.Location = New System.Drawing.Point(172, 22)
        Me.FimDT.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.FimDT.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.FimDT.Name = "FimDT"
        Me.FimDT.Size = New System.Drawing.Size(98, 20)
        Me.FimDT.TabIndex = 34
        '
        'InicioDT
        '
        Me.InicioDT.CustomFormat = "dd/MM/yyyy"
        Me.InicioDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.InicioDT.Location = New System.Drawing.Point(36, 22)
        Me.InicioDT.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.InicioDT.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.InicioDT.Name = "InicioDT"
        Me.InicioDT.Size = New System.Drawing.Size(98, 20)
        Me.InicioDT.TabIndex = 33
        '
        'DeLB
        '
        Me.DeLB.AutoSize = True
        Me.DeLB.Location = New System.Drawing.Point(6, 25)
        Me.DeLB.Name = "DeLB"
        Me.DeLB.Size = New System.Drawing.Size(24, 13)
        Me.DeLB.TabIndex = 32
        Me.DeLB.Text = "De:"
        '
        'AteLB
        '
        Me.AteLB.AutoSize = True
        Me.AteLB.Location = New System.Drawing.Point(140, 25)
        Me.AteLB.Name = "AteLB"
        Me.AteLB.Size = New System.Drawing.Size(26, 13)
        Me.AteLB.TabIndex = 31
        Me.AteLB.Text = "Até:"
        '
        'GerarRelatorioVendaBT
        '
        Me.GerarRelatorioVendaBT.Location = New System.Drawing.Point(298, 20)
        Me.GerarRelatorioVendaBT.Name = "GerarRelatorioVendaBT"
        Me.GerarRelatorioVendaBT.Size = New System.Drawing.Size(103, 23)
        Me.GerarRelatorioVendaBT.TabIndex = 30
        Me.GerarRelatorioVendaBT.Text = "Gerar Relatório"
        Me.GerarRelatorioVendaBT.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcoesToolStripMenuItem, Me.AcessosToolStripMenuItem, Me.EstoqueToolStripMenuItem, Me.FornecedoresToolStripMenuItem, Me.VendasToolStripMenuItem, Me.BalançoDeCaixaToolStripMenuItem, Me.MonitoramentoToolStripMenuItem, Me.FuncionáriosToolStripMenuItem, Me.ClientesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(729, 24)
        Me.MenuStrip1.TabIndex = 7
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NobelTheater.My.Resources.Resources.ControleDeVendasMain
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.NobelTheater.My.Resources.Resources.Adicionar
        Me.PictureBox6.Location = New System.Drawing.Point(18, 16)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(27, 20)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 17
        Me.PictureBox6.TabStop = False
        '
        'ClienteIMG
        '
        Me.ClienteIMG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClienteIMG.Image = Global.NobelTheater.My.Resources.Resources.Busca
        Me.ClienteIMG.Location = New System.Drawing.Point(619, 16)
        Me.ClienteIMG.Name = "ClienteIMG"
        Me.ClienteIMG.Size = New System.Drawing.Size(27, 20)
        Me.ClienteIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ClienteIMG.TabIndex = 16
        Me.ClienteIMG.TabStop = False
        '
        'ConfirmaProdutoIMG
        '
        Me.ConfirmaProdutoIMG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConfirmaProdutoIMG.Image = Global.NobelTheater.My.Resources.Resources.Confirmar
        Me.ConfirmaProdutoIMG.Location = New System.Drawing.Point(652, 61)
        Me.ConfirmaProdutoIMG.Name = "ConfirmaProdutoIMG"
        Me.ConfirmaProdutoIMG.Size = New System.Drawing.Size(27, 20)
        Me.ConfirmaProdutoIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ConfirmaProdutoIMG.TabIndex = 13
        Me.ConfirmaProdutoIMG.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.NobelTheater.My.Resources.Resources.Adicionar
        Me.PictureBox3.Location = New System.Drawing.Point(18, 61)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(27, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'ProdutoOrcamentoIMG
        '
        Me.ProdutoOrcamentoIMG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProdutoOrcamentoIMG.Image = Global.NobelTheater.My.Resources.Resources.Busca
        Me.ProdutoOrcamentoIMG.Location = New System.Drawing.Point(619, 61)
        Me.ProdutoOrcamentoIMG.Name = "ProdutoOrcamentoIMG"
        Me.ProdutoOrcamentoIMG.Size = New System.Drawing.Size(27, 20)
        Me.ProdutoOrcamentoIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProdutoOrcamentoIMG.TabIndex = 5
        Me.ProdutoOrcamentoIMG.TabStop = False
        '
        'ConfimarProdutoAcompanharOrcamentoIMG
        '
        Me.ConfimarProdutoAcompanharOrcamentoIMG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConfimarProdutoAcompanharOrcamentoIMG.Image = Global.NobelTheater.My.Resources.Resources.Confirmar
        Me.ConfimarProdutoAcompanharOrcamentoIMG.Location = New System.Drawing.Point(646, 66)
        Me.ConfimarProdutoAcompanharOrcamentoIMG.Name = "ConfimarProdutoAcompanharOrcamentoIMG"
        Me.ConfimarProdutoAcompanharOrcamentoIMG.Size = New System.Drawing.Size(27, 20)
        Me.ConfimarProdutoAcompanharOrcamentoIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ConfimarProdutoAcompanharOrcamentoIMG.TabIndex = 39
        Me.ConfimarProdutoAcompanharOrcamentoIMG.TabStop = False
        '
        'SelecionarProdutoAcompanharOrcamentoIMG
        '
        Me.SelecionarProdutoAcompanharOrcamentoIMG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SelecionarProdutoAcompanharOrcamentoIMG.Image = Global.NobelTheater.My.Resources.Resources.Busca
        Me.SelecionarProdutoAcompanharOrcamentoIMG.Location = New System.Drawing.Point(613, 66)
        Me.SelecionarProdutoAcompanharOrcamentoIMG.Name = "SelecionarProdutoAcompanharOrcamentoIMG"
        Me.SelecionarProdutoAcompanharOrcamentoIMG.Size = New System.Drawing.Size(27, 20)
        Me.SelecionarProdutoAcompanharOrcamentoIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SelecionarProdutoAcompanharOrcamentoIMG.TabIndex = 35
        Me.SelecionarProdutoAcompanharOrcamentoIMG.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.NobelTheater.My.Resources.Resources.Adicionar
        Me.PictureBox7.Location = New System.Drawing.Point(12, 66)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(27, 20)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 36
        Me.PictureBox7.TabStop = False
        '
        'ConfirmarProdutoAcompanharVendaIMG
        '
        Me.ConfirmarProdutoAcompanharVendaIMG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConfirmarProdutoAcompanharVendaIMG.Image = Global.NobelTheater.My.Resources.Resources.Confirmar
        Me.ConfirmarProdutoAcompanharVendaIMG.Location = New System.Drawing.Point(602, 14)
        Me.ConfirmarProdutoAcompanharVendaIMG.Name = "ConfirmarProdutoAcompanharVendaIMG"
        Me.ConfirmarProdutoAcompanharVendaIMG.Size = New System.Drawing.Size(27, 20)
        Me.ConfirmarProdutoAcompanharVendaIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ConfirmarProdutoAcompanharVendaIMG.TabIndex = 26
        Me.ConfirmarProdutoAcompanharVendaIMG.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox8.Image = Global.NobelTheater.My.Resources.Resources.Busca
        Me.PictureBox8.Location = New System.Drawing.Point(633, 77)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(27, 20)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 21
        Me.PictureBox8.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = Global.NobelTheater.My.Resources.Resources.Busca
        Me.PictureBox5.Location = New System.Drawing.Point(633, 46)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(27, 20)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 17
        Me.PictureBox5.TabStop = False
        '
        'ControleVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 519)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ControleVendas"
        Me.Text = "Controle de Vendas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ControleVendasTabControl.ResumeLayout(False)
        Me.CriarNovoOrcamentoTP.ResumeLayout(False)
        Me.CriarNovoOrcamentoTP.PerformLayout()
        CType(Me.QtdeTF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosDT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OrcamentosAndamentoTab.ResumeLayout(False)
        CType(Me.OrcamentosDT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AcompanharOrcamentoTab.ResumeLayout(False)
        Me.AcompanharOrcamentoTab.PerformLayout()
        CType(Me.QtdeProdutoAcompanharOrcamentoTF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusGB.ResumeLayout(False)
        Me.StatusGB.PerformLayout()
        CType(Me.ProdutosAcompanharOrcamentoDT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VendasAndamentoTab.ResumeLayout(False)
        CType(Me.VendasDT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AcompanharVendaTab.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PagamentosAcompanharVendaDT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.VisualizarInfoVisitaTP.ResumeLayout(False)
        Me.VisualizarInfoVisitaTP.PerformLayout()
        CType(Me.InfoVisitaTecnicaDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExtrairRelatoriosVendasTP.ResumeLayout(False)
        Me.ExtrairRelatoriosVendasTP.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfirmaProdutoIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutoOrcamentoIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfimarProdutoAcompanharOrcamentoIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelecionarProdutoAcompanharOrcamentoIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfirmarProdutoAcompanharVendaIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ControleVendasTabControl As System.Windows.Forms.TabControl
    Friend WithEvents CriarNovoOrcamentoTP As System.Windows.Forms.TabPage
    Friend WithEvents FinalizarBT As System.Windows.Forms.Button
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents ClienteIMG As System.Windows.Forms.PictureBox
    Friend WithEvents SelecionarClienteNovoOrcamentoTF As System.Windows.Forms.TextBox
    Friend WithEvents SelecionarClienteNovoOrcamentoLB As System.Windows.Forms.Label
    Friend WithEvents ConfirmaProdutoIMG As System.Windows.Forms.PictureBox
    Friend WithEvents QtdeTF As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CodigoProdutoTF As System.Windows.Forms.TextBox
    Friend WithEvents ProdutosDT As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents ProdutoOrcamentoIMG As System.Windows.Forms.PictureBox
    Friend WithEvents SelecionarProdutoNovoOrcamentoTF As System.Windows.Forms.TextBox
    Friend WithEvents SelecionarProdutoNovoOrcamentoLB As System.Windows.Forms.Label
    Friend WithEvents VendasAndamentoTab As System.Windows.Forms.TabPage
    Friend WithEvents VendasDT As System.Windows.Forms.DataGridView
    Friend WithEvents ExtrairRelatoriosVendasTP As System.Windows.Forms.TabPage
    Friend WithEvents AcompanharVendaTab As System.Windows.Forms.TabPage
    Friend WithEvents VisualizarInfoVisitaTP As System.Windows.Forms.TabPage
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
    Friend WithEvents PerfilTF As Label
    Friend WithEvents MatriculaTF As Label
    Friend WithEvents NomeTF As Label
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Quantidade As DataGridViewTextBoxColumn
    Friend WithEvents PrecoTotal As DataGridViewTextBoxColumn
    Friend WithEvents Remover As DataGridViewButtonColumn
    Friend WithEvents OrcamentosAndamentoTab As TabPage
    Friend WithEvents ClienteDocumentoVisitaMT As MaskedTextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents ClienteNomeVisitaTF As TextBox
    Friend WithEvents ClienteNomeVisitaLB As Label
    Friend WithEvents ClienteDocumentoVisitaLB As Label
    Friend WithEvents SelecionarPorAcompanharVisitaLB As Label
    Friend WithEvents FimDT As DateTimePicker
    Friend WithEvents InicioDT As DateTimePicker
    Friend WithEvents DeLB As Label
    Friend WithEvents AteLB As Label
    Friend WithEvents GerarRelatorioVendaBT As Button
    Friend WithEvents InfoVisitaTecnicaDG As DataGridView
    Friend WithEvents ClienteVisitaTecnica As DataGridViewTextBoxColumn
    Friend WithEvents DataVisita As DataGridViewTextBoxColumn
    Friend WithEvents SupervisorResponsavel As DataGridViewTextBoxColumn
    Friend WithEvents ValorDaVisita As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn2 As DataGridViewButtonColumn
    Friend WithEvents DataGridViewButtonColumn3 As DataGridViewButtonColumn
    Friend WithEvents RemoverVisita As DataGridViewButtonColumn
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents SupervisorVisitaTF As TextBox
    Friend WithEvents SupervisorVisitaLB As Label
    Friend WithEvents OrcamentosDT As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents Vendedor As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn1 As DataGridViewButtonColumn
    Friend WithEvents AcompanharOrcamentoTab As TabPage
    Friend WithEvents ClienteAcompanharOrcamentoTF As TextBox
    Friend WithEvents ProdutoAcompanharOrcamentoTF As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents QtdeProdutoAcompanharOrcamentoTF As NumericUpDown
    Friend WithEvents CodigoProdutoAcompanharOrcamentoTF As TextBox
    Friend WithEvents ConfimarProdutoAcompanharOrcamentoIMG As PictureBox
    Friend WithEvents SelecionarProdutoAcompanharOrcamentoIMG As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents StatusGB As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents StatusOrcamentoCB As ComboBox
    Friend WithEvents DataEmissaoNFCotacaoLB As Label
    Friend WithEvents NumeroNFCotacaoLB As Label
    Friend WithEvents DataEmissaoNFOrcamentoTF As TextBox
    Friend WithEvents NumeroNFOrcamentoTF As TextBox
    Friend WithEvents SalvarAcompanharOrcamentoBT As Button
    Friend WithEvents ProdutosAcompanharOrcamentoDT As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn6 As DataGridViewButtonColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents VendedorAcompanharOrcamentoTF As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CriarVisitaAcompanharVendaBT As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ConfirmarProdutoAcompanharVendaIMG As PictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TipoPagamentoCB As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents DataPagamentoTF As TextBox
    Friend WithEvents ValorPgtoTF As TextBox
    Friend WithEvents SalvarVendaBT As Button
    Friend WithEvents PagamentosAcompanharVendaDT As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn4 As DataGridViewButtonColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents VerItensAcompanharVendaBT As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents VendedorAcompanharVendaTF As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents DataAprovacaoAcompanharVendaTF As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents DataOrcamentoAcompanharVendaTF As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents StatusVendaAcompanharVendaCB As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents DataEmissaoAcompanharVendaTF As TextBox
    Friend WithEvents NumeroNFAcompanharVendaTF As TextBox
    Friend WithEvents ClienteAcompanharVendaTF As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Fornecedor As DataGridViewTextBoxColumn
    Friend WithEvents NotaFiscal As DataGridViewTextBoxColumn
    Friend WithEvents VerProd As DataGridViewButtonColumn
End Class
