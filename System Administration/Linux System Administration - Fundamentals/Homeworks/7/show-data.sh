#!/bin/bash

if [ $# -ne 1 ]; then
	echo "Wrong number of arguments";
	exit 1;
fi

echo "File $1 contains:"

ROW_NUM=1
while read row;
do
	echo "Row #$ROW_NUM: $row";
	ROW_NUM=$(($ROW_NUM+1));
done < $1
