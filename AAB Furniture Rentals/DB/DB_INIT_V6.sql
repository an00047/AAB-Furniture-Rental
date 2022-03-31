-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema RentMe
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema RentMe
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `RentMe` DEFAULT CHARACTER SET utf8 ;
USE `RentMe` ;

-- -----------------------------------------------------
-- Table `RentMe`.`member`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `RentMe`.`member` (
  `memberID` INT NOT NULL AUTO_INCREMENT,
  `fname` VARCHAR(45) NOT NULL,
  `lname` VARCHAR(45) NOT NULL,
  `sex` TINYTEXT NULL,
  `dob` DATETIME NOT NULL,
  `address` VARCHAR(45) NOT NULL,
  `phone` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`memberID`),
  UNIQUE INDEX `memberID_UNIQUE` (`memberID` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `RentMe`.`furniture_style`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `RentMe`.`furniture_style` (
  `style_type` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`style_type`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `RentMe`.`furniture_categories`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `RentMe`.`furniture_categories` (
  `category_type` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`category_type`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `RentMe`.`furniture`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `RentMe`.`furniture` (
  `furnitureID` INT NOT NULL AUTO_INCREMENT,
  `style_type` VARCHAR(45) NOT NULL,
  `category_type` VARCHAR(45) NOT NULL,
  `description` VARCHAR(45) NOT NULL,
  `daily_rental_rate` DECIMAL(4,2) NOT NULL,
  `quantity` INT NOT NULL,
  `fine_rate` DECIMAL(4,2) NOT NULL,
  PRIMARY KEY (`furnitureID`),
  INDEX `fk_furniture_furniture_style1_idx` (`style_type` ASC) VISIBLE,
  INDEX `fk_furniture_furniture_categories1_idx` (`category_type` ASC) VISIBLE,
  UNIQUE INDEX (`furnitureID` ASC) VISIBLE,
  CONSTRAINT `fk_furniture_furniture_style1`
    FOREIGN KEY (`style_type`)
    REFERENCES `RentMe`.`furniture_style` (`style_type`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_furniture_furniture_categories1`
    FOREIGN KEY (`category_type`)
    REFERENCES `RentMe`.`furniture_categories` (`category_type`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `RentMe`.`login_data`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `RentMe`.`login_data` (
  `username` VARCHAR(20) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`username`),
  UNIQUE INDEX `username_UNIQUE` (`username` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `RentMe`.`employee`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `RentMe`.`employee` (
  `employeeID` INT NOT NULL AUTO_INCREMENT,
  `fname` VARCHAR(45) NOT NULL,
  `lname` VARCHAR(45) NOT NULL,
  `sex` VARCHAR(1) NULL,
  `dob` DATETIME NOT NULL,
  `address` VARCHAR(45) NOT NULL,
  `phone` VARCHAR(10) NOT NULL,
  `active` TINYINT NULL,
  `city` VARCHAR(45) NOT NULL,
  `state` VARCHAR(2) NOT NULL,
  `zip` VARCHAR(5) NOT NULL,
  `login_data_username` VARCHAR(20) NOT NULL,
  `admin` TINYINT NOT NULL DEFAULT 0,
  PRIMARY KEY (`employeeID`),
  INDEX `fk_employee_login_data1_idx` (`login_data_username` ASC) VISIBLE,
  UNIQUE INDEX `employeeID_UNIQUE` (`employeeID` ASC) VISIBLE,
  CONSTRAINT `fk_employee_login_data1`
    FOREIGN KEY (`login_data_username`)
    REFERENCES `RentMe`.`login_data` (`username`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `RentMe`.`rentals`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `RentMe`.`rentals` (
  `rentalTransactionID` INT NOT NULL AUTO_INCREMENT,
  `memberID` INT NOT NULL,
  `employeeID` INT NOT NULL,
  `datetime` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `datetime_due` DATETIME NOT NULL,
  PRIMARY KEY (`rentalTransactionID`),
  INDEX `fk_rentals_member1_idx` (`memberID` ASC) VISIBLE,
  UNIQUE INDEX `transactionID_UNIQUE` (`rentalTransactionID` ASC) VISIBLE,
  INDEX `fk_rentals_employee1_idx` (`employeeID` ASC) VISIBLE,
  CONSTRAINT `fk_rentals_member1`
    FOREIGN KEY (`memberID`)
    REFERENCES `RentMe`.`member` (`memberID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_rentals_employee1`
    FOREIGN KEY (`employeeID`)
    REFERENCES `RentMe`.`employee` (`employeeID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `RentMe`.`is_rented`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `RentMe`.`is_rented` (
  `transactionID` INT NOT NULL,
  `quantityOut` INT NOT NULL,
  `furnitureID` INT NOT NULL,
  PRIMARY KEY (`transactionID`, `furnitureID`),
  INDEX `fk_is_rented_furniture1_idx` (`furnitureID` ASC) VISIBLE,
  CONSTRAINT `fk_is_rented_rentals1`
    FOREIGN KEY (`transactionID`)
    REFERENCES `RentMe`.`rentals` (`rentalTransactionID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_is_rented_furniture1`
    FOREIGN KEY (`furnitureID`)
    REFERENCES `RentMe`.`furniture` (`furnitureID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `RentMe`.`returns`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `RentMe`.`returns` (
  `returnTransactionID` INT NOT NULL AUTO_INCREMENT,
  `datetime` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `employee_employeeID` INT NOT NULL,
  PRIMARY KEY (`returnTransactionID`),
  UNIQUE INDEX `transactionID_UNIQUE` (`returnTransactionID` ASC) VISIBLE,
  INDEX `fk_returns_employee1_idx` (`employee_employeeID` ASC) VISIBLE,
  CONSTRAINT `fk_returns_employee1`
    FOREIGN KEY (`employee_employeeID`)
    REFERENCES `RentMe`.`employee` (`employeeID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `RentMe`.`is_returned`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `RentMe`.`is_returned` (
  `quantityIn` INT ZEROFILL NOT NULL,
  `is_rented_transactionID` INT NOT NULL,
  `is_rented_furnitureID` INT NOT NULL,
  `returns_returnTransactionID` INT NOT NULL,
  PRIMARY KEY (`is_rented_transactionID`, `is_rented_furnitureID`, `returns_returnTransactionID`),
  INDEX `fk_is_returned_is_rented1_idx` (`is_rented_transactionID` ASC, `is_rented_furnitureID` ASC) VISIBLE,
  INDEX `fk_is_returned_returns1_idx` (`returns_returnTransactionID` ASC) VISIBLE,
  CONSTRAINT `fk_is_returned_is_rented1`
    FOREIGN KEY (`is_rented_transactionID` , `is_rented_furnitureID`)
    REFERENCES `RentMe`.`is_rented` (`transactionID` , `furnitureID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_is_returned_returns1`
    FOREIGN KEY (`returns_returnTransactionID`)
    REFERENCES `RentMe`.`returns` (`returnTransactionID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

USE `RentMe`;

DELIMITER $$
USE `RentMe`$$
CREATE DEFINER = CURRENT_USER TRIGGER `RentMe`.`sub_out_of_inventory` AFTER INSERT ON `is_rented` FOR EACH ROW
BEGIN
UPDATE `rentme`.`furniture` SET
`quantity` = `quantity` - NEW.`quantityOut`
WHERE `furniture`.`furnitureID` = NEW.`furnitureID`;
END$$

USE `RentMe`$$
CREATE DEFINER = CURRENT_USER TRIGGER `RentMe`.`add_back_to_inventory` AFTER INSERT ON `is_returned` FOR EACH ROW
BEGIN
UPDATE `rentme`.`furniture` SET
`quantity` = `quantity` + NEW.`quantityIn`
WHERE `furniture`.`furnitureID` = NEW.`is_rented_furnitureID`;
END$$


DELIMITER ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
