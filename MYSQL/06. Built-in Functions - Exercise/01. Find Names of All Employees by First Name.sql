# Solution 1 - using REGEXP
SELECT `first_name`, `last_name` 
FROM `employees`
WHERE `first_name` REGEXP '^Sa *'
ORDER BY `employee_id`;

# Solution 2 - using SUBSTR
SELECT `first_name`, `last_name`
FROM `employees`
WHERE SUBSTR(`first_name`, 1, 2) = 'Sa'
ORDER BY `employee_id`;
