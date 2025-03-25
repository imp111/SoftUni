SELECT `title` FROM `books`
WHERE `title` REGEXP '^Harry Potter and the *'
ORDER BY `id`;