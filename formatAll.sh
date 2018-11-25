#!/usr/bin/env bash

# Very (!) crude script to format all files in Visual Studio for Mac solution
# according to code formatting rules of solution.
# Potential current limitation: Number of files opened at once in Visual Studio for Mac.
# Usage:
# - Set "Format Document" Shortcut to "Command-I" in Visual Studio for Mac
# - Open solution in Visual Studio for Mac
# - Execute this script in base directory of solution
# - Leave mac alone until no more file are opened
# - Save all files

for file in `find . -type f -iname "*.cs"`
do
    open -a "Visual Studio" $file
    sleep 1
    osascript -e 'activate application "Visual Studio"'
    osascript -e 'tell application "System Events" to keystroke "p" using {shift down, command down}'
done

