Option Strict On
Option Explicit On

Imports System.Data.SqlClient
Imports System.Text

Public Module SQLTableManager
    'OK
    Public Function CreateClientes() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE Clientes (")
        strSQL.Append("id BIGINT PRIMARY KEY IDENTITY NOT NULL, ")
        strSQL.Append("nome VARCHAR(100) NOT NULL, ")
        strSQL.Append("telefone VARCHAR(20) NOT NULL, ")
        strSQL.Append("dataCadastro DATETIME NOT NULL)")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateClientesPF() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE ClientesPF (")
        strSQL.Append("cpf VARCHAR(11) UNIQUE NOT NULL, ")
        strSQL.Append("idCliente BIGINT UNIQUE NOT NULL, ")
        strSQL.Append("PRIMARY KEY (cpf, idCliente), ")
        strSQL.Append("CONSTRAINT ClientesPF_FK FOREIGN KEY (idCliente) REFERENCES Clientes (id))")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateClientesPJ() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE ClientesPJ (")
        strSQL.Append("cnpj VARCHAR(14) UNIQUE NOT NULL, ")
        strSQL.Append("idCliente BIGINT UNIQUE NOT NULL, ")
        strSQL.Append("razaoSocial VARCHAR(100) NOT NULL, ")
        strSQL.Append("PRIMARY KEY (cnpj, idCliente), ")
        strSQL.Append("CONSTRAINT ClientesPJ_FK FOREIGN KEY (idCliente) REFERENCES Clientes (id))")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateEnderecosClientes() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE EnderecosClientes (")
        strSQL.Append("id BIGINT IDENTITY UNIQUE NOT NULL, ")
        strSQL.Append("idCliente BIGINT NOT NULL, ")
        strSQL.Append("logradouro VARCHAR(90), ")
        strSQL.Append("numero VARCHAR(10) NOT NULL DEFAULT 'S/N', ")
        strSQL.Append("bairro VARCHAR(30) NULL, ")
        strSQL.Append("cidade VARCHAR(30) NOT NULL, ")
        strSQL.Append("estado VARCHAR(2) NOT NULL, ")
        strSQL.Append("cep VARCHAR(8) NOT NULL, ")
        strSQL.Append("tipo VARCHAR(20) NOT NULL, ")
        strSQL.Append("PRIMARY KEY (id, idCliente), ")
        strSQL.Append("CONSTRAINT EnderecosClientes_FK FOREIGN KEY (idCliente) REFERENCES Clientes (id))")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateProdutos() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE Produtos (")
        strSQL.Append("codigo BIGINT PRIMARY KEY IDENTITY NOT NULL, ")
        strSQL.Append("nome VARCHAR(100) NOT NULL, ")
        strSQL.Append("precoUnit FLOAT NOT NULL, ")
        strSQL.Append("descricao VARCHAR(500) NULL, ")
        strSQL.Append("tipo VARCHAR(50) NULL, ")
        strSQL.Append("unidade VARCHAR(50) NULL, ")
        strSQL.Append("imagem IMAGE NULL)")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateAlertas() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE Alertas (")
        strSQL.Append("dataAlerta DATETIME NOT NULL, ")
        strSQL.Append("observacao VARCHAR(500) NOT NULL, ")
        strSQL.Append("codigoProduto BIGINT NOT NULL, ")
        strSQL.Append("PRIMARY KEY (codigoProduto, dataAlerta, observacao), ")
        strSQL.Append("CONSTRAINT Alertas_FK FOREIGN KEY (codigoProduto) REFERENCES Produtos (codigo))")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateFornecedores() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE Fornecedores (")
        strSQL.Append("cnpj VARCHAR(14) PRIMARY KEY NOT NULL, ")
        strSQL.Append("razaoSocial VARCHAR(100) NOT NULL, ")
        strSQL.Append("nomeFantasia VARCHAR(100) NOT NULL, ")
        strSQL.Append("telefone VARCHAR(20) NOT NULL, ")
        strSQL.Append("inicioRelacionamento DATETIME NOT NULL, ")
        strSQL.Append("tipoFornecedor VARCHAR(50),")
        strSQL.Append("logradouro VARCHAR(90),")
        strSQL.Append("numero VARCHAR(10) NOT NULL,")
        strSQL.Append("bairro VARCHAR(30) NULL,")
        strSQL.Append("cidade VARCHAR(30) NOT NULL,")
        strSQL.Append("estado VARCHAR(2) NOT NULL,")
        strSQL.Append("cep VARCHAR(8) NOT NULL,")
        strSQL.Append("tipoEndereco VARCHAR(20) NOT NULL,")
        strSQL.Append("cnpjAssistencia VARCHAR(14) NOT NULL,")
        strSQL.Append("CONSTRAINT FornecedoresFK FOREIGN KEY (cnpjAssistencia) REFERENCES Fornecedores (cnpj))")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateFuncionarios() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE Funcionarios (")
        strSQL.Append("matricula BIGINT PRIMARY KEY IDENTITY NOT NULL, ")
        strSQL.Append("cpf VARCHAR(11) NOT NULL UNIQUE, ")
        strSQL.Append("nome VARCHAR(100) NOT NULL, ")
        strSQL.Append("telefone VARCHAR(20) NOT NULL, ")
        strSQL.Append("dataContratacao DATETIME NOT NULL, ")
        strSQL.Append("perfil VARCHAR(40) NOT NULL, ")
        strSQL.Append("cargo VARCHAR(50) NOT NULL, ")
        strSQL.Append("logradouro VARCHAR(90) NOT NULL, ")
        strSQL.Append("numero VARCHAR(10) NOT NULL, ")
        strSQL.Append("bairro VARCHAR(30) NULL, ")
        strSQL.Append("cidade VARCHAR(30) NOT NULL, ")
        strSQL.Append("estado VARCHAR(2) NOT NULL, ")
        strSQL.Append("cep VARCHAR(8) NOT NULL, ")
        strSQL.Append("tipoEndereco VARCHAR(20) NOT NULL, ")
        strSQL.Append("senha VARCHAR(20) NOT NULL, ")
        strSQL.Append("revogado INT NOT NULL DEFAULT 0, ")
        strSQL.Append("dataRevogacao DATETIME NULL, ")
        strSQL.Append("matriculaSupervisor BIGINT NULL, ")
        strSQL.Append("CONSTRAINT Funcionarios_FK FOREIGN KEY (matriculaSupervisor) REFERENCES Funcionarios (matricula))")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateOrcamentos() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE Orcamentos (")
        strSQL.Append("id BIGINT PRIMARY KEY IDENTITY Not NULL, ")
        strSQL.Append("dataOrcamento DATETIME NOT NULL, ")
        strSQL.Append("matriculaVendedor BIGINT Not NULL, ")
        strSQL.Append("idCliente BIGINT NOT NULL, ")
        strSQL.Append("statusOrcamento VARCHAR(20) Not NULL, ")
        strSQL.Append("CONSTRAINT Orcamentos_FK FOREIGN KEY (matriculaVendedor) REFERENCES Funcionarios (matricula), ")
        strSQL.Append("CONSTRAINT Orcamentos_FK2 FOREIGN KEY (idCliente) REFERENCES Clientes (id))")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateCotacoes() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE Cotacoes (")
        strSQL.Append("id BIGINT PRIMARY KEY IDENTITY NOT NULL, ")
        strSQL.Append("dataCotacao DATETIME Not NULL, ")
        strSQL.Append("cnpjFornecedor VARCHAR(14) NOT NULL, ")
        strSQL.Append("statusCotacao VARCHAR(20) NOT NULL, ")
        strSQL.Append("CONSTRAINT Cotacoes_FK FOREIGN KEY (cnpjFornecedor) REFERENCES Fornecedores (cnpj))")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateNotasFiscaisCompras() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE NotasFiscaisCompras (")
        strSQL.Append("id BIGINT PRIMARY KEY IDENTITY Not NULL , ")
        strSQL.Append("statusNF VARCHAR(20) NOT NULL, ")
        strSQL.Append("emissaoNF DATETIME Not NULL, ")
        strSQL.Append("numeroNF INT NOT NULL, ")
        strSQL.Append("dataAprovacao DATETIME Not NULL, ")
        strSQL.Append("idCotacao BIGINT NOT NULL, ")
        strSQL.Append("CONSTRAINT NotasFiscaisCompras_FK FOREIGN KEY (idCotacao) REFERENCES Cotacoes (id))")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateNotasFiscaisVendas() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE NotasFiscaisVendas (")
        strSQL.Append("id BIGINT PRIMARY KEY IDENTITY Not NULL, ")
        strSQL.Append("statusNF VARCHAR(20) NOT NULL, ")
        strSQL.Append("emissaoNF DATETIME Not NULL, ")
        strSQL.Append("numeroNF INT NOT NULL, ")
        strSQL.Append("dataAprovacao DATETIME Not NULL, ")
        strSQL.Append("dataFinalObra DATETIME NULL, ")
        strSQL.Append("idOrcamento BIGINT Not NULL, ")
        strSQL.Append("CONSTRAINT NotasFiscaisVendas_FK FOREIGN KEY (idOrcamento) REFERENCES Orcamentos (id))")


        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateRegistrosPontos() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE RegistrosPontos (")
        strSQL.Append("dataRegistro DATETIME Not NULL, ")
        strSQL.Append("tipo VARCHAR(20) NOT NULL, ")
        strSQL.Append("matriculaFuncionario BIGINT Not NULL, ")
        strSQL.Append("PRIMARY KEY (matriculaFuncionario, dataRegistro, tipo), ")
        strSQL.Append("CONSTRAINT RegistrosPontos_FK FOREIGN KEY (matriculaFuncionario) REFERENCES Funcionarios (matricula))")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateVisitasTecnicas() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE VisitasTecnicas (")
        strSQL.Append("idNotaFiscal BIGINT Not NULL, ")
        strSQL.Append("dataVisita DATETIME NOT NULL, ")
        strSQL.Append("tipo VARCHAR(20) Not NULL, ")
        strSQL.Append("preco FLOAT NOT NULL DEFAULT 0.0, ")
        strSQL.Append("parecerObra VARCHAR(500) Not NULL, ")
        strSQL.Append("matriculaSupervisor BIGINT NOT NULL, ")
        strSQL.Append("PRIMARY KEY (idNotaFiscal, dataVisita, tipo), ")
        strSQL.Append("CONSTRAINT VisitasTecnicas_FK FOREIGN KEY (idNotaFiscal) REFERENCES NotasFiscaisVendas (id), ")
        strSQL.Append("CONSTRAINT VisitasTecnicas_FK2 FOREIGN KEY (matriculaSupervisor) REFERENCES Funcionarios (matricula))")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateOrdensServicos() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE OrdensServicos (")
        strSQL.Append("id BIGINT PRIMARY KEY IDENTITY Not NULL, ")
        strSQL.Append("cnpjFornecedor VARCHAR(14) NOT NULL, ")
        strSQL.Append("idCliente BIGINT Not NULL, ")
        strSQL.Append("dataSolicitacao DATETIME NOT NULL, ")
        strSQL.Append("statusOrdem VARCHAR(20) Not NULL, ")
        strSQL.Append("CONSTRAINT OrdensServicos_FK FOREIGN KEY (cnpjFornecedor) REFERENCES Fornecedores (cnpj), ")
        strSQL.Append("CONSTRAINT OrdensServicos_FK2 FOREIGN KEY (idCliente) REFERENCES Clientes (id))")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateSolicitacoesEmprestimos() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE SolicitacoesEmprestimos (")
        strSQL.Append("id BIGINT PRIMARY KEY IDENTITY Not NULL, ")
        strSQL.Append("dataSolicitacao DATETIME NOT NULL, ")
        strSQL.Append("idCliente BIGINT Not NULL, ")
        strSQL.Append("statusSolicitacao VARCHAR(20) NOT NULL, ")
        strSQL.Append("CONSTRAINT SolicitacoesEmprestimos_FK FOREIGN KEY (idCliente) REFERENCES Clientes (id))")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreatePagamentosEfetuados() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE PagamentosEfetuados (")
        strSQL.Append("idNotaFiscal BIGINT Not NULL, ")
        strSQL.Append("dataPagamento DATETIME NOT NULL, ")
        strSQL.Append("valor FLOAT Not NULL, ")
        strSQL.Append("statusPagamento VARCHAR(20) NOT NULL, ")
        strSQL.Append("tipo VARCHAR(20) Not NULL, ")
        strSQL.Append("PRIMARY KEY (idNotaFiscal, dataPagamento, valor), ")
        strSQL.Append("CONSTRAINT PagamentosEfetuados_FK FOREIGN KEY (idNotaFiscal) REFERENCES NotasFiscaisCompras (id))")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreatePagamentosRecebidos() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE PagamentosRecebidos (")
        strSQL.Append("idNotaFiscal BIGINT Not NULL, ")
        strSQL.Append("dataPagamento DATETIME NOT NULL, ")
        strSQL.Append("valor FLOAT Not NULL, ")
        strSQL.Append("statusPagamento VARCHAR(20) NOT NULL, ")
        strSQL.Append("tipo VARCHAR(20) Not NULL, ")
        strSQL.Append("PRIMARY KEY (idNotaFiscal, dataPagamento, valor), ")
        strSQL.Append("CONSTRAINT PagamentosRealizados_FK FOREIGN KEY (idNotaFiscal) REFERENCES NotasFiscaisVendas (id))")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateSalarios() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE Salarios (")
        strSQL.Append("matriculaFuncionario BIGINT NOT NULL, ")
        strSQL.Append("valor FLOAT NOT NULL, ")
        strSQL.Append("inicio DATETIME NOT NULL, ")
        strSQL.Append("fim DATETIME NULL, ")
        strSQL.Append("motivo VARCHAR(500) NOT NULL, ")
        strSQL.Append("PRIMARY KEY (matriculaFuncionario, valor, inicio), ")
        strSQL.Append("CONSTRAINT Salarios_FK FOREIGN KEY (matriculaFuncionario) REFERENCES Funcionarios (matricula))")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateItensCotados() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE ItensCotados ( ")
        strSQL.Append("codigoProduto BIGINT Not NULL, ")
        strSQL.Append("idCotacao BIGINT NOT NULL, ")
        strSQL.Append("quantidade INT Not NULL, ")
        strSQL.Append("PRIMARY KEY (codigoProduto, idCotacao), ")
        strSQL.Append("CONSTRAINT ItensCotados_FK FOREIGN KEY (codigoProduto) REFERENCES Produtos (codigo), ")
        strSQL.Append("CONSTRAINT ItensCotados_FK2 FOREIGN KEY (idCotacao) REFERENCES Cotacoes (id)) ")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateItensOrcados() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE ItensOrcados (")
        strSQL.Append("codigoProduto BIGINT Not NULL, ")
        strSQL.Append("idOrcamento BIGINT NOT NULL, ")
        strSQL.Append("quantidade INT Not NULL Default 1, ")
        strSQL.Append("PRIMARY KEY (codigoProduto, idOrcamento), ")
        strSQL.Append("CONSTRAINT ItensOrcados_FK FOREIGN KEY (codigoProduto) REFERENCES Produtos (codigo), ")
        strSQL.Append("CONSTRAINT ItensOrcados_FK2 FOREIGN KEY (idOrcamento) REFERENCES Orcamentos (id))")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateItensEmprestimos() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE ItensEmprestimos (")
        strSQL.Append("codigoProduto BIGINT Not NULL, ")
        strSQL.Append("idSolicitacao BIGINT NOT NULL, ")
        strSQL.Append("quantidade INT Not NULL, ")
        strSQL.Append("dataEmprestimo DATETIME NOT NULL, ")
        strSQL.Append("dataDevolucao DATETIME NULL, ")
        strSQL.Append("PRIMARY KEY (codigoProduto, idSolicitacao), ")
        strSQL.Append("CONSTRAINT ItensEmprestimos_FK FOREIGN KEY (idSolicitacao) REFERENCES SolicitacoesEmprestimos (id), ")
        strSQL.Append("CONSTRAINT ItensEmprestimos_FK2 FOREIGN KEY (codigoProduto) REFERENCES Produtos (codigo))")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateItensOrdens() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE ItensOrdens (")
        strSQL.Append("codigoProduto BIGINT Not NULL, ")
        strSQL.Append("idOrdem BIGINT NOT NULL, ")
        strSQL.Append("quantidade INT Not NULL, ")
        strSQL.Append("dataEntrega DATETIME NOT NULL, ")
        strSQL.Append("dataRecebimento DATETIME NULL, ")
        strSQL.Append("dataDevolucao DATETIME NULL, ")
        strSQL.Append("PRIMARY KEY (codigoProduto, idOrdem), ")
        strSQL.Append("CONSTRAINT ItensOrdens_FK FOREIGN KEY (codigoProduto) REFERENCES Produtos (codigo), ")
        strSQL.Append("CONSTRAINT ItensOrdens_FK2 FOREIGN KEY (idOrdem) REFERENCES OrdensServicos (id))")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateItensComprados() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE ItensComprados (")
        strSQL.Append("codigoProduto BIGINT Not NULL, ")
        strSQL.Append("idNotaFiscal BIGINT NOT NULL, ")
        strSQL.Append("quantidade INT Not NULL, ")
        strSQL.Append("PRIMARY KEY (codigoProduto, idNotaFiscal), ")
        strSQL.Append("CONSTRAINT ItensComprados_FK FOREIGN KEY (codigoProduto) REFERENCES Produtos (codigo), ")
        strSQL.Append("CONSTRAINT ItensComprados_FK2 FOREIGN KEY (idNotaFiscal) REFERENCES NotasFiscaisCompras (id))")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateItensVendidos() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE ItensVendidos (")
        strSQL.Append("codigoProduto BIGINT Not NULL, ")
        strSQL.Append("idNotaFiscal BIGINT NOT NULL, ")
        strSQL.Append("quantidade INT Not NULL Default 1, ")
        strSQL.Append("PRIMARY KEY (codigoProduto, idNotaFiscal), ")
        strSQL.Append("CONSTRAINT ItensVendidos_FK FOREIGN KEY (idNotaFiscal) REFERENCES NotasFiscaisVendas (id), ")
        strSQL.Append("CONSTRAINT ItensVendidos_FK2 FOREIGN KEY (codigoProduto) REFERENCES Produtos (codigo))")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function DropItensCotados() As Boolean
        Dim conn As New Connection
        Return conn.ExecuteCommand("DROP TABLE ItensCotados")
    End Function

    'OK
    Public Function DropItensVendidos() As Boolean
        Dim conn As New Connection
        Return conn.ExecuteCommand("DROP TABLE ItensVendidos")
    End Function

    'OK
    Public Function DropItensEmprestimos() As Boolean
        Dim conn As New Connection
        Return conn.ExecuteCommand("DROP TABLE ItensEmprestimos")
    End Function

    'OK
    Public Function DropItensOrdens() As Boolean
        Dim conn As New Connection
        Return conn.ExecuteCommand("DROP TABLE ItensOrdens")
    End Function

    'OK
    Public Function DropItensComprados() As Boolean
        Dim conn As New Connection
        Return conn.ExecuteCommand("DROP TABLE ItensComprados")
    End Function

    'OK
    Public Function DropItensOrcados() As Boolean
        Dim conn As New Connection
        Return conn.ExecuteCommand("DROP TABLE ItensOrcados")
    End Function

    'OK
    Public Function DropPagamentosEfetuados() As Boolean
        Dim conn As New Connection
        Return conn.ExecuteCommand("DROP TABLE PagamentosEfetuados")
    End Function

    'OK
    Public Function DropPagamentosRecebidos() As Boolean
        Dim conn As New Connection
        Return conn.ExecuteCommand("DROP TABLE PagamentosRecebidos")
    End Function

    'OK
    Public Function DropVisitasTecnicas() As Boolean
        Dim conn As New Connection
        Return conn.ExecuteCommand("DROP TABLE VisitasTecnicas")
    End Function

    'OK
    Public Function DropRegistrosPontos() As Boolean
        Dim conn As New Connection
        Return conn.ExecuteCommand("DROP TABLE RegistrosPontos")
    End Function

    'OK
    Public Function DropOrdensServicos() As Boolean
        Dim conn As New Connection
        Return conn.ExecuteCommand("DROP TABLE OrdensServicos")
    End Function

    'OK
    Public Function DropSolicitacoesEmprestimos() As Boolean
        Dim conn As New Connection
        Return conn.ExecuteCommand("DROP TABLE SolicitacoesEmprestimos")
    End Function

    'OK
    Public Function DropEnderecosClientes() As Boolean
        Dim conn As New Connection
        Return conn.ExecuteCommand("DROP TABLE EnderecosClientes")
    End Function

    'OK
    Public Function DropClientesPF() As Boolean
        Dim conn As New Connection
        Return conn.ExecuteCommand("DROP TABLE ClientesPF")
    End Function

    'OK
    Public Function DropClientesPJ() As Boolean
        Dim conn As New Connection
        Return conn.ExecuteCommand("DROP TABLE ClientesPJ")
    End Function

    'OK
    Public Function DropSalarios() As Boolean
        Dim conn As New Connection
        Return conn.ExecuteCommand("DROP TABLE Salarios")
    End Function

    'OK
    Public Function DropAlertas() As Boolean
        Dim conn As New Connection
        Return conn.ExecuteCommand("DROP TABLE Alertas")
    End Function

    'OK
    Public Function DropProdutos() As Boolean
        Dim conn As New Connection
        Return conn.ExecuteCommand("DROP TABLE Produtos")
    End Function

    'OK
    Public Function DropNotasFiscaisCompras() As Boolean
        Dim conn As New Connection
        Return conn.ExecuteCommand("DROP TABLE NotasFiscaisCompras")
    End Function

    'OK
    Public Function DropNotasFiscaisVendas() As Boolean
        Dim conn As New Connection
        Return conn.ExecuteCommand("DROP TABLE NotasFiscaisVendas")
    End Function

    'OK
    Public Function DropOrcamentos() As Boolean
        Dim conn As New Connection
        Return conn.ExecuteCommand("DROP TABLE Orcamentos")
    End Function

    'OK
    Public Function DropCotacoes() As Boolean
        Dim conn As New Connection
        Return conn.ExecuteCommand("DROP TABLE Cotacoes")
    End Function

    'OK
    Public Function DropClientes() As Boolean
        Dim conn As New Connection
        Return conn.ExecuteCommand("DROP TABLE Clientes")
    End Function

    'OK
    Public Function DropFornecedores() As Boolean
        Dim conn As New Connection
        Return conn.ExecuteCommand("DROP TABLE Fornecedores")
    End Function

    'OK
    Public Function DropFuncionarios() As Boolean
        Dim conn As New Connection
        Return conn.ExecuteCommand("DROP TABLE Funcionarios")
    End Function

    'OK
    Public Sub PopulateFuncionarios()
        Dim f1 As New Funcionario("08219004983", "Leonardo Nunes", "41998161345", Now, TipoPerfilFuncionario.Gerente, TipoCargo.GerenteAdm, "Rua Cidade de Maria Helena", "476", "CIC", "Curitiba", "PR", "81250360", TipoImovel.Casa)
        f1.Supervisor = f1
        f1.Matricula = FuncionarioBC.Insert(f1)
        FuncionarioBC.UpdateSupervisor(f1)

        Dim f2 As New Funcionario("04567812311", "Teste 02", "41998161346", Now, TipoPerfilFuncionario.AssistenteAdm, TipoCargo.AssistenteAdm, "Rua Cidade de Maria Helena", "S/N", "CIC", "Curitiba", "PR", "81250360", TipoImovel.Casa)
        f2.Supervisor = f1
        f2.Matricula = FuncionarioBC.Insert(f2)
        FuncionarioBC.UpdateSupervisor(f2)

        Dim f3 As New Funcionario("04597513213", "Teste 03", "41998161347", Now, TipoPerfilFuncionario.SupervisorObra, TipoCargo.SupervisorObra, "Rua Cidade de Maria Helena", "S/N", "CIC", "Curitiba", "PR", "81250360", TipoImovel.Casa)
        f3.Supervisor = f1
        f3.Matricula = FuncionarioBC.Insert(f3)
        FuncionarioBC.UpdateSupervisor(f3)
    End Sub

    'OK
    Public Sub PopulateFornecedores()
        Dim f1 As New Fornecedor("12345678901234", "Farinha LTDA", "Farinha", "998161345", Now, TipoFornecedor.FornecedorAssistencia, "Rua Teste 01", "100", "Boqueirão", "Curitiba", "PR", "81450920", TipoImovel.Escritorio)
        f1.Assistencia = f1
        FornecedorBC.Insert(f1)
        FornecedorBC.UpdateAssistencia(f1)

        Dim f2 As New Fornecedor("79845678901564", "Biscoito LTDA", "Biscoito", "998164589", Now, TipoFornecedor.FornecedorAssistencia, "Rua Teste 05", "780", "CIC", "Curitiba", "PR", "81450789", TipoImovel.Fabrica)
        f2.Assistencia = f2
        FornecedorBC.Insert(f2)
        FornecedorBC.UpdateAssistencia(f2)

        Dim f3 As New Fornecedor("41745678901951", "Peças S/A", "Peças", "998167894", Now, TipoFornecedor.FornecedorAssistencia, "Rua Teste 04", "500", "Santa Cândida", "Curitiba", "PR", "84789654", TipoImovel.Escritorio)
        f3.Assistencia = f3
        FornecedorBC.Insert(f3)
        FornecedorBC.UpdateAssistencia(f3)
    End Sub

    'OK
    Public Sub PopulateProdutos()
        Dim p1 As New Produto("Cabo legal", 5.0, "Cabo", TipoProduto.Cabo, UnidadeProduto.Metro)
        ProdutoBC.Insert(p1)

        Dim p2 As New Produto("Roteador dos bons", 500.0, "Roteador", TipoProduto.Roteador, UnidadeProduto.Peca)
        ProdutoBC.Insert(p2)

        Dim p3 As New Produto("Projetor bacana", 850.0, "Projetor", TipoProduto.Projetor, UnidadeProduto.Peca)
        ProdutoBC.Insert(p3)
    End Sub

    'OK
    Public Sub PopulateRegistrosPontos()
        Dim f1 As Funcionario = FuncionarioBC.FindByMatricula(1)
        Dim f2 As Funcionario = FuncionarioBC.FindByMatricula(2)
        Dim f3 As Funcionario = FuncionarioBC.FindByMatricula(3)

        Dim r1 As New RegistroPonto(New Date(2017, 1, 15, 7, 0, 0), TipoRegistro.Entrada, f1)
        Dim r2 As New RegistroPonto(New Date(2017, 1, 15, 16, 0, 0), TipoRegistro.Saida, f1)
        Dim r3 As New RegistroPonto(New Date(2017, 1, 16, 7, 0, 0), TipoRegistro.Entrada, f1)
        Dim r4 As New RegistroPonto(New Date(2017, 1, 16, 16, 0, 0), TipoRegistro.Saida, f1)
        Dim r5 As New RegistroPonto(New Date(2017, 1, 17, 7, 0, 0), TipoRegistro.Entrada, f1)
        Dim r6 As New RegistroPonto(New Date(2017, 1, 17, 16, 0, 0), TipoRegistro.Saida, f1)
        Dim r7 As New RegistroPonto(New Date(2017, 1, 17, 7, 0, 0), TipoRegistro.Entrada, f2)
        Dim r8 As New RegistroPonto(New Date(2017, 1, 17, 16, 0, 0), TipoRegistro.Saida, f2)
        Dim r9 As New RegistroPonto(New Date(2017, 1, 17, 7, 0, 0), TipoRegistro.Entrada, f3)
        Dim r10 As New RegistroPonto(New Date(2017, 1, 17, 16, 0, 0), TipoRegistro.Saida, f3)

        RegistroPontoBC.Insert(r1)
        RegistroPontoBC.Insert(r2)
        RegistroPontoBC.Insert(r3)
        RegistroPontoBC.Insert(r4)
        RegistroPontoBC.Insert(r5)
        RegistroPontoBC.Insert(r6)
        RegistroPontoBC.Insert(r7)
        RegistroPontoBC.Insert(r8)
        RegistroPontoBC.Insert(r9)
        RegistroPontoBC.Insert(r10)

    End Sub

    'OK
    Public Sub PopulateClientesPF()
        Dim c1 As New ClientePF("Leonardo Nunes", "998161345", Now, "08219004983")
        Dim endereco As New EnderecoCliente(c1, "Rua Teste 01", "100", "Boqueirão", "Curitiba", "PR", "81450920", TipoImovel.Casa)
        c1.Enderecos.Add(endereco)
        ClientePFBC.Insert(c1)
        For Each enderecoCliente As EnderecoCliente In c1.Enderecos
            EnderecoClienteBC.Insert(enderecoCliente)
        Next

        Dim c2 As New ClientePF("Teste 02", "998161345", Now, "48987546153")
        Dim endereco2 As New EnderecoCliente(c2, "Rua Teste 01", "100", "Boqueirão", "Curitiba", "PR", "81450920", TipoImovel.Casa)
        c2.Enderecos.Add(endereco2)
        ClientePFBC.Insert(c2)
        For Each enderecoCliente As EnderecoCliente In c2.Enderecos
            EnderecoClienteBC.Insert(enderecoCliente)
        Next

        Dim c3 As New ClientePF("Teste 03", "998161345", Now, "15987546413")
        Dim endereco3 As New EnderecoCliente(c3, "Rua Teste 01", "100", "Boqueirão", "Curitiba", "PR", "81450920", TipoImovel.Casa)
        c3.Enderecos.Add(endereco3)
        ClientePFBC.Insert(c3)
        For Each enderecoCliente As EnderecoCliente In c3.Enderecos
            EnderecoClienteBC.Insert(enderecoCliente)
        Next
    End Sub

    'OK
    Public Sub PopulateClientesPJ()
        Dim c1 As New ClientePJ("Biscoito LTDA", "998161245", Now, "12345678901234", "Biscoito")
        Dim endereco As New EnderecoCliente(c1, "Rua Teste 01", "100", "Boqueirão", "Curitiba", "PR", "81450920", TipoImovel.Casa)
        c1.Enderecos.Add(endereco)
        ClientePJBC.Insert(c1)
        For Each enderecoCliente As EnderecoCliente In c1.Enderecos
            EnderecoClienteBC.Insert(enderecoCliente)
        Next

        Dim c2 As New ClientePJ("Bolacha LTDA", "998161299", Now, "48945678901159", "Bolacha")
        Dim endereco2 As New EnderecoCliente(c2, "Rua Teste 01", "100", "Boqueirão", "Curitiba", "PR", "81450920", TipoImovel.Casa)
        c2.Enderecos.Add(endereco2)
        ClientePJBC.Insert(c2)
        For Each enderecoCliente As EnderecoCliente In c2.Enderecos
            EnderecoClienteBC.Insert(enderecoCliente)
        Next

        Dim c3 As New ClientePJ("Pão LTDA", "998161200", Now, "72445678901789", "Pão")
        Dim endereco3 As New EnderecoCliente(c3, "Rua Teste 01", "100", "Boqueirão", "Curitiba", "PR", "81450920", TipoImovel.Casa)
        c3.Enderecos.Add(endereco3)
        ClientePJBC.Insert(c3)
        For Each enderecoCliente As EnderecoCliente In c3.Enderecos
            EnderecoClienteBC.Insert(enderecoCliente)
        Next
    End Sub
End Module
