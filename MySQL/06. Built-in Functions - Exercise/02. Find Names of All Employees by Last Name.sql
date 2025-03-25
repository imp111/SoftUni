# Solution 1
SELECT `first_name`, `last_name`
FROM `employees`
WHERE `last_name` LIKE '%ei%'
ORDER BY `employee_id`;

# Solution 2
SELECT `first_name`, `last_name`
FROM `employees`
WHERE LOCATE('ei', `last_name`)
ORDER BY `employee_id`;
