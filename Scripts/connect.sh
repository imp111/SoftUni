#!/bin/bash

USER="username"
HOST=$1
PORT="22"
PASSWORD="password"

if [ -z "$HOST" ]; then
    echo "Invalid hostname"
    exit 1
fi

sshpass -p "$PASSWORD" ssh -o StrictHostKeyChecking=no "$USER@$HOST" -p "$PORT"

