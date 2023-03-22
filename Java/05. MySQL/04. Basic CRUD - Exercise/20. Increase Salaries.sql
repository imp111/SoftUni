SELECT `first_name`, `last_name`, `department_id`, `salary` FROM `employees`
WHERE `department_id` IN (1, 2, 4, 11)
ORDER BY `salary` DESC;

UPDATE `employees`
SET `salary`= `salary` * 1.12
WHERE `department_id`='1' OR `department_id`='2' OR `department_id`='4' OR `department_id`='11';