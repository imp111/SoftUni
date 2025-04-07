#!/bin/bash
#BRAND=$(echo $1 | tr '[:upper:]' '[:lower:]')
# Ticket notes
read -p "Affected service/domain: " SERVICE
read -p "Chat investigation: " CHAT

# Internal notes
read -p "Enter internal note: " INTERNAL

# Output

echo "Hello,

I am raising this ticket, as per our live chat conversation, regarding the issue you are experiencing.

The affected domain/service is: $SERVICE 

Details identified from the chat investigation: $CHAT

Following the below steps will reproduce the issue: 

Our team will further investigate the issue and will update you in more detail once it is resolved.

Please feel free to send any additional information that you see fit.

Kind regards, 
Aleksandar T.

$1

$INTERNAL" | xclip -selection clipboard
