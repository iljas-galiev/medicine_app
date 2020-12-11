-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Дек 12 2020 г., 01:01
-- Версия сервера: 8.0.19
-- Версия PHP: 7.4.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `medicine`
--

-- --------------------------------------------------------

--
-- Структура таблицы `message`
--

CREATE TABLE `message` (
  `id` int NOT NULL,
  `datetime` datetime NOT NULL,
  `user_id` int NOT NULL,
  `user_to` int NOT NULL,
  `offer_id` int NOT NULL,
  `text` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `message`
--

INSERT INTO `message` (`id`, `datetime`, `user_id`, `user_to`, `offer_id`, `text`) VALUES
(1, '2020-11-14 12:53:18', 3, 2, 6, '123'),
(2, '2020-11-14 12:54:31', 3, 2, 6, '1234'),
(3, '2020-11-14 12:54:43', 3, 2, 6, '123'),
(4, '2020-11-14 13:00:23', 3, 2, 6, '123'),
(5, '2020-11-14 13:00:25', 3, 2, 6, '1234'),
(6, '2020-11-14 13:00:29', 3, 2, 5, '1235'),
(7, '2020-11-14 13:00:40', 2, 3, 5, '123'),
(8, '2020-11-14 13:00:42', 3, 2, 6, '123'),
(9, '2020-11-14 13:01:01', 3, 2, 6, '123'),
(10, '2020-11-14 13:01:05', 3, 2, 6, 'hello'),
(11, '2020-11-14 13:03:50', 3, 2, 6, 'hi'),
(12, '2020-11-14 13:07:15', 3, 2, 6, '123 he'),
(13, '2020-11-14 13:07:27', 3, 2, 6, '123'),
(14, '2020-11-14 13:07:31', 3, 2, 6, '123'),
(15, '2020-11-14 13:07:33', 3, 2, 6, '1234'),
(16, '2020-11-14 13:07:35', 3, 2, 6, '12345'),
(17, '2020-12-12 00:06:38', 2, 3, 6, 'hello'),
(18, '2020-12-12 00:07:11', 2, 3, 6, 'hello1'),
(19, '2020-12-12 00:07:33', 2, 3, 6, 'hello1'),
(20, '2020-12-12 00:07:37', 2, 3, 6, '123'),
(21, '2020-12-12 00:08:26', 2, 3, 6, '123'),
(22, '2020-12-12 00:09:21', 2, 3, 6, '123'),
(23, '2020-12-12 00:09:22', 2, 3, 6, '123'),
(24, '2020-12-12 00:09:23', 2, 3, 6, '123'),
(25, '2020-12-12 00:09:23', 2, 3, 6, '123'),
(26, '2020-12-12 00:09:24', 2, 3, 6, '123'),
(27, '2020-12-12 00:09:24', 2, 3, 6, '123'),
(28, '2020-12-12 00:09:24', 2, 3, 6, '123'),
(29, '2020-12-12 00:09:24', 2, 3, 6, '123'),
(30, '2020-12-12 00:09:24', 2, 3, 6, '123'),
(31, '2020-12-12 00:09:44', 2, 3, 6, '123'),
(32, '2020-12-12 00:09:48', 2, 3, 6, 'hello1');

-- --------------------------------------------------------

--
-- Структура таблицы `offer`
--

CREATE TABLE `offer` (
  `id` int NOT NULL,
  `user_id` int NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL,
  `title` varchar(255) NOT NULL,
  `brand` varchar(255) NOT NULL,
  `model` varchar(255) NOT NULL,
  `phone` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `description` text NOT NULL,
  `price` double NOT NULL,
  `status` int NOT NULL,
  `main_picture` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `offer`
--

INSERT INTO `offer` (`id`, `user_id`, `created_at`, `updated_at`, `title`, `brand`, `model`, `phone`, `email`, `description`, `price`, `status`, `main_picture`) VALUES
(6, 2, '0001-01-01 00:00:00', '0001-01-01 00:00:00', 'offer name', '123', '123', '+79872364520', 'iljas-galiev@mail.ru', '                    \r\n    123213\r\n        ', 123123, 1, '/Files/1886404037_Screenshot_1.jpg');

-- --------------------------------------------------------

--
-- Структура таблицы `offer_image`
--

CREATE TABLE `offer_image` (
  `id` int NOT NULL,
  `offer_id` int NOT NULL,
  `image` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `offer_image`
--

INSERT INTO `offer_image` (`id`, `offer_id`, `image`) VALUES
(1, 6, '/Files/1965475144_Screenshot_2.jpg'),
(2, 6, '/Files/1491476210_Screenshot_3.jpg'),
(3, 6, '/Files/1563907440_Screenshot_4.jpg'),
(4, 6, '/Files/535820922_Screenshot_5.jpg');

-- --------------------------------------------------------

--
-- Структура таблицы `user`
--

CREATE TABLE `user` (
  `id` int NOT NULL,
  `email` varchar(255) NOT NULL,
  `name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `password` varchar(32) NOT NULL,
  `phone` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `status` int NOT NULL,
  `role` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL,
  `last_login_at` datetime DEFAULT NULL,
  `salt` varchar(32) NOT NULL,
  `image` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `user`
--

INSERT INTO `user` (`id`, `email`, `name`, `password`, `phone`, `status`, `role`, `created_at`, `updated_at`, `last_login_at`, `salt`, `image`) VALUES
(2, 'iljas-galiev@mail.ru', 'Ильяс', '25d55ad283aa400af464c76d713c07ad', '+79872364520', 1, NULL, '2020-11-07 11:19:35', '2020-11-07 11:19:35', '0001-01-01 00:00:00', '0eb27573f9c460e1adbd78967f4c2cb2', '/Files/1554995934_KAN.png'),
(3, '123@123.ru', 'Anton', '4297f44b13955235245b2497399d7a93', NULL, 1, NULL, '2020-11-14 12:25:47', '2020-11-14 12:25:47', '0001-01-01 00:00:00', '268e1feb1886978a35ecf1a1f3d4727e', '/Files/1554995934_KAN.png'),
(4, 'iljas-galiev@mail.ru', 'iltiffka', '25d55ad283aa400af464c76d713c07ad', '+79872364520', 1, NULL, '2020-12-12 00:32:11', '2020-12-12 00:32:11', '0001-01-01 00:00:00', '739c93761478f4d5ee66bdf16c4fcda8', NULL);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `message`
--
ALTER TABLE `message`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `offer`
--
ALTER TABLE `offer`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `offer_image`
--
ALTER TABLE `offer_image`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `message`
--
ALTER TABLE `message`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT для таблицы `offer`
--
ALTER TABLE `offer`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT для таблицы `offer_image`
--
ALTER TABLE `offer_image`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `user`
--
ALTER TABLE `user`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
