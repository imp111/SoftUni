SELECT CONCAT(`first_name`, ' ', `last_name`) AS `Full Name`, 
IF (`died` IS NULL, NULL, DATEDIFF(`died`, `born`)) AS `Days Lived` 
FROM `authors`;