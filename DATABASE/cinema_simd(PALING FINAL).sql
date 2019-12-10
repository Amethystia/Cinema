-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3307
-- Generation Time: Dec 10, 2019 at 01:39 PM
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

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `Reports` (IN `@pricecinema` INT(20), IN `@requestorcinema` VARCHAR(30), IN `@priceticket` INT(20), IN `@requestorticket` VARCHAR(30))  select sum(price)as price1,count(requestor)as requestor1 from bookingcinema
UNION
select sum(price)as price2,count(book_by)as requestor2 from bookedtickets$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `bookedtickets`
--

CREATE TABLE `bookedtickets` (
  `Ticket_BookId` int(11) NOT NULL,
  `Book_By` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `Cinema_Name` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `Theather` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `Movie_Name` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `Time` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `Seat_Number` varchar(5) COLLATE utf8_unicode_ci NOT NULL,
  `Price` float NOT NULL,
  `BookedOn` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `bookedtickets`
--

INSERT INTO `bookedtickets` (`Ticket_BookId`, `Book_By`, `Cinema_Name`, `Theather`, `Movie_Name`, `Time`, `Seat_Number`, `Price`, `BookedOn`) VALUES
(1, 'ryo', 'Yishun', '3', 'Death Race', '16:00', '20', 35000, '0000-00-00'),
(2, 'ryo', 'Yishun', '3', 'Death Race', '16:00', '2', 35000, '0000-00-00'),
(3, 'ryo', 'Yishun', '1', 'Death Race 2', '16:00', '12', 35000, '0000-00-00'),
(4, 'ryo', 'Yishun', '1', 'Death Race 2', '16:00', '25', 35000, '0000-00-00'),
(5, 'ryo', 'Bedok', '2', 'Resident Evil: Extinction', '16:00', '11', 125000, '0000-00-00'),
(6, 'ryo', 'Bedok', '2', 'Resident Evil: Extinction', '16:00', '7', 125000, '0000-00-00'),
(7, 'ryo', 'Yishun', '3', 'Death Race', '16:00', '32', 35000, '0000-00-00'),
(8, 'ryo', 'Yishun', '1', 'Death Race 2', '16:00', '30', 35000, '0000-00-00');

-- --------------------------------------------------------

--
-- Table structure for table `bookingcinema`
--

CREATE TABLE `bookingcinema` (
  `Cinema_BookId` int(11) NOT NULL,
  `Book_By` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `Cinema_Name` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `Theather` int(11) DEFAULT NULL,
  `Movie_Name` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `Class` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `Date` datetime NOT NULL,
  `Price` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `RequestStatus` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ApproveDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `bookingcinema`
--

INSERT INTO `bookingcinema` (`Cinema_BookId`, `Book_By`, `Cinema_Name`, `Theather`, `Movie_Name`, `Class`, `Date`, `Price`, `RequestStatus`, `ApproveDate`) VALUES
(1, 'ryo', 'Yishun', NULL, 'Resident Evil: The Final Chapter', 'Economy', '2019-12-09 19:37:56', '1050000', 'waiting', '0000-00-00'),
(2, 'ryo', 'Bedok', NULL, 'Resident Evil', 'Economy', '2019-12-05 19:43:50', '1050000', 'waiting', '0000-00-00'),
(3, 'ryo', 'Clark Quay', NULL, 'Spider Man 3', '3D', '2019-12-10 19:38:39', '3900000', 'waiting', '0000-00-00');

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

-- --------------------------------------------------------

--
-- Table structure for table `movies`
--

CREATE TABLE `movies` (
  `Movie_Id` int(11) NOT NULL,
  `Movie_Name` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `Movie_Imdb` varchar(4) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Movie_Description` varchar(5000) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Movie_Image` varchar(250) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Slide_Image` varchar(300) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Duration` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Release_Date` date DEFAULT NULL,
  `IsReleased` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `movies`
--

INSERT INTO `movies` (`Movie_Id`, `Movie_Name`, `Movie_Imdb`, `Movie_Description`, `Movie_Image`, `Slide_Image`, `Duration`, `Release_Date`, `IsReleased`) VALUES
(1, 'Death Race', '6.4', 'Framed for a murder he did not commit, three-time speedway champ Jensen Ames (Jason Statham) finds himself at Terminal Island, the countrys toughest prison, but he gets an unexpected chance at freedom when the warden offers a choice: Compete in the Death Race as a mythical driver called Frankenstein, or rot in a cell forever. Riding in a car equipped with flamethrowers and grenade launchers, Ames must survive a gauntlet of vicious criminals to win his freedom -- or die trying.', 'C:\\Cinema\\Assets\\Movies\\deat_race.jpg', NULL, '120', '2019-12-04', 1),
(2, 'Death Race 2', '5.6', 'After being convicted of killing a cop, a prison inmate tries to win his freedom by competing in a brutal race where cars are deadly weapons.', 'C:\\Cinema\\Assets\\Movies\\deat_race_2.jpg', NULL, '100', '2019-12-04', 1),
(3, 'Death Race 3', '5.5', 'Only one victory away from winning his freedom, legendary driver Carl Lucas (Luke Goss) enters the first Death Race to take place in the brutal Kalahari Desert.', 'C:\\Cinema\\Assets\\Movies\\deat_race_3.jpg', NULL, '125', '2019-12-04', 1),
(5, 'Maze Runner: The Scorch Trials', '4.3', 'Transported to a remote fortified outpost, Thomas and his fellow teenage Gladers find themselves in trouble after uncovering a diabolical plot from the mysterious and powerful organization WCKD. With help from a new ally, the Gladers stage a daring escape into the Scorch, a desolate landscape filled with dangerous obstacles and crawling with the virus-infected Cranks. The Gladers only hope may be to find the Right Hand, a group of resistance fighters who can help them battle WCKD.', 'C:\\Cinema\\Assets\\Movies\\labirent_2.jpg', NULL, '100', '2019-12-04', 1),
(6, 'Maze Runner: The Death Cure', '9.5', 'Thomas leads some escaped Gladers on their final and most dangerous mission yet. To save their friends, they must break into the legendary Last City, a WCKD-controlled labyrinth that may turn out to be the deadliest maze of all. Anyone who makes it out alive will get answers to the questions that the Gladers have been asking since they arrived in the maze.', 'C:\\Cinema\\Assets\\Movies\\labirent_3.jpg', NULL, '98', '2019-12-04', 0),
(7, 'The Lord of the Rings: The Fellowship of the Ring2', '8.8', 'The future of civilization rests in the fate of the One Ring, which has been lost for centuries. Powerful forces are unrelenting in their search for it. But fate has placed it in the hands of a young Hobbit named Frodo Baggins (Elijah Wood), who inherits the Ring and steps into legend. A daunting task lies ahead for Frodo when he becomes the Ringbearer - to destroy the One Ring in the fires of Mount Doom where it was forged.', 'C:\\Cinema\\Assets\\Movies\\lord_of_the_rings_1.jpg', NULL, '102', '2019-12-04', 1),
(8, 'The Lord of the Rings: The Two Towers', '8.7', 'The sequel to the Golden Globe-nominated and AFI Award-winning \"The Lord of the Rings: The Fellowship of the Ring,\" \"The Two Towers\" follows the continuing quest of Frodo (Elijah Wood) and the Fellowship to destroy the One Ring. Frodo and Sam (Sean Astin) discover they are being followed by the mysterious Gollum. Aragorn (Viggo Mortensen), the Elf archer Legolas and Gimli the Dwarf encounter the besieged Rohan kingdom, whose once great King Theoden has fallen under Sarumans deadly spell.', 'C:\\Cinema\\Assets\\Movies\\lord_of_the_rings_2.jpg', 'C:\\Cinema\\Assets\\HomeSlide\\LordOfTheRings2.jpg\r\n', '105', '2019-12-04', 0),
(9, 'The Lord of the Rings: The Return of the King', '8.9', 'The Lord of the Rings: The Return of the King is a 2003 epic fantasy adventure film co-produced, co-written, and directed by Peter Jackson based on the second and third volumes of J. R. R. Tolkiens The Lord of the Rings.', 'C:\\Cinema\\Assets\\Movies\\lord_of_the_rings_3.jpg', NULL, '108', '2019-12-04', 1),
(10, 'Resident Evil', '9.0', 'Resident Evil, known in Japan as Bio Hazard, is a survival horror video game developed and released by Capcom originally for the PlayStation in 1996, and is the first game in the Resident Evil series.', 'C:\\Cinema\\Assets\\Movies\\resident_evil.jpg', NULL, '105', '2019-12-04', 1),
(11, 'Resident Evil 2', '9.0', 'Resident Evil 2, known in Japan as Biohazard 2, is a survival horror game developed and published by Capcom and released for the PlayStation in 1998.', 'C:\\Cinema\\Assets\\Movies\\resident_evil_2.jpg', NULL, '90', '2019-12-04', 0),
(12, 'Resident Evil: Extinction', '6.3', 'Captured by the Umbrella Corp., Alice (Milla Jovovich) receives genetic alterations that leave her with superhuman abilities. Hiding out in the Nevada desert, she joins forces with former cohorts Carlos (Oded Fehr) and L.J. (Mike Epps) as well as new survivors Claire (Ali Larter), K-Mart (Spencer Locke) and Nurse Betty (Ashanti) to eradicate the virus that threatens to turn every human on Earth into a zombie.', 'C:\\Cinema\\Assets\\Movies\\resident_evil_3.jpg', NULL, '100', '2019-12-04', 1),
(13, 'Resident Evil: Afterlife', '5.9', 'In a world overrun with the walking dead, Alice (Milla Jovovich) continues her battle against Umbrella Corp., rounding up survivors along the way. Joined by an old friend, Alice and her group set out for a rumored safe haven in Los Angeles. Instead of sanctuary, they find the city overrun with zombies, and a trap about to spring.', 'C:\\Cinema\\Assets\\Movies\\resident_evil_4.jpg', NULL, '93', '2019-12-04', 1),
(14, 'Resident Evil: Retribution', '5.4', 'As Umbrella Corps deadly T-virus continues to turn the worlds population into legions of flesh-eating zombies, Alice (Milla Jovovich), the human races last hope, awakes deep within Umbrellas secret operations facility. The further she delves into the complex, the more of her mysterious past is unveiled. Her global hunt for those responsible for the outbreak leads to a mind-blowing revelation; Aided by friends old and new, Alice fights to escape from a world on the edge of oblivion', 'C:\\Cinema\\Assets\\Movies\\resident_evil_5.jpg', NULL, '92', '2019-12-04', 1),
(15, 'Scream', '7.2', 'Wes Craven re-invented and revitalised the slasher-horror genre with this modern horror classic, which manages to be funny, clever and scary, as a fright-masked knife maniac stalks high-school students in middle-class suburbia. Craven is happy to provide both tension and self-parody as the body count mounts - but the victims arent always the ones youd expect.', 'C:\\Cinema\\Assets\\Movies\\scream_!.jpg', NULL, '91', '2019-12-04', 1),
(16, 'Spider Man 2', '7.2', 'When a failed nuclear fusion experiment results in an explosion that kills his wife, Dr. Otto Octavius (Alfred Molina) is transformed into Dr. Octopus, a cyborg with deadly metal tentacles. Doc Ock blames Spider-Man (Tobey Maguire) for the accident and seeks revenge. Meanwhile, Spideys alter ego, Peter Parker, faces fading powers and self-doubt. Complicating matters are his best friends (James Franco) hatred for Spider-Man and his true loves (Kirsten Dunst) sudden engagement to another man.', 'C:\\Cinema\\Assets\\Movies\\spider_man_2.jpg', NULL, '100', '2019-12-04', 1),
(17, 'Spider Man 3', '6.2', 'Peter Parker (Tobey Maguire) and M.J. (Kirsten Dunst) seem to finally be on the right track in their complicated relationship, but trouble looms for the superhero and his lover. Peters Spider-Man suit turns black and takes control of him, not only giving Peter enhanced power but also bringing out the dark side of his personality. Peter must overcome the suits influence as two supervillains, Sandman and Venom, rise up to destroy him and all those he holds dear.', 'C:\\Cinema\\Assets\\Movies\\spider_man_3.jpg', NULL, '102', '2019-12-04', 1),
(18, 'The Fast and the Furious', '6.8', 'Dominic Toretto (Vin Diesel) enjoys the adrenaline of street car racing and his fans treat him like a rock star. After a blazing encounter with the ruthless Johnny Tran, Dom decides to take Brian (Paul Walker), a newcomer to street racing, under his wing. Doms sister Mia sees something she likes in Brian, too. Trouble is, neither of them realize hes an undercover cop, and Dominic and his rival Johnny Tran are both the prime suspects in a case involving dirty money and big-rig hijacking.', 'C:\\Cinema\\Assets\\Movies\\the_fast_furious.jpg', NULL, '104', '2019-12-04', 1),
(19, 'DeadPool', '8.0', 'Wade Wilson (Ryan Reynolds) is a former Special Forces operative who now works as a mercenary. His world comes crashing down when evil scientist Ajax (Ed Skrein) tortures, disfigures and transforms him into Deadpool. The rogue experiment leaves Deadpool with accelerated healing powers and a twisted sense of humor. With help from mutant allies Colossus and Negasonic Teenage Warhead (Brianna Hildebrand), Deadpool uses his new skills to hunt down the man who nearly destroyed his life.', 'C:\\Cinema\\Assets\\Movies\\deadpool.jpg', NULL, '107', '2019-12-04', 0),
(20, 'Resident Evil: The Final Chapter', '5.6', 'The T-virus unleashed by the evil Umbrella Corp. has spread to every corner of the globe, infesting the planet with zombies, demons and monsters. Alice (Milla Jovovich), a former Umbrella employee turned rogue warrior, joins her friends on a last-chance mission to storm the companys headquarters located deep underneath what used to be Raccoon City. But the Red Queen (Ever Anderson) knows that Alice is coming, and the final battle will determine if the rest of mankind lives or dies.', 'C:\\Cinema\\Assets\\Movies\\resident_evil_6.jpg', NULL, '115', '2019-12-04', 1),
(21, 'Shaun of the Dead', '7.9', 'Shaun (Simon Pegg) is a 30-something loser with a dull, easy existence. When hes not working at the electronics store, he lives with his slovenly best friend, Ed (Nick Frost), in a small flat on the outskirts of London. The only unpredictable element in his life is his girlfriend, Liz (Kate Ashfield), who wishes desperately for Shaun to grow up and be a man. When the town is inexplicably overrun with zombies, Shaun must rise to the occasion and protect both Liz and his mother (Penelope Wilton).', 'C:\\Cinema\\Assets\\Movies\\shaun_of_the_dead.jpg', NULL, '120', '2019-12-04', 0),
(22, 'Spider Man 1', '7.3', 'Spider-Man centers on student Peter Parker (Tobey Maguire) who, after being bitten by a genetically-altered spider, gains superhuman strength and the spider-like ability to cling to any surface. He vows to use his abilities to fight crime, coming to understand the words of his beloved Uncle Ben: With great power comes great responsibility.', 'C:\\Cinema\\Assets\\Movies\\spider_man_1.jpg', NULL, '87', '2019-12-04', 1),
(23, 'The Dark Knight', '9.0', 'With the help of allies Lt. Jim Gordon (Gary Oldman) and DA Harvey Dent (Aaron Eckhart), Batman (Christian Bale) has been able to keep a tight lid on crime in Gotham City. But when a vile young criminal calling himself the Joker (Heath Ledger) suddenly throws the town into chaos, the caped Crusader begins to tread a fine line between heroism and vigilantism.', 'C:\\Cinema\\Assets\\Movies\\the_dark_knight.jpg', 'C:\\Cinema\\Assets\\HomeSlide\\TheDarkKnight.jpg', '90', '2019-12-04', 0),
(24, 'The Fast and the Furious: Tokyo Drift', '6.0', 'Sean Boswell (Lucas Black) always feels like an outsider, but he defines himself through his victories as a street racer. His hobby makes him unpopular with the authorities, so he goes to live with his father in Japan. Once there and even more alienated, he learns about an exciting, but dangerous, new style of the sport. The stakes are high when Sean takes on the local champion and falls for the mans girlfriend.', 'C:\\Cinema\\Assets\\Movies\\the_fast_and_the_furious_tokyo_drift.jpg', 'C:\\\\Cinema\\\\Assets\\\\HomeSlide\\\\FastAndFurious.jpg', '115', '2019-12-04', 0),
(25, 'Zombieland', '7.7', 'After a virus turns most people into zombies, the worlds surviving humans remain locked in an ongoing battle against the hungry undead. Four survivors -- Tallahassee (Woody Harrelson) and his cohorts Columbus (Jesse Eisenberg), Wichita (Emma Stone) and Little Rock (Abigail Breslin) -- abide by a list of survival rules and zombie-killing strategies as they make their way toward a rumored safe haven in Los Angeles.', 'C:\\Cinema\\Assets\\Movies\\zombieland.jpg', 'C:\\Cinema\\Assets\\HomeSlide\\zombieland2.jpg', '190', '2019-12-04', 0),
(26, 'Death Race 4', '5.3', 'Death Race: Beyond Anarchy is a 2018 American action film. It is a sequel to the 2008 film Death Race and was directed by Don Michael Paul. The film was released on October 2, 2018 and the fourth film in the Death Race remake series.', 'C:\\Cinema\\Assets\\Movies\\deat_race_4.jpg', '', '115', '2019-12-04', 0);

-- --------------------------------------------------------

--
-- Table structure for table `promotion`
--

CREATE TABLE `promotion` (
  `Promotion_Id` int(11) NOT NULL,
  `Name` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `Picture_URL` varchar(200) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `promotion`
--

INSERT INTO `promotion` (`Promotion_Id`, `Name`, `Picture_URL`) VALUES
(1, 'Slide_1', 'C:\\Cinema\\Assets\\Promotion\\Promosi1.jpg'),
(2, 'Slide_2', 'C:\\Cinema\\CN_Main\\CN_Main\\bin\\Debug\\image\\Promosi2.jpg'),
(3, 'Slide_3', 'C:\\Cinema\\Assets\\Promotion\\Promosi3.jpg'),
(4, 'Slide_4', 'C:\\Cinema\\Assets\\Promotion\\Promosi4.Jpg');

-- --------------------------------------------------------

--
-- Table structure for table `theather`
--

CREATE TABLE `theather` (
  `Theather_Id` int(11) NOT NULL,
  `Cinema` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `Theather_Name` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `Seats` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `theather`
--

INSERT INTO `theather` (`Theather_Id`, `Cinema`, `Theather_Name`, `Seats`) VALUES
(1, 'Cathay', '1', 36),
(2, 'Cathay', '2', 36),
(3, 'Cathay', '3', 36),
(4, 'Cathay', '4', 36),
(5, 'Clark Quay', '1', 36),
(6, 'Clark Quay', '2', 36),
(7, 'Clark Quay', '3', 36),
(8, 'Clark Quay', '4', 36),
(9, 'Vivo City', '1', 36),
(10, 'Vivo City', '2', 36),
(11, 'Vivo City', '3', 36),
(12, 'Vivo City', '4', 36),
(13, 'Yishun', '1', 36),
(14, 'Yishun', '2', 36),
(15, 'Yishun', '3', 36),
(16, 'Yishun', '4', 36),
(17, 'Little India', '1', 36),
(18, 'Little India', '2', 36),
(19, 'Little India', '3', 36),
(20, 'Little India', '4', 36),
(21, 'Orchard', '1', 36),
(22, 'Orchard', '2', 36),
(23, 'Orchard', '3', 36),
(24, 'Orchard', '4', 36),
(25, 'Clementi', '1', 36),
(26, 'Clementi', '2', 36),
(27, 'Clementi', '3', 36),
(28, 'Clementi', '4', 36),
(29, 'Bedok', '1', 36),
(30, 'Bedok', '2', 36),
(31, 'Bedok', '3', 36),
(32, 'Bedok', '4', 36);

-- --------------------------------------------------------

--
-- Table structure for table `ticket`
--

CREATE TABLE `ticket` (
  `Code` int(11) NOT NULL,
  `Type` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `DayCode` int(11) NOT NULL,
  `Price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `ticket`
--

INSERT INTO `ticket` (`Code`, `Type`, `DayCode`, `Price`) VALUES
(1, 'Economy', 1, 35000),
(2, 'Economy', 2, 50000),
(3, 'Premium', 1, 75000),
(4, 'Premium', 2, 100000),
(5, 'Gold', 1, 125000),
(6, 'Gold', 2, 175000),
(7, '3D', 1, 130000),
(8, '3D', 2, 160000);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `User_ID` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Password` varchar(13) NOT NULL,
  `Status` varchar(50) NOT NULL,
  `Sex` varchar(10) NOT NULL,
  `BirthDate` date NOT NULL,
  `Address` varchar(255) NOT NULL,
  `IsEmployee` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`User_ID`, `Name`, `Password`, `Status`, `Sex`, `BirthDate`, `Address`, `IsEmployee`) VALUES
(1, 'Ryo', '1', 'Mahasiswa', 'Male', '2019-10-01', 'Taman kota mas ', 1),
(3, '1', '1', '1', '1', '2019-11-01', '12', 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bookedtickets`
--
ALTER TABLE `bookedtickets`
  ADD PRIMARY KEY (`Ticket_BookId`);

--
-- Indexes for table `bookingcinema`
--
ALTER TABLE `bookingcinema`
  ADD PRIMARY KEY (`Cinema_BookId`);

--
-- Indexes for table `cinemas`
--
ALTER TABLE `cinemas`
  ADD PRIMARY KEY (`Cinema_Id`);

--
-- Indexes for table `movies`
--
ALTER TABLE `movies`
  ADD PRIMARY KEY (`Movie_Id`);

--
-- Indexes for table `promotion`
--
ALTER TABLE `promotion`
  ADD PRIMARY KEY (`Promotion_Id`);

--
-- Indexes for table `theather`
--
ALTER TABLE `theather`
  ADD PRIMARY KEY (`Theather_Id`);

--
-- Indexes for table `ticket`
--
ALTER TABLE `ticket`
  ADD PRIMARY KEY (`Code`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`User_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bookedtickets`
--
ALTER TABLE `bookedtickets`
  MODIFY `Ticket_BookId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `bookingcinema`
--
ALTER TABLE `bookingcinema`
  MODIFY `Cinema_BookId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `cinemas`
--
ALTER TABLE `cinemas`
  MODIFY `Cinema_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=78;

--
-- AUTO_INCREMENT for table `movies`
--
ALTER TABLE `movies`
  MODIFY `Movie_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table `promotion`
--
ALTER TABLE `promotion`
  MODIFY `Promotion_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `theather`
--
ALTER TABLE `theather`
  MODIFY `Theather_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT for table `ticket`
--
ALTER TABLE `ticket`
  MODIFY `Code` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `User_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
