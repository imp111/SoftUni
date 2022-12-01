CREATE TABLE `users`(
	`id` INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    `username` VARCHAR(30) NOT NULL,
    `password` VARCHAR(26) NOT NULL,
    `profile_picture` BLOB,
    `last_login_time` DATETIME,
    `is_deleted` BOOLEAN
);
INSERT INTO `users`(`id`, `username`, `password`, `profile_picture`, `last_login_time`, `is_deleted`)
VALUES
('1', 'vanko1', '123a', NULL, '2022-12-1 15:30:33', false),
('2', 'donko1', '1234a', NULL, '2022-12-1 16:30:33', false),
('3', 'ror4o2', '12345a', NULL, '2022-12-1 17:30:33', false),
('4', 'fon4o1', '123456a', NULL, '2022-12-1 18:30:33', false),
('5', 'don4o1', '1234567a', NULL, '2022-12-1 19:30:33', false);
 
 
 