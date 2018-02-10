/*
Navicat MySQL Data Transfer

Source Server         : MySQL
Source Server Version : 50505
Source Host           : localhost:3306
Source Database       : belletableplanning

Target Server Type    : MYSQL
Target Server Version : 50505
File Encoding         : 65001

Date: 2018-02-10 16:15:23
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for agendas
-- ----------------------------
DROP TABLE IF EXISTS `agendas`;
CREATE TABLE `agendas` (
  `IDAgenda` int(11) NOT NULL AUTO_INCREMENT,
  `IDUser` int(11) NOT NULL,
  `Contenu` varchar(255) NOT NULL,
  PRIMARY KEY (`IDAgenda`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of agendas
-- ----------------------------

-- ----------------------------
-- Table structure for bloquer
-- ----------------------------
DROP TABLE IF EXISTS `bloquer`;
CREATE TABLE `bloquer` (
  `IDBloquer` int(11) NOT NULL AUTO_INCREMENT,
  `Creneau` varchar(255) NOT NULL,
  `IDAgenda` int(11) NOT NULL,
  `Description` varchar(255) NOT NULL,
  PRIMARY KEY (`IDBloquer`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of bloquer
-- ----------------------------

-- ----------------------------
-- Table structure for commerciaux
-- ----------------------------
DROP TABLE IF EXISTS `commerciaux`;
CREATE TABLE `commerciaux` (
  `IDCommercial` int(11) NOT NULL AUTO_INCREMENT,
  `IDUser` int(11) NOT NULL,
  `IDInterlocuteur` int(11) NOT NULL COMMENT 'Portefeuille Clients du commercial',
  PRIMARY KEY (`IDCommercial`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of commerciaux
-- ----------------------------

-- ----------------------------
-- Table structure for interlocuteurs
-- ----------------------------
DROP TABLE IF EXISTS `interlocuteurs`;
CREATE TABLE `interlocuteurs` (
  `IDInterlocuteur` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(255) NOT NULL,
  `Prenom` varchar(255) NOT NULL,
  `Mail` varchar(255) NOT NULL,
  `Adresse` varchar(255) NOT NULL,
  `Phone` varchar(255) NOT NULL,
  `IDStructure` int(11) NOT NULL,
  PRIMARY KEY (`IDInterlocuteur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of interlocuteurs
-- ----------------------------

-- ----------------------------
-- Table structure for qualifier
-- ----------------------------
DROP TABLE IF EXISTS `qualifier`;
CREATE TABLE `qualifier` (
  `IDQualification` int(11) NOT NULL AUTO_INCREMENT,
  `IDRdv` int(11) NOT NULL,
  `IDUser` int(11) NOT NULL,
  `IDInterlocuteur` int(11) NOT NULL,
  PRIMARY KEY (`IDQualification`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of qualifier
-- ----------------------------

-- ----------------------------
-- Table structure for rdv
-- ----------------------------
DROP TABLE IF EXISTS `rdv`;
CREATE TABLE `rdv` (
  `IDRdv` int(11) NOT NULL AUTO_INCREMENT,
  `Libelle` varchar(255) NOT NULL,
  `Description` varchar(255) NOT NULL,
  `Synthese` varchar(255) NOT NULL,
  `PlanAcces` varchar(255) NOT NULL,
  `InfoContexte` varchar(255) NOT NULL,
  PRIMARY KEY (`IDRdv`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of rdv
-- ----------------------------

-- ----------------------------
-- Table structure for structures
-- ----------------------------
DROP TABLE IF EXISTS `structures`;
CREATE TABLE `structures` (
  `IDStructure` int(11) NOT NULL AUTO_INCREMENT,
  `Libelle` varchar(255) NOT NULL,
  PRIMARY KEY (`IDStructure`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of structures
-- ----------------------------
INSERT INTO `structures` VALUES ('1', 'Organisme');
INSERT INTO `structures` VALUES ('2', 'Organisation');
INSERT INTO `structures` VALUES ('3', 'Société');
INSERT INTO `structures` VALUES ('4', 'Particulier');

-- ----------------------------
-- Table structure for types
-- ----------------------------
DROP TABLE IF EXISTS `types`;
CREATE TABLE `types` (
  `IDType` int(11) NOT NULL AUTO_INCREMENT,
  `Libelle` varchar(255) NOT NULL,
  `Description` varchar(255) NOT NULL,
  PRIMARY KEY (`IDType`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of types
-- ----------------------------
INSERT INTO `types` VALUES ('1', 'Commercial', 'Profil d\'un commercial. Un commercial se doit de prendre des rendez-vous avec des clients/prospects dont il a un portefeuille. Il est équipé d\'un agenda pour s\'organiser.');
INSERT INTO `types` VALUES ('2', 'Gestionnaire', 'Profil d\'un gestionnaire. Un gestionnaire s\'occupe de gérer les commerciaux. Il peut alors consulter les agendas des commerciaux et les gérer.');
INSERT INTO `types` VALUES ('3', 'Administrateur', 'Profil d\'un administrateur. Un administrateur doit s\'occuper du bon fonctionnement de l\'application. En cas de problème pour un utilisateur, il se doit d\'être présent pour l\'assister.');

-- ----------------------------
-- Table structure for users
-- ----------------------------
DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `IDUser` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(255) NOT NULL,
  `Prenom` varchar(255) NOT NULL,
  `Mail` varchar(255) NOT NULL,
  `Phone` varchar(255) NOT NULL,
  `IDType` int(11) NOT NULL,
  `Banned` int(11) NOT NULL,
  `Password` varchar(255) NOT NULL,
  PRIMARY KEY (`IDUser`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of users
-- ----------------------------
INSERT INTO `users` VALUES ('1', 'HAMADOUCHE', 'Elias', 'elias.hamadouche@hotmail.com', '0781247379', '3', '0', 'f9979f36577da1ba51890e088db3fbc410ede368373c17e2b3fb0f8ffb0f2a51e3edddc78284c4a7d65e5f185e7c1ca66f3ec623013452d8821060a0e96ca6f3');
