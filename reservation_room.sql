-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Nov 10, 2021 at 06:52 AM
-- Server version: 8.0.17
-- PHP Version: 7.3.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `reservation_room`
--

-- --------------------------------------------------------

--
-- Table structure for table `normal_informations`
--

CREATE TABLE `normal_informations` (
  `CustomerName` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `CustomerLastName` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `CustomerIDCard` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `CustomerPhoneNumber` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `CustomerAddress` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `CustomerBloodType` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `CongenitalDisease` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `BookingDate` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `normal_informations`
--

INSERT INTO `normal_informations` (`CustomerName`, `CustomerLastName`, `CustomerIDCard`, `CustomerPhoneNumber`, `CustomerAddress`, `CustomerBloodType`, `CongenitalDisease`, `BookingDate`) VALUES
('Teerapong', 'Pinkaew', '112', '4793', 'Bangkok', 'O', 'No', '2021-12-02');

-- --------------------------------------------------------

--
-- Table structure for table `sign_in`
--

CREATE TABLE `sign_in` (
  `email` varchar(30) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `pass` varchar(30) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `sign_in`
--

INSERT INTO `sign_in` (`email`, `pass`) VALUES
('thirapong.p@ku.th', 'Asdopoo123!'),
('admin', '1'),
('1', '1'),
('', ''),
('a', 'a');

-- --------------------------------------------------------

--
-- Table structure for table `suit_informations`
--

CREATE TABLE `suit_informations` (
  `CustomerName` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `CustomerLastName` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `CustomerIDCard` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `CustomerPhoneNumber` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `CustomerAddress` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `CustomerBloodType` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `CongenitalDisease` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `BookingDate` varchar(50) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `suit_informations`
--

INSERT INTO `suit_informations` (`CustomerName`, `CustomerLastName`, `CustomerIDCard`, `CustomerPhoneNumber`, `CustomerAddress`, `CustomerBloodType`, `CongenitalDisease`, `BookingDate`) VALUES
('Teerapong', 'Pinkaew', '112', '47937', 'Bangkok', 'O', 'No', '2021-11-03');

-- --------------------------------------------------------

--
-- Table structure for table `sweet_informations`
--

CREATE TABLE `sweet_informations` (
  `CustomerName` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `CustomerLastName` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `CustomerIDCard` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `CustomerPhoneNumber` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `CustomerAddress` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `CustomerBloodType` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `CongenitalDisease` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `BookingDate` varchar(50) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `sweet_informations`
--

INSERT INTO `sweet_informations` (`CustomerName`, `CustomerLastName`, `CustomerIDCard`, `CustomerPhoneNumber`, `CustomerAddress`, `CustomerBloodType`, `CongenitalDisease`, `BookingDate`) VALUES
('Teerapong', 'Pinkaew', '112', '4793', 'Bangkok', 'O', 'No', '2021-11-04');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
