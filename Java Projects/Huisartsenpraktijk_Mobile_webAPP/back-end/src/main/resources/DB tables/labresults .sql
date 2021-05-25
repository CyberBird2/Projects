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
-- Table structure for table `labresults`
--

CREATE TABLE `labresults` (
  `lab_ResultID` int(11) NOT NULL,
  `patientID` int(11) NOT NULL,
  `result_Description` longtext NOT NULL,
  `lab_Name` varchar(200) NOT NULL,
  `date_Taken` date NOT NULL,
  `date_Ready` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `labresults`
--

INSERT INTO `labresults` (`lab_ResultID`, `patientID`, `result_Description`, `lab_Name`, `date_Taken`, `date_Ready`) VALUES
(1, 1, 'Result description', 'NL Lab', '2020-11-04', '2020-11-05');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `labresults`
--
ALTER TABLE `labresults`
  ADD PRIMARY KEY (`lab_ResultID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `labresults`
--
ALTER TABLE `labresults`
  MODIFY `lab_ResultID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
