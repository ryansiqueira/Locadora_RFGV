﻿CREATE DATABASE Locadora
GO

USE Locadora
GO

CREATE TABLE Funcionarios (
    CdFuncionario INT PRIMARY KEY IDENTITY,
	Nome     VARCHAR (50)  NOT NULL,
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
    DsStatus varchar(max) NOT NULL
)

CREATE TABLE Itens (
        CdItem INT PRIMARY KEY IDENTITY,
        CodigoBarras INT NOT NULL,
        Titulo varchar(50) NOT NULL,
        Genero varchar(50) NOT NULL,
        Ano date NOT NULL,
        Tipo char(1) NOT NULL,
        Preco decimal NOT NULL,
        DtAdquirida date NOT NULL,
        VlCusto decimal NOT NULL,
        Situacao char(1) NOT NULL,
        Atores varchar(max) NOT NULL,
        Diretor varchar(max) NOT NULL,
        CapaFilme image NOT NULL
)

CREATE TABLE Clientes (
    CdCliente INT PRIMARY KEY IDENTITY,
    Nome varchar(50) NOT NULL,
    DtNascimento date NOT NULL,
    Sexo char(1) NOT NULL,
    DsEstadoCivil CHAR (1) NOT NULL,
    RG varchar(10) NOT NULL,
    CPF varchar(12) NOT NULL,
    Endereco varchar(50) NOT NULL,
    Cidade varchar(50) NOT NULL,
    CEP varchar(50) NOT NULL,
    Estado varchar(2) NOT NULL,
    Telefone varchar(20) NOT NULL,
    Email varchar(50) NOT NULL,
    Celular varchar(20) NOT NULL,
    DsStatus varchar(50) NOT NULL
)

CREATE TABLE Artistas (
    CdArtistia INT PRIMARY KEY IDENTITY,
    Nome varchar (50) NOT NULL,
    DtNascimento date NOT NULL,
    PaisNascimento varchar(20) NOT NULL,
    Foto image
)

CREATE TABLE Generos (
    CdGenero INT PRIMARY KEY IDENTITY,
    Nome varchar(50) NOT NULL,
)

--CREATE TABLE Locacao (
    -- 05/11/202:
    -- Devemos falar com o Anderson, para saber como proceder:
    -- Chave primaria composta
--)