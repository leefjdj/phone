-- phpMyAdmin SQL Dump
-- version 3.2.3
-- http://www.phpmyadmin.net
--
-- 호스트: localhost
-- 처리한 시간: 19-04-01 22:19 
-- 서버 버전: 5.1.41
-- PHP 버전: 5.2.12

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- 데이터베이스: `phonedb`
--

-- --------------------------------------------------------

--
-- 테이블 구조 `customer`
--

CREATE TABLE IF NOT EXISTS `customer` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(20) DEFAULT NULL,
  `address` varchar(40) DEFAULT NULL,
  `customercol` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- 테이블의 덤프 데이터 `customer`
--


-- --------------------------------------------------------

--
-- 테이블 구조 `detail`
--

CREATE TABLE IF NOT EXISTS `detail` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(40) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `storage` varchar(15) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `color` varchar(35) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `price` int(11) DEFAULT NULL,
  `count` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_detail_phone1_idx1` (`name`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=103 ;

--
-- 테이블의 덤프 데이터 `detail`
--

INSERT INTO `detail` (`id`, `name`, `storage`, `color`, `price`, `count`) VALUES
(1, '갤럭시S10 ', '128GB', '프리즘 화이트', 1056000, 0),
(2, '갤럭시S10', '128GB', '프리즘 그린', 1056000, 0),
(3, '갤럭시S10', '128GB', '프리즘 블랙', 1056000, 0),
(4, '갤럭시S10', '512GB', '프리즘 화이트', 1298000, 0),
(5, '갤럭시S10', '512GB', '프리즘 그린', 1298000, 0),
(6, '갤럭시S10 ', '512GB', '프리즘 블랙', 1298000, 0),
(7, '갤럭시S10플러스', '128GB', '프리즘 블랙', 1155000, 0),
(8, '갤럭시S10플러스', '128GB', '프리즘 화이트', 1155000, 0),
(9, '갤럭시S10플러스', '512GB', '세라믹블랙', 1397000, 0),
(10, '갤럭시S10플러스', '512GB', '세라믹화이트', 1397000, 0),
(11, '갤럭시S10플러스', '1TB', '세라믹 화이트', 1878000, 0),
(13, '갤럭시S10e', '128GB', '프리즘 블랙', 899800, 0),
(14, '갤럭시S10e', '128GB', '프리즘 화이트', 899800, 0),
(15, '갤럭시S10e', '128GB', '카나리아 옐로우', 899800, 0),
(16, '갤럭시노트9', '128GB', '알파인 화이트', 944500, 0),
(17, '갤럭시노트9', '128GB', '미드나잇 블랙', 944500, 0),
(18, '갤럭시노트9', '128GB', '라벤더 퍼플', 944500, 0),
(19, '갤럭시노트9', '128GB', '메탈릭 코퍼', 944500, 0),
(20, '갤럭시S9', '64GB', '미드나잇 블랙', 782000, 0),
(21, '갤럭시S9', '64GB', '티타늄 그레이', 782000, 0),
(22, '갤럭시S9', '64GB', '코랄 블루', 782000, 0),
(23, '갤럭시S9', '64GB', '라일락 퍼플', 782000, 0),
(24, '갤럭시S9', '64GB', '폴라리스 블루', 782000, 0),
(25, '갤럭시S9플러스', '64GB', '미드나잇 블랙', 968000, 0),
(26, '갤럭시S9플러스', '64GB', '코랄 블루', 968000, 0),
(27, '갤럭시S9플러스', '64GB', '라일락 퍼플', 968000, 0),
(28, '갤럭시S9플러스', '64GB', '버건디 레드', 968000, 0),
(29, '갤럭시A7 2018', '64GB', '블랙', 569400, 0),
(30, '갤럭시A7 2018', '64GB', '블루', 569400, 0),
(31, '갤럭시A7 2018', '64GB', '골드', 569400, 0),
(32, '갤럭시A8 2018', '32GB', '블랙', 549400, 0),
(33, '갤럭시A8 2018', '32GB', '블루', 549400, 0),
(34, '갤럭시A8 2018', '32GB', '골드', 549400, 0),
(35, '갤럭시A6 2018', '32GB', '블랙', 346500, 0),
(36, '갤럭시A6 2018', '32GB', '골드', 346500, 0),
(37, '갤럭시A6 2018', '32GB', '라벤더', 346500, 0),
(38, '아이폰XR', '64GB', '화이트', 990000, 0),
(39, '아이폰XR', '64GB', '블랙', 990000, 0),
(40, '아이폰XR', '64GB', '블루', 990000, 0),
(41, '아이폰XR', '64GB', '옐로', 990000, 0),
(42, '아이폰XR', '64GB', '코럴', 990000, 0),
(43, '아이폰XR', '64GB', '레드', 990000, 0),
(45, '아이폰XR', '128GB', '화이트', 1060000, 0),
(46, '아이폰XR', '128GB', '블랙', 1060000, 0),
(47, '아이폰XR', '128GB', '블루', 1060000, 0),
(48, '아이폰XR', '128GB', '옐로', 1060000, 0),
(49, '아이폰XR', '128GB', '코럴', 1060000, 0),
(50, '아이폰XR', '128GB', '레드', 1060000, 0),
(51, '아이폰XR', '256GB', '화이트', 1200000, 0),
(52, '아이폰XR', '256GB', '블랙', 1200000, 0),
(53, '아이폰XR', '256GB', '블루', 1200000, 0),
(54, '아이폰XR', '256GB', '옐로', 1200000, 0),
(55, '아이폰XR', '256GB', '코럴', 1200000, 0),
(56, '아이폰XR', '256GB', '레드', 1200000, 0),
(57, '아이폰XS', '64GB', '실버', 1370000, 0),
(58, '아이폰XS', '64GB', '골드', 1370000, 0),
(59, '아이폰XS', '64GB', '스페이스 그레이', 1370000, 0),
(60, '아이폰XS', '256GB', '실버', 1580000, 0),
(61, '아이폰XS', '256GB', '골드', 1580000, 0),
(62, '아이폰XS', '256GB', '스페이스 그레이', 1580000, 0),
(63, '아이폰XS', '512GB', '실버', 1850000, 0),
(64, '아이폰XS', '512GB', '골드', 1850000, 0),
(65, '아이폰XS', '512GB', '스페이스 그레이', 1850000, 0),
(66, '아이폰XS Max', '64GB', '실버', 1500000, 0),
(67, '아이폰XS Max', '64GB', '골드', 1500000, 0),
(68, '아이폰XS Max', '64GB', '스페이스 그레이', 1500000, 0),
(69, '아이폰XS Max', '256GB', '실버', 1710000, 0),
(70, '아이폰XS Max', '256GB', '골드', 1710000, 0),
(71, '아이폰XS Max', '256GB', '스페이스 그레이', 1710000, 0),
(72, '아이폰XS Max', '512GB', '실버', 1980000, 0),
(73, '아이폰XS Max', '512GB', '골드', 1980000, 0),
(74, '아이폰XS Max', '512GB', '스페이스 그레이', 1980000, 0),
(75, '아이폰8', '64GB', '실버', 820000, 0),
(76, '아이폰8', '64GB', '골드', 820000, 0),
(77, '아이폰8', '64GB', '스페이스 그레이', 820000, 0),
(78, '아이폰8', '256GB', '실버', 1030000, 0),
(79, '아이폰8', '256GB', '골드', 1030000, 0),
(80, '아이폰8', '256GB', '스페이스 그레이', 1030000, 0),
(81, '아이폰8플러스', '64GB', '실버', 960000, 0),
(82, '아이폰8플러스', '64GB', '골드', 960000, 0),
(83, '아이폰8플러스', '64GB', '스페이스그레이', 960000, 0),
(84, '아이폰8플러스', '256GB', '실버', 1170000, 0),
(85, '아이폰8플러스', '256GB', '골드', 1170000, 0),
(86, '아이폰8플러스', '256GB', '스페이스 그레이', 1170000, 0),
(87, '아이폰7', '32GB', '블랙', 620000, 0),
(88, '아이폰7', '32GB', '실버', 620000, 0),
(89, '아이폰7', '32GB', '골드', 620000, 0),
(90, '아이폰7', '32GB', '로즈골드', 620000, 0),
(91, '아이폰7', '128GB', '블랙', 760000, 0),
(92, '아이폰7', '128GB', '실버', 760000, 0),
(93, '아이폰7', '128GB', '골드', 760000, 0),
(94, '아이폰7', '128GB', '로즈골드', 760000, 0),
(95, '아이폰7플러스', '32GB', '블랙', 760000, 0),
(96, '아이폰7플러스', '32GB', '실버', 760000, 0),
(97, '아이폰7플러스', '32GB', '골드', 760000, 0),
(98, '아이폰7플러스', '32GB', '로즈골드', 760000, 0),
(99, '아이폰7플러스', '128GB', '블랙', 900000, 0),
(100, '아이폰7플러스', '128GB', '실버', 900000, 0),
(101, '아이폰7플러스', '128GB', '골드', 900000, 0),
(102, '아이폰7플러스', '128GB', '로즈골드', 900000, 0);

-- --------------------------------------------------------

--
-- 테이블 구조 `order`
--

CREATE TABLE IF NOT EXISTS `order` (
  `order_id` int(11) NOT NULL AUTO_INCREMENT,
  `detail_id` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `price` int(11) DEFAULT NULL,
  `order_date` date DEFAULT NULL,
  PRIMARY KEY (`order_id`),
  KEY `fk_order_detail1_idx` (`detail_id`),
  KEY `fk_order_customer1_idx` (`customer_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- 테이블의 덤프 데이터 `order`
--


-- --------------------------------------------------------

--
-- 테이블 구조 `phone`
--

CREATE TABLE IF NOT EXISTS `phone` (
  `name` varchar(40) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `company` varchar(30) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `launch_date` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `os` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `price` int(11) NOT NULL,
  `ram` varchar(10) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `size` varchar(35) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `display` varchar(35) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `battery` varchar(15) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `front_camera` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `back_camera` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- 테이블의 덤프 데이터 `phone`
--

INSERT INTO `phone` (`name`, `company`, `launch_date`, `os`, `price`, `ram`, `size`, `display`, `battery`, `front_camera`, `back_camera`) VALUES
('갤럭시A6 2018 ', '삼성', '2018년 6월', '안드로이드', 346500, '3GB', '70.8 x 149.9 x 7.7mm', '5.6인치 HD', '3000mAh', '1600만화소', '1600만화소'),
('갤럭시A7 2018 ', '삼성', '2018년 10월', '안드로이드', 569400, '4GB', '76.8 x 159.8 x 7.5mm', '6.0인치 FHD', '3300mAh', '2400만화소', '2400만화소'),
('갤럭시A8 2018', '삼성', '2018년 1월', '안드로이드', 549400, '4GB', '70.6 x 149.2 x 8.4mm', '5.6인치 FHD', '3000mAh', '800만화소', '1600만화소'),
('갤럭시S10 ', '삼성', '2019년 3월', '안드로이드', 1056000, '8GB', '70.4 x 149.9 x 7.8mm', '6.1인치 QHD + (3040 x1440)', '3400mAh', '1000만화소', '1200만화소'),
('갤럭시S10e', '삼성', '2019년 3월', '안드로이드', 899800, '6GB', '69.9 x 142.2 x 7.9mm', '5.8인치 FHD + (2280 x1080)', '3100mAh', '1000만화소', '1200만화소'),
('갤럭시S10플러스', '삼성', '2019년 3월', '안드로이드', 1155000, '8GB', '74.1 x 157.6 x 7.8mm', '6.3인치 QHD + (3040 x1440)', '4100mAh', '1000만화소', '1200만화소'),
('갤럭시S9', '삼성', '2018년 3월', '안드로이드', 782000, '4GB', '68.7 x 147.7 x 8.5mm', '5.8인치 QHD + (2960 x 1440)', '3000mAh', '800만화소', '1200만화소'),
('갤럭시S9플러스', '삼성', '2018년 3월', '안드로이드', 968000, '6GB', '73.8 x 158.1 x 8.5mm', '6.2인치 QHD + (2960 x 1440)', '3500mAh', '800만화소', '1200만화소'),
('갤럭시노트9', '삼성', '2018년 8월', '안드로이드', 944500, '6GB', '76.4 x 161.9 x 8.8mm', '6.4인치 QHD', '4000mAh', '800만화소', '1200만화소'),
('아이폰7', '애플', '2016년 9월', 'ios', 620000, '2GB', '67.1 x 138.3 x 7.1mm', '4.7인치 1334 x 750', '1960mAh', '700만화소', '1200만화소'),
('아이폰7플러스', '애플', '2016년 9월', 'ios', 760000, '3GB', '77.9 x 158.2 x 7.3mm', '5.5인치 2208 x 1242', '2900mAh', '700만화소', '1200만화소'),
('아이폰8', '애플', '2017년 9월', 'ios', 820000, '2GB', '67.3 x 138.4 x 7.3mm', '4.7인치 1334 x 750', '1821mAh', '700만화소', '1200만화소'),
('아이폰8플러스', '애플', '2017년 9월', 'ios', 960000, '3GB', '78.1 x 158.4 x 7.5mm', '5.5인치 2208 x 1242', '2691mAh', '700만화소', '1200만화소'),
('아이폰XR', '애플', '2018년 9월', 'ios', 990000, '3GB', '75.7 x 150.9 x 8.3mm', '6.1인치 1792 x 828', '2942mAh', '700만화소', '1200만화소'),
('아이폰XS', '애플', '2018년 9월', 'ios', 1370000, '4GB', '70.9 x 143.6 x 7.7mm', '5.8인치 2436 x 1125', '2758mAh', '700만화소', '1200만화소'),
('아이폰XS Max', '애플', '2018년 9월', 'ios', 1500000, '4GB', '77.4 x 157.5 x 7.7mm', '6.5인치 2688 x 1242', '3174mAh', '700만화소', '1200만화소');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `detail`
--
ALTER TABLE `detail`
  ADD CONSTRAINT `fk_detail_phone1` FOREIGN KEY (`name`) REFERENCES `phone` (`name`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `order`
--
ALTER TABLE `order`
  ADD CONSTRAINT `fk_order_detail1` FOREIGN KEY (`detail_id`) REFERENCES `detail` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_order_customer1` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
