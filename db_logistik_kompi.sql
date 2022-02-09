-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Waktu pembuatan: 20 Agu 2021 pada 03.52
-- Versi server: 5.7.24
-- Versi PHP: 7.2.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
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
-- Struktur dari tabel `tb_anggota`
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
-- Dumping data untuk tabel `tb_anggota`
--

INSERT INTO `tb_anggota` (`tb_anggota_id`, `tb_anggota_nrp`, `tb_anggota_nama`, `tb_anggota_pangkat`, `tb_anggota_jabatan`, `tb_anggota_kesatuan`) VALUES
('AG0002', '70050335', 'MARYADI', 'IPDA', 'WADANKI', 'KOMPI 1C'),
('AG0003', '77040229', 'DIDIK KURNIANTO, SH', 'IPDA', 'DANTON', 'KOMPI 1C'),
('AG0004', '80020155', 'TUPONO', 'AIPTU', 'DANTON', 'KOMPI 1C'),
('AG0005', '77050144', 'AGUS KA', 'AIPTU', 'PA OPS', 'KOMPI 1C'),
('AG0006', '79110053', 'HARIANTO', 'AIPTU', 'PAMIN', 'KOMPI 1C'),
('AG0007', '83050833', 'BAMBANG ASRORI, SH', 'AIPDA', 'DANTON', 'KOMPI 1C'),
('AG0008', '69110256', 'ZAENUL MUSTOFA', 'AIPDA', 'ANGGOTA', 'KOMPI 1C'),
('AG0009', '74090443', 'LASIMIN, SH', 'AIPDA', 'ANGGOTA', 'KOMPI 1C'),
('AG0010', '74090331', 'APRIH  BUDI S', 'BRIPKA', 'ANGGOTA', 'KOMPI 1C'),
('AG0011', '75050271', 'I KOMANG MURDANA', 'BRIPKA', 'ANGGOTA', 'KOMPI 1C'),
('AG0012', '80031081', 'AGUNG SUPRIYADI, SH', 'BRIPKA', 'ANGGOTA', 'KOMPI 1C'),
('AG0013', '85121539', 'BUDI RAHARJO, SE', 'BRIPKA', 'ANGGOTA', 'KOMPI 1C'),
('AG0014', '85050883', 'EKO SRI RUDIANTO, SH', 'BRIPKA', 'ANGGOTA', 'KOMPI 1C'),
('AG0015', '88070532', 'YULIANTO NUGROHO', 'BRIGADIR', 'ANGGOTA', 'KOMPI 1C');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_logistik`
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
-- Dumping data untuk tabel `tb_logistik`
--

INSERT INTO `tb_logistik` (`tb_logistik_id`, `tb_logistik_nomor`, `tb_logistik_jenis`, `tb_logistik_status`, `tb_logistik_kode`, `tb_logistik_nama`, `tb_logistik_jumlah`) VALUES
('LG0001', '8D 06390', 'SENPI GENGAM', 'Siap Pakai', '1', 'S&W', '2'),
('LG0002', 'XK 249188', 'SENPI GENGAM', 'Siap Pakai', '2', 'TAURUS', '1'),
('LG0003', '01628-95', 'SENPI GENGAM', 'Siap Pakai', '3', 'MARTIAL', '4'),
('LG0004', '40250', 'SENPI GENGAM', 'Siap Pakai', '4', 'SCORPION', '9'),
('LG0005', 'CF 2771', 'SENPI PHH', 'Siap Pakai', '5', 'LARAS LICIN', '4'),
('LG0006', 'JKT 13-0776', 'SENPI PHH', 'Siap Pakai', '6', 'LARAS LICIN TYPE SHOEBILL', '2'),
('LG0007', '353250', 'SENPI PHH', 'Siap Pakai', '7', 'PAPPERBALL', '9'),
('LG0008', '20FB11553', 'SENPI PHH', 'Siap Pakai', '8', 'FLASHBALL', '2'),
('LG0009', '11-0138', 'SENPI PHH', 'Siap Pakai', '9', 'GAS GUN DH-001', '15'),
('LG0010', '99 063487', 'SENPI BAHU', 'Siap Pakai', '10', 'SS1', '24'),
('LG0011', '94 38212', 'SENPI BAHU', 'Siap Pakai', '11', 'M16', '8'),
('LG0012', 'NB 126', 'SENPI BAHU', 'Siap Pakai', '12', 'RPD', '3'),
('LG0013', '103865', 'SENPI BAHU', 'Siap Pakai', '13', 'AK2000P', '18'),
('LG0014', 'ARH01', 'ALSUS PHH', 'Siap Pakai', '14', 'ANTI RIOT HELM', '15'),
('LG0015', 'RHB01', 'ALSUS PHH', 'Siap Pakai', '15', 'ROMPI HITAM BARU', '60');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_logistik_detail`
--

CREATE TABLE `tb_logistik_detail` (
  `tb_logistik_id` varchar(128) NOT NULL,
  `tb_logistik_detail_nosenpi` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_logistik_detail`
--

INSERT INTO `tb_logistik_detail` (`tb_logistik_id`, `tb_logistik_detail_nosenpi`) VALUES
('LG0001', '8D 27453'),
('LG0001', '8D 26566'),
('LG0002', 'XK 249210'),
('LG0002', 'YJ 342227'),
('LG0002', 'XK 249209'),
('LG0003', '01622-95'),
('LG0003', '01634-95'),
('LG0003', '01645-95'),
('LG0003', '01523-95'),
('LG0004', '44747'),
('LG0004', '40037'),
('LG0004', '42046'),
('LG0004', '44811'),
('LG0003', '01644-95'),
('LG0004', '43808'),
('LG0004', '40242'),
('LG0004', '40109'),
('LG0005', 'CF 2645'),
('LG0005', 'CK 2989'),
('LG0005', 'CF 2666'),
('LG0006', 'JKT 13-0771'),
('LG0007', '353236'),
('LG0007', '353233'),
('LG0007', '353138'),
('LG0007', '353125'),
('LG0008', '20FB11554'),
('LG0009', '11-0137'),
('LG0009', 'JKT 113-0162'),
('LG0009', 'JKT 114-0087'),
('LG0009', 'PHH 15-0909'),
('LG0009', 'PHH 15-0910'),
('LG0010', '99 063598'),
('LG0010', '96 040274'),
('LG0010', '99 064588'),
('LG0010', '99 064588'),
('LG0010', '99 063476'),
('LG0010', '99 064164'),
('LG0011', '94 39889'),
('LG0011', '94 39156'),
('LG0011', '94 40289'),
('LG0012', 'AB 192'),
('LG0012', 'MK 494'),
('LG0013', '103179'),
('LG0013', '101428'),
('LG0013', '104432'),
('LG0013', '101907'),
('LG0013', '102189'),
('LG0014', 'ARH02'),
('LG0014', 'ARH03'),
('LG0014', 'ARH04'),
('LG0014', 'ARH05');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_pinjaman`
--

CREATE TABLE `tb_pinjaman` (
  `tb_pinjaman_id` varchar(11) NOT NULL,
  `tb_anggota_id` varchar(11) NOT NULL,
  `tb_logistik_id` varchar(25) NOT NULL,
  `tb_pinjaman_tanggal_pinjam` date NOT NULL,
  `tb_pinjaman_tanggal_kembali` date NOT NULL,
  `tb_pinjam_status` varchar(128) NOT NULL,
  `tb_pinjaman_nosenpi` varchar(182) NOT NULL,
  `tb_logistik_persetujuan` varchar(182) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_pinjaman`
--

INSERT INTO `tb_pinjaman` (`tb_pinjaman_id`, `tb_anggota_id`, `tb_logistik_id`, `tb_pinjaman_tanggal_pinjam`, `tb_pinjaman_tanggal_kembali`, `tb_pinjam_status`, `tb_pinjaman_nosenpi`, `tb_logistik_persetujuan`) VALUES
('PI0003', 'AG0003', 'LG0002', '2021-08-10', '2021-08-11', 'Di Pinjam', 'YJ 342227', 'DI SETUJUI'),
('PI0004', 'AG0008', 'LG0004', '2021-08-18', '2021-08-21', 'Di Pinjam', '44747', 'DI SETUJUI');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tb_anggota`
--
ALTER TABLE `tb_anggota`
  ADD PRIMARY KEY (`tb_anggota_id`);

--
-- Indeks untuk tabel `tb_logistik`
--
ALTER TABLE `tb_logistik`
  ADD PRIMARY KEY (`tb_logistik_id`);

--
-- Indeks untuk tabel `tb_pinjaman`
--
ALTER TABLE `tb_pinjaman`
  ADD PRIMARY KEY (`tb_pinjaman_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
