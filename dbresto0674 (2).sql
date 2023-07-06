-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 15 Mar 2023 pada 15.05
-- Versi server: 10.4.27-MariaDB
-- Versi PHP: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbresto0674`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `detail_jual`
--

CREATE TABLE `detail_jual` (
  `id_jual` char(5) NOT NULL,
  `id_menu` char(5) NOT NULL,
  `harga_jual` decimal(18,0) NOT NULL,
  `qty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `detail_jual`
--

INSERT INTO `detail_jual` (`id_jual`, `id_menu`, `harga_jual`, `qty`) VALUES
('PJ001', 'M0001', '46000', 1),
('PJ001', 'M0012', '4000', 1),
('PJ002', 'M0002', '46000', 1),
('PJ002', 'M0003', '12000', 1),
('PJ002', 'M0011', '3000', 1),
('PJ003', 'M0004', '33000', 3),
('PJ004', 'M0007', '46000', 2),
('PJ004', 'M0004', '33000', 2),
('PJ004', 'M0013', '3000', 2),
('PJ005', 'M0003', '12000', 1),
('PJ005', 'M0005', '35000', 1),
('PJ005', 'M0012', '4000', 2);

-- --------------------------------------------------------

--
-- Struktur dari tabel `kasir`
--

CREATE TABLE `kasir` (
  `id_kasir` char(5) NOT NULL,
  `nama_kasir` varchar(50) NOT NULL,
  `userid` varchar(10) NOT NULL,
  `pass` varchar(10) NOT NULL,
  `level_kasir` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `kasir`
--

INSERT INTO `kasir` (`id_kasir`, `nama_kasir`, `userid`, `pass`, `level_kasir`) VALUES
('K0001', 'DWI APRILIA', 'APRIL', '12345', 'AK'),
('K0002', 'SRI ASTUTI', 'TUTI', 'tut123', 'AK'),
('K0003', 'MAEMUNAH', 'MAEMUN', '0109', 'AK'),
('K0004', 'PRATIWI', 'TIWI', 't1w1', 'AK'),
('K0005', 'TIKA ANDINI', 'TIKA', '001TA', 'SK');

-- --------------------------------------------------------

--
-- Struktur dari tabel `kategori`
--

CREATE TABLE `kategori` (
  `id_kategori` char(5) NOT NULL,
  `nama_kategori` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `kategori`
--

INSERT INTO `kategori` (`id_kategori`, `nama_kategori`) VALUES
('KT001', 'MAKANAN'),
('KT002', 'MINUMAN');

-- --------------------------------------------------------

--
-- Struktur dari tabel `menu`
--

CREATE TABLE `menu` (
  `id_menu` char(5) NOT NULL,
  `id_kategori` char(5) NOT NULL,
  `nama_menu` varchar(50) NOT NULL,
  `harga_menu` decimal(18,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `menu`
--

INSERT INTO `menu` (`id_menu`, `id_kategori`, `nama_menu`, `harga_menu`) VALUES
('M0001', 'KT001', 'KEPITING SAOS PADANG', '46000'),
('M0002', 'KT001', 'KEPITING SAOS TIRAM', '46000'),
('M0003', 'KT001', 'KERANG HIJAU REBUS', '12000'),
('M0004', 'KT001', 'CUMI CAH BROKOLI', '33000'),
('M0005', 'KT001', 'CUMI GORENG TEPUNG', '35000'),
('M0006', 'KT001', 'CUMI GORENG SAOS TIRAM', '38000'),
('M0007', 'KT001', 'CUMI CAH KEMBANG KOL', '33000'),
('M0008', 'KT001', 'IKAN GURAME ASAM MANIS', '46000'),
('M0009', 'KT001', 'IKAN GURAME GORENG KERING', '10000'),
('M0010', 'KT001', 'SOP IKAN ASAM PEDAS', '35000'),
('M0011', 'KT002', 'ES TEH/TEH HANGAT', '3000'),
('M0012', 'KT002', 'ES JERUK/JERUK HANGAT', '4000'),
('M0013', 'KT002', 'AIR MINERAL BOTOL', '5000'),
('M0014', 'KT001', 'KEPITING ASAM MANIS', '46000'),
('M0015', 'KT001', 'KEPITING SAOS LADA HITAM', '46000'),
('M0016', 'KT001', 'KERANG HIJAU SAOS PADANG', '17000'),
('M0017', 'KT001', 'KERANG HIJAU SAOS TIRAM', '17000'),
('M0018', 'KT001', 'CUMI MASAKAN PADANG', '38000'),
('M0019', 'KT001', 'CUMI CAH KANGKUNG', '24000'),
('M0020', 'KT001', 'CUMI CAH JAMUR', '33000'),
('M0021', 'KT001', 'IKAN GURAME SAOS PADANG', '11000'),
('M0022', 'KT001', 'IKAN GURAME TIM', '11000'),
('M0023', 'KT002', 'JUS MANGGA', '8000'),
('M0024', 'KT002', 'JUS JERUK', '5000'),
('M0025', 'KT002', 'JUS WORTEL', '4000'),
('M0026', 'KT002', 'ES CAMPUR', '7000');

-- --------------------------------------------------------

--
-- Struktur dari tabel `penjualan`
--

CREATE TABLE `penjualan` (
  `id_jual` char(5) NOT NULL,
  `total` decimal(18,0) NOT NULL,
  `tgl_jual` date NOT NULL,
  `id_kasir` char(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `penjualan`
--

INSERT INTO `penjualan` (`id_jual`, `total`, `tgl_jual`, `id_kasir`) VALUES
('PJ001', '50000', '2020-01-03', 'K0001'),
('PJ002', '61000', '2020-01-03', 'K0001'),
('PJ003', '99000', '2020-01-04', 'K0002'),
('PJ004', '164000', '2020-01-04', 'K0002'),
('PJ005', '55000', '2020-01-05', 'K0002');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `detail_jual`
--
ALTER TABLE `detail_jual`
  ADD KEY `id_jual` (`id_jual`),
  ADD KEY `id_menu` (`id_menu`);

--
-- Indeks untuk tabel `kasir`
--
ALTER TABLE `kasir`
  ADD PRIMARY KEY (`id_kasir`);

--
-- Indeks untuk tabel `kategori`
--
ALTER TABLE `kategori`
  ADD PRIMARY KEY (`id_kategori`);

--
-- Indeks untuk tabel `menu`
--
ALTER TABLE `menu`
  ADD PRIMARY KEY (`id_menu`),
  ADD KEY `id_kategori` (`id_kategori`);

--
-- Indeks untuk tabel `penjualan`
--
ALTER TABLE `penjualan`
  ADD PRIMARY KEY (`id_jual`),
  ADD KEY `id_kasir` (`id_kasir`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `detail_jual`
--
ALTER TABLE `detail_jual`
  ADD CONSTRAINT `detail_jual_ibfk_1` FOREIGN KEY (`id_jual`) REFERENCES `penjualan` (`id_jual`),
  ADD CONSTRAINT `detail_jual_ibfk_2` FOREIGN KEY (`id_menu`) REFERENCES `menu` (`id_menu`);

--
-- Ketidakleluasaan untuk tabel `menu`
--
ALTER TABLE `menu`
  ADD CONSTRAINT `menu_ibfk_1` FOREIGN KEY (`id_kategori`) REFERENCES `kategori` (`id_kategori`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `penjualan`
--
ALTER TABLE `penjualan`
  ADD CONSTRAINT `penjualan_ibfk_1` FOREIGN KEY (`id_kasir`) REFERENCES `kasir` (`id_kasir`) ON DELETE NO ACTION ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
