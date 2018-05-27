-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  mar. 22 mai 2018 à 02:48
-- Version du serveur :  5.7.19
-- Version de PHP :  7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `belletableplanning`
--

-- --------------------------------------------------------

--
-- Structure de la table `agendas`
--

DROP TABLE IF EXISTS `agendas`;
CREATE TABLE IF NOT EXISTS `agendas` (
  `IDAgenda` int(11) NOT NULL AUTO_INCREMENT,
  `IDUser` int(11) NOT NULL,
  `Contenu` varchar(255) NOT NULL,
  PRIMARY KEY (`IDAgenda`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `agendas`
--

INSERT INTO `agendas` (`IDAgenda`, `IDUser`, `Contenu`) VALUES
(1, 5, ''),
(2, 8, ''),
(3, 9, ''),
(4, 10, '');

-- --------------------------------------------------------

--
-- Structure de la table `bloquer`
--

DROP TABLE IF EXISTS `bloquer`;
CREATE TABLE IF NOT EXISTS `bloquer` (
  `IDBloquer` int(11) NOT NULL AUTO_INCREMENT,
  `Creneau` varchar(255) NOT NULL,
  `IDAgenda` int(11) NOT NULL,
  `IDRdv` int(11) NOT NULL,
  PRIMARY KEY (`IDBloquer`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `bloquer`
--

INSERT INTO `bloquer` (`IDBloquer`, `Creneau`, `IDAgenda`, `IDRdv`) VALUES
(1, '13/04/2018', 1, 1),
(2, '16/04/2018', 2, 2),
(3, '21/05/2018', 4, 3);

-- --------------------------------------------------------

--
-- Structure de la table `commerciaux`
--

DROP TABLE IF EXISTS `commerciaux`;
CREATE TABLE IF NOT EXISTS `commerciaux` (
  `IDCommercial` int(11) NOT NULL AUTO_INCREMENT,
  `IDUser` int(11) NOT NULL,
  `IDInterlocuteur` int(11) NOT NULL COMMENT 'Portefeuille Clients du commercial',
  PRIMARY KEY (`IDCommercial`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `incidents`
--

DROP TABLE IF EXISTS `incidents`;
CREATE TABLE IF NOT EXISTS `incidents` (
  `IDIncident` int(11) NOT NULL AUTO_INCREMENT,
  `Objet` varchar(255) NOT NULL,
  `Message` varchar(255) NOT NULL,
  `Type` int(11) NOT NULL COMMENT '1 : Normal / 2 : Urgent / 3 : Critique',
  `DateAjout` datetime NOT NULL,
  `Auteur` int(11) NOT NULL,
  `Resolu` int(11) NOT NULL COMMENT '0 : Non-résolu / 1 : Résolu',
  PRIMARY KEY (`IDIncident`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `incidents`
--

INSERT INTO `incidents` (`IDIncident`, `Objet`, `Message`, `Type`, `DateAjout`, `Auteur`, `Resolu`) VALUES
(1, 'ObjetTest', 'MessageTest blabla', 1, '2018-04-07 19:51:07', 0, 0),
(2, 'MonTitre', 'MonMessage', 1, '2018-04-07 20:08:51', 5, 0),
(3, 'TestIncident', 'Tellement de bugs... :(', 2, '2018-04-07 20:25:21', 5, 0),
(4, 'Test Critique', 'VITE ! ON A BESOIN DE VOUS !!!', 3, '2018-04-07 20:25:56', 5, 0),
(5, 'Problème de connexion à la liste des rdv', 'Je n\'arrive pas à afficher mes rendez-vous, tout est vide', 2, '2018-04-10 09:21:01', 5, 0);

-- --------------------------------------------------------

--
-- Structure de la table `interlocuteurs`
--

DROP TABLE IF EXISTS `interlocuteurs`;
CREATE TABLE IF NOT EXISTS `interlocuteurs` (
  `IDInterlocuteur` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(255) NOT NULL,
  `Prenom` varchar(255) NOT NULL,
  `Mail` varchar(255) NOT NULL,
  `Adresse` varchar(255) NOT NULL,
  `Phone` varchar(255) NOT NULL,
  `IDStructure` int(11) NOT NULL,
  PRIMARY KEY (`IDInterlocuteur`),
  UNIQUE KEY `Mail` (`Mail`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `interlocuteurs`
--

INSERT INTO `interlocuteurs` (`IDInterlocuteur`, `Nom`, `Prenom`, `Mail`, `Adresse`, `Phone`, `IDStructure`) VALUES
(1, 'LADEROUTE', 'Charles', 'CharlesLaderoute@armyspy.com', '4, rue des Coudriers, \r\n31600 MURET', '05.99.48.99.79', 4),
(2, 'MARSEAU', 'Thomas', 'ThomasMarseau@jourrapide.com', '34, rue Sébastopol, \r\n97230 SAINTE-MARIE', '05.13.95.04.32', 3),
(3, 'ADLER', 'Catherine', 'CatherineAdler@jourrapide.com', '88, rue des Nations Unies\r\n, 42400 SAINT-CHAMOND', '04.70.03.16.50', 1),
(4, 'BIENVENUE', 'Clémence', 'ClemenceBienvenue@armyspy.com', '9, Rue Frédéric Chopin\r\n44120 VERTOU \r\n', '02.63.76.37.74', 2),
(5, 'Alterno', 'Alessandro', 'aa@mail.com', '30 Rue de la gare - Roubaix\r\n', '0102030405', 3);

-- --------------------------------------------------------

--
-- Structure de la table `licences`
--

DROP TABLE IF EXISTS `licences`;
CREATE TABLE IF NOT EXISTS `licences` (
  `id_licence` int(11) NOT NULL AUTO_INCREMENT,
  `Cle` varchar(255) NOT NULL,
  `Date_debut` date NOT NULL,
  `Date_Fin` date NOT NULL,
  PRIMARY KEY (`id_licence`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `licences`
--

INSERT INTO `licences` (`id_licence`, `Cle`, `Date_debut`, `Date_Fin`) VALUES
(1, 'abcdefghijklmnopqrstuvwxyz2018', '2018-04-10', '2018-04-10');

-- --------------------------------------------------------

--
-- Structure de la table `messages`
--

DROP TABLE IF EXISTS `messages`;
CREATE TABLE IF NOT EXISTS `messages` (
  `id_msg` int(11) NOT NULL AUTO_INCREMENT,
  `objet_msg` varchar(100) NOT NULL,
  `contenu_msg` varchar(255) NOT NULL,
  `id_emet` int(11) NOT NULL,
  `id_dest` int(11) NOT NULL,
  `date_envoi` datetime NOT NULL,
  `Vu` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_msg`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `messages`
--

INSERT INTO `messages` (`id_msg`, `objet_msg`, `contenu_msg`, `id_emet`, `id_dest`, `date_envoi`, `Vu`) VALUES
(1, 'Objet Test', 'Message Contenu', 5, 5, '2018-04-10 00:00:00', 0),
(2, 'test', 'tst', 5, 8, '2018-04-10 00:00:00', 0),
(3, 'test', 'message de test', 5, 8, '2018-04-10 00:00:00', 0),
(4, 'Bonjour', 'Ceci est un message', 10, 5, '2018-04-10 00:00:00', 0),
(5, 'Mail d\'essai', 'Ceci est le message', 5, 10, '2018-04-10 00:00:00', 0),
(6, 'Ceci est un objet', 'Ceci est un message', 10, 5, '2018-04-10 00:00:00', 0),
(7, 'jhjkhjjh', 'uihyiuyiu', 10, 9, '2018-05-21 22:18:33', 0),
(8, 'hjjjjjjjjjj', 'ghgggggg', 10, 5, '2018-05-21 22:18:57', 0);

-- --------------------------------------------------------

--
-- Structure de la table `qualifier`
--

DROP TABLE IF EXISTS `qualifier`;
CREATE TABLE IF NOT EXISTS `qualifier` (
  `IDQualification` int(11) NOT NULL AUTO_INCREMENT,
  `IDRdv` int(11) NOT NULL,
  `IDUser` int(11) NOT NULL,
  `IDInterlocuteur` int(11) NOT NULL,
  PRIMARY KEY (`IDQualification`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `qualifier`
--

INSERT INTO `qualifier` (`IDQualification`, `IDRdv`, `IDUser`, `IDInterlocuteur`) VALUES
(1, 1, 5, 1),
(2, 2, 8, 2),
(3, 3, 10, 5);

-- --------------------------------------------------------

--
-- Structure de la table `rdv`
--

DROP TABLE IF EXISTS `rdv`;
CREATE TABLE IF NOT EXISTS `rdv` (
  `IDRdv` int(11) NOT NULL AUTO_INCREMENT,
  `Libelle` varchar(255) NOT NULL,
  `Description` varchar(255) NOT NULL,
  `TypeRdv` int(11) NOT NULL,
  `PlanAcces` varchar(255) NOT NULL,
  `InfoContexte` varchar(255) NOT NULL,
  PRIMARY KEY (`IDRdv`),
  UNIQUE KEY `Libelle` (`Libelle`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `rdv`
--

INSERT INTO `rdv` (`IDRdv`, `Libelle`, `Description`, `TypeRdv`, `PlanAcces`, `InfoContexte`) VALUES
(1, 'Entretien hebdomadaire Mars #034', 'A 10h00. Entretien secret.\r\n', 4, 'Voir les plans de secours sur les murs du bâtiment.\r\n', ''),
(2, 'Entretien avec Le Joker #1', 'Une visite hebdomadaire, rien de nouveau.\r\n', 3, 'Bâtiment B.\r\n', ''),
(3, 'ljklk', 'kjkjkjkj\r\n', 1, 'kjkj\r\n', '');

-- --------------------------------------------------------

--
-- Structure de la table `structures`
--

DROP TABLE IF EXISTS `structures`;
CREATE TABLE IF NOT EXISTS `structures` (
  `IDStructure` int(11) NOT NULL AUTO_INCREMENT,
  `Libelle` varchar(255) NOT NULL,
  PRIMARY KEY (`IDStructure`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `structures`
--

INSERT INTO `structures` (`IDStructure`, `Libelle`) VALUES
(1, 'Organisme'),
(2, 'Organisation'),
(3, 'Société'),
(4, 'Particulier');

-- --------------------------------------------------------

--
-- Structure de la table `types`
--

DROP TABLE IF EXISTS `types`;
CREATE TABLE IF NOT EXISTS `types` (
  `IDType` int(11) NOT NULL AUTO_INCREMENT,
  `Libelle` varchar(255) NOT NULL,
  `Description` varchar(255) NOT NULL,
  PRIMARY KEY (`IDType`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `types`
--

INSERT INTO `types` (`IDType`, `Libelle`, `Description`) VALUES
(1, 'Commercial', 'Profil d\'un commercial. Un commercial se doit de prendre des rendez-vous avec des clients/prospects dont il a un portefeuille. Il est équipé d\'un agenda pour s\'organiser.'),
(2, 'Gestionnaire', 'Profil d\'un gestionnaire. Un gestionnaire s\'occupe de gérer les commerciaux. Il peut alors consulter les agendas des commerciaux et les gérer.'),
(3, 'Administrateur', 'Profil d\'un administrateur. Un administrateur doit s\'occuper du bon fonctionnement de l\'application. En cas de problème pour un utilisateur, il se doit d\'être présent pour l\'assister.');

-- --------------------------------------------------------

--
-- Structure de la table `typesrdv`
--

DROP TABLE IF EXISTS `typesrdv`;
CREATE TABLE IF NOT EXISTS `typesrdv` (
  `IDTypeRDV` int(11) NOT NULL AUTO_INCREMENT,
  `Libelle` varchar(255) NOT NULL,
  PRIMARY KEY (`IDTypeRDV`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `typesrdv`
--

INSERT INTO `typesrdv` (`IDTypeRDV`, `Libelle`) VALUES
(1, 'Première rencontre'),
(2, 'Rendez-vous téléphonique'),
(3, 'Visite de courtoisie'),
(4, 'Visite technique'),
(5, 'Conclusion');

-- --------------------------------------------------------

--
-- Structure de la table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `IDUser` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(255) NOT NULL,
  `Prenom` varchar(255) NOT NULL,
  `Mail` varchar(255) NOT NULL,
  `Phone` varchar(255) NOT NULL,
  `IDType` int(11) NOT NULL COMMENT '1 : Commercial / 2 : Responsable / 3 : Administrateur',
  `Banned` int(11) NOT NULL DEFAULT '0',
  `Password` varchar(255) NOT NULL,
  PRIMARY KEY (`IDUser`),
  UNIQUE KEY `Mail` (`Mail`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `users`
--

INSERT INTO `users` (`IDUser`, `Nom`, `Prenom`, `Mail`, `Phone`, `IDType`, `Banned`, `Password`) VALUES
(1, 'HAMADOUCHE', 'Elias', 'elias.hamadouche@hotmail.com', '0781247379', 3, 0, 'f9979f36577da1ba51890e088db3fbc410ede368373c17e2b3fb0f8ffb0f2a51e3edddc78284c4a7d65e5f185e7c1ca66f3ec623013452d8821060a0e96ca6f3'),
(5, 'MonNom', 'MonPrenom', 'MonMail@Mail.com', '0148805751', 3, 0, '7iaw3Ur350mqGo7jwQrpkj9hiYB3Lkc/iBml1JQODbJ6wYX4oOHV+E+IvIh/1nsUNzLDBMxfqa2Ob1f1ACio/w=='),
(8, 'WAYNE', 'Bruce', 'bruce@waynecorp.com', '0148805751', 1, 0, 'DNVUgQLPBSAw1heYt6fA++wORO0OZXF6GcP7xHMpaHDRK+89AhNJVW1fUktZT716k7NgvHS3/TKXlgHBvQMLPg=='),
(9, 'MANDJARO', 'Kelly', 'kelly.mandjaro@gmail.com', '0148805751', 1, 0, '67ABw8/RqqM07v/vltXIIZYFR123qpU+eFboaIORpnsWnEznOk5rEqyRmMUVU0Qs4BcFIl1xYWwamu7Udbfq0w=='),
(10, 'test', 'test', 'test@test.com', '0102030405', 1, 0, '7iaw3Ur350mqGo7jwQrpkj9hiYB3Lkc/iBml1JQODbJ6wYX4oOHV+E+IvIh/1nsUNzLDBMxfqa2Ob1f1ACio/w==');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
