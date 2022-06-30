-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Июн 30 2022 г., 14:34
-- Версия сервера: 10.3.16-MariaDB
-- Версия PHP: 7.3.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `db_calendar`
--

-- --------------------------------------------------------

--
-- Структура таблицы `tbl_calendar`
--

CREATE TABLE `tbl_calendar` (
  `id` int(11) NOT NULL,
  `event` text NOT NULL,
  `date` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `tbl_calendar`
--

INSERT INTO `tbl_calendar` (`id`, `event`, `date`) VALUES
(5, 'wq', '1.6.2022'),
(6, 'wq', '4.6.2022'),
(7, 'wq', '8.6.2022'),
(8, '123', '9.6.2022'),
(9, '1qwe', '9.6.2022');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `tbl_calendar`
--
ALTER TABLE `tbl_calendar`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `tbl_calendar`
--
ALTER TABLE `tbl_calendar`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
