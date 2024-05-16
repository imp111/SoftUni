CREATE SCHEMA `Movies`;
CREATE TABLE `directors`(
	`id` INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    `director_name` VARCHAR(30) NOT NULL,
    `notes` TEXT
);
INSERT INTO `directors` (`id`, `director_name`, `notes`)
VALUES
('1', 'Georgi', NULL),
('2', 'Doni', NULL),
('3', 'Foni', NULL),
('4', 'Elon', NULL),
('5', 'Alex', NULL);

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

SELECT * FROM movies;