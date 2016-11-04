-- phpMyAdmin SQL Dump
-- version 4.5.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 01-Nov-2016 às 15:03
-- Versão do servidor: 5.7.11
-- PHP Version: 5.6.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `stock`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `fornecedor`
--

CREATE TABLE `fornecedor` (
  `cnpj` varchar(15) NOT NULL,
  `razSocial` varchar(50) DEFAULT NULL,
  `telefone` char(10) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `endereco` varchar(80) DEFAULT NULL,
  `numero` varchar(20) DEFAULT NULL,
  `cidade` varchar(50) DEFAULT NULL,
  `estado` varchar(20) DEFAULT NULL,
  `cep` char(8) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionario`
--

CREATE TABLE `funcionario` (
  `cpf` char(11) NOT NULL,
  `nome_fun` varchar(50) DEFAULT NULL,
  `senha` char(10) DEFAULT NULL,
  `foto` varchar(20) DEFAULT NULL,
  `status` char(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `gerente`
--

CREATE TABLE `gerente` (
  `cpf_gt` char(11) NOT NULL,
  `nome_g` varchar(50) DEFAULT NULL,
  `senha` char(10) DEFAULT NULL,
  `foto` varchar(20) DEFAULT NULL,
  `status` char(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `movimentacao`
--

CREATE TABLE `movimentacao` (
  `cod_mov` int(11) NOT NULL,
  `cod_prod` int(11) DEFAULT NULL,
  `mov` char(30) DEFAULT NULL,
  `tipo` varchar(20) DEFAULT NULL,
  `endereco` varchar(80) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `data_mov` date DEFAULT NULL,
  `qtd_mov` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

CREATE TABLE `produto` (
  `cod_prod` int(11) NOT NULL,
  `cnpj` varchar(15) DEFAULT NULL,
  `nome_prod` varchar(50) DEFAULT NULL,
  `valor` double DEFAULT NULL,
  `qtd` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `prod_mov`
--

CREATE TABLE `prod_mov` (
  `cod_prod` int(11) DEFAULT NULL,
  `cod_mov` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `fornecedor`
--
ALTER TABLE `fornecedor`
  ADD PRIMARY KEY (`cnpj`);

--
-- Indexes for table `funcionario`
--
ALTER TABLE `funcionario`
  ADD PRIMARY KEY (`cpf`);

--
-- Indexes for table `gerente`
--
ALTER TABLE `gerente`
  ADD PRIMARY KEY (`cpf_gt`);

--
-- Indexes for table `movimentacao`
--
ALTER TABLE `movimentacao`
  ADD PRIMARY KEY (`cod_mov`),
  ADD KEY `cod_prod` (`cod_prod`);

--
-- Indexes for table `produto`
--
ALTER TABLE `produto`
  ADD PRIMARY KEY (`cod_prod`),
  ADD KEY `cnpj` (`cnpj`);

--
-- Indexes for table `prod_mov`
--
ALTER TABLE `prod_mov`
  ADD KEY `cod_prod` (`cod_prod`),
  ADD KEY `cod_mov` (`cod_mov`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
