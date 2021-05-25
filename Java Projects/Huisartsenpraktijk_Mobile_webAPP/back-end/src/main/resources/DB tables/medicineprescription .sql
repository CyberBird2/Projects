-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 17, 2020 at 11:02 PM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pharma`
--

-- --------------------------------------------------------

--
-- Table structure for table `medicineprescription`
--

CREATE TABLE `medicineprescription` (
  `prescriptionID` int(11) NOT NULL,
  `patientID` int(11) NOT NULL,
  `prescription` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `medicineprescription`
--

INSERT INTO `medicineprescription` (`prescriptionID`, `patientID`, `prescription`) VALUES
(1, 1, 'Paracetamol 2 times a day, one in the morning and one in the afternoon'),
(2, 1, 'Paracetamol 3 times a day, one in the morning and one in the afternoon and one before going to bed'),
(3, 1, 'Paracetamol 4 times a day, one in the morning and one in the afternoon and two before going to bed'),
(4, 2, 'Paracetamol 2 times a day, one in the morning and one in the afternoon'),
(5, 3, 'Paracetamol 2 times a day, one in the morning and one in the afternoon');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `medicineprescription`
--
ALTER TABLE `medicineprescription`
  ADD PRIMARY KEY (`prescriptionID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `medicineprescription`
--
ALTER TABLE `medicineprescription`
  MODIFY `prescriptionID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
