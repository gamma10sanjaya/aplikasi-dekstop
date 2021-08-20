-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Aug 10, 2021 at 08:17 AM
-- Server version: 5.7.24
-- PHP Version: 7.2.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_logistik_kompi`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_admin`
--

CREATE TABLE `tb_admin` (
  `id_admin` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_admin`
--

INSERT INTO `tb_admin` (`id_admin`, `username`, `password`) VALUES
(1, 'admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `tb_anggota`
--

CREATE TABLE `tb_anggota` (
  `tb_anggota_id` varchar(11) NOT NULL,
  `tb_anggota_nrp` varchar(128) NOT NULL,
  `tb_anggota_nama` varchar(128) NOT NULL,
  `tb_anggota_pangkat` varchar(128) NOT NULL,
  `tb_anggota_jabatan` varchar(128) NOT NULL,
  `tb_anggota_kesatuan` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_anggota`
--

INSERT INTO `tb_anggota` (`tb_anggota_id`, `tb_anggota_nrp`, `tb_anggota_nama`, `tb_anggota_pangkat`, `tb_anggota_jabatan`, `tb_anggota_kesatuan`) VALUES
('AG0001', '76040441', 'EDY SULISTIYONO, S.H.', 'IPTU', 'DANKI', 'B'),
('AG0002', '229392', 'ajsndkjasn', 'BRIPKA', 'dua', 'siap'),
('AG0003', '12122124', 'scdscdscds', 'AKP', 'dua', 'ok');

-- --------------------------------------------------------

--
-- Table structure for table `tb_logistik`
--

CREATE TABLE `tb_logistik` (
  `tb_logistik_id` varchar(11) NOT NULL,
  `tb_logistik_nomor` varchar(182) NOT NULL,
  `tb_logistik_jenis` varchar(128) NOT NULL,
  `tb_logistik_status` varchar(128) NOT NULL,
  `tb_logistik_kode` varchar(128) NOT NULL,
  `tb_logistik_nama` varchar(128) NOT NULL,
  `tb_logistik_jumlah` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_logistik`
--

INSERT INTO `tb_logistik` (`tb_logistik_id`, `tb_logistik_nomor`, `tb_logistik_jenis`, `tb_logistik_status`, `tb_logistik_kode`, `tb_logistik_nama`, `tb_logistik_jumlah`) VALUES
('LG0002', 'AWD0001', 'Senjata Api /Senpi', 'Siap Pakai', '2', 'HS- 9 Kroasia', '13'),
('LG0003', 'AWD002', 'SENPI', 'Layak Pakai', '2', 'Senpi Genggem', '21'),
('LG0004', 'DWW0002', 'SENPI', 'Siap Pakai', '4', 'senpi ak 45', '30'),
('LG0005', 'AW7777', 'SENPI', 'Layak Pakai', '2', 'Pistol', '3');

-- --------------------------------------------------------

--
-- Table structure for table `tb_logistik_detail`
--

CREATE TABLE `tb_logistik_detail` (
  `tb_logistik_id` varchar(128) NOT NULL,
  `tb_logistik_detail_nosenpi` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_logistik_detail`
--

INSERT INTO `tb_logistik_detail` (`tb_logistik_id`, `tb_logistik_detail_nosenpi`) VALUES
('LG0002', '8D.262566'),
('LG0002', '8D.06390');

-- --------------------------------------------------------

--
-- Table structure for table `tb_pinjaman`
--

CREATE TABLE `tb_pinjaman` (
  `tb_pinjaman_id` varchar(11) NOT NULL,
  `tb_anggota_id` varchar(11) NOT NULL,
  `tb_logistik_id` varchar(25) NOT NULL,
  `tb_pinjaman_tanggal_pinjam` date NOT NULL,
  `tb_pinjaman_tanggal_kembali` date NOT NULL,
  `tb_pinjam_status` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_pinjaman`
--

INSERT INTO `tb_pinjaman` (`tb_pinjaman_id`, `tb_anggota_id`, `tb_logistik_id`, `tb_pinjaman_tanggal_pinjam`, `tb_pinjaman_tanggal_kembali`, `tb_pinjam_status`) VALUES
('PI0001', 'AG0002', 'LG0001', '2021-07-12', '2021-08-10', 'Telah Dikembalikan'),
('PI0002', 'AG0001', 'LG0005', '2021-07-22', '2021-08-10', 'Telah Dikembalikan'),
('PI0003', 'AG0001', 'LG0001', '2021-07-22', '2021-08-24', 'Telah Dipinjam'),
('PI0004', 'AG0002', 'LG0002', '2021-07-23', '2021-08-10', 'Telah Dikembalikan'),
('PI0005', 'AG0001', 'LG0004', '2021-08-10', '2021-08-17', 'Di Pinjam');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_admin`
--
ALTER TABLE `tb_admin`
  ADD PRIMARY KEY (`id_admin`);

--
-- Indexes for table `tb_anggota`
--
ALTER TABLE `tb_anggota`
  ADD PRIMARY KEY (`tb_anggota_id`);

--
-- Indexes for table `tb_logistik`
--
ALTER TABLE `tb_logistik`
  ADD PRIMARY KEY (`tb_logistik_id`);

--
-- Indexes for table `tb_pinjaman`
--
ALTER TABLE `tb_pinjaman`
  ADD PRIMARY KEY (`tb_pinjaman_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_admin`
--
ALTER TABLE `tb_admin`
  MODIFY `id_admin` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
