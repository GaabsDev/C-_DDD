CREATE DATABASE `unaspchamados`
CREATE TABLE `cargos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `descricao` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
CREATE TABLE `chamados` (
  `id` int NOT NULL AUTO_INCREMENT,
  `prioridade_id` int DEFAULT NULL,
  `severidade_id` int DEFAULT NULL,
  `funcionario_id` int DEFAULT NULL,
  `sistema_id` int DEFAULT NULL,
  `precisa_aprovacao` tinyint(1) DEFAULT NULL,
  `titulo` varchar(50) DEFAULT NULL,
  `descricao` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `prioridade_id` (`prioridade_id`),
  KEY `severidade_id` (`severidade_id`),
  KEY `usuario_id` (`funcionario_id`),
  KEY `sistema_id` (`sistema_id`),
  CONSTRAINT `chamados_ibfk_1` FOREIGN KEY (`prioridade_id`) REFERENCES `prioridades` (`id`),
  CONSTRAINT `chamados_ibfk_2` FOREIGN KEY (`severidade_id`) REFERENCES `severidades` (`id`),
  CONSTRAINT `chamados_ibfk_3` FOREIGN KEY (`funcionario_id`) REFERENCES `funcionarios` (`id`),
  CONSTRAINT `chamados_ibfk_4` FOREIGN KEY (`sistema_id`) REFERENCES `sistemas` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
CREATE TABLE `changes` (
  `id` int NOT NULL AUTO_INCREMENT,
  `localMudanca` varchar(255) DEFAULT NULL,
  `areasImpactadas` varchar(255) DEFAULT NULL,
  `podeTerRollBack` tinyint(1) DEFAULT NULL,
  `diaInicio` datetime DEFAULT NULL,
  `diaFim` datetime DEFAULT NULL,
  `prioridade_id` int DEFAULT NULL,
  `descricao` varchar(255) DEFAULT NULL,
  `titulo` varchar(50) DEFAULT NULL,
  `funcionario_id` int DEFAULT NULL,
  `username` varchar(8) DEFAULT NULL,
  `email` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `prioridade_id` (`prioridade_id`),
  KEY `funcionario_id` (`funcionario_id`),
  CONSTRAINT `changes_ibfk_1` FOREIGN KEY (`prioridade_id`) REFERENCES `prioridades` (`id`),
  CONSTRAINT `changes_ibfk_2` FOREIGN KEY (`funcionario_id`) REFERENCES `funcionarios` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
CREATE TABLE `departamentos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `descricao` varchar(100) DEFAULT NULL,
  `gerente` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
CREATE TABLE `funcionarios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(255) DEFAULT NULL,
  `departamento_id` int DEFAULT NULL,
  `cargo_id` int DEFAULT NULL,
  `username` varchar(8) DEFAULT NULL,
  `senha` varchar(8) DEFAULT NULL,
  `perfilAcesso` varchar(3) DEFAULT NULL,
  `email` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `cargo_id` (`cargo_id`),
  KEY `departamento_id` (`departamento_id`),
  CONSTRAINT `funcionarios_ibfk_1` FOREIGN KEY (`cargo_id`) REFERENCES `cargos` (`id`),
  CONSTRAINT `funcionarios_ibfk_3` FOREIGN KEY (`departamento_id`) REFERENCES `departamentos` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
CREATE TABLE `prioridades` (
  `id` int NOT NULL AUTO_INCREMENT,
  `descricao` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
CREATE TABLE `problems` (
  `id` int NOT NULL AUTO_INCREMENT,
  `causa` varchar(255) DEFAULT NULL,
  `impactos` varchar(255) DEFAULT NULL,
  `numChamado1` int DEFAULT NULL,
  `numChamado2` int DEFAULT NULL,
  `descricao` varchar(255) DEFAULT NULL,
  `titulo` varchar(50) DEFAULT NULL,
  `funcionario_id` int DEFAULT NULL,
  `username` varchar(8) DEFAULT NULL,
  `email` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `funcionario_id` (`funcionario_id`),
  CONSTRAINT `problems_ibfk_1` FOREIGN KEY (`funcionario_id`) REFERENCES `funcionarios` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
CREATE TABLE `severidades` (
  `id` int NOT NULL AUTO_INCREMENT,
  `descricao` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
CREATE TABLE `sistemas` (
  `id` int NOT NULL AUTO_INCREMENT,
  `versao` varchar(10) DEFAULT NULL,
  `ultima_licenca` date DEFAULT NULL,
  `nome` varchar(50) DEFAULT NULL,
  `descricao` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;


