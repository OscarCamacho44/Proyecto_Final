-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 13-05-2024 a las 03:25:46
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `ferreteria`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `id_cliente` int(5) NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `ape_paterno` varchar(20) NOT NULL,
  `ape_materno` varchar(20) NOT NULL,
  `contrasena` varchar(8) NOT NULL,
  `celular` bigint(10) NOT NULL,
  `direccion` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`id_cliente`, `nombre`, `ape_paterno`, `ape_materno`, `contrasena`, `celular`, `direccion`) VALUES
(1, 'Oscar', 'Camacho', 'Melgar', 'oscar444', 9614684951, 'Calle tabasco mz 134 lot 20 col las granjas'),
(2, 'Karen', 'Peréz', 'Ovando', 'Karen123', 9614522387, 'Calle platanitos mz 182 lot 32'),
(3, 'Daniel', 'Camacho', 'Melgar', 'Camacho4', 9614658891, 'Calle de los patos mz 123 lot 21'),
(4, 'Sergio', 'Peréz', 'Toledo', 'Ivan4554', 9614587557, 'Calle san antonio de vida real mz 181 lot 39');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE `producto` (
  `codigo` int(5) NOT NULL,
  `cedula` int(9) NOT NULL,
  `Nombre` varchar(30) NOT NULL,
  `marca` varchar(30) NOT NULL,
  `descripcion` varchar(100) NOT NULL,
  `precio` float NOT NULL,
  `stock` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`codigo`, `cedula`, `Nombre`, `marca`, `descripcion`, `precio`, `stock`) VALUES
(1, 1, 'Martillokkkkk', 'Pandas', 'Martillo de cabeza de metal y mang de goma color azul, amarillo y rojo', 26, 0),
(4, 11, 'aaaa', 'aaaa', 'asssssssssa', 12.3, 100),
(5, 2, 'assd', 'sda', 'aaaaaa', 21, 5),
(6, 7, 'aasas', 'assa', 'aaaaaaaaadas', 54, 40);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE `proveedor` (
  `cedula` int(9) NOT NULL,
  `Nombre` varchar(20) NOT NULL,
  `APE_paterno` varchar(20) NOT NULL,
  `APE_materno` varchar(20) NOT NULL,
  `direccion` varchar(50) NOT NULL,
  `celular` bigint(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `proveedor`
--

INSERT INTO `proveedor` (`cedula`, `Nombre`, `APE_paterno`, `APE_materno`, `direccion`, `celular`) VALUES
(1, 'Victor', 'Mendéz', 'Ramírezz', 'Calle san jose mz 220 lot 31 col terán', 9614566587),
(2, 'Julioaaa', 'Chacon', 'Hernández', 'Calle los pastores entre 4ta y 5ta norte mz 210 lo', 9615542655),
(3, 'Victoria', 'Mendéz', 'Ramírez', 'Calle san jose mz 220 lot 31 col terán', 9614566587),
(4, 'Victor', 'Mendéz', 'Ramíres', 'Calle san jose mz 220 lot 31 col terán', 9614566594),
(5, 'aaaa', 'aaa', 'aaa', 'aaa', 1234567981),
(6, 'aaaa', 'aaa', 'aaa', 'aaa', 1234567981),
(7, 'aaaa', 'aaa', 'aaa', 'aaa', 1234567981),
(8, 'aaaa', 'aaa', 'aaa', 'aaa', 1234567981),
(9, 'aaaa', 'aaa', 'aaa', 'aaa', 1234567981),
(10, 'aaaam', 'aaa', 'aaa', 'aaa', 1234567981),
(11, 'aaaa', 'aaa', 'aaa', 'aaa', 1234567981),
(12, 'aaaa', 'aaa', 'aaa', 'aaa', 1234567981),
(13, 'aaaa', 'aaa', 'aaa', 'aaa', 1234567981),
(14, 'aaaa', 'aaa', 'aaa', 'aaa', 1234567981),
(15, 'Roberto', 'Abisai', 'Zepeda', 'Calle trujillo mz 123 lot 32', 1234567981),
(16, 'aaaasass', 'aaa', 'aaa', 'aaa', 1234567981),
(17, 'aaaa', 'aaa', 'aaa', 'aaa', 1234567981),
(18, 'Rogelio', 'Gonzales', 'Aguila', 'Calle don marquitos entre albania alta y albania b', 9612456798),
(21, 'Daniel', 'Escobar', 'Nafate', '12 y 13 oriente', 9613662919),
(22, 'Erick', 'Lopez', 'Dionicio', '10a.calle ote.sur', 9612571865),
(23, 'Luis', 'cortes', 'Hilerio', '9 sur.Col la salle', 9612456747),
(24, 'Axelaa', 'Zepeda', 'Gomez', 'Av.tercera sur pte.', 9612546907),
(25, 'Jacinta', 'Martinez', 'Chacon', 'Calle san marcos mz 123 lot 12', 9614523544);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta`
--

CREATE TABLE `venta` (
  `id_venta` int(5) NOT NULL,
  `id_cliente` int(5) NOT NULL,
  `id_producto` int(5) NOT NULL,
  `nombre_p` varchar(20) NOT NULL,
  `cantidad` int(5) NOT NULL,
  `fecha` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `venta`
--

INSERT INTO `venta` (`id_venta`, `id_cliente`, `id_producto`, `nombre_p`, `cantidad`, `fecha`) VALUES
(1, 1, 1, 'coca', 4, '2024-05-11'),
(2, 2, 1, 'Martillo', 25, '2024-02-08'),
(3, 1, 4, 'aaaa', 2, '2024-05-12'),
(4, 1, 4, 'aaaa', 5, '2024-05-12'),
(5, 1, 4, 'aaaa', 9, '2024-05-12'),
(6, 3, 4, 'aaaa', 18, '2024-05-12'),
(7, 4, 6, 'aasas', 5, '2024-05-12');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id_cliente`);

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `cedula` (`cedula`);

--
-- Indices de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD PRIMARY KEY (`cedula`);

--
-- Indices de la tabla `venta`
--
ALTER TABLE `venta`
  ADD PRIMARY KEY (`id_venta`),
  ADD KEY `id_cliente` (`id_cliente`),
  ADD KEY `id_producto` (`id_producto`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id_cliente` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `producto`
--
ALTER TABLE `producto`
  MODIFY `codigo` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  MODIFY `cedula` int(9) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT de la tabla `venta`
--
ALTER TABLE `venta`
  MODIFY `id_venta` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `producto`
--
ALTER TABLE `producto`
  ADD CONSTRAINT `producto_ibfk_1` FOREIGN KEY (`cedula`) REFERENCES `proveedor` (`cedula`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `venta`
--
ALTER TABLE `venta`
  ADD CONSTRAINT `venta_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`),
  ADD CONSTRAINT `venta_ibfk_2` FOREIGN KEY (`id_producto`) REFERENCES `producto` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
