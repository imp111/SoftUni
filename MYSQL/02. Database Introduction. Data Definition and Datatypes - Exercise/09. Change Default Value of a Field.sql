SELECT * FROM users;

ALTER TABLE users
CHANGE COLUMN `last_login_time` `last_login_time` DATETIME DEFAULT NOW();

INSERT INTO `users`(`id`, `username`, `password`, `profile_picture`, `last_login_time`, `is_deleted`)
VALUES
('6', 'ar4o1', 'asd123', NULL, Default, false);