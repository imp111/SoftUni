SELECT * FROM people;

CREATE TABLE `people` (
	`id` INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    `name` VARCHAR(200) NOT NULL,
    `picture` BLOB NULL,
    `height` FLOAT(5, 2),
    `weight` FLOAT(5, 2),
    `gender` CHAR(1) NOT NULL,
    `birthdate` DATE NOT NULL,
    `biography` TEXT 
);
INSERT INTO `people` (`id`, `name`, `picture`, `height`, `weight`, `gender`, `birthdate`, `biography`)
VALUES
('1', 'Gosho', null, '180', '80', 'm', '1999-12-19', null),
('2', 'Bonio', null, '175', '75', 'm', '1998-08-15', null),
('3', 'Dinka', null, '160', '50', 'f', '1997-09-12', null),
('4', 'Donio', null, '185', '85', 'm', '1996-10-11', null),
('5', 'Minka', null, '170', '53', 'f', '1995-11-21', null);
