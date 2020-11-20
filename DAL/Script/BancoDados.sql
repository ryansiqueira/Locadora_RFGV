﻿CREATE DATABASE Locadora
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

CREATE TABLE Itens (
        CdItem INT PRIMARY KEY IDENTITY,
        CodigoBarras int NOT NULL,
        Titulo varchar(50) NOT NULL,
        Genero varchar(Max) NOT NULL,
        Ano INT NOT NULL,
        Tipo char(1) NOT NULL,
        Preco decimal NOT NULL,
        DtAdquirida Datetime NOT NULL,
        VlCusto decimal NOT NULL,
        Situacao char(1) NOT NULL,
        Atores varchar(max) NOT NULL,
        Diretor varchar(max) NOT NULL,
        CapaFilme varbinary(Max) NOT NULL

)

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
    CdArtistia INT PRIMARY KEY IDENTITY,
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
)

CREATE TABLE Locacao (
    CdLocacao INT,
    CdItens INT REFERENCES Itens (CdItem),
    PRIMARY KEY (CdLocacao, CdItens),
    FKCliente INT REFERENCES Clientes (CdCliente),
    DtAtual DATE NOT NULL,
    DtPrevista DATE NOT NULL,
    ValorTotal DECIMAL NOT NULL,
    DsStatusPg bit NOT NULL
)

CREATE TABLE Devolucao (
    CdDevolucao INT PRIMARY KEY IDENTITY,
    FKLocacao INT NOT NULL,
    FKItens INT NOT NULL,
    FOREIGN KEY (FKLocacao, FKItens) REFERENCES Locacao (CdLocacao, CdItens),
    VlRecebido DECIMAL NOT NULL,
    DsStatusPg bit NOT NULL
)