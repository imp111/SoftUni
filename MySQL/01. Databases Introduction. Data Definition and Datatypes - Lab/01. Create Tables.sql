CREATE SCHEMA `gamebar`;
CREATE TABLE `gamebar`.`employees` (
	`id` INT AUTO_INCREMENT,
    `first_name` VARCHAR(45) NOT NULL,
    `second_name` VARCHAR(45) NOT NULL,
    PRIMARY KEY(`id`)
);
CREATE TABLE `gamebar`.`categories` (
	`id` INT AUTO_INCREMENT,
    `name` VARCHAR(45) NOT NULL,
    PRIMARY KEY(`id`)
);
CREATE TABLE `gamebar`.`products` (
	`id` INT AUTO_INCREMENT,
    `name` VARCHAR(45) NOT NULL,
    `category_id` INT NOT NULL,
    PRIMARY KEY(`id`)
);

