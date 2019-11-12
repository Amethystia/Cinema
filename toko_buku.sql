-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 12, 2019 at 02:29 PM
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
-- Database: `toko_buku`
--

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `Kode_Cus` int(20) NOT NULL,
  `Nama_Cus` varchar(40) NOT NULL,
  `Alamat` varchar(100) NOT NULL,
  `No_Telp` int(20) NOT NULL,
  `Keterangan` varchar(300) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`Kode_Cus`, `Nama_Cus`, `Alamat`, `No_Telp`, `Keterangan`) VALUES
(2, '2', '2', 1111, '2'),
(12, 'rt222ww', '22', 1, '2');

-- --------------------------------------------------------

--
-- Table structure for table `detttransjual`
--

CREATE TABLE `detttransjual` (
  `faktur` varchar(100) NOT NULL,
  `kdbarang` varchar(100) NOT NULL,
  `harga` int(100) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `subtotal` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `KodeProduct` int(11) NOT NULL,
  `NamaProduct` varchar(60) NOT NULL,
  `JenisProduct` varchar(40) NOT NULL,
  `PriceHarga` int(11) NOT NULL,
  `Keterangan` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`KodeProduct`, `NamaProduct`, `JenisProduct`, `PriceHarga`, `Keterangan`) VALUES
(1, 's', 's', 1, '1'),
(2, '2', '2', 2, '2'),
(23, '33', '33', 0, '33');

-- --------------------------------------------------------

--
-- Table structure for table `transjual`
--

CREATE TABLE `transjual` (
  `faktur` varchar(100) NOT NULL,
  `TanggalJual` date NOT NULL,
  `Total` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`Kode_Cus`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`KodeProduct`);

--
-- Indexes for table `transjual`
--
ALTER TABLE `transjual`
  ADD PRIMARY KEY (`faktur`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `KodeProduct` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
