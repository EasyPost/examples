# Concurrently Buy Insurance

This script allows you to concurrently buy EasyPost insurance. It will work with EasyPost Shipments or standalone Insurance. Use the `sample.csv` file as a template, fill in the details, and run the script.

## Usage

After running the script, a CSV file will be saved with the success status of each insurance purchase attempt and the time it took. If there are errors, those messages will be included.

```shell
EASYPOST_API_KEY=123... CSV=sample.csv go run concurrent_insurance_buy.go
```
