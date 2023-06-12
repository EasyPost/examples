#!/usr/bin/env bash

# Symlink all files in a directory to another directory
# Usage: symlink_directory_files.sh <source_dir> <target_dir>

# Check if the source directory exists
if [ ! -d "$1" ]; then
    echo "Source directory does not exist"
    exit 1
fi

# Check if the target directory exists
if [ ! -d "$2" ]; then
    echo "Target directory does not exist"
    exit 1
fi

# Get the absolute path of the source directory
SOURCE_DIR=$(cd "$1" && pwd)

# Get the absolute path of the target directory
TARGET_DIR=$(cd "$2" && pwd)

# Loop through all files in the source directory
for FILE in "$SOURCE_DIR"/*; do
    # Get the filename of the file
    FILENAME=$(basename "$FILE")

    # Skip the "*" since it's not actually a file
    if [ "$FILENAME" == "*" ]; then
        continue
    fi

    # Create a symlink in the target directory (overwrite if the file already exists, be careful!)
    ln -sf "$FILE" "$TARGET_DIR/$FILENAME"
done

# Repeat for hidden files
for FILE in "$SOURCE_DIR"/.*; do
    # Get the filename of the file
    FILENAME=$(basename "$FILE")

    # Skip the current and parent directory
    if [ "$FILENAME" == "." ] || [ "$FILENAME" == ".." ]; then
        continue
    fi

    # Create a symlink in the target directory (overwrite if the file already exists, be careful!)
    ln -sf "$FILE" "$TARGET_DIR/$FILENAME"
done
