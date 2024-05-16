SELECT `peak_name`, `river_name`, LOWER(CONCAT(`peak_name`, SUBSTR(`river_name`, 2, CHAR_LENGTH(`river_name`) - 1))) AS Mix FROM `rivers`, `peaks`
WHERE RIGHT(`peak_name`, 1) = LEFT(`river_name`, 1)
ORDER BY `Mix` ASC;