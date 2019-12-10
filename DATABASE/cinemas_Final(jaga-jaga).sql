-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3307
-- Generation Time: Dec 09, 2019 at 06:59 PM
-- Server version: 10.4.6-MariaDB
-- PHP Version: 7.3.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cinema_simd`
--

-- --------------------------------------------------------

--
-- Table structure for table `cinemas`
--

CREATE TABLE `cinemas` (
  `Cinema_Id` int(11) NOT NULL,
  `Cinema_Name` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Movie_Name` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Theather` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Time` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Class` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `cinemas`
--

INSERT INTO `cinemas` (`Cinema_Id`, `Cinema_Name`, `Movie_Name`, `Theather`, `Time`, `Class`) VALUES
(1, 'Jurong', 'Maze Runner: The Death Cure', '1', '15:35', 'Economy'),
(2, 'Jurong', 'Maze Runner: The Death Cure', '2', '21:05', 'Premium'),
(3, 'Jurong', 'Maze Runner: The Death Cure', '3', '17:15', 'Gold'),
(4, 'Jurong', 'Resident Evil', '1', '20:30', 'Economy'),
(5, 'Jurong', 'Resident Evil', '2', '19:15', 'Premium'),
(6, 'Jurong', 'Resident Evil', '3', '19:00', 'Gold'),
(7, 'Jurong', 'Resident Evil', '4', '17:10', '3D'),
(8, 'Jurong', 'Scream', '1', '18:55', 'Economy'),
(9, 'Jurong', 'Scream', '2', '22:50', 'Premium'),
(10, 'Jurong', 'Scream', '3', '14:00', 'Gold'),
(11, 'Jurong', 'Shaun of the Dead', '1', '22:20', 'Economy'),
(12, 'Jurong', 'Shaun of the Dead', '2', '17:10', 'Premium'),
(13, 'Jurong', 'Shaun of the Dead', '3', '20:50', 'Gold'),
(14, 'Jurong', 'Spider Man 1', '1', '14:00', 'Economy'),
(15, 'Jurong', 'Spider Man 1', '2', '15:35', 'Premium'),
(16, 'Jurong', 'Spider Man 1', '3', '22:55', 'Gold'),
(17, 'Jurong', 'Spider Man 1', '4', '15:35', '3D'),
(18, 'Jurong', 'The Dark Knight', '1', '17:20', 'Economy'),
(19, 'Jurong', 'The Dark Knight', '2', '14:00', 'Premium'),
(20, 'Jurong', 'The Dark Knight', '3', '15:40', 'Gold'),
(21, 'Yishun', 'Resident Evil: The Final Chapter', '1', '16:00', 'Economy'),
(22, 'Little India', 'Shaun of the Dead', '2', '16:00', 'Economy'),
(23, 'Orchard', 'Spider Man 1', '3', '16:00', 'Economy'),
(24, 'Orchard', 'The Dark Knight', '1', '16:00', 'GOLD'),
(25, 'Orchard', 'The Fast and the Furious: Tokyo Drift', '2', '16:00', 'Economy'),
(26, 'Orchard', 'Zombieland', '3', '16:00', '3D'),
(27, 'Orchard', 'Scream', '1', '16:00', 'Economy'),
(28, 'Orchard', 'Spider Man 2', '2', '16:00', 'PREMIUM'),
(29, 'Little India', 'Spider Man 3', '3', '16:00', 'Economy'),
(30, 'Little India', 'The Fast and the Furious', '1', '16:00', 'Economy'),
(31, 'Little India', 'DeadPool', '2', '16:00', '3D'),
(32, 'Yishun', 'Death Race', '3', '16:00', 'Economy'),
(33, 'Yishun', 'Death Race 2', '1', '16:00', 'Economy'),
(34, 'Yishun', 'Death Race 3', '2', '16:00', 'GOLD'),
(35, 'Little India', 'Death Race 4', '3', '16:00', 'Economy'),
(36, 'Yishun', 'Maze Runner: The Scorch Trials', '1', '16:00', 'Economy'),
(37, 'Clementi', 'Maze Runner: The Death Cure', '2', '16:00', 'PREMIUM'),
(38, 'Clementi', 'The Lord of the Rings: The Fellowship of the Ring', '3', '16:00', 'Economy'),
(39, 'Clementi', 'The Lord of the Rings: The Two Towers', '1', '16:00', 'PREMIUM'),
(40, 'Little India', 'The Lord of the Rings: The Return of the King', '2', '16:00', '3D'),
(41, 'Bedok', 'Resident Evil', '3', '16:00', 'Economy'),
(42, 'Bedok', 'Resident Evil 2', '1', '16:00', '3D'),
(43, 'Bedok', 'Resident Evil: Extinction', '2', '16:00', 'GOLD'),
(44, 'Little India', 'Resident Evil: Afterlife', '3', '16:00', 'Economy'),
(45, 'Yishun', 'Resident Evil: Retribution', '3', '16:00', 'Economy'),
(46, 'Bedok', 'Maze Runner: The Scorch Trials', '1', '20:30', 'Economy'),
(47, 'Bedok', 'Shaun of the Dead', '2', '20:30', 'Economy'),
(48, 'Bedok', 'Spider Man 1', '3', '20:30', 'Economy'),
(49, 'Cathay', 'The Dark Knight', '1', '20:30', 'GOLD'),
(50, 'Cathay', 'The Fast and the Furious: Tokyo Drift', '2', '20:30', 'Economy'),
(51, 'Clark Quay', 'Zombieland', '3', '20:30', '3D'),
(52, 'Clark Quay', 'Scream', '1', '20:30', 'Economy'),
(53, 'Clark Quay', 'Spider Man 2', '2', '20:30', 'PREMIUM'),
(54, 'Clark Quay', 'Spider Man 3', '3', '20:30', 'Economy'),
(59, 'Little India', 'Death Race 3', '2', '20:30', 'GOLD'),
(60, 'Little India', 'Death Race 4', '3', '20:30', 'Economy'),
(61, 'Little India', 'Maze Runner: The Scorch Trials', '1', '20:30', 'Economy'),
(62, 'Little India', 'Maze Runner: The Death Cure', '2', '20:30', 'PREMIUM'),
(63, 'Orchard', 'The Lord of the Rings: The Fellowship of the Ring', '3', '20:30', 'Economy'),
(64, 'Orchard', 'The Lord of the Rings: The Two Towers', '1', '20:30', 'PREMIUM'),
(65, 'Orchard', 'The Lord of the Rings: The Return of the King', '2', '20:30', '3D'),
(66, 'Bedok', 'Resident Evil', '3', '20:30', 'Economy'),
(67, 'Bedok', 'Resident Evil 2', '1', '20:30', '3D'),
(68, 'Bedok', 'Resident Evil: Extinction', '2', '20:30', 'GOLD'),
(69, 'Yishun', 'Resident Evil: Afterlife', '3', '20:30', 'Economy'),
(70, 'Little India', 'Resident Evil: Retribution', '3', '20:30', 'Economy'),
(71, 'Yishun', 'The Lord of the Rings: The Fellowship of the Ring2', '2', '15:30', 'Economy');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cinemas`
--
ALTER TABLE `cinemas`
  ADD PRIMARY KEY (`Cinema_Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cinemas`
--
ALTER TABLE `cinemas`
  MODIFY `Cinema_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=78;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
