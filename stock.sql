-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: 27-Nov-2016 às 01:10
-- Versão do servidor: 5.7.16
-- PHP Version: 5.6.26

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
  `telefone` char(11) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `endereco` varchar(80) DEFAULT NULL,
  `numero` varchar(20) DEFAULT NULL,
  `cidade` varchar(50) DEFAULT NULL,
  `estado` varchar(20) DEFAULT NULL,
  `cep` char(8) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `fornecedor`
--

INSERT INTO `fornecedor` (`cnpj`, `razSocial`, `telefone`, `email`, `endereco`, `numero`, `cidade`, `estado`, `cep`) VALUES
('35267177000133', 'DNG calçados', '34778965', 'dng@contato.com', 'Rua da Aurora', '34', 'Recife', 'PE', '69092475');

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionario`
--

CREATE TABLE `funcionario` (
  `cpf_fun` char(11) NOT NULL,
  `nome_fun` varchar(50) DEFAULT NULL,
  `email_fun` varchar(80) NOT NULL,
  `endereco_fun` varchar(80) NOT NULL,
  `cep_fun` char(8) NOT NULL,
  `nickname_fun` varchar(15) NOT NULL,
  `senha_fun` char(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `funcionario`
--

INSERT INTO `funcionario` (`cpf_fun`, `nome_fun`, `email_fun`, `endereco_fun`, `cep_fun`, `nickname_fun`, `senha_fun`) VALUES
('48522457034', 'dasd', 'asd ', 'dasdas', '12222222', 'dasdasda', 'dasda'),
('67188083347', 'Guilherme', 'g@gmail.com ', 'rua das ninfas', '21312412', 'gui', 'gui'),
('93240939320', 'Ikaro Sales', 'ikarosales7@gmail.com ', 'Rua das Ninfas N 13', '66152130', 'iks7', 'iks7');

-- --------------------------------------------------------

--
-- Estrutura da tabela `gerente`
--

CREATE TABLE `gerente` (
  `cpf_gt` char(11) NOT NULL,
  `nome_g` varchar(50) DEFAULT NULL,
  `email` varchar(80) NOT NULL,
  `endereco` varchar(80) NOT NULL,
  `cep` char(8) NOT NULL,
  `nickname` varchar(15) NOT NULL,
  `senha` char(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `gerente`
--

INSERT INTO `gerente` (`cpf_gt`, `nome_g`, `email`, `endereco`, `cep`, `nickname`, `senha`) VALUES
('11533777489', 'Guilherme Santana', 'gui.sants74@gmail.com ', 'Rua Maranata N 12', '5434055', 'admin', 'admin'),
('19465054470', 'asd', 'das ', 'ads', '33333333', 'ds', 'ads'),
('31658975227', 'Guilherme Santana', 'gui.sants@hotmail.com ', 'Rua Maranata N 12', '54340557', 'FunGui', 'fungui'),
('35492308505', 'ads', 'asd ', 'dasda', '11111111', 'dasd', 'dasd'),
('48522457034', 'dasd', 'asd ', 'dasdas', '12222222', 'dasdasda', 'dasda'),
('70409789461', 'zxc', 'zxc ', 'zxc', '11111111', 'zxc', 'zxc'),
('90554530481', 'asd', 'ds ', 'asd', '11111111', 'ads', 'ads');

-- --------------------------------------------------------

--
-- Estrutura da tabela `movimentacao`
--

CREATE TABLE `movimentacao` (
  `cod_mov` int(11) NOT NULL,
  `mov` char(30) DEFAULT NULL,
  `tipo` varchar(20) DEFAULT NULL,
  `endereco` varchar(80) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `data_mov` char(10) DEFAULT NULL,
  `qtd_mov` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `movimentacao`
--

INSERT INTO `movimentacao` (`cod_mov`, `mov`, `tipo`, `endereco`, `email`, `data_mov`, `qtd_mov`) VALUES
(1, 'Saida', 'Avaliação da fábrica', 'Rua das ninfas', 'dng@contato.com', '14/11/2016', 52),
(2, 'entrada', 'Extorno de entrada', 'Rua das ninfas', 'dng@contato.com', '2016-11-12', 35),
(3, 'entrada', 'devolução', 'Rua das ninfas', 'dng@contato.com', '2016-11-22', 40),
(4, 'entrada', 'Extorno de entrada', 'Rua das ninfas', 'dng@contato.com', '2016-11-28', 67),
(5, 'entrada', 'devolução', 'Rua das ninfas', 'dng@contato.com', '2016-11-25', 23),
(6, 'Entrada', 'Devolução', 'Rua das ninfas', 'contato@gmail.com', '25/11/2016', 30),
(7, 'Entrada', 'Extorno de Entrada', 'Rua dos doidos', 'contato@gmail.com', '25/11/2016', 28),
(8, 'Entrada', 'Devolução', 'aaaaaaaaa', 'aaaaaaaaa', '01/11/2016', 30),
(9, 'Entrada', 'Extorno de Entrada', 'aaaaaaaaaa', 'aaaaaaaa@aaaaaaaa.com', '08/11/2016', 29),
(10, 'Saida', 'Extorno de Saida', 'Rua das Ninfetinhas', 'ninfa@ninfosa.com', '25/11/2016', 20),
(12, 'Entrada', 'Devolução', 'iop', 'iop', '25/11/2016', 21),
(13, 'Entrada', 'Devolução', 'qwe', 'qwe', '25/11/2016', 27),
(14, 'Entrada', 'Devolução', 'tyu', 'tyu', '25/11/2016', 27),
(15, 'Entrada', 'Devolução', 'tyu', 'tyu', '25/11/2016', 27),
(16, 'Entrada', 'Devolução', 'rty', 'rty', '25/11/2016', 28),
(17, 'Entrada', 'Devolução', 'ert', 'ert', '25/11/2016', 24),
(19, 'Saida', 'Entrega', 'poi', 'poi', '25/11/2016', 13),
(20, 'Entrada', 'Devolução', 'Rua dos cegos ', 'nike@contato.com', '25/11/2016', 60),
(22, 'Saida', 'Avaliação da fábrica', 'Rua dos doidos', 'cartago@contato.com', '28/11/2016', 30);

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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `produto`
--

INSERT INTO `produto` (`cod_prod`, `cnpj`, `nome_prod`, `valor`, `qtd`) VALUES
(4, '35267177000133', 'Tênis pé Baruel', 350000, 30),
(5, '35267177000133', 'Sapatênis ', 50000, 12),
(6, '35267177000133', 'Nike ', 350000, 87),
(7, '35267177000133', 'Cartago ', 50000, 26);

-- --------------------------------------------------------

--
-- Estrutura da tabela `prod_mov`
--

CREATE TABLE `prod_mov` (
  `cod_prod` int(11) DEFAULT NULL,
  `cod_mov` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `prod_mov`
--

INSERT INTO `prod_mov` (`cod_prod`, `cod_mov`) VALUES
(7, 22);

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
  ADD PRIMARY KEY (`cpf_fun`);

--
-- Indexes for table `gerente`
--
ALTER TABLE `gerente`
  ADD PRIMARY KEY (`cpf_gt`);

--
-- Indexes for table `movimentacao`
--
ALTER TABLE `movimentacao`
  ADD PRIMARY KEY (`cod_mov`);

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

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `movimentacao`
--
ALTER TABLE `movimentacao`
  MODIFY `cod_mov` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;
--
-- AUTO_INCREMENT for table `produto`
--
ALTER TABLE `produto`
  MODIFY `cod_prod` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `produto`
--
ALTER TABLE `produto`
  ADD CONSTRAINT `produto_ibfk_1` FOREIGN KEY (`cnpj`) REFERENCES `fornecedor` (`cnpj`);

--
-- Limitadores para a tabela `prod_mov`
--
ALTER TABLE `prod_mov`
  ADD CONSTRAINT `prod_mov_ibfk_1` FOREIGN KEY (`cod_prod`) REFERENCES `produto` (`cod_prod`),
  ADD CONSTRAINT `prod_mov_ibfk_2` FOREIGN KEY (`cod_mov`) REFERENCES `movimentacao` (`cod_mov`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
