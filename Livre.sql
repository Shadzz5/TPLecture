DROP DATABASE IF EXISTS Lectures;
CREATE DATABASE Lectures;
USE Lectures;

CREATE TABLE IF NOT EXISTS `Livre` (
  `Identifiant` INT NOT NULL AUTO_INCREMENT,
  `NombrePages` INT NOT NULL,
  `Titre` varchar(255) NOT NULL,
  `Edition` varchar(255) NOT NULL,
  `ISBN` varchar(255) NOT NULL,
  `DateEdition` DATE NOT NULL,
  `DateLecture` DATE NULL,
  `Note` INT NULL,
  `Resume` VARCHAR(4000)  NULL,
  `Commentaire` TEXT  NULL,
  PRIMARY KEY (`Identifiant`)
) ENGINE=INNODB DEFAULT CHARSET=utf8mb4;

