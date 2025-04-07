#!/bin/bash

# Commands:
# - hta || ht 
# - php || phpinfo || info || pi
# - ticket || ti || tic || tick

if [ "$#" -eq 0 ]; then
    echo "No arguments added, exiting!"
    exit 1
fi

echo "Short"
echo "Commands: hta/ht | php/phpinfo/info/pi | ticket/ti/tic/tick | handler/hand/phph | slow | ports/port"

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
	echo "AddHandler application/x-httpd-alt-php74___lsphp .php - for cloudlonux"
	echo "AddHandler application/x-httpd-alt-php$2___lsphp.php" | xclip -selection clipboard

elif [[ $1 = "slow" ]]; then
	echo "<IfModule mod_expires.c>
ExpiresActive On

# Images
ExpiresByType image/jpeg "access plus 1 year"
ExpiresByType image/gif "access plus 1 year"
ExpiresByType image/png "access plus 1 year"
ExpiresByType image/webp "access plus 1 year"
ExpiresByType image/svg+xml "access plus 1 year"
ExpiresByType image/x-icon "access plus 1 year"

# Video
ExpiresByType video/webm "access plus 1 year"
ExpiresByType video/mp4 "access plus 1 year"
ExpiresByType video/mpeg "access plus 1 year"

# Fonts
ExpiresByType font/ttf "access plus 1 year"
ExpiresByType font/otf "access plus 1 year"
ExpiresByType font/woff "access plus 1 year"
ExpiresByType font/woff2 "access plus 1 year"
ExpiresByType application/font-woff "access plus 1 year"

# CSS, JavaScript
ExpiresByType text/css "access plus 1 month"
ExpiresByType text/javascript "access plus 1 month"
ExpiresByType application/javascript "access plus 1 month"

# Others
ExpiresByType application/pdf "access plus 1 month"
ExpiresByType image/vnd.microsoft.icon "access plus 1 year"
</IfModule>

<ifModule mod_gzip.c>
mod_gzip_on Yes
mod_gzip_dechunk Yes
mod_gzip_item_include file .(html?|txt|css|js|php|pl)$
mod_gzip_item_include handler ^cgi-script$
mod_gzip_item_include mime ^text/.
mod_gzip_item_include mime ^application/x-javascript.
mod_gzip_item_exclude mime ^image/.
mod_gzip_item_exclude rspheader ^Content-Encoding:.gzip.*
</ifModule>

<IfModule mod_deflate.c>
# Compress HTML, CSS, JavaScript, Text, XML and fonts
AddOutputFilterByType DEFLATE application/javascript
AddOutputFilterByType DEFLATE application/rss+xml
AddOutputFilterByType DEFLATE application/vnd.ms-fontobject
AddOutputFilterByType DEFLATE application/x-font
AddOutputFilterByType DEFLATE application/x-font-opentype
AddOutputFilterByType DEFLATE application/x-font-otf
AddOutputFilterByType DEFLATE application/x-font-truetype
AddOutputFilterByType DEFLATE application/x-font-ttf
AddOutputFilterByType DEFLATE application/x-javascript
AddOutputFilterByType DEFLATE application/xhtml+xml
AddOutputFilterByType DEFLATE application/xml
AddOutputFilterByType DEFLATE font/opentype
AddOutputFilterByType DEFLATE font/otf
AddOutputFilterByType DEFLATE font/ttf
AddOutputFilterByType DEFLATE image/svg+xml
AddOutputFilterByType DEFLATE image/x-icon
AddOutputFilterByType DEFLATE text/css
AddOutputFilterByType DEFLATE text/html
AddOutputFilterByType DEFLATE text/javascript
AddOutputFilterByType DEFLATE text/plain
AddOutputFilterByType DEFLATE text/xml
AddType x-font/otf .otf
AddType x-font/ttf .ttf
AddType x-font/eot .eot
AddType x-font/woff .woff
AddType image/x-icon .ico
AddType image/png .png

# Remove browser bugs (only needed for really old browsers)

BrowserMatch ^Mozilla/4 gzip-only-text/html
BrowserMatch ^Mozilla/4.0[678] no-gzip
BrowserMatch \bMSIE !no-gzip !gzip-only-text/html
Header append Vary User-Agent
</IfModule> " | xclip -selection clipboard
elif [[ $1 = "ports" || $1 = "port" ]]; then
	read -p "Enter protocol name: " protocol
	case $protocol in
		http)
			echo "80"
			echo "80" | xclip -selection clipboard ;;
		https)
			echo "443"
			echo "443" | xclip -selection clipboard ;;
		ssh)
			echo "22"
			echo "22" | xclip -selection clipboard ;;
		ftp)
			echo "21"
			echo "21" | xclip -selection clipboard ;;
		pop)
			echo "110/995"
			echo "110/995" | xclip -selection clipboard ;;
		imap)
			echo "143/993"
			echo "143/993" | xclip -selection clipboard ;;
		smtp)
			echo "25, 26/465, 587"
			echo "25, 26/465, 587" | xclip -selection clipboard ;;
		mysql)
			echo "3306"
			echo "3306" | xclip -selection clipboard ;;
		cpanel)
			echo "2082/2083"
			echo "2082/2083" | xclip -selection clipboard ;;
		whm)
			echo "2086/2087"
			echo "2086/2087" | xclip -selection clipboard ;;
		webmail)
			echo "2095/2096"
			echo "2095/2096" | xclip -selection clipboard ;;
		*)
			echo "Port not found" ;;
	esac

else
	echo "wrong command"
fi
