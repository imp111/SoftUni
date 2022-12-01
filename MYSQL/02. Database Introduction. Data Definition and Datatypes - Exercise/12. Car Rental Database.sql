CREATE SCHEMA car_rental;
/*
categories (id, category, daily_rate, weekly_rate, monthly_rate, weekend_rate)
cars (id, plate_number, make, model, car_year, category_id, doors, picture, car_condition, available)
employees (id, first_name, last_name, title, notes)
customers (id, driver_licence_number, full_name, address, city, zip_code, notes)
rental_orders (id, employee_id, customer_id, car_id, car_condition, tank_level, kilometrage_start, kilometrage_end, total_kilometrage, start_date, end_date, total_days, rate_applied, tax_rate, order_status, notes)

Set most appropriate data types for each column. Set primary key to each table. 
Populate each table with 3 records. Make sure the columns that are present in 2 tables would be of the same data type. 
Consider which fields are always required and which are optional. 
Submit your CREATE TABLE and INSERT statements as Run queries & check DB
*/
CREATE TABLE `categories`(
	`id` INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    `category` VARCHAR(30) NOT NULL,
    `daily_rate` TEXT,
    `weekly_rate` TEXT,
    `monthly_rate` TEXT,
    `weekend_rate` TEXT
);
INSERT INTO `categories` (`id`, `category`, `daily_rate`, `weekly_rate`, `monthly_rate`, `weekend_rate`)
VALUES
('1', 'Georgi', NULL, '1', 'Georgi', NULL),
('1', 'Georgi', NULL, '1', 'Georgi', NULL),
('1', 'Georgi', NULL, '1', 'Georgi', NULL);

CREATE TABLE `genres`(
	`id` INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    `genre_name` VARCHAR(30) NOT NULL,
    `notes` TEXT
);
INSERT INTO `genres` (`id`, `genre_name`, `notes`)
VALUES
('1', 'Action', NULL),
('2', 'Drama', NULL),
('3', 'Comedy', NULL),
('4', 'Horror', NULL),
('5', 'Sci-fi', NULL);

CREATE TABLE `categories`(
	`id` INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    `category_name` VARCHAR(30) NOT NULL,
    `notes` TEXT
);
INSERT INTO `categories` (`id`, `category_name`, `notes`)
VALUES
('1', 'Russian', NULL),
('2', 'War', NULL),
('3', 'Gangster', NULL),
('4', 'Animated', NULL),
('5', 'Historical', NULL);

CREATE TABLE `movies`(
	`id` INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    `title` VARCHAR(30) NOT NULL,
    `director_id` INT,
    `copyright_year` DATE,
    `length` INT,
    `genre_id` INT,
    `category_id` INT,
    `ratings` INT,
    `notes` TEXT,
    CONSTRAINT `fk_director`
    FOREIGN KEY (`director_id`)
    REFERENCES `directors`(`id`),
	CONSTRAINT `fk_genre`
    FOREIGN KEY (`genre_id`)
    REFERENCES `genres`(`id`),
	CONSTRAINT `fk_category`
    FOREIGN KEY (`category_id`)
    REFERENCES `categories`(`id`)
);
INSERT INTO `movies` (`id`, `title`, `director_id`, `copyright_year`, `length`, `genre_id`, `category_id`, `ratings`, `notes`)
VALUES
('1', 'Transformers', 1, NULL, '130', 1, 3, null, null),
('2', 'World War Z', 2, NULL, '135', 2, 2, null, null),
('3', 'Mutant Ninja Turtles', 3, NULL, '140', 3, 4, null, null),
('4', 'Constantine', 4, NULL, '145', 4, 5, null, null),
('5', 'Avengers: End Game', 5, NULL, '150', 5, 1, null, null);