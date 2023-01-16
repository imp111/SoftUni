ALTER TABLE minions
ADD `town_id` INT;
ALTER TABLE minions
ADD FOREIGN KEY(`town_id`) REFERENCES towns(`id`);