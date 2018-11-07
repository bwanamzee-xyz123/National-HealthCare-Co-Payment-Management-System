-- phpMyAdmin SQL Dump
-- version 4.5.4.1deb2ubuntu2
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: May 10, 2017 at 06:31 PM
-- Server version: 5.7.17-0ubuntu0.16.04.2
-- PHP Version: 7.0.15-0ubuntu0.16.04.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ellie_nhcpms`
--

-- --------------------------------------------------------

--
-- Table structure for table `approval`
--

CREATE TABLE `approval` (
  `account_no` varchar(100) NOT NULL,
  `transaction_code` varchar(100) NOT NULL,
  `bank` varchar(100) NOT NULL,
  `balance` varchar(100) NOT NULL,
  `transfer_amount` varchar(100) NOT NULL,
  `actual_balance` varchar(100) NOT NULL,
  `date` varchar(100) NOT NULL,
  `contact` varchar(100) NOT NULL,
  `reason` varchar(100) NOT NULL,
  `comport` varchar(100) NOT NULL,
  `photo` varchar(100) NOT NULL,
  `datee` varchar(100) NOT NULL,
  `time` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `bank`
--

CREATE TABLE `bank` (
  `account_no` varchar(100) NOT NULL,
  `holders_name` varchar(100) NOT NULL,
  `bank` varchar(100) NOT NULL,
  `acc_type` varchar(100) NOT NULL,
  `next_of_kin` varchar(100) NOT NULL,
  `phone_no` varchar(100) NOT NULL,
  `gender` varchar(100) NOT NULL,
  `age` varchar(100) NOT NULL,
  `occupation` varchar(100) NOT NULL,
  `balance` varchar(100) NOT NULL,
  `acc_status` varchar(100) NOT NULL,
  `supervisor` varchar(100) NOT NULL,
  `date` varchar(100) NOT NULL,
  `photo` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `company`
--

CREATE TABLE `company` (
  `company` varchar(100) NOT NULL,
  `surname` varchar(100) NOT NULL,
  `middle_name` varchar(100) NOT NULL,
  `othername` varchar(100) NOT NULL,
  `id` varchar(100) NOT NULL,
  `gender` varchar(100) NOT NULL,
  `occupation` varchar(100) NOT NULL,
  `box_no` varchar(100) NOT NULL,
  `marital_status` varchar(100) NOT NULL,
  `age` varchar(100) NOT NULL,
  `nhcp_id` varchar(100) NOT NULL,
  `passport-id_no` varchar(100) NOT NULL,
  `city` varchar(100) NOT NULL,
  `district` varchar(100) NOT NULL,
  `town` varchar(100) NOT NULL,
  `contact` varchar(100) NOT NULL,
  `village` varchar(100) NOT NULL,
  `subcounty` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `municipality` varchar(100) NOT NULL,
  `code` varchar(100) NOT NULL,
  `spouse` varchar(100) NOT NULL,
  `spouse_email` varchar(100) NOT NULL,
  `date_of_birth` varchar(100) NOT NULL,
  `photo` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `hospital_id` varchar(100) NOT NULL,
  `tittle` varchar(100) NOT NULL,
  `surname` varchar(100) NOT NULL,
  `othername` varchar(100) NOT NULL,
  `job_type` varchar(100) NOT NULL,
  `address` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `contact` varchar(100) NOT NULL,
  `dob` varchar(100) NOT NULL,
  `salary` varchar(100) NOT NULL,
  `hire_date` varchar(100) NOT NULL,
  `job_status` varchar(100) NOT NULL,
  `blood_group` varchar(100) NOT NULL,
  `marital_status` varchar(100) NOT NULL,
  `department` varchar(100) NOT NULL,
  `photo` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `healthunit`
--

CREATE TABLE `healthunit` (
  `hospital_id` varchar(100) NOT NULL,
  `tittle` varchar(100) NOT NULL,
  `lname` varchar(100) NOT NULL,
  `fname` varchar(100) NOT NULL,
  `gender` varchar(100) NOT NULL,
  `job_type` varchar(100) NOT NULL,
  `address` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `contact` varchar(100) NOT NULL,
  `birth_date` varchar(100) NOT NULL,
  `hire_date` varchar(100) NOT NULL,
  `salary` varchar(100) NOT NULL,
  `blood_group` varchar(100) NOT NULL,
  `m_status` varchar(100) NOT NULL,
  `department` varchar(100) NOT NULL,
  `status` varchar(100) NOT NULL,
  `photo` blob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `healthunit`
--

INSERT INTO `healthunit` (`hospital_id`, `tittle`, `lname`, `fname`, `gender`, `job_type`, `address`, `email`, `contact`, `birth_date`, `hire_date`, `salary`, `blood_group`, `m_status`, `department`, `status`, `photo`) VALUES
('HSPTL002', 'Accountant', 'Emma', 'Watson', 'Male ', 'tyyy', 'trtrgtf', 'kiiryaelijah@yahoo.com', '0759675729', '5/10/2017', '5/10/2017', '', 'O', 'Single', 'ICT', 'STATUS', ''),
('HSPTL003', 'Nurse', 'Hawa', 'Lynn', 'Female', 'Nurse', 'kawaala', 'hawalynn@gmail.com', '0759675729', '5/10/2017', '5/10/2017', '', 'O', 'Married', 'Diagnosis', 'STATUS', 0x53797374656d2e44726177696e672e4269746d6170),
('sadc', 'zxcz', 'cxz', 'xczxc', 'xczx', 'zxcc', 'cxzx', 'zczx', 'xczxc', '5/8/2017', '5/8/2017', '', 'xzc', 'xc', 'zxcxz', 'STATUS', '');

-- --------------------------------------------------------

--
-- Table structure for table `individual`
--

CREATE TABLE `individual` (
  `nhcp_id` varchar(100) NOT NULL,
  `serial_no` varchar(100) NOT NULL,
  `time` varchar(100) NOT NULL,
  `surname` varchar(100) NOT NULL,
  `first_name` varchar(100) NOT NULL,
  `last_name` varchar(100) NOT NULL,
  `marital_status` varchar(100) NOT NULL,
  `occupation` varchar(100) NOT NULL,
  `code` varchar(100) NOT NULL,
  `spouse` varchar(100) NOT NULL,
  `spouse_contact` varchar(100) NOT NULL,
  `gender` varchar(100) NOT NULL,
  `age` varchar(100) NOT NULL,
  `address` varchar(100) NOT NULL,
  `contact` varchar(100) NOT NULL,
  `district` varchar(100) NOT NULL,
  `city` varchar(100) NOT NULL,
  `town` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `national_id` varchar(100) NOT NULL,
  `village` varchar(100) NOT NULL,
  `subcounty` varchar(100) NOT NULL,
  `municipality` varchar(100) NOT NULL,
  `date_of_birth` varchar(100) NOT NULL,
  `photo` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `sessions`
--

CREATE TABLE `sessions` (
  `session_id` varchar(100) NOT NULL,
  `user_id` varchar(100) NOT NULL,
  `login_time` varchar(100) NOT NULL,
  `logout_time` varchar(100) NOT NULL,
  `username` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `username` varchar(10) NOT NULL,
  `password` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`username`, `password`) VALUES
('admin', 'admin'),
('ellie', '19931208ke'),
('emma', '123456'),
('Username', 'password');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `approval`
--
ALTER TABLE `approval`
  ADD PRIMARY KEY (`transaction_code`);

--
-- Indexes for table `bank`
--
ALTER TABLE `bank`
  ADD PRIMARY KEY (`account_no`);

--
-- Indexes for table `company`
--
ALTER TABLE `company`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`hospital_id`);

--
-- Indexes for table `healthunit`
--
ALTER TABLE `healthunit`
  ADD PRIMARY KEY (`hospital_id`);

--
-- Indexes for table `individual`
--
ALTER TABLE `individual`
  ADD PRIMARY KEY (`nhcp_id`);

--
-- Indexes for table `sessions`
--
ALTER TABLE `sessions`
  ADD PRIMARY KEY (`session_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`username`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
