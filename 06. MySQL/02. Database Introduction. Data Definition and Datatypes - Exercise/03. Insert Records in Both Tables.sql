INSERT INTO towns (`id`, `name`)
VALUES
('1', 'Sofia'),
('2', 'Plovdiv'),
('3', 'Varna');
ALTER TABLE minions
MODIFY `age` INT NULL;
INSERT INTO minions (`id`, `name`, `age`, `town_id`)
VALUES
('1', 'Kevin', '22', '1'),
('2', 'Bob', '15', '3'),
('3', 'Steward', null, '2');