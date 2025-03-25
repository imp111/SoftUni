CREATE SCHEMA `soft_uni`;
USE `soft_uni`;
SET FOREIGN_KEY_CHECKS=0;

# towns (id, name), towns: Sofia, Plovdiv, Varna, Burgas
CREATE TABLE `towns` (
	`id` INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    `name` VARCHAR(30) NOT NULL
);
INSERT INTO `towns` (`id`, `name`)
VALUES
('1', 'Sofia'),
('2', 'Plovdiv'),
('3', 'Varna'),
('4', 'Burgas');

# addresses (id, address_text, town_id)
CREATE TABLE `addresses` (
	`id` INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    `address_text` VARCHAR(30) NOT NULL,
    `town_id` INT NOT NULL,
    CONSTRAINT `fk_addresses_towns`
    FOREIGN KEY (`town_id`) REFERENCES `towns`(`id`)
);

# departments (id, name), departments: Engineering, Sales, Marketing, Software Development, Quality Assurance
CREATE TABLE `departments` (
	`id` INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    `name` VARCHAR(30)
);
INSERT INTO `departments` (`id`, `name`)
VALUES
('1', 'Engineering'),
('2', 'Sales'),
('3', 'Marketing'),
('4', 'Software Development'),
('5', 'Quality Assurance');

/*  employees (id, first_name, middle_name, last_name, job_title, department_id, hire_date, salary, address_id)
Ivan Ivanov Ivanov .NET Developer Software Development 01/02/2013 3500.00
Petar Petrov Petrov Senior Engineer Engineering 02/03/2004 4000.00
Maria Petrova Ivanova Intern Quality Assurance 28/08/2016 525.25
Georgi Terziev Ivanov CEO Sales 09/12/2007 3000.00
Peter Pan Pan Intern Marketing 28/08/2016 599.88 
*/
CREATE TABLE `employees` (
	`id` INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    `first_name` VARCHAR(20) NOT NULL,
    `middle_name` VARCHAR(20) NOT NULL,
    `last_name` VARCHAR(20) NOT NULL,
    `job_title` VARCHAR(30),
    `department_id` INT,
    `hire_date` DATE NOT NULL,
    `salary` FLOAT(7, 2),
    `address_id` INT,
    CONSTRAINT `fk_employees_department`
    FOREIGN KEY (`department_id`) REFERENCES `departments`(`id`),
    CONSTRAINT `fk_employees_address`
    FOREIGN KEY (`address_id`) REFERENCES `addresses`(`id`)
);
INSERT INTO `employees` (`id`, `first_name`, `middle_name`, `last_name`, `job_title`, `department_id`, `hire_date`, `salary`, `address_id`)
VALUES
('1', 'Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 4, '2013/02/01', '3500.00', 1),
('2', 'Petar', 'Petrov', 'Petrov', 'Senior Engineer', 1, '2004/03/02', '4000.00', 3),
('3', 'Maria', 'Petrova', 'Ivanova', 'Intern', 5, '2016/08/28', '525.25', 2),
('4','Georgi', 'Terziev', 'Ivanov', 'CEO', 2, '2007/12/09', '3000.00', 4),
('5', 'Peter', 'Pan', 'Pan', 'Intern', 3, '2016/08/28', '599.88', 1); 