CREATE SCHEMA minions;

CREATE TABLE `minions` (
	`id` INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    `name` VARCHAR(30) NOT NULL,
    `age` INT NOT NULL
);
CREATE TABLE `towns` (
	`town_id` INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    `name` VARCHAR(45) NOT NULL
);