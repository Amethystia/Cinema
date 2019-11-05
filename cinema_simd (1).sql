-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 05, 2019 at 03:24 PM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 7.3.1

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
CREATE DATABASE IF NOT EXISTS `cinema_simd` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;
USE `cinema_simd`;

-- --------------------------------------------------------

--
-- Table structure for table `cinemas`
--

CREATE TABLE `cinemas` (
  `cinema_name` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `movie_name` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `theather` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `date` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `time` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `class` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `cinemas`
--

INSERT INTO `cinemas` (`cinema_name`, `movie_name`, `theather`, `date`, `time`, `class`) VALUES
('Cathay', 'Death Race', '1', '3/11/2019', '14:00', 'Economy'),
('Jurong', 'Death Race 2', '2', '3/11/2019', '14:00', 'GOLD'),
('Clark Quay', 'Death Race 3', '2', '3/11/2019', '14:00', 'Economy'),
('Cathay', 'Death Race 4', '3', '3/11/2019', '14:00', 'PREMIUM'),
('Jurong', 'Maze Runner: The Scorch Trials', '3', '3/11/2019', '14:00', 'Economy'),
('Clark Quay', 'Maze Runner: The Death Cure', '1', '3/11/2019', '14:00', 'PREMIUM'),
('Cathay', 'The Lord of the Rings: The Fellowship of the Ring', '2', '3/11/2019', '14:00', 'Economy'),
('Vivo City', 'The Lord of the Rings: The Two Towers', '3', '3/11/2019', '14:00', 'PREMIUM'),
('Jurong', 'The Lord of the Rings: The Return of the King', '3', '3/11/2019', '14:00', '3D'),
('Vivo City', 'Resident Evil', '2', '3/11/2019', '14:00', 'Economy'),
('Cathay', 'Resident Evil 2', '1', '3/11/2019', '14:00', 'GOLD'),
('Vivo City', 'Resident Evil: Extinction', '2', '3/11/2019', '14:00', 'Economy'),
('Jurong', 'Resident Evil: Afterlife', '3', '3/11/2019', '14:00', 'Economy'),
('Cathay', 'Resident Evil: Retribution', '1', '3/11/2019', '14:00', 'PREMIUM'),
('Vivo City', 'Scream', '2', '3/11/2019', '14:00', 'Economy'),
('Jurong', 'Spider Man 2', '3', '3/11/2019', '14:00', 'PREMIUM'),
('Cathay', 'Spider Man 3', '1', '3/11/2019', '14:00', 'Economy'),
('Vivo City', 'The Fast and the Furious', '1', '3/11/2019', '14:00', 'GOLD'),
('Jurong', 'DeadPool', '2', '3/11/2019', '14:00', 'Economy'),
('Cathay', 'Resident Evil: The Final Chapter', '3', '3/11/2019', '14:00', 'Economy'),
('Vivo City', 'Shaun of the Dead', '1', '3/11/2019', '14:00', 'Economy'),
('Jurong', 'Spider Man 1', '1', '3/11/2019', '14:00', 'GOLD'),
('Cathay', 'The Dark Knight', '2', '3/11/2019', '14:00', 'Economy'),
('Vivo City', 'The Fast and the Furious: Tokyo Drift', '3', '3/11/2019', '14:00', 'Economy'),
('Jurong', 'Zombieland', '3', '3/11/2019', '14:00', '3D'),
('Yishun', 'Death Race', '1', '3/11/2019', '16:00', 'Economy'),
('Little India', 'Death Race 2', '2', '3/11/2019', '16:00', 'Economy'),
('Orchard', 'Death Race 3', '3', '3/11/2019', '16:00', 'Economy'),
('Orchard', 'Death Race 4', '1', '3/11/2019', '16:00', 'GOLD'),
('Orchard', 'Maze Runner: The Scorch Trials', '2', '3/11/2019', '16:00', 'Economy'),
('Orchard', 'Maze Runner: The Death Cure', '3', '3/11/2019', '16:00', '3D'),
('Orchard', 'The Lord of the Rings: The Fellowship of the Ring', '1', '3/11/2019', '16:00', 'Economy'),
('Orchard', 'The Lord of the Rings: The Two Towers', '2', '3/11/2019', '16:00', 'PREMIUM'),
('Little India', 'The Lord of the Rings: The Return of the King', '3', '3/11/2019', '16:00', 'Economy'),
('Little India', 'Resident Evil', '1', '3/11/2019', '16:00', 'Economy'),
('Little India', 'Resident Evil 2', '2', '3/11/2019', '16:00', '3D'),
('Yishun', 'Resident Evil: Extinction', '3', '3/11/2019', '16:00', 'Economy'),
('Yishun', 'Resident Evil: Afterlife', '1', '3/11/2019', '16:00', 'Economy'),
('Yishun', 'Resident Evil: Retribution', '2', '3/11/2019', '16:00', 'GOLD'),
('Little India', 'Scream', '3', '3/11/2019', '16:00', 'Economy'),
('Yishun', 'Spider Man 2', '1', '3/11/2019', '16:00', 'Economy'),
('Clementi', 'Spider Man 3', '2', '3/11/2019', '16:00', 'PREMIUM'),
('Clementi', 'The Fast and the Furious', '3', '3/11/2019', '16:00', 'Economy'),
('Clementi', 'DeadPool', '1', '3/11/2019', '16:00', 'PREMIUM'),
('Little India', 'Resident Evil: The Final Chapter', '2', '3/11/2019', '16:00', '3D'),
('Bedok', 'Shaun of the Dead', '3', '3/11/2019', '16:00', 'Economy'),
('Bedok', 'Spider Man 1', '1', '3/11/2019', '16:00', '3D'),
('Bedok', 'The Dark Knight', '2', '3/11/2019', '16:00', 'GOLD'),
('Little India', 'The Fast and the Furious: Tokyo Drift', '3', '3/11/2019', '16:00', 'Economy'),
('Yishun', 'Zombieland', '3', '3/11/2019', '16:00', 'Economy');

-- --------------------------------------------------------

--
-- Table structure for table `movies`
--

CREATE TABLE `movies` (
  `id` int(11) NOT NULL,
  `movie_name` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `movie_imdb` varchar(4) COLLATE utf8_unicode_ci DEFAULT NULL,
  `movie_description` varchar(5000) COLLATE utf8_unicode_ci DEFAULT NULL,
  `movie_image` varchar(250) COLLATE utf8_unicode_ci DEFAULT NULL,
  `duration` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `movies`
--

INSERT INTO `movies` (`id`, `movie_name`, `movie_imdb`, `movie_description`, `movie_image`, `duration`) VALUES
(1, 'Death Race', '6.4', 'Framed for a murder he did not commit, three-time speedway champ Jensen Ames (Jason Statham) finds himself at Terminal Island, the countrys toughest prison, but he gets an unexpected chance at freedom when the warden offers a choice: Compete in the Death Race as a mythical driver called Frankenstein, or rot in a cell forever. Riding in a car equipped with flamethrowers and grenade launchers, Ames must survive a gauntlet of vicious criminals to win his freedom -- or die trying.', 'C:\\Cinema\\Assets\\Movies\\deat_race.jpg', '120'),
(2, 'Death Race 2', '5.6', 'After being convicted of killing a cop, a prison inmate tries to win his freedom by competing in a brutal race where cars are deadly weapons.', 'C:\\Cinema\\Assets\\Movies\\deat_race_2.jpg', '100'),
(3, 'Death Race 3', '5.5', 'Only one victory away from winning his freedom, legendary driver Carl Lucas (Luke Goss) enters the first Death Race to take place in the brutal Kalahari Desert.', 'C:\\Cinema\\Assets\\Movies\\deat_race_3.jpg', '125'),
(4, 'Death Race 4', '5.3', 'Death Race: Beyond Anarchy is a 2018 American action film. It is a sequel to the 2008 film Death Race and was directed by Don Michael Paul. The film was released on October 2, 2018 and the fourth film in the Death Race remake series.', 'C:\\Cinema\\Assets\\Movies\\deat_race_4.jpg', '115'),
(5, 'Maze Runner: The Scorch Trials', '4.3', 'Transported to a remote fortified outpost, Thomas and his fellow teenage Gladers find themselves in trouble after uncovering a diabolical plot from the mysterious and powerful organization WCKD. With help from a new ally, the Gladers stage a daring escape into the Scorch, a desolate landscape filled with dangerous obstacles and crawling with the virus-infected Cranks. The Gladers only hope may be to find the Right Hand, a group of resistance fighters who can help them battle WCKD.', 'C:\\Cinema\\Assets\\Movies\\labirent_2.jpg', '100'),
(6, 'Maze Runner: The Death Cure', '9.5', 'Thomas leads some escaped Gladers on their final and most dangerous mission yet. To save their friends, they must break into the legendary Last City, a WCKD-controlled labyrinth that may turn out to be the deadliest maze of all. Anyone who makes it out alive will get answers to the questions that the Gladers have been asking since they arrived in the maze.', 'C:\\Cinema\\Assets\\Movies\\labirent_3.jpg', '98'),
(7, 'The Lord of the Rings: The Fellowship of the Ring', '8.8', 'The future of civilization rests in the fate of the One Ring, which has been lost for centuries. Powerful forces are unrelenting in their search for it. But fate has placed it in the hands of a young Hobbit named Frodo Baggins (Elijah Wood), who inherits the Ring and steps into legend. A daunting task lies ahead for Frodo when he becomes the Ringbearer - to destroy the One Ring in the fires of Mount Doom where it was forged.', 'C:\\Cinema\\Assets\\Movies\\lord_of_the_rings_1.jpg', '102'),
(8, 'The Lord of the Rings: The Two Towers', '8.7', 'The sequel to the Golden Globe-nominated and AFI Award-winning \"The Lord of the Rings: The Fellowship of the Ring,\" \"The Two Towers\" follows the continuing quest of Frodo (Elijah Wood) and the Fellowship to destroy the One Ring. Frodo and Sam (Sean Astin) discover they are being followed by the mysterious Gollum. Aragorn (Viggo Mortensen), the Elf archer Legolas and Gimli the Dwarf encounter the besieged Rohan kingdom, whose once great King Theoden has fallen under Sarumans deadly spell.', 'C:\\Cinema\\Assets\\Movies\\lord_of_the_rings_2.jpg', '105'),
(9, 'The Lord of the Rings: The Return of the King', '8.9', 'The Lord of the Rings: The Return of the King is a 2003 epic fantasy adventure film co-produced, co-written, and directed by Peter Jackson based on the second and third volumes of J. R. R. Tolkiens The Lord of the Rings.', 'C:\\Cinema\\Assets\\Movies\\lord_of_the_rings_3.jpg', '108'),
(10, 'Resident Evil', '9.0', 'Resident Evil, known in Japan as Bio Hazard, is a survival horror video game developed and released by Capcom originally for the PlayStation in 1996, and is the first game in the Resident Evil series.', 'C:\\Cinema\\Assets\\Movies\\resident_evil.jpg', '105'),
(11, 'Resident Evil 2', '9.0', 'Resident Evil 2, known in Japan as Biohazard 2, is a survival horror game developed and published by Capcom and released for the PlayStation in 1998.', 'C:\\Cinema\\Assets\\Movies\\resident_evil_2.jpg', '90'),
(12, 'Resident Evil: Extinction', '6.3', 'Captured by the Umbrella Corp., Alice (Milla Jovovich) receives genetic alterations that leave her with superhuman abilities. Hiding out in the Nevada desert, she joins forces with former cohorts Carlos (Oded Fehr) and L.J. (Mike Epps) as well as new survivors Claire (Ali Larter), K-Mart (Spencer Locke) and Nurse Betty (Ashanti) to eradicate the virus that threatens to turn every human on Earth into a zombie.', 'C:\\Cinema\\Assets\\Movies\\resident_evil_3.jpg', '100'),
(13, 'Resident Evil: Afterlife', '5.9', 'In a world overrun with the walking dead, Alice (Milla Jovovich) continues her battle against Umbrella Corp., rounding up survivors along the way. Joined by an old friend, Alice and her group set out for a rumored safe haven in Los Angeles. Instead of sanctuary, they find the city overrun with zombies, and a trap about to spring.', 'C:\\Cinema\\Assets\\Movies\\resident_evil_4.jpg', '93'),
(14, 'Resident Evil: Retribution', '5.4', 'As Umbrella Corps deadly T-virus continues to turn the worlds population into legions of flesh-eating zombies, Alice (Milla Jovovich), the human races last hope, awakes deep within Umbrellas secret operations facility. The further she delves into the complex, the more of her mysterious past is unveiled. Her global hunt for those responsible for the outbreak leads to a mind-blowing revelation; Aided by friends old and new, Alice fights to escape from a world on the edge of oblivion', 'C:\\Cinema\\Assets\\Movies\\resident_evil_5.jpg', '92'),
(15, 'Scream', '7.2', 'Wes Craven re-invented and revitalised the slasher-horror genre with this modern horror classic, which manages to be funny, clever and scary, as a fright-masked knife maniac stalks high-school students in middle-class suburbia. Craven is happy to provide both tension and self-parody as the body count mounts - but the victims arent always the ones youd expect.', 'C:\\Cinema\\Assets\\Movies\\scream_!.jpg', '91'),
(16, 'Spider Man 2', '7.2', 'When a failed nuclear fusion experiment results in an explosion that kills his wife, Dr. Otto Octavius (Alfred Molina) is transformed into Dr. Octopus, a cyborg with deadly metal tentacles. Doc Ock blames Spider-Man (Tobey Maguire) for the accident and seeks revenge. Meanwhile, Spideys alter ego, Peter Parker, faces fading powers and self-doubt. Complicating matters are his best friends (James Franco) hatred for Spider-Man and his true loves (Kirsten Dunst) sudden engagement to another man.', 'C:\\Cinema\\Assets\\Movies\\spider_man_2.jpg', '100'),
(17, 'Spider Man 3', '6.2', 'Peter Parker (Tobey Maguire) and M.J. (Kirsten Dunst) seem to finally be on the right track in their complicated relationship, but trouble looms for the superhero and his lover. Peters Spider-Man suit turns black and takes control of him, not only giving Peter enhanced power but also bringing out the dark side of his personality. Peter must overcome the suits influence as two supervillains, Sandman and Venom, rise up to destroy him and all those he holds dear.', 'C:\\Cinema\\Assets\\Movies\\spider_man_3.jpg', '102'),
(18, 'The Fast and the Furious', '6.8', 'Dominic Toretto (Vin Diesel) enjoys the adrenaline of street car racing and his fans treat him like a rock star. After a blazing encounter with the ruthless Johnny Tran, Dom decides to take Brian (Paul Walker), a newcomer to street racing, under his wing. Doms sister Mia sees something she likes in Brian, too. Trouble is, neither of them realize hes an undercover cop, and Dominic and his rival Johnny Tran are both the prime suspects in a case involving dirty money and big-rig hijacking.', 'C:\\Cinema\\Assets\\Movies\\the_fast_furious.jpg', '104'),
(19, 'DeadPool', '8.0', 'Wade Wilson (Ryan Reynolds) is a former Special Forces operative who now works as a mercenary. His world comes crashing down when evil scientist Ajax (Ed Skrein) tortures, disfigures and transforms him into Deadpool. The rogue experiment leaves Deadpool with accelerated healing powers and a twisted sense of humor. With help from mutant allies Colossus and Negasonic Teenage Warhead (Brianna Hildebrand), Deadpool uses his new skills to hunt down the man who nearly destroyed his life.', 'C:\\Cinema\\Assets\\Movies\\deadpool.jpg', '107'),
(20, 'Resident Evil: The Final Chapter', '5.6', 'The T-virus unleashed by the evil Umbrella Corp. has spread to every corner of the globe, infesting the planet with zombies, demons and monsters. Alice (Milla Jovovich), a former Umbrella employee turned rogue warrior, joins her friends on a last-chance mission to storm the companys headquarters located deep underneath what used to be Raccoon City. But the Red Queen (Ever Anderson) knows that Alice is coming, and the final battle will determine if the rest of mankind lives or dies.', 'C:\\Cinema\\Assets\\Movies\\resident_evil_6.jpg', '115'),
(21, 'Shaun of the Dead', '7.9', 'Shaun (Simon Pegg) is a 30-something loser with a dull, easy existence. When hes not working at the electronics store, he lives with his slovenly best friend, Ed (Nick Frost), in a small flat on the outskirts of London. The only unpredictable element in his life is his girlfriend, Liz (Kate Ashfield), who wishes desperately for Shaun to grow up and be a man. When the town is inexplicably overrun with zombies, Shaun must rise to the occasion and protect both Liz and his mother (Penelope Wilton).', 'C:\\Cinema\\Assets\\Movies\\shaun_of_the_dead.jpg', '120'),
(22, 'Spider Man 1', '7.3', 'Spider-Man centers on student Peter Parker (Tobey Maguire) who, after being bitten by a genetically-altered spider, gains superhuman strength and the spider-like ability to cling to any surface. He vows to use his abilities to fight crime, coming to understand the words of his beloved Uncle Ben: With great power comes great responsibility.', 'C:\\Cinema\\Assets\\Movies\\spider_man_1.jpg', '87'),
(23, 'The Dark Knight', '9.0', 'With the help of allies Lt. Jim Gordon (Gary Oldman) and DA Harvey Dent (Aaron Eckhart), Batman (Christian Bale) has been able to keep a tight lid on crime in Gotham City. But when a vile young criminal calling himself the Joker (Heath Ledger) suddenly throws the town into chaos, the caped Crusader begins to tread a fine line between heroism and vigilantism.', 'C:\\Cinema\\Assets\\Movies\\the_dark_knight.jpg', '90'),
(24, 'The Fast and the Furious: Tokyo Drift', '6.0', 'Sean Boswell (Lucas Black) always feels like an outsider, but he defines himself through his victories as a street racer. His hobby makes him unpopular with the authorities, so he goes to live with his father in Japan. Once there and even more alienated, he learns about an exciting, but dangerous, new style of the sport. The stakes are high when Sean takes on the local champion and falls for the mans girlfriend.', 'C:\\Cinema\\Assets\\Movies\\the_fast_and_the_furious_tokyo_drift.jpg', '115'),
(25, 'Zombieland', '7.7', 'After a virus turns most people into zombies, the worlds surviving humans remain locked in an ongoing battle against the hungry undead. Four survivors -- Tallahassee (Woody Harrelson) and his cohorts Columbus (Jesse Eisenberg), Wichita (Emma Stone) and Little Rock (Abigail Breslin) -- abide by a list of survival rules and zombie-killing strategies as they make their way toward a rumored safe haven in Los Angeles.', 'C:\\Cinema\\Assets\\Movies\\zombieland.jpg', '190');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `ID` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Password` varchar(13) NOT NULL,
  `Status` varchar(50) NOT NULL,
  `Sex` varchar(10) NOT NULL,
  `BirthDate` date NOT NULL,
  `Address` varchar(255) NOT NULL,
  `IsActive` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`ID`, `Name`, `Password`, `Status`, `Sex`, `BirthDate`, `Address`, `IsActive`) VALUES
(1, 'Ryo', '1', 'Mahasiswa', 'Male', '2019-10-01', 'Taman kota mas ', 1),
(2, 's', 's', 's', 's', '2019-11-01', 's', 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `movies`
--
ALTER TABLE `movies`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `movies`
--
ALTER TABLE `movies`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
