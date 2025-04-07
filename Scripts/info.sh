#!/bin/bash

# USAGE:
# Number of CMD Line arguments:
# 	- 0 - Invalid
# 	- 1 - Domain information <argument> (domain name)
# 	- 2 - Notes <argument> <flags> 

RED='\033[0;31m'
GREEN='\033[0;32m'
NC='\033[0m' # reset colors back to normal
BLACK='\033[0;30m'
YELLOW='\033[0;33m'
BLUE='\033[0;34m'
PURPLE='\033[0;35m'
CYAN='\033[0;36m'
WHITE='\033[0;37m'

if [ $# -eq 1 ]; then

    whois_info=$(whois "$1")

    print_field() {
        local field="$1"
        local value=$(echo "$whois_info" | grep -i "^$field:" | sed 's/^[^:]*://; s/^ *//; s/ *$//' | head -n 1)
        if [ ! -z "$value" ]; then
            echo -e "${CYAN}$field${NC} $value"
        fi
    }

    echo -e "\n${PURPLE}Info for $1: ${NC}\n"
    print_field "Domain Name"
    print_field "Registrar"
    print_field "Registrar WHOIS Server"
    print_field "Registrar URL"
    print_field "Creation Date"

    expiration=$(echo "$whois_info" | grep -iE "^(Registry )?(Expir(y|ation) Date|Expiration Time|Registrar Registration Expiration Date):" | sed 's/^[^:]*://; s/^ *//; s/ *$//' | sort -u | head -n 1)
    if [ ! -z "$expiration" ]; then
        echo -e "${CYAN}Expiration Date${NC} $expiration"
    else
        
        expiration=$(echo "$whois_info" | grep -iE "expir|renew" | grep -iE "date|time" | sed 's/^[^:]*://; s/^ *//; s/ *$//' | sort -u | head -n 1)
        if [ ! -z "$expiration" ]; then
            echo -e "${CYAN}Expiration Date${NC} $expiration"
        fi
    fi

    print_field "DNSSEC"

    echo -e "${CYAN}Name Servers${NC}"
    echo "$whois_info" | grep -i "^Name Server:" | sed 's/^[^:]*://; s/^ *//; s/ *$//' | awk '{print tolower($0)}' | sort -u | head -n 4 | sed 's/^/  /'

    echo -e "${CYAN}Domain Status${NC}"
    TAB=$(echo "$whois_info" | grep -iE "^\tDomain Status" | sed 's/^[^:]*://; s/^ *//; s/ *$//' | awk '{print tolower($0)}' | sort -u | sed 's/^/  /')
    NOTAB=$(echo "$whois_info" | grep -iE "^Domain Status:" | sed 's/^[^:]*://; s/^ *//; s/ *$//' | awk '{print tolower($0)}' | sort -u | sed 's/^/  /')

    if [[ -n $TAB && -z $NOTAB ]]; then
        echo "$TAB"
    elif [[ -z $TAB && -n $NOTAB ]]; then
        echo "$NOTAB"
    elif [[ -n $TAB && -n $NOTAB ]]; then
        echo "$NOTAB"
    else
        echo "no domain status found"
    fi

    echo -e "${CYAN}IP Address${NC}"
    ip_address=$(dig +short "$1" | head -n 1)
    ptr_record=$(dig +short -x "$ip_address")
    if [ ! -z "$ip_address" ]; then
        if [ ! -z "$ptr_record" ]; then
            echo -e "  $ip_address \t $ptr_record"
        else
            echo "  $ip_address - No PTR record found"
        fi
    else
        echo "  Unable to resolve IP address"
    fi

    echo -e "${CYAN}MX Records${NC}"
    mx_records=$(dig +short MX "$1" | sort -n)
    if [ ! -z "$mx_records" ]; then
        echo "$mx_records" | while read priority server; do
            echo "  Priority: $priority, Server: $server $(ping -c 1 $server | grep "(*)" | awk '{print $3}')"
        done
    else
        echo "  No MX records found"
    fi

elif [ $# -eq 2 ]; then
    echo "Notes for $1"
    echo "Flags for $2"
else
    echo "Usage: $0 <domain>"
    exit 1
fi