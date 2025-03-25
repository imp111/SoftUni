CREATE TABLE `employees` (
	`id` INT(11) PRIMARY KEY NOT NULL AUTO_INCREMENT,
    `first_name` VARCHAR(30) NOT NULL,
    `last_name` VARCHAR(30) NOT NULL,
    `project_id` INT(11)
);

CREATE TABLE `projects` (
	`id` INT(11) PRIMARY KEY NOT NULL AUTO_INCREMENT,
    `client_id` INT(11),
    `project_lead_id` INT(11),
    CONSTRAINT `fk_client_id`
    FOREIGN KEY (`client_id`)
    REFERENCES `clients`(`id`)
);

CREATE TABLE `clients` (
	`id` INT(11) PRIMARY KEY NOT NULL AUTO_INCREMENT,
    `client_name` VARCHAR(100)
);