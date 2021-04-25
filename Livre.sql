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

CREATE TABLE Commentaire(
 `Identifiant` int(11) NOT NULL AUTO_INCREMENT,
  `pseudo` varchar(255) NOT NULL,
  `commentaire` text NOT NULL,
  `datepublication` DATE NOT NULL,
  `timepublication` TIME NOT NULL,
  `IdentifiantLivre` int(11) NOT NULL,  PRIMARY KEY (`Identifiant`)
)ENGINE=INNODB DEFAULT CHARSET=utf8mb4;

ALTER Table Commentaire ADD CONSTRAINT fk_commantaire_livre     FOREIGN KEY(IdentifiantLivre) 
            REFERENCES Livre (Identifiant)
            ON DELETE CASCADE;