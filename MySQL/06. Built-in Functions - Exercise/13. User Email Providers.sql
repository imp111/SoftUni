SELECT `user_name`, SUBSTRING(`email`, LOCATE('@', `email`) + 1) AS `email` FROM `users`
ORDER BY `email`, `user_name`;