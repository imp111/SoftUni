#Solution 1
SELECT `first_name`, `last_name` 
FROM `employees`
WHERE `first_name` REGEXP '^Sa *'
ORDER BY `employee_id`;

# Solution 2
SELECT `first_name`, `last_name`
FROM `employees`
WHERE SUBSTR(`first_name`, 1, 2) = 'Sa'
ORDER BY `employee_id`;
