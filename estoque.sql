-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.4.18-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              11.2.0.6213
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Copiando estrutura do banco de dados para estoque
CREATE DATABASE IF NOT EXISTS `estoque` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `estoque`;

-- Copiando estrutura para tabela estoque.login
CREATE TABLE IF NOT EXISTS `login` (
  `ID_USUARIO` int(11) NOT NULL AUTO_INCREMENT,
  `USUARIO` varchar(50) DEFAULT NULL,
  `SENHA` float DEFAULT NULL,
  PRIMARY KEY (`ID_USUARIO`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

-- Copiando dados para a tabela estoque.login: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
INSERT INTO `login` (`ID_USUARIO`, `USUARIO`, `SENHA`) VALUES
	(1, 'Yuri', 123456);
/*!40000 ALTER TABLE `login` ENABLE KEYS */;

-- Copiando estrutura para tabela estoque.produtos
CREATE TABLE IF NOT EXISTS `produtos` (
  `ID_PRODUTO` int(11) NOT NULL AUTO_INCREMENT,
  `CATEGORIA` varchar(50) NOT NULL,
  `DESCRICAO` varchar(50) NOT NULL,
  `MARCA` varchar(50) NOT NULL,
  `QUANTIDADE` int(10) NOT NULL,
  PRIMARY KEY (`ID_PRODUTO`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;

-- Copiando dados para a tabela estoque.produtos: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `produtos` DISABLE KEYS */;
INSERT INTO `produtos` (`ID_PRODUTO`, `CATEGORIA`, `DESCRICAO`, `MARCA`, `QUANTIDADE`) VALUES
	(5, 'Animais', 'Ração', 'Pedigree', 7);
/*!40000 ALTER TABLE `produtos` ENABLE KEYS */;

-- Copiando estrutura para tabela estoque.vendas
CREATE TABLE IF NOT EXISTS `vendas` (
  `ID_VENDA` int(11) NOT NULL AUTO_INCREMENT,
  `ID_PRODUTO` int(11) NOT NULL,
  `QUANTIDADE` int(10) NOT NULL,
  `NOME_CLIENTE` varchar(50) NOT NULL,
  PRIMARY KEY (`ID_VENDA`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

-- Copiando dados para a tabela estoque.vendas: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `vendas` DISABLE KEYS */;
INSERT INTO `vendas` (`ID_VENDA`, `ID_PRODUTO`, `QUANTIDADE`, `NOME_CLIENTE`) VALUES
	(3, 4, 15, 'Marcio'),
	(4, 5, 3, 'Mirlei');
/*!40000 ALTER TABLE `vendas` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
