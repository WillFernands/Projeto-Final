<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControleEstoque
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PerfilTF = New System.Windows.Forms.Label()
        Me.MatriculaTF = New System.Windows.Forms.Label()
        Me.NomeTF = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ControleEstoqueTab = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.FinalizarBT = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.FornecedorIMG = New System.Windows.Forms.PictureBox()
        Me.FornecedorTF = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ConfirmaProdutoIMG = New System.Windows.Forms.PictureBox()
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
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ProdutoCotacaoIMG = New System.Windows.Forms.PictureBox()
        Me.NomeProdutoTF = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.AlertasDT = New System.Windows.Forms.DataGridView()
        Me.DataAlerta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemoverAlerta = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.CriarAlertaBT = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ObservacaoTF = New System.Windows.Forms.TextBox()
        Me.ProdutoAlertaTF = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ProdutoAlertaIMG = New System.Windows.Forms.PictureBox()
        Me.CotacoesAndamentoTab = New System.Windows.Forms.TabPage()
        Me.CotacoesDT = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.AcompanharCotacaoTab = New System.Windows.Forms.TabPage()
        Me.SalvarBT = New System.Windows.Forms.Button()
        Me.StatusGB = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.StatusCotacaoCB = New System.Windows.Forms.ComboBox()
        Me.DataEmissaoNFCotacaoLB = New System.Windows.Forms.Label()
        Me.NumeroNFCotacaoLB = New System.Windows.Forms.Label()
        Me.DataEmissaoNFCotacaoTF = New System.Windows.Forms.TextBox()
        Me.NumeroNFCotacaoTF = New System.Windows.Forms.TextBox()
        Me.FornecedorAcompanharCotacaoTF = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.QtdeProdutoAcompanharCotacaoTF = New System.Windows.Forms.NumericUpDown()
        Me.CodigoProdutoAcompanharCotacaoTF = New System.Windows.Forms.TextBox()
        Me.ProdutoAcompanharCotacaoTF = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProdutosAcompanharCotacaoDT = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ConfimarProdutoAcompanharCotacaoTF = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.ComprasAndamentoTab = New System.Windows.Forms.TabPage()
        Me.ComprasDT = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotaFiscal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerProd = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.AcompanharCompraTab = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TipoPagamentoCB = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.DataPagamentoTF = New System.Windows.Forms.TextBox()
        Me.ValorPgtoTF = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PagamentosDT = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.VerItensAcompanharCompraBT = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.FornecedorAcompanharCompraTF = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DataAprovacaoAcompanharCompraTF = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DataCotacaoAcompanharCompraTF = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.StatusCompraAcompanharCompraCB = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DataEmissaoAcompanharCompraTF = New System.Windows.Forms.TextBox()
        Me.NumeroNFAcompanharCompraTF = New System.Windows.Forms.TextBox()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.FinalizarEmprestimoBT = New System.Windows.Forms.Button()
        Me.QtdeEmprestarProdutoTF = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CodigoProdutoEmprestarProdutoTF = New System.Windows.Forms.TextBox()
        Me.ProdutosEmprestimoDT = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn5 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.NomeProdutoEmprestarProdutoTF = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ClienteEmprestarProdutoTF = New System.Windows.Forms.TextBox()
        Me.ClienteEmprestimoLB = New System.Windows.Forms.Label()
        Me.ConfirmarProdutoEmprestarProdutoIMG = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BuscarProdutoEmprestarProdutoIMG = New System.Windows.Forms.PictureBox()
        Me.BuscarClienteEmprestarProdutoIMG = New System.Windows.Forms.PictureBox()
        Me.ProdutosEmprestadosTab = New System.Windows.Forms.TabPage()
        Me.BuscaAllRB = New System.Windows.Forms.RadioButton()
        Me.BuscaIDRB = New System.Windows.Forms.RadioButton()
        Me.IDEmprestimoTF = New System.Windows.Forms.TextBox()
        Me.BuscaProdutoRB = New System.Windows.Forms.RadioButton()
        Me.BuscaClienteRB = New System.Windows.Forms.RadioButton()
        Me.CodigoProdutoEmprestimoTF = New System.Windows.Forms.TextBox()
        Me.NomeProdutoEmprestimoTF = New System.Windows.Forms.TextBox()
        Me.ClienteEmprestimoTF = New System.Windows.Forms.TextBox()
        Me.ProdutosEmprestadosDT = New System.Windows.Forms.DataGridView()
        Me.IDSolicitacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusSolicitacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteProdutoEmprestado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataEmprestimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerProdutos = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.FinalizarSolicitacao = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.EnviarParaAssistenciaBT = New System.Windows.Forms.Button()
        Me.ProdutosOrdemDT = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn4 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.AssistenciaEnvioAssistenciaTF = New System.Windows.Forms.TextBox()
        Me.SelecionarAssistenciaLB = New System.Windows.Forms.Label()
        Me.SelecionarAssistenciaEnvioAssistenciaIMG = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.QtdeProdutoEnvioAssistenciaTF = New System.Windows.Forms.NumericUpDown()
        Me.CodigoProdutoEnvioAssistenciaTF = New System.Windows.Forms.TextBox()
        Me.ProdutoEnvioAssistenciaTF = New System.Windows.Forms.TextBox()
        Me.SelecionarProdutoEnvioAssistenciaLB = New System.Windows.Forms.Label()
        Me.ClienteEnvioAssistenciaTB = New System.Windows.Forms.TextBox()
        Me.SelecionarClienteEnvioAssistenciaLB = New System.Windows.Forms.Label()
        Me.ConfirmarProdutoEnvioAssistenciaIMG = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.SelecionarProdutoEnvioAssistenciaIMG = New System.Windows.Forms.PictureBox()
        Me.SelecionarClienteEnvioAssistenciaIMG = New System.Windows.Forms.PictureBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.BuscarTodosProdutosEnviadosAssistenciaRB = New System.Windows.Forms.RadioButton()
        Me.BuscarIDdeEnvioRB = New System.Windows.Forms.RadioButton()
        Me.BuscarPorIDEnvioTF = New System.Windows.Forms.TextBox()
        Me.BuscarPorProdutoRB = New System.Windows.Forms.RadioButton()
        Me.BuscarPorClienteRB = New System.Windows.Forms.RadioButton()
        Me.IDProdutoTF = New System.Windows.Forms.TextBox()
        Me.BuscarPorProdutoTF = New System.Windows.Forms.TextBox()
        Me.BuscarPorClienteTF = New System.Windows.Forms.TextBox()
        Me.ProdutosEnviadosAssistenciaDG = New System.Windows.Forms.DataGridView()
        Me.IDProdutoAssistencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusProdutoAssistencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteProdutoAssistencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDeEnvioAssistencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerProdutosAssistencia = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.FinalizarSolicitacaoEnvioAssistencia = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.FimDT = New System.Windows.Forms.DateTimePicker()
        Me.InicioDT = New System.Windows.Forms.DateTimePicker()
        Me.DeLB = New System.Windows.Forms.Label()
        Me.AteLB = New System.Windows.Forms.Label()
        Me.GerarRelatorioCompraBT = New System.Windows.Forms.Button()
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
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.ControleEstoqueTab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FornecedorIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfirmaProdutoIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtdeTF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutoCotacaoIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.AlertasDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutoAlertaIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CotacoesAndamentoTab.SuspendLayout()
        CType(Me.CotacoesDT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AcompanharCotacaoTab.SuspendLayout()
        Me.StatusGB.SuspendLayout()
        CType(Me.QtdeProdutoAcompanharCotacaoTF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosAcompanharCotacaoDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfimarProdutoAcompanharCotacaoTF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ComprasAndamentoTab.SuspendLayout()
        CType(Me.ComprasDT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AcompanharCompraTab.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagamentosDT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtdeEmprestarProdutoTF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosEmprestimoDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfirmarProdutoEmprestarProdutoIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarProdutoEmprestarProdutoIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarClienteEmprestarProdutoIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProdutosEmprestadosTab.SuspendLayout()
        CType(Me.ProdutosEmprestadosDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.ProdutosOrdemDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelecionarAssistenciaEnvioAssistenciaIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtdeProdutoEnvioAssistenciaTF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfirmarProdutoEnvioAssistenciaIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelecionarProdutoEnvioAssistenciaIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelecionarClienteEnvioAssistenciaIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.ProdutosEnviadosAssistenciaDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
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
        Me.Panel1.TabIndex = 3
        '
        'PerfilTF
        '
        Me.PerfilTF.AutoSize = True
        Me.PerfilTF.Location = New System.Drawing.Point(140, 72)
        Me.PerfilTF.Name = "PerfilTF"
        Me.PerfilTF.Size = New System.Drawing.Size(86, 13)
        Me.PerfilTF.TabIndex = 9
        Me.PerfilTF.Text = "Perfil de Acesso:"
        '
        'MatriculaTF
        '
        Me.MatriculaTF.AutoSize = True
        Me.MatriculaTF.Location = New System.Drawing.Point(140, 44)
        Me.MatriculaTF.Name = "MatriculaTF"
        Me.MatriculaTF.Size = New System.Drawing.Size(55, 13)
        Me.MatriculaTF.TabIndex = 8
        Me.MatriculaTF.Text = "Matrícula:"
        '
        'NomeTF
        '
        Me.NomeTF.AutoSize = True
        Me.NomeTF.Location = New System.Drawing.Point(140, 16)
        Me.NomeTF.Name = "NomeTF"
        Me.NomeTF.Size = New System.Drawing.Size(38, 13)
        Me.NomeTF.TabIndex = 7
        Me.NomeTF.Text = "Nome:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NobelTheater.My.Resources.Resources.ControleDeEstoqueMain
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ControleEstoqueTab)
        Me.Panel2.Location = New System.Drawing.Point(12, 131)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(705, 374)
        Me.Panel2.TabIndex = 4
        '
        'ControleEstoqueTab
        '
        Me.ControleEstoqueTab.Controls.Add(Me.TabPage1)
        Me.ControleEstoqueTab.Controls.Add(Me.TabPage2)
        Me.ControleEstoqueTab.Controls.Add(Me.CotacoesAndamentoTab)
        Me.ControleEstoqueTab.Controls.Add(Me.AcompanharCotacaoTab)
        Me.ControleEstoqueTab.Controls.Add(Me.ComprasAndamentoTab)
        Me.ControleEstoqueTab.Controls.Add(Me.AcompanharCompraTab)
        Me.ControleEstoqueTab.Controls.Add(Me.TabPage8)
        Me.ControleEstoqueTab.Controls.Add(Me.ProdutosEmprestadosTab)
        Me.ControleEstoqueTab.Controls.Add(Me.TabPage3)
        Me.ControleEstoqueTab.Controls.Add(Me.TabPage6)
        Me.ControleEstoqueTab.Controls.Add(Me.TabPage5)
        Me.ControleEstoqueTab.Location = New System.Drawing.Point(9, 10)
        Me.ControleEstoqueTab.Name = "ControleEstoqueTab"
        Me.ControleEstoqueTab.SelectedIndex = 0
        Me.ControleEstoqueTab.Size = New System.Drawing.Size(693, 361)
        Me.ControleEstoqueTab.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.FinalizarBT)
        Me.TabPage1.Controls.Add(Me.PictureBox6)
        Me.TabPage1.Controls.Add(Me.FornecedorIMG)
        Me.TabPage1.Controls.Add(Me.FornecedorTF)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.ConfirmaProdutoIMG)
        Me.TabPage1.Controls.Add(Me.QtdeTF)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.CodigoProdutoTF)
        Me.TabPage1.Controls.Add(Me.ProdutosDT)
        Me.TabPage1.Controls.Add(Me.PictureBox3)
        Me.TabPage1.Controls.Add(Me.ProdutoCotacaoIMG)
        Me.TabPage1.Controls.Add(Me.NomeProdutoTF)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(685, 335)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Criar Nova Cotação"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'FinalizarBT
        '
        Me.FinalizarBT.Location = New System.Drawing.Point(291, 306)
        Me.FinalizarBT.Name = "FinalizarBT"
        Me.FinalizarBT.Size = New System.Drawing.Size(103, 23)
        Me.FinalizarBT.TabIndex = 18
        Me.FinalizarBT.Text = "Finalizar Cotação"
        Me.FinalizarBT.UseVisualStyleBackColor = True
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
        'FornecedorIMG
        '
        Me.FornecedorIMG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FornecedorIMG.Image = Global.NobelTheater.My.Resources.Resources.Busca
        Me.FornecedorIMG.Location = New System.Drawing.Point(619, 16)
        Me.FornecedorIMG.Name = "FornecedorIMG"
        Me.FornecedorIMG.Size = New System.Drawing.Size(27, 20)
        Me.FornecedorIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FornecedorIMG.TabIndex = 16
        Me.FornecedorIMG.TabStop = False
        '
        'FornecedorTF
        '
        Me.FornecedorTF.Enabled = False
        Me.FornecedorTF.Location = New System.Drawing.Point(172, 16)
        Me.FornecedorTF.Name = "FornecedorTF"
        Me.FornecedorTF.Size = New System.Drawing.Size(443, 20)
        Me.FornecedorTF.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(49, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Selecionar Fornecedor:"
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
        'QtdeTF
        '
        Me.QtdeTF.Location = New System.Drawing.Point(573, 61)
        Me.QtdeTF.Name = "QtdeTF"
        Me.QtdeTF.Size = New System.Drawing.Size(42, 20)
        Me.QtdeTF.TabIndex = 12
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
        Me.CodigoProdutoTF.TabIndex = 9
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
        Me.ProdutosDT.TabIndex = 8
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
        'Remover
        '
        Me.Remover.HeaderText = "Remover"
        Me.Remover.Name = "Remover"
        Me.Remover.ReadOnly = True
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
        'ProdutoCotacaoIMG
        '
        Me.ProdutoCotacaoIMG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProdutoCotacaoIMG.Image = Global.NobelTheater.My.Resources.Resources.Busca
        Me.ProdutoCotacaoIMG.Location = New System.Drawing.Point(619, 61)
        Me.ProdutoCotacaoIMG.Name = "ProdutoCotacaoIMG"
        Me.ProdutoCotacaoIMG.Size = New System.Drawing.Size(27, 20)
        Me.ProdutoCotacaoIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProdutoCotacaoIMG.TabIndex = 5
        Me.ProdutoCotacaoIMG.TabStop = False
        '
        'NomeProdutoTF
        '
        Me.NomeProdutoTF.Enabled = False
        Me.NomeProdutoTF.Location = New System.Drawing.Point(172, 61)
        Me.NomeProdutoTF.Name = "NomeProdutoTF"
        Me.NomeProdutoTF.Size = New System.Drawing.Size(355, 20)
        Me.NomeProdutoTF.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Selecionar Produto:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.AlertasDT)
        Me.TabPage2.Controls.Add(Me.CriarAlertaBT)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.ObservacaoTF)
        Me.TabPage2.Controls.Add(Me.ProdutoAlertaTF)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.ProdutoAlertaIMG)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(685, 335)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Alertas de Estoque"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'AlertasDT
        '
        Me.AlertasDT.AllowUserToAddRows = False
        Me.AlertasDT.AllowUserToDeleteRows = False
        Me.AlertasDT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AlertasDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AlertasDT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataAlerta, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.RemoverAlerta})
        Me.AlertasDT.Location = New System.Drawing.Point(6, 126)
        Me.AlertasDT.Name = "AlertasDT"
        Me.AlertasDT.ReadOnly = True
        Me.AlertasDT.RowHeadersVisible = False
        Me.AlertasDT.Size = New System.Drawing.Size(673, 203)
        Me.AlertasDT.TabIndex = 20
        '
        'DataAlerta
        '
        Me.DataAlerta.HeaderText = "Data Alerta"
        Me.DataAlerta.Name = "DataAlerta"
        Me.DataAlerta.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cod Produto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nome Produto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Observação"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 250
        '
        'RemoverAlerta
        '
        Me.RemoverAlerta.HeaderText = "Remover"
        Me.RemoverAlerta.Name = "RemoverAlerta"
        Me.RemoverAlerta.ReadOnly = True
        '
        'CriarAlertaBT
        '
        Me.CriarAlertaBT.Location = New System.Drawing.Point(305, 90)
        Me.CriarAlertaBT.Name = "CriarAlertaBT"
        Me.CriarAlertaBT.Size = New System.Drawing.Size(75, 23)
        Me.CriarAlertaBT.TabIndex = 19
        Me.CriarAlertaBT.Text = "Criar Alerta"
        Me.CriarAlertaBT.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Observação:"
        '
        'ObservacaoTF
        '
        Me.ObservacaoTF.Location = New System.Drawing.Point(143, 57)
        Me.ObservacaoTF.Name = "ObservacaoTF"
        Me.ObservacaoTF.Size = New System.Drawing.Size(491, 20)
        Me.ObservacaoTF.TabIndex = 17
        '
        'ProdutoAlertaTF
        '
        Me.ProdutoAlertaTF.Enabled = False
        Me.ProdutoAlertaTF.Location = New System.Drawing.Point(143, 24)
        Me.ProdutoAlertaTF.Name = "ProdutoAlertaTF"
        Me.ProdutoAlertaTF.Size = New System.Drawing.Size(491, 20)
        Me.ProdutoAlertaTF.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Selecionar Produto:"
        '
        'ProdutoAlertaIMG
        '
        Me.ProdutoAlertaIMG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProdutoAlertaIMG.Image = Global.NobelTheater.My.Resources.Resources.Busca
        Me.ProdutoAlertaIMG.Location = New System.Drawing.Point(640, 24)
        Me.ProdutoAlertaIMG.Name = "ProdutoAlertaIMG"
        Me.ProdutoAlertaIMG.Size = New System.Drawing.Size(27, 20)
        Me.ProdutoAlertaIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProdutoAlertaIMG.TabIndex = 16
        Me.ProdutoAlertaIMG.TabStop = False
        '
        'CotacoesAndamentoTab
        '
        Me.CotacoesAndamentoTab.Controls.Add(Me.CotacoesDT)
        Me.CotacoesAndamentoTab.Location = New System.Drawing.Point(4, 22)
        Me.CotacoesAndamentoTab.Name = "CotacoesAndamentoTab"
        Me.CotacoesAndamentoTab.Padding = New System.Windows.Forms.Padding(3)
        Me.CotacoesAndamentoTab.Size = New System.Drawing.Size(685, 335)
        Me.CotacoesAndamentoTab.TabIndex = 9
        Me.CotacoesAndamentoTab.Text = "Cotacoes em Andamento"
        Me.CotacoesAndamentoTab.UseVisualStyleBackColor = True
        '
        'CotacoesDT
        '
        Me.CotacoesDT.AllowUserToAddRows = False
        Me.CotacoesDT.AllowUserToDeleteRows = False
        Me.CotacoesDT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CotacoesDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CotacoesDT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn13, Me.DataGridViewButtonColumn1})
        Me.CotacoesDT.Location = New System.Drawing.Point(6, 6)
        Me.CotacoesDT.Name = "CotacoesDT"
        Me.CotacoesDT.ReadOnly = True
        Me.CotacoesDT.RowHeadersVisible = False
        Me.CotacoesDT.Size = New System.Drawing.Size(673, 323)
        Me.CotacoesDT.TabIndex = 22
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 50
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Data da Cotação"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 75
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Status da Cotação"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Fornecedor"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 300
        '
        'DataGridViewButtonColumn1
        '
        Me.DataGridViewButtonColumn1.HeaderText = "Ver Produtos"
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.ReadOnly = True
        '
        'AcompanharCotacaoTab
        '
        Me.AcompanharCotacaoTab.Controls.Add(Me.SalvarBT)
        Me.AcompanharCotacaoTab.Controls.Add(Me.StatusGB)
        Me.AcompanharCotacaoTab.Controls.Add(Me.FornecedorAcompanharCotacaoTF)
        Me.AcompanharCotacaoTab.Controls.Add(Me.Label3)
        Me.AcompanharCotacaoTab.Controls.Add(Me.QtdeProdutoAcompanharCotacaoTF)
        Me.AcompanharCotacaoTab.Controls.Add(Me.CodigoProdutoAcompanharCotacaoTF)
        Me.AcompanharCotacaoTab.Controls.Add(Me.ProdutoAcompanharCotacaoTF)
        Me.AcompanharCotacaoTab.Controls.Add(Me.Label4)
        Me.AcompanharCotacaoTab.Controls.Add(Me.ProdutosAcompanharCotacaoDT)
        Me.AcompanharCotacaoTab.Controls.Add(Me.ConfimarProdutoAcompanharCotacaoTF)
        Me.AcompanharCotacaoTab.Controls.Add(Me.PictureBox7)
        Me.AcompanharCotacaoTab.Controls.Add(Me.PictureBox8)
        Me.AcompanharCotacaoTab.Location = New System.Drawing.Point(4, 22)
        Me.AcompanharCotacaoTab.Name = "AcompanharCotacaoTab"
        Me.AcompanharCotacaoTab.Size = New System.Drawing.Size(685, 335)
        Me.AcompanharCotacaoTab.TabIndex = 10
        Me.AcompanharCotacaoTab.Text = "Acompanhar Cotação"
        Me.AcompanharCotacaoTab.UseVisualStyleBackColor = True
        '
        'SalvarBT
        '
        Me.SalvarBT.Location = New System.Drawing.Point(300, 300)
        Me.SalvarBT.Name = "SalvarBT"
        Me.SalvarBT.Size = New System.Drawing.Size(103, 23)
        Me.SalvarBT.TabIndex = 31
        Me.SalvarBT.Text = "Salvar Alterações"
        Me.SalvarBT.UseVisualStyleBackColor = True
        '
        'StatusGB
        '
        Me.StatusGB.Controls.Add(Me.Label11)
        Me.StatusGB.Controls.Add(Me.StatusCotacaoCB)
        Me.StatusGB.Controls.Add(Me.DataEmissaoNFCotacaoLB)
        Me.StatusGB.Controls.Add(Me.NumeroNFCotacaoLB)
        Me.StatusGB.Controls.Add(Me.DataEmissaoNFCotacaoTF)
        Me.StatusGB.Controls.Add(Me.NumeroNFCotacaoTF)
        Me.StatusGB.Location = New System.Drawing.Point(12, 94)
        Me.StatusGB.Name = "StatusGB"
        Me.StatusGB.Size = New System.Drawing.Size(661, 38)
        Me.StatusGB.TabIndex = 30
        Me.StatusGB.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Status Cotação:"
        '
        'StatusCotacaoCB
        '
        Me.StatusCotacaoCB.FormattingEnabled = True
        Me.StatusCotacaoCB.Location = New System.Drawing.Point(95, 12)
        Me.StatusCotacaoCB.Name = "StatusCotacaoCB"
        Me.StatusCotacaoCB.Size = New System.Drawing.Size(165, 21)
        Me.StatusCotacaoCB.TabIndex = 4
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
        'DataEmissaoNFCotacaoTF
        '
        Me.DataEmissaoNFCotacaoTF.Location = New System.Drawing.Point(555, 12)
        Me.DataEmissaoNFCotacaoTF.Name = "DataEmissaoNFCotacaoTF"
        Me.DataEmissaoNFCotacaoTF.Size = New System.Drawing.Size(100, 20)
        Me.DataEmissaoNFCotacaoTF.TabIndex = 1
        '
        'NumeroNFCotacaoTF
        '
        Me.NumeroNFCotacaoTF.Location = New System.Drawing.Point(349, 12)
        Me.NumeroNFCotacaoTF.Name = "NumeroNFCotacaoTF"
        Me.NumeroNFCotacaoTF.Size = New System.Drawing.Size(100, 20)
        Me.NumeroNFCotacaoTF.TabIndex = 0
        '
        'FornecedorAcompanharCotacaoTF
        '
        Me.FornecedorAcompanharCotacaoTF.Enabled = False
        Me.FornecedorAcompanharCotacaoTF.Location = New System.Drawing.Point(166, 17)
        Me.FornecedorAcompanharCotacaoTF.Name = "FornecedorAcompanharCotacaoTF"
        Me.FornecedorAcompanharCotacaoTF.Size = New System.Drawing.Size(443, 20)
        Me.FornecedorAcompanharCotacaoTF.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Selecionar Fornecedor:"
        '
        'QtdeProdutoAcompanharCotacaoTF
        '
        Me.QtdeProdutoAcompanharCotacaoTF.Location = New System.Drawing.Point(567, 62)
        Me.QtdeProdutoAcompanharCotacaoTF.Name = "QtdeProdutoAcompanharCotacaoTF"
        Me.QtdeProdutoAcompanharCotacaoTF.Size = New System.Drawing.Size(42, 20)
        Me.QtdeProdutoAcompanharCotacaoTF.TabIndex = 24
        Me.QtdeProdutoAcompanharCotacaoTF.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CodigoProdutoAcompanharCotacaoTF
        '
        Me.CodigoProdutoAcompanharCotacaoTF.Enabled = False
        Me.CodigoProdutoAcompanharCotacaoTF.Location = New System.Drawing.Point(525, 62)
        Me.CodigoProdutoAcompanharCotacaoTF.Name = "CodigoProdutoAcompanharCotacaoTF"
        Me.CodigoProdutoAcompanharCotacaoTF.Size = New System.Drawing.Size(37, 20)
        Me.CodigoProdutoAcompanharCotacaoTF.TabIndex = 23
        '
        'ProdutoAcompanharCotacaoTF
        '
        Me.ProdutoAcompanharCotacaoTF.Enabled = False
        Me.ProdutoAcompanharCotacaoTF.Location = New System.Drawing.Point(166, 62)
        Me.ProdutoAcompanharCotacaoTF.Name = "ProdutoAcompanharCotacaoTF"
        Me.ProdutoAcompanharCotacaoTF.Size = New System.Drawing.Size(355, 20)
        Me.ProdutoAcompanharCotacaoTF.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Selecionar Produto:"
        '
        'ProdutosAcompanharCotacaoDT
        '
        Me.ProdutosAcompanharCotacaoDT.AllowUserToAddRows = False
        Me.ProdutosAcompanharCotacaoDT.AllowUserToDeleteRows = False
        Me.ProdutosAcompanharCotacaoDT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProdutosAcompanharCotacaoDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProdutosAcompanharCotacaoDT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewButtonColumn2})
        Me.ProdutosAcompanharCotacaoDT.Location = New System.Drawing.Point(12, 142)
        Me.ProdutosAcompanharCotacaoDT.Name = "ProdutosAcompanharCotacaoDT"
        Me.ProdutosAcompanharCotacaoDT.ReadOnly = True
        Me.ProdutosAcompanharCotacaoDT.RowHeadersVisible = False
        Me.ProdutosAcompanharCotacaoDT.Size = New System.Drawing.Size(661, 142)
        Me.ProdutosAcompanharCotacaoDT.TabIndex = 18
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 50
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 250
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Preço Unit"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 90
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Qtde"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 50
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "Preço Total"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewButtonColumn2
        '
        Me.DataGridViewButtonColumn2.HeaderText = "Remover"
        Me.DataGridViewButtonColumn2.Name = "DataGridViewButtonColumn2"
        Me.DataGridViewButtonColumn2.ReadOnly = True
        '
        'ConfimarProdutoAcompanharCotacaoTF
        '
        Me.ConfimarProdutoAcompanharCotacaoTF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConfimarProdutoAcompanharCotacaoTF.Image = Global.NobelTheater.My.Resources.Resources.Confirmar
        Me.ConfimarProdutoAcompanharCotacaoTF.Location = New System.Drawing.Point(646, 62)
        Me.ConfimarProdutoAcompanharCotacaoTF.Name = "ConfimarProdutoAcompanharCotacaoTF"
        Me.ConfimarProdutoAcompanharCotacaoTF.Size = New System.Drawing.Size(27, 20)
        Me.ConfimarProdutoAcompanharCotacaoTF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ConfimarProdutoAcompanharCotacaoTF.TabIndex = 25
        Me.ConfimarProdutoAcompanharCotacaoTF.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.NobelTheater.My.Resources.Resources.Adicionar
        Me.PictureBox7.Location = New System.Drawing.Point(12, 62)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(27, 20)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 22
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox8.Image = Global.NobelTheater.My.Resources.Resources.Busca
        Me.PictureBox8.Location = New System.Drawing.Point(613, 62)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(27, 20)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 21
        Me.PictureBox8.TabStop = False
        '
        'ComprasAndamentoTab
        '
        Me.ComprasAndamentoTab.Controls.Add(Me.ComprasDT)
        Me.ComprasAndamentoTab.Location = New System.Drawing.Point(4, 22)
        Me.ComprasAndamentoTab.Name = "ComprasAndamentoTab"
        Me.ComprasAndamentoTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ComprasAndamentoTab.Size = New System.Drawing.Size(685, 335)
        Me.ComprasAndamentoTab.TabIndex = 2
        Me.ComprasAndamentoTab.Text = "Compras em Andamento"
        Me.ComprasAndamentoTab.UseVisualStyleBackColor = True
        '
        'ComprasDT
        '
        Me.ComprasDT.AllowUserToAddRows = False
        Me.ComprasDT.AllowUserToDeleteRows = False
        Me.ComprasDT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ComprasDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ComprasDT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.Fornecedor, Me.NotaFiscal, Me.VerProd})
        Me.ComprasDT.Location = New System.Drawing.Point(6, 6)
        Me.ComprasDT.Name = "ComprasDT"
        Me.ComprasDT.ReadOnly = True
        Me.ComprasDT.RowHeadersVisible = False
        Me.ComprasDT.Size = New System.Drawing.Size(673, 323)
        Me.ComprasDT.TabIndex = 21
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
        Me.DataGridViewTextBoxColumn6.HeaderText = "Data da Cotação"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Status da Compra"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Data Aprovação"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'Fornecedor
        '
        Me.Fornecedor.HeaderText = "Fornecedor"
        Me.Fornecedor.Name = "Fornecedor"
        Me.Fornecedor.ReadOnly = True
        Me.Fornecedor.Width = 75
        '
        'NotaFiscal
        '
        Me.NotaFiscal.HeaderText = "Nota Fiscal"
        Me.NotaFiscal.Name = "NotaFiscal"
        Me.NotaFiscal.ReadOnly = True
        '
        'VerProd
        '
        Me.VerProd.HeaderText = "Ver Produtos"
        Me.VerProd.Name = "VerProd"
        Me.VerProd.ReadOnly = True
        '
        'AcompanharCompraTab
        '
        Me.AcompanharCompraTab.Controls.Add(Me.GroupBox2)
        Me.AcompanharCompraTab.Controls.Add(Me.Button1)
        Me.AcompanharCompraTab.Controls.Add(Me.PagamentosDT)
        Me.AcompanharCompraTab.Controls.Add(Me.GroupBox1)
        Me.AcompanharCompraTab.Location = New System.Drawing.Point(4, 22)
        Me.AcompanharCompraTab.Name = "AcompanharCompraTab"
        Me.AcompanharCompraTab.Padding = New System.Windows.Forms.Padding(3)
        Me.AcompanharCompraTab.Size = New System.Drawing.Size(685, 335)
        Me.AcompanharCompraTab.TabIndex = 6
        Me.AcompanharCompraTab.Text = "Acompanhar Compra"
        Me.AcompanharCompraTab.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.TipoPagamentoCB)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.DataPagamentoTF)
        Me.GroupBox2.Controls.Add(Me.ValorPgtoTF)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(661, 38)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.NobelTheater.My.Resources.Resources.Confirmar
        Me.PictureBox2.Location = New System.Drawing.Point(602, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(300, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 23)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Salvar Alterações"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PagamentosDT
        '
        Me.PagamentosDT.AllowUserToAddRows = False
        Me.PagamentosDT.AllowUserToDeleteRows = False
        Me.PagamentosDT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PagamentosDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PagamentosDT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewButtonColumn3})
        Me.PagamentosDT.Location = New System.Drawing.Point(12, 179)
        Me.PagamentosDT.Name = "PagamentosDT"
        Me.PagamentosDT.ReadOnly = True
        Me.PagamentosDT.RowHeadersVisible = False
        Me.PagamentosDT.Size = New System.Drawing.Size(661, 112)
        Me.PagamentosDT.TabIndex = 32
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 50
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 250
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 90
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
        'DataGridViewButtonColumn3
        '
        Me.DataGridViewButtonColumn3.HeaderText = "Remover"
        Me.DataGridViewButtonColumn3.Name = "DataGridViewButtonColumn3"
        Me.DataGridViewButtonColumn3.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.VerItensAcompanharCompraBT)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.FornecedorAcompanharCompraTF)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.DataAprovacaoAcompanharCompraTF)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.DataCotacaoAcompanharCompraTF)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.StatusCompraAcompanharCompraCB)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.DataEmissaoAcompanharCompraTF)
        Me.GroupBox1.Controls.Add(Me.NumeroNFAcompanharCompraTF)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(661, 115)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'VerItensAcompanharCompraBT
        '
        Me.VerItensAcompanharCompraBT.Location = New System.Drawing.Point(460, 80)
        Me.VerItensAcompanharCompraBT.Name = "VerItensAcompanharCompraBT"
        Me.VerItensAcompanharCompraBT.Size = New System.Drawing.Size(195, 23)
        Me.VerItensAcompanharCompraBT.TabIndex = 44
        Me.VerItensAcompanharCompraBT.Text = "Ver Itens da Compra"
        Me.VerItensAcompanharCompraBT.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 83)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(103, 13)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Data de Aprovação:"
        '
        'FornecedorAcompanharCompraTF
        '
        Me.FornecedorAcompanharCompraTF.Enabled = False
        Me.FornecedorAcompanharCompraTF.Location = New System.Drawing.Point(118, 19)
        Me.FornecedorAcompanharCompraTF.Name = "FornecedorAcompanharCompraTF"
        Me.FornecedorAcompanharCompraTF.Size = New System.Drawing.Size(537, 20)
        Me.FornecedorAcompanharCompraTF.TabIndex = 41
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 13)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Fornecedor:"
        '
        'DataAprovacaoAcompanharCompraTF
        '
        Me.DataAprovacaoAcompanharCompraTF.Enabled = False
        Me.DataAprovacaoAcompanharCompraTF.Location = New System.Drawing.Point(118, 80)
        Me.DataAprovacaoAcompanharCompraTF.Name = "DataAprovacaoAcompanharCompraTF"
        Me.DataAprovacaoAcompanharCompraTF.Size = New System.Drawing.Size(100, 20)
        Me.DataAprovacaoAcompanharCompraTF.TabIndex = 8
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 54)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 13)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Data da Cotação:"
        '
        'DataCotacaoAcompanharCompraTF
        '
        Me.DataCotacaoAcompanharCompraTF.Enabled = False
        Me.DataCotacaoAcompanharCompraTF.Location = New System.Drawing.Point(118, 51)
        Me.DataCotacaoAcompanharCompraTF.Name = "DataCotacaoAcompanharCompraTF"
        Me.DataCotacaoAcompanharCompraTF.Size = New System.Drawing.Size(100, 20)
        Me.DataCotacaoAcompanharCompraTF.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(235, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Status Compra:"
        '
        'StatusCompraAcompanharCompraCB
        '
        Me.StatusCompraAcompanharCompraCB.FormattingEnabled = True
        Me.StatusCompraAcompanharCompraCB.Location = New System.Drawing.Point(320, 80)
        Me.StatusCompraAcompanharCompraCB.Name = "StatusCompraAcompanharCompraCB"
        Me.StatusCompraAcompanharCompraCB.Size = New System.Drawing.Size(123, 21)
        Me.StatusCompraAcompanharCompraCB.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(457, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Data Emissão NF:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(235, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Número NF:"
        '
        'DataEmissaoAcompanharCompraTF
        '
        Me.DataEmissaoAcompanharCompraTF.Location = New System.Drawing.Point(555, 51)
        Me.DataEmissaoAcompanharCompraTF.Name = "DataEmissaoAcompanharCompraTF"
        Me.DataEmissaoAcompanharCompraTF.Size = New System.Drawing.Size(100, 20)
        Me.DataEmissaoAcompanharCompraTF.TabIndex = 1
        '
        'NumeroNFAcompanharCompraTF
        '
        Me.NumeroNFAcompanharCompraTF.Location = New System.Drawing.Point(320, 51)
        Me.NumeroNFAcompanharCompraTF.Name = "NumeroNFAcompanharCompraTF"
        Me.NumeroNFAcompanharCompraTF.Size = New System.Drawing.Size(123, 20)
        Me.NumeroNFAcompanharCompraTF.TabIndex = 0
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.PictureBox13)
        Me.TabPage8.Controls.Add(Me.FinalizarEmprestimoBT)
        Me.TabPage8.Controls.Add(Me.QtdeEmprestarProdutoTF)
        Me.TabPage8.Controls.Add(Me.Label5)
        Me.TabPage8.Controls.Add(Me.Label10)
        Me.TabPage8.Controls.Add(Me.CodigoProdutoEmprestarProdutoTF)
        Me.TabPage8.Controls.Add(Me.ProdutosEmprestimoDT)
        Me.TabPage8.Controls.Add(Me.NomeProdutoEmprestarProdutoTF)
        Me.TabPage8.Controls.Add(Me.Label14)
        Me.TabPage8.Controls.Add(Me.ClienteEmprestarProdutoTF)
        Me.TabPage8.Controls.Add(Me.ClienteEmprestimoLB)
        Me.TabPage8.Controls.Add(Me.ConfirmarProdutoEmprestarProdutoIMG)
        Me.TabPage8.Controls.Add(Me.PictureBox4)
        Me.TabPage8.Controls.Add(Me.BuscarProdutoEmprestarProdutoIMG)
        Me.TabPage8.Controls.Add(Me.BuscarClienteEmprestarProdutoIMG)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(685, 335)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "Emprestar Produto"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = Global.NobelTheater.My.Resources.Resources.Adicionar
        Me.PictureBox13.Location = New System.Drawing.Point(9, 19)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(27, 20)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 44
        Me.PictureBox13.TabStop = False
        '
        'FinalizarEmprestimoBT
        '
        Me.FinalizarEmprestimoBT.Location = New System.Drawing.Point(284, 307)
        Me.FinalizarEmprestimoBT.Name = "FinalizarEmprestimoBT"
        Me.FinalizarEmprestimoBT.Size = New System.Drawing.Size(116, 23)
        Me.FinalizarEmprestimoBT.TabIndex = 43
        Me.FinalizarEmprestimoBT.Text = "Finalizar Empréstimo"
        Me.FinalizarEmprestimoBT.UseVisualStyleBackColor = True
        '
        'QtdeEmprestarProdutoTF
        '
        Me.QtdeEmprestarProdutoTF.Location = New System.Drawing.Point(564, 64)
        Me.QtdeEmprestarProdutoTF.Name = "QtdeEmprestarProdutoTF"
        Me.QtdeEmprestarProdutoTF.Size = New System.Drawing.Size(42, 20)
        Me.QtdeEmprestarProdutoTF.TabIndex = 41
        Me.QtdeEmprestarProdutoTF.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(568, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Qtde"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(527, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Cod"
        '
        'CodigoProdutoEmprestarProdutoTF
        '
        Me.CodigoProdutoEmprestarProdutoTF.Enabled = False
        Me.CodigoProdutoEmprestarProdutoTF.Location = New System.Drawing.Point(522, 64)
        Me.CodigoProdutoEmprestarProdutoTF.Name = "CodigoProdutoEmprestarProdutoTF"
        Me.CodigoProdutoEmprestarProdutoTF.Size = New System.Drawing.Size(37, 20)
        Me.CodigoProdutoEmprestarProdutoTF.TabIndex = 38
        '
        'ProdutosEmprestimoDT
        '
        Me.ProdutosEmprestimoDT.AllowUserToAddRows = False
        Me.ProdutosEmprestimoDT.AllowUserToDeleteRows = False
        Me.ProdutosEmprestimoDT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProdutosEmprestimoDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProdutosEmprestimoDT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn26, Me.DataGridViewButtonColumn5})
        Me.ProdutosEmprestimoDT.Location = New System.Drawing.Point(9, 91)
        Me.ProdutosEmprestimoDT.Name = "ProdutosEmprestimoDT"
        Me.ProdutosEmprestimoDT.ReadOnly = True
        Me.ProdutosEmprestimoDT.RowHeadersVisible = False
        Me.ProdutosEmprestimoDT.Size = New System.Drawing.Size(661, 209)
        Me.ProdutosEmprestimoDT.TabIndex = 37
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 50
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Width = 450
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.HeaderText = "Qtde"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Width = 50
        '
        'DataGridViewButtonColumn5
        '
        Me.DataGridViewButtonColumn5.HeaderText = "Remover"
        Me.DataGridViewButtonColumn5.Name = "DataGridViewButtonColumn5"
        Me.DataGridViewButtonColumn5.ReadOnly = True
        '
        'NomeProdutoEmprestarProdutoTF
        '
        Me.NomeProdutoEmprestarProdutoTF.Enabled = False
        Me.NomeProdutoEmprestarProdutoTF.Location = New System.Drawing.Point(163, 64)
        Me.NomeProdutoEmprestarProdutoTF.Name = "NomeProdutoEmprestarProdutoTF"
        Me.NomeProdutoEmprestarProdutoTF.Size = New System.Drawing.Size(355, 20)
        Me.NomeProdutoEmprestarProdutoTF.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(40, 67)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Selecionar Produto:"
        '
        'ClienteEmprestarProdutoTF
        '
        Me.ClienteEmprestarProdutoTF.Enabled = False
        Me.ClienteEmprestarProdutoTF.Location = New System.Drawing.Point(163, 22)
        Me.ClienteEmprestarProdutoTF.Name = "ClienteEmprestarProdutoTF"
        Me.ClienteEmprestarProdutoTF.Size = New System.Drawing.Size(441, 20)
        Me.ClienteEmprestarProdutoTF.TabIndex = 10
        '
        'ClienteEmprestimoLB
        '
        Me.ClienteEmprestimoLB.AutoSize = True
        Me.ClienteEmprestimoLB.Location = New System.Drawing.Point(40, 22)
        Me.ClienteEmprestimoLB.Name = "ClienteEmprestimoLB"
        Me.ClienteEmprestimoLB.Size = New System.Drawing.Size(95, 13)
        Me.ClienteEmprestimoLB.TabIndex = 3
        Me.ClienteEmprestimoLB.Text = "Selecionar Cliente:"
        '
        'ConfirmarProdutoEmprestarProdutoIMG
        '
        Me.ConfirmarProdutoEmprestarProdutoIMG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConfirmarProdutoEmprestarProdutoIMG.Image = Global.NobelTheater.My.Resources.Resources.Confirmar
        Me.ConfirmarProdutoEmprestarProdutoIMG.Location = New System.Drawing.Point(643, 64)
        Me.ConfirmarProdutoEmprestarProdutoIMG.Name = "ConfirmarProdutoEmprestarProdutoIMG"
        Me.ConfirmarProdutoEmprestarProdutoIMG.Size = New System.Drawing.Size(27, 20)
        Me.ConfirmarProdutoEmprestarProdutoIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ConfirmarProdutoEmprestarProdutoIMG.TabIndex = 42
        Me.ConfirmarProdutoEmprestarProdutoIMG.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.NobelTheater.My.Resources.Resources.Adicionar
        Me.PictureBox4.Location = New System.Drawing.Point(9, 64)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(27, 20)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 36
        Me.PictureBox4.TabStop = False
        '
        'BuscarProdutoEmprestarProdutoIMG
        '
        Me.BuscarProdutoEmprestarProdutoIMG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BuscarProdutoEmprestarProdutoIMG.Image = Global.NobelTheater.My.Resources.Resources.Busca
        Me.BuscarProdutoEmprestarProdutoIMG.Location = New System.Drawing.Point(610, 64)
        Me.BuscarProdutoEmprestarProdutoIMG.Name = "BuscarProdutoEmprestarProdutoIMG"
        Me.BuscarProdutoEmprestarProdutoIMG.Size = New System.Drawing.Size(27, 20)
        Me.BuscarProdutoEmprestarProdutoIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BuscarProdutoEmprestarProdutoIMG.TabIndex = 35
        Me.BuscarProdutoEmprestarProdutoIMG.TabStop = False
        '
        'BuscarClienteEmprestarProdutoIMG
        '
        Me.BuscarClienteEmprestarProdutoIMG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BuscarClienteEmprestarProdutoIMG.Image = Global.NobelTheater.My.Resources.Resources.Busca
        Me.BuscarClienteEmprestarProdutoIMG.Location = New System.Drawing.Point(610, 22)
        Me.BuscarClienteEmprestarProdutoIMG.Name = "BuscarClienteEmprestarProdutoIMG"
        Me.BuscarClienteEmprestarProdutoIMG.Size = New System.Drawing.Size(27, 20)
        Me.BuscarClienteEmprestarProdutoIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BuscarClienteEmprestarProdutoIMG.TabIndex = 30
        Me.BuscarClienteEmprestarProdutoIMG.TabStop = False
        '
        'ProdutosEmprestadosTab
        '
        Me.ProdutosEmprestadosTab.Controls.Add(Me.BuscaAllRB)
        Me.ProdutosEmprestadosTab.Controls.Add(Me.BuscaIDRB)
        Me.ProdutosEmprestadosTab.Controls.Add(Me.IDEmprestimoTF)
        Me.ProdutosEmprestadosTab.Controls.Add(Me.BuscaProdutoRB)
        Me.ProdutosEmprestadosTab.Controls.Add(Me.BuscaClienteRB)
        Me.ProdutosEmprestadosTab.Controls.Add(Me.CodigoProdutoEmprestimoTF)
        Me.ProdutosEmprestadosTab.Controls.Add(Me.NomeProdutoEmprestimoTF)
        Me.ProdutosEmprestadosTab.Controls.Add(Me.ClienteEmprestimoTF)
        Me.ProdutosEmprestadosTab.Controls.Add(Me.ProdutosEmprestadosDT)
        Me.ProdutosEmprestadosTab.Controls.Add(Me.PictureBox14)
        Me.ProdutosEmprestadosTab.Controls.Add(Me.PictureBox15)
        Me.ProdutosEmprestadosTab.Location = New System.Drawing.Point(4, 22)
        Me.ProdutosEmprestadosTab.Name = "ProdutosEmprestadosTab"
        Me.ProdutosEmprestadosTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ProdutosEmprestadosTab.Size = New System.Drawing.Size(685, 335)
        Me.ProdutosEmprestadosTab.TabIndex = 3
        Me.ProdutosEmprestadosTab.Text = "Produtos Emprestados"
        Me.ProdutosEmprestadosTab.UseVisualStyleBackColor = True
        '
        'BuscaAllRB
        '
        Me.BuscaAllRB.AutoSize = True
        Me.BuscaAllRB.Location = New System.Drawing.Point(463, 10)
        Me.BuscaAllRB.Name = "BuscaAllRB"
        Me.BuscaAllRB.Size = New System.Drawing.Size(209, 17)
        Me.BuscaAllRB.TabIndex = 51
        Me.BuscaAllRB.Text = "Buscar todas as solicitações em aberto"
        Me.BuscaAllRB.UseVisualStyleBackColor = True
        '
        'BuscaIDRB
        '
        Me.BuscaIDRB.AutoSize = True
        Me.BuscaIDRB.Location = New System.Drawing.Point(15, 10)
        Me.BuscaIDRB.Name = "BuscaIDRB"
        Me.BuscaIDRB.Size = New System.Drawing.Size(161, 17)
        Me.BuscaIDRB.TabIndex = 50
        Me.BuscaIDRB.Text = "Busca por ID de empréstimo:"
        Me.BuscaIDRB.UseVisualStyleBackColor = True
        '
        'IDEmprestimoTF
        '
        Me.IDEmprestimoTF.Location = New System.Drawing.Point(197, 9)
        Me.IDEmprestimoTF.Name = "IDEmprestimoTF"
        Me.IDEmprestimoTF.Size = New System.Drawing.Size(67, 20)
        Me.IDEmprestimoTF.TabIndex = 48
        '
        'BuscaProdutoRB
        '
        Me.BuscaProdutoRB.AutoSize = True
        Me.BuscaProdutoRB.Location = New System.Drawing.Point(15, 84)
        Me.BuscaProdutoRB.Name = "BuscaProdutoRB"
        Me.BuscaProdutoRB.Size = New System.Drawing.Size(115, 17)
        Me.BuscaProdutoRB.TabIndex = 47
        Me.BuscaProdutoRB.Text = "Busca por produto:"
        Me.BuscaProdutoRB.UseVisualStyleBackColor = True
        '
        'BuscaClienteRB
        '
        Me.BuscaClienteRB.AutoSize = True
        Me.BuscaClienteRB.Location = New System.Drawing.Point(15, 47)
        Me.BuscaClienteRB.Name = "BuscaClienteRB"
        Me.BuscaClienteRB.Size = New System.Drawing.Size(110, 17)
        Me.BuscaClienteRB.TabIndex = 46
        Me.BuscaClienteRB.Text = "Busca por cliente:"
        Me.BuscaClienteRB.UseVisualStyleBackColor = True
        '
        'CodigoProdutoEmprestimoTF
        '
        Me.CodigoProdutoEmprestimoTF.Enabled = False
        Me.CodigoProdutoEmprestimoTF.Location = New System.Drawing.Point(601, 85)
        Me.CodigoProdutoEmprestimoTF.Name = "CodigoProdutoEmprestimoTF"
        Me.CodigoProdutoEmprestimoTF.Size = New System.Drawing.Size(37, 20)
        Me.CodigoProdutoEmprestimoTF.TabIndex = 45
        '
        'NomeProdutoEmprestimoTF
        '
        Me.NomeProdutoEmprestimoTF.Enabled = False
        Me.NomeProdutoEmprestimoTF.Location = New System.Drawing.Point(197, 85)
        Me.NomeProdutoEmprestimoTF.Name = "NomeProdutoEmprestimoTF"
        Me.NomeProdutoEmprestimoTF.Size = New System.Drawing.Size(398, 20)
        Me.NomeProdutoEmprestimoTF.TabIndex = 43
        '
        'ClienteEmprestimoTF
        '
        Me.ClienteEmprestimoTF.Enabled = False
        Me.ClienteEmprestimoTF.Location = New System.Drawing.Point(197, 47)
        Me.ClienteEmprestimoTF.Name = "ClienteEmprestimoTF"
        Me.ClienteEmprestimoTF.Size = New System.Drawing.Size(441, 20)
        Me.ClienteEmprestimoTF.TabIndex = 40
        '
        'ProdutosEmprestadosDT
        '
        Me.ProdutosEmprestadosDT.AllowUserToAddRows = False
        Me.ProdutosEmprestadosDT.AllowUserToDeleteRows = False
        Me.ProdutosEmprestadosDT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProdutosEmprestadosDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProdutosEmprestadosDT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDSolicitacao, Me.StatusSolicitacao, Me.ClienteProdutoEmprestado, Me.DataEmprestimo, Me.VerProdutos, Me.FinalizarSolicitacao})
        Me.ProdutosEmprestadosDT.Location = New System.Drawing.Point(11, 115)
        Me.ProdutosEmprestadosDT.Name = "ProdutosEmprestadosDT"
        Me.ProdutosEmprestadosDT.ReadOnly = True
        Me.ProdutosEmprestadosDT.RowHeadersVisible = False
        Me.ProdutosEmprestadosDT.Size = New System.Drawing.Size(661, 209)
        Me.ProdutosEmprestadosDT.TabIndex = 22
        '
        'IDSolicitacao
        '
        Me.IDSolicitacao.HeaderText = "ID"
        Me.IDSolicitacao.Name = "IDSolicitacao"
        Me.IDSolicitacao.ReadOnly = True
        Me.IDSolicitacao.Width = 50
        '
        'StatusSolicitacao
        '
        Me.StatusSolicitacao.HeaderText = "Status"
        Me.StatusSolicitacao.Name = "StatusSolicitacao"
        Me.StatusSolicitacao.ReadOnly = True
        Me.StatusSolicitacao.Width = 75
        '
        'ClienteProdutoEmprestado
        '
        Me.ClienteProdutoEmprestado.HeaderText = "Cliente"
        Me.ClienteProdutoEmprestado.Name = "ClienteProdutoEmprestado"
        Me.ClienteProdutoEmprestado.ReadOnly = True
        Me.ClienteProdutoEmprestado.Width = 150
        '
        'DataEmprestimo
        '
        Me.DataEmprestimo.HeaderText = "Data da Solicitação"
        Me.DataEmprestimo.Name = "DataEmprestimo"
        Me.DataEmprestimo.ReadOnly = True
        Me.DataEmprestimo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataEmprestimo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataEmprestimo.Width = 150
        '
        'VerProdutos
        '
        Me.VerProdutos.HeaderText = "Ver Produtos"
        Me.VerProdutos.Name = "VerProdutos"
        Me.VerProdutos.ReadOnly = True
        '
        'FinalizarSolicitacao
        '
        Me.FinalizarSolicitacao.HeaderText = "Finalizar Solicitação"
        Me.FinalizarSolicitacao.Name = "FinalizarSolicitacao"
        Me.FinalizarSolicitacao.ReadOnly = True
        Me.FinalizarSolicitacao.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FinalizarSolicitacao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FinalizarSolicitacao.Width = 125
        '
        'PictureBox14
        '
        Me.PictureBox14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox14.Image = Global.NobelTheater.My.Resources.Resources.Busca
        Me.PictureBox14.Location = New System.Drawing.Point(644, 85)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(27, 20)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox14.TabIndex = 44
        Me.PictureBox14.TabStop = False
        '
        'PictureBox15
        '
        Me.PictureBox15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox15.Image = Global.NobelTheater.My.Resources.Resources.Busca
        Me.PictureBox15.Location = New System.Drawing.Point(644, 47)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(27, 20)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox15.TabIndex = 41
        Me.PictureBox15.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.EnviarParaAssistenciaBT)
        Me.TabPage3.Controls.Add(Me.ProdutosOrdemDT)
        Me.TabPage3.Controls.Add(Me.PictureBox18)
        Me.TabPage3.Controls.Add(Me.AssistenciaEnvioAssistenciaTF)
        Me.TabPage3.Controls.Add(Me.SelecionarAssistenciaLB)
        Me.TabPage3.Controls.Add(Me.SelecionarAssistenciaEnvioAssistenciaIMG)
        Me.TabPage3.Controls.Add(Me.PictureBox10)
        Me.TabPage3.Controls.Add(Me.QtdeProdutoEnvioAssistenciaTF)
        Me.TabPage3.Controls.Add(Me.CodigoProdutoEnvioAssistenciaTF)
        Me.TabPage3.Controls.Add(Me.ProdutoEnvioAssistenciaTF)
        Me.TabPage3.Controls.Add(Me.SelecionarProdutoEnvioAssistenciaLB)
        Me.TabPage3.Controls.Add(Me.ClienteEnvioAssistenciaTB)
        Me.TabPage3.Controls.Add(Me.SelecionarClienteEnvioAssistenciaLB)
        Me.TabPage3.Controls.Add(Me.ConfirmarProdutoEnvioAssistenciaIMG)
        Me.TabPage3.Controls.Add(Me.PictureBox12)
        Me.TabPage3.Controls.Add(Me.SelecionarProdutoEnvioAssistenciaIMG)
        Me.TabPage3.Controls.Add(Me.SelecionarClienteEnvioAssistenciaIMG)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(685, 335)
        Me.TabPage3.TabIndex = 11
        Me.TabPage3.Text = "Enviar Produto a Assistência"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'EnviarParaAssistenciaBT
        '
        Me.EnviarParaAssistenciaBT.Location = New System.Drawing.Point(275, 306)
        Me.EnviarParaAssistenciaBT.Name = "EnviarParaAssistenciaBT"
        Me.EnviarParaAssistenciaBT.Size = New System.Drawing.Size(135, 23)
        Me.EnviarParaAssistenciaBT.TabIndex = 61
        Me.EnviarParaAssistenciaBT.Text = "Enviar para Assistência"
        Me.EnviarParaAssistenciaBT.UseVisualStyleBackColor = True
        '
        'ProdutosOrdemDT
        '
        Me.ProdutosOrdemDT.AllowUserToAddRows = False
        Me.ProdutosOrdemDT.AllowUserToDeleteRows = False
        Me.ProdutosOrdemDT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProdutosOrdemDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProdutosOrdemDT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn27, Me.DataGridViewButtonColumn4})
        Me.ProdutosOrdemDT.Location = New System.Drawing.Point(6, 116)
        Me.ProdutosOrdemDT.Name = "ProdutosOrdemDT"
        Me.ProdutosOrdemDT.ReadOnly = True
        Me.ProdutosOrdemDT.RowHeadersVisible = False
        Me.ProdutosOrdemDT.Size = New System.Drawing.Size(673, 184)
        Me.ProdutosOrdemDT.TabIndex = 60
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 50
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Width = 450
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.HeaderText = "Qtde"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Width = 50
        '
        'DataGridViewButtonColumn4
        '
        Me.DataGridViewButtonColumn4.HeaderText = "Remover"
        Me.DataGridViewButtonColumn4.Name = "DataGridViewButtonColumn4"
        Me.DataGridViewButtonColumn4.ReadOnly = True
        '
        'PictureBox18
        '
        Me.PictureBox18.Image = Global.NobelTheater.My.Resources.Resources.Adicionar
        Me.PictureBox18.Location = New System.Drawing.Point(6, 51)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(27, 20)
        Me.PictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox18.TabIndex = 59
        Me.PictureBox18.TabStop = False
        '
        'AssistenciaEnvioAssistenciaTF
        '
        Me.AssistenciaEnvioAssistenciaTF.Enabled = False
        Me.AssistenciaEnvioAssistenciaTF.Location = New System.Drawing.Point(159, 52)
        Me.AssistenciaEnvioAssistenciaTF.Name = "AssistenciaEnvioAssistenciaTF"
        Me.AssistenciaEnvioAssistenciaTF.Size = New System.Drawing.Size(445, 20)
        Me.AssistenciaEnvioAssistenciaTF.TabIndex = 57
        '
        'SelecionarAssistenciaLB
        '
        Me.SelecionarAssistenciaLB.AutoSize = True
        Me.SelecionarAssistenciaLB.Location = New System.Drawing.Point(35, 55)
        Me.SelecionarAssistenciaLB.Name = "SelecionarAssistenciaLB"
        Me.SelecionarAssistenciaLB.Size = New System.Drawing.Size(125, 13)
        Me.SelecionarAssistenciaLB.TabIndex = 56
        Me.SelecionarAssistenciaLB.Text = "Selecionar a Assistência:"
        '
        'SelecionarAssistenciaEnvioAssistenciaIMG
        '
        Me.SelecionarAssistenciaEnvioAssistenciaIMG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SelecionarAssistenciaEnvioAssistenciaIMG.Image = Global.NobelTheater.My.Resources.Resources.Busca
        Me.SelecionarAssistenciaEnvioAssistenciaIMG.Location = New System.Drawing.Point(610, 52)
        Me.SelecionarAssistenciaEnvioAssistenciaIMG.Name = "SelecionarAssistenciaEnvioAssistenciaIMG"
        Me.SelecionarAssistenciaEnvioAssistenciaIMG.Size = New System.Drawing.Size(27, 20)
        Me.SelecionarAssistenciaEnvioAssistenciaIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SelecionarAssistenciaEnvioAssistenciaIMG.TabIndex = 58
        Me.SelecionarAssistenciaEnvioAssistenciaIMG.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.NobelTheater.My.Resources.Resources.Adicionar
        Me.PictureBox10.Location = New System.Drawing.Point(6, 17)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(27, 20)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 55
        Me.PictureBox10.TabStop = False
        '
        'QtdeProdutoEnvioAssistenciaTF
        '
        Me.QtdeProdutoEnvioAssistenciaTF.Location = New System.Drawing.Point(562, 90)
        Me.QtdeProdutoEnvioAssistenciaTF.Name = "QtdeProdutoEnvioAssistenciaTF"
        Me.QtdeProdutoEnvioAssistenciaTF.Size = New System.Drawing.Size(42, 20)
        Me.QtdeProdutoEnvioAssistenciaTF.TabIndex = 53
        Me.QtdeProdutoEnvioAssistenciaTF.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CodigoProdutoEnvioAssistenciaTF
        '
        Me.CodigoProdutoEnvioAssistenciaTF.Enabled = False
        Me.CodigoProdutoEnvioAssistenciaTF.Location = New System.Drawing.Point(519, 89)
        Me.CodigoProdutoEnvioAssistenciaTF.Name = "CodigoProdutoEnvioAssistenciaTF"
        Me.CodigoProdutoEnvioAssistenciaTF.Size = New System.Drawing.Size(37, 20)
        Me.CodigoProdutoEnvioAssistenciaTF.TabIndex = 52
        '
        'ProdutoEnvioAssistenciaTF
        '
        Me.ProdutoEnvioAssistenciaTF.Enabled = False
        Me.ProdutoEnvioAssistenciaTF.Location = New System.Drawing.Point(159, 89)
        Me.ProdutoEnvioAssistenciaTF.Name = "ProdutoEnvioAssistenciaTF"
        Me.ProdutoEnvioAssistenciaTF.Size = New System.Drawing.Size(355, 20)
        Me.ProdutoEnvioAssistenciaTF.TabIndex = 49
        '
        'SelecionarProdutoEnvioAssistenciaLB
        '
        Me.SelecionarProdutoEnvioAssistenciaLB.AutoSize = True
        Me.SelecionarProdutoEnvioAssistenciaLB.Location = New System.Drawing.Point(35, 92)
        Me.SelecionarProdutoEnvioAssistenciaLB.Name = "SelecionarProdutoEnvioAssistenciaLB"
        Me.SelecionarProdutoEnvioAssistenciaLB.Size = New System.Drawing.Size(100, 13)
        Me.SelecionarProdutoEnvioAssistenciaLB.TabIndex = 48
        Me.SelecionarProdutoEnvioAssistenciaLB.Text = "Selecionar Produto:"
        '
        'ClienteEnvioAssistenciaTB
        '
        Me.ClienteEnvioAssistenciaTB.Enabled = False
        Me.ClienteEnvioAssistenciaTB.Location = New System.Drawing.Point(159, 17)
        Me.ClienteEnvioAssistenciaTB.Name = "ClienteEnvioAssistenciaTB"
        Me.ClienteEnvioAssistenciaTB.Size = New System.Drawing.Size(445, 20)
        Me.ClienteEnvioAssistenciaTB.TabIndex = 46
        '
        'SelecionarClienteEnvioAssistenciaLB
        '
        Me.SelecionarClienteEnvioAssistenciaLB.AutoSize = True
        Me.SelecionarClienteEnvioAssistenciaLB.Location = New System.Drawing.Point(35, 20)
        Me.SelecionarClienteEnvioAssistenciaLB.Name = "SelecionarClienteEnvioAssistenciaLB"
        Me.SelecionarClienteEnvioAssistenciaLB.Size = New System.Drawing.Size(95, 13)
        Me.SelecionarClienteEnvioAssistenciaLB.TabIndex = 45
        Me.SelecionarClienteEnvioAssistenciaLB.Text = "Selecionar Cliente:"
        '
        'ConfirmarProdutoEnvioAssistenciaIMG
        '
        Me.ConfirmarProdutoEnvioAssistenciaIMG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConfirmarProdutoEnvioAssistenciaIMG.Image = Global.NobelTheater.My.Resources.Resources.Confirmar
        Me.ConfirmarProdutoEnvioAssistenciaIMG.Location = New System.Drawing.Point(641, 90)
        Me.ConfirmarProdutoEnvioAssistenciaIMG.Name = "ConfirmarProdutoEnvioAssistenciaIMG"
        Me.ConfirmarProdutoEnvioAssistenciaIMG.Size = New System.Drawing.Size(27, 20)
        Me.ConfirmarProdutoEnvioAssistenciaIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ConfirmarProdutoEnvioAssistenciaIMG.TabIndex = 54
        Me.ConfirmarProdutoEnvioAssistenciaIMG.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = Global.NobelTheater.My.Resources.Resources.Adicionar
        Me.PictureBox12.Location = New System.Drawing.Point(6, 89)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(27, 20)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 51
        Me.PictureBox12.TabStop = False
        '
        'SelecionarProdutoEnvioAssistenciaIMG
        '
        Me.SelecionarProdutoEnvioAssistenciaIMG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SelecionarProdutoEnvioAssistenciaIMG.Image = Global.NobelTheater.My.Resources.Resources.Busca
        Me.SelecionarProdutoEnvioAssistenciaIMG.Location = New System.Drawing.Point(610, 89)
        Me.SelecionarProdutoEnvioAssistenciaIMG.Name = "SelecionarProdutoEnvioAssistenciaIMG"
        Me.SelecionarProdutoEnvioAssistenciaIMG.Size = New System.Drawing.Size(27, 20)
        Me.SelecionarProdutoEnvioAssistenciaIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SelecionarProdutoEnvioAssistenciaIMG.TabIndex = 50
        Me.SelecionarProdutoEnvioAssistenciaIMG.TabStop = False
        '
        'SelecionarClienteEnvioAssistenciaIMG
        '
        Me.SelecionarClienteEnvioAssistenciaIMG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SelecionarClienteEnvioAssistenciaIMG.Image = Global.NobelTheater.My.Resources.Resources.Busca
        Me.SelecionarClienteEnvioAssistenciaIMG.Location = New System.Drawing.Point(610, 17)
        Me.SelecionarClienteEnvioAssistenciaIMG.Name = "SelecionarClienteEnvioAssistenciaIMG"
        Me.SelecionarClienteEnvioAssistenciaIMG.Size = New System.Drawing.Size(27, 20)
        Me.SelecionarClienteEnvioAssistenciaIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SelecionarClienteEnvioAssistenciaIMG.TabIndex = 47
        Me.SelecionarClienteEnvioAssistenciaIMG.TabStop = False
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.BuscarTodosProdutosEnviadosAssistenciaRB)
        Me.TabPage6.Controls.Add(Me.BuscarIDdeEnvioRB)
        Me.TabPage6.Controls.Add(Me.BuscarPorIDEnvioTF)
        Me.TabPage6.Controls.Add(Me.BuscarPorProdutoRB)
        Me.TabPage6.Controls.Add(Me.BuscarPorClienteRB)
        Me.TabPage6.Controls.Add(Me.IDProdutoTF)
        Me.TabPage6.Controls.Add(Me.BuscarPorProdutoTF)
        Me.TabPage6.Controls.Add(Me.BuscarPorClienteTF)
        Me.TabPage6.Controls.Add(Me.ProdutosEnviadosAssistenciaDG)
        Me.TabPage6.Controls.Add(Me.PictureBox5)
        Me.TabPage6.Controls.Add(Me.PictureBox9)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(685, 335)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Produtos Enviados a Assistência"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'BuscarTodosProdutosEnviadosAssistenciaRB
        '
        Me.BuscarTodosProdutosEnviadosAssistenciaRB.AutoSize = True
        Me.BuscarTodosProdutosEnviadosAssistenciaRB.Location = New System.Drawing.Point(417, 11)
        Me.BuscarTodosProdutosEnviadosAssistenciaRB.Name = "BuscarTodosProdutosEnviadosAssistenciaRB"
        Me.BuscarTodosProdutosEnviadosAssistenciaRB.Size = New System.Drawing.Size(255, 17)
        Me.BuscarTodosProdutosEnviadosAssistenciaRB.TabIndex = 62
        Me.BuscarTodosProdutosEnviadosAssistenciaRB.Text = "Buscar todos os produtos enviados a assistência"
        Me.BuscarTodosProdutosEnviadosAssistenciaRB.UseVisualStyleBackColor = True
        '
        'BuscarIDdeEnvioRB
        '
        Me.BuscarIDdeEnvioRB.AutoSize = True
        Me.BuscarIDdeEnvioRB.Location = New System.Drawing.Point(16, 11)
        Me.BuscarIDdeEnvioRB.Name = "BuscarIDdeEnvioRB"
        Me.BuscarIDdeEnvioRB.Size = New System.Drawing.Size(134, 17)
        Me.BuscarIDdeEnvioRB.TabIndex = 61
        Me.BuscarIDdeEnvioRB.Text = "Busca por ID de envio:"
        Me.BuscarIDdeEnvioRB.UseVisualStyleBackColor = True
        '
        'BuscarPorIDEnvioTF
        '
        Me.BuscarPorIDEnvioTF.Location = New System.Drawing.Point(198, 10)
        Me.BuscarPorIDEnvioTF.Name = "BuscarPorIDEnvioTF"
        Me.BuscarPorIDEnvioTF.Size = New System.Drawing.Size(67, 20)
        Me.BuscarPorIDEnvioTF.TabIndex = 60
        '
        'BuscarPorProdutoRB
        '
        Me.BuscarPorProdutoRB.AutoSize = True
        Me.BuscarPorProdutoRB.Location = New System.Drawing.Point(16, 85)
        Me.BuscarPorProdutoRB.Name = "BuscarPorProdutoRB"
        Me.BuscarPorProdutoRB.Size = New System.Drawing.Size(115, 17)
        Me.BuscarPorProdutoRB.TabIndex = 59
        Me.BuscarPorProdutoRB.Text = "Busca por produto:"
        Me.BuscarPorProdutoRB.UseVisualStyleBackColor = True
        '
        'BuscarPorClienteRB
        '
        Me.BuscarPorClienteRB.AutoSize = True
        Me.BuscarPorClienteRB.Location = New System.Drawing.Point(16, 48)
        Me.BuscarPorClienteRB.Name = "BuscarPorClienteRB"
        Me.BuscarPorClienteRB.Size = New System.Drawing.Size(110, 17)
        Me.BuscarPorClienteRB.TabIndex = 58
        Me.BuscarPorClienteRB.Text = "Busca por cliente:"
        Me.BuscarPorClienteRB.UseVisualStyleBackColor = True
        '
        'IDProdutoTF
        '
        Me.IDProdutoTF.Enabled = False
        Me.IDProdutoTF.Location = New System.Drawing.Point(602, 86)
        Me.IDProdutoTF.Name = "IDProdutoTF"
        Me.IDProdutoTF.Size = New System.Drawing.Size(37, 20)
        Me.IDProdutoTF.TabIndex = 57
        '
        'BuscarPorProdutoTF
        '
        Me.BuscarPorProdutoTF.Enabled = False
        Me.BuscarPorProdutoTF.Location = New System.Drawing.Point(198, 86)
        Me.BuscarPorProdutoTF.Name = "BuscarPorProdutoTF"
        Me.BuscarPorProdutoTF.Size = New System.Drawing.Size(398, 20)
        Me.BuscarPorProdutoTF.TabIndex = 55
        '
        'BuscarPorClienteTF
        '
        Me.BuscarPorClienteTF.Enabled = False
        Me.BuscarPorClienteTF.Location = New System.Drawing.Point(198, 48)
        Me.BuscarPorClienteTF.Name = "BuscarPorClienteTF"
        Me.BuscarPorClienteTF.Size = New System.Drawing.Size(441, 20)
        Me.BuscarPorClienteTF.TabIndex = 53
        '
        'ProdutosEnviadosAssistenciaDG
        '
        Me.ProdutosEnviadosAssistenciaDG.AllowUserToAddRows = False
        Me.ProdutosEnviadosAssistenciaDG.AllowUserToDeleteRows = False
        Me.ProdutosEnviadosAssistenciaDG.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProdutosEnviadosAssistenciaDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProdutosEnviadosAssistenciaDG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDProdutoAssistencia, Me.StatusProdutoAssistencia, Me.ClienteProdutoAssistencia, Me.DataDeEnvioAssistencia, Me.VerProdutosAssistencia, Me.FinalizarSolicitacaoEnvioAssistencia})
        Me.ProdutosEnviadosAssistenciaDG.Location = New System.Drawing.Point(12, 116)
        Me.ProdutosEnviadosAssistenciaDG.Name = "ProdutosEnviadosAssistenciaDG"
        Me.ProdutosEnviadosAssistenciaDG.ReadOnly = True
        Me.ProdutosEnviadosAssistenciaDG.RowHeadersVisible = False
        Me.ProdutosEnviadosAssistenciaDG.Size = New System.Drawing.Size(661, 209)
        Me.ProdutosEnviadosAssistenciaDG.TabIndex = 52
        '
        'IDProdutoAssistencia
        '
        Me.IDProdutoAssistencia.HeaderText = "ID"
        Me.IDProdutoAssistencia.Name = "IDProdutoAssistencia"
        Me.IDProdutoAssistencia.ReadOnly = True
        Me.IDProdutoAssistencia.Width = 50
        '
        'StatusProdutoAssistencia
        '
        Me.StatusProdutoAssistencia.HeaderText = "Status"
        Me.StatusProdutoAssistencia.Name = "StatusProdutoAssistencia"
        Me.StatusProdutoAssistencia.ReadOnly = True
        Me.StatusProdutoAssistencia.Width = 75
        '
        'ClienteProdutoAssistencia
        '
        Me.ClienteProdutoAssistencia.HeaderText = "Cliente"
        Me.ClienteProdutoAssistencia.Name = "ClienteProdutoAssistencia"
        Me.ClienteProdutoAssistencia.ReadOnly = True
        Me.ClienteProdutoAssistencia.Width = 150
        '
        'DataDeEnvioAssistencia
        '
        Me.DataDeEnvioAssistencia.HeaderText = "Data de Envio"
        Me.DataDeEnvioAssistencia.Name = "DataDeEnvioAssistencia"
        Me.DataDeEnvioAssistencia.ReadOnly = True
        Me.DataDeEnvioAssistencia.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataDeEnvioAssistencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataDeEnvioAssistencia.Width = 150
        '
        'VerProdutosAssistencia
        '
        Me.VerProdutosAssistencia.HeaderText = "Ver Produtos"
        Me.VerProdutosAssistencia.Name = "VerProdutosAssistencia"
        Me.VerProdutosAssistencia.ReadOnly = True
        '
        'FinalizarSolicitacaoEnvioAssistencia
        '
        Me.FinalizarSolicitacaoEnvioAssistencia.HeaderText = "Finalizar Solicitação"
        Me.FinalizarSolicitacaoEnvioAssistencia.Name = "FinalizarSolicitacaoEnvioAssistencia"
        Me.FinalizarSolicitacaoEnvioAssistencia.ReadOnly = True
        Me.FinalizarSolicitacaoEnvioAssistencia.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FinalizarSolicitacaoEnvioAssistencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FinalizarSolicitacaoEnvioAssistencia.Width = 125
        '
        'PictureBox5
        '
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = Global.NobelTheater.My.Resources.Resources.Busca
        Me.PictureBox5.Location = New System.Drawing.Point(645, 86)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(27, 20)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 56
        Me.PictureBox5.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox9.Image = Global.NobelTheater.My.Resources.Resources.Busca
        Me.PictureBox9.Location = New System.Drawing.Point(645, 48)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(27, 20)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 54
        Me.PictureBox9.TabStop = False
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.FimDT)
        Me.TabPage5.Controls.Add(Me.InicioDT)
        Me.TabPage5.Controls.Add(Me.DeLB)
        Me.TabPage5.Controls.Add(Me.AteLB)
        Me.TabPage5.Controls.Add(Me.GerarRelatorioCompraBT)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(685, 335)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Extrair Relatórios de Compras"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'FimDT
        '
        Me.FimDT.CustomFormat = "dd/MM/yyyy"
        Me.FimDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FimDT.Location = New System.Drawing.Point(173, 20)
        Me.FimDT.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.FimDT.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.FimDT.Name = "FimDT"
        Me.FimDT.Size = New System.Drawing.Size(98, 20)
        Me.FimDT.TabIndex = 39
        '
        'InicioDT
        '
        Me.InicioDT.CustomFormat = "dd/MM/yyyy"
        Me.InicioDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.InicioDT.Location = New System.Drawing.Point(37, 20)
        Me.InicioDT.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.InicioDT.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.InicioDT.Name = "InicioDT"
        Me.InicioDT.Size = New System.Drawing.Size(98, 20)
        Me.InicioDT.TabIndex = 38
        '
        'DeLB
        '
        Me.DeLB.AutoSize = True
        Me.DeLB.Location = New System.Drawing.Point(7, 23)
        Me.DeLB.Name = "DeLB"
        Me.DeLB.Size = New System.Drawing.Size(24, 13)
        Me.DeLB.TabIndex = 37
        Me.DeLB.Text = "De:"
        '
        'AteLB
        '
        Me.AteLB.AutoSize = True
        Me.AteLB.Location = New System.Drawing.Point(141, 23)
        Me.AteLB.Name = "AteLB"
        Me.AteLB.Size = New System.Drawing.Size(26, 13)
        Me.AteLB.TabIndex = 36
        Me.AteLB.Text = "Até:"
        '
        'GerarRelatorioCompraBT
        '
        Me.GerarRelatorioCompraBT.Location = New System.Drawing.Point(299, 18)
        Me.GerarRelatorioCompraBT.Name = "GerarRelatorioCompraBT"
        Me.GerarRelatorioCompraBT.Size = New System.Drawing.Size(103, 23)
        Me.GerarRelatorioCompraBT.TabIndex = 35
        Me.GerarRelatorioCompraBT.Text = "Gerar Relatório"
        Me.GerarRelatorioCompraBT.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcoesToolStripMenuItem, Me.AcessosToolStripMenuItem, Me.EstoqueToolStripMenuItem, Me.FornecedoresToolStripMenuItem, Me.VendasToolStripMenuItem, Me.BalançoDeCaixaToolStripMenuItem, Me.MonitoramentoToolStripMenuItem, Me.FuncionáriosToolStripMenuItem, Me.ClientesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(729, 24)
        Me.MenuStrip1.TabIndex = 5
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
        'ControleEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 519)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ControleEstoque"
        Me.Text = "Controle de Estoque"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ControleEstoqueTab.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FornecedorIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfirmaProdutoIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtdeTF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutoCotacaoIMG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.AlertasDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutoAlertaIMG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CotacoesAndamentoTab.ResumeLayout(False)
        CType(Me.CotacoesDT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AcompanharCotacaoTab.ResumeLayout(False)
        Me.AcompanharCotacaoTab.PerformLayout()
        Me.StatusGB.ResumeLayout(False)
        Me.StatusGB.PerformLayout()
        CType(Me.QtdeProdutoAcompanharCotacaoTF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosAcompanharCotacaoDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfimarProdutoAcompanharCotacaoTF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ComprasAndamentoTab.ResumeLayout(False)
        CType(Me.ComprasDT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AcompanharCompraTab.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagamentosDT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtdeEmprestarProdutoTF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosEmprestimoDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfirmarProdutoEmprestarProdutoIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarProdutoEmprestarProdutoIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarClienteEmprestarProdutoIMG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProdutosEmprestadosTab.ResumeLayout(False)
        Me.ProdutosEmprestadosTab.PerformLayout()
        CType(Me.ProdutosEmprestadosDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.ProdutosOrdemDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelecionarAssistenciaEnvioAssistenciaIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtdeProdutoEnvioAssistenciaTF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfirmarProdutoEnvioAssistenciaIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelecionarProdutoEnvioAssistenciaIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelecionarClienteEnvioAssistenciaIMG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.ProdutosEnviadosAssistenciaDG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ControleEstoqueTab As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ProdutoCotacaoIMG As System.Windows.Forms.PictureBox
    Friend WithEvents NomeProdutoTF As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents QtdeTF As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CodigoProdutoTF As System.Windows.Forms.TextBox
    Friend WithEvents ProdutosDT As System.Windows.Forms.DataGridView
    Friend WithEvents ConfirmaProdutoIMG As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents FornecedorTF As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents FinalizarBT As System.Windows.Forms.Button
    Friend WithEvents AlertasDT As System.Windows.Forms.DataGridView
    Friend WithEvents CriarAlertaBT As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ObservacaoTF As System.Windows.Forms.TextBox
    Friend WithEvents ProdutoAlertaIMG As System.Windows.Forms.PictureBox
    Friend WithEvents ProdutoAlertaTF As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComprasAndamentoTab As System.Windows.Forms.TabPage
    Friend WithEvents ComprasDT As System.Windows.Forms.DataGridView
    Friend WithEvents ProdutosEmprestadosTab As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents AcompanharCompraTab As System.Windows.Forms.TabPage
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
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
    Friend WithEvents DataAlerta As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents RemoverAlerta As DataGridViewButtonColumn
    Friend WithEvents CotacoesAndamentoTab As TabPage
    Friend WithEvents CotacoesDT As DataGridView
    Friend WithEvents AcompanharCotacaoTab As TabPage
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn1 As DataGridViewButtonColumn
    Friend WithEvents FornecedorAcompanharCotacaoTF As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ConfimarProdutoAcompanharCotacaoTF As PictureBox
    Friend WithEvents QtdeProdutoAcompanharCotacaoTF As NumericUpDown
    Friend WithEvents CodigoProdutoAcompanharCotacaoTF As TextBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents ProdutoAcompanharCotacaoTF As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ProdutosAcompanharCotacaoDT As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn2 As DataGridViewButtonColumn
    Friend WithEvents StatusGB As GroupBox
    Friend WithEvents SalvarBT As Button
    Friend WithEvents NumeroNFCotacaoLB As Label
    Friend WithEvents DataEmissaoNFCotacaoTF As TextBox
    Friend WithEvents NumeroNFCotacaoTF As TextBox
    Friend WithEvents DataEmissaoNFCotacaoLB As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents StatusCotacaoCB As ComboBox
    Friend WithEvents ProdutosEmprestadosDT As DataGridView
    Friend WithEvents FimDT As DateTimePicker
    Friend WithEvents InicioDT As DateTimePicker
    Friend WithEvents DeLB As Label
    Friend WithEvents AteLB As Label
    Friend WithEvents GerarRelatorioCompraBT As Button
    Friend WithEvents BuscarClienteEmprestarProdutoIMG As PictureBox
    Friend WithEvents ClienteEmprestarProdutoTF As TextBox
    Friend WithEvents ClienteEmprestimoLB As Label
    Friend WithEvents FornecedorIMG As PictureBox
    Friend WithEvents FinalizarEmprestimoBT As Button
    Friend WithEvents ConfirmarProdutoEmprestarProdutoIMG As PictureBox
    Friend WithEvents QtdeEmprestarProdutoTF As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CodigoProdutoEmprestarProdutoTF As TextBox
    Friend WithEvents ProdutosEmprestimoDT As DataGridView
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents BuscarProdutoEmprestarProdutoIMG As PictureBox
    Friend WithEvents NomeProdutoEmprestarProdutoTF As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn5 As DataGridViewButtonColumn
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents CodigoProdutoEmprestimoTF As TextBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents NomeProdutoEmprestimoTF As TextBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents ClienteEmprestimoTF As TextBox
    Friend WithEvents BuscaProdutoRB As RadioButton
    Friend WithEvents BuscaClienteRB As RadioButton
    Friend WithEvents BuscaIDRB As RadioButton
    Friend WithEvents IDEmprestimoTF As TextBox
    Friend WithEvents BuscaAllRB As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents PagamentosDT As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents VerItensAcompanharCompraBT As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents FornecedorAcompanharCompraTF As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents DataAprovacaoAcompanharCompraTF As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents DataCotacaoAcompanharCompraTF As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents StatusCompraAcompanharCompraCB As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents DataEmissaoAcompanharCompraTF As TextBox
    Friend WithEvents NumeroNFAcompanharCompraTF As TextBox
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn3 As DataGridViewButtonColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TipoPagamentoCB As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents DataPagamentoTF As TextBox
    Friend WithEvents ValorPgtoTF As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Fornecedor As DataGridViewTextBoxColumn
    Friend WithEvents NotaFiscal As DataGridViewTextBoxColumn
    Friend WithEvents VerProd As DataGridViewButtonColumn
    Friend WithEvents IDSolicitacao As DataGridViewTextBoxColumn
    Friend WithEvents StatusSolicitacao As DataGridViewTextBoxColumn
    Friend WithEvents ClienteProdutoEmprestado As DataGridViewTextBoxColumn
    Friend WithEvents DataEmprestimo As DataGridViewTextBoxColumn
    Friend WithEvents VerProdutos As DataGridViewButtonColumn
    Friend WithEvents FinalizarSolicitacao As DataGridViewButtonColumn
    Friend WithEvents BuscarTodosProdutosEnviadosAssistenciaRB As RadioButton
    Friend WithEvents BuscarIDdeEnvioRB As RadioButton
    Friend WithEvents BuscarPorIDEnvioTF As TextBox
    Friend WithEvents BuscarPorProdutoRB As RadioButton
    Friend WithEvents BuscarPorClienteRB As RadioButton
    Friend WithEvents IDProdutoTF As TextBox
    Friend WithEvents BuscarPorProdutoTF As TextBox
    Friend WithEvents BuscarPorClienteTF As TextBox
    Friend WithEvents ProdutosEnviadosAssistenciaDG As DataGridView
    Friend WithEvents IDProdutoAssistencia As DataGridViewTextBoxColumn
    Friend WithEvents StatusProdutoAssistencia As DataGridViewTextBoxColumn
    Friend WithEvents ClienteProdutoAssistencia As DataGridViewTextBoxColumn
    Friend WithEvents DataDeEnvioAssistencia As DataGridViewTextBoxColumn
    Friend WithEvents VerProdutosAssistencia As DataGridViewButtonColumn
    Friend WithEvents FinalizarSolicitacaoEnvioAssistencia As DataGridViewButtonColumn
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents EnviarParaAssistenciaBT As Button
    Friend WithEvents ProdutosOrdemDT As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn4 As DataGridViewButtonColumn
    Friend WithEvents PictureBox18 As PictureBox
    Friend WithEvents AssistenciaEnvioAssistenciaTF As TextBox
    Friend WithEvents SelecionarAssistenciaLB As Label
    Friend WithEvents SelecionarAssistenciaEnvioAssistenciaIMG As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents QtdeProdutoEnvioAssistenciaTF As NumericUpDown
    Friend WithEvents CodigoProdutoEnvioAssistenciaTF As TextBox
    Friend WithEvents ProdutoEnvioAssistenciaTF As TextBox
    Friend WithEvents SelecionarProdutoEnvioAssistenciaLB As Label
    Friend WithEvents ClienteEnvioAssistenciaTB As TextBox
    Friend WithEvents SelecionarClienteEnvioAssistenciaLB As Label
    Friend WithEvents ConfirmarProdutoEnvioAssistenciaIMG As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents SelecionarProdutoEnvioAssistenciaIMG As PictureBox
    Friend WithEvents SelecionarClienteEnvioAssistenciaIMG As PictureBox
End Class
