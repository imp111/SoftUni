SELECT `department_id`, MAX(`salary`) as `max_salary`
FROM `employees`
GROUP BY `department_id`
HAVING `max_salary` NOT IN ('30000', '70000')
ORDER BY `department_id` ASC;