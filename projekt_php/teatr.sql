-- phpMyAdmin SQL Dump
-- version 4.0.4.2
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Czas wygenerowania: 16 Kwi 2015, 16:32
-- Wersja serwera: 5.6.13
-- Wersja PHP: 5.4.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Baza danych: `teatr`
--
CREATE DATABASE IF NOT EXISTS `teatr` DEFAULT CHARACTER SET utf8 COLLATE utf8_polish_ci;
USE `teatr`;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `aktor`
--

CREATE TABLE IF NOT EXISTS `aktor` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `imie` varchar(255) CHARACTER SET utf8 COLLATE utf8_polish_ci NOT NULL,
  `nazwisko` varchar(255) CHARACTER SET utf8 COLLATE utf8_polish_ci NOT NULL,
  `pesel` char(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15 ;

--
-- Zrzut danych tabeli `aktor`
--

INSERT INTO `aktor` (`id`, `imie`, `nazwisko`, `pesel`) VALUES
(10, 'Marcin', 'Kalina', '94235235325'),
(11, 'Marek', 'Chamski', '92334532355'),
(12, 'Artur', 'Pierdzik', '94323442442'),
(13, 'Jan', 'Matowski', '94112984321'),
(14, 'Marian', 'Zięba', '90124531212');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `bilet`
--

CREATE TABLE IF NOT EXISTS `bilet` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `cena` decimal(8,2) NOT NULL,
  `rodzaj` varchar(255) CHARACTER SET utf8 COLLATE utf8_polish_ci NOT NULL,
  `rzad` int(11) NOT NULL,
  `miejsce` int(11) NOT NULL,
  `spektakl_id` int(11) NOT NULL,
  `zakup_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `spektakl_id` (`spektakl_id`),
  KEY `zakup_id` (`zakup_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Zrzut danych tabeli `bilet`
--

INSERT INTO `bilet` (`id`, `cena`, `rodzaj`, `rzad`, `miejsce`, `spektakl_id`, `zakup_id`) VALUES
(1, '50.00', 'ulgowy', 2, 15, 2, 2),
(2, '80.00', 'normalny', 1, 10, 3, 1),
(3, '40.00', 'ulgowy', 2, 19, 2, 2),
(4, '60.00', 'ulgowy', 3, 3, 5, 5),
(5, '60.00', 'normalny', 5, 11, 3, 2);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `klient`
--

CREATE TABLE IF NOT EXISTS `klient` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `imie` varchar(255) CHARACTER SET utf8 COLLATE utf8_polish_ci NOT NULL,
  `nazwisko` varchar(255) CHARACTER SET utf8 COLLATE utf8_polish_ci NOT NULL,
  `pesel` char(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Zrzut danych tabeli `klient`
--

INSERT INTO `klient` (`id`, `imie`, `nazwisko`, `pesel`) VALUES
(3, 'Martin', 'Zelek', '94111307437'),
(4, 'Krystian', 'Smokowski', '94343233223'),
(5, 'Marek', 'Bucko', '93345353445'),
(7, 'Arkadiusz', 'Malarz', '94436346633'),
(8, 'Jan', 'Matlak', '93434556819');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `spektakl`
--

CREATE TABLE IF NOT EXISTS `spektakl` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `tytul` varchar(255) CHARACTER SET utf8 COLLATE utf8_polish_ci NOT NULL,
  `data_rozp` datetime NOT NULL,
  `data_zak` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Zrzut danych tabeli `spektakl`
--

INSERT INTO `spektakl` (`id`, `tytul`, `data_rozp`, `data_zak`) VALUES
(2, 'Turkusowa Łąka', '2013-11-11 11:10:15', '2012-11-10 09:20:00'),
(3, 'Anonimozje', '2010-10-10 12:00:00', '2010-10-10 12:00:00'),
(4, 'Lawenda bućka', '2010-10-10 15:00:00', '2010-10-10 17:00:00'),
(5, 'Kochana ladacznica', '2010-10-10 20:00:00', '2010-10-10 22:00:00'),
(6, 'Romeo i Julia', '2011-11-11 12:30:15', '2011-11-11 12:30:15');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `wystep`
--

CREATE TABLE IF NOT EXISTS `wystep` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `aktor_id` int(11) NOT NULL,
  `spektakl_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `aktor_id` (`aktor_id`),
  KEY `spektakl_id` (`spektakl_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci AUTO_INCREMENT=3 ;

--
-- Zrzut danych tabeli `wystep`
--

INSERT INTO `wystep` (`id`, `aktor_id`, `spektakl_id`) VALUES
(1, 11, 5),
(2, 11, 3);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `zakup`
--

CREATE TABLE IF NOT EXISTS `zakup` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `data_zakupu` datetime NOT NULL,
  `klient_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `klient_id` (`klient_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Zrzut danych tabeli `zakup`
--

INSERT INTO `zakup` (`id`, `data_zakupu`, `klient_id`) VALUES
(1, '2010-10-10 12:00:00', 3),
(2, '2010-10-10 12:00:00', 4),
(3, '2011-11-11 11:30:15', 5),
(5, '2010-11-10 14:30:15', 4),
(6, '2011-11-11 11:40:00', 8),
(7, '2010-10-10 12:00:00', 8);

--
-- Ograniczenia dla zrzutów tabel
--

--
-- Ograniczenia dla tabeli `bilet`
--
ALTER TABLE `bilet`
  ADD CONSTRAINT `bilet_ibfk_1` FOREIGN KEY (`spektakl_id`) REFERENCES `spektakl` (`id`),
  ADD CONSTRAINT `bilet_ibfk_2` FOREIGN KEY (`zakup_id`) REFERENCES `zakup` (`id`);

--
-- Ograniczenia dla tabeli `wystep`
--
ALTER TABLE `wystep`
  ADD CONSTRAINT `wystep_ibfk_1` FOREIGN KEY (`aktor_id`) REFERENCES `aktor` (`id`),
  ADD CONSTRAINT `wystep_ibfk_2` FOREIGN KEY (`spektakl_id`) REFERENCES `spektakl` (`id`);

--
-- Ograniczenia dla tabeli `zakup`
--
ALTER TABLE `zakup`
  ADD CONSTRAINT `zakup_ibfk_1` FOREIGN KEY (`klient_id`) REFERENCES `klient` (`id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
