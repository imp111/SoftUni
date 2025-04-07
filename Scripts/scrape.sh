#!/bin/bash

# Define the URL
URL="https://stablechat.mysecurecloudhost.com/app/accounts/1/conversations/660674"

# Fetch the webpage content
HTML_CONTENT=$(curl -i -H "Accept: text/html" $URL)

echo $HTML_CONTENT

# Extract email addresses using grep
EMAILS=$(echo "$HTML_CONTENT" | grep -oP '[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}')

# Check if emails were found
if [[ -n "$EMAILS" ]]; then
    echo "Extracted Email Addresses:"
    echo "$EMAILS"
else
    echo "No email addresses found on the page."
fi



