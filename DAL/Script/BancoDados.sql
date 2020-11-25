CREATE DATABASE Locadora
GO

USE Locadora
GO

CREATE TABLE Funcionarios (
    CdFuncionario INT PRIMARY KEY IDENTITY,
	NmFuncionario VARCHAR (50)  NOT NULL,
    CPF        VARCHAR (14)  NOT NULL,
    DtNascimento  DATE          NOT NULL,
    DsEstadoCivil CHAR (1)      NOT NULL,
    Sexo        CHAR (1)      NOT NULL,
    Email       VARCHAR (100) NOT NULL,
    Telefone  VARCHAR (20)  NOT NULL,
    RG VARCHAR(10) NOT NULL,
    Endereco varchar(MAX) NOT NULL,
    Cidade varchar(MAX) NOT NULL,
    CEP varchar(9) NOT NULL,
    Estado varchar(3) NOT NULL,
    Celular varchar(12) NOT NULL,
    DsStatus bit NOT NULL
)

CREATE TABLE [dbo].[Itens] (
    [CdItem] INT IDENTITY (1, 1) NOT NULL,
    [CodigoBarras] INT NOT NULL,
    [Titulo] VARCHAR (50) NOT NULL,
    [Genero] VARCHAR (MAX) NOT NULL,
    [Ano] INT NOT NULL,
    [Tipo] CHAR (1) NOT NULL,
    [Preco] DECIMAL (18) NOT NULL,
    [DtAdquirida] DATETIME NOT NULL,
    [VlCusto] DECIMAL (18) NOT NULL,
    [Situacao] CHAR (1) NOT NULL,
    [Atores] VARCHAR (MAX) NOT NULL,
    [Diretor] VARCHAR (MAX) NOT NULL,
    [CapaFilme] VARBINARY (MAX) NULL,
    [Caminho] VARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([CdItem] ASC)
);

CREATE TABLE Clientes (
    CdCliente INT PRIMARY KEY IDENTITY,
    NmCliente varchar(500) NOT NULL,
    DtNascimento date NOT NULL,
    Sexo varchar(20) NOT NULL,
    DsEstadoCivil CHAR (20) NOT NULL,
    RG varchar(20) NOT NULL,
    CPF varchar(20) NOT NULL,
    Endereco varchar(200) NOT NULL,
    Cidade varchar(50) NOT NULL,
    CEP varchar(50) NOT NULL,
    Estado varchar(2) NOT NULL,
    Telefone varchar(50) NOT NULL,
    Email varchar(200) NOT NULL,
    Celular varchar(50) NOT NULL,
    DsStatus varchar(50) NOT NULL
)

CREATE TABLE Artistas (
    CdArtista INT PRIMARY KEY IDENTITY,
    NmArtistas varchar (50) NOT NULL,
    DtNascimento date NOT NULL,
    PaisNascimento varchar(20) NOT NULL,
    Foto image
)

CREATE TABLE Generos (
    CdGenero INT PRIMARY KEY IDENTITY,
    NmGenero varchar(50) NOT NULL,
)

CREATE TABLE Usuarios (
    CdUsuario INT PRIMARY KEY IDENTITY,
    DsLogin VARCHAR(32) NOT NULL,
    Senha VARCHAR(32) NOT NULL,
    Administrador BIT default(0)
)

CREATE TABLE Locacao (
    CdLocacao INT,
    CdItens INT REFERENCES Itens (CdItem),
    PRIMARY KEY (CdLocacao, CdItens),
    FKCliente INT REFERENCES Clientes (CdCliente),  
    FKFuncionario INT REFERENCES Funcionario (CdFuncionario),
    DtAtual DATE NOT NULL,
    DtPrevista DATE NOT NULL,
    ValorTotal DECIMAL NOT NULL,
    DsStatusPg char(1) NOT NULL,
    ValorRecebido decimal(18,0)
)

CREATE TABLE Devolucao (
    CdDevolucao INT PRIMARY KEY IDENTITY,
    DataEntrega date NOT NULL,
    DataPrevista date NOT NULL,
    ValorTotal decimal NOT NULL,
    ValorPago decimal NOT NULL,
    Pagamento char(1) NOT NULL,
    FKLocacao INT REFERENCES Locacao(CdLocacao),
    Recebido bit NOT NULL
)

CREATE TABLE CONTATOS (
	CdContato int PRIMARY KEY IDENTITY,
	EMAIL VARCHAR(50) NOT NULL,
	NOME VARCHAR(50) NOT NULL,
	ASSUNTO VARCHAR(20) NOT NULL,
	MENSAGEM VARCHAR(MAX) NOT NULL,
    DataMensagem Date NOT NULL
)