USE `segundoparcial2k25` ;

CREATE TABLE `Tbl_facultades` (
  `Pk_id_facultad` int NOT NULL AUTO_INCREMENT,
  `Cmp_Nombre_facultad` varchar(45) DEFAULT NULL,
  `Cmp_estatus_facultad` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`Pk_id_facultad`)
);


select * from Tbl_facultades;