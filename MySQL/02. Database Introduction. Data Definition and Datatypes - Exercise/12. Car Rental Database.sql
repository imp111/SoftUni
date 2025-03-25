CREATE SCHEMA car_rental;
USE `car_rental`;

-- categories (id, category, daily_rate, weekly_rate, monthly_rate, weekend_rate)
CREATE TABLE `categories`(
	`id` INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    `category` VARCHAR(30) NOT NULL,
    `daily_rate` FLOAT(5, 2),
    `weekly_rate` FLOAT(5, 2),
    `monthly_rate` FLOAT(5, 2),
    `weekend_rate` FLOAT(5, 2)
);
INSERT INTO `categories` (`id`, `category`, `daily_rate`, `weekly_rate`, `monthly_rate`, `weekend_rate`)
VALUES
('1', 'SUV', NULL, NULL, NULL, NULL),
('2', 'Hatchback', NULL, NULL, NULL, NULL),
('3', 'Crossover', NULL, NULL, NULL, NULL);

-- cars (id, plate_number, make, model, car_year, category_id, doors, picture, car_condition, available)
CREATE TABLE `cars`(
	`id` INT NOT NULL AUTO_INCREMENT,
    `plate_number` VARCHAR(8) NOT NULL,
    `make` VARCHAR(20) NOT NULL,
    `model` VARCHAR(20) NOT NULL,
    `car_year` INT NOT NULL,
    `category_id` INT NOT NULL,
    `doors` INT NOT NULL,
    `picture` TEXT,
    `car_condition` VARCHAR(10) NOT NULL,
    `available` BOOLEAN NOT NULL,
    CONSTRAINT PK_cars PRIMARY KEY(`id`, `car_condition`),
    CONSTRAINT `fk_category`
    FOREIGN KEY (`category_id`)
    REFERENCES `categories`(`id`)
);
INSERT INTO `cars` (`id`, `plate_number`, `make`, `model`, `car_year`, `category_id`, `doors`, `picture`, `car_condition`, `available`)
VALUES
('1', 'CT1234AH', 'BMW', 'F10', '2020', 2, '5', NULL, 'brand-new', TRUE),
('2', 'CA7645PH', 'Mercedes', 'Maybach', '2021', 3, '5', NULL, 'brand-new', TRUE),
('3', 'CB1111AA', 'Lamborghini', 'Urus', '2022', 1, '5', NULL, 'brand-new', TRUE);

-- employees (id, first_name, last_name, title, notes)
CREATE TABLE `employees`(
	`id` INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    `first_name` VARCHAR(20) NOT NULL,
    `last_name` VARCHAR(20) NOT NULL,
    `title` VARCHAR(20),
    `notes` TEXT
);
INSERT INTO `employees` (`id`, `first_name`, `last_name`, `title`, `notes`)
VALUES
('1', 'Aleksandar', 'Goshev', 'Sales Representative', NULL),
('2', 'Georgi', 'Donchev', 'Sales Representative', NULL),
('3', 'Foncho', 'Sinkov', 'Sales Representative', NULL);

-- customers (id, driver_licence_number, full_name, address, city, zip_code, notes)
CREATE TABLE `customers`(
	`id` INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    `driver_license_number` VARCHAR(15) NOT NULL,
    `full_name` VARCHAR(50) NOT NULL,
    `address` VARCHAR(30),
    `city` VARCHAR(30),
    `zip_code` INT,
    `notes` TEXT
);
INSERT INTO `customers` (`id`, `driver_license_number`, `full_name`, `address`, `city`, `zip_code`, `notes`)
VALUES
('1', '1235fj49d93k50f', 'Dimitar Dimitrov Dimitrev', NULL, 'Sofia', '1000', NULL),
('2', 'fioj4059u2409rj', 'Donka Doneva Doncheva', NULL, 'Sofia', '1000', NULL),
('3', 'gk59fj430921d33', 'Siika Siikova Sinkova', NULL, 'Sofia', '1000', NULL);

-- rental_orders (id, employee_id, customer_id, car_id, car_condition, tank_level, kilometrage_start, kilometrage_end, total_kilometrage, start_date, end_date, total_days, rate_applied, tax_rate, order_status, notes)
CREATE TABLE `rental_orders`(
	`id` INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    `employee_id` INT NOT NULL,
    `customer_id` INT NOT NULL,
    `car_id` INT NOT NULL,
    `car_condition` VARCHAR(10),
    `tank_level` VARCHAR(4),
    `kilometrage_start` INT,
    `kilometrage_end` INT,
    `total_kilometrage` INT,
    `start_date` DATE,
    `end_date` DATE,
    `total_days` INT,
    `rate_applied` INT,
    `tax_rate` FLOAT(5, 2),
    `order_status` VARCHAR(10),
    `notes` TEXT,
    CONSTRAINT `fk_employee`
    FOREIGN KEY (`employee_id`)
    REFERENCES `employees`(`id`),
	CONSTRAINT `fk_customer`
    FOREIGN KEY (`customer_id`)
    REFERENCES `customers`(`id`),
	CONSTRAINT `fk_car`
    FOREIGN KEY (`car_id`)
    REFERENCES `cars`(`id`)
);
INSERT INTO `rental_orders` (`id`, `employee_id`, `customer_id`, `car_id`, `car_condition`, `tank_level`, `kilometrage_start`, 
`kilometrage_end`, `total_kilometrage`, `start_date`, `end_date`, `total_days`, `rate_applied`, `tax_rate`, `order_status`, `notes`)
VALUES
('1', 3, 1, 3, 3, '100%', '0', '100', '1000', '2022-12-02', '2022-12-04', '2', null, null, 'pending', null),
('2', 1, 3, 2, 2, '100%', '0', '100', '1000', '2022-12-02', '2022-12-04', '2', null, null, 'pending', null),
('3', 2, 2, 1, 1, '100%', '0', '100', '1000', '2022-12-02', '2022-12-04', '2', null, null, 'pending', null);