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
        strSQL.Append("")

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

        strSQL.Append("CREATE TABLE Funcionarios (
  matricula BIGINT PRIMARY KEY IDENTITY NOT NULL,
  cpf VARCHAR(11) NOT NULL UNIQUE,
  nome VARCHAR(100) NOT NULL,
  telefone VARCHAR(20) NOT NULL,
  dataContratacao DATETIME NOT NULL,
  perfil VARCHAR(20) NOT NULL,
  cargo VARCHAR(50) NOT NULL,
  logradouro VARCHAR(90) NOT NULL,
  numero VARCHAR(10) NOT NULL,
  bairro VARCHAR(30) NULL,
  cidade VARCHAR(30) NOT NULL,
  estado VARCHAR(2) NOT NULL,
  cep VARCHAR(8) NOT NULL,
  tipoEndereco VARCHAR(20) NOT NULL,
  senha VARCHAR(20) NOT NULL,
  matriculaSupervisor BIGINT NULL,
  CONSTRAINT Funcionarios_FK FOREIGN KEY (matriculaSupervisor) REFERENCES Funcionarios (matricula))")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateOrcamentos() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE Orcamentos (
  id BIGINT PRIMARY KEY IDENTITY NOT NULL,
  dataOrcamento DATETIME NOT NULL,
  matriculaVendedor BIGINT NOT NULL,
  idCliente BIGINT NOT NULL,
  statusOrcamento VARCHAR(20) NOT NULL,
  CONSTRAINT Orcamentos_FK FOREIGN KEY (matriculaVendedor) REFERENCES Funcionarios (matricula),
  CONSTRAINT Orcamentos_FK2 FOREIGN KEY (idCliente) REFERENCES Clientes (id))
")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateCotacoes() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE Cotacoes (
  id BIGINT PRIMARY KEY IDENTITY NOT NULL,
  dataCotacao DATETIME NOT NULL,
  cnpjFornecedor VARCHAR(14) NOT NULL,
  statusCotacao VARCHAR(20) NOT NULL,
  CONSTRAINT Cotacoes_FK FOREIGN KEY (cnpjFornecedor) REFERENCES Fornecedores (cnpj))
")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateNotasFiscaisCompras() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE NotasFiscaisCompras (
  id BIGINT PRIMARY KEY IDENTITY NOT NULL ,
  statusNF VARCHAR(20) NOT NULL,
  emissaoNF DATETIME NOT NULL,
  numeroNF INT NOT NULL,
  dataAprovacao DATETIME NOT NULL,
  idCotacao BIGINT NOT NULL,
  CONSTRAINT NotasFiscaisCompras_FK FOREIGN KEY (idCotacao) REFERENCES Cotacoes (id))
")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateNotasFiscaisVendas() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE NotasFiscaisVendas (
  id BIGINT PRIMARY KEY IDENTITY NOT NULL,
  statusNF VARCHAR(20) NOT NULL,
  emissaoNF DATETIME NOT NULL,
  numeroNF INT NOT NULL,
  dataAprovacao DATETIME NOT NULL,
  dataFinalObra DATETIME NULL,
  idOrcamento BIGINT NOT NULL,
  CONSTRAINT NotasFiscaisVendas_FK FOREIGN KEY (idOrcamento) REFERENCES Orcamentos (id))
")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateRegistrosPontos() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE RegistrosPontos (
  dataRegistro DATETIME NOT NULL,
  tipo VARCHAR(20) NOT NULL,
  matriculaFuncionario BIGINT NOT NULL,
  PRIMARY KEY (matriculaFuncionario, dataRegistro, tipo),
  CONSTRAINT RegistrosPontos_FK FOREIGN KEY (matriculaFuncionario) REFERENCES Funcionarios (matricula))
")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateVisitasTecnicas() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE VisitasTecnicas (
  idNotaFiscal BIGINT NOT NULL,
  dataVisita DATETIME NOT NULL,
  tipo VARCHAR(20) NOT NULL,
  preco FLOAT NOT NULL DEFAULT 0.0,
  parecerObra VARCHAR(500) NOT NULL,
  matriculaSupervisor BIGINT NOT NULL,
  PRIMARY KEY (idNotaFiscal, dataVisita, tipo),
  CONSTRAINT VisitasTecnicas_FK FOREIGN KEY (idNotaFiscal) REFERENCES NotasFiscaisVendas (id),
  CONSTRAINT VisitasTecnicas_FK2 FOREIGN KEY (matriculaSupervisor) REFERENCES Funcionarios (matricula))
")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateOrdensServicos() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE OrdensServicos (
  id BIGINT PRIMARY KEY IDENTITY NOT NULL,
  cnpjFornecedor VARCHAR(14) NOT NULL,
  idCliente BIGINT NOT NULL,
  dataSolicitacao DATETIME NOT NULL,
  statusOrdem VARCHAR(20) NOT NULL,
  CONSTRAINT OrdensServicos_FK FOREIGN KEY (cnpjFornecedor) REFERENCES Fornecedores (cnpj),
  CONSTRAINT OrdensServicos_FK2 FOREIGN KEY (idCliente) REFERENCES Clientes (id))
")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateSolicitacoesEmprestimos() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE SolicitacoesEmprestimos (
  id BIGINT PRIMARY KEY IDENTITY NOT NULL, 
  dataSolicitacao DATETIME NOT NULL,
  idCliente BIGINT NOT NULL,
  statusSolicitacao VARCHAR(20) NOT NULL,
  CONSTRAINT SolicitacoesEmprestimos_FK FOREIGN KEY (idCliente) REFERENCES Clientes (id))
")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreatePagamentosEfetuados() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE PagamentosEfetuados (
  idNotaFiscal BIGINT NOT NULL,
  dataPagamento DATETIME NOT NULL,
  valor FLOAT NOT NULL,
  statusPagamento VARCHAR(20) NOT NULL,
  tipo VARCHAR(20) NOT NULL,
  PRIMARY KEY (idNotaFiscal, dataPagamento, valor),
  CONSTRAINT PagamentosEfetuados_FK FOREIGN KEY (idNotaFiscal) REFERENCES NotasFiscaisCompras (id))
")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreatePagamentosRecebidos() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE PagamentosRecebidos (
  idNotaFiscal BIGINT NOT NULL,
  dataPagamento DATETIME NOT NULL,
  valor FLOAT NOT NULL,
  statusPagamento VARCHAR(20) NOT NULL,
  tipo VARCHAR(20) NOT NULL,
  PRIMARY KEY (idNotaFiscal, dataPagamento, valor),
  CONSTRAINT PagamentosRealizados_FK FOREIGN KEY (idNotaFiscal) REFERENCES NotasFiscaisVendas (id))
")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateSalarios() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE Salarios (
  matriculaFuncionario BIGINT NOT NULL,
  valor FLOAT NOT NULL,
  inicio DATETIME NOT NULL,
  fim DATETIME NULL,
  motivo VARCHAR(500) NOT NULL,
  PRIMARY KEY (matriculaFuncionario, valor, inicio),
  CONSTRAINT Salarios_FK FOREIGN KEY (matriculaFuncionario) REFERENCES Funcionarios (matricula))
")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateItensCotados() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE ItensCotados (
  codigoProduto BIGINT NOT NULL,
  idCotacao BIGINT NOT NULL,
  quantidade INT NOT NULL,
  PRIMARY KEY (codigoProduto, idCotacao),
  CONSTRAINT ItensCotados_FK FOREIGN KEY (codigoProduto) REFERENCES Produtos (codigo),
  CONSTRAINT ItensCotados_FK2 FOREIGN KEY (idCotacao) REFERENCES Cotacoes (id))
")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateItensOrcados() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE ItensOrcados (
  codigoProduto BIGINT NOT NULL,
  idOrcamento BIGINT NOT NULL,
  quantidade INT NOT NULL DEFAULT 1,
  PRIMARY KEY (codigoProduto, idOrcamento),
  CONSTRAINT ItensOrcados_FK FOREIGN KEY (codigoProduto) REFERENCES Produtos (codigo),
  CONSTRAINT ItensOrcados_FK2 FOREIGN KEY (idOrcamento) REFERENCES Orcamentos (id))
")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateItensEmprestimos() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE ItensEmprestimos (
  codigoProduto BIGINT NOT NULL,
  idSolicitacao BIGINT NOT NULL,
  quantidade INT NOT NULL,
  dataEmprestimo DATETIME NOT NULL,
  dataDevolucao DATETIME NULL,
  PRIMARY KEY (codigoProduto, idSolicitacao),
  CONSTRAINT ItensEmprestimos_FK FOREIGN KEY (idSolicitacao) REFERENCES SolicitacoesEmprestimos (id),
  CONSTRAINT ItensEmprestimos_FK2 FOREIGN KEY (codigoProduto) REFERENCES Produtos (codigo))
")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateItensOrdens() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE ItensOrdens (
  codigoProduto BIGINT NOT NULL,
  idOrdem BIGINT NOT NULL,
  quantidade INT NOT NULL,
  dataEntrega DATETIME NOT NULL,
  dataRecebimento DATETIME NULL,
  dataDevolucao DATETIME NULL,
  PRIMARY KEY (codigoProduto, idOrdem),
  CONSTRAINT ItensOrdens_FK FOREIGN KEY (codigoProduto) REFERENCES Produtos (codigo),
  CONSTRAINT ItensOrdens_FK2 FOREIGN KEY (idOrdem) REFERENCES OrdensServicos (id))
")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateItensComprados() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE ItensComprados (
  codigoProduto BIGINT NOT NULL,
  idNotaFiscal BIGINT NOT NULL,
  quantidade INT NOT NULL,
  PRIMARY KEY (codigoProduto, idNotaFiscal),
  CONSTRAINT ItensComprados_FK FOREIGN KEY (codigoProduto) REFERENCES Produtos (codigo),
  CONSTRAINT ItensComprados_FK2 FOREIGN KEY (idNotaFiscal) REFERENCES NotasFiscaisCompras (id))
")

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

    'OK
    Public Function CreateItensVendidos() As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("CREATE TABLE ItensVendidos (
  codigoProduto BIGINT NOT NULL,
  idNotaFiscal BIGINT NOT NULL,
  quantidade INT NOT NULL DEFAULT 1,
  PRIMARY KEY (codigoProduto, idNotaFiscal),
  CONSTRAINT ItensVendidos_FK FOREIGN KEY (idNotaFiscal) REFERENCES NotasFiscaisVendas (id),
  CONSTRAINT ItensVendidos_FK2 FOREIGN KEY (codigoProduto) REFERENCES Produtos (codigo))
")

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
End Module
