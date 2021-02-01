-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jul 26, 2020 at 12:46 PM
-- Server version: 8.0.18
-- PHP Version: 7.4.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `attendance`
--

-- --------------------------------------------------------

--
-- Table structure for table `log`
--

CREATE TABLE `log` (
  `logID` int(11) NOT NULL,
  `studentID` int(11) NOT NULL,
  `startTime` datetime DEFAULT NULL,
  `endTime` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `log`
--

INSERT INTO `log` (`logID`, `studentID`, `startTime`, `endTime`) VALUES
(23, 92010001, '2020-07-21 00:38:00', '2020-07-21 00:38:07'),
(24, 92010003, '2020-07-21 00:38:16', '2020-07-21 00:38:33'),
(25, 92010001, '2020-07-21 00:38:21', '2020-07-21 00:38:36'),
(26, 92010004, '2020-07-21 00:38:24', '2020-07-21 00:38:30'),
(27, 92010001, '2020-07-21 00:43:57', '2020-07-21 00:44:10'),
(28, 92010005, '2020-07-21 00:44:00', '2020-07-21 00:44:21'),
(29, 92010011, '2020-07-21 00:44:03', '2020-07-21 00:44:29'),
(30, 92010008, '2020-07-21 00:44:06', '2020-07-21 00:44:26'),
(31, 92010005, '2020-07-21 10:44:26', '2020-07-21 11:34:37'),
(32, 92010004, '2020-07-21 10:49:15', '2020-07-21 11:09:55'),
(33, 92010027, '2020-07-21 10:49:20', '2020-07-21 11:35:50'),
(34, 92010003, '2020-07-21 10:59:29', '2020-07-21 11:35:33'),
(35, 92010001, '2020-07-21 11:09:44', '2020-07-21 11:24:55'),
(36, 92010004, '2020-07-21 11:25:02', '2020-07-21 11:30:59'),
(37, 92010001, '2020-07-21 11:31:09', '2020-07-21 11:35:30'),
(38, 92010004, '2020-07-21 11:34:28', '2020-07-21 11:35:37'),
(39, 92010001, '2020-07-21 11:36:37', '2020-07-21 12:08:47'),
(40, 92010004, '2020-07-21 11:36:50', '2020-07-21 11:48:17'),
(41, 92010003, '2020-07-21 11:48:13', '2020-07-21 12:12:36'),
(43, 92010005, '2020-07-21 12:20:20', '2020-07-21 12:21:45'),
(44, 92019797, '2020-07-21 12:23:53', '2020-07-21 12:23:58'),
(45, 92010005, '2020-07-21 12:25:50', '2020-07-21 12:38:01'),
(46, 92010003, '2020-07-21 12:26:06', '2020-07-21 12:34:52'),
(47, 92010004, '2020-07-21 12:27:36', '2020-07-21 12:32:17'),
(49, 92010004, '2020-07-21 12:35:34', '2020-07-21 12:44:32'),
(50, 92010003, '2020-07-21 12:35:52', '2020-07-21 12:37:21'),
(51, 92010007, '2020-07-21 12:37:44', '2020-07-26 22:20:04'),
(52, 92010003, '2020-07-21 12:37:53', '2020-07-21 16:03:58'),
(53, 92010027, '2020-07-21 12:39:57', '2020-07-21 13:23:24'),
(54, 92010008, '2020-07-21 13:31:02', '2020-07-26 22:51:59'),
(55, 92010005, '2020-07-21 13:54:52', '2020-07-21 15:21:43'),
(56, 92010004, '2020-07-21 13:57:18', '2020-07-21 14:22:21'),
(57, 92010004, '2020-07-21 14:46:26', '2020-07-21 14:46:29'),
(58, 92010001, '2020-07-21 15:32:20', '2020-07-26 19:57:09'),
(59, 92010000, '2020-07-21 16:04:04', '2020-07-21 16:44:15'),
(60, 92010005, '2020-07-21 16:44:07', '2020-07-26 22:18:48'),
(61, 92010000, '2020-07-21 16:44:19', '2020-07-21 16:44:21'),
(62, 92010000, '2020-07-21 16:44:33', '2020-07-21 16:44:40'),
(63, 92019797, '2020-07-21 16:45:52', '2020-07-21 16:46:01'),
(64, 92010004, '2020-07-25 00:35:36', '2020-07-26 21:25:50'),
(65, 92019797, '2020-07-26 20:00:37', '2020-07-26 20:00:41');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `studentID` int(11) NOT NULL,
  `studentName` varchar(255) DEFAULT NULL,
  `signIn` tinyint(1) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`studentID`, `studentName`, `signIn`) VALUES
(92010000, 'Josiah Z. Sweeney', 0),
(92010001, 'Benjamin E. Clark', 0),
(92010002, 'Flavia E. Mayer', 0),
(92010003, 'Oscar L. Marshall', 0),
(92010004, 'Oleg H. Richards', 0),
(92010005, 'Chester N. Sullivan', 0),
(92010006, 'Illana Q. Briggs', 0),
(92010007, 'Colin C. Bradford', 0),
(92010008, 'Idona P. Branch', 0),
(92010009, 'Howard V. Lawson', 0),
(92010010, 'Timothy H. Wilder', 0),
(92010011, 'Hillary B. Hendricks', 0),
(92010012, 'Yardley H. Gallagher', 0),
(92010013, 'Joelle E. Sanford', 0),
(92010014, 'Craig Y. Sandoval', 0),
(92010015, 'Duncan H. Briggs', 0),
(92010016, 'Brianna Z. Valenzuela', 0),
(92010017, 'Yuli C. Lowery', 0),
(92010018, 'Cullen A. Nolan', 0),
(92010019, 'Hillary T. Byrd', 0),
(92010020, 'Amir C. Boyd', 0),
(92010021, 'Branden I. Hubbard', 0),
(92010022, 'Lani U. Singleton', 0),
(92010023, 'Orlando M. Mayer', 0),
(92010024, 'Gil W. Duffy', 0),
(92010025, 'Joshua J. Welch', 0),
(92010026, 'Kato R. Massey', 0),
(92010027, 'Chava V. Osborn', 0),
(92010028, 'Dominic Q. Garza', 0),
(92010029, 'Grace X. Mccoy', 0),
(92010030, 'Ruth D. Johnson', 0),
(92010031, 'Vernon R. Prince', 0),
(92010032, 'Francis G. David', 0),
(92010033, 'Unity S. Potter', 0),
(92010034, 'Madonna Q. Richmond', 0),
(92010035, 'Clinton C. Daniel', 0),
(92010036, 'Madonna B. Aguirre', 0),
(92010037, 'Thane H. Peters', 0),
(92010038, 'Erich J. Copeland', 0),
(92010039, 'Blair I. Dyer', 0),
(92010040, 'Zephr L. Howell', 0),
(92010041, 'Judah D. Bridges', 0),
(92010042, 'Nigel U. Le', 0),
(92010043, 'Zephania V. Kinney', 0),
(92010044, 'Oscar X. Wall', 0),
(92010045, 'Hall H. Ingram', 0),
(92010046, 'Penelope G. Robinson', 0),
(92010047, 'Kimberley O. Valenzuela', 0),
(92010048, 'Riley V. Copeland', 0),
(92010049, 'Brenden A. Munoz', 0),
(92010050, 'Basil H. Webster', 0),
(92010051, 'Myra N. Strong', 0),
(92010052, 'Ethan N. Collins', 0),
(92010053, 'Thaddeus B. Jarvis', 0),
(92010054, 'Rama P. Barry', 0),
(92010055, 'Mallory U. Montoya', 0),
(92010056, 'Seth G. Rasmussen', 0),
(92010057, 'Alana M. Odom', 0),
(92010058, 'Francis I. Hendricks', 0),
(92010059, 'Unity U. Matthews', 0),
(92010060, 'Malachi G. Leach', 0),
(92010061, 'Victor O. Page', 0),
(92010062, 'Zephania T. Daniel', 0),
(92010063, 'Rajah M. Farrell', 0),
(92010064, 'Angela U. Nash', 0),
(92010065, 'Alden E. Leblanc', 0),
(92010066, 'Raymond O. Sanford', 0),
(92010067, 'Lev R. Oneil', 0),
(92010068, 'Heather I. Moses', 0),
(92010069, 'Vielka P. Giles', 0),
(92010070, 'Hadassah X. Grimes', 0),
(92010071, 'Ayanna F. Pearson', 0),
(92010072, 'Virginia I. Norris', 0),
(92010073, 'Maryam O. Crawford', 0),
(92010074, 'Lydia D. Booker', 0),
(92010075, 'Dane G. Phillips', 0),
(92010076, 'Skyler N. Oconnor', 0),
(92010077, 'Savannah P. Parsons', 0),
(92010078, 'Damian N. Cohen', 0),
(92010079, 'Dorothy Z. Drake', 0),
(92010080, 'Anastasia S. Wiley', 0),
(92010081, 'Keelie G. Jacobson', 0),
(92010082, 'Zenaida N. Weaver', 0),
(92010083, 'Quinn E. Russo', 0),
(92010084, 'Felix W. Branch', 0),
(92010085, 'Britanni Y. Newman', 0),
(92010086, 'John T. Turner', 0),
(92010087, 'Elton Y. Hoover', 0),
(92010088, 'Virginia S. Vang', 0),
(92010089, 'Isabella F. Medina', 0),
(92010090, 'Madeson B. Marquez', 0),
(92010091, 'Jessica Q. Day', 0),
(92010092, 'Shaeleigh I. Lawson', 0),
(92010093, 'Driscoll S. Holland', 0),
(92010094, 'Louis A. Anderson', 0),
(92010095, 'Rhoda Y. Keith', 0),
(92010096, 'Ignatius Q. Wise', 0),
(92010097, 'William D. Adkins', 0),
(92010098, 'Hayfa M. Davis', 0),
(92010099, 'Vivien F. Leblanc', 0),
(92019797, 'Chung L. Tsao', 0),
(92019999, 'John Merryweather', 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `log`
--
ALTER TABLE `log`
  ADD PRIMARY KEY (`logID`),
  ADD UNIQUE KEY `logID_UNIQUE` (`logID`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`studentID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `log`
--
ALTER TABLE `log`
  MODIFY `logID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=73;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
