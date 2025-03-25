#!/bin/bash

read -p "First name: " FIRST_NAME
read -p "Second name: " SECOND_NAME
read -p "Place of birth: " BIRTH_PLACE

echo "$FIRST_NAME;$SECOND_NAME;$BIRTH_PLACE" >> /tmp/user-data.dat
