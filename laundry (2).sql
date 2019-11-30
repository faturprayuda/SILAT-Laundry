-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 11, 2019 at 08:35 AM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 7.3.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `laundry`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `id_pegawai` int(12) NOT NULL,
  `user_pegawai` varchar(50) NOT NULL,
  `password_pegawai` varchar(50) NOT NULL DEFAULT '1234',
  `nama_pegawai` varchar(50) NOT NULL,
  `alamat_pegawai` text NOT NULL,
  `no_hp_pegawai` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`id_pegawai`, `user_pegawai`, `password_pegawai`, `nama_pegawai`, `alamat_pegawai`, `no_hp_pegawai`) VALUES
(1, 'Admin', '1234', 'Abdul', 'Jl. Kesana Kemari', '123456789');

-- --------------------------------------------------------

--
-- Table structure for table `barang`
--

CREATE TABLE `barang` (
  `id_barang` int(12) NOT NULL,
  `nama_barang` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `barang`
--

INSERT INTO `barang` (`id_barang`, `nama_barang`) VALUES
(7, 'Almamater'),
(3, 'Batik'),
(8, 'Dress'),
(9, 'Handuk'),
(2, 'Kaos'),
(10, 'Kebaya'),
(4, 'Kemeja'),
(1, 'Kemeja Panjang'),
(99, 'Kiloan'),
(5, 'Piyama');

-- --------------------------------------------------------

--
-- Table structure for table `layanan`
--

CREATE TABLE `layanan` (
  `id_layanan` varchar(5) NOT NULL,
  `nama_layanan` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `layanan`
--

INSERT INTO `layanan` (`id_layanan`, `nama_layanan`) VALUES
('L002', 'Kiloan'),
('L001', 'Satuan');

-- --------------------------------------------------------

--
-- Table structure for table `tranksaksi`
--

CREATE TABLE `tranksaksi` (
  `id_tranksaksi` int(11) NOT NULL,
  `tgl_masuk` date NOT NULL,
  `tgl_keluar` date NOT NULL,
  `nama_layanan` varchar(15) NOT NULL,
  `nama_barang` varchar(50) NOT NULL,
  `banyak_barang` int(99) NOT NULL,
  `harga` int(10) NOT NULL,
  `total_harga` int(10) NOT NULL,
  `id_user` int(12) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tranksaksi`
--

INSERT INTO `tranksaksi` (`id_tranksaksi`, `tgl_masuk`, `tgl_keluar`, `nama_layanan`, `nama_barang`, `banyak_barang`, `harga`, `total_harga`, `id_user`) VALUES
(1, '2019-06-01', '2019-06-08', 'Satuan', 'Batik', 1, 15000, 15000, 1),
(34, '2019-06-01', '2019-06-01', 'Kiloan', 'Kiloan', 2, 10000, 20000, 6),
(35, '2019-06-01', '2019-06-22', 'Satuan', 'Batik', 1, 10000, 10000, 6),
(36, '2019-06-01', '2019-06-08', 'Satuan', 'Kebaya', 1, 15000, 15000, 1);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id_user` int(12) NOT NULL,
  `nama_user` varchar(50) NOT NULL,
  `alamat_user` text NOT NULL,
  `no_user` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id_user`, `nama_user`, `alamat_user`, `no_user`) VALUES
(1, 'abdul', 'Jl. wow', '1234'),
(6, 'Fatur', 'Jl. jakpus', '588'),
(8, 'ijat', 'Jl. wow', '1234');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id_pegawai`);

--
-- Indexes for table `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`nama_barang`);

--
-- Indexes for table `layanan`
--
ALTER TABLE `layanan`
  ADD PRIMARY KEY (`nama_layanan`);

--
-- Indexes for table `tranksaksi`
--
ALTER TABLE `tranksaksi`
  ADD PRIMARY KEY (`id_tranksaksi`),
  ADD KEY `FK_Layanan` (`nama_layanan`),
  ADD KEY `FK_barang` (`nama_barang`),
  ADD KEY `FK_user` (`id_user`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `id_pegawai` int(12) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tranksaksi`
--
ALTER TABLE `tranksaksi`
  MODIFY `id_tranksaksi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id_user` int(12) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tranksaksi`
--
ALTER TABLE `tranksaksi`
  ADD CONSTRAINT `FK_Layanan` FOREIGN KEY (`nama_layanan`) REFERENCES `layanan` (`nama_layanan`),
  ADD CONSTRAINT `FK_barang` FOREIGN KEY (`nama_barang`) REFERENCES `barang` (`nama_barang`),
  ADD CONSTRAINT `FK_user` FOREIGN KEY (`id_user`) REFERENCES `user` (`id_user`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
