﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.ConfimarProdutoAcompanharCotacaoTF = New System.Windows.Forms.PictureBox()
        Me.QtdeProdutoAcompanharCotacaoTF = New System.Windows.Forms.NumericUpDown()
        Me.CodigoProdutoAcompanharCotacaoTF = New System.Windows.Forms.TextBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.ProdutoAcompanharCotacaoTF = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProdutosAcompanharCotacaoDT = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ComprasAndamentoTab = New System.Windows.Forms.TabPage()
        Me.ComprasDT = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotaFiscal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerProd = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.VerPgto = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewButtonColumn4 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.EditarAcompanharCompra = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.RemoverAcompanharCompra = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.AteAcompanharCompraDT = New System.Windows.Forms.DateTimePicker()
        Me.AteAcompanharCompraLB = New System.Windows.Forms.Label()
        Me.DeAcompanharCompraDT = New System.Windows.Forms.DateTimePicker()
        Me.DeAcompanharCompraLB = New System.Windows.Forms.Label()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.NotaFiscalAcompanharCompraTF = New System.Windows.Forms.TextBox()
        Me.NotaFiscalAcompanharCompraLB = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.FornecedorAcompanharCompraTF = New System.Windows.Forms.TextBox()
        Me.FornecedorAcompanharCompraLB = New System.Windows.Forms.Label()
        Me.ProdutoAcompanharCompraTF = New System.Windows.Forms.TextBox()
        Me.ProdutoAcompanharCompraLB = New System.Windows.Forms.Label()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.FinalizarEmprestimoBT = New System.Windows.Forms.Button()
        Me.ConfirmarProdutoEmprestarProdutoIMG = New System.Windows.Forms.PictureBox()
        Me.QtdeEmprestarProdutoTF = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CodigoProdutoEmprestarProdutoTF = New System.Windows.Forms.TextBox()
        Me.ProdutosEmprestimoDT = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn5 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BuscarProdutoEmprestarProdutoIMG = New System.Windows.Forms.PictureBox()
        Me.NomeProdutoEmprestarProdutoTF = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BuscarClienteEmprestarProdutoIMG = New System.Windows.Forms.PictureBox()
        Me.ClienteEmprestarProdutoTF = New System.Windows.Forms.TextBox()
        Me.ClienteEmprestimoLB = New System.Windows.Forms.Label()
        Me.ProdutosEmprestadosTab = New System.Windows.Forms.TabPage()
        Me.BuscaAllRB = New System.Windows.Forms.RadioButton()
        Me.BuscaIDRB = New System.Windows.Forms.RadioButton()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.BuscaProdutoRB = New System.Windows.Forms.RadioButton()
        Me.BuscaClienteRB = New System.Windows.Forms.RadioButton()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDSolicitacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusSolicitacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteProdutoEmprestado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataEmprestimo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.VerProdutos = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.FinalizarSolicitacao = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ProdutoAssistencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteProdutoAssistencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataEnvioAssistencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResponsavelAssistencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EditarProdutoAssistencia = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.RemoverProdutoAssistencia = New System.Windows.Forms.DataGridViewButtonColumn()
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
        CType(Me.ConfimarProdutoAcompanharCotacaoTF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtdeProdutoAcompanharCotacaoTF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosAcompanharCotacaoDT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ComprasAndamentoTab.SuspendLayout()
        CType(Me.ComprasDT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage8.SuspendLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfirmarProdutoEmprestarProdutoIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtdeEmprestarProdutoTF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosEmprestimoDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarProdutoEmprestarProdutoIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarClienteEmprestarProdutoIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProdutosEmprestadosTab.SuspendLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PictureBox1.Image = Global.NobelTheater.My.Resources.Resources.warehouseicon
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
        Me.ControleEstoqueTab.Controls.Add(Me.TabPage7)
        Me.ControleEstoqueTab.Controls.Add(Me.TabPage8)
        Me.ControleEstoqueTab.Controls.Add(Me.ProdutosEmprestadosTab)
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
        Me.AcompanharCotacaoTab.Controls.Add(Me.ConfimarProdutoAcompanharCotacaoTF)
        Me.AcompanharCotacaoTab.Controls.Add(Me.QtdeProdutoAcompanharCotacaoTF)
        Me.AcompanharCotacaoTab.Controls.Add(Me.CodigoProdutoAcompanharCotacaoTF)
        Me.AcompanharCotacaoTab.Controls.Add(Me.PictureBox7)
        Me.AcompanharCotacaoTab.Controls.Add(Me.PictureBox8)
        Me.AcompanharCotacaoTab.Controls.Add(Me.ProdutoAcompanharCotacaoTF)
        Me.AcompanharCotacaoTab.Controls.Add(Me.Label4)
        Me.AcompanharCotacaoTab.Controls.Add(Me.ProdutosAcompanharCotacaoDT)
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
        Me.ComprasDT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.Fornecedor, Me.NotaFiscal, Me.VerProd, Me.VerPgto})
        Me.ComprasDT.Location = New System.Drawing.Point(6, 6)
        Me.ComprasDT.Name = "ComprasDT"
        Me.ComprasDT.ReadOnly = True
        Me.ComprasDT.RowHeadersVisible = False
        Me.ComprasDT.Size = New System.Drawing.Size(673, 323)
        Me.ComprasDT.TabIndex = 21
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Data da Cotação"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 75
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Status da Compra"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 75
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Data Aprovação"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 75
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
        Me.NotaFiscal.HeaderText = "NotaFiscal"
        Me.NotaFiscal.Name = "NotaFiscal"
        Me.NotaFiscal.ReadOnly = True
        Me.NotaFiscal.Width = 75
        '
        'VerProd
        '
        Me.VerProd.HeaderText = "Ver Produtos"
        Me.VerProd.Name = "VerProd"
        Me.VerProd.ReadOnly = True
        '
        'VerPgto
        '
        Me.VerPgto.HeaderText = "Ver Pagamentos"
        Me.VerPgto.Name = "VerPgto"
        Me.VerPgto.ReadOnly = True
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.DataGridView4)
        Me.TabPage7.Controls.Add(Me.AteAcompanharCompraDT)
        Me.TabPage7.Controls.Add(Me.AteAcompanharCompraLB)
        Me.TabPage7.Controls.Add(Me.DeAcompanharCompraDT)
        Me.TabPage7.Controls.Add(Me.DeAcompanharCompraLB)
        Me.TabPage7.Controls.Add(Me.PictureBox10)
        Me.TabPage7.Controls.Add(Me.NotaFiscalAcompanharCompraTF)
        Me.TabPage7.Controls.Add(Me.NotaFiscalAcompanharCompraLB)
        Me.TabPage7.Controls.Add(Me.PictureBox9)
        Me.TabPage7.Controls.Add(Me.PictureBox5)
        Me.TabPage7.Controls.Add(Me.FornecedorAcompanharCompraTF)
        Me.TabPage7.Controls.Add(Me.FornecedorAcompanharCompraLB)
        Me.TabPage7.Controls.Add(Me.ProdutoAcompanharCompraTF)
        Me.TabPage7.Controls.Add(Me.ProdutoAcompanharCompraLB)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(685, 335)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Acompanhar Compra"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.AllowUserToDeleteRows = False
        Me.DataGridView4.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewButtonColumn3, Me.DataGridViewButtonColumn4, Me.EditarAcompanharCompra, Me.RemoverAcompanharCompra})
        Me.DataGridView4.Location = New System.Drawing.Point(6, 88)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.ReadOnly = True
        Me.DataGridView4.RowHeadersVisible = False
        Me.DataGridView4.Size = New System.Drawing.Size(673, 241)
        Me.DataGridView4.TabIndex = 31
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "Data da Cotação"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 75
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "Status da Compra"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 75
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "Data Aprovação"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 75
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.HeaderText = "Data Ult. Pgto"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 75
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.HeaderText = "Fornecedor"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 75
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.HeaderText = "NotaFiscal"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 75
        '
        'DataGridViewButtonColumn3
        '
        Me.DataGridViewButtonColumn3.HeaderText = "Ver Produtos"
        Me.DataGridViewButtonColumn3.Name = "DataGridViewButtonColumn3"
        Me.DataGridViewButtonColumn3.ReadOnly = True
        '
        'DataGridViewButtonColumn4
        '
        Me.DataGridViewButtonColumn4.HeaderText = "Ver Pagamentos"
        Me.DataGridViewButtonColumn4.Name = "DataGridViewButtonColumn4"
        Me.DataGridViewButtonColumn4.ReadOnly = True
        '
        'EditarAcompanharCompra
        '
        Me.EditarAcompanharCompra.HeaderText = "Editar"
        Me.EditarAcompanharCompra.Name = "EditarAcompanharCompra"
        Me.EditarAcompanharCompra.ReadOnly = True
        '
        'RemoverAcompanharCompra
        '
        Me.RemoverAcompanharCompra.HeaderText = "Remover"
        Me.RemoverAcompanharCompra.Name = "RemoverAcompanharCompra"
        Me.RemoverAcompanharCompra.ReadOnly = True
        '
        'AteAcompanharCompraDT
        '
        Me.AteAcompanharCompraDT.Location = New System.Drawing.Point(358, 61)
        Me.AteAcompanharCompraDT.Name = "AteAcompanharCompraDT"
        Me.AteAcompanharCompraDT.Size = New System.Drawing.Size(159, 20)
        Me.AteAcompanharCompraDT.TabIndex = 30
        '
        'AteAcompanharCompraLB
        '
        Me.AteAcompanharCompraLB.AutoSize = True
        Me.AteAcompanharCompraLB.Location = New System.Drawing.Point(328, 65)
        Me.AteAcompanharCompraLB.Name = "AteAcompanharCompraLB"
        Me.AteAcompanharCompraLB.Size = New System.Drawing.Size(26, 13)
        Me.AteAcompanharCompraLB.TabIndex = 29
        Me.AteAcompanharCompraLB.Text = "Até:"
        '
        'DeAcompanharCompraDT
        '
        Me.DeAcompanharCompraDT.Location = New System.Drawing.Point(163, 62)
        Me.DeAcompanharCompraDT.Name = "DeAcompanharCompraDT"
        Me.DeAcompanharCompraDT.Size = New System.Drawing.Size(159, 20)
        Me.DeAcompanharCompraDT.TabIndex = 28
        '
        'DeAcompanharCompraLB
        '
        Me.DeAcompanharCompraLB.AutoSize = True
        Me.DeAcompanharCompraLB.Location = New System.Drawing.Point(133, 65)
        Me.DeAcompanharCompraLB.Name = "DeAcompanharCompraLB"
        Me.DeAcompanharCompraLB.Size = New System.Drawing.Size(24, 13)
        Me.DeAcompanharCompraLB.TabIndex = 27
        Me.DeAcompanharCompraLB.Text = "De:"
        '
        'PictureBox10
        '
        Me.PictureBox10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox10.Image = Global.NobelTheater.My.Resources.Resources.Busca
        Me.PictureBox10.Location = New System.Drawing.Point(601, 28)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(27, 20)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 26
        Me.PictureBox10.TabStop = False
        '
        'NotaFiscalAcompanharCompraTF
        '
        Me.NotaFiscalAcompanharCompraTF.Enabled = False
        Me.NotaFiscalAcompanharCompraTF.Location = New System.Drawing.Point(358, 28)
        Me.NotaFiscalAcompanharCompraTF.Name = "NotaFiscalAcompanharCompraTF"
        Me.NotaFiscalAcompanharCompraTF.Size = New System.Drawing.Size(237, 20)
        Me.NotaFiscalAcompanharCompraTF.TabIndex = 25
        '
        'NotaFiscalAcompanharCompraLB
        '
        Me.NotaFiscalAcompanharCompraLB.AutoSize = True
        Me.NotaFiscalAcompanharCompraLB.Location = New System.Drawing.Point(289, 31)
        Me.NotaFiscalAcompanharCompraLB.Name = "NotaFiscalAcompanharCompraLB"
        Me.NotaFiscalAcompanharCompraLB.Size = New System.Drawing.Size(63, 13)
        Me.NotaFiscalAcompanharCompraLB.TabIndex = 24
        Me.NotaFiscalAcompanharCompraLB.Text = "Nota Fiscal:"
        '
        'PictureBox9
        '
        Me.PictureBox9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox9.Image = Global.NobelTheater.My.Resources.Resources.Busca
        Me.PictureBox9.Location = New System.Drawing.Point(256, 28)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(27, 20)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 23
        Me.PictureBox9.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = Global.NobelTheater.My.Resources.Resources.Busca
        Me.PictureBox5.Location = New System.Drawing.Point(601, 4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(27, 20)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 22
        Me.PictureBox5.TabStop = False
        '
        'FornecedorAcompanharCompraTF
        '
        Me.FornecedorAcompanharCompraTF.Enabled = False
        Me.FornecedorAcompanharCompraTF.Location = New System.Drawing.Point(76, 4)
        Me.FornecedorAcompanharCompraTF.Name = "FornecedorAcompanharCompraTF"
        Me.FornecedorAcompanharCompraTF.Size = New System.Drawing.Size(519, 20)
        Me.FornecedorAcompanharCompraTF.TabIndex = 21
        '
        'FornecedorAcompanharCompraLB
        '
        Me.FornecedorAcompanharCompraLB.AutoSize = True
        Me.FornecedorAcompanharCompraLB.Location = New System.Drawing.Point(6, 7)
        Me.FornecedorAcompanharCompraLB.Name = "FornecedorAcompanharCompraLB"
        Me.FornecedorAcompanharCompraLB.Size = New System.Drawing.Size(64, 13)
        Me.FornecedorAcompanharCompraLB.TabIndex = 20
        Me.FornecedorAcompanharCompraLB.Text = "Fornecedor:"
        '
        'ProdutoAcompanharCompraTF
        '
        Me.ProdutoAcompanharCompraTF.Enabled = False
        Me.ProdutoAcompanharCompraTF.Location = New System.Drawing.Point(76, 28)
        Me.ProdutoAcompanharCompraTF.Name = "ProdutoAcompanharCompraTF"
        Me.ProdutoAcompanharCompraTF.Size = New System.Drawing.Size(174, 20)
        Me.ProdutoAcompanharCompraTF.TabIndex = 18
        '
        'ProdutoAcompanharCompraLB
        '
        Me.ProdutoAcompanharCompraLB.AutoSize = True
        Me.ProdutoAcompanharCompraLB.Location = New System.Drawing.Point(6, 31)
        Me.ProdutoAcompanharCompraLB.Name = "ProdutoAcompanharCompraLB"
        Me.ProdutoAcompanharCompraLB.Size = New System.Drawing.Size(47, 13)
        Me.ProdutoAcompanharCompraLB.TabIndex = 17
        Me.ProdutoAcompanharCompraLB.Text = "Produto:"
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.PictureBox13)
        Me.TabPage8.Controls.Add(Me.FinalizarEmprestimoBT)
        Me.TabPage8.Controls.Add(Me.ConfirmarProdutoEmprestarProdutoIMG)
        Me.TabPage8.Controls.Add(Me.QtdeEmprestarProdutoTF)
        Me.TabPage8.Controls.Add(Me.Label5)
        Me.TabPage8.Controls.Add(Me.Label10)
        Me.TabPage8.Controls.Add(Me.CodigoProdutoEmprestarProdutoTF)
        Me.TabPage8.Controls.Add(Me.ProdutosEmprestimoDT)
        Me.TabPage8.Controls.Add(Me.PictureBox4)
        Me.TabPage8.Controls.Add(Me.BuscarProdutoEmprestarProdutoIMG)
        Me.TabPage8.Controls.Add(Me.NomeProdutoEmprestarProdutoTF)
        Me.TabPage8.Controls.Add(Me.Label14)
        Me.TabPage8.Controls.Add(Me.BuscarClienteEmprestarProdutoIMG)
        Me.TabPage8.Controls.Add(Me.ClienteEmprestarProdutoTF)
        Me.TabPage8.Controls.Add(Me.ClienteEmprestimoLB)
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
        'ProdutosEmprestadosTab
        '
        Me.ProdutosEmprestadosTab.Controls.Add(Me.BuscaAllRB)
        Me.ProdutosEmprestadosTab.Controls.Add(Me.BuscaIDRB)
        Me.ProdutosEmprestadosTab.Controls.Add(Me.TextBox7)
        Me.ProdutosEmprestadosTab.Controls.Add(Me.BuscaProdutoRB)
        Me.ProdutosEmprestadosTab.Controls.Add(Me.BuscaClienteRB)
        Me.ProdutosEmprestadosTab.Controls.Add(Me.TextBox3)
        Me.ProdutosEmprestadosTab.Controls.Add(Me.PictureBox14)
        Me.ProdutosEmprestadosTab.Controls.Add(Me.TextBox4)
        Me.ProdutosEmprestadosTab.Controls.Add(Me.PictureBox15)
        Me.ProdutosEmprestadosTab.Controls.Add(Me.TextBox6)
        Me.ProdutosEmprestadosTab.Controls.Add(Me.DataGridView1)
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
        Me.BuscaAllRB.Checked = True
        Me.BuscaAllRB.Location = New System.Drawing.Point(463, 10)
        Me.BuscaAllRB.Name = "BuscaAllRB"
        Me.BuscaAllRB.Size = New System.Drawing.Size(209, 17)
        Me.BuscaAllRB.TabIndex = 51
        Me.BuscaAllRB.TabStop = True
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
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(197, 9)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(67, 20)
        Me.TextBox7.TabIndex = 48
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
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(601, 85)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(37, 20)
        Me.TextBox3.TabIndex = 45
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
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(197, 85)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(398, 20)
        Me.TextBox4.TabIndex = 43
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
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(197, 47)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(441, 20)
        Me.TextBox6.TabIndex = 40
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDSolicitacao, Me.StatusSolicitacao, Me.ClienteProdutoEmprestado, Me.DataEmprestimo, Me.VerProdutos, Me.FinalizarSolicitacao})
        Me.DataGridView1.Location = New System.Drawing.Point(11, 115)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(661, 209)
        Me.DataGridView1.TabIndex = 22
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
        Me.DataEmprestimo.HeaderText = "Data do Emprestimo"
        Me.DataEmprestimo.Name = "DataEmprestimo"
        Me.DataEmprestimo.ReadOnly = True
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
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.DataGridView2)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(685, 335)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Produtos Enviados a Assistência"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdutoAssistencia, Me.ClienteProdutoAssistencia, Me.DataEnvioAssistencia, Me.ResponsavelAssistencia, Me.EditarProdutoAssistencia, Me.RemoverProdutoAssistencia})
        Me.DataGridView2.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(673, 323)
        Me.DataGridView2.TabIndex = 22
        '
        'ProdutoAssistencia
        '
        Me.ProdutoAssistencia.HeaderText = "Produto"
        Me.ProdutoAssistencia.Name = "ProdutoAssistencia"
        Me.ProdutoAssistencia.ReadOnly = True
        '
        'ClienteProdutoAssistencia
        '
        Me.ClienteProdutoAssistencia.HeaderText = "Cliente"
        Me.ClienteProdutoAssistencia.Name = "ClienteProdutoAssistencia"
        Me.ClienteProdutoAssistencia.ReadOnly = True
        '
        'DataEnvioAssistencia
        '
        Me.DataEnvioAssistencia.HeaderText = "Data de Envio"
        Me.DataEnvioAssistencia.Name = "DataEnvioAssistencia"
        Me.DataEnvioAssistencia.ReadOnly = True
        '
        'ResponsavelAssistencia
        '
        Me.ResponsavelAssistencia.HeaderText = "Responsável"
        Me.ResponsavelAssistencia.Name = "ResponsavelAssistencia"
        Me.ResponsavelAssistencia.ReadOnly = True
        '
        'EditarProdutoAssistencia
        '
        Me.EditarProdutoAssistencia.HeaderText = "Editar"
        Me.EditarProdutoAssistencia.Name = "EditarProdutoAssistencia"
        Me.EditarProdutoAssistencia.ReadOnly = True
        Me.EditarProdutoAssistencia.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EditarProdutoAssistencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'RemoverProdutoAssistencia
        '
        Me.RemoverProdutoAssistencia.HeaderText = "Remover"
        Me.RemoverProdutoAssistencia.Name = "RemoverProdutoAssistencia"
        Me.RemoverProdutoAssistencia.ReadOnly = True
        Me.RemoverProdutoAssistencia.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RemoverProdutoAssistencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
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
        CType(Me.ConfimarProdutoAcompanharCotacaoTF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtdeProdutoAcompanharCotacaoTF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosAcompanharCotacaoDT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ComprasAndamentoTab.ResumeLayout(False)
        CType(Me.ComprasDT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfirmarProdutoEmprestarProdutoIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtdeEmprestarProdutoTF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosEmprestimoDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarProdutoEmprestarProdutoIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarClienteEmprestarProdutoIMG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProdutosEmprestadosTab.ResumeLayout(False)
        Me.ProdutosEmprestadosTab.PerformLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FimDT As DateTimePicker
    Friend WithEvents InicioDT As DateTimePicker
    Friend WithEvents DeLB As Label
    Friend WithEvents AteLB As Label
    Friend WithEvents GerarRelatorioCompraBT As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ProdutoAssistencia As DataGridViewTextBoxColumn
    Friend WithEvents ClienteProdutoAssistencia As DataGridViewTextBoxColumn
    Friend WithEvents DataEnvioAssistencia As DataGridViewTextBoxColumn
    Friend WithEvents ResponsavelAssistencia As DataGridViewTextBoxColumn
    Friend WithEvents EditarProdutoAssistencia As DataGridViewButtonColumn
    Friend WithEvents RemoverProdutoAssistencia As DataGridViewButtonColumn
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn3 As DataGridViewButtonColumn
    Friend WithEvents DataGridViewButtonColumn4 As DataGridViewButtonColumn
    Friend WithEvents EditarAcompanharCompra As DataGridViewButtonColumn
    Friend WithEvents RemoverAcompanharCompra As DataGridViewButtonColumn
    Friend WithEvents AteAcompanharCompraDT As DateTimePicker
    Friend WithEvents AteAcompanharCompraLB As Label
    Friend WithEvents DeAcompanharCompraDT As DateTimePicker
    Friend WithEvents DeAcompanharCompraLB As Label
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents NotaFiscalAcompanharCompraTF As TextBox
    Friend WithEvents NotaFiscalAcompanharCompraLB As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents FornecedorAcompanharCompraTF As TextBox
    Friend WithEvents FornecedorAcompanharCompraLB As Label
    Friend WithEvents ProdutoAcompanharCompraTF As TextBox
    Friend WithEvents ProdutoAcompanharCompraLB As Label
    Friend WithEvents BuscarClienteEmprestarProdutoIMG As PictureBox
    Friend WithEvents ClienteEmprestarProdutoTF As TextBox
    Friend WithEvents ClienteEmprestimoLB As Label
    Friend WithEvents FornecedorIMG As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Fornecedor As DataGridViewTextBoxColumn
    Friend WithEvents NotaFiscal As DataGridViewTextBoxColumn
    Friend WithEvents VerProd As DataGridViewButtonColumn
    Friend WithEvents VerPgto As DataGridViewButtonColumn
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
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents BuscaProdutoRB As RadioButton
    Friend WithEvents BuscaClienteRB As RadioButton
    Friend WithEvents BuscaIDRB As RadioButton
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents BuscaAllRB As RadioButton
    Friend WithEvents IDSolicitacao As DataGridViewTextBoxColumn
    Friend WithEvents StatusSolicitacao As DataGridViewTextBoxColumn
    Friend WithEvents ClienteProdutoEmprestado As DataGridViewTextBoxColumn
    Friend WithEvents DataEmprestimo As DataGridViewCheckBoxColumn
    Friend WithEvents VerProdutos As DataGridViewButtonColumn
    Friend WithEvents FinalizarSolicitacao As DataGridViewButtonColumn
End Class
