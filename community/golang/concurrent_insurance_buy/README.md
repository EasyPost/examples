# Concurrently Buy Insurance

This script allows you to concurrently buy EasyPost Insurance. It works when insuring EasyPost Shipments or when buying standalone Insurance for a package bought outside of the EasyPost ecosystem. Use the `sample.csv` file as a template, fill in the details (do not delete the header), and run the script.

## Things to Know

- You must follow the `sample.csv` template or the script will not work correctly. Do not delete the header row
- Only run the script once! Running the script multiple times with the same data will create duplicate insurance objects and fees
- The script will spin up 20 concurrent requests at a time
  - Because requests are sent concurrently, they may complete in a different order than they were specified in the original CSV. Sorting the results CSV by Tracking Code and the original `sample.csv` will allow you to match up requests with input data for debugging purchases in the event of errors
- The status of each request will be saved to a CSV once the script is complete. Each line will include error messages if there were any, the time each request took, and the status of the request
- If there are errors reported in the results CSV, correct input data as necessary and run the script again
  - NOTE: Ensure you delete successful rows from the `sample.csv` file before running the script again. Failure to do so will result in duplicate insurance objects and fees (eg: If I had 5 rows, 3 succeeded, 2 failed - I would remove the 3 rows with a success status of true so that my sample CSV contained the 2 rows that initially failed, I'd correct the data as needed, and re-run the script with only those two failed rows)
- It's recommended to run the `sample.csv` file as-is with a test API key to get a feel for how it works prior to loading real data and using a production API key

## Usage

```shell
EASYPOST_API_KEY=123... CSV=path/to/sample.csv go run concurrent_insurance_buy.go
```

## Development

```shell
# To build a standalone binary of this tool (eg: call it bulkins)
go build -o bulkins
```
