#!/bin/bash

if [ $# -ne 2 ]; then
	echo "Incorrect amount of parameters!";
	exit 1;
fi

if [ ! -d $1 ]; then
	echo "Parameter 1 is not a folder or it does nto exist!";
	exit 2;
fi

if [ -f $2 ]; then
	echo "Parameter 2 is an existing file and it should be a non-existing one!";
	exit 3;
fi

tar cvzf $2 $1 1>/tmp/archiver-errors.txt 2>&1
