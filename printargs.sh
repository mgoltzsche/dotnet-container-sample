#!/bin/sh

echo Running $0 with arguments:

while [ $# -gt 0 ]; do
	echo "ARG: $1"
	shift
done
