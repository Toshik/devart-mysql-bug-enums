--
-- Table structure for table `records`
--

DROP TABLE IF EXISTS `records`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `records` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `int_column1` int(11) DEFAULT NULL,
  `int_column2` int(11) DEFAULT NULL,
  `date_column` date NOT NULL,
  `boolean_column` tinyint(1) NOT NULL,
  `enum_int_column` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6575 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;
