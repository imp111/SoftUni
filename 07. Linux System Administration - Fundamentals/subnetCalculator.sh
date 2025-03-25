#!/bin/bash

# $1 - IP address, IP address with CIDR notation
# $2 - Subnet mask

if [ $# -eq 0 ]; then
	echo "Incorrect number of command-line arguments"
	exit 0;
elif [ $# -eq 1 ]; then
	IP_ADDR=$1

		
elif [ $# -eq 2 ]; then
	echo "two arguments"
fi






