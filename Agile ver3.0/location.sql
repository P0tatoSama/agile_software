-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Dec 10, 2019 at 02:38 PM
-- Server version: 5.7.26
-- PHP Version: 7.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `agile_algorithm5`
--

-- --------------------------------------------------------

--
-- Table structure for table `location`
--

DROP TABLE IF EXISTS `location`;
CREATE TABLE IF NOT EXISTS `location` (
  `Location_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Location_Name` varchar(60) DEFAULT NULL,
  `Location_Category` varchar(255) NOT NULL,
  `Location_Address` varchar(255) DEFAULT NULL,
  `Location_City` varchar(50) NOT NULL,
  `Location_Rating` decimal(20,1) DEFAULT NULL,
  `Location_Review` int(20) DEFAULT NULL,
  `Location_Photo` text,
  PRIMARY KEY (`Location_ID`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `location`
--

INSERT INTO `location` (`Location_ID`, `Location_Name`, `Location_Category`, `Location_Address`, `Location_City`, `Location_Rating`, `Location_Review`, `Location_Photo`) VALUES
(1, 'Prima Setapak Condominium', 'Accommodation', 'Address: Prima Setapak Condominium, Taman Setapak, 53100 Kuala Lumpur, Wilayah Persekutuan Kuala Lumpur', 'Setapak', '4.1', 75, 'LocationPhoto/Prima.png'),
(2, 'PV13 Platinum Lake Condominium', 'Accommodation', 'Address: G16,PV13 Platinum Lake Condominium, No.9, Jalan Danau Saujana 1, Setapak, 53300 Kuala Lumpur', 'Setapak', '4.0', 597, 'LocationPhoto/pv13.jpg'),
(3, 'Setapak Central Mall', 'Attraction and Entertainment', 'Address: 67, Jalan Taman Ibu Kota, Taman Danau Kota, 53300 Kuala Lumpur, Wilayah Persekutuan Kuala Lumpur', 'Setapak', '4.2', 8256, 'LocationPhoto/setapakcentral.jpg'),
(4, 'Sushi Mentai', 'Food and Beverage', 'Address: 126, Jalan Genting Kelang, Taman Danau Kota, 53300 Kuala Lumpur, Wilayah Persekutuan Kuala Lumpur', 'Setapak', '4.1', 962, 'LocationPhoto/sushimentai.jpg'),
(5, 'Tunku Abdul Rahman University College', 'Education', 'Address: Kampus Utama, Jalan Genting Kelang, 53300 Kuala Lumpur, Wilayah Persekutuan Kuala Lumpur', 'Setapak', '4.4', 9844, 'LocationPhoto/tarc.jpg'),
(6, 'New Chapter by The Owls Cafe', 'Food and Beverage', 'Calvary Convention Centre, 1, Jalan Jalil Perkasa 1, Bukit Jalil, 57100 Kuala Lumpur, Wilayah Persekutuan Kuala Lumpur', 'Bukit Jalil', '4.3', 1336, 'LocationPhoto/Owl.JPG'),
(7, 'National Stadium Bukit Jalil', 'Attraction and Entertainment', 'Jalan Barat, Bukit Jalil, 57000 Kuala Lumpur, Wilayah Persekutuan Kuala Lumpur', 'Bukit Jalil', '4.5', 6559, 'LocationPhoto/Stadium.jpg'),
(8, 'Stage Cafe', 'Food and Beverage', '2-1, Jalan Temenggung 29/9, Bandar Mahkota Cheras, 43200 Kajang, Selangor', 'Cheras', '4.4', 308, 'LocationPhoto/Stage.jpg'),
(9, 'Shi Fu Wantan Mee', 'Food and Beverage', '14, Jalan Manis 4, Taman Segar, Kuala Lumpur, Cheras, 56100', 'Cheras', '4.0', 183, 'LocationPhoto/SHifu.jpg'),
(10, 'Poppo Kanteen', 'Food and Beverage', '26, Jalan Manis 4, Taman Segar, Kuala Lumpur, Cheras, 56100', 'Cheras', '3.9', 416, 'LocationPhoto/Poppo.jpg'),
(11, 'Pavilion Kuala Lumpur', 'Attraction and Entertainment', '168, Jalan Bukit Bintang, Bukit Bintang, 55100 Kuala Lumpur, Wilayah Persekutuan Kuala Lumpur', 'Bukit Bintang', '4.6', 37221, 'LocationPhoto/pavilion.jpg');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
