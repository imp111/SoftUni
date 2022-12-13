SELECT `title` FROM `books`
WHERE `title` REGEXP '^The *'
ORDER BY `id`;