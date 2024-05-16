USE `soft_uni`;

UPDATE `employees` SET `salary`= salary + (salary*10/100) WHERE Id!=0;
SELECT `salary` FROM `employees`;