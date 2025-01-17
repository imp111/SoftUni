#!/bin/bash

# Commands:
# - hta || ht 
# - php || phpinfo || info || pi
# - ticket || ti || tic || tick

if [ "$#" -eq 0 ]; then
    echo "No arguments added, exiting!"
    exit 1
fi

if [[ $1 = "hta" || $1 = "ht" || $1 = "htaccess" ]]; then
	echo "#Begin Wordpress
	RewriteEngine On
	RewriteRule .* - [E=HTTP_AUTHORIZATION:%{HTTP:Authorization}]
	RewriteBase /
	RewriteRule ^index.php$ - [L]
	RewriteCond %{REQUEST_FILENAME} !-f
	RewriteCond %{REQUEST_FILENAME} !-d
	RewriteRule . /index.php [L]
	#End Wordpress" | xclip -selection clipboard
elif [[ $1 = "php" || $1 = "phpinfo" || $1 = "info" || $1 = "pi" ]]; then
	echo "<?php

	// Show all information, defaults to INFO_ALL
	phpinfo();

	// Show just the module information.
	// phpinfo(8) yields identical results.
	phpinfo(INFO_MODULES);

	?>" | xclip -selection clipboard
elif [[ $1 = "ticket" || $1 = "ti" || $1 = "tic" || $1 == "tick" ]]; then
	echo "Hello,

I am raising this ticket, as per our live chat conversation, regarding the issue you are experiencing.

The affected domain/service is: $2 

Details identified from the chat investigation: $3

Following the below steps will reproduce the issue: 

Our team will further investigate the issue and will update you in more detail once it is resolved.

Please feel free to send any additional information that you see fit.

Kind regards, 
Aleksandar T." | xclip -selection clipboard
elif [[ $1 = "handler" || $1 = "hand" || $1 == "phph" ]]; then
	echo "AddHandler application/x-httpd-alt-php$2___lsphp.php" | xclip -selection clipboard
else
	echo "wrong command"
fi
